<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EnquiryWin
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.cboCustomerID = New System.Windows.Forms.ComboBox()
        Me.txtDateOfJourney = New System.Windows.Forms.TextBox()
        Me.txtSeatNo = New System.Windows.Forms.TextBox()
        Me.txtFlightID = New System.Windows.Forms.TextBox()
        Me.txtTicketNo = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.GroupBox1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Panel1)
        Me.GroupBox1.Controls.Add(Me.cboCustomerID)
        Me.GroupBox1.Controls.Add(Me.txtDateOfJourney)
        Me.GroupBox1.Controls.Add(Me.txtSeatNo)
        Me.GroupBox1.Controls.Add(Me.txtFlightID)
        Me.GroupBox1.Controls.Add(Me.txtTicketNo)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(786, 404)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Monotype Corsiva", 27.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Yellow
        Me.Label3.Location = New System.Drawing.Point(161, 13)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(465, 45)
        Me.Label3.TabIndex = 36
        Me.Label3.Text = "Enquire if Customer has booked"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.OrangeRed
        Me.Panel1.Controls.Add(Me.txtSearch)
        Me.Panel1.Controls.Add(Me.btnSearch)
        Me.Panel1.Location = New System.Drawing.Point(240, 102)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(260, 50)
        Me.Panel1.TabIndex = 7
        '
        'txtSearch
        '
        Me.txtSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.Location = New System.Drawing.Point(10, 14)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(91, 23)
        Me.txtSearch.TabIndex = 1
        Me.txtSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTip1.SetToolTip(Me.txtSearch, "Please Input ID and click the Search button")
        '
        'btnSearch
        '
        Me.btnSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.ForeColor = System.Drawing.Color.Maroon
        Me.btnSearch.Location = New System.Drawing.Point(113, 4)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(144, 42)
        Me.btnSearch.TabIndex = 2
        Me.btnSearch.Text = "Search by ID"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'cboCustomerID
        '
        Me.cboCustomerID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCustomerID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCustomerID.FormattingEnabled = True
        Me.cboCustomerID.IntegralHeight = False
        Me.cboCustomerID.ItemHeight = 15
        Me.cboCustomerID.Location = New System.Drawing.Point(374, 170)
        Me.cboCustomerID.Name = "cboCustomerID"
        Me.cboCustomerID.Size = New System.Drawing.Size(126, 23)
        Me.cboCustomerID.TabIndex = 0
        Me.ToolTip1.SetToolTip(Me.cboCustomerID, "Search by Select ID")
        '
        'txtDateOfJourney
        '
        Me.txtDateOfJourney.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDateOfJourney.Location = New System.Drawing.Point(374, 335)
        Me.txtDateOfJourney.Name = "txtDateOfJourney"
        Me.txtDateOfJourney.ReadOnly = True
        Me.txtDateOfJourney.Size = New System.Drawing.Size(126, 21)
        Me.txtDateOfJourney.TabIndex = 6
        '
        'txtSeatNo
        '
        Me.txtSeatNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSeatNo.Location = New System.Drawing.Point(374, 292)
        Me.txtSeatNo.Name = "txtSeatNo"
        Me.txtSeatNo.ReadOnly = True
        Me.txtSeatNo.Size = New System.Drawing.Size(126, 21)
        Me.txtSeatNo.TabIndex = 6
        Me.txtSeatNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtFlightID
        '
        Me.txtFlightID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFlightID.Location = New System.Drawing.Point(374, 253)
        Me.txtFlightID.Name = "txtFlightID"
        Me.txtFlightID.ReadOnly = True
        Me.txtFlightID.Size = New System.Drawing.Size(126, 21)
        Me.txtFlightID.TabIndex = 4
        Me.txtFlightID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtTicketNo
        '
        Me.txtTicketNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTicketNo.Location = New System.Drawing.Point(374, 211)
        Me.txtTicketNo.Name = "txtTicketNo"
        Me.txtTicketNo.ReadOnly = True
        Me.txtTicketNo.Size = New System.Drawing.Size(126, 21)
        Me.txtTicketNo.TabIndex = 3
        Me.txtTicketNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Yellow
        Me.Label7.Location = New System.Drawing.Point(303, 254)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(68, 17)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Flight ID"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Yellow
        Me.Label6.Location = New System.Drawing.Point(247, 336)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(124, 17)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Data of Journey"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Yellow
        Me.Label4.Location = New System.Drawing.Point(305, 293)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 17)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Seat No"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Yellow
        Me.Label2.Location = New System.Drawing.Point(294, 212)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Ticket No"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Yellow
        Me.Label1.Location = New System.Drawing.Point(275, 172)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Customer ID"
        '
        'EnquiryWin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Maroon
        Me.ClientSize = New System.Drawing.Size(810, 428)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "EnquiryWin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtSeatNo As System.Windows.Forms.TextBox
    Friend WithEvents txtFlightID As System.Windows.Forms.TextBox
    Friend WithEvents txtTicketNo As System.Windows.Forms.TextBox
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents cboCustomerID As System.Windows.Forms.ComboBox
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents txtDateOfJourney As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
