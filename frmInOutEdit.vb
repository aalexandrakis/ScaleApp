Public Class frmInOutEdit

    Private Sub txtDescri_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtDescri.KeyUp
        Dim SqlSelectDes As String

        If e.KeyCode = Keys.Back Or e.KeyCode = Keys.Space Then
            Exit Sub
        End If
        txtDescri.Text.Trim()

        Dim Leng As Integer
       
        If e.KeyCode = Keys.Up Then
            SqlSelectDes = "Select Distinct Descri from TableInOut where trim(Descri) < '" & txtDescri.Text.Trim & "' order by Descri Desc"
        ElseIf e.KeyCode = Keys.Down Then
            SqlSelectDes = "Select Distinct Descri from TableInOut where trim(Descri) > '" & txtDescri.Text.Trim & "' order by Descri"
        Else
            SqlSelectDes = "Select * from TableInOut where lEFT(Descri, " & txtDescri.Text.Length & ") = '" & txtDescri.Text & " ' ORDER BY Descri"
        End If

        Dim adapter1 As New Odbc.OdbcDataAdapter(SqlSelectDes, MyConnection)
        Dim Dset1 As New DataSet
        Leng = txtDescri.Text.Trim.Length
        If txtDescri.Text <> "" Then
            If MyConnection.State = ConnectionState.Closed Then
                MyConnection.Open()
            End If
            Dset1.Clear()
            adapter1.Fill(Dset1)
            MyConnection.Close()

            If Dset1.Tables(0).Rows.Count > 0 Then
                txtDescri.Text = Dset1.Tables(0).Rows(0).Item("Descri")
                txtDescri.Select(Leng, txtDescri.Text.Trim.Length - Leng)
            End If
        Else

        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim SqlStm As String
        If txtCode.Value = 0 Then
            SqlStm = "Insert into TableInOut (Descri, Ammount, [Date], InOut) Values('" & _
            txtDescri.Text.Trim & "', '" & _
            txtAmmount.Value & "', '" & _
            txtDate.Value.ToString("yyyyMMdd") & "', '" & _
            cbxType.SelectedIndex & "')"
        Else
            SqlStm = "Update TableInOut Set Descri = '" & txtDescri.Text.Trim & "', " & _
                     " Ammount ='" & txtAmmount.Value & "', " & _
                     " [Date] ='" & txtDate.Value.ToString("yyyyMMdd") & "', " & _
                     " InOut = '" & cbxType.SelectedIndex & "' where Code = " & txtCode.Value
        End If

        If MyConnection.State = ConnectionState.Closed Then
            MyConnection.Open()
        End If
        trans = MyConnection.BeginTransaction
        MyCommand = New Odbc.OdbcCommand(SqlStm, MyConnection, trans)
        MyCommand.CommandType = CommandType.Text
        MyCommand.ExecuteNonQuery()
        trans.Commit()
        MyConnection.Close()
        txtDescri.Text = ""
        txtAmmount.Value = 0

    End Sub

   

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim SqlDel As String = "Delete from TableInOut where Code = " & txtCode.Value

        If MyConnection.State = ConnectionState.Closed Then
            MyConnection.Open()
        End If
        trans = MyConnection.BeginTransaction
        MyCommand = New Odbc.OdbcCommand(SqlDel, MyConnection, trans)
        MyCommand.CommandType = CommandType.Text
        MyCommand.ExecuteNonQuery()
        trans.Commit()
        MyConnection.Close()
        Me.Close()
    End Sub
End Class