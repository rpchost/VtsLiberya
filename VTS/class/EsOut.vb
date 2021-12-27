Imports System.IO

Public Class EsOut
    Public Function CreateTitleHeaderEOF(ByVal HeaderType As String, ByVal EsType As String, ByVal EsIO As String, ByVal FileName As String, ByVal VisitType As String, Optional EsVehTyp As String = "") As Boolean
        Dim Res As Boolean = False
        'Dim sw As StreamWriter = Nothing

        Try
            If (Not FileName.Contains(".txt")) Then FileName = FileName & ".txt"

            Dim strFile As String = Handler.GetEsLocation(EsIO, EsVehTyp) & "\" & FileName

            'If EsOut skeleton exist then exit
            If (File.Exists(strFile)) Then
                Return True
            End If

            Using sw = New StreamWriter(strFile, True)
                If (HeaderType.Equals("TitleHeader")) Then
                    sw.WriteLine(Title(EsType, FileName))
                    sw.WriteLine(setEsOut(FileName))
                    sw.WriteLine(EOF())
                End If
                Res = True
                sw.Close()
            End Using
        Catch ex As IOException
            Res = False
            Handler.Log("Error creating " & EsVehTyp & EsIO & " file " & ". " & FileName & " HeaderType = " & HeaderType, Handler.GenerateTimeZone(), "EsOut.CreateTitleHeader", ex.Message)
        End Try
        Return Res
    End Function

    Public Function getCalculatedVtsGrType(ByVal VtsCode As String, ByRef VtsCodeEquation As String) As String
        Dim conn As New connection
        Dim Sql As String = "Select CLC_VTS_TYP from CALCULATED_VTS_CODES where CLC_VTS_CODE = '" & VtsCode & "'"
        Dim dt As DataTable = conn.ExecuteReaderdt(Sql)
        If dt.Rows.Count > 0 Then
            Return dt.Rows(0).Item("CLC_VTS_TYP")
        Else
            Return "-1"
        End If
    End Function

    Private Function getKeyValue(strFile As String, strKey As String) As String
        Dim str As String = ""
        Dim Res As String = ""

        Dim i As Integer = strFile.IndexOf(strKey)

        While (Not strFile(i) = vbCr)
            Res = Res & strFile(i)
            i = i + 1
        End While
        Return Res
    End Function

    Public Function SetVtsCodes(ByVal FileName As String, dc As Dictionary(Of String, String)) As Boolean

        If (Not FileName.Contains(".txt")) Then FileName = FileName & ".txt"

        Dim strFile As String = Handler.GetEsLocation("OUT", "VTS") & "\" & FileName

        Dim line As String = ""
        Dim allFile As String = IO.File.ReadAllText(strFile)

        'We iterate thru each vts code in Esout VTS and we change its value taken from Ryme file
        For Each iKey In dc.Keys
            If (allFile.Contains(iKey.Trim)) Then allFile = allFile.Replace(getKeyValue(allFile, iKey.Trim), iKey.Trim & "= " & dc(iKey).Replace(",", "."))
        Next

        Dim sw As New StreamWriter(strFile, False)

        sw.Write(allFile)
        sw.Close()
        sw.Dispose()

        Return True
    End Function

    Public Function getRymeValueFromFile(RymePath As String, FileName As String, RymeCode As String) As String

        If (Not FileName.Contains(".txt")) Then FileName = FileName & ".txt"

        Dim strFile As String = RymePath & "\" & FileName
        Dim line As String

        Dim Res As String = ""

        Using sr As StreamReader = New System.IO.StreamReader(strFile)

            Dim dc As New Dictionary(Of String, String)
            Dim arr() As String = Nothing

            Do Until sr.EndOfStream
                line = sr.ReadLine()
                If (line.Contains(RymeCode)) Then
                    arr = line.Split("=")
                    Res = arr(1).Replace(",", ".")
                    Exit Do
                End If
            Loop

            sr.Close()

        End Using

        Return Res
    End Function

    Public Function Title(ByVal VisitType As String, ByVal FileName As String, Optional EsVehTyp As String = "") As String
        Dim strTitle As String = ""

        If (FileName.Contains(".txt")) Then FileName = FileName.Replace(".txt", "")

        If (VisitType = "I") Then
            strTitle = strTitle & "; Test value-File in ASCII-Format for SQL-Server" & vbCrLf
            strTitle = strTitle & "; Date : " & Handler.GenerateTimeZone() & " Time " & Handler.GenerateTimeZone().ToString("HH:mm") & vbCrLf
            strTitle = strTitle & "; FileName : " & FileName & ".txt" & vbCrLf
            strTitle = strTitle & "; ----------------------------------------------" & vbCrLf
        End If
        Return strTitle
    End Function

    Public Function getVtsValueFromCode(ByVal FileName As String, Code As String) As String
        Dim line As String
        If (Not FileName.Contains(".txt")) Then FileName = FileName & ".txt"
        Using sr As StreamReader = New System.IO.StreamReader(Handler.GetEsLocation("OUT", "VTS") & "\" & FileName)
            line = sr.ReadLine()
            While (Not line.Contains(Code))
                line = sr.ReadLine()
            End While

            If (line.Contains(Code)) Then
                Dim arr() As String
                arr = line.Split("=")
                Return arr(1).Trim
            Else
                Return ""
            End If
            sr.Close()
        End Using
    End Function

    Private Function getSectionLabel(ByVal intSectionLabel As Integer) As String
        Dim str As String = ""
        Dim opExec As New connection
        Dim sql As String = ""
        Dim arr As New ArrayList

        sql = "select VTS_TYP_GR from VTS_TYPES_GR where VTS_ORDR_GR = " & intSectionLabel

        Dim reader As SqlClient.SqlDataReader = opExec.rdGetReader(sql)
        Try

            If reader.HasRows = True Then

                reader.Read()

                Return reader("VTS_TYP_GR")

            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            opExec.closeConnection()
        End Try
    End Function

    Public Function getCalVtsBr(ByVal CalcVtsCode As String) As String
        Dim str As String = ""
        Dim opExec As New connection
        Dim sql As String = ""
        Dim arr As New ArrayList

        sql = "select CLC_VTS_TYP from CALCULATED_VTS_CODES where CLC_VTS_CODE = '" & CalcVtsCode & "' "

        Dim reader As SqlClient.SqlDataReader = opExec.rdGetReader(sql)
        Try

            If reader.HasRows = True Then

                reader.Read()

                Return reader("CLC_VTS_TYP")

            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            opExec.closeConnection()
        End Try
    End Function

    Private Function setEsOut(FileName As String) As String

        Dim strRes As String = ""
        Dim opExec As New connection
        Dim sql As String = ""
        Dim arr As New ArrayList

        sql = "select * from VTS_TYPES_GR order by VTS_ORDR_GR asc"

        Dim reader As SqlClient.SqlDataReader = opExec.rdGetReader(sql)
        Try

            If reader.HasRows = True Then

                While reader.Read()
                    strRes = strRes & setEsOutSection(reader("VTS_ORDR_GR"), FileName)
                End While

            End If

            Return strRes

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            opExec.closeConnection()
        End Try
    End Function

    Private Function getHeaderData(ByVal Plate As String) As Dictionary(Of String, String)
        Dim opExec As New connection
        Dim dc As New Dictionary(Of String, String)

        Dim reader As SqlClient.SqlDataReader = opExec.rdGetReader("select * from Cardaftar where plateno = '" & Plate & "'")
        Try
            If reader.HasRows = True Then
                reader.Read()
                dc("Chassis") = IIf(IsDBNull(reader("Chassisno")), "", reader("Chassisno"))
                dc("Address") = IIf(IsDBNull(reader("ADDRESS1")), "", reader("ADDRESS1"))
                dc("DateManufactured") = IIf(IsDBNull(reader("DATEMANUFACTURED")), "", reader("DATEMANUFACTURED"))
                dc("Engine") = IIf(IsDBNull(reader("EnginePower")), "", reader("EnginePower"))
                dc("Make") = IIf(IsDBNull(reader("MAKE")), "", reader("MAKE"))
                dc("Manufacturer") = IIf(IsDBNull(reader("MANUFACTURER")), "", reader("MANUFACTURER"))
                dc("FueType") = IIf(IsDBNull(reader("FuelType")), "", reader("FuelType"))
                dc("Phone") = IIf(IsDBNull(reader("Phone")), "", reader("Phone"))
                dc("Owner") = IIf(IsDBNull(reader("OWNER")), "", reader("OWNER"))
                dc("Color") = IIf(IsDBNull(reader("Color")), "", reader("Color"))
                dc("Model") = IIf(IsDBNull(reader("Model")), "", reader("Model"))
                dc("Weight") = IIf(IsDBNull(reader("WeightTotal")), "", reader("WeightTotal"))
                dc("VehicleCategory") = IIf(IsDBNull(reader("VehicleCategory")), "", reader("VehicleCategory"))
            End If
            Return dc
        Catch ex As Exception
            MessageBox.Show("Error in getHeaderData")
        Finally
            opExec.closeConnection()
        End Try
    End Function

    Private Function setEsOutSection(ByVal intSectionLabel As Integer, ByVal FileName As String) As String
        Dim str As String = ""
        Dim opExec As New connection
        Dim sql As String = ""
        Dim arr As New ArrayList
        Dim SectionLabel As String = getSectionLabel(intSectionLabel)

        If (FileName.Contains(".txt")) Then FileName = FileName.Replace(".txt", "")

        Dim strSectionHeader As String = ""
        If (SectionLabel = "Header") Then
            strSectionHeader = "[HEADER]" & vbCrLf
        Else
            strSectionHeader = vbCrLf & "; ----------" & SectionLabel & vbCrLf
        End If

        Dim headerData As Dictionary(Of String, String)
        If (intSectionLabel = 1) Then headerData = getHeaderData(FileName)

        sql = "select * from CodesMappingLookup where type = " & intSectionLabel & " order by MahaCode asc"

        Dim reader As SqlClient.SqlDataReader = opExec.rdGetReader(sql)
        Try

            If reader.HasRows = True Then

                While reader.Read()
                    If (reader("MahaCode").trim = "10100") Then
                        strSectionHeader = strSectionHeader & reader("MahaCode").trim & "= " & FileName & vbCrLf
                    ElseIf (reader("MahaCode").trim = "10102") Then
                        strSectionHeader = strSectionHeader & reader("MahaCode").trim & "= " & Handler.Chassis & vbCrLf
                    ElseIf (reader("MahaCode").trim = "10010") Then
                        strSectionHeader = strSectionHeader & reader("MahaCode").trim & "= " & Handler.Lane & vbCrLf
                    ElseIf (reader("MahaCode").trim = "10304") Then
                        strSectionHeader = strSectionHeader & reader("MahaCode").trim & "= " & Handler.InspectionNo & vbCrLf
                    ElseIf (reader("MahaCode").trim = "10104") Then
                        strSectionHeader = strSectionHeader & reader("MahaCode").trim & "= " & headerData("Engine") & vbCrLf
                    ElseIf (reader("MahaCode").trim = "10050") Then
                        strSectionHeader = strSectionHeader & reader("MahaCode").trim & "= " & headerData("Owner") & vbCrLf
                    ElseIf (reader("MahaCode").trim = "10202") Then
                        strSectionHeader = strSectionHeader & reader("MahaCode").trim & "= " & headerData("DateManufactured") & vbCrLf
                    ElseIf (reader("MahaCode").trim = "10201") Then
                        strSectionHeader = strSectionHeader & reader("MahaCode").trim & "= " & headerData("Make") & vbCrLf
                    ElseIf (reader("MahaCode").trim = "10200") Then
                        strSectionHeader = strSectionHeader & reader("MahaCode").trim & "= " & headerData("Manufacturer") & vbCrLf
                    ElseIf (reader("MahaCode").trim = "10109") Then
                        strSectionHeader = strSectionHeader & reader("MahaCode").trim & "= " & headerData("Color") & vbCrLf
                    ElseIf (reader("MahaCode").trim = "10400") Then
                        strSectionHeader = strSectionHeader & reader("MahaCode").trim & "= " & headerData("Weight") & vbCrLf
                    ElseIf (reader("MahaCode").trim = "10191") Then
                        strSectionHeader = strSectionHeader & reader("MahaCode").trim & "= " & headerData("VehicleCategory") & vbCrLf
                        'ElseIf (reader("MahaCode").trim = "10303") Then
                        '    strSectionHeader = strSectionHeader & reader("MahaCode").trim & "= " & headerData("VehicleCategory") & vbCrLf
                    ElseIf (reader("MahaCode").trim = "10057") Then
                        strSectionHeader = strSectionHeader & reader("MahaCode").trim & "= " & IIf(Handler.InspType = "Y", "Fst Visit", "Repeat Visit") & vbCrLf
                    Else
                        strSectionHeader = strSectionHeader & reader("MahaCode").trim & "= " & vbCrLf
                    End If


                End While

            End If

            Return strSectionHeader

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            opExec.closeConnection()
        End Try
    End Function

    'Public Function Header(ByVal VisitType As String, ByVal FileName As String, Optional EsVehTyp As String = "") As String
    '    Dim strHeader As String = "[HEADER]" & vbCrLf

    '    If (VisitType = "I") Then
    '        strHeader = strHeader & "10003= " & vbCrLf
    '        strHeader = strHeader & "10010= " & Handler.Lane & vbCrLf
    '        strHeader = strHeader & "10053= " & Handler.userId & vbCrLf
    '        strHeader = strHeader & "10057= Fst Visit" & vbCrLf
    '        strHeader = strHeader & "10058= " & Handler.GenerateTimeZone() & vbCrLf
    '        strHeader = strHeader & "10100= " & Handler.Plate & vbCrLf
    '        strHeader = strHeader & "10102= " & Handler.Chassis & vbCrLf
    '        strHeader = strHeader & "10105= " & vbCrLf
    '        strHeader = strHeader & "10109= " & vbCrLf
    '        strHeader = strHeader & "10111= " & vbCrLf
    '        strHeader = strHeader & "10190= " & vbCrLf
    '        strHeader = strHeader & "10191= " & vbCrLf
    '        strHeader = strHeader & "10195= " & vbCrLf
    '        strHeader = strHeader & "10196= " & vbCrLf
    '        strHeader = strHeader & "10200= " & vbCrLf
    '        strHeader = strHeader & "10201= " & vbCrLf
    '        strHeader = strHeader & "10202= " & vbCrLf
    '        strHeader = strHeader & "10204= " & vbCrLf
    '        strHeader = strHeader & "10212= " & vbCrLf
    '        strHeader = strHeader & "10227= " & vbCrLf
    '        strHeader = strHeader & "10121= " & vbCrLf
    '        strHeader = strHeader & "10131= " & vbCrLf
    '        strHeader = strHeader & "10110= " & vbCrLf
    '        strHeader = strHeader & "10050= " & vbCrLf
    '        strHeader = strHeader & "10251= " & vbCrLf
    '        strHeader = strHeader & "10208= " & vbCrLf
    '        strHeader = strHeader & "10054= " & vbCrLf
    '        strHeader = strHeader & "10303= " & vbCrLf
    '        strHeader = strHeader & "10076= " & vbCrLf
    '        strHeader = strHeader & "10072= " & vbCrLf
    '        strHeader = strHeader & "10071= " & vbCrLf
    '    End If

    '    Return strHeader
    'End Function

    Public Function RymeSection(ByVal SectionLabelHeader As String, ByVal dcRymeCodesSection As Dictionary(Of String, String), Optional EsVehTyp As String = "") As String
        Dim strRymeCode As String = "; ----------" & SectionLabelHeader & vbCrLf

        For Each iKey As String In dcRymeCodesSection.Keys
            Dim value As String = dcRymeCodesSection(iKey)
            strRymeCode = strRymeCode & iKey & "=" & value & vbCrLf
        Next
        Return strRymeCode
    End Function

    Public Function VtsSections(ByVal SectionLabelHeader As String, ByVal dcVtsCodesSection As Dictionary(Of String, String), Optional EsVehTyp As String = "") As String
        Dim strRymeCode As String = "; ----------" & SectionLabelHeader & vbCrLf

        For Each iKey As String In dcVtsCodesSection.Keys
            Dim value As String = dcVtsCodesSection(iKey)
            strRymeCode = strRymeCode & iKey & "=" & value & vbCrLf
        Next

        Return strRymeCode
    End Function

    Public Function GetVtsTypesGroups() As ArrayList
        Dim str As String = ""
        Dim opExec As New connection
        Dim sql As String = ""
        Dim arr As New ArrayList

        sql = "select CLC_VTS_TYP from calculated_vts_codes group by CLC_VTS_TYP"

        Dim reader As SqlClient.SqlDataReader = opExec.rdGetReader(sql)
        Try

            If reader.HasRows = True Then

                While reader.Read()
                    arr.Add(reader("CLC_VTS_TYP"))
                End While

            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            opExec.closeConnection()
        End Try
        Return arr
    End Function

    Public Function EOF() As String
        Dim strEOF As String = "; --------- End of File ---------------------" & vbCrLf
        strEOF = strEOF & "999999=END OF FILE" & vbCrLf
        strEOF = strEOF & "[ENDOFFILE]" & vbCrLf
        strEOF = strEOF & "999999=END OF FILE" & vbCrLf
        Return strEOF
    End Function
End Class
