Public Class FrmSupInvoices

   
    
    Private Sub FillList()
        Dim SqlSelect As String
        Dim SupCod As Integer
        If txtSupCod.Text = "" Then
            SupCod = 0
        Else
            SupCod = txtSupCod.Text
        End If


        If txtEidCod.Text = "" Then
            SqlSelect = "Select a.seira as Σειρά, a.Number as Αριθμός, a.SupCod as Κωδικός, " & _
        " b.SupName as Επωνυμία_Προμηθευτή, a.InvDate as Ημερομηνία, a.Summary as Ποσό, a.fpa as ΦΠΑ, a.summary + a.fpa as Συνολο from TableSupInvHead a" & _
        " inner join TableSuppliers b on a.SupCod = b.SupCod where a.InvDate between " & _
        DateFrom.Value.ToString("yyyyMMdd") & " and " & DateTo.Value.ToString("yyyyMMdd") & _
        " and (" & SupCod & " = 0 or " & SupCod & " = a.SupCod ) " & _
        " order by a.InvDate, a.supCod"
        Else
            SqlSelect = "Select a.seira as Σειρά, a.Number as Αριθμός, a.SupCod as Κωδικός, " & _
        " b.SupName as Επωνυμία_Προμηθευτή, a.InvDate as Ημερομηνία, a.Summary as Ποσό, a.fpa as ΦΠΑ, a.summary + a.fpa as Συνολο from TableSupInvHead a" & _
        " inner join TableSuppliers b on a.SupCod = b.SupCod where a.InvDate between " & _
        DateFrom.Value.ToString("yyyyMMdd") & " and " & DateTo.Value.ToString("yyyyMMdd") & _
        " and exists(Select 1 from TableSupInvDet c where c.Seira = a.Seira and c.Number = a.Number and a.supcod = c.supcod " & _
        "and c.item = " & txtEidCod.Text & _
        " and (" & SupCod & " = 0 or " & SupCod & " = a.SupCod ) " & _
        ") order by a.InvDate, a.supCod"
        End If
        Dim adapter1 As New Odbc.OdbcDataAdapter(SqlSelect, MyConnection)
        Dim Dset1 As New DataSet

        If MyConnection.State = ConnectionState.Closed Then
            MyConnection.Open()
        End If
        Dset1.Clear()
        adapter1.Fill(Dset1)
        MyConnection.Close()
        DataGridView1.DataSource = Dset1.Tables(0)

        Dim i As Integer
        txtSum.Value = 0
        For i = 1 To DataGridView1.Rows.Count
            txtSum.Value += DataGridView1.Rows(i - 1).Cells(7).Value
        Next

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim frmSupInvoice As New frmSupInvoice
        frmSupInvoice.Show()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Call FillList()
    End Sub

    
    Private Sub DataGridView1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridView1.DoubleClick
        Dim frmSupInvoice As New frmSupInvoice
        frmSupInvoice.txtSupCod.Text = DataGridView1.Item(2, DataGridView1.CurrentRow.Index).Value
        frmSupInvoice.txtSeira.Text = DataGridView1.Item(0, DataGridView1.CurrentRow.Index).Value
        frmSupInvoice.txtNumber.Text = DataGridView1.Item(1, DataGridView1.CurrentRow.Index).Value
        frmSupInvoice.txtDate.Value = Date.ParseExact(DataGridView1.Item(4, DataGridView1.CurrentRow.Index).Value, "yyyyMMdd", System.Globalization.CultureInfo.CurrentCulture)
        frmSupInvoice.ShowDialog()
    End Sub

    Private Sub txtEidCod_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtEidCod.TextChanged
        Dim SqlSelectEid As String = "Select * from TableEidos where EidCod = " & txtEidCod.Text
        Dim adapter1 As New Odbc.OdbcDataAdapter(SqlSelectEid, MyConnection)
        Dim Dset1 As New DataSet

        If txtEidCod.Text <> "" Then
            If MyConnection.State = ConnectionState.Closed Then
                MyConnection.Open()
            End If
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

    Private Sub txtSupCod_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSupCod.TextChanged

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
    End Sub

    Private Sub btnSearchSupplier_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearchSupplier.Click
        Dim frmSupplierSearch As New FrmSupplierSearch
        frmSupplierSearch.FormLoad(txtSupName.Text)
        frmSupplierSearch.ShowDialog()
        txtSupCod.Text = frmSupplierSearch.SelectedSupplier
    End Sub
End Class