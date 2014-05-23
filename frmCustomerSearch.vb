Public Class frmCustomerSearch
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
    Friend WithEvents btnNewCust As System.Windows.Forms.Button

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents DataGrid1 As System.Windows.Forms.DataGrid
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.DataGrid1 = New System.Windows.Forms.DataGrid
        Me.btnNewCust = New System.Windows.Forms.Button
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
        Me.DataGrid1.Size = New System.Drawing.Size(672, 432)
        Me.DataGrid1.TabIndex = 4
        '
        'btnNewCust
        '
        Me.btnNewCust.Location = New System.Drawing.Point(555, 446)
        Me.btnNewCust.Name = "btnNewCust"
        Me.btnNewCust.Size = New System.Drawing.Size(121, 25)
        Me.btnNewCust.TabIndex = 5
        Me.btnNewCust.Text = "��� ����������"
        Me.btnNewCust.UseVisualStyleBackColor = True
        '
        'frmCustomerSearch
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(688, 472)
        Me.Controls.Add(Me.btnNewCust)
        Me.Controls.Add(Me.DataGrid1)
        Me.Name = "frmCustomerSearch"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "��������� ������"
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Public SelectedCustomer As Integer

    Public Sub FormLoad(ByVal StartsWith As String)
        Dim SqlSelect As String = "" & _
               "Select a.CusCod as �������, a.CusName as ��������, a.CusAfm as ���, a.CusAddress as ���������, a.CusZipCod as ���_���, " & _
               "(select NomDes from TableNomoi where a.Nomcod=TableNomoi.Nomcod) as �����,  " & _
               "(select CitDes from TableCities where a.Citcod=TableCities.Citcod) as ����,  " & _
               "(select DimDes from TableDimoi where a.Dimcod=TableDimoi.Dimcod) as �����,  " & _
               "CusAcN as �����������_���������," & _
               "(select EpaDes from TableEpa where a.Epacod=TableEpa.Epacod) as ���������,  " & _
               "CusEml as EMAIL," & _
               "(select CatCDes from TableCatCus where a.CatCCod=TableCatCus.CatCCod) as ���������,  " & _
               "CusSubFpa as ���������_��� " & _
               "from TableCustomers as a " & _
               "where a.CusName like '" & StartsWith & "%'"

        Dim adapter1 As New Odbc.OdbcDataAdapter(SqlSelect, MyConnection)
        Dim Dset1 As New DataSet

        MyConnection.Open()
        Dset1.Clear()
        adapter1.Fill(Dset1)
        MyConnection.Close()

        DataGrid1.DataSource = Dset1.Tables(0)
    End Sub



    Private Sub DataGrid1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGrid1.DoubleClick
        SelectedCustomer = DataGrid1.Item(DataGrid1.CurrentRowIndex, 0)
        Me.Close()
    End Sub

    Private Sub btnNewCust_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNewCust.Click
        Dim frmCustomeredit As New FrmCustomerEdit
        frmCustomeredit.ShowDialog()
        Call FormLoad("")
    End Sub

    Private Sub frmCustomerSearch_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
