<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReviewMeasurement
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
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.btnMeasureEsc = New System.Windows.Forms.Button()
        Me.lblUserCode = New System.Windows.Forms.Label()
        Me.CheckedListBox1 = New System.Windows.Forms.CheckedListBox()
        Me.lblType = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.header = New System.Windows.Forms.Label()
        Me.lblInspectorID = New System.Windows.Forms.Label()
        Me.lblInspectionNo = New System.Windows.Forms.Label()
        Me.lblPlate = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnRemove
        '
        Me.btnRemove.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRemove.Location = New System.Drawing.Point(16, 873)
        Me.btnRemove.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(196, 65)
        Me.btnRemove.TabIndex = 7
        Me.btnRemove.Text = "REMOVE CODE"
        Me.btnRemove.UseVisualStyleBackColor = True
        '
        'btnMeasureEsc
        '
        Me.btnMeasureEsc.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMeasureEsc.Location = New System.Drawing.Point(731, 873)
        Me.btnMeasureEsc.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnMeasureEsc.Name = "btnMeasureEsc"
        Me.btnMeasureEsc.Size = New System.Drawing.Size(143, 65)
        Me.btnMeasureEsc.TabIndex = 8
        Me.btnMeasureEsc.Text = "ESC"
        Me.btnMeasureEsc.UseVisualStyleBackColor = True
        '
        'lblUserCode
        '
        Me.lblUserCode.AutoSize = True
        Me.lblUserCode.Location = New System.Drawing.Point(20, 973)
        Me.lblUserCode.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblUserCode.Name = "lblUserCode"
        Me.lblUserCode.Size = New System.Drawing.Size(51, 17)
        Me.lblUserCode.TabIndex = 9
        Me.lblUserCode.Text = "Label1"
        Me.lblUserCode.Visible = False
        '
        'CheckedListBox1
        '
        Me.CheckedListBox1.BackColor = System.Drawing.SystemColors.Window
        Me.CheckedListBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckedListBox1.FormattingEnabled = True
        Me.CheckedListBox1.HorizontalScrollbar = True
        Me.CheckedListBox1.Location = New System.Drawing.Point(7, 236)
        Me.CheckedListBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CheckedListBox1.Name = "CheckedListBox1"
        Me.CheckedListBox1.Size = New System.Drawing.Size(1417, 604)
        Me.CheckedListBox1.TabIndex = 10
        '
        'lblType
        '
        Me.lblType.AutoSize = True
        Me.lblType.Location = New System.Drawing.Point(107, 973)
        Me.lblType.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblType.Name = "lblType"
        Me.lblType.Size = New System.Drawing.Size(54, 17)
        Me.lblType.TabIndex = 12
        Me.lblType.Text = "lblType"
        Me.lblType.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(509, 39)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(568, 52)
        Me.Label3.TabIndex = 273
        Me.Label3.Text = "REVIEW MEASUREMENT"
        '
        'header
        '
        Me.header.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.header.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.header.ForeColor = System.Drawing.Color.White
        Me.header.Location = New System.Drawing.Point(-3, -3)
        Me.header.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.header.Name = "header"
        Me.header.Size = New System.Drawing.Size(1427, 95)
        Me.header.TabIndex = 272
        '
        'lblInspectorID
        '
        Me.lblInspectorID.AutoSize = True
        Me.lblInspectorID.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblInspectorID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInspectorID.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblInspectorID.Location = New System.Drawing.Point(16, 59)
        Me.lblInspectorID.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblInspectorID.Name = "lblInspectorID"
        Me.lblInspectorID.Size = New System.Drawing.Size(101, 25)
        Me.lblInspectorID.TabIndex = 274
        Me.lblInspectorID.Text = "Inspector"
        Me.lblInspectorID.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblInspectionNo
        '
        Me.lblInspectionNo.AutoSize = True
        Me.lblInspectionNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInspectionNo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblInspectionNo.Location = New System.Drawing.Point(17, 137)
        Me.lblInspectionNo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblInspectionNo.Name = "lblInspectionNo"
        Me.lblInspectionNo.Size = New System.Drawing.Size(95, 20)
        Me.lblInspectionNo.TabIndex = 276
        Me.lblInspectionNo.Text = "Inspection"
        Me.lblInspectionNo.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblPlate
        '
        Me.lblPlate.AutoSize = True
        Me.lblPlate.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPlate.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblPlate.Location = New System.Drawing.Point(17, 171)
        Me.lblPlate.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPlate.Name = "lblPlate"
        Me.lblPlate.Size = New System.Drawing.Size(81, 31)
        Me.lblPlate.TabIndex = 275
        Me.lblPlate.Text = "Plate"
        Me.lblPlate.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'ReviewMeasurement
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(1399, 696)
        Me.Controls.Add(Me.lblInspectionNo)
        Me.Controls.Add(Me.lblPlate)
        Me.Controls.Add(Me.lblInspectorID)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.header)
        Me.Controls.Add(Me.lblType)
        Me.Controls.Add(Me.CheckedListBox1)
        Me.Controls.Add(Me.lblUserCode)
        Me.Controls.Add(Me.btnMeasureEsc)
        Me.Controls.Add(Me.btnRemove)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "ReviewMeasurement"
        Me.Text = "ReviewMeasurement"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnRemove As System.Windows.Forms.Button
    Friend WithEvents btnMeasureEsc As System.Windows.Forms.Button
    Friend WithEvents lblUserCode As System.Windows.Forms.Label
    Friend WithEvents CheckedListBox1 As System.Windows.Forms.CheckedListBox
    Friend WithEvents lblType As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents header As System.Windows.Forms.Label
    Friend WithEvents lblInspectorID As Label
    Friend WithEvents lblInspectionNo As Label
    Friend WithEvents lblPlate As Label
End Class
