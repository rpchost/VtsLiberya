<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ComputerNamePattern
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbPattern1 = New System.Windows.Forms.ComboBox()
        Me.cmbPattern2 = New System.Windows.Forms.ComboBox()
        Me.lblCurrentPattern = New System.Windows.Forms.Label()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnEsc = New System.Windows.Forms.Button()
        Me.txtPrefix = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'header
        '
        Me.header.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.header.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.header.ForeColor = System.Drawing.Color.White
        Me.header.Location = New System.Drawing.Point(1, 0)
        Me.header.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.header.Name = "header"
        Me.header.Size = New System.Drawing.Size(1379, 77)
        Me.header.TabIndex = 17
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(508, 38)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(515, 39)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "COMPUTER NAME PATTERN"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.15951!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(578, 324)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 17)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Prefix"
        '
        'cmbPattern1
        '
        Me.cmbPattern1.FormattingEnabled = True
        Me.cmbPattern1.Items.AddRange(New Object() {"Lane", "Section"})
        Me.cmbPattern1.Location = New System.Drawing.Point(748, 324)
        Me.cmbPattern1.Margin = New System.Windows.Forms.Padding(2)
        Me.cmbPattern1.Name = "cmbPattern1"
        Me.cmbPattern1.Size = New System.Drawing.Size(74, 21)
        Me.cmbPattern1.TabIndex = 21
        '
        'cmbPattern2
        '
        Me.cmbPattern2.FormattingEnabled = True
        Me.cmbPattern2.Items.AddRange(New Object() {"Lane", "Section"})
        Me.cmbPattern2.Location = New System.Drawing.Point(823, 324)
        Me.cmbPattern2.Margin = New System.Windows.Forms.Padding(2)
        Me.cmbPattern2.Name = "cmbPattern2"
        Me.cmbPattern2.Size = New System.Drawing.Size(74, 21)
        Me.cmbPattern2.TabIndex = 22
        '
        'lblCurrentPattern
        '
        Me.lblCurrentPattern.AutoSize = True
        Me.lblCurrentPattern.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCurrentPattern.ForeColor = System.Drawing.Color.Teal
        Me.lblCurrentPattern.Location = New System.Drawing.Point(743, 242)
        Me.lblCurrentPattern.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblCurrentPattern.Name = "lblCurrentPattern"
        Me.lblCurrentPattern.Size = New System.Drawing.Size(89, 26)
        Me.lblCurrentPattern.TabIndex = 24
        Me.lblCurrentPattern.Text = "Pattern"
        '
        'btnUpdate
        '
        Me.btnUpdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.Location = New System.Drawing.Point(733, 371)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(103, 50)
        Me.btnUpdate.TabIndex = 31
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnEsc
        '
        Me.btnEsc.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEsc.Location = New System.Drawing.Point(744, 610)
        Me.btnEsc.Name = "btnEsc"
        Me.btnEsc.Size = New System.Drawing.Size(88, 50)
        Me.btnEsc.TabIndex = 32
        Me.btnEsc.Text = "ESC"
        Me.btnEsc.UseVisualStyleBackColor = True
        '
        'txtPrefix
        '
        Me.txtPrefix.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrefix.Location = New System.Drawing.Point(663, 316)
        Me.txtPrefix.Margin = New System.Windows.Forms.Padding(2)
        Me.txtPrefix.MaxLength = 10
        Me.txtPrefix.Name = "txtPrefix"
        Me.txtPrefix.Size = New System.Drawing.Size(81, 29)
        Me.txtPrefix.TabIndex = 44
        Me.txtPrefix.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ComputerNamePattern
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1391, 862)
        Me.Controls.Add(Me.txtPrefix)
        Me.Controls.Add(Me.btnEsc)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.lblCurrentPattern)
        Me.Controls.Add(Me.cmbPattern2)
        Me.Controls.Add(Me.cmbPattern1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.header)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "ComputerNamePattern"
        Me.Text = "ComputerNamePattern"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents header As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents cmbPattern1 As ComboBox
    Friend WithEvents cmbPattern2 As ComboBox
    Friend WithEvents lblCurrentPattern As Label
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnEsc As Button
    Friend WithEvents txtPrefix As TextBox
End Class
