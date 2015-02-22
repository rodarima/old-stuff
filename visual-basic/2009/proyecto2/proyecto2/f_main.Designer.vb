<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class f_main
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(f_main))
        Me.txt = New System.Windows.Forms.TextBox
        Me.LbActualizar = New System.Windows.Forms.LinkLabel
        Me.LbUnidad = New System.Windows.Forms.Label
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.BtnAutOn = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.LbEstadoAutorun = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'txt
        '
        Me.txt.Location = New System.Drawing.Point(5, 5)
        Me.txt.Name = "txt"
        Me.txt.Size = New System.Drawing.Size(190, 20)
        Me.txt.TabIndex = 0
        '
        'LbActualizar
        '
        Me.LbActualizar.AutoSize = True
        Me.LbActualizar.Location = New System.Drawing.Point(10, 40)
        Me.LbActualizar.Name = "LbActualizar"
        Me.LbActualizar.Size = New System.Drawing.Size(53, 13)
        Me.LbActualizar.TabIndex = 1
        Me.LbActualizar.TabStop = True
        Me.LbActualizar.Text = "Actualizar"
        '
        'LbUnidad
        '
        Me.LbUnidad.AutoSize = True
        Me.LbUnidad.Location = New System.Drawing.Point(10, 60)
        Me.LbUnidad.Name = "LbUnidad"
        Me.LbUnidad.Size = New System.Drawing.Size(67, 13)
        Me.LbUnidad.TabIndex = 3
        Me.LbUnidad.Text = "                    "
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 5000
        '
        'BtnAutOn
        '
        Me.BtnAutOn.Location = New System.Drawing.Point(245, 145)
        Me.BtnAutOn.Name = "BtnAutOn"
        Me.BtnAutOn.Size = New System.Drawing.Size(105, 25)
        Me.BtnAutOn.TabIndex = 4
        Me.BtnAutOn.Text = "Desactivar autorun"
        Me.BtnAutOn.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(245, 120)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(105, 25)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "Activar autorun"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'LbEstadoAutorun
        '
        Me.LbEstadoAutorun.AutoSize = True
        Me.LbEstadoAutorun.Location = New System.Drawing.Point(245, 105)
        Me.LbEstadoAutorun.Name = "LbEstadoAutorun"
        Me.LbEstadoAutorun.Size = New System.Drawing.Size(46, 13)
        Me.LbEstadoAutorun.TabIndex = 6
        Me.LbEstadoAutorun.Text = "             "
        '
        'f_main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(579, 299)
        Me.Controls.Add(Me.LbEstadoAutorun)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.BtnAutOn)
        Me.Controls.Add(Me.LbUnidad)
        Me.Controls.Add(Me.LbActualizar)
        Me.Controls.Add(Me.txt)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "f_main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Utilidades"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txt As System.Windows.Forms.TextBox
    Friend WithEvents LbActualizar As System.Windows.Forms.LinkLabel
    Friend WithEvents LbUnidad As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents BtnAutOn As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents LbEstadoAutorun As System.Windows.Forms.Label
End Class
