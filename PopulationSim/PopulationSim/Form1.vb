Option Strict On

Public Class Form1

    Private Sub btnPopulation_Click(sender As System.Object, e As System.EventArgs) Handles btnPopulation.Click
        Dim CurPop As Double
        Dim CurYEar As Integer

        CurYEar = 2012
        CurPop = 7000

        Do While (CurPop >= 6)
            CurYEar = (CurYEar - 50)
            CurPop = CurPop / 2


        Loop



        MessageBox.Show("The population wwas less than 6 million in " & CurYEar, "Error")

    End Sub

End Class
