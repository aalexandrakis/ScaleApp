Public Class FrmSupplierSearch
    Public SelectedSupplier As Integer

    Public Sub FormLoad(ByVal StartsWith As String)
        Dim SqlSelect As String = "" & _
               "Select a.SupCod as ΚΩΔΙΚΟΣ, a.SupName as ΕΠΩΝΥΜΙΑ, a.SupAfm as ΑΦΜ, a.SupAddress as ΔΙΕΥΘΥΝΣΗ, " & _
               "SupPhone as ΤΗΛΕΦΩΝΟ " & _
               "from TableSuppliers as a " & _
               "where a.SupName like '" & StartsWith & "%'"

        Dim adapter1 As New Odbc.OdbcDataAdapter(SqlSelect, MyConnection)
        Dim Dset1 As New DataSet

        If MyConnection.State = ConnectionState.Closed Then
            MyConnection.Open()
        End If
        Dset1.Clear()
        adapter1.Fill(Dset1)
        MyConnection.Close()

        DataGrid1.DataSource = Dset1.Tables(0)
    End Sub

    Private Sub DataGrid1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGrid1.DoubleClick
        SelectedSupplier = DataGrid1.Item(DataGrid1.CurrentRowIndex, 0)
        Me.Close()
    End Sub

    Private Sub btnNewCust_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNewCust.Click
        Dim frmSupplieredit As New FrmSupplierEdit
        frmSupplieredit.ShowDialog()
        Call FormLoad("")
    End Sub

End Class