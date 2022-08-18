Imports MySql.Data.MySqlClient

Module ActivityLog

    Public Function ActLog(activity As String)
        Dim query As Integer = 0

        Using con As MySqlConnection = Conn()
            stmt = "INSERT INTO activitylog SET User_ID = @uid, Name = @fullname, " _
                    & "Activity = @activity, Created_At = @createdat"
            cmd = Command(stmt, con)
            With cmd.Parameters
                .AddWithValue("uid", LoggedUser.ID)
                .AddWithValue("fullname", LoggedUser.FullName)
                .AddWithValue("activity", activity)
                .AddWithValue("createdat", Date.Now)
            End With
            con.Open()
            query = cmd.ExecuteNonQuery
        End Using

        Return query
    End Function

End Module