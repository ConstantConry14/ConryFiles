Imports BookProjectBusiness

Public Class frmOrders

    Private Sub frmOrders_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.StoresTableAdapter1.Fill(Me.BookCollectionDataSet1.stores)
        Me.TitlesTableAdapter1.FillActiveTitles(Me.BookCollectionDataSet1.titles)
        cboStore.SelectedIndex = -1
        lstTitles.SelectedIndex = -1
        txtFirst.Focus()
    End Sub

    Private Sub frmOrders_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        If Not objFoundTitle Is Nothing Then
            lstTitles.SetSelected(lstTitles.FindString(objFoundTitle.Title), True)
            objFoundTitle = Nothing
        End If
    End Sub

    Private Sub btnPlaceOrder_Click(sender As Object, e As EventArgs) Handles btnPlaceOrder.Click
        Dim objOrder As OrderBO
        Dim lstSelectedTitles As New List(Of String)
        Dim hasError As Boolean = False

        If txtFirst.Text = "" Then
            errFirstName.SetError(txtFirst, "First Name can not be blank.")
            hasError = True
        Else
            errFirstName.SetError(txtFirst, "")
        End If

        If txtLast.Text = "" Then
            errLastName.SetError(txtLast, "Last Name can not be blank.")
            hasError = True
        Else
            errLastName.SetError(txtLast, "")
        End If

        If txtPhoneNumber.Text = "(   )    -" Then
            errTelNumber.SetError(txtPhoneNumber, "Telephone Number can not be blank.")
            hasError = True
        ElseIf txtPhoneNumber.Text.Length < 10 Then
            errTelNumber.SetError(txtPhoneNumber, "This is not a valid telephone number.")
            hasError = True
        Else
            errTelNumber.SetError(txtPhoneNumber, "")
        End If

        If txtAddress.Text = "" Then
            errAddress.SetError(txtAddress, "Address can not be blank.")
            hasError = True
        Else
            errAddress.SetError(txtAddress, "")
        End If

        If txtCity.Text = "" Then
            errCity.SetError(txtCity, "City can not be blank.")
            hasError = True
        Else
            errCity.SetError(txtCity, "")
        End If

        If txtState.Text = "" Then
            errState.SetError(txtState, "State can not be blank.")
            hasError = True
        ElseIf txtState.Text.Length < 2 Then
            errState.SetError(txtState, "This is not a valid state.")
            hasError = True
        Else
            errState.SetError(txtState, "")
        End If

        If txtZip.Text = "" Then
            errZip.SetError(txtZip, "ZIP can not be blank.")
            hasError = True
        ElseIf txtZip.Text.Length < 5 Then
            errZip.SetError(txtZip, "This is not a valid ZIP code")
            hasError = True
        Else
            errZip.SetError(txtZip, "")
        End If

        If lstTitles.SelectedItems.Count = 0 Then
            errBookTitle.SetError(lstTitles, "You must select at least one title.")
            hasError = True
        Else
            errBookTitle.SetError(lstTitles, "")
        End If

        If cboStore.SelectedIndex = -1 Then
            errStoreNum.SetError(cboStore, "You must select a store number.")
            hasError = True
        Else
            errStoreNum.SetError(cboStore, "")
        End If

        If txtQuantity.Text = "" Then
            errQuantity.SetError(txtQuantity, "You must enter a quantity.")
            hasError = True
        ElseIf txtQuantity.Text > 5000 Then
            errQuantity.SetError(txtQuantity, "This is an invalid quanitity, max in one order is 5000.")
            hasError = True
        ElseIf txtQuantity.Text <= 0 Then
            errQuantity.SetError(txtQuantity, "This is an invalid quanitity, minimum in an order is 1.")
            hasError = True
        Else
            errQuantity.SetError(txtQuantity, "")
        End If



        If hasError = False Then

            For Each objItem As DataRowView In lstTitles.SelectedItems
                lstSelectedTitles.Add(objItem.Row.Item(0).ToString())
            Next

            objOrder = New OrderBO(txtFirst.Text, _
                                   txtLast.Text, _
                                   txtPhoneNumber.Text, _
                                   txtAddress.Text, _
                                   txtCity.Text, _
                                   txtState.Text, _
                                   txtZip.Text, _
                                   rtbSpecialInstructions.Text, _
                                   lstSelectedTitles, _
                                   CInt(cboStore.SelectedItem.Row.Item(0)), _
                                   txtQuantity.Text)

        Else
            Return
        End If

        Try
            objController.processOrder(objOrder)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ERROR")
            Return
        End Try
        clearEverything()
        MessageBox.Show("Order placed!", "NOTICE")
    End Sub

    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        Me.Close()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        confirmAction()
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        frmSearch.ShowDialog()
    End Sub

    Private Sub btnInvoices_Click(sender As Object, e As EventArgs) Handles btnInvoices.Click
        frmInvoices.ShowDialog()
    End Sub

    Private Sub frmOrders_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        confirmAction(e)
    End Sub

    Private Sub confirmAction()
        Dim dialogResult As Integer = MessageBox.Show("Any unsaved work will be lost, continue?", "CONFIRMATION", MessageBoxButtons.YesNoCancel)
        Select Case dialogResult
            Case Windows.Forms.DialogResult.Yes
            Case Else
                Return
        End Select
        clearEverything()
        txtFirst.Focus()
    End Sub

    Private Sub confirmAction(e As FormClosingEventArgs)
        Dim dialogResult As Integer = MessageBox.Show("Do you really want to exit the orders form?", "CONFIRMATION", MessageBoxButtons.YesNoCancel)
        Select Case dialogResult
            Case Windows.Forms.DialogResult.Yes
            Case Else
                e.Cancel = True
                Return
        End Select
        clearEverything()
    End Sub

    Private Sub clearEverything()
        errFirstName.SetError(txtFirst, "")
        errLastName.SetError(txtLast, "")
        errTelNumber.SetError(txtPhoneNumber, "")
        errAddress.SetError(txtAddress, "")
        errCity.SetError(txtCity, "")
        errState.SetError(txtState, "")
        errZip.SetError(txtZip, "")
        errBookTitle.SetError(lstTitles, "")
        errStoreNum.SetError(cboStore, "")
        errQuantity.SetError(txtQuantity, "")
        txtFirst.ResetText()
        txtLast.ResetText()
        txtPhoneNumber.ResetText()
        txtAddress.ResetText()
        txtCity.ResetText()
        txtState.ResetText()
        txtZip.ResetText()
        rtbSpecialInstructions.ResetText()
        lstTitles.SelectedIndex = -1
        cboStore.SelectedIndex = -1
        txtQuantity.ResetText()
    End Sub

End Class
