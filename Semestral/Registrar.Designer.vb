<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Registrar
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.comboroleUser = New System.Windows.Forms.ComboBox()
        Me.inputNombre = New System.Windows.Forms.TextBox()
        Me.inputEmail = New System.Windows.Forms.TextBox()
        Me.inputApellido = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.inputPassword = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.bregistrer = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Constantia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label1.Location = New System.Drawing.Point(68, 118)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Constantia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label2.Location = New System.Drawing.Point(71, 222)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 19)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Email"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Constantia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label3.Location = New System.Drawing.Point(71, 330)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 19)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Tipo"
        '
        'comboroleUser
        '
        Me.comboroleUser.AllowDrop = True
        Me.comboroleUser.FormattingEnabled = True
        Me.comboroleUser.Location = New System.Drawing.Point(158, 327)
        Me.comboroleUser.Name = "comboroleUser"
        Me.comboroleUser.Size = New System.Drawing.Size(121, 21)
        Me.comboroleUser.TabIndex = 3
        '
        'inputNombre
        '
        Me.inputNombre.Location = New System.Drawing.Point(158, 118)
        Me.inputNombre.Name = "inputNombre"
        Me.inputNombre.Size = New System.Drawing.Size(121, 20)
        Me.inputNombre.TabIndex = 4
        '
        'inputEmail
        '
        Me.inputEmail.Location = New System.Drawing.Point(158, 222)
        Me.inputEmail.Name = "inputEmail"
        Me.inputEmail.Size = New System.Drawing.Size(121, 20)
        Me.inputEmail.TabIndex = 5
        '
        'inputApellido
        '
        Me.inputApellido.Location = New System.Drawing.Point(158, 174)
        Me.inputApellido.Name = "inputApellido"
        Me.inputApellido.Size = New System.Drawing.Size(121, 20)
        Me.inputApellido.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Constantia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label4.Location = New System.Drawing.Point(68, 174)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(74, 19)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Apellido"
        '
        'inputPassword
        '
        Me.inputPassword.Location = New System.Drawing.Point(158, 270)
        Me.inputPassword.Name = "inputPassword"
        Me.inputPassword.Size = New System.Drawing.Size(121, 20)
        Me.inputPassword.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Constantia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label5.Location = New System.Drawing.Point(71, 270)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(81, 19)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Password"
        '
        'bregistrer
        '
        Me.bregistrer.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.bregistrer.Location = New System.Drawing.Point(204, 374)
        Me.bregistrer.Name = "bregistrer"
        Me.bregistrer.Size = New System.Drawing.Size(75, 23)
        Me.bregistrer.TabIndex = 10
        Me.bregistrer.Text = "Registrar"
        Me.bregistrer.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.bregistrer.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Copperplate Gothic Bold", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.GrayText
        Me.Label6.Location = New System.Drawing.Point(124, 9)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(161, 33)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Registro"
        '
        'Registrar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Semestral.My.Resources.Resources.clinica
        Me.ClientSize = New System.Drawing.Size(381, 450)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.bregistrer)
        Me.Controls.Add(Me.inputPassword)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.inputApellido)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.inputEmail)
        Me.Controls.Add(Me.inputNombre)
        Me.Controls.Add(Me.comboroleUser)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Registrar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registrar"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents comboroleUser As ComboBox
    Friend WithEvents inputNombre As TextBox
    Friend WithEvents inputEmail As TextBox
    Friend WithEvents inputApellido As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents inputPassword As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents bregistrer As Button
    Friend WithEvents Label6 As Label
End Class
