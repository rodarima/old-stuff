Option Strict On

Imports Microsoft.VisualBasic
Imports System
Imports System.Text

Imports System.Runtime.InteropServices

Module discos
    Public result As String
    Public letresult As String
    Enum TipoUnidades As Integer
        ' Indico también los valores del API (empiezan por cero y van de uno en uno)
        Desconocido     ' 0 DRIVE_UNKNOWN       The drive type cannot be determined.
        No_montado      ' 1 DRIVE_NO_ROOT_DIR   The root path is invalid;
        '                                       for example, there is no volume mounted at the path.
        Extraible       ' 2 DRIVE_REMOVABLE     The drive has removable media;
        '                                       for example, a floppy drive or flash card reader.
        '                                       Las llaves USB los da como extraibles.
        Fijo            ' 3 DRIVE_FIXED         The drive has fixed media;
        '                                       for example, a hard drive, flash drive, or thumb drive.
        '                                       Los discos duros normales enchufados por USB son fijos.
        Remoto          ' 4 DRIVE_REMOTE        The drive is a remote (network) drive. 
        CDROM           ' 5 DRIVE_CDROM         The drive is a CD-ROM drive.
        RAMDISK         ' 6 DRIVE_RAMDISK       The drive is a RAM disk.
    End Enum

    ' Para el tipo de unidad
    'Private Declare Function GetDriveType Lib "kernel32.dll" Alias "GetDriveTypeA" _
    '        (ByVal nDrive As String) As TipoUnidades

    <DllImport("kernel32.dll")> _
    Private Function GetDriveType(ByVal nDrive As String) As TipoUnidades
    End Function

    ' Para las unidades lógicas libres y ocupadas
    'Private Declare Function GetLogicalDrives Lib "kernel32.dll" () As Integer

    <DllImport("kernel32.dll")> _
    Private Function GetLogicalDrives() As Integer
    End Function

    Sub Main()
        Dim ret As Integer
        Dim retType As TipoUnidades
        Dim sbLibres As New StringBuilder
        Dim leOcupadas As New StringBuilder
        Dim sbOcupadas As New StringBuilder


        ret = GetLogicalDrives()
        If ret > 0 Then
            For i As Integer = 0 To 25
                Dim sUnidad As String = ChrW(i + 65) & ": "
                retType = GetDriveType(sUnidad)
                Dim lUnidad As String = ChrW(i + 65)
                ' Si el bit es cero, es que no existe la unidad o no está mapeada
                If (ret And CInt(2 ^ i)) = 0 Then
                    ' Mostrar el nombre de la unidad disponible
                    sbLibres.AppendFormat("{0}, ", sUnidad & vbNewLine)

                Else
                    ' Mostrar el nombre de la unidad ocupada
                    sbOcupadas.AppendFormat("{0} ({1}){2}", sUnidad, retType, vbNewLine)
                    leOcupadas.AppendFormat(lUnidad & vbNewLine)
                End If

            Next
            result = "Unidades disponibles:" & vbNewLine & sbOcupadas.ToString
            letresult = leOcupadas.ToString & vbNewLine
            Console.WriteLine("Unidades ocupadas:")
            Console.WriteLine(sbOcupadas.ToString)
            Console.WriteLine()
            Console.WriteLine("Unidades libres:")
            Console.WriteLine(sbLibres.ToString)
        Else
            result = "No se ha podido obtener la información de las unidades lógicas"
            Console.WriteLine("No se ha podido obtener la información de las unidades lógicas")
        End If


        ' Para ver las unidades usando clases de .NET
        Console.WriteLine()
        Console.WriteLine("Unidades lógicas usando la clase Environment:")
        Dim drives() As String = Environment.GetLogicalDrives()
        Console.WriteLine("GetLogicalDrives: {0}", String.Join(", ", drives))

        Console.WriteLine()
        Console.WriteLine("Pulsa INTRO")
        Console.ReadLine()

    End Sub

End Module

