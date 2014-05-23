<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSupInvoice
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
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtSeira = New System.Windows.Forms.TextBox
        Me.txtNumber = New System.Windows.Forms.NumericUpDown
        Me.txtDate = New System.Windows.Forms.DateTimePicker
        Me.txtSupCod = New System.Windows.Forms.TextBox
        Me.txtSupName = New System.Windows.Forms.TextBox
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
        Me.btnSearchSupplier = New System.Windows.Forms.Button
        Me.btnSearchItem = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.txtSumInv = New System.Windows.Forms.NumericUpDown
        Me.Label9 = New System.Windows.Forms.Label
        Me.btnDeleteAll = New System.Windows.Forms.Button
        Me.btnDeleteItem = New System.Windows.Forms.Button
        Me.btnPrint = New System.Windows.Forms.Button
        Me.aaud = New System.Windows.Forms.NumericUpDown
        Me.FpaPer = New System.Windows.Forms.NumericUpDown
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.txtsumFpa = New System.Windows.Forms.NumericUpDown
        Me.txtSum = New System.Windows.Forms.NumericUpDown
        Me.txtFpa = New System.Windows.Forms.NumericUpDown
        Me.Label12 = New System.Windows.Forms.Label
        Me.Button2 = New System.Windows.Forms.Button
        CType(Me.txtNumber, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtItemPrice, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCount, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSumPrice, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSumInv, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.aaud, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FpaPer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtsumFpa, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSum, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFpa, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(36, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Σειρά"
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
        Me.Label4.Size = New System.Drawing.Size(74, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Προμηθευτής"
        '
        'txtSeira
        '
        Me.txtSeira.Location = New System.Drawing.Point(54, 6)
        Me.txtSeira.MaxLength = 2
        Me.txtSeira.Name = "txtSeira"
        Me.txtSeira.Size = New System.Drawing.Size(22, 20)
        Me.txtSeira.TabIndex = 1
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
        'txtSupCod
        '
        Me.txtSupCod.Location = New System.Drawing.Point(97, 42)
        Me.txtSupCod.Name = "txtSupCod"
        Me.txtSupCod.Size = New System.Drawing.Size(58, 20)
        Me.txtSupCod.TabIndex = 4
        '
        'txtSupName
        '
        Me.txtSupName.Location = New System.Drawing.Point(171, 42)
        Me.txtSupName.Name = "txtSupName"
        Me.txtSupName.Size = New System.Drawing.Size(301, 20)
        Me.txtSupName.TabIndex = 5
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
        'btnSearchSupplier
        '
        Me.btnSearchSupplier.Location = New System.Drawing.Point(479, 41)
        Me.btnSearchSupplier.Name = "btnSearchSupplier"
        Me.btnSearchSupplier.Size = New System.Drawing.Size(20, 21)
        Me.btnSearchSupplier.TabIndex = 6
        Me.btnSearchSupplier.UseVisualStyleBackColor = True
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
        Me.txtSumInv.Location = New System.Drawing.Point(326, 361)
        Me.txtSumInv.Maximum = New Decimal(New Integer() {99999999, 0, 0, 131072})
        Me.txtSumInv.Name = "txtSumInv"
        Me.txtSumInv.Size = New System.Drawing.Size(87, 20)
        Me.txtSumInv.TabIndex = 23
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(277, 367)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(43, 13)
        Me.Label9.TabIndex = 24
        Me.Label9.Text = "Σύνολο"
        '
        'btnDeleteAll
        '
        Me.btnDeleteAll.Location = New System.Drawing.Point(381, 136)
        Me.btnDeleteAll.Name = "btnDeleteAll"
        Me.btnDeleteAll.Size = New System.Drawing.Size(96, 24)
        Me.btnDeleteAll.TabIndex = 26
        Me.btnDeleteAll.Text = "Διαγραφή Όλων"
        '
        'btnDeleteItem
        '
        Me.btnDeleteItem.Location = New System.Drawing.Point(271, 136)
        Me.btnDeleteItem.Name = "btnDeleteItem"
        Me.btnDeleteItem.Size = New System.Drawing.Size(104, 24)
        Me.btnDeleteItem.TabIndex = 25
        Me.btnDeleteItem.Text = "Διαγραφή Είδους"
        '
        'btnPrint
        '
        Me.btnPrint.Location = New System.Drawing.Point(483, 136)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(96, 24)
        Me.btnPrint.TabIndex = 27
        Me.btnPrint.Text = "Εκτύπωση"
        '
        'aaud
        '
        Me.aaud.Location = New System.Drawing.Point(588, 136)
        Me.aaud.Maximum = New Decimal(New Integer() {99999999, 0, 0, 0})
        Me.aaud.Name = "aaud"
        Me.aaud.Size = New System.Drawing.Size(120, 20)
        Me.aaud.TabIndex = 28
        '
        'FpaPer
        '
        Me.FpaPer.DecimalPlaces = 2
        Me.FpaPer.Enabled = False
        Me.FpaPer.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.FpaPer.Location = New System.Drawing.Point(545, 72)
        Me.FpaPer.Maximum = New Decimal(New Integer() {99999999, 0, 0, 131072})
        Me.FpaPer.Name = "FpaPer"
        Me.FpaPer.ReadOnly = True
        Me.FpaPer.Size = New System.Drawing.Size(70, 20)
        Me.FpaPer.TabIndex = 29
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(511, 75)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(31, 13)
        Me.Label10.TabIndex = 30
        Me.Label10.Text = "ΦΠΑ"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(423, 366)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(31, 13)
        Me.Label11.TabIndex = 32
        Me.Label11.Text = "ΦΠΑ"
        '
        'txtsumFpa
        '
        Me.txtsumFpa.DecimalPlaces = 2
        Me.txtsumFpa.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.txtsumFpa.Location = New System.Drawing.Point(472, 360)
        Me.txtsumFpa.Maximum = New Decimal(New Integer() {99999999, 0, 0, 131072})
        Me.txtsumFpa.Name = "txtsumFpa"
        Me.txtsumFpa.Size = New System.Drawing.Size(87, 20)
        Me.txtsumFpa.TabIndex = 31
        '
        'txtSum
        '
        Me.txtSum.DecimalPlaces = 2
        Me.txtSum.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.txtSum.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.txtSum.Location = New System.Drawing.Point(592, 359)
        Me.txtSum.Maximum = New Decimal(New Integer() {99999999, 0, 0, 131072})
        Me.txtSum.Name = "txtSum"
        Me.txtSum.Size = New System.Drawing.Size(121, 29)
        Me.txtSum.TabIndex = 33
        '
        'txtFpa
        '
        Me.txtFpa.DecimalPlaces = 2
        Me.txtFpa.Enabled = False
        Me.txtFpa.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.txtFpa.Location = New System.Drawing.Point(545, 106)
        Me.txtFpa.Maximum = New Decimal(New Integer() {99999999, 0, 0, 131072})
        Me.txtFpa.Name = "txtFpa"
        Me.txtFpa.ReadOnly = True
        Me.txtFpa.Size = New System.Drawing.Size(70, 20)
        Me.txtFpa.TabIndex = 34
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(511, 113)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(31, 13)
        Me.Label12.TabIndex = 35
        Me.Label12.Text = "ΦΠΑ"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(116, 136)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(149, 24)
        Me.Button2.TabIndex = 36
        Me.Button2.Text = "Ενημέρωση Υπολοίπων"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'frmSupInvoice
        '
        Me.AcceptButton = Me.btnInsert
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(720, 408)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.txtFpa)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txtSum)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txtsumFpa)
        Me.Controls.Add(Me.FpaPer)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.aaud)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.btnDeleteAll)
        Me.Controls.Add(Me.btnDeleteItem)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtSumInv)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnSearchItem)
        Me.Controls.Add(Me.btnSearchSupplier)
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
        Me.Controls.Add(Me.txtSupName)
        Me.Controls.Add(Me.txtSupCod)
        Me.Controls.Add(Me.txtDate)
        Me.Controls.Add(Me.txtNumber)
        Me.Controls.Add(Me.txtSeira)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmSupInvoice"
        Me.Text = "frmSupInvoice"
        CType(Me.txtNumber, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtItemPrice, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCount, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSumPrice, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSumInv, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.aaud, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FpaPer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtsumFpa, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSum, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFpa, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtSeira As System.Windows.Forms.TextBox
    Friend WithEvents txtNumber As System.Windows.Forms.NumericUpDown
    Friend WithEvents txtDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtSupCod As System.Windows.Forms.TextBox
    Friend WithEvents txtSupName As System.Windows.Forms.TextBox
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
    Friend WithEvents btnSearchSupplier As System.Windows.Forms.Button
    Friend WithEvents btnSearchItem As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents txtSumInv As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents btnDeleteAll As System.Windows.Forms.Button
    Friend WithEvents btnDeleteItem As System.Windows.Forms.Button
    Friend WithEvents btnPrint As System.Windows.Forms.Button
    Friend WithEvents aaud As System.Windows.Forms.NumericUpDown
    Friend WithEvents FpaPer As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtsumFpa As System.Windows.Forms.NumericUpDown
    Friend WithEvents txtSum As System.Windows.Forms.NumericUpDown
    Friend WithEvents txtFpa As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
End Class
