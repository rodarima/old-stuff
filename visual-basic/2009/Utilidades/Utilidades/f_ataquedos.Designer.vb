<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class f_ataquedos
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(f_ataquedos))
        Me.txt_IP = New System.Windows.Forms.TextBox
        Me.txt_Port = New System.Windows.Forms.TextBox
        Me.T1 = New System.Windows.Forms.Timer(Me.components)
        Me.W1 = New AxMSWinsockLib.AxWinsock
        Me.W2 = New AxMSWinsockLib.AxWinsock
        Me.W3 = New AxMSWinsockLib.AxWinsock
        Me.W4 = New AxMSWinsockLib.AxWinsock
        Me.W5 = New AxMSWinsockLib.AxWinsock
        Me.T2 = New System.Windows.Forms.Timer(Me.components)
        Me.T3 = New System.Windows.Forms.Timer(Me.components)
        Me.T4 = New System.Windows.Forms.Timer(Me.components)
        Me.T5 = New System.Windows.Forms.Timer(Me.components)
        Me.txt_total = New System.Windows.Forms.TextBox
        Me.txt_ataques1 = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.txt_ataques2 = New System.Windows.Forms.TextBox
        Me.txt_ataques3 = New System.Windows.Forms.TextBox
        Me.txt_ataques4 = New System.Windows.Forms.TextBox
        Me.txt_ataques5 = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.btn5 = New System.Windows.Forms.Button
        Me.btn4 = New System.Windows.Forms.Button
        Me.btn3 = New System.Windows.Forms.Button
        Me.btn2 = New System.Windows.Forms.Button
        Me.btn1 = New System.Windows.Forms.Button
        Me.btn_todos = New System.Windows.Forms.Button
        Me.lbl_inf = New System.Windows.Forms.Label
        Me.Timer = New System.Windows.Forms.Timer(Me.components)
        Me.Tiempo = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.intervalo = New System.Windows.Forms.NumericUpDown
        CType(Me.W1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.W2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.W3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.W4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.W5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.intervalo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txt_IP
        '
        Me.txt_IP.Location = New System.Drawing.Point(12, 20)
        Me.txt_IP.Name = "txt_IP"
        Me.txt_IP.Size = New System.Drawing.Size(112, 20)
        Me.txt_IP.TabIndex = 0
        '
        'txt_Port
        '
        Me.txt_Port.Location = New System.Drawing.Point(133, 20)
        Me.txt_Port.MaxLength = 5
        Me.txt_Port.Name = "txt_Port"
        Me.txt_Port.Size = New System.Drawing.Size(40, 20)
        Me.txt_Port.TabIndex = 1
        Me.txt_Port.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'T1
        '
        '
        'W1
        '
        Me.W1.Enabled = True
        Me.W1.Location = New System.Drawing.Point(-12, 191)
        Me.W1.Name = "W1"
        Me.W1.OcxState = CType(resources.GetObject("W1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.W1.Size = New System.Drawing.Size(28, 28)
        Me.W1.TabIndex = 5
        '
        'W2
        '
        Me.W2.Enabled = True
        Me.W2.Location = New System.Drawing.Point(-12, 191)
        Me.W2.Name = "W2"
        Me.W2.OcxState = CType(resources.GetObject("W2.OcxState"), System.Windows.Forms.AxHost.State)
        Me.W2.Size = New System.Drawing.Size(28, 28)
        Me.W2.TabIndex = 11
        '
        'W3
        '
        Me.W3.Enabled = True
        Me.W3.Location = New System.Drawing.Point(-12, 191)
        Me.W3.Name = "W3"
        Me.W3.OcxState = CType(resources.GetObject("W3.OcxState"), System.Windows.Forms.AxHost.State)
        Me.W3.Size = New System.Drawing.Size(28, 28)
        Me.W3.TabIndex = 17
        '
        'W4
        '
        Me.W4.Enabled = True
        Me.W4.Location = New System.Drawing.Point(-12, 191)
        Me.W4.Name = "W4"
        Me.W4.OcxState = CType(resources.GetObject("W4.OcxState"), System.Windows.Forms.AxHost.State)
        Me.W4.Size = New System.Drawing.Size(28, 28)
        Me.W4.TabIndex = 23
        '
        'W5
        '
        Me.W5.Enabled = True
        Me.W5.Location = New System.Drawing.Point(-12, 191)
        Me.W5.Name = "W5"
        Me.W5.OcxState = CType(resources.GetObject("W5.OcxState"), System.Windows.Forms.AxHost.State)
        Me.W5.Size = New System.Drawing.Size(28, 28)
        Me.W5.TabIndex = 29
        '
        'T2
        '
        '
        'T3
        '
        '
        'T4
        '
        '
        'T5
        '
        '
        'txt_total
        '
        Me.txt_total.Location = New System.Drawing.Point(118, 61)
        Me.txt_total.Name = "txt_total"
        Me.txt_total.ReadOnly = True
        Me.txt_total.Size = New System.Drawing.Size(55, 20)
        Me.txt_total.TabIndex = 30
        Me.txt_total.Text = "0"
        Me.txt_total.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txt_ataques1
        '
        Me.txt_ataques1.Enabled = False
        Me.txt_ataques1.Location = New System.Drawing.Point(50, 51)
        Me.txt_ataques1.Name = "txt_ataques1"
        Me.txt_ataques1.ReadOnly = True
        Me.txt_ataques1.Size = New System.Drawing.Size(62, 20)
        Me.txt_ataques1.TabIndex = 31
        Me.txt_ataques1.Text = "0"
        Me.txt_ataques1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(118, 84)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 13)
        Me.Label1.TabIndex = 32
        Me.Label1.Text = "Intervalo (ms)"
        '
        'txt_ataques2
        '
        Me.txt_ataques2.Enabled = False
        Me.txt_ataques2.Location = New System.Drawing.Point(50, 81)
        Me.txt_ataques2.Name = "txt_ataques2"
        Me.txt_ataques2.ReadOnly = True
        Me.txt_ataques2.Size = New System.Drawing.Size(62, 20)
        Me.txt_ataques2.TabIndex = 35
        Me.txt_ataques2.Text = "0"
        Me.txt_ataques2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txt_ataques3
        '
        Me.txt_ataques3.Enabled = False
        Me.txt_ataques3.Location = New System.Drawing.Point(50, 110)
        Me.txt_ataques3.Name = "txt_ataques3"
        Me.txt_ataques3.ReadOnly = True
        Me.txt_ataques3.Size = New System.Drawing.Size(62, 20)
        Me.txt_ataques3.TabIndex = 36
        Me.txt_ataques3.Text = "0"
        Me.txt_ataques3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txt_ataques4
        '
        Me.txt_ataques4.Enabled = False
        Me.txt_ataques4.Location = New System.Drawing.Point(50, 139)
        Me.txt_ataques4.Name = "txt_ataques4"
        Me.txt_ataques4.ReadOnly = True
        Me.txt_ataques4.Size = New System.Drawing.Size(62, 20)
        Me.txt_ataques4.TabIndex = 37
        Me.txt_ataques4.Text = "0"
        Me.txt_ataques4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txt_ataques5
        '
        Me.txt_ataques5.Enabled = False
        Me.txt_ataques5.Location = New System.Drawing.Point(50, 169)
        Me.txt_ataques5.Name = "txt_ataques5"
        Me.txt_ataques5.ReadOnly = True
        Me.txt_ataques5.Size = New System.Drawing.Size(62, 20)
        Me.txt_ataques5.TabIndex = 38
        Me.txt_ataques5.Text = "0"
        Me.txt_ataques5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(118, 45)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(31, 13)
        Me.Label4.TabIndex = 39
        Me.Label4.Text = "Total"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(135, 4)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(38, 13)
        Me.Label5.TabIndex = 40
        Me.Label5.Text = "Puerto"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(9, 4)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(74, 13)
        Me.Label6.TabIndex = 41
        Me.Label6.Text = "Dirección o IP"
        '
        'btn5
        '
        Me.btn5.FlatAppearance.BorderSize = 0
        Me.btn5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn5.Image = Global.Utilidades.My.Resources.Resources.bug
        Me.btn5.Location = New System.Drawing.Point(12, 165)
        Me.btn5.Name = "btn5"
        Me.btn5.Size = New System.Drawing.Size(32, 32)
        Me.btn5.TabIndex = 45
        Me.btn5.UseVisualStyleBackColor = True
        '
        'btn4
        '
        Me.btn4.FlatAppearance.BorderSize = 0
        Me.btn4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn4.Image = Global.Utilidades.My.Resources.Resources.bug
        Me.btn4.Location = New System.Drawing.Point(12, 135)
        Me.btn4.Name = "btn4"
        Me.btn4.Size = New System.Drawing.Size(32, 32)
        Me.btn4.TabIndex = 44
        Me.btn4.UseVisualStyleBackColor = True
        '
        'btn3
        '
        Me.btn3.FlatAppearance.BorderSize = 0
        Me.btn3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn3.Image = Global.Utilidades.My.Resources.Resources.bug
        Me.btn3.Location = New System.Drawing.Point(12, 106)
        Me.btn3.Name = "btn3"
        Me.btn3.Size = New System.Drawing.Size(32, 32)
        Me.btn3.TabIndex = 43
        Me.btn3.UseVisualStyleBackColor = True
        '
        'btn2
        '
        Me.btn2.FlatAppearance.BorderSize = 0
        Me.btn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn2.Image = Global.Utilidades.My.Resources.Resources.bug
        Me.btn2.Location = New System.Drawing.Point(12, 77)
        Me.btn2.Name = "btn2"
        Me.btn2.Size = New System.Drawing.Size(32, 32)
        Me.btn2.TabIndex = 42
        Me.btn2.UseVisualStyleBackColor = True
        '
        'btn1
        '
        Me.btn1.FlatAppearance.BorderSize = 0
        Me.btn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn1.Image = Global.Utilidades.My.Resources.Resources.bug
        Me.btn1.Location = New System.Drawing.Point(12, 47)
        Me.btn1.Name = "btn1"
        Me.btn1.Size = New System.Drawing.Size(32, 32)
        Me.btn1.TabIndex = 2
        Me.btn1.UseVisualStyleBackColor = True
        '
        'btn_todos
        '
        Me.btn_todos.Image = Global.Utilidades.My.Resources.Resources.bug1
        Me.btn_todos.Location = New System.Drawing.Point(120, 165)
        Me.btn_todos.Name = "btn_todos"
        Me.btn_todos.Size = New System.Drawing.Size(52, 39)
        Me.btn_todos.TabIndex = 46
        Me.btn_todos.UseVisualStyleBackColor = True
        '
        'lbl_inf
        '
        Me.lbl_inf.AutoSize = True
        Me.lbl_inf.Location = New System.Drawing.Point(50, 199)
        Me.lbl_inf.Name = "lbl_inf"
        Me.lbl_inf.Size = New System.Drawing.Size(0, 13)
        Me.lbl_inf.TabIndex = 47
        '
        'Timer
        '
        Me.Timer.Interval = 1000
        '
        'Tiempo
        '
        Me.Tiempo.Location = New System.Drawing.Point(118, 139)
        Me.Tiempo.Name = "Tiempo"
        Me.Tiempo.Size = New System.Drawing.Size(55, 20)
        Me.Tiempo.TabIndex = 48
        Me.Tiempo.Text = "0"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(118, 123)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 13)
        Me.Label2.TabIndex = 49
        Me.Label2.Text = "Tiempo:"
        '
        'intervalo
        '
        Me.intervalo.Increment = New Decimal(New Integer() {10, 0, 0, 0})
        Me.intervalo.Location = New System.Drawing.Point(118, 100)
        Me.intervalo.Maximum = New Decimal(New Integer() {999, 0, 0, 0})
        Me.intervalo.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.intervalo.Name = "intervalo"
        Me.intervalo.Size = New System.Drawing.Size(55, 20)
        Me.intervalo.TabIndex = 51
        Me.intervalo.Value = New Decimal(New Integer() {100, 0, 0, 0})
        '
        'f_ataquedos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(195, 214)
        Me.Controls.Add(Me.intervalo)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Tiempo)
        Me.Controls.Add(Me.lbl_inf)
        Me.Controls.Add(Me.btn_todos)
        Me.Controls.Add(Me.btn5)
        Me.Controls.Add(Me.btn4)
        Me.Controls.Add(Me.btn3)
        Me.Controls.Add(Me.btn2)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txt_ataques5)
        Me.Controls.Add(Me.txt_ataques4)
        Me.Controls.Add(Me.txt_ataques3)
        Me.Controls.Add(Me.txt_ataques2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_ataques1)
        Me.Controls.Add(Me.txt_total)
        Me.Controls.Add(Me.W5)
        Me.Controls.Add(Me.W4)
        Me.Controls.Add(Me.W3)
        Me.Controls.Add(Me.W2)
        Me.Controls.Add(Me.W1)
        Me.Controls.Add(Me.btn1)
        Me.Controls.Add(Me.txt_Port)
        Me.Controls.Add(Me.txt_IP)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "f_ataquedos"
        Me.Opacity = 0.85
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ataque DoS"
        Me.TopMost = True
        CType(Me.W1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.W2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.W3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.W4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.W5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.intervalo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txt_IP As System.Windows.Forms.TextBox
    Friend WithEvents txt_Port As System.Windows.Forms.TextBox
    Friend WithEvents btn1 As System.Windows.Forms.Button
    Friend WithEvents T1 As System.Windows.Forms.Timer
    Friend WithEvents W1 As AxMSWinsockLib.AxWinsock
    Friend WithEvents W2 As AxMSWinsockLib.AxWinsock
    Friend WithEvents W3 As AxMSWinsockLib.AxWinsock
    Friend WithEvents W4 As AxMSWinsockLib.AxWinsock
    Friend WithEvents W5 As AxMSWinsockLib.AxWinsock
    Friend WithEvents T2 As System.Windows.Forms.Timer
    Friend WithEvents T3 As System.Windows.Forms.Timer
    Friend WithEvents T4 As System.Windows.Forms.Timer
    Friend WithEvents T5 As System.Windows.Forms.Timer
    Friend WithEvents txt_total As System.Windows.Forms.TextBox
    Friend WithEvents txt_ataques1 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_ataques2 As System.Windows.Forms.TextBox
    Friend WithEvents txt_ataques3 As System.Windows.Forms.TextBox
    Friend WithEvents txt_ataques4 As System.Windows.Forms.TextBox
    Friend WithEvents txt_ataques5 As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btn2 As System.Windows.Forms.Button
    Friend WithEvents btn3 As System.Windows.Forms.Button
    Friend WithEvents btn4 As System.Windows.Forms.Button
    Friend WithEvents btn5 As System.Windows.Forms.Button
    Friend WithEvents btn_todos As System.Windows.Forms.Button
    Friend WithEvents lbl_inf As System.Windows.Forms.Label
    Friend WithEvents Timer As System.Windows.Forms.Timer
    Friend WithEvents Tiempo As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents intervalo As System.Windows.Forms.NumericUpDown
End Class
