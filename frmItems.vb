Public Class frmItems

    Private Sub txtEidCod_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtEidCod.KeyUp
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
                txtPrice.Value = Dset1.Tables(0).Rows(0).Item("EidPrice")
                txtSelPrice.Value = Dset1.Tables(0).Rows(0).Item("SelPrice")
                Me.GetLastCount()
            Else
                txtEidDes.Text = ""
                txtPrice.Value = 0
                txtSelPrice.Value = 0
            End If
        Else
            txtEidDes.Text = ""
        End If

    End Sub

    Private Sub txtEidDes_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtEidDes.KeyUp
        If e.KeyCode = Keys.Back Or e.KeyCode = Keys.Space Then
            txtEidCod.Text = ""
            txtPrice.Value = 0
            txtSelPrice.Value = 0
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
            If MyConnection.State = ConnectionState.Closed Then
                MyConnection.Open()
            End If
            Dset1.Clear()
            adapter1.Fill(Dset1)
            MyConnection.Close()

            If Dset1.Tables(0).Rows.Count > 0 Then
                txtEidCod.Text = Dset1.Tables(0).Rows(0).Item("EidCod")
                txtPrice.Value = Dset1.Tables(0).Rows(0).Item("EidPrice")
                txtEidDes.Text = Dset1.Tables(0).Rows(0).Item("EidDes")
                txtSelPrice.Value = Dset1.Tables(0).Rows(0).Item("SelPrice")
                Me.GetLastCount()
                txtEidDes.Select(Leng, txtEidDes.Text.Trim.Length - Leng)
            Else
                txtPrice.Value = 0
                txtSelPrice.Value = 0
            End If
        Else

        End If
    End Sub
    
    Private Sub btnSearchItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearchItem.Click
        Dim frmEidosSearch As New FrmEidosSearch
        frmEidosSearch.FormLoad(txtEidDes.Text)
        frmEidosSearch.ShowDialog()
        txtEidCod.Text = frmEidosSearch.SelectedEidos
    End Sub

    Private Sub GetLastCount()
        Dim SelectLastCount As String = "SELECT TableSupInvDet.Item, TableSupInvDet.Count as COUNT, TableSupInvHead.INVDATE" & _
        " FROM TableSupInvDet INNER JOIN TableSupInvHead ON (TableSupInvDet.SupCod=TableSupInvHead.SUPCOD) AND (TableSupInvDet.Number=TableSupInvHead.NUMBER) AND (TableSupInvDet.Seira=TableSupInvHead.SEIRA)" & _
        " WHERE(((TableSupInvDet.Item) = " & txtEidCod.Text & "))" & _
        " ORDER BY TableSupInvHead.INVDATE DESC;"
        Dim adapter2 As New Odbc.OdbcDataAdapter(SelectLastCount, MyConnection)
        Dim Dset2 As New DataSet
        If MyConnection.State = ConnectionState.Closed Then
            MyConnection.Open()
        End If
        Dset2.Clear()
        adapter2.Fill(Dset2)
        MyConnection.Close()

        If Dset2.Tables(0).Rows.Count > 0 Then
            txtCount.Value = Dset2.Tables(0).Rows(0).Item("Count")
            txtLastDate.Value = Date.ParseExact(Dset2.Tables(0).Rows(0).Item("INVDATE"), "yyyyMMdd", System.Globalization.CultureInfo.CurrentCulture)


        End If
    End Sub

    
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim Row As Integer
        DG.Rows.Add()
        Row = DG.RowCount - 1
        DG.Rows(Row).Cells(0).Value = txtEidCod.Text
        DG.Rows(Row).Cells(1).Value = txtEidDes.Text
        DG.Rows(Row).Cells(2).Value = txtLastDate.Value.ToString
        DG.Rows(Row).Cells(3).Value = txtCount.Value
        DG.Rows(Row).Cells(4).Value = txtPrice.Value
        DG.Rows(Row).Cells(5).Value = txtSelPrice.Value

        txtEidCod.Text = ""
        txtEidDes.Text = ""
        txtEidCod.Focus()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        DataGridToExcel(DG, "Λίστα ειδών")
    End Sub

    
End Class