Public Class FrmSupplierEdit
    Dim sqlstring As String
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If txtSupCod.Text = "" Then
            If MyConnection.State = ConnectionState.Closed Then
                MyConnection.Open()
            End If
            sqlString = "INSERT INTO TableSuppliers(SupName,SupAfm,SupAddress,SupPhone) VALUES('" & _
            Trim(txtSupName.Text) & "','" & Trim(txtSupAfm.Text) & "','" & Trim(txtSupAddress.Text) & "','" & Trim(txtSupPhone.Text) & "')"

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
            sqlString = "Update TableSuppliers set " & _
            "SupName='" & Trim(txtSupName.Text) & "'," & _
            "SupAfm='" & Trim(txtSupAfm.Text) & "'," & _
            "SupAddress='" & Trim(txtSupAddress.Text) & "'," & _
            "SupPhone='" & Trim(txtSupPhone.Text) & "'" & _
            " where supCod=" & txtSupCod.Text

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

        txtSupName.Text = ""
        txtSupCod.Text = ""
        txtSupAfm.Text = ""
        txtSupAddress.Text = ""
        txtSupPhone.Text = ""
        
    End Sub

    Public Sub LoadForm(ByVal SupCod As Integer)
        txtSupCod.Text = SupCod

        If SupCod > 0 Then
            Dim sqlString As String = "Select * from TableSuppliers where SupCod=" & SupCod
            Dim adapter1 As New Odbc.OdbcDataAdapter(sqlString, MyConnection)
            Dim Dset1 As New DataSet

            If MyConnection.State = ConnectionState.Closed Then
                MyConnection.Open()
            End If
            Dset1.Clear()
            adapter1.Fill(Dset1)
            MyConnection.Close()
            If Dset1.Tables(0).Rows.Count > 0 Then
                txtSupName.Text = Dset1.Tables(0).Rows(0).Item("SupName")
                txtSupAfm.Text = Dset1.Tables(0).Rows(0).Item("SupAfm")
                txtSupAddress.Text = Dset1.Tables(0).Rows(0).Item("SupAddress")
                txtSupPhone.Text = Dset1.Tables(0).Rows(0).Item("SupPhone")
                Me.Refresh()
            End If
        End If
        Me.ShowDialog()
    End Sub

    Private Sub FrmSupplierEdit_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        If txtSupCod.Text = "" Then
            Button2.Visible = False
        End If

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        If MsgBox("Να γίνει Διαγραφή του προμηθευτή;", MsgBoxStyle.OkCancel, "Επιβεβαίωση διαγραφής") = MsgBoxResult.Ok Then
            sqlString = "Delete * from TableSuppliers where SupCod=" & txtSupCod.Text

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