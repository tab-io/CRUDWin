Imports System.Data.SqlClient
Public Class User

    Private _username As String
    Private _password As String
    Private _firstName As String
    Private _lastName As String
    Private _phoneNumber As String
    Private _emailAddress As String

    Const conString As String = "Data Source=DESKTOP-9FJ3D74;Initial Catalog=CRUDUsers;Integrated Security=True"

    Public Property UserName() As String
        Get
            Return _username
        End Get
        Set(ByVal value As String)
            _username = value
        End Set
    End Property

    Public Property Password() As String
        Get
            Return _password
        End Get
        Set(ByVal value As String)
            _password = value
        End Set
    End Property

    Public Property FirstName() As String
        Get
            Return _firstName
        End Get
        Set(ByVal value As String)
            _firstName = value
        End Set
    End Property

    Public Property LastName() As String
        Get
            Return _lastName
        End Get
        Set(ByVal value As String)
            _lastName = value
        End Set
    End Property

    Public Property PhoneNumber() As String
        Get
            Return _phoneNumber
        End Get
        Set(ByVal value As String)
            _phoneNumber = value
        End Set
    End Property

    Public Property EmailAddress() As String
        Get
            Return _emailAddress
        End Get
        Set(ByVal value As String)
            _emailAddress = value
        End Set
    End Property

    Public Function Login() As Boolean

        Dim sqlCon As New SqlConnection(conString)
        Dim cmd As SqlCommand = sqlCon.CreateCommand

        sqlCon.Open()
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add(New SqlParameter("@Username", _username))
        cmd.Parameters.Add(New SqlParameter("@Password", _password))
        cmd.CommandText = "ValidateUserCredentials"
        If cmd.ExecuteScalar() Then
            Login = True
        Else
            Login = False
        End If
        sqlCon.Close()

    End Function

End Class
