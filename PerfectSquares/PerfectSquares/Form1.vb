Public Class Form1

    Private Sub btnDisplay_Click(sender As System.Object, e As System.EventArgs) Handles btnDisplay.Click
        Dim num As Integer = 1
        Dim sqr As Integer

        lstResult.Items.Clear()
        Do While num <= 9

            num = num + 1
            sqr = num ^ 2
            lstResult.Items.Add("The perfect square is " & sqr)



        Loop


        lstResult.Items.Add("These are the first 10 perfect squares!")

    End Sub
End Class
