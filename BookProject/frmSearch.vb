Imports BookProjectBusiness

Public Class frmSearch

    Private Sub btnFind_Click(sender As Object, e As EventArgs) Handles btnFind.Click
        If txtTitle.Text = "" Then
            MessageBox.Show("Can not search for an empty title.", "ERROR")
        Else
            Dim lstTempResults As List(Of TitlesBO) = objController.FindByTitle(txtTitle.Text)
            If lstTempResults.Count > 1 Then
                Dim intDialogResult = MessageBox.Show("We've found more than 1 title with this name." & vbNewLine & _
                                                      vbNewLine & "Would you like to view the results?", "CONFIRMATION", _
                                                      MessageBoxButtons.YesNo)
                Select Case intDialogResult
                    Case DialogResult.Yes
                        Dim frmResults = New frmResults(lstTempResults)
                        frmResults.ShowDialog()
                    Case Else
                        Me.Close()
                End Select
            Else
                MessageBox.Show("We've found your title, and selected it for the order.", "NOTICE")
                objFoundTitle = lstTempResults.Item(0)
                Me.Close()
            End If
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        'If the text box is not empty, then
        If txtTitle.Text <> "" Then
            'Show them some kind of confirmation.
            Dim intResult As Integer = MessageBox.Show("Are you sure you want to exit?", "Confirmation", MessageBoxButtons.YesNo)
            'If the user selects No, then don't do anything
            Select Case intResult
                Case DialogResult.No
                    'Else, close out the form
                Case Else
                    Me.Close()
            End Select
            'Any other case, you close out the form
        Else
            Me.Close()
        End If
    End Sub

    Private Sub frmSearch_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        txtTitle.Text = ""
    End Sub
End Class