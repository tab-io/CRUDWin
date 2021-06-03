Public Class Form_User

    Dim SQL As New SQLControls

    Private _activeUser As String
    Public Property ActiveUser() As String
        Get
            Return _activeUser
        End Get
        Set(ByVal value As String)
            _activeUser = value
        End Set
    End Property

    Private Sub OpenEditForm(ByVal editModeActive As Boolean)
        If Me.DataGridView1.SelectedRows.Count = 1 Or Not editModeActive Then
            Me.Hide()
            Dim EditForm As New Form_Edit
            EditForm.EditMode = editModeActive
            If editModeActive Then
                Dim editUser As New User
                SetUserPropertiesWithDataGrid(editUser)
                EditForm.EditUser = editUser
                EditForm.Label_EditHeader.Text = "Editing User: " ' & current user form user property
                EditForm.GroupBox_Edit.Text = "Edit User Information"
            End If
            EditForm.ActiveUser = _activeUser
            EditForm.ShowDialog()
            UpdateCRUDData()
            Me.Show()
        Else
            MsgBox("Please select a row for edit")
        End If
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
        Me.DataGridView1.DataSource = SQL.GetDataTable
    End Sub

    Private Sub Button_Create_Click(sender As Object, e As EventArgs) Handles Button_Create.Click
        OpenEditForm(False)
    End Sub

    Private Sub Button_Edit_Click(sender As Object, e As EventArgs) Handles Button_Edit.Click
        OpenEditForm(True)
    End Sub

    Private Sub Button_Delete_Click(sender As Object, e As EventArgs) Handles Button_Delete.Click

    End Sub

End Class