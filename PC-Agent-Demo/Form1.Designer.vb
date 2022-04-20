<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Btn_GetStarted = New System.Windows.Forms.Button()
        Me.Lbl_Company = New System.Windows.Forms.Label()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(64, 290)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(295, 23)
        Me.TextBox1.TabIndex = 0
        Me.TextBox1.Text = "Email"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(220, 250)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(139, 23)
        Me.TextBox2.TabIndex = 1
        Me.TextBox2.Text = "Last Name"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(64, 250)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(150, 23)
        Me.TextBox3.TabIndex = 2
        Me.TextBox3.Text = "First Name"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.PC_Agent_Demo.My.Resources.Resources._11094_man_raising_hand_light_skin_tone_icon
        Me.PictureBox1.Location = New System.Drawing.Point(134, 93)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(166, 131)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(134, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(168, 47)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Welcome"
        '
        'Btn_GetStarted
        '
        Me.Btn_GetStarted.BackColor = System.Drawing.Color.Firebrick
        Me.Btn_GetStarted.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Btn_GetStarted.Location = New System.Drawing.Point(150, 369)
        Me.Btn_GetStarted.Name = "Btn_GetStarted"
        Me.Btn_GetStarted.Size = New System.Drawing.Size(116, 35)
        Me.Btn_GetStarted.TabIndex = 5
        Me.Btn_GetStarted.Text = "Get Started"
        Me.Btn_GetStarted.UseVisualStyleBackColor = False
        '
        'Lbl_Company
        '
        Me.Lbl_Company.AutoSize = True
        Me.Lbl_Company.Location = New System.Drawing.Point(163, 639)
        Me.Lbl_Company.Name = "Lbl_Company"
        Me.Lbl_Company.Size = New System.Drawing.Size(94, 15)
        Me.Lbl_Company.TabIndex = 4
        Me.Lbl_Company.Text = "Company Name"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(64, 319)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(202, 19)
        Me.CheckBox1.TabIndex = 6
        Me.CheckBox1.Text = "I accept the terms and conditions"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ClientSize = New System.Drawing.Size(419, 663)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.Btn_GetStarted)
        Me.Controls.Add(Me.Lbl_Company)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tech Agent"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Btn_GetStarted As Button
    Friend WithEvents Lbl_Company As Label
    Friend WithEvents CheckBox1 As CheckBox
End Class
