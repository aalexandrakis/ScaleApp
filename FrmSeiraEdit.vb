Public Class FrmSeiraEdit
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
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtSeiraNum As System.Windows.Forms.NumericUpDown
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents btnAction As System.Windows.Forms.Button
    Friend WithEvents txtSeiraDes As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtSeiraId As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Button1 = New System.Windows.Forms.Button
        Me.txtSeiraId = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtSeiraNum = New System.Windows.Forms.NumericUpDown
        Me.Button2 = New System.Windows.Forms.Button
        Me.btnAction = New System.Windows.Forms.Button
        Me.txtSeiraDes = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        CType(Me.txtSeiraNum, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(112, 112)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(88, 24)
        Me.Button1.TabIndex = 77
        Me.Button1.Text = "Διαγραφή"
        '
        'txtSeiraId
        '
        Me.txtSeiraId.Location = New System.Drawing.Point(72, 8)
        Me.txtSeiraId.MaxLength = 2
        Me.txtSeiraId.Name = "txtSeiraId"
        Me.txtSeiraId.Size = New System.Drawing.Size(40, 20)
        Me.txtSeiraId.TabIndex = 69
        Me.txtSeiraId.Text = ""
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.Label3.Location = New System.Drawing.Point(8, 8)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 23)
        Me.Label3.TabIndex = 76
        Me.Label3.Text = "Σειρά"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 72)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 23)
        Me.Label1.TabIndex = 75
        Me.Label1.Text = "Ποσοστό"
        '
        'txtSeiraNum
        '
        Me.txtSeiraNum.Location = New System.Drawing.Point(72, 72)
        Me.txtSeiraNum.Maximum = New Decimal(New Integer() {99999999, 0, 0, 0})
        Me.txtSeiraNum.Name = "txtSeiraNum"
        Me.txtSeiraNum.Size = New System.Drawing.Size(88, 20)
        Me.txtSeiraNum.TabIndex = 71
        Me.txtSeiraNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(224, 112)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(88, 24)
        Me.Button2.TabIndex = 73
        Me.Button2.Text = "Έξοδος"
        '
        'btnAction
        '
        Me.btnAction.Location = New System.Drawing.Point(8, 112)
        Me.btnAction.Name = "btnAction"
        Me.btnAction.Size = New System.Drawing.Size(88, 24)
        Me.btnAction.TabIndex = 72
        Me.btnAction.Text = "Ενημέρωση"
        '
        'txtSeiraDes
        '
        Me.txtSeiraDes.Location = New System.Drawing.Point(72, 40)
        Me.txtSeiraDes.MaxLength = 50
        Me.txtSeiraDes.Name = "txtSeiraDes"
        Me.txtSeiraDes.Size = New System.Drawing.Size(248, 20)
        Me.txtSeiraDes.TabIndex = 70
        Me.txtSeiraDes.Text = ""
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.Label2.Location = New System.Drawing.Point(8, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 23)
        Me.Label2.TabIndex = 74
        Me.Label2.Text = "Περιγραφή"
        '
        'FrmSeiraEdit
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(328, 148)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtSeiraId)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtSeiraNum)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.btnAction)
        Me.Controls.Add(Me.txtSeiraDes)
        Me.Controls.Add(Me.Label2)
        Me.Name = "FrmSeiraEdit"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Επεξεργασία Εγγραφής"
        CType(Me.txtSeiraNum, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim sqlstring As String
    Dim SeiraId As String = ""
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
    Private Sub btnAction_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAction.Click

        If Trim(txtSeiraDes.Text) = "" Then
            MsgBox("Πρέπει να συμπληρώσεις Περιγραφή κατηγορίας.", , "Error message")
            txtSeiraDes.Focus()
            Exit Sub
        End If

        If SeiraId = "" Then
            sqlString = "Select * from TableSeira where SeiraId = '" & Trim(txtSeiraId.Text) & "'"
            Dim adapter1 As New Odbc.OdbcDataAdapter(sqlString, MyConnection)
            Dim Dset1 As New DataSet
            If MyConnection.State = ConnectionState.Closed Then
                MyConnection.Open()
            End If
            Dset1.Clear()
            adapter1.Fill(Dset1)
            MyConnection.Close()

            If Dset1.Tables(0).Rows.Count > 0 Then
                MsgBox("Η σειρά που έβαλες υπάρχει.", , "Error message")
                txtSeiraId.Focus()
                Exit Sub
            End If

        End If

        If SeiraId = "" Then
            If MyConnection.State = ConnectionState.Closed Then
                MyConnection.Open()
            End If
            sqlString = "INSERT INTO TableSeira(SeiraId, SeiraDes, SeiraNum) VALUES('" & _
            Trim(txtSeiraId.Text) & "','" & CStr(txtSeiraDes.Text) & "','" & txtSeiraNum.Value & "')"

            trans = MyConnection.BeginTransaction
            MyCommand = New Odbc.OdbcCommand(sqlString, MyConnection, trans)
            MyCommand.CommandType = CommandType.Text
            MyCommand.ExecuteNonQuery()
            trans.Commit()
            MyConnection.Close()
            txtSeiraId.Text = ""
            txtSeiraDes.Text = ""
            txtSeiraNum.Value = 0
        Else
            If MyConnection.State = ConnectionState.Closed Then
                MyConnection.Open()
            End If
            sqlString = "update TableSeira set " & _
             "SeiraDes = '" & CStr(txtSeiraDes.Text) & _
             "', SeiraNum = '" & txtSeiraNum.Value & _
             "'  where SeiraId ='" & txtSeiraId.Text & "'"

            trans = MyConnection.BeginTransaction
            MyCommand = New Odbc.OdbcCommand(sqlString, MyConnection, trans)
            MyCommand.CommandType = CommandType.Text
            MyCommand.ExecuteNonQuery()
            trans.Commit()
            MyConnection.Close()
            Me.Close()
        End If
    End Sub

    Public Sub FormLoad(ByVal Code As String)
        If Code <> "" Then
            sqlString = "Select * from TableSeira where SeiraId = '" & Code & "'"

            Dim adapter1 As New Odbc.OdbcDataAdapter(sqlString, MyConnection)
            Dim Dset1 As New DataSet

            If MyConnection.State = ConnectionState.Closed Then
                MyConnection.Open()
            End If
            Dset1.Clear()
            adapter1.Fill(Dset1)
            MyConnection.Close()
            txtSeiraId.Text = CStr(Dset1.Tables(0).Rows(0).Item("SeiraId"))
            txtSeiraDes.Text = CStr(Dset1.Tables(0).Rows(0).Item("SeiraDes"))
            txtSeiraNum.Text = CStr(Dset1.Tables(0).Rows(0).Item("SeiraNum"))
            txtSeiraId.Enabled = False
        End If
        SeiraId = Code
        Me.ShowDialog()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If MyConnection.State = ConnectionState.Closed Then
            MyConnection.Open()
        End If
        sqlString = "Delete from TableSeira where SeiraId ='" & txtSeiraId.Text & "'"

        trans = MyConnection.BeginTransaction
        MyCommand = New Odbc.OdbcCommand(sqlString, MyConnection, trans)
        MyCommand.CommandType = CommandType.Text
        MyCommand.ExecuteNonQuery()
        trans.Commit()
        MyConnection.Close()
        Me.Close()

    End Sub
    Private Sub FrmSeiraEdit_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If SeiraId = "" Then
            Button1.Visible = False
        End If
    End Sub
End Class
