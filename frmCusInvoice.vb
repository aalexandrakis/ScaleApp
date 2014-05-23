Public Class frmCusInvoice
    Dim EidPrice As Decimal
    Dim SearchByCode As Boolean
    Dim SearchByDescr As Boolean
    Private Sub txtCusCod_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCusCod.TextChanged

        txtNumber.Value = 0
        Dim SqlSelectCus As String = "Select * from TableCustomers where CusCod = " & txtCusCod.Text
        Dim adapter1 As New Odbc.OdbcDataAdapter(SqlSelectCus, MyConnection)
        Dim Dset1 As New DataSet

        If txtCusCod.Text <> "" Then
            MyConnection.Open()
            Dset1.Clear()
            adapter1.Fill(Dset1)
            MyConnection.Close()

            If Dset1.Tables(0).Rows.Count > 0 Then
                txtCusName.Text = Dset1.Tables(0).Rows(0).Item("CusName")

                Dim SqlSelectNum As String = "Select max(Number) as Num from TableCusInvHead where CusCod = " & txtCusCod.Text
                Dim adapterN As New Odbc.OdbcDataAdapter(SqlSelectNum, MyConnection)
                Dim DsetN As New DataSet
                MyConnection.Open()
                DsetN.Clear()
                adapterN.Fill(DsetN)
                MyConnection.Close()
                If DsetN.Tables(0).Rows.Count > 0 And Not IsDBNull(DsetN.Tables(0).Rows(0).Item("Num")) Then
                    txtNumber.Value = DsetN.Tables(0).Rows(0).Item("Num") + 1
                Else
                    txtNumber.Value = 1
                End If
            Else
                txtCusName.Text = ""
            End If
        Else
            txtCusName.Text = ""
            txtNumber.Value = 1
        End If
        
        Call FillList()
    End Sub

    Private Sub btnSearchCustomer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearchCustomer.Click
        Dim frmCustomerSearch As New frmCustomerSearch
        frmCustomerSearch.FormLoad(txtCusName.Text)
        frmCustomerSearch.ShowDialog()
        txtCusCod.Text = frmCustomerSearch.SelectedCustomer
    End Sub

    Private Sub txtEidCod_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtEidCod.KeyUp
        Dim SqlSelectEid As String = "Select * from TableEidos where EidCod = " & txtEidCod.Text
        Dim adapter1 As New Odbc.OdbcDataAdapter(SqlSelectEid, MyConnection)
        Dim Dset1 As New DataSet

        If txtEidCod.Text <> "" Then
            MyConnection.Open()
            Dset1.Clear()
            adapter1.Fill(Dset1)
            MyConnection.Close()

            If Dset1.Tables(0).Rows.Count > 0 Then
                txtEidDes.Text = Dset1.Tables(0).Rows(0).Item("EidDes")
                txtItemPrice.Value = Dset1.Tables(0).Rows(0).Item("EidPrice")
            Else
                txtEidDes.Text = ""
                txtItemPrice.Value = 0
            End If
        Else
            txtEidDes.Text = ""
        End If

    End Sub

    Private Sub txtItemCod_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtEidCod.TextChanged

    End Sub

    Private Sub btnSearchItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearchItem.Click
        Dim frmEidosSearch As New FrmEidosSearch
        frmEidosSearch.FormLoad(txtEidDes.Text)
        frmEidosSearch.ShowDialog()
        txtEidCod.Text = frmEidosSearch.SelectedEidos
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.txtSumPrice.Value = Me.txtItemPrice.Value * Me.txtCount.Value
    End Sub

    Private Sub btnInsert_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInsert.Click
        Me.txtSumPrice.Value = Me.txtItemPrice.Value * Me.txtCount.Value

        If txtNumber.Value = 0 Then
            MsgBox("Συμπλήρωσε αριθμό παραστατικού", MsgBoxStyle.OkOnly, "ErrorMessage")
            txtNumber.Focus()
            Exit Sub
        End If

        If txtCusCod.Text = "" Then
            MsgBox("Συμπλήρωσε Κωδικό Πελάτη", MsgBoxStyle.OkOnly, "ErrorMessage")
            txtCusCod.Focus()
            Exit Sub
        End If

        If txtEidCod.Text = "" Then
            MsgBox("Συμπλήρωσε Κωδικό Είδους", MsgBoxStyle.OkOnly, "ErrorMessage")
            txtEidCod.Focus()
            Exit Sub
        End If

        If txtCount.Value = 0 Then
            MsgBox("Συμπλήρωσε Ποσότητα", MsgBoxStyle.OkOnly, "ErrorMessage")
            txtCount.Focus()
            Exit Sub
        End If

        Dim SqlSelectD1 As String = "Select * from TableCusInvDet where  Number = " & _
                txtNumber.Text & " and CusCod = " & txtCusCod.Text & " and Item = " & CInt(txtEidCod.Text)

        Dim adapterd1 As New Odbc.OdbcDataAdapter(SqlSelectD1, MyConnection)
        Dim Dsetd1 As New DataSet

        MyConnection.Open()
        Dsetd1.Clear()
        adapterd1.Fill(Dsetd1)
        MyConnection.Close()
        If Dsetd1.Tables(0).Rows.Count > 0 Then
            'update
            Dim SqlUpdateD As String = "Update TableCusInvDet set " & _
            "Price = '" & txtItemPrice.Text & "', " & _
            "Count = '" & txtCount.Text & "', " & _
            "Poso = '" & txtSumPrice.Text & "' " & _
            "where  Number = " & _
                txtNumber.Text & " and CusCod = " & txtCusCod.Text & " and Item = " & CInt(txtEidCod.Text)
            MyConnection.Open()
            trans = MyConnection.BeginTransaction
            MyCommand = New Odbc.OdbcCommand(SqlUpdateD, MyConnection, trans)
            MyCommand.CommandType = CommandType.Text
            MyCommand.ExecuteNonQuery()
            trans.Commit()
            MyConnection.Close()

        Else
            'insert
            Dim SqlInsertD As String = "Insert into TableCusInvDet values('" & txtNumber.Text & "', '" & _
                    txtCusCod.Text & "', '" & txtEidCod.Text & "', '" & txtItemPrice.Text & "', '" & txtCount.Text & "', '" & txtSumPrice.Text & "')"

            MyConnection.Open()
            trans = MyConnection.BeginTransaction
            MyCommand = New Odbc.OdbcCommand(SqlInsertD, MyConnection, trans)
            MyCommand.CommandType = CommandType.Text
            MyCommand.ExecuteNonQuery()
            trans.Commit()
            MyConnection.Close()

        End If



        Dim SqlSelectD As String = "Select sum(Poso) as SumPos from TableCusInvDet where  Number = " & _
        txtNumber.Text & " and CusCod = " & txtCusCod.Text

        Dim adapter1 As New Odbc.OdbcDataAdapter(SqlSelectD, MyConnection)
        Dim Dset1 As New DataSet

        MyConnection.Open()
        Dset1.Clear()
        adapter1.Fill(Dset1)
        MyConnection.Close()

        Dim SumInv As Decimal
        If Dset1.Tables(0).Rows.Count > 0 Then
            SumInv = Dset1.Tables(0).Rows(0).Item("SumPos")
        Else
            SumInv = 0
        End If


        Dim SqlSelectH As String = "Select *  from TableCusInvHead where  Number = " & _
        txtNumber.Text & " and CusCod = " & txtCusCod.Text

        Dim adapter2 As New Odbc.OdbcDataAdapter(SqlSelectH, MyConnection)
        Dim Dset2 As New DataSet

        MyConnection.Open()
        Dset2.Clear()
        adapter2.Fill(Dset2)
        MyConnection.Close()

        If Dset2.Tables(0).Rows.Count = 0 Then
            'Insert
            Dim SqlInsertH As String = "Insert into TableCusInvHead values('" & txtNumber.Text & "', '" & _
                txtCusCod.Text & "', '" & txtDate.Value.ToString("yyyMMdd") & "', '" & SumInv & "')"


            MyConnection.Open()
            trans = MyConnection.BeginTransaction
            MyCommand = New Odbc.OdbcCommand(SqlInsertH, MyConnection, trans)
            MyCommand.CommandType = CommandType.Text
            MyCommand.ExecuteNonQuery()
            trans.Commit()
            MyConnection.Close()

        Else
            'Update
            Dim SqlUpdateH As String = "Update TableCusInvHead Set " & _
            "SUMMARY = '" & SumInv & _
            "', InvDate = '" & txtDate.Value.ToString("yyyMMdd") & _
            "' where  NUMBER = " & _
            CInt(txtNumber.Text) & " and CusCOD = " & CInt(txtCusCod.Text)

            MyConnection.Open()
            trans = MyConnection.BeginTransaction
            MyCommand = New Odbc.OdbcCommand(SqlUpdateH, MyConnection, trans)
            MyCommand.CommandType = CommandType.Text
            MyCommand.ExecuteNonQuery()
            trans.Commit()
            MyConnection.Close()
        End If

        
        Call FillList()
        txtEidCod.Text = ""
        txtCount.Value = 0
        txtEidCod.Focus()
    End Sub
    Private Sub FillList()
        If txtCusCod.Text = "" Then
            Exit Sub
        End If
        Dim SqlSelect As String = "Select a.item as Κωδικός, " & _
        "b.eiddes as Περιγραφή, a.Count as Ποσότητα, a.Price as Τιμή_Μονάδος, a.Poso as Τιμή " & _
        "from TableCusInvDet a inner join TableEidos b on a.Item = b.Eidcod " & _
        "where  Number = " & _
        txtNumber.Value & " and CusCod = " & txtCusCod.Text

        Dim adapter3 As New Odbc.OdbcDataAdapter(SqlSelect, MyConnection)
        Dim Dset3 As New DataSet

        MyConnection.Open()
        Dset3.Clear()
        adapter3.Fill(Dset3)
        MyConnection.Close()
        DataGridView1.DataSource = Dset3.Tables(0)

        Dim SqlSelectD As String = "Select sum(Poso) as SumPos from TableCusInvDet where  Number = " & _
                txtNumber.Text & " and CusCod = " & txtCusCod.Text

        Dim adapter1 As New Odbc.OdbcDataAdapter(SqlSelectD, MyConnection)
        Dim Dset1 As New DataSet

        MyConnection.Open()
        Dset1.Clear()
        adapter1.Fill(Dset1)
        MyConnection.Close()

        Dim SumInv As Decimal
        If Dset1.Tables(0).Rows.Count > 0 Then
            If IsDBNull(Dset1.Tables(0).Rows(0).Item("SumPos")) Then
                txtSumInv.Value = 0
            Else
                txtSumInv.Value = Dset1.Tables(0).Rows(0).Item("SumPos")
            End If

        Else
            SumInv = 0
        End If
    End Sub
    Private Sub txtSeira_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Call FillList()
    End Sub

    Private Sub txtNumber_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNumber.GotFocus
        txtNumber.Select(0, txtNumber.Text.ToString.Length)
    End Sub

    Private Sub txtNumber_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNumber.ValueChanged
        Call FillList()
    End Sub

    Private Sub btnDeleteItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDeleteItem.Click
        Dim SqlDelete As String = "Delete from TableCusInvDet where  Number = " & _
                txtNumber.Text & " and CusCod = " & txtCusCod.Text & " and Item = " & CInt(txtEidCod.Text)

        MyConnection.Open()
        trans = MyConnection.BeginTransaction
        MyCommand = New Odbc.OdbcCommand(SqlDelete, MyConnection, trans)
        MyCommand.CommandType = CommandType.Text
        MyCommand.ExecuteNonQuery()
        trans.Commit()
        MyConnection.Close()

        Dim SqlSelectD As String = "Select sum(Poso) as SumPos from TableCusInvDet where  Number = " & _
        txtNumber.Text & " and CusCod = " & txtCusCod.Text

        Dim adapter1 As New Odbc.OdbcDataAdapter(SqlSelectD, MyConnection)
        Dim Dset1 As New DataSet

        MyConnection.Open()
        Dset1.Clear()
        adapter1.Fill(Dset1)
        MyConnection.Close()
        If IsDBNull(Dset1.Tables(0).Rows(0).Item("SumPos")) Then
            txtSumInv.Value = 0
        Else
            txtSumInv.Value = Dset1.Tables(0).Rows(0).Item("SumPos")
        End If


        Dim SqlUpdateH As String = "Update TableCusInvHead Set " & _
        "SUMMARY = '" & txtSumInv.Text & _
        "' where  NUMBER = " & _
        CInt(txtNumber.Text) & " and CusCOD = " & CInt(txtCusCod.Text)

        MyConnection.Open()
        trans = MyConnection.BeginTransaction
        MyCommand = New Odbc.OdbcCommand(SqlUpdateH, MyConnection, trans)
        MyCommand.CommandType = CommandType.Text
        MyCommand.ExecuteNonQuery()
        trans.Commit()
        MyConnection.Close()

        Call FillList()
    End Sub


    Private Sub DataGridView1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridView1.DoubleClick
        txtEidCod.Text = DataGridView1.Item(0, DataGridView1.CurrentRow.Index).Value
        txtCount.Value = DataGridView1.Item(2, DataGridView1.CurrentRow.Index).Value
        txtItemPrice.Value = DataGridView1.Item(3, DataGridView1.CurrentRow.Index).Value
        txtSumPrice.Value = DataGridView1.Item(4, DataGridView1.CurrentRow.Index).Value
    End Sub

    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
        Call SupInvToExcel("", txtNumber.Value, txtCusCod.Text)
    End Sub

    Private Sub txtCount_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCount.GotFocus
        txtCount.Select(0, txtCount.Text.ToString.Length)
    End Sub

    Private Sub txtItemPrice_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtItemPrice.GotFocus
        txtItemPrice.Select(0, txtItemPrice.Text.ToString.Length)
    End Sub


    Private Sub txtEidDes_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtEidDes.KeyUp
        If e.KeyCode = Keys.Back Or e.KeyCode = Keys.Space Then
            txtEidCod.Text = ""
            txtItemPrice.Value = 0
            Exit Sub
        End If

        txtEidDes.Text.Trim()

        'MsgBox(txtEidDes.Text.Length, MsgBoxStyle.OkOnly)

        Dim Leng As Integer
        Dim SqlSelectEid As String
        If e.KeyCode = Keys.Up Then
            SqlSelectEid = "Select * from TableEidos where trim(EidDes) < '" & txtEidDes.Text.Trim & " ' ORDER BY EIDDES desc"
        ElseIf e.KeyCode = Keys.Down Then
            SqlSelectEid = "Select * from TableEidos where trim(EidDes) > '" & txtEidDes.Text.Trim & " ' ORDER BY EIDDES"
        Else
            SqlSelectEid = "Select * from TableEidos where lEFT(EidDes, " & txtEidDes.Text.Length & ") = '" & txtEidDes.Text & " ' ORDER BY EIDDES"
        End If

        Dim adapter1 As New Odbc.OdbcDataAdapter(SqlSelectEid, MyConnection)
        Dim Dset1 As New DataSet
        Leng = txtEidDes.Text.Trim.Length
        If txtEidDes.Text <> "" Then
            MyConnection.Open()
            Dset1.Clear()
            adapter1.Fill(Dset1)
            MyConnection.Close()

            If Dset1.Tables(0).Rows.Count > 0 Then
                txtEidCod.Text = Dset1.Tables(0).Rows(0).Item("EidCod")
                txtItemPrice.Value = Dset1.Tables(0).Rows(0).Item("EidPrice")
                txtEidDes.Text = Dset1.Tables(0).Rows(0).Item("EidDes")
                txtEidDes.Select(Leng, txtEidDes.Text.Trim.Length - Leng)
            Else

                txtItemPrice.Value = 0
            End If
        Else

        End If
    End Sub

    
End Class