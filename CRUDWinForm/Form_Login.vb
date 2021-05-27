Public Class Form_Login

    Dim CRUDUser As New User
    Private Sub Button_Login_Click(sender As Object, e As EventArgs) Handles Button_Login.Click
        UserLogin()
    End Sub

    Private Sub Button_Login_KeyDown(sender As Object, e As KeyEventArgs) Handles Button_Login.KeyDown
        If e.KeyCode = Keys.Enter Then UserLogin()
    End Sub

    Private Sub UserLogin()
        CRUDUser.UserName = Me.TextBox_Username.Text
        CRUDUser.Password = Me.TextBox_Password.Text
        If CRUDUser.Login() Then
            Me.Hide()
            Dim UserForm As New Form_User
            UserForm.Show()
            Me.Show()
        Else
            MsgBox("Sorry, this is not a valid login. Please try again")
        End If
    End Sub
End Class
