<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Pédale_du_frein_de_service
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
        Me.btnDetImportante = New System.Windows.Forms.Button()
        Me.btnDeterioration = New System.Windows.Forms.Button()
        Me.btnCourseImportante = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.header = New System.Windows.Forms.Label()
        Me.btnOrganesESC = New System.Windows.Forms.Button()
        Me.lblInspectionNo = New System.Windows.Forms.Label()
        Me.lblInspectorID = New System.Windows.Forms.Label()
        Me.lblPlate = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnDetImportante
        '
        Me.btnDetImportante.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDetImportante.Location = New System.Drawing.Point(525, 331)
        Me.btnDetImportante.Name = "btnDetImportante"
        Me.btnDetImportante.Size = New System.Drawing.Size(225, 181)
        Me.btnDetImportante.TabIndex = 5
        Me.btnDetImportante.Text = "1.3.1.1.2 Détérioration  importante "
        Me.btnDetImportante.UseVisualStyleBackColor = True
        '
        'btnDeterioration
        '
        Me.btnDeterioration.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeterioration.Location = New System.Drawing.Point(263, 331)
        Me.btnDeterioration.Name = "btnDeterioration"
        Me.btnDeterioration.Size = New System.Drawing.Size(212, 181)
        Me.btnDeterioration.TabIndex = 4
        Me.btnDeterioration.Text = "1.3.1.1.1 Détérioration "
        Me.btnDeterioration.UseVisualStyleBackColor = True
        '
        'btnCourseImportante
        '
        Me.btnCourseImportante.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCourseImportante.Location = New System.Drawing.Point(798, 331)
        Me.btnCourseImportante.Name = "btnCourseImportante"
        Me.btnCourseImportante.Size = New System.Drawing.Size(235, 181)
        Me.btnCourseImportante.TabIndex = 6
        Me.btnCourseImportante.Text = "1.3.1.2.1 Course importante > 7 clicks"
        Me.btnCourseImportante.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(603, 161)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 18)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Label2"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(603, 185)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 18)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Label3"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(604, 208)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 18)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Label4"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(308, 531)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(115, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "1.3.1.1.1 Détérioration "
        Me.Label5.Visible = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(559, 531)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(170, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "1.3.1.1.2 Détérioration  importante "
        Me.Label6.Visible = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(823, 531)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(188, 13)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "1.3.1.2.1 Course importante > 7 clicks "
        Me.Label7.Visible = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(460, 32)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(363, 39)
        Me.Label8.TabIndex = 201
        Me.Label8.Text = "PASSAGE DE ROUE"
        '
        'header
        '
        Me.header.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.header.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.header.ForeColor = System.Drawing.Color.White
        Me.header.Location = New System.Drawing.Point(0, -2)
        Me.header.Name = "header"
        Me.header.Size = New System.Drawing.Size(1301, 77)
        Me.header.TabIndex = 200
        '
        'btnOrganesESC
        '
        Me.btnOrganesESC.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOrganesESC.Location = New System.Drawing.Point(590, 654)
        Me.btnOrganesESC.Name = "btnOrganesESC"
        Me.btnOrganesESC.Size = New System.Drawing.Size(98, 67)
        Me.btnOrganesESC.TabIndex = 202
        Me.btnOrganesESC.Text = "ESC"
        Me.btnOrganesESC.UseVisualStyleBackColor = True
        '
        'lblInspectionNo
        '
        Me.lblInspectionNo.AutoSize = True
        Me.lblInspectionNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInspectionNo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblInspectionNo.Location = New System.Drawing.Point(9, 111)
        Me.lblInspectionNo.Name = "lblInspectionNo"
        Me.lblInspectionNo.Size = New System.Drawing.Size(79, 16)
        Me.lblInspectionNo.TabIndex = 205
        Me.lblInspectionNo.Text = "Inspection"
        Me.lblInspectionNo.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblInspectorID
        '
        Me.lblInspectorID.AutoSize = True
        Me.lblInspectorID.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblInspectorID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInspectorID.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblInspectorID.Location = New System.Drawing.Point(15, 51)
        Me.lblInspectorID.Name = "lblInspectorID"
        Me.lblInspectorID.Size = New System.Drawing.Size(85, 20)
        Me.lblInspectorID.TabIndex = 204
        Me.lblInspectorID.Text = "Inspector"
        Me.lblInspectorID.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblPlate
        '
        Me.lblPlate.AutoSize = True
        Me.lblPlate.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPlate.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblPlate.Location = New System.Drawing.Point(9, 139)
        Me.lblPlate.Name = "lblPlate"
        Me.lblPlate.Size = New System.Drawing.Size(66, 25)
        Me.lblPlate.TabIndex = 203
        Me.lblPlate.Text = "Plate"
        Me.lblPlate.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Pédale_du_frein_de_service
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1296, 818)
        Me.Controls.Add(Me.lblInspectionNo)
        Me.Controls.Add(Me.lblInspectorID)
        Me.Controls.Add(Me.lblPlate)
        Me.Controls.Add(Me.btnOrganesESC)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.header)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnCourseImportante)
        Me.Controls.Add(Me.btnDetImportante)
        Me.Controls.Add(Me.btnDeterioration)
        Me.Name = "Pédale_du_frein_de_service"
        Me.Text = "Pédale_du_frein_de_service"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnDetImportante As System.Windows.Forms.Button
    Friend WithEvents btnDeterioration As System.Windows.Forms.Button
    Friend WithEvents btnCourseImportante As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents header As System.Windows.Forms.Label
    Friend WithEvents btnOrganesESC As System.Windows.Forms.Button
    Friend WithEvents lblInspectionNo As Label
    Friend WithEvents lblInspectorID As Label
    Friend WithEvents lblPlate As Label
End Class
