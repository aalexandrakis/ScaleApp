<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmLostItemEdit
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
        Me.btnSearchItem = New System.Windows.Forms.Button
        Me.txtEidDes = New System.Windows.Forms.TextBox
        Me.txtEidCod = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtItemPrice = New System.Windows.Forms.NumericUpDown
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtCount = New System.Windows.Forms.NumericUpDown
        Me.Label7 = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.txtSumPrice = New System.Windows.Forms.NumericUpDown
        Me.Label8 = New System.Windows.Forms.Label
        Me.btnCancel = New System.Windows.Forms.Button
        Me.btnDelete = New System.Windows.Forms.Button
        Me.btnInsert = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtLostDate = New System.Windows.Forms.DateTimePicker
        CType(Me.txtItemPrice, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCount, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSumPrice, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnSearchItem
        '
        Me.btnSearchItem.Location = New System.Drawing.Point(448, 34)
        Me.btnSearchItem.Name = "btnSearchItem"
        Me.btnSearchItem.Size = New System.Drawing.Size(20, 21)
        Me.btnSearchItem.TabIndex = 4
        Me.btnSearchItem.UseVisualStyleBackColor = True
        '
        'txtEidDes
        '
        Me.txtEidDes.Location = New System.Drawing.Point(141, 34)
        Me.txtEidDes.Name = "txtEidDes"
        Me.txtEidDes.Size = New System.Drawing.Size(301, 20)
        Me.txtEidDes.TabIndex = 3
        '
        'txtEidCod
        '
        Me.txtEidCod.Location = New System.Drawing.Point(77, 34)
        Me.txtEidCod.Name = "txtEidCod"
        Me.txtEidCod.Size = New System.Drawing.Size(58, 20)
        Me.txtEidCod.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(30, 41)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(34, 13)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Είδος"
        '
        'txtItemPrice
        '
        Me.txtItemPrice.DecimalPlaces = 2
        Me.txtItemPrice.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.txtItemPrice.Location = New System.Drawing.Point(77, 60)
        Me.txtItemPrice.Maximum = New Decimal(New Integer() {99999999, 0, 0, 131072})
        Me.txtItemPrice.Name = "txtItemPrice"
        Me.txtItemPrice.Size = New System.Drawing.Size(70, 20)
        Me.txtItemPrice.TabIndex = 5
        Me.txtItemPrice.ThousandsSeparator = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(36, 67)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(28, 13)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Τιμή"
        '
        'txtCount
        '
        Me.txtCount.DecimalPlaces = 2
        Me.txtCount.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.txtCount.Location = New System.Drawing.Point(76, 87)
        Me.txtCount.Maximum = New Decimal(New Integer() {99999999, 0, 0, 131072})
        Me.txtCount.Name = "txtCount"
        Me.txtCount.Size = New System.Drawing.Size(70, 20)
        Me.txtCount.TabIndex = 6
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(12, 94)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(58, 13)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "Ποσότητα"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(169, 87)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(20, 21)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "="
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtSumPrice
        '
        Me.txtSumPrice.DecimalPlaces = 2
        Me.txtSumPrice.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.txtSumPrice.Location = New System.Drawing.Point(246, 88)
        Me.txtSumPrice.Maximum = New Decimal(New Integer() {99999999, 0, 0, 131072})
        Me.txtSumPrice.Name = "txtSumPrice"
        Me.txtSumPrice.Size = New System.Drawing.Size(70, 20)
        Me.txtSumPrice.TabIndex = 8
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(207, 94)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(33, 13)
        Me.Label8.TabIndex = 20
        Me.Label8.Text = "Ποσό"
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(220, 141)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(96, 24)
        Me.btnCancel.TabIndex = 11
        Me.btnCancel.Text = "Έξοδος"
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(110, 141)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(104, 24)
        Me.btnDelete.TabIndex = 10
        Me.btnDelete.Text = "Διαγραφή Είδους"
        '
        'btnInsert
        '
        Me.btnInsert.Location = New System.Drawing.Point(11, 141)
        Me.btnInsert.Name = "btnInsert"
        Me.btnInsert.Size = New System.Drawing.Size(93, 24)
        Me.btnInsert.TabIndex = 9
        Me.btnInsert.Text = "Καταχώρηση"
        Me.btnInsert.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(4, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 13)
        Me.Label1.TabIndex = 32
        Me.Label1.Text = "Ημερομηνία"
        '
        'txtLostDate
        '
        Me.txtLostDate.Location = New System.Drawing.Point(77, 8)
        Me.txtLostDate.Name = "txtLostDate"
        Me.txtLostDate.Size = New System.Drawing.Size(200, 20)
        Me.txtLostDate.TabIndex = 1
        '
        'FrmLostItemEdit
        '
        Me.AcceptButton = Me.btnInsert
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(480, 175)
        Me.Controls.Add(Me.txtLostDate)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnInsert)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtSumPrice)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtCount)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtItemPrice)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btnSearchItem)
        Me.Controls.Add(Me.txtEidDes)
        Me.Controls.Add(Me.txtEidCod)
        Me.Controls.Add(Me.Label5)
        Me.Name = "FrmLostItemEdit"
        Me.Text = "FrmLostItemEdit"
        CType(Me.txtItemPrice, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCount, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSumPrice, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnSearchItem As System.Windows.Forms.Button
    Friend WithEvents txtEidDes As System.Windows.Forms.TextBox
    Friend WithEvents txtEidCod As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtItemPrice As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtCount As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents txtSumPrice As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnInsert As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtLostDate As System.Windows.Forms.DateTimePicker
End Class
