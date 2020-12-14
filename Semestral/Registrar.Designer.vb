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
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(143, 104)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(146, 222)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(31, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "email"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(146, 330)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(24, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "tipo"
        '
        'comboroleUser
        '
        Me.comboroleUser.AllowDrop = True
        Me.comboroleUser.FormattingEnabled = True
        Me.comboroleUser.Location = New System.Drawing.Point(233, 327)
        Me.comboroleUser.Name = "comboroleUser"
        Me.comboroleUser.Size = New System.Drawing.Size(121, 21)
        Me.comboroleUser.TabIndex = 3
        '
        'inputNombre
        '
        Me.inputNombre.Location = New System.Drawing.Point(233, 104)
        Me.inputNombre.Name = "inputNombre"
        Me.inputNombre.Size = New System.Drawing.Size(121, 20)
        Me.inputNombre.TabIndex = 4
        '
        'inputEmail
        '
        Me.inputEmail.Location = New System.Drawing.Point(233, 222)
        Me.inputEmail.Name = "inputEmail"
        Me.inputEmail.Size = New System.Drawing.Size(121, 20)
        Me.inputEmail.TabIndex = 5
        '
        'inputApellido
        '
        Me.inputApellido.Location = New System.Drawing.Point(233, 160)
        Me.inputApellido.Name = "inputApellido"
        Me.inputApellido.Size = New System.Drawing.Size(121, 20)
        Me.inputApellido.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(143, 160)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Apellido"
        '
        'inputPassword
        '
        Me.inputPassword.Location = New System.Drawing.Point(233, 270)
        Me.inputPassword.Name = "inputPassword"
        Me.inputPassword.Size = New System.Drawing.Size(121, 20)
        Me.inputPassword.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(146, 270)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Password"
        '
        'bregistrer
        '
        Me.bregistrer.Location = New System.Drawing.Point(418, 233)
        Me.bregistrer.Name = "bregistrer"
        Me.bregistrer.Size = New System.Drawing.Size(75, 23)
        Me.bregistrer.TabIndex = 10
        Me.bregistrer.Text = "Registrar"
        Me.bregistrer.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.bregistrer.UseVisualStyleBackColor = True
        '
        'Registrar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
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
End Class
