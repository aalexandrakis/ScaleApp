Public Class frmOrderEdit
    Inherits System.Windows.Forms.Form
    Public NewOrder As Boolean

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents CustomerControl1 As CustomerInvoice.CustomerControl
    Friend WithEvents EidosControl1 As CustomerInvoice.EidosControl
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtCount As System.Windows.Forms.NumericUpDown
    Friend WithEvents txtPrice As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnCalc As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtOrderNumber As System.Windows.Forms.TextBox
    Friend WithEvents DataGrid1 As System.Windows.Forms.DataGrid
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents btnDeleteItem As System.Windows.Forms.Button
    Friend WithEvents btnDeleteAll As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents txtFpaPos As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtEkpPer As System.Windows.Forms.NumericUpDown
    Friend WithEvents txtEkpPos As System.Windows.Forms.NumericUpDown
    Friend WithEvents txtPriceB As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cbxParast As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtSeiraId As System.Windows.Forms.TextBox
    Friend WithEvents txtInvoiceNumber As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents btnSend As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtOrderText As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtOrderSummary As System.Windows.Forms.NumericUpDown
    Friend WithEvents btnInvoice As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtCount = New System.Windows.Forms.NumericUpDown
        Me.txtPrice = New System.Windows.Forms.NumericUpDown
        Me.Label3 = New System.Windows.Forms.Label
        Me.btnCalc = New System.Windows.Forms.Button
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtOrderNumber = New System.Windows.Forms.TextBox
        Me.DataGrid1 = New System.Windows.Forms.DataGrid
        Me.btnUpdate = New System.Windows.Forms.Button
        Me.btnDeleteItem = New System.Windows.Forms.Button
        Me.btnDeleteAll = New System.Windows.Forms.Button
        Me.btnCancel = New System.Windows.Forms.Button
        Me.txtFpaPos = New System.Windows.Forms.NumericUpDown
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtEkpPer = New System.Windows.Forms.NumericUpDown
        Me.txtEkpPos = New System.Windows.Forms.NumericUpDown
        Me.txtPriceB = New System.Windows.Forms.NumericUpDown
        Me.Label8 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.btnInvoice = New System.Windows.Forms.Button
        Me.txtInvoiceNumber = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.txtSeiraId = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.cbxParast = New System.Windows.Forms.ComboBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.btnSend = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtOrderText = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.txtOrderSummary = New System.Windows.Forms.NumericUpDown
        Me.EidosControl1 = New CustomerInvoice.EidosControl
        Me.CustomerControl1 = New CustomerInvoice.CustomerControl
        CType(Me.txtCount, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPrice, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFpaPos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtEkpPer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtEkpPos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPriceB, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.txtOrderSummary, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(56, 120)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 16)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Ποσότητα"
        '
        'txtCount
        '
        Me.txtCount.DecimalPlaces = 2
        Me.txtCount.Increment = New Decimal(New Integer() {5, 0, 0, 65536})
        Me.txtCount.Location = New System.Drawing.Point(120, 120)
        Me.txtCount.Maximum = New Decimal(New Integer() {9999999, 0, 0, 131072})
        Me.txtCount.Minimum = New Decimal(New Integer() {9999999, 0, 0, -2147352576})
        Me.txtCount.Name = "txtCount"
        Me.txtCount.Size = New System.Drawing.Size(80, 20)
        Me.txtCount.TabIndex = 3
        Me.txtCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtPrice
        '
        Me.txtPrice.DecimalPlaces = 2
        Me.txtPrice.Increment = New Decimal(New Integer() {0, 0, 0, 65536})
        Me.txtPrice.Location = New System.Drawing.Point(272, 194)
        Me.txtPrice.Maximum = New Decimal(New Integer() {9999999, 0, 0, 131072})
        Me.txtPrice.Minimum = New Decimal(New Integer() {9999999, 0, 0, -2147352576})
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.ReadOnly = True
        Me.txtPrice.Size = New System.Drawing.Size(80, 20)
        Me.txtPrice.TabIndex = 7
        Me.txtPrice.TabStop = False
        Me.txtPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(202, 194)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 16)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Τελική Τιμή"
        '
        'btnCalc
        '
        Me.btnCalc.Location = New System.Drawing.Point(160, 192)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(24, 24)
        Me.btnCalc.TabIndex = 6
        Me.btnCalc.Text = "="
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(28, 8)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(30, 20)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Α/Α"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtOrderNumber
        '
        Me.txtOrderNumber.Location = New System.Drawing.Point(64, 8)
        Me.txtOrderNumber.Name = "txtOrderNumber"
        Me.txtOrderNumber.ReadOnly = True
        Me.txtOrderNumber.Size = New System.Drawing.Size(56, 20)
        Me.txtOrderNumber.TabIndex = 0
        Me.txtOrderNumber.TabStop = False
        '
        'DataGrid1
        '
        Me.DataGrid1.AccessibleRole = System.Windows.Forms.AccessibleRole.RowHeader
        Me.DataGrid1.DataMember = ""
        Me.DataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGrid1.Location = New System.Drawing.Point(0, 256)
        Me.DataGrid1.Name = "DataGrid1"
        Me.DataGrid1.ReadOnly = True
        Me.DataGrid1.Size = New System.Drawing.Size(1091, 332)
        Me.DataGrid1.TabIndex = 12
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(16, 224)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(88, 24)
        Me.btnUpdate.TabIndex = 7
        Me.btnUpdate.Text = "Ενημέρωση"
        '
        'btnDeleteItem
        '
        Me.btnDeleteItem.Location = New System.Drawing.Point(120, 224)
        Me.btnDeleteItem.Name = "btnDeleteItem"
        Me.btnDeleteItem.Size = New System.Drawing.Size(104, 24)
        Me.btnDeleteItem.TabIndex = 8
        Me.btnDeleteItem.Text = "Διαγραφή Είδους"
        '
        'btnDeleteAll
        '
        Me.btnDeleteAll.Location = New System.Drawing.Point(240, 224)
        Me.btnDeleteAll.Name = "btnDeleteAll"
        Me.btnDeleteAll.Size = New System.Drawing.Size(96, 24)
        Me.btnDeleteAll.TabIndex = 9
        Me.btnDeleteAll.Text = "Διαγραφή Όλων"
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(995, 223)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(88, 24)
        Me.btnCancel.TabIndex = 11
        Me.btnCancel.Text = "Έξοδος"
        '
        'txtFpaPos
        '
        Me.txtFpaPos.DecimalPlaces = 2
        Me.txtFpaPos.Increment = New Decimal(New Integer() {0, 0, 0, 65536})
        Me.txtFpaPos.Location = New System.Drawing.Point(272, 168)
        Me.txtFpaPos.Maximum = New Decimal(New Integer() {9999999, 0, 0, 131072})
        Me.txtFpaPos.Minimum = New Decimal(New Integer() {9999999, 0, 0, -2147352576})
        Me.txtFpaPos.Name = "txtFpaPos"
        Me.txtFpaPos.ReadOnly = True
        Me.txtFpaPos.Size = New System.Drawing.Size(80, 20)
        Me.txtFpaPos.TabIndex = 15
        Me.txtFpaPos.TabStop = False
        Me.txtFpaPos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(64, 144)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(56, 16)
        Me.Label6.TabIndex = 22
        Me.Label6.Text = "Έκπτωση"
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(184, 144)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(16, 16)
        Me.Label7.TabIndex = 21
        Me.Label7.Text = "%"
        '
        'txtEkpPer
        '
        Me.txtEkpPer.DecimalPlaces = 2
        Me.txtEkpPer.Increment = New Decimal(New Integer() {5, 0, 0, 65536})
        Me.txtEkpPer.Location = New System.Drawing.Point(120, 144)
        Me.txtEkpPer.Name = "txtEkpPer"
        Me.txtEkpPer.Size = New System.Drawing.Size(64, 20)
        Me.txtEkpPer.TabIndex = 4
        Me.txtEkpPer.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtEkpPos
        '
        Me.txtEkpPos.DecimalPlaces = 2
        Me.txtEkpPos.Increment = New Decimal(New Integer() {0, 0, 0, 65536})
        Me.txtEkpPos.Location = New System.Drawing.Point(272, 142)
        Me.txtEkpPos.Maximum = New Decimal(New Integer() {9999999, 0, 0, 131072})
        Me.txtEkpPos.Minimum = New Decimal(New Integer() {9999999, 0, 0, -2147352576})
        Me.txtEkpPos.Name = "txtEkpPos"
        Me.txtEkpPos.ReadOnly = True
        Me.txtEkpPos.Size = New System.Drawing.Size(80, 20)
        Me.txtEkpPos.TabIndex = 19
        Me.txtEkpPos.TabStop = False
        Me.txtEkpPos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtPriceB
        '
        Me.txtPriceB.DecimalPlaces = 2
        Me.txtPriceB.Increment = New Decimal(New Integer() {0, 0, 0, 65536})
        Me.txtPriceB.Location = New System.Drawing.Point(272, 120)
        Me.txtPriceB.Maximum = New Decimal(New Integer() {9999999, 0, 0, 131072})
        Me.txtPriceB.Minimum = New Decimal(New Integer() {9999999, 0, 0, -2147352576})
        Me.txtPriceB.Name = "txtPriceB"
        Me.txtPriceB.ReadOnly = True
        Me.txtPriceB.Size = New System.Drawing.Size(80, 20)
        Me.txtPriceB.TabIndex = 24
        Me.txtPriceB.TabStop = False
        Me.txtPriceB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(208, 120)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(64, 16)
        Me.Label8.TabIndex = 23
        Me.Label8.Text = "Μικτή Τιμή"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnInvoice)
        Me.GroupBox1.Controls.Add(Me.txtInvoiceNumber)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.txtSeiraId)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.cbxParast)
        Me.GroupBox1.Enabled = False
        Me.GroupBox1.Location = New System.Drawing.Point(683, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(408, 88)
        Me.GroupBox1.TabIndex = 26
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Στοιχεία για την τιμολόγηση"
        '
        'btnInvoice
        '
        Me.btnInvoice.Location = New System.Drawing.Point(322, 53)
        Me.btnInvoice.Name = "btnInvoice"
        Me.btnInvoice.Size = New System.Drawing.Size(80, 24)
        Me.btnInvoice.TabIndex = 32
        Me.btnInvoice.Text = "Τιμολόγηση"
        '
        'txtInvoiceNumber
        '
        Me.txtInvoiceNumber.Location = New System.Drawing.Point(240, 56)
        Me.txtInvoiceNumber.Name = "txtInvoiceNumber"
        Me.txtInvoiceNumber.ReadOnly = True
        Me.txtInvoiceNumber.Size = New System.Drawing.Size(72, 20)
        Me.txtInvoiceNumber.TabIndex = 31
        '
        'Label11
        '
        Me.Label11.Location = New System.Drawing.Point(104, 56)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(128, 16)
        Me.Label11.TabIndex = 30
        Me.Label11.Text = "Αριθμός Παραστατικού"
        '
        'txtSeiraId
        '
        Me.txtSeiraId.Location = New System.Drawing.Point(64, 56)
        Me.txtSeiraId.Name = "txtSeiraId"
        Me.txtSeiraId.ReadOnly = True
        Me.txtSeiraId.Size = New System.Drawing.Size(24, 20)
        Me.txtSeiraId.TabIndex = 29
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(24, 56)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(32, 16)
        Me.Label10.TabIndex = 28
        Me.Label10.Text = "Σειρά"
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(16, 24)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(128, 16)
        Me.Label9.TabIndex = 27
        Me.Label9.Text = "Επιλογή Παραστατικού"
        '
        'cbxParast
        '
        Me.cbxParast.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxParast.Location = New System.Drawing.Point(144, 24)
        Me.cbxParast.Name = "cbxParast"
        Me.cbxParast.Size = New System.Drawing.Size(256, 21)
        Me.cbxParast.TabIndex = 26
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(353, 222)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(92, 26)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "Εκτύπωση"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnSend
        '
        Me.btnSend.Location = New System.Drawing.Point(460, 221)
        Me.btnSend.Name = "btnSend"
        Me.btnSend.Size = New System.Drawing.Size(92, 26)
        Me.btnSend.TabIndex = 27
        Me.btnSend.Text = "Αποστολή"
        Me.btnSend.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(202, 170)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 16)
        Me.Label2.TabIndex = 28
        Me.Label2.Text = "ΦΠΑ"
        '
        'txtOrderText
        '
        Me.txtOrderText.Location = New System.Drawing.Point(425, 120)
        Me.txtOrderText.Name = "txtOrderText"
        Me.txtOrderText.Size = New System.Drawing.Size(632, 20)
        Me.txtOrderText.TabIndex = 29
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(358, 127)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(46, 13)
        Me.Label5.TabIndex = 30
        Me.Label5.Text = "Κείμενο"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.Label12.Location = New System.Drawing.Point(934, 610)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(61, 17)
        Me.Label12.TabIndex = 31
        Me.Label12.Text = "Συνολο"
        '
        'txtOrderSummary
        '
        Me.txtOrderSummary.DecimalPlaces = 2
        Me.txtOrderSummary.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.txtOrderSummary.Increment = New Decimal(New Integer() {0, 0, 0, 65536})
        Me.txtOrderSummary.Location = New System.Drawing.Point(1004, 607)
        Me.txtOrderSummary.Maximum = New Decimal(New Integer() {9999999, 0, 0, 131072})
        Me.txtOrderSummary.Minimum = New Decimal(New Integer() {9999999, 0, 0, -2147352576})
        Me.txtOrderSummary.Name = "txtOrderSummary"
        Me.txtOrderSummary.ReadOnly = True
        Me.txtOrderSummary.Size = New System.Drawing.Size(80, 23)
        Me.txtOrderSummary.TabIndex = 32
        Me.txtOrderSummary.TabStop = False
        Me.txtOrderSummary.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'EidosControl1
        '
        Me.EidosControl1.Location = New System.Drawing.Point(16, 64)
        Me.EidosControl1.Name = "EidosControl1"
        Me.EidosControl1.Size = New System.Drawing.Size(536, 48)
        Me.EidosControl1.TabIndex = 1
        '
        'CustomerControl1
        '
        Me.CustomerControl1.Location = New System.Drawing.Point(8, 32)
        Me.CustomerControl1.Name = "CustomerControl1"
        Me.CustomerControl1.Size = New System.Drawing.Size(761, 24)
        Me.CustomerControl1.TabIndex = 0
        '
        'frmOrderEdit
        '
        Me.AcceptButton = Me.btnCalc
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(1103, 636)
        Me.Controls.Add(Me.txtOrderSummary)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtOrderText)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnSend)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtPriceB)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtEkpPer)
        Me.Controls.Add(Me.txtEkpPos)
        Me.Controls.Add(Me.txtFpaPos)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnDeleteAll)
        Me.Controls.Add(Me.btnDeleteItem)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.DataGrid1)
        Me.Controls.Add(Me.txtOrderNumber)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnCalc)
        Me.Controls.Add(Me.txtPrice)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtCount)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.EidosControl1)
        Me.Controls.Add(Me.CustomerControl1)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(1111, 663)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(1111, 663)
        Me.Name = "frmOrderEdit"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Παραγγελία"
        CType(Me.txtCount, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPrice, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFpaPos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtEkpPer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtEkpPos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPriceB, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.txtOrderSummary, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private Sub frmOrderEdit_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If NewOrder = True Then
            '===================================================================================================
            FillComboBox(EidosControl1.cbxCounterType, "TableCounter", "CouCod", "CouDes", "CouDes")
            EidosControl1.cbxCounterType.SelectedIndex = 0
            '===================================================================================================
            FillComboBox(cbxParast, "TableSeira", "SeiraId", "SeiraDes", "SeiraDes")
            cbxParast.SelectedIndex = 0
            '===================================================================================================
            Dim SqlSelectNumber As String = "Select *  from OrderNumber"

            Dim adapterNumber As New Odbc.OdbcDataAdapter(SqlSelectNumber, MyConnection)
            Dim DsetNumber As New DataSet

            Dim NewNumber As Integer

            MyConnection.Open()
            DsetNumber.Clear()
            adapterNumber.Fill(DsetNumber)

            If DsetNumber.Tables(0).Rows.Count > 0 Then
                NewNumber = DsetNumber.Tables(0).Rows(0).Item("OrderNumber")
                NewNumber += 1

                sqlString = "update OrderNumber set " & _
                 "OrderNumber = '" & NewNumber & "'"

                trans = MyConnection.BeginTransaction
                MyCommand = New Odbc.OdbcCommand(sqlString, MyConnection, trans)
                MyCommand.CommandType = CommandType.Text
                MyCommand.ExecuteNonQuery()
                trans.Commit()
            Else
                NewNumber = 1
                sqlString = "INSERT INTO OrderNumber(OrderNumber) VALUES('1')"

                trans = MyConnection.BeginTransaction
                MyCommand = New Odbc.OdbcCommand(sqlString, MyConnection, trans)
                MyCommand.CommandType = CommandType.Text
                MyCommand.ExecuteNonQuery()
                trans.Commit()

            End If
            MyConnection.Close()
            txtOrderNumber.Text = NewNumber

            Call Me.FillDetailList()
        End If
    End Sub

    Private Sub btnCalc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalc.Click
        Call Calculate()
    End Sub
    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click
        Call Calculate()

        If CustomerControl1.CustomerExists = False Then
            MsgBox("Πρέπει να επιλέξεις πελάτη.", , "Error message")
            CustomerControl1.txtCusCod.Focus()
            Exit Sub
        End If

        If EidosControl1.txtEidCod.Text = "" Then
            Call UpdateOrderHead(txtOrderNumber.Text, CustomerControl1.txtCusCod.Text)
            Exit Sub
        End If

        If EidosControl1.EidosExists = False Then
            MsgBox("Πρέπει να επιλέξεις είδος.", , "Error message")
            EidosControl1.txtEidCod.Focus()
            Exit Sub
        End If
        '======================================================================================
        'Dim ExistsPosot As Decimal
        'Dim ExistsPrice As Decimal

        Dim SqlSelectItem As String = "Select *  from OrderDetail where OrderNumber = " & CInt(txtOrderNumber.Text) & "" & _
        " and EidCod = " & EidosControl1.txtEidCod.Text

        Dim adapterItem As New Odbc.OdbcDataAdapter(SqlSelectItem, MyConnection)
        Dim DsetItem As New DataSet

        MyConnection.Open()
        DsetItem.Clear()
        adapterItem.Fill(DsetItem)
        MyConnection.Close()

        If DsetItem.Tables(0).Rows.Count <= 0 Then
            MyConnection.Open()
            sqlString = "INSERT INTO OrderDetail VALUES('" & _
            CInt(txtOrderNumber.Text) & _
            "', '" & EidosControl1.txtEidCod.Text & _
            "', '" & EidosControl1.txtEidPrice.Text & _
            "', '" & EidosControl1.cbxCounterType.SelectedValue & _
            "', '" & txtCount.Text & _
            "', '" & txtPrice.Text & _
            "', '" & CustomerControl1.txtfpaper.Value & _
            "', '" & txtFpaPos.Text & _
            "', '" & txtEkpPer.Text & _
            "', '" & txtEkpPos.Text & _
            "', '" & txtPriceB.Text & _
            "')"


            trans = MyConnection.BeginTransaction
            MyCommand = New Odbc.OdbcCommand(sqlString, MyConnection, trans)
            MyCommand.CommandType = CommandType.Text
            MyCommand.ExecuteNonQuery()
            trans.Commit()
            MyConnection.Close()
            EidosControl1.txtEidCod.Text = ""
            txtCount.Text = 0
            txtPrice.Text = 0
        Else
            MyConnection.Open()
            sqlString = "update OrderDetail set " & _
             "EidCod = '" & EidosControl1.txtEidCod.Text & _
             "', EidPrice = '" & EidosControl1.txtEidPrice.Text & _
             "', CouCod = '" & EidosControl1.cbxCounterType.SelectedValue & _
             "', Count = '" & txtCount.Text & _
             "', Price = '" & txtPrice.Text & _
             "', FpaPos = '" & txtFpaPos.Text & _
             "', FpaPer = '" & CustomerControl1.txtfpaper.Text & _
             "', EkpPos = '" & txtEkpPos.Text & _
             "', EkpPer = '" & txtEkpPer.Text & _
             "', PriceB = '" & txtPriceB.Text & _
             "' where OrderNumber = " & CInt(txtOrderNumber.Text) & _
             " and EidCod = " & EidosControl1.txtEidCod.Text

            trans = MyConnection.BeginTransaction
            MyCommand = New Odbc.OdbcCommand(sqlString, MyConnection, trans)
            MyCommand.CommandType = CommandType.Text
            MyCommand.ExecuteNonQuery()
            trans.Commit()
            MyConnection.Close()

        End If
        Call UpdateOrderHead(txtOrderNumber.Text, CustomerControl1.txtCusCod.Text)
        Call Me.FillDetailList()
        EidosControl1.txtEidCod.Text = ""
        txtCount.Text = 0
        txtPrice.Text = 0
        Call Me.Calculate()
    End Sub


    Private Sub UpdateOrderHead(ByVal OrderNumber As Integer, ByVal CusCod As Integer)
        Dim OrderHeadExists As Boolean
        Dim OrderDetailExists As Boolean
        '==========================================================================

        Dim SqlSelectOrderH As String = "Select *  from OrderHead where OrderNumber = " & OrderNumber

        Dim adapterOrderH As New Odbc.OdbcDataAdapter(SqlSelectOrderH, MyConnection)
        Dim DsetOrderH As New DataSet

        MyConnection.Open()
        DsetOrderH.Clear()
        adapterOrderH.Fill(DsetOrderH)
        MyConnection.Close()
        If DsetOrderH.Tables(0).Rows.Count > 0 Then
            OrderHeadExists = True
        Else
            OrderHeadExists = False
        End If
        '==========================================================================
        Dim SqlSelectOrderD As String = "Select *  from OrderDetail where OrderNumber = " & OrderNumber

        Dim adapterOrderD As New Odbc.OdbcDataAdapter(SqlSelectOrderD, MyConnection)
        Dim DsetOrderD As New DataSet

        MyConnection.Open()
        DsetOrderD.Clear()
        adapterOrderD.Fill(DsetOrderD)
        MyConnection.Close()

        Dim Row As Integer
        Dim OrderPriceB As Decimal = 0
        Dim OrderPrice As Decimal = 0
        Dim OrderFpa As Decimal = 0
        Dim OrderEkp As Decimal = 0
        If DsetOrderD.Tables(0).Rows.Count > 0 Then
            OrderDetailExists = True
            For Row = 1 To DsetOrderD.Tables(0).Rows.Count
                OrderPriceB += DsetOrderD.Tables(0).Rows(Row - 1).Item("PriceB")
                OrderPrice += DsetOrderD.Tables(0).Rows(Row - 1).Item("Price")
                OrderFpa += DsetOrderD.Tables(0).Rows(Row - 1).Item("FpaPos")
                OrderEkp += DsetOrderD.Tables(0).Rows(Row - 1).Item("EkpPos")
            Next
        Else
            OrderDetailExists = False
        End If

        txtOrderSummary.Value = OrderPrice

        If OrderDetailExists Then
            If OrderHeadExists Then
                'update head
                MyConnection.Open()
                sqlString = "update OrderHead set " & _
                 "CusCod = '" & CustomerControl1.txtCusCod.Text & _
                 "', OrderPrice = '" & OrderPrice & _
                 "', OrderFpa = '" & OrderFpa & _
                 "', OrderEkp = '" & OrderEkp & _
                 "', OrderPriceB = '" & OrderPriceB & _
                 "', LastModDate = '" & Date.Now.ToString("yyyMMdd") & _
                 "', LastModUser = '" & UserId & _
                 "', SeiraId = '" & cbxParast.SelectedValue & _
                  "', OrderText = '" & txtOrderText.Text & _
                 "' where OrderNumber = " & OrderNumber

                trans = MyConnection.BeginTransaction
                MyCommand = New Odbc.OdbcCommand(sqlString, MyConnection, trans)
                MyCommand.CommandType = CommandType.Text
                MyCommand.ExecuteNonQuery()
                trans.Commit()
                MyConnection.Close()
            Else
                'insert head
                MyConnection.Open()
                sqlString = "INSERT INTO OrderHead VALUES('" & _
                txtOrderNumber.Text & _
                "','" & CusCod & _
                "','" & OrderPrice & _
                "','" & OrderEkp & _
                "','" & OrderFpa & _
                "','" & OrderPriceB & _
                "','" & Date.Now.ToString("yyyMMdd") & _
                "','" & Date.Now.ToString("yyyMMdd") & _
                "','" & UserId & _
                "','" & UserId & _
                "'," & "False" & _
                ",'" & "" & _
                "','" & 0 & _
                "','" & 0 & _
                "'," & "False" & _
                ",'" & 0 & _
                "','" & txtOrderText.Text & _
                "')"

                trans = MyConnection.BeginTransaction
                MyCommand = New Odbc.OdbcCommand(sqlString, MyConnection, trans)
                MyCommand.CommandType = CommandType.Text
                MyCommand.ExecuteNonQuery()
                trans.Commit()
                MyConnection.Close()

            End If
        Else
            'delete head
            MyConnection.Open()
            sqlString = "Delete * from  OrderHead where OrderNumber = " & OrderNumber

            trans = MyConnection.BeginTransaction
            MyCommand = New Odbc.OdbcCommand(sqlString, MyConnection, trans)
            MyCommand.CommandType = CommandType.Text
            MyCommand.ExecuteNonQuery()
            trans.Commit()
            MyConnection.Close()

        End If


    End Sub

    Private Sub btnDeleteItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDeleteItem.Click
        'delete head
        MyConnection.Open()
        sqlString = "Delete * from  OrderDetail where OrderNumber = " & txtOrderNumber.Text & _
        " and EidCod = " & EidosControl1.txtEidCod.Text

        trans = MyConnection.BeginTransaction
        MyCommand = New Odbc.OdbcCommand(sqlString, MyConnection, trans)
        MyCommand.CommandType = CommandType.Text
        MyCommand.ExecuteNonQuery()
        trans.Commit()
        MyConnection.Close()

        Call UpdateOrderHead(txtOrderNumber.Text, CustomerControl1.txtCusCod.Text)
        Call FillDetailList()
    End Sub

    Private Sub FillDetailList()
        Dim SqlGetOrderDetail As String = "Select " & _
        "a.EidCod as ΚΩΔ_ΕΙΔΟΥΣ, " & _
        "(select EidDes from TableEidos where a.EidCod=TableEidos.EidCod) as ΕΙΔΟΣ, " & _
        "a.CouCod as ΚΩΔ_ΜΟΝ_ΜΕΤ, " & _
        "(select CouDes from TableCounter where a.CouCod=TableCounter.CouCod) as ΜΟΝ_ΜΕΤ, " & _
        "a.count as ΠΟΣΟΤΗΤΑ, " & _
        "a.EidPrice as ΤΙΜΗ_ΜΟΝΑΔΟΣ, " & _
        "a.PriceB as ΤΙΜΗ, " & _
        "a.EkpPer as ΠΟΣΟΣΤΟ_ΕΚΠΤΩΣΗΣ, " & _
        "a.EkpPos as ΠΟΣΟ_ΕΚΠΤΩΣΗΣ, " & _
        "a.Price as ΤΕΛΙΚΗ_ΤΙΜΗ, " & _
        "a.FpaPer as ΠΟΣΟΣΤΟ_ΦΠΑ, " & _
        "a.FpaPos as ΠΟΣΟ_ΦΠΑ " & _
        "from OrderDetail as a where OrderNumber =  " & txtOrderNumber.Text

        Dim adapterOrderDetail As New Odbc.OdbcDataAdapter(SqlGetOrderDetail, MyConnection)
        Dim DsetOrderDetail As New DataSet

        MyConnection.Open()
        DsetOrderDetail.Clear()
        adapterOrderDetail.Fill(DsetOrderDetail)
        MyConnection.Close()

        DataGrid1.DataSource = DsetOrderDetail.Tables(0)

    End Sub

    Private Sub btnDeleteAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDeleteAll.Click
        'delete head-detail
        MyConnection.Open()
        sqlString = "Delete * from  OrderHead as a where a.OrderNumber = " & txtOrderNumber.Text

        trans = MyConnection.BeginTransaction
        MyCommand = New Odbc.OdbcCommand(sqlString, MyConnection, trans)
        MyCommand.CommandType = CommandType.Text
        MyCommand.ExecuteNonQuery()
        trans.Commit()

        sqlString = "Delete * from  OrderDetail as b where b.OrderNumber =" & txtOrderNumber.Text

        trans = MyConnection.BeginTransaction
        MyCommand = New Odbc.OdbcCommand(sqlString, MyConnection, trans)
        MyCommand.CommandType = CommandType.Text
        MyCommand.ExecuteNonQuery()
        trans.Commit()
        MyConnection.Close()
        Me.Close()
    End Sub
    Private Sub Calculate()
        'Μικτή Τιμή Είδους (χωρίς την έκπτωση)
        '====================================================================================
        txtPriceB.Value = Math.Round(txtCount.Value * EidosControl1.txtEidPrice.Value, 2)
        'Υπολογισμός Έκπτωσης
        '====================================================================================
        txtEkpPos.Value = 0
        If txtEkpPer.Value > 0 And txtPriceB.Value > 0 Then
            txtEkpPos.Value = Math.Round((txtPriceB.Value * txtEkpPer.Value) / 100, 2)
            txtEkpPer.Value = Math.Round(txtEkpPer.Value, 2)
            txtEkpPos.Value = Math.Round(txtEkpPos.Value, 2)
        End If
        'Υπολογισμός Φπα
        '====================================================================================
        txtFpaPos.Value = 0
        If CustomerControl1.txtfpaper.Value > 0 And txtPriceB.Value > 0 Then
            txtFpaPos.Value = Math.Round((txtPriceB.Value * CustomerControl1.txtfpaper.Value) / 100, 2)
            CustomerControl1.txtfpaper.Value = Math.Round(CustomerControl1.txtfpaper.Value, 2)
            txtFpaPos.Value = Math.Round(txtFpaPos.Value, 2)
        End If

        'Μικτή Τιμή Είδους (μετά την Έκπτωση)
        '====================================================================================
        txtPrice.Value = Math.Round((txtCount.Value * EidosControl1.txtEidPrice.Value) - txtEkpPos.Value, 2)

    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Public Sub LoadForm(ByVal OrderNumber As Integer)
        '===================================================================================================
        FillComboBox(EidosControl1.cbxCounterType, "TableCounter", "CouCod", "CouDes", "CouDes")
        '===================================================================================================
        FillComboBox(cbxParast, "TableSeira", "SeiraId", "SeiraDes", "SeiraDes")
        '===================================================================================================

        txtOrderNumber.Text = OrderNumber

        If OrderNumber > 0 Then
            Dim sqlString As String = "Select * from OrderHead where OrderNumber=" & OrderNumber
            Dim adapter1 As New Odbc.OdbcDataAdapter(sqlString, MyConnection)
            Dim Dset1 As New DataSet

            MyConnection.Open()
            Dset1.Clear()
            adapter1.Fill(Dset1)
            MyConnection.Close()
            If Dset1.Tables(0).Rows.Count > 0 Then
                CustomerControl1.txtCusCod.Text = Dset1.Tables(0).Rows(0).Item("CusCod")
                txtOrderText.Text = Dset1.Tables(0).Rows(0).Item("OrderText")
                txtInvoiceNumber.Text = Dset1.Tables(0).Rows(0).Item("InvoiceNumber")
                txtOrderSummary.Value = Dset1.Tables(0).Rows(0).Item("OrderPrice")

                If Dset1.Tables(0).Rows(0).Item("SeiraId") <> "" Then
                    cbxParast.SelectedValue = Dset1.Tables(0).Rows(0).Item("SeiraId")
                    txtSeiraId.Text = Dset1.Tables(0).Rows(0).Item("SeiraId")
                End If

                If Dset1.Tables(0).Rows(0).Item("Invoiced") = True Then
                    CustomerControl1.Enabled = False
                    EidosControl1.Enabled = False
                    txtCount.Enabled = False
                    txtEkpPer.Enabled = False
                    CustomerControl1.txtfpaper.Enabled = False
                    btnCalc.Enabled = False
                    cbxParast.Enabled = False
                    btnDeleteAll.Enabled = False
                    btnDeleteItem.Enabled = False
                    btnUpdate.Enabled = False
                    btnInvoice.Enabled = False
                    btnSend.Enabled = False
                End If
                If Dset1.Tables(0).Rows(0).Item("Send") = True Then
                    btnSend.Enabled = False
                End If
            End If
        End If


        Call Me.FillDetailList()

        Me.ShowDialog()
    End Sub


    Private Sub DataGrid1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGrid1.DoubleClick
        EidosControl1.txtEidCod.Text = DataGrid1.Item(DataGrid1.CurrentRowIndex, 0)
        EidosControl1.cbxCounterType.SelectedValue = DataGrid1.Item(DataGrid1.CurrentRowIndex, 2)
        txtCount.Value = DataGrid1.Item(DataGrid1.CurrentRowIndex, 4)
        EidosControl1.txtEidPrice.Value = DataGrid1.Item(DataGrid1.CurrentRowIndex, 5)
        txtPriceB.Value = DataGrid1.Item(DataGrid1.CurrentRowIndex, 6)
        txtEkpPer.Value = DataGrid1.Item(DataGrid1.CurrentRowIndex, 7)
        txtEkpPos.Value = DataGrid1.Item(DataGrid1.CurrentRowIndex, 8)
        txtPrice.Value = DataGrid1.Item(DataGrid1.CurrentRowIndex, 9)
        CustomerControl1.txtfpaper.Value = DataGrid1.Item(DataGrid1.CurrentRowIndex, 10)
        txtFpaPos.Value = DataGrid1.Item(DataGrid1.CurrentRowIndex, 11)
    End Sub


    Private Sub cbxParast_SelectionChangeCommitted(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbxParast.SelectionChangeCommitted
        txtSeiraId.Text = cbxParast.SelectedValue
    End Sub

    Private Sub btnInvoice_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInvoice.Click

        MyConnection.Open()
        '===========================================================================================
        Dim sqlGetInvoiceNumber As String = "Select SeiraNum from TableSeira where SeiraId='" & cbxParast.SelectedValue & "'"
        Dim adapterGetInvoiceNumber As New Odbc.OdbcDataAdapter(sqlGetInvoiceNumber, MyConnection)
        Dim DsetGetInvoiceNumber As New DataSet

        DsetGetInvoiceNumber.Clear()
        adapterGetInvoiceNumber.Fill(DsetGetInvoiceNumber)
        Dim NewInvNumber As Integer = DsetGetInvoiceNumber.Tables(0).Rows(0).Item(0) + 1
        '===========================================================================================
        Dim sqlStringUO As String = "update OrderHead set " & _
         " LastModDate = '" & Date.Now.ToString("yyyMMdd") & _
         "', LastModUser = '" & UserId & _
         "', SeiraId = '" & cbxParast.SelectedValue & _
         "', InvoiceNumber = '" & NewInvNumber & _
         "', Invoiced = " & "True" & _
         ", InvoiceDate = '" & Date.Now.ToString("yyyMMdd") & _
         "' where OrderNumber = " & CInt(txtOrderNumber.Text)

        trans = MyConnection.BeginTransaction
        MyCommand = New Odbc.OdbcCommand(sqlStringUO, MyConnection, trans)
        MyCommand.CommandType = CommandType.Text
        MyCommand.ExecuteNonQuery()
        trans.Commit()
        '===========================================================================================
        Dim sqlStringUI As String = "update TableSeira set " & _
         " SeiraNum = '" & NewInvNumber & _
         "' where SeiraId='" & cbxParast.SelectedValue & "'"

        trans = MyConnection.BeginTransaction
        MyCommand = New Odbc.OdbcCommand(sqlStringUI, MyConnection, trans)
        MyCommand.CommandType = CommandType.Text
        MyCommand.ExecuteNonQuery()
        trans.Commit()
        MyConnection.Close()
        Me.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        SelectedRec = txtOrderNumber.Text
        Dim frmPrintOrder As New FrmPrintOrder
        frmPrintOrder.ShowDialog()
    End Sub

    Private Sub btnSend_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSend.Click
        MyConnection.Open()
        sqlString = "update OrderHead set " & _
         "Send = " & "TRUE" & _
         ", SendDate = '" & Date.Now.ToString("yyyMMdd") & _
         "' where OrderNumber = " & CInt(txtOrderNumber.Text)

        trans = MyConnection.BeginTransaction
        MyCommand = New Odbc.OdbcCommand(sqlString, MyConnection, trans)
        MyCommand.CommandType = CommandType.Text
        MyCommand.ExecuteNonQuery()
        trans.Commit()
        MyConnection.Close()

    End Sub


    Private Sub CustomerControl1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CustomerControl1.Load

    End Sub
End Class
