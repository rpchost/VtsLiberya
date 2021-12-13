<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MahaRymeProcessor
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
        Me.header = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.lblStatus = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblSectionsDisplay = New System.Windows.Forms.Label()
        Me.lblSectionsDsc = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.grdRymeProcess = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtPlate = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtInspectionNo = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Cal = New System.Windows.Forms.MonthCalendar()
        Me.cmbStatus = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnFilter = New System.Windows.Forms.Button()
        Me.txtDate = New System.Windows.Forms.TextBox()
        Me.btnDate = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        CType(Me.grdRymeProcess, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'header
        '
        Me.header.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.header.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.header.ForeColor = System.Drawing.Color.White
        Me.header.Location = New System.Drawing.Point(-1, 1)
        Me.header.Name = "header"
        Me.header.Size = New System.Drawing.Size(1400, 95)
        Me.header.TabIndex = 10
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(583, 48)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(557, 52)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "VTS RYME PROCESSOR"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(83, 132)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowTemplate.Height = 28
        Me.DataGridView1.Size = New System.Drawing.Size(81, 108)
        Me.DataGridView1.TabIndex = 13
        Me.DataGridView1.Visible = False
        '
        'Timer1
        '
        '
        'DataGridView2
        '
        Me.DataGridView2.AllowUserToDeleteRows = False
        Me.DataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView2.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Location = New System.Drawing.Point(43, 253)
        Me.DataGridView2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.ReadOnly = True
        Me.DataGridView2.RowTemplate.Height = 28
        Me.DataGridView2.Size = New System.Drawing.Size(158, 70)
        Me.DataGridView2.TabIndex = 20
        Me.DataGridView2.Visible = False
        '
        'StatusStrip1
        '
        Me.StatusStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(27, 27)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblStatus, Me.ToolStripStatusLabel1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 1145)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Padding = New System.Windows.Forms.Padding(1, 0, 11, 0)
        Me.StatusStrip1.Size = New System.Drawing.Size(1551, 22)
        Me.StatusStrip1.TabIndex = 22
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'lblStatus
        '
        Me.lblStatus.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblStatus.ForeColor = System.Drawing.Color.Red
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(0, 17)
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(0, 17)
        '
        'lblSectionsDisplay
        '
        Me.lblSectionsDisplay.AutoSize = True
        Me.lblSectionsDisplay.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSectionsDisplay.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblSectionsDisplay.Location = New System.Drawing.Point(48, 144)
        Me.lblSectionsDisplay.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSectionsDisplay.Name = "lblSectionsDisplay"
        Me.lblSectionsDisplay.Size = New System.Drawing.Size(0, 20)
        Me.lblSectionsDisplay.TabIndex = 23
        '
        'lblSectionsDsc
        '
        Me.lblSectionsDsc.AutoSize = True
        Me.lblSectionsDsc.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSectionsDsc.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblSectionsDsc.Location = New System.Drawing.Point(201, 144)
        Me.lblSectionsDsc.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSectionsDsc.Name = "lblSectionsDsc"
        Me.lblSectionsDsc.Size = New System.Drawing.Size(0, 20)
        Me.lblSectionsDsc.TabIndex = 24
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(1016, 1070)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(152, 75)
        Me.Button1.TabIndex = 25
        Me.Button1.Text = "ESC"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(592, 1070)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(155, 75)
        Me.Button2.TabIndex = 26
        Me.Button2.Text = "LOGGER"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'grdRymeProcess
        '
        Me.grdRymeProcess.AllowUserToDeleteRows = False
        Me.grdRymeProcess.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.grdRymeProcess.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.grdRymeProcess.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdRymeProcess.Location = New System.Drawing.Point(365, 325)
        Me.grdRymeProcess.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.grdRymeProcess.Name = "grdRymeProcess"
        Me.grdRymeProcess.ReadOnly = True
        Me.grdRymeProcess.RowTemplate.Height = 28
        Me.grdRymeProcess.Size = New System.Drawing.Size(1170, 705)
        Me.grdRymeProcess.TabIndex = 27
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(257, 272)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 18)
        Me.Label1.TabIndex = 28
        Me.Label1.Text = "Filter By : "
        '
        'txtPlate
        '
        Me.txtPlate.Location = New System.Drawing.Point(392, 294)
        Me.txtPlate.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtPlate.Name = "txtPlate"
        Me.txtPlate.Size = New System.Drawing.Size(132, 22)
        Me.txtPlate.TabIndex = 29
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(388, 272)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 18)
        Me.Label2.TabIndex = 30
        Me.Label2.Text = "Plate"
        '
        'txtInspectionNo
        '
        Me.txtInspectionNo.Location = New System.Drawing.Point(560, 294)
        Me.txtInspectionNo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtInspectionNo.Name = "txtInspectionNo"
        Me.txtInspectionNo.Size = New System.Drawing.Size(203, 22)
        Me.txtInspectionNo.TabIndex = 31
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(556, 272)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(107, 18)
        Me.Label4.TabIndex = 32
        Me.Label4.Text = "InspectionNo"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(797, 272)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(85, 18)
        Me.Label5.TabIndex = 33
        Me.Label5.Text = "Date/Time"
        '
        'Cal
        '
        Me.Cal.Location = New System.Drawing.Point(801, 324)
        Me.Cal.Margin = New System.Windows.Forms.Padding(12, 11, 12, 11)
        Me.Cal.Name = "Cal"
        Me.Cal.TabIndex = 34
        Me.Cal.Visible = False
        '
        'cmbStatus
        '
        Me.cmbStatus.FormattingEnabled = True
        Me.cmbStatus.Items.AddRange(New Object() {"Success", "Failure"})
        Me.cmbStatus.Location = New System.Drawing.Point(1147, 295)
        Me.cmbStatus.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmbStatus.Name = "cmbStatus"
        Me.cmbStatus.Size = New System.Drawing.Size(160, 24)
        Me.cmbStatus.TabIndex = 35
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(1143, 272)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(56, 18)
        Me.Label6.TabIndex = 36
        Me.Label6.Text = "Status"
        '
        'btnFilter
        '
        Me.btnFilter.Location = New System.Drawing.Point(1343, 292)
        Me.btnFilter.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnFilter.Name = "btnFilter"
        Me.btnFilter.Size = New System.Drawing.Size(100, 28)
        Me.btnFilter.TabIndex = 37
        Me.btnFilter.Text = "Filter"
        Me.btnFilter.UseVisualStyleBackColor = True
        '
        'txtDate
        '
        Me.txtDate.Location = New System.Drawing.Point(801, 297)
        Me.txtDate.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtDate.Name = "txtDate"
        Me.txtDate.Size = New System.Drawing.Size(139, 22)
        Me.txtDate.TabIndex = 38
        '
        'btnDate
        '
        Me.btnDate.Location = New System.Drawing.Point(949, 295)
        Me.btnDate.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnDate.Name = "btnDate"
        Me.btnDate.Size = New System.Drawing.Size(47, 28)
        Me.btnDate.TabIndex = 39
        Me.btnDate.Text = "..."
        Me.btnDate.UseVisualStyleBackColor = True
        '
        'MahaRymeProcessor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(1572, 1030)
        Me.Controls.Add(Me.btnDate)
        Me.Controls.Add(Me.txtDate)
        Me.Controls.Add(Me.btnFilter)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cmbStatus)
        Me.Controls.Add(Me.Cal)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtInspectionNo)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtPlate)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.grdRymeProcess)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lblSectionsDsc)
        Me.Controls.Add(Me.lblSectionsDisplay)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.header)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MinimizeBox = False
        Me.Name = "MahaRymeProcessor"
        Me.Text = "VTS RYME PROCESSOR"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        CType(Me.grdRymeProcess, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents header As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Timer1 As Timer
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents lblStatus As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents lblSectionsDisplay As Label
    Friend WithEvents lblSectionsDsc As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents grdRymeProcess As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents txtPlate As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtInspectionNo As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Cal As MonthCalendar
    Friend WithEvents cmbStatus As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents btnFilter As Button
    Friend WithEvents txtDate As TextBox
    Friend WithEvents btnDate As Button
End Class
