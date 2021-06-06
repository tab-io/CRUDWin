Imports System.Data.SqlClient
Public Class SQLControls
    Private SQLCON As New SqlConnection("Data Source=DESKTOP-9FJ3D74;Initial Catalog=CRUDUsers;Integrated Security=True")
    Private SQLCMD As SqlCommand
    Private SQLDA As SqlDataAdapter
    Private SQLDS As DataSet

    Public Function IsAuthenticated(username As String, password As String) As Boolean
        Try
            SQLCON.Open()
            SQLCMD = SQLCON.CreateCommand
            SQLDA = New SqlDataAdapter(SQLCMD)
            SQLDS = New DataSet()

            With SQLCMD
                .CommandType = CommandType.StoredProcedure
                .Parameters.Add(New SqlParameter("@Username", username))
                .Parameters.Add(New SqlParameter("@Password", password))
                .CommandText = "ValidateUserCredentials"
            End With

            SQLDA.Fill(SQLDS)
            Return SQLDS.Tables(0).Rows.Count() > 0
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            If SQLCON.State = ConnectionState.Open Then SQLCON.Close()
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
            Return SQLDS.Tables.Item(0)
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        Finally
            If SQLCON.State = ConnectionState.Open Then SQLCON.Close()
        End Try
    End Function

    Public Function AddNewUser(username As String, password As String, firstName As String, lastName As String, emailAddress As String, phoneNumber As String) As Boolean
        Try
            SQLCON.Open()
            SQLCMD = SQLCON.CreateCommand

            With SQLCMD
                .CommandType = CommandType.StoredProcedure
                With .Parameters
                    .Add(New SqlParameter("@Username", username))
                    .Add(New SqlParameter("@Password", password))
                    .Add(New SqlParameter("@FirstName", firstName))
                    .Add(New SqlParameter("@LastName", lastName))
                    .Add(New SqlParameter("@Email", emailAddress))
                    .Add(New SqlParameter("@PhoneNumber", phoneNumber))
                End With
                .CommandText = "AddUser"
                .ExecuteNonQuery()
            End With

            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            If SQLCON.State = ConnectionState.Open Then SQLCON.Close()
        End Try
    End Function

    Public Function EditUser(username As String, password As String, firstName As String, lastName As String, emailAddress As String, phoneNumber As String, editUsername As String) As Boolean
        Try
            SQLCON.Open()
            SQLCMD = SQLCON.CreateCommand

            With SQLCMD
                .CommandType = CommandType.StoredProcedure
                With .Parameters
                    .Add(New SqlParameter("@Username", username))
                    .Add(New SqlParameter("@Password", password))
                    .Add(New SqlParameter("@FirstName", firstName))
                    .Add(New SqlParameter("@LastName", lastName))
                    .Add(New SqlParameter("@Email", emailAddress))
                    .Add(New SqlParameter("@PhoneNumber", phoneNumber))
                    .Add(New SqlParameter("@EditUsername", editUsername))
                End With
                .CommandText = "UpdateUser"
                .ExecuteNonQuery()
            End With

                Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            If SQLCON.State = ConnectionState.Open Then SQLCON.Close()
        End Try
    End Function

    Public Function DeleteUser(username As String) As Boolean
        Try
            SQLCON.Open()
            SQLCMD = SQLCON.CreateCommand

            With SQLCMD
                .CommandType = CommandType.StoredProcedure
                .Parameters.Add(New SqlParameter("@Username", username))
                .CommandText = "DeleteUser"
                .ExecuteNonQuery()
            End With

            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            If SQLCON.State = ConnectionState.Open Then SQLCON.Close()
        End Try
    End Function
End Class
