Public Class frmInOut

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Call FillList()
    End Sub

    Private Sub FillList()
        Dim SqlSelect As String
        DataGridView1.DataSource = ""

        SqlSelect = "Select Code As Κωδικός, Descri As Περιγραφή, Ammount As Ποσό, [Date] As Ημερομηνία, InOut from TableInOut a" & _
        " where [Date] between " & _
        DateFrom.Value.ToString("yyyyMMdd") & " and " & DateTo.Value.ToString("yyyyMMdd") & _
        " order by [Date]"

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
        For i = 1 To DataGridView1.Rows.Count
        Next

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim FrmInOutEdit As New frmInOutEdit
        FrmInOutEdit.Show()
    End Sub

    Private Sub DataGridView1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridView1.DoubleClick
        Dim frmInOutEdit As New frmInOutEdit
        frmInOutEdit.txtCode.Enabled = False
        frmInOutEdit.txtCode.Value = DataGridView1.Item(0, DataGridView1.CurrentRow.Index).Value
        frmInOutEdit.txtDescri.Text = DataGridView1.Item(1, DataGridView1.CurrentRow.Index).Value
        frmInOutEdit.txtAmmount.Value = DataGridView1.Item(2, DataGridView1.CurrentRow.Index).Value
        frmInOutEdit.txtDate.Value = Date.ParseExact(DataGridView1.Item(3, DataGridView1.CurrentRow.Index).Value, "yyyyMMdd", System.Globalization.CultureInfo.CurrentCulture)
        frmInOutEdit.cbxType.SelectedItem = CInt(DataGridView1.Item(4, DataGridView1.CurrentRow.Index).Value)
        frmInOutEdit.ShowDialog()

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        DataGridToExcel(DataGridView1, DateFrom.Value.ToString & "-" & DateTo.Value.ToString)
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Dim SqlSelect As String


        SqlSelect = "Select Descri As Περιγραφή, Sum(Ammount) As Ποσό,  InOut from TableInOut a" & _
        " where [Date] between " & _
        DateFrom.Value.ToString("yyyyMMdd") & " and " & DateTo.Value.ToString("yyyyMMdd") & _
        " Group By Descri, InOut Order By InOut "


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
        For i = 1 To DataGridView1.Rows.Count
        Next
    End Sub
End Class