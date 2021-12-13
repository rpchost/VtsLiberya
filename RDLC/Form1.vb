Imports Microsoft.Reporting.WinForms

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load







    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Using db As New VTSEntities

            RPTFstVisitFailRateByLane_ResultBindingSource.DataSource = db.RPTFstVisitFailRateByLane(DateTimePicker1.Value, DateTimePicker2.Value, txtStation.Text).ToList()

        End Using

        Me.ReportViewer1.RefreshReport()

    End Sub
End Class
