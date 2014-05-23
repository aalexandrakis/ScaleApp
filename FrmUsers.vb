Public Class FrmUsers
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
    Friend WithEvents btnNew As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnExcel As System.Windows.Forms.Button
    Friend WithEvents DataGrid1 As System.Windows.Forms.DataGrid
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.btnNew = New System.Windows.Forms.Button
        Me.btnExit = New System.Windows.Forms.Button
        Me.btnExcel = New System.Windows.Forms.Button
        Me.DataGrid1 = New System.Windows.Forms.DataGrid
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnNew
        '
        Me.btnNew.Location = New System.Drawing.Point(256, 328)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(104, 24)
        Me.btnNew.TabIndex = 13
        Me.btnNew.Text = "Νέα Καταχώρηση"
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(456, 328)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(64, 24)
        Me.btnExit.TabIndex = 12
        Me.btnExit.Text = "Έξοδος"
        '
        'btnExcel
        '
        Me.btnExcel.Location = New System.Drawing.Point(368, 328)
        Me.btnExcel.Name = "btnExcel"
        Me.btnExcel.Size = New System.Drawing.Size(80, 24)
        Me.btnExcel.TabIndex = 14
        Me.btnExcel.Text = "Excel"
        '
        'DataGrid1
        '
        Me.DataGrid1.DataMember = ""
        Me.DataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGrid1.Location = New System.Drawing.Point(8, 8)
        Me.DataGrid1.Name = "DataGrid1"
        Me.DataGrid1.ReadOnly = True
        Me.DataGrid1.Size = New System.Drawing.Size(512, 312)
        Me.DataGrid1.TabIndex = 15
        '
        'FrmUsers
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(528, 358)
        Me.Controls.Add(Me.DataGrid1)
        Me.Controls.Add(Me.btnExcel)
        Me.Controls.Add(Me.btnNew)
        Me.Controls.Add(Me.btnExit)
        Me.Name = "FrmUsers"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Χρήστες Εφαρμογής"
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim SqlSelect As String = "Select UserId as User_Id, UserName as User_Name, UserAdmin as Administrator, DisUser as Disabled from UserTable order by DisUser Desc, UserName"

    Dim adapter1 As New Odbc.OdbcDataAdapter(SqlSelect, MyConnection)
    Dim Dset1 As New DataSet

    Private Sub filllist()
        
        MyConnection.Open()
        Dset1.Clear()
        adapter1.Fill(Dset1)
        MyConnection.Close()
        DataGrid1.DataSource = Dset1.Tables(0)
    End Sub
    Private Sub frmRooms_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call filllist()
    End Sub
    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
    Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click
        If UserAdmin = False Then
            MsgBox("Δεν μπορείς να ανοίξεις νέο χρήστη ή να επεξεργαστείς έναν υπαρκτό.", , "Επεξεργασία Εγγραφής")
            Exit Sub
        End If

        Dim FrmUsersEdit As New frmUsersEdit
        FrmUsersEdit.ShowDialog()
        Call filllist()
    End Sub

    Private Sub btnExcel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcel.Click
        Call DataSetToExcel(Dset1, Me.Text)
    End Sub


    Private Sub DataGrid1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGrid1.DoubleClick
        Dim frmUsersEdit As New frmUsersEdit
        frmUsersEdit.FormLoad(DataGrid1.Item(DataGrid1.CurrentRowIndex, 0))
        Call filllist()
    End Sub
End Class
