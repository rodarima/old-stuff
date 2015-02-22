Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Dim Var1 As Double = 3 / 2
        'Dim Var2 As Integer = 3 / 2
        'Dim Var3 As Double = Var2 - Var1
        'MsgBox(Var1 & vbNewLine & Var2 & vbNewLine & Var3)
        'PlaySound("Startup.wav", 1)
    End Sub

    Sub PlaySound(ByVal SoundFile As String, ByVal Volume As Integer)
        My.Computer.Audio.Play(SoundFile, Volume)
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub PictureBox1_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox1.MouseEnter
        PictureBox1.Image = Exploraweb.My.Resources.Resources.new_doc
    End Sub


    Private Sub PictureBox1_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox1.MouseLeave
        PictureBox1.Image = Exploraweb.My.Resources.Resources.search
    End Sub
End Class
