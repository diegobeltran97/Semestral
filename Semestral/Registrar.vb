Imports MySql.Data.MySqlClient
Public Class Registrar
    Public dbconn As New MySqlConnection
    Public sql As String
    Public dbcomm As New MySqlCommand
    Public dbread As MySqlDataReader
    Private Sub Registrar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbconn = New MySqlConnection("server=localhost;user=root;password=tecnomysql;database=clinica;")

        Try
            dbconn.Open()
        Catch ex As Exception
            MsgBox("Connection Error: " & ex.Message.ToString)
        End Try


        sql = "SELECT * FROM t_usuario"
        Try
            dbcomm = New MySqlCommand(sql, dbconn)
            dbread = dbcomm.ExecuteReader()
            While dbread.Read
                comboroleUser.Items.Add(dbread("id").ToString().ToUpper() & "." & dbread("Tipo").ToString().ToUpper())
            End While
        Catch ex As Exception
            MsgBox("Problem loading data: " & ex.Message.ToString)
        End Try
        dbread.Close()
    End Sub

End Class