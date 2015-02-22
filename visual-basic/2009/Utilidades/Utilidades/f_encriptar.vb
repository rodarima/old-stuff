Imports System.Security.Cryptography
Imports System.Text


Public Class f_encriptar



    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_int.TextChanged
        txt_md5.Text = getMd5(txt_int.Text)
        txt_sha1.Text = getsha1(txt_int.Text)
        txt_base64.Text = Encode(txt_int.Text)
        des_base64.Text = Decode(txt_int.Text)
        'Dim url As String
        'url = "http://md5.rednoize.com/?q=" + txt_int.Text
        'Web.Navigate(url)
        'Dim Datos As String
        'Datos = Web.DocumentText(CInt(url))
        'code.Text = Datos
    End Sub


    Public Function getMd5(ByVal input As String) As String
        Dim md5Hasher As New MD5CryptoServiceProvider()
        Dim data As Byte() = md5Hasher.ComputeHash(Encoding.Default.GetBytes(input))
        Dim sBuilder As New StringBuilder()
        Dim i As Integer
        For i = 0 To data.Length - 1
            sBuilder.Append(data(i).ToString("x2"))
        Next i
        Return sBuilder.ToString()
    End Function

    Public Function getsha1(ByVal input As String) As String
        Dim sha1Hasher As New SHA1CryptoServiceProvider()
        Dim data As Byte() = sha1Hasher.ComputeHash(Encoding.Default.GetBytes(input))
        Dim sBuilder As New StringBuilder()
        Dim i As Integer
        For i = 0 To data.Length - 1
            sBuilder.Append(data(i).ToString("x2"))
        Next i
        Return sBuilder.ToString()
    End Function
    Function Encode(ByVal dec As String) As String

        Dim bt() As Byte
        ReDim bt(dec.Length)
        bt = System.Text.Encoding.ASCII.GetBytes(dec)
        Dim enc As String
        enc = System.Convert.ToBase64String(bt)
        Return enc
    End Function

    Function EncodeByte(ByVal bt() As Byte) As String
        Dim enc As String
        enc = System.Convert.ToBase64String(bt)
        Return enc
    End Function

    Function Decode(ByVal enc As String) As String
        On Error Resume Next
        Dim bt() As Byte
        bt = System.Convert.FromBase64String(enc)
        Dim dec As String
        dec = System.Text.Encoding.ASCII.GetString(bt)
        Return dec
    End Function

    Function DecodeToByte(ByVal enc As String) As Byte()
        On Error Resume Next
        Dim bt() As Byte = System.Convert.FromBase64String(enc)
        Return bt
    End Function



    Private Sub f_encriptar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim oClass As Class1
        oClass = New Class1()
        oClass.Comenzar(Me, 0.95, 3)
    End Sub



    'Private Sub Web_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Web.GotFocus
    '    txt_int.Focus()
    'End Sub
End Class