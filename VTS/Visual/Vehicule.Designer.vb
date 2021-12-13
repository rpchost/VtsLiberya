<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Vehicule
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnPresentation = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.header = New System.Windows.Forms.Label()
        Me.btnContSuppEsc = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(590, 182)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 18)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Label3"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(590, 206)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 18)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Label4"
        '
        'btnPresentation
        '
        Me.btnPresentation.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPresentation.Location = New System.Drawing.Point(450, 313)
        Me.btnPresentation.Name = "btnPresentation"
        Me.btnPresentation.Size = New System.Drawing.Size(320, 159)
        Me.btnPresentation.TabIndex = 4
        Me.btnPresentation.Text = "A 0.3.1 Présentation du véhicule"
        Me.btnPresentation.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(519, 475)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(154, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "0.3.1 Présentation du  véhicule"
        Me.Label2.Visible = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(506, 35)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(197, 39)
        Me.Label8.TabIndex = 121
        Me.Label8.Text = "VEHICULE"
        '
        'header
        '
        Me.header.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.header.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.header.ForeColor = System.Drawing.Color.White
        Me.header.Location = New System.Drawing.Point(2, 0)
        Me.header.Name = "header"
        Me.header.Size = New System.Drawing.Size(1311, 77)
        Me.header.TabIndex = 120
        '
        'btnContSuppEsc
        '
        Me.btnContSuppEsc.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnContSuppEsc.Location = New System.Drawing.Point(572, 557)
        Me.btnContSuppEsc.Name = "btnContSuppEsc"
        Me.btnContSuppEsc.Size = New System.Drawing.Size(100, 72)
        Me.btnContSuppEsc.TabIndex = 122
        Me.btnContSuppEsc.Text = "ESC"
        Me.btnContSuppEsc.UseVisualStyleBackColor = True
        '
        'Vehicule
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1313, 679)
        Me.Controls.Add(Me.btnContSuppEsc)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.header)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnPresentation)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Name = "Vehicule"
        Me.Text = "Vehicule"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnPresentation As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents header As System.Windows.Forms.Label
    Friend WithEvents btnContSuppEsc As System.Windows.Forms.Button
End Class
