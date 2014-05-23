Public Class FrmSupplierView
    Dim SqlSelect As String = "" & _
            "Select a.SupCod as ΚΩΔΙΚΟΣ, a.SupName as ΕΠΩΝΥΜΙΑ, a.SupAfm as ΑΦΜ, a.SupAddress as ΔΙΕΥΘΥΝΣΗ, " & _
            "SupPhone as ΤΗΛΕΦΩΝΟ " & _
            "from TableSuppliers as a "

    Dim adapter1 As New Odbc.OdbcDataAdapter(SqlSelect, MyConnection)
    Dim Dset1 As New DataSet
    Private Sub FrmSupplierView_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call filllist()
    End Sub

    Private Sub filllist()

        MyConnection.Open()
        Dset1.Clear()
        adapter1.Fill(Dset1)
        MyConnection.Close()

        DataGrid1.DataSource = Dset1.Tables(0)
    End Sub



    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim frmSupplieredit As New FrmSupplierEdit
        frmSupplieredit.ShowDialog()
        Call filllist()
    End Sub

    Private Sub DataGrid1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGrid1.DoubleClick
        Dim frmSupplierEdit As New FrmSupplierEdit
        frmSupplierEdit.LoadForm(DataGrid1.Item(DataGrid1.CurrentRowIndex, 0))
        Call filllist()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Call DataSetToExcel(Dset1, Me.Text)
    End Sub
End Class