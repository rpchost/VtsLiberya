<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form5
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
        Me.btnEsc = New System.Windows.Forms.Button
        Me.btnSave = New System.Windows.Forms.Button
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox
        Me.btnf7 = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'btnEsc
        '
        Me.btnEsc.Location = New System.Drawing.Point(365, 416)
        Me.btnEsc.Name = "btnEsc"
        Me.btnEsc.Size = New System.Drawing.Size(75, 44)
        Me.btnEsc.TabIndex = 0
        Me.btnEsc.Text = "ESC"
        Me.btnEsc.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(234, 414)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 44)
        Me.btnSave.TabIndex = 1
        Me.btnSave.Text = "F4"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Location = New System.Drawing.Point(12, 232)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(261, 137)
        Me.RichTextBox1.TabIndex = 2
        Me.RichTextBox1.Text = ""
        Me.RichTextBox1.Visible = False
        '
        'btnf7
        '
        Me.btnf7.Location = New System.Drawing.Point(99, 416)
        Me.btnf7.Name = "btnf7"
        Me.btnf7.Size = New System.Drawing.Size(75, 42)
        Me.btnf7.TabIndex = 3
        Me.btnf7.Text = "F7"
        Me.btnf7.UseVisualStyleBackColor = True
        '
        'Form5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(576, 477)
        Me.Controls.Add(Me.btnf7)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnEsc)
        Me.Name = "Form5"
        Me.Text = "Form5"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnEsc As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents RichTextBox1 As System.Windows.Forms.RichTextBox
    Friend WithEvents btnf7 As System.Windows.Forms.Button
End Class
