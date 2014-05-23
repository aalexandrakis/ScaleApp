Public Class FrmCounterEdit
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
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents btnAction As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtCouDes As System.Windows.Forms.TextBox
    Friend WithEvents txtCouCod As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Button2 = New System.Windows.Forms.Button
        Me.btnAction = New System.Windows.Forms.Button
        Me.txtCouDes = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtCouCod = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(232, 64)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(88, 24)
        Me.Button2.TabIndex = 69
        Me.Button2.Text = "Έξοδος"
        '
        'btnAction
        '
        Me.btnAction.Location = New System.Drawing.Point(8, 64)
        Me.btnAction.Name = "btnAction"
        Me.btnAction.Size = New System.Drawing.Size(88, 24)
        Me.btnAction.TabIndex = 68
        Me.btnAction.Text = "Καταχώρηση"
        '
        'txtCouDes
        '
        Me.txtCouDes.Location = New System.Drawing.Point(80, 32)
        Me.txtCouDes.Name = "txtCouDes"
        Me.txtCouDes.Size = New System.Drawing.Size(248, 20)
        Me.txtCouDes.TabIndex = 67
        Me.txtCouDes.Text = ""
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.Label2.Location = New System.Drawing.Point(8, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 23)
        Me.Label2.TabIndex = 66
        Me.Label2.Text = "Περιγραφή"
        '
        'txtCouCod
        '
        Me.txtCouCod.Location = New System.Drawing.Point(80, 8)
        Me.txtCouCod.Name = "txtCouCod"
        Me.txtCouCod.ReadOnly = True
        Me.txtCouCod.Size = New System.Drawing.Size(72, 20)
        Me.txtCouCod.TabIndex = 71
        Me.txtCouCod.Text = ""
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 23)
        Me.Label1.TabIndex = 70
        Me.Label1.Text = "Κωδικός"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(120, 64)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(88, 24)
        Me.Button1.TabIndex = 72
        Me.Button1.Text = "Διαγραφή"
        '
        'FrmCounterEdit
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(328, 93)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtCouCod)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.btnAction)
        Me.Controls.Add(Me.txtCouDes)
        Me.Controls.Add(Me.Label2)
        Me.Name = "FrmCounterEdit"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Επεξεργασία Εγγραφής"
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim sqlstring As String
    
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
    Private Sub btnAction_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAction.Click

        If Trim(txtCouDes.Text) = "" Then
            MsgBox("Πρέπει να συμπληρώσεις περιγραφή νομού.", , "Error message")
            txtCouDes.Focus()
            Exit Sub
        End If

        If txtCouCod.Text = "" Then
            If MyConnection.State = ConnectionState.Closed Then
                MyConnection.Open()
            End If
            sqlString = "INSERT INTO TableCouNTER(CouDes) VALUES('" & _
            CStr(txtCouDes.Text) & "')"

            trans = MyConnection.BeginTransaction
            MyCommand = New Odbc.OdbcCommand(sqlString, MyConnection, trans)
            MyCommand.CommandType = CommandType.Text
            MyCommand.ExecuteNonQuery()
            trans.Commit()
            MyConnection.Close()
            txtCouDes.Text = ""
        Else
            If MyConnection.State = ConnectionState.Closed Then
                MyConnection.Open()
            End If
            sqlString = "update TableCouNTER set " & _
             "CouDes = '" & CStr(txtCouDes.Text) & _
             "'  where CouCod =" & txtCouCod.Text

            trans = MyConnection.BeginTransaction
            MyCommand = New Odbc.OdbcCommand(sqlString, MyConnection, trans)
            MyCommand.CommandType = CommandType.Text
            MyCommand.ExecuteNonQuery()
            trans.Commit()
            MyConnection.Close()
            Me.Close()
        End If
    End Sub

    Public Sub FormLoad(ByVal Code As Integer)
        If Code <> 0 Then
            sqlString = "Select * from TableCouNTER where CouCod = " & Code

            Dim adapter1 As New Odbc.OdbcDataAdapter(sqlString, MyConnection)
            Dim Dset1 As New DataSet

            If MyConnection.State = ConnectionState.Closed Then
                MyConnection.Open()
            End If
            Dset1.Clear()
            adapter1.Fill(Dset1)
            'MyConnection.Close()
            txtCouCod.Text = CStr(Dset1.Tables(0).Rows(0).Item("CouCod"))
            txtCouDes.Text = CStr(Dset1.Tables(0).Rows(0).Item("CouDes"))
            MyConnection.Close()
        End If
        Me.ShowDialog()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If MyConnection.State = ConnectionState.Closed Then
            MyConnection.Open()
        End If
        sqlString = "Delete from TableCouNTER where CouCod =" & txtCouCod.Text

        trans = MyConnection.BeginTransaction
        MyCommand = New Odbc.OdbcCommand(sqlString, MyConnection, trans)
        MyCommand.CommandType = CommandType.Text
        MyCommand.ExecuteNonQuery()
        trans.Commit()
        MyConnection.Close()
        Me.Close()

    End Sub

    Private Sub FrmCounterEdit_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If txtCouCod.Text = "" Then
            Button1.Visible = False
        End If

    End Sub
End Class
