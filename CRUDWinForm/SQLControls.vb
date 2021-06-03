Imports System.Data.SqlClient
Public Class SQLControls
    Private SQLCON As New SqlConnection("Data Source=DESKTOP-9FJ3D74;Initial Catalog=CRUDUsers;Integrated Security=True")
    Private SQLCMD As SqlCommand
    Private SQLDA As SqlDataAdapter
    Private SQLDS As DataSet

    Public Function IsAuthenticated(ByVal username As String, ByVal password As String) As Boolean
        Try
            SQLCON.Open()

            SQLCMD = SQLCON.CreateCommand
            SQLDA = New SqlDataAdapter(SQLCMD)
            SQLDS = New DataSet()
            SQLCMD.CommandType = CommandType.StoredProcedure
            SQLCMD.Parameters.Add(New SqlParameter("@Username", username))
            SQLCMD.Parameters.Add(New SqlParameter("@Password", password))
            SQLCMD.CommandText = "ValidateUserCredentials"
            SQLDA.Fill(SQLDS)
            SQLCON.Close()
            If SQLDS.Tables(0).Rows.Count() <= 0 Then
                Return False
            Else
                Return True
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            If SQLCON.State = ConnectionState.Open Then SQLCON.Close()
            Return False
        End Try
    End Function

    Public Function GetDataTable() As DataTable
        Try
            SQLCON.Open()
            SQLCMD = SQLCON.CreateCommand
            SQLDA = New SqlDataAdapter(SQLCMD)
            SQLDS = New DataSet()
            SQLCMD.CommandType = CommandType.StoredProcedure
            SQLCMD.CommandText = "GetAllUsers"
            SQLDA.Fill(SQLDS)
            SQLCON.Close()
            Return SQLDS.Tables.Item(0)
        Catch ex As Exception
            MsgBox(ex.Message)
            If SQLCON.State = ConnectionState.Open Then SQLCON.Close()
            Return Nothing
        End Try
    End Function

    Public Function AddNewUser(ByVal username As String, ByVal password As String, ByVal firstName As String, ByVal lastName As String, ByVal emailAddress As String, ByVal phoneNumber As String) As Boolean
        Try
            SQLCON.Open()
            SQLCMD = SQLCON.CreateCommand
            SQLDA = New SqlDataAdapter(SQLCMD)
            SQLDS = New DataSet()
            SQLCMD.CommandType = CommandType.StoredProcedure
            SQLCMD.Parameters.Add(New SqlParameter("@Username", username))
            SQLCMD.Parameters.Add(New SqlParameter("@Password", password))
            SQLCMD.Parameters.Add(New SqlParameter("@FirstName", firstName))
            SQLCMD.Parameters.Add(New SqlParameter("@LastName", lastName))
            SQLCMD.Parameters.Add(New SqlParameter("@Email", emailAddress))
            SQLCMD.Parameters.Add(New SqlParameter("@PhoneNumber", phoneNumber))
            SQLCMD.CommandText = "AddUser"
            SQLCMD.ExecuteNonQuery()
            SQLCON.Close()
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            If SQLCON.State = ConnectionState.Open Then SQLCON.Close()
            Return False
        End Try
    End Function

    Public Function EditUser(ByVal username As String, ByVal password As String, ByVal firstName As String, ByVal lastName As String, ByVal emailAddress As String, ByVal phoneNumber As String) As Boolean
        Try
            SQLCON.Open()
            SQLCMD = SQLCON.CreateCommand
            SQLDA = New SqlDataAdapter(SQLCMD)
            SQLDS = New DataSet()
            SQLCMD.CommandType = CommandType.StoredProcedure
            SQLCMD.Parameters.Add(New SqlParameter("@Username", username))
            SQLCMD.Parameters.Add(New SqlParameter("@Password", password))
            SQLCMD.Parameters.Add(New SqlParameter("@FirstName", firstName))
            SQLCMD.Parameters.Add(New SqlParameter("@LastName", lastName))
            SQLCMD.Parameters.Add(New SqlParameter("@Email", emailAddress))
            SQLCMD.Parameters.Add(New SqlParameter("@PhoneNumber", phoneNumber))
            SQLCMD.CommandText = "UpdateUser"
            SQLCMD.ExecuteNonQuery()
            SQLCON.Close()
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            If SQLCON.State = ConnectionState.Open Then SQLCON.Close()
            Return False
        End Try
    End Function
End Class
