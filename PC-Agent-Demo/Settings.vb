Public Class Settings
    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RB_DarkTheme.CheckedChanged

        Me.BackColor = Color.LightSteelBlue

    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RB_LightTheme.CheckedChanged


        Me.BackColor = Color.WhiteSmoke


    End Sub
End Class