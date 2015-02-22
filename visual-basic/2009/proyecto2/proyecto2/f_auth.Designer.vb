<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class f_auth
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(f_auth))
        Me.txt_user = New System.Windows.Forms.TextBox
        Me.txt_pass = New System.Windows.Forms.TextBox
        Me.status = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel
        Me.reg = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.txt = New System.Windows.Forms.TextBox
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txt_user
        '
        Me.txt_user.Location = New System.Drawing.Point(70, 45)
        Me.txt_user.Name = "txt_user"
        Me.txt_user.Size = New System.Drawing.Size(170, 20)
        Me.txt_user.TabIndex = 0
        '
        'txt_pass
        '
        Me.txt_pass.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_pass.Location = New System.Drawing.Point(70, 70)
        Me.txt_pass.Name = "txt_pass"
        Me.txt_pass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_pass.Size = New System.Drawing.Size(170, 21)
        Me.txt_pass.TabIndex = 1
        '
        'status
        '
        Me.status.AutoSize = True
        Me.status.Location = New System.Drawing.Point(5, 125)
        Me.status.Name = "status"
        Me.status.Size = New System.Drawing.Size(58, 13)
        Me.status.TabIndex = 4
        Me.status.Text = "                 "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(20, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Usuario:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(5, 75)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Contaseña:"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(70, 95)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(104, 13)
        Me.LinkLabel1.TabIndex = 4
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Entrar como invitado"
        '
        'reg
        '
        Me.reg.AutoSize = True
        Me.reg.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.reg.Location = New System.Drawing.Point(35, 20)
        Me.reg.Name = "reg"
        Me.reg.Size = New System.Drawing.Size(67, 16)
        Me.reg.TabIndex = 10
        Me.reg.Text = "Registro"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.proyecto1.My.Resources.Resources.lock
        Me.PictureBox1.Location = New System.Drawing.Point(5, 5)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox1.TabIndex = 11
        Me.PictureBox1.TabStop = False
        '
        'Button2
        '
        Me.Button2.BackgroundImage = Global.proyecto1.My.Resources.Resources.Knob_Cancel
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Location = New System.Drawing.Point(225, 95)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(32, 32)
        Me.Button2.TabIndex = 3
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.BackgroundImage = Global.proyecto1.My.Resources.Resources.Knob_Valid_Green
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(190, 95)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(32, 32)
        Me.Button1.TabIndex = 2
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txt
        '
        Me.txt.Location = New System.Drawing.Point(55, 0)
        Me.txt.Name = "txt"
        Me.txt.Size = New System.Drawing.Size(210, 20)
        Me.txt.TabIndex = 12
        Me.txt.Visible = False
        '
        'f_auth
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 141)
        Me.Controls.Add(Me.txt)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.reg)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.status)
        Me.Controls.Add(Me.txt_pass)
        Me.Controls.Add(Me.txt_user)
        Me.Controls.Add(Me.Button1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "f_auth"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Autorización"
        Me.TopMost = True
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents txt_user As System.Windows.Forms.TextBox
    Friend WithEvents txt_pass As System.Windows.Forms.TextBox
    Friend WithEvents status As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents reg As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents txt As System.Windows.Forms.TextBox
End Class
