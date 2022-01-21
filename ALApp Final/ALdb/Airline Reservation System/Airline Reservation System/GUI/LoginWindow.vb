Imports System.Data.SqlClient
Imports System.IO
Public Class LoginWindow
    Dim SQL As New SQLcon
    Dim UW As New UserWindow
    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Application.Exit()
    End Sub

    Private Sub btnLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogin.Click
        ValidateFills()
        If Authenticated() = True Then
            Dim MW As New MainWindow

            If cboUserType.Text = "Admin" Then
                MW.Show()
                Me.Hide()
            End If

        End If

        If UserWinAuthenticated() = True Then

            If cboUserType.Text = "Users" Then
                UW.Show()
                LoadImage()
                UW.lblUserName.Text = txtUserName.Text
                Me.Hide()
            End If

        End If


    End Sub

    Private Function UserWinAuthenticated() As Boolean
        Dim W As New CreateUsersLogin

        If SQL.DSt IsNot Nothing Then
            SQL.DSt.Clear()
        End If
        Try

            Dim Pass = W.PasswordHash(txtPassword.Text)


            SQL.AddParam("@UName", txtUserName.Text)
            SQL.AddParam("@Pass", Pass)

            SQL.RunQuery("select count(UserName) as UserName from tblUser1 where UserName = @UName and UserPass = @Pass  COLLATE SQL_Latin1_General_CP1_CS_AS")

            If SQL.DSt.Rows(0).Item("UserName") = 1 Then
                Return True
            Else
                MessageBox.Show("UserName or Password do not match", "Important Info", MessageBoxButtons.RetryCancel)
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return False
    End Function

    Private Sub LoadImage()

        Dim img() As Byte
        Try


            SQL.RunQuery("select UserImage from tblUser1 where UserName = '" & txtUserName.Text & "'")

            img = SQL.DSt.Rows(0)("UserImage")
            Dim MS As New MemoryStream(img)

            UW.pbUserImage.Image = Image.FromStream(MS)


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub


    Private Sub linCreateUser_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles linCreateUser.LinkClicked
        CreateUsersLogin.Show()
        Me.Hide()
    End Sub


    Private Sub ValidateFills()

        If txtUserName.Text.Trim = "" Then
            MessageBox.Show("User Name is required")
            txtUserName.Focus()
            Exit Sub
        End If

        If IsNumeric(txtUserName.Text) Then
            MessageBox.Show("User Name start with a letter")
            txtUserName.Focus()
            Exit Sub
        End If

        If txtPassword.Text.Trim = "" Then
            MessageBox.Show("Password is required")
            txtPassword.Focus()
            Exit Sub
        End If

        If txtPassword.Text.Length < 8 Then
            MessageBox.Show("Password is too short")
            txtPassword.Focus()
            Exit Sub
        End If
    End Sub

    Private Function Authenticated() As Boolean
        Dim W As New CreateUsersLogin

        If SQL.DSt IsNot Nothing Then
            SQL.DSt.Clear()
        End If
        Try

            Dim Pass = W.PasswordHash(txtPassword.Text)


            SQL.AddParam("@UName", txtUserName.Text)
            SQL.AddParam("@Pass", Pass)

            SQL.RunQuery("select count(UserName) as UserName from tblUsers where UserName = @UName and UserPass = @Pass  COLLATE SQL_Latin1_General_CP1_CS_AS")

            If SQL.DSt.Rows(0).Item("UserName") = 1 Then
                Return True
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return False
    End Function

    Private Sub LoginWindow_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        Application.Exit()
    End Sub

   
End Class