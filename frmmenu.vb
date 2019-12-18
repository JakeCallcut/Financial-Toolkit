Public Class frmmenu


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

    Private Sub btncurr_Click(sender As Object, e As EventArgs) Handles btncurr.Click

        Me.Hide()
        currencyconverter.Show()

    End Sub

    Private Sub btnbudgeting_Click(sender As Object, e As EventArgs) Handles btnbudgeting.Click

        Me.Hide()
        budget_manager.Show()

    End Sub
End Class
