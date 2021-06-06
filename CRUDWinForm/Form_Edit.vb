Public Class Form_Edit

    Private _editMode As Boolean
    Private _editUsername As String
    Private _editUser As New User

    Public Sub New(inEditMode As Boolean, editUser As User)
        InitializeComponent()
        _editMode = inEditMode
        _editUser = editUser
        If inEditMode Then
            PopulateFormFields()
            _editUsername = _editUser.UserName
        End If
    End Sub

    Private Sub Button_Save_Click(sender As Object, e As EventArgs) Handles Button_Save.Click
        PopulateUserFromFormFields()
        If MessageBox.Show("Does this information look correct?", "Please verify user information", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            If _editMode Then
                If _editUser.Edit(_editUsername) Then
                    Me.Hide()
                End If
            Else
                CreateNewUser()
            End If
        End If
    End Sub

    Private Sub CreateNewUser()
        If _editUser.Add() Then
            Me.Hide()
        End If
    End Sub

    Private Sub Button_Cancel_Click(sender As Object, e As EventArgs) Handles Button_Cancel.Click
        If MessageBox.Show("Are you sure you want to cancel?", IIf(_editMode, "Cancelling Edit Mode", "Cancelling Create Mode"), MessageBoxButtons.YesNo) = DialogResult.Yes Then Me.Hide()
    End Sub

    Private Sub PopulateFormFields()
        With _editUser
            Me.TextBox_EmailAddress.Text = .EmailAddress
            Me.TextBox_FirstName.Text = .FirstName
            Me.TextBox_LastName.Text = .LastName
            Me.TextBox_Password.Text = .Password
            Me.TextBox_PhoneNumber.Text = .PhoneNumber
            Me.TextBox_Username.Text = .UserName
        End With
    End Sub

    Private Sub PopulateUserFromFormFields()
        With _editUser
            .EmailAddress = Me.TextBox_EmailAddress.Text
            .FirstName = Me.TextBox_FirstName.Text
            .LastName = Me.TextBox_LastName.Text
            .Password = Me.TextBox_Password.Text
            .PhoneNumber = Me.TextBox_PhoneNumber.Text
            .UserName = Me.TextBox_Username.Text
        End With
    End Sub
End Class