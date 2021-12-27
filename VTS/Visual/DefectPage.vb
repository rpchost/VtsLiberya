Imports System.IO
Imports System.IO.FileInfo
Public Class DefectPage

    Dim conn As New connection
    Dim sql As String
    Dim dt As New Data.DataTable
    Dim DefectDate As String
    Dim DefectHour As String
    Dim strAdd As String
    Dim Fleft1 As String
    Dim Mleft1 As String
    Dim Rleft1 As String
    Dim Cleft1 As String
    Dim CC1 As String
    Dim CD1 As String
    Dim RL1 As String
    Dim RM1 As String
    Dim RR1 As String
    Dim Minor1 As String
    Dim Major1 As String
    Dim sqlPic As String
    Dim dtPic As New Data.DataTable

    Dim XMajor As String
    Dim data1 As String
    Dim data2 As String
    Dim data3 As String
    Dim data4 As String
    Dim data5 As String
    Dim data6 As String
    Dim data7 As String
    Dim data8 As String
    Dim data9 As String
    Dim data10 As String
    Dim data11 As String
    Dim strinspectionNO As String
    Dim strCertNO As String

    Private Sub DefectPage_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        header.Width = Me.Width
        header.Height = 100

        lblinspectionNO.Text = Handler.InspNo
        lblInspectorID.Text = Handler.InspectorID
        lblPlate.Text = Handler.Plate

        If (Handler.InspectionNo.Contains("B-C-")) Then
            strinspectionNO = Handler.InspectionNo.Substring(42, 8)
            strCertNO = "B-C-00000000000000000000000000000000000000" & strinspectionNO
        Else
            strinspectionNO = Handler.InspectionNo
            strCertNO = strinspectionNO
        End If



        sqlPic = "select * from Defects_Temp   where  CertificateNO='" & strCertNO & "'"
        dtPic = conn.ExecuteReaderdt(sqlPic)

        If dtPic.Rows.Count > 0 Then
            For CounterRec As Integer = 0 To dtPic.Rows.Count - 1
                Dim arrLocation() As String
                Dim location As String

                location = dtPic.Rows(CounterRec).Item("DefectDesc")
                arrLocation = location.Split("-")

                If arrLocation(4) = "Defect Location:#AVG#" Then
                    btnFrontLeft.BackColor = Color.Red
                Else
                    btnFrontLeft.BackColor = Color.Silver
                End If
                '*******************************

                If arrLocation(4) = "Defect Location:#AVC#" Then
                    btnFrontMiddle.BackColor = Color.Red
                Else
                    btnFrontMiddle.BackColor = Color.Silver
                End If
                ''**************************************

                If arrLocation(4) = "Defect Location:#AVD#" Then
                    btnFrontRight.BackColor = Color.Red
                Else
                    btnFrontRight.BackColor = Color.Silver
                End If
                ''***********************************

                If arrLocation(4) = "Defect Location:#CG#" Then
                    btnCenterLeft.BackColor = Color.Red
                Else
                    btnCenterLeft.BackColor = Color.Silver
                End If

                ''************************************

                If arrLocation(4) = "Defect Location:#CC#" Then
                    btnCenter.BackColor = Color.Red
                Else
                    btnCenter.BackColor = Color.Silver
                End If

                ''******************
                If arrLocation(4) = "Defect Location:#CD#" Then
                    BtnCenterRight.BackColor = Color.Red
                Else
                    BtnCenterRight.BackColor = Color.Silver
                End If
                '*************

                If arrLocation(4) = "Defect Location:#ARG#" Then
                    btnRearLeft.BackColor = Color.Red
                Else
                    btnRearLeft.BackColor = Color.Silver
                End If
                ''******************************

                If arrLocation(4) = "Defect Location:#ARC#" Then
                    btnRearMiddle.BackColor = Color.Red
                Else
                    btnRearMiddle.BackColor = Color.Silver
                End If

                ''*********************
                ''******************************
                If arrLocation(4) = "Defect Location:#ARD#" Then
                    btnRearRight.BackColor = Color.Red
                Else
                    btnRearRight.BackColor = Color.Silver
                End If

                '******************************
                If arrLocation(4) = "Defect Location:#Minor Defect#" Then
                    btnMinorDefect.BackColor = Color.Red
                Else
                    btnMinorDefect.BackColor = Color.Silver
                End If

                ''******************************
                If arrLocation(4) = "Defect Location:#Major Defect#" Then
                    btnMajorDefect.BackColor = Color.Red
                Else
                    btnMajorDefect.BackColor = Color.Silver
                End If
            Next
        Else

            btnFrontLeft.BackColor = Color.Silver
            btnFrontMiddle.BackColor = Color.Silver
            btnFrontRight.BackColor = Color.Silver
            btnCenterLeft.BackColor = Color.Silver
            btnCenter.BackColor = Color.Silver
            BtnCenterRight.BackColor = Color.Silver
            btnRearLeft.BackColor = Color.Silver
            btnRearMiddle.BackColor = Color.Silver
            btnRearRight.BackColor = Color.Silver
            btnMinorDefect.BackColor = Color.Silver
            btnMajorDefect.BackColor = Color.Silver

        End If

    End Sub

    Private Sub Button15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button15.Click


        If (Handler.InspectionNo.Contains("B-C-")) Then
            strinspectionNO = Handler.InspectionNo.Substring(42, 8)
            strCertNO = "B-C-00000000000000000000000000000000000000" & strinspectionNO
        Else
            strinspectionNO = Handler.InspectionNo
            strCertNO = strinspectionNO
        End If

        If (Handler.InspectionNo = Nothing Or Handler.InspectionNo.Trim = "") Then
            MessageBox.Show("InspectionNo is null")
            Exit Sub
        End If


        Dim sqlCExist As String
        Dim dtCExist As New Data.DataTable

        sqlCExist = "select * from Defects_Temp   where  CertificateNO='" & strCertNO & "'  and DefectDESC like '%" & Label5.Text.Substring(0, 9) & "'"
        dtCExist = conn.ExecuteReaderdt(sqlCExist)

        If dtCExist.Rows.Count > 0 Then
            Label6.Visible = True

            My.Forms.Defects.Show()

            My.Forms.Defects.lblmsgStatus.Visible = True
            My.Forms.Defects.lblmsgStatus.ForeColor = Color.Red
            My.Forms.Defects.lblmsgStatus.Text = "YOU HAVE ADDED THIS CODE"
            Me.Dispose()
        Else



            Dim DefectDate As DateTime = Handler.GenerateTimeZone() 'Now.Year & "-" & Now.Month & "-" & Now.Day.ToString("D2") & Space(1) & Now.Hour.ToString("D2") & ":" & Now.Minute.ToString("D2")

            Dim CodeIdentification As String
            Dim arrID1() As String
            Dim arrID2() As String
            Dim arrID3() As String

            Dim ValIdent As String
            Dim arrIdent() As String
            Dim arrIdent2() As String
            arrIdent = Label4.Text.Replace("'", " ").Split(".")
            arrIdent2 = Label5.Text.Replace("'", " ").Split(".")


            ValIdent = arrIdent2(4).Remove(0, 1) & Space(1) & ":" & Space(1) & arrIdent(2).Remove(0, 1)

            arrID1 = Label2.Text.Split(".")
            arrID2 = Label4.Text.Split(".")
            arrID3 = Label5.Text.Split(".")


            CodeIdentification = arrID1(0) & arrID2(0) & arrID3(0) & arrID2(1) & arrID3(0) & arrID3(2) & "0" & arrID3(3)
            Dim visualCode = Label5.Text.Trim
            Dim arr() = visualCode.Split(" ")
            visualCode = arr(0).Trim

            Dim helper As New Helpers

            If (helper.DefectCodeExists(Handler.InspectionNo, visualCode)) Then
                MessageBox.Show("Defect code already added")
                Exit Sub
            End If
            If (Handler.dTDefects.Rows.Count > 0) Then
                For Each obj In Handler.dTDefects.Rows
                    If (obj("DefectDesc").contains(visualCode)) Then
                        MessageBox.Show("Defect code already added")
                        Exit Sub
                    End If
                Next
            End If

            'Dim DefectDesc As String = "No Inspector:" & Space(1) & lblInspectorID.Text & " - No Lane: " & Handler.Lane & " - No Section: " & Handler.Section & " - Defect CD:!" & CodeIdentification & "! - Defect Location:#" & Fleft1 & "" & Mleft1 & "" & Rleft1 & "" & Cleft1 & "" & CC1 & "" & CD1 & "" & RL1 & "" & RM1 & "" & RR1 & "" & Minor1 & "" & Major1 & "# - @ " & ValIdent & "@" & Label5.Text.Substring(0, 9) & " "
            Dim DefectDesc As String = "No Inspector:" & Space(1) & lblInspectorID.Text & " - No Lane: " & Handler.Lane & " - No Section: " & Handler.Section & " - Defect CD: !" & CodeIdentification & "! - @" & ValIdent & " " & visualCode & " @ - Defect Location:#" & Fleft1 & "" & Mleft1 & "" & Rleft1 & "" & Cleft1 & "" & CC1 & "" & CD1 & "" & RL1 & "" & RM1 & "" & RR1 & "" & Minor1 & "" & Major1 & "#- " & Handler.getDefectCodeResult(visualCode)

            ' Dim sqlInsertCode1 As String
            Dim Value1 As String
            Dim Value11 As String

            Value1 = ValIdent & "-" & Label5.Text.Substring(0, 9)

            If Fleft1 <> "" Then Value11 = "[" & Fleft1 & "]"
            If Mleft1 <> "" Then Value11 = Value1 & "[" & Mleft1 & "]"
            If Rleft1 <> "" Then Value11 = Value1 & "[" & Rleft1 & "]"
            If Cleft1 <> "" Then Value11 = Value1 & "[" & Cleft1 & "]"
            If CC1 <> "" Then Value11 = Value1 & "[" & CC1 & "]"
            If CD1 <> "" Then Value11 = Value1 & "[" & CD1 & "]"
            If RL1 <> "" Then Value11 = Value1 & "[" & RL1 & "]"
            If RM1 <> "" Then Value11 = Value1 & "[" & RM1 & "]"
            If RR1 <> "" Then Value11 = Value1 & "[" & RR1 & "]"
            If Minor1 <> "" Then Value11 = Value1 & "[" & Minor1 & "]"
            If Major1 <> "" Then Value11 = Value1 & "[" & Major1 & "]"

            ' Value11 = Fleft1 & Mleft1 & Rleft1 & Cleft1 & CC1 & CD1 & RL1 & RM1 & RR1 & Minor1 & Major1

            Handler.PopulateDefectTbl(DefectDesc, Handler.InspectionNo, DefectDate)


            My.Forms.Defects.Show()
            'My.Forms.Defects.lblCarDefect.Text = Label1.Text

            My.Forms.Defects.lblmsgStatus.Visible = True
            My.Forms.Defects.lblmsgStatus.ForeColor = Color.Green
            My.Forms.Defects.lblmsgStatus.Text = "SUCCEFULLY ADDED"

            'Me.Dispose()
            Me.Dispose()

            ' Me.close()

        End If


    End Sub

    Private Sub btnLogOut_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) 
        My.Forms.SYSTEMLOGIN.Show()
        My.Forms.SYSTEMLOGIN.txtUser.ResetText()
        My.Forms.SYSTEMLOGIN.txtPwd.ResetText()
        My.Forms.SYSTEMLOGIN.txtUser.Focus()
        My.Forms.SYSTEMLOGIN.lblmsg.ResetText()
        lblPlate.ResetText()
        Me.Close()
    End Sub


    Private Sub btnESC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnESC.Click



        Label6.Text = ""
        RichTextBox1.Text = " "
        LabelComments.Text = " "
        RichTextBox1.Visible = False

        LabelComments.Visible = False
        'My.Forms.Defects.lblCarDefect.Text = Label1.Text

        Defects.Show()
        Me.Dispose()
    End Sub

    Private Sub btnESC_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles btnESC.KeyDown, Button15.KeyDown, RichTextBox1.KeyDown
        If e.KeyCode = Keys.Escape Then
            'btnEsc.Focus()
            'Me.Close()
            Label6.Text = ""
            'My.Forms.Defects.lblCarDefect.Text = Label1.Text

            Defects.Show()
            RichTextBox1.Visible = False
            RichTextBox1.Text = " "
            LabelComments.Text = " "

            LabelComments.Visible = False
            Me.Dispose()
        End If

        If e.KeyCode = Keys.F4 Then

            Call Button15_Click(Nothing, Nothing)

        End If

        If e.KeyCode = Keys.F7 Then
            RichTextBox1.Visible = True


        End If
    End Sub



    Private Sub btnFrontLeft_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFrontLeft.Click, btnFrontMiddle.Click, btnFrontRight.Click, btnCenterLeft.Click, btnCenter.Click, BtnCenterRight.Click, btnRearLeft.Click, btnRearMiddle.Click, btnRearRight.Click, btnMinorDefect.Click, btnMajorDefect.Click
        'btnFrontLeft.BackColor = Color.Silver
        Select Case True
            Case sender Is btnFrontLeft

                'Code for Button1 clicked
                Fleft1 = "AVG"
                btnFrontLeft.BackColor = Color.Red
                '*******************************************************
            Case sender Is btnFrontMiddle
                btnFrontMiddle.BackColor = Color.Red
                Mleft1 = "AVC"

                '********************************************
            Case sender Is btnFrontRight
                btnFrontRight.BackColor = Color.Red
                Rleft1 = "AVD"
                '********************************
            Case sender Is btnCenterLeft
                btnCenterLeft.BackColor = Color.Red
                Cleft1 = "CG"
                '****************

            Case sender Is btnCenter
                btnCenter.BackColor = Color.Red
                CC1 = "CC"
                '*************

            Case sender Is BtnCenterRight
                BtnCenterRight.BackColor = Color.Red
                CD1 = "CD"

                '****************

            Case sender Is btnRearLeft
                btnRearLeft.BackColor = Color.Red
                RL1 = "ARG"
                '***********************
            Case sender Is btnRearMiddle

                btnRearMiddle.BackColor = Color.Red
                RM1 = "ARC"
                '*************************

            Case sender Is btnRearRight
                btnRearRight.BackColor = Color.Red
                RR1 = "ARD"

                '*******************************
            Case sender Is btnMinorDefect
                btnMinorDefect.BackColor = Color.Red
                Minor1 = "Minor Defect"
                '***********************************

            Case sender Is btnMajorDefect
                btnMajorDefect.BackColor = Color.Red
                Major1 = "Major Defect"
        End Select
    End Sub


End Class