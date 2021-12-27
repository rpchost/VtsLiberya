Imports System.IO

Public Class MahaRymeProcessor

    Public EmissionPath As String
    Public LightPath As String
    Public SuspensionPath As String

    Private Sub MahaRymeProcessor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim helper As New Helpers
        If (helper.Expires()) Then
            Dim Answer = MessageBox.Show("System Expired, Please contact administrator.", "Expired !!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If (Answer = MsgBoxResult.Yes Or Answer = MsgBoxResult.No) Then
                Dispose()
            End If
        End If

        Me.Width = My.Computer.Screen.WorkingArea.Size.Width
        Me.Height = My.Computer.Screen.WorkingArea.Size.Height
        Me.Top = My.Computer.Screen.WorkingArea.Top
        Me.Left = My.Computer.Screen.WorkingArea.Left
        header.Width = My.Computer.Screen.WorkingArea.Size.Width
        header.Height = 100

        grdRymeProcess.Width = My.Computer.Screen.WorkingArea.Size.Width
        grdRymeProcess.Left = 0

        Me.WindowState = FormWindowState.Maximized

        DataGridView1.RowHeadersDefaultCellStyle.BackColor = Color.Silver
        DataGridView1.RowHeadersDefaultCellStyle.ForeColor = Color.White

        lblStatus.Text = "Loading Sections .... "

        If (IsNothing(Handler.SectionsLabelsOut)) Then
            If (PopulateSectionsLabels()) Then lblStatus.Text = "Sections Loaded Successfully .... "
        End If

        Dim dt As New Data.DataTable
        Dim conn As New connection

        lblStatus.Text = "Loading Processes ...."

        DataGridView1.RowHeadersDefaultCellStyle.BackColor = Color.Silver
        DataGridView1.RowHeadersDefaultCellStyle.ForeColor = Color.White

        FillData()
        lblHeartBeat.Text = "0"
        lblHeartBeat.Refresh()

        Dim Interval As String = Handler.GetTimerInterval()
        Timer1.Interval = IIf(Interval = "", 10000, Interval)
        lblInterval.Text = Interval & " ms"
        Timer1.Start()
    End Sub

    Private Function PopulateSectionsLabels() As Boolean

        Dim dt As New Data.DataTable
        Dim conn As New connection
        Dim opExec As New connection
        Dim dcOut As New Dictionary(Of String, String)
        Dim dcIn As New Dictionary(Of String, String)

        Dim reader As SqlClient.SqlDataReader = opExec.rdGetReader("Select * from SECTION_LABELS where SC_TYP = 'RYME' and SC_IN_OUT = 'OUT' ")
        Try
            If reader.HasRows = True Then

                While reader.Read()

                    If (reader("SC_IN_OUT").trim.Equals("OUT")) Then
                        dcOut.Add(reader("SC_LBL"), reader("SC_DIR_LOC"))
                        lblSectionsDisplay.Text = lblSectionsDisplay.Text & reader("SC_LBL") & vbCrLf
                        lblSectionsDsc.Text = lblSectionsDsc.Text & reader("SC_DSC") & vbCrLf
                    End If

                    If (reader("SC_IN_OUT").trim.Equals("IN")) Then dcIn.Add(reader("SC_LBL"), reader("SC_DIR_LOC"))

                End While

                Handler.SectionsLabelsOut = dcOut
                Handler.SectionsLabelsIn = dcIn

                Return True

            End If
        Catch ex As Exception
            Return False
            MessageBox.Show(ex.Message)
        Finally
            opExec.closeConnection()
        End Try
    End Function

    Private Function ProcessRymeFiles() As Boolean

        ' Timer1.Stop()
        Try
            Dim Es As New EsOut
            If (Not (Handler.SectionsLabelsOut Is Nothing)) Then
                For Each iKey As String In Handler.SectionsLabelsOut.Keys
                    Dim value As String = Handler.SectionsLabelsOut(iKey)

                    For Each folder In New DirectoryInfo(value).GetDirectories()

                        For Each file As IO.FileInfo In folder.GetFiles 'IO.DirectoryInfo(value).GetFiles

                            If (file.FullName.Contains("SKIPPED")) Then
                                Continue For
                            End If

                            If (ProcessEsOut(folder.FullName, file.Name, iKey)) Then
                                Handler.Log(file.Name & " Processed successfully for Section : " & folder.FullName & ". InspectionNo = " & Es.getVtsValueFromCode(file.Name, "10304"), Handler.GenerateTimeZone().ToString("dd/MM/yyyy HH:mm"), "VTS RYME PROCESS", "Success")
                            Else
                                Handler.Log(file.Name & " Processed Unsuccessfully for Section : " & folder.FullName & "\" & file.Name, Handler.GenerateTimeZone().ToString("dd/MM/yyyy HH: mm"), "VTS RYME PROCESS", "Failure")
                            End If
                            Handler.heartBeat += 1
                            lblHeartBeat.Text = Handler.heartBeat
                            lblHeartBeat.Refresh()
                        Next
                    Next

                Next
            End If

            FillData()

            Return True
        Catch ex As Exception
            Return False
        End Try

        'Timer1.Start()

    End Function

    Private Function FillData() As Boolean
        Dim opExec As New connection
        Dim dt = New DataTable
        Dim sqlCondition As String = ""

        If (txtPlate.Text.Trim <> "") Then
            sqlCondition = " and LG_DSC like '%" & txtPlate.Text.Trim & "%' "
        End If
        If (txtInspectionNo.Text.Trim <> "") Then
            sqlCondition = sqlCondition & " and LG_DSC like '%" & txtInspectionNo.Text.Trim & "%' "
        End If
        If (txtDate.Text.Trim <> "") Then
            sqlCondition = sqlCondition & " and LG_DATETIME = CONVERT(datetime,'" & DateTime.Parse(txtDate.Text) & "',103) "
        End If
        If (cmbStatus.Text <> "") Then
            sqlCondition = sqlCondition & " And LG_ERR = '" & cmbStatus.Text & "' "
        End If

        Dim reader As SqlClient.SqlDataReader = opExec.rdGetReader("select ID, LG_DSC as DESCRIPTION, LG_DATETIME As DATE, LG_SRC as SOURCE, LG_ERR as STATUS from VTS_RYME_LOGGER where LG_SRC = 'VTS RYME PROCESS' " & sqlCondition & " order by ID desc")

        Try
            If reader.HasRows = True Then
                dt.Load(reader)
                grdRymeProcess.AutoGenerateColumns = True
                grdRymeProcess.DataSource = dt
                grdRymeProcess.Columns("ID").Width = 50
                grdRymeProcess.Columns("DESCRIPTION").Width = 800
                grdRymeProcess.Refresh()
            Else
                txtPlate.Text = ""
                txtInspectionNo.Text = ""
                txtDate.Text = ""
                cmbStatus.Text = ""
            End If

            Return True

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            opExec.closeConnection()
        End Try
    End Function

    'Private Function LoadVehiclesFiles() As DataTable
    '    Dim dtRyme As DataTable = New DataTable
    '    Dim value As String = ""
    '    dtRyme.Columns.Add("VEHICLE PLATE")
    '    For Each iKey As String In Handler.SectionsLabelsOut.Keys
    '        value = Handler.SectionsLabelsOut(iKey)
    '        dtRyme.Columns.Add(iKey)
    '    Next

    '    Dim i As Integer = 0

    '    value = Handler.SectionsLabelsOut(Handler.SectionsLabelsOut.Keys.First)

    '    For Each file As IO.FileInfo In New IO.DirectoryInfo(value).GetFiles
    '        Dim dr As DataRow = dtRyme.NewRow
    '        dr(0) = file.Name
    '        For Each iKey As String In Handler.SectionsLabelsOut.Keys
    '            value = Handler.SectionsLabelsOut(iKey)
    '            If (IO.File.Exists(value & "\" & dr(0)) And isSectionProcessed(dr(0), iKey)) Then
    '                dr(iKey) = True
    '            End If
    '        Next

    '        dtRyme.Rows.Add(dr)
    '    Next
    '    Return dtRyme
    'End Function

    Private Function isSectionProcessed(EsOutFile As String, SectionLabel As String) As Boolean
        Dim Res As Boolean = False
        Dim strFile As String = Handler.GetEsLocation("OUT", "VTS") & "\" & EsOutFile
        Dim sw As StreamReader
        Try
            If (Not File.Exists(strFile)) Then
                Res = False
            Else

                sw = New StreamReader(strFile, True)

                Dim line As String

                line = sw.ReadToEnd
                If (line.Contains(SectionLabel)) Then
                    Res = True
                Else
                    Res = False
                End If

                sw.Close()
                sw.Dispose()

            End If

            Return Res

        Catch ex As Exception
            Res = False
        End Try
    End Function

    Private Function TotallyProcessed(MahaEsOut As String) As Boolean
        Dim Res As Boolean = False
        Dim sw As StreamReader

        Dim strFile As String = Handler.GetEsLocation("OUT", "VTS") & "\" & MahaEsOut 'Handler.GetEsLocation("MahaEsOutPath") & "\" & MahaEsOut

        Try
            If (Not File.Exists(strFile)) Then
                Res = False
            Else

                sw = New StreamReader(strFile, True)

                Dim line As String

                line = sw.ReadToEnd
                If (Not (Handler.SectionsLabelsOut Is Nothing)) Then
                    For Each iKey As String In Handler.SectionsLabelsOut.Keys

                        If (line.Contains(iKey)) Then
                            Res = True
                        Else
                            Res = False
                        End If
                    Next
                End If
            End If

            Return Res

        Catch ex As Exception
            Res = False
        Finally
            sw.Close()
            sw.Dispose()
        End Try
    End Function

    'Private Function ProcessVehiclesFile() As Boolean
    '    Try
    '        Dim dtRyme As DataTable = Handler.dtProcessRyme
    '        Dim i As Integer

    '        If (dtRyme.Rows.Count > 0) Then

    '            For Each row As DataRow In dtRyme.Rows
    '                i = i + 1
    '                For Each iKey As String In Handler.SectionsLabelsOut.Keys
    '                    If (Not IsDBNull(row(iKey))) Then Continue For
    '                    Dim value As String = Handler.SectionsLabelsOut(iKey)
    '                    If (Not IO.File.Exists(value & "\" & row(0))) Then Continue For
    '                    Dim fileSection As New FileInfo(value & "\" & row(0))

    '                    Timer1.Stop()
    '                    row(iKey) = ProcessEsOut(value, row(0), iKey)
    '                    Timer1.Start()

    '                    If row(iKey) = True Then
    '                        'IO.File.Delete(value & "\" & row(0))
    '                        Handler.Log(row(0) & " Processed successfully. VS EsOut filled successfully. Section : " & iKey, Handler.GenerateTimeZone(), "VTS RYME PROCESS", "Success")
    '                    End If
    '                Next
    '            Next row

    '            dtRyme.AcceptChanges()
    '            Handler.dtProcessRyme = dtRyme
    '            Handler.dtProcessRyme.AcceptChanges()

    '        End If

    '        Return True
    '    Catch ex As Exception
    '        Console.WriteLine(ex.ToString)

    '        'Return nothing if something fails
    '        Return Nothing
    '    End Try
    'End Function

    'Private Function ProcessVehiclesFiles() As Boolean
    '    Try
    '        Dim dtRyme As DataTable = Handler.dtProcessRyme
    '        Dim i As Integer

    '        If (dtRyme.Rows.Count > 0) Then

    '            For Each row As DataRow In dtRyme.Rows
    '                i = i + 1
    '                For Each iKey As String In Handler.SectionsLabelsOut.Keys
    '                    If (Not IsDBNull(row(iKey))) Then Continue For
    '                    Dim value As String = Handler.SectionsLabelsOut(iKey)
    '                    If (Not IO.File.Exists(value & "\" & row(0))) Then Continue For
    '                    Dim fileSection As New FileInfo(value & "\" & row(0))

    '                    Timer1.Stop()
    '                    row(iKey) = ProcessEsOut(value, row(0), iKey)
    '                    Timer1.Start()

    '                    If row(iKey) = True Then
    '                        'IO.File.Delete(value & "\" & row(0))
    '                        Handler.Log(iKey & " Processed successfully. VS EsOut filled successfully. FileName : " & row(0), Handler.GenerateTimeZone(), "VTS RYME PROCESS", "Success")
    '                    End If
    '                Next
    '            Next row

    '            dtRyme.AcceptChanges()
    '            Handler.dtProcessRyme = dtRyme
    '            Handler.dtProcessRyme.AcceptChanges()

    '        End If

    '        Return True
    '    Catch ex As Exception
    '        Handler.Log(" Not Processed successfully. VS EsOut not filled successfully.", Handler.GenerateTimeZone(), ex.Message, "Failure")

    '        'Return nothing if something fails
    '        Return Nothing
    '    End Try
    'End Function

    Private Function ClearFiles(ByVal FileName As String) As Boolean
        For Each iKey As String In Handler.SectionsLabelsOut.Keys

            Dim value As String = Handler.SectionsLabelsOut(iKey)
            If (IO.File.Exists(value & "\" & FileName)) Then
                ' IO.File.Delete(value & "\" & FileName)
            End If

        Next
        Return True
    End Function

    'Provide the plateno, the location and the maha code and in return get the value of the code
    'Private Function GetEsCodeValue(plate As String, EsIo As String, EsTyp As String, code As String) As String
    '    Dim strFile As String = Handler.GetEsLocation(EsIo, EsTyp) & "\" & plate & ".txt"
    '    Dim line As String = ""
    '    Dim res As String = ""

    '    If (IO.File.Exists(strFile)) Then

    '        Using sr As StreamReader = New System.IO.StreamReader(strFile)


    '            Dim arr() As String

    '            Do Until sr.EndOfStream
    '                line = sr.ReadLine()
    '                If (line.Contains(code)) Then
    '                    arr = line.Split("=")

    '                    res = arr(1)

    '                End If

    '            Loop

    '            sr.Close()

    '        End Using
    '    End If
    '    Return res
    'End Function

    Private Function ProcessVehicleMahaFile() As DataTable
        Try
            'Create a new data table
            Dim dtMaha As DataTable = New DataTable
            dtMaha.Columns.AddRange({New DataColumn("Vehicle In Process"), New DataColumn("VTS Action")})
            'Loop through each file in the directory
            For Each file As IO.FileInfo In New IO.DirectoryInfo(Handler.GetEsLocation("OUT", "VTS")).GetFiles
                'Create a new row
                Dim dr As DataRow = dtMaha.NewRow

                'Set the data
                dr(0) = file.Name

                If (TotallyProcessed(file.Name) And Not isSectionProcessed(file.Name, "999999=End Of FILE")) Then
                    dr(1) = "Processed"

                    Dim Es As New EsOut

                    For Each itm In Es.GetVtsTypesGroups()
                        FillEsOutCodes(file.Name, itm, Handler.CalculateVtsCodes(itm))
                    Next

                    Es.CreateTitleHeaderEOF("EOF", "", "OUT", file.Name, "", "VTS")
                    ClearFiles(file.Name)
                Else
                    dr(1) = "Created"
                End If
                'Add the row to the data table
                dtMaha.Rows.Add(dr)
            Next
            Return dtMaha
        Catch ex As Exception
            Console.WriteLine(ex.ToString)
            Return Nothing
        End Try
    End Function

    Public Function FillEsOutCodes(ByVal EsOutFileName As String, ByVal SectionLabel As String, ByVal dcData As Dictionary(Of String, String)) As Boolean
        Dim Res As Boolean = False
        Dim sw As StreamWriter
        Try

            Dim strFile As String = Handler.GetEsLocation("OUT", "VTS") & "\" & EsOutFileName
            sw = New StreamWriter(strFile, True)
            Dim Es As New EsOut
            sw.WriteLine(Es.SetVtsCodes(EsOutFileName, dcData))
            Res = True
        Catch ex As IOException
            Res = False
            MessageBox.Show(ex.Message)
        Finally
            sw.Close()
            sw.Dispose()
        End Try

        Return Res
    End Function

    Public Function ManageRymeToMahaEsFiles(ByVal EsOutFile As IO.FileInfo) As Dictionary(Of String, String)
        Dim arr() As String
        Dim line As String
        Dim dc As New Dictionary(Of String, String)

        Dim reader As New System.IO.StreamReader(EsOutFile.OpenRead)
        Dim dcMachCodes As New Dictionary(Of String, String)

        While Not reader.EndOfStream
            line = reader.ReadLine
            If (line.Contains("=") And Not reader.EndOfStream) Then
                arr = line.Split("=")
                Try
                    If (arr(0).Trim <> "") Then
                        Dim val As String = setMahaCode(arr(0).Trim)
                        If val <> "" Then dc.Add(val, arr(1).Trim)
                    End If

                    If (Handler.GetMachineCodes.ContainsKey(arr(0))) Then
                        Try
                            dcMachCodes.Add(arr(0).Trim & ":" & arr(1).Trim, Handler.GetMachineCodes(arr(0)))
                            Handler.dcVtsCodes = dcMachCodes
                        Catch ex As Exception
                        End Try

                    End If

                Catch ex As Exception
                End Try

            End If
        End While

        reader.Close()
        reader.Dispose()

        Return dc
    End Function

    Public Function setMahaCode(ByVal RymeCode As String) As String
        Dim dt As New Data.DataTable
        Dim conn As New connection
        Dim Res As String = ""

        dt = conn.ExecuteReaderdt("Select MahaCode from CodesMappingLookup where RymeCode like '%" & RymeCode & "%' ")
        If dt.Rows.Count > 0 Then
            Res = IIf(IsDBNull(dt.Rows(0).Item("MahaCode")), RymeCode, dt.Rows(0).Item("MahaCode").ToString().Trim())
        End If

        Return Res
    End Function

    Private Function ProcessEquation(RymePath As String, FileName As String) As Dictionary(Of String, String)
        If (Not FileName.Contains(".txt")) Then FileName = FileName & ".txt"

        Dim strFile As String = RymePath & "\" & FileName

        Dim line As String = ""
        Dim allFile As String = IO.File.ReadAllText(strFile)
        Dim dcRes As New Dictionary(Of String, String)

        Dim dc As Dictionary(Of String, Dictionary(Of String, String)) = Handler.GetCalculatedVtsCodes2D
        Dim Val1 As Double = 0
        Dim Val2 As Double = 0
        Dim Val3 As Double = 0
        Dim Val4 As Double = 0
        Dim Es As New EsOut

        For Each iKey In dc.Keys

            Dim value As Dictionary(Of String, String) = dc(iKey)
            If (Es.getCalVtsBr(iKey).Equals("BRAKE")) Then
                If (allFile.Contains(value.First.Key) And allFile.Contains(value.First.Value)) Then
                    Val1 = Es.getRymeValueFromFile(RymePath, FileName, value.First.Key)
                    Val2 = Es.getRymeValueFromFile(RymePath, FileName, value.First.Value)
                    dcRes.Add(iKey, (Val1 - Val2) * 100 / Math.Max(Val1, Val2))
                End If
            ElseIf (Es.getCalVtsBr(iKey).Equals("WEIGHT")) Then
                Val1 = IIf(Es.getRymeValueFromFile(RymePath, FileName, "04014") = "", 0, Es.getRymeValueFromFile(RymePath, FileName, "04014"))
                Val2 = IIf(Es.getRymeValueFromFile(RymePath, FileName, "04016") = "", 0, Es.getRymeValueFromFile(RymePath, FileName, "04016"))
                Val3 = IIf(Es.getRymeValueFromFile(RymePath, FileName, "04018") = "", 0, Es.getRymeValueFromFile(RymePath, FileName, "04018"))
                Val4 = IIf(Es.getRymeValueFromFile(RymePath, FileName, "04020") = "", 0, Es.getRymeValueFromFile(RymePath, FileName, "04020"))
                dcRes.Add(iKey, Val1 + Val2 + Val3 + Val4)
            End If
        Next

        Return dcRes
    End Function

    Private Function ProcessEsOut(ByVal RymeEsOutPath As String, ByVal FileName As String, ByVal SectionLabel As String) As Boolean

        Dim Res As Boolean = False
        Dim Es As New EsOut
        Dim calcCode As String = ""
        Dim calcCodeEquation As String = ""
        'Return FillEsOutCodes(EsOut.Name, SectionLabel, ManageRymeToMahaEsFiles(EsOut))
        If (Not FileName.Contains(".txt")) Then FileName = FileName & ".txt"

        Dim line As String
        Dim VtsCode As String = ""

        Try

            Using sr As StreamReader = New System.IO.StreamReader(RymeEsOutPath & "\" & FileName)
                Dim arr() As String
                Dim dc As New Dictionary(Of String, String)
                Do Until sr.EndOfStream
                    line = sr.ReadLine()
                    If (line.Contains("=")) Then
                        arr = line.Split("=")

                        VtsCode = setMahaCode(arr(0))
                        If (VtsCode = "") Then Continue Do

                        dc.Add(setMahaCode(arr(0)), arr(1))

                    End If

                Loop

                sr.Close()

                If (Not File.Exists(Handler.GetEsLocation("OUT", "VTS") & "\" & FileName)) Then
                    My.Computer.FileSystem.RenameFile(RymeEsOutPath & "\" & FileName, Path.GetFileNameWithoutExtension(RymeEsOutPath & "\" & FileName) & "_SKIPPED" & ".txt")
                    Handler.Log(RymeEsOutPath & "\" & FileName & " SKIPPED by processor : " & SectionLabel, Handler.GenerateTimeZone(), "EsOut not found", "Skipped")
                Else
                    If (dc.Keys.Count > 0) Then
                        Es.SetVtsCodes(FileName, dc) 'Normal Vts Codes
                        Es.SetVtsCodes(FileName, ProcessEquation(RymeEsOutPath, FileName)) 'Calculated Vts Codes

                        If (File.Exists(RymeEsOutPath & "\" & FileName)) Then
                            IO.File.Delete(RymeEsOutPath & "\" & FileName)
                        End If
                        Dim RymeEsInPath = RymeEsOutPath.Replace("\OUT\", "\IN\")
                        If (File.Exists(RymeEsInPath & "\" & FileName)) Then
                            IO.File.Delete(RymeEsInPath & "\" & FileName)
                        End If
                        Res = True
                    End If
                End If
            End Using
        Catch ex As Exception
            Handler.Log(FileName & " Not Processed Successfully for Section : " & SectionLabel, Handler.GenerateTimeZone(), ex.Message.Replace("'", ""), "Failure")
            txtDate.Text = ""
            txtInspectionNo.Text = ""
            cmbStatus.Text = ""
            txtPlate.Text = ""
            FillData()
        End Try

        Return Res
    End Function

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        LoadProcessor()
    End Sub

    Private Sub LoadProcessor()
        If (DateTime.Now.Hour = 23) Then
            Dim helper As New Helpers
            If (helper.Expires()) Then
                Dim Answer = MessageBox.Show("System Expired, Please contact administrator.", "Expired !!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If (Answer = MsgBoxResult.Yes Or Answer = MsgBoxResult.No) Then
                    Dispose()
                End If
            End If
        End If

        ProcessRymeFiles()
        DataGridView2.DataSource = ProcessVehicleMahaFile()
        lblStatus.Text = "Processes Loaded Successfully"

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Dispose()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Log.Show()
    End Sub

    Private Sub BtnDate_Click(sender As Object, e As EventArgs) Handles btnDate.Click
        If Cal.Visible = False Then
            Cal.Visible = True
        Else
            Cal.Visible = False
        End If
    End Sub

    Private Sub Cal_DateChanged(sender As Object, e As DateRangeEventArgs) Handles Cal.DateChanged
        txtDate.Text = Cal.SelectionRange.Start.ToString("dd/MM/yyyy")
        Cal.Visible = False
    End Sub

    Private Sub BtnFilter_Click(sender As Object, e As EventArgs) Handles btnFilter.Click
        FillData()
    End Sub



End Class