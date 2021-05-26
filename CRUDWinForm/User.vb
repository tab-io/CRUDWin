Public Class User

    Private _username As String
    Private _password As String
    Private _firstName As String
    Private _lastName As String
    Private _phoneNumber As String
    Private _emailAddress As String

    Public ReadOnly Property UserName() As String
        Get
            Return _username
        End Get
    End Property

    Public ReadOnly Property Password() As String
        Get
            Return _password
        End Get
    End Property

    Public ReadOnly Property FirstName() As String
        Get
            Return _firstName
        End Get
    End Property

    Public ReadOnly Property LastName() As String
        Get
            Return _lastName
        End Get
    End Property

    Public ReadOnly Property PhoneNumber() As String
        Get
            Return _phoneNumber
        End Get
    End Property

    Public ReadOnly Property EmailAddress() As String
        Get
            Return _emailAddress
        End Get
    End Property

End Class
