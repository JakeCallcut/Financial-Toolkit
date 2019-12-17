Public Class frmmenu


    Private Sub btnquit_Click(sender As Object, e As EventArgs) Handles btnquit.Click
        Application.Exit()
    End Sub

    Private Sub btninterest_Click(sender As Object, e As EventArgs) Handles btninterest.Click

        Me.Hide()
        interestcalculator.Show()

    End Sub
End Class
