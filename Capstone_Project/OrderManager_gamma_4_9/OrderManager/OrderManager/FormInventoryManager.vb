Imports System.IO
Imports System.Text

Public Class FormInventoryManager
    Private restorePoint As DbSnapshot
    Private colNames() As String = {"Item_ID", "Item_Name", "Opening_QTY", "Closing_QTY"}

    Private Sub FormInventoryManager_Load(sender As Object, e As EventArgs) Handles MyBase.Load, TabControl1.SelectedIndexChanged
        DataGridViewInventory.DataSource = DbTable.SetColTitle(colNames, DbTable.GetTable(DbMysql.Query("select * from bar_item_closing"))).Copy
        DataGridViewEditINV.DataSource = DbTable.SetColTitle(colNames, DbTable.GetTable(DbMysql.Query("select * from bar_item_closing"))).Copy
        restorePoint = New DbSnapshot("bar_item_closing", DataGridViewInventory.DataSource)
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

                DataGridViewInventory.DataSource = DbTable.SetColTitle(colNames, DbTable.GetTable(DbMysql.Query("select * from bar_item_closing"))).Copy
                restorePoint = New DbSnapshot("bar_item_closing", DataGridViewInventory.DataSource)
            Catch ex As Exception
                MessageBox.Show("Error saving edit. " & ex.Message)
            End Try
        Else
            MessageBox.Show("Bottle level must be a positive number in X.XX format in 0.25 increments")
        End If


    End Sub

    Private Sub FormViewInventory_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        Debug.WriteLine("showing inventory from admin")
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim statement As String
        Dim itemID As String
        Dim itemName As String
        Dim itemQTY As String
        Dim itemQTYNUMBER As Int32

        itemQTYNUMBER = Int32.Parse(txtAddQTY.Text)
        If itemQTYNUMBER >= 0 Then
            Try
                itemID = txtAddID.Text
                itemName = txtAddName.Text
                itemQTY = txtAddQTY.Text

                statement = "INSERT INTO bar_item_closing (id, item_name, opening_qty, closing_qty) VALUES (" + itemID + " , '" + itemName + "' , " + itemQTY + " , " + itemQTY + ")"
                DbMysql.Query(statement)

                DataGridViewEditINV.DataSource = DbTable.SetColTitle(colNames, DbTable.GetTable(DbMysql.Query("select * from bar_item_closing"))).Copy
                restorePoint = New DbSnapshot("bar_item_closing", DataGridViewInventory.DataSource)
            Catch ex As Exception
                MessageBox.Show("Error adding item. " & ex.Message)
            End Try
        Else
            MessageBox.Show("Bottle level must be a positive number.")
        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim statement As String
        Dim itemID As String
        Try
            itemID = txtDeleteID.Text

            statement = "DELETE FROM bar_item_closing WHERE id = " + itemID

            DbMysql.Query(statement)

            DataGridViewEditINV.DataSource = DbTable.SetColTitle(colNames, DbTable.GetTable(DbMysql.Query("select * from bar_item_closing"))).Copy
            restorePoint = New DbSnapshot("bar_item_closing", DataGridViewInventory.DataSource)
        Catch ex As Exception
            MessageBox.Show("Error deleting item. " & ex.Message)
        End Try
    End Sub

    Private Sub btnSaveToFileMngr_Click(sender As Object, e As EventArgs) Handles btnSaveToFileMngr.Click
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
            For x As Integer = 0 To DataGridViewInventory.Rows.Count - 1
                For v As Integer = 0 To 3
                    'extracting cell value from 0 to 9 and add it on list
                    If v > 0 Then text.Append("|")
                    text.Append(DataGridViewInventory.Rows(x).Cells(v).Value.ToString())
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