Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'MembersDataSet.Membership' table. You can move, or remove it, as needed.
        Me.MembershipTableAdapter.Fill(Me.MembersDataSet.Membership)

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        MembersTableAdapter.Insert(10, "Hasegwe", "Han", "305-954-0544", #5/15/2014 , 1)
    End Sub
End Class
