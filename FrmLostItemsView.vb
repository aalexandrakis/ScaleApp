Public Class FrmLostItemsView

    Private Sub FrmLostItemsView_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub FillList()
        Dim SqlSelect As String = "Select a.Code as AA, a.EidCod as Κωδικός, b.EidDes as Περιγραφή , " & _
        " a.LostCount as Ποσότητα, a.EidPrice as Τιμή, (a.LostCount * a.EidPrice)  as Ποσό from LostItems a" & _
        " inner join TableEidos b on a.EidCod = b.EidCod where a.LostDate between " & _
        DateFrom.Value.ToString("yyyyMMdd") & " and " & DateTo.Value.ToString("yyyyMMdd") & " order by a.LostDate, b.EidDes"

        Dim adapter1 As New Odbc.OdbcDataAdapter(SqlSelect, MyConnection)
        Dim Dset1 As New DataSet

        MyConnection.Open()
        Dset1.Clear()
        adapter1.Fill(Dset1)
        MyConnection.Close()
        DataGridView1.DataSource = Dset1.Tables(0)

        Dim SqlSelect1 As String = "Select sum(LostCount * EidPrice) as Sum from LostItems a where a.LostDate between " & _
        DateFrom.Value.ToString("yyyyMMdd") & " and " & DateTo.Value.ToString("yyyyMMdd")

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
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Call FillList()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim frmLostItemEdit As New FrmLostItemEdit
        frmLostItemEdit.Show()
    End Sub



    Private Sub DataGridView1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridView1.DoubleClick
        Dim frmLostItemEdit As New FrmLostItemEdit
        frmLostItemEdit.LostCode = DataGridView1.Item(0, DataGridView1.CurrentRow.Index).Value
        frmLostItemEdit.ShowDialog()
    End Sub
End Class