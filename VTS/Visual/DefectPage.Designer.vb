<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DefectPage
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DefectPage))
        Me.lblPlate = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnFrontLeft = New System.Windows.Forms.Button()
        Me.btnFrontMiddle = New System.Windows.Forms.Button()
        Me.btnFrontRight = New System.Windows.Forms.Button()
        Me.btnCenter = New System.Windows.Forms.Button()
        Me.btnCenterLeft = New System.Windows.Forms.Button()
        Me.BtnCenterRight = New System.Windows.Forms.Button()
        Me.btnRearLeft = New System.Windows.Forms.Button()
        Me.btnRearMiddle = New System.Windows.Forms.Button()
        Me.btnRearRight = New System.Windows.Forms.Button()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.Button11 = New System.Windows.Forms.Button()
        Me.Label66 = New System.Windows.Forms.Label()
        Me.btnMinorDefect = New System.Windows.Forms.Button()
        Me.btnMajorDefect = New System.Windows.Forms.Button()
        Me.Button14 = New System.Windows.Forms.Button()
        Me.Button15 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button16 = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnESC = New System.Windows.Forms.Button()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.LabelComments = New System.Windows.Forms.Label()
        Me.header = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblInspectorID = New System.Windows.Forms.Label()
        Me.lblinspectionNO = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblPlate
        '
        Me.lblPlate.AutoSize = True
        Me.lblPlate.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPlate.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblPlate.Location = New System.Drawing.Point(891, 117)
        Me.lblPlate.Name = "lblPlate"
        Me.lblPlate.Size = New System.Drawing.Size(86, 33)
        Me.lblPlate.TabIndex = 0
        Me.lblPlate.Text = "Plate"
        Me.lblPlate.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(862, 232)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(152, 295)
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'btnFrontLeft
        '
        Me.btnFrontLeft.BackColor = System.Drawing.Color.Silver
        Me.btnFrontLeft.Location = New System.Drawing.Point(803, 243)
        Me.btnFrontLeft.Name = "btnFrontLeft"
        Me.btnFrontLeft.Size = New System.Drawing.Size(75, 23)
        Me.btnFrontLeft.TabIndex = 2
        Me.btnFrontLeft.Text = "Front Left"
        Me.btnFrontLeft.UseVisualStyleBackColor = False
        '
        'btnFrontMiddle
        '
        Me.btnFrontMiddle.BackColor = System.Drawing.Color.Silver
        Me.btnFrontMiddle.Location = New System.Drawing.Point(902, 215)
        Me.btnFrontMiddle.Name = "btnFrontMiddle"
        Me.btnFrontMiddle.Size = New System.Drawing.Size(75, 23)
        Me.btnFrontMiddle.TabIndex = 3
        Me.btnFrontMiddle.Text = "Front Middle"
        Me.btnFrontMiddle.UseVisualStyleBackColor = False
        '
        'btnFrontRight
        '
        Me.btnFrontRight.BackColor = System.Drawing.Color.Silver
        Me.btnFrontRight.Location = New System.Drawing.Point(1008, 240)
        Me.btnFrontRight.Name = "btnFrontRight"
        Me.btnFrontRight.Size = New System.Drawing.Size(75, 23)
        Me.btnFrontRight.TabIndex = 4
        Me.btnFrontRight.Text = "Front right"
        Me.btnFrontRight.UseVisualStyleBackColor = False
        '
        'btnCenter
        '
        Me.btnCenter.BackColor = System.Drawing.Color.Silver
        Me.btnCenter.Location = New System.Drawing.Point(893, 362)
        Me.btnCenter.Name = "btnCenter"
        Me.btnCenter.Size = New System.Drawing.Size(99, 23)
        Me.btnCenter.TabIndex = 5
        Me.btnCenter.Text = "Center"
        Me.btnCenter.UseVisualStyleBackColor = False
        '
        'btnCenterLeft
        '
        Me.btnCenterLeft.BackColor = System.Drawing.Color.Silver
        Me.btnCenterLeft.Location = New System.Drawing.Point(803, 362)
        Me.btnCenterLeft.Name = "btnCenterLeft"
        Me.btnCenterLeft.Size = New System.Drawing.Size(75, 23)
        Me.btnCenterLeft.TabIndex = 6
        Me.btnCenterLeft.Text = "Center Left"
        Me.btnCenterLeft.UseVisualStyleBackColor = False
        '
        'BtnCenterRight
        '
        Me.BtnCenterRight.BackColor = System.Drawing.Color.Silver
        Me.BtnCenterRight.Location = New System.Drawing.Point(1008, 362)
        Me.BtnCenterRight.Name = "BtnCenterRight"
        Me.BtnCenterRight.Size = New System.Drawing.Size(75, 23)
        Me.BtnCenterRight.TabIndex = 7
        Me.BtnCenterRight.Text = "Center Right"
        Me.BtnCenterRight.UseVisualStyleBackColor = False
        '
        'btnRearLeft
        '
        Me.btnRearLeft.BackColor = System.Drawing.Color.Silver
        Me.btnRearLeft.Location = New System.Drawing.Point(803, 508)
        Me.btnRearLeft.Name = "btnRearLeft"
        Me.btnRearLeft.Size = New System.Drawing.Size(75, 23)
        Me.btnRearLeft.TabIndex = 8
        Me.btnRearLeft.Text = "Rear Left"
        Me.btnRearLeft.UseVisualStyleBackColor = False
        '
        'btnRearMiddle
        '
        Me.btnRearMiddle.BackColor = System.Drawing.Color.Silver
        Me.btnRearMiddle.Location = New System.Drawing.Point(902, 521)
        Me.btnRearMiddle.Name = "btnRearMiddle"
        Me.btnRearMiddle.Size = New System.Drawing.Size(75, 23)
        Me.btnRearMiddle.TabIndex = 9
        Me.btnRearMiddle.Text = "Rear Middle"
        Me.btnRearMiddle.UseVisualStyleBackColor = False
        '
        'btnRearRight
        '
        Me.btnRearRight.BackColor = System.Drawing.Color.Silver
        Me.btnRearRight.Location = New System.Drawing.Point(1008, 506)
        Me.btnRearRight.Name = "btnRearRight"
        Me.btnRearRight.Size = New System.Drawing.Size(75, 23)
        Me.btnRearRight.TabIndex = 10
        Me.btnRearRight.Text = "Rear Right"
        Me.btnRearRight.UseVisualStyleBackColor = False
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(57, 526)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(53, 18)
        Me.Label22.TabIndex = 11
        Me.Label22.Text = "Axle(n)"
        '
        'Button10
        '
        Me.Button10.Location = New System.Drawing.Point(60, 560)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(75, 23)
        Me.Button10.TabIndex = 12
        Me.Button10.Text = "1"
        Me.Button10.UseVisualStyleBackColor = True
        '
        'Button11
        '
        Me.Button11.Location = New System.Drawing.Point(181, 560)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(75, 23)
        Me.Button11.TabIndex = 13
        Me.Button11.Text = "2"
        Me.Button11.UseVisualStyleBackColor = True
        '
        'Label66
        '
        Me.Label66.AutoSize = True
        Me.Label66.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label66.Location = New System.Drawing.Point(72, 709)
        Me.Label66.Name = "Label66"
        Me.Label66.Size = New System.Drawing.Size(113, 16)
        Me.Label66.TabIndex = 14
        Me.Label66.Text = "Defect Evaluation"
        '
        'btnMinorDefect
        '
        Me.btnMinorDefect.BackColor = System.Drawing.Color.Silver
        Me.btnMinorDefect.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMinorDefect.Location = New System.Drawing.Point(70, 738)
        Me.btnMinorDefect.Name = "btnMinorDefect"
        Me.btnMinorDefect.Size = New System.Drawing.Size(92, 54)
        Me.btnMinorDefect.TabIndex = 15
        Me.btnMinorDefect.Text = "A Minor Defect"
        Me.btnMinorDefect.UseVisualStyleBackColor = False
        '
        'btnMajorDefect
        '
        Me.btnMajorDefect.BackColor = System.Drawing.Color.Silver
        Me.btnMajorDefect.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMajorDefect.Location = New System.Drawing.Point(196, 738)
        Me.btnMajorDefect.Name = "btnMajorDefect"
        Me.btnMajorDefect.Size = New System.Drawing.Size(90, 54)
        Me.btnMajorDefect.TabIndex = 16
        Me.btnMajorDefect.Text = "B Major Defect"
        Me.btnMajorDefect.UseVisualStyleBackColor = False
        '
        'Button14
        '
        Me.Button14.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button14.Location = New System.Drawing.Point(371, 738)
        Me.Button14.Name = "Button14"
        Me.Button14.Size = New System.Drawing.Size(157, 54)
        Me.Button14.TabIndex = 17
        Me.Button14.Text = "C Road Unworthy"
        Me.Button14.UseVisualStyleBackColor = True
        '
        'Button15
        '
        Me.Button15.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button15.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button15.Location = New System.Drawing.Point(803, 560)
        Me.Button15.Name = "Button15"
        Me.Button15.Size = New System.Drawing.Size(280, 93)
        Me.Button15.TabIndex = 18
        Me.Button15.Text = "SAVE"
        Me.Button15.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(40, 204)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 16)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "Label4"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(40, 225)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 16)
        Me.Label5.TabIndex = 20
        Me.Label5.Text = "Label5"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(40, 180)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 16)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "Label2"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(40, 159)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 16)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "Label3"
        '
        'Button16
        '
        Me.Button16.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button16.Location = New System.Drawing.Point(556, 738)
        Me.Button16.Name = "Button16"
        Me.Button16.Size = New System.Drawing.Size(132, 54)
        Me.Button16.TabIndex = 23
        Me.Button16.Text = " D Canceled"
        Me.Button16.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(382, 310)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(120, 18)
        Me.Label6.TabIndex = 26
        Me.Label6.Text = "lblAddedCoded"
        Me.Label6.Visible = False
        '
        'btnESC
        '
        Me.btnESC.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnESC.Location = New System.Drawing.Point(1142, 721)
        Me.btnESC.Name = "btnESC"
        Me.btnESC.Size = New System.Drawing.Size(205, 71)
        Me.btnESC.TabIndex = 0
        Me.btnESC.Text = "ESC"
        Me.btnESC.UseVisualStyleBackColor = True
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBox1.Location = New System.Drawing.Point(203, 345)
        Me.RichTextBox1.Multiline = False
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(453, 28)
        Me.RichTextBox1.TabIndex = 30
        Me.RichTextBox1.Text = ""
        Me.RichTextBox1.Visible = False
        '
        'LabelComments
        '
        Me.LabelComments.AutoSize = True
        Me.LabelComments.Location = New System.Drawing.Point(409, 380)
        Me.LabelComments.Name = "LabelComments"
        Me.LabelComments.Size = New System.Drawing.Size(66, 13)
        Me.LabelComments.TabIndex = 32
        Me.LabelComments.Text = "lblComments"
        Me.LabelComments.Visible = False
        '
        'header
        '
        Me.header.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.header.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.header.ForeColor = System.Drawing.Color.White
        Me.header.Location = New System.Drawing.Point(-2, -4)
        Me.header.Name = "header"
        Me.header.Size = New System.Drawing.Size(1523, 77)
        Me.header.TabIndex = 51
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(621, 31)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(271, 39)
        Me.Label7.TabIndex = 52
        Me.Label7.Text = "DEFECT PAGE"
        '
        'lblInspectorID
        '
        Me.lblInspectorID.AutoSize = True
        Me.lblInspectorID.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblInspectorID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInspectorID.ForeColor = System.Drawing.Color.White
        Me.lblInspectorID.Location = New System.Drawing.Point(12, 50)
        Me.lblInspectorID.Name = "lblInspectorID"
        Me.lblInspectorID.Size = New System.Drawing.Size(85, 20)
        Me.lblInspectorID.TabIndex = 56
        Me.lblInspectorID.Text = "Inspector"
        '
        'lblinspectionNO
        '
        Me.lblinspectionNO.AutoSize = True
        Me.lblinspectionNO.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblinspectionNO.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblinspectionNO.Location = New System.Drawing.Point(14, 97)
        Me.lblinspectionNO.Name = "lblinspectionNO"
        Me.lblinspectionNO.Size = New System.Drawing.Size(96, 16)
        Me.lblinspectionNO.TabIndex = 57
        Me.lblinspectionNO.Text = "inspectionno"
        '
        'DefectPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(1519, 859)
        Me.Controls.Add(Me.lblinspectionNO)
        Me.Controls.Add(Me.lblInspectorID)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.header)
        Me.Controls.Add(Me.LabelComments)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.btnESC)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Button16)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Button15)
        Me.Controls.Add(Me.Button14)
        Me.Controls.Add(Me.btnMajorDefect)
        Me.Controls.Add(Me.btnMinorDefect)
        Me.Controls.Add(Me.Label66)
        Me.Controls.Add(Me.Button11)
        Me.Controls.Add(Me.Button10)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.btnRearRight)
        Me.Controls.Add(Me.btnRearMiddle)
        Me.Controls.Add(Me.btnRearLeft)
        Me.Controls.Add(Me.BtnCenterRight)
        Me.Controls.Add(Me.btnCenterLeft)
        Me.Controls.Add(Me.btnCenter)
        Me.Controls.Add(Me.btnFrontRight)
        Me.Controls.Add(Me.btnFrontMiddle)
        Me.Controls.Add(Me.btnFrontLeft)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lblPlate)
        Me.Name = "DefectPage"
        Me.Text = "DefectPage"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblPlate As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents btnFrontLeft As System.Windows.Forms.Button
    Friend WithEvents btnFrontMiddle As System.Windows.Forms.Button
    Friend WithEvents btnFrontRight As System.Windows.Forms.Button
    Friend WithEvents btnCenter As System.Windows.Forms.Button
    Friend WithEvents btnCenterLeft As System.Windows.Forms.Button
    Friend WithEvents BtnCenterRight As System.Windows.Forms.Button
    Friend WithEvents btnRearLeft As System.Windows.Forms.Button
    Friend WithEvents btnRearMiddle As System.Windows.Forms.Button
    Friend WithEvents btnRearRight As System.Windows.Forms.Button
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Button10 As System.Windows.Forms.Button
    Friend WithEvents Button11 As System.Windows.Forms.Button
    Friend WithEvents Label66 As System.Windows.Forms.Label
    Friend WithEvents btnMinorDefect As System.Windows.Forms.Button
    Friend WithEvents btnMajorDefect As System.Windows.Forms.Button
    Friend WithEvents Button14 As System.Windows.Forms.Button
    Friend WithEvents Button15 As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Button16 As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btnESC As System.Windows.Forms.Button
    Friend WithEvents RichTextBox1 As System.Windows.Forms.RichTextBox
    Friend WithEvents LabelComments As System.Windows.Forms.Label
    Friend WithEvents header As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents lblInspectorID As Label
    Friend WithEvents lblinspectionNO As Label
End Class
