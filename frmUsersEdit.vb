Public Class frmUsersEdit
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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtUserId As System.Windows.Forms.TextBox
    Friend WithEvents txtUserName As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents chkUserAdmin As System.Windows.Forms.CheckBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents btnAction As System.Windows.Forms.Button
    Friend WithEvents txtUserPass As System.Windows.Forms.TextBox
    Friend WithEvents chkDisUser As System.Windows.Forms.CheckBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.txtUserId = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtUserName = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtUserPass = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.chkUserAdmin = New System.Windows.Forms.CheckBox
        Me.Button2 = New System.Windows.Forms.Button
        Me.btnAction = New System.Windows.Forms.Button
        Me.chkDisUser = New System.Windows.Forms.CheckBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'txtUserId
        '
        Me.txtUserId.Location = New System.Drawing.Point(64, 16)
        Me.txtUserId.Name = "txtUserId"
        Me.txtUserId.ReadOnly = True
        Me.txtUserId.Size = New System.Drawing.Size(64, 20)
        Me.txtUserId.TabIndex = 42
        Me.txtUserId.Text = ""
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 23)
        Me.Label1.TabIndex = 41
        Me.Label1.Text = "Κωδικός"
        '
        'txtUserName
        '
        Me.txtUserName.Location = New System.Drawing.Point(64, 40)
        Me.txtUserName.Name = "txtUserName"
        Me.txtUserName.Size = New System.Drawing.Size(248, 20)
        Me.txtUserName.TabIndex = 44
        Me.txtUserName.Text = ""
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.Label2.Location = New System.Drawing.Point(16, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 23)
        Me.Label2.TabIndex = 43
        Me.Label2.Text = "Όνομα"
        '
        'txtUserPass
        '
        Me.txtUserPass.Location = New System.Drawing.Point(64, 64)
        Me.txtUserPass.Name = "txtUserPass"
        Me.txtUserPass.PasswordChar = Microsoft.VisualBasic.ChrW(42)
        Me.txtUserPass.Size = New System.Drawing.Size(248, 20)
        Me.txtUserPass.TabIndex = 46
        Me.txtUserPass.Text = ""
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.Label3.Location = New System.Drawing.Point(8, 64)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 23)
        Me.Label3.TabIndex = 45
        Me.Label3.Text = "Κωδικός"
        '
        'chkUserAdmin
        '
        Me.chkUserAdmin.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.chkUserAdmin.Location = New System.Drawing.Point(16, 96)
        Me.chkUserAdmin.Name = "chkUserAdmin"
        Me.chkUserAdmin.Size = New System.Drawing.Size(184, 24)
        Me.chkUserAdmin.TabIndex = 47
        Me.chkUserAdmin.Text = "Διαχειριστής Χρηστών"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(232, 160)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(88, 24)
        Me.Button2.TabIndex = 49
        Me.Button2.Text = "Έξοδος"
        '
        'btnAction
        '
        Me.btnAction.Location = New System.Drawing.Point(0, 160)
        Me.btnAction.Name = "btnAction"
        Me.btnAction.Size = New System.Drawing.Size(88, 24)
        Me.btnAction.TabIndex = 48
        Me.btnAction.Text = "Ενημέρωση"
        '
        'chkDisUser
        '
        Me.chkDisUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.chkDisUser.Location = New System.Drawing.Point(16, 120)
        Me.chkDisUser.Name = "chkDisUser"
        Me.chkDisUser.Size = New System.Drawing.Size(184, 24)
        Me.chkDisUser.TabIndex = 50
        Me.chkDisUser.Text = "Ανενεργός Χρήστης"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(113, 160)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(88, 24)
        Me.Button1.TabIndex = 51
        Me.Button1.Text = "Διαγραφή"
        '
        'frmUsersEdit
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(320, 189)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.chkDisUser)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.btnAction)
        Me.Controls.Add(Me.chkUserAdmin)
        Me.Controls.Add(Me.txtUserPass)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtUserName)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtUserId)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmUsersEdit"
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
        Dim UserAdmin As String
        Dim DisUser As String

        If chkUserAdmin.Checked = True Then
            UserAdmin = True
        Else
            UserAdmin = False
        End If

        If chkDisUser.Checked = True Then
            DisUser = True
        Else
            DisUser = False
        End If


        If Trim(txtUserName.Text) = "" Then
            MsgBox("Πρέπει να συμπληρώσεις όνομα χρήστη.", , "Error message")
            txtUserId.Focus()
            Exit Sub
        End If



        If Trim(txtUserPass.Text) = "" Then
            MsgBox("Πρέπει να συμπληρώσεις κωδικό χρήστη.", , "Error message")
            txtUserPass.Focus()
            Exit Sub
        End If




        If txtUserId.Text = "" Then
            If MyConnection.State = ConnectionState.Closed Then
                MyConnection.Open()
            End If
            sqlstring = "INSERT INTO UserTable(UserName, UserPass, UserAdmin, DisUser) VALUES('" & _
            CStr(txtUserName.Text) & "','" & CStr(txtUserPass.Text) & "'," & UserAdmin & "," & DisUser & ")"

            trans = MyConnection.BeginTransaction
            MyCommand = New Odbc.OdbcCommand(sqlstring, MyConnection, trans)
            MyCommand.CommandType = CommandType.Text
            MyCommand.ExecuteNonQuery()
            trans.Commit()
            MyConnection.Close()
            txtUserId.Text = ""
            txtUserName.Text = ""
            txtUserPass.Text = ""
            chkUserAdmin.Checked = False
        Else
            If MyConnection.State = ConnectionState.Closed Then
                MyConnection.Open()
            End If
            sqlstring = "update UserTable set " & _
             "UserName = '" & CStr(txtUserName.Text) & _
             "', UserPass ='" & CStr(txtUserPass.Text) & _
             "', UserAdmin=" & UserAdmin & _
             ", DisUser=" & DisUser & _
             "   where UserId =" & txtUserId.Text

            trans = MyConnection.BeginTransaction
            MyCommand = New Odbc.OdbcCommand(sqlstring, MyConnection, trans)
            MyCommand.CommandType = CommandType.Text
            MyCommand.ExecuteNonQuery()
            trans.Commit()
            MyConnection.Close()
            Me.Close()
        End If
    End Sub

    Public Sub FormLoad(ByVal Code As Integer)
        If Code <> 0 Then
            sqlString = "Select * from UserTable where UserId = " & Code

            Dim adapter1 As New Odbc.OdbcDataAdapter(sqlString, MyConnection)
            Dim Dset1 As New DataSet

            If MyConnection.State = ConnectionState.Closed Then
                MyConnection.Open()
            End If
            Dset1.Clear()
            adapter1.Fill(Dset1)
            MyConnection.Close()
            txtUserId.Text = CStr(Dset1.Tables(0).Rows(0).Item("UserId"))
            txtUserName.Text = CStr(Dset1.Tables(0).Rows(0).Item("UserName"))
            txtUserPass.Text = CStr(Dset1.Tables(0).Rows(0).Item("UserPass"))
            If CStr(Dset1.Tables(0).Rows(0).Item("UserAdmin")) = True Then
                chkUserAdmin.Checked = True
            Else
                chkUserAdmin.Checked = False
            End If

            If CStr(Dset1.Tables(0).Rows(0).Item("DisUser")) = True Then
                chkDisUser.Checked = True
            Else
                chkDisUser.Checked = False
            End If

            chkUserAdmin.Enabled = UserAdmin

            If UserAdmin = False Then
                Button1.Enabled = False
                chkDisUser.Enabled = False
            End If

            If UserId <> Code Then
                txtUserName.Enabled = False
                txtUserPass.Enabled = False
            End If

        End If
        Me.ShowDialog()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If MyConnection.State = ConnectionState.Closed Then
            MyConnection.Open()
        End If
        sqlString = "Delete from UserTable where UserId =" & txtUserId.Text

        trans = MyConnection.BeginTransaction
        MyCommand = New Odbc.OdbcCommand(sqlString, MyConnection, trans)
        MyCommand.CommandType = CommandType.Text
        MyCommand.ExecuteNonQuery()
        trans.Commit()
        MyConnection.Close()
        Me.Close()

    End Sub

   
    Private Sub frmUsersEdit_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If txtUserId.Text = "" Then
            Button1.Visible = False
        End If

    End Sub
End Class
