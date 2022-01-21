<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UpdateFlight
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
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.DGVFlightUpdate = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.btnSearchByID = New System.Windows.Forms.Button()
        Me.dtpArrival = New System.Windows.Forms.DateTimePicker()
        Me.dtpDeparture = New System.Windows.Forms.DateTimePicker()
        Me.txtNoSeat = New System.Windows.Forms.TextBox()
        Me.txtDestination = New System.Windows.Forms.TextBox()
        Me.txtSource = New System.Windows.Forms.TextBox()
        Me.txtFClass = New System.Windows.Forms.TextBox()
        Me.txtFlightID = New System.Windows.Forms.TextBox()
        Me.txtFlightName = New System.Windows.Forms.TextBox()
        Me.txtCharges = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnDelet = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnSaveUpdate = New System.Windows.Forms.Button()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DGVFlightUpdate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.DGVFlightUpdate)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 262)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(786, 156)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        '
        'DGVFlightUpdate
        '
        Me.DGVFlightUpdate.AllowUserToAddRows = False
        Me.DGVFlightUpdate.AllowUserToDeleteRows = False
        Me.DGVFlightUpdate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVFlightUpdate.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGVFlightUpdate.Location = New System.Drawing.Point(3, 16)
        Me.DGVFlightUpdate.MultiSelect = False
        Me.DGVFlightUpdate.Name = "DGVFlightUpdate"
        Me.DGVFlightUpdate.ReadOnly = True
        Me.DGVFlightUpdate.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGVFlightUpdate.Size = New System.Drawing.Size(780, 137)
        Me.DGVFlightUpdate.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Panel2)
        Me.GroupBox1.Controls.Add(Me.dtpArrival)
        Me.GroupBox1.Controls.Add(Me.dtpDeparture)
        Me.GroupBox1.Controls.Add(Me.txtNoSeat)
        Me.GroupBox1.Controls.Add(Me.txtDestination)
        Me.GroupBox1.Controls.Add(Me.txtSource)
        Me.GroupBox1.Controls.Add(Me.txtFClass)
        Me.GroupBox1.Controls.Add(Me.txtFlightID)
        Me.GroupBox1.Controls.Add(Me.txtFlightName)
        Me.GroupBox1.Controls.Add(Me.txtCharges)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Panel1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(786, 268)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Monotype Corsiva", 36.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Yellow
        Me.Label8.Location = New System.Drawing.Point(163, 12)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(461, 57)
        Me.Label8.TabIndex = 66
        Me.Label8.Text = "Edit Flight Information"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.OrangeRed
        Me.Panel2.Controls.Add(Me.txtSearch)
        Me.Panel2.Controls.Add(Me.btnSearchByID)
        Me.Panel2.Location = New System.Drawing.Point(593, 92)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(183, 43)
        Me.Panel2.TabIndex = 65
        '
        'txtSearch
        '
        Me.txtSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.Location = New System.Drawing.Point(11, 6)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(85, 30)
        Me.txtSearch.TabIndex = 9
        Me.txtSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnSearchByID
        '
        Me.btnSearchByID.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearchByID.ForeColor = System.Drawing.Color.Maroon
        Me.btnSearchByID.Location = New System.Drawing.Point(96, 6)
        Me.btnSearchByID.Name = "btnSearchByID"
        Me.btnSearchByID.Size = New System.Drawing.Size(75, 30)
        Me.btnSearchByID.TabIndex = 10
        Me.btnSearchByID.Text = "Search"
        Me.btnSearchByID.UseVisualStyleBackColor = True
        '
        'dtpArrival
        '
        Me.dtpArrival.Location = New System.Drawing.Point(388, 181)
        Me.dtpArrival.Name = "dtpArrival"
        Me.dtpArrival.Size = New System.Drawing.Size(133, 20)
        Me.dtpArrival.TabIndex = 5
        '
        'dtpDeparture
        '
        Me.dtpDeparture.Location = New System.Drawing.Point(134, 174)
        Me.dtpDeparture.Name = "dtpDeparture"
        Me.dtpDeparture.Size = New System.Drawing.Size(126, 20)
        Me.dtpDeparture.TabIndex = 4
        '
        'txtNoSeat
        '
        Me.txtNoSeat.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNoSeat.Location = New System.Drawing.Point(713, 154)
        Me.txtNoSeat.Name = "txtNoSeat"
        Me.txtNoSeat.Size = New System.Drawing.Size(63, 23)
        Me.txtNoSeat.TabIndex = 8
        Me.txtNoSeat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtDestination
        '
        Me.txtDestination.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDestination.Location = New System.Drawing.Point(388, 138)
        Me.txtDestination.Name = "txtDestination"
        Me.txtDestination.Size = New System.Drawing.Size(133, 20)
        Me.txtDestination.TabIndex = 3
        '
        'txtSource
        '
        Me.txtSource.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSource.Location = New System.Drawing.Point(134, 135)
        Me.txtSource.Name = "txtSource"
        Me.txtSource.Size = New System.Drawing.Size(126, 20)
        Me.txtSource.TabIndex = 2
        '
        'txtFClass
        '
        Me.txtFClass.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFClass.Location = New System.Drawing.Point(134, 215)
        Me.txtFClass.Name = "txtFClass"
        Me.txtFClass.Size = New System.Drawing.Size(126, 20)
        Me.txtFClass.TabIndex = 6
        Me.txtFClass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtFlightID
        '
        Me.txtFlightID.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFlightID.Location = New System.Drawing.Point(134, 98)
        Me.txtFlightID.Name = "txtFlightID"
        Me.txtFlightID.ReadOnly = True
        Me.txtFlightID.Size = New System.Drawing.Size(70, 20)
        Me.txtFlightID.TabIndex = 0
        Me.txtFlightID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtFlightName
        '
        Me.txtFlightName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFlightName.Location = New System.Drawing.Point(388, 98)
        Me.txtFlightName.Name = "txtFlightName"
        Me.txtFlightName.Size = New System.Drawing.Size(133, 20)
        Me.txtFlightName.TabIndex = 1
        '
        'txtCharges
        '
        Me.txtCharges.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCharges.Location = New System.Drawing.Point(388, 220)
        Me.txtCharges.Name = "txtCharges"
        Me.txtCharges.Size = New System.Drawing.Size(133, 20)
        Me.txtCharges.TabIndex = 7
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Yellow
        Me.Label9.Location = New System.Drawing.Point(290, 183)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(95, 17)
        Me.Label9.TabIndex = 64
        Me.Label9.Text = "Arrival Time"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Yellow
        Me.Label1.Location = New System.Drawing.Point(295, 139)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 17)
        Me.Label1.TabIndex = 63
        Me.Label1.Text = "Destination"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Yellow
        Me.Label7.Location = New System.Drawing.Point(546, 157)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(164, 17)
        Me.Label7.TabIndex = 61
        Me.Label7.Text = "No of Seats Available"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Yellow
        Me.Label6.Location = New System.Drawing.Point(272, 222)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(113, 17)
        Me.Label6.TabIndex = 58
        Me.Label6.Text = "Flight Charges"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Yellow
        Me.Label5.Location = New System.Drawing.Point(39, 216)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(92, 17)
        Me.Label5.TabIndex = 56
        Me.Label5.Text = "Flight Class"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Yellow
        Me.Label4.Location = New System.Drawing.Point(10, 176)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(121, 17)
        Me.Label4.TabIndex = 55
        Me.Label4.Text = "Departure Time"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Yellow
        Me.Label3.Location = New System.Drawing.Point(72, 136)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 17)
        Me.Label3.TabIndex = 52
        Me.Label3.Text = "Source"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Yellow
        Me.Label2.Location = New System.Drawing.Point(291, 100)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(94, 17)
        Me.Label2.TabIndex = 51
        Me.Label2.Text = "Flight Name"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Yellow
        Me.Label10.Location = New System.Drawing.Point(63, 100)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(68, 17)
        Me.Label10.TabIndex = 49
        Me.Label10.Text = "Flight ID"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.OrangeRed
        Me.Panel1.Controls.Add(Me.btnDelet)
        Me.Panel1.Controls.Add(Me.btnDelete)
        Me.Panel1.Controls.Add(Me.btnSaveUpdate)
        Me.Panel1.Location = New System.Drawing.Point(527, 201)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(249, 39)
        Me.Panel1.TabIndex = 46
        '
        'btnDelet
        '
        Me.btnDelet.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelet.ForeColor = System.Drawing.Color.Maroon
        Me.btnDelet.Location = New System.Drawing.Point(185, 3)
        Me.btnDelet.Name = "btnDelet"
        Me.btnDelet.Size = New System.Drawing.Size(60, 31)
        Me.btnDelet.TabIndex = 13
        Me.btnDelet.Text = "Exit"
        Me.btnDelet.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.ForeColor = System.Drawing.Color.Maroon
        Me.btnDelete.Location = New System.Drawing.Point(108, 4)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(69, 30)
        Me.btnDelete.TabIndex = 12
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnSaveUpdate
        '
        Me.btnSaveUpdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSaveUpdate.ForeColor = System.Drawing.Color.Maroon
        Me.btnSaveUpdate.Location = New System.Drawing.Point(4, 4)
        Me.btnSaveUpdate.Name = "btnSaveUpdate"
        Me.btnSaveUpdate.Size = New System.Drawing.Size(96, 30)
        Me.btnSaveUpdate.TabIndex = 11
        Me.btnSaveUpdate.Text = "Update"
        Me.btnSaveUpdate.UseVisualStyleBackColor = True
        '
        'UpdateFlight
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Maroon
        Me.ClientSize = New System.Drawing.Size(810, 428)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "UpdateFlight"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "UpdateFlight"
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.DGVFlightUpdate, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnSaveUpdate As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents btnSearchByID As System.Windows.Forms.Button
    Friend WithEvents dtpArrival As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpDeparture As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtNoSeat As System.Windows.Forms.TextBox
    Friend WithEvents txtDestination As System.Windows.Forms.TextBox
    Friend WithEvents txtSource As System.Windows.Forms.TextBox
    Friend WithEvents txtFClass As System.Windows.Forms.TextBox
    Friend WithEvents txtFlightID As System.Windows.Forms.TextBox
    Friend WithEvents txtFlightName As System.Windows.Forms.TextBox
    Friend WithEvents txtCharges As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents DGVFlightUpdate As System.Windows.Forms.DataGridView
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents btnDelet As System.Windows.Forms.Button
End Class
