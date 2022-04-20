Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        Dim Company_Name As String = "Tech Services"
        Lbl_Company.Text = Company_Name


    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.Click

        TextBox3.Text = ""

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.Click

        TextBox2.Text = ""



    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.Click


        TextBox1.Text = ""

    End Sub

    Private Sub Btn_GetStarted_Click(sender As Object, e As EventArgs) Handles Btn_GetStarted.Click


        Dim HomePage As New HomePage



        HomePage.Show()
        Me.Hide()



    End Sub
End Class
