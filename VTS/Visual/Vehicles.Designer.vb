<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Vehicles
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.lblPlate = New System.Windows.Forms.Label()
        Me.btnEuroBack = New System.Windows.Forms.Button()
        Me.header = New System.Windows.Forms.Label()
        Me.lblInspectorID = New System.Windows.Forms.Label()
        Me.lblInspectionNo = New System.Windows.Forms.Label()
        Me.lblMessage = New System.Windows.Forms.Label()
        Me.lblVisitType = New System.Windows.Forms.Label()
        Me.pnl = New System.Windows.Forms.Panel()
        Me.lblGroup = New System.Windows.Forms.Label()
        Me.lblLane = New System.Windows.Forms.Label()
        Me.lblSection = New System.Windows.Forms.Label()
        Me.lblStored = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblPlate
        '
        Me.lblPlate.AutoSize = True
        Me.lblPlate.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPlate.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblPlate.Location = New System.Drawing.Point(15, 131)
        Me.lblPlate.Name = "lblPlate"
        Me.lblPlate.Size = New System.Drawing.Size(66, 25)
        Me.lblPlate.TabIndex = 9
        Me.lblPlate.Text = "Plate"
        Me.lblPlate.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'btnEuroBack
        '
        Me.btnEuroBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEuroBack.Location = New System.Drawing.Point(918, 752)
        Me.btnEuroBack.Name = "btnEuroBack"
        Me.btnEuroBack.Size = New System.Drawing.Size(138, 72)
        Me.btnEuroBack.TabIndex = 0
        Me.btnEuroBack.Text = "LOG OUT"
        Me.btnEuroBack.UseVisualStyleBackColor = True
        '
        'header
        '
        Me.header.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.header.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.header.ForeColor = System.Drawing.Color.White
        Me.header.Location = New System.Drawing.Point(-1, -3)
        Me.header.Name = "header"
        Me.header.Size = New System.Drawing.Size(1443, 77)
        Me.header.TabIndex = 16
        '
        'lblInspectorID
        '
        Me.lblInspectorID.AutoSize = True
        Me.lblInspectorID.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblInspectorID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInspectorID.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblInspectorID.Location = New System.Drawing.Point(9, 53)
        Me.lblInspectorID.Name = "lblInspectorID"
        Me.lblInspectorID.Size = New System.Drawing.Size(85, 20)
        Me.lblInspectorID.TabIndex = 21
        Me.lblInspectorID.Text = "Inspector"
        Me.lblInspectorID.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblInspectionNo
        '
        Me.lblInspectionNo.AutoSize = True
        Me.lblInspectionNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInspectionNo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblInspectionNo.Location = New System.Drawing.Point(15, 103)
        Me.lblInspectionNo.Name = "lblInspectionNo"
        Me.lblInspectionNo.Size = New System.Drawing.Size(79, 16)
        Me.lblInspectionNo.TabIndex = 23
        Me.lblInspectionNo.Text = "Inspection"
        Me.lblInspectionNo.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblMessage
        '
        Me.lblMessage.AutoSize = True
        Me.lblMessage.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMessage.ForeColor = System.Drawing.Color.Red
        Me.lblMessage.Location = New System.Drawing.Point(18, 254)
        Me.lblMessage.Name = "lblMessage"
        Me.lblMessage.Size = New System.Drawing.Size(0, 20)
        Me.lblMessage.TabIndex = 24
        Me.lblMessage.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblVisitType
        '
        Me.lblVisitType.AutoSize = True
        Me.lblVisitType.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVisitType.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblVisitType.Location = New System.Drawing.Point(15, 166)
        Me.lblVisitType.Name = "lblVisitType"
        Me.lblVisitType.Size = New System.Drawing.Size(58, 25)
        Me.lblVisitType.TabIndex = 27
        Me.lblVisitType.Text = "Visit"
        Me.lblVisitType.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'pnl
        '
        Me.pnl.AutoScroll = True
        Me.pnl.Location = New System.Drawing.Point(811, 186)
        Me.pnl.Margin = New System.Windows.Forms.Padding(2)
        Me.pnl.Name = "pnl"
        Me.pnl.Size = New System.Drawing.Size(385, 561)
        Me.pnl.TabIndex = 290
        '
        'lblGroup
        '
        Me.lblGroup.AutoSize = True
        Me.lblGroup.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblGroup.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGroup.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblGroup.Location = New System.Drawing.Point(12, 28)
        Me.lblGroup.Name = "lblGroup"
        Me.lblGroup.Size = New System.Drawing.Size(59, 20)
        Me.lblGroup.TabIndex = 291
        Me.lblGroup.Text = "Group"
        Me.lblGroup.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblLane
        '
        Me.lblLane.AutoSize = True
        Me.lblLane.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblLane.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.857143!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLane.ForeColor = System.Drawing.Color.White
        Me.lblLane.Location = New System.Drawing.Point(16, 5)
        Me.lblLane.Name = "lblLane"
        Me.lblLane.Size = New System.Drawing.Size(44, 17)
        Me.lblLane.TabIndex = 292
        Me.lblLane.Text = "Lane"
        Me.lblLane.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblSection
        '
        Me.lblSection.AutoSize = True
        Me.lblSection.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblSection.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.857143!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSection.ForeColor = System.Drawing.Color.White
        Me.lblSection.Location = New System.Drawing.Point(104, 5)
        Me.lblSection.Name = "lblSection"
        Me.lblSection.Size = New System.Drawing.Size(62, 17)
        Me.lblSection.TabIndex = 293
        Me.lblSection.Text = "Section"
        Me.lblSection.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblStored
        '
        Me.lblStored.AutoSize = True
        Me.lblStored.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStored.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblStored.Location = New System.Drawing.Point(18, 209)
        Me.lblStored.Name = "lblStored"
        Me.lblStored.Size = New System.Drawing.Size(0, 25)
        Me.lblStored.TabIndex = 294
        Me.lblStored.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Vehicles
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(1450, 903)
        Me.Controls.Add(Me.lblStored)
        Me.Controls.Add(Me.lblSection)
        Me.Controls.Add(Me.lblLane)
        Me.Controls.Add(Me.lblGroup)
        Me.Controls.Add(Me.pnl)
        Me.Controls.Add(Me.lblVisitType)
        Me.Controls.Add(Me.lblMessage)
        Me.Controls.Add(Me.lblInspectionNo)
        Me.Controls.Add(Me.lblInspectorID)
        Me.Controls.Add(Me.header)
        Me.Controls.Add(Me.btnEuroBack)
        Me.Controls.Add(Me.lblPlate)
        Me.Name = "Vehicles"
        Me.Text = "Vehicles"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblPlate As System.Windows.Forms.Label
    Friend WithEvents btnEuroBack As System.Windows.Forms.Button
    Friend WithEvents header As Label
    Friend WithEvents lblInspectorID As Label
    Friend WithEvents lblInspectionNo As Label
    Friend WithEvents lblMessage As Label
    Friend WithEvents lblVisitType As Label
    Friend WithEvents pnl As Panel
    Friend WithEvents lblGroup As Label
    Friend WithEvents lblLane As Label
    Friend WithEvents lblSection As Label
    Friend WithEvents lblStored As Label
End Class
