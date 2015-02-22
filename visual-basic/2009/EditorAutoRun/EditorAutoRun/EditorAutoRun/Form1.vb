Option Explicit On
Option Strict On
Imports System.IO
Imports System

Public Class Form1

    Private Sub Form1_Load( _
        ByVal sender As System.Object, _
        ByVal e As System.EventArgs) Handles MyBase.Load
        On Error Resume Next
        TextBox2.Text = "El fichero AutoRun.inf no existe, asegúrese que se encuentra dentro de la carpeta raíz."
        Dim datos As New StreamReader("autorun.inf")
        ' lee todo el contenido y lo asigna al textbox
        TextBox2.Text = datos.ReadToEnd
        datos.Close() ' cierra
        TextBox1.Text = "El fichero AutoRun.txt no existe, asegúrese que se encuentra dentro de la carpeta raíz."
        Dim txt As New StreamReader("autorun.txt")
        ' lee todo el contenido y lo asigna al textbox
        TextBox1.Text = txt.ReadToEnd
        txt.Close() ' cierra
    End Sub


    Private Sub Button1_Click( _
        ByVal sender As System.Object, _
        ByVal e As System.EventArgs) Handles Button1.Click

        ' nuevo diálogo
        Dim OpenFiledlg As New OpenFileDialog
        With OpenFiledlg
            .Title = "Seleccionar archivo de texto"
            .Filter = "Archivos de texto *.txt|*.txt"
            Try
                If .ShowDialog = Windows.Forms.DialogResult.OK Then
                    Dim datos As New StreamReader(.FileName)
                    ' lee todo el contenido y lo asigna al textbox
                    TextBox1.Text = datos.ReadToEnd
                    datos.Close() ' cierra
                End If
                ' error
            Catch oMen As Exception
                MsgBox(oMen.Message, MsgBoxStyle.Critical)
            End Try
        End With
    End Sub

    Private Sub Button2_Click( _
        ByVal sender As System.Object, _
        ByVal e As System.EventArgs) Handles Button2.Click

        ' nuevo diálogo
        Dim OpenFiledlg As New OpenFileDialog
        With OpenFiledlg
            .Title = "Seleccionar archivo de texto"
            .Filter = "Archivos de configuracion *.inf|*.inf"
            Try
                If .ShowDialog = Windows.Forms.DialogResult.OK Then
                    Dim datos As New StreamReader(.FileName)
                    ' lee todo el contenido y lo asigna al textbox
                    TextBox2.Text = datos.ReadToEnd
                    datos.Close() ' cierra
                End If
                ' error
            Catch oMen As Exception
                MsgBox(oMen.Message, MsgBoxStyle.Critical)
            End Try
        End With
    End Sub



    
    
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim ArchivoTexto As String = ("Archivo.txt")
        FileOpen(1, ArchivoTexto, OpenMode.Output, OpenAccess.Write)
        PrintLine(1, TextBox1.Text)
        FileClose(1)

    End Sub
End Class

