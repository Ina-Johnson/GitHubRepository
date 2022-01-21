
Public Class Connection
    Dim S As New SQLcon
    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click

        If (My.Settings.Server = txtServer.Text) And (My.Settings.Database = txtDatabase.Text) Then
            MsgBox("Configuration has all ready been saved")
            Exit Sub
        End If

        My.Settings.Server = txtServer.Text.ToString()
        My.Settings.Database = txtDatabase.Text.ToString()
        My.Settings.Save()
        MsgBox("Configuration has Succssfully saved")

    End Sub

    Private Sub btnConnect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConnect.Click

        If S.ConnectFunction = True Then
            MsgBox("Succssfully Connected")
            Me.Hide()
            LoginWindow.Show()
        Else
            MsgBox("Fail to Connected")
        End If

    End Sub

    Private Sub Connection_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtServer.Text = My.Settings.Server
        txtDatabase.Text = My.Settings.Database
    End Sub

End Class