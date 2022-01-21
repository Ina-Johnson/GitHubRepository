<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainWindow
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainWindow))
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.LogOutToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogOutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.SidePanel = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnEditAirline = New System.Windows.Forms.Button()
        Me.gbEdit = New System.Windows.Forms.GroupBox()
        Me.btnEditUser = New System.Windows.Forms.Button()
        Me.btnEditFlight = New System.Windows.Forms.Button()
        Me.btnEditCustomer = New System.Windows.Forms.Button()
        Me.gbAddNew = New System.Windows.Forms.GroupBox()
        Me.btnUser = New System.Windows.Forms.Button()
        Me.btnFlight = New System.Windows.Forms.Button()
        Me.btnCustomer = New System.Windows.Forms.Button()
        Me.lblUserName = New System.Windows.Forms.Label()
        Me.pbImage = New System.Windows.Forms.PictureBox()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.MainPanel = New System.Windows.Forms.Panel()
        Me.MenuStrip.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.SidePanel.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.gbEdit.SuspendLayout()
        Me.gbAddNew.SuspendLayout()
        CType(Me.pbImage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip
        '
        Me.MenuStrip.BackColor = System.Drawing.Color.Maroon
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LogOutToolStripMenuItem1, Me.HelpToolStripMenuItem})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(947, 25)
        Me.MenuStrip.TabIndex = 5
        Me.MenuStrip.Text = "MenuStrip"
        '
        'LogOutToolStripMenuItem1
        '
        Me.LogOutToolStripMenuItem1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LogOutToolStripMenuItem1.ForeColor = System.Drawing.Color.Red
        Me.LogOutToolStripMenuItem1.Name = "LogOutToolStripMenuItem1"
        Me.LogOutToolStripMenuItem1.Size = New System.Drawing.Size(66, 21)
        Me.LogOutToolStripMenuItem1.Text = "LogOut"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HelpToolStripMenuItem.ForeColor = System.Drawing.Color.Maroon
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(49, 21)
        Me.HelpToolStripMenuItem.Text = "Help"
        Me.HelpToolStripMenuItem.Visible = False
        '
        'LogOutToolStripMenuItem
        '
        Me.LogOutToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
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
        Me.SplitContainer1.Panel2.Controls.Add(Me.MainPanel)
        Me.SplitContainer1.Size = New System.Drawing.Size(947, 431)
        Me.SplitContainer1.SplitterDistance = 131
        Me.SplitContainer1.TabIndex = 6
        '
        'SidePanel
        '
        Me.SidePanel.BackColor = System.Drawing.Color.DarkGray
        Me.SidePanel.Controls.Add(Me.GroupBox1)
        Me.SidePanel.Controls.Add(Me.gbEdit)
        Me.SidePanel.Controls.Add(Me.gbAddNew)
        Me.SidePanel.Controls.Add(Me.lblUserName)
        Me.SidePanel.Controls.Add(Me.pbImage)
        Me.SidePanel.Controls.Add(Me.ShapeContainer1)
        Me.SidePanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SidePanel.Location = New System.Drawing.Point(0, 0)
        Me.SidePanel.Name = "SidePanel"
        Me.SidePanel.Size = New System.Drawing.Size(131, 431)
        Me.SidePanel.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnEditAirline)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Maroon
        Me.GroupBox1.Location = New System.Drawing.Point(7, 370)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(116, 49)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Show Report"
        '
        'btnEditAirline
        '
        Me.btnEditAirline.Location = New System.Drawing.Point(10, 19)
        Me.btnEditAirline.Name = "btnEditAirline"
        Me.btnEditAirline.Size = New System.Drawing.Size(97, 23)
        Me.btnEditAirline.TabIndex = 1
        Me.btnEditAirline.Text = "Airline Info"
        Me.btnEditAirline.UseVisualStyleBackColor = True
        '
        'gbEdit
        '
        Me.gbEdit.Controls.Add(Me.btnEditUser)
        Me.gbEdit.Controls.Add(Me.btnEditFlight)
        Me.gbEdit.Controls.Add(Me.btnEditCustomer)
        Me.gbEdit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbEdit.ForeColor = System.Drawing.Color.Maroon
        Me.gbEdit.Location = New System.Drawing.Point(7, 258)
        Me.gbEdit.Name = "gbEdit"
        Me.gbEdit.Size = New System.Drawing.Size(116, 107)
        Me.gbEdit.TabIndex = 5
        Me.gbEdit.TabStop = False
        Me.gbEdit.Text = "Edit"
        '
        'btnEditUser
        '
        Me.btnEditUser.Location = New System.Drawing.Point(10, 17)
        Me.btnEditUser.Name = "btnEditUser"
        Me.btnEditUser.Size = New System.Drawing.Size(97, 23)
        Me.btnEditUser.TabIndex = 1
        Me.btnEditUser.Text = "User"
        Me.btnEditUser.UseVisualStyleBackColor = True
        '
        'btnEditFlight
        '
        Me.btnEditFlight.Location = New System.Drawing.Point(10, 75)
        Me.btnEditFlight.Name = "btnEditFlight"
        Me.btnEditFlight.Size = New System.Drawing.Size(97, 23)
        Me.btnEditFlight.TabIndex = 1
        Me.btnEditFlight.Text = "Flight"
        Me.btnEditFlight.UseVisualStyleBackColor = True
        '
        'btnEditCustomer
        '
        Me.btnEditCustomer.Location = New System.Drawing.Point(10, 46)
        Me.btnEditCustomer.Name = "btnEditCustomer"
        Me.btnEditCustomer.Size = New System.Drawing.Size(97, 23)
        Me.btnEditCustomer.TabIndex = 0
        Me.btnEditCustomer.Text = "Customer"
        Me.btnEditCustomer.UseVisualStyleBackColor = True
        '
        'gbAddNew
        '
        Me.gbAddNew.Controls.Add(Me.btnUser)
        Me.gbAddNew.Controls.Add(Me.btnFlight)
        Me.gbAddNew.Controls.Add(Me.btnCustomer)
        Me.gbAddNew.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbAddNew.ForeColor = System.Drawing.Color.Maroon
        Me.gbAddNew.Location = New System.Drawing.Point(7, 142)
        Me.gbAddNew.Name = "gbAddNew"
        Me.gbAddNew.Size = New System.Drawing.Size(116, 107)
        Me.gbAddNew.TabIndex = 4
        Me.gbAddNew.TabStop = False
        Me.gbAddNew.Text = "Add New"
        '
        'btnUser
        '
        Me.btnUser.Location = New System.Drawing.Point(10, 18)
        Me.btnUser.Name = "btnUser"
        Me.btnUser.Size = New System.Drawing.Size(97, 23)
        Me.btnUser.TabIndex = 1
        Me.btnUser.Text = "User"
        Me.btnUser.UseVisualStyleBackColor = True
        '
        'btnFlight
        '
        Me.btnFlight.Location = New System.Drawing.Point(10, 76)
        Me.btnFlight.Name = "btnFlight"
        Me.btnFlight.Size = New System.Drawing.Size(97, 23)
        Me.btnFlight.TabIndex = 1
        Me.btnFlight.Text = "Flight"
        Me.btnFlight.UseVisualStyleBackColor = True
        '
        'btnCustomer
        '
        Me.btnCustomer.Location = New System.Drawing.Point(10, 47)
        Me.btnCustomer.Name = "btnCustomer"
        Me.btnCustomer.Size = New System.Drawing.Size(97, 23)
        Me.btnCustomer.TabIndex = 0
        Me.btnCustomer.Text = "Customer"
        Me.btnCustomer.UseVisualStyleBackColor = True
        '
        'lblUserName
        '
        Me.lblUserName.AutoSize = True
        Me.lblUserName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUserName.ForeColor = System.Drawing.Color.Maroon
        Me.lblUserName.Location = New System.Drawing.Point(36, 106)
        Me.lblUserName.Name = "lblUserName"
        Me.lblUserName.Size = New System.Drawing.Size(59, 20)
        Me.lblUserName.TabIndex = 2
        Me.lblUserName.Text = "Admin"
        '
        'pbImage
        '
        Me.pbImage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pbImage.Image = Global.Airline_Reservation_System.My.Resources.Resources.images__38_
        Me.pbImage.Location = New System.Drawing.Point(3, 3)
        Me.pbImage.Name = "pbImage"
        Me.pbImage.Size = New System.Drawing.Size(125, 97)
        Me.pbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbImage.TabIndex = 1
        Me.pbImage.TabStop = False
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
        'MainPanel
        '
        Me.MainPanel.BackColor = System.Drawing.Color.DarkGray
        Me.MainPanel.BackgroundImage = Global.Airline_Reservation_System.My.Resources.Resources.indairline
        Me.MainPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.MainPanel.Location = New System.Drawing.Point(3, 3)
        Me.MainPanel.Name = "MainPanel"
        Me.MainPanel.Size = New System.Drawing.Size(810, 428)
        Me.MainPanel.TabIndex = 0
        '
        'MainWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(947, 456)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.MenuStrip)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MainMenuStrip = Me.MenuStrip
        Me.MaximizeBox = False
        Me.Name = "MainWindow"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Airline Reservation System"
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.SidePanel.ResumeLayout(False)
        Me.SidePanel.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.gbEdit.ResumeLayout(False)
        Me.gbAddNew.ResumeLayout(False)
        CType(Me.pbImage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents LogOutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents SidePanel As System.Windows.Forms.Panel
    Friend WithEvents MainPanel As System.Windows.Forms.Panel
    Friend WithEvents btnCustomer As System.Windows.Forms.Button
    Friend WithEvents gbEdit As System.Windows.Forms.GroupBox
    Friend WithEvents btnEditUser As System.Windows.Forms.Button
    Friend WithEvents btnEditFlight As System.Windows.Forms.Button
    Friend WithEvents btnEditCustomer As System.Windows.Forms.Button
    Friend WithEvents gbAddNew As System.Windows.Forms.GroupBox
    Friend WithEvents btnUser As System.Windows.Forms.Button
    Friend WithEvents btnFlight As System.Windows.Forms.Button
    Friend WithEvents lblUserName As System.Windows.Forms.Label
    Friend WithEvents pbImage As System.Windows.Forms.PictureBox
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LogOutToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnEditAirline As System.Windows.Forms.Button

End Class
