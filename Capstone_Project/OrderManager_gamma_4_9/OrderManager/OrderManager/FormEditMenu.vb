Public Class FormEditMenu

    Private restorePoint As DbSnapshot
    Private colNames() As String = {"item id", "name", "short name", "type code", "price", "allergy"}

    Private Sub FormEditMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvMenu.DataSource = DbTable.SetColTitle(colNames, DbTable.GetTable(DbMysql.Query("select * from menu_item"))).Copy
        restorePoint = New DbSnapshot("menu_item", dgvMenu.DataSource)
    End Sub

    Private Sub btnApply_Click(sender As Object, e As EventArgs) Handles btnApply.Click
        restorePoint.Write(dgvMenu.DataSource)
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        restorePoint.Restore()
        dgvMenu.DataSource = restorePoint.GetSave().Copy
    End Sub
End Class