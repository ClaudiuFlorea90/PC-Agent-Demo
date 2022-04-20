Public Class Ticket_Creation
    Private Sub Btn_SentTicket_Click(sender As Object, e As EventArgs) Handles Btn_SentTicket.Click

        If Tb_Description.Text = "Description" Or
                Tb_Subject.Text = "Subject" Then
            MessageBox.Show("Please Enter a ticket subject And description",
    "Invalid Subject or Description.",
    MessageBoxButtons.OK,
    MessageBoxIcon.Error,
    MessageBoxDefaultButton.Button1)
        Else
            MessageBox.Show("Ticket was successfully send.",
    "Thank you",
    MessageBoxButtons.OK,
    MessageBoxIcon.Information,
    MessageBoxDefaultButton.Button1)
            Tb_Subject.Text = "Subject"
            Tb_Description.Text = "Description"
        End If



        ' MessageBox.Show("Your ticket was submited. Thank you")
    End Sub

    Private Sub Ticket_Creation_Load(sender As Object, e As EventArgs) Handles MyBase.Load




        Tb_Subject.Text = "Subject"
        Tb_Description.Text = "Descprtion"



        If Tb_Description.Text = "" OrElse
                Tb_Subject.Text = "" Then
            Tb_Description.Text = "Decription"
            Tb_Subject.Text = "Subject"
        End If

    End Sub

    Private Sub Btn_TakeScreenShoot_Click(sender As Object, e As EventArgs) Handles Btn_TakeScreenShoot.Click

        Me.Hide()
        Threading.Thread.Sleep(1000)
        Dim hgtwth As Size = New Size(My.Computer.Screen.Bounds.Width, My.Computer.Screen.Bounds.Height)
        Dim Img As New Bitmap(My.Computer.Screen.Bounds.Width, My.Computer.Screen.Bounds.Height)
        Dim grph As System.Drawing.Graphics = System.Drawing.Graphics.FromImage(Img)
        grph.CopyFromScreen(New Point(0, 0), New Point(0, 0), hgtwth)
        PictureBox1.Visible = True
        PictureBox1.Image = Img
        Me.Show()

    End Sub

    Private Sub Btn_AddFiles_Click(sender As Object, e As EventArgs) Handles Btn_AddFiles.Click

        Using dialog As New OpenFileDialog
            If dialog.ShowDialog() <> DialogResult.OK Then Return
            MessageBox.Show("File was was uploaded")
        End Using
    End Sub

    Private Sub Tb_Subject_TextChanged(sender As Object, e As EventArgs) Handles Tb_Subject.Click

        Tb_Subject.Clear()

        Tb_Description.Text = "Description"


    End Sub

    Private Sub Tb_Description_TextChanged(sender As Object, e As EventArgs) Handles Tb_Description.Click


        Tb_Description.Clear()

        Tb_Subject.Text = "Subject"

    End Sub
End Class