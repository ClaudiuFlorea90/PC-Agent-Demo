Imports System.Management
Imports System.Text
Imports System
Imports System.IO
Imports System.Threading


Public Class HomePage
    Private PerCounter As System.Diagnostics.PerformanceCounter
    Dim cpu As PerformanceCounter

    Sub switchHomePanel(ByVal panel As Form)
        Panel_HomePage.Controls.Clear()
        panel.TopLevel = False
        Panel_HomePage.Controls.Add(panel)
        panel.Show()
    End Sub


    Private Sub FakeDiag()

        'Fake Diag
        Dim Diag As Integer = 0

        If Diag = 0 Then
            Pic_Diag.Image = My.Resources.sign_check_icon
            Lbl_Diag.Text = "Your computer is healthy"
        Else
            Pic_Diag.Image = My.Resources.no_icon
            Lbl_Diag.Text = "Your computer is NOT healthy..."
        End If



    End Sub


    Private Sub CpuProgressbar()

        'CPU Progress bar
        cpu = New PerformanceCounter("Processor", "% Processor Time", "_Total")

        PerCounter = New System.Diagnostics.PerformanceCounter
        PerCounter.CategoryName = "Processor"
        PerCounter.CounterName = "% Processor Time"
        PerCounter.InstanceName = "_Total"


    End Sub





    Private Sub HomePage_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        System.Windows.Forms.Control.CheckForIllegalCrossThreadCalls = False

        Dim Thread_1 As New Threading.Thread(Sub() FakeDiag())
        Dim Thread_2 As New Threading.Thread(Sub() CpuProgressbar())

        Thread_1.Start()
        Thread_2.Start()









        Lbl_Top1.Text = "Tech Services"

    End Sub



    Private Sub Btn_Back_Click(sender As Object, e As EventArgs) Handles Btn_Back.Click



        Panel_HomePage.Controls.Clear()



        Dim Form1 As New Form1



        Form1.Show()
        Me.Hide()




        'switchHomePanel(HomePanel)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Application.Exit()


    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        Dim Test As Integer
        Dim Test2 As Integer

        Test = 100 - cpu.NextValue.ToString
        Test2 = 100 - Test

        Lbl_Processor1.Text = "Processor  " & Test2 & "%"
        Pb_Processor1.Value = Test2
    End Sub

    Private Sub Btn_ExpertSupport_Click(sender As Object, e As EventArgs) Handles Btn_ExpertSupport.Click


        Lbl_Top1.Text = "Expert Support"

        switchHomePanel(ExpertSupport)


    End Sub

    Private Sub Panel1_LiveStatus_Paint(sender As Object, e As EventArgs) Handles Panel1_LiveStatus.Click


        Lbl_Top1.Text = "Live Status"

        switchHomePanel(LiveStatus)

    End Sub

    Private Sub Btn_Settings_Click(sender As Object, e As EventArgs) Handles Btn_Settings.Click

        Lbl_Top1.Text = "Settings"

        switchHomePanel(Settings)

    End Sub

    Private Sub Btn_QuickSupport_Click(sender As Object, e As EventArgs) Handles Btn_QuickSupport.Click


        Lbl_Top1.Text = "Quick Support"

        switchHomePanel(QuickSupport)


    End Sub

    Private Sub Btn_Privacy_Click(sender As Object, e As EventArgs) Handles Btn_Privacy.Click


        switchHomePanel(Privacy)

    End Sub
End Class