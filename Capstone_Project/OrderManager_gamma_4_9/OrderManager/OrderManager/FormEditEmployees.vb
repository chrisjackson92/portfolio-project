Public Class FormEditEmployees

    Private restorePoint As DbSnapshot
    Private colNames() As String = {"employee id", "first name", "last name", "type code"}

    Private Sub FormEditEmployees_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvEmployees.DataSource = DbTable.SetColTitle(colNames, DbTable.GetTable(DbMysql.Query("select * from employees"))).Copy
        restorePoint = New DbSnapshot("employees", dgvEmployees.DataSource)
    End Sub

    Private Sub btnApply_Click(sender As Object, e As EventArgs) Handles btnApply.Click
        restorePoint.Write(dgvEmployees.DataSource)
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        restorePoint.Restore()
        dgvEmployees.DataSource = restorePoint.GetSave().Copy
    End Sub
End Class