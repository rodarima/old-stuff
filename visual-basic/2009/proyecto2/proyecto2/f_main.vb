Option Explicit On
Imports Microsoft.Win32

Public Class f_main
  
    Private Sub f_main_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        f_auth.Close()


        If ident.ide = 1 Then
            txt.Text = "sesion registrada"
        End If
        If ident.ide = 0 Then
            txt.Text = "sesion como invitado"
            Me.Text = Me.Text & " - Sesión como Invitado"
        End If
        discos.Main()
        LbUnidad.Text = discos.result

    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LbActualizar.LinkClicked
        discos.Main()
        LbUnidad.Text = discos.result
    End Sub


    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        discos.Main()
        LbUnidad.Text = discos.result
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAutOn.Click
        Dim WshShell As Object
        WshShell = CreateObject("WScript.Shell")
        WshShell.RegWrite("HKCU\Software\Microsoft\Windows\CurrentVersion\Policies\Explorer\NoDriveTypeAutoRun", 181, "REG_DWORD")
        WshShell = Nothing
        StReg()

    End Sub

    Private Function StReg() As String
        Dim WshShell As Object
        WshShell = CreateObject("WScript.Shell")
        Dim StAutorun As String = WshShell.RegRead("HKCU\Software\Microsoft\Windows\CurrentVersion\Policies\Explorer\NoDriveTypeAutoRun")
        WshShell = Nothing


        If StAutorun = 181 Then
            LbEstadoAutorun.Text = "Reproduccion automática desactivada"
        End If
        If StAutorun = 141 Then
            LbEstadoAutorun.Text = "Reproduccion automática activada"
        End If
    End Function





    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim WshShell As Object
        WshShell = CreateObject("WScript.Shell")
        WshShell.RegWrite("HKCU\Software\Microsoft\Windows\CurrentVersion\Policies\Explorer\NoDriveTypeAutoRun", 141, "REG_DWORD")
        WshShell = Nothing
        StReg()

    End Sub
End Class

