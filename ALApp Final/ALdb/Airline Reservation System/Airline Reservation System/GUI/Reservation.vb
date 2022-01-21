Imports System.Data.SqlClient
Public Class Reservation
    Dim SQL As New SQLcon
    Dim CMD As SqlCommand
    Dim OriginalAvailableSeat As Integer

    Private Sub Reservation_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        cboCustomerID.SelectedText = "Please Select"
        GetCustomerID()
        GetFlightSource()

    End Sub

    Private Sub GetCustomerID()

        SQL.RunQuery("Select CustomerID from tblCustomer")
        If SQL.RecordCount > 0 Then
            For Each R As DataRow In SQL.DSt.Rows
                cboCustomerID.Items.Add(R(0))
            Next
        End If

    End Sub

    Public Sub GetFlightSource()

        SQL.RunQuery("Select DISTINCT(Source) from tblFlight ")
        If SQL.RecordCount > 0 Then
            For Each R As DataRow In SQL.DSt.Rows
                cboSource.Items.Add(R(0))
            Next
        End If

    End Sub



    Public Sub GetFlightDestination(ByVal Source As String)

        cboDestination.Items.Clear()

        SQL.AddParam("@FD", Source)
        SQL.RunQuery("Select DISTINCT(Destination) from tblFlight Where Source=@FD ")
        If SQL.RecordCount > 0 Then
            For Each R As DataRow In SQL.DSt.Rows
                cboDestination.Items.Add(R(0))
            Next
        End If

    End Sub

    Private Sub cboDestination_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboDestination.Click
        GetFlightDestination(cboSource.Text)
    End Sub


    Public Sub DisplayGetFlightDestination(ByVal Destination As String)

        SQL.AddParam("@FD", Destination)
        SQL.RunQuery("Select FlightID,FlightName,Source,Destination,DepartureTime,ArrivalTime,FlightClass," & _
                     "FlightSeat,FlightCharges from tblFlight Where Destination=@FD ")

        If SQL.RecordCount > 0 Then

            dgvFlightBook.DataSource = SQL.DSt

        End If

    End Sub

    Private Sub cboDestination_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboDestination.SelectedIndexChanged
        DisplayGetFlightDestination(cboDestination.Text)
    End Sub

    Private Function CheckForCustomerID() As Boolean
        Dim CustMessage As String = ""

        SQL.AddParam("@ID", cboCustomerID.Text)
        SQL.RunQuery("Select count(CustomerID) as CustomerID from tblReservation where CustomerID=@ID")
        If SQL.DSt.Rows(0).Item("CustomerID") = 1 Then
            CustMessage = ("Customer with this" & " " & cboCustomerID.Text & " " & "number" & Environment.NewLine & _
                "has already been booked")
        End If

        If CustMessage <> "" Then
            MsgBox(CustMessage)
            Return False
        Else
            Return True
        End If

    End Function

    Private Function CheckIfTotalSeatEqualSeatBooked() As Boolean

        Dim Str As String = "select COUNT (seatbooked) from tblReservation where FlightID ='" & txtFlightID.Text & "'"
        SQL.CON.Open()

        CMD = New SqlCommand(Str, SQL.CON)
        Dim SBooked = CMD.ExecuteScalar

        SQL.CON.Close()
        CMD.Dispose()
        If SQL.CON.State = ConnectionState.Open Then
            SQL.CON.Close()
        End If

        Dim Str1 As String = "select (FlightSeat) from tblFlight  where FlightID ='" & txtFlightID.Text & "'"
        SQL.CON.Open()

        CMD = New SqlCommand(Str, SQL.CON)
        Dim FSeat = CMD.ExecuteScalar

        SQL.CON.Close()
        CMD.Dispose()
        If SQL.CON.State = ConnectionState.Open Then
            SQL.CON.Close()
        End If

        If SBooked <> FSeat Then
            Return False
        Else
            Return True
        End If

    End Function

    Private Function IsDataComplete() As Boolean

        Dim Mess As String = ""

        If cboCustomerID.Text = "Please Select" Then
            Mess = ("Please select customer identification")
            cboCustomerID.Focus()
        ElseIf cboDays.Text = "Day" OrElse cboMonths.Text = "Month" OrElse cboYears.Text = "Year" Then
            Mess = ("Please select day,month and year")
            cboDays.Focus()
        ElseIf txtTicketNO.Text.Trim = "" Then
            Mess = ("Please enter ticket number")
            txtTicketNO.Focus()
        ElseIf txtSeatBook.Text.Trim = "" Then
            Mess = ("The flight is full")
            txtSeatBook.Focus()
        ElseIf Not IsNumeric(txtTicketNO.Text.Trim) Then
            Mess = ("Ticket number must be digit number")
            txtTicketNO.Focus()
        End If


        If Mess <> "" Then
            MsgBox(Mess)
            Return False
        Else
            Return True
        End If

    End Function

    Private Sub dgvFlightBook_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvFlightBook.CellClick

        Try
            txtFlightID.Text = (dgvFlightBook.Item(0, e.RowIndex).Value).ToString
            txtTotalNSeat.Text = (dgvFlightBook.Item(7, e.RowIndex).Value).ToString

            GetSeatBooked()

        Catch ex As Exception

        End Try
        If SQL.CON.State = ConnectionState.Open Then
            SQL.CON.Close()
        End If
    End Sub

    Private Sub GetSeatBooked()


        Try

            Dim string1 As String = " Select Max(Right(SeatBooked,1)) as SeatBooked From tblReservation where FlightID ='" & txtFlightID.Text & "' "

            SQL.CON.Open()

            CMD = New SqlCommand(string1, SQL.CON)

            Reader = CMD.ExecuteReader()

            While (Reader.Read())

                If (Reader.HasRows = False) Or IsDBNull((Reader.Item("SeatBooked"))) Then
                    txtSeatBook.Text = "1"
                ElseIf txtSeatBook.Text > txtTotalNSeat.Text Then
                    MsgBox("The flight has already full")
                    Exit Sub
                Else
                    Dim NewID As Integer = CInt(Reader.Item("SeatBooked"))
                    NewID += 1
                    txtSeatBook.Text = NewID.ToString("0")
                    If txtSeatBook.Text < txtTotalNSeat.Text Then
                    Else
                        txtSeatBook.Text = ""
                        txtAvailSeatNo.Text = "0"
                        MsgBox("The flight is full")
                        Exit Sub
                    End If
                End If

            End While

            SQL.CON.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        If SQL.CON.State = ConnectionState.Open Then
            SQL.CON.Close()
        End If
    End Sub

    Private Sub ResetEntireFills()

        cboCustomerID.Text = "Please Select"

        cboDays.Text = "Day"
        cboMonths.Text = "Month"
        cboYears.Text = "Year"

        txtFName.Clear()
        txtLName.Clear()
        txtGender.Clear()
        txtDateOfBirth.Clear()
        txtAddress.Clear()
        txtPhoneNo.Clear()
        txtTicketNO.Clear()
        txtSeatBook.Clear()
        txtAvailSeatNo.Clear()
        txtFlightID.Clear()
        txtTotalNSeat.Clear()

    End Sub

    Private Sub FillComboxes()

        'Day 
        Dim I As Integer = 1
        cboDays.Items.Add("Day")
        While I <= 31
            cboDays.Items.Add(I)
            I = I + 1
        End While
        cboDays.SelectedText = "Day"
        '==========================

        'Month
        Dim B As Integer = 1
        cboMonths.Items.Add("Month")
        While B <= 12
            cboMonths.Items.Add(B)
            B = B + 1
        End While
        cboMonths.SelectedText = "Month"
        '===============================

        'Year
        Dim C As Integer = 1920
        cboYears.Items.Add("Year")
        While C <= 2050
            cboYears.Items.Add(C)
            C = C + 1
        End While
        cboYears.SelectedText = "Year"
        '===========================
    End Sub

    Private Sub Reservation_Shown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Shown
        FillComboxes()
    End Sub

    Private Sub GetCustomerInfo()
        SQL.RunQuery("Select FirstName,LastName,Gender,DateOfBirth,PhoneNo,Address " & _
                      "From tblCustomer Where CustomerID='" & cboCustomerID.Text & "'")
        If SQL.RecordCount > 0 Then
            txtFName.Text = SQL.DSt.Rows(0).Item("FirstName")
            txtLName.Text = SQL.DSt.Rows(0).Item("LastName")
            txtGender.Text = SQL.DSt.Rows(0).Item("Gender")
            txtDateOfBirth.Text = SQL.DSt.Rows(0).Item("DateOfBirth")
            txtPhoneNo.Text = SQL.DSt.Rows(0).Item("PhoneNo")
            txtAddress.Text = SQL.DSt.Rows(0).Item("Address")
        End If

    End Sub

    Private Sub cboCustomerID_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboCustomerID.SelectedIndexChanged
        GetCustomerInfo()
    End Sub

    Private Sub txtSeatBook_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSeatBook.TextChanged
        Try
           
            txtAvailSeatNo.Text = txtTotalNSeat.Text - (txtSeatBook.Text)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtTotalNSeat_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTotalNSeat.TextChanged
        Try
            txtAvailSeatNo.Text = txtTotalNSeat.Text - (txtSeatBook.Text)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnBook_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBook.Click

        If dgvFlightBook.SelectedRows.Count = 0 Then
            MsgBox("Please select a flight to book")
            Exit Sub
            cboSource.Focus()
        End If

        If Not IsDataComplete() Then
            Exit Sub
        End If

        If Not CheckForCustomerID() Then
            Exit Sub
        End If


        If Not CheckIfTotalSeatEqualSeatBooked() Then
            MsgBox("The flight has already full")
            Exit Sub
        End If

        If txtSeatBook.Text <> "" Then

            SQL.AddParam("@CustID", cboCustomerID.Text)
            SQL.AddParam("@Day", cboDays.Text + "/")
            SQL.AddParam("@Month", cboMonths.Text + "/")
            SQL.AddParam("@Year", cboYears.Text)
            SQL.AddParam("@FID", txtFlightID.Text)
            SQL.AddParam("@SeatB", txtSeatBook.Text)
            SQL.AddParam("@TNo", txtTicketNO.Text)

            SQL.RunQuery("INSERT INTO tblReservation (CustomerID,DateOfJourney,FlightID,SeatBooked,TicketNo)" & _
                          "VALUES(@CustID,@Day+@Month+@Year,@FID,@SeatB,@TNo)")

            If SQL.RecordCount > 0 Then
                MsgBox("Customer with an ID of " + " " + cboCustomerID.Text + " " + "has booked")
            End If

        End If

        ResetEntireFills()

        GetSeatBooked()

    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
End Class