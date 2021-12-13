<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Cashier
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.header = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtPlate = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtChassis = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtOwner = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtDateOwnership = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtPhone = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtManufacturer = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtMake = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtModel = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtEnginePower = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtFuelType = New System.Windows.Forms.TextBox()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.lblCashier = New System.Windows.Forms.Label()
        Me.lblVisitType = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtLane = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(530, 36)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(177, 39)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "CASHIER"
        '
        'header
        '
        Me.header.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.header.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.header.ForeColor = System.Drawing.Color.White
        Me.header.Location = New System.Drawing.Point(-2, -2)
        Me.header.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.header.Name = "header"
        Me.header.Size = New System.Drawing.Size(1355, 77)
        Me.header.TabIndex = 22
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.857143!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(507, 186)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 17)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "PLATE"
        '
        'txtPlate
        '
        Me.txtPlate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.857143!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPlate.Location = New System.Drawing.Point(594, 186)
        Me.txtPlate.Margin = New System.Windows.Forms.Padding(2)
        Me.txtPlate.Name = "txtPlate"
        Me.txtPlate.Size = New System.Drawing.Size(113, 22)
        Me.txtPlate.TabIndex = 25
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.857143!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(172, 270)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 17)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "CHASSIS"
        '
        'txtChassis
        '
        Me.txtChassis.Location = New System.Drawing.Point(326, 269)
        Me.txtChassis.Margin = New System.Windows.Forms.Padding(2)
        Me.txtChassis.Name = "txtChassis"
        Me.txtChassis.Size = New System.Drawing.Size(156, 20)
        Me.txtChassis.TabIndex = 27
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.857143!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(166, 303)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 17)
        Me.Label4.TabIndex = 28
        Me.Label4.Text = "OWNER"
        '
        'txtOwner
        '
        Me.txtOwner.Location = New System.Drawing.Point(326, 303)
        Me.txtOwner.Margin = New System.Windows.Forms.Padding(2)
        Me.txtOwner.Name = "txtOwner"
        Me.txtOwner.Size = New System.Drawing.Size(156, 20)
        Me.txtOwner.TabIndex = 29
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.857143!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(166, 346)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(81, 17)
        Me.Label5.TabIndex = 30
        Me.Label5.Text = "ADDRESS"
        '
        'txtAddress
        '
        Me.txtAddress.Location = New System.Drawing.Point(326, 346)
        Me.txtAddress.Margin = New System.Windows.Forms.Padding(2)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(156, 20)
        Me.txtAddress.TabIndex = 31
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.857143!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(166, 391)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(147, 17)
        Me.Label6.TabIndex = 32
        Me.Label6.Text = "DATE OWNERSHIP"
        '
        'txtDateOwnership
        '
        Me.txtDateOwnership.Location = New System.Drawing.Point(326, 392)
        Me.txtDateOwnership.Margin = New System.Windows.Forms.Padding(2)
        Me.txtDateOwnership.Name = "txtDateOwnership"
        Me.txtDateOwnership.Size = New System.Drawing.Size(156, 20)
        Me.txtDateOwnership.TabIndex = 33
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.857143!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(172, 441)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(62, 17)
        Me.Label7.TabIndex = 34
        Me.Label7.Text = "PHONE"
        '
        'txtPhone
        '
        Me.txtPhone.Location = New System.Drawing.Point(326, 441)
        Me.txtPhone.Margin = New System.Windows.Forms.Padding(2)
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(156, 20)
        Me.txtPhone.TabIndex = 35
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.857143!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(725, 269)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(134, 17)
        Me.Label8.TabIndex = 36
        Me.Label8.Text = "MANUFACTURER"
        '
        'txtManufacturer
        '
        Me.txtManufacturer.Location = New System.Drawing.Point(868, 270)
        Me.txtManufacturer.Margin = New System.Windows.Forms.Padding(2)
        Me.txtManufacturer.Name = "txtManufacturer"
        Me.txtManufacturer.Size = New System.Drawing.Size(135, 20)
        Me.txtManufacturer.TabIndex = 37
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.857143!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(725, 303)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(50, 17)
        Me.Label9.TabIndex = 38
        Me.Label9.Text = "MAKE"
        '
        'txtMake
        '
        Me.txtMake.Location = New System.Drawing.Point(868, 303)
        Me.txtMake.Margin = New System.Windows.Forms.Padding(2)
        Me.txtMake.Name = "txtMake"
        Me.txtMake.Size = New System.Drawing.Size(135, 20)
        Me.txtMake.TabIndex = 39
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.857143!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(725, 346)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(62, 17)
        Me.Label10.TabIndex = 40
        Me.Label10.Text = "MODEL"
        '
        'txtModel
        '
        Me.txtModel.Location = New System.Drawing.Point(868, 346)
        Me.txtModel.Margin = New System.Windows.Forms.Padding(2)
        Me.txtModel.Name = "txtModel"
        Me.txtModel.Size = New System.Drawing.Size(135, 20)
        Me.txtModel.TabIndex = 41
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.857143!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(725, 392)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(123, 17)
        Me.Label11.TabIndex = 42
        Me.Label11.Text = "ENGINEPOWER"
        '
        'txtEnginePower
        '
        Me.txtEnginePower.Location = New System.Drawing.Point(868, 392)
        Me.txtEnginePower.Margin = New System.Windows.Forms.Padding(2)
        Me.txtEnginePower.Name = "txtEnginePower"
        Me.txtEnginePower.Size = New System.Drawing.Size(135, 20)
        Me.txtEnginePower.TabIndex = 43
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.857143!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(725, 441)
        Me.Label12.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(87, 17)
        Me.Label12.TabIndex = 44
        Me.Label12.Text = "FUELTYPE"
        '
        'txtFuelType
        '
        Me.txtFuelType.Location = New System.Drawing.Point(868, 442)
        Me.txtFuelType.Margin = New System.Windows.Forms.Padding(2)
        Me.txtFuelType.Name = "txtFuelType"
        Me.txtFuelType.Size = New System.Drawing.Size(135, 20)
        Me.txtFuelType.TabIndex = 45
        '
        'btnUpdate
        '
        Me.btnUpdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.857143!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.Location = New System.Drawing.Point(594, 560)
        Me.btnUpdate.Margin = New System.Windows.Forms.Padding(2)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(117, 47)
        Me.btnUpdate.TabIndex = 46
        Me.btnUpdate.Text = "SUBMIT"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.857143!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(594, 625)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(117, 47)
        Me.Button1.TabIndex = 47
        Me.Button1.Text = "ESC"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'lblCashier
        '
        Me.lblCashier.AutoSize = True
        Me.lblCashier.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblCashier.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCashier.ForeColor = System.Drawing.Color.White
        Me.lblCashier.Location = New System.Drawing.Point(2, 57)
        Me.lblCashier.Name = "lblCashier"
        Me.lblCashier.Size = New System.Drawing.Size(0, 20)
        Me.lblCashier.TabIndex = 48
        '
        'lblVisitType
        '
        Me.lblVisitType.AutoSize = True
        Me.lblVisitType.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.857143!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVisitType.ForeColor = System.Drawing.Color.Teal
        Me.lblVisitType.Location = New System.Drawing.Point(591, 213)
        Me.lblVisitType.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblVisitType.Name = "lblVisitType"
        Me.lblVisitType.Size = New System.Drawing.Size(0, 17)
        Me.lblVisitType.TabIndex = 49
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.857143!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(172, 477)
        Me.Label13.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(48, 17)
        Me.Label13.TabIndex = 50
        Me.Label13.Text = "LANE"
        '
        'txtLane
        '
        Me.txtLane.Location = New System.Drawing.Point(326, 474)
        Me.txtLane.Margin = New System.Windows.Forms.Padding(2)
        Me.txtLane.Name = "txtLane"
        Me.txtLane.Size = New System.Drawing.Size(93, 20)
        Me.txtLane.TabIndex = 36
        '
        'Cashier
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(1347, 858)
        Me.Controls.Add(Me.txtLane)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.lblVisitType)
        Me.Controls.Add(Me.lblCashier)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.txtFuelType)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txtEnginePower)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txtModel)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtMake)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtManufacturer)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtPhone)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtDateOwnership)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtAddress)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtOwner)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtChassis)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtPlate)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.header)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Cashier"
        Me.Text = "CASHIER"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label3 As Label
    Friend WithEvents header As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtPlate As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtChassis As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtOwner As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtDateOwnership As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtManufacturer As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtMake As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txtModel As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txtEnginePower As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents txtFuelType As TextBox
    Friend WithEvents btnUpdate As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents lblCashier As Label
    Friend WithEvents lblVisitType As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents txtLane As TextBox
End Class
