Imports Microsoft.Reporting.WinForms

Public Class Certificate
    Private Sub Certificate_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.Width = My.Computer.Screen.WorkingArea.Size.Width - 50
        Me.Height = My.Computer.Screen.WorkingArea.Size.Height - 50
        Me.Top = My.Computer.Screen.WorkingArea.Top + 20
        Me.Left = My.Computer.Screen.WorkingArea.Left + 20
        Dim opExec As New connection
        Dim sql As String = ""
        Dim dc As New Dictionary(Of String, String)

        sql = "select * from DEFECTS_Tmp where inspectionNo = '" & Handler.InspectionNo & "' "

        Dim reader As SqlClient.SqlDataReader = opExec.rdGetReader(sql)


        'If reader.HasRows = True Then
        '    Using db As New VTSEntities
        '        VTSEntitiesBindingSource.DataSource = reader ' db.DEFECTS_Tmp.ToList()
        '        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "VTS.Report1.rdlc"
        '        ReportViewer1.ProcessingMode = ProcessingMode.Local

        '        Dim ChassisParam As New ReportParameter("ChassiParam", Handler.Chassis)
        '        ReportViewer1.LocalReport.SetParameters(ChassisParam)
        '        '' ReportViewer1.LocalReport.SetParameters((New ReportParameter("ChassiParam"))

        '        Dim PlateParam As New ReportParameter("PlateParam", Handler.Plate)
        '        ReportViewer1.LocalReport.SetParameters(PlateParam)

        '        Me.ReportViewer1.RefreshReport()
        '    End Using
        'End If






    End Sub
End Class