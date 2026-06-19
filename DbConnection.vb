Imports MySql.Data.MySqlClient
Module DbConnection
    Private ReadOnly connString As String = "Server=localhost;Database=petcaredb;User Id=root;Password=;"

    ' Function returns a MySqlConnection object (closed)
    Public Function GetConnection() As MySqlConnection
        Dim conn As New MySqlConnection(connString)
        ' Do not open here, open in calling code
        Return conn
    End Function

    ' Test DB connection
    Public Function TestConnection() As Boolean
        Try
            Using conn As New MySqlConnection(connString)
                conn.Open()
                conn.Close()
            End Using
            Return True
        Catch ex As Exception
            MessageBox.Show("Database Connection Failed: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function
End Module
