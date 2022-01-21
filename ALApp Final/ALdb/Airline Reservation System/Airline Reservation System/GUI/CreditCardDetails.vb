Public Class CreditCardDetails
    Dim C As New ChequeDetails
    Dim SQL As New SQLcon

    Private Sub CreditCardDetails_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        cboCardType.Text = "Please Select"
        cboCardType.Items.Add("Master Card")
        cboCardType.Items.Add("Vissa Card")

    End Sub

    Private Function ISdataCompleted() As Boolean

        Dim Message As String = ""

        If txtCardNo.Text.Trim = "" Then
            Message = "Please enter card number"
            txtCardNo.Focus()
        ElseIf Not IsNumeric(txtCardNo.Text.Trim) Then
            Message = "Card number must be a figure"
            txtCardNo.Focus()
        ElseIf cboCardType.SelectedText = "Please Select" Then
            Message = "Please select your card type"
            cboCardType.Focus()
        ElseIf txtHolderName.Text.Trim = "" Then
            Message = "Card berrier name is required"
            txtHolderName.Focus()
        ElseIf IsNumeric(txtHolderName.Text.Trim) Then
            Message = "Name must start with a letter"
            txtHolderName.Focus()
        ElseIf dtpExpiryDate.Value = Now Then
            Message = "Please enter expiry date"
            dtpExpiryDate.Focus()
        ElseIf txtBankName.Text.Trim = "" Then
            Message = "Bank name is required"
            txtBankName.Focus()
        ElseIf IsNumeric(txtBankName.Text.Trim) Then
            Message = "Bank name must start with a letter"
            txtBankName.Focus()
        End If

        If Message <> "" Then
            MsgBox(Message)
            Return False
        Else
            Return True
        End If

    End Function

    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click

        If Not ISdataCompleted() Then
            Exit Sub
        End If

        If Not C.CheckForPaymentID Then
            Exit Sub
        End If


        Dim PaymentID As Integer = Nothing
        SQL.RunQuery("SELECT IDENT_CURRENT ('tblPayment' )")
        If SQL.RecordCount = 1 Then
            PaymentID = SQL.DSt.Rows(0).Item(0)
        End If

        SQL.AddParam("@PK", PaymentID)
        SQL.AddParam("@CNo", txtCardNo.Text)
        SQL.AddParam("@CT", cboCardType.Text)
        SQL.AddParam("@HN", txtHolderName.Text)
        SQL.AddParam("@EDate", dtpExpiryDate.Value)
        SQL.AddParam("@BName", txtBankName.Text)

        SQL.RunQuery("Insert into tblCreditCard ( PaymentID ,CardNo,CardType,HolderName,ExpireDate,BankName) " & _
                     "VALUES(@PK,@CNo,@CT,@HN,@EDate,@BName)")

        If SQL.RecordCount > 0 Then
            MsgBox("Successfully Saved")
        End If
        ResetAllFields()
        Me.Hide()
    End Sub

    Private Sub ResetAllFields()
        txtCardNo.Clear()
        cboCardType.Text = "Please Select"
        txtHolderName.Clear()
        dtpExpiryDate.Value = Date.Now
        txtBankName.Clear()
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
End Class