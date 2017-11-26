Public Class frmReports


    Private Sub frmReports_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BookCollectionDataSet.sales' table. You can move, or remove it, as needed.
        Me.SalesTableAdapter.Fill(Me.BookCollectionDataSet.sales)

    End Sub
End Class