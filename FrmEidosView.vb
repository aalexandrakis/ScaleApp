Public Class FrmEidosView
    Inherits System.Windows.Forms.Form

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
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnExcel As System.Windows.Forms.Button
    Friend WithEvents btnNew As System.Windows.Forms.Button
    Friend WithEvents chkDsp As System.Windows.Forms.CheckBox
    Friend WithEvents cbxItemCat As System.Windows.Forms.ComboBox
    Friend WithEvents btnFill As System.Windows.Forms.Button
    Friend WithEvents DataGrid1 As System.Windows.Forms.DataGrid
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.btnExit = New System.Windows.Forms.Button
        Me.btnExcel = New System.Windows.Forms.Button
        Me.btnNew = New System.Windows.Forms.Button
        Me.DataGrid1 = New System.Windows.Forms.DataGrid
        Me.chkDsp = New System.Windows.Forms.CheckBox
        Me.cbxItemCat = New System.Windows.Forms.ComboBox
        Me.btnFill = New System.Windows.Forms.Button
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(644, 384)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(64, 24)
        Me.btnExit.TabIndex = 27
        Me.btnExit.Text = "Έξοδος"
        '
        'btnExcel
        '
        Me.btnExcel.Location = New System.Drawing.Point(556, 384)
        Me.btnExcel.Name = "btnExcel"
        Me.btnExcel.Size = New System.Drawing.Size(80, 24)
        Me.btnExcel.TabIndex = 29
        Me.btnExcel.Text = "Excel"
        '
        'btnNew
        '
        Me.btnNew.Location = New System.Drawing.Point(444, 384)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(104, 24)
        Me.btnNew.TabIndex = 28
        Me.btnNew.Text = "Νέα Καταχώρηση"
        '
        'DataGrid1
        '
        Me.DataGrid1.DataMember = ""
        Me.DataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGrid1.Location = New System.Drawing.Point(8, 8)
        Me.DataGrid1.Name = "DataGrid1"
        Me.DataGrid1.Size = New System.Drawing.Size(703, 368)
        Me.DataGrid1.TabIndex = 30
        '
        'chkDsp
        '
        Me.chkDsp.AutoSize = True
        Me.chkDsp.Location = New System.Drawing.Point(12, 384)
        Me.chkDsp.Name = "chkDsp"
        Me.chkDsp.Size = New System.Drawing.Size(103, 17)
        Me.chkDsp.TabIndex = 31
        Me.chkDsp.Text = "Εμφάνιση όλων"
        Me.chkDsp.UseVisualStyleBackColor = True
        '
        'cbxItemCat
        '
        Me.cbxItemCat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxItemCat.Location = New System.Drawing.Point(121, 382)
        Me.cbxItemCat.Name = "cbxItemCat"
        Me.cbxItemCat.Size = New System.Drawing.Size(224, 21)
        Me.cbxItemCat.TabIndex = 32
        '
        'btnFill
        '
        Me.btnFill.Location = New System.Drawing.Point(351, 382)
        Me.btnFill.Name = "btnFill"
        Me.btnFill.Size = New System.Drawing.Size(87, 25)
        Me.btnFill.TabIndex = 33
        Me.btnFill.Text = "Ανανέωση"
        Me.btnFill.UseVisualStyleBackColor = True
        '
        'FrmEidosView
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(723, 412)
        Me.Controls.Add(Me.btnFill)
        Me.Controls.Add(Me.cbxItemCat)
        Me.Controls.Add(Me.chkDsp)
        Me.Controls.Add(Me.DataGrid1)
        Me.Controls.Add(Me.btnExcel)
        Me.Controls.Add(Me.btnNew)
        Me.Controls.Add(Me.btnExit)
        Me.Name = "FrmEidosView"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Πίνακας Ειδών"
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region
    Dim SqlSelect As String
    Dim Dset1 As New DataSet



    Private Sub FrmEidosView_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        '===================================================================================================
        FillComboBox(cbxItemCat, "TableItemCat", "CodCat", "DesCat", "DesCat")
        cbxItemCat.SelectedIndex = 0
        '===================================================================================================
    End Sub

    Private Sub filllist()

        SqlSelect = "Select EidCod as Κωδικός, EidDes as Περιγραφή, EidPrice as Τιμή, SelPrice as Τιμή_Πώλησης, " & _
            "(Select CouDes from TableCounter where Coucod = a.Coucod) as Μονάδα_Μέτρησης,  " & _
            "(Select DesCat from TableItemCat where CodCat = a.CodCat) as Κατηγορία, FPA as ΦΠΑ from TableEidos a where " & _
            "(('" & chkDsp.Checked.ToString & "' = 'True') or ('" & chkDsp.Checked.ToString & "' = 'False' and a.Display ='Yes'))" & _
            " and a.CodCat = " & cbxItemCat.SelectedValue & _
            " order by 2"




        Dim adapter1 As New Odbc.OdbcDataAdapter(SqlSelect, MyConnection)

        If MyConnection.State = ConnectionState.Closed Then
            MyConnection.Open()
        End If
        Dset1.Clear()
        adapter1.Fill(Dset1)
        MyConnection.Close()

        DataGrid1.DataSource = Dset1.Tables(0)

    End Sub
    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click
        Dim frmEidosEdit As New FrmEidosEdit
        frmEidosEdit.ShowDialog()
        Call filllist()
    End Sub
    ' Private Sub btnExcel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcel.Click
    '     Call DataSetToExcel(Dset1, Me.Text)
    ' End Sub
    Private Sub DataGrid1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGrid1.DoubleClick
        Dim frmEidosEdit As New FrmEidosEdit
        frmEidosEdit.FormLoad(DataGrid1.Item(DataGrid1.CurrentRowIndex, 0))
        Call filllist()
    End Sub

    Private Sub btnFill_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFill.Click
        Call filllist()

    End Sub

    Private Sub DataGrid1_Navigate(ByVal sender As System.Object, ByVal ne As System.Windows.Forms.NavigateEventArgs) Handles DataGrid1.Navigate

    End Sub
End Class
