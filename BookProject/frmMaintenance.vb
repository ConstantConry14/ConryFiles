Public Class frmMaintenance

    Private Sub AuthorsBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub frmMaintenance_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BookCollectionDataSet.titles' table. You can move, or remove it, as needed.
        Me.TitlesTableAdapter.Fill(Me.BookCollectionDataSet.titles)

       

    End Sub

    Private Sub TitleToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles mnuTitles.Click

        If mnuTitles.Checked = True Then

        End If

    End Sub

    Private Sub AuthorsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles mnuAuthors.Click

        If TitlesDataGridView.DataSource = mnuAuthors Then


        End If
    End Sub

    Private Sub PublisherToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles mnuPublishers.Click

        If TitlesDataGridView.DataSource = mnuPublishers Then

        End If
    End Sub
End Class