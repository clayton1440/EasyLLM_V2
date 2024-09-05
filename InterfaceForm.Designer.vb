<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InterfaceForm
	Inherits System.Windows.Forms.Form

	'Form overrides dispose to clean up the component list.
	<System.Diagnostics.DebuggerNonUserCode()> _
	Protected Overrides Sub Dispose(ByVal disposing As Boolean)
		Try
			If disposing AndAlso components IsNot Nothing Then
				components.Dispose()
			End If
		Finally
			MyBase.Dispose(disposing)
		End Try
	End Sub

	'Required by the Windows Form Designer
	Private components As System.ComponentModel.IContainer

	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.  
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> _
	Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(InterfaceForm))
        Me.Utils_CheckInButton = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Utils_ShowSQLFormButton = New System.Windows.Forms.Button()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Utils_PrintGroup = New System.Windows.Forms.GroupBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Utils_PrintQty = New System.Windows.Forms.NumericUpDown()
        Me.Utils_PrintCompact = New System.Windows.Forms.CheckBox()
        Me.Utils_PrintButton = New System.Windows.Forms.Button()
        Me.AutoRefGroup = New System.Windows.Forms.GroupBox()
        Me.Utils_AutoRefTextBox = New System.Windows.Forms.TextBox()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Utils_RefNumTextbox = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Utils_ClearItemHistoryButton = New System.Windows.Forms.Button()
        Me.Utils_CheckInUserCB = New System.Windows.Forms.ComboBox()
        Me.DGVHistory = New System.Windows.Forms.DataGridView()
        Me.History_GridContextMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ExportToExcelToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.History_ExportAllButton = New System.Windows.Forms.ToolStripMenuItem()
        Me.History_ExportSelectedButton = New System.Windows.Forms.ToolStripMenuItem()
        Me.UserStockPage = New System.Windows.Forms.TabPage()
        Me.DGVUserStock = New System.Windows.Forms.DataGridView()
        Me.AnyStock_GridContextMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.EditItemInformationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.ManualTransferGroup = New System.Windows.Forms.GroupBox()
        Me.Utils_CheckOutButton = New System.Windows.Forms.Button()
        Me.Utils_CheckOutUserCB = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.ManualCheckInGroup = New System.Windows.Forms.GroupBox()
        Me.Utils_FinalCheckIn = New System.Windows.Forms.CheckBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.ProgramStockPage = New System.Windows.Forms.TabPage()
        Me.DGVProgramStock = New System.Windows.Forms.DataGridView()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.AutoRef_SwitchUserCombo = New System.Windows.Forms.ToolStripComboBox()
        Me.SwitchUserToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AutoRefContextMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.RecordPage = New System.Windows.Forms.TabPage()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.CheckInButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.RefNumInput = New System.Windows.Forms.TextBox()
        Me.DGVRefNum = New System.Windows.Forms.DataGridView()
        Me.ReferenceNumberRI = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PartDescriptionRI = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PartNumberRI = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LotNumberRI = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ExpirationDateRI = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DGVUtilities = New System.Windows.Forms.DataGridView()
        Me.ManagementPage = New System.Windows.Forms.TabPage()
        Me.ManagementPageTabControl = New System.Windows.Forms.TabControl()
        Me.InvUtilsPage = New System.Windows.Forms.TabPage()
        Me.AddMaterialsTab = New System.Windows.Forms.TabPage()
        Me.FlowLayoutPanel3 = New System.Windows.Forms.FlowLayoutPanel()
        Me.AddMaterials_MaterialInfoGroup = New System.Windows.Forms.GroupBox()
        Me.AddMaterials_ExpDate = New System.Windows.Forms.DateTimePicker()
        Me.AddMaterials_LotNumber = New System.Windows.Forms.TextBox()
        Me.AddMaterials_PartDescription = New System.Windows.Forms.TextBox()
        Me.AddMaterials_PartNumber = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.SavePartDescButton = New System.Windows.Forms.Button()
        Me.AddMaterials_NoExpDate = New System.Windows.Forms.CheckBox()
        Me.AddMaterials_StockTypeGroup = New System.Windows.Forms.GroupBox()
        Me.AddMaterials_CommonStockTypeRadio = New System.Windows.Forms.RadioButton()
        Me.AddMaterials_ProgramStockTypeRadio = New System.Windows.Forms.RadioButton()
        Me.AddMaterials_UserStockTypeRadio = New System.Windows.Forms.RadioButton()
        Me.AddMaterials_ProgramCommonRefNumGroup = New System.Windows.Forms.GroupBox()
        Me.AddMaterials_ProgramCommonRefNumTextBox = New System.Windows.Forms.TextBox()
        Me.AddMaterials_ProgramQtyAvailGroup = New System.Windows.Forms.GroupBox()
        Me.AddMaterials_ProgramQtyPerUse = New System.Windows.Forms.NumericUpDown()
        Me.AddMaterials_ProgramQtyAvailable = New System.Windows.Forms.NumericUpDown()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.AddMaterials_UserStockGroup = New System.Windows.Forms.GroupBox()
        Me.AddMaterials_UserRefNumbers = New System.Windows.Forms.ListBox()
        Me.AddMaterials_UserQtyAvailable = New System.Windows.Forms.NumericUpDown()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.AddMaterials_AddButtonGroup = New System.Windows.Forms.GroupBox()
        Me.AddMaterials_AddItemsButton = New System.Windows.Forms.Button()
        Me.AddMaterials_CompactLabelCheck = New System.Windows.Forms.CheckBox()
        Me.AddMaterials_PrintLabelCB = New System.Windows.Forms.CheckBox()
        Me.EditMaterialsTab = New System.Windows.Forms.TabPage()
        Me.TableLayoutPanel5 = New System.Windows.Forms.TableLayoutPanel()
        Me.FlowLayoutPanel2 = New System.Windows.Forms.FlowLayoutPanel()
        Me.EditMaterials_MaterialInfoGroup = New System.Windows.Forms.GroupBox()
        Me.EditMaterials_ExpDatePicker = New System.Windows.Forms.DateTimePicker()
        Me.EditMaterials_LotBatchTB = New System.Windows.Forms.TextBox()
        Me.EditMaterials_PartDescTB = New System.Windows.Forms.TextBox()
        Me.EditMaterials_PartNumberTB = New System.Windows.Forms.TextBox()
        Me.EditMaterials_NoExpDateCB = New System.Windows.Forms.CheckBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.EditMaterials_ProgramQtyGroup = New System.Windows.Forms.GroupBox()
        Me.EditMaterials_ProgramQtyPerUse = New System.Windows.Forms.NumericUpDown()
        Me.EditMaterials_ProgramTotalQtyAvail = New System.Windows.Forms.NumericUpDown()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.EditMaterials_ButtonGroup = New System.Windows.Forms.GroupBox()
        Me.EditMaterials_PrintCompactCB = New System.Windows.Forms.CheckBox()
        Me.EditMaterials_PrintQty = New System.Windows.Forms.NumericUpDown()
        Me.EditMaterials_PrintButton = New System.Windows.Forms.Button()
        Me.EditMaterials_DropItemButton = New System.Windows.Forms.Button()
        Me.EditMaterials_SaveButton = New System.Windows.Forms.Button()
        Me.DGVAssignRefNum = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CommonStockPage = New System.Windows.Forms.TabPage()
        Me.DGVCommonTable = New System.Windows.Forms.DataGridView()
        Me.HistoryPage = New System.Windows.Forms.TabPage()
        Me.AutoDescTab = New System.Windows.Forms.TabPage()
        Me.TableLayoutPanel6 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.AutoPart_SaveButton = New System.Windows.Forms.Button()
        Me.DGVAutoPart = New System.Windows.Forms.DataGridView()
        Me.InfoTooltip = New System.Windows.Forms.ToolTip(Me.components)
        Me.MasterTabControl = New System.Windows.Forms.TabControl()
        Me.AutoRefPage = New System.Windows.Forms.TabPage()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.BMS3306Radio = New System.Windows.Forms.RadioButton()
        Me.DGVAutoRef = New System.Windows.Forms.DataGridView()
        Me.ReferenceNumber = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PartDescription = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PartNumber = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LotNumber = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ExpirationDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CopyData = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.QtyPerUse = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.BMS3303Radio = New System.Windows.Forms.RadioButton()
        Me.CommonStockRadio = New System.Windows.Forms.RadioButton()
        Me.UserStockRadio = New System.Windows.Forms.RadioButton()
        Me.ProgramStockRadio = New System.Windows.Forms.RadioButton()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.WarningProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.WarningTooltip = New System.Windows.Forms.ToolTip(Me.components)
        Me.ClearHistoryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.History_ClearAllButton = New System.Windows.Forms.ToolStripMenuItem()
        Me.History_ClearSelectedButton = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox1.SuspendLayout()
        Me.Utils_PrintGroup.SuspendLayout()
        CType(Me.Utils_PrintQty, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.AutoRefGroup.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.DGVHistory, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.History_GridContextMenu.SuspendLayout()
        Me.UserStockPage.SuspendLayout()
        CType(Me.DGVUserStock, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.AnyStock_GridContextMenu.SuspendLayout()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.ManualTransferGroup.SuspendLayout()
        Me.ManualCheckInGroup.SuspendLayout()
        Me.ProgramStockPage.SuspendLayout()
        CType(Me.DGVProgramStock, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.AutoRefContextMenu.SuspendLayout()
        Me.RecordPage.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.DGVRefNum, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGVUtilities, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ManagementPage.SuspendLayout()
        Me.ManagementPageTabControl.SuspendLayout()
        Me.InvUtilsPage.SuspendLayout()
        Me.AddMaterialsTab.SuspendLayout()
        Me.FlowLayoutPanel3.SuspendLayout()
        Me.AddMaterials_MaterialInfoGroup.SuspendLayout()
        Me.AddMaterials_StockTypeGroup.SuspendLayout()
        Me.AddMaterials_ProgramCommonRefNumGroup.SuspendLayout()
        Me.AddMaterials_ProgramQtyAvailGroup.SuspendLayout()
        CType(Me.AddMaterials_ProgramQtyPerUse, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AddMaterials_ProgramQtyAvailable, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.AddMaterials_UserStockGroup.SuspendLayout()
        CType(Me.AddMaterials_UserQtyAvailable, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.AddMaterials_AddButtonGroup.SuspendLayout()
        Me.EditMaterialsTab.SuspendLayout()
        Me.TableLayoutPanel5.SuspendLayout()
        Me.FlowLayoutPanel2.SuspendLayout()
        Me.EditMaterials_MaterialInfoGroup.SuspendLayout()
        Me.EditMaterials_ProgramQtyGroup.SuspendLayout()
        CType(Me.EditMaterials_ProgramQtyPerUse, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EditMaterials_ProgramTotalQtyAvail, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EditMaterials_ButtonGroup.SuspendLayout()
        CType(Me.EditMaterials_PrintQty, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGVAssignRefNum, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CommonStockPage.SuspendLayout()
        CType(Me.DGVCommonTable, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.HistoryPage.SuspendLayout()
        Me.AutoDescTab.SuspendLayout()
        Me.TableLayoutPanel6.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.DGVAutoPart, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MasterTabControl.SuspendLayout()
        Me.AutoRefPage.SuspendLayout()
        Me.TableLayoutPanel4.SuspendLayout()
        CType(Me.DGVAutoRef, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WarningProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Utils_CheckInButton
        '
        Me.Utils_CheckInButton.Location = New System.Drawing.Point(120, 37)
        Me.Utils_CheckInButton.Margin = New System.Windows.Forms.Padding(1)
        Me.Utils_CheckInButton.Name = "Utils_CheckInButton"
        Me.Utils_CheckInButton.Size = New System.Drawing.Size(85, 27)
        Me.Utils_CheckInButton.TabIndex = 14
        Me.Utils_CheckInButton.Text = "Check In"
        Me.Utils_CheckInButton.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Utils_ShowSQLFormButton)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Location = New System.Drawing.Point(427, 1)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(1)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(1)
        Me.GroupBox1.Size = New System.Drawing.Size(211, 74)
        Me.GroupBox1.TabIndex = 50
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Manual SQL Command"
        Me.GroupBox1.Visible = False
        '
        'Utils_ShowSQLFormButton
        '
        Me.Utils_ShowSQLFormButton.Location = New System.Drawing.Point(121, 25)
        Me.Utils_ShowSQLFormButton.Margin = New System.Windows.Forms.Padding(1)
        Me.Utils_ShowSQLFormButton.Name = "Utils_ShowSQLFormButton"
        Me.Utils_ShowSQLFormButton.Size = New System.Drawing.Size(85, 27)
        Me.Utils_ShowSQLFormButton.TabIndex = 49
        Me.Utils_ShowSQLFormButton.Text = "Show"
        Me.WarningTooltip.SetToolTip(Me.Utils_ShowSQLFormButton, "This function is for advanced users only. Executing SQL commands directly" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "can ca" &
        "use irreversible damage to the database if done improperly." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "See documentation f" &
        "or schema reference." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10))
        Me.Utils_ShowSQLFormButton.UseVisualStyleBackColor = True
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(10, 26)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(112, 26)
        Me.Label16.TabIndex = 13
        Me.Label16.Text = "Direct SQL Execution " & Global.Microsoft.VisualBasic.ChrW(10) & "(Non-Query Only)"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.WarningTooltip.SetToolTip(Me.Label16, "This function is for advanced users only. Executing SQL commands directly" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "can ca" &
        "use irreversible damage to the database if done improperly." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "See documentation f" &
        "or schema reference.")
        '
        'Utils_PrintGroup
        '
        Me.Utils_PrintGroup.Controls.Add(Me.Label14)
        Me.Utils_PrintGroup.Controls.Add(Me.Utils_PrintQty)
        Me.Utils_PrintGroup.Controls.Add(Me.Utils_PrintCompact)
        Me.Utils_PrintGroup.Controls.Add(Me.Utils_PrintButton)
        Me.Utils_PrintGroup.Enabled = False
        Me.Utils_PrintGroup.Location = New System.Drawing.Point(1, 77)
        Me.Utils_PrintGroup.Margin = New System.Windows.Forms.Padding(1)
        Me.Utils_PrintGroup.Name = "Utils_PrintGroup"
        Me.Utils_PrintGroup.Padding = New System.Windows.Forms.Padding(1)
        Me.Utils_PrintGroup.Size = New System.Drawing.Size(211, 74)
        Me.Utils_PrintGroup.TabIndex = 50
        Me.Utils_PrintGroup.TabStop = False
        Me.Utils_PrintGroup.Text = "Print Labels"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(24, 23)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(26, 13)
        Me.Label14.TabIndex = 52
        Me.Label14.Text = "Qty:"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Utils_PrintQty
        '
        Me.Utils_PrintQty.Location = New System.Drawing.Point(27, 37)
        Me.Utils_PrintQty.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.Utils_PrintQty.Name = "Utils_PrintQty"
        Me.Utils_PrintQty.Size = New System.Drawing.Size(51, 20)
        Me.Utils_PrintQty.TabIndex = 51
        Me.Utils_PrintQty.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Utils_PrintCompact
        '
        Me.Utils_PrintCompact.AutoSize = True
        Me.Utils_PrintCompact.Location = New System.Drawing.Point(122, 21)
        Me.Utils_PrintCompact.Name = "Utils_PrintCompact"
        Me.Utils_PrintCompact.Size = New System.Drawing.Size(68, 17)
        Me.Utils_PrintCompact.TabIndex = 50
        Me.Utils_PrintCompact.Text = "Compact"
        Me.Utils_PrintCompact.UseVisualStyleBackColor = True
        '
        'Utils_PrintButton
        '
        Me.Utils_PrintButton.Location = New System.Drawing.Point(121, 37)
        Me.Utils_PrintButton.Margin = New System.Windows.Forms.Padding(1)
        Me.Utils_PrintButton.Name = "Utils_PrintButton"
        Me.Utils_PrintButton.Size = New System.Drawing.Size(85, 27)
        Me.Utils_PrintButton.TabIndex = 49
        Me.Utils_PrintButton.Text = "Print"
        Me.Utils_PrintButton.UseVisualStyleBackColor = True
        '
        'AutoRefGroup
        '
        Me.AutoRefGroup.Controls.Add(Me.Utils_AutoRefTextBox)
        Me.AutoRefGroup.Enabled = False
        Me.AutoRefGroup.Location = New System.Drawing.Point(214, 77)
        Me.AutoRefGroup.Margin = New System.Windows.Forms.Padding(1)
        Me.AutoRefGroup.Name = "AutoRefGroup"
        Me.AutoRefGroup.Padding = New System.Windows.Forms.Padding(1, 0, 1, 1)
        Me.AutoRefGroup.Size = New System.Drawing.Size(322, 74)
        Me.AutoRefGroup.TabIndex = 51
        Me.AutoRefGroup.TabStop = False
        Me.AutoRefGroup.Text = "AutoRef Text"
        '
        'Utils_AutoRefTextBox
        '
        Me.Utils_AutoRefTextBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Utils_AutoRefTextBox.Location = New System.Drawing.Point(1, 13)
        Me.Utils_AutoRefTextBox.Margin = New System.Windows.Forms.Padding(3, 0, 3, 3)
        Me.Utils_AutoRefTextBox.Multiline = True
        Me.Utils_AutoRefTextBox.Name = "Utils_AutoRefTextBox"
        Me.Utils_AutoRefTextBox.ReadOnly = True
        Me.Utils_AutoRefTextBox.Size = New System.Drawing.Size(320, 60)
        Me.Utils_AutoRefTextBox.TabIndex = 0
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 3
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.Panel2, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Utils_ClearItemHistoryButton, 2, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(1, 68)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(679, 55)
        Me.TableLayoutPanel2.TabIndex = 52
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Utils_RefNumTextbox)
        Me.Panel2.Controls.Add(Me.Label15)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(282, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(114, 49)
        Me.Panel2.TabIndex = 0
        '
        'Utils_RefNumTextbox
        '
        Me.Utils_RefNumTextbox.Location = New System.Drawing.Point(4, 25)
        Me.Utils_RefNumTextbox.Name = "Utils_RefNumTextbox"
        Me.Utils_RefNumTextbox.Size = New System.Drawing.Size(102, 20)
        Me.Utils_RefNumTextbox.TabIndex = 10
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(1, 9)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(100, 13)
        Me.Label15.TabIndex = 11
        Me.Label15.Text = "Reference Number:"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Utils_ClearItemHistoryButton
        '
        Me.Utils_ClearItemHistoryButton.Location = New System.Drawing.Point(415, 16)
        Me.Utils_ClearItemHistoryButton.Margin = New System.Windows.Forms.Padding(16, 16, 3, 3)
        Me.Utils_ClearItemHistoryButton.Name = "Utils_ClearItemHistoryButton"
        Me.Utils_ClearItemHistoryButton.Size = New System.Drawing.Size(124, 23)
        Me.Utils_ClearItemHistoryButton.TabIndex = 1
        Me.Utils_ClearItemHistoryButton.Text = "Clear Item History"
        Me.Utils_ClearItemHistoryButton.UseVisualStyleBackColor = True
        Me.Utils_ClearItemHistoryButton.Visible = False
        '
        'Utils_CheckInUserCB
        '
        Me.Utils_CheckInUserCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Utils_CheckInUserCB.FormattingEnabled = True
        Me.Utils_CheckInUserCB.Items.AddRange(New Object() {"BSTOCK"})
        Me.Utils_CheckInUserCB.Location = New System.Drawing.Point(13, 38)
        Me.Utils_CheckInUserCB.Margin = New System.Windows.Forms.Padding(1)
        Me.Utils_CheckInUserCB.Name = "Utils_CheckInUserCB"
        Me.Utils_CheckInUserCB.Size = New System.Drawing.Size(101, 21)
        Me.Utils_CheckInUserCB.TabIndex = 0
        '
        'DGVHistory
        '
        Me.DGVHistory.AllowUserToAddRows = False
        Me.DGVHistory.AllowUserToDeleteRows = False
        Me.DGVHistory.AllowUserToOrderColumns = True
        Me.DGVHistory.AllowUserToResizeColumns = False
        Me.DGVHistory.AllowUserToResizeRows = False
        Me.DGVHistory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DGVHistory.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText
        Me.DGVHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVHistory.ContextMenuStrip = Me.History_GridContextMenu
        Me.DGVHistory.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGVHistory.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DGVHistory.Location = New System.Drawing.Point(1, 1)
        Me.DGVHistory.Name = "DGVHistory"
        Me.DGVHistory.ReadOnly = True
        Me.DGVHistory.RowHeadersVisible = False
        Me.DGVHistory.RowHeadersWidth = 102
        Me.DGVHistory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGVHistory.ShowCellErrors = False
        Me.DGVHistory.ShowCellToolTips = False
        Me.DGVHistory.ShowEditingIcon = False
        Me.DGVHistory.ShowRowErrors = False
        Me.DGVHistory.Size = New System.Drawing.Size(679, 325)
        Me.DGVHistory.TabIndex = 11
        '
        'History_GridContextMenu
        '
        Me.History_GridContextMenu.ImageScalingSize = New System.Drawing.Size(40, 40)
        Me.History_GridContextMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExportToExcelToolStripMenuItem, Me.ClearHistoryToolStripMenuItem})
        Me.History_GridContextMenu.Name = "ContextMenuStrip2"
        Me.History_GridContextMenu.Size = New System.Drawing.Size(181, 70)
        '
        'ExportToExcelToolStripMenuItem
        '
        Me.ExportToExcelToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.History_ExportAllButton, Me.History_ExportSelectedButton})
        Me.ExportToExcelToolStripMenuItem.Name = "ExportToExcelToolStripMenuItem"
        Me.ExportToExcelToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ExportToExcelToolStripMenuItem.Text = "Export to Excel"
        '
        'History_ExportAllButton
        '
        Me.History_ExportAllButton.Name = "History_ExportAllButton"
        Me.History_ExportAllButton.Size = New System.Drawing.Size(180, 22)
        Me.History_ExportAllButton.Text = "All"
        '
        'History_ExportSelectedButton
        '
        Me.History_ExportSelectedButton.Name = "History_ExportSelectedButton"
        Me.History_ExportSelectedButton.Size = New System.Drawing.Size(180, 22)
        Me.History_ExportSelectedButton.Text = "Selection"
        '
        'UserStockPage
        '
        Me.UserStockPage.Controls.Add(Me.DGVUserStock)
        Me.UserStockPage.Location = New System.Drawing.Point(4, 22)
        Me.UserStockPage.Name = "UserStockPage"
        Me.UserStockPage.Size = New System.Drawing.Size(681, 327)
        Me.UserStockPage.TabIndex = 4
        Me.UserStockPage.Text = "User Stock"
        Me.UserStockPage.UseVisualStyleBackColor = True
        '
        'DGVUserStock
        '
        Me.DGVUserStock.AllowUserToAddRows = False
        Me.DGVUserStock.AllowUserToDeleteRows = False
        Me.DGVUserStock.AllowUserToOrderColumns = True
        Me.DGVUserStock.AllowUserToResizeColumns = False
        Me.DGVUserStock.AllowUserToResizeRows = False
        Me.DGVUserStock.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DGVUserStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVUserStock.ContextMenuStrip = Me.AnyStock_GridContextMenu
        Me.DGVUserStock.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGVUserStock.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DGVUserStock.Location = New System.Drawing.Point(0, 0)
        Me.DGVUserStock.Name = "DGVUserStock"
        Me.DGVUserStock.ReadOnly = True
        Me.DGVUserStock.RowHeadersVisible = False
        Me.DGVUserStock.RowHeadersWidth = 102
        Me.DGVUserStock.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGVUserStock.ShowCellErrors = False
        Me.DGVUserStock.ShowCellToolTips = False
        Me.DGVUserStock.ShowEditingIcon = False
        Me.DGVUserStock.ShowRowErrors = False
        Me.DGVUserStock.Size = New System.Drawing.Size(681, 327)
        Me.DGVUserStock.TabIndex = 11
        '
        'AnyStock_GridContextMenu
        '
        Me.AnyStock_GridContextMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EditItemInformationToolStripMenuItem})
        Me.AnyStock_GridContextMenu.Name = "AnyStock_GridContextMenu"
        Me.AnyStock_GridContextMenu.Size = New System.Drawing.Size(188, 26)
        '
        'EditItemInformationToolStripMenuItem
        '
        Me.EditItemInformationToolStripMenuItem.Name = "EditItemInformationToolStripMenuItem"
        Me.EditItemInformationToolStripMenuItem.Size = New System.Drawing.Size(187, 22)
        Me.EditItemInformationToolStripMenuItem.Text = "Edit Item Information"
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.AutoScroll = True
        Me.FlowLayoutPanel1.Controls.Add(Me.ManualTransferGroup)
        Me.FlowLayoutPanel1.Controls.Add(Me.ManualCheckInGroup)
        Me.FlowLayoutPanel1.Controls.Add(Me.GroupBox1)
        Me.FlowLayoutPanel1.Controls.Add(Me.Utils_PrintGroup)
        Me.FlowLayoutPanel1.Controls.Add(Me.AutoRefGroup)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(3, 3)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(673, 197)
        Me.FlowLayoutPanel1.TabIndex = 51
        '
        'ManualTransferGroup
        '
        Me.ManualTransferGroup.Controls.Add(Me.Utils_CheckOutButton)
        Me.ManualTransferGroup.Controls.Add(Me.Utils_CheckOutUserCB)
        Me.ManualTransferGroup.Controls.Add(Me.Label13)
        Me.ManualTransferGroup.Enabled = False
        Me.ManualTransferGroup.Location = New System.Drawing.Point(1, 1)
        Me.ManualTransferGroup.Margin = New System.Windows.Forms.Padding(1)
        Me.ManualTransferGroup.Name = "ManualTransferGroup"
        Me.ManualTransferGroup.Padding = New System.Windows.Forms.Padding(1)
        Me.ManualTransferGroup.Size = New System.Drawing.Size(211, 74)
        Me.ManualTransferGroup.TabIndex = 15
        Me.ManualTransferGroup.TabStop = False
        Me.ManualTransferGroup.Text = "Manual Check-Out"
        '
        'Utils_CheckOutButton
        '
        Me.Utils_CheckOutButton.Location = New System.Drawing.Point(121, 25)
        Me.Utils_CheckOutButton.Margin = New System.Windows.Forms.Padding(1)
        Me.Utils_CheckOutButton.Name = "Utils_CheckOutButton"
        Me.Utils_CheckOutButton.Size = New System.Drawing.Size(85, 27)
        Me.Utils_CheckOutButton.TabIndex = 14
        Me.Utils_CheckOutButton.Text = "Transfer"
        Me.Utils_CheckOutButton.UseVisualStyleBackColor = True
        '
        'Utils_CheckOutUserCB
        '
        Me.Utils_CheckOutUserCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Utils_CheckOutUserCB.FormattingEnabled = True
        Me.Utils_CheckOutUserCB.Items.AddRange(New Object() {"BSTOCK"})
        Me.Utils_CheckOutUserCB.Location = New System.Drawing.Point(12, 38)
        Me.Utils_CheckOutUserCB.Margin = New System.Windows.Forms.Padding(1)
        Me.Utils_CheckOutUserCB.Name = "Utils_CheckOutUserCB"
        Me.Utils_CheckOutUserCB.Size = New System.Drawing.Size(101, 21)
        Me.Utils_CheckOutUserCB.TabIndex = 0
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(9, 24)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(48, 13)
        Me.Label13.TabIndex = 13
        Me.Label13.Text = "To User:"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ManualCheckInGroup
        '
        Me.ManualCheckInGroup.Controls.Add(Me.Utils_FinalCheckIn)
        Me.ManualCheckInGroup.Controls.Add(Me.Utils_CheckInButton)
        Me.ManualCheckInGroup.Controls.Add(Me.Utils_CheckInUserCB)
        Me.ManualCheckInGroup.Controls.Add(Me.Label19)
        Me.ManualCheckInGroup.Enabled = False
        Me.ManualCheckInGroup.Location = New System.Drawing.Point(214, 1)
        Me.ManualCheckInGroup.Margin = New System.Windows.Forms.Padding(1)
        Me.ManualCheckInGroup.Name = "ManualCheckInGroup"
        Me.ManualCheckInGroup.Padding = New System.Windows.Forms.Padding(1)
        Me.ManualCheckInGroup.Size = New System.Drawing.Size(211, 74)
        Me.ManualCheckInGroup.TabIndex = 17
        Me.ManualCheckInGroup.TabStop = False
        Me.ManualCheckInGroup.Text = "Manual Check-In"
        '
        'Utils_FinalCheckIn
        '
        Me.Utils_FinalCheckIn.AutoSize = True
        Me.Utils_FinalCheckIn.Checked = True
        Me.Utils_FinalCheckIn.CheckState = System.Windows.Forms.CheckState.Checked
        Me.Utils_FinalCheckIn.Location = New System.Drawing.Point(121, 21)
        Me.Utils_FinalCheckIn.Name = "Utils_FinalCheckIn"
        Me.Utils_FinalCheckIn.Size = New System.Drawing.Size(48, 17)
        Me.Utils_FinalCheckIn.TabIndex = 15
        Me.Utils_FinalCheckIn.Text = "Final"
        Me.InfoTooltip.SetToolTip(Me.Utils_FinalCheckIn, resources.GetString("Utils_FinalCheckIn.ToolTip"))
        Me.Utils_FinalCheckIn.UseVisualStyleBackColor = True
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(10, 24)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(58, 13)
        Me.Label19.TabIndex = 13
        Me.Label19.Text = "From User:"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ProgramStockPage
        '
        Me.ProgramStockPage.Controls.Add(Me.DGVProgramStock)
        Me.ProgramStockPage.Location = New System.Drawing.Point(4, 22)
        Me.ProgramStockPage.Margin = New System.Windows.Forms.Padding(1)
        Me.ProgramStockPage.Name = "ProgramStockPage"
        Me.ProgramStockPage.Padding = New System.Windows.Forms.Padding(1)
        Me.ProgramStockPage.Size = New System.Drawing.Size(681, 327)
        Me.ProgramStockPage.TabIndex = 6
        Me.ProgramStockPage.Text = "Program Stock"
        Me.ProgramStockPage.UseVisualStyleBackColor = True
        '
        'DGVProgramStock
        '
        Me.DGVProgramStock.AllowUserToAddRows = False
        Me.DGVProgramStock.AllowUserToDeleteRows = False
        Me.DGVProgramStock.AllowUserToOrderColumns = True
        Me.DGVProgramStock.AllowUserToResizeColumns = False
        Me.DGVProgramStock.AllowUserToResizeRows = False
        Me.DGVProgramStock.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DGVProgramStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVProgramStock.ContextMenuStrip = Me.AnyStock_GridContextMenu
        Me.DGVProgramStock.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGVProgramStock.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DGVProgramStock.Location = New System.Drawing.Point(1, 1)
        Me.DGVProgramStock.Name = "DGVProgramStock"
        Me.DGVProgramStock.ReadOnly = True
        Me.DGVProgramStock.RowHeadersVisible = False
        Me.DGVProgramStock.RowHeadersWidth = 102
        Me.DGVProgramStock.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGVProgramStock.ShowCellErrors = False
        Me.DGVProgramStock.ShowCellToolTips = False
        Me.DGVProgramStock.ShowEditingIcon = False
        Me.DGVProgramStock.ShowRowErrors = False
        Me.DGVProgramStock.Size = New System.Drawing.Size(679, 325)
        Me.DGVProgramStock.TabIndex = 10
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 1
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.FlowLayoutPanel1, 0, 0)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(1, 123)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 1
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(679, 203)
        Me.TableLayoutPanel3.TabIndex = 53
        '
        'AutoRef_SwitchUserCombo
        '
        Me.AutoRef_SwitchUserCombo.Name = "AutoRef_SwitchUserCombo"
        Me.AutoRef_SwitchUserCombo.Size = New System.Drawing.Size(200, 23)
        '
        'SwitchUserToolStripMenuItem
        '
        Me.SwitchUserToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AutoRef_SwitchUserCombo})
        Me.SwitchUserToolStripMenuItem.Name = "SwitchUserToolStripMenuItem"
        Me.SwitchUserToolStripMenuItem.Size = New System.Drawing.Size(135, 22)
        Me.SwitchUserToolStripMenuItem.Text = "Switch User"
        '
        'AutoRefContextMenu
        '
        Me.AutoRefContextMenu.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.AutoRefContextMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SwitchUserToolStripMenuItem})
        Me.AutoRefContextMenu.Name = "ContextMenuStrip1"
        Me.AutoRefContextMenu.Size = New System.Drawing.Size(136, 26)
        '
        'RecordPage
        '
        Me.RecordPage.Controls.Add(Me.TableLayoutPanel1)
        Me.RecordPage.Controls.Add(Me.DGVRefNum)
        Me.RecordPage.Location = New System.Drawing.Point(4, 22)
        Me.RecordPage.Name = "RecordPage"
        Me.RecordPage.Padding = New System.Windows.Forms.Padding(3)
        Me.RecordPage.Size = New System.Drawing.Size(691, 355)
        Me.RecordPage.TabIndex = 0
        Me.RecordPage.Text = "Record Inventory"
        Me.RecordPage.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 140.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Panel1, 1, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(3, 70)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.058824!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 92.94118!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(685, 282)
        Me.TableLayoutPanel1.TabIndex = 10
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.CheckInButton)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.RefNumInput)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(275, 20)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(134, 223)
        Me.Panel1.TabIndex = 0
        '
        'CheckInButton
        '
        Me.CheckInButton.Location = New System.Drawing.Point(6, 72)
        Me.CheckInButton.Name = "CheckInButton"
        Me.CheckInButton.Size = New System.Drawing.Size(123, 29)
        Me.CheckInButton.TabIndex = 4
        Me.CheckInButton.Text = "Check In/Out"
        Me.CheckInButton.UseVisualStyleBackColor = True
        Me.CheckInButton.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Reference Number:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'RefNumInput
        '
        Me.RefNumInput.Location = New System.Drawing.Point(17, 29)
        Me.RefNumInput.Name = "RefNumInput"
        Me.RefNumInput.Size = New System.Drawing.Size(102, 20)
        Me.RefNumInput.TabIndex = 0
        '
        'DGVRefNum
        '
        Me.DGVRefNum.AllowUserToAddRows = False
        Me.DGVRefNum.AllowUserToDeleteRows = False
        Me.DGVRefNum.AllowUserToResizeColumns = False
        Me.DGVRefNum.AllowUserToResizeRows = False
        Me.DGVRefNum.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGVRefNum.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVRefNum.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ReferenceNumberRI, Me.PartDescriptionRI, Me.PartNumberRI, Me.LotNumberRI, Me.ExpirationDateRI})
        Me.DGVRefNum.Dock = System.Windows.Forms.DockStyle.Top
        Me.DGVRefNum.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DGVRefNum.Location = New System.Drawing.Point(3, 3)
        Me.DGVRefNum.MaximumSize = New System.Drawing.Size(0, 67)
        Me.DGVRefNum.Name = "DGVRefNum"
        Me.DGVRefNum.ReadOnly = True
        Me.DGVRefNum.RowHeadersVisible = False
        Me.DGVRefNum.RowHeadersWidth = 102
        Me.DGVRefNum.ShowCellErrors = False
        Me.DGVRefNum.ShowCellToolTips = False
        Me.DGVRefNum.ShowEditingIcon = False
        Me.DGVRefNum.ShowRowErrors = False
        Me.DGVRefNum.Size = New System.Drawing.Size(685, 67)
        Me.DGVRefNum.TabIndex = 5
        '
        'ReferenceNumberRI
        '
        Me.ReferenceNumberRI.FillWeight = 35.0!
        Me.ReferenceNumberRI.HeaderText = "REF"
        Me.ReferenceNumberRI.Name = "ReferenceNumberRI"
        Me.ReferenceNumberRI.ReadOnly = True
        '
        'PartDescriptionRI
        '
        Me.PartDescriptionRI.HeaderText = "Desc"
        Me.PartDescriptionRI.Name = "PartDescriptionRI"
        Me.PartDescriptionRI.ReadOnly = True
        '
        'PartNumberRI
        '
        Me.PartNumberRI.FillWeight = 60.0!
        Me.PartNumberRI.HeaderText = "P/N"
        Me.PartNumberRI.Name = "PartNumberRI"
        Me.PartNumberRI.ReadOnly = True
        '
        'LotNumberRI
        '
        Me.LotNumberRI.FillWeight = 55.0!
        Me.LotNumberRI.HeaderText = "Lot"
        Me.LotNumberRI.Name = "LotNumberRI"
        Me.LotNumberRI.ReadOnly = True
        '
        'ExpirationDateRI
        '
        Me.ExpirationDateRI.FillWeight = 50.0!
        Me.ExpirationDateRI.HeaderText = "Exp"
        Me.ExpirationDateRI.Name = "ExpirationDateRI"
        Me.ExpirationDateRI.ReadOnly = True
        '
        'DGVUtilities
        '
        Me.DGVUtilities.AllowUserToAddRows = False
        Me.DGVUtilities.AllowUserToDeleteRows = False
        Me.DGVUtilities.AllowUserToResizeColumns = False
        Me.DGVUtilities.AllowUserToResizeRows = False
        Me.DGVUtilities.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DGVUtilities.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVUtilities.Dock = System.Windows.Forms.DockStyle.Top
        Me.DGVUtilities.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DGVUtilities.Location = New System.Drawing.Point(1, 1)
        Me.DGVUtilities.MaximumSize = New System.Drawing.Size(0, 67)
        Me.DGVUtilities.Name = "DGVUtilities"
        Me.DGVUtilities.ReadOnly = True
        Me.DGVUtilities.RowHeadersVisible = False
        Me.DGVUtilities.RowHeadersWidth = 102
        Me.DGVUtilities.ShowCellErrors = False
        Me.DGVUtilities.ShowCellToolTips = False
        Me.DGVUtilities.ShowEditingIcon = False
        Me.DGVUtilities.ShowRowErrors = False
        Me.DGVUtilities.Size = New System.Drawing.Size(679, 67)
        Me.DGVUtilities.TabIndex = 12
        '
        'ManagementPage
        '
        Me.ManagementPage.Controls.Add(Me.ManagementPageTabControl)
        Me.ManagementPage.Location = New System.Drawing.Point(4, 22)
        Me.ManagementPage.Margin = New System.Windows.Forms.Padding(1)
        Me.ManagementPage.Name = "ManagementPage"
        Me.ManagementPage.Padding = New System.Windows.Forms.Padding(1)
        Me.ManagementPage.Size = New System.Drawing.Size(691, 355)
        Me.ManagementPage.TabIndex = 6
        Me.ManagementPage.Text = "Management"
        Me.ManagementPage.UseVisualStyleBackColor = True
        '
        'ManagementPageTabControl
        '
        Me.ManagementPageTabControl.Controls.Add(Me.InvUtilsPage)
        Me.ManagementPageTabControl.Controls.Add(Me.AddMaterialsTab)
        Me.ManagementPageTabControl.Controls.Add(Me.EditMaterialsTab)
        Me.ManagementPageTabControl.Controls.Add(Me.ProgramStockPage)
        Me.ManagementPageTabControl.Controls.Add(Me.UserStockPage)
        Me.ManagementPageTabControl.Controls.Add(Me.CommonStockPage)
        Me.ManagementPageTabControl.Controls.Add(Me.HistoryPage)
        Me.ManagementPageTabControl.Controls.Add(Me.AutoDescTab)
        Me.ManagementPageTabControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ManagementPageTabControl.Location = New System.Drawing.Point(1, 1)
        Me.ManagementPageTabControl.Margin = New System.Windows.Forms.Padding(1, 42, 1, 1)
        Me.ManagementPageTabControl.Name = "ManagementPageTabControl"
        Me.ManagementPageTabControl.SelectedIndex = 0
        Me.ManagementPageTabControl.Size = New System.Drawing.Size(689, 353)
        Me.ManagementPageTabControl.TabIndex = 11
        Me.ManagementPageTabControl.TabStop = False
        '
        'InvUtilsPage
        '
        Me.InvUtilsPage.Controls.Add(Me.TableLayoutPanel3)
        Me.InvUtilsPage.Controls.Add(Me.TableLayoutPanel2)
        Me.InvUtilsPage.Controls.Add(Me.DGVUtilities)
        Me.InvUtilsPage.Location = New System.Drawing.Point(4, 22)
        Me.InvUtilsPage.Margin = New System.Windows.Forms.Padding(1)
        Me.InvUtilsPage.Name = "InvUtilsPage"
        Me.InvUtilsPage.Padding = New System.Windows.Forms.Padding(1)
        Me.InvUtilsPage.Size = New System.Drawing.Size(681, 327)
        Me.InvUtilsPage.TabIndex = 2
        Me.InvUtilsPage.Text = "Utilities"
        Me.InvUtilsPage.UseVisualStyleBackColor = True
        '
        'AddMaterialsTab
        '
        Me.AddMaterialsTab.Controls.Add(Me.FlowLayoutPanel3)
        Me.AddMaterialsTab.Location = New System.Drawing.Point(4, 22)
        Me.AddMaterialsTab.Name = "AddMaterialsTab"
        Me.AddMaterialsTab.Padding = New System.Windows.Forms.Padding(3)
        Me.AddMaterialsTab.Size = New System.Drawing.Size(681, 327)
        Me.AddMaterialsTab.TabIndex = 7
        Me.AddMaterialsTab.Text = "Add Materials"
        Me.AddMaterialsTab.UseVisualStyleBackColor = True
        '
        'FlowLayoutPanel3
        '
        Me.FlowLayoutPanel3.Controls.Add(Me.AddMaterials_MaterialInfoGroup)
        Me.FlowLayoutPanel3.Controls.Add(Me.AddMaterials_StockTypeGroup)
        Me.FlowLayoutPanel3.Controls.Add(Me.AddMaterials_ProgramCommonRefNumGroup)
        Me.FlowLayoutPanel3.Controls.Add(Me.AddMaterials_ProgramQtyAvailGroup)
        Me.FlowLayoutPanel3.Controls.Add(Me.AddMaterials_UserStockGroup)
        Me.FlowLayoutPanel3.Controls.Add(Me.AddMaterials_AddButtonGroup)
        Me.FlowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel3.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.FlowLayoutPanel3.Location = New System.Drawing.Point(3, 3)
        Me.FlowLayoutPanel3.Margin = New System.Windows.Forms.Padding(0)
        Me.FlowLayoutPanel3.Name = "FlowLayoutPanel3"
        Me.FlowLayoutPanel3.Size = New System.Drawing.Size(675, 321)
        Me.FlowLayoutPanel3.TabIndex = 57
        '
        'AddMaterials_MaterialInfoGroup
        '
        Me.AddMaterials_MaterialInfoGroup.Controls.Add(Me.AddMaterials_ExpDate)
        Me.AddMaterials_MaterialInfoGroup.Controls.Add(Me.AddMaterials_LotNumber)
        Me.AddMaterials_MaterialInfoGroup.Controls.Add(Me.AddMaterials_PartDescription)
        Me.AddMaterials_MaterialInfoGroup.Controls.Add(Me.AddMaterials_PartNumber)
        Me.AddMaterials_MaterialInfoGroup.Controls.Add(Me.Label3)
        Me.AddMaterials_MaterialInfoGroup.Controls.Add(Me.Label4)
        Me.AddMaterials_MaterialInfoGroup.Controls.Add(Me.Label5)
        Me.AddMaterials_MaterialInfoGroup.Controls.Add(Me.Label8)
        Me.AddMaterials_MaterialInfoGroup.Controls.Add(Me.SavePartDescButton)
        Me.AddMaterials_MaterialInfoGroup.Controls.Add(Me.AddMaterials_NoExpDate)
        Me.AddMaterials_MaterialInfoGroup.Location = New System.Drawing.Point(3, 3)
        Me.AddMaterials_MaterialInfoGroup.Name = "AddMaterials_MaterialInfoGroup"
        Me.AddMaterials_MaterialInfoGroup.Size = New System.Drawing.Size(266, 135)
        Me.AddMaterials_MaterialInfoGroup.TabIndex = 54
        Me.AddMaterials_MaterialInfoGroup.TabStop = False
        Me.AddMaterials_MaterialInfoGroup.Text = "Material Information"
        '
        'AddMaterials_ExpDate
        '
        Me.AddMaterials_ExpDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.AddMaterials_ExpDate.Location = New System.Drawing.Point(153, 104)
        Me.AddMaterials_ExpDate.Margin = New System.Windows.Forms.Padding(1)
        Me.AddMaterials_ExpDate.Name = "AddMaterials_ExpDate"
        Me.AddMaterials_ExpDate.Size = New System.Drawing.Size(102, 20)
        Me.AddMaterials_ExpDate.TabIndex = 40
        '
        'AddMaterials_LotNumber
        '
        Me.AddMaterials_LotNumber.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.AddMaterials_LotNumber.Location = New System.Drawing.Point(9, 104)
        Me.AddMaterials_LotNumber.Name = "AddMaterials_LotNumber"
        Me.AddMaterials_LotNumber.Size = New System.Drawing.Size(135, 20)
        Me.AddMaterials_LotNumber.TabIndex = 39
        '
        'AddMaterials_PartDescription
        '
        Me.AddMaterials_PartDescription.Location = New System.Drawing.Point(9, 67)
        Me.AddMaterials_PartDescription.Name = "AddMaterials_PartDescription"
        Me.AddMaterials_PartDescription.Size = New System.Drawing.Size(246, 20)
        Me.AddMaterials_PartDescription.TabIndex = 37
        '
        'AddMaterials_PartNumber
        '
        Me.AddMaterials_PartNumber.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.AddMaterials_PartNumber.Location = New System.Drawing.Point(9, 30)
        Me.AddMaterials_PartNumber.Name = "AddMaterials_PartNumber"
        Me.AddMaterials_PartNumber.Size = New System.Drawing.Size(102, 20)
        Me.AddMaterials_PartNumber.TabIndex = 36
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 13)
        Me.Label3.TabIndex = 45
        Me.Label3.Text = "Part Number:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(7, 90)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 13)
        Me.Label4.TabIndex = 46
        Me.Label4.Text = "Lot/Batch:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(150, 91)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(57, 13)
        Me.Label5.TabIndex = 47
        Me.Label5.Text = "Exp. Date:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 53)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(85, 13)
        Me.Label8.TabIndex = 48
        Me.Label8.Text = "Part Description:"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'SavePartDescButton
        '
        Me.SavePartDescButton.Location = New System.Drawing.Point(117, 29)
        Me.SavePartDescButton.Name = "SavePartDescButton"
        Me.SavePartDescButton.Size = New System.Drawing.Size(138, 22)
        Me.SavePartDescButton.TabIndex = 38
        Me.SavePartDescButton.Text = "Save Part Description"
        Me.SavePartDescButton.UseVisualStyleBackColor = True
        Me.SavePartDescButton.Visible = False
        '
        'AddMaterials_NoExpDate
        '
        Me.AddMaterials_NoExpDate.AutoSize = True
        Me.AddMaterials_NoExpDate.Location = New System.Drawing.Point(208, 89)
        Me.AddMaterials_NoExpDate.Margin = New System.Windows.Forms.Padding(1)
        Me.AddMaterials_NoExpDate.Name = "AddMaterials_NoExpDate"
        Me.AddMaterials_NoExpDate.Size = New System.Drawing.Size(52, 17)
        Me.AddMaterials_NoExpDate.TabIndex = 41
        Me.AddMaterials_NoExpDate.Text = "None"
        Me.AddMaterials_NoExpDate.UseVisualStyleBackColor = True
        '
        'AddMaterials_StockTypeGroup
        '
        Me.AddMaterials_StockTypeGroup.Controls.Add(Me.AddMaterials_CommonStockTypeRadio)
        Me.AddMaterials_StockTypeGroup.Controls.Add(Me.AddMaterials_ProgramStockTypeRadio)
        Me.AddMaterials_StockTypeGroup.Controls.Add(Me.AddMaterials_UserStockTypeRadio)
        Me.AddMaterials_StockTypeGroup.Location = New System.Drawing.Point(3, 144)
        Me.AddMaterials_StockTypeGroup.Name = "AddMaterials_StockTypeGroup"
        Me.AddMaterials_StockTypeGroup.Size = New System.Drawing.Size(266, 48)
        Me.AddMaterials_StockTypeGroup.TabIndex = 55
        Me.AddMaterials_StockTypeGroup.TabStop = False
        Me.AddMaterials_StockTypeGroup.Text = "Stock Type"
        '
        'AddMaterials_CommonStockTypeRadio
        '
        Me.AddMaterials_CommonStockTypeRadio.AutoSize = True
        Me.AddMaterials_CommonStockTypeRadio.Location = New System.Drawing.Point(181, 20)
        Me.AddMaterials_CommonStockTypeRadio.Name = "AddMaterials_CommonStockTypeRadio"
        Me.AddMaterials_CommonStockTypeRadio.Size = New System.Drawing.Size(66, 17)
        Me.AddMaterials_CommonStockTypeRadio.TabIndex = 2
        Me.AddMaterials_CommonStockTypeRadio.Text = "Common"
        Me.InfoTooltip.SetToolTip(Me.AddMaterials_CommonStockTypeRadio, "Common Stock materials are visible to all users and can be used" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "without being as" &
        "ked to specify Shop Order and Quantity.")
        Me.AddMaterials_CommonStockTypeRadio.UseVisualStyleBackColor = True
        '
        'AddMaterials_ProgramStockTypeRadio
        '
        Me.AddMaterials_ProgramStockTypeRadio.AutoSize = True
        Me.AddMaterials_ProgramStockTypeRadio.Location = New System.Drawing.Point(101, 20)
        Me.AddMaterials_ProgramStockTypeRadio.Name = "AddMaterials_ProgramStockTypeRadio"
        Me.AddMaterials_ProgramStockTypeRadio.Size = New System.Drawing.Size(64, 17)
        Me.AddMaterials_ProgramStockTypeRadio.TabIndex = 1
        Me.AddMaterials_ProgramStockTypeRadio.Text = "Program"
        Me.InfoTooltip.SetToolTip(Me.AddMaterials_ProgramStockTypeRadio, resources.GetString("AddMaterials_ProgramStockTypeRadio.ToolTip"))
        Me.AddMaterials_ProgramStockTypeRadio.UseVisualStyleBackColor = True
        '
        'AddMaterials_UserStockTypeRadio
        '
        Me.AddMaterials_UserStockTypeRadio.AutoSize = True
        Me.AddMaterials_UserStockTypeRadio.Location = New System.Drawing.Point(21, 20)
        Me.AddMaterials_UserStockTypeRadio.Name = "AddMaterials_UserStockTypeRadio"
        Me.AddMaterials_UserStockTypeRadio.Size = New System.Drawing.Size(47, 17)
        Me.AddMaterials_UserStockTypeRadio.TabIndex = 0
        Me.AddMaterials_UserStockTypeRadio.Text = "User"
        Me.InfoTooltip.SetToolTip(Me.AddMaterials_UserStockTypeRadio, resources.GetString("AddMaterials_UserStockTypeRadio.ToolTip"))
        Me.AddMaterials_UserStockTypeRadio.UseVisualStyleBackColor = True
        '
        'AddMaterials_ProgramCommonRefNumGroup
        '
        Me.AddMaterials_ProgramCommonRefNumGroup.Controls.Add(Me.AddMaterials_ProgramCommonRefNumTextBox)
        Me.AddMaterials_ProgramCommonRefNumGroup.Location = New System.Drawing.Point(3, 198)
        Me.AddMaterials_ProgramCommonRefNumGroup.Name = "AddMaterials_ProgramCommonRefNumGroup"
        Me.AddMaterials_ProgramCommonRefNumGroup.Size = New System.Drawing.Size(266, 48)
        Me.AddMaterials_ProgramCommonRefNumGroup.TabIndex = 56
        Me.AddMaterials_ProgramCommonRefNumGroup.TabStop = False
        Me.AddMaterials_ProgramCommonRefNumGroup.Text = "Reference Number"
        Me.AddMaterials_ProgramCommonRefNumGroup.Visible = False
        '
        'AddMaterials_ProgramCommonRefNumTextBox
        '
        Me.AddMaterials_ProgramCommonRefNumTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.AddMaterials_ProgramCommonRefNumTextBox.Location = New System.Drawing.Point(80, 19)
        Me.AddMaterials_ProgramCommonRefNumTextBox.Name = "AddMaterials_ProgramCommonRefNumTextBox"
        Me.AddMaterials_ProgramCommonRefNumTextBox.ReadOnly = True
        Me.AddMaterials_ProgramCommonRefNumTextBox.Size = New System.Drawing.Size(102, 20)
        Me.AddMaterials_ProgramCommonRefNumTextBox.TabIndex = 50
        '
        'AddMaterials_ProgramQtyAvailGroup
        '
        Me.AddMaterials_ProgramQtyAvailGroup.Controls.Add(Me.AddMaterials_ProgramQtyPerUse)
        Me.AddMaterials_ProgramQtyAvailGroup.Controls.Add(Me.AddMaterials_ProgramQtyAvailable)
        Me.AddMaterials_ProgramQtyAvailGroup.Controls.Add(Me.Label6)
        Me.AddMaterials_ProgramQtyAvailGroup.Controls.Add(Me.Label7)
        Me.AddMaterials_ProgramQtyAvailGroup.Location = New System.Drawing.Point(3, 252)
        Me.AddMaterials_ProgramQtyAvailGroup.Name = "AddMaterials_ProgramQtyAvailGroup"
        Me.AddMaterials_ProgramQtyAvailGroup.Size = New System.Drawing.Size(266, 64)
        Me.AddMaterials_ProgramQtyAvailGroup.TabIndex = 59
        Me.AddMaterials_ProgramQtyAvailGroup.TabStop = False
        Me.AddMaterials_ProgramQtyAvailGroup.Text = "Program Stock"
        Me.AddMaterials_ProgramQtyAvailGroup.Visible = False
        '
        'AddMaterials_ProgramQtyPerUse
        '
        Me.AddMaterials_ProgramQtyPerUse.DecimalPlaces = 6
        Me.AddMaterials_ProgramQtyPerUse.Increment = New Decimal(New Integer() {1, 0, 0, 131072})
        Me.AddMaterials_ProgramQtyPerUse.Location = New System.Drawing.Point(162, 32)
        Me.AddMaterials_ProgramQtyPerUse.Name = "AddMaterials_ProgramQtyPerUse"
        Me.AddMaterials_ProgramQtyPerUse.Size = New System.Drawing.Size(84, 20)
        Me.AddMaterials_ProgramQtyPerUse.TabIndex = 6
        '
        'AddMaterials_ProgramQtyAvailable
        '
        Me.AddMaterials_ProgramQtyAvailable.DecimalPlaces = 6
        Me.AddMaterials_ProgramQtyAvailable.Location = New System.Drawing.Point(15, 32)
        Me.AddMaterials_ProgramQtyAvailable.Name = "AddMaterials_ProgramQtyAvailable"
        Me.AddMaterials_ProgramQtyAvailable.Size = New System.Drawing.Size(84, 20)
        Me.AddMaterials_ProgramQtyAvailable.TabIndex = 4
        Me.AddMaterials_ProgramQtyAvailable.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(159, 18)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(87, 13)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Quantity Per Use"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(12, 18)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(119, 13)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "Total Quantity Available"
        '
        'AddMaterials_UserStockGroup
        '
        Me.AddMaterials_UserStockGroup.Controls.Add(Me.AddMaterials_UserRefNumbers)
        Me.AddMaterials_UserStockGroup.Controls.Add(Me.AddMaterials_UserQtyAvailable)
        Me.AddMaterials_UserStockGroup.Controls.Add(Me.Label9)
        Me.AddMaterials_UserStockGroup.Controls.Add(Me.Label2)
        Me.AddMaterials_UserStockGroup.Location = New System.Drawing.Point(275, 3)
        Me.AddMaterials_UserStockGroup.Name = "AddMaterials_UserStockGroup"
        Me.AddMaterials_UserStockGroup.Size = New System.Drawing.Size(266, 189)
        Me.AddMaterials_UserStockGroup.TabIndex = 58
        Me.AddMaterials_UserStockGroup.TabStop = False
        Me.AddMaterials_UserStockGroup.Text = "User Stock"
        Me.AddMaterials_UserStockGroup.Visible = False
        '
        'AddMaterials_UserRefNumbers
        '
        Me.AddMaterials_UserRefNumbers.FormattingEnabled = True
        Me.AddMaterials_UserRefNumbers.Location = New System.Drawing.Point(106, 32)
        Me.AddMaterials_UserRefNumbers.Name = "AddMaterials_UserRefNumbers"
        Me.AddMaterials_UserRefNumbers.Size = New System.Drawing.Size(154, 147)
        Me.AddMaterials_UserRefNumbers.TabIndex = 0
        '
        'AddMaterials_UserQtyAvailable
        '
        Me.AddMaterials_UserQtyAvailable.Location = New System.Drawing.Point(15, 32)
        Me.AddMaterials_UserQtyAvailable.Name = "AddMaterials_UserQtyAvailable"
        Me.AddMaterials_UserQtyAvailable.Size = New System.Drawing.Size(72, 20)
        Me.AddMaterials_UserQtyAvailable.TabIndex = 1
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(103, 18)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(105, 13)
        Me.Label9.TabIndex = 48
        Me.Label9.Text = "Reference Numbers:"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 13)
        Me.Label2.TabIndex = 47
        Me.Label2.Text = "Qty Available:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'AddMaterials_AddButtonGroup
        '
        Me.AddMaterials_AddButtonGroup.Controls.Add(Me.AddMaterials_AddItemsButton)
        Me.AddMaterials_AddButtonGroup.Controls.Add(Me.AddMaterials_CompactLabelCheck)
        Me.AddMaterials_AddButtonGroup.Controls.Add(Me.AddMaterials_PrintLabelCB)
        Me.AddMaterials_AddButtonGroup.Location = New System.Drawing.Point(275, 198)
        Me.AddMaterials_AddButtonGroup.Name = "AddMaterials_AddButtonGroup"
        Me.AddMaterials_AddButtonGroup.Size = New System.Drawing.Size(266, 48)
        Me.AddMaterials_AddButtonGroup.TabIndex = 57
        Me.AddMaterials_AddButtonGroup.TabStop = False
        Me.AddMaterials_AddButtonGroup.Visible = False
        '
        'AddMaterials_AddItemsButton
        '
        Me.AddMaterials_AddItemsButton.Location = New System.Drawing.Point(162, 15)
        Me.AddMaterials_AddItemsButton.Name = "AddMaterials_AddItemsButton"
        Me.AddMaterials_AddItemsButton.Size = New System.Drawing.Size(94, 24)
        Me.AddMaterials_AddItemsButton.TabIndex = 44
        Me.AddMaterials_AddItemsButton.Text = "Add"
        Me.AddMaterials_AddItemsButton.UseVisualStyleBackColor = True
        '
        'AddMaterials_CompactLabelCheck
        '
        Me.AddMaterials_CompactLabelCheck.AutoSize = True
        Me.AddMaterials_CompactLabelCheck.Location = New System.Drawing.Point(54, 20)
        Me.AddMaterials_CompactLabelCheck.Name = "AddMaterials_CompactLabelCheck"
        Me.AddMaterials_CompactLabelCheck.Size = New System.Drawing.Size(108, 17)
        Me.AddMaterials_CompactLabelCheck.TabIndex = 43
        Me.AddMaterials_CompactLabelCheck.Text = "(Compact) Labels"
        Me.InfoTooltip.SetToolTip(Me.AddMaterials_CompactLabelCheck, resources.GetString("AddMaterials_CompactLabelCheck.ToolTip"))
        Me.AddMaterials_CompactLabelCheck.UseVisualStyleBackColor = True
        '
        'AddMaterials_PrintLabelCB
        '
        Me.AddMaterials_PrintLabelCB.AutoSize = True
        Me.AddMaterials_PrintLabelCB.Checked = True
        Me.AddMaterials_PrintLabelCB.CheckState = System.Windows.Forms.CheckState.Checked
        Me.AddMaterials_PrintLabelCB.Location = New System.Drawing.Point(8, 20)
        Me.AddMaterials_PrintLabelCB.Margin = New System.Windows.Forms.Padding(1)
        Me.AddMaterials_PrintLabelCB.Name = "AddMaterials_PrintLabelCB"
        Me.AddMaterials_PrintLabelCB.Size = New System.Drawing.Size(47, 17)
        Me.AddMaterials_PrintLabelCB.TabIndex = 42
        Me.AddMaterials_PrintLabelCB.Text = "Print"
        Me.InfoTooltip.SetToolTip(Me.AddMaterials_PrintLabelCB, "Print a label for each Reference Number added. Example below:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "REF: 99999" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "P/N:" &
        " EX-ITEM" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "LOT: 1234ABC6789" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "EXP: 1/15/2000")
        Me.AddMaterials_PrintLabelCB.UseVisualStyleBackColor = True
        '
        'EditMaterialsTab
        '
        Me.EditMaterialsTab.Controls.Add(Me.TableLayoutPanel5)
        Me.EditMaterialsTab.Location = New System.Drawing.Point(4, 22)
        Me.EditMaterialsTab.Margin = New System.Windows.Forms.Padding(0)
        Me.EditMaterialsTab.Name = "EditMaterialsTab"
        Me.EditMaterialsTab.Size = New System.Drawing.Size(681, 327)
        Me.EditMaterialsTab.TabIndex = 8
        Me.EditMaterialsTab.Text = "Edit Materials"
        Me.EditMaterialsTab.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel5
        '
        Me.TableLayoutPanel5.ColumnCount = 1
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel5.Controls.Add(Me.FlowLayoutPanel2, 0, 1)
        Me.TableLayoutPanel5.Controls.Add(Me.DGVAssignRefNum, 0, 0)
        Me.TableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel5.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel5.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel5.Name = "TableLayoutPanel5"
        Me.TableLayoutPanel5.RowCount = 2
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 150.0!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel5.Size = New System.Drawing.Size(681, 327)
        Me.TableLayoutPanel5.TabIndex = 0
        '
        'FlowLayoutPanel2
        '
        Me.FlowLayoutPanel2.Controls.Add(Me.EditMaterials_MaterialInfoGroup)
        Me.FlowLayoutPanel2.Controls.Add(Me.EditMaterials_ProgramQtyGroup)
        Me.FlowLayoutPanel2.Controls.Add(Me.EditMaterials_ButtonGroup)
        Me.FlowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel2.Location = New System.Drawing.Point(0, 177)
        Me.FlowLayoutPanel2.Margin = New System.Windows.Forms.Padding(0)
        Me.FlowLayoutPanel2.Name = "FlowLayoutPanel2"
        Me.FlowLayoutPanel2.Size = New System.Drawing.Size(681, 150)
        Me.FlowLayoutPanel2.TabIndex = 12
        '
        'EditMaterials_MaterialInfoGroup
        '
        Me.EditMaterials_MaterialInfoGroup.Controls.Add(Me.EditMaterials_ExpDatePicker)
        Me.EditMaterials_MaterialInfoGroup.Controls.Add(Me.EditMaterials_LotBatchTB)
        Me.EditMaterials_MaterialInfoGroup.Controls.Add(Me.EditMaterials_PartDescTB)
        Me.EditMaterials_MaterialInfoGroup.Controls.Add(Me.EditMaterials_PartNumberTB)
        Me.EditMaterials_MaterialInfoGroup.Controls.Add(Me.EditMaterials_NoExpDateCB)
        Me.EditMaterials_MaterialInfoGroup.Controls.Add(Me.Label20)
        Me.EditMaterials_MaterialInfoGroup.Controls.Add(Me.Label21)
        Me.EditMaterials_MaterialInfoGroup.Controls.Add(Me.Label12)
        Me.EditMaterials_MaterialInfoGroup.Controls.Add(Me.Label18)
        Me.EditMaterials_MaterialInfoGroup.Enabled = False
        Me.EditMaterials_MaterialInfoGroup.Location = New System.Drawing.Point(3, 3)
        Me.EditMaterials_MaterialInfoGroup.Name = "EditMaterials_MaterialInfoGroup"
        Me.EditMaterials_MaterialInfoGroup.Size = New System.Drawing.Size(302, 144)
        Me.EditMaterials_MaterialInfoGroup.TabIndex = 11
        Me.EditMaterials_MaterialInfoGroup.TabStop = False
        Me.EditMaterials_MaterialInfoGroup.Text = "Material Information"
        '
        'EditMaterials_ExpDatePicker
        '
        Me.EditMaterials_ExpDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.EditMaterials_ExpDatePicker.Location = New System.Drawing.Point(146, 110)
        Me.EditMaterials_ExpDatePicker.Margin = New System.Windows.Forms.Padding(1)
        Me.EditMaterials_ExpDatePicker.Name = "EditMaterials_ExpDatePicker"
        Me.EditMaterials_ExpDatePicker.Size = New System.Drawing.Size(102, 20)
        Me.EditMaterials_ExpDatePicker.TabIndex = 55
        '
        'EditMaterials_LotBatchTB
        '
        Me.EditMaterials_LotBatchTB.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.EditMaterials_LotBatchTB.Location = New System.Drawing.Point(16, 110)
        Me.EditMaterials_LotBatchTB.Name = "EditMaterials_LotBatchTB"
        Me.EditMaterials_LotBatchTB.Size = New System.Drawing.Size(120, 20)
        Me.EditMaterials_LotBatchTB.TabIndex = 54
        '
        'EditMaterials_PartDescTB
        '
        Me.EditMaterials_PartDescTB.Location = New System.Drawing.Point(15, 71)
        Me.EditMaterials_PartDescTB.Name = "EditMaterials_PartDescTB"
        Me.EditMaterials_PartDescTB.Size = New System.Drawing.Size(246, 20)
        Me.EditMaterials_PartDescTB.TabIndex = 50
        '
        'EditMaterials_PartNumberTB
        '
        Me.EditMaterials_PartNumberTB.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.EditMaterials_PartNumberTB.Location = New System.Drawing.Point(15, 34)
        Me.EditMaterials_PartNumberTB.Name = "EditMaterials_PartNumberTB"
        Me.EditMaterials_PartNumberTB.Size = New System.Drawing.Size(102, 20)
        Me.EditMaterials_PartNumberTB.TabIndex = 49
        '
        'EditMaterials_NoExpDateCB
        '
        Me.EditMaterials_NoExpDateCB.AutoSize = True
        Me.EditMaterials_NoExpDateCB.Location = New System.Drawing.Point(203, 94)
        Me.EditMaterials_NoExpDateCB.Margin = New System.Windows.Forms.Padding(1)
        Me.EditMaterials_NoExpDateCB.Name = "EditMaterials_NoExpDateCB"
        Me.EditMaterials_NoExpDateCB.Size = New System.Drawing.Size(52, 17)
        Me.EditMaterials_NoExpDateCB.TabIndex = 56
        Me.EditMaterials_NoExpDateCB.Text = "None"
        Me.EditMaterials_NoExpDateCB.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.EditMaterials_NoExpDateCB.UseVisualStyleBackColor = True
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(144, 96)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(57, 13)
        Me.Label20.TabIndex = 58
        Me.Label20.Text = "Exp. Date:"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(14, 96)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(58, 13)
        Me.Label21.TabIndex = 57
        Me.Label21.Text = "Lot/Batch:"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(13, 57)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(85, 13)
        Me.Label12.TabIndex = 53
        Me.Label12.Text = "Part Description:"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(13, 20)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(69, 13)
        Me.Label18.TabIndex = 52
        Me.Label18.Text = "Part Number:"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'EditMaterials_ProgramQtyGroup
        '
        Me.EditMaterials_ProgramQtyGroup.Controls.Add(Me.EditMaterials_ProgramQtyPerUse)
        Me.EditMaterials_ProgramQtyGroup.Controls.Add(Me.EditMaterials_ProgramTotalQtyAvail)
        Me.EditMaterials_ProgramQtyGroup.Controls.Add(Me.Label11)
        Me.EditMaterials_ProgramQtyGroup.Controls.Add(Me.Label10)
        Me.EditMaterials_ProgramQtyGroup.Location = New System.Drawing.Point(311, 3)
        Me.EditMaterials_ProgramQtyGroup.Name = "EditMaterials_ProgramQtyGroup"
        Me.EditMaterials_ProgramQtyGroup.Size = New System.Drawing.Size(138, 144)
        Me.EditMaterials_ProgramQtyGroup.TabIndex = 9
        Me.EditMaterials_ProgramQtyGroup.TabStop = False
        Me.EditMaterials_ProgramQtyGroup.Text = "Program Stock"
        Me.EditMaterials_ProgramQtyGroup.Visible = False
        '
        'EditMaterials_ProgramQtyPerUse
        '
        Me.EditMaterials_ProgramQtyPerUse.DecimalPlaces = 6
        Me.EditMaterials_ProgramQtyPerUse.Increment = New Decimal(New Integer() {1, 0, 0, 131072})
        Me.EditMaterials_ProgramQtyPerUse.Location = New System.Drawing.Point(13, 71)
        Me.EditMaterials_ProgramQtyPerUse.Name = "EditMaterials_ProgramQtyPerUse"
        Me.EditMaterials_ProgramQtyPerUse.Size = New System.Drawing.Size(93, 20)
        Me.EditMaterials_ProgramQtyPerUse.TabIndex = 2
        Me.EditMaterials_ProgramQtyPerUse.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'EditMaterials_ProgramTotalQtyAvail
        '
        Me.EditMaterials_ProgramTotalQtyAvail.DecimalPlaces = 6
        Me.EditMaterials_ProgramTotalQtyAvail.Location = New System.Drawing.Point(13, 34)
        Me.EditMaterials_ProgramTotalQtyAvail.Name = "EditMaterials_ProgramTotalQtyAvail"
        Me.EditMaterials_ProgramTotalQtyAvail.Size = New System.Drawing.Size(93, 20)
        Me.EditMaterials_ProgramTotalQtyAvail.TabIndex = 0
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(10, 57)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(87, 13)
        Me.Label11.TabIndex = 3
        Me.Label11.Text = "Quantity Per Use"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(10, 20)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(119, 13)
        Me.Label10.TabIndex = 1
        Me.Label10.Text = "Total Quantity Available"
        '
        'EditMaterials_ButtonGroup
        '
        Me.EditMaterials_ButtonGroup.Controls.Add(Me.EditMaterials_PrintCompactCB)
        Me.EditMaterials_ButtonGroup.Controls.Add(Me.EditMaterials_PrintQty)
        Me.EditMaterials_ButtonGroup.Controls.Add(Me.EditMaterials_PrintButton)
        Me.EditMaterials_ButtonGroup.Controls.Add(Me.EditMaterials_DropItemButton)
        Me.EditMaterials_ButtonGroup.Controls.Add(Me.EditMaterials_SaveButton)
        Me.EditMaterials_ButtonGroup.Enabled = False
        Me.EditMaterials_ButtonGroup.Location = New System.Drawing.Point(455, 3)
        Me.EditMaterials_ButtonGroup.Name = "EditMaterials_ButtonGroup"
        Me.EditMaterials_ButtonGroup.Size = New System.Drawing.Size(92, 144)
        Me.EditMaterials_ButtonGroup.TabIndex = 10
        Me.EditMaterials_ButtonGroup.TabStop = False
        '
        'EditMaterials_PrintCompactCB
        '
        Me.EditMaterials_PrintCompactCB.AutoSize = True
        Me.EditMaterials_PrintCompactCB.Location = New System.Drawing.Point(7, 80)
        Me.EditMaterials_PrintCompactCB.Name = "EditMaterials_PrintCompactCB"
        Me.EditMaterials_PrintCompactCB.Size = New System.Drawing.Size(68, 17)
        Me.EditMaterials_PrintCompactCB.TabIndex = 51
        Me.EditMaterials_PrintCompactCB.Text = "Compact"
        Me.EditMaterials_PrintCompactCB.UseVisualStyleBackColor = True
        '
        'EditMaterials_PrintQty
        '
        Me.EditMaterials_PrintQty.Location = New System.Drawing.Point(59, 58)
        Me.EditMaterials_PrintQty.Maximum = New Decimal(New Integer() {9, 0, 0, 0})
        Me.EditMaterials_PrintQty.Name = "EditMaterials_PrintQty"
        Me.EditMaterials_PrintQty.Size = New System.Drawing.Size(28, 20)
        Me.EditMaterials_PrintQty.TabIndex = 48
        Me.EditMaterials_PrintQty.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'EditMaterials_PrintButton
        '
        Me.EditMaterials_PrintButton.Location = New System.Drawing.Point(6, 57)
        Me.EditMaterials_PrintButton.Name = "EditMaterials_PrintButton"
        Me.EditMaterials_PrintButton.Size = New System.Drawing.Size(49, 23)
        Me.EditMaterials_PrintButton.TabIndex = 47
        Me.EditMaterials_PrintButton.Text = "Print"
        Me.EditMaterials_PrintButton.UseVisualStyleBackColor = True
        '
        'EditMaterials_DropItemButton
        '
        Me.EditMaterials_DropItemButton.ForeColor = System.Drawing.Color.Firebrick
        Me.EditMaterials_DropItemButton.Location = New System.Drawing.Point(6, 111)
        Me.EditMaterials_DropItemButton.Name = "EditMaterials_DropItemButton"
        Me.EditMaterials_DropItemButton.Size = New System.Drawing.Size(81, 23)
        Me.EditMaterials_DropItemButton.TabIndex = 46
        Me.EditMaterials_DropItemButton.Text = "Remove"
        Me.WarningTooltip.SetToolTip(Me.EditMaterials_DropItemButton, "This action is permanent!" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "This unique reference number will not occur again unle" &
        "ss removed from history.")
        Me.EditMaterials_DropItemButton.UseVisualStyleBackColor = True
        '
        'EditMaterials_SaveButton
        '
        Me.EditMaterials_SaveButton.Location = New System.Drawing.Point(6, 16)
        Me.EditMaterials_SaveButton.Name = "EditMaterials_SaveButton"
        Me.EditMaterials_SaveButton.Size = New System.Drawing.Size(81, 23)
        Me.EditMaterials_SaveButton.TabIndex = 45
        Me.EditMaterials_SaveButton.Text = "Save"
        Me.EditMaterials_SaveButton.UseVisualStyleBackColor = True
        '
        'DGVAssignRefNum
        '
        Me.DGVAssignRefNum.AllowUserToAddRows = False
        Me.DGVAssignRefNum.AllowUserToDeleteRows = False
        Me.DGVAssignRefNum.AllowUserToResizeColumns = False
        Me.DGVAssignRefNum.AllowUserToResizeRows = False
        Me.DGVAssignRefNum.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGVAssignRefNum.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVAssignRefNum.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5})
        Me.DGVAssignRefNum.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGVAssignRefNum.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DGVAssignRefNum.Location = New System.Drawing.Point(3, 3)
        Me.DGVAssignRefNum.MultiSelect = False
        Me.DGVAssignRefNum.Name = "DGVAssignRefNum"
        Me.DGVAssignRefNum.ReadOnly = True
        Me.DGVAssignRefNum.RowHeadersVisible = False
        Me.DGVAssignRefNum.RowHeadersWidth = 102
        Me.DGVAssignRefNum.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGVAssignRefNum.ShowCellErrors = False
        Me.DGVAssignRefNum.ShowCellToolTips = False
        Me.DGVAssignRefNum.ShowEditingIcon = False
        Me.DGVAssignRefNum.ShowRowErrors = False
        Me.DGVAssignRefNum.Size = New System.Drawing.Size(675, 171)
        Me.DGVAssignRefNum.TabIndex = 6
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.FillWeight = 35.0!
        Me.DataGridViewTextBoxColumn1.HeaderText = "REF"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.HeaderText = "Desc"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.FillWeight = 60.0!
        Me.DataGridViewTextBoxColumn3.HeaderText = "P/N"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.FillWeight = 55.0!
        Me.DataGridViewTextBoxColumn4.HeaderText = "Lot"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.FillWeight = 50.0!
        Me.DataGridViewTextBoxColumn5.HeaderText = "Exp"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'CommonStockPage
        '
        Me.CommonStockPage.Controls.Add(Me.DGVCommonTable)
        Me.CommonStockPage.Location = New System.Drawing.Point(4, 22)
        Me.CommonStockPage.Margin = New System.Windows.Forms.Padding(1)
        Me.CommonStockPage.Name = "CommonStockPage"
        Me.CommonStockPage.Padding = New System.Windows.Forms.Padding(1)
        Me.CommonStockPage.Size = New System.Drawing.Size(681, 327)
        Me.CommonStockPage.TabIndex = 1
        Me.CommonStockPage.Text = "Common Stock"
        Me.CommonStockPage.UseVisualStyleBackColor = True
        '
        'DGVCommonTable
        '
        Me.DGVCommonTable.AllowUserToAddRows = False
        Me.DGVCommonTable.AllowUserToDeleteRows = False
        Me.DGVCommonTable.AllowUserToOrderColumns = True
        Me.DGVCommonTable.AllowUserToResizeColumns = False
        Me.DGVCommonTable.AllowUserToResizeRows = False
        Me.DGVCommonTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DGVCommonTable.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText
        Me.DGVCommonTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVCommonTable.ContextMenuStrip = Me.AnyStock_GridContextMenu
        Me.DGVCommonTable.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGVCommonTable.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DGVCommonTable.Location = New System.Drawing.Point(1, 1)
        Me.DGVCommonTable.Name = "DGVCommonTable"
        Me.DGVCommonTable.ReadOnly = True
        Me.DGVCommonTable.RowHeadersVisible = False
        Me.DGVCommonTable.RowHeadersWidth = 75
        Me.DGVCommonTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGVCommonTable.ShowCellErrors = False
        Me.DGVCommonTable.ShowCellToolTips = False
        Me.DGVCommonTable.ShowRowErrors = False
        Me.DGVCommonTable.Size = New System.Drawing.Size(679, 325)
        Me.DGVCommonTable.TabIndex = 11
        '
        'HistoryPage
        '
        Me.HistoryPage.Controls.Add(Me.DGVHistory)
        Me.HistoryPage.Location = New System.Drawing.Point(4, 22)
        Me.HistoryPage.Margin = New System.Windows.Forms.Padding(1)
        Me.HistoryPage.Name = "HistoryPage"
        Me.HistoryPage.Padding = New System.Windows.Forms.Padding(1)
        Me.HistoryPage.Size = New System.Drawing.Size(681, 327)
        Me.HistoryPage.TabIndex = 3
        Me.HistoryPage.Text = "History"
        Me.HistoryPage.UseVisualStyleBackColor = True
        '
        'AutoDescTab
        '
        Me.AutoDescTab.Controls.Add(Me.TableLayoutPanel6)
        Me.AutoDescTab.Location = New System.Drawing.Point(4, 22)
        Me.AutoDescTab.Name = "AutoDescTab"
        Me.AutoDescTab.Size = New System.Drawing.Size(681, 327)
        Me.AutoDescTab.TabIndex = 9
        Me.AutoDescTab.Text = "Part Descriptions"
        Me.AutoDescTab.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel6
        '
        Me.TableLayoutPanel6.ColumnCount = 1
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel6.Controls.Add(Me.Panel3, 0, 1)
        Me.TableLayoutPanel6.Controls.Add(Me.DGVAutoPart, 0, 0)
        Me.TableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel6.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel6.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel6.Name = "TableLayoutPanel6"
        Me.TableLayoutPanel6.RowCount = 2
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32.0!))
        Me.TableLayoutPanel6.Size = New System.Drawing.Size(681, 327)
        Me.TableLayoutPanel6.TabIndex = 0
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.AutoPart_SaveButton)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 295)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(681, 32)
        Me.Panel3.TabIndex = 0
        '
        'AutoPart_SaveButton
        '
        Me.AutoPart_SaveButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AutoPart_SaveButton.Location = New System.Drawing.Point(591, 5)
        Me.AutoPart_SaveButton.Name = "AutoPart_SaveButton"
        Me.AutoPart_SaveButton.Size = New System.Drawing.Size(75, 24)
        Me.AutoPart_SaveButton.TabIndex = 0
        Me.AutoPart_SaveButton.Text = "Save"
        Me.AutoPart_SaveButton.UseVisualStyleBackColor = True
        '
        'DGVAutoPart
        '
        Me.DGVAutoPart.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGVAutoPart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVAutoPart.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGVAutoPart.Location = New System.Drawing.Point(0, 0)
        Me.DGVAutoPart.Margin = New System.Windows.Forms.Padding(0)
        Me.DGVAutoPart.Name = "DGVAutoPart"
        Me.DGVAutoPart.Size = New System.Drawing.Size(681, 295)
        Me.DGVAutoPart.TabIndex = 1
        '
        'InfoTooltip
        '
        Me.InfoTooltip.AutoPopDelay = 15000
        Me.InfoTooltip.InitialDelay = 450
        Me.InfoTooltip.ReshowDelay = 100
        Me.InfoTooltip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.InfoTooltip.ToolTipTitle = "Information"
        '
        'MasterTabControl
        '
        Me.MasterTabControl.Controls.Add(Me.AutoRefPage)
        Me.MasterTabControl.Controls.Add(Me.RecordPage)
        Me.MasterTabControl.Controls.Add(Me.ManagementPage)
        Me.MasterTabControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MasterTabControl.Location = New System.Drawing.Point(0, 0)
        Me.MasterTabControl.Name = "MasterTabControl"
        Me.MasterTabControl.SelectedIndex = 0
        Me.MasterTabControl.Size = New System.Drawing.Size(699, 381)
        Me.MasterTabControl.TabIndex = 5
        Me.MasterTabControl.TabStop = False
        '
        'AutoRefPage
        '
        Me.AutoRefPage.Controls.Add(Me.TableLayoutPanel4)
        Me.AutoRefPage.Location = New System.Drawing.Point(4, 22)
        Me.AutoRefPage.Margin = New System.Windows.Forms.Padding(1)
        Me.AutoRefPage.Name = "AutoRefPage"
        Me.AutoRefPage.Padding = New System.Windows.Forms.Padding(1)
        Me.AutoRefPage.Size = New System.Drawing.Size(691, 355)
        Me.AutoRefPage.TabIndex = 5
        Me.AutoRefPage.Text = "Auto Reference"
        Me.AutoRefPage.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.ColumnCount = 5
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel4.Controls.Add(Me.BMS3306Radio, 4, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.DGVAutoRef, 0, 1)
        Me.TableLayoutPanel4.Controls.Add(Me.BMS3303Radio, 3, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.CommonStockRadio, 2, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.UserStockRadio, 0, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.ProgramStockRadio, 1, 0)
        Me.TableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(1, 1)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 2
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(689, 353)
        Me.TableLayoutPanel4.TabIndex = 0
        '
        'BMS3306Radio
        '
        Me.BMS3306Radio.AutoSize = True
        Me.BMS3306Radio.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BMS3306Radio.Location = New System.Drawing.Point(551, 3)
        Me.BMS3306Radio.Name = "BMS3306Radio"
        Me.BMS3306Radio.Padding = New System.Windows.Forms.Padding(32, 0, 0, 0)
        Me.BMS3306Radio.Size = New System.Drawing.Size(135, 18)
        Me.BMS3306Radio.TabIndex = 4
        Me.BMS3306Radio.Text = "BMS33.06"
        Me.BMS3306Radio.UseVisualStyleBackColor = True
        '
        'DGVAutoRef
        '
        Me.DGVAutoRef.AllowUserToAddRows = False
        Me.DGVAutoRef.AllowUserToDeleteRows = False
        Me.DGVAutoRef.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGVAutoRef.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVAutoRef.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ReferenceNumber, Me.PartDescription, Me.PartNumber, Me.LotNumber, Me.ExpirationDate, Me.CopyData, Me.QtyPerUse})
        Me.TableLayoutPanel4.SetColumnSpan(Me.DGVAutoRef, 5)
        Me.DGVAutoRef.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGVAutoRef.Location = New System.Drawing.Point(0, 24)
        Me.DGVAutoRef.Margin = New System.Windows.Forms.Padding(0)
        Me.DGVAutoRef.Name = "DGVAutoRef"
        Me.DGVAutoRef.RowTemplate.Height = 28
        Me.DGVAutoRef.Size = New System.Drawing.Size(689, 329)
        Me.DGVAutoRef.TabIndex = 1
        '
        'ReferenceNumber
        '
        Me.ReferenceNumber.FillWeight = 35.0!
        Me.ReferenceNumber.HeaderText = "REF"
        Me.ReferenceNumber.Name = "ReferenceNumber"
        Me.ReferenceNumber.ReadOnly = True
        '
        'PartDescription
        '
        Me.PartDescription.HeaderText = "Desc"
        Me.PartDescription.Name = "PartDescription"
        Me.PartDescription.ReadOnly = True
        '
        'PartNumber
        '
        Me.PartNumber.FillWeight = 60.0!
        Me.PartNumber.HeaderText = "P/N"
        Me.PartNumber.Name = "PartNumber"
        Me.PartNumber.ReadOnly = True
        '
        'LotNumber
        '
        Me.LotNumber.FillWeight = 55.0!
        Me.LotNumber.HeaderText = "LOT"
        Me.LotNumber.Name = "LotNumber"
        Me.LotNumber.ReadOnly = True
        '
        'ExpirationDate
        '
        Me.ExpirationDate.FillWeight = 50.0!
        Me.ExpirationDate.HeaderText = "EXP"
        Me.ExpirationDate.Name = "ExpirationDate"
        Me.ExpirationDate.ReadOnly = True
        '
        'CopyData
        '
        Me.CopyData.FillWeight = 35.0!
        Me.CopyData.HeaderText = ""
        Me.CopyData.Name = "CopyData"
        Me.CopyData.ReadOnly = True
        Me.CopyData.Text = ""
        '
        'QtyPerUse
        '
        Me.QtyPerUse.HeaderText = "QtyPerUse"
        Me.QtyPerUse.Name = "QtyPerUse"
        Me.QtyPerUse.ReadOnly = True
        Me.QtyPerUse.Visible = False
        '
        'BMS3303Radio
        '
        Me.BMS3303Radio.AutoSize = True
        Me.BMS3303Radio.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BMS3303Radio.Location = New System.Drawing.Point(414, 3)
        Me.BMS3303Radio.Name = "BMS3303Radio"
        Me.BMS3303Radio.Padding = New System.Windows.Forms.Padding(32, 0, 0, 0)
        Me.BMS3303Radio.Size = New System.Drawing.Size(131, 18)
        Me.BMS3303Radio.TabIndex = 3
        Me.BMS3303Radio.Text = "BMS33.03"
        Me.BMS3303Radio.UseVisualStyleBackColor = True
        '
        'CommonStockRadio
        '
        Me.CommonStockRadio.AutoSize = True
        Me.CommonStockRadio.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CommonStockRadio.Location = New System.Drawing.Point(277, 3)
        Me.CommonStockRadio.Name = "CommonStockRadio"
        Me.CommonStockRadio.Padding = New System.Windows.Forms.Padding(32, 0, 0, 0)
        Me.CommonStockRadio.Size = New System.Drawing.Size(131, 18)
        Me.CommonStockRadio.TabIndex = 2
        Me.CommonStockRadio.Text = "Common"
        Me.CommonStockRadio.UseVisualStyleBackColor = True
        '
        'UserStockRadio
        '
        Me.UserStockRadio.Checked = True
        Me.UserStockRadio.ContextMenuStrip = Me.AutoRefContextMenu
        Me.UserStockRadio.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UserStockRadio.Location = New System.Drawing.Point(3, 3)
        Me.UserStockRadio.Name = "UserStockRadio"
        Me.UserStockRadio.Padding = New System.Windows.Forms.Padding(32, 0, 0, 0)
        Me.UserStockRadio.Size = New System.Drawing.Size(131, 18)
        Me.UserStockRadio.TabIndex = 0
        Me.UserStockRadio.TabStop = True
        Me.UserStockRadio.Text = "User"
        Me.UserStockRadio.UseVisualStyleBackColor = True
        '
        'ProgramStockRadio
        '
        Me.ProgramStockRadio.AutoSize = True
        Me.ProgramStockRadio.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ProgramStockRadio.Location = New System.Drawing.Point(140, 3)
        Me.ProgramStockRadio.Name = "ProgramStockRadio"
        Me.ProgramStockRadio.Padding = New System.Windows.Forms.Padding(32, 0, 0, 0)
        Me.ProgramStockRadio.Size = New System.Drawing.Size(131, 18)
        Me.ProgramStockRadio.TabIndex = 1
        Me.ProgramStockRadio.Text = "Program"
        Me.ProgramStockRadio.UseVisualStyleBackColor = True
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink
        Me.ErrorProvider1.ContainerControl = Me
        '
        'WarningProvider1
        '
        Me.WarningProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink
        Me.WarningProvider1.ContainerControl = Me
        Me.WarningProvider1.Icon = CType(resources.GetObject("WarningProvider1.Icon"), System.Drawing.Icon)
        '
        'WarningTooltip
        '
        Me.WarningTooltip.AutoPopDelay = 10000
        Me.WarningTooltip.InitialDelay = 1
        Me.WarningTooltip.ReshowDelay = 100
        Me.WarningTooltip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Warning
        Me.WarningTooltip.ToolTipTitle = "Warning"
        '
        'ClearHistoryToolStripMenuItem
        '
        Me.ClearHistoryToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.History_ClearAllButton, Me.History_ClearSelectedButton})
        Me.ClearHistoryToolStripMenuItem.Name = "ClearHistoryToolStripMenuItem"
        Me.ClearHistoryToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ClearHistoryToolStripMenuItem.Text = "Clear History"
        '
        'History_ClearAllButton
        '
        Me.History_ClearAllButton.Name = "History_ClearAllButton"
        Me.History_ClearAllButton.Size = New System.Drawing.Size(180, 22)
        Me.History_ClearAllButton.Text = "All"
        '
        'History_ClearSelectedButton
        '
        Me.History_ClearSelectedButton.Name = "History_ClearSelectedButton"
        Me.History_ClearSelectedButton.Size = New System.Drawing.Size(180, 22)
        Me.History_ClearSelectedButton.Text = "Selection"
        '
        'InterfaceForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(699, 381)
        Me.Controls.Add(Me.MasterTabControl)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(715, 420)
        Me.Name = "InterfaceForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Limited Life Materials"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Utils_PrintGroup.ResumeLayout(False)
        Me.Utils_PrintGroup.PerformLayout()
        CType(Me.Utils_PrintQty, System.ComponentModel.ISupportInitialize).EndInit()
        Me.AutoRefGroup.ResumeLayout(False)
        Me.AutoRefGroup.PerformLayout()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.DGVHistory, System.ComponentModel.ISupportInitialize).EndInit()
        Me.History_GridContextMenu.ResumeLayout(False)
        Me.UserStockPage.ResumeLayout(False)
        CType(Me.DGVUserStock, System.ComponentModel.ISupportInitialize).EndInit()
        Me.AnyStock_GridContextMenu.ResumeLayout(False)
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.ManualTransferGroup.ResumeLayout(False)
        Me.ManualTransferGroup.PerformLayout()
        Me.ManualCheckInGroup.ResumeLayout(False)
        Me.ManualCheckInGroup.PerformLayout()
        Me.ProgramStockPage.ResumeLayout(False)
        CType(Me.DGVProgramStock, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.AutoRefContextMenu.ResumeLayout(False)
        Me.RecordPage.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DGVRefNum, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGVUtilities, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ManagementPage.ResumeLayout(False)
        Me.ManagementPageTabControl.ResumeLayout(False)
        Me.InvUtilsPage.ResumeLayout(False)
        Me.AddMaterialsTab.ResumeLayout(False)
        Me.FlowLayoutPanel3.ResumeLayout(False)
        Me.AddMaterials_MaterialInfoGroup.ResumeLayout(False)
        Me.AddMaterials_MaterialInfoGroup.PerformLayout()
        Me.AddMaterials_StockTypeGroup.ResumeLayout(False)
        Me.AddMaterials_StockTypeGroup.PerformLayout()
        Me.AddMaterials_ProgramCommonRefNumGroup.ResumeLayout(False)
        Me.AddMaterials_ProgramCommonRefNumGroup.PerformLayout()
        Me.AddMaterials_ProgramQtyAvailGroup.ResumeLayout(False)
        Me.AddMaterials_ProgramQtyAvailGroup.PerformLayout()
        CType(Me.AddMaterials_ProgramQtyPerUse, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AddMaterials_ProgramQtyAvailable, System.ComponentModel.ISupportInitialize).EndInit()
        Me.AddMaterials_UserStockGroup.ResumeLayout(False)
        Me.AddMaterials_UserStockGroup.PerformLayout()
        CType(Me.AddMaterials_UserQtyAvailable, System.ComponentModel.ISupportInitialize).EndInit()
        Me.AddMaterials_AddButtonGroup.ResumeLayout(False)
        Me.AddMaterials_AddButtonGroup.PerformLayout()
        Me.EditMaterialsTab.ResumeLayout(False)
        Me.TableLayoutPanel5.ResumeLayout(False)
        Me.FlowLayoutPanel2.ResumeLayout(False)
        Me.EditMaterials_MaterialInfoGroup.ResumeLayout(False)
        Me.EditMaterials_MaterialInfoGroup.PerformLayout()
        Me.EditMaterials_ProgramQtyGroup.ResumeLayout(False)
        Me.EditMaterials_ProgramQtyGroup.PerformLayout()
        CType(Me.EditMaterials_ProgramQtyPerUse, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EditMaterials_ProgramTotalQtyAvail, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EditMaterials_ButtonGroup.ResumeLayout(False)
        Me.EditMaterials_ButtonGroup.PerformLayout()
        CType(Me.EditMaterials_PrintQty, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGVAssignRefNum, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CommonStockPage.ResumeLayout(False)
        CType(Me.DGVCommonTable, System.ComponentModel.ISupportInitialize).EndInit()
        Me.HistoryPage.ResumeLayout(False)
        Me.AutoDescTab.ResumeLayout(False)
        Me.TableLayoutPanel6.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        CType(Me.DGVAutoPart, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MasterTabControl.ResumeLayout(False)
        Me.AutoRefPage.ResumeLayout(False)
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.TableLayoutPanel4.PerformLayout()
        CType(Me.DGVAutoRef, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WarningProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Utils_CheckInButton As Button
    Friend WithEvents InfoTooltip As ToolTip
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Utils_ShowSQLFormButton As Button
    Friend WithEvents Label16 As Label
    Friend WithEvents Utils_PrintGroup As GroupBox
    Friend WithEvents Utils_PrintCompact As CheckBox
    Friend WithEvents Utils_PrintButton As Button
    Friend WithEvents AutoRefGroup As GroupBox
    Friend WithEvents Utils_AutoRefTextBox As TextBox
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents Utils_RefNumTextbox As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Utils_CheckInUserCB As ComboBox
    Friend WithEvents DGVHistory As DataGridView
    Friend WithEvents UserStockPage As TabPage
    Friend WithEvents DGVUserStock As DataGridView
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents ManualTransferGroup As GroupBox
    Friend WithEvents Utils_CheckOutButton As Button
    Friend WithEvents Utils_CheckOutUserCB As ComboBox
    Friend WithEvents ManualCheckInGroup As GroupBox
    Friend WithEvents Label19 As Label
    Friend WithEvents ProgramStockPage As TabPage
    Friend WithEvents DGVProgramStock As DataGridView
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents AutoRef_SwitchUserCombo As ToolStripComboBox
    Friend WithEvents SwitchUserToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AutoRefContextMenu As ContextMenuStrip
    Friend WithEvents History_GridContextMenu As ContextMenuStrip
    Friend WithEvents RecordPage As TabPage
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents CheckInButton As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents RefNumInput As TextBox
    Friend WithEvents DGVUtilities As DataGridView
    Friend WithEvents ManagementPage As TabPage
    Friend WithEvents ManagementPageTabControl As TabControl
    Friend WithEvents CommonStockPage As TabPage
    Friend WithEvents DGVCommonTable As DataGridView
    Friend WithEvents HistoryPage As TabPage
    Friend WithEvents InvUtilsPage As TabPage
    Friend WithEvents MasterTabControl As TabControl
    Friend WithEvents AutoRefPage As TabPage
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents BMS3306Radio As RadioButton
    Friend WithEvents BMS3303Radio As RadioButton
    Friend WithEvents CommonStockRadio As RadioButton
    Friend WithEvents ProgramStockRadio As RadioButton
    Friend WithEvents UserStockRadio As RadioButton
    Friend WithEvents DGVAutoRef As DataGridView
    Friend WithEvents DGVRefNum As DataGridView
    Friend WithEvents ReferenceNumberRI As DataGridViewTextBoxColumn
    Friend WithEvents PartDescriptionRI As DataGridViewTextBoxColumn
    Friend WithEvents PartNumberRI As DataGridViewTextBoxColumn
    Friend WithEvents LotNumberRI As DataGridViewTextBoxColumn
    Friend WithEvents ExpirationDateRI As DataGridViewTextBoxColumn
    Friend WithEvents ReferenceNumber As DataGridViewTextBoxColumn
    Friend WithEvents PartDescription As DataGridViewTextBoxColumn
    Friend WithEvents PartNumber As DataGridViewTextBoxColumn
    Friend WithEvents LotNumber As DataGridViewTextBoxColumn
    Friend WithEvents ExpirationDate As DataGridViewTextBoxColumn
    Friend WithEvents CopyData As DataGridViewButtonColumn
    Friend WithEvents QtyPerUse As DataGridViewButtonColumn
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents WarningProvider1 As ErrorProvider
    Friend WithEvents AddMaterialsTab As TabPage
    Friend WithEvents AddMaterials_CompactLabelCheck As CheckBox
    Friend WithEvents AddMaterials_PrintLabelCB As CheckBox
    Friend WithEvents AddMaterials_NoExpDate As CheckBox
    Friend WithEvents SavePartDescButton As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents AddMaterials_PartDescription As TextBox
    Friend WithEvents AddMaterials_AddItemsButton As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents AddMaterials_ExpDate As DateTimePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents AddMaterials_LotNumber As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents AddMaterials_PartNumber As TextBox
    Friend WithEvents EditMaterialsTab As TabPage
    Friend WithEvents AddMaterials_ProgramCommonRefNumTextBox As TextBox
    Friend WithEvents DGVAssignRefNum As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TableLayoutPanel5 As TableLayoutPanel
    Friend WithEvents FlowLayoutPanel2 As FlowLayoutPanel
    Friend WithEvents EditMaterials_ProgramQtyGroup As GroupBox
    Friend WithEvents Label11 As Label
    Friend WithEvents EditMaterials_ProgramQtyPerUse As NumericUpDown
    Friend WithEvents Label10 As Label
    Friend WithEvents EditMaterials_ProgramTotalQtyAvail As NumericUpDown
    Friend WithEvents EditMaterials_ButtonGroup As GroupBox
    Friend WithEvents EditMaterials_SaveButton As Button
    Friend WithEvents EditMaterials_MaterialInfoGroup As GroupBox
    Friend WithEvents Label12 As Label
    Friend WithEvents EditMaterials_PartDescTB As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents EditMaterials_PartNumberTB As TextBox
    Friend WithEvents EditMaterials_DropItemButton As Button
    Friend WithEvents EditMaterials_ExpDatePicker As DateTimePicker
    Friend WithEvents EditMaterials_NoExpDateCB As CheckBox
    Friend WithEvents Label20 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents EditMaterials_LotBatchTB As TextBox
    Friend WithEvents EditMaterials_PrintQty As NumericUpDown
    Friend WithEvents EditMaterials_PrintButton As Button
    Friend WithEvents EditMaterials_PrintCompactCB As CheckBox
    Friend WithEvents AddMaterials_MaterialInfoGroup As GroupBox
    Friend WithEvents AddMaterials_StockTypeGroup As GroupBox
    Friend WithEvents AddMaterials_CommonStockTypeRadio As RadioButton
    Friend WithEvents AddMaterials_ProgramStockTypeRadio As RadioButton
    Friend WithEvents AddMaterials_UserStockTypeRadio As RadioButton
    Friend WithEvents FlowLayoutPanel3 As FlowLayoutPanel
    Friend WithEvents AddMaterials_ProgramCommonRefNumGroup As GroupBox
    Friend WithEvents AddMaterials_AddButtonGroup As GroupBox
    Friend WithEvents AddMaterials_UserStockGroup As GroupBox
    Friend WithEvents AddMaterials_UserRefNumbers As ListBox
    Friend WithEvents Label2 As Label
    Friend WithEvents AddMaterials_UserQtyAvailable As NumericUpDown
    Friend WithEvents AddMaterials_ProgramQtyAvailGroup As GroupBox
    Friend WithEvents Label6 As Label
    Friend WithEvents AddMaterials_ProgramQtyPerUse As NumericUpDown
    Friend WithEvents Label7 As Label
    Friend WithEvents AddMaterials_ProgramQtyAvailable As NumericUpDown
    Friend WithEvents Label9 As Label
    Friend WithEvents AnyStock_GridContextMenu As ContextMenuStrip
    Friend WithEvents EditItemInformationToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label13 As Label
    Friend WithEvents Utils_FinalCheckIn As CheckBox
    Friend WithEvents WarningTooltip As ToolTip
    Friend WithEvents Label14 As Label
    Friend WithEvents Utils_PrintQty As NumericUpDown
    Friend WithEvents Utils_ClearItemHistoryButton As Button
    Friend WithEvents AutoDescTab As TabPage
    Friend WithEvents TableLayoutPanel6 As TableLayoutPanel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents AutoPart_SaveButton As Button
    Friend WithEvents DGVAutoPart As DataGridView
    Friend WithEvents ExportToExcelToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents History_ExportAllButton As ToolStripMenuItem
    Friend WithEvents History_ExportSelectedButton As ToolStripMenuItem
    Friend WithEvents ClearHistoryToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents History_ClearAllButton As ToolStripMenuItem
    Friend WithEvents History_ClearSelectedButton As ToolStripMenuItem
End Class
