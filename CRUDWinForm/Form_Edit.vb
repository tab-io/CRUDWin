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
        If CheckForRequiredFields() Then
            PopulateUserFromFormFields()
            If MessageBox.Show("Does this information look correct?", "Please verify user information", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                If _editMode Then
                    EditSelectedUser()
                Else
                    CreateNewUser()
                End If
            End If
        Else
            MsgBox("All fields are required!", vbCritical)
        End If
    End Sub

    Private Function CheckForRequiredFields() As Boolean
        CheckForRequiredFields = Me.TextBox_EmailAddress.Text <> vbNullString And
                                 Me.TextBox_FirstName.Text <> vbNullString And
                                 Me.TextBox_LastName.Text <> vbNullString And
                                 Me.TextBox_Password.Text <> vbNullString And
                                 Me.TextBox_PhoneNumber.Text <> vbNullString And
                                 Me.TextBox_Username.Text <> vbNullString
    End Function

    Private Sub EditSelectedUser()
        If _editUser.Edit(_editUsername) Then
            Me.Hide()
        Else
            DisplayInputError()
        End If
    End Sub

    Private Sub CreateNewUser()
        If _editUser.Add() Then
            Me.Hide()
        Else
            DisplayInputError()
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

    Private Sub DisplayInputError()
        Select Case _editUser.SQLCheckConstraint
            Case "CHK_ValidUsername"
                MsgBox("Your username must be at least 5 characters.")
            Case "CHK_ValidPassword"
                MsgBox("Your password must be at least 5 characters.")
            Case "CHK_ValidFirstName"
                MsgBox("Surely this user has a first name?")
            Case "CHK_ValidLastName"
                MsgBox("Surely this user has a last name?")
            Case "CHK_ValidEmail"
                MsgBox("Please use a valid email Ex. JohnDoe@example.com")
            Case "CHK_ValidPhone"
                MsgBox("Please enter your phone number, area code included for a total of 10 numbers.")
            Case Else
                MsgBox(_editUser.SQLCheckConstraint)
        End Select
    End Sub
End Class