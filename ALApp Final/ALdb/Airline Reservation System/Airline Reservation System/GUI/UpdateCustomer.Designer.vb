<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UpdateCustomer
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.txtSearchID = New System.Windows.Forms.TextBox()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnDelet = New System.Windows.Forms.Button()
        Me.btnSaveUpdate = New System.Windows.Forms.Button()
        Me.txtDateOfBirth = New System.Windows.Forms.TextBox()
        Me.txtPhone = New System.Windows.Forms.MaskedTextBox()
        Me.btnStartWebcam = New System.Windows.Forms.Button()
        Me.btnLoad = New System.Windows.Forms.Button()
        Me.picUpdateImage = New System.Windows.Forms.PictureBox()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.txtGender = New System.Windows.Forms.TextBox()
        Me.txtLName = New System.Windows.Forms.TextBox()
        Me.txtFName = New System.Windows.Forms.TextBox()
        Me.txtCustomerID = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.DGVCustomerUpdate = New System.Windows.Forms.DataGridView()
        Me.GroupBox1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.picUpdateImage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DGVCustomerUpdate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Panel2)
        Me.GroupBox1.Controls.Add(Me.Panel1)
        Me.GroupBox1.Controls.Add(Me.txtDateOfBirth)
        Me.GroupBox1.Controls.Add(Me.txtPhone)
        Me.GroupBox1.Controls.Add(Me.btnStartWebcam)
        Me.GroupBox1.Controls.Add(Me.btnLoad)
        Me.GroupBox1.Controls.Add(Me.picUpdateImage)
        Me.GroupBox1.Controls.Add(Me.txtAddress)
        Me.GroupBox1.Controls.Add(Me.txtGender)
        Me.GroupBox1.Controls.Add(Me.txtLName)
        Me.GroupBox1.Controls.Add(Me.txtFName)
        Me.GroupBox1.Controls.Add(Me.txtCustomerID)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(786, 251)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Monotype Corsiva", 27.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Yellow
        Me.Label9.Location = New System.Drawing.Point(170, 12)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(446, 45)
        Me.Label9.TabIndex = 47
        Me.Label9.Text = "Update Customer Information"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.OrangeRed
        Me.Panel2.Controls.Add(Me.txtSearchID)
        Me.Panel2.Controls.Add(Me.btnSearch)
        Me.Panel2.Location = New System.Drawing.Point(595, 71)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(159, 39)
        Me.Panel2.TabIndex = 46
        '
        'txtSearchID
        '
        Me.txtSearchID.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearchID.Location = New System.Drawing.Point(6, 4)
        Me.txtSearchID.Name = "txtSearchID"
        Me.txtSearchID.Size = New System.Drawing.Size(70, 30)
        Me.txtSearchID.TabIndex = 7
        Me.txtSearchID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnSearch
        '
        Me.btnSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.ForeColor = System.Drawing.Color.Maroon
        Me.btnSearch.Location = New System.Drawing.Point(75, 4)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(77, 30)
        Me.btnSearch.TabIndex = 8
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.OrangeRed
        Me.Panel1.Controls.Add(Me.btnExit)
        Me.Panel1.Controls.Add(Me.btnDelet)
        Me.Panel1.Controls.Add(Me.btnSaveUpdate)
        Me.Panel1.Location = New System.Drawing.Point(265, 197)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(280, 40)
        Me.Panel1.TabIndex = 46
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.Color.Maroon
        Me.btnExit.Location = New System.Drawing.Point(215, 6)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(56, 31)
        Me.btnExit.TabIndex = 13
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnDelet
        '
        Me.btnDelet.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelet.ForeColor = System.Drawing.Color.Maroon
        Me.btnDelet.Location = New System.Drawing.Point(128, 5)
        Me.btnDelet.Name = "btnDelet"
        Me.btnDelet.Size = New System.Drawing.Size(81, 31)
        Me.btnDelet.TabIndex = 12
        Me.btnDelet.Text = "Delete"
        Me.btnDelet.UseVisualStyleBackColor = True
        '
        'btnSaveUpdate
        '
        Me.btnSaveUpdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSaveUpdate.ForeColor = System.Drawing.Color.Maroon
        Me.btnSaveUpdate.Location = New System.Drawing.Point(7, 5)
        Me.btnSaveUpdate.Name = "btnSaveUpdate"
        Me.btnSaveUpdate.Size = New System.Drawing.Size(115, 30)
        Me.btnSaveUpdate.TabIndex = 11
        Me.btnSaveUpdate.Text = "Save Update"
        Me.btnSaveUpdate.UseVisualStyleBackColor = True
        '
        'txtDateOfBirth
        '
        Me.txtDateOfBirth.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDateOfBirth.Location = New System.Drawing.Point(114, 213)
        Me.txtDateOfBirth.Name = "txtDateOfBirth"
        Me.txtDateOfBirth.Size = New System.Drawing.Size(145, 21)
        Me.txtDateOfBirth.TabIndex = 4
        '
        'txtPhone
        '
        Me.txtPhone.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPhone.Location = New System.Drawing.Point(360, 71)
        Me.txtPhone.Mask = "(999) 000-000"
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(185, 21)
        Me.txtPhone.TabIndex = 5
        '
        'btnStartWebcam
        '
        Me.btnStartWebcam.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStartWebcam.ForeColor = System.Drawing.Color.Maroon
        Me.btnStartWebcam.Location = New System.Drawing.Point(601, 204)
        Me.btnStartWebcam.Name = "btnStartWebcam"
        Me.btnStartWebcam.Size = New System.Drawing.Size(86, 30)
        Me.btnStartWebcam.TabIndex = 9
        Me.btnStartWebcam.Text = "Webcam"
        Me.btnStartWebcam.UseVisualStyleBackColor = True
        '
        'btnLoad
        '
        Me.btnLoad.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLoad.ForeColor = System.Drawing.Color.Maroon
        Me.btnLoad.Location = New System.Drawing.Point(693, 204)
        Me.btnLoad.Name = "btnLoad"
        Me.btnLoad.Size = New System.Drawing.Size(61, 30)
        Me.btnLoad.TabIndex = 10
        Me.btnLoad.Text = "Load "
        Me.btnLoad.UseVisualStyleBackColor = True
        '
        'picUpdateImage
        '
        Me.picUpdateImage.BackColor = System.Drawing.Color.Gray
        Me.picUpdateImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picUpdateImage.Location = New System.Drawing.Point(601, 122)
        Me.picUpdateImage.Name = "picUpdateImage"
        Me.picUpdateImage.Size = New System.Drawing.Size(153, 76)
        Me.picUpdateImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picUpdateImage.TabIndex = 44
        Me.picUpdateImage.TabStop = False
        '
        'txtAddress
        '
        Me.txtAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddress.Location = New System.Drawing.Point(360, 122)
        Me.txtAddress.Multiline = True
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(185, 53)
        Me.txtAddress.TabIndex = 6
        '
        'txtGender
        '
        Me.txtGender.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGender.Location = New System.Drawing.Point(114, 179)
        Me.txtGender.Name = "txtGender"
        Me.txtGender.Size = New System.Drawing.Size(145, 21)
        Me.txtGender.TabIndex = 3
        '
        'txtLName
        '
        Me.txtLName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLName.Location = New System.Drawing.Point(116, 142)
        Me.txtLName.Name = "txtLName"
        Me.txtLName.Size = New System.Drawing.Size(145, 21)
        Me.txtLName.TabIndex = 2
        '
        'txtFName
        '
        Me.txtFName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFName.Location = New System.Drawing.Point(116, 102)
        Me.txtFName.Name = "txtFName"
        Me.txtFName.Size = New System.Drawing.Size(145, 21)
        Me.txtFName.TabIndex = 1
        '
        'txtCustomerID
        '
        Me.txtCustomerID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCustomerID.Location = New System.Drawing.Point(114, 68)
        Me.txtCustomerID.Name = "txtCustomerID"
        Me.txtCustomerID.ReadOnly = True
        Me.txtCustomerID.Size = New System.Drawing.Size(74, 21)
        Me.txtCustomerID.TabIndex = 0
        Me.txtCustomerID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Yellow
        Me.Label8.Location = New System.Drawing.Point(551, 125)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(50, 17)
        Me.Label8.TabIndex = 43
        Me.Label8.Text = "Photo"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Yellow
        Me.Label7.Location = New System.Drawing.Point(290, 125)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(67, 17)
        Me.Label7.TabIndex = 28
        Me.Label7.Text = "Address"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Yellow
        Me.Label6.Location = New System.Drawing.Point(278, 73)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(79, 17)
        Me.Label6.TabIndex = 27
        Me.Label6.Text = "Phone No"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Yellow
        Me.Label5.Location = New System.Drawing.Point(11, 215)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(100, 17)
        Me.Label5.TabIndex = 26
        Me.Label5.Text = "Date of Birth"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Yellow
        Me.Label4.Location = New System.Drawing.Point(49, 181)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 17)
        Me.Label4.TabIndex = 25
        Me.Label4.Text = "Gender"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Yellow
        Me.Label3.Location = New System.Drawing.Point(28, 143)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(85, 17)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = "Last Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Yellow
        Me.Label2.Location = New System.Drawing.Point(27, 104)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 17)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "First Name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Yellow
        Me.Label1.Location = New System.Drawing.Point(15, 71)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 17)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "Customer ID"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.DGVCustomerUpdate)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 256)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(786, 160)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        '
        'DGVCustomerUpdate
        '
        Me.DGVCustomerUpdate.AllowUserToAddRows = False
        Me.DGVCustomerUpdate.AllowUserToDeleteRows = False
        Me.DGVCustomerUpdate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVCustomerUpdate.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGVCustomerUpdate.Location = New System.Drawing.Point(3, 16)
        Me.DGVCustomerUpdate.MultiSelect = False
        Me.DGVCustomerUpdate.Name = "DGVCustomerUpdate"
        Me.DGVCustomerUpdate.ReadOnly = True
        Me.DGVCustomerUpdate.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGVCustomerUpdate.Size = New System.Drawing.Size(780, 141)
        Me.DGVCustomerUpdate.TabIndex = 0
        '
        'UpdateCustomer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Maroon
        Me.ClientSize = New System.Drawing.Size(810, 428)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "UpdateCustomer"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "UpdateCustomer"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        CType(Me.picUpdateImage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.DGVCustomerUpdate, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtDateOfBirth As System.Windows.Forms.TextBox
    Friend WithEvents txtPhone As System.Windows.Forms.MaskedTextBox
    Friend WithEvents btnStartWebcam As System.Windows.Forms.Button
    Friend WithEvents btnLoad As System.Windows.Forms.Button
    Friend WithEvents picUpdateImage As System.Windows.Forms.PictureBox
    Friend WithEvents txtAddress As System.Windows.Forms.TextBox
    Friend WithEvents txtLName As System.Windows.Forms.TextBox
    Friend WithEvents txtFName As System.Windows.Forms.TextBox
    Friend WithEvents txtCustomerID As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnSaveUpdate As System.Windows.Forms.Button
    Friend WithEvents txtGender As System.Windows.Forms.TextBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents txtSearchID As System.Windows.Forms.TextBox
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents btnDelet As System.Windows.Forms.Button
    Friend WithEvents DGVCustomerUpdate As System.Windows.Forms.DataGridView
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents btnExit As System.Windows.Forms.Button
End Class
