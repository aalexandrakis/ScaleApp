Public Class FrmFpaEdit
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
    Friend WithEvents txtFpaDes As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtfpaper As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents txtFpaCod As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Button2 = New System.Windows.Forms.Button
        Me.btnAction = New System.Windows.Forms.Button
        Me.txtFpaDes = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtfpaper = New System.Windows.Forms.NumericUpDown
        Me.Label1 = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.txtFpaCod = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        CType(Me.txtfpaper, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(224, 112)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(88, 24)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "Έξοδος"
        '
        'btnAction
        '
        Me.btnAction.Location = New System.Drawing.Point(8, 112)
        Me.btnAction.Name = "btnAction"
        Me.btnAction.Size = New System.Drawing.Size(88, 24)
        Me.btnAction.TabIndex = 3
        Me.btnAction.Text = "Ενημέρωση"
        '
        'txtFpaDes
        '
        Me.txtFpaDes.Location = New System.Drawing.Point(72, 40)
        Me.txtFpaDes.Name = "txtFpaDes"
        Me.txtFpaDes.Size = New System.Drawing.Size(248, 20)
        Me.txtFpaDes.TabIndex = 1
        Me.txtFpaDes.Text = ""
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.Label2.Location = New System.Drawing.Point(8, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 23)
        Me.Label2.TabIndex = 54
        Me.Label2.Text = "Περιγραφή"
        '
        'txtfpaper
        '
        Me.txtfpaper.DecimalPlaces = 2
        Me.txtfpaper.Increment = New Decimal(New Integer() {5, 0, 0, 65536})
        Me.txtfpaper.Location = New System.Drawing.Point(72, 72)
        Me.txtfpaper.Name = "txtfpaper"
        Me.txtfpaper.Size = New System.Drawing.Size(64, 20)
        Me.txtfpaper.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 72)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 23)
        Me.Label1.TabIndex = 59
        Me.Label1.Text = "Ποσοστό"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(116, 112)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(88, 24)
        Me.Button1.TabIndex = 60
        Me.Button1.Text = "Διαγραφή"
        '
        'txtFpaCod
        '
        Me.txtFpaCod.Location = New System.Drawing.Point(73, 10)
        Me.txtFpaCod.Name = "txtFpaCod"
        Me.txtFpaCod.ReadOnly = True
        Me.txtFpaCod.Size = New System.Drawing.Size(71, 20)
        Me.txtFpaCod.TabIndex = 61
        Me.txtFpaCod.Text = ""
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.Label3.Location = New System.Drawing.Point(9, 10)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 23)
        Me.Label3.TabIndex = 62
        Me.Label3.Text = "Περιγραφή"
        '
        'FrmFpaEdit
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(328, 141)
        Me.Controls.Add(Me.txtFpaCod)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtfpaper)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.btnAction)
        Me.Controls.Add(Me.txtFpaDes)
        Me.Controls.Add(Me.Label2)
        Me.Name = "FrmFpaEdit"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmFpaEdit"
        CType(Me.txtfpaper, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim sqlstring As String
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
    Private Sub btnAction_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAction.Click

        If Trim(txtFpaDes.Text) = "" Then
            MsgBox("Πρέπει να συμπληρώσεις Περιγραφή κατηγορίας.", , "Error message")
            txtFpaDes.Focus()
            Exit Sub
        End If

        If txtFpaCod.Text = "" Then
            If MyConnection.State = ConnectionState.Closed Then
                MyConnection.Open()
            End If
            sqlString = "INSERT INTO TableFpa(FpaDes, FpaPer) VALUES('" & _
            CStr(txtFpaDes.Text) & "','" & txtfpaper.Value & "')"
            trans = MyConnection.BeginTransaction
            MyCommand = New Odbc.OdbcCommand(sqlString, MyConnection, trans)
            MyCommand.CommandType = CommandType.Text
            MyCommand.ExecuteNonQuery()
            trans.Commit()
            MyConnection.Close()
            txtFpaDes.Text = ""
            txtfpaper.Value = 0

        Else

            If MyConnection.State = ConnectionState.Closed Then
                MyConnection.Open()
            End If
            sqlString = "update TableFpa set " & _
             "FpaDes = '" & CStr(txtFpaDes.Text) & _
             "', FpaPer = '" & txtfpaper.Value & _
             "'  where FpaCod =" & txtFpaCod.Text

            trans = MyConnection.BeginTransaction
            MyCommand = New Odbc.OdbcCommand(sqlString, MyConnection, trans)
            MyCommand.CommandType = CommandType.Text
            MyCommand.ExecuteNonQuery()
            trans.Commit()
            MyConnection.Close()
            Me.Close()
        End If



    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If MyConnection.State = ConnectionState.Closed Then
            MyConnection.Open()
        End If
        sqlString = "Delete from TableFpa where FpaCod =" & txtFpaCod.Text

        trans = MyConnection.BeginTransaction
        MyCommand = New Odbc.OdbcCommand(sqlString, MyConnection, trans)
        MyCommand.CommandType = CommandType.Text
        MyCommand.ExecuteNonQuery()
        trans.Commit()
        MyConnection.Close()
        Me.Close()
    End Sub


    Public Sub FormLoad(ByVal Code As Integer)

        If Code <> 0 Then
            sqlString = "Select * from TableFpa where FpaCod = " & Code

            Dim adapter1 As New Odbc.OdbcDataAdapter(sqlString, MyConnection)
            Dim Dset1 As New DataSet

            If MyConnection.State = ConnectionState.Closed Then
                MyConnection.Open()
            End If
            Dset1.Clear()
            adapter1.Fill(Dset1)
            MyConnection.Close()
            txtFpaCod.Text = CStr(Dset1.Tables(0).Rows(0).Item("FpaCod"))
            txtFpaDes.Text = CStr(Dset1.Tables(0).Rows(0).Item("FpaDes"))
            txtfpaper.Text = CStr(Dset1.Tables(0).Rows(0).Item("FpaPer"))
            MyConnection.Close()

        End If
        Me.ShowDialog()
    End Sub

    Private Sub FrmFpaEdit_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If txtFpaCod.Text = "" Then
            Button1.Visible = False
        End If

    End Sub
End Class
