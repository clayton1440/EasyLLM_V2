
Imports System.ComponentModel
Imports ZXing

Public Class InterfaceForm


#Region "Horizontal Mouse Wheel"

	MustInherit Class Win32Messages
		Public Const WM_MOUSEHWHEEL As Integer = &H20E 'setting constant for horizontal mouse wheel WndProc message
		Public Const WM_MOUSE_ESC As Integer = -1
	End Class



	Protected Overrides Sub WndProc(ByRef m As Message)
		'override the WndProc. If the horizontal mouse wheel message is sent, intercept it, else return the message to the normal WndProc
		Try
			MyBase.WndProc(m)
			If m.HWnd <> Me.Handle Then
				Return
			End If
			Select Case m.Msg
				Case Win32Messages.WM_MOUSEHWHEEL
					'if message is for horizontal scroll, send the WParam to determine which direction and actually do the scrolling.
					'Set the WndProc result so the nothing else processes the same message
					MouseHorizontalScroll(m.WParam.ToInt64)
					m.Result = CType(1, IntPtr)
					Exit Select
				Case Else
					'Console.WriteLine($"WndProc m.Msg = {m.Msg}")
					Exit Select
			End Select
		Catch ex As Exception
			'MessageBox.Show(ex.Message)
		End Try

	End Sub

	Private Sub MouseHorizontalScroll(WParam)
		Dim DGV1 As DataGridView = GetVisibleDGV()
		If DGV1 Is Nothing OrElse Not DGV1.Visible Then Exit Sub
		Dim scrollColumns As Integer

		If WParam < 1000000000 AndAlso WParam > 0 Then 'wheel tilt right/horz wheel up
			scrollColumns = -1
		Else 'wheel tilt left/horz wheel down
			scrollColumns = 1
			'Else
			'Console.WriteLine(WParam)
			'Exit Sub
		End If

		Dim scrollMultiplier As Integer
		If My.Computer.Keyboard.CtrlKeyDown Then
			scrollMultiplier = 100
		Else
			scrollMultiplier = 75
		End If

		' Determine the new horizontal scroll position
		Dim newScrollPosition As Integer = DGV1.HorizontalScrollingOffset - scrollColumns * scrollMultiplier

		' Determine the maximum scroll position
		Dim maxScrollPosition As Integer = DGV1.Columns.GetColumnsWidth(DataGridViewElementStates.None) - DGV1.ClientSize.Width

		' Ensure the scroll position is within the valid range
		If newScrollPosition < 0 Then
			newScrollPosition = 0
		ElseIf newScrollPosition > maxScrollPosition Then
			newScrollPosition = maxScrollPosition
		End If

		' Set the new horizontal scroll position
		DGV1.HorizontalScrollingOffset = newScrollPosition
	End Sub

	Private Function GetVisibleDGV() As DataGridView
		If DGVAutoRef.Visible Then
			Return DGVAutoRef
		ElseIf DGVCommonTable.Visible Then
			Return DGVCommonTable
		ElseIf DGVHistory.Visible Then
			Return DGVHistory
		ElseIf DGVProgramStock.Visible Then
			Return DGVProgramStock
		ElseIf DGVRefNum.Visible Then
			Return DGVRefNum
		ElseIf DGVUserStock.Visible Then
			Return DGVUserStock
		ElseIf DGVUtilities.Visible Then
			Return DGVUtilities
		ElseIf DGVAssignRefNum.Visible Then
			Return DGVAssignRefNum
		Else
			Return Nothing
		End If
	End Function


#End Region

#Region "Startup.Miscellaneous"

	Public Shared Function GetDisplayScale(Form As Object) As Double
		Dim graphics As Graphics = Form.CreateGraphics()
		Dim DpiX As Single = graphics.DpiX
		Dim ScaleX As Double = DpiX / 96

		Return ScaleX

	End Function
	Private Sub InterfaceForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		Me.KeyPreview = True
		If LLMDB.UserLogin() Then
			Me.Size = New Size(Math.Round(820 * GetDisplayScale(Me)), Math.Round(550 * GetDisplayScale(Me)))
		Else
			MasterTabControl.TabPages.Remove(ManagementPage)
		End If

		Utils_AutoRefTextBox.Font = eFont.LoadEmbeddedFont(My.Resources.CGMono_Regular, 8)

		DGVAutoRef.RowTemplate.Height = Math.Round(DGVAutoRef.RowTemplate.Height * GetDisplayScale(Me))

		Dim users As List(Of String) = LLMDB.GetUsers
		AutoRef_SwitchUserCombo.Items.Clear()
		AutoRef_SwitchUserCombo.Items.AddRange(users.ToArray)

	End Sub
	Private Sub InterfaceForm_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
		If e.KeyCode = Keys.F9 Then
			If MasterTabControl.TabPages.Contains(ManagementPage) Then
				MasterTabControl.TabPages.Remove(ManagementPage)
			Else
				MasterTabControl.TabPages.Add(ManagementPage)
			End If
		End If
	End Sub
	Private Sub Misc_NumericUpDownMouseWheelImprovement(sender As Object, e As HandledMouseEventArgs) Handles EditMaterials_ProgramQtyPerUse.MouseWheel, EditMaterials_ProgramTotalQtyAvail.MouseWheel, EditMaterials_PrintQty.MouseWheel, AddMaterials_UserQtyAvailable.MouseWheel,
		AddMaterials_ProgramQtyAvailable.MouseWheel, AddMaterials_ProgramQtyPerUse.MouseWheel, Utils_PrintQty.MouseWheel
		Try
			Dim nud As NumericUpDown = sender
			e.Handled = True
			If e.Delta > 0 Then
				nud.UpButton()
			Else
				nud.DownButton()
			End If
		Catch ex As Exception

		End Try
	End Sub
#End Region

#Region "Auto Reference"

	Private LoadedAutoRefItems As List(Of LLMDB.Item)
	Private AutoRefUser As String = Environment.UserName

	''' <summary>
	''' Loads DGVAutoRef with the stock information of the selected stock type. This method is called at startup, and when a user clicks a stock type radio button.
	''' </summary>
	''' <remarks>
	''' DGVAutoRef is read-only and is not intended to be edited. It is used to allow users to copy formatted data from the stock table to Velocity. <br/> Button columns are added to allow users to copy data to the clipboard, and will request the quantity used for Program Stock.
	''' </remarks>
	''' <param name="sender"></param>
	''' <param name="e"></param>
	Private Sub AutoRef_LoadGrid() Handles UserStockRadio.Click, ProgramStockRadio.Click, CommonStockRadio.Click, BMS3303Radio.Click, BMS3306Radio.Click, AutoRefPage.Enter ' these handles trigger at startup for some reason, but it works
		Dim Items As New List(Of LLMDB.Item)

		If UserStockRadio.Checked Then
			Items = LLMDB.GetUserStock(AutoRefUser)
		ElseIf ProgramStockRadio.Checked Then
			Items = LLMDB.GetProgramStock()
		ElseIf CommonStockRadio.Checked Then
			Items = LLMDB.GetCommonStock()
		ElseIf BMS3303Radio.Checked Then
			Items = LLMDB.GetBMS3303Stock()
		ElseIf BMS3306Radio.Checked Then
			Items = LLMDB.GetBMS3306Stock()
		End If

		LoadedAutoRefItems = Items

		DGVAutoRef.Rows.Clear()
		For Each item As LLMDB.Item In Items
			DGVAutoRef.Rows.Add(item.ReferenceNumber, item.PartDescription, item.PartNumber, item.LotNumber, If(item.ExpirationDate <> Nothing, item.ExpirationDate.ToShortDateString, Nothing), "Copy", item.IncrementalQuantity)
		Next
	End Sub

	Private Sub AutoRef_CopyData(sender As Object, e As DataGridViewCellEventArgs) Handles DGVAutoRef.CellClick
		If e.RowIndex < 0 Then Exit Sub
		If e.ColumnIndex = 5 Then
			Dim ItemRef As String = DGVAutoRef.Rows(e.RowIndex).Cells(0).Value
			Dim Item As New LLMDB.Item
			For Each i As LLMDB.Item In LoadedAutoRefItems
				If i.ReferenceNumber = CInt(ItemRef) Then
					Item = i
					Exit For
				End If
			Next

			Dim CopyData As String =
$"{Item.PartDescription}
P/N: {Item.PartNumber}
LOT: {Item.LotNumber}{If(Item.ExpirationDate <> Nothing, $"{vbCrLf}EXP: {Item.ExpirationDate.ToString("M/d/yyyy")}", "")}"



			If UserStockRadio.Checked Then
				My.Computer.Clipboard.SetText(CopyData)
				DGVAutoRef.Rows(e.RowIndex).Cells(5).Value = "Copied"
				Application.DoEvents()
				LLMDB.UsedCommonStock(Item.ReferenceNumber)
			ElseIf ProgramStockRadio.Checked Then
				Dim UsedItem As QuantityUsedForm.UsedItem = QuantityUsedForm.GetQuantityUsed(Me)
				If UsedItem Is Nothing Then Exit Sub
				If UsedItem.Quantity > 0 Then
					My.Computer.Clipboard.SetText(CopyData)
					DGVAutoRef.Rows(e.RowIndex).Cells(5).Value = "Copied"
					Application.DoEvents()
					LLMDB.UsedProgramStock(Item.ReferenceNumber, Item.IncrementalQuantity * UsedItem.Quantity, UsedItem.ShopOrder)
				End If
			ElseIf CommonStockRadio.Checked Then
				My.Computer.Clipboard.SetText(CopyData)
				DGVAutoRef.Rows(e.RowIndex).Cells(5).Value = "Copied"
				Application.DoEvents()
				LLMDB.UsedCommonStock(Item.ReferenceNumber)
			ElseIf BMS3303Radio.Checked Then
				My.Computer.Clipboard.SetText(CopyData)
				DGVAutoRef.Rows(e.RowIndex).Cells(5).Value = "Copied"
				Application.DoEvents()
				LLMDB.UsedCommonStock(Item.ReferenceNumber)
			ElseIf BMS3306Radio.Checked Then
				My.Computer.Clipboard.SetText(CopyData)
				DGVAutoRef.Rows(e.RowIndex).Cells(5).Value = "Copied"
				Application.DoEvents()
				LLMDB.UsedCommonStock(Item.ReferenceNumber)
			End If

		End If
	End Sub

	Private Sub AutoRef_SwitchUser() Handles AutoRef_SwitchUserCombo.SelectedIndexChanged
		AutoRefUser = AutoRef_SwitchUserCombo.SelectedItem.ToString
		Me.Text = $"Limited Life Materials - {AutoRefUser}"
		AutoRef_LoadGrid()
	End Sub

#End Region

#Region "Record Inventory"
	''' <summary>
	''' Loads DGVRefNum with the item information of the entered reference number.
	''' </summary>
	''' <remarks>
	''' DGVRefNum is read-only.
	''' </remarks>
	Private Sub RecordInventory_LoadGrid() Handles RefNumInput.TextChanged
		WarningProvider1.Clear()
		CheckInButton.Enabled = True
		WarningTooltip.SetToolTip(CheckInButton, "")
		If RefNumInput.Text.Length = 5 Then
			Dim Item As LLMDB.Item = LLMDB.GetItemByRef(RefNumInput.Text)
			If Item IsNot Nothing Then
				DGVRefNum.Rows.Clear()
				DGVRefNum.Rows.Add(Item.ReferenceNumber, Item.PartDescription, Item.PartNumber, Item.LotNumber, Item.ExpirationDate.ToShortDateString)

				CheckInButton.Visible = Item.IsUserStock
				If Item.IsUserStock Then
					If Item.IsCheckedOut Then ' Update Button text
						CheckInButton.Text = "Check In"
						WarningTooltip.SetToolTip(CheckInButton, "Check this item in only if it is empty")
					Else
						CheckInButton.Text = "Check Out"
					End If
				End If
			Else
				WarningProvider1.SetError(Label1, "Item not found!")
				DGVRefNum.Rows.Clear()
				CheckInButton.Visible = False
				RefNumInput.SelectAll()
			End If
		Else
			DGVRefNum.Rows.Clear()
			CheckInButton.Visible = False
		End If
	End Sub

	Private Sub RecordInventory_CheckOutButton() Handles CheckInButton.Click
		If RefNumInput.Text.Length = 5 Then
			CheckInButton.Enabled = False
			Application.DoEvents()

			Dim Item As LLMDB.Item = LLMDB.GetItemByRef(RefNumInput.Text)
			If Item IsNot Nothing AndAlso Item.IsUserStock Then
				If Item.IsCheckedOut Then
					LLMDB.UserCheckIn(Item.ReferenceNumber) ' Check in
					RecordInventory_LoadGrid()
					RefNumInput.Focus()
					RefNumInput.SelectAll()
				Else
					LLMDB.UserCheckOut(Item.ReferenceNumber) ' Check out
					RecordInventory_LoadGrid()
					RefNumInput.Focus()
					RefNumInput.SelectAll()
				End If
			Else
				DGVRefNum.Rows.Clear()
			End If
		Else
			DGVRefNum.Rows.Clear()
		End If
		CheckInButton.Visible = False
	End Sub
#End Region

#Region "Add Materials"
	Private Sub AddMaterials_Enter() Handles AddMaterialsTab.Enter
		AddMaterials_ExpDate.Value = Date.Today.AddDays(1)
		AddMaterials_ExpDate.MinDate = Date.Today.AddDays(1)
	End Sub
	Private Sub AddMaterials_StockTypeRadio_Click(sender As Object, e As EventArgs) Handles AddMaterials_UserStockTypeRadio.Click, AddMaterials_ProgramStockTypeRadio.Click, AddMaterials_CommonStockTypeRadio.Click
		If AddMaterials_UserStockTypeRadio.Checked Then 'user stock
			AddMaterials_AddButtonGroup.Visible = True

			AddMaterials_ProgramCommonRefNumGroup.Visible = False
			AddMaterials_ProgramQtyAvailGroup.Visible = False
			AddMaterials_UserStockGroup.Visible = True
			AddMaterials_UserQtyAvailable.Value = 0

		ElseIf AddMaterials_ProgramStockTypeRadio.Checked Then ' program stock
			AddMaterials_AddButtonGroup.Visible = True

			AddMaterials_ProgramCommonRefNumGroup.Visible = True
			AddMaterials_ProgramQtyAvailGroup.Visible = True
			AddMaterials_UserStockGroup.Visible = False

			AddMaterials_ProgramCommonRefNumTextBox.Text = LLMDB.CreateReferenceNumber(19999)

		ElseIf AddMaterials_CommonStockTypeRadio.Checked Then ' common stock
			AddMaterials_AddButtonGroup.Visible = True

			AddMaterials_ProgramCommonRefNumGroup.Visible = True
			AddMaterials_ProgramQtyAvailGroup.Visible = False
			AddMaterials_UserStockGroup.Visible = False

			AddMaterials_ProgramCommonRefNumTextBox.Text = LLMDB.CreateReferenceNumber(19999)

		End If
	End Sub

	Private Sub AddMaterials_UserQtyAvailable_ValueChanged(sender As Object, e As EventArgs) Handles AddMaterials_UserQtyAvailable.ValueChanged
		If AddMaterials_UserQtyAvailable.Value > AddMaterials_UserRefNumbers.Items.Count Then
			Do Until AddMaterials_UserQtyAvailable.Value = AddMaterials_UserRefNumbers.Items.Count
				AddMaterials_UserRefNumbers.Items.Add(LLMDB.CreateReferenceNumber(19999, ListBoxItemsToListOfInteger(AddMaterials_UserRefNumbers)))
				Application.DoEvents()
				'Threading.Thread.Sleep(25)
			Loop
		Else
			Do Until AddMaterials_UserQtyAvailable.Value = AddMaterials_UserRefNumbers.Items.Count
				AddMaterials_UserRefNumbers.Items.RemoveAt(AddMaterials_UserRefNumbers.Items.Count - 1)

			Loop
		End If
	End Sub

	Private Function ListBoxItemsToListOfInteger(ListBoxItems As ListBox) As List(Of Integer)
		Dim returnList As New List(Of Integer)
		For Each item As String In ListBoxItems.Items
			returnList.Add(CInt(item))
		Next
		Return returnList
	End Function

	Private Sub AddMaterials_SearchAutoPart() Handles AddMaterials_PartNumber.Leave
		If AddMaterials_PartNumber.Text.Length > 0 Then
			AddMaterials_PartDescription.Text = LLMDB.GetPartDescription(AddMaterials_PartNumber.Text)
		End If
	End Sub

	Private Sub AddMaterials_CheckAutoPart() Handles AddMaterials_PartDescription.Leave
		If AddMaterials_PartNumber.Text.Length = 0 Then Exit Sub
		SavePartDescButton.Visible = AddMaterials_PartDescription.Text <> LLMDB.GetPartDescription(AddMaterials_PartNumber.Text)
	End Sub

	Private Sub AddMaterials_SavePartDesc() Handles SavePartDescButton.Click
		LLMDB.SetPartDescription(AddMaterials_PartNumber.Text, AddMaterials_PartDescription.Text)
		SavePartDescButton.Visible = False
	End Sub

	Private Sub CreateRefNumber_NoExpDate_CheckedChanged() Handles AddMaterials_NoExpDate.Click
		AddMaterials_ExpDate.Enabled = Not AddMaterials_NoExpDate.Checked
	End Sub

	Private Sub AddMaterials_ProgramQtyAvailable_ValueChanged(sender As Object, e As EventArgs) Handles AddMaterials_ProgramQtyAvailable.ValueChanged
		AddMaterials_ProgramQtyPerUse.Maximum = AddMaterials_ProgramQtyAvailable.Value
		AddMaterials_ProgramQtyPerUse.Value = Math.Min(AddMaterials_ProgramQtyPerUse.Value, AddMaterials_ProgramQtyAvailable.Value)
	End Sub

	Private Sub AddMaterials_AddItemsButton_Click(sender As Object, e As EventArgs) Handles AddMaterials_AddItemsButton.Click
		Dim HasErrors As Boolean = False
		If String.IsNullOrWhiteSpace(AddMaterials_PartNumber.Text) Then
			ErrorProvider1.SetError(Label3, "Part Number is required")
			HasErrors = True
		End If
		If String.IsNullOrWhiteSpace(AddMaterials_PartDescription.Text) Then
			ErrorProvider1.SetError(Label8, "Part Description is required")
			HasErrors = True
		End If
		If String.IsNullOrWhiteSpace(AddMaterials_LotNumber.Text) Then
			ErrorProvider1.SetError(Label4, "Lot Number is required")
			HasErrors = True
		End If

		If HasErrors Then Exit Sub

		ErrorProvider1.Clear()

		If AddMaterials_UserStockTypeRadio.Checked Then 'user stock
			If AddMaterials_UserQtyAvailable.Value > 0 Then
				Dim SupressErrors As Boolean = False
				For Each item As String In AddMaterials_UserRefNumbers.Items
					If LLMDB.AddOrReplaceItem(CInt(item), AddMaterials_PartNumber.Text, AddMaterials_PartDescription.Text, AddMaterials_LotNumber.Text, If(AddMaterials_NoExpDate.Checked, Nothing, AddMaterials_ExpDate.Value)) Then
						LLMDB.AssignUserStock(CInt(item))
						If AddMaterials_PrintLabelCB.Checked Then
							LabelPrinter.Print(LLMDB.GetItemByRef(CInt(item)), AddMaterials_CompactLabelCheck.Checked)
						End If
					Else
						If Not SupressErrors Then
							Dim dmsg As New DynamicMessageBox($"Ref Number '{item}' could not be added to the database.
This item will be skipped.", "Item Error", DynamicMessageBox.DARK_DISABLE, DynamicMessageBox.GetCenterPoint(Me))
							dmsg.Checkbox1Text = "Supress remaining errors"
							dmsg.ShowDialog()
							SupressErrors = dmsg.OptionChecked
						End If
					End If
				Next
			End If
			AddMaterials_UserQtyAvailable.Value = 0
			AddMaterials_LotNumber.Clear()
		ElseIf AddMaterials_ProgramStockTypeRadio.Checked Then ' program stock
			If LLMDB.AddOrReplaceItem(CInt(AddMaterials_ProgramCommonRefNumTextBox.Text), AddMaterials_PartNumber.Text, AddMaterials_PartDescription.Text, AddMaterials_LotNumber.Text, If(AddMaterials_NoExpDate.Checked, Nothing, AddMaterials_ExpDate.Value)) Then
				LLMDB.AssignProgramStock(CInt(AddMaterials_ProgramCommonRefNumTextBox.Text), AddMaterials_ProgramQtyPerUse.Value, AddMaterials_ProgramQtyAvailable.Value)
				If AddMaterials_PrintLabelCB.Checked Then
					LabelPrinter.Print(LLMDB.GetItemByRef(CInt(AddMaterials_ProgramCommonRefNumTextBox.Text)), AddMaterials_CompactLabelCheck.Checked)
				End If
			Else
				Dim dmsg As New DynamicMessageBox($"Ref Number '{AddMaterials_ProgramCommonRefNumTextBox.Text}' could not be added to the database.
This item will be skipped.", "Item Error", DynamicMessageBox.DARK_DISABLE, DynamicMessageBox.GetCenterPoint(Me))
				dmsg.ShowDialog()
			End If
			AddMaterials_ProgramStockTypeRadio.PerformClick()
			AddMaterials_LotNumber.Clear()
		ElseIf AddMaterials_CommonStockTypeRadio.Checked Then ' common stock
			If LLMDB.AddOrReplaceItem(CInt(AddMaterials_ProgramCommonRefNumTextBox.Text), AddMaterials_PartNumber.Text, AddMaterials_PartDescription.Text, AddMaterials_LotNumber.Text, If(AddMaterials_NoExpDate.Checked, Nothing, AddMaterials_ExpDate.Value)) Then
				LLMDB.AssignCommonStock(CInt(AddMaterials_ProgramCommonRefNumTextBox.Text))
				If AddMaterials_PrintLabelCB.Checked Then
					LabelPrinter.Print(LLMDB.GetItemByRef(CInt(AddMaterials_ProgramCommonRefNumTextBox.Text)), AddMaterials_CompactLabelCheck.Checked)
				End If
			Else
				Dim dmsg As New DynamicMessageBox($"Ref Number '{AddMaterials_ProgramCommonRefNumTextBox.Text}' could not be added to the database.
This item will be skipped.", "Item Error", DynamicMessageBox.DARK_DISABLE, DynamicMessageBox.GetCenterPoint(Me))
				dmsg.ShowDialog()
			End If
			AddMaterials_CommonStockTypeRadio.PerformClick()
			AddMaterials_LotNumber.Clear()
		End If
	End Sub
#End Region

#Region "Edit Materials"
	Private Sub EditThisItem(ReferenceNumber As Integer)
		ManagementPageTabControl.SelectedTab = EditMaterialsTab
		EditMaterials_Load(ReferenceNumber)
	End Sub
	Private Sub EditMaterials_Enter() Handles EditMaterialsTab.Enter
		EditMaterials_Load()
	End Sub
	Private Sub EditMaterials_Load(Optional SelectRef As Integer = Nothing)
		Dim MatTable As DataTable = LLMDB.GetMaterials
		DGVAssignRefNum.Rows.Clear()
		For i = 0 To MatTable.Rows.Count - 1
			DGVAssignRefNum.Rows.Add(MatTable.Rows(i).Item(0), MatTable.Rows(i).Item(2), MatTable.Rows(i).Item(1), MatTable.Rows(i).Item(3), MatTable.Rows(i).Item(4))
		Next

		EditMaterials_MaterialInfoGroup.Enabled = False
		EditMaterials_ProgramQtyGroup.Visible = False
		EditMaterials_ButtonGroup.Enabled = False

		EditMaterials_PartNumberTB.Clear()
		EditMaterials_PartDescTB.Clear()
		EditMaterials_LotBatchTB.Clear()
		EditMaterials_ExpDatePicker.Value = Now
		EditMaterials_NoExpDateCB.Checked = False

		EditMaterials_ProgramQtyPerUse.Value = 0
		EditMaterials_ProgramTotalQtyAvail.Value = 0

		EditMaterials_PrintQty.Value = 1

		If SelectRef <> Nothing Then
			For Each row As DataGridViewRow In DGVAssignRefNum.Rows
				If row.Cells(0).Value = SelectRef Then
					row.Selected = True
					Exit For
				End If
			Next
		Else
			DGVAssignRefNum.ClearSelection()
		End If
	End Sub

	Private EditMaterials_SelectedItem As LLMDB.Item

	Private Sub EditMaterials_SelectItem() Handles DGVAssignRefNum.SelectionChanged
		If DGVAssignRefNum.SelectedRows.Count = 0 Then Exit Sub
		EditMaterials_SelectedItem = LLMDB.GetItemByRef(DGVAssignRefNum.SelectedRows(0).Cells(0).Value)
		If EditMaterials_SelectedItem IsNot Nothing Then
			EditMaterials_MaterialInfoGroup.Enabled = True
			EditMaterials_ButtonGroup.Enabled = True

			EditMaterials_PartNumberTB.Text = EditMaterials_SelectedItem.PartNumber
			EditMaterials_PartDescTB.Text = EditMaterials_SelectedItem.PartDescription
			EditMaterials_LotBatchTB.Text = EditMaterials_SelectedItem.LotNumber
			If EditMaterials_SelectedItem.ExpirationDate <> Nothing Then
				EditMaterials_ExpDatePicker.Value = EditMaterials_SelectedItem.ExpirationDate
				EditMaterials_ExpDatePicker.Enabled = True
				EditMaterials_NoExpDateCB.Checked = False
			Else
				EditMaterials_ExpDatePicker.Enabled = False
				EditMaterials_NoExpDateCB.Checked = True
			End If


			EditMaterials_ProgramQtyPerUse.Value = EditMaterials_SelectedItem.IncrementalQuantity
			EditMaterials_ProgramTotalQtyAvail.Value = EditMaterials_SelectedItem.QuantityRemaining

			EditMaterials_ProgramQtyGroup.Visible = EditMaterials_SelectedItem.IsProgramStock

		Else
			EditMaterials_MaterialInfoGroup.Enabled = False
			EditMaterials_ProgramQtyGroup.Visible = False
			EditMaterials_ButtonGroup.Enabled = False

			EditMaterials_PartNumberTB.Clear()
			EditMaterials_PartDescTB.Clear()
			EditMaterials_LotBatchTB.Clear()
			EditMaterials_ExpDatePicker.Value = Now
			EditMaterials_NoExpDateCB.Checked = False

			EditMaterials_ProgramQtyPerUse.Value = 0
			EditMaterials_ProgramTotalQtyAvail.Value = 0

			EditMaterials_PrintQty.Value = 1
		End If
	End Sub

	Private Sub EditMaterials_NoExpDate_CheckedChanged() Handles EditMaterials_NoExpDateCB.CheckedChanged
		EditMaterials_ExpDatePicker.Enabled = Not EditMaterials_NoExpDateCB.Checked
	End Sub

	Private Function EditMaterials_GridItemCount(LotNumber As String) As Integer
		Dim ItemCount As Integer = 0
		For i = 0 To DGVAssignRefNum.Rows.Count - 1
			If DGVAssignRefNum.Rows(i).Cells(3).Value.ToString = LotNumber Then ItemCount += 1
		Next
		Return ItemCount
	End Function
	Private Sub EditMaterials_SaveItem() Handles EditMaterials_SaveButton.Click
		If EditMaterials_SelectedItem IsNot Nothing Then
			Dim ItemCount As Integer = EditMaterials_GridItemCount(EditMaterials_SelectedItem.LotNumber)
			If ItemCount > 1 AndAlso 'check if item appears multiple times and any material information was changed
				(EditMaterials_SelectedItem.PartNumber <> EditMaterials_PartNumberTB.Text Or
				EditMaterials_SelectedItem.PartDescription <> EditMaterials_PartDescTB.Text Or
				EditMaterials_SelectedItem.LotNumber <> EditMaterials_LotBatchTB.Text Or
				EditMaterials_SelectedItem.ExpirationDate <> EditMaterials_ExpDatePicker.Value Or
				(EditMaterials_SelectedItem.ExpirationDate <> Nothing And EditMaterials_NoExpDateCB.Checked) Or
				(EditMaterials_SelectedItem.ExpirationDate = Nothing And Not EditMaterials_NoExpDateCB.Checked)) Then

				Dim dmsg As New DynamicMessageBox("Material information has been changed. Save changes for all materials with this Lot Number?", "Material Information Changed", DynamicMessageBox.DARK_DISABLE, DynamicMessageBox.GetCenterPoint(Me))
				dmsg.Button1Text = "Yes"
				dmsg.Button1DialogResult = DialogResult.Yes
				dmsg.Button2Text = "This Item Only"
				dmsg.Button2DialogResult = DialogResult.No
				dmsg.Button3Text = "Cancel"
				dmsg.Button3DialogResult = DialogResult.Cancel
				Dim dr As DialogResult = dmsg.ShowDialog
				If dr = DialogResult.Yes Then 'update all matching materials, then update reference number
					If Not LLMDB.UpdateMaterialInformation(EditMaterials_SelectedItem, EditMaterials_PartNumberTB.Text, EditMaterials_PartDescTB.Text, EditMaterials_LotBatchTB.Text, If(EditMaterials_NoExpDateCB.Checked, Nothing, EditMaterials_ExpDatePicker.Value)) Then
						MessageBox.Show("Save failed")
					End If
				ElseIf dr = DialogResult.No Then 'update reference number only
					If Not LLMDB.AddOrReplaceItem(EditMaterials_SelectedItem.ReferenceNumber, EditMaterials_PartNumberTB.Text, EditMaterials_PartDescTB.Text, EditMaterials_LotBatchTB.Text, If(EditMaterials_NoExpDateCB.Checked, Nothing, EditMaterials_ExpDatePicker.Value)) Then
						MessageBox.Show("Save failed")
					End If
				Else 'cancel
					Exit Sub
				End If
			Else 'item only appears once
				If Not LLMDB.AddOrReplaceItem(EditMaterials_SelectedItem.ReferenceNumber, EditMaterials_PartNumberTB.Text, EditMaterials_PartDescTB.Text, EditMaterials_LotBatchTB.Text, If(EditMaterials_NoExpDateCB.Checked, Nothing, EditMaterials_ExpDatePicker.Value)) Then
					MessageBox.Show("Save failed")
				End If
			End If

			If EditMaterials_SelectedItem.IsProgramStock Then
				LLMDB.AssignProgramStock(EditMaterials_SelectedItem.ReferenceNumber, EditMaterials_ProgramQtyPerUse.Value, EditMaterials_ProgramTotalQtyAvail.Value)
			End If


			EditMaterials_Load(EditMaterials_SelectedItem.ReferenceNumber)
		End If
	End Sub

	Private Sub EditMaterials_PrintLabel() Handles EditMaterials_PrintButton.Click
		LabelPrinter.Print(EditMaterials_SelectedItem, EditMaterials_PrintCompactCB.Checked, , EditMaterials_PrintQty.Value)
	End Sub

	Private Sub EditMaterials_DropItem() Handles EditMaterials_DropItemButton.Click
		Dim dmsg As New DynamicMessageBox("Are you sure you want to delete this item?" & vbCrLf & "This action is permanent.", "Delete Item", DynamicMessageBox.DARK_DISABLE, DynamicMessageBox.GetCenterPoint(Me))
		dmsg.Button1Text = "Yes"
		dmsg.Button2Text = "No"
		dmsg.Button1DialogResult = DialogResult.Yes
		dmsg.Button2DialogResult = DialogResult.No

		If dmsg.ShowDialog = DialogResult.Yes Then
			LLMDB.DropItem(EditMaterials_SelectedItem.ReferenceNumber)
			EditMaterials_Load()
		End If
		dmsg.Dispose()
	End Sub

	Private Sub EditItemInformationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditItemInformationToolStripMenuItem.Click
		If DGVProgramStock.Visible Then
			EditThisItem(DGVProgramStock.SelectedRows(0).Cells(0).Value)
		ElseIf DGVUserStock.Visible Then
			EditThisItem(DGVUserStock.SelectedRows(0).Cells(0).Value)
		ElseIf DGVCommonTable.Visible Then
			EditThisItem(DGVCommonTable.SelectedRows(0).Cells(0).Value)
		End If
	End Sub

#End Region

#Region "History"

	Private Sub History_Load() Handles HistoryPage.Enter
		Dim HistoryTable As DataTable = LLMDB.GetHistory()
		For i = 0 To HistoryTable.Rows.Count - 1
			HistoryTable.Rows(i).Item("UseTimestamp") = CDate(HistoryTable.Rows(i).Item("UseTimestamp")).ToLocalTime()
		Next

		DGVHistory.DataSource = HistoryTable
	End Sub

	Private Sub History_ClearAllButton_Click(sender As Object, e As EventArgs) Handles History_ClearAllButton.Click
		LLMDB.ClearHistory()
		History_Load()
	End Sub

	Private Sub History_ClearSelectedButton_Click(sender As Object, e As EventArgs) Handles History_ClearSelectedButton.Click
		For i = 0 To DGVHistory.SelectedRows.Count - 1
			LLMDB.ClearHistory(DGVHistory.SelectedRows(i).Cells("UID").Value)
		Next
		History_Load()
	End Sub

	Private Sub History_ExportAllButton_Click(sender As Object, e As EventArgs) Handles History_ExportAllButton.Click
		ExcelInterop.OpenHistoryWorkbook(DGVHistory.DataSource)
	End Sub

	Private Sub History_ExportSelectedButton_Click(sender As Object, e As EventArgs) Handles History_ExportSelectedButton.Click
		Dim HistoryData As New DataTable
		HistoryData.Columns.Add("UID", GetType(Integer))
		HistoryData.Columns.Add("UserName", GetType(String))
		HistoryData.Columns.Add("ReferenceNumber", GetType(Integer))
		HistoryData.Columns.Add("PartNumber", GetType(String))
		HistoryData.Columns.Add("LotNumber", GetType(String))
		HistoryData.Columns.Add("ShopOrder", GetType(String))
		HistoryData.Columns.Add("UseTimestamp", GetType(Date))
		HistoryData.Columns.Add("QtyUsed", GetType(Double))
		HistoryData.Columns.Add("IsCheckOut", GetType(Boolean))
		HistoryData.Columns.Add("IsCheckIn", GetType(Boolean))
		HistoryData.Columns.Add("IsFinalCheckIn", GetType(Boolean))

		For i = 0 To DGVHistory.SelectedRows.Count - 1
			HistoryData.Rows.Add(DGVHistory.SelectedRows(i).Cells("UID").Value,
								 DGVHistory.SelectedRows(i).Cells("UserName").Value,
								 DGVHistory.SelectedRows(i).Cells("ReferenceNumber").Value,
								 DGVHistory.SelectedRows(i).Cells("PartNumber").Value,
								 DGVHistory.SelectedRows(i).Cells("LotNumber").Value,
								 DGVHistory.SelectedRows(i).Cells("ShopOrder").Value,
								 DGVHistory.SelectedRows(i).Cells("UseTimestamp").Value,
								 DGVHistory.SelectedRows(i).Cells("QtyUsed").Value,
								 DGVHistory.SelectedRows(i).Cells("IsCheckOut").Value,
								 DGVHistory.SelectedRows(i).Cells("IsCheckIn").Value,
								 DGVHistory.SelectedRows(i).Cells("IsFinalCheckIn").Value)
		Next

		ExcelInterop.OpenHistoryWorkbook(HistoryData)
	End Sub

#End Region

#Region "View Program Inventory"

	Private Sub ProgramStock_LoadGrid() Handles ProgramStockPage.Enter
		DGVProgramStock.DataSource = LLMDB.GetProgramStock_All()
	End Sub

#End Region

#Region "View User Inventory"

	Private Sub UserStock_LoadGrid() Handles UserStockPage.Enter
		Dim UserStockTable As DataTable = LLMDB.GetUserStock_All
		For i = 0 To UserStockTable.Rows.Count - 1
			If IsDBNull(UserStockTable.Rows(i).Item("CheckedOutTimestamp")) Then Continue For
			UserStockTable.Rows(i).Item("CheckedOutTimestamp") = CDate(UserStockTable.Rows(i).Item("CheckedOutTimestamp")).ToLocalTime()
		Next

		DGVUserStock.DataSource = UserStockTable
	End Sub

#End Region

#Region "View Common Inventory"

	Private Sub CommonStock_LoadGrid() Handles CommonStockPage.Enter
		DGVCommonTable.DataSource = LLMDB.GetCommonStock_All
	End Sub

#End Region

#Region "Utilities"

	Private Sub Utils_Enter() Handles InvUtilsPage.Enter
		Dim users As List(Of String) = LLMDB.GetUsers
		Utils_CheckInUserCB.Items.Clear()
		Utils_CheckInUserCB.Items.AddRange(users.ToArray)

		Utils_CheckOutUserCB.Items.Clear()
		Utils_CheckOutUserCB.Items.AddRange(users.ToArray)

		Utils_RefNumTextbox.Focus()
		Utils_RefNumTextbox.SelectAll()
	End Sub

	Dim Utils_SelectedItem As LLMDB.Item
	Private Sub Utils_LoadGrid() Handles Utils_RefNumTextbox.TextChanged
		WarningProvider1.Clear()
		If Utils_RefNumTextbox.Text.Length = 5 Then
			Utils_SelectedItem = LLMDB.GetItemByRef(Utils_RefNumTextbox.Text)
			If Utils_SelectedItem IsNot Nothing Then
				DGVUtilities.DataSource = Utils_SelectedItem.ToTable

				ManualTransferGroup.Enabled = Utils_SelectedItem.IsUserStock
				ManualCheckInGroup.Enabled = Utils_SelectedItem.IsUserStock
				Utils_PrintGroup.Enabled = True
				Utils_AutoRefTextBox.Text = $"{Utils_SelectedItem.PartDescription}{vbCrLf}P/N: {Utils_SelectedItem.PartNumber}{vbCrLf}LOT: {Utils_SelectedItem.LotNumber}{If(Utils_SelectedItem.ExpirationDate <> Nothing, $"{vbCrLf}EXP: {Utils_SelectedItem.ExpirationDate.ToString("M/d/yyyy")}", "")}"
				AutoRefGroup.Enabled = True
				Utils_FinalCheckIn.Checked = True

				Utils_ClearItemHistoryButton.Visible = False
			ElseIf LLMDB.ItemHasHistory(Utils_RefNumTextbox.Text) Then
				WarningProvider1.SetError(Label15, "Item only present in History.")
				Utils_ClearItemHistoryButton.Visible = True
			Else
				WarningProvider1.SetError(Label15, "Item not found!")
				DGVUtilities.DataSource = Nothing
				Utils_RefNumTextbox.SelectAll()

				ManualTransferGroup.Enabled = False
				ManualCheckInGroup.Enabled = False
				Utils_PrintGroup.Enabled = False
				Utils_AutoRefTextBox.Text = $""
				AutoRefGroup.Enabled = False

				Utils_ClearItemHistoryButton.Visible = False
			End If
		Else
			DGVUtilities.DataSource = Nothing

			ManualTransferGroup.Enabled = False
			ManualCheckInGroup.Enabled = False
			Utils_PrintGroup.Enabled = False
			Utils_AutoRefTextBox.Text = $""
			AutoRefGroup.Enabled = False

			Utils_ClearItemHistoryButton.Visible = False
		End If
	End Sub
	Private Sub Utils_CheckOutButton_Click() Handles Utils_CheckOutButton.Click
		If Utils_SelectedItem IsNot Nothing AndAlso Utils_SelectedItem.IsUserStock AndAlso Utils_CheckOutUserCB.SelectedIndex > -1 Then
			LLMDB.UserCheckOut(Utils_SelectedItem.ReferenceNumber, Utils_CheckOutUserCB.Text)
			Utils_LoadGrid()
		End If
	End Sub

	Private Sub Utils_CheckInButton_Click() Handles Utils_CheckInButton.Click
		If Utils_SelectedItem IsNot Nothing AndAlso Utils_SelectedItem.IsUserStock AndAlso Utils_CheckInUserCB.SelectedIndex > -1 Then
			If Utils_FinalCheckIn.Checked Then
				LLMDB.UserCheckIn(Utils_SelectedItem.ReferenceNumber, Utils_CheckInUserCB.Text)
			Else
				LLMDB.UserCheckIn(Utils_SelectedItem.ReferenceNumber,, False)
			End If
			Utils_LoadGrid()
		End If
	End Sub

	Private Sub Utils_PrintButton_Click() Handles Utils_PrintButton.Click
		LabelPrinter.Print(Utils_SelectedItem, Utils_PrintCompact.Checked,, Utils_PrintQty.Value)
	End Sub

	Private Sub Utils_ClearItemHistoryButton_Click() Handles Utils_ClearItemHistoryButton.Click
		LLMDB.ClearItemHistory(Utils_RefNumTextbox.Text)
		Utils_RefNumTextbox.Clear()
		Utils_RefNumTextbox.Focus()
	End Sub
#End Region


#Region "Auto Description"

	Dim UnsavedPartDesc As Boolean = False

	Private Sub AutoDesc_Load() Handles AutoDescTab.Enter
		DGVAutoPart.DataSource = LLMDB.GetPartDescriptions
	End Sub

	Private Sub AutoDesc_InfoChanged() Handles DGVAutoPart.CellValueChanged
		UnsavedPartDesc = True
	End Sub

	Private Sub AutoDesc_BeforeLeave(sender As Object, e As EventArgs) Handles AutoDescTab.Leave
		If UnsavedPartDesc Then
			Dim dmsg As New DynamicMessageBox("Save changes to Part Descriptions?", "Save Changes", DynamicMessageBox.DARK_DISABLE, DynamicMessageBox.GetCenterPoint(Me))
			dmsg.Button1Text = "Yes"
			dmsg.Button1DialogResult = DialogResult.Yes
			dmsg.Button2Text = "No"
			dmsg.Button2DialogResult = DialogResult.No
			Dim dr As DialogResult = dmsg.ShowDialog
			If dr = DialogResult.Yes Then
				LLMDB.SetPartDescriptions(DGVAutoPart.DataSource)
				UnsavedPartDesc = False
			End If
		End If
	End Sub

	Private Sub AutoDesc_Save() Handles AutoPart_SaveButton.Click
		LLMDB.SetPartDescriptions(DGVAutoPart.DataSource)
		UnsavedPartDesc = False
	End Sub


#End Region

End Class

Public Class LabelPrinter
	Public Shared Sub Print(Item As LLMDB.Item, Optional Compact As Boolean = False, Optional FontSize As Integer = 9, Optional Quantity As Integer = 1) '
		If Item Is Nothing Then Exit Sub

		Dim pd As New Printing.PrintDocument()
		pd.PrinterSettings.PrinterName = UserConfig.Printer
		If String.IsNullOrWhiteSpace(pd.PrinterSettings.PrinterName) Then Exit Sub
		pd.DefaultPageSettings.Margins = New Printing.Margins(0, 0, 0, 0)
		pd.PrinterSettings.Copies = Quantity

		Dim LbCol1 As String = ""
		Dim LbCol2 As String = ""
		If Compact Then
			LbCol1 = $"REF: {Item.ReferenceNumber}{vbCrLf}LOT: {Item.LotNumber}"
			If Item.ExpirationDate = Nothing Then
				LbCol2 = $"P/N: {Item.PartNumber}"
			Else
				LbCol2 = $"P/N: {Item.PartNumber}{vbCrLf}EXP: {Item.ExpirationDate.ToString("MM/dd/yyyy")}"
			End If
		Else
			If Item.ExpirationDate = Nothing Then
				LbCol1 = $"REF: {Item.ReferenceNumber}{vbCrLf}P/N: {Item.PartNumber}{vbCrLf}LOT: {Item.LotNumber}"
			Else
				LbCol1 = $"REF: {Item.ReferenceNumber}{vbCrLf}P/N: {Item.PartNumber}{vbCrLf}LOT: {Item.LotNumber}{vbCrLf}EXP: {Item.ExpirationDate.ToString("MM/dd/yyyy")}"
			End If
		End If

		Dim embFont As Font = eFont.LoadEmbeddedFont(My.Resources.CGMono_Regular, FontSize)
		'
		AddHandler pd.PrintPage, Sub(sender As Object, e As Printing.PrintPageEventArgs)
									 e.Graphics.DrawString(LbCol1, embFont, Brushes.Black, 0, 0)
									 e.Graphics.DrawString(LbCol2, embFont, Brushes.Black, 150, 0)
									 e.Graphics.DrawImage(GenerateBarcode(Item.ReferenceNumber.ToString), New Point(If(String.IsNullOrWhiteSpace(LbCol2), 140, 290), 0))
								 End Sub

		Dim PrintThread As New Threading.Thread(AddressOf pd.Print) With {.IsBackground = True}
		PrintThread.Start()

	End Sub

	Private Shared Function GenerateBarcode(InputString As String) As Bitmap
		Try
			Dim BarcodeWriter As BarcodeWriter = New ZXing.BarcodeWriter With {
				.Format = BarcodeFormat.AZTEC}

			Dim Options As New ZXing.Common.EncodingOptions With {
				.Height = 36,
				.Width = 36,
				.NoPadding = True}

			BarcodeWriter.Options = Options

			Dim Result As Bitmap = BarcodeWriter.Write(InputString.Replace(vbCrLf, vbLf))
			Return Result
		Catch ex As Exception
			Return New Bitmap(1, 1)
		End Try
	End Function

	Public Shared Function GetInstalledPrinters() As List(Of String)
		Dim printers As New List(Of String)
		For Each printer As String In Printing.PrinterSettings.InstalledPrinters
			printers.Add(printer)
		Next
		Return printers
	End Function

End Class