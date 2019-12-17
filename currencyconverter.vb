Public Class currencyconverter

    Dim arrowright As Boolean

    Private Sub rdbtnleft_CheckedChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnswap_Click(sender As Object, e As EventArgs) Handles btnswap.Click

        If lbltofrom.Text = ">" Then
            arrowright = False
            lbltofrom.Text = "<"
        End If

        If lbltofrom.Text = "<" Then
            arrowright = True
            lbltofrom.Text = ">"
        End If

    End Sub
End Class