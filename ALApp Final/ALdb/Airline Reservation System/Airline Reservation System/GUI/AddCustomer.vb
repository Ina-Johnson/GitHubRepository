Imports AForge.Video
Imports AForge.Video.DirectShow
Imports AForge.Video.FFMPEG
Imports System.IO
Imports System.Data.SqlClient
Public Class AddCustomer
    Private SQL1 As New SQLcon
    Private Camera As VideoCaptureDevice
    Dim BMP As Bitmap
    Dim CMD As SqlCommand

    Private Sub AddCustomer_Shown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Shown
        DisAbledControls()
        FillComboxes()

    End Sub

    Private Sub CaptureDevice(ByVal sender As Object, ByVal eventArgs As NewFrameEventArgs)
        BMP = DirectCast(eventArgs.Frame.Clone(), Bitmap)
        picImage.Image = DirectCast(eventArgs.Frame.Clone(), Bitmap)
    End Sub

    Private Sub DisAbledControls()
        txtCustomerID.Enabled = False
        txtFName.Enabled = False
        txtLName.Enabled = False
        txtPhone.Enabled = False
        txtAddress.Enabled = False
        cboGender.Enabled = False
        cboDay.Enabled = False
        cboMonth.Enabled = False
        cboYear.Enabled = False
        picImage.Enabled = False
        btnCapture.Enabled = False
        btnLoad.Enabled = False
        btnSave.Enabled = False
        picImage.Image = Nothing
    End Sub

    Private Sub EnabledControls()
        txtFName.Focus()
        txtCustomerID.Enabled = True
        txtFName.Enabled = True
        txtLName.Enabled = True
        txtPhone.Enabled = True
        txtAddress.Enabled = True
        cboGender.Enabled = True
        cboDay.Enabled = True
        cboMonth.Enabled = True
        cboYear.Enabled = True
        picImage.Enabled = True
        btnCapture.Enabled = True
        btnLoad.Enabled = True
        btnSave.Enabled = True
    End Sub

    Private Sub ResetAllFields()
        txtCustomerID.Clear()
        txtFName.Clear()
        txtLName.Clear()
        txtPhone.Clear()
        txtAddress.Clear()
        cboGender.SelectedItem = "Please Select"
        cboDay.SelectedItem = "Day"
        cboMonth.SelectedItem = "Month"
        cboYear.SelectedItem = "Year"
        picImage.Image = Nothing
        Try
            Camera.Stop()
        Catch ex As Exception

        End Try

    End Sub

    Private Sub FillComboxes()



        cboGender.Items.Add("Please Select")
        cboGender.Items.Add("Male")
        cboGender.Items.Add("Female")
        cboGender.SelectedItem = "Please Select"


        'Day 
        Dim I As Integer = 1
        cboDay.Items.Add("Day")
        While I <= 31
            cboDay.Items.Add(I)
            I = I + 1
        End While
        cboDay.SelectedText = "Day"
        '==========================

        'Month
        Dim B As Integer = 1
        cboMonth.Items.Add("Month")
        While B <= 12
            cboMonth.Items.Add(B)
            B = B + 1
        End While
        cboMonth.SelectedText = "Month"
        '===============================

        'Year
        Dim C As Integer = 1920
        cboYear.Items.Add("Year")
        While C <= 2050
            cboYear.Items.Add(C)
            C = C + 1
        End While
        cboYear.SelectedText = "Year"
        '===========================
    End Sub

    Private Sub btnAddNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddNew.Click
        txtFName.Focus()
        If btnAddNew.Text = "Add New" Then
            btnAddNew.Text = "Cancel Add"
            EnabledControls()
            GenerateCustomerID()
        Else
            btnAddNew.Text = "Add New"
            ResetAllFields()
            DisAbledControls()
            Exit Sub
        End If

    End Sub



    Public Sub GenerateCustomerID()

        Try

            Dim string1 As String = "Select Max(Right(CustomerID,4)) as CustomerID From tblCustomer"

            SQL1.CON.Open()

            CMD = New SqlCommand(string1, SQL1.CON)

            Reader = CMD.ExecuteReader()

            While (Reader.Read())

                If (Reader.HasRows = False) Or IsDBNull((Reader.Item("CustomerID"))) Then
                    txtCustomerID.Text = "0001"
                Else
                    Dim NewID As Integer = CInt(Reader.Item("CustomerID"))
                    NewID += 1
                    txtCustomerID.Text = NewID.ToString("0000")
                End If

            End While

            SQL1.CON.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub


#Region "ValidateInput"

    Private Function IsValidationCheckComplete() As Boolean
        Dim Mess As String = ""
        If txtFName.Text.Trim = "" Then
            Mess = ("Please enter your name")
            txtFName.Focus()
        ElseIf IsNumeric(txtFName.Text) Then
            Mess = ("Your name must start with a letter")
            txtFName.Focus()
        ElseIf txtLName.Text.Trim = "" Then
            Mess = ("Please enter your last name")
            txtLName.Focus()
        ElseIf IsNumeric(txtLName.Text) Then
            Mess = ("Your name must start with a letter")
            txtLName.Focus()
        ElseIf cboGender.SelectedItem = "Please Select" Then
            Mess = ("Please select your gender")
            cboGender.Focus()
        ElseIf cboDay.SelectedText = "Day" OrElse cboMonth.SelectedText = "Month" OrElse cboYear.SelectedText = "Year" Then
            Mess = ("Please select your day,month and year")
            cboDay.Focus()
        ElseIf txtPhone.Text.Trim = "(   )    -" Then
            Mess = ("Your phone number is required")
            txtPhone.Focus()
        ElseIf txtAddress.Text.Trim = "" Then
            Mess = ("Please enter your address")
            txtAddress.Focus()
        ElseIf picImage.Image Is Nothing Then
            Mess = ("Please your photo is required")
            btnLoad.Focus()
        End If

        If Mess <> "" Then
            MsgBox(Mess)
            Return False
        Else
            Return True
        End If
    End Function

#End Region

    Private Sub btnLoad_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLoad.Click

        With SQL1.OpenF
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



    Public Sub StartWebCam()
        Dim CameraSelection As VideoCaptureDeviceForm = New VideoCaptureDeviceForm()
        If CameraSelection.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Camera = CameraSelection.VideoDevice
            AddHandler Camera.NewFrame, New NewFrameEventHandler(AddressOf CaptureDevice)
            Camera.Start()
        End If
    End Sub

    Private Sub AddCustomer_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        Try
            Camera.Stop()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click

        If Not IsValidationCheckComplete() Then
            Exit Sub
        End If

        AddParameterAndInsert()

        SQL1.RunQuery("INSERT INTO tblCustomer (CustomerID,FirstName,LastName,Gender,DateOfBirth,PhoneNo,Address,Photo)" & _
                            "VALUES (@ID, @FN, @LN, @Gender, @Day+@Month+@Year, @Phone, @Address, @pic)")

        If SQL1.RecordCount > 0 Then
            MsgBox(txtFName.Text + " " + txtLName.Text + " " + "has been saved")
        End If

        ResetAllFields()
        btnAddNew_Click(sender, e)

    End Sub

    Private Sub AddParameterAndInsert()

        Try

            SQL1.AddParam("@ID", txtCustomerID.Text)
            SQL1.AddParam("@FN", txtFName.Text)
            SQL1.AddParam("@LN", txtLName.Text)
            SQL1.AddParam("@Gender", cboGender.Text)
            SQL1.AddParam("@Day", cboDay.Text + "/")
            SQL1.AddParam("@Month", cboMonth.Text + "/")
            SQL1.AddParam("@Year", cboYear.Text)
            SQL1.AddParam("@Phone", txtPhone.Text)
            SQL1.AddParam("@Address", txtAddress.Text)

            If Not (picImage.Image Is Nothing) Then
                Dim MS As New MemoryStream()
                picImage.Image.Save(MS, Drawing.Imaging.ImageFormat.Bmp)
                Dim PictureImage() As Byte = MS.ToArray()
                SQL1.AddParam("@Pic", PictureImage)
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub


End Class
