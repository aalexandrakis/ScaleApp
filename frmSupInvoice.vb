Public Class frmSupInvoice
    Dim EidPrice As Decimal
    Dim SearchByCode As Boolean
    Dim SearchByDescr As Boolean
    Private Sub txtSupCod_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSupCod.TextChanged

        txtNumber.Value = 0
        Dim SqlSelectSup As String = "Select * from TableSuppliers where SupCod = " & txtSupCod.Text
        Dim adapter1 As New Odbc.OdbcDataAdapter(SqlSelectSup, MyConnection)
        Dim Dset1 As New DataSet

        If txtSupCod.Text <> "" Then
            If MyConnection.State = ConnectionState.Closed Then
                MyConnection.Open()
            End If
            Dset1.Clear()
            adapter1.Fill(Dset1)
            MyConnection.Close()

            If Dset1.Tables(0).Rows.Count > 0 Then
                txtSupName.Text = Dset1.Tables(0).Rows(0).Item("SupName")
            Else
                txtSupName.Text = ""
            End If
        Else
            txtSupName.Text = ""
        End If

        Call FillList()
    End Sub

    Private Sub btnSearchSupplier_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearchSupplier.Click
        Dim frmSupplierSearch As New FrmSupplierSearch
        frmSupplierSearch.FormLoad(txtSupName.Text)
        frmSupplierSearch.ShowDialog()
        txtSupCod.Text = frmSupplierSearch.SelectedSupplier
    End Sub

    Private Sub txtEidCod_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtEidCod.KeyUp
        Call GetItem()

    End Sub
    Private Sub GetItem()
        Dim SqlSelectEid As String = "Select * from TableEidos where EidCod = " & txtEidCod.Text
        Dim adapter1 As New Odbc.OdbcDataAdapter(SqlSelectEid, MyConnection)
        Dim Dset1 As New DataSet
        If Not IsNumeric(txtEidCod.Text) And txtEidCod.Text <> "" Then
            MsgBox("Λάθος κωδικός είδους", MsgBoxStyle.OkOnly, "Error Message")
            Exit Sub
        End If

        If txtEidCod.Text <> "" Then
            If MyConnection.State = ConnectionState.Closed Then
                MyConnection.Open()
            End If
            Dset1.Clear()
            adapter1.Fill(Dset1)
            MyConnection.Close()

            If Dset1.Tables(0).Rows.Count > 0 Then
                txtEidDes.Text = Dset1.Tables(0).Rows(0).Item("EidDes")
                txtItemPrice.Value = Dset1.Tables(0).Rows(0).Item("EidPrice")
                FpaPer.Value = Dset1.Tables(0).Rows(0).Item("FPA")
            Else
                txtEidDes.Text = ""
                txtItemPrice.Value = 0
            End If
        Else
            txtEidDes.Text = ""
        End If
    End Sub



    Private Sub btnSearchItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearchItem.Click
        Dim frmEidosSearch As New FrmEidosSearch
        frmEidosSearch.FormLoad(txtEidDes.Text)
        frmEidosSearch.ShowDialog()
        txtEidCod.Text = frmEidosSearch.SelectedEidos
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.txtSumPrice.Value = Me.txtItemPrice.Value * Me.txtCount.Value
        Me.txtFpa.Value = Me.txtSumPrice.Value * Me.FpaPer.Value / 100
    End Sub

    Private Sub btnInsert_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInsert.Click
        Me.txtSumPrice.Value = Me.txtItemPrice.Value * Me.txtCount.Value
        Me.txtFpa.Value = Me.txtSumPrice.Value * Me.FpaPer.Value / 100

        If txtNumber.Value = 0 Then
            MsgBox("Συμπλήρωσε αριθμό παραστατικού", MsgBoxStyle.OkOnly, "ErrorMessage")
            txtNumber.Focus()
            Exit Sub
        End If

        If txtSupCod.Text = "" Then
            MsgBox("Συμπλήρωσε Κωδικό Προμηθευτή", MsgBoxStyle.OkOnly, "ErrorMessage")
            txtSupCod.Focus()
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

        txtNumber.Enabled = False
        txtSupCod.Enabled = False
        txtSupName.Enabled = False
        btnSearchSupplier.Enabled = False

        ' Dim SqlSelectD1 As String = "Select * from TableSupInvDet where Seira = '" & txtSeira.Text & "' and Number = " & _
        '        txtNumber.Text & " and SupCod = " & txtSupCod.Text & " and Item = " & CInt(txtEidCod.Text)
        Dim SqlSelectD1 As String = "Select * from TableSupInvDet where RRN = " & aaud.Text
        Dim adapterd1 As New Odbc.OdbcDataAdapter(SqlSelectD1, MyConnection)
        Dim Dsetd1 As New DataSet

        If MyConnection.State = ConnectionState.Closed Then
            MyConnection.Open()
        End If
        Dsetd1.Clear()
        adapterd1.Fill(Dsetd1)
        MyConnection.Close()
        If Dsetd1.Tables(0).Rows.Count > 0 Then
            'update
            Dim SqlUpdateD As String = "Update TableSupInvDet set " & _
            "Price = '" & txtItemPrice.Text & "', " & _
            "Count = '" & txtCount.Text & "', " & _
            "Poso = '" & txtSumPrice.Text & "', " & _
            "fpa = '" & txtFpa.Value & "' " & _
            "where RRN =" & aaud.Text
            ' "where Seira = '" & txtSeira.Text & "' and Number = " & _
            '     txtNumber.Text & " and SupCod = " & txtSupCod.Text & " and Item = " & CInt(txtEidCod.Text)
            If MyConnection.State = ConnectionState.Closed Then
                MyConnection.Open()
            End If
            trans = MyConnection.BeginTransaction
            MyCommand = New Odbc.OdbcCommand(SqlUpdateD, MyConnection, trans)
            MyCommand.CommandType = CommandType.Text
            MyCommand.ExecuteNonQuery()
            trans.Commit()
            MyConnection.Close()
            aaud.Value = 0

        Else
            'insert
            Dim SqlInsertD As String = "Insert into TableSupInvDet(Seira, [Number], SupCod, Item, Price, Count, Poso, FPA) values('" & txtSeira.Text & "', '" & txtNumber.Text & "', '" & _
                    txtSupCod.Text & "', '" & txtEidCod.Text & "', '" & txtItemPrice.Text & "', '" & txtCount.Text & "', '" & txtSumPrice.Text & "', '" & txtFpa.Value & "')"

            If MyConnection.State = ConnectionState.Closed Then
                MyConnection.Open()
            End If
            trans = MyConnection.BeginTransaction
            MyCommand = New Odbc.OdbcCommand(SqlInsertD, MyConnection, trans)
            MyCommand.CommandType = CommandType.Text
            MyCommand.ExecuteNonQuery()
            trans.Commit()
            MyConnection.Close()

        End If



        Dim SqlSelectD As String = "Select sum(Poso) as SumPos, SUM(FPA) AS SUMFPA from TableSupInvDet where Seira = '" & txtSeira.Text & "' and Number = " & _
        txtNumber.Text & " and SupCod = " & txtSupCod.Text

        Dim adapter1 As New Odbc.OdbcDataAdapter(SqlSelectD, MyConnection)
        Dim Dset1 As New DataSet

        If MyConnection.State = ConnectionState.Closed Then
            MyConnection.Open()
        End If
        Dset1.Clear()
        adapter1.Fill(Dset1)
        MyConnection.Close()

        Dim SumInv As Decimal
        Dim SUMFPA As Decimal
        If Dset1.Tables(0).Rows.Count > 0 Then
            SumInv = Dset1.Tables(0).Rows(0).Item("SumPos")
            SUMFPA = Dset1.Tables(0).Rows(0).Item("SUMFPA")
        Else
            SumInv = 0
            SUMFPA = 0
        End If


        Dim SqlSelectH As String = "Select *  from TableSupInvHead where Seira = '" & txtSeira.Text & "' and Number = " & _
        txtNumber.Text & " and SupCod = " & txtSupCod.Text

        Dim adapter2 As New Odbc.OdbcDataAdapter(SqlSelectH, MyConnection)
        Dim Dset2 As New DataSet

        If MyConnection.State = ConnectionState.Closed Then
            MyConnection.Open()
        End If
        Dset2.Clear()
        adapter2.Fill(Dset2)
        MyConnection.Close()

        If Dset2.Tables(0).Rows.Count = 0 Then
            'Insert
            Dim SqlInsertH As String = "Insert into TableSupInvHead values('" & txtSeira.Text & "', '" & txtNumber.Text & "', '" & _
                txtSupCod.Text & "', '" & txtDate.Value.ToString("yyyMMdd") & "', '" & SumInv & "', '" & SUMFPA & "')"


            If MyConnection.State = ConnectionState.Closed Then
                MyConnection.Open()
            End If
            trans = MyConnection.BeginTransaction
            MyCommand = New Odbc.OdbcCommand(SqlInsertH, MyConnection, trans)
            MyCommand.CommandType = CommandType.Text
            MyCommand.ExecuteNonQuery()
            trans.Commit()
            MyConnection.Close()

        Else
            'Update
            Dim SqlUpdateH As String = "Update TableSupInvHead Set " & _
            "SUMMARY = '" & SumInv & _
            "',FPA = '" & SUMFPA & _
            "', InvDate = '" & txtDate.Value.ToString("yyyMMdd") & _
            "' where SEIRA = '" & txtSeira.Text & "' and NUMBER = " & _
            CInt(txtNumber.Text) & " and SUPCOD = " & CInt(txtSupCod.Text)

            If MyConnection.State = ConnectionState.Closed Then
                MyConnection.Open()
            End If
            trans = MyConnection.BeginTransaction
            MyCommand = New Odbc.OdbcCommand(SqlUpdateH, MyConnection, trans)
            MyCommand.CommandType = CommandType.Text
            MyCommand.ExecuteNonQuery()
            trans.Commit()
            MyConnection.Close()
        End If

        Dim SqlUpdateI As String = "Update TableEidos Set " & _
            "EidPrice = '" & txtItemPrice.Value & _
            "', Display = 'Yes'" & _
            " where EidCod = " & CInt(txtEidCod.Text)

        If MyConnection.State = ConnectionState.Closed Then
            MyConnection.Open()
        End If
        trans = MyConnection.BeginTransaction
        MyCommand = New Odbc.OdbcCommand(SqlUpdateI, MyConnection, trans)
        MyCommand.CommandType = CommandType.Text
        MyCommand.ExecuteNonQuery()
        trans.Commit()
        MyConnection.Close()

        Call FillList()
        txtEidCod.Text = ""
        txtCount.Value = 0
        txtEidCod.Focus()
    End Sub
    Private Sub FillList()
        If txtSupCod.Text = "" Then
            Exit Sub
        End If
        Dim SqlSelect As String = "Select a.RRN as ΑΑ, a.item as Κωδικός, " & _
        "b.eiddes as Περιγραφή, a.Count as Ποσότητα, a.Price as Τιμή_Μονάδος, a.Poso as Τιμή, a.FPA as ΦΠΑ " & _
        "from TableSupInvDet a inner join TableEidos b on a.Item = b.Eidcod " & _
        "where Seira = '" & txtSeira.Text & "' and Number = " & _
        txtNumber.Value & " and SupCod = " & txtSupCod.Text

        Dim adapter3 As New Odbc.OdbcDataAdapter(SqlSelect, MyConnection)
        Dim Dset3 As New DataSet

        If MyConnection.State = ConnectionState.Closed Then
            MyConnection.Open()
        End If
        Dset3.Clear()
        adapter3.Fill(Dset3)
        MyConnection.Close()
        DataGridView1.DataSource = Dset3.Tables(0)

        Dim SqlSelectD As String = "Select sum(Poso) as SumPos, SUM(FPA) AS SUMFPA from TableSupInvDet where Seira = '" & txtSeira.Text & "' and Number = " & _
                txtNumber.Text & " and SupCod = " & txtSupCod.Text

        Dim adapter1 As New Odbc.OdbcDataAdapter(SqlSelectD, MyConnection)
        Dim Dset1 As New DataSet

        If MyConnection.State = ConnectionState.Closed Then
            MyConnection.Open()
        End If
        Dset1.Clear()
        adapter1.Fill(Dset1)
        MyConnection.Close()

        Dim SumInv As Decimal
        Dim SUMFPA As Decimal

        If Dset1.Tables(0).Rows.Count > 0 Then
            If IsDBNull(Dset1.Tables(0).Rows(0).Item("SumPos")) Then
                txtSumInv.Value = 0
                txtsumFpa.Value = 0
            Else
                txtSumInv.Value = Dset1.Tables(0).Rows(0).Item("SumPos")
                txtsumFpa.Value = Dset1.Tables(0).Rows(0).Item("sumfpa")
            End If

        Else
            SumInv = 0
            SUMFPA = 0

        End If
        txtSum.Value = txtSumInv.Value + txtsumFpa.Value
    End Sub
    Private Sub txtSeira_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSeira.TextChanged
        Call FillList()
    End Sub

    Private Sub txtNumber_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNumber.GotFocus
        txtNumber.Select(0, txtNumber.Text.ToString.Length)
    End Sub

    Private Sub txtNumber_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNumber.ValueChanged
        Call FillList()
    End Sub

    Private Sub btnDeleteItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDeleteItem.Click
        ' Dim SqlDelete As String = "Delete from TableSupInvDet where Seira = '" & txtSeira.Text & "' and Number = " & _
        '        txtNumber.Text & " and SupCod = " & txtSupCod.Text & " and Item = " & CInt(txtEidCod.Text)
        Dim SqlDelete As String = "Delete from TableSupInvDet where RRN = " & aaud.Text


        If MyConnection.State = ConnectionState.Closed Then
            MyConnection.Open()
        End If
        trans = MyConnection.BeginTransaction
        MyCommand = New Odbc.OdbcCommand(SqlDelete, MyConnection, trans)
        MyCommand.CommandType = CommandType.Text
        MyCommand.ExecuteNonQuery()
        trans.Commit()
        MyConnection.Close()

        Dim SqlSelectD As String = "Select sum(Poso) as SumPos, sum(FPA) as SumFpa from TableSupInvDet where Seira = '" & txtSeira.Text & "' and Number = " & _
        txtNumber.Text & " and SupCod = " & txtSupCod.Text

        Dim adapter1 As New Odbc.OdbcDataAdapter(SqlSelectD, MyConnection)
        Dim Dset1 As New DataSet

        If MyConnection.State = ConnectionState.Closed Then
            MyConnection.Open()
        End If
        Dset1.Clear()
        adapter1.Fill(Dset1)
        MyConnection.Close()
        If IsDBNull(Dset1.Tables(0).Rows(0).Item("SUMPOS")) Then
            txtSumInv.Value = 0
            txtsumFpa.Value = 0

            Dim SqlDeleteH As String = "DeletE from  TableSupInvHead " & _
            " where SEIRA = '" & txtSeira.Text & "' and NUMBER = " & _
            CInt(txtNumber.Text) & " and SUPCOD = " & CInt(txtSupCod.Text) & _
            " and invdate = " & txtDate.Value.ToString("yyyMMdd")

            If MyConnection.State = ConnectionState.Closed Then
                MyConnection.Open()
            End If
            trans = MyConnection.BeginTransaction
            MyCommand = New Odbc.OdbcCommand(SqlDeleteH, MyConnection, trans)
            MyCommand.CommandType = CommandType.Text
            MyCommand.ExecuteNonQuery()
            trans.Commit()
            MyConnection.Close()

        Else
            txtSumInv.Value = Dset1.Tables(0).Rows(0).Item("SumPos")
            txtsumFpa.Value = Dset1.Tables(0).Rows(0).Item("SumFpa")

            Dim SqlUpdateH As String = "Update TableSupInvHead Set " & _
            "SUMMARY = '" & txtSumInv.Text & _
            "', FPA = '" & txtsumFpa.Text & _
            "' where SEIRA = '" & txtSeira.Text & "' and NUMBER = " & _
            CInt(txtNumber.Text) & " and SUPCOD = " & CInt(txtSupCod.Text) & _
            " and invdate = " & txtDate.Value.ToString("yyyMMdd")

            If MyConnection.State = ConnectionState.Closed Then
                MyConnection.Open()
            End If
            trans = MyConnection.BeginTransaction
            MyCommand = New Odbc.OdbcCommand(SqlUpdateH, MyConnection, trans)
            MyCommand.CommandType = CommandType.Text
            MyCommand.ExecuteNonQuery()
            trans.Commit()
            MyConnection.Close()
        End If



        Call FillList()
    End Sub


    Private Sub DataGridView1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridView1.DoubleClick
        aaud.Value = DataGridView1.Item(0, DataGridView1.CurrentRow.Index).Value
        txtEidCod.Text = DataGridView1.Item(1, DataGridView1.CurrentRow.Index).Value
        Call GetItem()
        txtCount.Value = DataGridView1.Item(3, DataGridView1.CurrentRow.Index).Value
        txtItemPrice.Value = DataGridView1.Item(4, DataGridView1.CurrentRow.Index).Value
        txtSumPrice.Value = DataGridView1.Item(5, DataGridView1.CurrentRow.Index).Value
        txtFpa.Value = DataGridView1.Item(6, DataGridView1.CurrentRow.Index).Value
    End Sub

    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
        Call SupInvToExcel(txtSeira.Text, txtNumber.Value, txtSupCod.Text)
    End Sub

    Private Sub txtCount_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCount.GotFocus
        txtCount.Select(0, txtCount.Text.ToString.Length)
    End Sub

    Private Sub txtItemPrice_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtItemPrice.GotFocus
        txtItemPrice.Select(0, txtItemPrice.Text.ToString.Length)
    End Sub

    Private Sub frmSupInvoice_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
    Private Sub txtEidDes_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtEidDes.KeyUp
        If e.KeyCode = Keys.Back Or e.KeyCode = Keys.Space Then
            txtEidCod.Text = ""
            txtItemPrice.Value = 0
            Exit Sub
        End If
        txtEidDes.Text.Trim()

        Dim SqlSelectEid As String
        Dim Leng As Integer
        'MsgBox(txtEidDes.Text.Length, MsgBoxStyle.OkOnly)

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
            If MyConnection.State = ConnectionState.Closed Then
                MyConnection.Open()
            End If
            Dset1.Clear()
            adapter1.Fill(Dset1)
            MyConnection.Close()

            If Dset1.Tables(0).Rows.Count > 0 Then
                txtEidCod.Text = Dset1.Tables(0).Rows(0).Item("EidCod")
                txtItemPrice.Value = Dset1.Tables(0).Rows(0).Item("EidPrice")
                txtEidDes.Text = Dset1.Tables(0).Rows(0).Item("EidDes")
                FpaPer.Value = Dset1.Tables(0).Rows(0).Item("FPA")
                txtEidDes.Select(Leng, txtEidDes.Text.Trim.Length - Leng)
            Else

                txtItemPrice.Value = 0
            End If
        Else

        End If
    End Sub





    Private Sub txtEidCod_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtEidCod.TextChanged

    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub btnDeleteAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDeleteAll.Click

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim i As Integer
        For i = 0 To DataGridView1.Rows.Count - 1
            Dim SqlUpdateD As String = "Update TableRem set " & _
                        "Rem = Rem + '" & DataGridView1.Item(3, i).Value & "' " & _
                        " where ItemCode  =" & DataGridView1.Item(1, i).Value
            If MyConnection.State = ConnectionState.Closed Then
                MyConnection.Open()
            End If
            trans = MyConnection.BeginTransaction
            MyCommand = New Odbc.OdbcCommand(SqlUpdateD, MyConnection, trans)
            MyCommand.CommandType = CommandType.Text
            MyCommand.ExecuteNonQuery()
            trans.Commit()
            MyConnection.Close()
            
        Next
        txtNumber.Value = 0
        txtSupCod.Text = ""
        txtNumber.Enabled = True
        txtSupCod.Enabled = True
        txtSupName.Enabled = True
        btnSearchSupplier.Enabled = True
        txtSupCod.Focus()

    End Sub
End Class