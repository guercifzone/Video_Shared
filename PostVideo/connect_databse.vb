Imports MySql.Data.MySqlClient

Public Class connect_databse
      Dim connect As New MySqlConnection
    Dim cmd As New MySqlCommand

    Public Function get_data() As Boolean
        connect = New MySqlConnection
        connect.ConnectionString = "server=localhost;userid=root;password=aqwzsxedc;database=postvideo;"
        Try
            connect.Open()
            connect.Close()
            connect = Nothing
            Return True

        Catch ex As Exception
            MessageBox.Show(ex.Message)
            connect = Nothing
            cmd = Nothing
            Return False
        End Try

    End Function



End Class
