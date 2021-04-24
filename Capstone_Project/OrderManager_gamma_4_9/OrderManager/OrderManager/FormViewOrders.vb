Public Class FormViewOrders

    Private ordersTable As List(Of Order)
    Private finit As Boolean = False
    Private colNames() As String = {"order id", "order date", "employee name", "customer name", "table #"}

    Private Sub RefreshTableView()
        If finit Then
            Dim numOrders As Integer = Int(spnrNumOrders.Value)
            If numOrders > 0 Then
                Dim ordersArray As List(Of Array) = New List(Of Array)
                For n = 0 To numOrders - 1
                    If n < ordersTable.Count Then
                        ordersArray.Add(ordersTable.Item(n).ToArray)
                    End If
                Next
                dgvOrders.DataSource = DbTable.SetColTitle(colNames, DbTable.GetTable(ordersArray))
            End If
        End If
    End Sub

    Private Sub spnrNumOrders_ValueChanged(sender As Object, e As EventArgs) Handles spnrNumOrders.ValueChanged
        RefreshTableView()
    End Sub

    Private Sub FormViewOrders_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim ordersResult = DbMysql.Query("select * from orders")
        If ordersResult.Count > 0 Then
            ordersTable = New List(Of Order)
            For Each order In ordersResult
                ordersTable.Add(New Order(order))
            Next
            ordersTable.Sort(AddressOf Order.OrderByDate)

            Dim selSort = "
            'selection sort by date
            Dim prev As Integer = 0
            For n = 0 To ordersTable.Count
                prev = n
                For nxt = n + 1 To ordersTable.Count
                    If ordersTable.Item(prev).orderDate > ordersTable.Item(nxt).orderDate Then
                        prev = nxt
                    End If
                Next
                If prev <> n Then
                    Dim temp As Order = ordersTable.Item(n)
                    ordersTable.Item(n) = ordersTable.Item(prev)
                    ordersTable.Item(prev) = temp
                End If
            Next
"
        End If
        finit = True
        RefreshTableView()
    End Sub
End Class