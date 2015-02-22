Option Explicit On

Imports System.Security.Cryptography
Imports System.Text


Public Class f_auth

    Private Sub txt_pass_KeyPress(ByVal sender As Object, _
                              ByVal e As System.Windows.Forms.KeyPressEventArgs) _
                              Handles txt_pass.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            registrar()
        End If
    End Sub



    Public Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        
        registrar()
        
    End Sub
    Private Function registrar() As String

        Dim md5str As String
        Dim md5txt As String
        md5str = getMd5(txt_user.Text) & getMd5(txt_pass.Text)
        md5txt = getMd5(md5str)
        txt.Text = getMd5(md5str)
        If txt_user.Text = "" Then
            status.ForeColor = Color.Red
            status.Text = "Debe escribir un nombre de usuario"
        Else
            If txt_pass.Text = "" Then
                status.ForeColor = Color.Red
                status.Text = "Debe escribir una contraseña"
            Else
                If md5txt = "31d583f3c100078c0afd0b21c5597f34" Then
                    status.ForeColor = Color.Green
                    status.Text = "Correcto"
                    ident.ide = 1
                    f_main.Show()
                    Me.Hide()

                Else
                    status.ForeColor = Color.Red
                    status.Text = "Contraseña o usuario incorrectos"

                End If
            End If
        End If
    End Function

    Private Function getMd5(ByVal input As String) As String
        Dim md5Hasher As New MD5CryptoServiceProvider()
        Dim data As Byte() = md5Hasher.ComputeHash(Encoding.Default.GetBytes(input))
        Dim sBuilder As New StringBuilder()
        Dim i As Integer
        For i = 0 To data.Length - 1
            sBuilder.Append(data(i).ToString("x2"))
        Next i
        Return sBuilder.ToString()
    End Function

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub



    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        ident.ide = 0

        f_main.Show()
        Me.Hide()
    End Sub
End Class
