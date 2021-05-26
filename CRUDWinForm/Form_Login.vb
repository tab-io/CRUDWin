Public Class Form_Login

    Dim CRUDUser As New User
    Private Sub Button_Login_Click(sender As Object, e As EventArgs) Handles Button_Login.Click
        CRUDUser.UserName = Me.TextBox_Username.Text
        CRUDUser.Password = Me.TextBox_Password.Text
        CRUDUser.Login()
    End Sub

End Class
