Public Class FormNewCustomer

    Private Class Customer
        Public id As Integer
        Public phone As Integer
        Public firstName As String
        Public lastName As String
        Public notes As String
    End Class

    Private cust As Customer

    Public Sub New(phone As Integer)
        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        cust = New Customer()
        cust.phone = phone
        txtPhone.Text = phone.ToString
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Try
            If txtFname.Text = "" Then
                Throw New Exception("Enter the customers first name")
            ElseIf txtLname.Text = "" Then
                Throw New Exception("Enter the customers last name")
            End If
            Dim strCustInsert As String
            With cust
                .id = cust.phone
                .firstName = txtFname.Text
                .lastName = txtLname.Text
                .notes = txtNotes.Text
                If cust.notes <> "" Then
                    strCustInsert = "insert into customer values(" & .id & "," & .phone & ",'" & .firstName & " " & .lastName & "','" & .notes & "')"
                Else
                    strCustInsert = "insert into customer values(" & .id & "," & .phone & ",'" & .firstName & " " & .lastName & "', '')"
                End If
            End With
            DbMysql.Query(strCustInsert)
            Me.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Notice")
        End Try
    End Sub
End Class