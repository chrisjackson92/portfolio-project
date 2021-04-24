
Imports System.IO
Public Class SaveDialog

    Public Sub New(ByRef txt As String)
        Dim saveDialog As SaveFileDialog = New SaveFileDialog()
        saveDialog.Filter = "Text File|*.txt|All Files|*.*"
        If saveDialog.ShowDialog() = DialogResult.OK And saveDialog.FileName <> String.Empty Then
            Try
                Dim oStream As StreamWriter = File.CreateText(saveDialog.FileName)
                oStream.Write(txt)
                oStream.Close()
                MessageBox.Show("File saved successfully")
            Catch ex As Exception
                MessageBox.Show("Error writing the file " & saveDialog.FileName)
            End Try
        End If
    End Sub

End Class
