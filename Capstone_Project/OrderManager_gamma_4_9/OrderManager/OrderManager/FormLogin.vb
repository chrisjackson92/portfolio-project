Public Class FormLogin

    Private Function DbConnect() As Boolean
        Dim connected = DbMysql.Touch("arigato")
        If connected = False Then
            MessageBox.Show("No database connection")
        End If
        Return connected
    End Function

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If DbConnect() Then

            Dim type As String = ""

            If txtEmpId.Text = "admin" Then
                type = "manager"
            Else
                Dim empTypeAnswer = DbMysql.Query("select type from employee_type where id = (select type from employees where id = '" & txtEmpId.Text & "')")
                If txtEmpId.Text <> "" And empTypeAnswer.Count > 0 Then
                    type = CType(empTypeAnswer.Item(0)(0), String)
                    Debug.WriteLine("The employee is type: " & type)
                End If
            End If

            If type <> "" Then
                If type = "manager" Then
                    FormAdminHome.Show()
                ElseIf type = "waiter" Then
                    Dim orderForm As FormPlaceOrder = New FormPlaceOrder(CType(txtEmpId.Text, Integer))
                    orderForm.Show()
                ElseIf type = "bartender" Then
                    Dim bartenderView As FormViewInventory = New FormViewInventory()
                    bartenderView.Show()
                    'TODO: SHOW THE INVENTORY SCREEN FOR BARTENDERS 


                End If
                Me.Hide()
            End If
        End If
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        'reset the database schema
        If DbMysql.Touch("arigato") Then
            Debug.WriteLine("resetting database")
            DbMysql.Run(TableData.inventoryTables)
            DbMysql.Run(TableData.inventorySamples)

            'DbMysql.MultiRun(TableData.posTables)
            'DbMysql.Run(TableData.posSamples)
        End If
    End Sub
End Class