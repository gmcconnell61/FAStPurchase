<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class POLateUpdateNotes
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.chkCopyElec = New System.Windows.Forms.CheckBox()
        Me.chkCopyMech = New System.Windows.Forms.CheckBox()
        Me.btnSaveNote = New System.Windows.Forms.Button()
        Me.btnNotNow = New System.Windows.Forms.Button()
        Me.txtNewNote = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.chkCopyMech)
        Me.GroupBox1.Controls.Add(Me.chkCopyElec)
        Me.GroupBox1.Location = New System.Drawing.Point(18, 70)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(221, 100)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(218, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(159, 25)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Update PO Notes"
        '
        'chkCopyElec
        '
        Me.chkCopyElec.AutoSize = True
        Me.chkCopyElec.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.chkCopyElec.Location = New System.Drawing.Point(21, 26)
        Me.chkCopyElec.Name = "chkCopyElec"
        Me.chkCopyElec.Size = New System.Drawing.Size(147, 24)
        Me.chkCopyElec.TabIndex = 0
        Me.chkCopyElec.Text = "cc   R. Thompson"
        Me.chkCopyElec.UseVisualStyleBackColor = True
        '
        'chkCopyMech
        '
        Me.chkCopyMech.AutoSize = True
        Me.chkCopyMech.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.chkCopyMech.Location = New System.Drawing.Point(21, 56)
        Me.chkCopyMech.Name = "chkCopyMech"
        Me.chkCopyMech.Size = New System.Drawing.Size(114, 24)
        Me.chkCopyMech.TabIndex = 1
        Me.chkCopyMech.Text = "cc   R. Kelley"
        Me.chkCopyMech.UseVisualStyleBackColor = True
        '
        'btnSaveNote
        '
        Me.btnSaveNote.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnSaveNote.Location = New System.Drawing.Point(372, 82)
        Me.btnSaveNote.Name = "btnSaveNote"
        Me.btnSaveNote.Size = New System.Drawing.Size(186, 38)
        Me.btnSaveNote.TabIndex = 2
        Me.btnSaveNote.Text = "Save Note && Notify"
        Me.btnSaveNote.UseVisualStyleBackColor = True
        '
        'btnNotNow
        '
        Me.btnNotNow.BackColor = System.Drawing.Color.Red
        Me.btnNotNow.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnNotNow.ForeColor = System.Drawing.Color.White
        Me.btnNotNow.Location = New System.Drawing.Point(372, 132)
        Me.btnNotNow.Name = "btnNotNow"
        Me.btnNotNow.Size = New System.Drawing.Size(186, 38)
        Me.btnNotNow.TabIndex = 3
        Me.btnNotNow.Text = "Not Now"
        Me.btnNotNow.UseVisualStyleBackColor = False
        '
        'txtNewNote
        '
        Me.txtNewNote.Location = New System.Drawing.Point(18, 196)
        Me.txtNewNote.Multiline = True
        Me.txtNewNote.Name = "txtNewNote"
        Me.txtNewNote.Size = New System.Drawing.Size(574, 321)
        Me.txtNewNote.TabIndex = 4
        '
        'POLateUpdateNotes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Beige
        Me.ClientSize = New System.Drawing.Size(611, 529)
        Me.Controls.Add(Me.txtNewNote)
        Me.Controls.Add(Me.btnNotNow)
        Me.Controls.Add(Me.btnSaveNote)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "POLateUpdateNotes"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "POLateUpdateNotes"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents chkCopyMech As CheckBox
    Friend WithEvents chkCopyElec As CheckBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnSaveNote As Button
    Friend WithEvents btnNotNow As Button
    Friend WithEvents txtNewNote As TextBox
End Class
