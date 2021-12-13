<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Select_Vehicle
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnSignOut = New System.Windows.Forms.Button()
        Me.header = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.lblInspectorID = New System.Windows.Forms.Label()
        Me.lblSection = New System.Windows.Forms.Label()
        Me.lblLane = New System.Windows.Forms.Label()
        Me.lblGroup = New System.Windows.Forms.Label()
        Me.lstVehicle = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(0, 100)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 24)
        Me.Label1.TabIndex = 6
        Me.Label1.Visible = False
        '
        'btnSignOut
        '
        Me.btnSignOut.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSignOut.Location = New System.Drawing.Point(679, 811)
        Me.btnSignOut.Name = "btnSignOut"
        Me.btnSignOut.Size = New System.Drawing.Size(139, 74)
        Me.btnSignOut.TabIndex = 2
        Me.btnSignOut.Text = "LOGOUT"
        Me.btnSignOut.UseVisualStyleBackColor = True
        '
        'header
        '
        Me.header.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.header.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.header.ForeColor = System.Drawing.Color.White
        Me.header.Location = New System.Drawing.Point(-3, -3)
        Me.header.Name = "header"
        Me.header.Size = New System.Drawing.Size(1490, 77)
        Me.header.TabIndex = 9
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(725, 35)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(321, 39)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "SELECT VEHICLE"
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(957, 812)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(145, 72)
        Me.Button2.TabIndex = 12
        Me.Button2.Text = "EXIT"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        '
        'lblInspectorID
        '
        Me.lblInspectorID.AutoSize = True
        Me.lblInspectorID.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblInspectorID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInspectorID.ForeColor = System.Drawing.Color.White
        Me.lblInspectorID.Location = New System.Drawing.Point(2, 54)
        Me.lblInspectorID.Name = "lblInspectorID"
        Me.lblInspectorID.Size = New System.Drawing.Size(85, 20)
        Me.lblInspectorID.TabIndex = 13
        Me.lblInspectorID.Text = "Inspector"
        '
        'lblSection
        '
        Me.lblSection.AutoSize = True
        Me.lblSection.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblSection.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.857143!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSection.ForeColor = System.Drawing.Color.White
        Me.lblSection.Location = New System.Drawing.Point(97, 5)
        Me.lblSection.Name = "lblSection"
        Me.lblSection.Size = New System.Drawing.Size(62, 17)
        Me.lblSection.TabIndex = 296
        Me.lblSection.Text = "Section"
        Me.lblSection.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblLane
        '
        Me.lblLane.AutoSize = True
        Me.lblLane.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblLane.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.857143!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLane.ForeColor = System.Drawing.Color.White
        Me.lblLane.Location = New System.Drawing.Point(8, 5)
        Me.lblLane.Name = "lblLane"
        Me.lblLane.Size = New System.Drawing.Size(44, 17)
        Me.lblLane.TabIndex = 295
        Me.lblLane.Text = "Lane"
        Me.lblLane.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblGroup
        '
        Me.lblGroup.AutoSize = True
        Me.lblGroup.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblGroup.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGroup.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblGroup.Location = New System.Drawing.Point(4, 28)
        Me.lblGroup.Name = "lblGroup"
        Me.lblGroup.Size = New System.Drawing.Size(59, 20)
        Me.lblGroup.TabIndex = 294
        Me.lblGroup.Text = "Group"
        Me.lblGroup.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lstVehicle
        '
        Me.lstVehicle.Font = New System.Drawing.Font("Arial", 21.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstVehicle.FormattingEnabled = True
        Me.lstVehicle.ItemHeight = 33
        Me.lstVehicle.Location = New System.Drawing.Point(679, 117)
        Me.lstVehicle.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.lstVehicle.Name = "lstVehicle"
        Me.lstVehicle.Size = New System.Drawing.Size(423, 664)
        Me.lstVehicle.TabIndex = 297
        '
        'Select_Vehicle
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1489, 965)
        Me.Controls.Add(Me.lstVehicle)
        Me.Controls.Add(Me.lblSection)
        Me.Controls.Add(Me.lblLane)
        Me.Controls.Add(Me.lblGroup)
        Me.Controls.Add(Me.lblInspectorID)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.header)
        Me.Controls.Add(Me.btnSignOut)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Select_Vehicle"
        Me.Text = "Select_Vehicle"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnSignOut As System.Windows.Forms.Button
    Friend WithEvents header As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents lblInspectorID As Label
    Friend WithEvents lblSection As Label
    Friend WithEvents lblLane As Label
    Friend WithEvents lblGroup As Label
    Friend WithEvents lstVehicle As ListBox
End Class
