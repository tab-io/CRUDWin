Public Class Form_Login

    Private CRUDUser As New User
    Private Sub Button_Login_Click(sender As Object, e As EventArgs) Handles Button_Login.Click
        UserLogin()
    End Sub

    Private Sub Button_Login_KeyDown(sender As Object, e As KeyEventArgs) Handles Button_Login.KeyDown
        If e.KeyCode = Keys.Enter Then UserLogin()
    End Sub

    Private Sub UserLogin()
        CRUDUser.UserName = Me.TextBox_Username.Text
        CRUDUser.Password = Me.TextBox_Password.Text
        Try
            CRUDUser.Login()
            Me.Hide()
            Dim UserForm As New Form_User
            UserForm.ShowDialog()
            Me.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

End Class
