Module DbTable
    Public Function GetTable(ByRef response As List(Of Array)) As DataTable
        Dim table As DataTable = New DataTable()
        If response.Count > 0 Then
            Dim numCols As Integer = response.Item(0).Length
            'set the first dimension of columns
            For colNum = 1 To numCols
                table.Columns.Add(colNum, GetType(String))
            Next
            Dim objItem As Object
            'set the second dimension
            For rowNum = 0 To response.Count - 1
                Dim record(numCols - 1) As String
                For colNum = 0 To numCols - 1
                    objItem = response.Item(rowNum).GetValue(colNum)
                    If objItem.Equals(DBNull.Value) Then
                        record(colNum) = ""
                    Else
                        record(colNum) = objItem
                    End If
                Next
                table.Rows.Add(record)
            Next
        End If
        Return table
    End Function

    Public Function SetColTitle(titles() As String, ByRef table As DataTable) As DataTable
        Dim rtnTable As DataTable = New DataTable()
        Dim numCols = table.Columns.Count
        For colNum = 0 To table.Columns.Count - 1
            If colNum < titles.Count Then
                rtnTable.Columns.Add(titles(colNum), GetType(String))
            Else
                rtnTable.Columns.Add(table.Columns.Item(colNum).ColumnName)
            End If
        Next
        For rowNum = 0 To table.Rows.Count - 1
            Dim record(numCols - 1) As String
            For colNum = 0 To numCols - 1
                record(colNum) = table.Rows.Item(rowNum).Item(colNum)
            Next
            rtnTable.Rows.Add(record)
        Next
        Return rtnTable
    End Function
End Module
