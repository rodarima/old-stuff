<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class f_editautorun
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
        Me.Text_txt = New System.Windows.Forms.TextBox
        Me.Text_inf = New System.Windows.Forms.TextBox
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip
        Me.dir_estatus = New System.Windows.Forms.ToolStripStatusLabel
        Me.txt_estatus = New System.Windows.Forms.ToolStripStatusLabel
        Me.inf_estatus = New System.Windows.Forms.ToolStripStatusLabel
        Me.estado_dir = New System.Windows.Forms.ToolStripStatusLabel
        Me.estado_txt = New System.Windows.Forms.ToolStripStatusLabel
        Me.estado_inf = New System.Windows.Forms.ToolStripStatusLabel
        Me.btn_borrar_txt = New System.Windows.Forms.Button
        Me.btn_guardar_txt = New System.Windows.Forms.Button
        Me.btn_proteger = New System.Windows.Forms.Button
        Me.btn_borrar_inf = New System.Windows.Forms.Button
        Me.btn_guardar_inf = New System.Windows.Forms.Button
        Me.btn_salir = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Text_txt
        '
        Me.Text_txt.Location = New System.Drawing.Point(15, 25)
        Me.Text_txt.Multiline = True
        Me.Text_txt.Name = "Text_txt"
        Me.Text_txt.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.Text_txt.Size = New System.Drawing.Size(517, 149)
        Me.Text_txt.TabIndex = 0
        '
        'Text_inf
        '
        Me.Text_inf.Location = New System.Drawing.Point(12, 234)
        Me.Text_inf.Multiline = True
        Me.Text_inf.Name = "Text_inf"
        Me.Text_inf.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.Text_inf.Size = New System.Drawing.Size(517, 149)
        Me.Text_inf.TabIndex = 1
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.dir_estatus, Me.txt_estatus, Me.inf_estatus})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 433)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.ManagerRenderMode
        Me.StatusStrip1.Size = New System.Drawing.Size(541, 23)
        Me.StatusStrip1.TabIndex = 8
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'dir_estatus
        '
        Me.dir_estatus.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dir_estatus.Name = "dir_estatus"
        Me.dir_estatus.Size = New System.Drawing.Size(146, 18)
        Me.dir_estatus.Text = "ToolStripStatusLabel1"
        '
        'txt_estatus
        '
        Me.txt_estatus.Name = "txt_estatus"
        Me.txt_estatus.Size = New System.Drawing.Size(111, 18)
        Me.txt_estatus.Text = "ToolStripStatusLabel1"
        '
        'inf_estatus
        '
        Me.inf_estatus.Name = "inf_estatus"
        Me.inf_estatus.Size = New System.Drawing.Size(111, 18)
        Me.inf_estatus.Text = "ToolStripStatusLabel1"
        '
        'estado_dir
        '
        Me.estado_dir.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.estado_dir.Name = "estado_dir"
        Me.estado_dir.Size = New System.Drawing.Size(190, 19)
        Me.estado_dir.Text = "ToolStripStatusLabel1"
        '
        'estado_txt
        '
        Me.estado_txt.Name = "estado_txt"
        Me.estado_txt.Size = New System.Drawing.Size(111, 19)
        Me.estado_txt.Text = "ToolStripStatusLabel1"
        '
        'estado_inf
        '
        Me.estado_inf.Name = "estado_inf"
        Me.estado_inf.Size = New System.Drawing.Size(111, 19)
        Me.estado_inf.Text = "ToolStripStatusLabel1"
        '
        'btn_borrar_txt
        '
        Me.btn_borrar_txt.FlatAppearance.BorderSize = 0
        Me.btn_borrar_txt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_borrar_txt.Image = Global.Utilidades.My.Resources.Resources.borrar
        Me.btn_borrar_txt.Location = New System.Drawing.Point(50, 180)
        Me.btn_borrar_txt.Name = "btn_borrar_txt"
        Me.btn_borrar_txt.Size = New System.Drawing.Size(32, 32)
        Me.btn_borrar_txt.TabIndex = 10
        Me.btn_borrar_txt.UseVisualStyleBackColor = True
        '
        'btn_guardar_txt
        '
        Me.btn_guardar_txt.FlatAppearance.BorderSize = 0
        Me.btn_guardar_txt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_guardar_txt.Image = Global.Utilidades.My.Resources.Resources.guardar
        Me.btn_guardar_txt.Location = New System.Drawing.Point(12, 180)
        Me.btn_guardar_txt.Name = "btn_guardar_txt"
        Me.btn_guardar_txt.Size = New System.Drawing.Size(32, 32)
        Me.btn_guardar_txt.TabIndex = 9
        Me.btn_guardar_txt.UseVisualStyleBackColor = True
        '
        'btn_proteger
        '
        Me.btn_proteger.FlatAppearance.BorderSize = 0
        Me.btn_proteger.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_proteger.Image = Global.Utilidades.My.Resources.Resources.proteger
        Me.btn_proteger.Location = New System.Drawing.Point(88, 389)
        Me.btn_proteger.Name = "btn_proteger"
        Me.btn_proteger.Size = New System.Drawing.Size(32, 32)
        Me.btn_proteger.TabIndex = 6
        Me.btn_proteger.UseVisualStyleBackColor = True
        '
        'btn_borrar_inf
        '
        Me.btn_borrar_inf.FlatAppearance.BorderSize = 0
        Me.btn_borrar_inf.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_borrar_inf.Image = Global.Utilidades.My.Resources.Resources.borrar
        Me.btn_borrar_inf.Location = New System.Drawing.Point(50, 389)
        Me.btn_borrar_inf.Name = "btn_borrar_inf"
        Me.btn_borrar_inf.Size = New System.Drawing.Size(32, 32)
        Me.btn_borrar_inf.TabIndex = 5
        Me.btn_borrar_inf.UseVisualStyleBackColor = True
        '
        'btn_guardar_inf
        '
        Me.btn_guardar_inf.FlatAppearance.BorderSize = 0
        Me.btn_guardar_inf.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_guardar_inf.Image = Global.Utilidades.My.Resources.Resources.guardar
        Me.btn_guardar_inf.Location = New System.Drawing.Point(12, 389)
        Me.btn_guardar_inf.Name = "btn_guardar_inf"
        Me.btn_guardar_inf.Size = New System.Drawing.Size(32, 32)
        Me.btn_guardar_inf.TabIndex = 4
        Me.btn_guardar_inf.UseVisualStyleBackColor = True
        '
        'btn_salir
        '
        Me.btn_salir.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn_salir.FlatAppearance.BorderSize = 0
        Me.btn_salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_salir.Image = Global.Utilidades.My.Resources.Resources.salir1
        Me.btn_salir.Location = New System.Drawing.Point(497, 389)
        Me.btn_salir.Name = "btn_salir"
        Me.btn_salir.Size = New System.Drawing.Size(32, 32)
        Me.btn_salir.TabIndex = 11
        Me.btn_salir.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 218)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(99, 13)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Visor de Autorun.inf"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(99, 13)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Visor de Autorun.txt"
        '
        'f_editautorun
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.CancelButton = Me.btn_salir
        Me.ClientSize = New System.Drawing.Size(541, 456)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_salir)
        Me.Controls.Add(Me.btn_borrar_txt)
        Me.Controls.Add(Me.btn_guardar_txt)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.btn_proteger)
        Me.Controls.Add(Me.btn_borrar_inf)
        Me.Controls.Add(Me.btn_guardar_inf)
        Me.Controls.Add(Me.Text_inf)
        Me.Controls.Add(Me.Text_txt)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "f_editautorun"
        Me.Opacity = 0.95
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Editor de Autorun"
        Me.TopMost = True
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Text_txt As System.Windows.Forms.TextBox
    Friend WithEvents Text_inf As System.Windows.Forms.TextBox
    Friend WithEvents btn_guardar_inf As System.Windows.Forms.Button
    Friend WithEvents btn_borrar_inf As System.Windows.Forms.Button
    Friend WithEvents btn_proteger As System.Windows.Forms.Button
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents estado_dir As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents estado_txt As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents estado_inf As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents btn_borrar_txt As System.Windows.Forms.Button
    Friend WithEvents btn_guardar_txt As System.Windows.Forms.Button
    Friend WithEvents btn_salir As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dir_estatus As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents txt_estatus As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents inf_estatus As System.Windows.Forms.ToolStripStatusLabel
End Class
