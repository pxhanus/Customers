Public Class Form1
    Structure CustomerInfo
        Dim firstName As String
        Dim lastName As String
        Dim balance As Double
    End Structure
    Private Sub btnCustomerInfo_Click(sender As Object, e As EventArgs) Handles btnCustomerInfo.Click
        Dim customers(4) As CustomerInfo
        Dim highestBalance As Double = 0
        Dim highestBalanceIndex As Integer
        For index As Integer = 0 To customers.Length - 1
            customers(index).firstName = InputBox("Please enter the customer's first name:", "Customer " & index)
            customers(index).lastName = InputBox("Please enter the customer's last name:", "Customer " & index)
            customers(index).balance = InputBox("Please enter the customer's account balance:", "Customer " & index)
        Next

        'Finds highest customer balance
        For index As Integer = 0 To customers.Length - 1
            If customers(index).balance Then
                highestBalance = customers(index).balance
                highestBalanceIndex = index
            End If
        Next
    End Sub
End Class
