Option Explicit On
Option Strict On

Public Class Form1
    ' variables
    Private x As Integer
    Private y As Integer
    Private mover As Boolean

    Private Sub Form1_MouseDown( _
        ByVal sender As Object, _
        ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseDown

        If e.Button = Windows.Forms.MouseButtons.Left Then
            ' habilitar el flag
            mover = True
            ' guardar las coordenadas
            x = e.X
            y = e.Y
            ' cambiar el cursor del mouse
            Me.Cursor = Cursors.NoMove2D
        End If
    End Sub

    Private Sub Form1_MouseMove( _
        ByVal sender As Object, _
        ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove

        If mover Then
            ' establecer la nueva posición
            Me.Location = New Point((Me.Left + e.X - x), (Me.Top + e.Y - y))
        End If

    End Sub

    Private Sub Form1_MouseUp( _
        ByVal sender As Object, _
        ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseUp
        ' reestablecer
        mover = False
        Me.Cursor = Cursors.Default
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class

