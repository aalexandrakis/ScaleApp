<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnOk = New System.Windows.Forms.Button
        Me.NmDebAmm = New System.Windows.Forms.NumericUpDown
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.nmAA = New System.Windows.Forms.NumericUpDown
        Me.btnCancel = New System.Windows.Forms.Button
        Me.CbxDebNames = New System.Windows.Forms.ComboBox
        Me.dg1 = New System.Windows.Forms.DataGridView
        CType(Me.NmDebAmm, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nmAA, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dg1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnOk
        '
        Me.btnOk.Location = New System.Drawing.Point(12, 221)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(75, 23)
        Me.btnOk.TabIndex = 0
        Me.btnOk.Text = "OK"
        Me.btnOk.UseVisualStyleBackColor = True
        '
        'NmDebAmm
        '
        Me.NmDebAmm.DecimalPlaces = 2
        Me.NmDebAmm.Location = New System.Drawing.Point(94, 64)
        Me.NmDebAmm.Maximum = New Decimal(New Integer() {999999, 0, 0, 131072})
        Me.NmDebAmm.Name = "NmDebAmm"
        Me.NmDebAmm.Size = New System.Drawing.Size(97, 20)
        Me.NmDebAmm.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(28, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Ωφειλέτης"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(35, 66)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Υπόλοιπο"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 14)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Α/Α Απόδειξης"
        '
        'nmAA
        '
        Me.nmAA.Enabled = False
        Me.nmAA.Location = New System.Drawing.Point(94, 12)
        Me.nmAA.Maximum = New Decimal(New Integer() {999999999, 0, 0, 0})
        Me.nmAA.Name = "nmAA"
        Me.nmAA.ReadOnly = True
        Me.nmAA.Size = New System.Drawing.Size(77, 20)
        Me.nmAA.TabIndex = 5
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(236, 221)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 7
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'CbxDebNames
        '
        Me.CbxDebNames.FormattingEnabled = True
        Me.CbxDebNames.Location = New System.Drawing.Point(94, 37)
        Me.CbxDebNames.Name = "CbxDebNames"
        Me.CbxDebNames.Size = New System.Drawing.Size(179, 21)
        Me.CbxDebNames.TabIndex = 8
        '
        'dg1
        '
        Me.dg1.AllowUserToAddRows = False
        Me.dg1.AllowUserToDeleteRows = False
        Me.dg1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg1.Location = New System.Drawing.Point(12, 94)
        Me.dg1.Name = "dg1"
        Me.dg1.Size = New System.Drawing.Size(299, 121)
        Me.dg1.TabIndex = 9
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(323, 256)
        Me.Controls.Add(Me.dg1)
        Me.Controls.Add(Me.CbxDebNames)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.nmAA)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.NmDebAmm)
        Me.Controls.Add(Me.btnOk)
        Me.Name = "Form3"
        Me.Text = "Form3"
        CType(Me.NmDebAmm, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nmAA, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dg1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnOk As System.Windows.Forms.Button
    Friend WithEvents NmDebAmm As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents nmAA As System.Windows.Forms.NumericUpDown
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents CbxDebNames As System.Windows.Forms.ComboBox
    Friend WithEvents dg1 As System.Windows.Forms.DataGridView
End Class
