Imports System.Data.SqlClient
Public Class AddFlight
    Dim SQL1 As New SQLcon
    Dim CMD As SqlCommand

    Private Sub btnAddNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddNew.Click
        If btnAddNew.Text = "Add New" Then
            btnAddNew.Text = "Cancel"
            EnableControls()
            GenerateFlightID()
        Else
            btnAddNew.Text = "Add New"
            DisableControls()
            ResetFill()
        End If


    End Sub
    Public Sub GenerateFlightID()

        Try

            Dim string1 As String = "Select Max(Right(FlightID,4)) as FlightID From tblFlight"

            SQL1.CON.Open()

            CMD = New SqlCommand(string1, SQL1.CON)

            Reader = CMD.ExecuteReader()

            While (Reader.Read())

                If (Reader.HasRows = False) Or IsDBNull((Reader.Item("FlightID"))) Then
                    txtFlightID.Text = "0001"
                Else
                    Dim NewID As Integer = CInt(Reader.Item("FlightID"))
                    NewID += 1
                    txtFlightID.Text = NewID.ToString("0000")
                End If

            End While

            SQL1.CON.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub



    Private Function IsdataComplete() As Boolean
        Dim Mess As String = ""
        If txtFlightName.Text.Trim = "" Then
            Mess = "Flight name is required"
            txtFlightName.Focus()
        ElseIf IsNumeric(txtFlightName.Text) Then
            Mess = ("Flight name must start with a letter")
            txtFlightName.Focus()
        ElseIf txtSource.Text.Trim = "" Then
            Mess = ("Flight take off point is required")
            txtSource.Focus()
        ElseIf IsNumeric(txtSource.Text) Then
            Mess = ("Flight take off point must start with a letter")
            txtSource.Focus()
        ElseIf dtpDeparture.Value = Date.Today Then
            Mess = ("Please select a departure time")
            dtpDeparture.Focus()
        ElseIf txtFClass.Text.Trim = "" Then
            Mess = ("Flight class is required")
            txtFClass.Focus()
        ElseIf IsNumeric(txtFClass.Text) Then
            Mess = ("Flight class name must start with a letter")
            txtFClass.Focus()
        ElseIf txtNoSeat.Text.Trim = "" Then
            Mess = ("Number of available seat is required")
            txtNoSeat.Focus()
        ElseIf Not IsNumeric(txtNoSeat.Text) Then
            Mess = ("Please enter a number")
            txtNoSeat.Focus()
        ElseIf txtDestination.Text.Trim = "" Then
            Mess = ("Flight destination point is required")
            txtDestination.Focus()
        ElseIf IsNumeric(txtDestination.Text) Then
            Mess = ("Flight destination point must start with a letter")
            txtDestination.Focus()
        ElseIf dtpArrival.Value = Date.Today Then
            Mess = ("Please select arrival time")
            dtpArrival.Focus()
        ElseIf txtCharges.Text.Trim = "" Then
            Mess = ("Charge fee is required")
            txtCharges.Focus()
        ElseIf Not IsNumeric(txtCharges.Text) Then
            Mess = ("Please enter an amount")
            txtCharges.Focus()
        End If

        If Mess <> "" Then
            MsgBox(Mess)
            Return False
        Else
            Return True
        End If

    End Function

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click

        If Not IsdataComplete() Then
            Exit Sub
        End If

        Prameter()

        SQL1.RunQuery("INSERT INTO tblFlight (FlightID,FlightName,Source,Destination,DepartureTime,ArrivalTime,FlightClass,FlightCharges,FlightSeat)" & _
                            " VALUES (@FlightID ,@FName ,@FSource ,@FDestination ,@DTime ,@ATime ,@FClass ,@FCharges ,@FSeat)")

        If SQL1.RecordCount > 0 Then
            MsgBox(txtFlightName.Text & " " & "Flight has been saved")
        End If
        ResetFill()
        btnAddNew_Click(sender, e)
    End Sub

    Private Sub DisableControls()

        txtFlightName.Enabled = False
        txtSource.Enabled = False
        txtCharges.Enabled = False
        txtDestination.Enabled = False
        txtFClass.Enabled = False
        txtFlightID.Enabled = False
        txtNoSeat.Enabled = False
        dtpArrival.Enabled = False
        dtpDeparture.Enabled = False
        btnSave.Enabled = False

    End Sub

    Private Sub EnableControls()

        txtFlightName.Enabled = True
        txtSource.Enabled = True
        txtCharges.Enabled = True
        txtDestination.Enabled = True
        txtFClass.Enabled = True
        txtFlightID.Enabled = True
        txtNoSeat.Enabled = True
        dtpArrival.Enabled = True
        dtpDeparture.Enabled = True
        btnSave.Enabled = True

    End Sub

    Private Sub AddFlight_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DisableControls()
    End Sub

    Private Sub ResetFill()

        txtFlightName.Clear()
        txtSource.Clear()
        txtCharges.Clear()
        txtDestination.Clear()
        txtFClass.Clear()
        txtFlightID.Clear()
        txtNoSeat.Clear()
        dtpArrival.Value = Now
        dtpDeparture.Value = Now

    End Sub


    Private Sub Prameter()

        SQL1.AddParam("@FlightID", txtFlightID.Text)
        SQL1.AddParam("@FName", txtFlightName.Text)
        SQL1.AddParam("@FSource", txtSource.Text)
        SQL1.AddParam("@FDestination", txtDestination.Text)
        SQL1.AddParam("@DTime", dtpDeparture.Value)
        SQL1.AddParam("@ATime", dtpArrival.Value)
        SQL1.AddParam("@FClass", txtFClass.Text)
        SQL1.AddParam("@FCharges", txtCharges.Text)
        SQL1.AddParam("@FSeat", txtNoSeat.Text)

    End Sub
End Class