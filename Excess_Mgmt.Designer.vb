<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Excess_Mgmt
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
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnImport = New System.Windows.Forms.Button()
        Me.btnExport = New System.Windows.Forms.Button()
        Me.btnEmpty = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnAdd.Location = New System.Drawing.Point(24, 51)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(147, 38)
        Me.btnAdd.TabIndex = 0
        Me.btnAdd.Text = "Add Items"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'btnImport
        '
        Me.btnImport.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnImport.Location = New System.Drawing.Point(24, 111)
        Me.btnImport.Name = "btnImport"
        Me.btnImport.Size = New System.Drawing.Size(147, 38)
        Me.btnImport.TabIndex = 1
        Me.btnImport.Text = "Import List"
        Me.btnImport.UseVisualStyleBackColor = False
        '
        'btnExport
        '
        Me.btnExport.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnExport.Location = New System.Drawing.Point(24, 173)
        Me.btnExport.Name = "btnExport"
        Me.btnExport.Size = New System.Drawing.Size(147, 38)
        Me.btnExport.TabIndex = 2
        Me.btnExport.Text = "Export List"
        Me.btnExport.UseVisualStyleBackColor = False
        '
        'btnEmpty
        '
        Me.btnEmpty.BackColor = System.Drawing.Color.Maroon
        Me.btnEmpty.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnEmpty.ForeColor = System.Drawing.Color.White
        Me.btnEmpty.Location = New System.Drawing.Point(24, 1019)
        Me.btnEmpty.Name = "btnEmpty"
        Me.btnEmpty.Size = New System.Drawing.Size(147, 38)
        Me.btnEmpty.TabIndex = 3
        Me.btnEmpty.Text = "Empty List"
        Me.btnEmpty.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(217, 51)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 45
        Me.DataGridView1.RowTemplate.Height = 27
        Me.DataGridView1.Size = New System.Drawing.Size(1658, 1006)
        Me.DataGridView1.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(220, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(135, 20)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Current Inventory"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.ForeColor = System.Drawing.Color.Maroon
        Me.Label2.Location = New System.Drawing.Point(1526, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(300, 20)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Double Click 'Note' cell to Add/Edit Notes"
        '
        'Excess_Mgmt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Tan
        Me.ClientSize = New System.Drawing.Size(1904, 1095)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btnEmpty)
        Me.Controls.Add(Me.btnExport)
        Me.Controls.Add(Me.btnImport)
        Me.Controls.Add(Me.btnAdd)
        Me.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "Excess_Mgmt"
        Me.Text = "Excess_Mgmt"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnAdd As Button
    Friend WithEvents btnImport As Button
    Friend WithEvents btnExport As Button
    Friend WithEvents btnEmpty As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
