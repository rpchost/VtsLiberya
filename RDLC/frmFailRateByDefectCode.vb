Public Class frmFailRateByDefectCode
    Private Sub FrmFailRateByDefectCode_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Using db As New VTSEntitiesFailRateByDefectcode

            RptFailRateByDefectCode_ResultBindingSource.DataSource = db.RptFailRateByDefectCode(DateTimePicker1.Value.ToShortDateString, DateTimePicker2.Value.ToShortDateString, txtStation.Text, txtDefectCode.Text, txtVisit.Text, txtVehicleType.Text, txtVehicleCategory.Text).ToList()

        End Using

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class