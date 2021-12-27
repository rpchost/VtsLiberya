<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CancelInspection
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
        Me.txtPlate = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lstInspections = New System.Windows.Forms.ListBox()
        Me.btnUpdateData = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtPlate
        '
        Me.txtPlate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.857143!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPlate.Location = New System.Drawing.Point(553, 155)
        Me.txtPlate.Margin = New System.Windows.Forms.Padding(2)
        Me.txtPlate.Name = "txtPlate"
        Me.txtPlate.Size = New System.Drawing.Size(113, 22)
        Me.txtPlate.TabIndex = 51
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.857143!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(466, 155)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 17)
        Me.Label1.TabIndex = 50
        Me.Label1.Text = "PLATE"
        '
        'lstInspections
        '
        Me.lstInspections.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstInspections.FormattingEnabled = True
        Me.lstInspections.ItemHeight = 20
        Me.lstInspections.Location = New System.Drawing.Point(290, 223)
        Me.lstInspections.Name = "lstInspections"
        Me.lstInspections.Size = New System.Drawing.Size(648, 204)
        Me.lstInspections.TabIndex = 52
        '
        'btnUpdateData
        '
        Me.btnUpdateData.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.857143!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdateData.Location = New System.Drawing.Point(483, 458)
        Me.btnUpdateData.Margin = New System.Windows.Forms.Padding(2)
        Me.btnUpdateData.Name = "btnUpdateData"
        Me.btnUpdateData.Size = New System.Drawing.Size(239, 38)
        Me.btnUpdateData.TabIndex = 59
        Me.btnUpdateData.Text = "CANCEL INSPECTION"
        Me.btnUpdateData.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.857143!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(549, 590)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(117, 47)
        Me.Button1.TabIndex = 58
        Me.Button1.Text = "ESC"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'CancelInspection
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1121, 667)
        Me.Controls.Add(Me.btnUpdateData)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lstInspections)
        Me.Controls.Add(Me.txtPlate)
        Me.Controls.Add(Me.Label1)
        Me.Name = "CancelInspection"
        Me.Text = "Cancel Inspection"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtPlate As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lstInspections As ListBox
    Friend WithEvents btnUpdateData As Button
    Friend WithEvents Button1 As Button
End Class
