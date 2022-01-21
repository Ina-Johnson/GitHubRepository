Imports System.Data.SqlClient
Imports Microsoft.Reporting.WinForms
Public Class ReportWindow
    Dim conWin As New SQLcon
    

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click

        If cboSelect.Text = "" Then
            MsgBox("Please select Report")
        ElseIf cboSelect.Text = "Reservation" Then
            ReservationReport()
        ElseIf cboSelect.Text = "Customer" Then
            CustomerReport()
        ElseIf cboSelect.Text = "Flight" Then
            FlightReport()
        End If
    End Sub


    Private Sub ReservationReport()

        Dim cmd As New SqlCommand("select * from tblReservation", conWin.CON)
        Dim da As New SqlDataAdapter(cmd)
        Dim dt As New DataTable
        da.Fill(dt)
        With Me.RV.LocalReport
            .DataSources.Clear()
            .ReportPath = "ReservationReport.rdlc"
            .DataSources.Add(New ReportDataSource("DataSet1", dt))
        End With
        RV.RefreshReport()

    End Sub


    Private Sub CustomerReport()

        Dim cmd As New SqlCommand("select * from tblCustomer", conWin.CON)
        Dim da As New SqlDataAdapter(cmd)
        Dim dt As New DataTable
        da.Fill(dt)
        With Me.RV.LocalReport
            .DataSources.Clear()
            .ReportPath = "CustomerReport.rdlc"
            .DataSources.Add(New ReportDataSource("DataSetCustomer", dt))
        End With
        RV.RefreshReport()

    End Sub



    Private Sub FlightReport()

        Dim cmd As New SqlCommand("select * from tblFlight", conWin.CON)
        Dim da As New SqlDataAdapter(cmd)
        Dim dt As New DataTable
        da.Fill(dt)
        With Me.RV.LocalReport
            .DataSources.Clear()
            .ReportPath = "FlightReport.rdlc"
            .DataSources.Add(New ReportDataSource("DataSet1", dt))
        End With
        RV.RefreshReport()

    End Sub

    
End Class