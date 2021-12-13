Public Class ReviewMeasurementRepeat

    Dim dcDefectsToRemove As New Dictionary(Of String, String)

    Private Sub ReviewMeasurementRepeat_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim i As Integer
        Dim arr() As String


        Me.WindowState = FormWindowState.Maximized

        header.Width = Me.Width
        header.Height = 100


        lblInspectionNo.Text = Handler.InspNo
        lblInspectorID.Text = Handler.InspectorID
        lblPlate.Text = Handler.Plate

        If (Handler.IType = "I") Then
            lblVisitType.Text = "Fst Visit"
        ElseIf (Handler.IType = "R") Then
            lblVisitType.Text = "Repeat Visit"
        Else
            lblVisitType.Text = ""
        End If

        For Each ikey In getDefectCodes(Handler.InspectionNo)

            Dim btnDefect As New Windows.Forms.Button
            Dim lblDefectDesc As New Label

            arr = ikey.Value.Split("@")

            btnDefect.Size = New Size(180, 50)

            btnDefect.AutoSize = True
            btnDefect.Name = "btnDefect" & i
            btnDefect.Text = ikey.Key & "-" & arr(2).Trim
            btnDefect.Font = New Font("Arial", 11, FontStyle.Bold)
            btnDefect.BackColor = Color.Green
            btnDefect.ForeColor = Color.White
            btnDefect.Top = i * 80
            btnDefect.Left = 25

            lblDefectDesc.Text = ikey.Value
            lblDefectDesc.Font = New Font("Arial", 11, FontStyle.Bold)
            lblDefectDesc.MaximumSize = New Size(650, 0)
            lblDefectDesc.AutoSize = True
            lblDefectDesc.Top = i * 80
            lblDefectDesc.Left = btnDefect.Width + 50

            i = i + 1

            AddHandler btnDefect.Click, AddressOf Defect

            pnl.Controls.Add(btnDefect)
            pnl.Controls.Add(lblDefectDesc)

            pnl.Refresh()

        Next

    End Sub


    Private Function Defect(ByVal sender As Object, ByVal e As EventArgs) As Boolean
        Dim arr() As String

        Dim btn As Button = DirectCast(sender, Button)
        arr = btn.Text.Split("-")

        If (btn.BackColor = Color.Green) Then
            btn.BackColor = Color.Red

            dcDefectsToRemove.Add(arr(0), arr(1))

        Else
            btn.BackColor = Color.Green
            If (dcDefectsToRemove.ContainsKey(arr(0))) Then
                dcDefectsToRemove.Remove(arr(0))
            End If
        End If

    End Function


    Private Function getDefectCodes(inspectionNo As String) As Dictionary(Of String, String)

        Dim str As String = ""
        Dim opExec As New connection
        Dim sql As String = ""
        Dim dc As New Dictionary(Of String, String)

        sql = "select * from DEFECTS_TMP where inspectionNo =  '" & inspectionNo & "' "

        Dim reader As SqlClient.SqlDataReader = opExec.rdGetReader(sql)
        Try
            Dim arr() As String

            If reader.HasRows = True Then

                While reader.Read()
                    'arr = reader("DEFECTDESC").split("@")

                    dc.Add(reader("ID"), reader("DEFECTDESC"))
                End While

            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            opExec.closeConnection()
        End Try

        Return dc


    End Function

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click

        If MsgBox("Are you sure you want to remove defect Codes ?", vbQuestion Or vbYesNo Or vbDefaultButton2, "Confirm Vehicle Inspection") = vbYes Then

            Dim opExec As New connection
            For Each ikey In dcDefectsToRemove.Keys
                opExec.ExecuteSqlCommand(" delete from defects_Tmp where ID =  " & ikey)
                opExec.closeConnection()

                MessageBox.Show("Codes deleted successfuly")
                Me.Dispose()

            Next



        End If

    End Sub

    Private Sub BtnMeasureEsc_Click(sender As Object, e As EventArgs) Handles btnMeasureEsc.Click
        Me.Dispose()
    End Sub
End Class