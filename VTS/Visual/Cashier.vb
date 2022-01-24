Imports System.Globalization

Public Class Cashier

    Public exist As Boolean

    Private Sub Cashier_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim newCulture As CultureInfo = DirectCast(System.Threading.Thread.CurrentThread.CurrentCulture.Clone(), CultureInfo)
        newCulture.DateTimeFormat.ShortDatePattern = "dd/MMM/yyyy"
        newCulture.DateTimeFormat.DateSeparator = "-"
        Threading.Thread.CurrentThread.CurrentCulture = newCulture

        Me.Width = My.Computer.Screen.WorkingArea.Size.Width
        Me.Height = My.Computer.Screen.WorkingArea.Size.Height
        Me.Top = My.Computer.Screen.WorkingArea.Top
        Me.Left = My.Computer.Screen.WorkingArea.Left
        header.Width = My.Computer.Screen.WorkingArea.Size.Width
        header.Height = 100
        Me.WindowState = FormWindowState.Maximized

        Dim VehicleType As New List(Of Vehicle.Type)

        Dim vehicle As New Vehicle.Type

        vehicle.TypeName = ""
        vehicle.TypeValue = 0
        VehicleType.Add(vehicle)

        vehicle = New Vehicle.Type
        vehicle.TypeName = "Truck"
        vehicle.TypeValue = 1
        VehicleType.Add(vehicle)

        vehicle = New Vehicle.Type
        vehicle.TypeName = "Car"
        vehicle.TypeValue = 2
        VehicleType.Add(vehicle)

        vehicle = New Vehicle.Type
        vehicle.TypeName = "Moto"
        vehicle.TypeValue = 3
        VehicleType.Add(vehicle)

        cmbVehicleType.DataSource = VehicleType
        cmbVehicleType.DisplayMember = "TypeName"
        cmbVehicleType.ValueMember = "TypeValue"

        Dim str As String = ""

        lblCashier.Text = Handler.InspectorID

        Dim helper As New Helpers
        If (txtChassis.Text.Trim <> "" And txtPlate.Text.Trim <> "") Then lblVisitType.Text = helper.GetVisitNature(txtChassis.Text.Trim)

    End Sub

    Public Sub txtPlate_TextChanged(sender As Object, e As EventArgs) Handles txtPlate.TextChanged
        Dim str As String = ""
        Dim opExec As New connection

        lblVisitType.Text = ""
        CancelInspection.Enabled = True
        btnSendInspection.Enabled = True

        Dim reader As SqlClient.SqlDataReader = opExec.rdGetReader("select * from Cardaftar where plateno = '" & txtPlate.Text & "'")
        Try

            If reader.HasRows = True Then

                reader.Read()

                txtChassis.Text = IIf(IsDBNull(reader("Chassisno")), "", reader("Chassisno"))
                txtAddress.Text = IIf(IsDBNull(reader("ADDRESS1")), "", reader("ADDRESS1"))
                txtDateOwnership.Text = IIf(IsDBNull(reader("DATEMANUFACTURED")), "", reader("DATEMANUFACTURED"))
                txtEnginePower.Text = IIf(IsDBNull(reader("EnginePower")), "", reader("EnginePower"))
                txtMake.Text = IIf(IsDBNull(reader("MAKE")), "", reader("MAKE"))
                txtManufacturer.Text = IIf(IsDBNull(reader("MANUFACTURER")), "", reader("MANUFACTURER"))
                cmbFuelType.Text = IIf(IsDBNull(reader("FuelType")), "", reader("FuelType"))
                txtPhone.Text = IIf(IsDBNull(reader("Phone")), "", reader("Phone"))
                txtOwner.Text = IIf(IsDBNull(reader("OWNER")), "", reader("OWNER"))
                txtColor.Text = IIf(IsDBNull(reader("Color")), "", reader("Color"))
                txtModel.Text = IIf(IsDBNull(reader("Model")), "", reader("Model"))
                txtWeight.Text = IIf(IsDBNull(reader("WeightTotal")), "", reader("WeightTotal"))

                chk4Wd.Checked = IIf(IsDBNull(reader("FourWd")), False, reader("FourWd"))
                cmbVehicleType.SelectedValue = IIf(IsDBNull(reader("VehicleCategory")), "", reader("VehicleCategory"))

                exist = True

                If (txtChassis.Text.Trim <> "" And txtPlate.Text.Trim <> "") Then
                    Dim helper As New Helpers
                    Dim VistNature = helper.GetVisitNature(txtChassis.Text.Trim)
                    If (VistNature = "Y") Then
                        lblVisitType.Text = "First Visit"
                    ElseIf (VistNature = "R") Then
                        lblVisitType.Text = "Repeat Visit"
                    ElseIf (VistNature = "RP") Then
                        lblVisitType.Text = "Already passed"
                        CancelInspection.Enabled = False
                        btnSendInspection.Enabled = False
                    End If

                    Dim InspActive = helper.GetLastInspectionActive(txtChassis.Text.Trim)
                    If (InspActive.Count > 0) Then
                        lblInspNo.Text = $"{InspActive("InspectionNo") } on Lane [{InspActive("Lane")}]"
                        cmbFeeLabel.Text = InspActive("FeeLabel")
                        lblStation.Text = InspActive("StationName")
                    Else
                        lblInspNo.Text = ""
                        cmbFeeLabel.Text = ""
                    End If
                End If

            Else
                exist = False

                txtChassis.Text = ""
                txtAddress.Text = ""
                txtDateOwnership.Text = ""
                txtEnginePower.Text = ""
                txtMake.Text = ""
                txtManufacturer.Text = ""
                cmbFuelType.Text = ""
                cmbFeeLabel.Text = ""
                lblStation.Text = ""
                lblInspNo.Text = ""
                txtPhone.Text = ""
                txtOwner.Text = ""
                txtModel.Text = ""
                txtWeight.Text = ""
                txtColor.Text = ""
                chk4Wd.Checked = False
                cmbVehicleType.Text = ""
            End If

        Catch ex As Exception
            MessageBox.Show("Wrong data input")
        Finally
            opExec.closeConnection()
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Dispose()
    End Sub

    Private Sub btnSendInspection_Click(sender As Object, e As EventArgs) Handles btnSendInspection.Click

        Dim userFk As Integer = Handler.UserFk(Handler.InspectorID)
        Dim sqlCardaftar As String = ""
        Dim opExec As New connection


        If (txtPlate.Text = "" Or txtChassis.Text = "" Or cmbLane.Text = "" Or txtDateOwnership.Text = "" Or txtManufacturer.Text = "" Or txtMake.Text = "" Or txtEnginePower.Text = "" Or cmbFuelType.Text = "" Or txtWeight.Text = "" Or cmbVehicleType.Text = "") Then
            MessageBox.Show("You must fill required fields")
            Exit Sub
        End If

        If (Not IsNumeric(txtDateOwnership.Text)) Then
            MessageBox.Show("Date ownership must be numeric")
            Exit Sub
        End If

        If (Not IsNumeric(txtEnginePower.Text)) Then
            MessageBox.Show("Engine Power must be numeric")
            Exit Sub
        End If

        If (Not IsNumeric(txtWeight.Text)) Then
            MessageBox.Show("Weight must be numeric")
            Exit Sub
        End If

        If (Not IsNumeric(cmbLane.Text)) Then
            MessageBox.Show("Lane must be numeric")
            Exit Sub
        End If

        If (cmbFuelType.Text <> "P" And cmbFuelType.Text <> "D" And cmbFuelType.Text <> "G") Then
            MessageBox.Show("Fuel type is not valid")
            Exit Sub
        End If
        If (cmbVehicleType.Text <> "Truck" And cmbVehicleType.Text <> "Car" And cmbVehicleType.Text <> "Moto") Then
            MessageBox.Show("Vehivle type is not valid")
            Exit Sub
        End If

        Dim helper As New Helpers
        If helper.InspectionActiveExist(txtChassis.Text.Trim()) = True Then
            MessageBox.Show("There is already an inspection active for this Chassis")
            Exit Sub
        End If

        If (exist = True) Then
            sqlCardaftar = "update cardaftar set FourWD = " & CInt(chk4Wd.Checked) & ", VehicleCategory = " & cmbVehicleType.SelectedValue & ", Model = '" & txtModel.Text & "', Color = '" & txtColor.Text & "', WeightTotal = '" & txtWeight.Text & "', ADDRESS1 = '" & txtAddress.Text & "', DATEMANUFACTURED ='" & txtDateOwnership.Text & "' ,EnginePower ='" & txtEnginePower.Text & "',MAKE ='" & txtMake.Text & "' , MANUFACTURER = '" & txtManufacturer.Text & "',Phone = '" & txtPhone.Text & "', FuelType = '" & cmbFuelType.Text & "',  OWNER = '" & txtOwner.Text & "' ,UPDATEDATE = '" & Handler.GenerateTimeZone() & "',HOSTNAME = '" & System.Environment.MachineName & "',USERNAME = '" & Handler.InspectorID & "' WHERE PLATENO = '" & txtPlate.Text & "' and chassisno = '" & txtChassis.Text & "' and UPDATEDATE = '" & Handler.GenerateTimeZone() & "' "
            Dim execUpdate = opExec.ExecuteSqlCommand(sqlCardaftar)
            If (execUpdate.Item1 = False) Then
                MessageBox.Show($"Error while updating cardaftar; {execUpdate.Item2}")
                Exit Sub
            End If
        Else
            sqlCardaftar = "insert into cardaftar (plateno, chassisno,FourWD,VehicleCategory, Model,Color, WeightTotal, ADDRESS1, DATEMANUFACTURED, EnginePower, MAKE, MANUFACTURER,Phone, FuelType,[OWNER],  user_fk, UPDATEDATE,HOSTNAME,USERNAME) values ('" & txtPlate.Text & "','" & txtChassis.Text & "'," & CInt(chk4Wd.Checked) & "," & cmbVehicleType.SelectedValue & ",'" & txtModel.Text & "','" & txtColor.Text & "','" & txtWeight.Text & "','" & txtAddress.Text & "','" & txtDateOwnership.Text & "' , '" & txtEnginePower.Text & "', '" & txtMake.Text & "' ,  '" & txtManufacturer.Text & "', '" & txtPhone.Text & "',  '" & cmbFuelType.Text & "',   '" & txtOwner.Text & "'," & userFk & ",'" & Handler.GenerateTimeZone() & "','" & System.Environment.MachineName & "','" & Handler.InspectorID & "') "
            Dim execInsert = opExec.ExecuteSqlCommand(sqlCardaftar)
            If (execInsert.Item1 = False) Then
                MessageBox.Show($"Error while creating cardaftar; {execInsert.Item2}")
                Exit Sub
            End If
        End If

        If MsgBox($"Send vehicle to Lane {cmbLane.Text}", vbQuestion Or vbYesNo Or vbDefaultButton2, "Confirm Vehicle Inspection") = vbYes Then
            Dim helpers As New Helpers()

            If (helpers.CreateInspectionActive(txtPlate.Text, txtChassis.Text, cmbLane.Text, cmbFeeLabel.Text)) Then
                MessageBox.Show("InspectionActive created successfully")

                txtPlate.Text = ""
                txtChassis.Text = ""
                txtAddress.Text = ""
                txtDateOwnership.Text = ""
                txtEnginePower.Text = ""
                txtMake.Text = ""
                txtManufacturer.Text = ""
                cmbFuelType.Text = ""
                txtPhone.Text = ""
                txtOwner.Text = ""
                cmbLane.Text = ""
                txtModel.Text = ""
                txtColor.Text = ""
                txtWeight.Text = ""
                chk4Wd.Checked = False
                cmbFeeLabel.Text = ""
                cmbVehicleType.Text = ""

                txtPlate.Select()
            End If

        End If

    End Sub

    Private Sub btnUpdateData_Click(sender As Object, e As EventArgs) Handles btnUpdateData.Click
        Dim userFk As Integer = Handler.UserFk(Handler.InspectorID)
        Dim sqlCardaftar As String = ""
        Dim opExec As New connection
        If (exist = True) Then
            sqlCardaftar = "update cardaftar set FourWD = " & CInt(chk4Wd.Checked) & ", VehicleCategory = " & cmbVehicleType.SelectedValue & ", Model = '" & txtModel.Text & "', Color = '" & txtColor.Text & "', WeightTotal = '" & txtWeight.Text & "', ADDRESS1 = '" & txtAddress.Text & "', DATEMANUFACTURED ='" & txtDateOwnership.Text & "' ,EnginePower ='" & txtEnginePower.Text & "',MAKE ='" & txtMake.Text & "' , MANUFACTURER = '" & txtManufacturer.Text & "',Phone = '" & txtPhone.Text & "', FuelType = '" & cmbFuelType.Text & "',  OWNER = '" & txtOwner.Text & "',UPDATEDATE = '" & Handler.GenerateTimeZone() & "',HOSTNAME = '" & System.Environment.MachineName & "',USERNAME = '" & Handler.InspectorID & "' WHERE PLATENO = '" & txtPlate.Text & "' and chassisno = '" & txtChassis.Text & "' "
            Dim execUpdate = opExec.ExecuteSqlCommand(sqlCardaftar)
            If (execUpdate.Item1 = False) Then
                MessageBox.Show($"Error while updating cardaftar; {execUpdate.Item2}")
                Exit Sub
            End If
        Else
            sqlCardaftar = "insert into cardaftar (plateno, chassisno,FourWD,VehicleCategory, Model,Color, WeightTotal, ADDRESS1, DATEMANUFACTURED, EnginePower, MAKE, MANUFACTURER,Phone, FuelType,[OWNER],  user_fk,UPDATEDATE,HOSTNAME,USERNAME) values ('" & txtPlate.Text & "','" & txtChassis.Text & "'," & CInt(chk4Wd.Checked) & "," & cmbVehicleType.SelectedValue & ",'" & txtModel.Text & "','" & txtColor.Text & "','" & txtWeight.Text & "','" & txtAddress.Text & "','" & txtDateOwnership.Text & "' , '" & txtEnginePower.Text & "', '" & txtMake.Text & "' ,  '" & txtManufacturer.Text & "', '" & txtPhone.Text & "',  '" & cmbFuelType.Text & "',   '" & txtOwner.Text & "'," & userFk & ",'" & Handler.GenerateTimeZone() & "','" & System.Environment.MachineName & "','" & Handler.InspectorID & "') "
            Dim execInsert = opExec.ExecuteSqlCommand(sqlCardaftar)
            If (execInsert.Item1 = False) Then
                MessageBox.Show($"Error while creating cardaftar; {execInsert.Item2}")
                Exit Sub
            End If
        End If
        MessageBox.Show("Data updated successfully")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If (txtPlate.Text.Trim() <> "") Then
            Handler.Plate = txtPlate.Text.Trim()
        End If
        CancelInspection.Show()
    End Sub
End Class