Public Class FrmSeiraView
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
    Friend WithEvents DataGrid1 As System.Windows.Forms.DataGrid
    Friend WithEvents btnExcel As System.Windows.Forms.Button
    Friend WithEvents btnNew As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.DataGrid1 = New System.Windows.Forms.DataGrid
        Me.btnExcel = New System.Windows.Forms.Button
        Me.btnNew = New System.Windows.Forms.Button
        Me.btnExit = New System.Windows.Forms.Button
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
        Me.DataGrid1.Size = New System.Drawing.Size(672, 368)
        Me.DataGrid1.TabIndex = 34
        '
        'btnExcel
        '
        Me.btnExcel.Location = New System.Drawing.Point(528, 384)
        Me.btnExcel.Name = "btnExcel"
        Me.btnExcel.Size = New System.Drawing.Size(80, 24)
        Me.btnExcel.TabIndex = 33
        Me.btnExcel.Text = "Excel"
        '
        'btnNew
        '
        Me.btnNew.Location = New System.Drawing.Point(416, 384)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(104, 24)
        Me.btnNew.TabIndex = 32
        Me.btnNew.Text = "Νέα Καταχώρηση"
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(616, 384)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(64, 24)
        Me.btnExit.TabIndex = 31
        Me.btnExit.Text = "Έξοδος"
        '
        'FrmSeiraView
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(688, 412)
        Me.Controls.Add(Me.DataGrid1)
        Me.Controls.Add(Me.btnExcel)
        Me.Controls.Add(Me.btnNew)
        Me.Controls.Add(Me.btnExit)
        Me.Name = "FrmSeiraView"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Σειρές Παραστατικών"
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim SqlSelect As String = "Select SeiraId as Σειρά, SeiraDes as Περιγραφή, SeiraNum as Αριθμός from TableSeira order by SeiraId"

    Dim adapter1 As New Odbc.OdbcDataAdapter(SqlSelect, MyConnection)
    Dim Dset1 As New DataSet

    Private Sub FrmSeiraView_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call filllist()
    End Sub

    
    Private Sub filllist()

        MyConnection.Open()
        Dset1.Clear()
        adapter1.Fill(Dset1)
        MyConnection.Close()

        DataGrid1.DataSource = Dset1.Tables(0)

    End Sub
    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click
        Dim frmSeiraEdit As New FrmSeiraEdit
        frmSeiraEdit.ShowDialog()
        Call filllist()
    End Sub
    Private Sub btnExcel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcel.Click
        Call DataSetToExcel(Dset1, Me.Text)
    End Sub
    Private Sub DataGrid1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGrid1.DoubleClick
        Dim frmSeiraEdit As New FrmSeiraEdit
        frmSeiraEdit.FormLoad(DataGrid1.Item(DataGrid1.CurrentRowIndex, 0))
        Call filllist()
    End Sub


End Class
