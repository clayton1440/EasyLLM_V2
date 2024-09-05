Imports System.Runtime.InteropServices

Public Class DynamicMessageBox
    Private TitleText As String = ""
    Private MessageText As String = ""
    'Private CheckBoxText As String = ""
    'Private ButtonType As MessageBoxButtons
    'Private CheckBoxValue As Boolean

    Public Const DARK_AUTO As Integer = 0
    Public Const DARK_DISABLE As Integer = 1
    Public Const DARK_ENABLE As Integer = 2

    Public Button1Text As String = ""
    Public Button1DialogResult As DialogResult = DialogResult.None
    Public Button2Text As String = ""
    Public Button2DialogResult As DialogResult = DialogResult.None
    Public Button3Text As String = ""
    Public Button3DialogResult As DialogResult = DialogResult.None
    Public Checkbox1Text As String = ""
    Public Checkbox1Checked As Boolean = False

    Public Sub New(Message As String, Optional Title As String = "", Optional DarkModeOverride As Integer = DARK_AUTO, Optional CenterPoint As Point = Nothing)

        MessageText = Message
        TitleText = Title

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        Select Case DarkModeOverride
            Case DARK_AUTO
                SwitchDarkMode(CheckDarkMode)
            Case DARK_ENABLE
                SwitchDarkMode(True)
            Case DARK_DISABLE
                'do nothing
            Case -1
                'do nothing
            Case Else 'auto
                SwitchDarkMode(CheckDarkMode)
        End Select

        Dim DisplayScale As Double = GetDisplayScale(Me)

        Dim TextSize As Size = TextRenderer.MeasureText(MessageText, Label1.Font)

        Me.Size = New Size(Math.Max(TextSize.Width + (96 * DisplayScale), Me.MinimumSize.Width), Math.Max(TextSize.Height + (176 * DisplayScale), Me.MinimumSize.Height))


        If CenterPoint <> Nothing Then
            Me.StartPosition = FormStartPosition.Manual
            Dim FormCornerPosition As Point = New Point(CenterPoint.X - (Me.Width / 2), CenterPoint.Y - (Me.Height / 2))
            Me.Location = FormCornerPosition
        End If

    End Sub
    Private Sub DynamicMessageBox_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        Me.Text = TitleText
        Label1.Text = MessageText


        If Not String.IsNullOrWhiteSpace(Checkbox1Text) Then
            CheckBox1.Visible = True
            CheckBox1.Text = Checkbox1Text
            CheckBox1.Checked = Checkbox1Checked
        End If

        If Not String.IsNullOrWhiteSpace(Button1Text) Then
            Button1.Visible = True
            Button1.Text = Button1Text
            Button1.DialogResult = Button1DialogResult
        End If

        If Not String.IsNullOrWhiteSpace(Button2Text) Then
            Button2.Visible = True
            Button2.Text = Button2Text
            Button2.DialogResult = Button2DialogResult
        End If

        If Not String.IsNullOrWhiteSpace(Button3Text) Then
            Button3.Visible = True
            Button3.Text = Button3Text
            Button3.DialogResult = Button3DialogResult
        End If

        If String.IsNullOrWhiteSpace(Button1Text) And String.IsNullOrWhiteSpace(Button2Text) And String.IsNullOrWhiteSpace(Button3Text) Then
            Button1.Visible = True
            Button1.Text = "OK"
            Button1.DialogResult = DialogResult.OK
        End If


    End Sub


    Public Function OptionChecked() As Boolean
        Return Checkbox1Checked
    End Function

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        Checkbox1Checked = CheckBox1.Checked
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.DialogResult = Button1.DialogResult
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.DialogResult = Button2.DialogResult
        Me.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.DialogResult = Button3.DialogResult
        Me.Close()
    End Sub

    Private Sub DynamicMessageBox_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown, TableLayoutPanel1.KeyDown, Label1.KeyDown, Button1.KeyDown, Button2.KeyDown, Button3.KeyDown, CheckBox1.KeyDown
        If e.KeyValue = Keys.Escape Then
            Me.DialogResult = DialogResult.Cancel
            Me.Close()
        End If
    End Sub

    Private Sub SwitchDarkMode(Enabled As Boolean)
        If Enabled Then
            DarkMode.UseImmersiveDarkMode(Handle, Enabled)
            Dim DarkFormBack As Color = Color.FromArgb(60, 58, 56)
            Dim DarkFormFore As Color = Color.WhiteSmoke
            Dim DarkButtonBack As Color = Color.FromArgb(68, 68, 68)

            Me.BackColor = DarkFormBack
            Me.ForeColor = DarkFormFore

            Button1.FlatStyle = FlatStyle.Flat
            Button1.BackColor = DarkButtonBack
            Button2.FlatStyle = FlatStyle.Flat
            Button2.BackColor = DarkButtonBack
            Button3.FlatStyle = FlatStyle.Flat
            Button3.BackColor = DarkButtonBack
        End If
    End Sub

    Public Shared Function GetDisplayScale(Form As Object) As Double
        Dim graphics As Graphics = Form.CreateGraphics()
        Dim DpiX As Single = graphics.DpiX
        Dim ScaleX As Double = DpiX / 96

        Return ScaleX

    End Function

    Shared Function GetCenterPoint(Form As Object) As Point
        If Form IsNot Nothing Then
            Dim CenterPoint As New Point(Form.Location.X + (Form.Width / 2), Form.Location.Y + (Form.Height / 2))
            Return CenterPoint
        Else
            'centerpoint of screen where mouse is
            Dim MousePosition As New Point(Cursor.Position.X, Cursor.Position.Y)
            Dim screen As Screen = Screen.FromPoint(MousePosition)
            Dim CenterPoint As New Point(screen.Bounds.X + (screen.Bounds.Width / 2), screen.Bounds.Y + (screen.Bounds.Height / 2))
            Return CenterPoint
        End If
    End Function

    Shared Function CheckDarkMode(Optional MachineOnly As Boolean = False) As Boolean
        Dim SystemLightMode = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\SOFTWARE\Microsoft\Windows\CurrentVersion\Themes\Personalize", "AppsUseLightTheme", True)


        If MachineOnly Then
            Return Not SystemLightMode
        Else
            Dim UserTheme As String = UserConfig.Theme
            If (UserTheme = "System" AndAlso Not SystemLightMode) OrElse UserTheme = "Dark" Then
                Return True
            Else
                Return False
            End If
        End If


    End Function
End Class

Public Class DarkMode
    <DllImport("dwmapi.dll")>
    Private Shared Function DwmSetWindowAttribute(hwnd As IntPtr, attr As Integer, ByRef attrValue As Integer, attrSize As Integer) As Integer
    End Function

    Private Const DWMWA_USE_IMMERSIVE_DARK_MODE_BEFORE_20H1 As Integer = 19
    Private Const DWMWA_USE_IMMERSIVE_DARK_MODE As Integer = 20


    Public Shared Function UseImmersiveDarkMode(FormHandle As IntPtr, enabled As Boolean) As Boolean
        If IsWindows10OrGreater(17763) Then
            Dim attribute As Integer = DWMWA_USE_IMMERSIVE_DARK_MODE_BEFORE_20H1
            If IsWindows10OrGreater(18985) Then
                attribute = DWMWA_USE_IMMERSIVE_DARK_MODE
            End If

            Dim ImmersiveDarkMode As Integer = If(enabled, 1, 0)
            Return DwmSetWindowAttribute(FormHandle, attribute, ImmersiveDarkMode, Marshal.SizeOf(GetType(Integer))) = 0
        Else
            Dim dm As New DynamicMessageBox("Failed Windows version threshold.",, DynamicMessageBox.DARK_DISABLE, DynamicMessageBox.GetCenterPoint(FormHandle))
            dm.ShowDialog()
            dm.Dispose()
        End If

        Return False
    End Function

    Private Shared Function IsWindows10OrGreater(Optional build As Integer = -1) As Boolean
        Return Environment.OSVersion.Version.Major >= 10 AndAlso Environment.OSVersion.Version.Build >= build
    End Function


    Public Shared Function IsSystemDarkMode() As Boolean
        Dim SystemLightMode = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\SOFTWARE\Microsoft\Windows\CurrentVersion\Themes\Personalize", "AppsUseLightTheme", True)
        Return Not SystemLightMode
    End Function
End Class