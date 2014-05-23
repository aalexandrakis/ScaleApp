Public Class FrmOrderView
    Inherits System.Windows.Forms.Form

    Dim SqlSelect As String
    Friend WithEvents RdNotSend As System.Windows.Forms.RadioButton
    Friend WithEvents rdSend As System.Windows.Forms.RadioButton
    Friend WithEvents rdInv As System.Windows.Forms.RadioButton
    Friend WithEvents rdNotInv As System.Windows.Forms.RadioButton
    Dim Dset1 As New DataSet

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
    Friend WithEvents DataGrid1 As System.Windows.Forms.DataGrid
    Friend WithEvents btnNew As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnExcel As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.DataGrid1 = New System.Windows.Forms.DataGrid
        Me.btnNew = New System.Windows.Forms.Button
        Me.btnExit = New System.Windows.Forms.Button
        Me.btnExcel = New System.Windows.Forms.Button
        Me.RdNotSend = New System.Windows.Forms.RadioButton
        Me.rdSend = New System.Windows.Forms.RadioButton
        Me.rdInv = New System.Windows.Forms.RadioButton
        Me.rdNotInv = New System.Windows.Forms.RadioButton
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGrid1
        '
        Me.DataGrid1.DataMember = ""
        Me.DataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGrid1.Location = New System.Drawing.Point(0, 0)
        Me.DataGrid1.Name = "DataGrid1"
        Me.DataGrid1.ReadOnly = True
        Me.DataGrid1.Size = New System.Drawing.Size(920, 597)
        Me.DataGrid1.TabIndex = 0
        '
        'btnNew
        '
        Me.btnNew.Location = New System.Drawing.Point(656, 603)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(104, 24)
        Me.btnNew.TabIndex = 41
        Me.btnNew.Text = "мщА йАТАВЧЯГСГ"
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(856, 603)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(64, 24)
        Me.btnExit.TabIndex = 40
        Me.btnExit.Text = "╦НОДОР"
        '
        'btnExcel
        '
        Me.btnExcel.Location = New System.Drawing.Point(768, 603)
        Me.btnExcel.Name = "btnExcel"
        Me.btnExcel.Size = New System.Drawing.Size(80, 24)
        Me.btnExcel.TabIndex = 42
        Me.btnExcel.Text = "Excel"
        '
        'RdNotSend
        '
        Me.RdNotSend.AutoSize = True
        Me.RdNotSend.Checked = True
        Me.RdNotSend.Location = New System.Drawing.Point(12, 603)
        Me.RdNotSend.Name = "RdNotSend"
        Me.RdNotSend.Size = New System.Drawing.Size(116, 17)
        Me.RdNotSend.TabIndex = 43
        Me.RdNotSend.TabStop = True
        Me.RdNotSend.Text = "лГ аПЕСТАКЛщМЕР"
        Me.RdNotSend.UseVisualStyleBackColor = True
        '
        'rdSend
        '
        Me.rdSend.AutoSize = True
        Me.rdSend.Location = New System.Drawing.Point(134, 603)
        Me.rdSend.Name = "rdSend"
        Me.rdSend.Size = New System.Drawing.Size(99, 17)
        Me.rdSend.TabIndex = 44
        Me.rdSend.Text = "аПЕСТАКЛщМЕР"
        Me.rdSend.UseVisualStyleBackColor = True
        '
        'rdInv
        '
        Me.rdInv.AutoSize = True
        Me.rdInv.Location = New System.Drawing.Point(361, 603)
        Me.rdInv.Name = "rdInv"
        Me.rdInv.Size = New System.Drawing.Size(99, 17)
        Me.rdInv.TabIndex = 45
        Me.rdInv.Text = "тИЛОКОЦГЛщМЕР"
        Me.rdInv.UseVisualStyleBackColor = True
        '
        'rdNotInv
        '
        Me.rdNotInv.AutoSize = True
        Me.rdNotInv.Location = New System.Drawing.Point(239, 603)
        Me.rdNotInv.Name = "rdNotInv"
        Me.rdNotInv.Size = New System.Drawing.Size(116, 17)
        Me.rdNotInv.TabIndex = 46
        Me.rdNotInv.TabStop = True
        Me.rdNotInv.Text = "лГ тИЛОКОЦГЛщМЕР"
        Me.rdNotInv.UseVisualStyleBackColor = True
        '
        'FrmOrderView
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(920, 627)
        Me.Controls.Add(Me.rdNotInv)
        Me.Controls.Add(Me.rdInv)
        Me.Controls.Add(Me.rdSend)
        Me.Controls.Add(Me.RdNotSend)
        Me.Controls.Add(Me.btnNew)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnExcel)
        Me.Controls.Add(Me.DataGrid1)
        Me.Name = "FrmOrderView"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "пАЯАЦЦЕКъЕР"
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private Sub FrmOrderView_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call FillList()
    End Sub
    Private Sub FillList()
        Dim BoolTrue As Boolean = True
        Dim BoolFalse As Boolean = False

        If RdNotSend.Checked Then
            SqlSelect = "Select a.OrderNumber as аяихлос_паяаццекиас, " & _
            "a.CusCod as йыдийос, " & _
            "(select CusName from TableCustomers where a.Cuscod=TableCustomers.Cuscod) as епымулиа_пекатг,  " & _
            "a.OrderPrice as тилг, " & _
            "a.OrderEkp as посо_ейптысгс, " & _
            "OrderPriceB as текийг_тилг, " & _
            "a.OrderFpa as посо_жпа, " & _
            "(select UserName from UserTable where a.LastModUser=UserTable.UserId) as вягстгс,  " & _
            "Mid(Cstr(LastModDate), 7, 2) & '/' & Mid(Cstr(LastModDate), 5, 2) & '/' & Mid(Cstr(LastModDate), 1, 4) as глеяолгмиа, " & _
            "a.Invoiced as тилокоцилемг, " & _
            "a.Send as апестаклемг " & _
            "from OrderHead as a where Send = False " & _
            "order by OrderNumber"
        End If

        If rdSend.Checked Then
            SqlSelect = "Select a.OrderNumber as аяихлос_паяаццекиас, " & _
            "a.CusCod as йыдийос, " & _
            "(select CusName from TableCustomers where a.Cuscod=TableCustomers.Cuscod) as епымулиа_пекатг,  " & _
            "a.OrderPrice as тилг, " & _
            "a.OrderEkp as посо_ейптысгс, " & _
            "OrderPriceB as текийг_тилг, " & _
            "a.OrderFpa as посо_жпа, " & _
            "(select UserName from UserTable where a.LastModUser=UserTable.UserId) as вягстгс,  " & _
            "Mid(Cstr(LastModDate), 7, 2) & '/' & Mid(Cstr(LastModDate), 5, 2) & '/' & Mid(Cstr(LastModDate), 1, 4) as глеяолгмиа, " & _
            "a.Invoiced as тилокоцилемг, " & _
            "a.Send as апестаклемг " & _
            "from OrderHead as a where Send = True " & _
            "order by OrderNumber"
        End If

        If rdNotInv.Checked Then
            SqlSelect = "Select a.OrderNumber as аяихлос_паяаццекиас, " & _
            "a.CusCod as йыдийос, " & _
            "(select CusName from TableCustomers where a.Cuscod=TableCustomers.Cuscod) as епымулиа_пекатг,  " & _
            "a.OrderPrice as тилг, " & _
            "a.OrderEkp as посо_ейптысгс, " & _
            "OrderPriceB as текийг_тилг, " & _
            "a.OrderFpa as посо_жпа, " & _
            "(select UserName from UserTable where a.LastModUser=UserTable.UserId) as вягстгс,  " & _
            "Mid(Cstr(LastModDate), 7, 2) & '/' & Mid(Cstr(LastModDate), 5, 2) & '/' & Mid(Cstr(LastModDate), 1, 4) as глеяолгмиа, " & _
            "a.Invoiced as тилокоцилемг, " & _
            "a.Send as апестаклемг " & _
            "from OrderHead as a where Invoiced = False " & _
            "order by OrderNumber"
        End If

        If rdInv.Checked Then
            SqlSelect = "Select a.OrderNumber as аяихлос_паяаццекиас, " & _
            "a.CusCod as йыдийос, " & _
            "(select CusName from TableCustomers where a.Cuscod=TableCustomers.Cuscod) as епымулиа_пекатг,  " & _
            "a.OrderPrice as тилг, " & _
            "a.OrderEkp as посо_ейптысгс, " & _
            "OrderPriceB as текийг_тилг, " & _
            "a.OrderFpa as посо_жпа, " & _
            "(select UserName from UserTable where a.LastModUser=UserTable.UserId) as вягстгс,  " & _
            "Mid(Cstr(LastModDate), 7, 2) & '/' & Mid(Cstr(LastModDate), 5, 2) & '/' & Mid(Cstr(LastModDate), 1, 4) as глеяолгмиа, " & _
            "a.Invoiced as тилокоцилемг, " & _
            "a.Send as апестаклемг " & _
            "from OrderHead as a where Invoiced = True " & _
            "order by OrderNumber"
        End If

        Dim adapter1 As New Odbc.OdbcDataAdapter(SqlSelect, MyConnection)
        MyConnection.Open()
        Dset1.Clear()
        adapter1.Fill(Dset1)
        MyConnection.Close()

        DataGrid1.DataSource = Dset1.Tables(0)
    End Sub
    Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click
        Dim frmOrderEdit As New frmOrderEdit
        frmOrderEdit.NewOrder = True
        frmOrderEdit.ShowDialog()
        Call FillList()
    End Sub

    Private Sub btnExcel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcel.Click
        Call DataSetToExcel(Dset1, Me.Text)
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub


    Private Sub DataGrid1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGrid1.DoubleClick
        Dim frmOrderEdit As New frmOrderEdit
        frmOrderEdit.NewOrder = False
        frmOrderEdit.LoadForm(DataGrid1.Item(DataGrid1.CurrentRowIndex, 0))
        Call FillList()
    End Sub


    Private Sub RdNotSend_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RdNotSend.CheckedChanged
        Call FillList()
    End Sub

    Private Sub rdSend_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdSend.CheckedChanged
        Call FillList()
    End Sub

    Private Sub rdNotInv_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdNotInv.CheckedChanged
        Call FillList()
    End Sub

    Private Sub rdInv_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdInv.CheckedChanged
        Call FillList()
    End Sub
End Class
