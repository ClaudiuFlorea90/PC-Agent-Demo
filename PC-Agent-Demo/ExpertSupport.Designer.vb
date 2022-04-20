<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ExpertSupport
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ExpertSupport))
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Btn_History = New System.Windows.Forms.Button()
        Me.Btn_Phone = New System.Windows.Forms.Button()
        Me.Btn_Ticket = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel3
        '
        Me.Panel3.Location = New System.Drawing.Point(2, 131)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(376, 485)
        Me.Panel3.TabIndex = 15
        '
        'Btn_History
        '
        Me.Btn_History.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_History.Image = Global.PC_Agent_Demo.My.Resources.Resources.history_icon
        Me.Btn_History.Location = New System.Drawing.Point(275, 98)
        Me.Btn_History.Name = "Btn_History"
        Me.Btn_History.Size = New System.Drawing.Size(75, 27)
        Me.Btn_History.TabIndex = 12
        Me.Btn_History.Text = "History"
        Me.Btn_History.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Btn_History.UseVisualStyleBackColor = True
        '
        'Btn_Phone
        '
        Me.Btn_Phone.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Phone.Image = Global.PC_Agent_Demo.My.Resources.Resources.MetroUI_Other_Phone_icon
        Me.Btn_Phone.Location = New System.Drawing.Point(154, 98)
        Me.Btn_Phone.Name = "Btn_Phone"
        Me.Btn_Phone.Size = New System.Drawing.Size(75, 27)
        Me.Btn_Phone.TabIndex = 13
        Me.Btn_Phone.Text = "Phone"
        Me.Btn_Phone.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Btn_Phone.UseVisualStyleBackColor = True
        '
        'Btn_Ticket
        '
        Me.Btn_Ticket.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Ticket.Image = CType(resources.GetObject("Btn_Ticket.Image"), System.Drawing.Image)
        Me.Btn_Ticket.Location = New System.Drawing.Point(28, 98)
        Me.Btn_Ticket.Name = "Btn_Ticket"
        Me.Btn_Ticket.Size = New System.Drawing.Size(75, 27)
        Me.Btn_Ticket.TabIndex = 14
        Me.Btn_Ticket.Text = "Ticket"
        Me.Btn_Ticket.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Btn_Ticket.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label10.Location = New System.Drawing.Point(118, 22)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(142, 25)
        Me.Label10.TabIndex = 10
        Me.Label10.Text = "Expert Support"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.PC_Agent_Demo.My.Resources.Resources.support_icon
        Me.PictureBox2.Location = New System.Drawing.Point(12, 8)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(100, 77)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 11
        Me.PictureBox2.TabStop = False
        '
        'ExpertSupport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ClientSize = New System.Drawing.Size(385, 616)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Btn_History)
        Me.Controls.Add(Me.Btn_Phone)
        Me.Controls.Add(Me.Btn_Ticket)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.PictureBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ExpertSupport"
        Me.Text = "ExpertSupport"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel3 As Panel
    Friend WithEvents Btn_History As Button
    Friend WithEvents Btn_Phone As Button
    Friend WithEvents Btn_Ticket As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents PictureBox2 As PictureBox
End Class
