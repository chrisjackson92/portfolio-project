Public Class MenuNav
    Private rootForm As Form
    Private menuBtns As List(Of Button)
    Private menuForms As List(Of Form)

    Public Sub btnClick(sender As Object, e As EventArgs) ' Handles btnMenuEntry.Click
        Dim intBtn As Integer = 0
        'rootForm.Hide()
        While intBtn < menuBtns.Count
            If (CType(sender, Button).Equals(menuBtns.Item(intBtn))) Then
                menuForms.Item(intBtn).ShowDialog()
            End If
            intBtn += 1
        End While
    End Sub

    Public Sub New(ByRef parentForm As Form, ByRef forms As Dictionary(Of String, Object))
        Dim pnlContainer As Panel = New Panel()
        With pnlContainer
            .Width = parentForm.Width * 0.9
            .Height = parentForm.Height * 0.1
            .AutoSize = True
            .Location = New Point(parentForm.Width * 0.04, 10)
            .BorderStyle = BorderStyle.FixedSingle
        End With

        Dim intBtnHeight As Integer = pnlContainer.Height * 0.9
        Dim intBtnWidth As Integer = (pnlContainer.Width * 0.95) / forms.Count
        Dim intBtnLeft As Integer = (pnlContainer.Width * 0.03) / forms.Count
        Dim intBtnTop As Integer = pnlContainer.Height * 0.05

        menuBtns = New List(Of Button)
        menuForms = New List(Of Form)
        Dim intMenuItem As Integer = 0
        For Each key In forms.Keys
            menuForms.Add(DirectCast(forms.Item(key), Form))
            Dim btnMenuEntry = New Button()
            With btnMenuEntry
                .FlatStyle = FlatStyle.Flat
                .Text = key
                .Location = New Point(((intMenuItem + 1) * intBtnLeft) + (intMenuItem * intBtnWidth), intBtnTop)
                .Height = intBtnHeight
                .Width = intBtnWidth
            End With
            AddHandler btnMenuEntry.Click, AddressOf btnClick
            menuBtns.Add(btnMenuEntry)
            pnlContainer.Controls.Add(btnMenuEntry)
            intMenuItem += 1
        Next
        rootForm = parentForm
        parentForm.Controls.Add(pnlContainer)
    End Sub


End Class
