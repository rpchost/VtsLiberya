Imports System.Globalization
Imports System.IO
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

    Public Function CreateInspectionActive(PlateNo As String, ChassisNo As String, Lane As String, FeeAmount As String) As Boolean
        Dim inspType As String = ""
        Dim iType As String = ""
        Dim VisitNature As String = GetVisitNature(ChassisNo)
        Try
            ' If (VisitNature.Equals("Repeat Visit")) Then
            inspType = VisitNature '"R"
            ' ElseIf (VisitNature.Equals("Fst Visit")) Then
            ' inspType = "Y"
            '  End If

            If (Lane.Trim() = "") Then
                MessageBox.Show("Lane cannot be empty")
                Return False
            Else
                Try
                    If (Not IsNumeric(Lane) Or CInt(Lane) < 1 Or CInt(Lane) > 12) Then
                        MessageBox.Show("You have to choose a valid Lane")
                        Return False
                    End If
                Catch ex As Exception
                    MessageBox.Show("You have to choose a valid Lane")
                    Return False
                End Try
            End If

            If (InspectionActiveExist(ChassisNo) = True) Then
                MessageBox.Show("There is already an inspection active for this vehicle")
                Return False
            End If

            Dim opExec As New connection
            Dim sqlInsertInspactionActive = opExec.ExecuteSqlCommand("insert into InspectionActive (INSPECTIONNO, ChassisNo, FeeLabel, iType, Lane, FEETYPE, EsInCreated, InspType,UPDATEDATE,HOSTNAME,USERNAME,stationname) values ('" & getSerial("active") & "','" & ChassisNo & "','" & FeeAmount & "' , 'I', '" & Lane & "' ,  'F', 1,  '" & inspType & "','" & Handler.GenerateTimeZone() & "','" & System.Environment.MachineName & "','" & Handler.InspectorID & "','Liberya') ")
            If (sqlInsertInspactionActive.Item1 = False) Then
                MessageBox.Show($"Failed to create InspectionActive; {sqlInsertInspactionActive.Item2}")
                Return False
            Else
                IncrementSerial("active")
                opExec.closeConnection()
            End If

            Return True

        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return False
        End Try
    End Function

    Public Function InspectionActiveExist(ChassisNo As String) As Boolean
        Dim opExec As New connection
        Dim reader As SqlClient.SqlDataReader = opExec.rdGetReader("Select * from InspectionActive where Chassisno = '" & ChassisNo & "' ")
        Try
            If reader.HasRows = True Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MessageBox.Show($"Error in InspectionActiveExist{ex.Message}")
        Finally
            opExec.closeConnection()
        End Try
    End Function

    Public Function DefectCodeExists(InspectionNo As String, VisualCode As String) As Boolean
        Dim opExec As New connection
        Dim reader As SqlClient.SqlDataReader = opExec.rdGetReader("Select * from Defects_tmp where InspectionNo = '" & InspectionNo & "' and DefectDesc like '%" & VisualCode & "%' ")
        Try
            If reader.HasRows = True Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MessageBox.Show($"Error in DefectCodeExists {ex.Message}")
        Finally
            opExec.closeConnection()
        End Try
    End Function

    Public Function CanCompleteAndSave(Lane As Integer, Section As Integer) As Boolean
        Dim result = False
        If (IsNumeric(Lane) And IsNumeric(Section)) Then
            If (Lane > 0 And Lane <= 11) Then
                If (Section = 3) Then
                    result = True
                End If
            ElseIf (Lane = 12) Then
                result = True
            End If
        End If
        Return result
    End Function

    Public Function GetSections(SC_TYP As String, SC_IN_OUT As String, Optional Lane As String = "") As Dictionary(Of String, String)

        Dim dt As New Data.DataTable
        Dim conn As New connection
        Dim opExec As New connection
        Dim dc As New Dictionary(Of String, String)

        Dim reader As SqlClient.SqlDataReader = opExec.rdGetReader("Select * from SECTION_LABELS where SC_TYP = '" & SC_TYP & "' and SC_IN_OUT = '" & SC_IN_OUT & "' ")
        Try
            If reader.HasRows = True Then

                While reader.Read()
                    Dim loc = IIf(Lane = "", reader("SC_DIR_LOC"), reader("SC_DIR_LOC") & "\" & Lane)
                    dc.Add(reader("SC_LBL"), loc)
                End While

                Return dc

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            opExec.closeConnection()
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

    Private Function getSerialDB() As String
        Dim str As String = ""
        Dim opExec As New connection
        Dim sql As String = ""
        Dim LastCertificate As New Dictionary(Of String, String)

        sql = "select SerialTest from Settings"

        Dim reader As SqlClient.SqlDataReader = opExec.rdGetReader(sql)
        Try

            If reader.HasRows = True Then

                While reader.Read()
                    Return reader("SerialTest")
                End While
            Else
                Return ""
            End If

        Catch ex As Exception
            MessageBox.Show("getSerial Error: " & ex.Message)
        Finally
            opExec.closeConnection()
        End Try
    End Function

    Private Function getSerialFromFile() As String
        Try
            Dim allFile As String = File.ReadAllText("C:/Visual/Serial.txt")
            Return allFile.Trim
        Catch ex As Exception
            Throw New Exception("Error getting the serial")
        End Try
    End Function

    Private Function IncrementSerial(SerialLabel As String) As Int64

        Dim opExec As New connection
        Dim LastCertificate As New Dictionary(Of String, String)
        Dim serialValue As Int64

        Dim Sql = "select Serial from Serial where SerialLabel = '" & SerialLabel & "' "

        Dim reader As SqlClient.SqlDataReader = opExec.rdGetReader(Sql)
        Try

            If reader.HasRows = True Then
                reader.Read()
                serialValue = CInt(reader("Serial"))
            Else
                serialValue = 0
            End If

            Dim sqlIncrement As String = ""
            If (serialValue > 0) Then
                sqlIncrement = "update serial set serial = " & serialValue + 1 & "  where SerialLabel = '" & SerialLabel & "' "
            Else
                sqlIncrement = "insert into serial (serial, SerialLabel) values (" & serialValue + 1 & ", '" & SerialLabel & "')"
            End If

            If (opExec.ExecuteSqlCommand(sqlIncrement).Item1 = False) Then
                MessageBox.Show($"Failed to create increment serial for " & SerialLabel)
                Return False
            Else
                Return True
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            opExec.closeConnection()
        End Try
    End Function

    Private Function getSerial(SerialLabel As String) As String

        Dim opExec As New connection
        Dim LastCertificate As New Dictionary(Of String, String)

        Dim Sql = "select SerialSequence, Serial from Serial where SerialLabel = '" & SerialLabel & "' "

        Dim reader As SqlClient.SqlDataReader = opExec.rdGetReader(Sql)
        Try

            If reader.HasRows = True Then

                reader.Read()
                Return reader("SerialSequence") & reader("Serial")

            Else
                Throw New Exception("Error generating a serial for " & SerialLabel)
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            opExec.closeConnection()
        End Try

    End Function

    Public Function GetVisitNature(Chassis As String) As String
        Dim Res As String = ""
        Dim VisitNature = GetLastInspectinHistoryInCurrentYear(Chassis) 'GetLastCertificateInCurrentYear(Chassis)
        If (VisitNature.Count > 0) Then
            If (VisitNature("TestResult") = "P") Then
                Res = "RP"
            Else
                Res = "R"
            End If
        Else
            Res = "Y"
        End If

        Return Res
    End Function

    'Public Function GetiType(Chassis As String) As String
    '    Dim str As String = ""
    '    Dim opExec As New connection
    '    Dim sql As String = ""
    '    Dim LastInspectionHistory As New Dictionary(Of String, String)

    '    sql = "select * from INSPECTIONHISTORY where UPDATEDATE in (select max(UPDATEDATE) from INSPECTIONHISTORY where Chassisno='" & Chassis & "' and YEAR(UPDATEDATE) = YEAR(GETDATE()))"

    '    Dim reader As SqlClient.SqlDataReader = opExec.rdGetReader(sql)
    '    Try

    '        If reader.HasRows = True Then

    '            While reader.Read()
    '                LastInspectionHistory.Add("Chassis", reader("ChassisNo"))
    '                LastInspectionHistory.Add("UPDATEDATE", reader("UPDATEDATE"))
    '                LastInspectionHistory.Add("InspectionNo", reader("InspectionNo"))
    '                LastInspectionHistory.Add("LaneNo", reader("LaneNo"))
    '                LastInspectionHistory.Add("InspType", reader("InspType"))
    '                LastInspectionHistory.Add("TestResult", reader("TestResult"))
    '            End While

    '        End If

    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message)
    '    Finally
    '        opExec.closeConnection()
    '    End Try

    '    Return LastInspectionHistory
    'End Function

    Public Function GetLastCertificateInCurrentYear(Chassis As String) As Dictionary(Of String, String)
        Dim str As String = ""
        Dim opExec As New connection
        Dim sql As String = ""
        Dim LastCertificate As New Dictionary(Of String, String)

        sql = "select * from certificate where certificatedate in (select max(certificatedate) from certificate where Chassisno='" & Chassis & "' and YEAR(certificatedate) = YEAR(GETDATE()))"

        Dim reader As SqlClient.SqlDataReader = opExec.rdGetReader(sql)
        Try

            If reader.HasRows = True Then

                While reader.Read()
                    LastCertificate.Add("Chassis", IIf(IsDBNull(reader("ChassisNo")), "", reader("ChassisNo")))
                    LastCertificate.Add("Certificatedate", IIf(IsDBNull(reader("certificatedate")), "", reader("certificatedate")))
                    LastCertificate.Add("CertificateNo", IIf(IsDBNull(reader("CertificateNo")), "", reader("CertificateNo")))
                    LastCertificate.Add("Lane", IIf(IsDBNull(reader("LaneNo")), "", reader("LaneNo")))
                    LastCertificate.Add("FeeLabel", IIf(IsDBNull(reader("FeeLabel")), "", reader("FeeLabel")))
                    LastCertificate.Add("TestResult", IIf(IsDBNull(reader("TestResult")), "", reader("TestResult")))
                End While

            End If

        Catch ex As Exception
            MessageBox.Show("GetLastCertificateInCurrentYear Error: " & ex.Message)
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

        sql = "select * from INSPECTIONHISTORY where UPDATEDATE in (select max(UPDATEDATE) from INSPECTIONHISTORY where Chassisno='" & Chassis & "' and YEAR(UPDATEDATE) = YEAR(GETDATE()))"

        Dim reader As SqlClient.SqlDataReader = opExec.rdGetReader(sql)
        Try

            If reader.HasRows = True Then

                While reader.Read()
                    LastInspectionHistory.Add("Chassis", IIf(IsDBNull(reader("ChassisNo")), "", reader("ChassisNo")))
                    LastInspectionHistory.Add("UPDATEDATE", IIf(IsDBNull(reader("UPDATEDATE")), "", reader("UPDATEDATE")))
                    LastInspectionHistory.Add("Inspection", IIf(IsDBNull(reader("Inspectionno")), "", reader("Inspectionno")))
                    LastInspectionHistory.Add("LaneNo", IIf(IsDBNull(reader("Lane")), "", reader("Lane")))
                    LastInspectionHistory.Add("InspType", IIf(IsDBNull(reader("InspType")), "", reader("InspType")))
                    LastInspectionHistory.Add("TestResult", IIf(IsDBNull(reader("TestResult")), "", reader("TestResult")))
                End While

            End If

        Catch ex As Exception
            MessageBox.Show("GetLastInspectinHistoryInCurrentYear Error: " & ex.Message)
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
                    LastInspectionActive.Add("FeeLabel", IIf(IsDBNull(reader("FeeLabel")), "", reader("FeeLabel")))
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
