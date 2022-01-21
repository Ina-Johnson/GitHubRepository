Public Class ChequeDetails
    Dim SQL As New SQLcon
    Dim PKey As Integer
    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click

        If Not ISChequeCompleted() Then
            Exit Sub
        End If

        If Not CheckForPaymentID() Then
            Exit Sub
        End If

        Dim PaymentID As Integer = Nothing
        SQL.RunQuery("SELECT IDENT_CURRENT ('tblPayment' )")
        If SQL.RecordCount = 1 Then
            PaymentID = SQL.DSt.Rows(0).Item(0)
        End If

        SQL.AddParam("@PK", PaymentID)
        SQL.AddParam("@CNo", txtChequeNo.Text)
        SQL.AddParam("@CDate", dtpChequeDate.Value)
        SQL.AddParam("@BName", txtBank.Text)

        SQL.RunQuery("Insert into tblCheque (PaymentID ,ChequeNo,ChequeDate,BankName) VALUES(@PK,@CNo,@CDate,@BName)")

        If SQL.RecordCount > 0 Then
            MsgBox("Successfully Saved")
        End If

        txtBank.Clear()
        txtChequeNo.Clear()
        dtpChequeDate.Value = Date.Now
    End Sub

    Public Function CheckForPaymentID() As Boolean
        Dim P As New AddPayment
        Dim PayMessage As String = ""

        SQL.RunQuery("Select count(PaymentID) as PaymentID from tblCheque ")

        If SQL.DSt.Rows(0).Item("PaymentID") = 1 Then
            PayMessage = ("Customer with this" & " " & P.cboCustomerID.Text & " " & "number" & Environment.NewLine & _
                "has already been made payment")
        End If

        If PayMessage <> "" Then
            MsgBox(PayMessage)
            Return False
        Else
            Return True
        End If

    End Function

    Private Function ISChequeCompleted() As Boolean

        Dim Message As String = ""

        If txtChequeNo.Text.Trim = "" Then
            Message = "Please enter cheque number"
            txtChequeNo.Focus()
        ElseIf Not IsNumeric(txtChequeNo.Text.Trim) Then
            Message = "Cheque number must be a figure"
            txtChequeNo.Focus()
        ElseIf dtpChequeDate.Value = Date.Today Then
            Message = "Please enter  date"
            dtpChequeDate.Focus()
        ElseIf txtBank.Text.Trim = "" Then
            Message = "Bank name is required"
            txtBank.Focus()
        ElseIf IsNumeric(txtBank.Text.Trim) Then
            Message = "Bank name must start with a letter"
            txtBank.Focus()
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

End Class