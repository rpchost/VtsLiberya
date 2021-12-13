<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Antivol_de_direction
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnEsc = New System.Windows.Forms.Button()
        Me.header = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblInspectionNo = New System.Windows.Forms.Label()
        Me.lblInspectorID = New System.Windows.Forms.Label()
        Me.lblPlate = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Arial", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(526, 286)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(225, 137)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "A 2.2.2.1.1 Détérioration"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(609, 129)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 18)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Label2"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(609, 156)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 18)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Label4"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(609, 186)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(57, 18)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Label6"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(569, 444)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(112, 13)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "2.2.2.1.1 Détérioration"
        Me.Label7.Visible = False
        '
        'btnEsc
        '
        Me.btnEsc.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEsc.Location = New System.Drawing.Point(552, 630)
        Me.btnEsc.Name = "btnEsc"
        Me.btnEsc.Size = New System.Drawing.Size(174, 75)
        Me.btnEsc.TabIndex = 12
        Me.btnEsc.Text = "ESC"
        Me.btnEsc.UseVisualStyleBackColor = True
        '
        'header
        '
        Me.header.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.header.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.header.ForeColor = System.Drawing.Color.White
        Me.header.Location = New System.Drawing.Point(-2, -3)
        Me.header.Name = "header"
        Me.header.Size = New System.Drawing.Size(1326, 77)
        Me.header.TabIndex = 13
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(432, 35)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(439, 39)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "ANTIVOL DE DIRECTION"
        '
        'lblInspectionNo
        '
        Me.lblInspectionNo.AutoSize = True
        Me.lblInspectionNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInspectionNo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblInspectionNo.Location = New System.Drawing.Point(6, 111)
        Me.lblInspectionNo.Name = "lblInspectionNo"
        Me.lblInspectionNo.Size = New System.Drawing.Size(79, 16)
        Me.lblInspectionNo.TabIndex = 26
        Me.lblInspectionNo.Text = "Inspection"
        Me.lblInspectionNo.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblInspectorID
        '
        Me.lblInspectorID.AutoSize = True
        Me.lblInspectorID.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblInspectorID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInspectorID.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblInspectorID.Location = New System.Drawing.Point(12, 51)
        Me.lblInspectorID.Name = "lblInspectorID"
        Me.lblInspectorID.Size = New System.Drawing.Size(85, 20)
        Me.lblInspectorID.TabIndex = 25
        Me.lblInspectorID.Text = "Inspector"
        Me.lblInspectorID.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblPlate
        '
        Me.lblPlate.AutoSize = True
        Me.lblPlate.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPlate.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblPlate.Location = New System.Drawing.Point(6, 139)
        Me.lblPlate.Name = "lblPlate"
        Me.lblPlate.Size = New System.Drawing.Size(66, 25)
        Me.lblPlate.TabIndex = 24
        Me.lblPlate.Text = "Plate"
        Me.lblPlate.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Antivol_de_direction
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1317, 814)
        Me.Controls.Add(Me.lblInspectionNo)
        Me.Controls.Add(Me.lblInspectorID)
        Me.Controls.Add(Me.lblPlate)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.header)
        Me.Controls.Add(Me.btnEsc)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Antivol_de_direction"
        Me.Text = "Antivol_de_direction"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents btnEsc As Button
    Friend WithEvents header As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblInspectionNo As Label
    Friend WithEvents lblInspectorID As Label
    Friend WithEvents lblPlate As Label
End Class
