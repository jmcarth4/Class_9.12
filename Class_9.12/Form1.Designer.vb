<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.SubmitButton = New System.Windows.Forms.Button()
        Me.InputTextBox = New System.Windows.Forms.TextBox()
        Me.OutputLabel = New System.Windows.Forms.Label()
        Me.BadLabel = New System.Windows.Forms.Label()
        Me.GoodLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'SubmitButton
        '
        Me.SubmitButton.Location = New System.Drawing.Point(374, 206)
        Me.SubmitButton.Name = "SubmitButton"
        Me.SubmitButton.Size = New System.Drawing.Size(130, 66)
        Me.SubmitButton.TabIndex = 0
        Me.SubmitButton.Text = "Submit"
        Me.SubmitButton.UseVisualStyleBackColor = True
        '
        'InputTextBox
        '
        Me.InputTextBox.Location = New System.Drawing.Point(343, 114)
        Me.InputTextBox.Name = "InputTextBox"
        Me.InputTextBox.Size = New System.Drawing.Size(100, 26)
        Me.InputTextBox.TabIndex = 1
        '
        'OutputLabel
        '
        Me.OutputLabel.AutoSize = True
        Me.OutputLabel.Location = New System.Drawing.Point(582, 104)
        Me.OutputLabel.Name = "OutputLabel"
        Me.OutputLabel.Size = New System.Drawing.Size(58, 20)
        Me.OutputLabel.TabIndex = 2
        Me.OutputLabel.Text = "Output"
        '
        'BadLabel
        '
        Me.BadLabel.AutoSize = True
        Me.BadLabel.Location = New System.Drawing.Point(582, 176)
        Me.BadLabel.Name = "BadLabel"
        Me.BadLabel.Size = New System.Drawing.Size(18, 20)
        Me.BadLabel.TabIndex = 3
        Me.BadLabel.Text = "0"
        '
        'GoodLabel
        '
        Me.GoodLabel.AutoSize = True
        Me.GoodLabel.Location = New System.Drawing.Point(582, 229)
        Me.GoodLabel.Name = "GoodLabel"
        Me.GoodLabel.Size = New System.Drawing.Size(18, 20)
        Me.GoodLabel.TabIndex = 4
        Me.GoodLabel.Text = "0"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.GoodLabel)
        Me.Controls.Add(Me.BadLabel)
        Me.Controls.Add(Me.OutputLabel)
        Me.Controls.Add(Me.InputTextBox)
        Me.Controls.Add(Me.SubmitButton)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents SubmitButton As Button
    Friend WithEvents InputTextBox As TextBox
    Friend WithEvents OutputLabel As Label
    Friend WithEvents BadLabel As Label
    Friend WithEvents GoodLabel As Label
End Class
