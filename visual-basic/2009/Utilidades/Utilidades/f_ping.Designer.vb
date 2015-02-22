<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class f_ping
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
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.List1 = New System.Windows.Forms.ListBox
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Interval = 300
        '
        'List1
        '
        Me.List1.FormattingEnabled = True
        Me.List1.Location = New System.Drawing.Point(0, -1)
        Me.List1.Name = "List1"
        Me.List1.Size = New System.Drawing.Size(45, 212)
        Me.List1.TabIndex = 2
        '
        'f_ping
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(46, 214)
        Me.Controls.Add(Me.List1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "f_ping"
        Me.Opacity = 0.95
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ping"
        Me.TopMost = True
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents List1 As System.Windows.Forms.ListBox
End Class
