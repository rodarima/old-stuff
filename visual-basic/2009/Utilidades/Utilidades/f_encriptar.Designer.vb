<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class f_encriptar
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txt_int = New System.Windows.Forms.TextBox
        Me.lbl_introducir = New System.Windows.Forms.Label
        Me.lbl_encript = New System.Windows.Forms.Label
        Me.txt_md5 = New System.Windows.Forms.TextBox
        Me.txt_sha1 = New System.Windows.Forms.TextBox
        Me.lbl_md5 = New System.Windows.Forms.Label
        Me.lbl_sha1 = New System.Windows.Forms.Label
        Me.base64 = New System.Windows.Forms.Label
        Me.txt_base64 = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.des_base64 = New System.Windows.Forms.TextBox
        Me.TextBox2 = New System.Windows.Forms.TextBox
        Me.TextBox3 = New System.Windows.Forms.TextBox
        Me.Web = New System.Windows.Forms.WebBrowser
        Me.code = New System.Windows.Forms.TextBox
        Me.SuspendLayout()
        '
        'txt_int
        '
        Me.txt_int.Location = New System.Drawing.Point(15, 25)
        Me.txt_int.Multiline = True
        Me.txt_int.Name = "txt_int"
        Me.txt_int.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txt_int.Size = New System.Drawing.Size(559, 79)
        Me.txt_int.TabIndex = 0
        '
        'lbl_introducir
        '
        Me.lbl_introducir.AutoSize = True
        Me.lbl_introducir.Location = New System.Drawing.Point(12, 9)
        Me.lbl_introducir.Name = "lbl_introducir"
        Me.lbl_introducir.Size = New System.Drawing.Size(158, 13)
        Me.lbl_introducir.TabIndex = 2
        Me.lbl_introducir.Text = "Introduzca una cadena de texto"
        '
        'lbl_encript
        '
        Me.lbl_encript.AutoSize = True
        Me.lbl_encript.Location = New System.Drawing.Point(55, 107)
        Me.lbl_encript.Name = "lbl_encript"
        Me.lbl_encript.Size = New System.Drawing.Size(97, 13)
        Me.lbl_encript.TabIndex = 3
        Me.lbl_encript.Text = "Cadena encriptada"
        '
        'txt_md5
        '
        Me.txt_md5.Location = New System.Drawing.Point(58, 123)
        Me.txt_md5.Name = "txt_md5"
        Me.txt_md5.ReadOnly = True
        Me.txt_md5.Size = New System.Drawing.Size(255, 20)
        Me.txt_md5.TabIndex = 4
        '
        'txt_sha1
        '
        Me.txt_sha1.Location = New System.Drawing.Point(58, 149)
        Me.txt_sha1.Name = "txt_sha1"
        Me.txt_sha1.ReadOnly = True
        Me.txt_sha1.Size = New System.Drawing.Size(255, 20)
        Me.txt_sha1.TabIndex = 5
        '
        'lbl_md5
        '
        Me.lbl_md5.AutoSize = True
        Me.lbl_md5.Location = New System.Drawing.Point(12, 126)
        Me.lbl_md5.Name = "lbl_md5"
        Me.lbl_md5.Size = New System.Drawing.Size(28, 13)
        Me.lbl_md5.TabIndex = 6
        Me.lbl_md5.Text = "Md5"
        '
        'lbl_sha1
        '
        Me.lbl_sha1.AutoSize = True
        Me.lbl_sha1.Location = New System.Drawing.Point(12, 152)
        Me.lbl_sha1.Name = "lbl_sha1"
        Me.lbl_sha1.Size = New System.Drawing.Size(32, 13)
        Me.lbl_sha1.TabIndex = 7
        Me.lbl_sha1.Text = "Sha1"
        '
        'base64
        '
        Me.base64.AutoSize = True
        Me.base64.Location = New System.Drawing.Point(12, 177)
        Me.base64.Name = "base64"
        Me.base64.Size = New System.Drawing.Size(43, 13)
        Me.base64.TabIndex = 8
        Me.base64.Text = "Base64"
        '
        'txt_base64
        '
        Me.txt_base64.Location = New System.Drawing.Point(58, 174)
        Me.txt_base64.Multiline = True
        Me.txt_base64.Name = "txt_base64"
        Me.txt_base64.ReadOnly = True
        Me.txt_base64.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txt_base64.Size = New System.Drawing.Size(255, 85)
        Me.txt_base64.TabIndex = 9
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(316, 107)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(114, 13)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Cadena desencriptada"
        '
        'des_base64
        '
        Me.des_base64.Location = New System.Drawing.Point(319, 174)
        Me.des_base64.Multiline = True
        Me.des_base64.Name = "des_base64"
        Me.des_base64.ReadOnly = True
        Me.des_base64.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.des_base64.Size = New System.Drawing.Size(255, 85)
        Me.des_base64.TabIndex = 11
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(319, 149)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = True
        Me.TextBox2.Size = New System.Drawing.Size(255, 20)
        Me.TextBox2.TabIndex = 13
        Me.TextBox2.Text = "No disponible"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(319, 123)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.ReadOnly = True
        Me.TextBox3.Size = New System.Drawing.Size(255, 20)
        Me.TextBox3.TabIndex = 12
        Me.TextBox3.Text = "No disponible"
        '
        'Web
        '
        Me.Web.Location = New System.Drawing.Point(58, 350)
        Me.Web.MinimumSize = New System.Drawing.Size(20, 20)
        Me.Web.Name = "Web"
        Me.Web.ScrollBarsEnabled = False
        Me.Web.Size = New System.Drawing.Size(516, 183)
        Me.Web.TabIndex = 15
        '
        'code
        '
        Me.code.Location = New System.Drawing.Point(58, 539)
        Me.code.Multiline = True
        Me.code.Name = "code"
        Me.code.Size = New System.Drawing.Size(516, 30)
        Me.code.TabIndex = 16
        '
        'f_encriptar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(585, 271)
        Me.Controls.Add(Me.code)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.des_base64)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_base64)
        Me.Controls.Add(Me.base64)
        Me.Controls.Add(Me.lbl_sha1)
        Me.Controls.Add(Me.lbl_md5)
        Me.Controls.Add(Me.txt_sha1)
        Me.Controls.Add(Me.txt_md5)
        Me.Controls.Add(Me.lbl_encript)
        Me.Controls.Add(Me.lbl_introducir)
        Me.Controls.Add(Me.txt_int)
        Me.Controls.Add(Me.Web)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "f_encriptar"
        Me.Opacity = 0.95
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Encriptador y desencriptador"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txt_int As System.Windows.Forms.TextBox
    Friend WithEvents lbl_introducir As System.Windows.Forms.Label
    Friend WithEvents lbl_encript As System.Windows.Forms.Label
    Friend WithEvents txt_md5 As System.Windows.Forms.TextBox
    Friend WithEvents txt_sha1 As System.Windows.Forms.TextBox
    Friend WithEvents lbl_md5 As System.Windows.Forms.Label
    Friend WithEvents lbl_sha1 As System.Windows.Forms.Label
    Friend WithEvents base64 As System.Windows.Forms.Label
    Friend WithEvents txt_base64 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents des_base64 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents Web As System.Windows.Forms.WebBrowser
    Friend WithEvents code As System.Windows.Forms.TextBox
End Class
