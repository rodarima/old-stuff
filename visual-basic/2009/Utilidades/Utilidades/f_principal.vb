Option Explicit On

Public Class f_principal

    Private Sub Form3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim oClass As Class2
        oClass = New Class2()
        oClass.Comenzar(Me, 0.99, 10)
        transparente()
        'sonido()
    End Sub
    Private Sub btn_1_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_editautorun.MouseHover
        txt_datos.Text = "Un editor de autorun para discos extraibles"

    End Sub
    Private Sub btn_1_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_editautorun.MouseLeave
        txt_datos.Text = ""
    End Sub
    Private Sub btn_1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_editautorun.Click
        sonido()
        f_editautorun.Show()
    End Sub
    Function sonido() As String
        Dim reproductor As New System.Media.SoundPlayer
        Dim wind As String
        wind = Environment.GetEnvironmentVariable("WINDIR")
        reproductor.SoundLocation = wind + "\Media\start.wav"
        reproductor.Play()
    End Function
    Private Sub btn_cerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cerrar.Click
        Me.Close()

    End Sub
    Function transparente()



        'CopyRight.Parent = PictureBox1
        'CopyRight.BackColor = Color.Transparent

        btn_editautorun.Parent = PictureBox1
        btn_editautorun.BackColor = Color.Transparent


        btn_encriptar.Parent = PictureBox1
        btn_encriptar.BackColor = Color.Transparent

        btn_instalar.Parent = PictureBox1
        btn_instalar.BackColor = Color.Transparent

        btn_dos.Parent = PictureBox1
        btn_dos.BackColor = Color.Transparent

        btn_ping.Parent = PictureBox1
        btn_ping.BackColor = Color.Transparent

    End Function
    Private Sub btn_2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_encriptar.Click
        sonido()
        f_encriptar.Show()
    End Sub
    Private Sub btn_3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_instalar.Click
        On Error Resume Next
        sonido()
        Shell("files/aimp.exe", AppWinStyle.NormalFocus, False)
    End Sub
    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_dos.Click
        On Error Resume Next
        sonido()
        f_ataquedos.Show()
        'panel_ataques.Parent = PictureBox1
        'panel_ataques.BackColor = Color.Transparent
        'panel_ataques.Visible = True
    End Sub

    Private Sub btn_encriptar_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_encriptar.MouseHover
        txt_datos.Text = "Un encriptador y desencriptador de Md5, Sha1 y Base64"
    End Sub

    Private Sub btn_encriptar_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_encriptar.MouseLeave
        txt_datos.Text = ""
    End Sub

    Private Sub btn_dos_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_dos.MouseHover
        txt_datos.Text = "Varias utilidades para lanzar ataques."
    End Sub

    Private Sub btn_dos_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_dos.MouseLeave
        txt_datos.Text = ""
    End Sub

    Private Sub btn_instalar_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_instalar.MouseHover
        txt_datos.Text = "Instalador de programas automático."
    End Sub

    Private Sub btn_instalar_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_instalar.MouseLeave
        txt_datos.Text = ""
    End Sub

    Private Sub btn_ping_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_ping.Click
        sonido()
        f_ping.Show()

    End Sub
End Class