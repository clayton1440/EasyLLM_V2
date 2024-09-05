Public Class UserConfig
    Private Shared ConfigPath As String = $"C:\Users\{Environment.UserName}\AppData\Roaming\EasyLLM\EasyLLM.cfg"
    Public Shared Property DatabasePath As String
        Get
            Return ReadConfig("DatabasePath")
        End Get
        Set(value As String)
            SetConfig("DatabasePath", value)
        End Set
    End Property
    Public Shared Property Theme As String
        Get
            Return ReadConfig("Theme")
        End Get
        Set(value As String)
            SetConfig("Theme", value)
        End Set
    End Property

    Public Shared Property Printer As String
        Get
            Dim printerName As String = ReadConfig("Printer")
            If printerName = "" Then
                Dim pd As New PrintDialog
                If pd.ShowDialog = DialogResult.OK Then
                    printerName = pd.PrinterSettings.PrinterName
                    SetConfig("Printer", printerName)
                End If
            End If
            Return printerName
        End Get
        Set(value As String)
            SetConfig("Printer", value)
        End Set
    End Property

    Private Shared Function ReadConfig(key As String) As String
        If Not IO.Directory.Exists(ConfigPath.Substring(0, ConfigPath.LastIndexOf("\"))) Then
            IO.Directory.CreateDirectory(ConfigPath.Substring(0, ConfigPath.LastIndexOf("\")))
            IO.File.WriteAllText(ConfigPath, BlankConfig())
        End If

        If Not IO.File.Exists(ConfigPath) Then
            IO.File.WriteAllText(ConfigPath, BlankConfig())
        End If

        Dim ConfigLines As String() = IO.File.ReadAllLines(ConfigPath)

        For Each line In ConfigLines
            If line.StartsWith($"{key}=") Then
                Return line.Substring(line.IndexOf("=") + 1)
            End If
        Next

        Throw New Exception($"Key {key} was not found in the configuration.")
    End Function

    Private Shared Sub SetConfig(key As String, newvalue As String)
        If Not IO.Directory.Exists(ConfigPath.Substring(0, ConfigPath.LastIndexOf("\"))) Then
            IO.Directory.CreateDirectory(ConfigPath.Substring(0, ConfigPath.LastIndexOf("\")))
            IO.File.WriteAllText(ConfigPath, BlankConfig())
        End If
        If Not IO.File.Exists(ConfigPath) Then
            IO.File.WriteAllText(ConfigPath, BlankConfig())
        End If

        Dim ConfigLines As String() = IO.File.ReadAllLines(ConfigPath)
        For i = 0 To ConfigLines.Count - 1
            If ConfigLines(i).StartsWith($"{key}=") Then
                ConfigLines(i) = $"{key}={newvalue}"
                IO.File.WriteAllLines(ConfigPath, ConfigLines)
                Exit Sub
            End If
        Next

        Throw New Exception($"Key {key} was not found in the configuration.")
    End Sub
    Private Shared Function BlankConfig() As String
        Return $"DatabasePath={DefaultDatabasePath()}
Theme=Light
Printer="
    End Function
    Private Shared Function DefaultDatabasePath() As String
        Return System.Reflection.Assembly.GetExecutingAssembly.Location.Substring(0, System.Reflection.Assembly.GetExecutingAssembly.Location.LastIndexOf("\") + 1) & "EasyLLM.db"
    End Function
End Class