Public Class FrmEidosEdit
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
    Friend WithEvents txtEidPrice As System.Windows.Forms.NumericUpDown
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents btnAction As System.Windows.Forms.Button
    Friend WithEvents txtEidDes As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtEidCod As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cbxCounterType As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtPerL As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtPerX As System.Windows.Forms.NumericUpDown
    Friend WithEvents cbxItemCat As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtSelPrice As System.Windows.Forms.NumericUpDown
    Friend WithEvents chkDsp As System.Windows.Forms.CheckBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents FPAnm As System.Windows.Forms.NumericUpDown
    Friend WithEvents Button1 As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtEidPrice = New System.Windows.Forms.NumericUpDown
        Me.Button2 = New System.Windows.Forms.Button
        Me.btnAction = New System.Windows.Forms.Button
        Me.txtEidDes = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtEidCod = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.cbxCounterType = New System.Windows.Forms.ComboBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtPerL = New System.Windows.Forms.NumericUpDown
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtPerX = New System.Windows.Forms.NumericUpDown
        Me.cbxItemCat = New System.Windows.Forms.ComboBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.txtSelPrice = New System.Windows.Forms.NumericUpDown
        Me.chkDsp = New System.Windows.Forms.CheckBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.FPAnm = New System.Windows.Forms.NumericUpDown
        CType(Me.txtEidPrice, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPerL, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPerX, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSelPrice, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FPAnm, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 72)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 23)
        Me.Label1.TabIndex = 65
        Me.Label1.Text = "Τιμή αγοράς"
        '
        'txtEidPrice
        '
        Me.txtEidPrice.DecimalPlaces = 2
        Me.txtEidPrice.Increment = New Decimal(New Integer() {5, 0, 0, 65536})
        Me.txtEidPrice.Location = New System.Drawing.Point(104, 72)
        Me.txtEidPrice.Name = "txtEidPrice"
        Me.txtEidPrice.Size = New System.Drawing.Size(72, 20)
        Me.txtEidPrice.TabIndex = 3
        Me.txtEidPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(227, 278)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(88, 24)
        Me.Button2.TabIndex = 11
        Me.Button2.Text = "Έξοδος"
        '
        'btnAction
        '
        Me.btnAction.Location = New System.Drawing.Point(11, 279)
        Me.btnAction.Name = "btnAction"
        Me.btnAction.Size = New System.Drawing.Size(88, 24)
        Me.btnAction.TabIndex = 9
        Me.btnAction.Text = "Ενημέρωση"
        '
        'txtEidDes
        '
        Me.txtEidDes.Location = New System.Drawing.Point(104, 40)
        Me.txtEidDes.Name = "txtEidDes"
        Me.txtEidDes.Size = New System.Drawing.Size(248, 20)
        Me.txtEidDes.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.Label2.Location = New System.Drawing.Point(8, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 23)
        Me.Label2.TabIndex = 64
        Me.Label2.Text = "Περιγραφή"
        '
        'txtEidCod
        '
        Me.txtEidCod.Enabled = False
        Me.txtEidCod.Location = New System.Drawing.Point(104, 8)
        Me.txtEidCod.Name = "txtEidCod"
        Me.txtEidCod.Size = New System.Drawing.Size(248, 20)
        Me.txtEidCod.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.Label3.Location = New System.Drawing.Point(8, 8)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 23)
        Me.Label3.TabIndex = 67
        Me.Label3.Text = "Κωδικός"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(117, 278)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(88, 24)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "Διαγραφή"
        '
        'cbxCounterType
        '
        Me.cbxCounterType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxCounterType.Location = New System.Drawing.Point(104, 203)
        Me.cbxCounterType.Name = "cbxCounterType"
        Me.cbxCounterType.Size = New System.Drawing.Size(224, 21)
        Me.cbxCounterType.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.Label4.Location = New System.Drawing.Point(7, 204)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 16)
        Me.Label4.TabIndex = 69
        Me.Label4.Text = "Μον.Μετ."
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.Label5.Location = New System.Drawing.Point(8, 98)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(90, 23)
        Me.Label5.TabIndex = 71
        Me.Label5.Text = "Κέρδος Λιαν."
        '
        'txtPerL
        '
        Me.txtPerL.DecimalPlaces = 2
        Me.txtPerL.Increment = New Decimal(New Integer() {5, 0, 0, 65536})
        Me.txtPerL.Location = New System.Drawing.Point(104, 98)
        Me.txtPerL.Name = "txtPerL"
        Me.txtPerL.Size = New System.Drawing.Size(72, 20)
        Me.txtPerL.TabIndex = 4
        Me.txtPerL.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.Label6.Location = New System.Drawing.Point(8, 124)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(90, 23)
        Me.Label6.TabIndex = 73
        Me.Label6.Text = "Κέρδος Χονδ."
        '
        'txtPerX
        '
        Me.txtPerX.DecimalPlaces = 2
        Me.txtPerX.Increment = New Decimal(New Integer() {5, 0, 0, 65536})
        Me.txtPerX.Location = New System.Drawing.Point(104, 124)
        Me.txtPerX.Name = "txtPerX"
        Me.txtPerX.Size = New System.Drawing.Size(72, 20)
        Me.txtPerX.TabIndex = 5
        Me.txtPerX.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'cbxItemCat
        '
        Me.cbxItemCat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxItemCat.Location = New System.Drawing.Point(104, 232)
        Me.cbxItemCat.Name = "cbxItemCat"
        Me.cbxItemCat.Size = New System.Drawing.Size(224, 21)
        Me.cbxItemCat.TabIndex = 8
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.Label7.Location = New System.Drawing.Point(7, 233)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(80, 20)
        Me.Label7.TabIndex = 75
        Me.Label7.Text = "Κατηγορία"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.Label8.Location = New System.Drawing.Point(8, 147)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(90, 23)
        Me.Label8.TabIndex = 77
        Me.Label8.Text = "Τιμή Πώλησης"
        '
        'txtSelPrice
        '
        Me.txtSelPrice.DecimalPlaces = 2
        Me.txtSelPrice.Increment = New Decimal(New Integer() {5, 0, 0, 65536})
        Me.txtSelPrice.Location = New System.Drawing.Point(104, 147)
        Me.txtSelPrice.Name = "txtSelPrice"
        Me.txtSelPrice.Size = New System.Drawing.Size(72, 20)
        Me.txtSelPrice.TabIndex = 6
        Me.txtSelPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'chkDsp
        '
        Me.chkDsp.AutoSize = True
        Me.chkDsp.Checked = True
        Me.chkDsp.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkDsp.Location = New System.Drawing.Point(104, 255)
        Me.chkDsp.Name = "chkDsp"
        Me.chkDsp.Size = New System.Drawing.Size(191, 17)
        Me.chkDsp.TabIndex = 78
        Me.chkDsp.Text = "Απόκρυψη από τον τιμοκατάλογο"
        Me.chkDsp.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.Label9.Location = New System.Drawing.Point(8, 173)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(90, 23)
        Me.Label9.TabIndex = 80
        Me.Label9.Text = "ΦΠΑ"
        '
        'FPAnm
        '
        Me.FPAnm.DecimalPlaces = 2
        Me.FPAnm.Increment = New Decimal(New Integer() {5, 0, 0, 65536})
        Me.FPAnm.Location = New System.Drawing.Point(104, 173)
        Me.FPAnm.Name = "FPAnm"
        Me.FPAnm.Size = New System.Drawing.Size(72, 20)
        Me.FPAnm.TabIndex = 79
        Me.FPAnm.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'FrmEidosEdit
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(359, 342)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.FPAnm)
        Me.Controls.Add(Me.chkDsp)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtSelPrice)
        Me.Controls.Add(Me.cbxItemCat)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtPerX)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtPerL)
        Me.Controls.Add(Me.cbxCounterType)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtEidCod)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtEidPrice)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.btnAction)
        Me.Controls.Add(Me.txtEidDes)
        Me.Controls.Add(Me.Label2)
        Me.Name = "FrmEidosEdit"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Επεξεργασία Εγγραφής"
        CType(Me.txtEidPrice, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPerL, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPerX, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSelPrice, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FPAnm, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region
    Dim EidCod As String = ""
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
    Private Sub btnAction_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAction.Click
        Dim Display As String
        If Trim(txtEidDes.Text) = "" Then
            MsgBox("Πρέπει να συμπληρώσεις Περιγραφή κατηγορίας.", , "Error message")
            txtEidDes.Focus()
            Exit Sub
        End If
        If chkDsp.Checked Then
            Display = "No"
        Else
            Display = "Yes"
        End If

        If EidCod = "" Then
            If MyConnection.State = ConnectionState.Closed Then
                MyConnection.Open()
            End If
            sqlstringm = "INSERT INTO TableEidos(EidDes, EidPrice, CouCod, PerL, PerX, CodCat, SelPrice, FPA) VALUES('" & _
            CStr(txtEidDes.Text) & "','" & txtEidPrice.Value & "','" & cbxCounterType.SelectedValue & _
         "','" & txtPerL.Value & "','" & txtPerX.Value & "','" & cbxItemCat.SelectedValue & "','" & txtSelPrice.Value & "','" & FPAnm.Value & "')"

            trans = MyConnection.BeginTransaction
            MyCommand = New Odbc.OdbcCommand(sqlstringm, MyConnection, trans)
            MyCommand.CommandType = CommandType.Text
            MyCommand.ExecuteNonQuery()
            trans.Commit()
            MyConnection.Close()
            txtEidCod.Text = ""
            txtEidDes.Text = ""
            txtEidPrice.Value = 0

            Dim sqlString As String = "Select Max(EidCod) from TableEidos"
            Dim adapter1 As New Odbc.OdbcDataAdapter(sqlString, MyConnection)
            Dim Dset1 As New DataSet
            If MyConnection.State = ConnectionState.Closed Then
                MyConnection.Open()
            End If
            Dset1.Clear()
            adapter1.Fill(Dset1)
            MyConnection.Close()

            sqlString = "Insert into TableRem Values(" & Dset1.Tables(0).Rows(0).Item(0) & ", 0, 0)"
            If MyConnection.State = ConnectionState.Closed Then
                MyConnection.Open()
            End If
            trans = MyConnection.BeginTransaction
            MyCommand = New Odbc.OdbcCommand(sqlString, MyConnection, trans)
            MyCommand.CommandType = CommandType.Text
            MyCommand.ExecuteNonQuery()
            trans.Commit()
            MyConnection.Close()
        Else
            If MyConnection.State = ConnectionState.Closed Then
                MyConnection.Open()
            End If
            sqlstringm = "update TableEidos set " & _
             "EidDes = '" & CStr(txtEidDes.Text) & _
             "', EidPrice = '" & txtEidPrice.Value & _
             "', CouCod = '" & cbxCounterType.SelectedValue & _
             "', PerL = '" & txtPerL.Value & _
             "', PerX = '" & txtPerX.Value & _
             "', CodCat = '" & cbxItemCat.SelectedValue & _
             "', SelPrice = '" & txtSelPrice.Value & _
             "', Display = '" & Display & _
            "', FPA = '" & FPAnm.Value & _
            "'  where EidCod =" & txtEidCod.Text

            trans = MyConnection.BeginTransaction
            MyCommand = New Odbc.OdbcCommand(sqlstringm, MyConnection, trans)
            MyCommand.CommandType = CommandType.Text
            MyCommand.ExecuteNonQuery()
            trans.Commit()
            MyConnection.Close()
            Me.Close()
        End If
    End Sub

    Public Sub FormLoad(ByVal Code As String)
        FillComboBox(cbxCounterType, "TableCounter", "CouCod", "CouDes", "CouDes")
        cbxCounterType.SelectedIndex = 0

        FillComboBox(cbxItemCat, "TableItemCat", "CodCat", "DesCat", "DesCat")
        cbxItemCat.SelectedIndex = 0

        If Code <> "" Then
            sqlstringm = "Select * from TableEidos where EidCod = " & Code

            Dim adapter1 As New Odbc.OdbcDataAdapter(sqlstringm, MyConnection)
            Dim Dset1 As New DataSet

            If MyConnection.State = ConnectionState.Closed Then
                MyConnection.Open()
            End If
            Dset1.Clear()
            adapter1.Fill(Dset1)
            MyConnection.Close()
            txtEidCod.Text = CStr(Dset1.Tables(0).Rows(0).Item("EidCod"))
            txtEidDes.Text = CStr(Dset1.Tables(0).Rows(0).Item("EidDes"))
            txtEidPrice.Text = CStr(Dset1.Tables(0).Rows(0).Item("EidPrice"))
            cbxCounterType.SelectedValue = Dset1.Tables(0).Rows(0).Item("CouCod")
            txtPerL.Text = CStr(Dset1.Tables(0).Rows(0).Item("PerL"))
            txtPerX.Text = CStr(Dset1.Tables(0).Rows(0).Item("PerX"))
            cbxItemCat.SelectedValue = Dset1.Tables(0).Rows(0).Item("CodCat")
            txtSelPrice.Text = CStr(Dset1.Tables(0).Rows(0).Item("SelPrice"))
            FPAnm.Value = CStr(Dset1.Tables(0).Rows(0).Item("FPA"))
        End If
        EidCod = Code
        Me.ShowDialog()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If MyConnection.State = ConnectionState.Closed Then
            MyConnection.Open()
        End If
        sqlstringM = "Delete from TableEidos where EidCod =" & txtEidCod.Text

        trans = MyConnection.BeginTransaction
        MyCommand = New Odbc.OdbcCommand(sqlstringM, MyConnection, trans)
        MyCommand.CommandType = CommandType.Text
        MyCommand.ExecuteNonQuery()
        trans.Commit()
        MyConnection.Close()

        Me.Close()

    End Sub


    Private Sub FrmEidosEdit_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        txtEidPrice.Enabled = UserAdmin
        txtPerX.Enabled = UserAdmin
        txtPerL.Enabled = UserAdmin
        Button1.Enabled = UserAdmin
        
        If EidCod = "" Then
            '===================================================================================================
            FillComboBox(cbxCounterType, "TableCounter", "CouCod", "CouDes", "CouDes")
            cbxCounterType.SelectedIndex = 0
            '===================================================================================================
            FillComboBox(cbxItemCat, "TableItemCat", "CodCat", "DesCat", "DesCat")
            cbxItemCat.SelectedIndex = 0
            '===================================================================================================

            '===================================================================================================
            Button1.Visible = False
        End If

    End Sub

    
    
    
End Class
