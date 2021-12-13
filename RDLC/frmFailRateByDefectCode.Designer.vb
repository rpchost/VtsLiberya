<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFailRateByDefectCode
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
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.txtStation = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.txtDefectCode = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtVisit = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtVehicleType = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtVehicleCategory = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.RptFailRateByDefectCode_ResultBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.RptFailRateByDefectCode_ResultBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        ReportDataSource1.Name = "DsFailRateByDefectCode"
        ReportDataSource1.Value = Me.RptFailRateByDefectCode_ResultBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "RDLC.RptFailRateByDefectcode.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(126, 107)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(923, 504)
        Me.ReportViewer1.TabIndex = 0
        '
        'txtStation
        '
        Me.txtStation.Location = New System.Drawing.Point(709, 14)
        Me.txtStation.Name = "txtStation"
        Me.txtStation.Size = New System.Drawing.Size(69, 20)
        Me.txtStation.TabIndex = 14
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(650, 14)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 15)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Station"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(397, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(23, 15)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "To"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(126, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 15)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "From"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(961, 51)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(88, 21)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "Get Report"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Location = New System.Drawing.Point(426, 14)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker2.TabIndex = 9
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(172, 14)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker1.TabIndex = 8
        '
        'txtDefectCode
        '
        Me.txtDefectCode.Location = New System.Drawing.Point(217, 51)
        Me.txtDefectCode.Name = "txtDefectCode"
        Me.txtDefectCode.Size = New System.Drawing.Size(155, 20)
        Me.txtDefectCode.TabIndex = 16
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(126, 52)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(85, 15)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Defect Code"
        '
        'txtVisit
        '
        Me.txtVisit.Location = New System.Drawing.Point(443, 52)
        Me.txtVisit.Name = "txtVisit"
        Me.txtVisit.Size = New System.Drawing.Size(76, 20)
        Me.txtVisit.TabIndex = 18
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(397, 52)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(34, 15)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Visit"
        '
        'txtVehicleType
        '
        Me.txtVehicleType.Location = New System.Drawing.Point(638, 52)
        Me.txtVehicleType.Name = "txtVehicleType"
        Me.txtVehicleType.Size = New System.Drawing.Size(76, 20)
        Me.txtVehicleType.TabIndex = 20
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(544, 53)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(88, 15)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = "Vehicle Type"
        '
        'txtVehicleCategory
        '
        Me.txtVehicleCategory.Location = New System.Drawing.Point(854, 52)
        Me.txtVehicleCategory.Name = "txtVehicleCategory"
        Me.txtVehicleCategory.Size = New System.Drawing.Size(76, 20)
        Me.txtVehicleCategory.TabIndex = 22
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(734, 54)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(114, 15)
        Me.Label7.TabIndex = 21
        Me.Label7.Text = "Vehicle Category"
        '
        'RptFailRateByDefectCode_ResultBindingSource
        '
        Me.RptFailRateByDefectCode_ResultBindingSource.DataSource = GetType(RDLC.RptFailRateByDefectCode_Result)
        '
        'frmFailRateByDefectCode
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1135, 662)
        Me.Controls.Add(Me.txtVehicleCategory)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtVehicleType)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtVisit)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtDefectCode)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtStation)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DateTimePicker2)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "frmFailRateByDefectCode"
        Me.Text = "FAIL RATE BY DEFECT CODE"
        CType(Me.RptFailRateByDefectCode_ResultBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents txtStation As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents txtDefectCode As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtVisit As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtVehicleType As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtVehicleCategory As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents RptFailRateByDefectCode_ResultBindingSource As BindingSource
End Class
