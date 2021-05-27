Public Class Form_Edit

    Private _editMode As Boolean
    Public Property EditMode() As Boolean
        Get
            Return _editMode
        End Get
        Set(ByVal value As Boolean)
            _editMode = value
        End Set
    End Property

    Private Sub Button_Save_Click(sender As Object, e As EventArgs) Handles Button_Save.Click
        If _editMode Then

        Else
            CreateNewUser()
        End If
    End Sub

    Private Sub CreateNewUser()
        Dim addedUser As New User
        SetUserPropertiesWithFormText(addedUser)
        If addedUser.Add() Then
            Me.Hide()
        Else
            MsgBox("This username is currently being used, please try a different name.")
        End If
    End Sub

    Private Sub Button_Cancel_Click(sender As Object, e As EventArgs) Handles Button_Cancel.Click
        If MessageBox.Show("Are you sure you want to cancel?", IIf(_editMode, "Cancelling Edit Mode", "Cancelling Create Mode"), MessageBoxButtons.YesNo) = DialogResult.Yes Then Me.Hide()
    End Sub

    Private Sub SetUserPropertiesWithFormText(ByRef currentUser As User)
        With currentUser
            .UserName = TextBox_Username.Text
            .Password = TextBox_Password.Text
            .FirstName = TextBox_FirstName.Text
            .LastName = TextBox_LastName.Text
            .EmailAddress = TextBox_EmailAddress.Text
            .PhoneNumber = TextBox_PhoneNumber.Text
        End With
    End Sub
End Class