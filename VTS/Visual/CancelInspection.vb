Imports System.IO

Public Class CancelInspection
    Private Sub txtPlate_TextChanged(sender As Object, e As EventArgs) Handles txtPlate.TextChanged
        Dim str As String = ""
        Dim opExec As New connection

        Dim sqlReader = "select i.InspectionNo,i.Lane from InspectionActive i inner join Cardaftar c on i.Chassisno = c.chassisno where c.plateno = '" & txtPlate.Text & "'"
        Try

            Dim dtReader As New Data.DataTable
            dtReader = opExec.ExecuteReaderdt(sqlReader)

            lstInspections.DataSource = dtReader
            lstInspections.DisplayMember = "InspectionNo"
            lstInspections.ValueMember = "Lane"

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            opExec.closeConnection()
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub btnUpdateData_Click(sender As Object, e As EventArgs) Handles btnUpdateData.Click
        Dim opExec As New connection
        If (lstInspections.GetItemText(lstInspections.SelectedItem) = "") Then
            Return
        End If

        If MsgBox($"Are you sure you want to cancel this inspection ?", vbQuestion Or vbYesNo Or vbDefaultButton2, "Confirm Delete Vehicle Inspection") = vbYes Then

            Dim sqlInsertInspectionHistory = "insert into inspectionHistory (INSPECTIONNO, CHASSISNO, LANE, FEEAMOUNT, CASHIERNAME, InspType,IType,stationname) select INSPECTIONNO, CHASSISNO, Lane, FEEAMOUNT,CASHIERNAME,InspType,IType,stationname from inspectionactive where inspectionno = '" & lstInspections.GetItemText(lstInspections.SelectedItem) & "'"
            Dim execInsert = opExec.ExecuteSqlCommand(sqlInsertInspectionHistory)
            If (execInsert.Item1 = True) Then
                Dim sqlDeleteInspectionActive = "delete from InspectionActive where inspectionno = '" & lstInspections.GetItemText(lstInspections.SelectedItem) & "' "
                Dim execDelete = opExec.ExecuteSqlCommand(sqlDeleteInspectionActive)

                If (execDelete.Item1 = False) Then
                    MessageBox.Show($"Error while deleting inspectionactive; {execDelete.Item2}")
                    Exit Sub
                Else
                    'Flag InspectionHistory type as Aborted

                    Dim sqlFlagInspectionHistory = "update inspectionHistory set InspType = 'A',IType='C', UPDATETIME = '" & Handler.GenerateTimeZone & "' where inspectionno = '" & lstInspections.GetItemText(lstInspections.SelectedItem) & "'  "
                    Dim execFlagInspectionHistory = opExec.ExecuteSqlCommand(sqlFlagInspectionHistory)

                    Dim getSections As New Helpers

                    For Each folder In getSections.GetSections("RYME", "IN", lstInspections.SelectedValue.ToString())
                        If (File.Exists(folder.Value & "\" & txtPlate.Text & ".txt")) Then
                            File.Delete(folder.Value & "\" & txtPlate.Text & ".txt")
                        End If
                    Next

                    'Delete the file from EsOut VTS
                    If (File.Exists(Handler.GetEsLocation("OUT", "VTS") & "\" & txtPlate.Text & ".txt")) Then
                        File.Delete(Handler.GetEsLocation("OUT", "VTS") & "\" & txtPlate.Text & ".txt")
                    End If

                    MessageBox.Show("Inspection cancelled successfully")
                    txtPlate.Text = ""
                End If
                opExec.closeConnection()
            Else
                MessageBox.Show("Inspection failed to cancel")

            End If
        End If
    End Sub

    Private Sub CancelInspection_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If (Handler.Plate <> Nothing And Handler.Plate <> "") Then
            txtPlate.Text = Handler.Plate
        End If
    End Sub
End Class