Imports MathLibrary
Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim objmath As BasicMathFunctions = New BasicMathFunctions
        txtResult.Text = objmath.add(CInt(txtNum1.Text), CInt(txtNum2.Text))
    End Sub

    Private Sub btnSubtract_Click(sender As Object, e As EventArgs) Handles btnSubtract.Click

    End Sub
End Class
