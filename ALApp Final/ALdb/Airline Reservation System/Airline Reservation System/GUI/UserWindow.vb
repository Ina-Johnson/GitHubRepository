Public Class UserWindow
    Dim toolTip As New ToolTip
    Private Sub btnCheck_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCheck.Click
        LoadUserForm(EnquiryWin)
    End Sub


    Public Sub LoadUserForm(ByVal WinLoad As Form)
        UserMainPanel.Controls.Clear()
        WinLoad.TopLevel = False
        UserMainPanel.Controls.Add(WinLoad)
        WinLoad.Show()
    End Sub

    Private Sub btnBooked_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBooked.Click
        LoadUserForm(Reservation)
    End Sub

    Private Sub btnCancelRes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelRes.Click
        LoadUserForm(CancellTicket)
    End Sub

    Private Sub btnMPayment_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMPayment.Click
        LoadUserForm(AddPayment)
    End Sub

    Private Sub UserWindow_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        Application.Exit()
    End Sub

    Private Sub LogOutToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LogOutToolStripMenuItem1.Click
        Me.Close()
        Dim Lwin As New LoginWindow
        Lwin.ShowDialog()
    End Sub

    Private Sub btnCheck_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCheck.MouseHover
        toolTip.IsBalloon = True
        toolTip.UseAnimation = True
        toolTip.ToolTipTitle = ""
        toolTip.SetToolTip(btnCheck, "Check to see if user has been booked")
    End Sub

    Private Sub btnBooked_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBooked.MouseHover
        toolTip.IsBalloon = True
        toolTip.UseAnimation = True
        toolTip.ToolTipTitle = ""
        toolTip.SetToolTip(btnBooked, "Make your Reservation")
    End Sub

    Private Sub btnCancelRes_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelRes.MouseHover
        toolTip.IsBalloon = True
        toolTip.UseAnimation = True
        toolTip.ToolTipTitle = ""
        toolTip.SetToolTip(btnCancelRes, "Cancel your Reservation")
    End Sub

    Private Sub btnMPayment_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMPayment.MouseHover
        toolTip.IsBalloon = True
        toolTip.UseAnimation = True
        toolTip.ToolTipTitle = ""
        toolTip.SetToolTip(btnMPayment, "Make your Payment Here")
    End Sub

    Private Sub HelpToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HelpToolStripMenuItem.Click
        LoadUserForm(AboutAirLine)
    End Sub
End Class