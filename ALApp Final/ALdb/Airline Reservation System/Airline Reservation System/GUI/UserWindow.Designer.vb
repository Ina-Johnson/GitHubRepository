<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserWindow
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.LogOutToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogOutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.SidePanel = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblUserName = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnCancelRes = New System.Windows.Forms.Button()
        Me.btnBooked = New System.Windows.Forms.Button()
        Me.gbEdit = New System.Windows.Forms.GroupBox()
        Me.btnMPayment = New System.Windows.Forms.Button()
        Me.gbAddNew = New System.Windows.Forms.GroupBox()
        Me.btnCheck = New System.Windows.Forms.Button()
        Me.pbUserImage = New System.Windows.Forms.PictureBox()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.UserMainPanel = New System.Windows.Forms.Panel()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.SidePanel.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.gbEdit.SuspendLayout()
        Me.gbAddNew.SuspendLayout()
        CType(Me.pbUserImage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Maroon
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LogOutToolStripMenuItem1, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(947, 25)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'LogOutToolStripMenuItem1
        '
        Me.LogOutToolStripMenuItem1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LogOutToolStripMenuItem1.ForeColor = System.Drawing.Color.Red
        Me.LogOutToolStripMenuItem1.Name = "LogOutToolStripMenuItem1"
        Me.LogOutToolStripMenuItem1.Size = New System.Drawing.Size(66, 21)
        Me.LogOutToolStripMenuItem1.Text = "LogOut"
        '
        'LogOutToolStripMenuItem
        '
        Me.LogOutToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LogOutToolStripMenuItem.Name = "LogOutToolStripMenuItem"
        Me.LogOutToolStripMenuItem.Size = New System.Drawing.Size(60, 20)
        Me.LogOutToolStripMenuItem.Text = "LogOut"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 25)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.SidePanel)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.UserMainPanel)
        Me.SplitContainer1.Size = New System.Drawing.Size(947, 431)
        Me.SplitContainer1.SplitterDistance = 131
        Me.SplitContainer1.TabIndex = 7
        '
        'SidePanel
        '
        Me.SidePanel.BackColor = System.Drawing.Color.DarkGray
        Me.SidePanel.Controls.Add(Me.Panel1)
        Me.SidePanel.Controls.Add(Me.GroupBox1)
        Me.SidePanel.Controls.Add(Me.gbEdit)
        Me.SidePanel.Controls.Add(Me.gbAddNew)
        Me.SidePanel.Controls.Add(Me.pbUserImage)
        Me.SidePanel.Controls.Add(Me.ShapeContainer1)
        Me.SidePanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SidePanel.Location = New System.Drawing.Point(0, 0)
        Me.SidePanel.Name = "SidePanel"
        Me.SidePanel.Size = New System.Drawing.Size(131, 431)
        Me.SidePanel.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.lblUserName)
        Me.Panel1.Location = New System.Drawing.Point(3, 105)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(125, 25)
        Me.Panel1.TabIndex = 7
        '
        'lblUserName
        '
        Me.lblUserName.AutoSize = True
        Me.lblUserName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUserName.ForeColor = System.Drawing.Color.Maroon
        Me.lblUserName.Location = New System.Drawing.Point(24, 2)
        Me.lblUserName.Name = "lblUserName"
        Me.lblUserName.Size = New System.Drawing.Size(77, 20)
        Me.lblUserName.TabIndex = 3
        Me.lblUserName.Text = "Johnson"
        Me.lblUserName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnCancelRes)
        Me.GroupBox1.Controls.Add(Me.btnBooked)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Maroon
        Me.GroupBox1.Location = New System.Drawing.Point(7, 220)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(116, 118)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Reservation"
        '
        'btnCancelRes
        '
        Me.btnCancelRes.Location = New System.Drawing.Point(10, 66)
        Me.btnCancelRes.Name = "btnCancelRes"
        Me.btnCancelRes.Size = New System.Drawing.Size(97, 41)
        Me.btnCancelRes.TabIndex = 1
        Me.btnCancelRes.Text = "Cancel"
        Me.btnCancelRes.UseVisualStyleBackColor = True
        '
        'btnBooked
        '
        Me.btnBooked.Location = New System.Drawing.Point(10, 19)
        Me.btnBooked.Name = "btnBooked"
        Me.btnBooked.Size = New System.Drawing.Size(97, 41)
        Me.btnBooked.TabIndex = 0
        Me.btnBooked.Text = "Booked"
        Me.btnBooked.UseVisualStyleBackColor = True
        '
        'gbEdit
        '
        Me.gbEdit.Controls.Add(Me.btnMPayment)
        Me.gbEdit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbEdit.ForeColor = System.Drawing.Color.Maroon
        Me.gbEdit.Location = New System.Drawing.Point(7, 347)
        Me.gbEdit.Name = "gbEdit"
        Me.gbEdit.Size = New System.Drawing.Size(116, 74)
        Me.gbEdit.TabIndex = 5
        Me.gbEdit.TabStop = False
        Me.gbEdit.Text = "Payment"
        '
        'btnMPayment
        '
        Me.btnMPayment.Location = New System.Drawing.Point(10, 19)
        Me.btnMPayment.Name = "btnMPayment"
        Me.btnMPayment.Size = New System.Drawing.Size(97, 41)
        Me.btnMPayment.TabIndex = 1
        Me.btnMPayment.Text = "Make Payment"
        Me.btnMPayment.UseVisualStyleBackColor = True
        '
        'gbAddNew
        '
        Me.gbAddNew.Controls.Add(Me.btnCheck)
        Me.gbAddNew.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbAddNew.ForeColor = System.Drawing.Color.Maroon
        Me.gbAddNew.Location = New System.Drawing.Point(7, 137)
        Me.gbAddNew.Name = "gbAddNew"
        Me.gbAddNew.Size = New System.Drawing.Size(116, 72)
        Me.gbAddNew.TabIndex = 4
        Me.gbAddNew.TabStop = False
        Me.gbAddNew.Text = "Enquire"
        '
        'btnCheck
        '
        Me.btnCheck.Location = New System.Drawing.Point(10, 20)
        Me.btnCheck.Name = "btnCheck"
        Me.btnCheck.Size = New System.Drawing.Size(97, 41)
        Me.btnCheck.TabIndex = 0
        Me.btnCheck.Text = "Check"
        Me.btnCheck.UseVisualStyleBackColor = True
        '
        'pbUserImage
        '
        Me.pbUserImage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pbUserImage.Image = Global.Airline_Reservation_System.My.Resources.Resources.images__38_
        Me.pbUserImage.Location = New System.Drawing.Point(3, 3)
        Me.pbUserImage.Name = "pbUserImage"
        Me.pbUserImage.Size = New System.Drawing.Size(125, 97)
        Me.pbUserImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbUserImage.TabIndex = 1
        Me.pbUserImage.TabStop = False
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(131, 431)
        Me.ShapeContainer1.TabIndex = 3
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape1
        '
        Me.LineShape1.BorderWidth = 2
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 3
        Me.LineShape1.X2 = 127
        Me.LineShape1.Y1 = 133
        Me.LineShape1.Y2 = 133
        '
        'UserMainPanel
        '
        Me.UserMainPanel.BackColor = System.Drawing.Color.Maroon
        Me.UserMainPanel.BackgroundImage = Global.Airline_Reservation_System.My.Resources.Resources.indairline
        Me.UserMainPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.UserMainPanel.Location = New System.Drawing.Point(3, 3)
        Me.UserMainPanel.Name = "UserMainPanel"
        Me.UserMainPanel.Size = New System.Drawing.Size(810, 428)
        Me.UserMainPanel.TabIndex = 0
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HelpToolStripMenuItem.ForeColor = System.Drawing.Color.Red
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(49, 21)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'UserWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(947, 456)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "UserWindow"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Airline Reservation System"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.SidePanel.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.gbEdit.ResumeLayout(False)
        Me.gbAddNew.ResumeLayout(False)
        CType(Me.pbUserImage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents LogOutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents SidePanel As System.Windows.Forms.Panel
    Friend WithEvents gbEdit As System.Windows.Forms.GroupBox
    Friend WithEvents btnMPayment As System.Windows.Forms.Button
    Friend WithEvents gbAddNew As System.Windows.Forms.GroupBox
    Friend WithEvents btnCheck As System.Windows.Forms.Button
    Friend WithEvents pbUserImage As System.Windows.Forms.PictureBox
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents UserMainPanel As System.Windows.Forms.Panel
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnCancelRes As System.Windows.Forms.Button
    Friend WithEvents btnBooked As System.Windows.Forms.Button
    Friend WithEvents LogOutToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lblUserName As System.Windows.Forms.Label
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
