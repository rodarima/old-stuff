Option Explicit On
Option Strict On
Imports System.IO
Imports System

Public Class Form1

    Private Sub Form1_Load( _
        ByVal sender As System.Object, _
        ByVal e As System.EventArgs) Handles MyBase.Load
        sonido2()
        actualizar()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Guardar_txt.Click
        On Error Resume Next
        sonido1()
        Dim ArchivoTxt As String = ("autorun.txt")
        FileOpen(1, ArchivoTxt, OpenMode.Output, OpenAccess.Write)
        PrintLine(1, Text_txt.Text)
        FileClose(1)
        actualizar()

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Guardar_inf.Click
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

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Borrar_inf.Click
        On Error Resume Next
        sonido1()
        SetAttr("autorun.inf", CType(vbNormal, FileAttribute))
        My.Computer.FileSystem.DeleteFile("autorun.inf")
        My.Computer.FileSystem.DeleteDirectory("autorun.inf", _
        FileIO.DeleteDirectoryOption.ThrowIfDirectoryNonEmpty)

        actualizar()
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Proteger_inf.Click
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

    Private Sub Borrar_txt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Borrar_txt.Click
        On Error Resume Next
        sonido1()
        My.Computer.FileSystem.DeleteFile("autorun.txt")
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
            Estado_dir.ForeColor = Color.Green
            Proteger_inf.Text = "Desproteger"
            Proteger_inf.ForeColor = Color.Red
            Guardar_inf.Enabled = False

        Else
            dir_status = "DESPROTEGIDO"
            Estado_dir.ForeColor = Color.Red
            Proteger_inf.Text = "Proteger"
            Proteger_inf.ForeColor = Color.Green
            Guardar_inf.Enabled = True


        End If

        If File.Exists("autorun.inf") Then
            inf_status = "Encontrado AutoRun.INF"
            Text_inf.Text = inf.ReadToEnd
            inf.Close()
            Guardar_inf.Text = "Guardar"
            Estado_inf.ForeColor = Color.Green
            Borrar_inf.Enabled = True

        Else
            inf_status = "No existe AutoRun.INF"
            Text_inf.Text = "Fichero no encontrado"
            Guardar_inf.Text = "Crear"
            Estado_inf.ForeColor = Color.Red
            Borrar_inf.Enabled = False

        End If

        If File.Exists("autorun.txt") Then
            txt_status = "Encontrado AutoRun.TXT"
            Text_txt.Text = txt.ReadToEnd
            txt.Close()
            Guardar_txt.Text = "Guardar"
            Estado_txt.ForeColor = Color.Green
            Borrar_txt.Enabled = True
        Else
            txt_status = "No existe AutoRun.TXT"
            Text_txt.Text = "Fichero no encontrado"
            Guardar_txt.Text = "Crear"
            Estado_txt.ForeColor = Color.Red
            Borrar_txt.Enabled = False

        End If

        Estado_dir.Text = dir_status
        Estado_txt.Text = txt_status
        Estado_inf.Text = inf_status


    End Function

    Function borrar() As String
        On Error Resume Next
        SetAttr("autorun.inf", CType(vbNormal, FileAttribute))
        My.Computer.FileSystem.DeleteFile("autorun.inf")
        My.Computer.FileSystem.DeleteDirectory("autorun.inf", _
FileIO.DeleteDirectoryOption.ThrowIfDirectoryNonEmpty)

    End Function
    Function sonido1() As String
        Dim reproductor As New System.Media.SoundPlayer
        Dim wind As String
        wind = Environment.GetEnvironmentVariable("WINDIR")
        reproductor.SoundLocation = wind + "\Media\start.wav"
        reproductor.Play()
    End Function
    Function sonido2() As String
        Dim reproductor As New System.Media.SoundPlayer
        Dim wind As String
        wind = Environment.GetEnvironmentVariable("WINDIR")
        reproductor.SoundLocation = wind + "\Media\tada.wav"
        reproductor.Play()
    End Function
End Class


