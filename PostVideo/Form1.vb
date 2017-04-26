Imports MySql.Data.MySqlClient
Public Class Form1



    Dim mysqlconnect As MySqlConnection
    Dim mysqlcmd As MySqlCommand
    Dim mylink As String
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Txt_CPU.Text = CpuId()

        Dim data As New connect_databse
        If data.get_data = True Then
            Label_connection.Visible = True
            Label_connection.ForeColor = Color.Green
        Else
            Label_connection.Visible = True
            Label_connection.ForeColor = Color.Red
            Label_connection.Text = "&Databse Is Not Connected!!"

        End If



    End Sub



    Private Function CpuId() As String
        Dim computer As String = "."
        Dim wmi As Object = GetObject("winmgmts:" & "{impersonationLevel=impersonate}!\\" & computer & "\root\cimv2")
        Dim processors As Object = wmi.ExecQuery("Select * from Win32_Processor")

        Dim cpu_ids As String = ""
        For Each cpu As Object In processors
            cpu_ids = cpu_ids & ", " & cpu.ProcessorId
        Next cpu
        If cpu_ids.Length > 0 Then cpu_ids = cpu_ids.Substring(2)

        Return cpu_ids
    End Function



    Private Sub Btn_Post_Click(sender As Object, e As EventArgs) Handles Btn_Post.Click
        Dim sttuf As String = Txt_Link.Text
        Dim len As Integer = sttuf.Length

        mylink = sttuf.Substring(32, len - 32)

        mysqlconnect = New MySqlConnection
        mysqlconnect.ConnectionString = "server=localhost;userid=root;password=aqwzsxedc;database=postvideo;"
        Dim mysqlreader As MySqlDataReader

        Try
            mysqlconnect.Open()
            Dim QUERY As String
            QUERY = "insert postvideo.video (name,type,newlink)VALUES('" & Txt_Title.Text & "','" & Combo_Type.Text & "','" & mylink & "')"
            mysqlcmd = New MySqlCommand(QUERY, mysqlconnect)
            mysqlreader = mysqlcmd.ExecuteReader

            MsgBox("Post to  database ")

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            mysqlconnect.Dispose()
            mysqlcmd.Dispose()
            ' mysqlreader.Dispose()

        End Try

    End Sub

    Private Sub Txt_Link_Validated(sender As Object, e As EventArgs) Handles Txt_Link.Validated
        Dim lix As String
        'https://youtbe.com/qazwsxedcrfv=qweeserrt
        lix = InStr(Txt_Link.Text, "https://youtbe.com")
        If lix <> 0 Then
        Else

            MsgBox("please put https youtube link!!")


        End If
    End Sub


End Class
