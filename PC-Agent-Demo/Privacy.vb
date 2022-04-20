Public Class Privacy

    Dim isCollapsed As Boolean = True
    Dim isCollapsed2 As Boolean = True
    Dim IsCollapsed3 As Boolean = True






    Private Sub Privacy_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        DropPanel1.Size = DropPanel1.MinimumSize
        DropPanel2.Size = DropPanel2.MinimumSize
        DropPanel3.Size = DropPanel3.MinimumSize



    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        If isCollapsed Then
            Btn_DropButton1.Image = My.Resources.Arrow_Down_2_icon1
            DropPanel1.Height += 10
            If DropPanel1.Size = DropPanel1.MaximumSize Then
                Timer1.Stop()
                isCollapsed = False
            End If
        Else
            Btn_DropButton1.Image = My.Resources.Arrow_Up_2_icon
            DropPanel1.Height -= 10
            If DropPanel1.Size = DropPanel1.MinimumSize Then
                Timer1.Stop()
                isCollapsed = True
            End If
        End If


    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick

        If isCollapsed2 Then
            Btn_DropButton2.Image = My.Resources.Arrow_Down_2_icon1
            DropPanel2.Height += 10
            If DropPanel2.Size = DropPanel2.MaximumSize Then
                Timer2.Stop()
                isCollapsed2 = False
            End If
        Else
            Btn_DropButton2.Image = My.Resources.Arrow_Up_2_icon
            DropPanel2.Height -= 10
            If DropPanel2.Size = DropPanel2.MinimumSize Then
                Timer2.Stop()
                isCollapsed2 = True
            End If
        End If

    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick

        If IsCollapsed3 Then
            Btn_DropButton3.Image = My.Resources.Arrow_Down_2_icon1
            DropPanel3.Height += 10
            If DropPanel3.Size = DropPanel3.MaximumSize Then
                Timer3.Stop()
                IsCollapsed3 = False
            End If
        Else
            Btn_DropButton3.Image = My.Resources.Arrow_Up_2_icon
            DropPanel3.Height -= 10
            If DropPanel3.Size = DropPanel3.MinimumSize Then
                Timer3.Stop()
                IsCollapsed3 = True
            End If
        End If


    End Sub

    Private Sub Btn_DropButton1_Click(sender As Object, e As EventArgs) Handles Btn_DropButton1.Click



        isCollapsed2 = False
        IsCollapsed3 = False



        Timer1.Start()
        Timer2.Start()
        Timer3.Start()




    End Sub

    Private Sub Btn_DropButton2_Click(sender As Object, e As EventArgs) Handles Btn_DropButton2.Click

        isCollapsed = False
        IsCollapsed3 = False

        Timer1.Start()
        Timer2.Start()
        Timer3.Start()


    End Sub

    Private Sub Btn_DropButton3_Click(sender As Object, e As EventArgs) Handles Btn_DropButton3.Click

        isCollapsed2 = False
        isCollapsed = False

        Timer1.Start()
        Timer2.Start()
        Timer3.Start()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

    End Sub
End Class