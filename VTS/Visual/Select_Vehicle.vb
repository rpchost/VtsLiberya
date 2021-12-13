Imports System.IO
Public Class Select_Vehicle
    Dim conn As New connection
    Dim sql As String
    Dim dt As New Data.DataTable
    Dim str As String

    Dim HsT As Hashtable
    Dim lst As List(Of String)


    Private Sub Select_Vehicle_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        header.Width = Me.Width
        header.Height = 100

        lblInspectorID.Text = Handler.InspectorID
        lblGroup.Text = Handler.GroupName
        lblLane.Text = IIf(Handler.Lane <> "", "Lane : " & Handler.Lane, "")
        lblSection.Text = IIf(Handler.Section <> "", "Section : " & Handler.Section, "")

        LoadVehicles()

        Dim Interval As String = Handler.GetTimerInterval()
        Timer1.Interval = IIf(Interval = "", 10000, Interval)
        Timer1.Start()
    End Sub

    Private Sub btnEscVehicle_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Escape Then

            My.Forms.Vehicles.lblPlate.Visible = True

            Vehicles.Show()
            Me.Dispose()
        End If
    End Sub
    Private Sub btnEscVehicle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        My.Forms.Vehicles.lblPlate.Visible = True

        Vehicles.Show()
        Me.Dispose()
    End Sub

    Private Sub btnSignOut_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSignOut.Click
        Label1.ResetText()
        My.Forms.SYSTEMLOGIN.Show()
        My.Forms.SYSTEMLOGIN.txtUser.ResetText()
        My.Forms.SYSTEMLOGIN.txtPwd.ResetText()
        My.Forms.SYSTEMLOGIN.txtUser.Focus()
        My.Forms.SYSTEMLOGIN.lblmsg.ResetText()
        Me.Dispose()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
        Dispose()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        LoadVehicles()
    End Sub

    Private Sub LoadVehicles()
        Dim str As String
        Dim dtCar As New Data.DataTable

        str = "select distinct plateno, inspectionactive.chassisno from cardaftar inner join inspectionactive on cardaftar.chassisno=inspectionactive.chassisno and esincreated=1 and inspectionactive.Lane = " & Handler.Lane
        dtCar = conn.ExecuteReaderdt(str)

        lstVehicle.DataSource = dtCar
        lstVehicle.DisplayMember = "Plateno"
        lstVehicle.ValueMember = "chassisno"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Me.Dispose()
    End Sub
    Private Sub lstVehicle_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles lstVehicle.MouseDoubleClick
        If (Handler.dTDefects IsNot Nothing) Then
            Handler.dTDefects.Dispose()
        End If

        'Dim sqlLabelCar As String
        'Dim dtLabelCar As New Data.DataTable
        'sqlLabelCar = "select * from inspectionactive  where Chassisno='" & lstVehicle.SelectedValue & "' order by testdate desc"
        'dtLabelCar = conn.ExecuteReaderdt(sqlLabelCar)

        Dim helper As New Helpers
        Dim InspectionActive = helper.GetLastInspectionActive(lstVehicle.SelectedValue)

        Handler.InspectionNo = InspectionActive("InspectionNo") 'dtLabelCar.Rows(0).Item("InspectionNo")
        Handler.Plate = lstVehicle.GetItemText(lstVehicle.SelectedItem)
        Handler.InspNo = Handler.FillInspNo(InspectionActive("InspectionNo"))
        Handler.IType = InspectionActive("IType") 'dtLabelCar.Rows(0).Item("IType")

        If (Handler.IType = "R") Then
            Handler.LastInspectionNo = Handler.GetEsCodeValue(Handler.Plate, "OUT", "PROCESS_SUCCESS", "10304").Trim().Replace("C", "I")
        Else
            Handler.LastInspectionNo = ""
        End If

        Handler.InspType = InspectionActive("InspType") 'dtLabelCar.Rows(0).Item("InspType")
        Handler.Lane = InspectionActive("Lane") 'dtLabelCar.Rows(0).Item("Lane")
        Handler.userId = InspectionActive("userId") 'IIf(IsDBNull(dtLabelCar.Rows(0).Item("user_Fk")), "", dtLabelCar.Rows(0).Item("user_Fk"))
        Handler.Chassis = InspectionActive("Chassis") 'dtLabelCar.Rows(0).Item("ChassisNo")
        Handler.StationName = InspectionActive("StationName") 'IIf(IsDBNull(dtLabelCar.Rows(0).Item("StationName")), "", dtLabelCar.Rows(0).Item("StationName"))

        My.Forms.Vehicles.lblPlate.Visible = True

        Vehicles.Vehicles_Load(sender, e)
        Vehicles.Show()

        Me.Dispose()

    End Sub
End Class