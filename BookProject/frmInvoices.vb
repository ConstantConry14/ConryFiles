Imports BookProjectBusiness

Public Class frmInvoices

    Private Sub frmInvoices_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        Me.SalesTableAdapter.FillByUniqueOrderNums(Me.BookCollectionDataSet.sales)
        grdSales.Rows.Item(0).Selected = True
        checkRow(0)
    End Sub

    Private Sub btnInvoiceOrder_Click(sender As Object, e As EventArgs) Handles btnInvoiceOrder.Click
        For Each record As DataGridViewRow In grdSales.SelectedRows
            Dim objInvoice As InvoiceBO = New InvoiceBO(record.Cells.Item(2).Value, record.Cells.Item(1).Value, 0, 0)
            Try
                objController.invoiceOrder(objInvoice)
            Catch ex As Exception
                MessageBox.Show(ex.Message, "ERROR")
                Return
            End Try
        Next

        Dim intDialogResult As Integer = MessageBox.Show("Order invoiced, would you like to view the invoice?", "NOTIFICATION", MessageBoxButtons.YesNo)
        Select Case intDialogResult
            Case DialogResult.Yes
                viewInvoice()
            Case Else
                Return
        End Select
    End Sub

    Private Sub btnViewInvoice_Click(sender As Object, e As EventArgs) Handles btnViewInvoice.Click
        viewInvoice()
    End Sub

    Private Sub grdSales_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles grdSales.CellClick
        Try
            checkRow(e.RowIndex)
        Catch ex As Exception
            Return
        End Try
    End Sub

    Public Sub viewInvoice()
        Try
            Dim objInvoice As InvoiceBO = _
                objController.GetInvoiceByOrderNumber(grdSales.SelectedRows.Item(0).Cells.Item(1).Value)
            Dim frmViewInvoice As New frmViewInvoice(objInvoice)
            frmViewInvoice.ShowDialog()
        Catch ex As Exception
            MessageBox.Show("This order doesn't have an invoice, unable to display.", "ERROR")
        End Try
    End Sub

    Private Sub checkRow(ByVal intIndex As Integer)
        If grdSales.Rows.Item(intIndex).Cells.Item(2).Value = 0 Then
            btnInvoiceOrder.Enabled = False
            btnViewInvoice.Enabled = False
        Else
            btnInvoiceOrder.Enabled = True
            btnViewInvoice.Enabled = True
        End If
    End Sub

End Class