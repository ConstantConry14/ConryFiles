Public Class frmConverter

   

    Private Sub frmConverter_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    
    Private Sub btnCalucate_Click(sender As Object, e As EventArgs) Handles btnCalucate.Click
        Const dblPound_Factor As Double = 0.68
        Const dblEuro_Factor As Double = 0.83
        Const dblYen_Factor As Double = 108.36

        Dim dblDollar_Factor As Double = CDbl(txtDollar.Text)


        Dim dblPound As Double = dblDollar_Factor * dblPound_Factor
        Dim dblEuro As Double = dblDollar_Factor * dblEuro_Factor
        Dim dblYen As Double = dblDollar_Factor * dblYen_Factor

        txtDollar.Text = dblDollar_Factor.ToString("C2", CultureInfo.CreateSpecificCulture("en-US"))
        txtPound.Text = dblDollar_Factor.ToString("C2", CultureInfo.CreateSpecificCulture("en-GR"))
        txtYen.Text = dblDollar_Factor.ToString("C2", CultureInfo.CreateSpecificCulture("ja-Jp"))
        txtEuro.Text = dblDollar_Factor.ToString("", CultureInfo.CreateSpecificCulture("fr-FR"))
    End Sub
End Class
