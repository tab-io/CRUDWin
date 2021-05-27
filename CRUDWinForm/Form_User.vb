Public Class Form_User
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub Form_User_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'CRUDUsersDataSet.CRUDUsers_tbl' table. You can move, or remove it, as needed.
        Me.CRUDUsers_tblTableAdapter.Fill(Me.CRUDUsersDataSet.CRUDUsers_tbl)

    End Sub
End Class