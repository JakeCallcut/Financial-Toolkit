Public Class mortagecalculator
    Private Sub btncalc_Click(sender As Object, e As EventArgs) Handles btncalc.Click

        Dim houseprice As Double
        Dim downpayment As Double
        Dim monthlypayment As Double
        Dim years As Integer
        Dim amounttopay As Double


        houseprice = txtprice.Text
        downpayment = txtdownpay.Text
        monthlypayment = txtmonthpay.Text

        If IsNumeric(houseprice) = True Then
            If IsNumeric(downpayment) = True Then
                If IsNumeric(monthlypayment) = True Then

                    amounttopay = houseprice - downpayment
                    years = Int(amounttopay / (monthlypayment * 12))

                    lblyears.Text = "Years: " & years

                Else
                    MessageBox.Show("Please enter a number in the monthly payment field")
                End If
            Else
                MessageBox.Show("Please enter a number in the down paymant field")
            End If
        Else
            MessageBox.Show("Please enter a number in the house price field")
        End If

    End Sub

    Private Sub btnback_Click(sender As Object, e As EventArgs) Handles btnback.Click

        Me.Close()
        frmmenu.Show()

    End Sub
End Class