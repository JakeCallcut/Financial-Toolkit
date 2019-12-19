Public Class budget_manager
    Private Sub btnadd_Click(sender As Object, e As EventArgs) Handles btnadd.Click

        Dim item As String = ""
        Dim price As Double
        Dim budget As Double
        Dim totalexpense As Double
        Dim remaining As Double

        budget = txtbudget.Text
        item = InputBox("Please enter the name of the item or expense")
        price = InputBox("Please enter the price of " & item)

        If IsNumeric(budget) = True Then
            If IsNumeric(price) = True Then

                lstbxbudget.Items.Add(item & ", " & price)

                totalexpense = totalexpense + price
                lbltotal.text = "Total Expenses: " & totalexpense
                remaining = budget - totalexpense
                lblremaining.Text = "Remaining: " & remaining

            Else
                MessageBox.Show("Please enter a number in the price field")
            End If
        Else
            MessageBox.Show("Please enter a number in the budget field")
        End If


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnback.Click

        Me.Close()
        frmmenu.Show()

    End Sub

    Private Sub btnclr_Click(sender As Object, e As EventArgs) Handles btnclr.Click

        lstbxbudget.Items.Clear()

    End Sub
End Class