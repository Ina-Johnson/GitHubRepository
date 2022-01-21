Imports System.Windows.Forms

Public Class MainWindow
    Dim toolTip As New ToolTip
    Dim Login As New LoginWindow

    Private Sub LogOutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LogOutToolStripMenuItem.Click
        Me.Close()
        Login.ShowDialog()
    End Sub

    Private Sub LoadForm(ByVal Win As Form)
        MainPanel.Controls.Clear()
        Win.TopLevel = False
        MainPanel.Controls.Add(Win)
        Win.Show()
    End Sub

    
    Private Sub btnCustomer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCustomer.Click
        LoadForm(AddCustomer)
    End Sub

    Private Sub btnFlight_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFlight.Click
        LoadForm(AddFlight)
    End Sub

    Private Sub btnEditFlight_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditFlight.Click
        LoadForm(UpdateFlight)
    End Sub

    Private Sub btnEditCustomer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditCustomer.Click
        LoadForm(UpdateCustomer)
    End Sub

    Private Sub LogOutToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LogOutToolStripMenuItem1.Click
        Me.Close()
        Login.ShowDialog()
    End Sub

    Private Sub HelpToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HelpToolStripMenuItem.Click
        'LoadForm(AboutAirLine)
    End Sub

    Private Sub btnEditUser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditUser.Click
        LoadForm(EditUser)
    End Sub

    Private Sub btnUser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUser.Click
        LoadForm(CreateUsersLogin)
    End Sub

   
    Private Sub btnEditAirline_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditAirline.Click
        LoadForm(ReportWindow)
    End Sub

    Private Sub btnUser_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUser.MouseHover
        ToolTip.IsBalloon = True
        ToolTip.UseAnimation = True
        ToolTip.ToolTipTitle = ""
        toolTip.SetToolTip(btnUser, "User Registration")
    End Sub

    Private Sub btnCustomer_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCustomer.MouseHover
        toolTip.IsBalloon = True
        toolTip.UseAnimation = True
        toolTip.ToolTipTitle = ""
        toolTip.SetToolTip(btnCustomer, "Passenger Registration")
    End Sub

    Private Sub btnFlight_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFlight.MouseHover
        toolTip.IsBalloon = True
        toolTip.UseAnimation = True
        toolTip.ToolTipTitle = ""
        toolTip.SetToolTip(btnFlight, "Flight Registration")
    End Sub

    Private Sub btnEditUser_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditUser.MouseHover
        toolTip.IsBalloon = True
        toolTip.UseAnimation = True
        toolTip.ToolTipTitle = ""
        toolTip.SetToolTip(btnEditUser, "Modify Users Info")
    End Sub

    Private Sub btnEditCustomer_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditCustomer.MouseHover
        toolTip.IsBalloon = True
        toolTip.UseAnimation = True
        toolTip.ToolTipTitle = ""
        toolTip.SetToolTip(btnEditCustomer, "Modify Passengers Info")
    End Sub

    Private Sub btnEditFlight_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditFlight.MouseHover
        toolTip.IsBalloon = True
        toolTip.UseAnimation = True
        toolTip.ToolTipTitle = ""
        toolTip.SetToolTip(btnEditFlight, "Modify Flight Info")
    End Sub

    Private Sub btnEditAirline_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditAirline.MouseHover
        toolTip.IsBalloon = True
        toolTip.UseAnimation = True
        toolTip.ToolTipTitle = ""
        toolTip.SetToolTip(btnEditAirline, "Show Reports")
    End Sub
End Class
