<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Settings
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
        Me.Label10 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.RB_LightTheme = New System.Windows.Forms.RadioButton()
        Me.RB_DarkTheme = New System.Windows.Forms.RadioButton()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label10.Location = New System.Drawing.Point(109, 33)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(81, 25)
        Me.Label10.TabIndex = 12
        Me.Label10.Text = "Settings"
        '
        'PictureBox2
        '
        Me.PictureBox2.ErrorImage = Global.PC_Agent_Demo.My.Resources.Resources.settings_icon
        Me.PictureBox2.Image = Global.PC_Agent_Demo.My.Resources.Resources.settings_icon
        Me.PictureBox2.Location = New System.Drawing.Point(3, 3)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(100, 70)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 13
        Me.PictureBox2.TabStop = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(146, 348)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(109, 33)
        Me.Button1.TabIndex = 14
        Me.Button1.Text = "Report an issue"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(40, 124)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(138, 17)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Notification Frequency"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(40, 169)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 17)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Theme"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(40, 220)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(96, 17)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Launch at login"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(40, 274)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 17)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "App version"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label5.Location = New System.Drawing.Point(146, 274)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(25, 17)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "0.1"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(250, 267)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(120, 33)
        Me.Button2.TabIndex = 14
        Me.Button2.Text = "Check for updates"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'RB_LightTheme
        '
        Me.RB_LightTheme.AllowDrop = True
        Me.RB_LightTheme.AutoSize = True
        Me.RB_LightTheme.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.RB_LightTheme.Location = New System.Drawing.Point(250, 167)
        Me.RB_LightTheme.Name = "RB_LightTheme"
        Me.RB_LightTheme.Size = New System.Drawing.Size(51, 19)
        Me.RB_LightTheme.TabIndex = 16
        Me.RB_LightTheme.TabStop = True
        Me.RB_LightTheme.Text = "Light"
        Me.RB_LightTheme.UseVisualStyleBackColor = True
        '
        'RB_DarkTheme
        '
        Me.RB_DarkTheme.AllowDrop = True
        Me.RB_DarkTheme.AutoSize = True
        Me.RB_DarkTheme.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.RB_DarkTheme.Location = New System.Drawing.Point(307, 167)
        Me.RB_DarkTheme.Name = "RB_DarkTheme"
        Me.RB_DarkTheme.Size = New System.Drawing.Size(48, 19)
        Me.RB_DarkTheme.TabIndex = 16
        Me.RB_DarkTheme.TabStop = True
        Me.RB_DarkTheme.Text = "Dark"
        Me.RB_DarkTheme.UseVisualStyleBackColor = True
        '
        'Settings
        '
        Me.AllowDrop = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ClientSize = New System.Drawing.Size(399, 621)
        Me.Controls.Add(Me.RB_DarkTheme)
        Me.Controls.Add(Me.RB_LightTheme)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.PictureBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Settings"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Settings"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label10 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents RB_LightTheme As RadioButton
    Friend WithEvents RB_DarkTheme As RadioButton
End Class
