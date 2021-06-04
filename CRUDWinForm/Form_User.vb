Public Class Form_User
    Private Sub OpenEditForm(ByVal editModeActive As Boolean)
        If Me.DataGridView1.SelectedRows.Count = 1 Or Not editModeActive Then
            Me.Hide()
            If editModeActive Then
                DisplayEditModeForm()
            Else
                DisplayCreateModeForm()
            End If
        Else
            MsgBox("Please select a row for edit")
        End If
    End Sub

    Private Sub DisplayCreateModeForm()
        Dim EditForm As New Form_Edit(False, New User)
        EditForm.ShowDialog()
        UpdateCRUDData()
        Me.Show()
    End Sub

    Private Sub DisplayEditModeForm()
        Dim editUser As New User
        SetUserPropertiesWithDataGrid(editUser)
        Dim EditForm As New Form_Edit(True, editUser)
        EditForm.Label_EditHeader.Text = "Editing Username: " & editUser.UserName
        EditForm.GroupBox_Edit.Text = "Edit User Information"
        EditForm.ShowDialog()
        UpdateCRUDData()
        Me.Show()
    End Sub

    Private Sub SetUserPropertiesWithDataGrid(ByRef currentUser As User)
        With currentUser
            .UserName = DataGridView1.SelectedRows.Item(0).Cells(0).Value
            .Password = DataGridView1.SelectedRows.Item(0).Cells(1).Value
            .FirstName = DataGridView1.SelectedRows.Item(0).Cells(2).Value
            .LastName = DataGridView1.SelectedRows.Item(0).Cells(3).Value
            .EmailAddress = DataGridView1.SelectedRows.Item(0).Cells(4).Value
            .PhoneNumber = DataGridView1.SelectedRows.Item(0).Cells(5).Value
        End With
    End Sub

    '   EVENTS
    Private Sub Form_User_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UpdateCRUDData()
    End Sub

    Private Sub UpdateCRUDData()
        Dim SQL As New SQLControls
        Me.DataGridView1.DataSource = SQL.GetDataTable()
    End Sub

    Private Sub Button_Create_Click(sender As Object, e As EventArgs) Handles Button_Create.Click
        OpenEditForm(False)
    End Sub

    Private Sub Button_Edit_Click(sender As Object, e As EventArgs) Handles Button_Edit.Click
        OpenEditForm(True)
    End Sub

    Private Sub Button_Delete_Click(sender As Object, e As EventArgs) Handles Button_Delete.Click
        If Me.DataGridView1.SelectedRows.Count = 1 Then
            If Me.DataGridView1.Rows.Count <> 2 Then
                If MessageBox.Show("Are you sure you want to delete this user?", "This user will be gone forever!", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                    Dim deleteUser As New User
                    SetUserPropertiesWithDataGrid(deleteUser)
                    deleteUser.Delete()
                    UpdateCRUDData()
                End If
            Else
                MsgBox("Please do not delete our last user!")
            End If
        Else
            MsgBox("Please select a single row to delete")
        End If
    End Sub

End Class