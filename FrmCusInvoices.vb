Public Class FrmCusInvoices


    
    Private Sub FillList()
        Dim SqlSelect As String
        If txtEidCod.Text = "" Then
            SqlSelect = "Select  a.Number as Αριθμός, a.CusCod as Κωδικός, " & _
        " b.CusName as Επωνυμία_Πελάτη, a.InvDate as Ημερομηνία, a.Summary as Ποσό from TableCusInvHead a" & _
        " inner join TableCustomers b on a.CusCod = b.CusCod where a.InvDate between " & _
        DateFrom.Value.ToString("yyyyMMdd") & " and " & DateTo.Value.ToString("yyyyMMdd") & _
        " and (" & CInt(txtCusCod.Text) & " = 0 or " & txtCusCod.Text & " = a.CusCod)" & _
        " order by a.InvDate, a.CusCod"
        Else
            SqlSelect = "Select  a.Number as Αριθμός, a.CusCod as Κωδικός, " & _
        " b.CusName as Επωνυμία_Πελάτη, a.InvDate as Ημερομηνία, a.Summary as Ποσό from TableCusInvHead a" & _
        " inner join TableCustomers b on a.CusCod = b.CusCod where a.InvDate between " & _
        DateFrom.Value.ToString("yyyyMMdd") & " and " & DateTo.Value.ToString("yyyyMMdd") & _
        " and exists(Select 1 from TableCusInvDet c where  c.Number = a.Number and a.Cuscod = c.Cuscod " & _
        "and c.item = " & txtEidCod.Text & _
        " and (" & CInt(txtCusCod.Text) & " = 0 or " & txtCusCod.Text & " = a.CusCod)" & _
        ") orderby a.InvDate, a.CusCod"
        End If
        Dim adapter1 As New Odbc.OdbcDataAdapter(SqlSelect, MyConnection)
        Dim Dset1 As New DataSet

        MyConnection.Open()
        Dset1.Clear()
        adapter1.Fill(Dset1)
        MyConnection.Close()
        DataGridView1.DataSource = Dset1.Tables(0)

        txtSum.Value = 0
        If txtEidCod.Text = "" Then
            Dim SqlSelect1 As String = "Select sum(Summary) as Sum from TableCusInvHead a where a.InvDate between " & _
            DateFrom.Value.ToString("yyyyMMdd") & " and " & DateTo.Value.ToString("yyyyMMdd") & _
            " and (" & CInt(txtCusCod.Text) & " = 0 or " & txtCusCod.Text & " = a.CusCod)"

            Dim adapter2 As New Odbc.OdbcDataAdapter(SqlSelect1, MyConnection)
            Dim Dset2 As New DataSet

            MyConnection.Open()
            Dset2.Clear()
            adapter2.Fill(Dset2)
            MyConnection.Close()
            If IsDBNull(Dset2.Tables(0).Rows(0).Item("Sum")) Then
                txtSum.Value = 0
            Else
                txtSum.Value = Dset2.Tables(0).Rows(0).Item("Sum")
            End If
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim frmCusInvoice As New frmCusInvoice
        frmCusInvoice.Show()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If txtCusCod.Text = "" Then
            txtCusCod.Text = 0
        End If

        Call FillList()
    End Sub


    Private Sub DataGridView1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridView1.DoubleClick
        Dim frmCusInvoice As New frmCusInvoice
        frmCusInvoice.txtCusCod.Text = DataGridView1.Item(1, DataGridView1.CurrentRow.Index).Value
        frmCusInvoice.txtNumber.Text = DataGridView1.Item(0, DataGridView1.CurrentRow.Index).Value
        frmCusInvoice.txtDate.Value = Date.ParseExact(DataGridView1.Item(3, DataGridView1.CurrentRow.Index).Value, "yyyyMMdd", System.Globalization.CultureInfo.CurrentCulture)
        frmCusInvoice.ShowDialog()
    End Sub

    Private Sub txtEidCod_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtEidCod.TextChanged
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
            Else
                txtEidDes.Text = ""
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

    Private Sub txtCusCod_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCusCod.TextChanged
        'txtNumber.Value = 0
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
                    ' txtNumber.Value = DsetN.Tables(0).Rows(0).Item("Num") + 1
                Else
                    'txtNumber.Value = 1
                End If
            Else
                txtCusName.Text = ""
            End If
        Else
            txtCusName.Text = ""
            'txtNumber.Value = 1
        End If
    End Sub

    Private Sub btnSearchCustomer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearchCustomer.Click
        Dim frmCustomerSearch As New frmCustomerSearch
        frmCustomerSearch.FormLoad(txtCusName.Text)
        frmCustomerSearch.ShowDialog()
        txtCusCod.Text = frmCustomerSearch.SelectedCustomer
    End Sub
End Class