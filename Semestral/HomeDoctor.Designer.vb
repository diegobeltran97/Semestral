<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class HomeDoctor
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.nombreDoctor = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.LogoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.btnCovid = New System.Windows.Forms.Button()
        Me.txtUsuario = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnActualizar = New System.Windows.Forms.Button()
        Me.DataGridCitas = New System.Windows.Forms.DataGridView()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.MenuStrip1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.DataGridCitas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'nombreDoctor
        '
        Me.nombreDoctor.AutoSize = True
        Me.nombreDoctor.BackColor = System.Drawing.Color.Transparent
        Me.nombreDoctor.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nombreDoctor.Location = New System.Drawing.Point(354, 24)
        Me.nombreDoctor.Name = "nombreDoctor"
        Me.nombreDoctor.Size = New System.Drawing.Size(86, 29)
        Me.nombreDoctor.TabIndex = 2
        Me.nombreDoctor.Text = "Label2"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.CadetBlue
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LogoutToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(928, 24)
        Me.MenuStrip1.TabIndex = 3
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'LogoutToolStripMenuItem
        '
        Me.LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        Me.LogoutToolStripMenuItem.Size = New System.Drawing.Size(41, 20)
        Me.LogoutToolStripMenuItem.Text = "Salir"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(177, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(183, 29)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Bienvenido, Dr. "
        '
        'TabPage2
        '
        Me.TabPage2.Location = New System.Drawing.Point(124, 4)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(693, 327)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Pacientes Alert"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.btnCovid)
        Me.TabPage1.Controls.Add(Me.txtUsuario)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.btnActualizar)
        Me.TabPage1.Controls.Add(Me.DataGridCitas)
        Me.TabPage1.Location = New System.Drawing.Point(124, 4)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(693, 327)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Citas"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'btnCovid
        '
        Me.btnCovid.BackColor = System.Drawing.Color.Red
        Me.btnCovid.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnCovid.Location = New System.Drawing.Point(530, 295)
        Me.btnCovid.Name = "btnCovid"
        Me.btnCovid.Size = New System.Drawing.Size(75, 23)
        Me.btnCovid.TabIndex = 7
        Me.btnCovid.Text = "Covid"
        Me.btnCovid.UseVisualStyleBackColor = False
        '
        'txtUsuario
        '
        Me.txtUsuario.Location = New System.Drawing.Point(410, 297)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.ReadOnly = True
        Me.txtUsuario.Size = New System.Drawing.Size(100, 20)
        Me.txtUsuario.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(342, 298)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 20)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Cliente:"
        '
        'btnActualizar
        '
        Me.btnActualizar.BackColor = System.Drawing.Color.Green
        Me.btnActualizar.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnActualizar.Location = New System.Drawing.Point(611, 295)
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Size = New System.Drawing.Size(75, 23)
        Me.btnActualizar.TabIndex = 1
        Me.btnActualizar.Text = "Terminada"
        Me.btnActualizar.UseVisualStyleBackColor = False
        '
        'DataGridCitas
        '
        Me.DataGridCitas.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.DataGridCitas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridCitas.Location = New System.Drawing.Point(4, 3)
        Me.DataGridCitas.Name = "DataGridCitas"
        Me.DataGridCitas.Size = New System.Drawing.Size(680, 273)
        Me.DataGridCitas.TabIndex = 0
        '
        'TabControl1
        '
        Me.TabControl1.Alignment = System.Windows.Forms.TabAlignment.Left
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed
        Me.TabControl1.ItemSize = New System.Drawing.Size(30, 120)
        Me.TabControl1.Location = New System.Drawing.Point(59, 83)
        Me.TabControl1.Multiline = True
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(821, 335)
        Me.TabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed
        Me.TabControl1.TabIndex = 1
        '
        'HomeDoctor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Semestral.My.Resources.Resources._12
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(928, 521)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.nombreDoctor)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "HomeDoctor"
        Me.Text = "HomeDoctor"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.DataGridCitas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents nombreDoctor As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents LogoutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label2 As Label
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents btnCovid As Button
    Friend WithEvents txtUsuario As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnActualizar As Button
    Friend WithEvents DataGridCitas As DataGridView
    Friend WithEvents TabControl1 As TabControl
End Class
