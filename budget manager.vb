Public Class budget_manager

    Dim items(999) As String
    Dim prices(999) As Double
    Dim totalexpense As Double
    Dim remaining As Double

    Dim counter As Integer

    Private Sub btnadd_Click(sender As Object, e As EventArgs) Handles btnadd.Click

        Dim item As String = ""
        Dim price As Double
        Dim budget As Double

        budget = txtbudget.Text
        item = InputBox("Please enter the name of the item or expense")
        price = InputBox("Please enter the price of " & item)

        If IsNumeric(budget) = True Then
            If IsNumeric(price) = True Then

                lstbxbudget.Items.Add(item & ", " & price)
                items(counter) = item
                prices(counter) = price
                counter = counter + 1

                totalexpense = totalexpense + price
                lbltotal.Text = "Total Expenses: " & totalexpense
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
        lblremaining.Text = "Remaining:"
        lbltotal.Text = "Total Expenses:"
        totalexpense = 0
        remaining = 0

    End Sub

    Private Sub btnsrt_Click(sender As Object, e As EventArgs) Handles btnsrt.Click

        Dim i As Integer
        Dim index As Integer = 0

        'Dim spareint As Integer

        ReDim Preserve items(counter)
        ReDim Preserve prices(counter)

        If cmbxbudget.SelectedIndex = 0 Then

            Do Until prices(index) < prices(index + 1)

            Loop

        ElseIf cmbxbudget.SelectedIndex = 1 Then

            ' Do Until 

            'Loop

        End If

        For i = 0 To counter
            lstbxbudget.Items.Add(items(i) & ", " & prices(i))
        Next
    End Sub
End Class