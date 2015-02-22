<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Label1 = New System.Windows.Forms.Label
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txt_ataques5 = New System.Windows.Forms.TextBox
        Me.W5 = New AxMSWinsockLib.AxWinsock
        Me.txt_IP = New System.Windows.Forms.TextBox
        Me.W4 = New AxMSWinsockLib.AxWinsock
        Me.txt_Port = New System.Windows.Forms.TextBox
        Me.W3 = New AxMSWinsockLib.AxWinsock
        Me.W2 = New AxMSWinsockLib.AxWinsock
        Me.txt_total = New System.Windows.Forms.TextBox
        Me.W1 = New AxMSWinsockLib.AxWinsock
        Me.txt_ataques1 = New System.Windows.Forms.TextBox
        Me.intervalo = New System.Windows.Forms.NumericUpDown
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.txt_ataques2 = New System.Windows.Forms.TextBox
        Me.Tiempo = New System.Windows.Forms.TextBox
        Me.txt_ataques3 = New System.Windows.Forms.TextBox
        Me.lbl_inf = New System.Windows.Forms.Label
        Me.txt_ataques4 = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.TabPage3 = New System.Windows.Forms.TabPage
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.LinkLabel5 = New System.Windows.Forms.LinkLabel
        Me.LinkLabel6 = New System.Windows.Forms.LinkLabel
        Me.Label14 = New System.Windows.Forms.Label
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.LinkLabel3 = New System.Windows.Forms.LinkLabel
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.LinkLabel2 = New System.Windows.Forms.LinkLabel
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel
        Me.Label7 = New System.Windows.Forms.Label
        Me.T1 = New System.Windows.Forms.Timer(Me.components)
        Me.T2 = New System.Windows.Forms.Timer(Me.components)
        Me.T3 = New System.Windows.Forms.Timer(Me.components)
        Me.T4 = New System.Windows.Forms.Timer(Me.components)
        Me.T5 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer = New System.Windows.Forms.Timer(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.btn1 = New System.Windows.Forms.Button
        Me.btn_todos = New System.Windows.Forms.Button
        Me.btn5 = New System.Windows.Forms.Button
        Me.btn4 = New System.Windows.Forms.Button
        Me.btn3 = New System.Windows.Forms.Button
        Me.btn2 = New System.Windows.Forms.Button
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Panel1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.W5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.W4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.W3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.W2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.W1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.intervalo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(590, 45)
        Me.Panel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(35, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(189, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Utilidades Varias"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Location = New System.Drawing.Point(5, 50)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(580, 265)
        Me.TabControl1.TabIndex = 2
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.White
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(572, 239)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Utilidades"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.White
        Me.TabPage2.Controls.Add(Me.GroupBox1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(572, 239)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Red"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txt_ataques5)
        Me.GroupBox1.Controls.Add(Me.W5)
        Me.GroupBox1.Controls.Add(Me.txt_IP)
        Me.GroupBox1.Controls.Add(Me.W4)
        Me.GroupBox1.Controls.Add(Me.txt_Port)
        Me.GroupBox1.Controls.Add(Me.W3)
        Me.GroupBox1.Controls.Add(Me.btn1)
        Me.GroupBox1.Controls.Add(Me.W2)
        Me.GroupBox1.Controls.Add(Me.txt_total)
        Me.GroupBox1.Controls.Add(Me.W1)
        Me.GroupBox1.Controls.Add(Me.txt_ataques1)
        Me.GroupBox1.Controls.Add(Me.intervalo)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txt_ataques2)
        Me.GroupBox1.Controls.Add(Me.Tiempo)
        Me.GroupBox1.Controls.Add(Me.txt_ataques3)
        Me.GroupBox1.Controls.Add(Me.lbl_inf)
        Me.GroupBox1.Controls.Add(Me.txt_ataques4)
        Me.GroupBox1.Controls.Add(Me.btn_todos)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.btn5)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.btn4)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.btn3)
        Me.GroupBox1.Controls.Add(Me.btn2)
        Me.GroupBox1.Location = New System.Drawing.Point(5, 5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(195, 230)
        Me.GroupBox1.TabIndex = 80
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Ataque DoS"
        '
        'txt_ataques5
        '
        Me.txt_ataques5.Enabled = False
        Me.txt_ataques5.Location = New System.Drawing.Point(8, 201)
        Me.txt_ataques5.Name = "txt_ataques5"
        Me.txt_ataques5.ReadOnly = True
        Me.txt_ataques5.Size = New System.Drawing.Size(62, 20)
        Me.txt_ataques5.TabIndex = 61
        Me.txt_ataques5.Text = "0"
        Me.txt_ataques5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'W5
        '
        Me.W5.Enabled = True
        Me.W5.Location = New System.Drawing.Point(145, 145)
        Me.W5.Name = "W5"
        Me.W5.OcxState = CType(resources.GetObject("W5.OcxState"), System.Windows.Forms.AxHost.State)
        Me.W5.Size = New System.Drawing.Size(28, 28)
        Me.W5.TabIndex = 79
        '
        'txt_IP
        '
        Me.txt_IP.Location = New System.Drawing.Point(8, 31)
        Me.txt_IP.Name = "txt_IP"
        Me.txt_IP.Size = New System.Drawing.Size(122, 20)
        Me.txt_IP.TabIndex = 52
        '
        'W4
        '
        Me.W4.Enabled = True
        Me.W4.Location = New System.Drawing.Point(145, 145)
        Me.W4.Name = "W4"
        Me.W4.OcxState = CType(resources.GetObject("W4.OcxState"), System.Windows.Forms.AxHost.State)
        Me.W4.Size = New System.Drawing.Size(28, 28)
        Me.W4.TabIndex = 78
        '
        'txt_Port
        '
        Me.txt_Port.Location = New System.Drawing.Point(134, 31)
        Me.txt_Port.MaxLength = 5
        Me.txt_Port.Name = "txt_Port"
        Me.txt_Port.Size = New System.Drawing.Size(40, 20)
        Me.txt_Port.TabIndex = 53
        Me.txt_Port.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'W3
        '
        Me.W3.Enabled = True
        Me.W3.Location = New System.Drawing.Point(145, 145)
        Me.W3.Name = "W3"
        Me.W3.OcxState = CType(resources.GetObject("W3.OcxState"), System.Windows.Forms.AxHost.State)
        Me.W3.Size = New System.Drawing.Size(28, 28)
        Me.W3.TabIndex = 77
        '
        'W2
        '
        Me.W2.Enabled = True
        Me.W2.Location = New System.Drawing.Point(145, 145)
        Me.W2.Name = "W2"
        Me.W2.OcxState = CType(resources.GetObject("W2.OcxState"), System.Windows.Forms.AxHost.State)
        Me.W2.Size = New System.Drawing.Size(28, 28)
        Me.W2.TabIndex = 76
        '
        'txt_total
        '
        Me.txt_total.Location = New System.Drawing.Point(119, 72)
        Me.txt_total.Name = "txt_total"
        Me.txt_total.ReadOnly = True
        Me.txt_total.Size = New System.Drawing.Size(55, 20)
        Me.txt_total.TabIndex = 55
        Me.txt_total.Text = "0"
        Me.txt_total.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'W1
        '
        Me.W1.Enabled = True
        Me.W1.Location = New System.Drawing.Point(145, 145)
        Me.W1.Name = "W1"
        Me.W1.OcxState = CType(resources.GetObject("W1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.W1.Size = New System.Drawing.Size(28, 28)
        Me.W1.TabIndex = 75
        '
        'txt_ataques1
        '
        Me.txt_ataques1.Enabled = False
        Me.txt_ataques1.Location = New System.Drawing.Point(8, 61)
        Me.txt_ataques1.Name = "txt_ataques1"
        Me.txt_ataques1.ReadOnly = True
        Me.txt_ataques1.Size = New System.Drawing.Size(62, 20)
        Me.txt_ataques1.TabIndex = 56
        Me.txt_ataques1.Text = "0"
        Me.txt_ataques1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'intervalo
        '
        Me.intervalo.Increment = New Decimal(New Integer() {10, 0, 0, 0})
        Me.intervalo.Location = New System.Drawing.Point(119, 111)
        Me.intervalo.Maximum = New Decimal(New Integer() {999, 0, 0, 0})
        Me.intervalo.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.intervalo.Name = "intervalo"
        Me.intervalo.Size = New System.Drawing.Size(55, 20)
        Me.intervalo.TabIndex = 73
        Me.intervalo.Value = New Decimal(New Integer() {100, 0, 0, 0})
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(119, 95)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 13)
        Me.Label3.TabIndex = 57
        Me.Label3.Text = "Intervalo (ms)"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(119, 134)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 13)
        Me.Label2.TabIndex = 72
        Me.Label2.Text = "Tiempo:"
        '
        'txt_ataques2
        '
        Me.txt_ataques2.Enabled = False
        Me.txt_ataques2.Location = New System.Drawing.Point(8, 96)
        Me.txt_ataques2.Name = "txt_ataques2"
        Me.txt_ataques2.ReadOnly = True
        Me.txt_ataques2.Size = New System.Drawing.Size(62, 20)
        Me.txt_ataques2.TabIndex = 58
        Me.txt_ataques2.Text = "0"
        Me.txt_ataques2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Tiempo
        '
        Me.Tiempo.Location = New System.Drawing.Point(119, 150)
        Me.Tiempo.Name = "Tiempo"
        Me.Tiempo.Size = New System.Drawing.Size(55, 20)
        Me.Tiempo.TabIndex = 71
        Me.Tiempo.Text = "0"
        '
        'txt_ataques3
        '
        Me.txt_ataques3.Enabled = False
        Me.txt_ataques3.Location = New System.Drawing.Point(8, 131)
        Me.txt_ataques3.Name = "txt_ataques3"
        Me.txt_ataques3.ReadOnly = True
        Me.txt_ataques3.Size = New System.Drawing.Size(62, 20)
        Me.txt_ataques3.TabIndex = 59
        Me.txt_ataques3.Text = "0"
        Me.txt_ataques3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lbl_inf
        '
        Me.lbl_inf.AutoSize = True
        Me.lbl_inf.Location = New System.Drawing.Point(123, 171)
        Me.lbl_inf.Name = "lbl_inf"
        Me.lbl_inf.Size = New System.Drawing.Size(34, 13)
        Me.lbl_inf.TabIndex = 70
        Me.lbl_inf.Text = "sdsds"
        '
        'txt_ataques4
        '
        Me.txt_ataques4.Enabled = False
        Me.txt_ataques4.Location = New System.Drawing.Point(8, 166)
        Me.txt_ataques4.Name = "txt_ataques4"
        Me.txt_ataques4.ReadOnly = True
        Me.txt_ataques4.Size = New System.Drawing.Size(62, 20)
        Me.txt_ataques4.TabIndex = 60
        Me.txt_ataques4.Text = "0"
        Me.txt_ataques4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(119, 56)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(31, 13)
        Me.Label4.TabIndex = 62
        Me.Label4.Text = "Total"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(136, 15)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(38, 13)
        Me.Label5.TabIndex = 63
        Me.Label5.Text = "Puerto"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(10, 15)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(74, 13)
        Me.Label6.TabIndex = 64
        Me.Label6.Text = "Dirección o IP"
        '
        'TabPage3
        '
        Me.TabPage3.BackColor = System.Drawing.Color.White
        Me.TabPage3.Controls.Add(Me.Panel3)
        Me.TabPage3.Controls.Add(Me.Panel2)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(572, 239)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Código y Programación"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Label11)
        Me.Panel3.Controls.Add(Me.Label13)
        Me.Panel3.Controls.Add(Me.LinkLabel5)
        Me.Panel3.Controls.Add(Me.LinkLabel6)
        Me.Panel3.Controls.Add(Me.Label14)
        Me.Panel3.Location = New System.Drawing.Point(0, 100)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(195, 95)
        Me.Panel3.TabIndex = 1
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(35, 35)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(117, 13)
        Me.Label11.TabIndex = 3
        Me.Label11.Text = "Editor de código fuente"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(60, 50)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(118, 13)
        Me.Label13.TabIndex = 3
        Me.Label13.Text = "Editor de Código fuente"
        '
        'LinkLabel5
        '
        Me.LinkLabel5.AutoSize = True
        Me.LinkLabel5.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.LinkLabel5.LinkColor = System.Drawing.SystemColors.Highlight
        Me.LinkLabel5.Location = New System.Drawing.Point(5, 50)
        Me.LinkLabel5.Name = "LinkLabel5"
        Me.LinkLabel5.Size = New System.Drawing.Size(60, 13)
        Me.LinkLabel5.TabIndex = 1
        Me.LinkLabel5.TabStop = True
        Me.LinkLabel5.Text = "Notepad++"
        '
        'LinkLabel6
        '
        Me.LinkLabel6.AutoSize = True
        Me.LinkLabel6.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.LinkLabel6.LinkColor = System.Drawing.SystemColors.Highlight
        Me.LinkLabel6.Location = New System.Drawing.Point(5, 35)
        Me.LinkLabel6.Name = "LinkLabel6"
        Me.LinkLabel6.Size = New System.Drawing.Size(31, 13)
        Me.LinkLabel6.TabIndex = 1
        Me.LinkLabel6.TabStop = True
        Me.LinkLabel6.Text = "Scite"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label14.Location = New System.Drawing.Point(5, 5)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(73, 19)
        Me.Label14.TabIndex = 0
        Me.Label14.Text = "Editores"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.LinkLabel3)
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Controls.Add(Me.Label10)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.LinkLabel2)
        Me.Panel2.Controls.Add(Me.LinkLabel1)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(195, 95)
        Me.Panel2.TabIndex = 1
        '
        'LinkLabel3
        '
        Me.LinkLabel3.AutoSize = True
        Me.LinkLabel3.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.LinkLabel3.LinkColor = System.Drawing.SystemColors.Highlight
        Me.LinkLabel3.Location = New System.Drawing.Point(5, 65)
        Me.LinkLabel3.Name = "LinkLabel3"
        Me.LinkLabel3.Size = New System.Drawing.Size(31, 13)
        Me.LinkLabel3.TabIndex = 4
        Me.LinkLabel3.TabStop = True
        Me.LinkLabel3.Text = "PEiD"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(50, 35)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(140, 13)
        Me.Label9.TabIndex = 3
        Me.Label9.Text = "32-bit Debugger con plugins"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(35, 65)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(105, 13)
        Me.Label10.TabIndex = 3
        Me.Label10.Text = "Detector de Packers"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(60, 50)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(106, 13)
        Me.Label8.TabIndex = 3
        Me.Label8.Text = "Otro 32-bit Debugger"
        '
        'LinkLabel2
        '
        Me.LinkLabel2.AutoSize = True
        Me.LinkLabel2.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.LinkLabel2.LinkColor = System.Drawing.SystemColors.Highlight
        Me.LinkLabel2.Location = New System.Drawing.Point(5, 50)
        Me.LinkLabel2.Name = "LinkLabel2"
        Me.LinkLabel2.Size = New System.Drawing.Size(57, 13)
        Me.LinkLabel2.TabIndex = 1
        Me.LinkLabel2.TabStop = True
        Me.LinkLabel2.Text = "W32Dasm"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.LinkLabel1.LinkColor = System.Drawing.SystemColors.Highlight
        Me.LinkLabel1.Location = New System.Drawing.Point(5, 35)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(44, 13)
        Me.LinkLabel1.TabIndex = 1
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "OllyDbg"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(5, 5)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(94, 19)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Debuggers"
        '
        'T1
        '
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
        'Timer
        '
        Me.Timer.Interval = 1000
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'btn1
        '
        Me.btn1.BackColor = System.Drawing.Color.Transparent
        Me.btn1.BackgroundImage = Global.Utility_Machine.My.Resources.Resources.play
        Me.btn1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btn1.FlatAppearance.BorderSize = 0
        Me.btn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn1.Location = New System.Drawing.Point(75, 55)
        Me.btn1.Name = "btn1"
        Me.btn1.Size = New System.Drawing.Size(32, 32)
        Me.btn1.TabIndex = 54
        Me.btn1.UseVisualStyleBackColor = False
        '
        'btn_todos
        '
        Me.btn_todos.BackgroundImage = Global.Utility_Machine.My.Resources.Resources.forward_button
        Me.btn_todos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_todos.Location = New System.Drawing.Point(130, 185)
        Me.btn_todos.Name = "btn_todos"
        Me.btn_todos.Size = New System.Drawing.Size(45, 39)
        Me.btn_todos.TabIndex = 69
        Me.btn_todos.UseVisualStyleBackColor = True
        '
        'btn5
        '
        Me.btn5.BackColor = System.Drawing.Color.Transparent
        Me.btn5.BackgroundImage = CType(resources.GetObject("btn5.BackgroundImage"), System.Drawing.Image)
        Me.btn5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btn5.FlatAppearance.BorderSize = 0
        Me.btn5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn5.Location = New System.Drawing.Point(75, 195)
        Me.btn5.Name = "btn5"
        Me.btn5.Size = New System.Drawing.Size(32, 32)
        Me.btn5.TabIndex = 68
        Me.btn5.UseVisualStyleBackColor = False
        '
        'btn4
        '
        Me.btn4.BackColor = System.Drawing.Color.Transparent
        Me.btn4.BackgroundImage = CType(resources.GetObject("btn4.BackgroundImage"), System.Drawing.Image)
        Me.btn4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btn4.FlatAppearance.BorderSize = 0
        Me.btn4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn4.Location = New System.Drawing.Point(75, 160)
        Me.btn4.Name = "btn4"
        Me.btn4.Size = New System.Drawing.Size(32, 32)
        Me.btn4.TabIndex = 67
        Me.btn4.UseVisualStyleBackColor = False
        '
        'btn3
        '
        Me.btn3.BackColor = System.Drawing.Color.Transparent
        Me.btn3.BackgroundImage = CType(resources.GetObject("btn3.BackgroundImage"), System.Drawing.Image)
        Me.btn3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btn3.FlatAppearance.BorderSize = 0
        Me.btn3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn3.Location = New System.Drawing.Point(75, 125)
        Me.btn3.Name = "btn3"
        Me.btn3.Size = New System.Drawing.Size(32, 32)
        Me.btn3.TabIndex = 66
        Me.btn3.UseVisualStyleBackColor = False
        '
        'btn2
        '
        Me.btn2.BackColor = System.Drawing.Color.Transparent
        Me.btn2.BackgroundImage = CType(resources.GetObject("btn2.BackgroundImage"), System.Drawing.Image)
        Me.btn2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btn2.FlatAppearance.BorderSize = 0
        Me.btn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn2.Location = New System.Drawing.Point(75, 90)
        Me.btn2.Name = "btn2"
        Me.btn2.Size = New System.Drawing.Size(32, 32)
        Me.btn2.TabIndex = 65
        Me.btn2.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = Global.Utility_Machine.My.Resources.Resources.advanced
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PictureBox1.Location = New System.Drawing.Point(5, 5)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(589, 322)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Main"
        Me.Text = "Utility Machine"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.W5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.W4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.W3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.W2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.W1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.intervalo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents intervalo As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Tiempo As System.Windows.Forms.TextBox
    Friend WithEvents lbl_inf As System.Windows.Forms.Label
    Friend WithEvents btn_todos As System.Windows.Forms.Button
    Friend WithEvents btn5 As System.Windows.Forms.Button
    Friend WithEvents btn4 As System.Windows.Forms.Button
    Friend WithEvents btn3 As System.Windows.Forms.Button
    Friend WithEvents btn2 As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txt_ataques5 As System.Windows.Forms.TextBox
    Friend WithEvents txt_ataques4 As System.Windows.Forms.TextBox
    Friend WithEvents txt_ataques3 As System.Windows.Forms.TextBox
    Friend WithEvents txt_ataques2 As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txt_ataques1 As System.Windows.Forms.TextBox
    Friend WithEvents txt_total As System.Windows.Forms.TextBox
    Friend WithEvents btn1 As System.Windows.Forms.Button
    Friend WithEvents txt_Port As System.Windows.Forms.TextBox
    Friend WithEvents txt_IP As System.Windows.Forms.TextBox
    Friend WithEvents T1 As System.Windows.Forms.Timer
    Friend WithEvents T2 As System.Windows.Forms.Timer
    Friend WithEvents T3 As System.Windows.Forms.Timer
    Friend WithEvents T4 As System.Windows.Forms.Timer
    Friend WithEvents T5 As System.Windows.Forms.Timer
    Friend WithEvents Timer As System.Windows.Forms.Timer
    Friend WithEvents W5 As AxMSWinsockLib.AxWinsock
    Friend WithEvents W4 As AxMSWinsockLib.AxWinsock
    Friend WithEvents W3 As AxMSWinsockLib.AxWinsock
    Friend WithEvents W2 As AxMSWinsockLib.AxWinsock
    Friend WithEvents W1 As AxMSWinsockLib.AxWinsock
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents LinkLabel2 As System.Windows.Forms.LinkLabel
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents LinkLabel3 As System.Windows.Forms.LinkLabel
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents LinkLabel5 As System.Windows.Forms.LinkLabel
    Friend WithEvents LinkLabel6 As System.Windows.Forms.LinkLabel
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox

End Class
