Public Class User
    Private _intID As Integer
    Private _strUsername As String
    Private _strPassword As String

    Public Property ID() As Integer
        Get
            Return _intID
        End Get
        Set(value As Integer)
            _intID = value
        End Set
    End Property
    'Username can be viewed and changed
    Public Property Username() As String
        Get
            Return _strUsername
        End Get
        Set(value As String)
            _strUsername = value
        End Set
    End Property

    'Password can only be changed
    Public WriteOnly Property Password() As String
        Set(value As String)
            _strPassword = value
        End Set
    End Property

    'Use this to check if inputted password is correct
    Public Function checkPassword(ByVal strInput As String)

        'Declaring Boolean for testing
        Dim blnTest As Boolean = False

        'If password is correct change to true
        If strInput = _strPassword Then
            blnTest = True
        End If

        'Output result
        Return blnTest

    End Function
End Class
