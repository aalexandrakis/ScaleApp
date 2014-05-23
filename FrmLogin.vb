Public Class FrmLogin
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
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cbxUser As System.Windows.Forms.ComboBox
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents btnLogin As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label
        Me.cbxUser = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtPassword = New System.Windows.Forms.TextBox
        Me.btnLogin = New System.Windows.Forms.Button
        Me.btnCancel = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.Label1.Location = New System.Drawing.Point(9, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Χρήστης"
        '
        'cbxUser
        '
        Me.cbxUser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxUser.Location = New System.Drawing.Point(72, 24)
        Me.cbxUser.Name = "cbxUser"
        Me.cbxUser.Size = New System.Drawing.Size(296, 21)
        Me.cbxUser.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.Label2.Location = New System.Drawing.Point(8, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Κωδικός"
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(72, 56)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(168, 20)
        Me.txtPassword.TabIndex = 3
        Me.txtPassword.Text = ""
        '
        'btnLogin
        '
        Me.btnLogin.Location = New System.Drawing.Point(8, 96)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(88, 24)
        Me.btnLogin.TabIndex = 4
        Me.btnLogin.Text = "Log In"
        '
        'btnCancel
        '
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Location = New System.Drawing.Point(280, 96)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(88, 24)
        Me.btnCancel.TabIndex = 5
        Me.btnCancel.Text = "Cancel"
        '
        'FrmLogin
        '
        Me.AcceptButton = Me.btnLogin
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(376, 126)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnLogin)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cbxUser)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FrmLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Εισαγωγή στην εφαρμογή"
        Me.ResumeLayout(False)

    End Sub

#End Region


    Private Sub FrmLogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call filllist()
    End Sub



    Private Sub filllist()
        'Dim REC As Integer
        Dim ROW As Integer = 0
        Dim SqlSelect As String = "Select * from UserTable WHERE DisUser=False order by UserName"

        Dim adapter1 As New Odbc.OdbcDataAdapter(SqlSelect, MyConnection)
        Dim Dset1 As New DataSet

        MyConnection.Open()
        Dset1.Clear()
        adapter1.Fill(Dset1)
        MyConnection.Close()
        cbxUser.Items.Clear()

        cbxUser.DataSource = Dset1.Tables(0)
        cbxUser.DisplayMember = "UserName"
        cbxUser.ValueMember = "UserId"

    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogin.Click
        If cbxUser.SelectedIndex = -1 Then
            MsgBox("Δεν έχεις διαλέξει χρήστη.", , "Log In")
            Exit Sub
        End If

        If Trim(txtPassword.Text) = "" Then
            MsgBox("Βάλε κωδικό.", , "Log In")
            Exit Sub
        End If

        UserId = cbxUser.SelectedValue


        Dim SqlSelect As String = "Select * from UserTable where UserId=" & UserId & "and UserPass='" & Trim(txtPassword.Text) & "'"
        Dim adapter1 As New Odbc.OdbcDataAdapter(SqlSelect, MyConnection)
        Dim Dset1 As New DataSet

        MyConnection.Open()
        Dset1.Clear()
        adapter1.Fill(Dset1)
        MyConnection.Close()

        If Dset1.Tables(0).Rows.Count = 0 Then
            MsgBox("Λάθος κωδικός.", , "Log In")
            Exit Sub
        Else
            UserName = Dset1.Tables(0).Rows(0).Item("UserName")
            UserAdmin = Dset1.Tables(0).Rows(0).Item("UserAdmin")
            Me.Hide()
            Dim frmMain As New frmMain
            frmMain.ShowDialog()
            Me.Close()
        End If
    End Sub
End Class
