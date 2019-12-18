Public Class interestcalculator

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        frmmenu.Show()
    End Sub

    Private Sub btncalc_Click(sender As Object, e As EventArgs) Handles btncalc.Click

        Dim interesttype As String = ""
        Dim years As Double
        Dim amount As Double
        Dim rate As Double
        Dim result As Double
        Dim decimalperc As Double
        Dim profit As Double

        years = txtyears.Text
        amount = txtamount.Text
        rate = txtrate.Text

        If IsNumeric(years) = True Then
            If IsNumeric(amount) = True Then
                If IsNumeric(rate) = True Then

                    If rdbtnsimple.Checked = True Then
                        interesttype = "simple"
                    End If

                    If rdbtncompound.Checked = True Then
                        interesttype = "compound"
                    End If

                    If interesttype = "simple" Then

                        decimalperc = (rate / 100)
                        result = amount + (amount * decimalperc * years)
                        lblresult.Text = "Return: " & result

                    ElseIf interesttype = "compound" Then

                        decimalperc = 1 + (rate / 100)
                        result = amount * (decimalperc ^ years)
                        lblresult.Text = "Return: " & result

                    End If

                    profit = result - amount
                    lblprof.Text = "Profit: " & profit

                Else
                    MessageBox.Show("Please enter a number in the rate field")
                End If
            Else
                    MessageBox.Show("Please enter a number in the amount field")
            End If
        Else
                MessageBox.Show("Please enter a number in the years field")
        End If
    End Sub

End Class