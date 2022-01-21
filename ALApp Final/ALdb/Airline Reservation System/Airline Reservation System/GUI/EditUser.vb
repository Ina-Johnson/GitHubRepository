Imports System.Security.Cryptography
Imports System.Data.SqlClient
Imports AForge.Video
Imports AForge.Video.DirectShow
Imports AForge.Video.FFMPEG
Imports System.IO

Public Class EditUser
    Dim SQL As New SQLcon
    Dim CMD As New SqlCommand
    Private Camera As VideoCaptureDevice
    Dim BMP As Bitmap
    Private Sub EditUser_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        btnUpdateUser.Enabled = False
        btnStart.Enabled = False
        btnLoad.Enabled = False

        DGVEditUser.RowTemplate.Height = 60
        GetRecord()
    End Sub

    Public Sub GetRecord()

        SQL.RunQuery("SELECT * FROM tblUser1")
        If SQL.RecordCount < 1 Then
            Exit Sub
        End If
        DGVEditUser.DataSource = SQL.DSt
        DGVEditUser.Columns("UserImage").Width = 100
        For I As Integer = 0 To DGVEditUser.Columns.Count - 1
            If TypeOf DGVEditUser.Columns(I) Is DataGridViewImageColumn Then
                DirectCast(DGVEditUser.Columns(I), DataGridViewImageColumn).ImageLayout = DataGridViewImageCellLayout.Stretch
            End If
        Next

    End Sub

    Private Function LoadImage(ByVal Photo As Integer) As Byte()
        SQL.CON.Open()

        With CMD
            .Connection = SQL.CON
            .CommandText = "SELECT UserImage FROM tblUser1 WHERE UserID=" & DGVEditUser.SelectedRows(0).Cells(0).Value & ""
        End With

        Dim MyPic() As Byte = CType(CMD.ExecuteScalar(), Byte())

        SQL.CON.Close()
        Return MyPic
    End Function

    Private Sub DGVEditUser_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGVEditUser.CellClick
        Try
            txtUserID.Text = DGVEditUser.Item("UserID", e.RowIndex).Value
            txtUserName.Text = DGVEditUser.Item("UserName", e.RowIndex).Value
            'txtPassword.Text = DGVEditUser.Item(2, e.RowIndex).Value
            Dim MS As New MemoryStream(LoadImage(CInt(DGVEditUser.SelectedCells(0).Value)))
            picImage.Image = Image.FromStream(MS)
        Catch ex As Exception

        End Try
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

    Private Sub btnUpdateUser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdateUser.Click
        Try
            If txtUserID.Text = "" OrElse DGVEditUser.SelectedRows.Count = 0 Then
                MsgBox("Please select the User information " & Environment.NewLine & "you want to update ")
                Exit Sub
            End If

            Dim Pass = PasswordHash(txtPassword.Text)

            SQL.AddParam("@FN1", txtUserName.Text)
            SQL.AddParam("@LN2", Pass)

            If Not (picImage.Image Is Nothing) Then
                Dim MS As New MemoryStream()
                picImage.Image.Save(MS, Drawing.Imaging.ImageFormat.Bmp)
                Dim PictureImage() As Byte = MS.ToArray()
                SQL.AddParam("@Pic1", PictureImage)
            End If

            SQL.AddParam("@CID", DGVEditUser.SelectedRows(0).Cells(0).Value)

            Dim Str As String
            If Not (picImage.Image Is Nothing) Then
                Str = "UPDATE tblUser1 SET UserName=@FN1, UserPass=@LN2, UserImage=@Pic1 WHERE UserID=@CID"
            Else
                Str = "UPDATE tblUser1 SET  UserName=@FN1, UserPass=@LN2,  WHERE UserID=@CID"
            End If

            SQL.RunQuery(Str)

            If SQL.RecordCount > 0 Then
                MsgBox(SQL.RecordCount & " " & "User has been updated successfully")
            End If

            GetRecord()
            ResetAllFields()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
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

    Private Sub ResetAllFields()

        txtUserName.Clear()
        txtPassword.Clear()
       
        picImage.Image = Nothing
        Try
            Camera.Stop()
        Catch ex As Exception

        End Try

    End Sub

    
    Private Sub btnStart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStart.Click
        If btnStart.Text = "Start" Then
            btnStart.Text = "Capture"
            StartWebCam()
        Else
            btnStart.Text = "Start"
            Me.picImage.Image = picImage.Image
            Try
                Camera.Stop()
            Catch ex As Exception

            End Try
        End If
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

    Private Sub txtUserName_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtUserName.TextChanged
        btnUpdateUser.Enabled = True
        btnStart.Enabled = True
        btnLoad.Enabled = True
    End Sub

    
    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        DeletetRecord()
    End Sub

    Private Sub DeletetRecord()
        SQL.RunQuery("Delete FROM tblUser1 Where UserID ='" & DGVEditUser.SelectedRows(0).Cells(0).Value & "' ")
        If SQL.RecordCount > 0 Then
            DGVEditUser.DataSource = SQL.DSt
        End If
        GetRecord()
        ResetAllFields()
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
End Class