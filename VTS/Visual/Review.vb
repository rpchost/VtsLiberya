Public Class Review
    Dim conn As New connection
    Dim sql As String
    Dim dt As New Data.DataTable
    Private Sub Review_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        header.Width = Me.Width
        header.Height = 100

        lblInspectionNo.Text = Handler.InspNo
        lblInspectorID.Text = Handler.InspectorID
        lblPlate.Text = Handler.Plate

        sql = "select * from cardaftar where plateno='" & lblReview.Text & "'"

        dt = conn.ExecuteReaderdt(sql)

        If dt.Rows.Count > 0 Then
            Label9.Text = dt.Rows(0).Item("chassisno")
            Label10.Text = dt.Rows(0).Item("owner")
            If IsDBNull(dt.Rows(0).Item("manufacturer")) = True Then
                Label11.Text = ""
            Else
                Label11.Text = dt.Rows(0).Item("manufacturer")

            End If

            If IsDBNull(dt.Rows(0).Item("DateManufactured")) = True Then
                Label12.Text = ""
            Else
                Label12.Text = dt.Rows(0).Item("DateManufactured")
            End If

            If IsDBNull(dt.Rows(0).Item("model")) = True Then
                Label13.Text = ""
            Else
                Label13.Text = dt.Rows(0).Item("model")

            End If

            If IsDBNull(dt.Rows(0).Item("TypeVisit")) = True Then
                Label14.Text = ""
            Else
                Label14.Text = dt.Rows(0).Item("TypeVisit")
            End If


        End If


    End Sub

  
    Private Sub btnEscReview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEscReview.Click
        My.Forms.Vehicles.lblPlate.Text = lblReview.Text
        'My.Forms.Vehicles.btnVisual.Enabled = True
        'My.Forms.Vehicles.btnReview.Enabled = True
        'My.Forms.Vehicles.btnStore.Enabled = True
        ''My.Forms.Vehicles.btnSelect.Enabled = False
        'My.Forms.Vehicles.btnDeleted.Enabled = True

        Vehicles.Show()
       Me.Dispose()
    End Sub
End Class