Public Class Form_User

    Private Sub Form_User_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UpdateCRUDData()
    End Sub

    Private Sub UpdateCRUDData()
        Me.CRUDUsers_tblTableAdapter.Fill(Me.CRUDUsersDataSet.CRUDUsers_tbl)
    End Sub

    Private Sub Button_Create_Click(sender As Object, e As EventArgs) Handles Button_Create.Click
        OpenEditForm(False)
    End Sub

    Private Sub Button_Edit_Click(sender As Object, e As EventArgs) Handles Button_Edit.Click
        OpenEditForm(True)
    End Sub

    Private Sub Button_Delete_Click(sender As Object, e As EventArgs) Handles Button_Delete.Click
        If (DataGridView1.SelectedRows.Count = 1) Then
            Dim dataRow As DataGridViewRow = DataGridView1.Rows(DataGridView1.FirstDisplayedScrollingRowIndex)
            Dim deleteUser As New User
            If deleteUser.Delete() Then
                SetUserPropertiesFromSelectedDataGridRow(deleteUser, dataRow)
            Else

            End If
        End If
    End Sub

    Private Sub SetUserPropertiesFromSelectedDataGridRow(ByRef currentUser As User, ByRef dataRow As DataGridViewRow)
        With currentUser
            .Password = dataRow.Cells(0).Value.ToString
        End With
    End Sub

    Private Sub OpenEditForm(ByVal enableEdit As Boolean)
        Me.Hide()
        Dim EditForm As New Form_Edit
        EditForm.EditMode = enableEdit
        If enableEdit Then
            EditForm.Label_EditHeader.Text = "Editing User: " ' & current user form user property
            EditForm.GroupBox_Edit.Text = "Edit User Information"
        End If
        EditForm.ShowDialog()
        UpdateCRUDData()
        Me.Show()
    End Sub

End Class