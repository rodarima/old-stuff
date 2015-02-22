Imports System.Net
Imports System.Net.Sockets
Imports System.Runtime.InteropServices
Public Class f_ping

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Dim Packet As New APing.CPing
        Dim retValue
        Dim aa As String = List1.Items.Count()
        If aa = "15" Then
            List1.Items.Clear()
        End If
        Packet.HostName = Trim("209.85.229.106")
        If Packet.Open Then
            retValue = Packet.Ping
            If retValue <> -1 Then
                List1.Items.Add(retValue)

            Else
                List1.Items.Add("Error")
            End If
            Packet.Close()


        End If
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim oClass As Class1
        oClass = New Class1()
        oClass.Comenzar(Me, 0.95, 3)
        Timer1.Start()
    End Sub

End Class




Namespace APing
    Structure Angel_Ping
#Region "VARIABLES"
        Dim Data() As Byte
        Dim Type_Message As Byte
        Dim SubCode_type As Byte
        Dim Complement_CheckSum As UInt16
        Dim Identifier As UInt16
        Dim SequenceNumber As UInt16
#End Region
#Region "Metodos"
        Public Sub Initialize(ByVal type As Byte, ByVal subCode As Byte, ByVal payload() As Byte)
            Dim Buffer_IcmpPacket() As Byte
            Dim CksumBuffer() As UInt16
            Dim IcmpHeaderBufferIndex As Int32 = 0
            Dim Index As Integer
            Me.Type_Message = type
            Me.SubCode_type = subCode
            Complement_CheckSum = UInt16.Parse("0")
            Identifier = UInt16.Parse("45")
            SequenceNumber = UInt16.Parse("0")
            Data = payload
            Buffer_IcmpPacket = Serialize()
            ReDim cksumBuffer((Buffer_IcmpPacket.Length() \ 2) - 1)
            For index = 0 To (cksumBuffer.Length() - 1)
                cksumBuffer(Index) = BitConverter.ToUInt16(Buffer_IcmpPacket, icmpHeaderBufferIndex)
                icmpHeaderBufferIndex += 2
            Next index
            Complement_CheckSum = MCheckSum.Calculate(cksumBuffer, cksumBuffer.Length())
        End Sub
        Public Function Size() As Integer
            Return (8 + Data.Length())
        End Function
        Public Function Serialize() As Byte()
            Dim Buffer() As Byte
            Dim B_Seq() As Byte = BitConverter.GetBytes(SequenceNumber)
            Dim B_Cksum() As Byte = BitConverter.GetBytes(Complement_CheckSum)
            Dim B_Id() As Byte = BitConverter.GetBytes(Identifier)
            Dim Index As Int32 = 0
            ReDim Buffer(Size() - 1)
            Buffer(0) = Type_Message
            Buffer(1) = SubCode_type
            Index += 2
            Array.Copy(B_Cksum, 0, Buffer, Index, 2) : Index += 2
            Array.Copy(B_Id, 0, Buffer, Index, 2) : Index += 2
            Array.Copy(B_Seq, 0, Buffer, Index, 2) : Index += 2
            If (Data.Length() > 0) Then Array.Copy(Data, 0, Buffer, Index, Data.Length())
            Return Buffer
        End Function
#End Region
    End Structure
    Public Class CPing
#Region "Contactes"
        Private Const DATA_SIZE As Integer = 32
        Private Const DEFAULT_TIMEOUT As Integer = 1500
        Private Const ICMP_ECHO As Integer = 8
        Private Const SOCKET_ERROR As Integer = -1
        Private Const PING_ERROR As Integer = -1
        Private Const RECV_SIZE As Integer = 128
#End Region
#Region "VARIABLES"
        Private _Open As Boolean = False
        Private _Initialized As Boolean
        Private _RecvBuffer() As Byte
        Private _Packet As Angel_Ping
        Private _HostName As String
        Private _Server As EndPoint
        Private _Local As EndPoint
        Private _Socket As Socket
#End Region
#Region "CONSTRUCTORS & FINALIZER"
        Public Sub New(ByVal hostName As String)
            Me.HostName() = hostName
            ReDim _recvBuffer(RECV_SIZE - 1)
        End Sub
        Public Sub New()
            Me.HostName() = Dns.GetHostName()
            ReDim _recvBuffer(RECV_SIZE - 1)
        End Sub
        Private Overloads Sub finalize()
            Me.Close()
            Erase _recvBuffer
        End Sub
#End Region
#Region "Metodos"
        Public Property HostName() As String
            Get
                Return _hostName
            End Get
            Set(ByVal Value As String)
                _hostName = Value
                If (_open) Then
                    Me.Close()
                    Me.Open()
                End If
            End Set
        End Property
        Public ReadOnly Property IsOpen() As Boolean
            Get
                Return _open
            End Get
        End Property
        Public Function Open() As Boolean
            Dim Payload() As Byte
            If (Not _open) Then
                Try
                    ReDim payload(DATA_SIZE)
                    _packet.Initialize(ICMP_ECHO, 0, payload)
                    _socket = New Socket(AddressFamily.InterNetwork, SocketType.Raw, ProtocolType.Icmp)
                    _server = New IPEndPoint(Dns.GetHostByName(_hostName).AddressList(0), 0)
                    _local = New IPEndPoint(Dns.GetHostByName(Dns.GetHostName()).AddressList(0), 0)
                    _open = True
                Catch
                    Return False
                End Try
            End If
            Return True
        End Function
        Public Function Close() As Boolean
            If (_open) Then
                _socket.Close()
                _socket = Nothing
                _server = Nothing
                _local = Nothing
                _open = False
            End If
            Return True
        End Function
        Public Overloads Function Ping() As Integer
            Return Ping(DEFAULT_TIMEOUT)
        End Function
        Public Overloads Function Ping(ByVal timeOutMilliSeconds As Integer) As Integer
            Dim TimeOut As Integer = timeOutMilliSeconds + Environment.TickCount()
            Try
                If (SOCKET_ERROR = _socket.SendTo(_packet.Serialize(), _packet.Size(), 0, _server)) Then
                    Return PING_ERROR
                End If
            Catch
            End Try
            Do
                If (_socket.Poll(1000, SelectMode.SelectRead)) Then
                    _socket.ReceiveFrom(_recvBuffer, RECV_SIZE, 0, _local)
                    Return (timeOutMilliSeconds - (timeOut - Environment.TickCount()))
                ElseIf (Environment.TickCount() >= timeOut) Then
                    Return PING_ERROR
                End If
            Loop While (True)
        End Function
#End Region
    End Class
    Module MCheckSum
#Region "Metodos"
        <StructLayout(LayoutKind.Explicit)> Structure UNION_INT16
            <FieldOffset(0)> Dim lsb As Byte
            <FieldOffset(1)> Dim msb As Byte
            <FieldOffset(0)> Dim w16 As Short
        End Structure
        <StructLayout(LayoutKind.Explicit)> Structure UNION_INT32
            <FieldOffset(0)> Dim lsw As UNION_INT16
            <FieldOffset(2)> Dim msw As UNION_INT16     '
            <FieldOffset(0)> Dim w32 As Integer
        End Structure
        Public Function Calculate(ByRef buffer() As UInt16, ByVal size As Int32) As UInt16
            Dim Counter As Int32 = 0
            Dim Cksum32 As UNION_INT32
            Do While (size > 0)
                cksum32.w32 += Convert.ToInt32(buffer(counter))
                counter += 1
                size -= 1
            Loop
            cksum32.w32 = cksum32.msw.w16 + cksum32.lsw.w16 + cksum32.msw.w16
            Return Convert.ToUInt16(cksum32.lsw.w16 Xor &HFFFF)
        End Function
#End Region
    End Module
End Namespace
