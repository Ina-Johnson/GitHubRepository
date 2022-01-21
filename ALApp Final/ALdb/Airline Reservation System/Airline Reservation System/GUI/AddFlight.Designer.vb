<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddFlight
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
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btnAddNew = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
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
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.btnAddNew)
        Me.GroupBox1.Controls.Add(Me.btnSave)
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
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(786, 404)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Monotype Corsiva", 36.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Yellow
        Me.Label10.Location = New System.Drawing.Point(210, 14)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(367, 57)
        Me.Label10.TabIndex = 35
        Me.Label10.Text = "Flight Information"
        '
        'btnAddNew
        '
        Me.btnAddNew.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddNew.ForeColor = System.Drawing.Color.Maroon
        Me.btnAddNew.Location = New System.Drawing.Point(481, 334)
        Me.btnAddNew.Name = "btnAddNew"
        Me.btnAddNew.Size = New System.Drawing.Size(86, 44)
        Me.btnAddNew.TabIndex = 9
        Me.btnAddNew.Text = "Add New"
        Me.btnAddNew.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.Maroon
        Me.btnSave.Location = New System.Drawing.Point(582, 334)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(63, 44)
        Me.btnSave.TabIndex = 10
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'dtpArrival
        '
        Me.dtpArrival.Location = New System.Drawing.Point(481, 216)
        Me.dtpArrival.Name = "dtpArrival"
        Me.dtpArrival.Size = New System.Drawing.Size(164, 20)
        Me.dtpArrival.TabIndex = 7
        '
        'dtpDeparture
        '
        Me.dtpDeparture.Location = New System.Drawing.Point(132, 220)
        Me.dtpDeparture.Name = "dtpDeparture"
        Me.dtpDeparture.Size = New System.Drawing.Size(161, 20)
        Me.dtpDeparture.TabIndex = 2
        '
        'txtNoSeat
        '
        Me.txtNoSeat.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNoSeat.Location = New System.Drawing.Point(193, 334)
        Me.txtNoSeat.Name = "txtNoSeat"
        Me.txtNoSeat.Size = New System.Drawing.Size(63, 20)
        Me.txtNoSeat.TabIndex = 4
        Me.txtNoSeat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtDestination
        '
        Me.txtDestination.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDestination.Location = New System.Drawing.Point(481, 162)
        Me.txtDestination.Name = "txtDestination"
        Me.txtDestination.Size = New System.Drawing.Size(164, 20)
        Me.txtDestination.TabIndex = 6
        '
        'txtSource
        '
        Me.txtSource.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSource.Location = New System.Drawing.Point(132, 161)
        Me.txtSource.Name = "txtSource"
        Me.txtSource.Size = New System.Drawing.Size(161, 20)
        Me.txtSource.TabIndex = 1
        '
        'txtFClass
        '
        Me.txtFClass.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFClass.Location = New System.Drawing.Point(132, 276)
        Me.txtFClass.Name = "txtFClass"
        Me.txtFClass.Size = New System.Drawing.Size(161, 20)
        Me.txtFClass.TabIndex = 3
        '
        'txtFlightID
        '
        Me.txtFlightID.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFlightID.Location = New System.Drawing.Point(481, 103)
        Me.txtFlightID.Name = "txtFlightID"
        Me.txtFlightID.ReadOnly = True
        Me.txtFlightID.Size = New System.Drawing.Size(164, 20)
        Me.txtFlightID.TabIndex = 5
        Me.txtFlightID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtFlightName
        '
        Me.txtFlightName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFlightName.Location = New System.Drawing.Point(132, 103)
        Me.txtFlightName.Name = "txtFlightName"
        Me.txtFlightName.Size = New System.Drawing.Size(161, 20)
        Me.txtFlightName.TabIndex = 0
        '
        'txtCharges
        '
        Me.txtCharges.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCharges.Location = New System.Drawing.Point(481, 276)
        Me.txtCharges.Name = "txtCharges"
        Me.txtCharges.Size = New System.Drawing.Size(164, 20)
        Me.txtCharges.TabIndex = 8
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Yellow
        Me.Label9.Location = New System.Drawing.Point(382, 217)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(95, 17)
        Me.Label9.TabIndex = 9
        Me.Label9.Text = "Arrival Time"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Yellow
        Me.Label8.Location = New System.Drawing.Point(386, 163)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(90, 17)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "Destination"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Yellow
        Me.Label7.Location = New System.Drawing.Point(25, 335)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(164, 17)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "No of Seats Available"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Yellow
        Me.Label6.Location = New System.Drawing.Point(365, 278)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(113, 17)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Flight Charges"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Yellow
        Me.Label5.Location = New System.Drawing.Point(34, 279)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(92, 17)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Flight Class"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Yellow
        Me.Label4.Location = New System.Drawing.Point(5, 219)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(121, 17)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Departure Time"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Yellow
        Me.Label3.Location = New System.Drawing.Point(67, 162)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 17)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Source"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Yellow
        Me.Label2.Location = New System.Drawing.Point(34, 106)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(94, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Flight Name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Yellow
        Me.Label1.Location = New System.Drawing.Point(407, 104)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Flight ID"
        '
        'AddFlight
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Maroon
        Me.ClientSize = New System.Drawing.Size(810, 428)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "AddFlight"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtDestination As System.Windows.Forms.TextBox
    Friend WithEvents txtSource As System.Windows.Forms.TextBox
    Friend WithEvents txtFClass As System.Windows.Forms.TextBox
    Friend WithEvents txtFlightID As System.Windows.Forms.TextBox
    Friend WithEvents txtFlightName As System.Windows.Forms.TextBox
    Friend WithEvents txtCharges As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtNoSeat As System.Windows.Forms.TextBox
    Friend WithEvents dtpArrival As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpDeparture As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnAddNew As System.Windows.Forms.Button
    Friend WithEvents Label10 As System.Windows.Forms.Label
End Class
