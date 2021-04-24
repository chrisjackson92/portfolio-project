Imports System.IO
Imports System.Text

Public Class FormViewInventory
    Private restorePoint As DbSnapshot
    Private colNames() As String = {"Item_ID", "Item_Name", "Opening_QTY", "Closing_QTY"}

    Private Sub FormViewInventory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataGridViewOrders.DataSource = DbTable.SetColTitle(colNames, DbTable.GetTable(DbMysql.Query("select * from bar_item_closing"))).Copy
        restorePoint = New DbSnapshot("bar_item_closing", DataGridViewOrders.DataSource)

        TabControl1.TabPages(1).Enabled = False
    End Sub




    Private Sub FormViewInventory_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        Debug.WriteLine("showing inventory from admin")

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim statement As String
        Dim itemID As String
        Dim itemLevel As String
        Dim itemLvlNUMBER As Decimal

        itemLvlNUMBER = Decimal.Parse(txtBottleLvl.Text)

        If itemLvlNUMBER >= 0 And itemLvlNUMBER Mod 0.25 = 0 Then
            Try
                itemID = txtBottleID.Text
                itemLevel = txtBottleLvl.Text

                statement = "UPDATE bar_item_closing SET closing_qty = " + itemLevel + " WHERE id = " + itemID

                DbMysql.Query(statement)

                DataGridViewOrders.DataSource = DbTable.SetColTitle(colNames, DbTable.GetTable(DbMysql.Query("select * from bar_item_closing"))).Copy
                restorePoint = New DbSnapshot("bar_item_closing", DataGridViewOrders.DataSource)
            Catch ex As Exception
                MessageBox.Show("Error saving edit. " & ex.Message)
            End Try
        Else
            MessageBox.Show("Bottle level must be a positive number in X.XX format in 0.25 increments")
        End If


    End Sub

    Private Sub btnSaveToFile_Click(sender As Object, e As EventArgs) Handles btnSaveToFile.Click
        Dim fileName As String
        fileName = "Inventory_Sheet_" + DateAndTime.DateString + ".txt"
        Dim text As New StringBuilder()
        Dim empName As String
        empName = txtName.ToString()
        text.Append(empName)
        text.AppendLine()
        text.Append(DateAndTime.DateString)
        text.AppendLine()
        text.AppendLine()
        Try
            For x As Integer = 0 To DataGridViewOrders.Rows.Count - 1
                For v As Integer = 0 To 3
                    'extracting cell value from 0 to 9 and add it on list
                    If v > 0 Then text.Append("|")
                    text.Append(DataGridViewOrders.Rows(x).Cells(v).Value.ToString())
                    'MessageBox.Show(text.ToString())
                Next
                'adding new line to text
                text.AppendLine()
            Next
            'IO.File.WriteAllText(fileName, text.ToString())
        Catch ex As NullReferenceException
            MessageBox.Show("end of table")
        End Try
        Dim myStream As Stream
        Dim sDialog As SaveFileDialog = New SaveFileDialog()

        sDialog.FileName = fileName
        sDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*"
        sDialog.DefaultExt = ".txt"
        sDialog.FilterIndex = 2
        sDialog.RestoreDirectory = True
        If sDialog.ShowDialog() = DialogResult.OK Then
            File.WriteAllText(sDialog.FileName, text.ToString())
        End If

    End Sub
End Class