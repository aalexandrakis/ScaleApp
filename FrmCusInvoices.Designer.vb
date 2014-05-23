<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCusInvoices
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
        Me.DateFrom = New System.Windows.Forms.DateTimePicker
        Me.DateTo = New System.Windows.Forms.DateTimePicker
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.Button2 = New System.Windows.Forms.Button
        Me.txtSum = New System.Windows.Forms.NumericUpDown
        Me.btnSearchItem = New System.Windows.Forms.Button
        Me.txtEidDes = New System.Windows.Forms.TextBox
        Me.txtEidCod = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtCusCod = New System.Windows.Forms.TextBox
        Me.txtCusName = New System.Windows.Forms.TextBox
        Me.btnSearchCustomer = New System.Windows.Forms.Button
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSum, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DateFrom
        '
        Me.DateFrom.Location = New System.Drawing.Point(49, 23)
        Me.DateFrom.Name = "DateFrom"
        Me.DateFrom.Size = New System.Drawing.Size(200, 20)
        Me.DateFrom.TabIndex = 0
        '
        'DateTo
        '
        Me.DateTo.Location = New System.Drawing.Point(332, 23)
        Me.DateTo.Name = "DateTo"
        Me.DateTo.Size = New System.Drawing.Size(200, 20)
        Me.DateTo.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(20, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(26, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Από"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(297, 31)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(29, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Έως"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(552, 21)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(87, 23)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Αναζήτηση"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(3, 103)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(792, 271)
        Me.DataGridView1.TabIndex = 5
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(645, 22)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(112, 21)
        Me.Button2.TabIndex = 6
        Me.Button2.Text = "Νέα καταχώρηση"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'txtSum
        '
        Me.txtSum.DecimalPlaces = 2
        Me.txtSum.Location = New System.Drawing.Point(675, 379)
        Me.txtSum.Maximum = New Decimal(New Integer() {99999999, 0, 0, 131072})
        Me.txtSum.Name = "txtSum"
        Me.txtSum.Size = New System.Drawing.Size(120, 20)
        Me.txtSum.TabIndex = 7
        '
        'btnSearchItem
        '
        Me.btnSearchItem.Location = New System.Drawing.Point(430, 76)
        Me.btnSearchItem.Name = "btnSearchItem"
        Me.btnSearchItem.Size = New System.Drawing.Size(20, 21)
        Me.btnSearchItem.TabIndex = 4
        Me.btnSearchItem.UseVisualStyleBackColor = True
        '
        'txtEidDes
        '
        Me.txtEidDes.Location = New System.Drawing.Point(123, 76)
        Me.txtEidDes.Name = "txtEidDes"
        Me.txtEidDes.Size = New System.Drawing.Size(301, 20)
        Me.txtEidDes.TabIndex = 3
        '
        'txtEidCod
        '
        Me.txtEidCod.Location = New System.Drawing.Point(49, 76)
        Me.txtEidCod.Name = "txtEidCod"
        Me.txtEidCod.Size = New System.Drawing.Size(58, 20)
        Me.txtEidCod.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 76)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(34, 13)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Είδος"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(0, 49)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(50, 13)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Πελάτης"
        '
        'txtCusCod
        '
        Me.txtCusCod.Location = New System.Drawing.Point(49, 49)
        Me.txtCusCod.Name = "txtCusCod"
        Me.txtCusCod.Size = New System.Drawing.Size(58, 20)
        Me.txtCusCod.TabIndex = 18
        '
        'txtCusName
        '
        Me.txtCusName.Location = New System.Drawing.Point(123, 49)
        Me.txtCusName.Name = "txtCusName"
        Me.txtCusName.Size = New System.Drawing.Size(301, 20)
        Me.txtCusName.TabIndex = 19
        '
        'btnSearchCustomer
        '
        Me.btnSearchCustomer.Location = New System.Drawing.Point(431, 48)
        Me.btnSearchCustomer.Name = "btnSearchCustomer"
        Me.btnSearchCustomer.Size = New System.Drawing.Size(20, 21)
        Me.btnSearchCustomer.TabIndex = 20
        Me.btnSearchCustomer.UseVisualStyleBackColor = True
        '
        'FrmCusInvoices
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(807, 403)
        Me.Controls.Add(Me.btnSearchCustomer)
        Me.Controls.Add(Me.txtCusName)
        Me.Controls.Add(Me.txtCusCod)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnSearchItem)
        Me.Controls.Add(Me.txtEidDes)
        Me.Controls.Add(Me.txtEidCod)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtSum)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DateTo)
        Me.Controls.Add(Me.DateFrom)
        Me.Name = "FrmCusInvoices"
        Me.Text = "Παραγγελείες Πελατών"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSum, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DateFrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateTo As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents txtSum As System.Windows.Forms.NumericUpDown
    Friend WithEvents btnSearchItem As System.Windows.Forms.Button
    Friend WithEvents txtEidDes As System.Windows.Forms.TextBox
    Friend WithEvents txtEidCod As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtCusCod As System.Windows.Forms.TextBox
    Friend WithEvents txtCusName As System.Windows.Forms.TextBox
    Friend WithEvents btnSearchCustomer As System.Windows.Forms.Button
End Class
