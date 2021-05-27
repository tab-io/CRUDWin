Module Program

    Public Const conString As String = "Data Source=DESKTOP-9FJ3D74;Initial Catalog=CRUDUsers;Integrated Security=True"
    Public Sub Main()
        Application.EnableVisualStyles()
        Application.SetCompatibleTextRenderingDefault(False)
        Application.Run(New Form_Login)
    End Sub

End Module
