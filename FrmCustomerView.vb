Public Class FrmCustomerView
    Inherits System.Windows.Forms.Form
    Dim SqlSelect As String = "" & _
        "Select a.CusCod as  Ÿƒ… œ”, a.CusName as ≈–ŸÕ’Ã…¡, a.CusAfm as ¡÷Ã, a.CusAddress as ƒ…≈’»’Õ”«, a.CusZipCod as ‘¡◊_ Ÿƒ, " & _
        "(select NomDes from TableNomoi where a.Nomcod=TableNomoi.Nomcod) as ÕœÃœ”,  " & _
        "(select CitDes from TableCities where a.Citcod=TableCities.Citcod) as –œÀ«,  " & _
        "(select DimDes from TableDimoi where a.Dimcod=TableDimoi.Dimcod) as ƒ«Ãœ”,  " & _
        "CusAcN as œ… œÕœÃ… œ”_’–≈’»’Õœ”," & _
        "(select EpaDes from TableEpa where a.Epacod=TableEpa.Epacod) as ≈–¡√√≈ÀÃ¡,  " & _
        "CusEml as EMAIL," & _
        "(select CatCDes from TableCatCus where a.CatCCod=TableCatCus.CatCCod) as  ¡‘«√œ—…¡,  " & _
        "CusSubFpa as Ã≈…ŸÃ≈Õœ”_÷–¡ " & _
        "from TableCustomers as a "

    Dim adapter1 As New Odbc.OdbcDataAdapter(SqlSelect, MyConnection)
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
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.DataGrid1 = New System.Windows.Forms.DataGrid
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGrid1
        '
        Me.DataGrid1.DataMember = ""
        Me.DataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGrid1.Location = New System.Drawing.Point(8, 8)
        Me.DataGrid1.Name = "DataGrid1"
        Me.DataGrid1.ReadOnly = True
        Me.DataGrid1.Size = New System.Drawing.Size(672, 400)
        Me.DataGrid1.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(408, 416)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(104, 24)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Õ›·  ·Ù·˜˛ÒÁÛÁ"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(520, 416)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(80, 24)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Excel"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(608, 416)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(72, 24)
        Me.Button3.TabIndex = 3
        Me.Button3.Text = "∏ÓÔ‰ÔÚ"
        '
        'FrmCustomerView
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(688, 444)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DataGrid1)
        Me.Name = "FrmCustomerView"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "–ÂÎ·ÙÔÎ¸„ÈÔ"
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub FrmCustomerView_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call filllist()
    End Sub

    Private Sub filllist()
        
        MyConnection.Open()
        Dset1.Clear()
        adapter1.Fill(Dset1)
        MyConnection.Close()

        DataGrid1.DataSource = Dset1.Tables(0)
    End Sub


    
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim frmCustomeredit As New FrmCustomerEdit
        frmCustomeredit.ShowDialog()
        Call filllist()
    End Sub

    Private Sub DataGrid1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGrid1.DoubleClick
        Dim frmCustomerEdit As New FrmCustomerEdit
        frmCustomerEdit.LoadForm(DataGrid1.Item(DataGrid1.CurrentRowIndex, 0))
        Call filllist()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Call DataSetToExcel(Dset1, Me.Text)
    End Sub
End Class
