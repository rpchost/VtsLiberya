<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Tambour_de_frein
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
        Me.btnHuile = New System.Windows.Forms.Button()
        Me.btnFixation = New System.Windows.Forms.Button()
        Me.btnDetImportante = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnTambourFreinESC = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.header = New System.Windows.Forms.Label()
        Me.lblInspectionNo = New System.Windows.Forms.Label()
        Me.lblInspectorID = New System.Windows.Forms.Label()
        Me.lblPlate = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnHuile
        '
        Me.btnHuile.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHuile.Location = New System.Drawing.Point(584, 351)
        Me.btnHuile.Name = "btnHuile"
        Me.btnHuile.Size = New System.Drawing.Size(214, 144)
        Me.btnHuile.TabIndex = 14
        Me.btnHuile.Text = "1.4.3.2.1 Présence d'huile"
        Me.btnHuile.UseVisualStyleBackColor = True
        '
        'btnFixation
        '
        Me.btnFixation.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFixation.Location = New System.Drawing.Point(878, 351)
        Me.btnFixation.Name = "btnFixation"
        Me.btnFixation.Size = New System.Drawing.Size(205, 144)
        Me.btnFixation.TabIndex = 13
        Me.btnFixation.Text = "1.4.3.3.1 Mauvaise fixation "
        Me.btnFixation.UseVisualStyleBackColor = True
        '
        'btnDetImportante
        '
        Me.btnDetImportante.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDetImportante.Location = New System.Drawing.Point(281, 351)
        Me.btnDetImportante.Name = "btnDetImportante"
        Me.btnDetImportante.Size = New System.Drawing.Size(213, 144)
        Me.btnDetImportante.TabIndex = 11
        Me.btnDetImportante.Text = "1.4.3.1.1 Détérioration  importante "
        Me.btnDetImportante.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(659, 167)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 18)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Label2"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(659, 190)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 18)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Label3"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(661, 214)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 18)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Label4"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(306, 508)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(170, 13)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "1.4.3.1.1 Détérioration  importante "
        Me.Label5.Visible = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(642, 508)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(130, 13)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = "1.4.3.2.1 Présence d'huile"
        Me.Label6.Visible = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(924, 508)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(137, 13)
        Me.Label7.TabIndex = 20
        Me.Label7.Text = "1.4.3.3.1 Mauvaise fixation "
        Me.Label7.Visible = False
        '
        'btnTambourFreinESC
        '
        Me.btnTambourFreinESC.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTambourFreinESC.Location = New System.Drawing.Point(637, 637)
        Me.btnTambourFreinESC.Name = "btnTambourFreinESC"
        Me.btnTambourFreinESC.Size = New System.Drawing.Size(110, 76)
        Me.btnTambourFreinESC.TabIndex = 21
        Me.btnTambourFreinESC.Text = "ESC"
        Me.btnTambourFreinESC.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(484, 32)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(375, 39)
        Me.Label8.TabIndex = 23
        Me.Label8.Text = "TAMBOUR DE FREIN"
        '
        'header
        '
        Me.header.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.header.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.header.ForeColor = System.Drawing.Color.White
        Me.header.Location = New System.Drawing.Point(-2, -2)
        Me.header.Name = "header"
        Me.header.Size = New System.Drawing.Size(1352, 77)
        Me.header.TabIndex = 22
        '
        'lblInspectionNo
        '
        Me.lblInspectionNo.AutoSize = True
        Me.lblInspectionNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInspectionNo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblInspectionNo.Location = New System.Drawing.Point(8, 111)
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
        Me.lblInspectorID.Location = New System.Drawing.Point(14, 51)
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
        Me.lblPlate.Location = New System.Drawing.Point(8, 139)
        Me.lblPlate.Name = "lblPlate"
        Me.lblPlate.Size = New System.Drawing.Size(66, 25)
        Me.lblPlate.TabIndex = 24
        Me.lblPlate.Text = "Plate"
        Me.lblPlate.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Tambour_de_frein
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1350, 840)
        Me.Controls.Add(Me.lblInspectionNo)
        Me.Controls.Add(Me.lblInspectorID)
        Me.Controls.Add(Me.lblPlate)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.header)
        Me.Controls.Add(Me.btnTambourFreinESC)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnHuile)
        Me.Controls.Add(Me.btnFixation)
        Me.Controls.Add(Me.btnDetImportante)
        Me.Name = "Tambour_de_frein"
        Me.Text = "Tambour_de_frein"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnHuile As System.Windows.Forms.Button
    Friend WithEvents btnFixation As System.Windows.Forms.Button
    Friend WithEvents btnDetImportante As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents btnTambourFreinESC As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents header As System.Windows.Forms.Label
    Friend WithEvents lblInspectionNo As Label
    Friend WithEvents lblInspectorID As Label
    Friend WithEvents lblPlate As Label
End Class
