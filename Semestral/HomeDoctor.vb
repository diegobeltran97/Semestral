Imports MySql.Data.MySqlClient
Imports System.Security
Imports System.Security.Cryptography
Imports System.IO
Imports System.Runtime.InteropServices
Imports System.Text.RegularExpressions
Imports System.Text
Public Class HomeDoctor
    Public dbconn As New MySqlConnection
    Public sql As String
    Public dbcomm As New MySqlCommand
    Public dbread As MySqlDataReader
    Public datos As DataSet
    Dim FilaActual As Integer
    Dim usuario As Integer

    Private Sub HomeDoctor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbconn = New MySqlConnection("server=localhost;user=admin;password=123456;database=clinica;")
        Dim Status As String


        Try
            dbconn.Open()
        Catch ex As Exception
            MsgBox("Connection Error: " & ex.Message.ToString)
        End Try


        MostrarCitas()
    End Sub

    Private Sub MostrarCitas()
        Dim adaptador As MySqlDataAdapter
        Dim datatable As DataTable
        sql = "SELECT c.id, u.nombre, c.hora, c.motivo, e.nombre as 'Status'FROM citas c inner join usuario u on c.user_id = u.id inner join citas_status e on c.estado_id = e.status_id"
        'adaptador = New MySqlDataAdapter(sql, dbconn)'


        Try
            'dbcomm = New MySqlCommand(sql, dbconn)'
            adaptador = New MySqlDataAdapter(sql, dbconn)
            'dbread = dbcomm.ExecuteReader()'
            'da.Fill(tbl)
            '

            ' While dbread.Read'

            datos = New DataSet
            adaptador.Fill(datos, "citas")
                'lista = datos.Tables("usuario").Rows.Count

                'If lista <> 0 Then
                DataGridCitas.DataSource = datos
                DataGridCitas.DataMember = "citas"

            'comboroleUser.Items.Add(dbread("id").ToString().ToUpper() & "." & dbread("Tipo").ToString().ToUpper())'
            ' End While'


        Catch ex As Exception
            MsgBox("Problem loading data: " & ex.Message.ToString)
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

    Private Sub TabPage1_Click(sender As Object, e As EventArgs) Handles TabPage1.Click

    End Sub

    Private Sub DataGridCitas_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridCitas.CellContentClick


        FilaActual = DataGridCitas.CurrentRow.Index
        txtUsuario.Text = DataGridCitas.Rows(FilaActual).Cells(0).Value
        usuario = Convert.ToInt32(txtUsuario.Text)


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click

        Dim adaptador As MySqlDataAdapter
        Dim datatable As DataTable



        ' sql = "UPDATE `citas` SET `estado_id`= 2  WHERE id='" & Text.txtUsuario & "'"'
        sql = "UPDATE `citas` SET `estado_id`= 2  WHERE id='" & usuario & "'"

        Try


            dbcomm = New MySqlCommand(sql, dbconn)
            dbread = dbcomm.ExecuteReader()
            dbread.Close()

            MsgBox("Estado de la cita actualizado.")
            MostrarCitas()


        Catch ex As Exception
            MsgBox("Problem with data: " & ex.Message.ToString)
        End Try


    End Sub

    Private Sub comboroleStatus_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub
End Class