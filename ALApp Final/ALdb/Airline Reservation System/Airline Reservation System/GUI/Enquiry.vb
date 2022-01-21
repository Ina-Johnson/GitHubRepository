Public Class EnquiryWin
    Dim SQL As New SQLcon

    Private Sub Enquiry_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
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

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        SearchByID(txtSearch.Text)
    End Sub

    Private Sub GetCustomerID()

        SQL.RunQuery("Select CustomerID From tblReservation")

        If SQL.RecordCount > 0 Then
            For Each R As DataRow In SQL.DSt.Rows
                cboCustomerID.Items.Add(R("CustomerID"))
            Next
        End If

    End Sub

    Private Sub cboCustomerID_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboCustomerID.SelectedIndexChanged
        SearchByID(cboCustomerID.Text)
    End Sub

End Class