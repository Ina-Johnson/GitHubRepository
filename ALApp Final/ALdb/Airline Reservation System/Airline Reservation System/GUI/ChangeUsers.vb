Public Class ChangeUsers

    Dim SQL3 As New SQLcon

    Private Sub btnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click

        If Not IsDataComplete() Then
            Exit Sub
        End If
        Dim s As New CreateUsersLogin
        Dim Pass = s.PasswordHash(txtNewPass.Text)
        If txtUName.Text <> "" Then

            If txtNewPass.Text.Length >= 8 Then

                Dim Cmd As String = "Update tblUsers Set UserPass='" & Pass & "'" & _
                    "Where UserName='" & txtUName.Text & "'"
                If SQL3.UpdateQuery(Cmd) = 0 Then
                    MsgBox(txtUName.Text + " " + " could not be found")
                Else
                    MsgBox(txtUName.Text + " " + " password successfully changed")
                End If

            Else
                MsgBox("Password length must be " + vbNewLine + "equal to 8 or more")
            End If

        End If
        txtNewPass.Clear()
        txtUName.Clear()

    End Sub
    Private Function IsDataComplete() As Boolean
        Dim Mess As String = ""
        If txtUName.Text.Trim = "" Then
            Mess = "Your user name is required"
            txtUName.Focus()
        ElseIf IsNumeric(txtUName.Text) Then
            Mess = "User Name must start with a letter"
        ElseIf txtNewPass.Text.Trim = "" Then
            Mess = "The new password is required"
            txtNewPass.Focus()
        End If

        If Mess <> "" Then
            MsgBox(Mess)
            Return False
        Else
            Return True
        End If

    End Function

    Private Sub ChangeUsers_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtUName.Focus()
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
End Class