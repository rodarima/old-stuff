<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Proteger_inf = New System.Windows.Forms.Button
        Me.Borrar_inf = New System.Windows.Forms.Button
        Me.Guardar_inf = New System.Windows.Forms.Button
        Me.Text_inf = New System.Windows.Forms.TextBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Borrar_txt = New System.Windows.Forms.Button
        Me.Guardar_txt = New System.Windows.Forms.Button
        Me.Text_txt = New System.Windows.Forms.TextBox
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip
        Me.Estado_dir = New System.Windows.Forms.ToolStripStatusLabel
        Me.Estado_txt = New System.Windows.Forms.ToolStripStatusLabel
        Me.Estado_inf = New System.Windows.Forms.ToolStripStatusLabel
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Proteger_inf)
        Me.GroupBox2.Controls.Add(Me.Borrar_inf)
        Me.GroupBox2.Controls.Add(Me.Guardar_inf)
        Me.GroupBox2.Controls.Add(Me.Text_inf)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 191)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(483, 173)
        Me.GroupBox2.TabIndex = 7
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Visor AutoRun"
        '
        'Proteger_inf
        '
        Me.Proteger_inf.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Proteger_inf.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Proteger_inf.Location = New System.Drawing.Point(115, 142)
        Me.Proteger_inf.Name = "Proteger_inf"
        Me.Proteger_inf.Size = New System.Drawing.Size(95, 23)
        Me.Proteger_inf.TabIndex = 5
        Me.Proteger_inf.Text = "Proteger"
        Me.Proteger_inf.UseVisualStyleBackColor = True
        '
        'Borrar_inf
        '
        Me.Borrar_inf.Location = New System.Drawing.Point(65, 142)
        Me.Borrar_inf.Name = "Borrar_inf"
        Me.Borrar_inf.Size = New System.Drawing.Size(44, 23)
        Me.Borrar_inf.TabIndex = 3
        Me.Borrar_inf.Text = "Borrar"
        Me.Borrar_inf.UseVisualStyleBackColor = True
        '
        'Guardar_inf
        '
        Me.Guardar_inf.Location = New System.Drawing.Point(6, 142)
        Me.Guardar_inf.Name = "Guardar_inf"
        Me.Guardar_inf.Size = New System.Drawing.Size(53, 23)
        Me.Guardar_inf.TabIndex = 4
        Me.Guardar_inf.Text = "Guardar"
        Me.Guardar_inf.UseVisualStyleBackColor = True
        '
        'Text_inf
        '
        Me.Text_inf.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Text_inf.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Text_inf.Location = New System.Drawing.Point(6, 19)
        Me.Text_inf.Multiline = True
        Me.Text_inf.Name = "Text_inf"
        Me.Text_inf.Size = New System.Drawing.Size(471, 117)
        Me.Text_inf.TabIndex = 2
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Borrar_txt)
        Me.GroupBox1.Controls.Add(Me.Guardar_txt)
        Me.GroupBox1.Controls.Add(Me.Text_txt)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(483, 173)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Visor fichero txt"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(88, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 13)
        Me.Label1.TabIndex = 9
        '
        'Borrar_txt
        '
        Me.Borrar_txt.Location = New System.Drawing.Point(65, 140)
        Me.Borrar_txt.Name = "Borrar_txt"
        Me.Borrar_txt.Size = New System.Drawing.Size(44, 23)
        Me.Borrar_txt.TabIndex = 8
        Me.Borrar_txt.Text = "Borrar"
        Me.Borrar_txt.UseVisualStyleBackColor = True
        '
        'Guardar_txt
        '
        Me.Guardar_txt.Location = New System.Drawing.Point(6, 140)
        Me.Guardar_txt.Name = "Guardar_txt"
        Me.Guardar_txt.Size = New System.Drawing.Size(53, 23)
        Me.Guardar_txt.TabIndex = 2
        Me.Guardar_txt.Text = "Guardar"
        Me.Guardar_txt.UseVisualStyleBackColor = True
        '
        'Text_txt
        '
        Me.Text_txt.AllowDrop = True
        Me.Text_txt.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Text_txt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Text_txt.Location = New System.Drawing.Point(9, 19)
        Me.Text_txt.Multiline = True
        Me.Text_txt.Name = "Text_txt"
        Me.Text_txt.Size = New System.Drawing.Size(468, 115)
        Me.Text_txt.TabIndex = 1
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Estado_dir, Me.Estado_txt, Me.Estado_inf})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 370)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(499, 24)
        Me.StatusStrip1.TabIndex = 11
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'Estado_dir
        '
        Me.Estado_dir.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Estado_dir.ForeColor = System.Drawing.Color.Red
        Me.Estado_dir.Name = "Estado_dir"
        Me.Estado_dir.Size = New System.Drawing.Size(190, 19)
        Me.Estado_dir.Text = "ToolStripStatusLabel1"
        '
        'Estado_txt
        '
        Me.Estado_txt.Name = "Estado_txt"
        Me.Estado_txt.Size = New System.Drawing.Size(111, 19)
        Me.Estado_txt.Text = "ToolStripStatusLabel1"
        '
        'Estado_inf
        '
        Me.Estado_inf.Name = "Estado_inf"
        Me.Estado_inf.Size = New System.Drawing.Size(111, 19)
        Me.Estado_inf.Text = "ToolStripStatusLabel1"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(499, 394)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "Form1"
        Me.Opacity = 0.95
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Editor de AutoRun"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Text_inf As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Guardar_txt As System.Windows.Forms.Button
    Friend WithEvents Text_txt As System.Windows.Forms.TextBox
    Friend WithEvents Guardar_inf As System.Windows.Forms.Button
    Friend WithEvents Proteger_inf As System.Windows.Forms.Button
    Friend WithEvents Borrar_inf As System.Windows.Forms.Button
    Friend WithEvents Borrar_txt As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents Estado_dir As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Estado_txt As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Estado_inf As System.Windows.Forms.ToolStripStatusLabel

End Class
