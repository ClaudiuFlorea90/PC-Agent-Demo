<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ticket_Creation
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
        Me.Btn_AddFiles = New System.Windows.Forms.Button()
        Me.Btn_TakeScreenShoot = New System.Windows.Forms.Button()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.Btn_SentTicket = New System.Windows.Forms.Button()
        Me.Tb_Description = New System.Windows.Forms.TextBox()
        Me.Tb_Subject = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Btn_AddFiles
        '
        Me.Btn_AddFiles.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_AddFiles.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Btn_AddFiles.Image = Global.PC_Agent_Demo.My.Resources.Resources.Very_Basic_Paper_Clip_icon
        Me.Btn_AddFiles.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_AddFiles.Location = New System.Drawing.Point(224, 12)
        Me.Btn_AddFiles.Name = "Btn_AddFiles"
        Me.Btn_AddFiles.Size = New System.Drawing.Size(150, 83)
        Me.Btn_AddFiles.TabIndex = 10
        Me.Btn_AddFiles.Text = "Add Files"
        Me.Btn_AddFiles.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Btn_AddFiles.UseVisualStyleBackColor = True
        '
        'Btn_TakeScreenShoot
        '
        Me.Btn_TakeScreenShoot.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_TakeScreenShoot.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Btn_TakeScreenShoot.Image = Global.PC_Agent_Demo.My.Resources.Resources.camera_icon__1_
        Me.Btn_TakeScreenShoot.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_TakeScreenShoot.Location = New System.Drawing.Point(21, 11)
        Me.Btn_TakeScreenShoot.Name = "Btn_TakeScreenShoot"
        Me.Btn_TakeScreenShoot.Size = New System.Drawing.Size(197, 84)
        Me.Btn_TakeScreenShoot.TabIndex = 11
        Me.Btn_TakeScreenShoot.Text = "Take Screenshoot"
        Me.Btn_TakeScreenShoot.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Btn_TakeScreenShoot.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CheckBox1.Location = New System.Drawing.Point(21, 283)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(267, 19)
        Me.CheckBox1.TabIndex = 15
        Me.CheckBox1.Text = "I accept remote connection from a technician"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Btn_SentTicket
        '
        Me.Btn_SentTicket.BackColor = System.Drawing.Color.Firebrick
        Me.Btn_SentTicket.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_SentTicket.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Btn_SentTicket.Location = New System.Drawing.Point(147, 371)
        Me.Btn_SentTicket.Name = "Btn_SentTicket"
        Me.Btn_SentTicket.Size = New System.Drawing.Size(94, 39)
        Me.Btn_SentTicket.TabIndex = 12
        Me.Btn_SentTicket.Text = "Send ticket"
        Me.Btn_SentTicket.UseVisualStyleBackColor = False
        '
        'Tb_Description
        '
        Me.Tb_Description.Location = New System.Drawing.Point(21, 146)
        Me.Tb_Description.Multiline = True
        Me.Tb_Description.Name = "Tb_Description"
        Me.Tb_Description.Size = New System.Drawing.Size(353, 122)
        Me.Tb_Description.TabIndex = 13
        Me.Tb_Description.Text = "Description"
        '
        'Tb_Subject
        '
        Me.Tb_Subject.Location = New System.Drawing.Point(21, 117)
        Me.Tb_Subject.Name = "Tb_Subject"
        Me.Tb_Subject.Size = New System.Drawing.Size(353, 23)
        Me.Tb_Subject.TabIndex = 14
        Me.Tb_Subject.Text = "Subject"
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(260, 165)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(104, 91)
        Me.PictureBox1.TabIndex = 16
        Me.PictureBox1.TabStop = False
        Me.PictureBox1.Visible = False
        '
        'Ticket_Creation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ClientSize = New System.Drawing.Size(376, 485)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Btn_AddFiles)
        Me.Controls.Add(Me.Btn_TakeScreenShoot)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.Btn_SentTicket)
        Me.Controls.Add(Me.Tb_Description)
        Me.Controls.Add(Me.Tb_Subject)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Ticket_Creation"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ticket_Creation"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Btn_AddFiles As Button
    Friend WithEvents Btn_TakeScreenShoot As Button
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents Btn_SentTicket As Button
    Friend WithEvents Tb_Description As TextBox
    Friend WithEvents Tb_Subject As TextBox
    Friend WithEvents PictureBox1 As PictureBox
End Class
