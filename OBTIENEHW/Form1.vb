Imports System.Management

Imports System.Threading
Imports System.Xml
Imports System.Environment
Imports Microsoft.VisualBasic.Devices
'Imports ClassLibrary1
Imports Microsoft.Win32
Imports Microsoft.SqlServer
Imports Microsoft.CSharp

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'ByVal sender As System.Object,
        '      ByVal e As System.EventArgs) Handles MyBase.Load
        ' Obtener información del sistema operativo
        Dim consultaSQLSO As String = "SELECT * FROM Win32_OperatingSystem"
        Dim objSO As New ManagementObjectSearcher(consultaSQLSO)
        For Each info As ManagementObject In objSO.Get()
            lInfoSistemaOperativo.Text =
                info.Properties("Caption").Value.ToString().Trim()
            'lInfoVersionSistemaOperativo.Text =
            '    info.Properties("Version").Value.ToString() &
            '    " Service Pack " &
            '    info.Properties("ServicePackMajorVersion").Value.ToString() & "." &
            'info.Properties("ServicePackMinorVersion").Value.ToString()
        Next info


        ' obtener nombre procesador 
        Dim consultaSQLArquitectura2 As String = "SELECT * FROM Win32_Processor"
        Dim objArquitectura2 As New ManagementObjectSearcher(consultaSQLArquitectura2)
        For Each info As ManagementObject In objArquitectura2.Get()
            lInfoVersionSistemaOperativo.Text =
                info.Properties("Name").Value.ToString()   'ProcessorId      Caption      Family
        Next info

        ' Obtener número de cores del procesador (nucleos)
        Dim consultaSQLCores As String = "SELECT * FROM Win32_Processor"
        Dim objCores As New ManagementObjectSearcher(consultaSQLCores)
        For Each info As ManagementObject In objCores.Get()
            lInfoNumeroCoresCPUF.Text =
                info.Properties("NumberOfCores").Value.ToString()
        Next info

        ' Obtener número de cores del procesador (hilos)
        Dim consultaSQLCores2 As String = "SELECT * FROM Win32_ComputerSystem"
        Dim objCores2 As New ManagementObjectSearcher(consultaSQLCores2)
        For Each info As ManagementObject In objCores2.Get()
            lInfoNumeroCoresCPU.Text =
                info.Properties("NumberOfLogicalProcessors").Value.ToString()
        Next info

        ' obtener arquitectura procesador (GHz)
        Dim consultaSQLArquitectura As String = "SELECT * FROM Win32_Processor"
        Dim objArquitectura As New ManagementObjectSearcher(consultaSQLArquitectura)
        For Each info As ManagementObject In objArquitectura.Get()
            lInfoArquitecturaCPU.Text =
                (info.Properties("CurrentClockSpeed").Value / 1000).ToString()
        Next info




    End Sub
End Class
