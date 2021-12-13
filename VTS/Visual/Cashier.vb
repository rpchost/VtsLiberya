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

        Dim str As String = ""

        lblCashier.Text = Handler.InspectorID

        Dim helper As New Helpers
        If (txtChassis.Text.Trim <> "" And txtPlate.Text.Trim <> "") Then lblVisitType.Text = helper.GetVisitNature(txtChassis.Text.Trim)

    End Sub

    Private Sub txtPlate_TextChanged(sender As Object, e As EventArgs) Handles txtPlate.TextChanged
        Dim str As String = ""
        Dim opExec As New connection

        lblVisitType.Text = ""

        Dim reader As SqlClient.SqlDataReader = opExec.rdGetReader("select * from Cardaftar where plateno = '" & txtPlate.Text & "'")
        Try

            If reader.HasRows = True Then

                reader.Read()

                txtChassis.Text = IIf(IsDBNull(reader("Chassisno")), "", reader("Chassisno"))
                txtAddress.Text = IIf(IsDBNull(reader("ADDRESS1")), "", reader("ADDRESS1"))
                txtDateOwnership.Text = IIf(IsDBNull(reader("DATEOWNERSHIP")), "", reader("DATEOWNERSHIP"))
                txtEnginePower.Text = IIf(IsDBNull(reader("EnginePower")), "", reader("EnginePower"))
                txtMake.Text = IIf(IsDBNull(reader("MAKE")), "", reader("MAKE"))
                txtManufacturer.Text = IIf(IsDBNull(reader("MANUFACTURER")), "", reader("MANUFACTURER"))
                txtFuelType.Text = IIf(IsDBNull(reader("FuelType")), "", reader("FuelType"))
                txtPhone.Text = IIf(IsDBNull(reader("Phone")), "", reader("Phone"))
                txtOwner.Text = IIf(IsDBNull(reader("OWNER")), "", reader("OWNER"))
                exist = True

                If (txtChassis.Text.Trim <> "" And txtPlate.Text.Trim <> "") Then
                    Dim helper As New Helpers
                    lblVisitType.Text = helper.GetVisitNature(txtChassis.Text.Trim)
                End If

            Else
                exist = False

                txtChassis.Text = ""
                txtAddress.Text = ""
                txtDateOwnership.Text = ""
                txtEnginePower.Text = ""
                txtMake.Text = ""
                txtManufacturer.Text = ""
                txtFuelType.Text = ""
                txtPhone.Text = ""
                txtOwner.Text = ""
            End If

        Catch ex As Exception

        Finally
            opExec.closeConnection()
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Dispose()
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click

        Dim userFk As Integer = Handler.UserFk(Handler.InspectorID)
        Dim sqlCardaftar As String = ""
        Dim opExec As New connection
        If (exist = True) Then
            sqlCardaftar = "update cardaftar set ADDRESS1 = '" & txtAddress.Text & "', DATEOWNERSHIP ='" & txtDateOwnership.Text & "' ,EnginePower ='" & txtEnginePower.Text & "',MAKE ='" & txtMake.Text & "' , MANUFACTURER = '" & txtManufacturer.Text & "',Phone = '" & txtPhone.Text & "', FuelType = '" & txtFuelType.Text & "',  OWNER = '" & txtOwner.Text & "' WHERE PLATENO = '" & txtPlate.Text & "' and chassisno = '" & txtChassis.Text & "' "
            Dim execUpdate = opExec.ExecuteSqlCommand(sqlCardaftar)
            If (execUpdate.Item1 = False) Then
                MessageBox.Show($"Error while updating cardaftar; {execUpdate.Item2}")
                Exit Sub
            End If
        Else
            sqlCardaftar = "insert into cardaftar (plateno, chassisno, ADDRESS1, DATEOWNERSHIP, EnginePower, MAKE, MANUFACTURER,Phone, FuelType,[OWNER],  user_fk) values ('" & txtPlate.Text & "','" & txtChassis.Text & "','" & txtAddress.Text & "','" & txtDateOwnership.Text & "' , '" & txtEnginePower.Text & "', '" & txtMake.Text & "' ,  '" & txtManufacturer.Text & "', '" & txtPhone.Text & "',  '" & txtFuelType.Text & "',   '" & txtOwner.Text & "'," & userFk & ") "
            Dim execInsert = opExec.ExecuteSqlCommand(sqlCardaftar)
            If (execInsert.Item1 = False) Then
                MessageBox.Show($"Error while creating cardaftar; {execInsert.Item2}")
                Exit Sub
            End If

        End If

        If MsgBox($"Send vehicle to Lane {txtLane.Text}", vbQuestion Or vbYesNo Or vbDefaultButton2, "Confirm Vehicle Inspection") = vbYes Then
            Dim helpers As New Helpers()
            If (helpers.CreateInspectionActive(txtPlate.Text, txtChassis.Text, txtLane.Text)) Then
                MessageBox.Show("InspectionActive created successfully")

                txtPlate.Text = ""
                txtChassis.Text = ""
                txtAddress.Text = ""
                txtDateOwnership.Text = ""
                txtEnginePower.Text = ""
                txtMake.Text = ""
                txtManufacturer.Text = ""
                txtFuelType.Text = ""
                txtPhone.Text = ""
                txtOwner.Text = ""
                txtLane.Text = ""

                txtPlate.Select()
            End If
        End If

    End Sub
End Class