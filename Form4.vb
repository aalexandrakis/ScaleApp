Public Class Form4
    Dim SqlSelect As String

    Private Sub FillGrid()
        If RdKatPel.Checked = True Then
            SqlSelect = "Select CatCCod as  ˘‰ÈÍ¸Ú, CatCDes as –ÂÒÈ„Ò·ˆﬁ from TableCatCus order by CatCDes"
            TextBox1.Text = RdKatPel.Text
        End If

        If RdNomoi.Checked = True Then
            SqlSelect = "Select NomCod as  ˘‰ÈÍ¸Ú, NomDes as –ÂÒÈ„Ò·ˆﬁ from TableNomoi order by NomDes"
            TextBox1.Text = RdNomoi.Text
        End If

        If RdDimoi.Checked = True Then
            SqlSelect = "Select DimCod as  ˘‰ÈÍ¸Ú, DimDes as –ÂÒÈ„Ò·ˆﬁ from TableDimoi order by DimDes"
            TextBox1.Text = RdDimoi.Text
        End If

        If RdPoleis.Checked = True Then
            SqlSelect = "Select CitCod as  ˘‰ÈÍ¸Ú, CitDes as –ÂÒÈ„Ò·ˆﬁ from TableCities order by CitDes"
            TextBox1.Text = RdPoleis.Text
        End If

        If RdEpa.Checked = True Then
            SqlSelect = "Select EpaCod as  ˘‰ÈÍ¸Ú, EpaDes as ≈‹„„ÂÎÏ· from TableEpa order by EpaDes"
            TextBox1.Text = RdEpa.Text
        End If

        If RdCount.Checked = True Then
            SqlSelect = "Select CouCod as  ˘‰ÈÍ¸Ú, CouDes as –ÂÒÈ„Ò·ˆﬁ from tableCounter order by CouDes"
            TextBox1.Text = RdCount.Text
        End If

        If RdSeires.Checked = True Then
            SqlSelect = "Select SeiraId as ”ÂÈÒ‹, SeiraDes as –ÂÒÈ„Ò·ˆﬁ, SeiraNum as ¡ÒÈËÏ¸Ú from TableSeira order by SeiraId"
            TextBox1.Text = RdSeires.Text
        End If

        If RdUsers.Checked = True Then
            SqlSelect = "Select UserId as User_Id, UserName as User_Name, UserAdmin as Administrator, DisUser as Disabled from UserTable order by DisUser Desc, UserName"
            TextBox1.Text = RdUsers.Text
        End If

        If RdCustomers.Checked = True Then
            SqlSelect = "" & _
                   "Select a.CusCod as  Ÿƒ… œ”, a.CusName as ≈–ŸÕ’Ã…¡, a.CusAfm as ¡÷Ã, a.CusAddress as ƒ…≈’»’Õ”«, a.CusZipCod as ‘¡◊_ Ÿƒ, " & _
                   "(select NomDes from TableNomoi where a.Nomcod=TableNomoi.Nomcod) as ÕœÃœ”,  " & _
                   "(select CitDes from TableCities where a.Citcod=TableCities.Citcod) as –œÀ«,  " & _
                   "(select DimDes from TableDimoi where a.Dimcod=TableDimoi.Dimcod) as ƒ«Ãœ”,  " & _
                   "CusAcN as œ… œÕœÃ… œ”_’–≈’»’Õœ”," & _
                   "(select EpaDes from TableEpa where a.Epacod=TableEpa.Epacod) as ≈–¡√√≈ÀÃ¡,  " & _
                   "CusEml as EMAIL," & _
                   "(select CatCDes from TableCatCus where a.CatCCod=TableCatCus.CatCCod) as  ¡‘«√œ—…¡,  " & _
                   "CusSubFpa as Ã≈…ŸÃ≈Õœ”_÷–¡ " & _
                   "from TableCustomers as a "
            TextBox1.Text = RdCustomers.Text
        End If

        If RdSupliers.Checked = True Then
            SqlSelect = "" & _
                  "Select a.SupCod as  Ÿƒ… œ”, a.SupName as ≈–ŸÕ’Ã…¡, a.SupAfm as ¡÷Ã, a.SupAddress as ƒ…≈’»’Õ”«, " & _
            "SupPhone as ‘«À≈÷ŸÕœ " & _
            "from TableSuppliers as a "
            TextBox1.Text = RdCustomers.Text
        End If

        Dim adapter1 As New Odbc.OdbcDataAdapter(SqlSelect, MyConnection)
        Dim Dset1 As New DataSet
        If MyConnection.State = ConnectionState.Closed Then
            MyConnection.Open()
        End If
        Dset1.Clear()
        adapter1.Fill(Dset1)
        MyConnection.Close()
        dg1.DataSource = Dset1.Tables(0)
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If RdKatPel.Checked = True Then
            Dim FrmCatCustEdit As New FrmCatCustEdit
            FrmCatCustEdit.ShowDialog()
            Call FillGrid()
        End If

        If RdNomoi.Checked = True Then
            Dim FrmNomoiEdit As New FrmNomoiEdit
            FrmNomoiEdit.ShowDialog()
            Call FillGrid()
        End If

        If RdDimoi.Checked = True Then
            Dim FrmDimoiEdit As New FrmDimoiEdit
            FrmDimoiEdit.ShowDialog()
            Call FillGrid()
        End If

        If RdPoleis.Checked = True Then
            Dim FrmPoleisEdit As New FrmPoleisEdit
            FrmPoleisEdit.ShowDialog()
            Call FillGrid()
        End If

        If RdEpa.Checked = True Then
            Dim FrmEpaEdit As New FrmEpaEdit
            FrmEpaEdit.ShowDialog()
            Call FillGrid()
        End If

        If RdCount.Checked = True Then
            Dim FrmCounterEdit As New FrmCounterEdit
            FrmCounterEdit.ShowDialog()
            Call FillGrid()
        End If

        If RdSeires.Checked = True Then
            Dim FrmseiraEdit As New FrmSeiraEdit
            FrmseiraEdit.ShowDialog()
            Call FillGrid()
        End If

        If RdUsers.Checked = True Then
            Dim FrmUsersEdit As New frmUsersEdit
            FrmUsersEdit.ShowDialog()
            Call FillGrid()
        End If

        If RdCustomers.Checked = True Then
            Dim FrmCustomerEdit As New FrmCustomerEdit
            FrmCustomerEdit.ShowDialog()
            Call FillGrid()
        End If

        If RdSupliers.Checked = True Then
            Dim FrmSupplierEdit As New FrmSupplierEdit
            FrmSupplierEdit.ShowDialog()
            Call FillGrid()
        End If


    End Sub

    Private Sub dg1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dg1.DoubleClick
        Dim SelRow As Integer
        SelRow = dg1.CurrentRow.Index
        If RdKatPel.Checked Then
            Dim frmCatCustEdit As New FrmCatCustEdit
            frmCatCustEdit.FormLoad(dg1.Item(0, SelRow).Value)
        End If

        If RdNomoi.Checked Then
            Dim frmNomoiEdit As New FrmNomoiEdit
            frmNomoiEdit.FormLoad(dg1.Item(0, SelRow).Value)
        End If

        If RdDimoi.Checked Then
            Dim frmDimoiEdit As New FrmDimoiEdit
            frmDimoiEdit.FormLoad(dg1.Item(0, SelRow).Value)
        End If

        If RdPoleis.Checked Then
            Dim frmPoleisEdit As New FrmPoleisEdit
            frmPoleisEdit.FormLoad(dg1.Item(0, SelRow).Value)
        End If

        If RdEpa.Checked Then
            Dim frmEpaEdit As New FrmEpaEdit
            frmEpaEdit.FormLoad(dg1.Item(0, SelRow).Value)
        End If

        If RdCount.Checked Then
            Dim frmCounterEdit As New FrmCounterEdit
            frmCounterEdit.FormLoad(dg1.Item(0, SelRow).Value)
        End If

        If RdSeires.Checked Then
            Dim frmSeiraEdit As New FrmSeiraEdit
            frmSeiraEdit.FormLoad(dg1.Item(0, SelRow).Value)
        End If

        If RdUsers.Checked Then
            Dim frmUsersEdit As New frmUsersEdit
            frmUsersEdit.FormLoad(dg1.Item(0, SelRow).Value)
        End If

        If RdCustomers.Checked Then
            Dim frmCustomerEdit As New FrmCustomerEdit
            frmCustomerEdit.LoadForm(dg1.Item(0, SelRow).Value)
        End If

        If RdSupliers.Checked Then
            Dim frmSupplierEdit As New FrmSupplierEdit
            frmSupplierEdit.LoadForm(dg1.Item(0, SelRow).Value)
        End If

        Call FillGrid()
    End Sub

    Private Sub Form4_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        RdKatPel.Checked = True
        Call FillGrid()
    End Sub

    Private Sub RdKatPel_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RdKatPel.CheckedChanged
        Call FillGrid()
    End Sub

    Private Sub RdNomoi_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RdNomoi.CheckedChanged
        Call FillGrid()
    End Sub

    Private Sub RdDimoi_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RdDimoi.CheckedChanged
        Call FillGrid()
    End Sub

    Private Sub RdPoleis_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RdPoleis.CheckedChanged
        Call FillGrid()
    End Sub

    Private Sub RdEpa_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RdEpa.CheckedChanged
        Call FillGrid()
    End Sub

    Private Sub RdCount_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RdCount.CheckedChanged
        Call FillGrid()
    End Sub

    Private Sub RdSeires_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RdSeires.CheckedChanged
        Call FillGrid()
    End Sub

    Private Sub RdUsers_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RdUsers.CheckedChanged
        Call FillGrid()
    End Sub

    Private Sub RdCustomers_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RdCustomers.CheckedChanged
        Call FillGrid()
    End Sub

    Private Sub RdSupliers_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RdSupliers.CheckedChanged
        Call FillGrid()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Call DataGridToExcel(dg1, TextBox1.Text)
    End Sub
End Class