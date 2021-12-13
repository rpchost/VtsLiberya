<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ManageSections
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
        Me.header = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.txtLbl = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtDsc = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbIO = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtDir = New System.Windows.Forms.TextBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnEsc = New System.Windows.Forms.Button()
        Me.cmbType = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'header
        '
        Me.header.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.header.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.header.ForeColor = System.Drawing.Color.White
        Me.header.Location = New System.Drawing.Point(1, -4)
        Me.header.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.header.Name = "header"
        Me.header.Size = New System.Drawing.Size(1750, 130)
        Me.header.TabIndex = 16
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(580, 57)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(628, 69)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "MANAGE SECTIONS"
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(239, 426)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 30
        Me.DataGridView1.Size = New System.Drawing.Size(1351, 416)
        Me.DataGridView1.TabIndex = 18
        '
        'txtLbl
        '
        Me.txtLbl.Location = New System.Drawing.Point(324, 361)
        Me.txtLbl.Name = "txtLbl"
        Me.txtLbl.Size = New System.Drawing.Size(177, 28)
        Me.txtLbl.TabIndex = 19
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(389, 321)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 24)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "LABEL"
        '
        'txtDsc
        '
        Me.txtDsc.Location = New System.Drawing.Point(532, 361)
        Me.txtDsc.Name = "txtDsc"
        Me.txtDsc.Size = New System.Drawing.Size(273, 28)
        Me.txtDsc.TabIndex = 21
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(620, 321)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(135, 24)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "DESCRIPTION"
        '
        'cmbIO
        '
        Me.cmbIO.FormattingEnabled = True
        Me.cmbIO.Items.AddRange(New Object() {"IN", "OUT"})
        Me.cmbIO.Location = New System.Drawing.Point(825, 359)
        Me.cmbIO.Name = "cmbIO"
        Me.cmbIO.Size = New System.Drawing.Size(121, 30)
        Me.cmbIO.TabIndex = 23
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(852, 321)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(73, 24)
        Me.Label4.TabIndex = 24
        Me.Label4.Text = "IN/OUT"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(1051, 321)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(118, 24)
        Me.Label5.TabIndex = 25
        Me.Label5.Text = "DIRECTORY"
        '
        'txtDir
        '
        Me.txtDir.Location = New System.Drawing.Point(968, 359)
        Me.txtDir.Name = "txtDir"
        Me.txtDir.Size = New System.Drawing.Size(273, 28)
        Me.txtDir.TabIndex = 26
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(1460, 352)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 35)
        Me.btnAdd.TabIndex = 27
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(1623, 426)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(118, 39)
        Me.btnDelete.TabIndex = 28
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnEsc
        '
        Me.btnEsc.Location = New System.Drawing.Point(812, 906)
        Me.btnEsc.Name = "btnEsc"
        Me.btnEsc.Size = New System.Drawing.Size(150, 85)
        Me.btnEsc.TabIndex = 29
        Me.btnEsc.Text = "ESC"
        Me.btnEsc.UseVisualStyleBackColor = True
        '
        'cmbType
        '
        Me.cmbType.FormattingEnabled = True
        Me.cmbType.Items.AddRange(New Object() {"RYME", "VTS"})
        Me.cmbType.Location = New System.Drawing.Point(1268, 357)
        Me.cmbType.Name = "cmbType"
        Me.cmbType.Size = New System.Drawing.Size(121, 30)
        Me.cmbType.TabIndex = 30
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(1300, 321)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(59, 24)
        Me.Label6.TabIndex = 31
        Me.Label6.Text = "TYPE"
        '
        'ManageSections
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 22.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1694, 1003)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cmbType)
        Me.Controls.Add(Me.btnEsc)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.txtDir)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cmbIO)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtDsc)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtLbl)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.header)
        Me.Name = "ManageSections"
        Me.Text = "ManageSections"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents header As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents txtLbl As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtDsc As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents cmbIO As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtDir As TextBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnEsc As Button
    Friend WithEvents cmbType As ComboBox
    Friend WithEvents Label6 As Label
End Class
