Imports System.Management
Imports System.Text
Imports System
Imports System.IO
Imports System.Threading

Public Class LiveStatus
    Private PerCounter As System.Diagnostics.PerformanceCounter
    Dim cpu As PerformanceCounter


    Dim Thread1, Thread2, Thread3, Thread4, Thread5, Thread6 As System.Threading.Thread




    Private Sub Cpu_ProgressBar()

        'CPU Progress bar
        cpu = New PerformanceCounter("Processor", "% Processor Time", "_Total")

        PerCounter = New System.Diagnostics.PerformanceCounter
        PerCounter.CategoryName = "Processor"
        PerCounter.CounterName = "% Processor Time"
        PerCounter.InstanceName = "_Total"

    End Sub




    Private Sub SystemUpTime()

        'System Up-Time
        Dim strResult As String = String.Empty
        strResult &= (Environment.TickCount \ 86400000).ToString + " days, "
        strResult &= (Environment.TickCount / 3600000 Mod 24).ToString("n0") + " hours, "
        strResult &= (Environment.TickCount / 120000 Mod 60).ToString("n0") + " minutes, "

        Lbl_UpTime.Text = strResult

    End Sub


    Private Sub SystemProcesses()

        'System Processes
        Dim num As Integer

        For Each p As Process In Process.GetProcesses
            num = num + 1
        Next

        Lbl_SysProcesses.Text = num

    End Sub


    Private Sub RunningApplication()

        'Running Applications
        Dim app As Integer


        For Each proc As Process In Process.GetProcesses
            If proc.MainWindowTitle <> "" Then
                app = app + 1
            End If
        Next

        Lbl_Applications.Text = app

    End Sub


    Private Sub LiveStatus()


        'LIVE STATUS System Spects
        Dim _nameSpace$ = "root\CIMV2"

        Dim wql = "SELECT * FROM WIN32_Processor"
        Dim _strBuilder As New StringBuilder
        Using _moSearcher As New ManagementObjectSearcher(_nameSpace, wql)

            For Each _mobject As ManagementObject In _moSearcher.Get
                Lbl_CpuName.Text = $"{_mobject("Name")}"
                Lbl_BaseSpeed.Text = $"{_mobject("MaxClockSpeed")}"
                Lbl_Socket.Text = $"{_mobject("SocketDesignation")}"
                Lbl_cores.Text = $"{_mobject("NumberOfCores")}"
                Lbl_EnabledCores.Text = $"{_mobject("NumberOfEnabledCore")}"
                Lbl_LogicalProcessors.Text = $"{_mobject("NumberOfLogicalProcessors")}"
                Lbl_Threads.Text = $"{_mobject("ThreadCount")}"
                Lbl_Virtualization.Text = $"{_mobject("VirtualizationFirmwareEnabled")}"
                Lbl_L2Cache.Text = $"{_mobject("L2CacheSize")}"
                Lbl_L3Cache.Text = $"{_mobject("L3CacheSize")}"
                Lbl_Arhitecture.Text = $"{_mobject("Architecture")}"
                Lbl_Manufacturer.Text = $"{_mobject("Manufacturer")}"
            Next

        End Using

    End Sub


    Private Sub CpuName()
        Dim _nameSpace$ = "root\CIMV2"

        Dim wql = "SELECT * FROM WIN32_Processor"
        Dim _strBuilder As New StringBuilder
        Using _moSearcher As New ManagementObjectSearcher(_nameSpace, wql)

            For Each _mobject As ManagementObject In _moSearcher.Get
                Lbl_CpuName.Text = $"{_mobject("Name")}"
            Next
        End Using


    End Sub





    Private Sub LiveStatus_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        System.Windows.Forms.Control.CheckForIllegalCrossThreadCalls = False

        ' Dim Thread_1 As New Threading.Thread(Sub() Cpu_ProgressBar())
        ' Dim Thread_2 As New Threading.Thread(Sub() SystemUpTime())
        ' Dim Thread_3 As New Threading.Thread(Sub() SystemProcesses())
        ' Dim Thread_4 As New Threading.Thread(Sub() RunningApplication())
        ' Dim Thread_5 As New Threading.Thread(Sub() LiveStatus())



        Thread1 = New System.Threading.Thread(AddressOf Cpu_ProgressBar)
        Thread2 = New System.Threading.Thread(AddressOf SystemUpTime)
        Thread3 = New System.Threading.Thread(AddressOf SystemProcesses)
        Thread4 = New System.Threading.Thread(AddressOf RunningApplication)
        Thread5 = New System.Threading.Thread(AddressOf LiveStatus)
        Thread6 = New System.Threading.Thread(AddressOf CpuName)


        Thread1.Start()
        Thread2.Start()
        Thread3.Start()
        Thread4.Start()
        Thread5.Start()
        Thread6.Start()



    End Sub







    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        Dim Test As Integer
        Dim Test2 As Integer

        Test = 100 - cpu.NextValue.ToString
        Test2 = 100 - Test

        Lbl_Processor2.Text = "Processor  " & Test2 & "%"
        Pb_Processor2.Value = Test2
        Pb_Processor3.Value = Test2
        Lbl_Processor3.Text = Test2 & "%"

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class