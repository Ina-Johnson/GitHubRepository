Public Class CancellTicket
    Dim SQL As New SQLcon
    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        If cboCustomerID.SelectedItem <> "" Then
            CancelReservation(cboCustomerID.SelectedItem)
        ElseIf txtSearch.Text <> "" Then
            CancelReservation(txtSearch.Text)
        Else
            MsgBox("Please search for customer")
        End If
    End Sub

    Private Sub CancelReservation(ByVal CboC As String)

        SQL.AddParam("@CustomerID", CboC)
        If MessageBox.Show("Are you sure you want to cancel reservation", "Airline Reservation System", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) = Windows.Forms.DialogResult.OK Then
            SQL.RunQuery("Delete  From tblReservation Where CustomerID=@CustomerID")
        End If
        If SQL.RecordCount > 0 Then
            MsgBox("Reservation cancel")
        End If
        ResetAllF()
        GetCustomerID()
    End Sub

    Private Sub ResetAllF()
        cboCustomerID.Text = Nothing
        txtSearch.Clear()
        txtDateOfJourney.Clear()
        txtFlightID.Clear()
        txtSeatNo.Clear()
        txtTicketNo.Clear()
    End Sub

    Private Sub cboCustomerID_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboCustomerID.SelectedIndexChanged
        SearchByID(cboCustomerID.Text)
    End Sub

    Private Sub CancellTicket_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        GetCustomerID()
    End Sub

    Private Sub SearchByID(ByVal SearchID As String)

        SQL.AddParam("@SearchID", SearchID)
        SQL.RunQuery("Select TicketNo,FlightID,SeatBooked,DateOfJourney From tblReservation " & _
                      "Where  CustomerID=@SearchID ")

        If SQL.RecordCount > 0 Then

            txtTicketNo.Text = SQL.DSt.Rows(0).Item("TicketNo")
            txtFlightID.Text = SQL.DSt.Rows(0).Item("FlightID")
            txtSeatNo.Text = SQL.DSt.Rows(0).Item("SeatBooked")
            txtDateOfJourney.Text = SQL.DSt.Rows(0).Item("DateOfJourney")

        End If

    End Sub

    Private Sub GetCustomerID()

        cboCustomerID.Items.Clear()
        SQL.RunQuery("Select CustomerID From tblReservation")

        If SQL.RecordCount > 0 Then
            For Each R As DataRow In SQL.DSt.Rows
                cboCustomerID.Items.Add(R("CustomerID"))
            Next
        End If

    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        SearchByID(txtSearch.Text)
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
End Class