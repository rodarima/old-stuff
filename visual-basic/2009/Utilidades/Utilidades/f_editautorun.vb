Option Explicit On
Option Strict On
Imports System.IO
Imports System
Public Class f_editautorun

    Private Sub f_editautorun_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim oClass As Class1
        oClass = New Class1()
        oClass.Comenzar(Me, 0.95, 3)
        actualizar()
    End Sub

    Function actualizar() As String
        On Error Resume Next
        Dim dir_status As String
        Dim inf_status As String
        Dim txt_status As String
        Dim inf As New StreamReader("autorun.inf")
        Dim txt As New StreamReader("autorun.txt")




        If Directory.Exists("autorun.inf") Then
            dir_status = "PROTEGIDO"
            dir_estatus.ForeColor = Color.Green
            'btn_proteger.Text = "Desproteger"
            'btn_proteger.ForeColor = Color.Red
            btn_guardar_inf.Enabled = False

        Else
            dir_status = "DESPROTEGIDO"
            dir_estatus.ForeColor = Color.Red
            'btn_proteger.Text = "Proteger"
            'btn_proteger.ForeColor = Color.Green
            btn_guardar_inf.Enabled = True


        End If

        If File.Exists("autorun.inf") Then
            inf_status = "Encontrado AutoRun.INF"
            Text_inf.Text = inf.ReadToEnd
            inf.Close()
            'btn_guardar_inf.Text = "Guardar"
            inf_estatus.ForeColor = Color.Green
            btn_borrar_inf.Enabled = True

        Else
            inf_status = "No existe AutoRun.INF"
            Text_inf.Text = "Fichero no encontrado"
            'btn_guardar_inf.Text = "Crear"
            inf_estatus.ForeColor = Color.Red
            btn_borrar_inf.Enabled = False

        End If

        If File.Exists("autorun.txt") Then
            txt_status = "Encontrado AutoRun.TXT"
            Text_txt.Text = txt.ReadToEnd
            txt.Close()
            'btn_guardar_txt.Text = "Guardar"
            txt_estatus.ForeColor = Color.Green
            btn_borrar_txt.Enabled = True
        Else
            txt_status = "No existe AutoRun.TXT"
            Text_txt.Text = "Fichero no encontrado"
            'btn_guardar_txt.Text = "Crear"
            txt_estatus.ForeColor = Color.Red
            btn_borrar_txt.Enabled = False

        End If

        dir_estatus.Text = dir_status
        txt_estatus.Text = txt_status
        inf_estatus.Text = inf_status


    End Function
    Function sonido1() As String
        Dim reproductor As New System.Media.SoundPlayer
        Dim wind As String
        wind = Environment.GetEnvironmentVariable("WINDIR")
        reproductor.SoundLocation = wind + "\Media\start.wav"
        reproductor.Play()
    End Function
    
    Private Sub btn_guardar_inf_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_guardar_inf.Click
        On Error Resume Next
        sonido1()
        SetAttr("autorun.inf", CType(vbNormal, FileAttribute))
        Dim ArchivoInf As String = ("autorun.inf")
        FileOpen(1, ArchivoInf, OpenMode.Output, OpenAccess.Write)
        PrintLine(1, Text_inf.Text)
        FileClose(1)
        SetAttr("autorun.inf", CType(vbHidden + vbSystem + vbReadOnly, FileAttribute))
        actualizar()
    End Sub

    Private Sub btn_borrar_inf_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_borrar_inf.Click
        On Error Resume Next
        sonido1()
        SetAttr("autorun.inf", CType(vbNormal, FileAttribute))
        My.Computer.FileSystem.DeleteFile("autorun.inf")
        My.Computer.FileSystem.DeleteDirectory("autorun.inf", _
        FileIO.DeleteDirectoryOption.ThrowIfDirectoryNonEmpty)

        actualizar()
    End Sub

    Private Sub btn_proteger_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_proteger.Click
        On Error Resume Next
        sonido1()
        If Directory.Exists("autorun.inf") Then
            SetAttr("autorun.inf", CType(vbNormal, FileAttribute))
            My.Computer.FileSystem.DeleteDirectory("autorun.inf", _
FileIO.DeleteDirectoryOption.ThrowIfDirectoryNonEmpty)
            SetAttr("autorun.inf", CType(vbHidden + vbSystem + vbReadOnly, FileAttribute))
        Else

            borrar()
            My.Computer.FileSystem.CreateDirectory _
            ("autorun.inf")
            SetAttr("autorun.inf", CType(vbHidden + vbSystem + vbReadOnly, FileAttribute))
        End If
        actualizar()
    End Sub

    
    Function borrar() As String
        On Error Resume Next
        SetAttr("autorun.inf", CType(vbNormal, FileAttribute))
        My.Computer.FileSystem.DeleteFile("autorun.inf")
        My.Computer.FileSystem.DeleteDirectory("autorun.inf", _
FileIO.DeleteDirectoryOption.ThrowIfDirectoryNonEmpty)

    End Function

    Private Sub btn_salir_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_salir.Click
        sonido1()
        Me.Close()
    End Sub


    Private Sub btn_guardar_txt_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_guardar_txt.Click
        On Error Resume Next
        sonido1()
        Dim ArchivoTxt As String = ("autorun.txt")
        FileOpen(1, ArchivoTxt, OpenMode.Output, OpenAccess.Write)
        PrintLine(1, Text_txt.Text)
        FileClose(1)
        actualizar()
    End Sub

    Private Sub btn_borrar_txt_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_borrar_txt.Click
        On Error Resume Next
        sonido1()
        My.Computer.FileSystem.DeleteFile("autorun.txt")
        actualizar()
    End Sub
End Class