Public Class currencyconverter

    Dim arrowright As Boolean = True

    Private Sub rdbtnleft_CheckedChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnback_Click(sender As Object, e As EventArgs) Handles btnback.Click

        Me.Close()
        frmmenu.Show()

    End Sub
End Class