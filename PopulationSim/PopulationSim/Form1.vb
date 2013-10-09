Option Strict On

Public Class Form1

    Private Sub btnPopulation_Click(sender As System.Object, e As System.EventArgs) Handles btnPopulation.Click

        Dim currentyear As Integer
        Dim currentpop As Double

        currentyear = 2012
        currentpop = 7000

        Do While (currentpop > 6)
            currentyear = currentyear - 50
            currentpop = currentpop / 2
        Loop
        MessageBox.Show("The Year Is " & currentyear, "Error")



    End Sub
End Class
