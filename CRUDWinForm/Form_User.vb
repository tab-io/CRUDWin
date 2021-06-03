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

    End Sub

    Private Sub SetUserPropertiesFromSelectedDataGridRow(ByRef currentUser As User, ByRef dataRow As DataGridViewRow)

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