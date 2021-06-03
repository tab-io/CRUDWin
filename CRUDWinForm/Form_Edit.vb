Public Class Form_Edit

    Private _editMode As Boolean
    Private _activeUser As String
    Private _editUser As New User

    Public Property EditUser() As User
        Get
            Return _editUser
        End Get
        Set(ByVal value As User)
            _editUser = value
        End Set
    End Property
    Public Property EditMode() As Boolean
        Get
            Return _editMode
        End Get
        Set(ByVal value As Boolean)
            _editMode = value
        End Set
    End Property

    Public Property ActiveUser() As String
        Get
            Return _activeUser
        End Get
        Set(ByVal value As String)
            _activeUser = value
        End Set
    End Property

    Private Sub Form_Edit_Load(sender As Object, e As EventArgs) Handles Me.Load
        If _editMode Then
            Me.TextBox_EmailAddress.Text = _editUser.EmailAddress
            Me.TextBox_FirstName.Text = _editUser.FirstName
            Me.TextBox_LastName.Text = _editUser.LastName
            Me.TextBox_Password.Text = _editUser.Password
            Me.TextBox_PhoneNumber.Text = _editUser.PhoneNumber
            Me.TextBox_Username.Text = _editUser.UserName
        End If
    End Sub
    Private Sub Button_Save_Click(sender As Object, e As EventArgs) Handles Button_Save.Click
        If _editMode Then
            If _editUser.Edit() Then
                MsgBox("mucho success")
                Me.Hide()
            Else
                MsgBox("no good")
            End If
        Else
            CreateNewUser()
        End If
    End Sub

    Private Sub CreateNewUser()
        If _editUser.Add() Then
            Me.Hide()
        Else

        End If
    End Sub

    Private Sub Button_Cancel_Click(sender As Object, e As EventArgs) Handles Button_Cancel.Click
        If MessageBox.Show("Are you sure you want to cancel?", IIf(_editMode, "Cancelling Edit Mode", "Cancelling Create Mode"), MessageBoxButtons.YesNo) = DialogResult.Yes Then Me.Hide()
    End Sub
End Class