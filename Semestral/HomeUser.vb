Imports MySql.Data.MySqlClient
Imports GlobalVariables

Public Class HomeUser

    Public dbconn As New MySqlConnection
    Public sql As String
    Public dbcomm As New MySqlCommand
    Public dbread As MySqlDataReader
    Dim row As String()
    Private Sub HomeUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbconn = New MySqlConnection("server=localhost;user=admin;password=123456;database=clinica;")




        Try
            dbconn.Open()
        Catch ex As Exception
            MsgBox("Connection Error: " & ex.Message.ToString)
        End Try

        sql = "SELECT * FROM `citas` where user_id = '" + GlobalVariables.userId.ToString + "' " + "and " + "covid = ' " + "2" + " ' "
        Try
            dbcomm = New MySqlCommand(sql, dbconn)
            dbread = dbcomm.ExecuteReader()

            If (dbread.HasRows) Then
                MsgBox("Usted tiene covid")
            End If

        Catch ex As Exception
            MsgBox("Problem loading data: " & ex.Message.ToString)
        End Try
        dbread.Close()

        inicio()
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
    Private Sub inicio()
        nombrePaciente.Text = GlobalVariables.userName
    End Sub

    Private Sub buttonAddCita_Click(sender As Object, e As EventArgs) Handles buttonAddCita.Click
        Dim fechaCita As String
        Dim horaCita As String
        Dim motivo As String

        fechaCitaText.CustomFormat = "yyyy-MM-dd"

        fechaCita = fechaCitaText.Value.ToString("yyyy-M-d")
        horaCita = horaCitaText.Value.ToString("HH:mm:ss")
        motivo = motivoCitaText.Text




        sql = "INSERT INTO citas(user_id,fecha,hora, motivo ) VALUES('" + GlobalVariables.userId.ToString + " ', '" + fechaCita + "' , '" + horaCita + " ','" + motivo + "')"


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

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub


    Private Sub TabControl1_Selected(sender As Object, e As System.Windows.Forms.TabControlEventArgs) Handles TabControl1.Selected
        DataGridView1.Rows.Clear()
        If (e.TabPageIndex.ToString = "1") Then
            sql = "SELECT fecha , hora , motivo, estado_id FROM citas where user_id = '" + GlobalVariables.userId.ToString + " ' "
            Try
                dbcomm = New MySqlCommand(sql, dbconn)
                dbread = dbcomm.ExecuteReader()
                While dbread.Read

                    row = New String() {dbread("fecha").ToString(), dbread("hora").ToString(), dbread("motivo").ToString(), dbread("estado_id").ToString()}

                    DataGridView1.Rows.Add(row)

                End While
            Catch ex As Exception
                MsgBox("Problem loading data: " & ex.Message.ToString)
            End Try
            dbread.Close()
        End If

    End Sub

    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click
        GlobalVariables.userId = Nothing
        GlobalVariables.userName = ""
        Me.Hide()
        Login.Show()
    End Sub
End Class