Public Class interestcalculator
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        frmmenu.Show()
    End Sub

    Private Sub btncalc_Click(sender As Object, e As EventArgs) Handles btncalc.Click

        Dim interesttype As String
        Dim years As Double
        Dim amount As Double
        Dim rate As Double

        years = txtyears.Text
        amount = txtamount.Text
        rate = txtrate.Text

        If rdbtnsimple.Checked = True Then
            interesttype = "simple"
        End If

        If rdbtncompound.Checked = True Then
            interesttype = "compound"
        End If

        If interesttype = "simple" Then

        End If
    End Sub

End Class