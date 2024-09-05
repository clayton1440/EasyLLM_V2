Imports System.Data.SqlClient
Imports System.Data.SQLite

Public Class LLMDB



	Private Shared DbPath As String = UserConfig.DatabasePath
	Private Shared ConnectionString As String = $"Data Source={DbPath};Version=3;"

	Public Shared Sub Initialize()
		If Not IO.Directory.Exists(DbPath.Substring(0, DbPath.LastIndexOf("\"))) Then
			IO.Directory.CreateDirectory(DbPath.Substring(0, DbPath.LastIndexOf("\")))
		End If

		If Not IO.File.Exists(DbPath) Then
			Dim initCommand As String = My.Resources.DbInit
			Dim dmsg As New DynamicMessageBox("Database not found. EasyLLM will automatically create a new database.",, DynamicMessageBox.DARK_DISABLE, DynamicMessageBox.GetCenterPoint(Form.ActiveForm))
			dmsg.ShowDialog()
			initCommand = initCommand.Replace("@CurrentUser", Environment.UserName)
			ExecuteNonQuery(initCommand, True)
		End If
	End Sub

	''' <summary>
	''' Ensures the current user is present in the database.
	''' </summary>
	''' <returns>True or False depending on if the user is considered an Administrator.</returns>
	Public Shared Function UserLogin() As Boolean
		Initialize()
		Dim cmd0 As New SQLiteCommand
		cmd0.CommandText = "SELECT IsAdmin FROM Users WHERE Username = @Username;"
		cmd0.Parameters.AddWithValue("@Username", Environment.UserName)

		Dim IsAdmin As Boolean = ExecuteScalar(cmd0)

		Dim cmd As New SQLiteCommand
		cmd.CommandText = "DELETE FROM Users WHERE Username = @Username;"
		cmd.Parameters.AddWithValue("@Username", Environment.UserName)

		ExecuteNonQuery(cmd)

		Dim cmd1 As New SQLiteCommand
		cmd1.CommandText = $"INSERT INTO Users (Username, IsAdmin) VALUES (@Username, {If(IsAdmin, "1", "0")});"
		cmd1.Parameters.AddWithValue("@Username", Environment.UserName)

		ExecuteNonQuery(cmd1)
		Return IsAdmin
	End Function

	Public Shared Function GetUsers() As List(Of String)
		Dim cmd As New SQLiteCommand
		cmd.CommandText = "SELECT Username FROM Users ORDER BY Username ASC;"
		Dim dt As DataTable = ExecuteReader(cmd)
		Dim ReturnList As New List(Of String)

		For Each row As DataRow In dt.Rows
			ReturnList.Add(row("Username"))
		Next

		Return ReturnList
	End Function

	Public Shared Function ExecuteReader(SqlCommand As SQLiteCommand) As DataTable
		Initialize()
		Dim conn As New SQLiteConnection(ConnectionString, True)
		Dim dbquery As SQLiteCommand = SqlCommand
		Dim ReturnTable As New DataTable
		dbquery.Connection = conn

		Try
			conn.Open()
			ReturnTable.Load(dbquery.ExecuteReader)
			conn.Close()
		Catch ex As Exception
			conn.Close()
			Throw New Exception($"SOAReDB reported a query error: {ex.Message}", ex)
		End Try

		conn.Dispose()
		dbquery.Dispose()

		Return ReturnTable
	End Function
	Public Shared Function ExecuteNonQuery(SQLCommand As SQLiteCommand) As Integer
		Initialize()
		Dim conn As New SQLiteConnection(ConnectionString, True)
		Dim dbquery As SQLiteCommand = SQLCommand
		dbquery.Connection = conn

		Dim RU As Integer

		Try
			conn.Open()
			RU = dbquery.ExecuteNonQuery
			conn.Close()
		Catch ex As Exception
			conn.Close()
			Throw New Exception($"SOAReDB reported a query error: {ex.Message}", ex)
		End Try

		conn.Dispose()
		dbquery.Dispose()

		Return RU
	End Function

	Public Shared Function ExecuteScalar(SQLCommand As SQLiteCommand) As Object
		Initialize()
		Dim conn As New SQLiteConnection(ConnectionString, True)
		Dim dbquery As SQLiteCommand = SQLCommand
		dbquery.Connection = conn

		Dim RU As Object

		Try
			conn.Open()
			RU = dbquery.ExecuteScalar
			conn.Close()
		Catch ex As Exception
			conn.Close()
			Throw New Exception($"SOAReDB reported a query error: {ex.Message}", ex)
		End Try

		conn.Dispose()
		dbquery.Dispose()

		Return RU
	End Function

	Public Shared Function ExecuteReader(SQLCommandString As String) As DataTable
		Initialize()
		Dim conn As New SQLiteConnection(ConnectionString, True)
		Dim dbquery As New SQLiteCommand
		Dim ReturnTable As New DataTable
		dbquery.Connection = conn
		dbquery.CommandText = SQLCommandString

		Try
			conn.Open()
			ReturnTable.Load(dbquery.ExecuteReader)
			conn.Close()
		Catch ex As Exception
			conn.Close()
		End Try

		conn.Dispose()
		dbquery.Dispose()

		Return ReturnTable
	End Function

	Public Shared Function ExecuteNonQuery(SQLCommandString As String, Optional AvoidRecursion As Boolean = False) As String
		If Not AvoidRecursion Then Initialize()
		Dim conn As New SQLiteConnection(ConnectionString, True)
		Dim dbquery As New SQLiteCommand
		dbquery.Connection = conn
		dbquery.CommandText = SQLCommandString

		Dim RU As Integer = 0

		Try
			conn.Open()
			RU = dbquery.ExecuteNonQuery
			conn.Close()
		Catch ex As Exception
			conn.Close()
		End Try

		conn.Dispose()
		dbquery.Dispose()

		Return RU.ToString
	End Function

	Public Shared Function ExecuteScalar(SQLCommandString As String) As Object
		Initialize()
		Dim conn As New SQLiteConnection(ConnectionString, True)
		Dim dbquery As New SQLiteCommand
		dbquery.Connection = conn
		dbquery.CommandText = SQLCommandString

		Dim RU As Object = Nothing

		Try
			conn.Open()
			RU = dbquery.ExecuteScalar
			conn.Close()
		Catch ex As Exception
			conn.Close()
		End Try

		conn.Dispose()
		dbquery.Dispose()

		Return RU
	End Function


	Public Class Item
		Public Property ReferenceNumber As Integer
		Public Property PartNumber As String
		Public Property PartDescription As String
		Public Property LotNumber As String
		Public Property ExpirationDate As Date
		Public Property IsCommonStock As Boolean
		Public ReadOnly Property IsProgramStock As Boolean
			Get
				Return IncrementalQuantity <> Nothing
			End Get
		End Property

		''' <summary>
		''' Returns the fractional quantity of the item that is used per use.
		''' </summary>
		''' <remarks>
		''' This quantity is decremented from <strong>QuantityRemaining</strong> each time a unit of the item is used.
		''' </remarks>
		Public Property IncrementalQuantity As Double

		''' <summary>
		''' Returns the remaining quantity of the item in stock.
		''' </summary>
		''' <remarks>
		''' This quantity is decremented by <strong>IncrementalQuantity</strong> each time a unit of the item is used.
		''' </remarks>
		Public Property QuantityRemaining As Double

		''' <summary>
		''' Returns <strong>True</strong> if the item's <strong>ReferenceNumber</strong> is present in table <strong>UserStock</strong>.
		''' </summary>
		Public Property IsUserStock As Boolean

		''' <summary>
		''' Returns <strong>True</strong> if the item is checked out by a user.
		''' </summary>
		''' <remarks>
		''' This property is cast from <strong>CheckedOutUser</strong> and is <strong>ReadOnly</strong>.
		''' </remarks>
		Public ReadOnly Property IsCheckedOut As Boolean
			Get
				Return Not String.IsNullOrWhiteSpace(CheckedOutUser)
			End Get
		End Property
		Public Property CheckedOutUser As String
		Public Property CheckOutTimestamp As DateTime

		Public Function ToTable() As DataTable
			Dim dt As New DataTable
			dt.Columns.Add("ReferenceNumber", GetType(Integer))
			dt.Columns.Add("PartNumber", GetType(String))
			dt.Columns.Add("PartDescription", GetType(String))
			dt.Columns.Add("LotNumber", GetType(String))
			dt.Columns.Add("ExpirationDate", GetType(Date))
			dt.Columns.Add("IncrementalQuantity", GetType(Double))
			dt.Columns.Add("QuantityRemaining", GetType(Double))
			dt.Columns.Add("IsCommonStock", GetType(Boolean))
			dt.Columns.Add("IsProgramStock", GetType(Boolean))
			dt.Columns.Add("IsUserStock", GetType(Boolean))
			dt.Columns.Add("IsCheckedOut", GetType(Boolean))
			dt.Columns.Add("CheckedOutUser", GetType(String))
			dt.Columns.Add("CheckOutTimestamp", GetType(DateTime))

			Dim row As DataRow = dt.NewRow
			row("ReferenceNumber") = ReferenceNumber
			row("PartNumber") = PartNumber
			row("PartDescription") = PartDescription
			row("LotNumber") = LotNumber
			row("ExpirationDate") = ExpirationDate.ToString("yyyy-MM-dd")
			row("IncrementalQuantity") = IncrementalQuantity
			row("QuantityRemaining") = QuantityRemaining
			row("IsCommonStock") = IsCommonStock
			row("IsProgramStock") = IsProgramStock
			row("IsUserStock") = IsUserStock
			row("IsCheckedOut") = IsCheckedOut
			row("CheckedOutUser") = CheckedOutUser
			row("CheckOutTimestamp") = CheckOutTimestamp.ToLocalTime
			dt.Rows.Add(row)

			Return dt
		End Function
	End Class


	Public Shared Function GetMaterials() As DataTable
		Dim cmd As New SQLiteCommand
		cmd.CommandText = "SELECT * FROM Materials ORDER BY PartNumber;"
		Return ExecuteReader(cmd)
	End Function

	Public Shared Function GetHistory() As DataTable
		Dim cmd As New SQLiteCommand
		cmd.CommandText = "SELECT * FROM UsageHist;"
		Return ExecuteReader(cmd)
	End Function

	Public Shared Function ItemHasHistory(ReferenceNumber As Integer) As Boolean
		Dim cmd As New SQLiteCommand
		cmd.CommandText = "SELECT COUNT(ReferenceNumber) AS itemCount FROM UsageHist WHERE ReferenceNumber = @ReferenceNumber;"
		cmd.Parameters.AddWithValue("@ReferenceNumber", ReferenceNumber)
		Return CInt(ExecuteScalar(cmd)) > 0
	End Function

	Public Shared Sub ClearHistory()
		Dim cmd As New SQLiteCommand
		cmd.CommandText = "DELETE FROM UsageHist;"
		ExecuteNonQuery(cmd)
	End Sub

	Public Shared Sub ClearHistory(ItemID As Integer)
		Dim cmd As New SQLiteCommand
		cmd.CommandText = "DELETE FROM UsageHist WHERE UID = @ItemID;"
		cmd.Parameters.AddWithValue("@ItemID", ItemID)
		ExecuteNonQuery(cmd)
	End Sub

	Public Shared Sub ClearItemHistory(ReferenceNumber As Integer)
		Dim cmd As New SQLiteCommand
		cmd.CommandText = "DELETE FROM UsageHist WHERE ReferenceNumber = @ReferenceNumber;"
		cmd.Parameters.AddWithValue("@ReferenceNumber", ReferenceNumber)
		ExecuteNonQuery(cmd)
	End Sub

	Public Shared Function GetItemByRef(ReferenceNumber As Integer) As Item
		Dim cmd As New SQLiteCommand
		cmd.CommandText = "
    SELECT 
        m.ReferenceNumber, 
        m.PartNumber, 
        m.PartDescription, 
        m.LotNumber, 
        m.ExpirationDate,
        CASE WHEN ps.QtyPerUse IS NOT NULL THEN ps.QtyPerUse ELSE NULL END AS IncrementalQuantity,
        CASE WHEN ps.QtyRemaining IS NOT NULL THEN ps.QtyRemaining ELSE NULL END AS QuantityRemaining,
        CASE WHEN us.ReferenceNumber IS NOT NULL THEN 1 ELSE 0 END AS CanCheckOut,
		CASE WHEN cs.ReferenceNumber IS NOT NULL THEN 1 ELSE 0 END AS IsCommonStock,
        CASE WHEN us.CheckedOutUser IS NOT NULL THEN us.CheckedOutUser ELSE NULL END AS CheckedOutUser,
        CASE WHEN us.CheckedOutTimestamp IS NOT NULL THEN us.CheckedOutTimestamp ELSE NULL END AS CheckOutTimestamp
    FROM 
        Materials m
    LEFT JOIN 
        ProgramStock ps ON m.ReferenceNumber = ps.ReferenceNumber
    LEFT JOIN 
        UserStock us ON m.ReferenceNumber = us.ReferenceNumber
    LEFT JOIN
        CommonStock cs ON m.ReferenceNumber = cs.ReferenceNumber
    WHERE 
        m.ReferenceNumber = @RefNum;
    "
		cmd.Parameters.AddWithValue("@RefNum", ReferenceNumber)

		Dim dt As DataTable = ExecuteReader(cmd)
		If dt.Rows.Count > 0 Then
			Dim row = dt.Rows(0)
			Return New Item With {
			.ReferenceNumber = row("ReferenceNumber"),
			.PartNumber = row("PartNumber"),
			.PartDescription = row("PartDescription"),
			.LotNumber = row("LotNumber"),
			.ExpirationDate = If(row("ExpirationDate") Is DBNull.Value, Nothing, row("ExpirationDate")),
			.IncrementalQuantity = If(row("IncrementalQuantity") Is DBNull.Value, Nothing, row("IncrementalQuantity")),
			.QuantityRemaining = If(row("QuantityRemaining") Is DBNull.Value, Nothing, row("QuantityRemaining")),
			.IsUserStock = row("CanCheckOut"),
			.IsCommonStock = row("IsCommonStock"),
			.CheckedOutUser = If(row("CheckedOutUser") Is DBNull.Value, Nothing, row("CheckedOutUser")),
			.CheckOutTimestamp = If(row("CheckOutTimestamp") Is DBNull.Value, Nothing, row("CheckOutTimestamp"))
		}
		Else
			Return Nothing ' or throw an exception if the item does not exist
		End If
	End Function

	Public Shared Function GetUserStock(UserName As String) As List(Of Item)
		Dim cmd As New SQLiteCommand
		cmd.CommandText = "SELECT DISTINCT
	us.ReferenceNumber,
	m.PartNumber,
	m.PartDescription,
	m.LotNumber,
	m.ExpirationDate,
	m.DisplayAutoRef
FROM 
	UserStock us
JOIN 
	Materials m ON us.ReferenceNumber = m.ReferenceNumber
WHERE 
	us.CheckedOutUser = @User1
	AND (m.ExpirationDate IS NULL OR m.ExpirationDate >= DATE('now'))
	AND m.DisplayAutoRef = 1
	AND us.ReferenceNumber NOT IN (
		SELECT ReferenceNumber 
		FROM UsageHist 
		WHERE IsFinalCheckIn = 1 AND Username = @User2
	)
ORDER BY 
	m.PartNumber;"
		cmd.Parameters.AddWithValue("@User1", UserName)
		cmd.Parameters.AddWithValue("@User2", UserName)

		Dim dt As DataTable = ExecuteReader(cmd)
		Dim ReturnList As New List(Of Item)

		For Each row As DataRow In dt.Rows
			Dim i As New Item
			i.ReferenceNumber = row("ReferenceNumber")
			i.PartNumber = row("PartNumber")
			i.PartDescription = row("PartDescription")
			i.LotNumber = row("LotNumber")
			i.ExpirationDate = If(row("ExpirationDate") Is DBNull.Value, Nothing, row("ExpirationDate"))
			ReturnList.Add(i)
		Next

		Return ReturnList
	End Function

	Public Shared Function GetUserStock_All() As DataTable
		Dim cmd As New SQLiteCommand
		cmd.CommandText = "SELECT DISTINCT
	us.ReferenceNumber,
	m.PartNumber,
	m.PartDescription,
	m.LotNumber,
	m.ExpirationDate,
	us.CheckedOutUser,
    us.CheckedOutTimestamp,
    CASE WHEN us.CheckedOutUser IS NOT NULL THEN 1 ELSE 0 END AS IsCheckedOut,
    CASE WHEN EXISTS (SELECT 1 FROM UsageHist WHERE ReferenceNumber = us.ReferenceNumber AND IsFinalCheckIn = 1) THEN 1 ELSE 0 END AS IsCheckedIn
FROM 
	UserStock us
JOIN 
	Materials m ON us.ReferenceNumber = m.ReferenceNumber
ORDER BY 
	m.PartNumber;"

		Return ExecuteReader(cmd)
	End Function


	Public Shared Function GetProgramStock() As List(Of Item)
		Dim cmd As New SQLiteCommand
		cmd.CommandText = "SELECT DISTINCT
	m.ReferenceNumber, 
	m.PartNumber, 
	m.PartDescription, 
	m.LotNumber, 
	m.ExpirationDate, 
	ps.QtyPerUse,
	ps.QtyRemaining
FROM
	Materials m
JOIN
	ProgramStock ps ON m.ReferenceNumber = ps.ReferenceNumber
WHERE
	m.DisplayAutoRef = 1
	AND ps.QtyRemaining > 0
	AND (m.ExpirationDate IS NULL OR m.ExpirationDate >= DATE('now'))
ORDER BY
	m.PartNumber;"

		Dim dt As DataTable = ExecuteReader(cmd)
		Dim ReturnList As New List(Of Item)

		For Each row As DataRow In dt.Rows
			Dim i As New Item
			i.ReferenceNumber = row("ReferenceNumber")
			i.PartNumber = row("PartNumber")
			i.PartDescription = row("PartDescription")
			i.LotNumber = row("LotNumber")
			i.ExpirationDate = If(row("ExpirationDate") Is DBNull.Value, Nothing, row("ExpirationDate"))
			i.IncrementalQuantity = row("QtyPerUse")
			i.QuantityRemaining = row("QtyRemaining")
			ReturnList.Add(i)
		Next

		Return ReturnList

	End Function

	Public Shared Function GetProgramStock_All() As DataTable
		Dim cmd As New SQLiteCommand
		cmd.CommandText = "SELECT DISTINCT
	m.ReferenceNumber, 
	m.PartNumber, 
	m.PartDescription, 
	m.LotNumber, 
	m.ExpirationDate, 
	ps.QtyPerUse,
	ps.QtyRemaining
FROM
	Materials m
JOIN
	ProgramStock ps ON m.ReferenceNumber = ps.ReferenceNumber
ORDER BY
	m.PartNumber;"

		Return ExecuteReader(cmd)
	End Function

	Public Shared Function GetCommonStock() As List(Of Item)
		Dim cmd As New SQLiteCommand
		cmd.CommandText = "SELECT DISTINCT
	m.ReferenceNumber, 
	m.PartNumber, 
	m.PartDescription, 
	m.LotNumber, 
	m.ExpirationDate
FROM
	Materials m
JOIN
	CommonStock cs ON m.ReferenceNumber = cs.ReferenceNumber
WHERE
	m.DisplayAutoRef = 1
	AND (m.ExpirationDate IS NULL OR m.ExpirationDate >= DATE('now'))
	AND NOT m.PartNumber LIKE 'BMS%'
ORDER BY
	m.PartNumber;"

		Dim dt As DataTable = ExecuteReader(cmd)
		Dim ReturnList As New List(Of Item)

		For Each row As DataRow In dt.Rows
			Dim i As New Item
			i.ReferenceNumber = row("ReferenceNumber")
			i.PartNumber = row("PartNumber")
			i.PartDescription = row("PartDescription")
			i.LotNumber = row("LotNumber")
			i.ExpirationDate = If(row("ExpirationDate") Is DBNull.Value, Nothing, row("ExpirationDate"))
			ReturnList.Add(i)
		Next

		Return ReturnList

	End Function

	Public Shared Function GetCommonStock_All() As DataTable
		Dim cmd As New SQLiteCommand
		cmd.CommandText = "SELECT DISTINCT
	m.ReferenceNumber, 
	m.PartNumber, 
	m.PartDescription, 
	m.LotNumber, 
	m.ExpirationDate
FROM
	Materials m
JOIN
	CommonStock cs ON m.ReferenceNumber = cs.ReferenceNumber
ORDER BY
	m.PartNumber;"

		Return ExecuteReader(cmd)

	End Function

	Public Shared Function GetBMS3303Stock() As List(Of Item)
		Dim cmd As New SQLiteCommand
		cmd.CommandText = "SELECT DISTINCT
	m.ReferenceNumber, 
	m.PartNumber, 
	m.PartDescription, 
	m.LotNumber, 
	m.ExpirationDate
FROM
	Materials m
JOIN
	CommonStock cs ON m.ReferenceNumber = cs.ReferenceNumber
WHERE
	m.DisplayAutoRef = 1
	AND (m.ExpirationDate IS NULL OR m.ExpirationDate >= DATE('now'))
	AND m.PartNumber LIKE 'BMS33.03%'
ORDER BY
	m.PartNumber;"

		Dim dt As DataTable = ExecuteReader(cmd)
		Dim ReturnList As New List(Of Item)

		For Each row As DataRow In dt.Rows
			Dim i As New Item
			i.ReferenceNumber = row("ReferenceNumber")
			i.PartNumber = row("PartNumber")
			i.PartDescription = row("PartDescription")
			i.LotNumber = row("LotNumber")
			i.ExpirationDate = If(row("ExpirationDate") Is DBNull.Value, Nothing, row("ExpirationDate"))
			ReturnList.Add(i)
		Next

		Return ReturnList
	End Function

	Public Shared Function GetBMS3306Stock() As List(Of Item)
		Dim cmd As New SQLiteCommand
		cmd.CommandText = "SELECT DISTINCT
	m.ReferenceNumber, 
	m.PartNumber, 
	m.PartDescription, 
	m.LotNumber, 
	m.ExpirationDate
FROM
	Materials m
JOIN
	CommonStock cs ON m.ReferenceNumber = cs.ReferenceNumber
WHERE
	m.DisplayAutoRef = 1
	AND (m.ExpirationDate IS NULL OR m.ExpirationDate >= DATE('now'))
	AND m.PartNumber LIKE 'BMS33.06%'
ORDER BY
	m.PartNumber;"

		Dim dt As DataTable = ExecuteReader(cmd)
		Dim ReturnList As New List(Of Item)

		For Each row As DataRow In dt.Rows
			Dim i As New Item
			i.ReferenceNumber = row("ReferenceNumber")
			i.PartNumber = row("PartNumber")
			i.PartDescription = row("PartDescription")
			i.LotNumber = row("LotNumber")
			i.ExpirationDate = If(row("ExpirationDate") Is DBNull.Value, Nothing, row("ExpirationDate"))
			ReturnList.Add(i)
		Next

		Return ReturnList
	End Function



	''' <summary>
	''' Generates a unique reference number for a new item.
	''' </summary>
	''' <param name="MaxValue">The maximum value for any reference number generated. Default 89999</param>
	''' <returns>A randomly generated integer between 10010 and MaxValue</returns>
	Public Shared Function CreateReferenceNumber(Optional MaxValue As Integer = 89999, Optional ExistingList As List(Of Integer) = Nothing) As Integer
		Dim FoundUnique As Boolean = False
		Dim ReferenceNumber As Integer = 0

		If ExistingList Is Nothing Then ExistingList = New List(Of Integer)

		Do Until FoundUnique
			ReferenceNumber = New Random().Next(10010, MaxValue)
			If ExistingList.Contains(ReferenceNumber) Then Continue Do
			Dim cmd As New SQLiteCommand
			cmd.CommandText = "SELECT COUNT(*) AS occurrence_count
FROM (
    SELECT ReferenceNumber 
    FROM Materials 
    WHERE ReferenceNumber = @RefNum
    
    UNION ALL
    
    SELECT ReferenceNumber 
    FROM UsageHist 
    WHERE ReferenceNumber = @RefNum1
) AS combined_results;"
			cmd.Parameters.AddWithValue("@RefNum", ReferenceNumber)
			cmd.Parameters.AddWithValue("@RefNum1", ReferenceNumber)

			If ExecuteScalar(cmd) = 0 Then
				FoundUnique = True
			End If
		Loop

		Return ReferenceNumber
	End Function

	Public Shared Function GetPartDescription(PartNumber As String) As String
		Dim cmd As New SQLiteCommand
		cmd.CommandText = "SELECT PartDescription FROM AutoPart WHERE PartNumber = @PartNum;"
		cmd.Parameters.AddWithValue("@PartNum", PartNumber)

		Return ExecuteScalar(cmd)
	End Function

	Public Shared Function GetPartDescriptions() As DataTable
		Dim cmd As New SQLiteCommand
		cmd.CommandText = "SELECT PartNumber, PartDescription FROM AutoPart ORDER BY PartNumber ASC;"

		Return ExecuteReader(cmd)
	End Function

	Public Shared Sub SetPartDescription(PartNumber As String, PartDescription As String)
		Dim cmd As New SQLiteCommand
		cmd.CommandText = "INSERT OR REPLACE INTO AutoPart (PartNumber, PartDescription) VALUES (@PartNum, @PartDesc);"
		cmd.Parameters.AddWithValue("@PartDesc", PartDescription)
		cmd.Parameters.AddWithValue("@PartNum", PartNumber)

		ExecuteNonQuery(cmd)
	End Sub

	Public Shared Sub SetPartDescriptions(AutoPartTable As DataTable)
		For Each row As DataRow In AutoPartTable.Rows
			Dim cmd As New SQLiteCommand
			cmd.CommandText = "INSERT OR REPLACE INTO AutoPart (PartNumber, PartDescription) VALUES (@PartNum, @PartDesc);"
			cmd.Parameters.Clear()
			cmd.Parameters.AddWithValue("@PartNum", row("PartNumber"))
			cmd.Parameters.AddWithValue("@PartDesc", row("PartDescription"))
			ExecuteNonQuery(cmd)
		Next
	End Sub

	Public Shared Function AddOrReplaceItem(ReferenceNumber As Integer, PartNumber As String, PartDescription As String, LotNumber As String, ExpirationDate As Date) As Boolean
		Dim cmd As New SQLiteCommand
		cmd.CommandText = "INSERT OR REPLACE INTO Materials (ReferenceNumber, PartNumber, PartDescription, LotNumber, ExpirationDate) VALUES (@RefNum, @PartNum, @PartDesc, @LotNum, @ExpDate);"
		cmd.Parameters.AddWithValue("@RefNum", ReferenceNumber)
		cmd.Parameters.AddWithValue("@PartNum", PartNumber)
		cmd.Parameters.AddWithValue("@PartDesc", PartDescription)
		cmd.Parameters.AddWithValue("@LotNum", LotNumber)
		cmd.Parameters.AddWithValue("@ExpDate", If(ExpirationDate <> Nothing, ExpirationDate.ToString("yyyy-MM-dd"), Nothing))

		Return ExecuteNonQuery(cmd) > 0
	End Function

	Public Shared Function UpdateMaterialInformation(OldItemInfo As LLMDB.Item, NewPartNumber As String, NewPartDescription As String, NewLotNumber As String, NewExpDate As Date) As Boolean
		Dim cmd As New SQLiteCommand
		cmd.CommandText = "UPDATE Materials SET PartNumber = @NewPartNum, PartDescription = @NewPartDesc, LotNumber = @NewLotNum, ExpirationDate = @NewExpDate WHERE LotNumber = @OldLotNumber;"
		cmd.Parameters.AddWithValue("@NewPartNum", NewPartNumber)
		cmd.Parameters.AddWithValue("@NewPartDesc", NewPartDescription)
		cmd.Parameters.AddWithValue("@NewLotNum", NewLotNumber)
		cmd.Parameters.AddWithValue("@NewExpDate", If(NewExpDate <> Nothing, NewExpDate.ToString("yyyy-MM-dd"), Nothing))
		cmd.Parameters.AddWithValue("@OldLotNumber", OldItemInfo.LotNumber)

		Return ExecuteNonQuery(cmd) > 0
	End Function

	Public Shared Function DropItem(ReferenceNumber As Integer) As Boolean
		Dim cmd As New SQLiteCommand
		cmd.CommandText = "DELETE FROM CommonStock WHERE ReferenceNumber = @RefNum;"
		cmd.Parameters.AddWithValue("@RefNum", ReferenceNumber)

		ExecuteNonQuery(cmd)

		Dim cmd1 As New SQLiteCommand
		cmd1.CommandText = "DELETE FROM ProgramStock WHERE ReferenceNumber = @RefNum;"
		cmd1.Parameters.AddWithValue("@RefNum", ReferenceNumber)

		ExecuteNonQuery(cmd1)

		Dim cmd2 As New SQLiteCommand
		cmd2.CommandText = "DELETE FROM UserStock WHERE ReferenceNumber = @RefNum;"
		cmd2.Parameters.AddWithValue("@RefNum", ReferenceNumber)

		ExecuteNonQuery(cmd2)

		Dim cmd3 As New SQLiteCommand
		cmd3.CommandText = "DELETE FROM Materials WHERE ReferenceNumber = @RefNum;"
		cmd3.Parameters.AddWithValue("@RefNum", ReferenceNumber)

		Return ExecuteNonQuery(cmd3) > 0
	End Function

	Public Shared Function AssignProgramStock(ReferenceNumber As Integer, QtyPerUse As Double, QtyRemaining As Double)
		UnassignProgramStock(ReferenceNumber)

		Dim cmd As New SQLiteCommand
		cmd.CommandText = "INSERT OR REPLACE INTO ProgramStock (ReferenceNumber, QtyPerUse, QtyRemaining) VALUES (@RefNum, @QtyPerUse, @QtyRemaining);"
		cmd.Parameters.AddWithValue("@RefNum", ReferenceNumber)
		cmd.Parameters.AddWithValue("@QtyPerUse", QtyPerUse)
		cmd.Parameters.AddWithValue("@QtyRemaining", QtyRemaining)

		Return ExecuteNonQuery(cmd) > 0
	End Function

	Public Shared Function UnassignProgramStock(ReferenceNumber As Integer)
		Dim cmd As New SQLiteCommand
		cmd.CommandText = "DELETE FROM ProgramStock WHERE ReferenceNumber = @RefNum;"
		cmd.Parameters.AddWithValue("@RefNum", ReferenceNumber)

		Return ExecuteNonQuery(cmd) > 0
	End Function

	Public Shared Function AssignCommonStock(ReferenceNumber As Integer)
		UnassignCommonStock(ReferenceNumber)

		Dim cmd As New SQLiteCommand
		cmd.CommandText = "INSERT OR REPLACE INTO CommonStock (ReferenceNumber) VALUES (@RefNum);"
		cmd.Parameters.AddWithValue("@RefNum", ReferenceNumber)

		Return ExecuteNonQuery(cmd) > 0
	End Function

	Public Shared Function UnassignCommonStock(ReferenceNumber As Integer)
		Dim cmd As New SQLiteCommand
		cmd.CommandText = "DELETE FROM CommonStock WHERE ReferenceNumber = @RefNum;"
		cmd.Parameters.AddWithValue("@RefNum", ReferenceNumber)

		Return ExecuteNonQuery(cmd) > 0
	End Function

	Public Shared Function AssignUserStock(ReferenceNumber As Integer)
		UnassignUserStock(ReferenceNumber)

		Dim cmd As New SQLiteCommand
		cmd.CommandText = "INSERT OR REPLACE INTO UserStock (ReferenceNumber) VALUES (@RefNum);"
		cmd.Parameters.AddWithValue("@RefNum", ReferenceNumber)

		Return ExecuteNonQuery(cmd) > 0
	End Function

	Public Shared Function UnassignUserStock(ReferenceNumber As Integer)
		Dim cmd As New SQLiteCommand
		cmd.CommandText = "DELETE FROM UserStock WHERE ReferenceNumber = @RefNum;"
		cmd.Parameters.AddWithValue("@RefNum", ReferenceNumber)

		Return ExecuteNonQuery(cmd) > 0
	End Function

	Public Shared Sub UsedProgramStock(ReferenceNumber As Integer, Quantity As Double, ShopOrder As String)
		Dim cmd As New SQLiteCommand
		cmd.CommandText = "UPDATE ProgramStock SET QtyRemaining = QtyRemaining - @Quantity WHERE ReferenceNumber = @ReferenceNumber;"
		cmd.Parameters.AddWithValue("@Quantity", Quantity)
		cmd.Parameters.AddWithValue("@ReferenceNumber", ReferenceNumber)

		ExecuteNonQuery(cmd)

		Dim cmd1 As New SQLiteCommand

		cmd1.CommandText = "INSERT INTO UsageHist (Username, ReferenceNumber, PartNumber, LotNumber, ShopOrder, QtyUsed) VALUES (@Username, @ReferenceNumber, (SELECT PartNumber FROM Materials WHERE ReferenceNumber = @RefNum), (SELECT LotNumber FROM Materials WHERE ReferenceNumber = @RefNum1), @ShopOrder, @QtyUsed);"
		cmd1.Parameters.Clear()
		cmd1.Parameters.AddWithValue("@Username", Environment.UserName)
		cmd1.Parameters.AddWithValue("@ReferenceNumber", ReferenceNumber)
		cmd1.Parameters.AddWithValue("@RefNum", ReferenceNumber)
		cmd1.Parameters.AddWithValue("@RefNum1", ReferenceNumber)
		cmd1.Parameters.AddWithValue("@ShopOrder", ShopOrder)
		cmd1.Parameters.AddWithValue("@QtyUsed", Quantity)

		Dim ru As Integer = ExecuteNonQuery(cmd1)
		Console.WriteLine($"UsedProgramStock({ReferenceNumber}) = {ru}")
	End Sub

	Public Shared Sub UsedCommonStock(ReferenceNumber As Integer)
		Dim cmd1 As New SQLiteCommand

		cmd1.CommandText = "INSERT INTO UsageHist (Username, ReferenceNumber, PartNumber, LotNumber, QtyUsed) VALUES (@Username, @ReferenceNumber, (SELECT PartNumber FROM Materials WHERE ReferenceNumber = @RefNum), (SELECT LotNumber FROM Materials WHERE ReferenceNumber = @RefNum1), 0.001);"
		cmd1.Parameters.Clear()
		cmd1.Parameters.AddWithValue("@Username", Environment.UserName)
		cmd1.Parameters.AddWithValue("@ReferenceNumber", ReferenceNumber)
		cmd1.Parameters.AddWithValue("@RefNum", ReferenceNumber)
		cmd1.Parameters.AddWithValue("@RefNum1", ReferenceNumber)

		ExecuteNonQuery(cmd1)
	End Sub

	Public Shared Sub UserCheckOut(ReferenceNumber As Integer, Optional Username As String = Nothing)
		If Username Is Nothing Then Username = Environment.UserName
		Dim cmd As New SQLiteCommand
		cmd.CommandText = "UPDATE UserStock SET CheckedOutUser = @Username, CheckedOutTimestamp = DATETIME('now') WHERE ReferenceNumber = @ReferenceNumber;"
		cmd.Parameters.AddWithValue("@Username", Username)
		cmd.Parameters.AddWithValue("@ReferenceNumber", ReferenceNumber)

		ExecuteNonQuery(cmd)

		Dim cmd1 As New SQLiteCommand
		cmd1.CommandText = "INSERT INTO UsageHist (Username, ReferenceNumber, PartNumber, LotNumber, IsCheckOut) VALUES (@Username, @ReferenceNumber, (SELECT PartNumber FROM Materials WHERE ReferenceNumber = @RefNum), (SELECT LotNumber FROM Materials WHERE ReferenceNumber = @RefNum1), 1);"
		cmd1.Parameters.AddWithValue("@Username", Username)
		cmd1.Parameters.AddWithValue("@ReferenceNumber", ReferenceNumber)
		cmd1.Parameters.AddWithValue("@RefNum", ReferenceNumber)
		cmd1.Parameters.AddWithValue("@RefNum1", ReferenceNumber)

		ExecuteNonQuery(cmd1)
	End Sub

	Public Shared Sub UserCheckIn(ReferenceNumber As Integer, Optional Username As String = Nothing, Optional FinalCheckIn As Boolean = True)
		If Username Is Nothing Then Username = Environment.UserName

		Dim cmd1 As New SQLiteCommand
		cmd1.CommandText = $"INSERT INTO UsageHist (Username, ReferenceNumber, PartNumber, LotNumber, IsCheckIn, IsFinalCheckIn) VALUES (@Username, @ReferenceNumber, (SELECT PartNumber FROM Materials WHERE ReferenceNumber = @RefNum), (SELECT LotNumber FROM Materials WHERE ReferenceNumber = @RefNum1), 1, {If(FinalCheckIn, "1", "0")});"
		cmd1.Parameters.AddWithValue("@Username", Username)
		cmd1.Parameters.AddWithValue("@ReferenceNumber", ReferenceNumber)
		cmd1.Parameters.AddWithValue("@RefNum", ReferenceNumber)
		cmd1.Parameters.AddWithValue("@RefNum1", ReferenceNumber)

		ExecuteNonQuery(cmd1)

		If FinalCheckIn Then
			DropItem(ReferenceNumber)
		Else
			Dim cmd As New SQLiteCommand
			cmd.CommandText = "UPDATE UserStock SET CheckedOutUser = NULL, CheckedOutTimestamp = NULL WHERE ReferenceNumber = @ReferenceNumber;"
			cmd.Parameters.AddWithValue("@ReferenceNumber", ReferenceNumber)
			ExecuteNonQuery(cmd)
		End If
	End Sub
End Class

