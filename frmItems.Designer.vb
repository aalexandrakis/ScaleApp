<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmItems
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
        Me.btnSearchItem = New System.Windows.Forms.Button
        Me.txtEidDes = New System.Windows.Forms.TextBox
        Me.txtEidCod = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.txtSelPrice = New System.Windows.Forms.NumericUpDown
        Me.txtCount = New System.Windows.Forms.NumericUpDown
        Me.txtPrice = New System.Windows.Forms.NumericUpDown
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtLastDate = New System.Windows.Forms.DateTimePicker
        Me.Label4 = New System.Windows.Forms.Label
        Me.DG = New System.Windows.Forms.DataGridView
        Me.CODE = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Descr = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.LastBuyDate = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.LastBuyCount = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.LastBuyPrice = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SelPrice = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Button2 = New System.Windows.Forms.Button
        CType(Me.txtSelPrice, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCount, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPrice, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DG, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnSearchItem
        '
        Me.btnSearchItem.Location = New System.Drawing.Point(471, 12)
        Me.btnSearchItem.Name = "btnSearchItem"
        Me.btnSearchItem.Size = New System.Drawing.Size(20, 21)
        Me.btnSearchItem.TabIndex = 3
        Me.btnSearchItem.UseVisualStyleBackColor = True
        '
        'txtEidDes
        '
        Me.txtEidDes.Location = New System.Drawing.Point(164, 12)
        Me.txtEidDes.Name = "txtEidDes"
        Me.txtEidDes.Size = New System.Drawing.Size(301, 20)
        Me.txtEidDes.TabIndex = 2
        '
        'txtEidCod
        '
        Me.txtEidCod.Location = New System.Drawing.Point(90, 12)
        Me.txtEidCod.Name = "txtEidCod"
        Me.txtEidCod.Size = New System.Drawing.Size(58, 20)
        Me.txtEidCod.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(5, 15)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(34, 13)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Είδος"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(505, 10)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(80, 22)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Καταχώρση"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtSelPrice
        '
        Me.txtSelPrice.DecimalPlaces = 2
        Me.txtSelPrice.Enabled = False
        Me.txtSelPrice.Location = New System.Drawing.Point(164, 113)
        Me.txtSelPrice.Maximum = New Decimal(New Integer() {99999999, 0, 0, 131072})
        Me.txtSelPrice.Name = "txtSelPrice"
        Me.txtSelPrice.ReadOnly = True
        Me.txtSelPrice.Size = New System.Drawing.Size(92, 20)
        Me.txtSelPrice.TabIndex = 8
        '
        'txtCount
        '
        Me.txtCount.DecimalPlaces = 2
        Me.txtCount.Enabled = False
        Me.txtCount.Location = New System.Drawing.Point(164, 63)
        Me.txtCount.Maximum = New Decimal(New Integer() {99999999, 0, 0, 131072})
        Me.txtCount.Name = "txtCount"
        Me.txtCount.ReadOnly = True
        Me.txtCount.Size = New System.Drawing.Size(92, 20)
        Me.txtCount.TabIndex = 6
        '
        'txtPrice
        '
        Me.txtPrice.DecimalPlaces = 2
        Me.txtPrice.Enabled = False
        Me.txtPrice.Location = New System.Drawing.Point(164, 89)
        Me.txtPrice.Maximum = New Decimal(New Integer() {99999999, 0, 0, 131072})
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.ReadOnly = True
        Me.txtPrice.Size = New System.Drawing.Size(92, 20)
        Me.txtPrice.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(5, 70)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(122, 13)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Ποσοτητα τελ. αγοράς"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(5, 120)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 13)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Τιμή πώλησης"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(5, 96)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(92, 13)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "Τιμή τελ. αγοράς"
        '
        'txtLastDate
        '
        Me.txtLastDate.Enabled = False
        Me.txtLastDate.Location = New System.Drawing.Point(164, 38)
        Me.txtLastDate.Name = "txtLastDate"
        Me.txtLastDate.Size = New System.Drawing.Size(200, 20)
        Me.txtLastDate.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(5, 45)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(130, 13)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "Ημερομηνία τελ. αγοράς"
        '
        'DG
        '
        Me.DG.AllowUserToAddRows = False
        Me.DG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DG.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CODE, Me.Descr, Me.LastBuyDate, Me.LastBuyCount, Me.LastBuyPrice, Me.SelPrice})
        Me.DG.Location = New System.Drawing.Point(6, 165)
        Me.DG.Name = "DG"
        Me.DG.ReadOnly = True
        Me.DG.Size = New System.Drawing.Size(848, 309)
        Me.DG.TabIndex = 23
        '
        'CODE
        '
        Me.CODE.HeaderText = "Κωδικός"
        Me.CODE.Name = "CODE"
        Me.CODE.ReadOnly = True
        '
        'Descr
        '
        Me.Descr.HeaderText = "Περιγραφή"
        Me.Descr.Name = "Descr"
        Me.Descr.ReadOnly = True
        '
        'LastBuyDate
        '
        Me.LastBuyDate.HeaderText = "Τελ. Ημ. Αγοράς"
        Me.LastBuyDate.Name = "LastBuyDate"
        Me.LastBuyDate.ReadOnly = True
        '
        'LastBuyCount
        '
        Me.LastBuyCount.HeaderText = "Τελ. Ποσ. Αγορας"
        Me.LastBuyCount.Name = "LastBuyCount"
        Me.LastBuyCount.ReadOnly = True
        '
        'LastBuyPrice
        '
        Me.LastBuyPrice.HeaderText = "Τελ. Τιμή Αγοράς"
        Me.LastBuyPrice.Name = "LastBuyPrice"
        Me.LastBuyPrice.ReadOnly = True
        '
        'SelPrice
        '
        Me.SelPrice.HeaderText = "Τιμή Πώλησης"
        Me.SelPrice.Name = "SelPrice"
        Me.SelPrice.ReadOnly = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(607, 10)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(80, 22)
        Me.Button2.TabIndex = 24
        Me.Button2.Text = "Excel"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'frmItems
        '
        Me.AcceptButton = Me.Button1
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(854, 492)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.DG)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtLastDate)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtPrice)
        Me.Controls.Add(Me.txtCount)
        Me.Controls.Add(Me.txtSelPrice)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnSearchItem)
        Me.Controls.Add(Me.txtEidDes)
        Me.Controls.Add(Me.txtEidCod)
        Me.Controls.Add(Me.Label5)
        Me.Name = "frmItems"
        Me.Text = "frmItems"
        CType(Me.txtSelPrice, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCount, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPrice, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DG, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnSearchItem As System.Windows.Forms.Button
    Friend WithEvents txtEidDes As System.Windows.Forms.TextBox
    Friend WithEvents txtEidCod As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents txtSelPrice As System.Windows.Forms.NumericUpDown
    Friend WithEvents txtCount As System.Windows.Forms.NumericUpDown
    Friend WithEvents txtPrice As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtLastDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents DG As System.Windows.Forms.DataGridView
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents CODE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Descr As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LastBuyDate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LastBuyCount As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LastBuyPrice As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SelPrice As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
