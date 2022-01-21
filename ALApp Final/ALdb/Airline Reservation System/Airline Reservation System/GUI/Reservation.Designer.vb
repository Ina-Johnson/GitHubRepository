<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Reservation
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
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.dgvFlightBook = New System.Windows.Forms.DataGridView()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboDestination = New System.Windows.Forms.ComboBox()
        Me.cboSource = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnBook = New System.Windows.Forms.Button()
        Me.txtTicketNO = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtGender = New System.Windows.Forms.TextBox()
        Me.txtDateOfBirth = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtSeatBook = New System.Windows.Forms.TextBox()
        Me.cboDays = New System.Windows.Forms.ComboBox()
        Me.cboMonths = New System.Windows.Forms.ComboBox()
        Me.cboYears = New System.Windows.Forms.ComboBox()
        Me.txtTotalNSeat = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtAvailSeatNo = New System.Windows.Forms.TextBox()
        Me.txtFlightID = New System.Windows.Forms.TextBox()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.txtLName = New System.Windows.Forms.TextBox()
        Me.txtFName = New System.Windows.Forms.TextBox()
        Me.txtPhoneNo = New System.Windows.Forms.MaskedTextBox()
        Me.cboCustomerID = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.dgvFlightBook, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GroupBox4)
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Location = New System.Drawing.Point(11, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(465, 406)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.dgvFlightBook)
        Me.GroupBox4.Location = New System.Drawing.Point(6, 59)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(448, 334)
        Me.GroupBox4.TabIndex = 5
        Me.GroupBox4.TabStop = False
        '
        'dgvFlightBook
        '
        Me.dgvFlightBook.AllowUserToAddRows = False
        Me.dgvFlightBook.AllowUserToDeleteRows = False
        Me.dgvFlightBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvFlightBook.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvFlightBook.Location = New System.Drawing.Point(3, 16)
        Me.dgvFlightBook.MultiSelect = False
        Me.dgvFlightBook.Name = "dgvFlightBook"
        Me.dgvFlightBook.ReadOnly = True
        Me.dgvFlightBook.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvFlightBook.Size = New System.Drawing.Size(442, 315)
        Me.dgvFlightBook.TabIndex = 0
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.cboDestination)
        Me.GroupBox3.Controls.Add(Me.cboSource)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Location = New System.Drawing.Point(6, 8)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(448, 51)
        Me.GroupBox3.TabIndex = 4
        Me.GroupBox3.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Yellow
        Me.Label1.Location = New System.Drawing.Point(6, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Source"
        '
        'cboDestination
        '
        Me.cboDestination.DropDownHeight = 100
        Me.cboDestination.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboDestination.DropDownWidth = 100
        Me.cboDestination.FormattingEnabled = True
        Me.cboDestination.IntegralHeight = False
        Me.cboDestination.ItemHeight = 13
        Me.cboDestination.Location = New System.Drawing.Point(303, 18)
        Me.cboDestination.Name = "cboDestination"
        Me.cboDestination.Size = New System.Drawing.Size(131, 21)
        Me.cboDestination.TabIndex = 1
        '
        'cboSource
        '
        Me.cboSource.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSource.FormattingEnabled = True
        Me.cboSource.IntegralHeight = False
        Me.cboSource.ItemHeight = 13
        Me.cboSource.Location = New System.Drawing.Point(71, 18)
        Me.cboSource.Name = "cboSource"
        Me.cboSource.Size = New System.Drawing.Size(130, 21)
        Me.cboSource.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Yellow
        Me.Label2.Location = New System.Drawing.Point(207, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Destination"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Panel1)
        Me.GroupBox2.Controls.Add(Me.txtTicketNO)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.txtGender)
        Me.GroupBox2.Controls.Add(Me.txtDateOfBirth)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.txtSeatBook)
        Me.GroupBox2.Controls.Add(Me.cboDays)
        Me.GroupBox2.Controls.Add(Me.cboMonths)
        Me.GroupBox2.Controls.Add(Me.cboYears)
        Me.GroupBox2.Controls.Add(Me.txtTotalNSeat)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.txtAvailSeatNo)
        Me.GroupBox2.Controls.Add(Me.txtFlightID)
        Me.GroupBox2.Controls.Add(Me.txtAddress)
        Me.GroupBox2.Controls.Add(Me.txtLName)
        Me.GroupBox2.Controls.Add(Me.txtFName)
        Me.GroupBox2.Controls.Add(Me.txtPhoneNo)
        Me.GroupBox2.Controls.Add(Me.cboCustomerID)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.ShapeContainer1)
        Me.GroupBox2.Location = New System.Drawing.Point(482, 4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(318, 409)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.OrangeRed
        Me.Panel1.Controls.Add(Me.btnCancel)
        Me.Panel1.Controls.Add(Me.btnBook)
        Me.Panel1.Location = New System.Drawing.Point(51, 348)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(245, 42)
        Me.Panel1.TabIndex = 18
        '
        'btnCancel
        '
        Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.Color.Maroon
        Me.btnCancel.Location = New System.Drawing.Point(125, 5)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(109, 32)
        Me.btnCancel.TabIndex = 21
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnBook
        '
        Me.btnBook.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBook.ForeColor = System.Drawing.Color.Maroon
        Me.btnBook.Location = New System.Drawing.Point(10, 5)
        Me.btnBook.Name = "btnBook"
        Me.btnBook.Size = New System.Drawing.Size(109, 32)
        Me.btnBook.TabIndex = 20
        Me.btnBook.Text = "Book"
        Me.btnBook.UseVisualStyleBackColor = True
        '
        'txtTicketNO
        '
        Me.txtTicketNO.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTicketNO.Location = New System.Drawing.Point(247, 13)
        Me.txtTicketNO.Name = "txtTicketNO"
        Me.txtTicketNO.Size = New System.Drawing.Size(57, 23)
        Me.txtTicketNO.TabIndex = 16
        Me.txtTicketNO.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Yellow
        Me.Label15.Location = New System.Drawing.Point(181, 18)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(63, 13)
        Me.Label15.TabIndex = 4
        Me.Label15.Text = "Ticket No"
        '
        'txtGender
        '
        Me.txtGender.Location = New System.Drawing.Point(109, 114)
        Me.txtGender.Name = "txtGender"
        Me.txtGender.ReadOnly = True
        Me.txtGender.Size = New System.Drawing.Size(195, 20)
        Me.txtGender.TabIndex = 5
        '
        'txtDateOfBirth
        '
        Me.txtDateOfBirth.Location = New System.Drawing.Point(109, 144)
        Me.txtDateOfBirth.Name = "txtDateOfBirth"
        Me.txtDateOfBirth.ReadOnly = True
        Me.txtDateOfBirth.Size = New System.Drawing.Size(194, 20)
        Me.txtDateOfBirth.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Yellow
        Me.Label4.Location = New System.Drawing.Point(8, 320)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(113, 13)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Seat to be Booked"
        '
        'txtSeatBook
        '
        Me.txtSeatBook.Location = New System.Drawing.Point(121, 316)
        Me.txtSeatBook.Name = "txtSeatBook"
        Me.txtSeatBook.ReadOnly = True
        Me.txtSeatBook.Size = New System.Drawing.Size(54, 20)
        Me.txtSeatBook.TabIndex = 15
        Me.txtSeatBook.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cboDays
        '
        Me.cboDays.DropDownHeight = 100
        Me.cboDays.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboDays.FormattingEnabled = True
        Me.cboDays.IntegralHeight = False
        Me.cboDays.Location = New System.Drawing.Point(102, 250)
        Me.cboDays.Name = "cboDays"
        Me.cboDays.Size = New System.Drawing.Size(61, 23)
        Me.cboDays.TabIndex = 12
        '
        'cboMonths
        '
        Me.cboMonths.DropDownHeight = 100
        Me.cboMonths.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboMonths.FormattingEnabled = True
        Me.cboMonths.IntegralHeight = False
        Me.cboMonths.Location = New System.Drawing.Point(168, 250)
        Me.cboMonths.Name = "cboMonths"
        Me.cboMonths.Size = New System.Drawing.Size(66, 23)
        Me.cboMonths.TabIndex = 13
        '
        'cboYears
        '
        Me.cboYears.DropDownHeight = 100
        Me.cboYears.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboYears.FormattingEnabled = True
        Me.cboYears.IntegralHeight = False
        Me.cboYears.Location = New System.Drawing.Point(239, 250)
        Me.cboYears.Name = "cboYears"
        Me.cboYears.Size = New System.Drawing.Size(61, 23)
        Me.cboYears.TabIndex = 14
        '
        'txtTotalNSeat
        '
        Me.txtTotalNSeat.Location = New System.Drawing.Point(226, 284)
        Me.txtTotalNSeat.Name = "txtTotalNSeat"
        Me.txtTotalNSeat.ReadOnly = True
        Me.txtTotalNSeat.Size = New System.Drawing.Size(52, 20)
        Me.txtTotalNSeat.TabIndex = 16
        Me.txtTotalNSeat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Yellow
        Me.Label14.Location = New System.Drawing.Point(128, 288)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(95, 13)
        Me.Label14.TabIndex = 11
        Me.Label14.Text = "Number of Seat"
        '
        'txtAvailSeatNo
        '
        Me.txtAvailSeatNo.Location = New System.Drawing.Point(247, 316)
        Me.txtAvailSeatNo.Name = "txtAvailSeatNo"
        Me.txtAvailSeatNo.ReadOnly = True
        Me.txtAvailSeatNo.Size = New System.Drawing.Size(54, 20)
        Me.txtAvailSeatNo.TabIndex = 17
        Me.txtAvailSeatNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtFlightID
        '
        Me.txtFlightID.Location = New System.Drawing.Point(67, 284)
        Me.txtFlightID.Name = "txtFlightID"
        Me.txtFlightID.ReadOnly = True
        Me.txtFlightID.Size = New System.Drawing.Size(54, 20)
        Me.txtFlightID.TabIndex = 15
        Me.txtFlightID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtAddress
        '
        Me.txtAddress.Location = New System.Drawing.Point(109, 206)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.ReadOnly = True
        Me.txtAddress.Size = New System.Drawing.Size(194, 20)
        Me.txtAddress.TabIndex = 11
        '
        'txtLName
        '
        Me.txtLName.Location = New System.Drawing.Point(108, 86)
        Me.txtLName.Name = "txtLName"
        Me.txtLName.ReadOnly = True
        Me.txtLName.Size = New System.Drawing.Size(195, 20)
        Me.txtLName.TabIndex = 5
        '
        'txtFName
        '
        Me.txtFName.Location = New System.Drawing.Point(109, 49)
        Me.txtFName.Name = "txtFName"
        Me.txtFName.ReadOnly = True
        Me.txtFName.Size = New System.Drawing.Size(194, 20)
        Me.txtFName.TabIndex = 4
        '
        'txtPhoneNo
        '
        Me.txtPhoneNo.Location = New System.Drawing.Point(108, 174)
        Me.txtPhoneNo.Name = "txtPhoneNo"
        Me.txtPhoneNo.ReadOnly = True
        Me.txtPhoneNo.Size = New System.Drawing.Size(194, 20)
        Me.txtPhoneNo.TabIndex = 10
        '
        'cboCustomerID
        '
        Me.cboCustomerID.FormattingEnabled = True
        Me.cboCustomerID.IntegralHeight = False
        Me.cboCustomerID.ItemHeight = 13
        Me.cboCustomerID.Location = New System.Drawing.Point(83, 14)
        Me.cboCustomerID.Name = "cboCustomerID"
        Me.cboCustomerID.Size = New System.Drawing.Size(92, 21)
        Me.cboCustomerID.TabIndex = 2
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Yellow
        Me.Label13.Location = New System.Drawing.Point(179, 319)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(65, 13)
        Me.Label13.TabIndex = 11
        Me.Label13.Text = "Avail Seat"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Yellow
        Me.Label12.Location = New System.Drawing.Point(4, 255)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(97, 13)
        Me.Label12.TabIndex = 10
        Me.Label12.Text = "Date of Journey"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Yellow
        Me.Label11.Location = New System.Drawing.Point(43, 209)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(52, 13)
        Me.Label11.TabIndex = 9
        Me.Label11.Text = "Address"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Yellow
        Me.Label10.Location = New System.Drawing.Point(34, 177)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(63, 13)
        Me.Label10.TabIndex = 8
        Me.Label10.Text = "Phone No"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Yellow
        Me.Label9.Location = New System.Drawing.Point(26, 147)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(79, 13)
        Me.Label9.TabIndex = 7
        Me.Label9.Text = "Date of Birth"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Yellow
        Me.Label8.Location = New System.Drawing.Point(56, 117)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(48, 13)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "Gender"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Yellow
        Me.Label7.Location = New System.Drawing.Point(38, 89)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(67, 13)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "Last Name"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Yellow
        Me.Label6.Location = New System.Drawing.Point(39, 53)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(67, 13)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "First Name"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Yellow
        Me.Label5.Location = New System.Drawing.Point(6, 18)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(76, 13)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Customer ID"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Yellow
        Me.Label3.Location = New System.Drawing.Point(11, 287)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Flight ID"
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(3, 16)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(312, 390)
        Me.ShapeContainer1.TabIndex = 17
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape1
        '
        Me.LineShape1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LineShape1.BorderColor = System.Drawing.Color.Silver
        Me.LineShape1.BorderWidth = 3
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = -3
        Me.LineShape1.X2 = 314
        Me.LineShape1.Y1 = 225
        Me.LineShape1.Y2 = 225
        '
        'Reservation
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
        Me.Name = "Reservation"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        CType(Me.dgvFlightBook, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cboDestination As System.Windows.Forms.ComboBox
    Friend WithEvents cboSource As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtAvailSeatNo As System.Windows.Forms.TextBox
    Friend WithEvents txtFlightID As System.Windows.Forms.TextBox
    Friend WithEvents txtAddress As System.Windows.Forms.TextBox
    Friend WithEvents txtLName As System.Windows.Forms.TextBox
    Friend WithEvents txtFName As System.Windows.Forms.TextBox
    Friend WithEvents txtPhoneNo As System.Windows.Forms.MaskedTextBox
    Friend WithEvents cboCustomerID As System.Windows.Forms.ComboBox
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents txtTotalNSeat As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents cboDays As System.Windows.Forms.ComboBox
    Friend WithEvents cboMonths As System.Windows.Forms.ComboBox
    Friend WithEvents cboYears As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtSeatBook As System.Windows.Forms.TextBox
    Friend WithEvents txtGender As System.Windows.Forms.TextBox
    Friend WithEvents txtDateOfBirth As System.Windows.Forms.TextBox
    Friend WithEvents txtTicketNO As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnBook As System.Windows.Forms.Button
    Friend WithEvents dgvFlightBook As System.Windows.Forms.DataGridView
End Class
