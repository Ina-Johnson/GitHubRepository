Public Class AddPayment
    Dim SQL As New SQLcon
    Dim UW As New UserWindow
    Private Sub AddPayment_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cboCustomerID.SelectedText = "Please Select"
        GetCustomerID()
    End Sub

    Private Sub GetCustomerID()

        SQL.RunQuery("Select CustomerID from tblReservation")
        If SQL.RecordCount > 0 Then
            For Each R As DataRow In SQL.DSt.Rows
                cboCustomerID.Items.Add(R(0))
            Next
        End If

    End Sub

    Private Sub GetFlightID(ByVal Value1 As String)

        SQL.AddParam("@FID", value1)
        SQL.RunQuery("Select FlightID,TicketNo from tblReservation where CustomerID=@FID")
        If SQL.RecordCount > 0 Then
            txtFlightID.Text = SQL.DSt.Rows(0).Item("FlightID")
            txtTicketNo.Text = SQL.DSt.Rows(0).Item("TicketNo")
        End If

    End Sub

    Private Function CheckForCustomerID() As Boolean
        Dim CustMessage As String = ""

        SQL.AddParam("@ID", cboCustomerID.Text)
        SQL.RunQuery("Select count(CustomerID) as CustomerID from tblPayment where CustomerID=@ID")
        If SQL.DSt.Rows(0).Item("CustomerID") = 1 Then
            CustMessage = ("Customer with this" & " " & cboCustomerID.Text & " " & "number" & Environment.NewLine & _
                "has already been made payment")
        End If

        If CustMessage <> "" Then
            MsgBox(CustMessage)
            Return False
        Else
            Return True
        End If
       
    End Function

    'Private Sub LoadUserForm(ByVal WinLoad As Form)
    '    Dim UW As New UserWindow
    '    UW.UserMainPanel.Controls.Clear()
    '    WinLoad.TopLevel = False
    '    UW.UserMainPanel.Controls.Add(WinLoad)
    '    WinLoad.Show()
    'End Sub

    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click

        Dim RadioButton As String = Nothing

        If Not IsValidateFilled() Then
            Exit Sub
        End If

        If Not CheckForCustomerID() Then
            Exit Sub
        End If

        If RadioButton2.Checked = True Then
            Dim C As New ChequeDetails
            Me.Hide()
            'C.Show()
            UW.LoadUserForm(ChequeDetails)
        End If

        If RadioButton3.Checked = True Then
            Dim CR As New CreditCardDetails
            Me.Hide()
            'CR.Show()
            UW.LoadUserForm(CreditCardDetails)
        End If

        If RadioButton1.Checked = True Then
            RadioButton = "Cash"
        End If

        If RadioButton2.Checked = True Then
            RadioButton = "Cheque"
        End If

        If RadioButton3.Checked = True Then
            RadioButton = " Credit Card"
        End If

        SQL.AddParam("@CID", cboCustomerID.Text)
        SQL.AddParam("@FID", txtFlightID.Text)
        SQL.AddParam("@TNo", txtTicketNo.Text)
        SQL.AddParam("@Amount", txtAmount.Text)
        SQL.AddParam("@Rad", RadioButton)

        SQL.RunQuery("Insert into tblPayment (CustomerID, FlightID,TicketNo, Amount, ModeOfPayment) " & _
                     "Values(@CID, @FID,@TNo, @Amount, @Rad)")

        If SQL.RecordCount > 0 Then
            MsgBox("successfully saved")
        End If

        ResetAllFields()
        Me.Hide()

    End Sub

    Private Sub ResetAllFields()

        cboCustomerID.Text = "Please Select"
        txtFlightID.Clear()
        txtAmount.Clear()
        txtTicketNo.Clear()
        rdoCash.Checked = True
    End Sub

    Private Function IsValidateFilled() As Boolean
        Dim Message As String = ""
        If cboCustomerID.Text = "Please Select" Then
            Message = ("Please select customer " & Environment.NewLine & "Identification number")
            cboCustomerID.Focus()
        ElseIf txtTicketNo.Text.Trim = "" Then
            Message = ("Please enter your ticket number")
            txtTicketNo.Focus()
        ElseIf Not IsNumeric(txtTicketNo.Text.Trim) Then
            Message = ("Ticket number must be an integer")
            txtTicketNo.Focus()
        ElseIf txtAmount.Text.Trim = "" Then
            Message = ("Please enter payment cost")
            txtAmount.Focus()
        ElseIf Not IsNumeric(txtAmount.Text.Trim) Then
            Message = ("Amount cost must be in figure")
            txtAmount.Focus()
        End If

        If Message <> "" Then
            MsgBox(Message)
            Return False
        Else
            Return True
        End If
    End Function

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub cboCustomerID_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboCustomerID.SelectedIndexChanged
        GetFlightID(cboCustomerID.Text)
    End Sub
End Class