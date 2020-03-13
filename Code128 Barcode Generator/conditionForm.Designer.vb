<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class conditionForm
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ConditionComboBox = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Tai Le", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(36, 38)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(102, 26)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Condition"
        '
        'ConditionComboBox
        '
        Me.ConditionComboBox.FormattingEnabled = True
        Me.ConditionComboBox.Location = New System.Drawing.Point(159, 38)
        Me.ConditionComboBox.Name = "ConditionComboBox"
        Me.ConditionComboBox.Size = New System.Drawing.Size(373, 21)
        Me.ConditionComboBox.TabIndex = 17
        '
        'conditionForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(628, 112)
        Me.Controls.Add(Me.ConditionComboBox)
        Me.Controls.Add(Me.Label2)
        Me.Name = "conditionForm"
        Me.Text = "conditionForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ConditionComboBox As System.Windows.Forms.ComboBox
End Class
