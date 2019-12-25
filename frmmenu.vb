Public Class frmmenu

    Dim currency As Char
    Private Sub btnquit_Click(sender As Object, e As EventArgs) Handles btnquit.Click
        Application.Exit()
    End Sub

    Private Sub btninterest_Click(sender As Object, e As EventArgs) Handles btninterest.Click

        Me.Hide()
        interestcalculator.Show()

    End Sub

    Private Sub btnmortgage_Click(sender As Object, e As EventArgs) Handles btnmortgage.Click

        Me.Hide()
        mortagecalculator.Show()

    End Sub

    Private Sub btncurr_Click(sender As Object, e As EventArgs) Handles btn.Click

        Me.Hide()

    End Sub

    Private Sub btnbudgeting_Click(sender As Object, e As EventArgs) Handles btnbudgeting.Click

        Me.Hide()
        budget_manager.Show()

    End Sub

    Private Sub cmbcurr_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbcurr.SelectedIndexChanged

        If cmbcurr.SelectedIndex = 0 Then
            currency = "£"
        ElseIf cmbcurr.SelectedIndex = 1 Then
            currency = "$"
        ElseIf cmbcurr.SelectedIndex = 2 Then
            currency = ""
        ElseIf cmbcurr.SelectedIndex = 3 Then
            currency = ""
        ElseIf cmbcurr.SelectedIndex = 4 Then
            currency = ""
        ElseIf cmbcurr.SelectedIndex = 5 Then
            currency = "$"
        ElseIf cmbcurr.SelectedIndex = 6 Then
            currency = ""
        ElseIf cmbcurr.SelectedIndex = 7 Then
            currency = ""
        ElseIf cmbcurr.SelectedIndex = 8 Then
            currency = ""
        ElseIf cmbcurr.SelectedIndex = 9 Then
            currency = ""
        End If
    End Sub
End Class
