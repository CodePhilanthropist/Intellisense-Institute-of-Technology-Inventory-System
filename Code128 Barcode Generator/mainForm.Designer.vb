<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class mainForm
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
        Me.ItemNoTextBox = New System.Windows.Forms.TextBox()
        Me.SaveButton = New System.Windows.Forms.Button()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.QuitButton = New System.Windows.Forms.Button()
        Me.ReportButton = New System.Windows.Forms.Button()
        Me.SearchButton = New System.Windows.Forms.Button()
        Me.DeployButton = New System.Windows.Forms.Button()
        Me.RemarksButton = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape6 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape5 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape4 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape3 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape2 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ItemNameTextBox = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DescriptionTextBox = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.QuanityTextBox = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ValueTextBox = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.SerialNumberTextBox = New System.Windows.Forms.TextBox()
        Me.CategoryTextBox = New System.Windows.Forms.TextBox()
        Me.SearchTypeButton = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.ItemsDataGridView = New System.Windows.Forms.DataGridView()
        Me.AddButton = New System.Windows.Forms.Button()
        Me.SaveCurrentButton = New System.Windows.Forms.Button()
        Me.UpdateButton = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.ItemsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ItemNoTextBox
        '
        Me.ItemNoTextBox.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ItemNoTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ItemNoTextBox.Font = New System.Drawing.Font("Microsoft Tai Le", 18.0!)
        Me.ItemNoTextBox.Location = New System.Drawing.Point(263, 56)
        Me.ItemNoTextBox.Name = "ItemNoTextBox"
        Me.ItemNoTextBox.Size = New System.Drawing.Size(220, 31)
        Me.ItemNoTextBox.TabIndex = 5
        '
        'SaveButton
        '
        Me.SaveButton.BackColor = System.Drawing.Color.DarkGreen
        Me.SaveButton.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.SaveButton.Font = New System.Drawing.Font("Swis721 BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SaveButton.ForeColor = System.Drawing.Color.DarkGreen
        Me.SaveButton.Location = New System.Drawing.Point(312, 392)
        Me.SaveButton.Name = "SaveButton"
        Me.SaveButton.Size = New System.Drawing.Size(110, 46)
        Me.SaveButton.TabIndex = 17
        Me.SaveButton.Text = "Save"
        Me.SaveButton.UseVisualStyleBackColor = False
        '
        'SaveFileDialog1
        '
        Me.SaveFileDialog1.FileName = "Barcode "
        Me.SaveFileDialog1.Filter = "PNG IMAGE|*.png"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.SpringGreen
        Me.Panel1.Controls.Add(Me.QuitButton)
        Me.Panel1.Controls.Add(Me.ReportButton)
        Me.Panel1.Controls.Add(Me.SearchButton)
        Me.Panel1.Controls.Add(Me.DeployButton)
        Me.Panel1.Controls.Add(Me.RemarksButton)
        Me.Panel1.Location = New System.Drawing.Point(-5, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(236, 509)
        Me.Panel1.TabIndex = 4
        '
        'QuitButton
        '
        Me.QuitButton.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.QuitButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.QuitButton.Font = New System.Drawing.Font("Swis721 BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.QuitButton.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.QuitButton.Location = New System.Drawing.Point(35, 284)
        Me.QuitButton.Name = "QuitButton"
        Me.QuitButton.Size = New System.Drawing.Size(177, 46)
        Me.QuitButton.TabIndex = 23
        Me.QuitButton.Text = "Quit"
        Me.QuitButton.UseVisualStyleBackColor = False
        '
        'ReportButton
        '
        Me.ReportButton.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ReportButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ReportButton.Font = New System.Drawing.Font("Swis721 BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ReportButton.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.ReportButton.Location = New System.Drawing.Point(35, 232)
        Me.ReportButton.Name = "ReportButton"
        Me.ReportButton.Size = New System.Drawing.Size(177, 46)
        Me.ReportButton.TabIndex = 22
        Me.ReportButton.Text = "Report"
        Me.ReportButton.UseVisualStyleBackColor = False
        '
        'SearchButton
        '
        Me.SearchButton.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.SearchButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.SearchButton.Font = New System.Drawing.Font("Swis721 BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SearchButton.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.SearchButton.Location = New System.Drawing.Point(35, 180)
        Me.SearchButton.Name = "SearchButton"
        Me.SearchButton.Size = New System.Drawing.Size(177, 46)
        Me.SearchButton.TabIndex = 21
        Me.SearchButton.Text = "Search Item"
        Me.SearchButton.UseVisualStyleBackColor = False
        '
        'DeployButton
        '
        Me.DeployButton.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.DeployButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.DeployButton.Font = New System.Drawing.Font("Swis721 BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DeployButton.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.DeployButton.Location = New System.Drawing.Point(35, 128)
        Me.DeployButton.Name = "DeployButton"
        Me.DeployButton.Size = New System.Drawing.Size(177, 46)
        Me.DeployButton.TabIndex = 20
        Me.DeployButton.Text = "Available Items"
        Me.DeployButton.UseVisualStyleBackColor = False
        '
        'RemarksButton
        '
        Me.RemarksButton.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.RemarksButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.RemarksButton.Font = New System.Drawing.Font("Swis721 BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RemarksButton.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.RemarksButton.Location = New System.Drawing.Point(35, 76)
        Me.RemarksButton.Name = "RemarksButton"
        Me.RemarksButton.Size = New System.Drawing.Size(177, 46)
        Me.RemarksButton.TabIndex = 19
        Me.RemarksButton.Text = "Remarks"
        Me.RemarksButton.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Tai Le", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(260, 24)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 26)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Item No"
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape6, Me.LineShape5, Me.LineShape4, Me.LineShape3, Me.LineShape2, Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(1073, 759)
        Me.ShapeContainer1.TabIndex = 9
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape6
        '
        Me.LineShape6.Name = "LineShape6"
        Me.LineShape6.X1 = 532
        Me.LineShape6.X2 = 754
        Me.LineShape6.Y1 = 329
        Me.LineShape6.Y2 = 329
        '
        'LineShape5
        '
        Me.LineShape5.Name = "LineShape5"
        Me.LineShape5.X1 = 535
        Me.LineShape5.X2 = 757
        Me.LineShape5.Y1 = 249
        Me.LineShape5.Y2 = 249
        '
        'LineShape4
        '
        Me.LineShape4.Name = "LineShape4"
        Me.LineShape4.X1 = 535
        Me.LineShape4.X2 = 757
        Me.LineShape4.Y1 = 171
        Me.LineShape4.Y2 = 171
        '
        'LineShape3
        '
        Me.LineShape3.Name = "LineShape3"
        Me.LineShape3.X1 = 534
        Me.LineShape3.X2 = 756
        Me.LineShape3.Y1 = 88
        Me.LineShape3.Y2 = 88
        '
        'LineShape2
        '
        Me.LineShape2.Name = "LineShape2"
        Me.LineShape2.X1 = 262
        Me.LineShape2.X2 = 484
        Me.LineShape2.Y1 = 171
        Me.LineShape2.Y2 = 171
        '
        'LineShape1
        '
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 263
        Me.LineShape1.X2 = 485
        Me.LineShape1.Y1 = 89
        Me.LineShape1.Y2 = 89
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(633, 465)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(103, 21)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Scan Barcode"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBox1.Location = New System.Drawing.Point(428, 385)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(508, 112)
        Me.PictureBox1.TabIndex = 11
        Me.PictureBox1.TabStop = False
        '
        'ClearButton
        '
        Me.ClearButton.BackColor = System.Drawing.Color.DarkGreen
        Me.ClearButton.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.ClearButton.Font = New System.Drawing.Font("Swis721 BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClearButton.ForeColor = System.Drawing.Color.DarkGreen
        Me.ClearButton.Location = New System.Drawing.Point(312, 444)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(110, 46)
        Me.ClearButton.TabIndex = 18
        Me.ClearButton.Text = "Clear"
        Me.ClearButton.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Tai Le", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(260, 106)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(116, 26)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "Item Name"
        '
        'ItemNameTextBox
        '
        Me.ItemNameTextBox.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ItemNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ItemNameTextBox.Font = New System.Drawing.Font("Microsoft Tai Le", 18.0!)
        Me.ItemNameTextBox.Location = New System.Drawing.Point(263, 138)
        Me.ItemNameTextBox.Name = "ItemNameTextBox"
        Me.ItemNameTextBox.Size = New System.Drawing.Size(220, 31)
        Me.ItemNameTextBox.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Tai Le", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(259, 191)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(117, 26)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "Description"
        '
        'DescriptionTextBox
        '
        Me.DescriptionTextBox.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.DescriptionTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DescriptionTextBox.Font = New System.Drawing.Font("Microsoft Tai Le", 18.0!)
        Me.DescriptionTextBox.Location = New System.Drawing.Point(262, 223)
        Me.DescriptionTextBox.Multiline = True
        Me.DescriptionTextBox.Name = "DescriptionTextBox"
        Me.DescriptionTextBox.Size = New System.Drawing.Size(220, 115)
        Me.DescriptionTextBox.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Tai Le", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(532, 24)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(92, 26)
        Me.Label5.TabIndex = 24
        Me.Label5.Text = "Quantity"
        '
        'QuanityTextBox
        '
        Me.QuanityTextBox.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.QuanityTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.QuanityTextBox.Font = New System.Drawing.Font("Microsoft Tai Le", 18.0!)
        Me.QuanityTextBox.Location = New System.Drawing.Point(535, 56)
        Me.QuanityTextBox.Name = "QuanityTextBox"
        Me.QuanityTextBox.Size = New System.Drawing.Size(220, 31)
        Me.QuanityTextBox.TabIndex = 8
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Tai Le", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(532, 106)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(56, 26)
        Me.Label6.TabIndex = 26
        Me.Label6.Text = "Type"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Tai Le", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(532, 184)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(64, 26)
        Me.Label7.TabIndex = 28
        Me.Label7.Text = "Value"
        '
        'ValueTextBox
        '
        Me.ValueTextBox.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ValueTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ValueTextBox.Font = New System.Drawing.Font("Microsoft Tai Le", 18.0!)
        Me.ValueTextBox.Location = New System.Drawing.Point(535, 216)
        Me.ValueTextBox.Name = "ValueTextBox"
        Me.ValueTextBox.Size = New System.Drawing.Size(220, 31)
        Me.ValueTextBox.TabIndex = 10
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Tai Le", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(529, 264)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(144, 26)
        Me.Label8.TabIndex = 30
        Me.Label8.Text = "Serial Number"
        '
        'SerialNumberTextBox
        '
        Me.SerialNumberTextBox.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.SerialNumberTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.SerialNumberTextBox.Font = New System.Drawing.Font("Microsoft Tai Le", 18.0!)
        Me.SerialNumberTextBox.Location = New System.Drawing.Point(532, 296)
        Me.SerialNumberTextBox.Name = "SerialNumberTextBox"
        Me.SerialNumberTextBox.Size = New System.Drawing.Size(220, 31)
        Me.SerialNumberTextBox.TabIndex = 11
        '
        'CategoryTextBox
        '
        Me.CategoryTextBox.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.CategoryTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.CategoryTextBox.Font = New System.Drawing.Font("Microsoft Tai Le", 18.0!)
        Me.CategoryTextBox.Location = New System.Drawing.Point(535, 138)
        Me.CategoryTextBox.Name = "CategoryTextBox"
        Me.CategoryTextBox.Size = New System.Drawing.Size(220, 31)
        Me.CategoryTextBox.TabIndex = 9
        '
        'SearchTypeButton
        '
        Me.SearchTypeButton.Location = New System.Drawing.Point(768, 142)
        Me.SearchTypeButton.Name = "SearchTypeButton"
        Me.SearchTypeButton.Size = New System.Drawing.Size(40, 26)
        Me.SearchTypeButton.TabIndex = 31
        Me.SearchTypeButton.Text = "..."
        Me.SearchTypeButton.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.SpringGreen
        Me.Panel2.Controls.Add(Me.ItemsDataGridView)
        Me.Panel2.Location = New System.Drawing.Point(-2, 503)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1075, 254)
        Me.Panel2.TabIndex = 33
        '
        'ItemsDataGridView
        '
        Me.ItemsDataGridView.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.ItemsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ItemsDataGridView.Location = New System.Drawing.Point(156, 41)
        Me.ItemsDataGridView.Name = "ItemsDataGridView"
        Me.ItemsDataGridView.Size = New System.Drawing.Size(782, 165)
        Me.ItemsDataGridView.TabIndex = 1
        '
        'AddButton
        '
        Me.AddButton.BackColor = System.Drawing.Color.SpringGreen
        Me.AddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AddButton.Font = New System.Drawing.Font("Microsoft New Tai Lue", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddButton.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.AddButton.Location = New System.Drawing.Point(896, 106)
        Me.AddButton.Name = "AddButton"
        Me.AddButton.Size = New System.Drawing.Size(155, 52)
        Me.AddButton.TabIndex = 48
        Me.AddButton.Text = "Add"
        Me.AddButton.UseVisualStyleBackColor = False
        '
        'SaveCurrentButton
        '
        Me.SaveCurrentButton.BackColor = System.Drawing.Color.SpringGreen
        Me.SaveCurrentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SaveCurrentButton.Font = New System.Drawing.Font("Microsoft New Tai Lue", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SaveCurrentButton.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.SaveCurrentButton.Location = New System.Drawing.Point(896, 164)
        Me.SaveCurrentButton.Name = "SaveCurrentButton"
        Me.SaveCurrentButton.Size = New System.Drawing.Size(155, 52)
        Me.SaveCurrentButton.TabIndex = 49
        Me.SaveCurrentButton.Text = "Save"
        Me.SaveCurrentButton.UseVisualStyleBackColor = False
        '
        'UpdateButton
        '
        Me.UpdateButton.BackColor = System.Drawing.Color.SpringGreen
        Me.UpdateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.UpdateButton.Font = New System.Drawing.Font("Microsoft New Tai Lue", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UpdateButton.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.UpdateButton.Location = New System.Drawing.Point(896, 222)
        Me.UpdateButton.Name = "UpdateButton"
        Me.UpdateButton.Size = New System.Drawing.Size(155, 52)
        Me.UpdateButton.TabIndex = 50
        Me.UpdateButton.Text = "Update"
        Me.UpdateButton.UseVisualStyleBackColor = False
        '
        'mainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(1073, 759)
        Me.Controls.Add(Me.UpdateButton)
        Me.Controls.Add(Me.SaveCurrentButton)
        Me.Controls.Add(Me.AddButton)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.SearchTypeButton)
        Me.Controls.Add(Me.CategoryTextBox)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.SerialNumberTextBox)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.ValueTextBox)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.QuanityTextBox)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.DescriptionTextBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ItemNameTextBox)
        Me.Controls.Add(Me.ClearButton)
        Me.Controls.Add(Me.SaveButton)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.ItemNoTextBox)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "mainForm"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Main Menu"
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        CType(Me.ItemsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ItemNoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SaveButton As System.Windows.Forms.Button
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents ClearButton As System.Windows.Forms.Button
    Friend WithEvents DeployButton As System.Windows.Forms.Button
    Friend WithEvents RemarksButton As System.Windows.Forms.Button
    Friend WithEvents ReportButton As System.Windows.Forms.Button
    Friend WithEvents SearchButton As System.Windows.Forms.Button
    Friend WithEvents LineShape2 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ItemNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents LineShape4 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape3 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents DescriptionTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents QuanityTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents LineShape5 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents ValueTextBox As System.Windows.Forms.TextBox
    Friend WithEvents LineShape6 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents SerialNumberTextBox As System.Windows.Forms.TextBox
    Friend WithEvents QuitButton As System.Windows.Forms.Button
    Friend WithEvents CategoryTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SearchTypeButton As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents ItemsDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents AddButton As System.Windows.Forms.Button
    Friend WithEvents SaveCurrentButton As System.Windows.Forms.Button
    Friend WithEvents UpdateButton As System.Windows.Forms.Button

End Class
