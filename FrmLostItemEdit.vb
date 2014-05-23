Public Class FrmLostItemEdit
    Public LostCode As Integer

    Private Sub txtEidCod_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtEidCod.KeyUp
        Dim SqlSelectEid As String = "Select * from TableEidos where EidCod = " & txtEidCod.Text
        Dim adapter1 As New Odbc.OdbcDataAdapter(SqlSelectEid, MyConnection)
        Dim Dset1 As New DataSet
        If Not IsNumeric(txtEidCod.Text) And txtEidCod.Text <> "" Then
            MsgBox("Λάθος κωδικός είδους", MsgBoxStyle.OkOnly, "Error Message")
            Exit Sub
        End If

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
    Private Sub txtEidCod_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtEidCod.TextChanged
        
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
        If txtEidCod.Text = "" Then
            MsgBox("Βάλε κωδικό είδους", MsgBoxStyle.OkOnly, "Error Message")
            Exit Sub
        End If

        If txtCount.Value = 0 Then
            MsgBox("Βάλε ποσότητα", MsgBoxStyle.OkOnly, "Error Message")
            Exit Sub
        End If

        If LostCode = 0 Then
            'insert
            Dim SqlInsertD As String = "Insert into LostItems (EidCod, EidPrice, LostDate, LostCount) values('" & txtEidCod.Text & "', '" & txtItemPrice.Value & "', '" & _
                    txtLostDate.Value.ToString("yyyyMMdd") & "', '" & txtCount.Value & "')"

            MyConnection.Open()
            trans = MyConnection.BeginTransaction
            MyCommand = New Odbc.OdbcCommand(SqlInsertD, MyConnection, trans)
            MyCommand.CommandType = CommandType.Text
            MyCommand.ExecuteNonQuery()
            trans.Commit()
            MyConnection.Close()
            txtEidCod.Text = ""
            txtCount.Value = 0
            txtEidCod.Focus()

        Else
            Dim SqlUpdate As String = "Update LostItems set " & _
            " EidCod = '" & txtEidCod.Text & "', " & _
            " EidPrice = '" & txtItemPrice.Value & "', " & _
            " LostDate = '" & txtLostDate.Value.ToString("yyyyMMdd") & "', " & _
            " LostCount = '" & txtCount.Value & "' " & _
            " where Code = " & LostCode

            MyConnection.Open()
            trans = MyConnection.BeginTransaction
            MyCommand = New Odbc.OdbcCommand(SqlUpdate, MyConnection, trans)
            MyCommand.CommandType = CommandType.Text
            MyCommand.ExecuteNonQuery()
            trans.Commit()
            MyConnection.Close()
            Me.Close()
        End If

       
    End Sub

    Private Sub FrmLostItemEdit_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If LostCode <> 0 Then
            Dim SqlSelect As String = "Select * from LostItems where Code = " & LostCode
            Dim adapter2 As New Odbc.OdbcDataAdapter(SqlSelect, MyConnection)
            Dim Dset2 As New DataSet

            MyConnection.Open()
            Dset2.Clear()
            adapter2.Fill(Dset2)
            MyConnection.Close()

            If Dset2.Tables(0).Rows.Count > 0 Then
                txtEidCod.Text = Dset2.Tables(0).Rows(0).Item("EidCod")
                txtItemPrice.Value = Dset2.Tables(0).Rows(0).Item("EidPrice")
                txtCount.Text = Dset2.Tables(0).Rows(0).Item("LostCount")
                Me.txtSumPrice.Value = Me.txtItemPrice.Value * Me.txtCount.Value
                btnDelete.Enabled = True
            Else
                btnDelete.Enabled = False
            End If
        End If
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Dim SqlDelete As String = "Delete from LostItems " & _
            " where Code = " & LostCode

        MyConnection.Open()
        trans = MyConnection.BeginTransaction
        MyCommand = New Odbc.OdbcCommand(SqlDelete, MyConnection, trans)
        MyCommand.CommandType = CommandType.Text
        MyCommand.ExecuteNonQuery()
        trans.Commit()
        MyConnection.Close()
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

    Private Sub txtItemPrice_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtItemPrice.GotFocus
        txtItemPrice.Select(0, txtItemPrice.Value.ToString.Trim.Length)

    End Sub

    

    

    
    Private Sub txtCount_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCount.GotFocus
        txtCount.Select(0, txtCount.Value.ToString.Length)
    End Sub
End Class


