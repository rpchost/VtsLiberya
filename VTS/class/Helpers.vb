Imports System.Globalization
Imports Microsoft.Extensions.Configuration
Imports Microsoft.Extensions.Configuration.Json

Public Class Helpers

    Private config As IConfiguration
    Public Sub Helpers()

    End Sub

    Public Function Expires() As Boolean
        Dim ExpiryDate = Convert.ToDateTime(Handler.AppSettings("ExpiryDate")).ToString(Handler.AppSettings("DateFormat"))
        If (DateTime.Today.Date > ExpiryDate) Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function CreateInspectionActive(PlateNo As String, ChassisNo As String, Lane As String) As Boolean
        Dim iType As String = ""
        Dim VisitNature As String = GetVisitNature(ChassisNo)
        Try
            If (VisitNature.Equals("Repeat Visit")) Then
                iType = "R"
            ElseIf (VisitNature.Equals("Fst Visit")) Then
                iType = "I"
            End If

            Dim opExec As New connection
            Dim sqlInsertInspactionActive = opExec.ExecuteSqlCommand("insert into InspectionActive (INSPECTIONNO, chassisno, ITYPE, LANE, FEETYPE, EsInCreated, InspType) values ('" & getSerial() & "','" & ChassisNo & "' , '" & iType & "', '" & Lane & "' ,  'F', 1,  '') ")
            If (sqlInsertInspactionActive.Item1 = False) Then
                MessageBox.Show($"Failed to create InspectionActive; {sqlInsertInspactionActive.Item2}")
                Return False
            Else
                opExec.closeConnection()
            End If

            Return True

        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return False
        End Try
    End Function

    Private Function getSerial() As String
        Try
            Dim allFile As String = Handler.AppSettings()("Serial")
            Return allFile.Trim
        Catch ex As Exception
            Throw New Exception("Error getting the serial")
        End Try

    End Function

    Public Function GetVisitNature(Chassis As String) As String
        Dim Res As String = ""
        Dim VisitNature = GetLastInspectinHistoryInCurrentYear(Chassis)
        If (VisitNature.Count > 0) Then
            If (VisitNature("IType") = "I") Then
                Res = "Fst Visit"
            ElseIf (VisitNature("IType") = "R") Then
                Res = "Repeat Visit"
            Else
                Res = "Fst Visit"
            End If
        Else
            Res = "Fst Visit"
        End If

        Return Res
    End Function

    Public Function GetLastCertificateInCurrentYear(Chassis As String) As Dictionary(Of String, String)
        Dim str As String = ""
        Dim opExec As New connection
        Dim sql As String = ""
        Dim LastCertificate As New Dictionary(Of String, String)

        sql = "select * from certificate where certificatedate in (select max(certificatedate) from certificate where Chassisno='" & Chassis & "' and YEAR(certificatedate) = YEAR(CURDATE())"

        Dim reader As SqlClient.SqlDataReader = opExec.rdGetReader(sql)
        Try

            If reader.HasRows = True Then

                While reader.Read()
                    LastCertificate.Add("Chassis", reader("ChassisNo"))
                    LastCertificate.Add("Certificatedate", reader("certificatedate"))
                    LastCertificate.Add("Inspection", reader("InspectionNo"))
                    LastCertificate.Add("Lane", reader("LaneNo"))
                    LastCertificate.Add("FeeLabel", reader("FeeLabel"))
                    LastCertificate.Add("TestResult", reader("TestResult"))
                End While

            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            opExec.closeConnection()
        End Try

        Return LastCertificate
    End Function

    Public Function GetLastInspectinHistoryInCurrentYear(Chassis As String) As Dictionary(Of String, String)
        Dim str As String = ""
        Dim opExec As New connection
        Dim sql As String = ""
        Dim LastInspectionHistory As New Dictionary(Of String, String)

        sql = "select * from INSPECTIONHISTORY where TestDate in (select max(TestDate) from INSPECTIONHISTORY where Chassisno='" & Chassis & "' and YEAR(TestDate) = YEAR(GETDATE()))"

        Dim reader As SqlClient.SqlDataReader = opExec.rdGetReader(sql)
        Try

            If reader.HasRows = True Then

                While reader.Read()
                    LastInspectionHistory.Add("Chassis", reader("ChassisNo"))
                    LastInspectionHistory.Add("TestDate", reader("TestDate"))
                    LastInspectionHistory.Add("InspectionNo", reader("InspectionNo"))
                    LastInspectionHistory.Add("LaneNo", reader("LaneNo"))
                    LastInspectionHistory.Add("IType", reader("IType"))
                    LastInspectionHistory.Add("TestResult", reader("TestResult"))
                End While

            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            opExec.closeConnection()
        End Try

        Return LastInspectionHistory
    End Function

    Public Function GetLastInspectionActive(Chassis As String) As Dictionary(Of String, String)
        Dim str As String = ""
        Dim opExec As New connection
        Dim sql As String = ""
        Dim LastInspectionActive As New Dictionary(Of String, String)

        sql = "select * from InspectionActive where Chassisno='" & Chassis & "' "

        Dim reader As SqlClient.SqlDataReader = opExec.rdGetReader(sql)
        Try

            If reader.HasRows = True Then

                While reader.Read()
                    LastInspectionActive.Add("Chassis", reader("ChassisNo"))
                    LastInspectionActive.Add("InspectionNo", reader("InspectionNo"))
                    LastInspectionActive.Add("IType", reader("IType"))
                    LastInspectionActive.Add("FeeAmount", IIf(IsDBNull(reader("FeeAmount")), "", reader("FeeAmount")))
                    LastInspectionActive.Add("InspType", reader("InspType"))
                    LastInspectionActive.Add("Lane", reader("Lane"))
                    LastInspectionActive.Add("userId", IIf(IsDBNull(reader("user_fk")), "", reader("user_fk")))
                    LastInspectionActive.Add("StationName", IIf(IsDBNull(reader("StationName")), "", reader("StationName")))
                End While

            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            opExec.closeConnection()
        End Try

        Return LastInspectionActive
    End Function
End Class
