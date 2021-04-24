Public Class DbSnapshot

    Private save As DataTable
    Private saveSql As List(Of String)
    Private name As String
    Public Sub New(tableName As String, ByRef table As DataTable)
        name = tableName
        save = table.Copy
        saveSql = GenSpawnSql(tableName, table)
    End Sub

    Private Function GenSpawnSql(tableName As String, table As DataTable) As List(Of String)
        Dim strSql As List(Of String) = New List(Of String)
        Dim numRows As Integer = table.Rows.Count
        Dim numCols As Integer = table.Columns.Count
        Dim valueString As String = ""
        Dim strItem As String
        Dim dblItem As Double
        Dim objItem As Object
        For rowNum = 0 To numRows - 1
            valueString = "("
            For colNum = 0 To numCols - 1
                strItem = ""
                objItem = table.Rows.Item(rowNum).Item(colNum)
                If Double.TryParse(objItem, dblItem) Then
                    strItem = objItem.ToString
                Else
                    strItem = "'" & objItem.ToString() & "'"
                End If
                If colNum < numCols - 1 Then
                    valueString &= strItem & ","
                Else
                    valueString &= strItem & ")"
                End If
            Next
            strSql.Add("insert into " & tableName & " values" & valueString)
        Next
        Return strSql
    End Function

    Public Function GetSave() As DataTable
        Return save
    End Function

    Public Sub Restore()
        DbMysql.Query("delete from " & name)
        DbMysql.MultiRun(saveSql.ToArray)
    End Sub

    Public Function Write(updatedTable As DataTable) As Boolean
        Dim success As Boolean = False
        Try
            DbMysql.Query("delete from " & name)
            DbMysql.MultiRun(GenSpawnSql(name, updatedTable).ToArray)
            success = True
        Catch ex As Exception
            Restore()
        End Try
        Return success
    End Function

End Class
