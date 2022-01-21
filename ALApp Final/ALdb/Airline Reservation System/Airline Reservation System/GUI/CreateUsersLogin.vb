Imports System.Security.Cryptography
Imports AForge.Video
Imports AForge.Video.DirectShow
Imports AForge.Video.FFMPEG
Imports System.IO
Imports System.Data.SqlClient
Public Class CreateUsersLogin

    Private Camera As VideoCaptureDevice
    Dim BMP As Bitmap
    Dim CMD As SqlCommand
    Dim strText As String
    Dim SQL As New SQLcon
    Private Sub btnCreateUser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCreateUser.Click
        ValidateFill()
        CreateUsers()
    End Sub

#Region "Sub to Validate fill"

    Private Sub ValidateFill()
        If txtUserName.Text.Trim = "" Then
            MessageBox.Show("User name is required")
            txtUserName.Focus()
            Exit Sub
        End If

        If IsNumeric(txtUserName.Text) Then
            MessageBox.Show("User name must start with a letter")
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

        If txtConPassword.Text.Trim = "" Then
            MessageBox.Show("Confirmation Password is required")
            txtConPassword.Focus()
            Exit Sub
        End If

        If txtConPassword.Text.Length < 8 Then
            MessageBox.Show("Confirmation Password is too short")
            txtConPassword.Focus()
            Exit Sub
        End If

        If txtPassword.Text <> txtConPassword.Text Then
            MessageBox.Show("The password does not march it Confirmation")
            txtConPassword.Focus()
            Exit Sub
        End If

        If picImage.Image Is Nothing Then
            Mess = ("Please your photo is required")
            btnLoad.Focus()
        End If

    End Sub

#End Region

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub


    Private Sub CreateUsers()

        Try

            Dim Pass = PasswordHash(txtPassword.Text)


            SQL.AddParam("@UName", txtUserName.Text)
            SQL.AddParam("@Pass", Pass)

            If Not (picImage.Image Is Nothing) Then
                Dim MS As New MemoryStream()
                picImage.Image.Save(MS, Drawing.Imaging.ImageFormat.Bmp)
                Dim PictureImg() As Byte = MS.ToArray()
                SQL.AddParam("@Pic", PictureImg)
            End If

            SQL.RunQuery("INSERT INTO tblUser1 (UserName,UserPass,UserImage) Values(@UName,@Pass,@Pic)")

            Reset()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Sub Reset()
        txtUserName.Clear()
        txtPassword.Clear()
        txtConPassword.Clear()
        picImage.Image = Nothing
    End Sub

    Public Function PasswordHash(ByVal Pass As String) As String

        Dim MD5 As New MD5CryptoServiceProvider
        Dim Bt() As Byte = MD5.ComputeHash(System.Text.Encoding.ASCII.GetBytes(Pass))
        Dim S As String = Nothing
        For Each BY As Byte In Bt
            S += BY.ToString("x2")
        Next
        Return S

    End Function

    Private Sub CreateUsersLogin_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        LoginWindow.Show()
        Me.Hide()
    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            txtPassword.UseSystemPasswordChar = False
            txtConPassword.UseSystemPasswordChar = False
        Else
            txtPassword.UseSystemPasswordChar = True
            txtConPassword.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub CaptureDevice(ByVal sender As Object, ByVal eventArgs As NewFrameEventArgs)
        BMP = DirectCast(eventArgs.Frame.Clone(), Bitmap)
        picImage.Image = DirectCast(eventArgs.Frame.Clone(), Bitmap)
    End Sub

    Public Sub StartWebCam()
        Dim CameraSelection As VideoCaptureDeviceForm = New VideoCaptureDeviceForm()
        If CameraSelection.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Camera = CameraSelection.VideoDevice
            AddHandler Camera.NewFrame, New NewFrameEventHandler(AddressOf CaptureDevice)
            Camera.Start()
        End If
    End Sub

    Private Sub btnCapture_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCapture.Click
        If btnCapture.Text = "Start" Then
            btnCapture.Text = "Capture"
            StartWebCam()
        Else
            btnCapture.Text = "Start"
            Me.picImage.Image = picImage.Image
            Try
                Camera.Stop()
            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub btnLoad_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLoad.Click
        With SQL.OpenF
            .Title = "Select Photo"
            .Filter = "Jpeg images only|*.jpg"
            .FileName = ""
            .Multiselect = False
            .ShowDialog()
            If .FileName <> "" Then
                picImage.Load(.FileName)
            End If
        End With
    End Sub
End Class