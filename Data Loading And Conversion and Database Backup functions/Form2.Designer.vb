<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.UploadCsvButton = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.BackupCsvButton = New System.Windows.Forms.Button()
        Me.DeleteCsvButton = New System.Windows.Forms.Button()
        Me.ClearGridButton = New System.Windows.Forms.Button()
        Me.RowTextBox = New System.Windows.Forms.TextBox()
        Me.ColumnTextBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GoToCellButton = New System.Windows.Forms.Button()
        Me.CurrentCellTextBox = New System.Windows.Forms.TextBox()
        Me.RemoveRowButton = New System.Windows.Forms.Button()
        Me.RemoveColumnButton = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UploadCsvButton
        '
        Me.UploadCsvButton.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.UploadCsvButton.FlatAppearance.BorderSize = 0
        Me.UploadCsvButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.UploadCsvButton.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UploadCsvButton.ForeColor = System.Drawing.Color.Black
        Me.UploadCsvButton.Location = New System.Drawing.Point(22, 23)
        Me.UploadCsvButton.Margin = New System.Windows.Forms.Padding(2)
        Me.UploadCsvButton.Name = "UploadCsvButton"
        Me.UploadCsvButton.Size = New System.Drawing.Size(161, 33)
        Me.UploadCsvButton.TabIndex = 0
        Me.UploadCsvButton.Text = "Upload CSV File"
        Me.UploadCsvButton.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.DataGridView1.Location = New System.Drawing.Point(22, 99)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(2)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(511, 245)
        Me.DataGridView1.TabIndex = 1
        '
        'BackupCsvButton
        '
        Me.BackupCsvButton.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.BackupCsvButton.FlatAppearance.BorderSize = 0
        Me.BackupCsvButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BackupCsvButton.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BackupCsvButton.ForeColor = System.Drawing.Color.Black
        Me.BackupCsvButton.Location = New System.Drawing.Point(372, 23)
        Me.BackupCsvButton.Margin = New System.Windows.Forms.Padding(2)
        Me.BackupCsvButton.Name = "BackupCsvButton"
        Me.BackupCsvButton.Size = New System.Drawing.Size(161, 33)
        Me.BackupCsvButton.TabIndex = 2
        Me.BackupCsvButton.Text = "Create a Back-up"
        Me.BackupCsvButton.UseVisualStyleBackColor = False
        '
        'DeleteCsvButton
        '
        Me.DeleteCsvButton.BackColor = System.Drawing.Color.LightCoral
        Me.DeleteCsvButton.FlatAppearance.BorderSize = 0
        Me.DeleteCsvButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.DeleteCsvButton.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DeleteCsvButton.ForeColor = System.Drawing.Color.Black
        Me.DeleteCsvButton.Location = New System.Drawing.Point(406, 437)
        Me.DeleteCsvButton.Margin = New System.Windows.Forms.Padding(2)
        Me.DeleteCsvButton.Name = "DeleteCsvButton"
        Me.DeleteCsvButton.Size = New System.Drawing.Size(125, 26)
        Me.DeleteCsvButton.TabIndex = 3
        Me.DeleteCsvButton.Text = "Delete"
        Me.DeleteCsvButton.UseVisualStyleBackColor = False
        '
        'ClearGridButton
        '
        Me.ClearGridButton.BackColor = System.Drawing.Color.DarkGray
        Me.ClearGridButton.FlatAppearance.BorderSize = 0
        Me.ClearGridButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ClearGridButton.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClearGridButton.ForeColor = System.Drawing.Color.Black
        Me.ClearGridButton.Location = New System.Drawing.Point(21, 437)
        Me.ClearGridButton.Margin = New System.Windows.Forms.Padding(2)
        Me.ClearGridButton.Name = "ClearGridButton"
        Me.ClearGridButton.Size = New System.Drawing.Size(125, 26)
        Me.ClearGridButton.TabIndex = 5
        Me.ClearGridButton.Text = "Clear all"
        Me.ClearGridButton.UseVisualStyleBackColor = False
        '
        'RowTextBox
        '
        Me.RowTextBox.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.RowTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RowTextBox.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RowTextBox.ForeColor = System.Drawing.Color.Black
        Me.RowTextBox.Location = New System.Drawing.Point(371, 375)
        Me.RowTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.RowTextBox.Name = "RowTextBox"
        Me.RowTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.RowTextBox.Size = New System.Drawing.Size(90, 19)
        Me.RowTextBox.TabIndex = 6
        Me.RowTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ColumnTextBox
        '
        Me.ColumnTextBox.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ColumnTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ColumnTextBox.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColumnTextBox.ForeColor = System.Drawing.Color.Black
        Me.ColumnTextBox.Location = New System.Drawing.Point(168, 375)
        Me.ColumnTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.ColumnTextBox.Name = "ColumnTextBox"
        Me.ColumnTextBox.Size = New System.Drawing.Size(90, 19)
        Me.ColumnTextBox.TabIndex = 8
        Me.ColumnTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Location = New System.Drawing.Point(60, 377)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 15)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Enter Column:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(290, 377)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 15)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Enter Row:"
        '
        'GoToCellButton
        '
        Me.GoToCellButton.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.GoToCellButton.FlatAppearance.BorderSize = 0
        Me.GoToCellButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GoToCellButton.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GoToCellButton.ForeColor = System.Drawing.Color.Black
        Me.GoToCellButton.Location = New System.Drawing.Point(20, 407)
        Me.GoToCellButton.Margin = New System.Windows.Forms.Padding(2)
        Me.GoToCellButton.Name = "GoToCellButton"
        Me.GoToCellButton.Size = New System.Drawing.Size(510, 26)
        Me.GoToCellButton.TabIndex = 11
        Me.GoToCellButton.Text = "Search"
        Me.GoToCellButton.UseVisualStyleBackColor = False
        '
        'CurrentCellTextBox
        '
        Me.CurrentCellTextBox.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.CurrentCellTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.CurrentCellTextBox.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CurrentCellTextBox.ForeColor = System.Drawing.Color.Black
        Me.CurrentCellTextBox.Location = New System.Drawing.Point(22, 345)
        Me.CurrentCellTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.CurrentCellTextBox.Name = "CurrentCellTextBox"
        Me.CurrentCellTextBox.ReadOnly = True
        Me.CurrentCellTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CurrentCellTextBox.Size = New System.Drawing.Size(511, 16)
        Me.CurrentCellTextBox.TabIndex = 12
        Me.CurrentCellTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'RemoveRowButton
        '
        Me.RemoveRowButton.BackColor = System.Drawing.Color.DarkKhaki
        Me.RemoveRowButton.FlatAppearance.BorderSize = 0
        Me.RemoveRowButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RemoveRowButton.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RemoveRowButton.ForeColor = System.Drawing.Color.Black
        Me.RemoveRowButton.Location = New System.Drawing.Point(149, 437)
        Me.RemoveRowButton.Margin = New System.Windows.Forms.Padding(2)
        Me.RemoveRowButton.Name = "RemoveRowButton"
        Me.RemoveRowButton.Size = New System.Drawing.Size(125, 26)
        Me.RemoveRowButton.TabIndex = 18
        Me.RemoveRowButton.Text = "Remove Row"
        Me.RemoveRowButton.UseVisualStyleBackColor = False
        '
        'RemoveColumnButton
        '
        Me.RemoveColumnButton.BackColor = System.Drawing.Color.Khaki
        Me.RemoveColumnButton.FlatAppearance.BorderSize = 0
        Me.RemoveColumnButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RemoveColumnButton.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RemoveColumnButton.ForeColor = System.Drawing.Color.Black
        Me.RemoveColumnButton.Location = New System.Drawing.Point(277, 437)
        Me.RemoveColumnButton.Margin = New System.Windows.Forms.Padding(2)
        Me.RemoveColumnButton.Name = "RemoveColumnButton"
        Me.RemoveColumnButton.Size = New System.Drawing.Size(125, 26)
        Me.RemoveColumnButton.TabIndex = 19
        Me.RemoveColumnButton.Text = "Remove Column"
        Me.RemoveColumnButton.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(192, 73)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(147, 22)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "Data Grid View"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Desktop
        Me.ClientSize = New System.Drawing.Size(563, 494)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.RemoveColumnButton)
        Me.Controls.Add(Me.RemoveRowButton)
        Me.Controls.Add(Me.CurrentCellTextBox)
        Me.Controls.Add(Me.GoToCellButton)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ColumnTextBox)
        Me.Controls.Add(Me.RowTextBox)
        Me.Controls.Add(Me.ClearGridButton)
        Me.Controls.Add(Me.DeleteCsvButton)
        Me.Controls.Add(Me.BackupCsvButton)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.UploadCsvButton)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Form2"
        Me.Text = "Activity 5: Project Data Loading and Conversion plus Database Backup Functions"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents UploadCsvButton As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents BackupCsvButton As Button
    Friend WithEvents DeleteCsvButton As Button
    Friend WithEvents ClearGridButton As Button
    Friend WithEvents RowTextBox As TextBox
    Friend WithEvents ColumnTextBox As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GoToCellButton As Button
    Friend WithEvents CurrentCellTextBox As TextBox
    Friend WithEvents RemoveRowButton As Button
    Friend WithEvents RemoveColumnButton As Button
    Friend WithEvents Label3 As Label
End Class
