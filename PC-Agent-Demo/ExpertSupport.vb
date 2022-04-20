Imports System.Management
Imports System.Text
Imports System
Imports System.IO

Public Class ExpertSupport
    Private Sub ExpertSupport_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        switchPanel(Ticket_Creation)

    End Sub


    Sub switchPanel(ByVal panel As Form)
        Panel3.Controls.Clear()
        panel.TopLevel = False
        Panel3.Controls.Add(panel)
        panel.Show()
    End Sub




    Private Sub Btn_Ticket_Click(sender As Object, e As EventArgs) Handles Btn_Ticket.Click

        switchPanel(Ticket_Creation)



    End Sub

    Private Sub Btn_Phone_Click(sender As Object, e As EventArgs) Handles Btn_Phone.Click

        switchPanel(Ticket_PhoneNumber)

    End Sub

    Private Sub Btn_History_Click(sender As Object, e As EventArgs) Handles Btn_History.Click

        switchPanel(Ticket_History)

    End Sub

    Private Sub Btn_Back2_Click(sender As Object, e As EventArgs)



    End Sub
End Class