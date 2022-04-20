<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class QuickSupport
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Tb_Output = New System.Windows.Forms.TextBox()
        Me.TB_Input = New System.Windows.Forms.TextBox()
        Me.Btn_Call = New System.Windows.Forms.Button()
        Me.Btn_Video = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(93, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(97, 21)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Adam Intop"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.PC_Agent_Demo.My.Resources.Resources._10103_robot_face_icon1
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(75, 74)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(93, 51)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 15)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Online"
        '
        'Tb_Output
        '
        Me.Tb_Output.BackColor = System.Drawing.Color.Gainsboro
        Me.Tb_Output.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Tb_Output.Location = New System.Drawing.Point(12, 92)
        Me.Tb_Output.Multiline = True
        Me.Tb_Output.Name = "Tb_Output"
        Me.Tb_Output.Size = New System.Drawing.Size(345, 411)
        Me.Tb_Output.TabIndex = 3
        '
        'TB_Input
        '
        Me.TB_Input.BackColor = System.Drawing.Color.Gainsboro
        Me.TB_Input.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TB_Input.Location = New System.Drawing.Point(12, 519)
        Me.TB_Input.Name = "TB_Input"
        Me.TB_Input.Size = New System.Drawing.Size(345, 16)
        Me.TB_Input.TabIndex = 3
        Me.TB_Input.Text = "Send Message"
        '
        'Btn_Call
        '
        Me.Btn_Call.Location = New System.Drawing.Point(201, 43)
        Me.Btn_Call.Name = "Btn_Call"
        Me.Btn_Call.Size = New System.Drawing.Size(75, 23)
        Me.Btn_Call.TabIndex = 4
        Me.Btn_Call.Text = "Call"
        Me.Btn_Call.UseVisualStyleBackColor = True
        '
        'Btn_Video
        '
        Me.Btn_Video.Location = New System.Drawing.Point(282, 43)
        Me.Btn_Video.Name = "Btn_Video"
        Me.Btn_Video.Size = New System.Drawing.Size(75, 23)
        Me.Btn_Video.TabIndex = 4
        Me.Btn_Video.Text = "Video"
        Me.Btn_Video.UseVisualStyleBackColor = True
        '
        'QuickSupport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ClientSize = New System.Drawing.Size(369, 577)
        Me.Controls.Add(Me.Btn_Video)
        Me.Controls.Add(Me.Btn_Call)
        Me.Controls.Add(Me.TB_Input)
        Me.Controls.Add(Me.Tb_Output)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "QuickSupport"
        Me.Text = "QuickSupport"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Tb_Output As TextBox
    Friend WithEvents TB_Input As TextBox
    Friend WithEvents Btn_Call As Button
    Friend WithEvents Btn_Video As Button
End Class
