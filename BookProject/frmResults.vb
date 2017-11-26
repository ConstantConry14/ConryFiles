Imports BookProjectBusiness

Public Class frmResults
    Private lstTitleResults As List(Of TitlesBO)

    Public Sub New(ByRef lstListFromSearch As List(Of TitlesBO))
        InitializeComponent()
        lstTitleResults = lstListFromSearch
    End Sub

    Private Sub frmResults_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For Each Title In lstTitleResults
            lstResults.Items.Add(Title.Title)
        Next
    End Sub

    Private Sub btnSelect_Click(sender As Object, e As EventArgs) Handles btnSelect.Click
        objFoundTitle = lstTitleResults.Item(lstResults.SelectedIndex)
        MessageBox.Show("Title selected, please check the order to make sure this is the correct title.", "NOTICE")
        Me.Close()
        frmSearch.Close()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
End Class