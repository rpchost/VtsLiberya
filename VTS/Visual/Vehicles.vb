Imports System.IO

Public Class Vehicles
    Dim conn As New connection
    Public Sub Vehicles_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        header.Width = Me.Width
        header.Height = 100

        Dim i As Integer
        Dim arrLst As ArrayList = getBU(Handler.GroupID)

        Dim helper As New Helpers

        For i = 0 To arrLst.Count - 1

            Dim btnBU As New Windows.Forms.Button
            btnBU.Size = New Size(300, 60)

            btnBU.AutoSize = True
            btnBU.Name = "btn-" & arrLst(i)
            btnBU.Text = getBULabel(arrLst(i))

            If (btnBU.Text.Equals("Complete and Save")) Then
                If (helper.CanCompleteAndSave(Handler.Lane, Handler.Section) = False) Then
                    btnBU.Visible = False
                End If
            End If

            btnBU.Font = New Font("Microsoft Sans Serif", 15, FontStyle.Bold)
            btnBU.Top = i * 70
            btnBU.Left = 25
            AddHandler btnBU.Click, AddressOf BULink
            pnl.Controls.Add(btnBU)
            pnl.Refresh()
        Next

        'Start To insert in load for each form
        lblInspectionNo.Text = Handler.InspNo
        lblInspectorID.Text = Handler.InspectorID
        lblPlate.Text = Handler.Plate
        lblGroup.Text = Handler.GroupName
        lblLane.Text = IIf(Handler.Lane <> "", "Lane : " & Handler.Lane, "")
        lblSection.Text = IIf(Handler.Section <> "", "Section : " & Handler.Section, "")

        If (Handler.InspType = "Y") Then
            lblVisitType.Text = "Fst Visit"
        ElseIf (Handler.InspType = "R") Then
            lblVisitType.Text = "Repeat Visit"
        ElseIf (Handler.InspType = "A") Then
            lblVisitType.Text = "Aborted"
        Else
            lblVisitType.Text = ""
        End If

        If (File.Exists(Handler.GetEsLocation("OUT", "VTS") & "\" & Handler.Plate & ".txt")) Then
            lblStored.Text = "Stored intermediate"
        Else
            lblStored.Text = ""
        End If

        If (Handler.Group(Handler.InspectorID) = "Inspectors" Or Handler.Group(Handler.InspectorID) = "Supervisors") Then
            If (Handler.Plate = Nothing) Then
            Else
                Dim strFile As String = Handler.GetEsLocation("OUT", "VTS") & "\" & Handler.Plate & ".txt"
            End If
        End If
    End Sub

    Private Function BULink(ByVal sender As Object, ByVal e As EventArgs) As Boolean

        Dim arr() As String

        Dim btn As Button = DirectCast(sender, Button)

        arr = btn.Name.Split("-")

        Dim vForm As String
        vForm = getBULink(arr(1))

        Dim helper As New Helpers

        If (vForm = "cachier" Or vForm = "cashier") Then

            Cashier.Show()
        End If
        If (vForm = "VisualDefects" Or vForm = "Visual Defects") Then
            If (Handler.Plate = Nothing) Then
                MessageBox.Show("You must select a vehicle")
                Exit Function
            End If

            Defects.Show()
        End If
        If (vForm = "ReviewMeasurments" Or vForm = "Review Measurments") Then
            If (Handler.Plate = Nothing) Then
                MessageBox.Show("You must select a vehicle")
                Exit Function
            End If
            ReviewMeasurement.Show()
        End If
        If (vForm = "ViewDeletedCodes" Or vForm = "View Deleted Codes") Then
            If (Handler.Plate = Nothing) Then
                MessageBox.Show("You must select a vehicle")
                Exit Function
            End If
            DeletedCode.Show()
        End If
        If (vForm = "StoreIntermediate" Or vForm = "Store Intermediate") Then

            If (Handler.Plate = Nothing) Then
                MessageBox.Show("You must select a vehicle")
                Exit Function
            End If

            Dim inspActiveExists = helper.InspectionActiveExist(Handler.Chassis)

            If (inspActiveExists = False) Then
                MessageBox.Show("No Inspection Active for this vehicle")
                Exit Function
            End If

            Dim strFile As String = Handler.GetEsLocation("OUT", "VTS") & "\" & Handler.Plate & ".txt"

            Dim MaxReached = Handler.getDefectsCount(Handler.InspectionNo) + Handler.dTDefects.Rows.Count > 30
            If (MaxReached) Then
                MessageBox.Show("Number of entered defects reached the maximum (30)")
                Exit Function
            End If

            If (Handler.dTDefects.Rows.Count > 0) Then
                Try

                    If (Not Handler.ApplyDataTableToDefects(Handler.dTDefects)) Then
                        MessageBox.Show("Failure to store Defects DataTable")
                        Handler.Log(Handler.Plate & " Defects DataTable did not added successfully; " & Handler.InspNo, Handler.GenerateTimeZone(), "VTS RYME PROCESS", "Failure")
                    Else
                        Handler.Log(Handler.Plate & " Defects codes added successfully " & Handler.InspNo, Handler.GenerateTimeZone(), "VTS RYME PROCESS", "Success")
                        Handler.dTDefects.Clear()
                    End If
                Catch ex As Exception
                    Handler.Log(Handler.Plate & " Defects codes did not added successfully; " & ex.Message & "  " & Handler.InspNo, Handler.GenerateTimeZone(), "VTS RYME PROCESS", "Failure")
                    Exit Function
                End Try

                lblMessage.Text = "Defects codes stored successfully"
            Else
                lblMessage.Text = "You did not add any defect code to store"
            End If

            If (Handler.dTDelCodes.Rows.Count > 0) Then
                Handler.ApplyDataTableDelCodesToDB(Handler.dTDelCodes, "DELETEDCODES_tmp", "CERTIFICATENO", "DELETEDATE", "INSPECTOR", "LANE", "SECT", "DELETEDCODE", "string", "date", "string", "int", "int", "string", 255, 255, 255, 5, 5, 255)

                Try
                    Handler.dTDelCodes.Dispose()
                Catch ex As Exception
                End Try

                lblMessage.Text = lblMessage.Text & vbCrLf & "Deleted codes stored successfully"
            Else
                lblMessage.Text = lblMessage.Text & vbCrLf & "There is no deleted codes to store"
            End If

            'Create the ESIn files for Ryme Stations
            Dim esIn As New EsIn
            esIn.ToEsPath("RYME", "IN", Handler.Plate, Handler.Lane, "")

            If (Handler.InspType = "Y") Then

                'Create the EsOut file (Title + Header) for VTS
                Dim Es As New EsOut
                'If (Es.CreateTitleHeaderEOF("TitleHeader", Handler.IType, "IN", Handler.Plate, "", "VTS")) Then
                If (Es.CreateTitleHeaderEOF("TitleHeader", Handler.InspType, "OUT", Handler.Plate, "", "VTS")) Then ' Create the EsOut skeleton file in VTS/OUT
                    MessageBox.Show(Handler.Plate & " READY FOR RYME INSPECTION")
                    Handler.Log(Handler.Plate & " Status = Stored. VTS EsIn stored successfully. [First Visit]" & Handler.InspNo, Handler.GenerateTimeZone(), "VTS RYME PROCESS", "Success")
                Else
                    MessageBox.Show(Handler.Plate & " Error while Storing " & Handler.InspNo)
                    Handler.Log(Handler.Plate & " Status = Store Error. VTS EsIn fail to store. " & Handler.InspNo, Handler.GenerateTimeZone(), "VTS RYME PROCESS", "Failure")
                End If

            ElseIf (Handler.InspType = "R") Then
                Dim srcFile As String = Handler.GetEsLocation("OUT", "PROCESS_SUCCESS") & "\" & Handler.Plate & ".txt"
                If (IO.File.Exists(srcFile)) Then
                    Try
                        IO.File.Move(srcFile, strFile)
                    Catch ex As Exception
                        MessageBox.Show(Handler.Plate & " did not move successfully [Repeat Visit]" & Handler.InspNo)
                        Handler.Log(Handler.Plate & " did not move successfully. [Repeat Visit] " & Handler.InspNo, Handler.GenerateTimeZone(), "VTS RYME PROCESS", "Failure")
                    End Try

                    MessageBox.Show(Handler.Plate & " READY FOR RYME INSPECTION")
                    Handler.Log(Handler.Plate & " Status = Stored. VTS EsOut stored successfully. [Repeat Visit] " & Handler.InspNo, Handler.GenerateTimeZone(), "VTS RYME PROCESS", "Success")
                Else
                    MessageBox.Show(Handler.Plate & " does not exist in ProcessEsOut_Success [Repeat Visit]" & Handler.InspNo)
                    Handler.Log(Handler.Plate & " does not exist in ProcessEsOut_Success. [Repeat Visit] " & Handler.InspNo, Handler.GenerateTimeZone(), "VTS RYME PROCESS", "Failure")
                End If
            ElseIf (Handler.InspType = "A") Then
                MessageBox.Show(Handler.InspNo & " Ws Aborted")
            Else
                MessageBox.Show("No valid visit nature for this vehicle")
            End If

            If (helper.CanCompleteAndSave(Handler.Lane, Handler.Section) = False) Then

                My.Forms.SYSTEMLOGIN.Show()
                My.Forms.SYSTEMLOGIN.txtUser.ResetText()
                My.Forms.SYSTEMLOGIN.txtPwd.ResetText()
                My.Forms.SYSTEMLOGIN.txtUser.Focus()
                My.Forms.SYSTEMLOGIN.lblmsg.ResetText()
                Me.Dispose()

            End If


        End If

        If (vForm = "Complete and Save") Then

            If (Handler.Plate = Nothing) Then
                MessageBox.Show("You must select a vehicle")
                Exit Function
            End If

            Dim strSourceFile As String = Handler.GetEsLocation("OUT", "VTS") & "\" & Handler.Plate & ".txt"
            Dim strDestSuccess As String = Handler.GetEsLocation("OUT", "PROCESS_SUCCESS") & "\" & Handler.Plate & ".txt"
            Dim strDestFail As String = Handler.GetEsLocation("OUT", "PROCESS_FAIL") & "\" & Handler.Plate & ".txt"

            If (File.Exists(strSourceFile) = False) Then
                MessageBox.Show($"No Esout file exists for the plate {Handler.Plate}")
                Exit Function
            End If

            Dim inspActiveExists = helper.InspectionActiveExist(Handler.Chassis)

            If (inspActiveExists = False) Then
                MessageBox.Show("No Inspection Active for this vehicle")
                Exit Function
            End If

            If MsgBox("Are you sure you want to Complete and Save", vbQuestion Or vbYesNo Or vbDefaultButton2, "Confirm Vehicle Inspection") = vbYes Then

                Dim plate As String = Handler.Plate
                Dim Chassis As String = Handler.Chassis
                Dim Es As New EsOut

                Dim opExec As New connection

                IO.File.Move(strSourceFile, strDestSuccess)
                Handler.Log(Handler.InspectionNo & " Completed successfully, Plate = " & plate, Handler.GenerateTimeZone(), "COMPLETE AND SAVE", "Success")
                MessageBox.Show(Handler.InspectionNo & " Completed successfully")

                My.Forms.SYSTEMLOGIN.Show()
                My.Forms.SYSTEMLOGIN.txtUser.ResetText()
                My.Forms.SYSTEMLOGIN.txtPwd.ResetText()
                My.Forms.SYSTEMLOGIN.txtUser.Focus()
                My.Forms.SYSTEMLOGIN.lblmsg.ResetText()
                Me.Dispose()

                'Try
                '    Dim HistoryInserted = opExec.ExecuteSqlCommand("Insert into inspectionhistory (INSPECTIONNO, CHASSISNO, ITYPE, LANE, FEEAMOUNT, FEETYPE, FEELABEL, STATIONNAME, LASTSTATIONNAME, USER_FK, USERNAME, HOSTNAME, CASHIERNAME, CASHIER_FK, TESTRESULT, InspType, ReceiptNo, LaneIN, LANETYPE, MinLane) Select INSPECTIONNO,CHASSISNO,ITYPE,LANE,FEEAMOUNT,FEETYPE,FEELABEL,STATIONNAME,LASTSTATIONNAME ,USER_FK,USERNAME,HOSTNAME ,CASHIERNAME,CASHIER_FK,TESTRESULT,InspType,ReceiptNo,LaneIN,LANETYPE,MinLane from inspectionactive where inspectionno = '" & Handler.InspectionNo & "' ", True)

                '    If (HistoryInserted.Item1) Then
                '        Dim CertificateInserted = opExec.ExecuteSqlCommand("Insert into Certificate (CERTIFICATENO , inspectionno, CERTIFICATEDATE, LANENO,FeeLabel,CHASSISNO,TestResult, stationname)  select replace(INSPECTIONNO, 'B-C-', 'B-I-'),INSPECTIONNO,UPDATEDATE,LANE,FEELABEL,CHASSISNO,TestResult, stationname from inspectionactive where inspectionno = '" & Handler.InspectionNo & "' ", True)

                '        If (CertificateInserted.Item1) Then
                '            Dim DeleteInspectionActive = opExec.ExecuteSqlCommand("Delete from inspectionactive where inspectionno = '" & Handler.InspectionNo & "' ", True)

                '            If (DeleteInspectionActive.Item1) Then
                '                IO.File.Move(strSourceFile, strDestSuccess) 'It should go to ProcessEsOut folder and the ProcessEsOut software move it to success or failure folder
                '                Handler.Log(Handler.InspectionNo & " Completed successfully, Plate = " & plate, Handler.GenerateTimeZone(), "COMPLETE AND SAVE", "Success")
                '                MessageBox.Show(Handler.InspectionNo & " Completed successfully")

                '                My.Forms.SYSTEMLOGIN.Show()
                '                My.Forms.SYSTEMLOGIN.txtUser.ResetText()
                '                My.Forms.SYSTEMLOGIN.txtPwd.ResetText()
                '                My.Forms.SYSTEMLOGIN.txtUser.Focus()
                '                My.Forms.SYSTEMLOGIN.lblmsg.ResetText()
                '                Me.Dispose()
                '            Else
                '                Throw New DataException("Complete & Save not executed; InspectionActive not deleted")
                '            End If
                '        Else
                '            Throw New DataException("Complete & Save not executed; Certificate not inserted")
                '        End If
                '    Else
                '        Throw New DataException("Complete & Save not executed; Inspectionhisory not inserted")
                '    End If

                'Catch ex As Exception
                '    Handler.Log(Handler.InspectionNo & " failed to complete , Plate = " & plate & " ; " & ex.Message, Handler.GenerateTimeZone(), "COMPLETE AND SAVE", "Failure")
                '    MessageBox.Show(Handler.InspectionNo & " Failed to complete")
                'Finally
                '    opExec.closeConnection()
                'End Try
            End If
        End If

        If (vForm = "Print Certificate") Then
            If (Handler.Plate = Nothing) Then
                MessageBox.Show("You must select a vehicle")
                Exit Function
            End If
            Certificate.Show()
        End If

        If (vForm = "Settings") Then
            Settings.Show()
        End If

        If (vForm = "Select_Vehicle") Then
            Select_Vehicle.Show()
        End If

        Return True
    End Function


    Private Function getBULabel(BU As Integer) As String

        Dim str As String
        Dim dtBU As New Data.DataTable

        Dim conn As New connection
        str = "select * from BusinessUnit where ID=" & BU
        dtBU = conn.ExecuteReaderdt(str)
        If (dtBU.Rows.Count > 0) Then
            Return dtBU.Rows(0).Item("Label").ToString
        Else
            Return ""
        End If

    End Function

    Private Function getBULink(BU As Integer) As String

        Dim str As String
        Dim dtBU As New Data.DataTable

        Dim conn As New connection
        str = "select * from BusinessUnit where ID=" & BU
        dtBU = conn.ExecuteReaderdt(str)
        If (dtBU.Rows.Count > 0) Then
            Return dtBU.Rows(0).Item("BULnk").ToString
        Else
            Return ""
        End If

    End Function


    Private Function getBU(grpID As Integer) As ArrayList

        Dim opExec As New connection
        Dim arrLst As New ArrayList

        Dim reader As SqlClient.SqlDataReader = opExec.rdGetReader("select * from GroupsBusinessUNit where groupID=" & grpID)
        Try

            If reader.HasRows = True Then
                While reader.Read
                    arrLst.Add(reader("BU"))
                End While
            End If

            Return arrLst

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            opExec.closeConnection()
        End Try

    End Function

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        My.Forms.Select_Vehicle.Show()

        Me.Dispose()
    End Sub

    Private Sub btnVisual_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If (Handler.Plate = Nothing) Then
            MessageBox.Show("You must select a vehicle")
            Return
        End If


        Defects.Show()

        'If (lblVisitType.Text = "Fst Visit") Then
        '    Defects.Show()
        'End If

    End Sub

    Private Sub btnReview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If (Handler.Plate = Nothing) Then
            MessageBox.Show("You must select a vehicle")
            Return
        End If

        ReviewMeasurement.Show()

        'If (Handler.IType = "I") Then ReviewMeasurement.Show()
        'If (Handler.IType = "R") Then ReviewMeasurementRepeat.Show()


    End Sub

    Private Sub btnDeleted_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If (Handler.Plate = Nothing) Then
            MessageBox.Show("You must select a vehicle")
            Return
        End If

        Dim frm2 As New DeletedCode
        ' frm2.Label1.Text = Label1.Text
        frm2.Show()
        Me.Dispose()
    End Sub

    Private Sub btnEuroBack_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles btnEuroBack.KeyDown
        If e.KeyCode = Keys.Escape Then
            My.Forms.SYSTEMLOGIN.Show()
            My.Forms.SYSTEMLOGIN.txtUser.ResetText()
            My.Forms.SYSTEMLOGIN.txtPwd.ResetText()
            My.Forms.SYSTEMLOGIN.txtUser.Focus()
            My.Forms.SYSTEMLOGIN.lblmsg.ResetText()
            ' Label1.Text = ""
            Me.Dispose()
        End If
    End Sub

    Private Sub btnEuroBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEuroBack.Click
        My.Forms.SYSTEMLOGIN.Show()
        My.Forms.SYSTEMLOGIN.txtUser.ResetText()
        My.Forms.SYSTEMLOGIN.txtPwd.ResetText()
        My.Forms.SYSTEMLOGIN.txtUser.Focus()
        My.Forms.SYSTEMLOGIN.lblmsg.ResetText()
        'Label1.Text = ""
        Me.Dispose()
    End Sub

    Private Sub btnStore_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        If (Handler.Plate = Nothing) Then
            MessageBox.Show("You must select a vehicle")
            Return
        End If

        Dim strFile As String = Handler.GetEsLocation("OUT", "VTS") & "\" & Handler.Plate & ".txt"

        If (IO.File.Exists(strFile)) Then
            MessageBox.Show("Vehicle is already stored Intermediate")
            'Return
        End If


        If (Handler.dTDefects.Rows.Count > 0) Then
            'Handler.ApplyDataTableToDB(Handler.dTDefects, "DEFECTS_tmp", "DefectDesc", "DefectDate", "CertificateNo", "", "string", "date", "string", "", 255, 255, 255, 0)
            If (Not Handler.ApplyDataTableToDefects(Handler.dTDefects)) Then
                MessageBox.Show("Failure to store Defects DataTable")
                Return
            End If
            Try
                Handler.dTDefects.Dispose()
            Catch ex As Exception
            End Try

            lblMessage.Text = "Defects codes stored successfully"
        Else
            lblMessage.Text = "You did not add any defect code to store"
        End If

        If (Handler.dTDelCodes.Rows.Count > 0) Then
            Handler.ApplyDataTableDelCodesToDB(Handler.dTDelCodes, "DELETEDCODES_tmp", "CERTIFICATENO", "DELETEDATE", "INSPECTOR", "LANE", "SECT", "DELETEDCODE", "string", "date", "string", "int", "int", "string", 255, 255, 255, 5, 5, 255)

            Try
                Handler.dTDelCodes.Dispose()
            Catch ex As Exception
            End Try

            lblMessage.Text = lblMessage.Text & vbCrLf & "Deleted codes stored successfully"
        Else
            lblMessage.Text = lblMessage.Text & vbCrLf & "There is no deleted codes to store"
        End If

        'Create the ESIn files for Ryme Stations
        Dim esIn As New EsIn
        esIn.ToEsPath("RYME", "IN", Handler.Plate, Handler.Lane, "")

        'Create the EsOut file (Title + Header) for VTS
        Dim Es As New EsOut
        If (Es.CreateTitleHeaderEOF("TitleHeader", Handler.InspType, "OUT", Handler.Plate, "", "VTS")) Then
            ''btnStore.Enabled = False
            MessageBox.Show(Handler.Plate & " Stored Successfully " & Handler.InspNo)
            Handler.Log(Handler.Plate & " Status = Stored. VTS EsOut stored successfully. " & Handler.InspNo, Handler.GenerateTimeZone(), "VTS RYME PROCESS", "Success")
        Else
            MessageBox.Show(Handler.Plate & " Error while Storing " & Handler.InspNo)
            Handler.Log(Handler.Plate & " Status = Store Error. VTS EsOut stored UNsuccessfully. " & Handler.InspNo, Handler.GenerateTimeZone(), "VTS RYME PROCESS", "Failure")
        End If

    End Sub

    Private Sub btnESINPath_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Settings.Show()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        Me.Close()
        Dispose()

    End Sub

    Private Sub BtnSelectVehicle_Click(sender As Object, e As EventArgs)
        My.Forms.Select_Vehicle.Show()

        Me.Dispose()
    End Sub

    Private Sub btnComplete_Click(sender As Object, e As EventArgs)
        Dim strSourceFile As String = Handler.GetEsLocation("OUT", "VTS") & "\" & Handler.Plate & ".txt"
        Dim strDestSuccess As String = Handler.GetEsLocation("OUT", "PROCESS_SUCCESS") & "\" & Handler.Plate & ".txt"
        Dim strDestFail As String = Handler.GetEsLocation("OUT", "PROCESS_FAIL") & "\" & Handler.Plate & ".txt"

        If MsgBox("Are you sure you want to Complete and Save", vbQuestion Or vbYesNo Or vbDefaultButton2, "Confirm Vehicle Inspection") = vbYes Then

            Dim plate As String = Handler.Plate
            Dim Chassis As String = Handler.Chassis
            Dim Es As New EsOut

            Dim opExec As New connection


            Try
                Dim HistoryInserted = opExec.ExecuteSqlCommand("Insert into inspectionhistory (INSPECTIONNO, CHASSISNO, ITYPE, LANE, FEEAMOUNT, FEETYPE, FEELABEL, STATIONNAME, LASTSTATIONNAME, USER_FK, USERNAME, HOSTNAME, CASHIERNAME, CASHIER_FK, TESTRESULT, InspType, ReceiptNo, LaneIN, LANETYPE, MinLane) Select replace(INSPECTIONNO, 'B-C-', 'B-I-'),CHASSISNO,ITYPE,LANE,FEEAMOUNT,FEETYPE,FEELABEL,STATIONNAME,LASTSTATIONNAME ,USER_FK,USERNAME,HOSTNAME ,CASHIERNAME,CASHIER_FK,TESTRESULT,InspType,ReceiptNo,LaneIN,LANETYPE,MinLane from inspectionactive where inspectionno = '" & Handler.InspectionNo & "' ", True)

                If (HistoryInserted.Item1) Then
                    Dim CertificateInserted = opExec.ExecuteSqlCommand("Insert into Certificate (CERTIFICATENO ,CERTIFICATEDATE,INSPECTIONNO,LANENO,CHASSISNO,TestResult)  values ('" & Handler.InspectionNo.Replace("B-I-", "B-C-") & "', CONVERT(datetime,'" & Handler.GenerateTimeZone() & "',103),'" & Handler.InspectionNo & "','" & Handler.Lane & "','" & Chassis & "','F') ", True)

                    If (CertificateInserted.Item1) Then
                        Dim DeleteInspectionActive = opExec.ExecuteSqlCommand("Delete from inspectionactive where inspectionno = '" & Handler.InspectionNo & "' ", True)

                        If (DeleteInspectionActive.Item1) Then
                            IO.File.Move(strSourceFile, strDestSuccess) 'It should go to ProcessEsOut folder and the ProcessEsOut software move it to success or failure folder
                            Handler.Log(Handler.InspectionNo & " Completed successfully, Plate = " & plate, Handler.GenerateTimeZone(), "COMPLETE AND SAVE", "Success")
                            MessageBox.Show(Handler.InspectionNo & " Completed successfully")
                        Else
                            Throw New DataException("Complete & Save not executed; InspectionActive not deleted")
                        End If
                    Else
                        Throw New DataException("Complete & Save not executed; Certificate not inserted")
                    End If
                Else
                    Throw New DataException("Complete & Save not executed; Inspectionhisory not inserted")
                End If

            Catch ex As Exception
                IO.File.Move(strSourceFile, strDestFail)
                Handler.Log(Handler.InspectionNo & " failed to complete , Plate = " & plate & " ; " & ex.Message, Handler.GenerateTimeZone(), "COMPLETE AND SAVE", "Failure")
                MessageBox.Show(Handler.InspectionNo & " Failed to complete")
            Finally
                opExec.closeConnection()
            End Try

            'Try
            '        If (opExec.ExecuteSqlCommand("Insert into inspectionhistory (INSPECTIONNO, CHASSISNO, ITYPE, LANE, FEEAMOUNT, FEETYPE, FEELABEL, STATIONNAME, LASTSTATIONNAME, USER_FK, USERNAME, HOSTNAME, CASHIERNAME, CASHIER_FK, TESTRESULT, InspType, ReceiptNo, LaneIN, LANETYPE, MinLane) Select Replace(INSPECTIONNO,'B-C-','B-I-'),CHASSISNO,ITYPE,LANE,FEEAMOUNT,FEETYPE,FEELABEL,STATIONNAME,LASTSTATIONNAME ,USER_FK,USERNAME,HOSTNAME ,CASHIERNAME,CASHIER_FK,TESTRESULT,InspType,ReceiptNo,LaneIN,LANETYPE,MinLane from inspectionactive where inspectionno = '" & Handler.InspectionNo & "' ", True)) Then
            '            If (opExec.ExecuteSqlCommand("Insert into Certificate (CERTIFICATENO ,CERTIFICATEDATE,INSPECTIONNO,LANENO,CHASSISNO,TestResult)  values ('" & Handler.InspectionNo.Replace("B-I-", "B-C-") & "', CONVERT(datetime,'" & Handler.GenerateTimeZone() & "',103),'" & Handler.InspectionNo & "','" & Handler.Lane & "','" & Chassis & "','F') ")) Then
            '                If (opExec.ExecuteSqlCommand("Delete from inspectionactive where inspectionno = '" & Handler.InspectionNo & "' ", True)) Then
            '                    IO.File.Move(strSourceFile, strDestSuccess) 'It should go to ProcessEsOut folder and the ProcessEsOut software move it to success or failure folder
            '                    Handler.Log(Handler.InspectionNo & " Completed successfully, Plate = " & plate, Handler.GenerateTimeZone(), "COMPLETE AND SAVE", "Success")
            '                    MessageBox.Show(Handler.InspectionNo & " Completed successfully")
            '                End If
            '            End If
            '        End If
            '        'opExec.closeConnection()

            '        'Insert into certificate for testing
            '        ''opExec.ExecuteSqlCommand("Insert into Certificate (CERTIFICATENO ,CERTIFICATEDATE,INSPECTIONNO,LANENO,CHASSISNO,TestResult)  values ('" & Handler.InspectionNo.Replace("B-I-", "B-C-") & "', CONVERT(datetime,'" & Handler.GenerateTimeZone() & "',103),'" & Handler.InspectionNo & "','" & Handler.Lane & "','" & Chassis & "','F') ")
            '        'opExec.closeConnection()

            '        '' opExec.ExecuteSqlCommand("Delete from inspectionactive where inspectionno = '" & Handler.InspectionNo & "' ")

            '    Catch ex As Exception
            '        IO.File.Move(strSourceFile, strDestFail)
            '        Handler.Log(Handler.InspectionNo & " failed to complete , Plate = " & plate & " ; " & ex.Message, Handler.GenerateTimeZone(), "COMPLETE AND SAVE", "Failure")
            '        MessageBox.Show(Handler.InspectionNo & " Failed to complete")
            '    Finally
            '        opExec.closeConnection()
            '    End Try

        End If

    End Sub

    Private Sub btnCashier_Click(sender As Object, e As EventArgs)
        Cashier.Show()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs)
        ReviewMeasurementRepeat.Show()
    End Sub
End Class