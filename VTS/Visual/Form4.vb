Public Class Form4
    Dim conn1 As New connection
    Dim sql1 As String
    Dim dt1 As New Data.DataTable

    Private Sub Form4_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Label2.Text = ""



        sql1 = "select * from CodeDefects  where plateNO='b123456' and DeletedCode='NO' order by VisuelID asc"
        dt1 = conn1.ExecuteReaderdt(sql1)
        For i = 0 To dt1.Rows.Count - 1
            Label2.Text = Label2.Text & dt1.Rows(i).Item("DefectCode") & Environment.NewLine
        Next
        'Label2.Refresh()
    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        My.Forms.Vehicles.lblPlate.Text = Label1.Text
        'My.Forms.Vehicles.btnVisual.Enabled = True
        'My.Forms.Vehicles.btnReview.Enabled = True
        'My.Forms.Vehicles.btnStore.Enabled = True
        ''My.Forms.Vehicles.btnSelect.Enabled = False
        'My.Forms.Vehicles.btnDeleted.Enabled = True

        Vehicles.Show()
        Vehicles.Refresh()
       Me.Dispose()
    End Sub
End Class