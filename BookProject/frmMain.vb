Imports BookProjectBusiness

Public Class frmMain
    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            objController = New DatabaseControllerBO()
        Catch ex As Exception
            MessageBox.Show("Could not open Database connection: " + ex.Message)
            Me.Close()
        End Try
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        MessageBox.Show("Books Extra Sale System v1.0" _
                        & vbNewLine & vbNewLine & _
                        "Authors: Leonard Torres, Fiorella Silvana Vilchez, and Conry Williams", "About")
    End Sub

    Private Sub btnOrder_Click(sender As Object, e As EventArgs) Handles btnOrder.Click
        frmOrders.ShowDialog()
    End Sub

    Private Sub btnMaintenance_Click(sender As Object, e As EventArgs) Handles btnMaintenance.Click
        frmMaintenance.ShowDialog()
    End Sub

    Private Sub btnReport_Click(sender As Object, e As EventArgs) Handles btnReport.Click
        frmReports.ShowDialog()
    End Sub

    Private Sub mnuExit_Click(sender As Object, e As EventArgs) Handles mnuExit.Click
        Me.Close()
    End Sub

    Private Sub frmMain_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Try
            objController.Close()
        Catch ex As Exception
            Return
        End Try
    End Sub
End Class