Imports System.Globalization
Public Class FormAdminHome

    Private menusNav As MenuNav
    Private menus As Dictionary(Of String, Object)
    Private finit = False

    Private items As List(Of ItemOrder)

    Public Sub RefreshItems()
        items = New List(Of ItemOrder)
        Dim itemsResult As List(Of Array) = DbMysql.Query("select * from item_order")
        For Each item In itemsResult
            items.Add(New ItemOrder(item))
        Next
    End Sub

    Private Sub FormAdminHome_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        menus = New Dictionary(Of String, Object)
        menus.Add("View Orders", FormViewOrders)

        'TODO: REPLACE THE FORM NAME WITH THAT OF THE CLASS

        menus.Add("Inventory", FormInventoryManager)
        menus.Add("Edit Menu", FormEditMenu)
        menus.Add("Edit Employees", FormEditEmployees)
        menus.Add("Advanced", FormAdvanced)
    End Sub



    Public Sub UpdateSalesTotal(withRefresh As Boolean)
        If withRefresh Then
            RefreshItems()
        End If
        Dim dblTotal As Double = 0
        If cboxSalesPeriod.SelectedIndex <> -1 Then
            Dim local As CultureInfo = New CultureInfo("en-US")
            'Dim formatInto As DateTimeFormatInfo = local.DateTimeFormat
            Dim calendar As Calendar = local.Calendar

            Dim thisDay As Integer = calendar.GetDayOfYear(Date.Now)
            Dim thisWeek As Integer = calendar.GetWeekOfYear(Date.Now, local.DateTimeFormat.CalendarWeekRule, local.DateTimeFormat.FirstDayOfWeek)
            Dim thisMonth As Integer = calendar.GetMonth(Date.Now)
            Dim thisYear As Integer = calendar.GetYear(Date.Now)

            Dim ordersResult As List(Of Array) = DbMysql.Query("select * from orders")
            If ordersResult.Count > 0 Then
                Dim orders As List(Of Order) = New List(Of Order)
                For Each order In ordersResult
                    orders.Add(New Order(order))
                Next
                Dim itemTotals As Dictionary(Of Long, Integer) = New Dictionary(Of Long, Integer)
                Dim dateMatch As Boolean
                For Each order In orders
                    Dim orderDate As DateTime = DateTime.FromFileTime(order.orderDate)
                    dateMatch = False
                    If calendar.GetYear(orderDate) = thisYear And calendar.GetMonth(orderDate) = thisMonth Then
                        Select Case cboxSalesPeriod.SelectedItem.ToString
                            Case "Daily"
                                If calendar.GetDayOfYear(orderDate) = thisDay Then
                                    dateMatch = True
                                End If
                            Case "Weekly"
                                If calendar.GetWeekOfYear(orderDate, local.DateTimeFormat.CalendarWeekRule, local.DateTimeFormat.FirstDayOfWeek) = thisWeek Then
                                    dateMatch = True
                                End If
                            Case "Monthly"
                                dateMatch = True
                        End Select
                        If dateMatch Then
                            'cycle all the item orders
                            For Each itemEntry In items
                                'catch the items of this order
                                If itemEntry.orderId = order.id Then
                                    'search for entries of this item in the totals dictionary
                                    Dim newItem = True
                                    For n = 0 To itemTotals.Count - 1
                                        If itemEntry.itemId = itemTotals.ElementAt(n).Key Then
                                            newItem = False
                                            itemTotals.Item(itemTotals.Keys.ElementAt(n)) += itemEntry.quantity
                                        End If
                                    Next
                                    If newItem Then
                                        itemTotals.Add(itemEntry.itemId, itemEntry.quantity)
                                    End If
                                End If
                            Next
                        End If 'if date matches
                    End If 'year and month matches
                Next ' for each order
                'get the prices of all menu items
                Dim itemPrices As List(Of Array) = DbMysql.Query("select id, price from menu_item")
                For Each order In itemTotals.Keys
                    For Each item In itemPrices
                        If CLng(item(0)) = order Then
                            'Debug.WriteLine("order amount " & CDbl(item(1)) * itemTotals.Item(order))
                            dblTotal += CDbl(item(1)) * itemTotals.Item(order)
                        End If
                    Next
                Next
            End If 'if there are orders
        End If
        txtSalesTotal.Text = dblTotal.ToString("C")
    End Sub

    Public Sub UpdateOrders()
        RefreshItems()
        Dim itemCount As Dictionary(Of Integer, Integer) = New Dictionary(Of Integer, Integer)
        Dim itemName As List(Of String) = New List(Of String)
        Dim newItem As Boolean
        For Each item In items
            newItem = True
            For n = 0 To itemCount.Count - 1
                If item.itemId = itemCount.ElementAt(n).Key Then
                    newItem = False
                    itemCount.Item(itemCount.ElementAt(n).Key) += 1
                End If
            Next
            If newItem Then
                itemCount.Add(item.itemId, 1)
                itemName.Add(DbMysql.Query("select name from menu_item where id =" & item.itemId).Item(0)(0).ToString)
            End If
        Next
        lstOrders.Items.Clear()
        'list the last items first
        Dim numItems As Array = itemCount.Values.ToArray
        Dim itemNum = numItems.Length
        While itemNum > 0
            itemNum -= 1
            lstOrders.Items.Add(numItems(itemNum).ToString & vbTab & " : " & itemName.Item(itemNum))
        End While

    End Sub

    Public Sub UpdateCustomers()
        lstCustomers.Items.Clear()
        Dim ordersResult As List(Of Array) = DbMysql.Query("select * from orders")
        Dim custResponse As List(Of Array) = DbMysql.Query("select id, name from customer")
        If ordersResult.Count > 0 And custResponse.Count > 0 Then
            Dim orders As List(Of Order) = New List(Of Order)
            For Each order In ordersResult
                orders.Add(New Order(order))
            Next
            orders.Sort(AddressOf Order.OrderByDate)
            'add customers directly from the answer-set, in sequence from the sorted orders
            Dim orderDate As DateTime
            Dim strCustomers As List(Of String) = New List(Of String)
            For Each order In orders
                For Each customer In custResponse
                    If CInt(customer(0)) = order.customerId Then
                        orderDate = DateTime.FromFileTime(order.orderDate)
                        strCustomers.Add(orderDate.ToShortDateString & " " & orderDate.ToShortTimeString & "   " & customer(1).ToString)
                    End If
                Next
            Next
            Dim custNum As Integer = strCustomers.Count
            While custNum > 0
                custNum -= 1
                lstCustomers.Items.Add(strCustomers(custNum))
            End While
        End If
    End Sub

    Private Sub FormAdminHome_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        If finit = False Then
            finit = True
            'other first run processes
            menusNav = New MenuNav(MyBase.ActiveForm, menus)
        End If
        UpdateCustomers()
        UpdateOrders()
        UpdateSalesTotal(False)
        Me.Refresh()
    End Sub

    Private Sub FormAdminHome_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        End
    End Sub

    Private Sub cboxSalesPeriod_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboxSalesPeriod.SelectedIndexChanged
        UpdateSalesTotal(True)
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        UpdateCustomers()
        UpdateOrders()
        UpdateSalesTotal(False)
    End Sub
End Class
