Imports MySql.Data.MySqlClient
Public Class Login
    Public dbconn As New MySqlConnection
    Public sql As String
    Public dbcomm As New MySqlCommand
    Public dbread As MySqlDataReader



    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        dbconn = New MySqlConnection("server=localhost;user=root;password=tecnomysql;database=clinica;")

        Try
            dbconn.Open()
        Catch ex As Exception
            MsgBox("Connection Error: " & ex.Message.ToString)
        End Try
    End Sub
    Private Sub buttonLogin_Click(sender As Object, e As EventArgs) Handles buttonLogin.Click
        Dim email As String = inputEmail.Text
        Dim password As String = inputPassword.Text
        sql = "SELECT * FROM usuario where email ='" + email + "' and password = '" + password + " ' "


        Try
            dbcomm = New MySqlCommand(sql, dbconn)
            dbread = dbcomm.ExecuteReader()

            If (dbread.HasRows) Then

                While dbread.Read
                    System.Console.WriteLine(dbread("nombre").ToString())
                    MessageBox.Show("Login sucess Welcome to Homepage " + dbread("nombre").ToString())
                End While
            Else
                MessageBox.Show("Incorrect password or email")
            End If
        Catch ex As Exception
            MsgBox("Problem loading data: " & ex.Message.ToString)
        End Try
        dbread.Close()
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click

    End Sub

    Private Sub RegistrarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegistrarToolStripMenuItem.Click
        Registrar.Show()
    End Sub
End Class