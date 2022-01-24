Imports System.Data.SqlClient
Imports System.IO
Imports System.Text.RegularExpressions
Imports Microsoft.Extensions.Configuration

Public Class Handler

    Public Shared dTDefects As New DataTable
    Public Shared dTDefectsClone As New DataTable
    Public Shared dTDelCodes As New DataTable
    Public Shared InspectionNo As String
    Public Shared Engine As String
    Public Shared InspNo As String
    Public Shared InspectorID As String
    Public Shared Plate As String
    Public Shared Chassis As String
    Public Shared Address As String
    Public Shared DateManufactured As String
    Public Shared Make As String
    Public Shared Manufacturer As String
    Public Shared Color As String
    Public Shared FuelType As String
    Public Shared Weight As String
    Public Shared Phone As String
    Public Shared Owner As String
    Public Shared Lane As String
    Public Shared Section As String
    Public Shared StationName As String
    Public Shared userId As String
    Public Shared GroupName As String
    Public Shared GroupID As String
    Public Shared LastInspectionNo As String
    Public Shared InspectorGroupID As Integer
    Public Shared dSet As DataSet
    Public Shared IType As Char ' I : First / C : Cancelled
    Public Shared InspType As Char ' Y : First / R : Repeat / A : Aborted
    Public Shared RymeEmissionStat As String
    Public Shared RymeLightStat As String
    Public Shared Result As String
    Public Shared RymeSuspensionStat As String
    Public Shared SectionsLabelsOut As Dictionary(Of String, String)
    Public Shared SectionsLabelsIn As Dictionary(Of String, String)
    Public Shared dtProcessRyme As DataTable
    Public Shared dcVtsCodes As Dictionary(Of String, String)
    Public Shared heartBeat As Integer

    Public Shared Function AppSettings() As IConfiguration
        Dim builder = New ConfigurationBuilder()
        builder.AddJsonFile("./appsettings.json", True)
        Return builder.Build()
    End Function

    Public Shared Function ClearShared() As Boolean

        Try
            dTDefects.Dispose()
        Catch ex As Exception
        End Try
        Try
            dTDefectsClone.Dispose()
        Catch ex As Exception
        End Try
        Try
            dTDelCodes.Dispose()
        Catch ex As Exception
        End Try


        InspectionNo = Nothing

        InspNo = Nothing
        InspectorID = Nothing
        Plate = Nothing
        Chassis = Nothing
        Lane = Nothing
        StationName = Nothing
        userId = Nothing
        InspectorGroupID = Nothing
        dSet = Nothing
        IType = Nothing
        InspType = Nothing
        RymeEmissionStat = Nothing
        RymeLightStat = Nothing
        RymeSuspensionStat = Nothing
        SectionsLabelsOut = Nothing
        SectionsLabelsIn = Nothing
        dtProcessRyme = Nothing
        dcVtsCodes = Nothing

        Return True
    End Function

    Public Shared Function PopulateDefectTbl(ByVal DefectDesc As String, ByVal InspectionNo As String, ByVal DefectDate As DateTime) As DataTable

        If (Not dTDefects.Columns.Contains("ID")) Then
            Dim dtC As DataColumn = dTDefects.Columns.Add("ID", GetType(Int32))
            dtC.AutoIncrement = True
            dtC.AutoIncrementSeed = 1
            dtC.AutoIncrementStep = 1
        End If

        If (Not dTDefects.Columns.Contains("DefectDesc")) Then dTDefects.Columns.Add("DefectDesc", GetType(String))
        If (Not dTDefects.Columns.Contains("DefectDate")) Then dTDefects.Columns.Add("DefectDate", GetType(DateTime))
        If (Not dTDefects.Columns.Contains("InspectionNo")) Then dTDefects.Columns.Add("InspectionNo", GetType(String))

        dTDefects.Rows.Add(0, DefectDesc, DefectDate, InspectionNo)
    End Function

    Public Shared Function PopulateDefectFromDB(ByVal InspectionNo As String) As DataTable

        Dim opExec As New connection
        Dim sql As String = ""
        Dim dTDefects As New DataTable

        If (Not dTDefects.Columns.Contains("ID")) Then
            Dim dtC As DataColumn = dTDefects.Columns.Add("ID", GetType(Int32))
            dtC.AutoIncrement = True
            dtC.AutoIncrementSeed = 1
            dtC.AutoIncrementStep = 1
        End If

        If (Not dTDefects.Columns.Contains("DefectDesc")) Then dTDefects.Columns.Add("DefectDesc", GetType(String))
        If (Not dTDefects.Columns.Contains("DefectDate")) Then dTDefects.Columns.Add("DefectDate", GetType(DateTime))
        If (Not dTDefects.Columns.Contains("InspectionNo")) Then dTDefects.Columns.Add("InspectionNo", GetType(String))

        sql = "select * from DEFECTS_Tmp where inspectionno = '" & InspectionNo & "' "

        Dim reader As SqlClient.SqlDataReader = opExec.rdGetReader(sql)
        Try

            If reader.HasRows = True Then

                While reader.Read()
                    dTDefects.Rows.Add(reader("ID"), reader("DefectDesc"), reader("DefectDate"), reader("InspectionNo"))
                End While

            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            opExec.closeConnection()
        End Try

        Return dTDefects
    End Function

    Public Shared Function getInspection(ByVal Plate As String) As String

        Dim opExec As New connection
        Dim sql As String = ""
        Dim dc As New DataTable

        sql = "select Inspectionno from inspectionActive i inner join cardaftar c on i.chassisno = c.chassisno  where c.plateno = '" & Plate & "' "

        Dim reader As SqlClient.SqlDataReader = opExec.rdGetReader(sql)
        Try

            If reader.HasRows = True Then

                reader.Read()
                Return reader("Inspectionno")

            Else

                Return ""
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            opExec.closeConnection()
        End Try
    End Function

    Public Shared Function getDefectsCount(ByVal InspectionNo As String) As Integer

        Dim opExec As New connection
        Dim sql As String = ""
        Dim dc As New DataTable

        sql = "select Count(*) as count from defects_tmp  where inspectionno = '" & InspectionNo & "' "

        Dim reader As SqlClient.SqlDataReader = opExec.rdGetReader(sql)
        Try

            If reader.HasRows = True Then

                reader.Read()
                Return reader("count")

            Else
                Return 0

            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            opExec.closeConnection()
        End Try
    End Function



    Public Shared Function GetMachineCodes() As Dictionary(Of String, String)

        Dim str As String = ""
        Dim opExec As New connection
        Dim sql As String = ""
        Dim dc As New Dictionary(Of String, String)

        sql = "select * from MACHINE_CODES"

        Dim reader As SqlClient.SqlDataReader = opExec.rdGetReader(sql)
        Try

            If reader.HasRows = True Then

                While reader.Read()
                    dc.Add(reader("MACH_CODE"), reader("MACH_TYPE"))
                End While

            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            opExec.closeConnection()
        End Try

        Return dc
    End Function

    Public Function GetCalculatedVtsCodes() As Dictionary(Of String, String)

        Dim str As String = ""
        Dim opExec As New connection
        Dim sql As String = ""
        Dim dc As New Dictionary(Of String, String)

        sql = "select * from CALCULATED_VTS_CODES"

        Dim reader As SqlClient.SqlDataReader = opExec.rdGetReader(sql)
        Try
            If reader.HasRows = True Then

                While reader.Read()
                    dc.Add(reader("CLC_VTS_CODE"), reader("CLC_VTS_TYP"))
                End While

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            opExec.closeConnection()
        End Try

        Return dc

    End Function

    Public Shared Function GetCalculatedVtsCodes2D() As Dictionary(Of String, Dictionary(Of String, String))

        Dim str As String = ""
        Dim opExec As New connection
        Dim sql As String = ""
        Dim dc As New Dictionary(Of String, Dictionary(Of String, String))
        Dim NestedDc As Dictionary(Of String, String)
        Dim arr() As String

        sql = "select * from CALCULATED_VTS_CODES"

        Dim reader As SqlClient.SqlDataReader = opExec.rdGetReader(sql)
        Try

            If reader.HasRows = True Then

                While reader.Read()
                    arr = reader("CLC_EQUATION").ToString.Split("-")
                    NestedDc = New Dictionary(Of String, String)
                    ''If (Not NestedDc.ContainsKey(arr(0))) Then
                    NestedDc.Add(arr(0), arr(1))
                    dc.Add(reader("CLC_VTS_CODE"), NestedDc)
                    ''End If

                End While

            End If

            Return dc


        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            opExec.closeConnection()
        End Try

        Return dc
    End Function

    Public Shared Function GetEquationsVtsCodes(VtsTyp As String) As Dictionary(Of String, String)
        Dim str As String = ""
        Dim opExec As New connection
        Dim sql As String = ""
        Dim dc As New Dictionary(Of String, String)

        sql = "select * from CALCULATED_VTS_CODES where CLC_VTS_TYP = '" & VtsTyp & "' "

        Dim reader As SqlClient.SqlDataReader = opExec.rdGetReader(sql)
        Try
            If reader.HasRows = True Then

                While reader.Read()
                    dc.Add(reader("CLC_VTS_CODE"), reader("CLC_EQUATION"))
                End While

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            opExec.closeConnection()
        End Try

        Return dc
    End Function

    Public Function PopulateVtsCode(VtsType As String, RymeCodeValue As String) As Dictionary(Of String, String)
        Dim dc As New Dictionary(Of String, String)
        dc.Add(RymeCodeValue, VtsType)

        Return dc
    End Function

    Public Shared Function CalculateVtsCodes(VtsTyp As String) As Dictionary(Of String, String)

        Dim dcVts As New Dictionary(Of String, String)
        dcVts = GetEquationsVtsCodes(VtsTyp)
        Dim dcVtsRes As New Dictionary(Of String, String)

        For Each ikeyCalcVts In dcVts.Keys

            dcVtsRes.Add(ikeyCalcVts, ApplyEquation(dcVts(ikeyCalcVts), VtsTyp))

        Next

        Return dcVtsRes
    End Function

    Public Shared Function ApplyEquation(Equation As String, MACH_TYP As String) As Double

        Dim strCode1 As String = ""
        Dim strCode2 As String = ""
        Dim strCode3 As String = ""
        Dim strCode4 As String = ""
        Dim strCode5 As String = ""
        Dim strCode6 As String = ""
        Dim strCode7 As String = ""
        Dim strCode8 As String = ""

        Dim dblVal1 As Double = 0
        Dim dblVal2 As Double = 0
        Dim dblVal3 As Double = 0
        Dim dblVal4 As Double = 0
        Dim dblVal5 As Double = 0
        Dim dblVal6 As Double = 0
        Dim dblVal7 As Double = 0
        Dim dblVal8 As Double = 0

        Dim Max As Double = 0

        Dim pattern As String = "\[.*?\]"
        Dim mc As System.Text.RegularExpressions.MatchCollection
        Dim m As System.Text.RegularExpressions.Match

        Dim regx As New System.Text.RegularExpressions.Regex(pattern)

        If regx.IsMatch(Equation, pattern) Then

            If (MACH_TYP = "BRAKE") Then
                mc = regx.Matches(Equation)
                For index As Integer = 0 To mc.Count - 1

                    If (index = 0) Then
                        strCode1 = Replace(mc(index).Value, "[", "")
                        strCode1 = Replace(strCode1, "]", "")
                        dblVal1 = GetRymeValue(strCode1)

                    End If
                    If (index = 1) Then
                        strCode2 = Replace(mc(index).Value, "[", "")
                        strCode2 = Replace(strCode2, "]", "")
                        dblVal2 = GetRymeValue(strCode2)
                    End If

                Next

                Max = Math.Max(dblVal1, dblVal2)

                Return Math.Round((dblVal1 - dblVal2) * 100 / Max, 4)

            End If

            If (MACH_TYP = "DECELERATION PARK") Then
                mc = regx.Matches(Equation)
                For index As Integer = 0 To mc.Count - 1

                    If (index = 0) Then
                        strCode1 = Replace(mc(index).Value, "[", "")
                        strCode1 = Replace(strCode1, "]", "")
                        dblVal1 = GetRymeValue(strCode1)
                    End If
                    If (index = 1) Then
                        strCode2 = Replace(mc(index).Value, "[", "")
                        strCode2 = Replace(strCode2, "]", "")
                        dblVal2 = GetRymeValue(strCode2)
                    End If
                    If (index = 2) Then
                        strCode3 = Replace(mc(index).Value, "[", "")
                        strCode3 = Replace(strCode3, "]", "")
                        dblVal3 = GetRymeValue(strCode3)
                    End If
                    If (index = 3) Then
                        strCode4 = Replace(mc(index).Value, "[", "")
                        strCode4 = Replace(strCode4, "]", "")
                        dblVal4 = GetRymeValue(strCode4)
                    End If
                    If (index = 4) Then
                        strCode5 = Replace(mc(index).Value, "[", "")
                        strCode5 = Replace(strCode5, "]", "")
                        dblVal5 = GetRymeValue(strCode5)
                    End If
                    If (index = 5) Then
                        strCode6 = Replace(mc(index).Value, "[", "")
                        strCode6 = Replace(strCode6, "]", "")
                        dblVal6 = GetRymeValue(strCode6)
                    End If

                Next

                Return Math.Round(((dblVal1 + dblVal2) / (dblVal5 + dblVal6 + dblVal7 + dblVal8)) / (100 / 9.81), 4)
            End If

            If (MACH_TYP = "DECELERATION SERVICE") Then
                mc = regx.Matches(Equation)
                For index As Integer = 0 To mc.Count - 1

                    If (index = 0) Then
                        strCode1 = Replace(mc(index).Value, "[", "")
                        strCode1 = Replace(strCode1, "]", "")
                        dblVal1 = GetRymeValue(strCode1)
                    End If
                    If (index = 1) Then
                        strCode2 = Replace(mc(index).Value, "[", "")
                        strCode2 = Replace(strCode2, "]", "")
                        dblVal2 = GetRymeValue(strCode2)
                    End If
                    If (index = 2) Then
                        strCode3 = Replace(mc(index).Value, "[", "")
                        strCode3 = Replace(strCode3, "]", "")
                        dblVal3 = GetRymeValue(strCode3)
                    End If
                    If (index = 3) Then
                        strCode4 = Replace(mc(index).Value, "[", "")
                        strCode4 = Replace(strCode4, "]", "")
                        dblVal4 = GetRymeValue(strCode4)
                    End If
                    If (index = 4) Then
                        strCode5 = Replace(mc(index).Value, "[", "")
                        strCode5 = Replace(strCode5, "]", "")
                        dblVal5 = GetRymeValue(strCode5)
                    End If
                    If (index = 5) Then
                        strCode6 = Replace(mc(index).Value, "[", "")
                        strCode6 = Replace(strCode6, "]", "")
                        dblVal6 = GetRymeValue(strCode6)
                    End If
                    If (index = 6) Then
                        strCode7 = Replace(mc(index).Value, "[", "")
                        strCode7 = Replace(strCode7, "]", "")
                        dblVal7 = GetRymeValue(strCode7)
                    End If
                    If (index = 7) Then
                        strCode8 = Replace(mc(index).Value, "[", "")
                        strCode8 = Replace(strCode8, "]", "")
                        dblVal8 = GetRymeValue(strCode8)
                    End If
                Next

                Return Math.Round(((dblVal1 + dblVal2 + dblVal3 + dblVal4) / (dblVal5 + dblVal6 + dblVal7 + dblVal8)) / (100 / 9.81), 4)

            End If

            If (MACH_TYP = "OPACI") Then
                mc = regx.Matches(Equation)
                For index As Integer = 0 To mc.Count - 1

                    If (index = 0) Then
                        strCode1 = Replace(mc(index).Value, "[", "")
                        strCode1 = Replace(strCode1, "]", "")
                        dblVal1 = GetRymeValue(strCode1)
                    End If
                    If (index = 1) Then
                        strCode2 = Replace(mc(index).Value, "[", "")
                        strCode2 = Replace(strCode2, "]", "")
                        dblVal2 = GetRymeValue(strCode2)
                    End If
                    If (index = 2) Then
                        strCode3 = Replace(mc(index).Value, "[", "")
                        strCode3 = Replace(strCode3, "]", "")
                        dblVal3 = GetRymeValue(strCode3)
                    End If
                    If (index = 3) Then
                        strCode4 = Replace(mc(index).Value, "[", "")
                        strCode4 = Replace(strCode4, "]", "")
                        dblVal4 = GetRymeValue(strCode4)
                    End If
                    If (index = 4) Then
                        strCode5 = Replace(mc(index).Value, "[", "")
                        strCode5 = Replace(strCode5, "]", "")
                        dblVal5 = GetRymeValue(strCode5)
                    End If
                    If (index = 5) Then
                        strCode6 = Replace(mc(index).Value, "[", "")
                        strCode6 = Replace(strCode6, "]", "")
                        dblVal6 = GetRymeValue(strCode6)
                    End If
                    If (index = 6) Then
                        strCode7 = Replace(mc(index).Value, "[", "")
                        strCode7 = Replace(strCode7, "]", "")
                        dblVal7 = GetRymeValue(strCode7)
                    End If
                    If (index = 7) Then
                        strCode8 = Replace(mc(index).Value, "[", "")
                        strCode8 = Replace(strCode8, "]", "")
                        dblVal8 = GetRymeValue(strCode8)
                    End If

                Next

                Return Math.Round((dblVal1 + dblVal2 + dblVal3 + dblVal4 + dblVal5 + dblVal6 + dblVal7 + dblVal8) / 8, 4)

            End If
        End If
    End Function

    Public Shared Function GetRymeValue(RymeCode As String) As Double

        Dim dblVal As Double = -1
        Dim arr() As String

        For Each ikey In dcVtsCodes.Keys

            If (ikey.Contains(RymeCode)) Then
                arr = ikey.Split(":")
                dblVal = arr(1).Replace(",", ".")
                Exit For
            End If

        Next

        Return dblVal
    End Function

    Public Shared Function PopulateDelCodesTbl(ByVal CertificateNo As String, ByVal Deletedate As DateTime, ByVal Inspector As String, ByVal Lane As Integer, ByVal Section As Integer, ByVal DeletedCode As String) As DataTable

        If (Not dTDelCodes.Columns.Contains("ID")) Then
            Dim dtC As DataColumn = dTDelCodes.Columns.Add("ID", GetType(Int32))
            dtC.AutoIncrement = True
            dtC.AutoIncrementSeed = 1
            dtC.AutoIncrementStep = 1

        End If

        If (Not dTDelCodes.Columns.Contains("CertificateNo")) Then dTDelCodes.Columns.Add("CertificateNo", GetType(String))
        If (Not dTDelCodes.Columns.Contains("Deletedate")) Then dTDelCodes.Columns.Add("Deletedate", GetType(DateTime))
        If (Not dTDelCodes.Columns.Contains("Inspector")) Then dTDelCodes.Columns.Add("Inspector", GetType(String))
        If (Not dTDelCodes.Columns.Contains("Lane")) Then dTDelCodes.Columns.Add("Lane", GetType(Integer))
        If (Not dTDelCodes.Columns.Contains("Section")) Then dTDelCodes.Columns.Add("Section", GetType(Integer))
        If (Not dTDelCodes.Columns.Contains("DeletedCode")) Then dTDelCodes.Columns.Add("DeletedCode", GetType(String))

        dTDelCodes.Rows.Add(0, CertificateNo, Deletedate, Inspector, Lane, Section, DeletedCode)
    End Function

    Public Shared Function FillInspNo(InspectionNo As String) As String
        Dim res As String = ""

        If (InspectionNo.Length > 0) Then
            If (InspectionNo.Contains("B-C-")) Then
                res = "Inspection No = B-I-" & InspectionNo.Substring(42, InspectionNo.Length - 42)
            Else
                res = InspectionNo
            End If
        Else
            res = ""
        End If

        Return res
    End Function

    Public Function ConvertRymeToMahaCode(RymeCode As String) As String

        Dim res As String = ""
        Dim dt As New Data.DataTable
        Dim conn As New connection

        dt = conn.ExecuteReaderdt("Select MahaCode from CodesMappingLookup where RymeCode = '" & RymeCode & "' ")
        If dt.Rows.Count > 0 Then
            res = dt.Rows(0).Item("MahaCode")
        Else
            res = ""
        End If

        Return res
    End Function

    Public Shared Function ConvertMahaToRymeCode(MahaCode As String) As String
        Dim res As String = ""
        Dim dt As New Data.DataTable
        Dim conn As New connection

        dt = conn.ExecuteReaderdt("Select RymeCode from CodesMappingLookup where MahaCode = '" & MahaCode & "' ")
        If dt.Rows.Count > 0 Then
            res = dt.Rows(0).Item("RymeCode")
        Else
            res = ""
        End If

        Return res
    End Function

    Public Shared Function deleteDefectsRow(ColName As String, al As ArrayList) As Boolean

        Dim i As Integer = 0
        'Dim dt = dTDefects
        Dim dt As DataTable

        Dim str As String = ""
        If (al.Count = 0) Then
            Return True
        End If
        For j = 0 To al.Count - 1
            If (j = al.Count - 1) Then
                str = str & " DefectDesc <> '" & al(j) & "' "
            Else
                str = str & " DefectDesc <> '" & al(j) & "'  and "
            End If
        Next
        If (dTDefects.Select(str).Count > 0) Then
            dt = dTDefects.Select(str).CopyToDataTable()
            dTDefects = dt
        Else
            dTDefects.Rows.Clear()
        End If

        Return True
    End Function

    Public Shared Function getDefectCodeResult(DefectCode As String) As String
        Dim opExec As New connection
        Dim sql = "Select VisualResult from VisualLookup where VisualCodePnt = '" & DefectCode & "' "

        Dim reader As SqlClient.SqlDataReader = opExec.rdGetReader(sql)
        Try

            If reader.HasRows = True Then

                reader.Read()

                Return reader("VisualResult")

            Else
                Return ""
            End If

        Catch ex As Exception
            Return -1
        Finally
            opExec.closeConnection()
        End Try
    End Function

    Public Shared Function CopyDT(dTSource As DataTable) As Boolean
        Try

            dTDefectsClone.Columns.Add("inspectionno")
            dTDefectsClone.Columns.Add("DEFECTDATE")
            dTDefectsClone.Columns.Add("DEFECTDESC")
            dTDefectsClone.Columns.Add("ID")

        Catch ex As Exception
            dTDefectsClone.Rows.Clear()
        End Try

        dTDefectsClone.TableName = "Table1"

        For Each dr In dTSource.Rows
            dTDefectsClone.Rows.Add(dr.item("inspectionno"), dr.item("DEFECTDATE"), dr.item("DEFECTDESC"))
        Next
    End Function

    Public Shared Function GetComputerName() As String
        Dim ComputerName As String = ""

        If (GetChars(System.Environment.MachineName)) <> "LN-PC" Then
            ComputerName = GetComputerNameFromFile()
        Else
            ComputerName = System.Environment.MachineName
        End If
        Return ComputerName
    End Function

    Private Shared Function GetChars(input As String) As String
        Return New String(input.Where(Function(c) Not Char.IsDigit(c)).ToArray())
    End Function

    Public Shared Function GetPatterName() As String

        Dim res As String = ""
        Dim dt As New Data.DataTable
        Dim conn As New connection

        dt = conn.ExecuteReaderdt("Select ComputerPattern  from Settings")
        If dt.Rows.Count > 0 Then
            res = dt.Rows(0).Item("ComputerPattern")
        Else
            res = ""
        End If

        Return res
    End Function

    Public Shared Function GetTimerInterval() As String

        Dim res As String = ""
        Dim dt As New Data.DataTable
        Dim conn As New connection

        dt = conn.ExecuteReaderdt("Select TimerInterval  from Settings")
        If dt.Rows.Count > 0 Then
            res = IIf(IsDBNull(dt.Rows(0).Item("TimerInterval")), "", dt.Rows(0).Item("TimerInterval"))
        Else
            res = ""
        End If

        Return res
    End Function

    Private Shared Function GetPrefix() As String

        Dim res As String = ""
        Dim dt As New Data.DataTable
        Dim conn As New connection

        dt = conn.ExecuteReaderdt("Select ComputerPatternPrefix from Settings ")
        If dt.Rows.Count > 0 Then
            res = dt.Rows(0).Item("ComputerPatternPrefix")
        Else
            res = ""
        End If

        Return res
    End Function

    Public Shared Sub GetLaneSection()
        Try
            Dim str As String
            Dim dbl As Double = 0.0
            Dim i As Integer = 0

            Dim strComputerName = GetComputerName()
            Dim arr() As String = strComputerName.Split("-")
            Lane = arr(0)
            Section = arr(1)

            Lane = IIf(IsNumeric(Lane.Replace("LN", "")), Lane.Replace("LN", ""), "-1")
            Section = IIf(IsNumeric(Section.Replace("PC", "")), Section.Replace("PC", ""), "-1")
        Catch ex As Exception
            Lane = "-1"
            Section = "-1"
        End Try
    End Sub

    Public Shared Function GetLaneSectionFromFile()
        Try
            Dim str As String
            Dim dbl As Double = 0.0
            Dim i As Integer = 0

            Dim strComputerName = GetComputerNameFromFile()
            Dim arr() As String = strComputerName.Split("-")
            Lane = arr(0)
            Section = arr(1)

            Lane = IIf(IsNumeric(Lane.Replace("LN", "")), Lane.Replace("LN", ""), "-1")
            Section = IIf(IsNumeric(Section.Replace("PC", "")), Section.Replace("PC", ""), "-1")
        Catch ex As Exception
            Lane = "-1"
            Section = "-1"
        End Try
    End Function

    Private Shared Function GetComputerNameFromFile() As String
        Try
            Dim allFile As String = File.ReadAllText("C:/Visual/ComputerName.txt")
            Return allFile.Trim
        Catch ex As Exception
            Throw New Exception("Error getting the serial")
        End Try
    End Function

    Public Shared Function GetEsCodeValue(plate As String, EsIo As String, EsTyp As String, code As String) As String

        Dim strFile As String = GetEsLocation(EsIo, EsTyp) & "\" & plate & ".txt"
        Dim line As String = ""
        Dim res As String = ""

        If (IO.File.Exists(strFile)) Then

            Using sr As StreamReader = New System.IO.StreamReader(strFile)

                Dim arr() As String

                Do Until sr.EndOfStream
                    line = sr.ReadLine()
                    If (line.Contains(code)) Then
                        arr = line.Split("=")
                        res = arr(1)
                        Exit Do
                    End If
                Loop

                sr.Close()

            End Using
        End If
        Return res
    End Function

    Public Shared Function ApplyDbToHtDefect(tableName As String, InspectionNo As String) As DataTable

        Dim dt As New DataTable
        Dim opExec As New connection
        Dim dr As DataRow

        Dim reader As SqlClient.SqlDataReader = opExec.rdGetReader("select ID, DefectDesc,InspectionNo,DEFECTDATE from " & tableName & " where InspectionNo = '" & InspectionNo & "' ")
        Try

            If reader.HasRows = True Then

                dt.Columns.Add("ID")
                dt.Columns.Add("DefectDesc")

                While reader.Read()
                    dr = dt.NewRow

                    dr("ID") = reader("ID")
                    dr("DefectDesc") = reader("DefectDesc")
                    'dr("CERTIFICATENO") = reader("CERTIFICATENO")
                    dt.Rows.Add(dr)
                End While

            End If

            Return dt

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            opExec.closeConnection()
        End Try
    End Function

    Public Shared Function ApplyDataTableToDefects(dT As DataTable) As Boolean
        Dim opExec As New connection
        Dim res As Boolean = True

        For Each dr As DataRow In dT.Rows

            If (opExec.ExecuteSqlCommand("Insert into Defects_tmp (DefectDesc, inspectionNo, DefectDate) values ('" & dr("DefectDesc") & "', '" & Handler.InspectionNo & "', CONVERT(datetime,'" & GenerateTimeZone().ToString("dd/MM/yyyy HH:mm") & "',103))", True).Item1 = False) Then
                res = False
                Exit Function
            End If
        Next

        Return res
    End Function

    Public Function ApplyDataTableToDB(dT As DataTable, tableName As String, field1 As String, field2 As String, field3 As String, field4 As String, Type1 As String, Type2 As String, Type3 As String, type4 As String, capacity1 As Integer, capacity2 As Integer, capacity3 As Integer, capacity4 As Integer) As Boolean

        Dim DA As SqlDataAdapter = New SqlDataAdapter
        Dim Parm As New SqlParameter

        Dim tp1 As SqlDbType
        Dim tp2 As SqlDbType
        Dim tp3 As SqlDbType
        Dim tp4 As SqlDbType

        If (Type1 = "string") Then tp1 = SqlDbType.NVarChar
        If (Type1 = "int") Then tp1 = SqlDbType.Int
        If (Type1 = "date") Then tp1 = SqlDbType.DateTime

        If (Type2 = "string") Then tp2 = SqlDbType.NVarChar
        If (Type2 = "int") Then tp2 = SqlDbType.Int
        If (Type2 = "date") Then tp2 = SqlDbType.DateTime

        If (Type3 = "string") Then tp3 = SqlDbType.NVarChar
        If (Type3 = "int") Then tp3 = SqlDbType.Int
        If (Type3 = "date") Then tp3 = SqlDbType.DateTime

        If (type4 = "string") Then tp4 = SqlDbType.NVarChar
        If (type4 = "int") Then tp4 = SqlDbType.Int
        If (type4 = "date") Then tp4 = SqlDbType.DateTime

        Dim strSql As String = ""
        strSql = "Insert Into " & tableName & "( "

        If (Not field1.Equals("")) Then strSql = strSql + field1
        If (Not field2.Equals("")) Then strSql = strSql + "," + field2
        If (Not field3.Equals("")) Then strSql = strSql + "," + field3
        If (Not field4.Equals("")) Then strSql = strSql + "," + field4

        strSql = strSql + ")values("

        If (Not field1.Equals("")) Then
            strSql = strSql + "@fld1"
        End If
        If (Not field2.Equals("")) Then
            strSql = strSql + "," + "@fld2"
        End If
        If (Not field3.Equals("")) Then
            strSql = strSql + "," + "@fld3"
        End If
        If (Not field4.Equals("")) Then
            strSql = strSql + "," + "@fld4"
        End If

        strSql = strSql + ")"
        Dim conn As New connection

        DA.InsertCommand = New SqlCommand(strSql, New SqlClient.SqlConnection(conn.connetionString))

        If (Not field1.Equals("")) Then

            DA.InsertCommand.Parameters.Add(New SqlParameter("@fld1", tp1, capacity1, field1))
        End If
        If (Not field2.Equals("")) Then

            DA.InsertCommand.Parameters.Add(New SqlParameter("@fld2", tp2, capacity2, field2))
        End If
        If (Not field3.Equals("")) Then

            DA.InsertCommand.Parameters.Add(New SqlParameter("@fld3", tp3, capacity3, field3))
        End If
        If (Not field4.Equals("")) Then

            DA.InsertCommand.Parameters.Add(New SqlParameter("@fld4", tp4, capacity4, field4))
        End If

        Dim dSet As New DataSet

        ' CopyDT(Handler.dTDefects)

        ' dSet.Tables.Add(dTDefectsClone)
        DA.TableMappings.Add(tableName, "Table1")

        DA.Update(dSet, tableName)
    End Function

    Public Function ApplyDtDefectsToDB(dT As DataTable, tableName As String, field1 As String, Type1 As String, capacity1 As Integer) As Boolean

        Dim DA As SqlDataAdapter = New SqlDataAdapter
        Dim Parm As New SqlParameter

        Dim tp1 As SqlDbType

        If (Type1 = "string") Then tp1 = SqlDbType.NVarChar
        If (Type1 = "int") Then tp1 = SqlDbType.Int
        If (Type1 = "date") Then tp1 = SqlDbType.DateTime

        Dim strSql As String = ""
        strSql = "Insert Into " & tableName & "( "

        If (Not field1.Equals("")) Then strSql = strSql + field1

        strSql = strSql + ")values("

        If (Not field1.Equals("")) Then
            strSql = strSql + "@fld1"
        End If

        strSql = strSql + ")"
        Dim conn As New connection

        DA.InsertCommand = New SqlCommand(strSql, New SqlClient.SqlConnection(conn.connetionString))

        If (Not field1.Equals("")) Then

            DA.InsertCommand.Parameters.Add(New SqlParameter("@fld1", tp1, capacity1, field1))
        End If

        Dim dSet As New DataSet

        CopyDT(dTDefects)
        'Dim dtCopy As DataTable = dT.Copy()
        dSet.Tables.Add(dTDefectsClone)
        DA.TableMappings.Add(tableName, "Table1")

        DA.Update(dSet, tableName)
    End Function

    Public Shared Function ApplyDataTableDelCodesToDB(dT As DataTable, tableName As String, field1 As String, field2 As String, field3 As String, field4 As String, field5 As String, field6 As String, Type1 As String, Type2 As String, Type3 As String, type4 As String, type5 As String, type6 As String, capacity1 As Integer, capacity2 As Integer, capacity3 As Integer, capacity4 As Integer, capacity5 As Integer, capacity6 As Integer) As Boolean

        Dim DA As SqlDataAdapter = New SqlDataAdapter
        Dim Parm As New SqlParameter

        Dim tp1 As SqlDbType
        Dim tp2 As SqlDbType
        Dim tp3 As SqlDbType
        Dim tp4 As SqlDbType
        Dim tp5 As SqlDbType
        Dim tp6 As SqlDbType

        If (Type1 = "string") Then tp1 = SqlDbType.NVarChar
        If (Type1 = "int") Then tp1 = SqlDbType.Int
        If (Type1 = "date") Then tp1 = SqlDbType.DateTime

        If (Type2 = "string") Then tp2 = SqlDbType.NVarChar
        If (Type2 = "int") Then tp2 = SqlDbType.Int
        If (Type2 = "date") Then tp2 = SqlDbType.DateTime

        If (Type3 = "string") Then tp3 = SqlDbType.NVarChar
        If (Type3 = "int") Then tp3 = SqlDbType.Int
        If (Type3 = "date") Then tp3 = SqlDbType.DateTime

        If (type4 = "string") Then tp4 = SqlDbType.NVarChar
        If (type4 = "int") Then tp4 = SqlDbType.Int
        If (type4 = "date") Then tp4 = SqlDbType.DateTime

        If (type5 = "string") Then tp5 = SqlDbType.NVarChar
        If (type5 = "int") Then tp5 = SqlDbType.Int
        If (type5 = "date") Then tp5 = SqlDbType.DateTime

        If (type6 = "string") Then tp6 = SqlDbType.NVarChar
        If (type6 = "int") Then tp6 = SqlDbType.Int
        If (type6 = "date") Then tp6 = SqlDbType.DateTime

        Dim strSql As String = ""
        strSql = "Insert Into " & tableName & "( "

        If (Not field1.Equals("")) Then strSql = strSql + field1
        If (Not field2.Equals("")) Then strSql = strSql + "," + field2
        If (Not field3.Equals("")) Then strSql = strSql + "," + field3
        If (Not field4.Equals("")) Then strSql = strSql + "," + field4
        ' If (Not field5.Equals("")) Then strSql = strSql + "," + field5
        If (Not field6.Equals("")) Then strSql = strSql + "," + field6

        strSql = strSql + ")values("

        If (Not field1.Equals("")) Then
            strSql = strSql + "@fld1"
        End If
        If (Not field2.Equals("")) Then
            strSql = strSql + "," + "@fld2"
        End If
        If (Not field3.Equals("")) Then
            strSql = strSql + "," + "@fld3"
        End If
        If (Not field4.Equals("")) Then
            strSql = strSql + "," + "@fld4"
        End If
        If (Not field5.Equals("")) Then
            ' strSql = strSql + "," + "@fld5"
        End If
        If (Not field6.Equals("")) Then
            strSql = strSql + "," + "@fld6"
        End If

        strSql = strSql + ")"
        Dim conn As New connection

        DA.InsertCommand = New SqlCommand(strSql, New SqlClient.SqlConnection(conn.connetionString))

        If (Not field1.Equals("")) Then
            DA.InsertCommand.Parameters.Add(New SqlParameter("@fld1", tp1, capacity1, field1))
        End If
        If (Not field2.Equals("")) Then
            DA.InsertCommand.Parameters.Add(New SqlParameter("@fld2", tp2, capacity2, field2))
        End If
        If (Not field3.Equals("")) Then
            DA.InsertCommand.Parameters.Add(New SqlParameter("@fld3", tp3, capacity3, field3))
        End If
        If (Not field4.Equals("")) Then
            DA.InsertCommand.Parameters.Add(New SqlParameter("@fld4", tp4, capacity4, field4))
        End If
        If (Not field5.Equals("")) Then
            ' DA.InsertCommand.Parameters.Add(New SqlParameter("@fld5", tp5, capacity5, field5))
        End If
        If (Not field6.Equals("")) Then
            DA.InsertCommand.Parameters.Add(New SqlParameter("@fld6", tp6, capacity6, field6))
        End If

        Dim dSet As New DataSet()
        Dim dtCopy As DataTable = dT.Copy()

        dSet.Tables.Add(dtCopy)
        DA.TableMappings.Add(tableName, "Table1")

        DA.AcceptChangesDuringUpdate = True
        DA.Update(dSet, tableName)

        'dT.Dispose()
        dtCopy.Dispose()
    End Function

    Public Shared Function GenerateTimeZone() As DateTime
        Dim timeZoneInfo As TimeZoneInfo
        Dim dateTime As DateTime
        If (GetTimeZone() = Nothing Or GetTimeZone().Trim = "") Then
            Throw New InvalidTimeZoneException("You have to add a valid timezone in settings table")
            Exit Function
        End If
        timeZoneInfo = TimeZoneInfo.FindSystemTimeZoneById(GetTimeZone()) 'Ex: "Middle East Standard Time"
        dateTime = TimeZoneInfo.ConvertTime(Date.Now, timeZoneInfo)
        Return dateTime
    End Function

    Public Function GetEsLocation(ByVal EsInOut As String) As String ' EsInOut = EsInPath or EsOutPath

        Dim str As String = ""
        Dim opExec As New connection

        Dim reader As SqlClient.SqlDataReader = opExec.rdGetReader("select " & EsInOut & " from Settings")
        Try

            If reader.HasRows = True Then
                reader.Read()
                Return reader(EsInOut)
            Else
                Return ""
            End If

        Catch ex As Exception
            Return ex.Message
        Finally
            opExec.closeConnection()
        End Try
    End Function

    Public Shared Function GetTimeZone() As String

        Dim str As String = ""
        Dim opExec As New connection

        Dim reader As SqlClient.SqlDataReader = opExec.rdGetReader("select TimeZone from Settings")
        Try

            If reader.HasRows = True Then
                reader.Read()
                Return reader("TimeZone")
            Else
                Return ""
            End If

        Catch ex As Exception
            Return ex.Message
        Finally
            opExec.closeConnection()
        End Try

    End Function

    Public Shared Function GetEsLocation(ByVal EsFileIO As String, ByVal EsType As String, Optional ByVal EsLbl As String = "") As String ' EsInOut = EsInPath or EsOutPath

        Dim str As String = ""
        Dim opExec As New connection
        Dim sql As String = ""
        sql = "select * from SECTION_LABELS where SC_TYP = '" & EsType & "' and SC_IN_OUT = '" & EsFileIO & "'  "
        If (EsLbl <> "") Then sql = sql + " and SC_LBL = " & EsLbl

        Dim reader As SqlClient.SqlDataReader = opExec.rdGetReader(sql)
        Try
            If reader.HasRows = True Then
                reader.Read()

                Return reader("SC_DIR_LOC")
            Else
                Return ""
            End If

        Catch ex As Exception
            Return ex.Message
        Finally
            opExec.closeConnection()
        End Try

    End Function

    Public Shared Function Log(ByVal LG_DSC As String, ByVal LG_DATETIME As DateTime, ByVal LG_SRC As String, ByVal LG_ERR As String) As Boolean
        Dim opExec As New connection
        Dim sqlCommand = opExec.ExecuteSqlCommand("Insert into VTS_RYME_LOGGER (LG_DSC,LG_DATETIME,LG_SRC,LG_ERR) values ('" & LG_DSC & "','" & GenerateTimeZone() & "','" & LG_SRC & "','" & LG_ERR & "')", True)
        If (sqlCommand.Item1 = False) Then
            MessageBox.Show("Error with logger " & LG_DSC & " " & LG_DATETIME & " " & sqlCommand.Item2)
        End If
        opExec.closeConnection()
        Return True
    End Function

    Public Shared Function UserFk(ByVal UserName As String) As Integer

        Dim str As String = ""
        Dim opExec As New connection
        Dim sql As String = ""
        sql = "select ID from Users where name = '" & UserName & "'  "

        Dim reader As SqlClient.SqlDataReader = opExec.rdGetReader(sql)
        Try

            If reader.HasRows = True Then

                reader.Read()

                Return reader("ID")

            Else

                Return -1

            End If

        Catch ex As Exception
            Return ex.Message
        Finally
            opExec.closeConnection()
        End Try

    End Function

    Public Function GroupFk(ByVal GrpLabel As String) As Integer
        Dim conn As New connection
        Dim Sql As String = "select ID from GROUPS where LABEL='" & GrpLabel & "' "
        Dim dt As DataTable = conn.ExecuteReaderdt(Sql)
        If dt.Rows.Count > 0 Then
            Return dt.Rows(0).Item("ID")
        Else
            Return -1
        End If
    End Function

    Public Function GroupLbl(ByVal GrpFk As Integer) As String
        Dim conn As New connection
        Dim Sql As String = "select LABEL from GROUPS where ID=" & GrpFk
        Dim dt As DataTable = conn.ExecuteReaderdt(Sql)
        If dt.Rows.Count > 0 Then
            Return dt.Rows(0).Item("LABEL")
        Else
            Return "-1"
        End If
    End Function

    Public Shared Function Group(ByVal userName As String) As String
        Dim conn As New connection
        Dim Sql As String = "select Label from GROUPS inner join users on users.Group_FK = Groups.ID where users.Name  = '" & userName & "' "
        Dim dt As DataTable = conn.ExecuteReaderdt(Sql)
        If dt.Rows.Count > 0 Then
            Return dt.Rows(0).Item("LABEL")
        Else
            Return "-1"
        End If
    End Function
End Class

