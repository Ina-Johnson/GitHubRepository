Public Class UpdateFlight
    Dim SQL1 As New SQLcon

    Private Sub GetRecord()
        SQL1.RunQuery("SELECT * FROM tblFlight")
        If SQL1.RecordCount > 0 Then
            DGVFlightUpdate.DataSource = SQL1.DSt
        End If

    End Sub

    Private Sub DeletetRecord()
        SQL1.RunQuery("Delete FROM tblFlight Where FlightID ='" & DGVFlightUpdate.SelectedRows(0).Cells(0).Value & "' ")
        If SQL1.RecordCount > 0 Then
            DGVFlightUpdate.DataSource = SQL1.DSt
        End If
        GetRecord()
        ResetFills()
    End Sub

    Private Sub UpdateFlight_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        btnSaveUpdate.Enabled = False
        GetRecord()
    End Sub

    Private Sub btnSaveUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSaveUpdate.Click

        If txtFlightID.Text = "" OrElse DGVFlightUpdate.SelectedRows.Count = 0 Then
            MsgBox("Please select the flight information " & Environment.NewLine & "you want to update")
            Exit Sub
        End If

        SQL1.AddParam("@FN", txtFlightName.Text)
        SQL1.AddParam("@Sou", txtSource.Text)
        SQL1.AddParam("@Dest", txtDestination.Text)
        SQL1.AddParam("@Depart", dtpDeparture.Value)
        SQL1.AddParam("@Arriv", dtpArrival.Value)
        SQL1.AddParam("@Class", txtFClass.Text)
        SQL1.AddParam("@Charge", txtCharges.Text)
        SQL1.AddParam("@Seat", txtNoSeat.Text)
        SQL1.AddParam("@FID", DGVFlightUpdate.SelectedRows(0).Cells(0).Value)

        SQL1.RunQuery("UPDATE tblFlight SET FlightName=@FN, Source=@Sou, Destination=@Dest, " & _
                "DepartureTime=@Depart ,ArrivalTime=@Arriv, FlightClass=@Class ,FlightCharges=@Charge, FlightSeat=@Seat WHERE FlightID=@FID")

        If SQL1.RecordCount > 0 Then
            MsgBox(SQL1.RecordCount & " " & "Flight has been updated successfully")
        End If

        GetRecord()
        ResetFills()
    End Sub
    Private Sub ResetFills()
        txtFlightID.Clear()
        txtFlightName.Clear()
        txtSource.Clear()
        txtDestination.Clear()
        dtpDeparture.Value = Now
        dtpArrival.Value = Now
        txtFClass.Clear()
        txtCharges.Clear()
        txtNoSeat.Clear()
    End Sub

    Private Sub DGVFlightUpdate_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGVFlightUpdate.CellClick

        Try
            txtFlightID.Text = DGVFlightUpdate.Item(0, e.RowIndex).Value
            txtFlightName.Text = DGVFlightUpdate.Item(1, e.RowIndex).Value
            txtSource.Text = DGVFlightUpdate.Item(2, e.RowIndex).Value
            txtDestination.Text = DGVFlightUpdate.Item(3, e.RowIndex).Value
            dtpDeparture.Value = DGVFlightUpdate.Item(4, e.RowIndex).Value
            dtpArrival.Value = DGVFlightUpdate.Item(5, e.RowIndex).Value
            txtFClass.Text = DGVFlightUpdate.Item(6, e.RowIndex).Value
            txtCharges.Text = DGVFlightUpdate.Item(7, e.RowIndex).Value
            txtNoSeat.Text = DGVFlightUpdate.Item(8, e.RowIndex).Value
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtFlightID_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtFlightID.TextChanged
        btnSaveUpdate.Enabled = True
    End Sub

    Private Sub btnSearchByID_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearchByID.Click
        SearchByID(txtSearch.Text)
    End Sub

    Private Sub SearchByID(ByVal SearchID As String)

        SQL1.AddParam("@SearchID", "%" & SearchID & "%")
        SQL1.RunQuery("Select FlightID,FlightName,Source,Destination,DepartureTime,ArrivalTime,FlightClass,FlightCharges,FlightSeat from tblFlight " & _
                      "Where FlightID like @SearchID")

        If SQL1.RecordCount > 0 Then
            For Each R As DataRow In SQL1.DSt.Rows()

                txtFlightID.Text = R(0)
                txtFlightName.Text = R(1)
                txtSource.Text = R(2)
                txtDestination.Text = R(3)
                dtpDeparture.Value = R(4)
                dtpArrival.Value = R(5)
                txtFClass.Text = R(6)
                txtCharges.Text = R(7)
                txtNoSeat.Text = R(8)

            Next
        End If

    End Sub

    Private Sub btnDelet_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelet.Click
        Me.Close()
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        DeletetRecord()
    End Sub
End Class