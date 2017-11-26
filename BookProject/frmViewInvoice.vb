Imports BookProjectBusiness

Public Class frmViewInvoice
    Private objInvoice As InvoiceBO
    Private objOrder As OrderBO

    Public Sub New(ByVal invoice As InvoiceBO)
        InitializeComponent()
        objInvoice = invoice
    End Sub

    Private Sub frmViewInvoice_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        Try
            lblHeader.Text = "Invoice Number " + objInvoice.InvoiceNumber.ToString()
            lblDisplayOrderNo.Text = objInvoice.OrderNumber
            lblDisplaySubTotal.Text = objInvoice.SubTotal.ToString("c")
            lblDisplayTotal.Text = objInvoice.Total.ToString("c")
            objOrder = objController.GetInvoiceDetails(objInvoice.OrderNumber)
            lblDisplayFirstName.Text = objOrder.FirstName
            lblDisplayLastName.Text = objOrder.LastName
            lblDisplayTelNum.Text = objOrder.TelephoneNumber
            lblDisplayAddr.Text = objOrder.Address
            lblDisplayCity.Text = objOrder.City
            lblDisplayState.Text = objOrder.State
            lblDisplayZip.Text = objOrder.Zip
            lblDisplayInstructions.Text = objOrder.Instructions
        Catch ex As Exception
            Me.DestroyHandle()
            MessageBox.Show("No invoice exists for this order.")
            Me.Close()
        End Try
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

End Class