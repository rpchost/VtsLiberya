Imports System.IO
Imports System.IO.FileInfo

Public Class ReviewMeasurement
    Dim conn As New connection
    Dim sql As String
    Dim dt As New Data.DataTable
    Dim j As Integer
    Dim constr As String
    Dim constr2 As String

    Dim DefectDate As String
    Dim DefectHour As String
    Dim arrCode() As String

    Private Sub ReviewMeasurement_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        header.Width = Me.Width
        header.Height = 100

        CheckedListBox1.Width = Me.Width

        Dim CertificateNo As String = ""
        If (Handler.InspectionNo <> Nothing) Then
            Try
                If (Handler.IType = "R") Then
                    If (Handler.LastInspectionNo <> "") Then
                        Handler.dTDefects = Handler.ApplyDbToHtDefect("DEFECTS_Tmp", Handler.LastInspectionNo)
                    Else
                        MessageBox.Show("No LastInspectionNo found, most probably last visit process Esout file was not found")
                        Exit Sub
                    End If
                End If
            Catch ex As Exception
                MessageBox.Show("Error loading the Defects Code for " & Handler.InspectionNo)
            End Try
        End If

        Try

            CheckedListBox1.DataSource = Handler.dTDefects
            CheckedListBox1.DisplayMember = "DefectDesc"
            CheckedListBox1.ValueMember = "ID"

            lblInspectionNo.Text = Handler.InspNo
            lblInspectorID.Text = Handler.InspectorID
            lblPlate.Text = Handler.Plate

        Catch ex As Exception
            MessageBox.Show("You must choose defect codes first")
        End Try

    End Sub


    Private Sub btnRemove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemove.Click

        Dim dd As New DataSet

        Dim strFile As String = Handler.GetEsLocation("OUT", "VTS") & "\" & Handler.Plate & ".txt"

        If (IO.File.Exists(strFile)) Then
            MessageBox.Show("You can not delete defects; vehicle is already stored Intermediate")
            Return
        End If


        If (CheckedListBox1.CheckedItems.Count = 0) Then
            MessageBox.Show("You must select at least 1 defect to delete")
            Return
        End If


        j = MessageBox.Show("Are you sure you want to delete the record(s) ?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If j = MsgBoxResult.Yes Then

                If CheckedListBox1.CheckedItems.Count > 0 Then
                    Dim sb As New System.Text.StringBuilder

                Try
                    For Each obj In CheckedListBox1.CheckedItems

                        Handler.deleteDefectsRow("ID", obj.row.itemArray(0).ToString)
                        Handler.CopyDT(Handler.dTDefects)

                        If (Handler.InspType.Equals("R")) Then
                            Handler.PopulateDelCodesTbl(Handler.InspectionNo, Handler.GenerateTimeZone(), Handler.InspectorID, Handler.Lane, Handler.Section, obj.row.itemArray(2))
                        End If
                    Next
                Catch ex As Exception
                End Try

            End If

        End If

    End Sub


    Private Sub btnMeasureEsc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMeasureEsc.Click
        'My.Forms.Vehicles.btnVisual.Enabled = True
        'My.Forms.Vehicles.btnReview.Enabled = True
        'My.Forms.Vehicles.btnStore.Enabled = True
        ''My.Forms.Vehicles.btnSelect.Enabled = False
        'My.Forms.Vehicles.btnDeleted.Enabled = True

        Vehicles.Show()
       Me.Dispose()
    End Sub


    Private Sub btnLogout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        My.Forms.SYSTEMLOGIN.Show()
        My.Forms.SYSTEMLOGIN.txtUser.ResetText()
        My.Forms.SYSTEMLOGIN.txtPwd.ResetText()
        My.Forms.SYSTEMLOGIN.txtUser.Focus()
        My.Forms.SYSTEMLOGIN.lblmsg.ResetText()
        Me.Dispose()
    End Sub


End Class