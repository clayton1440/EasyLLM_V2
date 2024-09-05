Imports System.Linq.Expressions

Public Class QuantityUsedForm

    Public Class UsedItem
        Public Property Quantity As Integer
        Public Property ShopOrder As String
    End Class

    Public Shared Function GetDisplayScale(Form As Object) As Double
        Dim graphics As Graphics = Form.CreateGraphics()
        Dim DpiX As Single = graphics.DpiX
        Dim ScaleX As Double = DpiX / 96

        Return ScaleX

    End Function
    Private Sub New(CenterOnForm As Form)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        Dim DisplayScale As Double = GetDisplayScale(Me)
        If CenterOnForm IsNot Nothing Then
            Me.StartPosition = FormStartPosition.Manual
            Me.Location = New Point(CenterOnForm.Location.X + (CenterOnForm.Width - Me.Width) / 2, CenterOnForm.Location.Y + (CenterOnForm.Height - Me.Height) / 2)
        Else
            Me.StartPosition = FormStartPosition.CenterScreen

        End If

    End Sub

    Public Shared Function GetQuantityUsed(CenterOnForm As Form) As UsedItem
        Dim qForm As New QuantityUsedForm(CenterOnForm)
        qForm.ShowDialog()
        If qForm.DialogResult = DialogResult.OK Then
            Dim UsedItem As New UsedItem
            UsedItem.Quantity = qForm.NumericUpDown1.Value
            UsedItem.ShopOrder = qForm.TextBox1.Text
            Return UsedItem
        Else
            Return Nothing
        End If
    End Function

    Private Sub OkButton_Click(sender As Object, e As EventArgs) Handles OkButton.Click
        If String.IsNullOrWhiteSpace(TextBox1.Text) Then
            ErrorProvider1.SetError(Label2, "Shop Order is required")
        Else
            DialogResult = DialogResult.OK
            Close()
        End If
    End Sub

    Private Sub CancelButton_Click(sender As Object, e As EventArgs) Handles CancelButton.Click
        DialogResult = DialogResult.Cancel
        Close()
    End Sub

    Private Sub NumericUpDown1_MouseWheel(sender As Object, e As HandledMouseEventArgs) Handles NumericUpDown1.MouseWheel
        Try
            e.Handled = True
            If e.Delta > 0 Then
                NumericUpDown1.UpButton()
            Else
                NumericUpDown1.DownButton()
            End If
        Catch ex As Exception
        End Try
    End Sub
End Class