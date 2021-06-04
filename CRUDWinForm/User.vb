Public Class User

    Inherits SQLControls

    Private _username As String
    Private _password As String
    Private _firstName As String
    Private _lastName As String
    Private _phoneNumber As String
    Private _emailAddress As String

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
        Return IsAuthenticated(_username, _password)
    End Function

    Public Function Add() As Boolean
        Return AddNewUser(_username, _password, _firstName, _lastName, _emailAddress, _phoneNumber)
    End Function

    Public Function Edit(editUsername As String) As Boolean
        Return EditUser(_username, _password, _firstName, _lastName, _emailAddress, _phoneNumber, editUsername)
    End Function

    Public Function Delete() As Boolean
        Return DeleteUser(_username)
    End Function

End Class
