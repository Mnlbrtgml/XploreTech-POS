Imports MySql.Data.MySqlClient
Imports System.Security.Cryptography
Imports System.IO
Module AuthUser
    Public LoggedUser As User = Nothing
    Private enc As System.Text.UTF8Encoding
    Private encryptor As ICryptoTransform
    Private decryptor As ICryptoTransform

    ''' <summary>
    ''' Return True if myPassword is valid.
    ''' </summary>
    ''' <param name="myPassword">Contains string with minimum length of 8 characters with atleast one numberic, lower, upper character.</param>
    ''' <returns>Boolean True or False.</returns>
    Public Function ValidPassword(myPassword As String) As Boolean
        If myPassword.Length < 8 Then Return False
        If Not myPassword.Any(Function(c) Char.IsDigit(c)) Then Return False
        If Not myPassword.Any(Function(c) Char.IsLower(c)) Then Return False
        If Not myPassword.Any(Function(c) Char.IsUpper(c)) Then Return False
        Return True
    End Function

    ''' <summary>
    ''' Return True if myUsername is valid.
    ''' </summary>
    ''' <param name="myUsername">myUsername must have atleast 8 characters.</param>
    ''' <returns>Boolean True or False.</returns>
    Public Function ValidUser(myUsername As String) As Boolean
        If myUsername.Length < 8 Then Return False
        Return True
    End Function

    Public Function EncryptPassword(ByVal text As String) As String
        Dim KEY_128 As Byte() = {42, 1, 52, 67, 231, 13, 94, 101, 123, 6, 0, 12, 32, 91, 4, 111, 31, 70, 21, 141, 123, 142, 234, 82, 95, 129, 187, 162, 12, 55, 98, 23}
        Dim IV_128 As Byte() = {234, 12, 52, 44, 214, 222, 200, 109, 2, 98, 45, 76, 88, 53, 23, 78}
        Dim symmetricKey As RijndaelManaged = New RijndaelManaged()
        symmetricKey.Mode = CipherMode.CBC

        enc = New System.Text.UTF8Encoding
        encryptor = symmetricKey.CreateEncryptor(KEY_128, IV_128)
        decryptor = symmetricKey.CreateDecryptor(KEY_128, IV_128)

        Dim pass As String = ""
        Dim sPlainText As String = text
        If Not String.IsNullOrEmpty(sPlainText) Then
            Dim memoryStream As MemoryStream = New MemoryStream()
            Dim cryptoStream As CryptoStream = New CryptoStream(memoryStream, encryptor, CryptoStreamMode.Write)
            cryptoStream.Write(enc.GetBytes(sPlainText), 0, sPlainText.Length)
            cryptoStream.FlushFinalBlock()
            pass = Convert.ToBase64String(memoryStream.ToArray())
            memoryStream.Close()
            cryptoStream.Close()
        End If
        Return pass
    End Function

    Public Function DecryptPassword(ByVal text As String) As String
        Dim KEY_128 As Byte() = {42, 1, 52, 67, 231, 13, 94, 101, 123, 6, 0, 12, 32, 91, 4, 111, 31, 70, 21, 141, 123, 142, 234, 82, 95, 129, 187, 162, 12, 55, 98, 23}
        Dim IV_128 As Byte() = {234, 12, 52, 44, 214, 222, 200, 109, 2, 98, 45, 76, 88, 53, 23, 78}
        Dim symmetricKey As RijndaelManaged = New RijndaelManaged()
        symmetricKey.Mode = CipherMode.CBC

        enc = New System.Text.UTF8Encoding
        encryptor = symmetricKey.CreateEncryptor(KEY_128, IV_128)
        decryptor = symmetricKey.CreateDecryptor(KEY_128, IV_128)
        Dim pass As String = ""
        Try
            Dim cypherTextBytes As Byte() = Convert.FromBase64String(text)
            Dim memoryStream As MemoryStream = New MemoryStream(cypherTextBytes)
            Dim cryptoStream As CryptoStream = New CryptoStream(memoryStream, decryptor, CryptoStreamMode.Read)
            Dim plainTextBytes(cypherTextBytes.Length) As Byte
            Dim decryptedByteCount As Integer = cryptoStream.Read(plainTextBytes, 0, plainTextBytes.Length)
            memoryStream.Close()
            cryptoStream.Close()
            pass = enc.GetString(plainTextBytes, 0, decryptedByteCount)
        Catch ex As Exception

        End Try

        Return pass
    End Function

    Public Function AuthenticateQR(ByVal decoded As String)

        Dim msg As String = ""

        Using con = Conn()
            Dim stmt As String = "SELECT * FROM user WHERE CONCAT(Username, Password) = @decoded"
            cmd = Command(stmt, con)
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("decoded", decoded)
            con.Open()

            Dim drr As MySqlDataReader = cmd.ExecuteReader

            drr.Read()

            If (drr.HasRows) Then

                LoggedUser = New User()
                With LoggedUser
                    .FullName = drr.GetValue(drr.GetOrdinal("Full_Name"))
                    .UserType = drr.GetValue(drr.GetOrdinal("User_Type"))
                    .ID = drr.GetValue(drr.GetOrdinal("User_ID"))
                    .Username = drr.GetValue(drr.GetOrdinal("Username"))
                    .Password = drr.GetValue(drr.GetOrdinal("Password"))
                End With

            Else
                msg = "Invalid QRcode!"
            End If

            con.Close()
        End Using

        Return msg

    End Function
End Module

Public Class UserAuthentication

    Public Function CheckUserIfExist(ByVal user As String)
        Dim exists As Boolean
        Using connection As MySqlConnection = Conn()
            connection.Open()
            Dim stmt As String = "SELECT * FROM user WHERE CONCAT(Full_Name, User_Type) = @user"

            cmd = New MySqlCommand(stmt, connection)
            cmd.Parameters.AddWithValue("user", user)

            Dim rdr As MySqlDataReader = cmd.ExecuteReader()

            rdr.Read()
            If (rdr.HasRows) Then
                exists = True
            Else
                exists = False
            End If
        End Using

        Return exists

    End Function

    Public Function AuthenticateUser(ByVal username As String, ByVal password As String)

        Dim msg As String = ""

        Using con As MySqlConnection = Conn()
            stmt = "SELECT * FROM user WHERE Username = @username"
            cmd = Command(stmt, con)
            With cmd.Parameters
                .Clear()
                .AddWithValue("username", username)
            End With
            con.Open()
            Dim drr As MySqlDataReader = cmd.ExecuteReader

            drr.Read()
            If drr.HasRows Then

                Dim pass As String = DecryptPassword(drr.GetValue(drr.GetOrdinal("Password")))

                If pass = password Then
                    LoggedUser = New User()
                    With LoggedUser
                        .FullName = drr.GetValue(drr.GetOrdinal("Full_Name"))
                        .UserType = drr.GetValue(drr.GetOrdinal("User_Type"))
                        .ID = drr.GetValue(drr.GetOrdinal("User_ID"))
                        .Username = drr.GetValue(drr.GetOrdinal("Username"))
                        .Password = DecryptPassword(drr.GetValue(drr.GetOrdinal("Password")))
                    End With
                Else
                    msg = "Wrong password"
                End If

            Else
                msg = "Invalid username or password!"
            End If

        End Using
        Return msg
    End Function

End Class

Class User

    Private _id As String

    Public Property ID() As String
        Get
            Return _id
        End Get
        Set(ByVal value As String)
            _id = value
        End Set
    End Property

    Private _full_name As String

    Public Property FullName() As String
        Get
            Return _full_name
        End Get
        Set(ByVal value As String)
            _full_name = value
        End Set


    End Property

    Private _userType As String

    Public Property UserType() As String
        Get
            Return _userType
        End Get
        Set(ByVal value As String)
            _userType = value
        End Set

    End Property

    Private _username As String

    Public Property Username() As String
        Get
            Return _username
        End Get
        Set(ByVal value As String)
            _username = value
        End Set

    End Property

    Private _password As String

    Public Property Password() As String
        Get
            Return _password
        End Get
        Set(ByVal value As String)
            _password = value
        End Set

    End Property

End Class
