<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCusInvoice
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
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtNumber = New System.Windows.Forms.NumericUpDown
        Me.txtDate = New System.Windows.Forms.DateTimePicker
        Me.txtCusCod = New System.Windows.Forms.TextBox
        Me.txtCusName = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtEidCod = New System.Windows.Forms.TextBox
        Me.txtEidDes = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.txtItemPrice = New System.Windows.Forms.NumericUpDown
        Me.txtCount = New System.Windows.Forms.NumericUpDown
        Me.txtSumPrice = New System.Windows.Forms.NumericUpDown
        Me.btnInsert = New System.Windows.Forms.Button
        Me.btnSearchCustomer = New System.Windows.Forms.Button
        Me.btnSearchItem = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.txtSumInv = New System.Windows.Forms.NumericUpDown
        Me.Label9 = New System.Windows.Forms.Label
        Me.btnDeleteAll = New System.Windows.Forms.Button
        Me.btnDeleteItem = New System.Windows.Forms.Button
        Me.btnPrint = New System.Windows.Forms.Button
        CType(Me.txtNumber, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtItemPrice, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCount, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSumPrice, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSumInv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(94, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Αριθμός"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(215, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Ημερομηνία"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 42)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(50, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Πελάτης"
        '
        'txtNumber
        '
        Me.txtNumber.Location = New System.Drawing.Point(139, 6)
        Me.txtNumber.Maximum = New Decimal(New Integer() {999999, 0, 0, 0})
        Me.txtNumber.Name = "txtNumber"
        Me.txtNumber.Size = New System.Drawing.Size(70, 20)
        Me.txtNumber.TabIndex = 2
        '
        'txtDate
        '
        Me.txtDate.Location = New System.Drawing.Point(285, 8)
        Me.txtDate.Name = "txtDate"
        Me.txtDate.Size = New System.Drawing.Size(214, 20)
        Me.txtDate.TabIndex = 3
        '
        'txtCusCod
        '
        Me.txtCusCod.Location = New System.Drawing.Point(97, 42)
        Me.txtCusCod.Name = "txtCusCod"
        Me.txtCusCod.Size = New System.Drawing.Size(58, 20)
        Me.txtCusCod.TabIndex = 4
        '
        'txtCusName
        '
        Me.txtCusName.Location = New System.Drawing.Point(171, 42)
        Me.txtCusName.Name = "txtCusName"
        Me.txtCusName.Size = New System.Drawing.Size(301, 20)
        Me.txtCusName.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 75)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(34, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Είδος"
        '
        'txtEidCod
        '
        Me.txtEidCod.Location = New System.Drawing.Point(97, 72)
        Me.txtEidCod.Name = "txtEidCod"
        Me.txtEidCod.Size = New System.Drawing.Size(58, 20)
        Me.txtEidCod.TabIndex = 7
        '
        'txtEidDes
        '
        Me.txtEidDes.Location = New System.Drawing.Point(171, 72)
        Me.txtEidDes.Name = "txtEidDes"
        Me.txtEidDes.Size = New System.Drawing.Size(301, 20)
        Me.txtEidDes.TabIndex = 8
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(181, 113)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(28, 13)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Τιμή"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(12, 114)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(58, 13)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Ποσότητα"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(355, 113)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(57, 13)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Πληρωτέο"
        '
        'txtItemPrice
        '
        Me.txtItemPrice.DecimalPlaces = 2
        Me.txtItemPrice.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.txtItemPrice.Location = New System.Drawing.Point(215, 106)
        Me.txtItemPrice.Maximum = New Decimal(New Integer() {99999999, 0, 0, 131072})
        Me.txtItemPrice.Name = "txtItemPrice"
        Me.txtItemPrice.Size = New System.Drawing.Size(70, 20)
        Me.txtItemPrice.TabIndex = 11
        '
        'txtCount
        '
        Me.txtCount.DecimalPlaces = 2
        Me.txtCount.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.txtCount.Location = New System.Drawing.Point(76, 107)
        Me.txtCount.Maximum = New Decimal(New Integer() {99999999, 0, 0, 131072})
        Me.txtCount.Name = "txtCount"
        Me.txtCount.Size = New System.Drawing.Size(70, 20)
        Me.txtCount.TabIndex = 10
        '
        'txtSumPrice
        '
        Me.txtSumPrice.DecimalPlaces = 2
        Me.txtSumPrice.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.txtSumPrice.Location = New System.Drawing.Point(418, 106)
        Me.txtSumPrice.Maximum = New Decimal(New Integer() {99999999, 0, 0, 131072})
        Me.txtSumPrice.Name = "txtSumPrice"
        Me.txtSumPrice.Size = New System.Drawing.Size(70, 20)
        Me.txtSumPrice.TabIndex = 13
        '
        'btnInsert
        '
        Me.btnInsert.Location = New System.Drawing.Point(15, 136)
        Me.btnInsert.Name = "btnInsert"
        Me.btnInsert.Size = New System.Drawing.Size(93, 24)
        Me.btnInsert.TabIndex = 14
        Me.btnInsert.Text = "Καταχώρηση"
        Me.btnInsert.UseVisualStyleBackColor = True
        '
        'btnSearchCustomer
        '
        Me.btnSearchCustomer.Location = New System.Drawing.Point(479, 41)
        Me.btnSearchCustomer.Name = "btnSearchCustomer"
        Me.btnSearchCustomer.Size = New System.Drawing.Size(20, 21)
        Me.btnSearchCustomer.TabIndex = 6
        Me.btnSearchCustomer.UseVisualStyleBackColor = True
        '
        'btnSearchItem
        '
        Me.btnSearchItem.Location = New System.Drawing.Point(478, 72)
        Me.btnSearchItem.Name = "btnSearchItem"
        Me.btnSearchItem.Size = New System.Drawing.Size(20, 21)
        Me.btnSearchItem.TabIndex = 9
        Me.btnSearchItem.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(317, 106)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(20, 21)
        Me.Button1.TabIndex = 12
        Me.Button1.Text = "="
        Me.Button1.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(6, 166)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(707, 189)
        Me.DataGridView1.TabIndex = 22
        '
        'txtSumInv
        '
        Me.txtSumInv.DecimalPlaces = 2
        Me.txtSumInv.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.txtSumInv.Location = New System.Drawing.Point(621, 361)
        Me.txtSumInv.Maximum = New Decimal(New Integer() {99999999, 0, 0, 131072})
        Me.txtSumInv.Name = "txtSumInv"
        Me.txtSumInv.Size = New System.Drawing.Size(87, 20)
        Me.txtSumInv.TabIndex = 23
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(572, 367)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(43, 13)
        Me.Label9.TabIndex = 24
        Me.Label9.Text = "Σύνολο"
        '
        'btnDeleteAll
        '
        Me.btnDeleteAll.Location = New System.Drawing.Point(224, 136)
        Me.btnDeleteAll.Name = "btnDeleteAll"
        Me.btnDeleteAll.Size = New System.Drawing.Size(96, 24)
        Me.btnDeleteAll.TabIndex = 26
        Me.btnDeleteAll.Text = "Διαγραφή Όλων"
        '
        'btnDeleteItem
        '
        Me.btnDeleteItem.Location = New System.Drawing.Point(114, 136)
        Me.btnDeleteItem.Name = "btnDeleteItem"
        Me.btnDeleteItem.Size = New System.Drawing.Size(104, 24)
        Me.btnDeleteItem.TabIndex = 25
        Me.btnDeleteItem.Text = "Διαγραφή Είδους"
        '
        'btnPrint
        '
        Me.btnPrint.Location = New System.Drawing.Point(326, 136)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(96, 24)
        Me.btnPrint.TabIndex = 27
        Me.btnPrint.Text = "Εκτύπωση"
        '
        'frmCusInvoice
        '
        Me.AcceptButton = Me.btnInsert
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(720, 389)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.btnDeleteAll)
        Me.Controls.Add(Me.btnDeleteItem)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtSumInv)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnSearchItem)
        Me.Controls.Add(Me.btnSearchCustomer)
        Me.Controls.Add(Me.btnInsert)
        Me.Controls.Add(Me.txtSumPrice)
        Me.Controls.Add(Me.txtCount)
        Me.Controls.Add(Me.txtItemPrice)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtEidDes)
        Me.Controls.Add(Me.txtEidCod)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtCusName)
        Me.Controls.Add(Me.txtCusCod)
        Me.Controls.Add(Me.txtDate)
        Me.Controls.Add(Me.txtNumber)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Name = "frmCusInvoice"
        Me.Text = "frmCusInvoice"
        CType(Me.txtNumber, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtItemPrice, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCount, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSumPrice, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSumInv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtNumber As System.Windows.Forms.NumericUpDown
    Friend WithEvents txtDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtCusCod As System.Windows.Forms.TextBox
    Friend WithEvents txtCusName As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtEidCod As System.Windows.Forms.TextBox
    Friend WithEvents txtEidDes As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtItemPrice As System.Windows.Forms.NumericUpDown
    Friend WithEvents txtCount As System.Windows.Forms.NumericUpDown
    Friend WithEvents txtSumPrice As System.Windows.Forms.NumericUpDown
    Friend WithEvents btnInsert As System.Windows.Forms.Button
    Friend WithEvents btnSearchCustomer As System.Windows.Forms.Button
    Friend WithEvents btnSearchItem As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents txtSumInv As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents btnDeleteAll As System.Windows.Forms.Button
    Friend WithEvents btnDeleteItem As System.Windows.Forms.Button
    Friend WithEvents btnPrint As System.Windows.Forms.Button
End Class
