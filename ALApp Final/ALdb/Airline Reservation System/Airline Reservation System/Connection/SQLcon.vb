
Imports System.IO
Imports System.Data
Imports System.Data.SqlClient

Public Class SQLcon

    Public CON As New SqlConnection("Data Source=" & My.Settings.Server & "; Initial Catalog=" & My.Settings.Database & "; Integrated Security=True")
    Public CMD As SqlCommand
    Public DA As SqlDataAdapter
    Public DSt As DataTable
    Public RecordCount As Integer
    Public Prams As New List(Of SqlParameter)
    Public Exception As String
    Public OpenF As New OpenFileDialog
    Private Reader As SqlDataReader

    Public Function ConnectFunction() As Boolean

        Try
            CON.Open()

            Return True

            CON.Close()
        Catch ex As Exception

            If CON.State = ConnectionState.Open Then
                CON.Close()
            End If

            Return False
        End Try

    End Function



    Public Sub RunQuery(ByVal Query As String)

        RecordCount = 0
        Exception = ""
        Try
            CON.Open()

            CMD = New SqlCommand(Query, CON)
            'Load the parameter into cmd
            Prams.ForEach(Sub(p) CMD.Parameters.Add(p))

            'Clear the parameter
            Prams.Clear()

            DA = New SqlDataAdapter(CMD)
            DSt = New DataTable()
            RecordCount = DA.Fill(DSt)

            CON.Close()

        Catch ex As Exception
            Exception = ex.Message
            If CON.State = ConnectionState.Open Then
                CON.Close()
            End If
        End Try
    End Sub

    Public Sub AddParam(ByVal Name As String, ByVal Value As Object)
        Dim NewPram As New SqlParameter(Name, Value)
        Prams.Add(NewPram)
    End Sub



    Public Function UpdateQuery(ByVal Query As String) As Integer

        Exception = ""
        Try
            CON.Open()

            CMD = New SqlCommand(Query, CON)

            RecordCount = CMD.ExecuteNonQuery()

            CON.Close()
            Return RecordCount
        Catch ex As Exception
            Exception = ex.Message
            If CON.State = ConnectionState.Open Then
                CON.Close()
            End If
        End Try
        Return 0
    End Function
End Class
