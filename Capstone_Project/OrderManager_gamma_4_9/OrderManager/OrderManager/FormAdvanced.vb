Public Class FormAdvanced

    Private bannedTerms As List(Of String)

    Private Sub FormAdvanced_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        bannedTerms = New List(Of String)
        bannedTerms.Add("DELETE")
        bannedTerms.Add("DROP")
        bannedTerms.Add("UPDATE")
        bannedTerms.Add("CREATE")
        bannedTerms.Add("INSERT")
    End Sub

    Private Sub btnRun_Click(sender As Object, e As EventArgs) Handles btnRun.Click
        Dim clean As Boolean = True
        Dim words As Array = txtQuery.Text.Split(" ")
        For Each word In words
            If word.ToString.Contains("@") Then
                clean = False
                Exit For
            End If
            For Each term In bannedTerms
                If String.Equals(word.ToUpper(), term) Then
                    clean = False
                End If
            Next
        Next

        If clean Then
            Dim response As List(Of Array) = DbMysql.Query(txtQuery.Text)
            If response.Count > 0 Then
                dgvResults.DataSource = DbTable.GetTable(response)
            End If
        Else
            'Debug.WriteLine("unclean SQL")
            MessageBox.Show("Statement not allowed")
        End If

    End Sub


End Class