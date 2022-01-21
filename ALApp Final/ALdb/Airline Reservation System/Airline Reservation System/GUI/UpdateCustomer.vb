Imports System.Data.SqlClient
Imports AForge.Video
Imports AForge.Video.DirectShow
Imports AForge.Video.FFMPEG
Imports System.IO
Public Class UpdateCustomer
    Dim SQL As New SQLcon
    Dim CMD As New SqlCommand
    Private Camera As VideoCaptureDevice
    Dim BMP As Bitmap

    Public Sub GetRecord()

        SQL.RunQuery("SELECT * FROM tblCustomer")
        If SQL.RecordCount < 1 Then
            Exit Sub
        End If
        DGVCustomerUpdate.DataSource = SQL.DSt
        DGVCustomerUpdate.Columns(7).Width = 100
        For I As Integer = 0 To DGVCustomerUpdate.Columns.Count - 1
            If TypeOf DGVCustomerUpdate.Columns(I) Is DataGridViewImageColumn Then
                DirectCast(DGVCustomerUpdate.Columns(I), DataGridViewImageColumn).ImageLayout = DataGridViewImageCellLayout.Stretch
            End If
        Next

    End Sub


    Private Function LoadImage(ByVal Photo As Integer) As Byte()
        SQL.CON.Open()

        With CMD
            .Connection = SQL.CON
            .CommandText = "SELECT Photo FROM tblCustomer WHERE CustomerID=" & DGVCustomerUpdate.SelectedRows(0).Cells(0).Value & ""
        End With

        Dim MyPic() As Byte = CType(CMD.ExecuteScalar(), Byte())

        SQL.CON.Close()
        Return MyPic
    End Function

    Private Sub UpdateCustomer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        btnSaveUpdate.Enabled = False
        btnStartWebcam.Enabled = False
        btnLoad.Enabled = False

        DGVCustomerUpdate.RowTemplate.Height = 60
        GetRecord()
    End Sub

    Private Sub DGVCustomerUpdate_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGVCustomerUpdate.CellClick

        Try
            txtCustomerID.Text = DGVCustomerUpdate.Item(0, e.RowIndex).Value
            txtFName.Text = DGVCustomerUpdate.Item(1, e.RowIndex).Value
            txtLName.Text = DGVCustomerUpdate.Item(2, e.RowIndex).Value
            txtGender.Text = DGVCustomerUpdate.Item(3, e.RowIndex).Value
            txtDateOfBirth.Text = DGVCustomerUpdate.Item(4, e.RowIndex).Value
            txtPhone.Text = DGVCustomerUpdate.Item(5, e.RowIndex).Value
            txtAddress.Text = DGVCustomerUpdate.Item(6, e.RowIndex).Value
            Dim MS As New MemoryStream(LoadImage(CInt(DGVCustomerUpdate.SelectedCells(0).Value)))
            picUpdateImage.Image = Image.FromStream(MS)
        Catch ex As Exception

        End Try

    End Sub

    Private Sub btnSaveUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSaveUpdate.Click

        Try

            If txtCustomerID.Text = "" OrElse DGVCustomerUpdate.SelectedRows.Count = 0 Then
                MsgBox("Please select the customer information " & Environment.NewLine & "you want to update ")
                Exit Sub
            End If

            SQL.AddParam("@FN1", txtFName.Text)
            SQL.AddParam("@LN2", txtLName.Text)
            SQL.AddParam("@Gen", txtGender.Text)
            SQL.AddParam("@DB", txtDateOfBirth.Text)
            SQL.AddParam("@Pho", txtPhone.Text)
            SQL.AddParam("@Add", txtAddress.Text)

            If Not (picUpdateImage.Image Is Nothing) Then
                Dim MS As New MemoryStream()
                picUpdateImage.Image.Save(MS, Drawing.Imaging.ImageFormat.Bmp)
                Dim PictureImage() As Byte = MS.ToArray()
                SQL.AddParam("@Pic1", PictureImage)
            End If

            SQL.AddParam("@CID", DGVCustomerUpdate.SelectedRows(0).Cells(0).Value)

            Dim Str As String
            If Not (picUpdateImage.Image Is Nothing) Then
                Str = "UPDATE tblCustomer SET FirstName=@FN1, LastName=@LN2, Gender=@Gen, DateOfBirth=@DB, " & _
                        "PhoneNo=@Pho ,Address=@Add, Photo=@Pic1 WHERE CustomerID=@CID"
            Else
                Str = "UPDATE tblCustomer SET  FirstName=@FN1, LastName=@LN2, Gender=@Gen, DateOfBirth=@DB, PhoneNo=@Pho," & _
                    "Address=@Add  WHERE CustomerID=@CID"
            End If

            SQL.RunQuery(Str)

            If SQL.RecordCount > 0 Then
                MsgBox(SQL.RecordCount & " " & "Customer has been updated successfully")
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
                picUpdateImage.Load(.FileName)
            End If
        End With
    End Sub

    Private Sub ResetAllFields()

        txtDateOfBirth.Clear()
        txtCustomerID.Clear()
        txtFName.Clear()
        txtLName.Clear()
        txtPhone.Clear()
        txtAddress.Clear()
        txtGender.Clear()
        picUpdateImage.Image = Nothing
        Try
            Camera.Stop()
        Catch ex As Exception

        End Try

    End Sub

    Private Sub btnStartWebcam_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStartWebcam.Click
        If btnStartWebcam.Text = "Start Webcam" Then
            btnStartWebcam.Text = "Capture"
            StartWebCam()
        Else
            btnStartWebcam.Text = "Start Webcam"
            Me.picUpdateImage.Image = picUpdateImage.Image
            Try
                Camera.Stop()
            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub CaptureDevice(ByVal sender As Object, ByVal eventArgs As NewFrameEventArgs)
        BMP = DirectCast(eventArgs.Frame.Clone(), Bitmap)
        picUpdateImage.Image = DirectCast(eventArgs.Frame.Clone(), Bitmap)
    End Sub

    Public Sub StartWebCam()
        Dim CameraSelection As VideoCaptureDeviceForm = New VideoCaptureDeviceForm()
        If CameraSelection.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Camera = CameraSelection.VideoDevice
            AddHandler Camera.NewFrame, New NewFrameEventHandler(AddressOf CaptureDevice)
            Camera.Start()
        End If
    End Sub

    Private Sub txtCustomerID_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCustomerID.TextChanged
        btnSaveUpdate.Enabled = True
        btnStartWebcam.Enabled = True
        btnLoad.Enabled = True
    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        SearchByID(txtSearchID.Text)
    End Sub

    Private Sub SearchByID(ByVal SearchID As String)

        SQL.AddParam("@SearchID", "%" & SearchID & "%")
        SQL.RunQuery("Select CustomerID,FirstName,LastName,Gender,DateOfBirth,PhoneNo,Address,Photo from tblCustomer " & _
                      "Where CustomerID like @SearchID")

        If SQL.RecordCount > 0 Then
            For Each R As DataRow In SQL.DSt.Rows()

                txtCustomerID.Text = R(0)
                txtFName.Text = R(1)
                txtLName.Text = R(2)
                txtGender.Text = R(3)
                txtDateOfBirth.Text = R(4)
                txtPhone.Text = R(5)
                txtAddress.Text = R(6)
                picUpdateImage.Image = R(7)

            Next
        End If

    End Sub

   
    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnDelet_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelet.Click
        DeletetRecord()
    End Sub

    Private Sub DeletetRecord()
        SQL.RunQuery("Delete FROM tblCustomer Where CustomerID ='" & DGVCustomerUpdate.SelectedRows(0).Cells(0).Value & "' ")
        If SQL.RecordCount > 0 Then
            DGVCustomerUpdate.DataSource = SQL.DSt
        End If
        GetRecord()
        ResetAllFields()
    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub
End Class