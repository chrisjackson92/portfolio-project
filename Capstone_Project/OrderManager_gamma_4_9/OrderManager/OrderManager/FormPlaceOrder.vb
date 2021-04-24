Public Class FormPlaceOrder

    Private Class ItemOrder
        Public id As Long
        Public orderId As Long
        Public itemId As Integer
        Public quantity As Integer
        Public notes As String = ""
    End Class

    Private empId As Integer
    Private dblTotal As Double = 0
    Private orderId As Long = 0
    Private thisOrder As Order
    Private orderItems As List(Of ItemOrder) = New List(Of ItemOrder)
    Private receiptItems As List(Of String) = New List(Of String)

    Public Sub New(id As Integer)
        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        empId = id
    End Sub

    Private Function GenerateReceipt() As String
        Dim receipt As String = ""
        For Each item In receiptItems
            receipt &= item & vbCrLf
        Next
        If cboxRewardAccept.Checked Then
            receipt &= "Reward: " & lblReward.Text
        End If
        If receipt <> "" Then
            receipt &= "Order Total: " & dblTotal.ToString("C")
        End If
        Return receipt
    End Function

    Private Sub PlaceOrder()
        ' continue the order process after an item has been added to the order
        If orderId <> 0 Then
            'add the order, and each item of the order to the DB
            With thisOrder
                DbMysql.Query("insert into orders values (" & .id & "," & .orderDate & "," & .employeeId & "," & .customerId & "," & .tableNum & ")")
            End With

            Dim strItemInsert As String
            For Each item In orderItems
                With item
                    If .notes <> String.Empty Then
                        strItemInsert = "insert into item_order values (" & .id & "," & .orderId & "," & .itemId & "," & .quantity & ",'" & .notes & "')"
                    Else
                        strItemInsert = "insert into item_order values (" & .id & "," & .orderId & "," & .itemId & "," & .quantity & ", '')"
                    End If
                    DbMysql.Query(strItemInsert)
                End With
            Next
        End If
        Dim receipt = GenerateReceipt()
        If receipt <> String.Empty Then
            If MessageBox.Show(receipt, "Save Receipt?", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                Dim saveDialog As SaveDialog = New SaveDialog(receipt)
            End If
        Else
            MessageBox.Show("No items were ordered")
        End If
        End
    End Sub

    Private Sub FormPlaceOrder_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        PlaceOrder()
    End Sub

    Private Sub btnRewardChk_Click(sender As Object, e As EventArgs) Handles btnRewardChk.Click
        Dim strReward As String = ""
        Dim custNum As Integer
        If txtPhone.Text.Equals(String.Empty) Or Integer.TryParse(txtPhone.Text, custNum) = False Then
            MessageBox.Show("Enter a valid phone number", "Error")
            txtPhone.Text = ""
        Else
            Dim custId As Integer = GetCustId(txtPhone.Text)
            If custId <> 0 Then
                Dim custOrderResults As List(Of Array) = DbMysql.Query("select item_id, quantity from item_order where order_id = (select id from orders where customer_id = " & custId & ")")
                Debug.WriteLine(custOrderResults.Count & " records found")
                If custOrderResults.Count > 0 Then

                    'TODO: match reward criteria and just set strReward to the potential reward

                End If
            Else
                'ask to add a new customer
                Dim answer = MessageBox.Show("Add new customer?", "New Customer", MessageBoxButtons.YesNo)
                If answer = DialogResult.Yes Then
                    Dim custForm As FormNewCustomer = New FormNewCustomer(custNum)
                    custForm.ShowDialog()
                End If
                If strReward <> "" Then
                    lblReward.Text = strReward
                    cboxRewardAccept.Enabled = True
                End If
            End If
        End If
    End Sub

    Private Sub ClearOrder()
        cboxMenuItems.SelectedIndex = -1
        spnrQnty.Value = 1
        txtItemNotes.Text = ""
        txtItemTotal.Text = ""
    End Sub

    Private Function GetCustId(strPhone As String) As Integer
        'return zero if the customer is not in the DB
        Dim custId As Integer = 0
        Dim custNum As Integer = 0
        If Integer.TryParse(strPhone, custNum) Then
            Dim custResult As List(Of Array) = DbMysql.Query("select id from customer where phone = '" & custNum & "'")
            If custResult.Count > 0 Then
                custId = CType(custResult.Item(0)(0), Integer)
            End If
        End If
        Return custId
    End Function

    Private Function GetNewOrderId() As Long
        thisOrder = New Order()
        With thisOrder
            .employeeId = empId
            .customerId = GetCustId(txtPhone.Text)
            .tableNum = spnrTableNum.Value
            .orderDate = System.DateTime.Now.ToFileTime()
            ' unique id is the table number + the time of order
            .id = CType(.tableNum.ToString & .orderDate.ToString, Long)
        End With
        Return thisOrder.id
    End Function

    Private Function GetItemTotal() As Double
        Dim total As Double = 0
        If cboxMenuItems.SelectedIndex <> -1 Then
            Dim priceResult = DbMysql.Query("select price from menu_item where name = '" & cboxMenuItems.SelectedItem.ToString & "'")
            If priceResult.Count > 0 Then
                total = spnrQnty.Value * CType(priceResult.Item(0)(0), Double)
            End If
        End If
        Return total
    End Function

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If cboxMenuItems.SelectedIndex <> -1 Then
            'lock the table number and customer info
            spnrTableNum.Enabled = txtPhone.Enabled = False
            If orderId = 0 Then
                orderId = GetNewOrderId()
                'Debug.WriteLine("new order id: " & orderId.ToString)
            End If
            Dim itemResult = DbMysql.Query("select id, short_name from menu_item where name = '" & cboxMenuItems.SelectedItem & "'")
            Dim strNow As String = DateTime.Now.ToFileTime.ToString
            Dim strItemId As String = itemResult.Item(0)(0).ToString
            Dim itemOrder = New ItemOrder
            With itemOrder
                .orderId = orderId
                .itemId = strItemId
                .quantity = spnrQnty.Value
                .notes = txtItemNotes.Text
                .id = CType(strItemId & strNow.Substring(strItemId.Length, strNow.Length - (strItemId.Length + 1)), Long)
            End With
            orderItems.Add(itemOrder)
            receiptItems.Add(itemResult.Item(0)(1).ToString & " " & txtItemTotal.Text)
            dblTotal += CType(txtItemTotal.Text, Double)
            txtOrderTotal.Text = dblTotal.ToString("C")
            ClearOrder()
        Else
            MessageBox.Show("No menu item selected")
        End If
    End Sub

    Private Sub spnrQnty_ValueChanged(sender As Object, e As EventArgs) Handles spnrQnty.ValueChanged
        txtItemTotal.Text = GetItemTotal().ToString("C")
    End Sub

    Private Sub cboxMenuItems_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboxMenuItems.SelectedIndexChanged
        txtItemTotal.Text = GetItemTotal().ToString("C")
    End Sub

    Private Sub FormPlaceOrder_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtOrderTotal.Text = "$0.00"
        Dim menuResult As List(Of Array) = DbMysql.Query("select name from menu_item")

        If menuResult.Count <> 0 Then
            Dim strItem As String = ""
            For Each item In menuResult
                strItem = item(0).ToString
                If strItem <> "combination" And strItem <> "special" Then
                    cboxMenuItems.Items.Add(strItem)
                End If
            Next
        End If
    End Sub

    Private Sub btnComplete_Click(sender As Object, e As EventArgs) Handles btnComplete.Click
        PlaceOrder()
    End Sub
End Class