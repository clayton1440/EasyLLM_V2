Imports Excel = Microsoft.Office.Interop.Excel
Public Class ExcelInterop

    ''' <summary>
    ''' Saves the embedded resource LLM_History.xltx to appdata, opens it, and inserts the values in the datatable starting in cell A1 of sheet History_PT. The workbook is displayed to the user.
    ''' </summary>
    ''' <param name="Datatable">History Datatable</param>
    Public Shared Sub OpenHistoryWorkbook(Datatable As DataTable)
        Dim WorkbookPath As String = $"C:\Users\{Environment.UserName}\AppData\Roaming\EasyLLM\LLM_History.xltx"

        'ensure template exists and is current
        If Not IO.File.Exists(WorkbookPath) OrElse IO.File.ReadAllBytes(WorkbookPath) IsNot My.Resources.LLM_History Then
            IO.Directory.CreateDirectory($"C:\Users\{Environment.UserName}\AppData\Roaming\EasyLLM")
            IO.File.WriteAllBytes(WorkbookPath, My.Resources.LLM_History)
        End If

        Dim ExcelApp As New Excel.Application
        Dim Workbook As Excel.Workbook = ExcelApp.Workbooks.Open(WorkbookPath)

        Dim Worksheet As Excel.Worksheet = Workbook.Sheets("History_PT")

        'insert column names
        For i = 0 To Datatable.Columns.Count - 1
            Worksheet.Cells(1, i + 1).Value = Datatable.Columns(i).ColumnName
        Next

        'insert data
        For i = 0 To Datatable.Rows.Count - 1
            For j = 0 To Datatable.Columns.Count - 1
                Worksheet.Cells(i + 2, j + 1).Value = Datatable.Rows(i)(j)
            Next
        Next

        'refresh built-in pivot table
        Dim HistoryPT As Excel.PivotTable = Worksheet.PivotTables(1)
        HistoryPT.RefreshTable()

        'filter the ShopOrder field in the pivottable to remove blanks
        Dim ShopOrderField As Excel.PivotField = HistoryPT.PivotFields("ShopOrder")
        ShopOrderField.PivotItems("(blank)").Visible = False

        'show excel
        ExcelApp.Visible = True

    End Sub
End Class
