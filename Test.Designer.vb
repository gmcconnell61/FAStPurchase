﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Test
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dgvFASOpen = New System.Windows.Forms.DataGridView()
        Me.btnAllocated = New System.Windows.Forms.Button()
        Me.btnLate = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rdo4 = New System.Windows.Forms.RadioButton()
        Me.rdo3 = New System.Windows.Forms.RadioButton()
        Me.rdo2 = New System.Windows.Forms.RadioButton()
        Me.rdo1 = New System.Windows.Forms.RadioButton()
        Me.rdo0 = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.dgvFASOpen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvFASOpen
        '
        Me.dgvFASOpen.AllowUserToAddRows = False
        Me.dgvFASOpen.AllowUserToDeleteRows = False
        Me.dgvFASOpen.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvFASOpen.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvFASOpen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvFASOpen.Location = New System.Drawing.Point(930, 13)
        Me.dgvFASOpen.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dgvFASOpen.Name = "dgvFASOpen"
        Me.dgvFASOpen.RowHeadersVisible = False
        Me.dgvFASOpen.RowHeadersWidth = 45
        Me.dgvFASOpen.RowTemplate.Height = 27
        Me.dgvFASOpen.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvFASOpen.Size = New System.Drawing.Size(962, 1053)
        Me.dgvFASOpen.TabIndex = 4
        '
        'btnAllocated
        '
        Me.btnAllocated.Location = New System.Drawing.Point(12, 25)
        Me.btnAllocated.Name = "btnAllocated"
        Me.btnAllocated.Size = New System.Drawing.Size(194, 46)
        Me.btnAllocated.TabIndex = 5
        Me.btnAllocated.Text = "Update Allocated"
        Me.btnAllocated.UseVisualStyleBackColor = True
        '
        'btnLate
        '
        Me.btnLate.Location = New System.Drawing.Point(12, 103)
        Me.btnLate.Name = "btnLate"
        Me.btnLate.Size = New System.Drawing.Size(194, 46)
        Me.btnLate.TabIndex = 6
        Me.btnLate.Text = "Update Late Dates"
        Me.btnLate.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rdo0)
        Me.GroupBox1.Controls.Add(Me.rdo4)
        Me.GroupBox1.Controls.Add(Me.rdo3)
        Me.GroupBox1.Controls.Add(Me.rdo2)
        Me.GroupBox1.Controls.Add(Me.rdo1)
        Me.GroupBox1.Location = New System.Drawing.Point(306, 25)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(257, 216)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "FIlter Data"
        '
        'rdo4
        '
        Me.rdo4.AutoSize = True
        Me.rdo4.Location = New System.Drawing.Point(20, 162)
        Me.rdo4.Name = "rdo4"
        Me.rdo4.Size = New System.Drawing.Size(89, 24)
        Me.rdo4.TabIndex = 3
        Me.rdo4.TabStop = True
        Me.rdo4.Text = "Problems"
        Me.rdo4.UseVisualStyleBackColor = True
        '
        'rdo3
        '
        Me.rdo3.AutoSize = True
        Me.rdo3.Location = New System.Drawing.Point(20, 129)
        Me.rdo3.Name = "rdo3"
        Me.rdo3.Size = New System.Drawing.Size(104, 24)
        Me.rdo3.TabIndex = 2
        Me.rdo3.TabStop = True
        Me.rdo3.Text = "UnChanged"
        Me.rdo3.UseVisualStyleBackColor = True
        '
        'rdo2
        '
        Me.rdo2.AutoSize = True
        Me.rdo2.Location = New System.Drawing.Point(20, 97)
        Me.rdo2.Name = "rdo2"
        Me.rdo2.Size = New System.Drawing.Size(131, 24)
        Me.rdo2.TabIndex = 1
        Me.rdo2.TabStop = True
        Me.rdo2.Text = "New Late Dates"
        Me.rdo2.UseVisualStyleBackColor = True
        '
        'rdo1
        '
        Me.rdo1.AutoSize = True
        Me.rdo1.Location = New System.Drawing.Point(20, 67)
        Me.rdo1.Name = "rdo1"
        Me.rdo1.Size = New System.Drawing.Size(91, 24)
        Me.rdo1.TabIndex = 0
        Me.rdo1.TabStop = True
        Me.rdo1.Text = "Allocated"
        Me.rdo1.UseVisualStyleBackColor = True
        '
        'rdo0
        '
        Me.rdo0.AutoSize = True
        Me.rdo0.Checked = True
        Me.rdo0.Location = New System.Drawing.Point(20, 37)
        Me.rdo0.Name = "rdo0"
        Me.rdo0.Size = New System.Drawing.Size(85, 24)
        Me.rdo0.TabIndex = 4
        Me.rdo0.TabStop = True
        Me.rdo0.Text = "All Items"
        Me.rdo0.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(846, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 20)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Label1"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(697, 248)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(83, 35)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "Highlight"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Test
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1904, 1095)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnLate)
        Me.Controls.Add(Me.btnAllocated)
        Me.Controls.Add(Me.dgvFASOpen)
        Me.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "Test"
        Me.Text = "Test"
        CType(Me.dgvFASOpen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvFASOpen As DataGridView
    Friend WithEvents btnAllocated As Button
    Friend WithEvents btnLate As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rdo4 As RadioButton
    Friend WithEvents rdo3 As RadioButton
    Friend WithEvents rdo2 As RadioButton
    Friend WithEvents rdo1 As RadioButton
    Friend WithEvents rdo0 As RadioButton
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
End Class