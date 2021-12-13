<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReviewMeasurementRepeat
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
        Me.lblInspectionNo = New System.Windows.Forms.Label()
        Me.lblPlate = New System.Windows.Forms.Label()
        Me.lblInspectorID = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.header = New System.Windows.Forms.Label()
        Me.lblType = New System.Windows.Forms.Label()
        Me.lblUserCode = New System.Windows.Forms.Label()
        Me.btnMeasureEsc = New System.Windows.Forms.Button()
        Me.pnl = New System.Windows.Forms.Panel()
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.lblVisitType = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblInspectionNo
        '
        Me.lblInspectionNo.AutoSize = True
        Me.lblInspectionNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInspectionNo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblInspectionNo.Location = New System.Drawing.Point(26, 207)
        Me.lblInspectionNo.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lblInspectionNo.Name = "lblInspectionNo"
        Me.lblInspectionNo.Size = New System.Drawing.Size(133, 29)
        Me.lblInspectionNo.TabIndex = 288
        Me.lblInspectionNo.Text = "Inspection"
        Me.lblInspectionNo.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblPlate
        '
        Me.lblPlate.AutoSize = True
        Me.lblPlate.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPlate.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblPlate.Location = New System.Drawing.Point(26, 258)
        Me.lblPlate.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lblPlate.Name = "lblPlate"
        Me.lblPlate.Size = New System.Drawing.Size(108, 42)
        Me.lblPlate.TabIndex = 287
        Me.lblPlate.Text = "Plate"
        Me.lblPlate.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblInspectorID
        '
        Me.lblInspectorID.AutoSize = True
        Me.lblInspectorID.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblInspectorID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInspectorID.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblInspectorID.Location = New System.Drawing.Point(24, 90)
        Me.lblInspectorID.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lblInspectorID.Name = "lblInspectorID"
        Me.lblInspectorID.Size = New System.Drawing.Size(140, 32)
        Me.lblInspectorID.TabIndex = 286
        Me.lblInspectorID.Text = "Inspector"
        Me.lblInspectorID.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(702, 61)
        Me.Label3.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(790, 71)
        Me.Label3.TabIndex = 285
        Me.Label3.Text = "REVIEW MEASUREMENT"
        '
        'header
        '
        Me.header.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.header.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.header.ForeColor = System.Drawing.Color.White
        Me.header.Location = New System.Drawing.Point(-2, -4)
        Me.header.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.header.Name = "header"
        Me.header.Size = New System.Drawing.Size(1925, 142)
        Me.header.TabIndex = 284
        '
        'lblType
        '
        Me.lblType.AutoSize = True
        Me.lblType.Location = New System.Drawing.Point(449, 1135)
        Me.lblType.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lblType.Name = "lblType"
        Me.lblType.Size = New System.Drawing.Size(76, 25)
        Me.lblType.TabIndex = 283
        Me.lblType.Text = "lblType"
        Me.lblType.Visible = False
        '
        'lblUserCode
        '
        Me.lblUserCode.AutoSize = True
        Me.lblUserCode.Location = New System.Drawing.Point(319, 1135)
        Me.lblUserCode.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lblUserCode.Name = "lblUserCode"
        Me.lblUserCode.Size = New System.Drawing.Size(71, 25)
        Me.lblUserCode.TabIndex = 280
        Me.lblUserCode.Text = "Label1"
        Me.lblUserCode.Visible = False
        '
        'btnMeasureEsc
        '
        Me.btnMeasureEsc.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMeasureEsc.Location = New System.Drawing.Point(1309, 1231)
        Me.btnMeasureEsc.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.btnMeasureEsc.Name = "btnMeasureEsc"
        Me.btnMeasureEsc.Size = New System.Drawing.Size(196, 126)
        Me.btnMeasureEsc.TabIndex = 279
        Me.btnMeasureEsc.Text = "ESC"
        Me.btnMeasureEsc.UseVisualStyleBackColor = True
        '
        'pnl
        '
        Me.pnl.AutoScroll = True
        Me.pnl.Location = New System.Drawing.Point(280, 218)
        Me.pnl.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.pnl.Name = "pnl"
        Me.pnl.Size = New System.Drawing.Size(1643, 914)
        Me.pnl.TabIndex = 289
        '
        'btnRemove
        '
        Me.btnRemove.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRemove.Location = New System.Drawing.Point(715, 1231)
        Me.btnRemove.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(270, 126)
        Me.btnRemove.TabIndex = 290
        Me.btnRemove.Text = "SAVE"
        Me.btnRemove.UseVisualStyleBackColor = True
        '
        'lblVisitType
        '
        Me.lblVisitType.AutoSize = True
        Me.lblVisitType.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVisitType.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblVisitType.Location = New System.Drawing.Point(26, 324)
        Me.lblVisitType.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lblVisitType.Name = "lblVisitType"
        Me.lblVisitType.Size = New System.Drawing.Size(93, 42)
        Me.lblVisitType.TabIndex = 291
        Me.lblVisitType.Text = "Visit"
        Me.lblVisitType.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'ReviewMeasurementRepeat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(1924, 1044)
        Me.Controls.Add(Me.lblVisitType)
        Me.Controls.Add(Me.btnRemove)
        Me.Controls.Add(Me.pnl)
        Me.Controls.Add(Me.lblInspectionNo)
        Me.Controls.Add(Me.lblPlate)
        Me.Controls.Add(Me.lblInspectorID)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.header)
        Me.Controls.Add(Me.lblType)
        Me.Controls.Add(Me.lblUserCode)
        Me.Controls.Add(Me.btnMeasureEsc)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "ReviewMeasurementRepeat"
        Me.Text = "Review Measurement"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblInspectionNo As Label
    Friend WithEvents lblPlate As Label
    Friend WithEvents lblInspectorID As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents header As Label
    Friend WithEvents lblType As Label
    Friend WithEvents lblUserCode As Label
    Friend WithEvents btnMeasureEsc As Button
    Friend WithEvents pnl As Panel
    Friend WithEvents btnRemove As Button
    Friend WithEvents lblVisitType As Label
End Class
