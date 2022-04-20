Public Class QuickSupport

    Dim anser As String

    Private Sub speak(data As String)
        Dim SAPI
        SAPI = CreateObject("SAPI.spvoice")
        SAPI.Speak(data)
    End Sub




    Private Sub QuickSupport_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TB_Input_TextChanged(sender As Object, e As EventArgs) Handles TB_Input.Enter



        TB_Input.Clear()



    End Sub

    Private Sub Tb_Output_TextChanged(sender As Object, e As EventArgs) Handles Tb_Output.TextChanged

        Tb_Output.Text = Text


    End Sub
End Class