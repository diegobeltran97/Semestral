Imports MySql.Data.MySqlClient
Imports System.Security
Imports System.Security.Cryptography
Imports System.IO
Imports System.Runtime.InteropServices
Imports System.Text.RegularExpressions
Imports System.Text

Public Class HomeUser

    Public dbconn As New MySqlConnection
    Public sql As String
    Public dbcomm As New MySqlCommand
    Public dbread As MySqlDataReader
    Private Sub HomeUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbconn = New MySqlConnection("server=localhost;user=root;password=tecnomysql;database=clinica;")
        Try
            dbconn.Open()
        Catch ex As Exception
            MsgBox("Connection Error: " & ex.Message.ToString)
        End Try
    End Sub

    Private Sub TabControl1_DrawItem(ByVal sender As Object, ByVal e As System.Windows.Forms.DrawItemEventArgs) Handles TabControl1.DrawItem
        Dim g As Graphics
        Dim sText As String

        Dim iX As Integer
        Dim iY As Integer
        Dim sizeText As SizeF

        Dim ctlTab As TabControl

        ctlTab = CType(sender, TabControl)

        g = e.Graphics

        sText = ctlTab.TabPages(e.Index).Text
        sizeText = g.MeasureString(sText, ctlTab.Font)

        iX = e.Bounds.Left + 6
        iY = e.Bounds.Top + (e.Bounds.Height - sizeText.Height) / 2

        g.DrawString(sText, ctlTab.Font, Brushes.Black, iX, iY)
    End Sub

    Private Sub buttonAddCita_Click(sender As Object, e As EventArgs) Handles buttonAddCita.Click
        Dim fechaCita As String
        Dim horaCita As String
        Dim motivo As String

        fechaCitaText.CustomFormat = "yyyy-MM-dd"

        fechaCita = fechaCitaText.Value.ToString("yyyy-M-d")
        horaCita = horaCitaText.Value.ToString("HH:mm:ss")
        motivo = motivoCitaText.Text


        System.Console.WriteLine(fechaCitaText.Value)

        sql = "INSERT INTO citas(user_id,fecha,hora, motivo ) VALUES('" + "2" + " ', '" + fechaCita + "' , '" + horaCita + " ','" + motivo + "')"


        Try
            dbcomm = New MySqlCommand(sql, dbconn)
            dbread = dbcomm.ExecuteReader()
            dbread.Close()
            MsgBox("Data inserted.")
        Catch ex As Exception
            MsgBox("Failed to insert data: " & ex.Message.ToString())
        End Try
        dbread.Close()






    End Sub
End Class