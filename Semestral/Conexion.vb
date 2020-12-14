Imports MySql.Data.MySqlClient
Public Class Conexion





    Public conDb As New MySqlConnection("server=localhost;user=root;password=tecnomysql;database=clinica;")

    Public dbcomm As New MySqlCommand
    Public dbread As MySqlDataReader
    Sub conectar()
        Try
            conDb.Open()
            MessageBox.Show("Conectado al servidor")
        Catch ex As Exception
            MessageBox.Show("Erro")
        End Try
    End Sub

    Sub cerrar()
        conDb.Close()
    End Sub

End Class
