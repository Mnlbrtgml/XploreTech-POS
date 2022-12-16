Imports MySql.Data.MySqlClient

Module DatabaseConnection

    Public stmt As String
    Public cmd As MySqlCommand

    Public Function Conn() As MySqlConnection
        Return New MySqlConnection("server=localhost;user id=root;database=dbpointofsale;password=password")
        'Return New MySqlConnection("server=localhost;user id=root;database=dbpointofsale;password=")
    End Function

    Public Function Command(ByVal stmt As String, ByVal conn As MySqlConnection) As MySqlCommand
        Return New MySqlCommand(stmt, conn)
    End Function
End Module
