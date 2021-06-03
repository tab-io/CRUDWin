Imports System.Data.SqlClient
Public Class SQLControls
    Private SQLCON As New SqlConnection("Data Source=DESKTOP-9FJ3D74;Initial Catalog=CRUDUsers;Integrated Security=True")
    Private SQLCMD As SqlCommand
    Public SQLDA As SqlDataAdapter
    Public SQLDS As DataSet

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

            If SQLDS.Tables(0).Rows.Count() <= 0 Then
                Return False
            Else
                Return True
            End If

            SQLCON.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            If SQLCON.State = ConnectionState.Open Then SQLCON.Close()
            Return False
        End Try
    End Function

    Public Sub PopulateDataSetInfo(ByRef ds As DataSet)
        Try
            SQLCON.Open()

            SQLCMD = SQLCON.CreateCommand
            SQLDA = New SqlDataAdapter(SQLCMD)
            SQLDS = New DataSet()
            SQLCMD.CommandType = CommandType.StoredProcedure
            SQLCMD.CommandText = "GetAllUsers"
            SQLDA.Fill(ds)

            SQLCON.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            If SQLCON.State = ConnectionState.Open Then SQLCON.Close()
        End Try
    End Sub
End Class
