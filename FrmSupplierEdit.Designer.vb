<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSupplierEdit
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
        Me.txtSupPhone = New System.Windows.Forms.TextBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.txtSupAfm = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.txtSupAddress = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtSupName = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtSupCod = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Button3 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'txtSupPhone
        '
        Me.txtSupPhone.Location = New System.Drawing.Point(114, 109)
        Me.txtSupPhone.MaxLength = 50
        Me.txtSupPhone.Name = "txtSupPhone"
        Me.txtSupPhone.Size = New System.Drawing.Size(272, 20)
        Me.txtSupPhone.TabIndex = 40
        '
        'Label13
        '
        Me.Label13.Location = New System.Drawing.Point(8, 109)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(90, 20)
        Me.Label13.TabIndex = 42
        Me.Label13.Text = "Τηλέφωνο"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtSupAfm
        '
        Me.txtSupAfm.Location = New System.Drawing.Point(113, 59)
        Me.txtSupAfm.MaxLength = 9
        Me.txtSupAfm.Name = "txtSupAfm"
        Me.txtSupAfm.Size = New System.Drawing.Size(96, 20)
        Me.txtSupAfm.TabIndex = 37
        '
        'Label12
        '
        Me.Label12.Location = New System.Drawing.Point(7, 59)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(90, 20)
        Me.Label12.TabIndex = 41
        Me.Label12.Text = "ΑΦΜ"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtSupAddress
        '
        Me.txtSupAddress.Location = New System.Drawing.Point(113, 83)
        Me.txtSupAddress.MaxLength = 50
        Me.txtSupAddress.Name = "txtSupAddress"
        Me.txtSupAddress.Size = New System.Drawing.Size(272, 20)
        Me.txtSupAddress.TabIndex = 39
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(7, 83)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 20)
        Me.Label3.TabIndex = 38
        Me.Label3.Text = "Διεύθυνση"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtSupName
        '
        Me.txtSupName.Location = New System.Drawing.Point(113, 35)
        Me.txtSupName.MaxLength = 100
        Me.txtSupName.Name = "txtSupName"
        Me.txtSupName.Size = New System.Drawing.Size(272, 20)
        Me.txtSupName.TabIndex = 36
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(7, 36)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 20)
        Me.Label2.TabIndex = 35
        Me.Label2.Text = "Επωνμία"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtSupCod
        '
        Me.txtSupCod.Location = New System.Drawing.Point(113, 8)
        Me.txtSupCod.Name = "txtSupCod"
        Me.txtSupCod.ReadOnly = True
        Me.txtSupCod.Size = New System.Drawing.Size(64, 20)
        Me.txtSupCod.TabIndex = 34
        Me.txtSupCod.TabStop = False
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(7, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 20)
        Me.Label1.TabIndex = 33
        Me.Label1.Text = "Κωδικός"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(314, 171)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(88, 24)
        Me.Button3.TabIndex = 45
        Me.Button3.Text = "Άκυρο"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(162, 171)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(88, 24)
        Me.Button2.TabIndex = 44
        Me.Button2.Text = "Διαγραφή"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(9, 171)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(88, 24)
        Me.Button1.TabIndex = 43
        Me.Button1.Text = "Ενημέρωση "
        '
        'FrmSupplierEdit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(405, 198)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtSupPhone)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.txtSupAfm)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txtSupAddress)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtSupName)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtSupCod)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FrmSupplierEdit"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmSupplierEdit"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtSupPhone As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtSupAfm As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtSupAddress As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtSupName As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtSupCod As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
