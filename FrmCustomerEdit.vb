Public Class FrmCustomerEdit
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
    Friend WithEvents txtCusCod As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtCusName As System.Windows.Forms.TextBox
    Friend WithEvents txtCusAddress As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtCusZipCod As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cbxNomos As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cbxCity As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cbxDimos As System.Windows.Forms.ComboBox
    Friend WithEvents txtCusAcN As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents cbxEpa As System.Windows.Forms.ComboBox
    Friend WithEvents txtCusEml As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents cbxCatCCod As System.Windows.Forms.ComboBox
    Friend WithEvents chlCusSubFpa As System.Windows.Forms.CheckBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents txtCusAfm As System.Windows.Forms.TextBox
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents txtCusPhone As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Button9 As System.Windows.Forms.Button
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents cbxFpa As System.Windows.Forms.ComboBox
    Friend WithEvents Button8 As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtCusCod = New System.Windows.Forms.TextBox
        Me.txtCusName = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtCusAddress = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtCusZipCod = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.cbxNomos = New System.Windows.Forms.ComboBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.cbxCity = New System.Windows.Forms.ComboBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.cbxDimos = New System.Windows.Forms.ComboBox
        Me.txtCusAcN = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.cbxEpa = New System.Windows.Forms.ComboBox
        Me.txtCusEml = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.cbxCatCCod = New System.Windows.Forms.ComboBox
        Me.chlCusSubFpa = New System.Windows.Forms.CheckBox
        Me.txtCusAfm = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        Me.Button4 = New System.Windows.Forms.Button
        Me.Button5 = New System.Windows.Forms.Button
        Me.Button6 = New System.Windows.Forms.Button
        Me.Button7 = New System.Windows.Forms.Button
        Me.Button8 = New System.Windows.Forms.Button
        Me.txtCusPhone = New System.Windows.Forms.TextBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.Button9 = New System.Windows.Forms.Button
        Me.Label14 = New System.Windows.Forms.Label
        Me.cbxFpa = New System.Windows.Forms.ComboBox
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(8, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(152, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Κωδικός"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtCusCod
        '
        Me.txtCusCod.Location = New System.Drawing.Point(176, 5)
        Me.txtCusCod.Name = "txtCusCod"
        Me.txtCusCod.ReadOnly = True
        Me.txtCusCod.Size = New System.Drawing.Size(64, 20)
        Me.txtCusCod.TabIndex = 1
        Me.txtCusCod.TabStop = False
        '
        'txtCusName
        '
        Me.txtCusName.Location = New System.Drawing.Point(176, 32)
        Me.txtCusName.MaxLength = 100
        Me.txtCusName.Name = "txtCusName"
        Me.txtCusName.Size = New System.Drawing.Size(272, 20)
        Me.txtCusName.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(8, 33)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(152, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Επωνμία"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtCusAddress
        '
        Me.txtCusAddress.Location = New System.Drawing.Point(176, 80)
        Me.txtCusAddress.MaxLength = 50
        Me.txtCusAddress.Name = "txtCusAddress"
        Me.txtCusAddress.Size = New System.Drawing.Size(272, 20)
        Me.txtCusAddress.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(8, 80)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(152, 16)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Διεύθυνση"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtCusZipCod
        '
        Me.txtCusZipCod.Location = New System.Drawing.Point(176, 131)
        Me.txtCusZipCod.MaxLength = 10
        Me.txtCusZipCod.Name = "txtCusZipCod"
        Me.txtCusZipCod.Size = New System.Drawing.Size(72, 20)
        Me.txtCusZipCod.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(8, 131)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(152, 16)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Ταχ. Κωδ."
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cbxNomos
        '
        Me.cbxNomos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxNomos.Location = New System.Drawing.Point(176, 155)
        Me.cbxNomos.Name = "cbxNomos"
        Me.cbxNomos.Size = New System.Drawing.Size(272, 21)
        Me.cbxNomos.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(8, 155)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(152, 16)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Νομός"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(8, 179)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(152, 16)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Πόλη"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cbxCity
        '
        Me.cbxCity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxCity.Location = New System.Drawing.Point(176, 179)
        Me.cbxCity.Name = "cbxCity"
        Me.cbxCity.Size = New System.Drawing.Size(272, 21)
        Me.cbxCity.TabIndex = 9
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(8, 203)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(152, 16)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Δήμος"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cbxDimos
        '
        Me.cbxDimos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxDimos.Location = New System.Drawing.Point(176, 203)
        Me.cbxDimos.Name = "cbxDimos"
        Me.cbxDimos.Size = New System.Drawing.Size(272, 21)
        Me.cbxDimos.TabIndex = 11
        '
        'txtCusAcN
        '
        Me.txtCusAcN.Location = New System.Drawing.Point(176, 227)
        Me.txtCusAcN.MaxLength = 100
        Me.txtCusAcN.Name = "txtCusAcN"
        Me.txtCusAcN.Size = New System.Drawing.Size(272, 20)
        Me.txtCusAcN.TabIndex = 13
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(8, 227)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(152, 16)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Οικονομικός Υπεύθυνος"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(8, 251)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(152, 16)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "Επάγγελμα"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cbxEpa
        '
        Me.cbxEpa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxEpa.Location = New System.Drawing.Point(176, 251)
        Me.cbxEpa.Name = "cbxEpa"
        Me.cbxEpa.Size = New System.Drawing.Size(272, 21)
        Me.cbxEpa.TabIndex = 14
        '
        'txtCusEml
        '
        Me.txtCusEml.Location = New System.Drawing.Point(176, 275)
        Me.txtCusEml.MaxLength = 50
        Me.txtCusEml.Name = "txtCusEml"
        Me.txtCusEml.Size = New System.Drawing.Size(272, 20)
        Me.txtCusEml.TabIndex = 16
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(8, 275)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(152, 16)
        Me.Label10.TabIndex = 18
        Me.Label10.Text = "E-mail"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label11
        '
        Me.Label11.Location = New System.Drawing.Point(8, 299)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(152, 16)
        Me.Label11.TabIndex = 21
        Me.Label11.Text = "Κατηγορία Πελάτη"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cbxCatCCod
        '
        Me.cbxCatCCod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxCatCCod.Location = New System.Drawing.Point(176, 299)
        Me.cbxCatCCod.Name = "cbxCatCCod"
        Me.cbxCatCCod.Size = New System.Drawing.Size(272, 21)
        Me.cbxCatCCod.TabIndex = 17
        '
        'chlCusSubFpa
        '
        Me.chlCusSubFpa.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chlCusSubFpa.Location = New System.Drawing.Point(8, 351)
        Me.chlCusSubFpa.Name = "chlCusSubFpa"
        Me.chlCusSubFpa.Size = New System.Drawing.Size(184, 16)
        Me.chlCusSubFpa.TabIndex = 21
        Me.chlCusSubFpa.Text = "Μειωμένος ΦΠΑ                                                          "
        Me.chlCusSubFpa.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtCusAfm
        '
        Me.txtCusAfm.Location = New System.Drawing.Point(176, 56)
        Me.txtCusAfm.MaxLength = 9
        Me.txtCusAfm.Name = "txtCusAfm"
        Me.txtCusAfm.Size = New System.Drawing.Size(96, 20)
        Me.txtCusAfm.TabIndex = 3
        '
        'Label12
        '
        Me.Label12.Location = New System.Drawing.Point(8, 56)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(152, 16)
        Me.Label12.TabIndex = 23
        Me.Label12.Text = "ΑΦΜ"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 406)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(88, 24)
        Me.Button1.TabIndex = 22
        Me.Button1.Text = "Ενημέρωση "
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(228, 406)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(88, 24)
        Me.Button2.TabIndex = 23
        Me.Button2.Text = "Διαγραφή"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(468, 406)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(88, 24)
        Me.Button3.TabIndex = 24
        Me.Button3.Text = "’κυρο"
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(448, 155)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(104, 20)
        Me.Button4.TabIndex = 8
        Me.Button4.Text = "Νέα καταχώρηση"
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(448, 179)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(104, 20)
        Me.Button5.TabIndex = 10
        Me.Button5.Text = "Νέα καταχώρηση"
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(448, 203)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(104, 20)
        Me.Button6.TabIndex = 12
        Me.Button6.Text = "Νέα καταχώρηση"
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(448, 251)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(104, 20)
        Me.Button7.TabIndex = 15
        Me.Button7.Text = "Νέα καταχώρηση"
        '
        'Button8
        '
        Me.Button8.Location = New System.Drawing.Point(448, 299)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(104, 20)
        Me.Button8.TabIndex = 18
        Me.Button8.Text = "Νέα καταχώρηση"
        '
        'txtCusPhone
        '
        Me.txtCusPhone.Location = New System.Drawing.Point(177, 106)
        Me.txtCusPhone.MaxLength = 50
        Me.txtCusPhone.Name = "txtCusPhone"
        Me.txtCusPhone.Size = New System.Drawing.Size(272, 20)
        Me.txtCusPhone.TabIndex = 5
        '
        'Label13
        '
        Me.Label13.Location = New System.Drawing.Point(9, 106)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(152, 16)
        Me.Label13.TabIndex = 32
        Me.Label13.Text = "Τηλέφωνο"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Button9
        '
        Me.Button9.Location = New System.Drawing.Point(447, 325)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(104, 20)
        Me.Button9.TabIndex = 20
        Me.Button9.Text = "Νέα καταχώρηση"
        '
        'Label14
        '
        Me.Label14.Location = New System.Drawing.Point(7, 325)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(152, 16)
        Me.Label14.TabIndex = 35
        Me.Label14.Text = "Φ.Π.Α."
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cbxFpa
        '
        Me.cbxFpa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxFpa.Location = New System.Drawing.Point(175, 325)
        Me.cbxFpa.Name = "cbxFpa"
        Me.cbxFpa.Size = New System.Drawing.Size(272, 21)
        Me.cbxFpa.TabIndex = 19
        '
        'FrmCustomerEdit
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(576, 442)
        Me.Controls.Add(Me.Button9)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.cbxFpa)
        Me.Controls.Add(Me.txtCusPhone)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtCusAfm)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.chlCusSubFpa)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.cbxCatCCod)
        Me.Controls.Add(Me.txtCusEml)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.cbxEpa)
        Me.Controls.Add(Me.txtCusAcN)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.cbxDimos)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cbxCity)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cbxNomos)
        Me.Controls.Add(Me.txtCusZipCod)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtCusAddress)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtCusName)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtCusCod)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FrmCustomerEdit"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Επεξεργσία Πελάτη"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Dim sqlstring As String
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If txtCusCod.Text = "" Then
            If MyConnection.State = ConnectionState.Closed Then
                MyConnection.Open()
            End If
            sqlstring = "INSERT INTO TableCustomers(CusName,CusAfm,CusAddress,CusPhone,CusZipCod,NomCod,CitCod,DimCod,CusAcN,EpaCod,CusEml,CatCCod,CusFpa,CusSubFpa) VALUES('" & _
            Trim(txtCusName.Text) & "','" & Trim(txtCusAfm.Text) & "','" & Trim(txtCusAddress.Text) & "','" & Trim(txtCusPhone.Text) & "','" & Trim(txtCusZipCod.Text) & "','" & _
            cbxNomos.SelectedValue & "','" & cbxCity.SelectedValue & "','" & cbxDimos.SelectedValue & "','" & _
            Trim(txtCusAcN.Text) & "','" & cbxEpa.SelectedValue & "','" & txtCusEml.Text & "','" & cbxCatCCod.SelectedValue & "','" & cbxFpa.SelectedValue & "','" & _
            chlCusSubFpa.CheckState & "')"

            trans = MyConnection.BeginTransaction
            MyCommand = New Odbc.OdbcCommand(sqlString, MyConnection, trans)
            MyCommand.CommandType = CommandType.Text
            MyCommand.ExecuteNonQuery()
            trans.Commit()
            MyConnection.Close()
            Call ClearForm()
        Else
            If MyConnection.State = ConnectionState.Closed Then
                MyConnection.Open()
            End If
            sqlString = "Update TableCustomers set " & _
            "CusName='" & Trim(txtCusName.Text) & "'," & _
            "CusAfm='" & Trim(txtCusAfm.Text) & "'," & _
            "CusAddress='" & Trim(txtCusAddress.Text) & "'," & _
            "CusPhone='" & Trim(txtCusPhone.Text) & "'," & _
            "CusZipCod='" & Trim(txtCusZipCod.Text) & "'," & _
            "NomCod='" & cbxNomos.SelectedValue & "'," & _
            "CitCod='" & cbxCity.SelectedValue & "'," & _
            "DimCod='" & cbxDimos.SelectedValue & "'," & _
            "CusAcN='" & Trim(txtCusAcN.Text) & "'," & _
            "EpaCod='" & cbxEpa.SelectedValue & "'," & _
            "CusEml='" & txtCusEml.Text & "'," & _
            "CatCCod='" & cbxCatCCod.SelectedValue & "'," & _
            "CusSubFpa='" & chlCusSubFpa.CheckState & "'," & _
            "CusFpa='" & cbxFpa.SelectedValue & "'" & _
            " where CusCod=" & txtCusCod.Text

            trans = MyConnection.BeginTransaction
            MyCommand = New Odbc.OdbcCommand(sqlString, MyConnection, trans)
            MyCommand.CommandType = CommandType.Text
            MyCommand.ExecuteNonQuery()
            trans.Commit()
            MyConnection.Close()
            Me.Close()

        End If
    End Sub

    Private Sub ClearForm()

        cbxNomos.Refresh()
        cbxCity.Refresh()
        cbxDimos.Refresh()
        cbxEpa.Refresh()
        cbxCatCCod.Refresh()
        cbxFpa.Refresh()

        txtCusCod.Text = ""
        txtCusAfm.Text = ""
        txtCusAddress.Text = ""
        txtCusPhone.Text = ""
        txtCusZipCod.Text = ""
        txtCusAcN.Text = ""
        txtCusEml.Text = ""
        chlCusSubFpa.Checked = False
    End Sub

    Public Sub LoadForm(ByVal CusCod As Integer)
        FillComboBox(cbxNomos, "TableNomoi", "NomCod", "NomDes", "NomDes")
        FillComboBox(cbxCity, "TableCities", "CitCod", "CitDes", "CitDes")
        FillComboBox(cbxDimos, "TableDimoi", "DimCod", "DimDes", "DimDes")
        FillComboBox(cbxEpa, "TableEpa", "EpaCod", "EpaDes", "EpaDes")
        FillComboBox(cbxCatCCod, "TableCatCus", "CatCCod", "CatCDes", "CatCDes")
        FillComboBox(cbxFpa, "TableFpa", "FpaCod", "FpaDes", "FpaDes")
        'Call ClearForm()
        txtCusCod.Text = CusCod

        If CusCod > 0 Then
            Dim sqlString As String = "Select * from TableCustomers where CusCod=" & CusCod
            Dim adapter1 As New Odbc.OdbcDataAdapter(sqlString, MyConnection)
            Dim Dset1 As New DataSet

            If MyConnection.State = ConnectionState.Closed Then
                MyConnection.Open()
            End If
            Dset1.Clear()
            adapter1.Fill(Dset1)
            MyConnection.Close()
            If Dset1.Tables(0).Rows.Count > 0 Then
                txtCusName.Text = Dset1.Tables(0).Rows(0).Item("CusName")
                txtCusAfm.Text = Dset1.Tables(0).Rows(0).Item("CusAfm")
                txtCusAddress.Text = Dset1.Tables(0).Rows(0).Item("CusAddress")
                txtCusPhone.Text = Dset1.Tables(0).Rows(0).Item("CusPhone")
                txtCusZipCod.Text = Dset1.Tables(0).Rows(0).Item("CusZipCod")
                cbxNomos.SelectedValue = Dset1.Tables(0).Rows(0).Item("NomCod")
                cbxCity.SelectedValue = Dset1.Tables(0).Rows(0).Item("CitCod")
                cbxDimos.SelectedValue = Dset1.Tables(0).Rows(0).Item("DimCod")
                txtCusAcN.Text = Dset1.Tables(0).Rows(0).Item("CusAcN")
                cbxEpa.SelectedValue = Dset1.Tables(0).Rows(0).Item("EpaCod")
                txtCusEml.Text = Dset1.Tables(0).Rows(0).Item("CusEml")
                cbxCatCCod.SelectedValue = Dset1.Tables(0).Rows(0).Item("CatCCod")
                cbxFpa.SelectedValue = Dset1.Tables(0).Rows(0).Item("CusFpa")
                chlCusSubFpa.Checked = CBool(Dset1.Tables(0).Rows(0).Item("CusSubFpa"))
                Me.Refresh()
            End If
        End If
        Me.ShowDialog()
    End Sub

    Private Sub FrmCustomerEdit_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        If txtCusCod.Text = "" Then
            FillComboBox(cbxNomos, "TableNomoi", "NomCod", "NomDes", "NomDes")
            FillComboBox(cbxCity, "TableCities", "CitCod", "CitDes", "CitDes")
            FillComboBox(cbxDimos, "TableDimoi", "DimCod", "DimDes", "DimDes")
            FillComboBox(cbxEpa, "TableEpa", "EpaCod", "EpaDes", "EpaDes")
            FillComboBox(cbxCatCCod, "TableCatCus", "CatCCod", "CatCDes", "CatCDes")
            FillComboBox(cbxFpa, "TableFpa", "FpaCod", "FpaDes", "FpaDes")


            cbxDimos.SelectedValue = GetDefaultValue("TableDimoi")
            cbxEpa.SelectedValue = GetDefaultValue("TableEpa")
            cbxCatCCod.SelectedValue = GetDefaultValue("TableCatCus")
            cbxFpa.SelectedValue = GetDefaultValue("TableFpa")

            Button2.Visible = False
        End If

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        If MsgBox("Να γίνει Διαγραφή του πελάτη;", MsgBoxStyle.OkCancel, "Επιβεβαίωση διαγραφής") = MsgBoxResult.Ok Then
            sqlString = "Delete * from TableCustomers where CusCod=" & txtCusCod.Text

            If MyConnection.State = ConnectionState.Closed Then
                MyConnection.Open()
            End If
            trans = MyConnection.BeginTransaction
            MyCommand = New Odbc.OdbcCommand(sqlString, MyConnection, trans)
            MyCommand.CommandType = CommandType.Text
            MyCommand.ExecuteNonQuery()
            trans.Commit()
            MyConnection.Close()
            Me.Close()
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Dim FrmNomoiEdit As New FrmNomoiEdit
        FrmNomoiEdit.ShowDialog()
        FillComboBox(cbxNomos, "TableNomoi", "NomCod", "NomDes", "NomDes")
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Dim FrmPoleisEdit As New FrmPoleisEdit
        FrmPoleisEdit.ShowDialog()
        FillComboBox(cbxCity, "TableCities", "CitCod", "CitDes", "CitDes")
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Dim FrmDimoiEdit As New FrmDimoiEdit
        FrmDimoiEdit.ShowDialog()
        FillComboBox(cbxDimos, "TableDimoi", "DimCod", "DimDes", "DimDes")
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Dim FrmEpaEdit As New FrmEpaEdit
        FrmEpaEdit.ShowDialog()
        FillComboBox(cbxEpa, "TableEpa", "EpaCod", "EpaDes", "EpaDes")
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        Dim FrmCatCustEdit As New FrmCatCustEdit
        FrmCatCustEdit.ShowDialog()
        FillComboBox(cbxCatCCod, "TableCatCus", "CatCCod", "CatCDes", "CatCDes")
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        Dim FrmFpaEdit As New FrmFpaEdit
        FrmFpaEdit.ShowDialog()
        FillComboBox(cbxFpa, "TableFpa", "FpaCod", "FpaDes", "FpaDes")
    End Sub

    Private Sub cbxFpa_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbxFpa.SelectedIndexChanged

    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        cbxFpa.SelectedValue = 2
    End Sub

    Private Function GetDefaultValue(ByVal Table As String) As Integer
        Dim sqlString As String = "Select * from " & Table & " where Default = True"
        Dim adapter1 As New Odbc.OdbcDataAdapter(sqlString, MyConnection)
        Dim Dset1 As New DataSet

        If MyConnection.State = ConnectionState.Closed Then
            MyConnection.Open()
        End If
        Dset1.Clear()
        adapter1.Fill(Dset1)
        MyConnection.Close()
        If Dset1.Tables(0).Rows.Count > 0 Then
            Return Dset1.Tables(0).Rows(0).Item(0)
        Else
            Return 0
        End If
    End Function
End Class
