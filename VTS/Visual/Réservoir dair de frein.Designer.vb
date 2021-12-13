<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Réservoir_dair_de_frein
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnDefaut = New System.Windows.Forms.Button()
        Me.btnFixation = New System.Windows.Forms.Button()
        Me.btnMauvais = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnPompeESC = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.header = New System.Windows.Forms.Label()
        Me.lblInspectionNo = New System.Windows.Forms.Label()
        Me.lblInspectorID = New System.Windows.Forms.Label()
        Me.lblPlate = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(495, 188)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(137, 42)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Label1"
        '
        'btnDefaut
        '
        Me.btnDefaut.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDefaut.Location = New System.Drawing.Point(767, 276)
        Me.btnDefaut.Name = "btnDefaut"
        Me.btnDefaut.Size = New System.Drawing.Size(261, 133)
        Me.btnDefaut.TabIndex = 6
        Me.btnDefaut.Text = "1.7.1.1.3 Défaut d'étanchéité"
        Me.btnDefaut.UseVisualStyleBackColor = True
        '
        'btnFixation
        '
        Me.btnFixation.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFixation.Location = New System.Drawing.Point(483, 276)
        Me.btnFixation.Name = "btnFixation"
        Me.btnFixation.Size = New System.Drawing.Size(232, 133)
        Me.btnFixation.TabIndex = 5
        Me.btnFixation.Text = "1.7.1.1.2 Mauvais fixation"
        Me.btnFixation.UseVisualStyleBackColor = True
        '
        'btnMauvais
        '
        Me.btnMauvais.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMauvais.Location = New System.Drawing.Point(225, 276)
        Me.btnMauvais.Name = "btnMauvais"
        Me.btnMauvais.Size = New System.Drawing.Size(203, 133)
        Me.btnMauvais.TabIndex = 4
        Me.btnMauvais.Text = "1.7.1.1.1 Mauvais état"
        Me.btnMauvais.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(302, 162)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 18)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Label2"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(302, 188)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 18)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Label3"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(303, 214)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 18)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Label4"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(247, 438)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(113, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "1.7.1.1.1 Mauvais état"
        Me.Label5.Visible = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(534, 438)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(128, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "1.7.1.1.2 Mauvais fixation"
        Me.Label6.Visible = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(812, 438)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(145, 13)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "1.7.1.1.3 Défaut d'étanchéité"
        Me.Label7.Visible = False
        '
        'btnPompeESC
        '
        Me.btnPompeESC.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPompeESC.Location = New System.Drawing.Point(510, 629)
        Me.btnPompeESC.Name = "btnPompeESC"
        Me.btnPompeESC.Size = New System.Drawing.Size(111, 69)
        Me.btnPompeESC.TabIndex = 249
        Me.btnPompeESC.Text = "ESC"
        Me.btnPompeESC.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(346, 34)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(513, 39)
        Me.Label8.TabIndex = 251
        Me.Label8.Text = "RESERVOIR D AIR DE FREIN"
        '
        'header
        '
        Me.header.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.header.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.header.ForeColor = System.Drawing.Color.White
        Me.header.Location = New System.Drawing.Point(6, -1)
        Me.header.Name = "header"
        Me.header.Size = New System.Drawing.Size(1050, 77)
        Me.header.TabIndex = 250
        '
        'lblInspectionNo
        '
        Me.lblInspectionNo.AutoSize = True
        Me.lblInspectionNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInspectionNo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblInspectionNo.Location = New System.Drawing.Point(15, 113)
        Me.lblInspectionNo.Name = "lblInspectionNo"
        Me.lblInspectionNo.Size = New System.Drawing.Size(79, 16)
        Me.lblInspectionNo.TabIndex = 254
        Me.lblInspectionNo.Text = "Inspection"
        Me.lblInspectionNo.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblInspectorID
        '
        Me.lblInspectorID.AutoSize = True
        Me.lblInspectorID.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblInspectorID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInspectorID.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblInspectorID.Location = New System.Drawing.Point(21, 53)
        Me.lblInspectorID.Name = "lblInspectorID"
        Me.lblInspectorID.Size = New System.Drawing.Size(85, 20)
        Me.lblInspectorID.TabIndex = 253
        Me.lblInspectorID.Text = "Inspector"
        Me.lblInspectorID.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblPlate
        '
        Me.lblPlate.AutoSize = True
        Me.lblPlate.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPlate.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblPlate.Location = New System.Drawing.Point(15, 141)
        Me.lblPlate.Name = "lblPlate"
        Me.lblPlate.Size = New System.Drawing.Size(66, 25)
        Me.lblPlate.TabIndex = 252
        Me.lblPlate.Text = "Plate"
        Me.lblPlate.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Réservoir_dair_de_frein
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1164, 741)
        Me.Controls.Add(Me.lblInspectionNo)
        Me.Controls.Add(Me.lblInspectorID)
        Me.Controls.Add(Me.lblPlate)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.header)
        Me.Controls.Add(Me.btnPompeESC)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnDefaut)
        Me.Controls.Add(Me.btnFixation)
        Me.Controls.Add(Me.btnMauvais)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Réservoir_dair_de_frein"
        Me.Text = "Réservoir_dair_de_frein"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnDefaut As System.Windows.Forms.Button
    Friend WithEvents btnFixation As System.Windows.Forms.Button
    Friend WithEvents btnMauvais As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents btnPompeESC As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents header As System.Windows.Forms.Label
    Friend WithEvents lblInspectionNo As Label
    Friend WithEvents lblInspectorID As Label
    Friend WithEvents lblPlate As Label
End Class
