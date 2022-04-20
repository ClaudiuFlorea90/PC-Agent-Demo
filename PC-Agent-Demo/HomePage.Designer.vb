<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HomePage
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
        Me.components = New System.ComponentModel.Container()
        Me.Lbl_Top1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Btn_Back = New System.Windows.Forms.Button()
        Me.Panel_HomePage = New System.Windows.Forms.Panel()
        Me.Panel1_Diag = New System.Windows.Forms.Panel()
        Me.Pic_Diag = New System.Windows.Forms.PictureBox()
        Me.Lbl_Diag = New System.Windows.Forms.Label()
        Me.Btn_Security = New System.Windows.Forms.Button()
        Me.Panel1_LiveStatus = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ProgressBar2 = New System.Windows.Forms.ProgressBar()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ProgressBar3 = New System.Windows.Forms.ProgressBar()
        Me.Pb_Processor1 = New System.Windows.Forms.ProgressBar()
        Me.Lbl_Processor1 = New System.Windows.Forms.Label()
        Me.Btn_Settings = New System.Windows.Forms.Button()
        Me.Btn_Network = New System.Windows.Forms.Button()
        Me.Btn_ExpertSupport = New System.Windows.Forms.Button()
        Me.Btn_Performance = New System.Windows.Forms.Button()
        Me.Btn_Privacy = New System.Windows.Forms.Button()
        Me.Btn_QuickSupport = New System.Windows.Forms.Button()
        Me.Btn_CleanUp = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel_HomePage.SuspendLayout()
        Me.Panel1_Diag.SuspendLayout()
        CType(Me.Pic_Diag, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1_LiveStatus.SuspendLayout()
        Me.SuspendLayout()
        '
        'Lbl_Top1
        '
        Me.Lbl_Top1.AutoSize = True
        Me.Lbl_Top1.Location = New System.Drawing.Point(161, 8)
        Me.Lbl_Top1.Name = "Lbl_Top1"
        Me.Lbl_Top1.Size = New System.Drawing.Size(94, 15)
        Me.Lbl_Top1.TabIndex = 21
        Me.Lbl_Top1.Text = "Company Name"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(378, 3)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(25, 25)
        Me.Button1.TabIndex = 20
        Me.Button1.Text = "X"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Btn_Back
        '
        Me.Btn_Back.Location = New System.Drawing.Point(12, 3)
        Me.Btn_Back.Name = "Btn_Back"
        Me.Btn_Back.Size = New System.Drawing.Size(25, 25)
        Me.Btn_Back.TabIndex = 19
        Me.Btn_Back.Text = "<"
        Me.Btn_Back.UseVisualStyleBackColor = True
        '
        'Panel_HomePage
        '
        Me.Panel_HomePage.Controls.Add(Me.Panel1_Diag)
        Me.Panel_HomePage.Controls.Add(Me.Btn_Security)
        Me.Panel_HomePage.Controls.Add(Me.Panel1_LiveStatus)
        Me.Panel_HomePage.Controls.Add(Me.Btn_Settings)
        Me.Panel_HomePage.Controls.Add(Me.Btn_Network)
        Me.Panel_HomePage.Controls.Add(Me.Btn_ExpertSupport)
        Me.Panel_HomePage.Controls.Add(Me.Btn_Performance)
        Me.Panel_HomePage.Controls.Add(Me.Btn_Privacy)
        Me.Panel_HomePage.Controls.Add(Me.Btn_QuickSupport)
        Me.Panel_HomePage.Controls.Add(Me.Btn_CleanUp)
        Me.Panel_HomePage.Location = New System.Drawing.Point(12, 29)
        Me.Panel_HomePage.Name = "Panel_HomePage"
        Me.Panel_HomePage.Size = New System.Drawing.Size(391, 621)
        Me.Panel_HomePage.TabIndex = 22
        '
        'Panel1_Diag
        '
        Me.Panel1_Diag.Controls.Add(Me.Pic_Diag)
        Me.Panel1_Diag.Controls.Add(Me.Lbl_Diag)
        Me.Panel1_Diag.Location = New System.Drawing.Point(5, 3)
        Me.Panel1_Diag.Name = "Panel1_Diag"
        Me.Panel1_Diag.Size = New System.Drawing.Size(376, 169)
        Me.Panel1_Diag.TabIndex = 43
        '
        'Pic_Diag
        '
        Me.Pic_Diag.Location = New System.Drawing.Point(78, 3)
        Me.Pic_Diag.Name = "Pic_Diag"
        Me.Pic_Diag.Size = New System.Drawing.Size(215, 130)
        Me.Pic_Diag.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Pic_Diag.TabIndex = 0
        Me.Pic_Diag.TabStop = False
        '
        'Lbl_Diag
        '
        Me.Lbl_Diag.AutoSize = True
        Me.Lbl_Diag.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Lbl_Diag.Location = New System.Drawing.Point(55, 136)
        Me.Lbl_Diag.Name = "Lbl_Diag"
        Me.Lbl_Diag.Size = New System.Drawing.Size(62, 30)
        Me.Lbl_Diag.TabIndex = 2
        Me.Lbl_Diag.Text = "DIAG"
        '
        'Btn_Security
        '
        Me.Btn_Security.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Security.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Btn_Security.Image = Global.PC_Agent_Demo.My.Resources.Resources.shield_icon
        Me.Btn_Security.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Btn_Security.Location = New System.Drawing.Point(262, 381)
        Me.Btn_Security.Name = "Btn_Security"
        Me.Btn_Security.Size = New System.Drawing.Size(117, 117)
        Me.Btn_Security.TabIndex = 40
        Me.Btn_Security.Text = "Security"
        Me.Btn_Security.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Btn_Security.UseVisualStyleBackColor = True
        '
        'Panel1_LiveStatus
        '
        Me.Panel1_LiveStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1_LiveStatus.Controls.Add(Me.Label3)
        Me.Panel1_LiveStatus.Controls.Add(Me.ProgressBar2)
        Me.Panel1_LiveStatus.Controls.Add(Me.Label2)
        Me.Panel1_LiveStatus.Controls.Add(Me.ProgressBar3)
        Me.Panel1_LiveStatus.Controls.Add(Me.Pb_Processor1)
        Me.Panel1_LiveStatus.Controls.Add(Me.Lbl_Processor1)
        Me.Panel1_LiveStatus.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Panel1_LiveStatus.Location = New System.Drawing.Point(5, 205)
        Me.Panel1_LiveStatus.Name = "Panel1_LiveStatus"
        Me.Panel1_LiveStatus.Size = New System.Drawing.Size(376, 48)
        Me.Panel1_LiveStatus.TabIndex = 44
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(256, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 15)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Memory"
        '
        'ProgressBar2
        '
        Me.ProgressBar2.Location = New System.Drawing.Point(132, 27)
        Me.ProgressBar2.Name = "ProgressBar2"
        Me.ProgressBar2.Size = New System.Drawing.Size(103, 10)
        Me.ProgressBar2.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(132, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 15)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Storage"
        '
        'ProgressBar3
        '
        Me.ProgressBar3.Location = New System.Drawing.Point(270, 27)
        Me.ProgressBar3.Name = "ProgressBar3"
        Me.ProgressBar3.Size = New System.Drawing.Size(103, 10)
        Me.ProgressBar3.TabIndex = 1
        '
        'Pb_Processor1
        '
        Me.Pb_Processor1.Location = New System.Drawing.Point(3, 27)
        Me.Pb_Processor1.Name = "Pb_Processor1"
        Me.Pb_Processor1.Size = New System.Drawing.Size(103, 10)
        Me.Pb_Processor1.TabIndex = 1
        '
        'Lbl_Processor1
        '
        Me.Lbl_Processor1.AutoSize = True
        Me.Lbl_Processor1.Location = New System.Drawing.Point(3, 9)
        Me.Lbl_Processor1.Name = "Lbl_Processor1"
        Me.Lbl_Processor1.Size = New System.Drawing.Size(58, 15)
        Me.Lbl_Processor1.TabIndex = 2
        Me.Lbl_Processor1.Text = "Processor"
        '
        'Btn_Settings
        '
        Me.Btn_Settings.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Settings.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Btn_Settings.Image = Global.PC_Agent_Demo.My.Resources.Resources.settings_icon
        Me.Btn_Settings.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Btn_Settings.Location = New System.Drawing.Point(262, 505)
        Me.Btn_Settings.Name = "Btn_Settings"
        Me.Btn_Settings.Size = New System.Drawing.Size(117, 117)
        Me.Btn_Settings.TabIndex = 36
        Me.Btn_Settings.Text = "Settings"
        Me.Btn_Settings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Btn_Settings.UseVisualStyleBackColor = True
        '
        'Btn_Network
        '
        Me.Btn_Network.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Network.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Btn_Network.Image = Global.PC_Agent_Demo.My.Resources.Resources.Internet_icon
        Me.Btn_Network.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Btn_Network.Location = New System.Drawing.Point(5, 504)
        Me.Btn_Network.Name = "Btn_Network"
        Me.Btn_Network.Size = New System.Drawing.Size(117, 117)
        Me.Btn_Network.TabIndex = 39
        Me.Btn_Network.Text = "Network"
        Me.Btn_Network.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Btn_Network.UseVisualStyleBackColor = True
        '
        'Btn_ExpertSupport
        '
        Me.Btn_ExpertSupport.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_ExpertSupport.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Btn_ExpertSupport.Image = Global.PC_Agent_Demo.My.Resources.Resources.support_icon
        Me.Btn_ExpertSupport.Location = New System.Drawing.Point(200, 270)
        Me.Btn_ExpertSupport.Name = "Btn_ExpertSupport"
        Me.Btn_ExpertSupport.Size = New System.Drawing.Size(181, 105)
        Me.Btn_ExpertSupport.TabIndex = 35
        Me.Btn_ExpertSupport.Text = "Expert Support"
        Me.Btn_ExpertSupport.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_ExpertSupport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Btn_ExpertSupport.UseVisualStyleBackColor = True
        '
        'Btn_Performance
        '
        Me.Btn_Performance.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Performance.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Btn_Performance.Image = Global.PC_Agent_Demo.My.Resources.Resources.speedometer_icon__1_
        Me.Btn_Performance.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Btn_Performance.Location = New System.Drawing.Point(5, 381)
        Me.Btn_Performance.Name = "Btn_Performance"
        Me.Btn_Performance.Size = New System.Drawing.Size(117, 117)
        Me.Btn_Performance.TabIndex = 42
        Me.Btn_Performance.Text = "Performance"
        Me.Btn_Performance.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Btn_Performance.UseVisualStyleBackColor = True
        '
        'Btn_Privacy
        '
        Me.Btn_Privacy.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Privacy.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Btn_Privacy.Image = Global.PC_Agent_Demo.My.Resources.Resources.lock_icon
        Me.Btn_Privacy.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Btn_Privacy.Location = New System.Drawing.Point(128, 382)
        Me.Btn_Privacy.Name = "Btn_Privacy"
        Me.Btn_Privacy.Size = New System.Drawing.Size(127, 117)
        Me.Btn_Privacy.TabIndex = 37
        Me.Btn_Privacy.Text = "Privacy"
        Me.Btn_Privacy.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Btn_Privacy.UseVisualStyleBackColor = True
        '
        'Btn_QuickSupport
        '
        Me.Btn_QuickSupport.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_QuickSupport.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Btn_QuickSupport.Image = Global.PC_Agent_Demo.My.Resources.Resources.Chat_icon
        Me.Btn_QuickSupport.Location = New System.Drawing.Point(5, 270)
        Me.Btn_QuickSupport.Name = "Btn_QuickSupport"
        Me.Btn_QuickSupport.Size = New System.Drawing.Size(189, 105)
        Me.Btn_QuickSupport.TabIndex = 38
        Me.Btn_QuickSupport.Text = "Quick Support"
        Me.Btn_QuickSupport.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_QuickSupport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Btn_QuickSupport.UseVisualStyleBackColor = True
        '
        'Btn_CleanUp
        '
        Me.Btn_CleanUp.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_CleanUp.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Btn_CleanUp.Image = Global.PC_Agent_Demo.My.Resources.Resources.Household_Broom_icon
        Me.Btn_CleanUp.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Btn_CleanUp.Location = New System.Drawing.Point(128, 504)
        Me.Btn_CleanUp.Name = "Btn_CleanUp"
        Me.Btn_CleanUp.Size = New System.Drawing.Size(127, 117)
        Me.Btn_CleanUp.TabIndex = 41
        Me.Btn_CleanUp.Text = "Clean Up"
        Me.Btn_CleanUp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Btn_CleanUp.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'HomePage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ClientSize = New System.Drawing.Size(419, 663)
        Me.Controls.Add(Me.Panel_HomePage)
        Me.Controls.Add(Me.Lbl_Top1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Btn_Back)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "HomePage"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "HomePage"
        Me.Panel_HomePage.ResumeLayout(False)
        Me.Panel1_Diag.ResumeLayout(False)
        Me.Panel1_Diag.PerformLayout()
        CType(Me.Pic_Diag, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1_LiveStatus.ResumeLayout(False)
        Me.Panel1_LiveStatus.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Lbl_Top1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Btn_Back As Button
    Friend WithEvents Panel_HomePage As Panel
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Panel1_Diag As Panel
    Friend WithEvents Pic_Diag As PictureBox
    Friend WithEvents Lbl_Diag As Label
    Friend WithEvents Btn_Security As Button
    Friend WithEvents Panel1_LiveStatus As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents ProgressBar2 As ProgressBar
    Friend WithEvents Label2 As Label
    Friend WithEvents ProgressBar3 As ProgressBar
    Friend WithEvents Pb_Processor1 As ProgressBar
    Friend WithEvents Lbl_Processor1 As Label
    Friend WithEvents Btn_Settings As Button
    Friend WithEvents Btn_Network As Button
    Friend WithEvents Btn_ExpertSupport As Button
    Friend WithEvents Btn_Performance As Button
    Friend WithEvents Btn_Privacy As Button
    Friend WithEvents Btn_QuickSupport As Button
    Friend WithEvents Btn_CleanUp As Button
End Class
