Module Module2

    Public appPath1 As String = System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase
    Public appPath As String = System.IO.Path.GetDirectoryName(appPath1)
    Public Connect_String As String = "Driver={Microsoft Access Driver (*.mdb)};DBQ=" & appPath.Replace("file:\", "") & "\Data\CustomerInvoiceDB.mdb"
    Public MyConnection As New Odbc.OdbcConnection(Connect_String)

    Public MyCommand As Odbc.OdbcCommand
    Public trans As Odbc.OdbcTransaction
    Public ModAction As String
    Public ModActionB As String
    Public sqlString As String
    Public SelectedRec As String

    Public UserId As Integer
    Public UserName As String
    Public UserAdmin As Boolean
    Public frmLogin As New FrmLogin
    Public CusFpaPer As Decimal
    Public CatCCod As Integer

    Sub main()
        FrmLogin.ShowDialog()
    End Sub

    Public Sub FillComboBox(ByRef cbx As System.Windows.Forms.ComboBox, ByVal Table As String, ByVal ValueM As String, ByVal DisplayM As String, ByVal ShortColumn As String)
        cbx.Refresh()
        Dim SelectString As String = "Select * from " & Table & " order by " & ShortColumn

        Dim adapter1 As New Odbc.OdbcDataAdapter(SelectString, MyConnection)
        Dim Dset1 As New DataSet

        MyConnection.Open()
        Dset1.Clear()
        adapter1.Fill(Dset1)
        MyConnection.Close()

        cbx.DataSource = Dset1.Tables(0)
        cbx.DisplayMember = DisplayM
        cbx.ValueMember = ValueM

    End Sub


    Public Sub DataSetToExcel(ByVal Dset As DataSet, ByVal ExcelTitle As String)
        Dim thisThread As System.Threading.Thread = _
           System.Threading.Thread.CurrentThread
        Dim originalCulture As System.Globalization.CultureInfo = _
            thisThread.CurrentCulture
        'Dim tempExpense As Object
        'Dim tempIncome As Object

        'Dim Criteria As String

        ' Use an exception block to switch back in case of a run-time error.
        Try
            thisThread.CurrentCulture = New System.Globalization.CultureInfo( _
                "en-US")
        Finally
            'thisThread.CurrentCulture = originalCulture
        End Try

        Dim oexcel As Excel.Application
        oexcel = New Excel.Application
        Dim obook As Excel.Workbook = oexcel.Workbooks.Add
        Dim xlRange As Excel.Range

        'Επικεφαλίδες

        oexcel.Visible = True
        oexcel.Cells(1, 1) = Trim(ExcelTitle)
        xlRange = oexcel.Range("A1", "I1")
        xlRange.Merge()

        xlRange = oexcel.Rows(1)
        xlRange.Font.Bold = 3

        'Εκτύπωση του DataSet
        Dim Row As Integer
        Dim Column As Integer

        xlRange = oexcel.Rows(4)
        xlRange.Font.Bold = 3

        Dim xlRow As Integer = 5
        Dim xlCol As Integer = 1

        For Row = 0 To Dset.Tables(0).Rows.Count - 1
            xlCol = 1
            For Column = 0 To Dset.Tables(0).Columns.Count - 1
                If Row = 0 Then
                    oexcel.Cells(xlRow - 1, xlCol) = Dset.Tables(0).Columns(Column).Caption
                End If
                oexcel.Cells(xlRow, xlCol) = Dset.Tables(0).Rows(Row).Item(Column)
                xlCol += 1
            Next
            xlRow += 1
        Next


        xlRange = oexcel.Columns("A")
        xlRange.AutoFit()

        xlRange = oexcel.Columns("B")
        xlRange.AutoFit()

        xlRange = oexcel.Columns("C")
        xlRange.AutoFit()

        xlRange = oexcel.Columns("D")
        xlRange.AutoFit()

        xlRange = oexcel.Columns("E")
        xlRange.AutoFit()

        xlRange = oexcel.Columns("F")
        xlRange.AutoFit()

        xlRange = oexcel.Columns("G")
        xlRange.AutoFit()

        xlRange = oexcel.Columns("H")
        xlRange.AutoFit()

        xlRange = oexcel.Columns("I")
        xlRange.AutoFit()

        xlRange = oexcel.Columns("J")
        xlRange.AutoFit()

        xlRange = oexcel.Columns("K")
        xlRange.AutoFit()

        xlRange = oexcel.Columns("L")
        xlRange.AutoFit()

        xlRange = oexcel.Columns("M")
        xlRange.AutoFit()

        xlRange = oexcel.Columns("N")
        xlRange.AutoFit()

        xlRange = oexcel.Columns("O")
        xlRange.AutoFit()

        xlRange = oexcel.Columns("P")
        xlRange.AutoFit()

        xlRange = oexcel.Columns("Q")
        xlRange.AutoFit()

        xlRange = oexcel.Columns("R")
        xlRange.AutoFit()

        xlRange = oexcel.Columns("S")
        xlRange.AutoFit()

        xlRange = oexcel.Columns("T")
        xlRange.AutoFit()

        xlRange = oexcel.Columns("J")
        xlRange.AutoFit()

        xlRange = oexcel.Columns("K")
        xlRange.AutoFit()

        xlRange = oexcel.Columns("L")
        xlRange.AutoFit()

        xlRange = oexcel.Columns("M")
        xlRange.AutoFit()

        xlRange = oexcel.Columns("N")
        xlRange.AutoFit()

        xlRange = oexcel.Columns("O")
        xlRange.AutoFit()

        xlRange = oexcel.Columns("P")
        xlRange.AutoFit()

        xlRange = oexcel.Columns("Q")
        xlRange.AutoFit()

        xlRange = oexcel.Columns("R")
        xlRange.AutoFit()

        xlRange = oexcel.Columns("S")
        xlRange.AutoFit()

        xlRange = oexcel.Columns("T")
        xlRange.AutoFit()

        xlRange = oexcel.Columns("U")
        xlRange.AutoFit()

        xlRange = oexcel.Columns("V")
        xlRange.AutoFit()

    End Sub

    Public Sub SupInvToExcel(ByVal Seira As String, ByVal Number As Integer, ByVal SupCod As Integer)
        Dim thisThread As System.Threading.Thread = _
           System.Threading.Thread.CurrentThread
        Dim originalCulture As System.Globalization.CultureInfo = _
            thisThread.CurrentCulture
        'Dim tempExpense As Object
        'Dim tempIncome As Object

        'Dim Criteria As String

        ' Use an exception block to switch back in case of a run-time error.
        Try
            thisThread.CurrentCulture = New System.Globalization.CultureInfo( _
                "en-US")
        Finally
            'thisThread.CurrentCulture = originalCulture
        End Try

        Dim oexcel As Excel.Application
        oexcel = New Excel.Application
        Dim obook As Excel.Workbook = oexcel.Workbooks.Add
        Dim xlRange As Excel.Range

        'Επικεφαλίδες

        oexcel.Visible = True
        oexcel.Cells(1, 1) = Trim(Seira) & " " & Trim(Number)
        'xlRange = oexcel.Range("A1", "I1")
        'xlRange.Merge()

        Dim SqlSelect As String = "Select b.SupName as Επωνυμία, a.invdate as Ημερομηνία, Summary as Ποσό  " & _
        "from TableSupInvHead a inner join TableSuppliers b on a.supcod = b.supcod where seira = '" & Trim(Seira) & _
        "' and Number = " & Number & " and a.SupCod = " & SupCod

        Dim adapter1 As New Odbc.OdbcDataAdapter(SqlSelect, MyConnection)
        Dim Dset1 As New DataSet
        MyConnection.Open()
        Dset1.Clear()
        adapter1.Fill(Dset1)
        MyConnection.Close()

        oexcel.Cells(1, 1) = Trim(Seira)
        oexcel.Cells(1, 2) = Number

        oexcel.Cells(2, 1) = SupCod
        oexcel.Cells(2, 2) = Dset1.Tables(0).Rows(0).Item("Επωνυμία")
        oexcel.Cells(3, 2) = "Ημερομηνία"
        oexcel.Cells(3, 2) = Dset1.Tables(0).Rows(0).Item("Ημερομηνία")

        xlRange = oexcel.Rows(1)
        xlRange.Font.Bold = 3
        xlRange = oexcel.Rows(2)
        xlRange.Font.Bold = 3
        xlRange = oexcel.Rows(3)
        xlRange.Font.Bold = 3

        'Εκτύπωση του DataSet

        Dim SqlSelectD As String = "Select a.item as Κωδικός, " & _
        "b.eiddes as Περιγραφή, a.Count as Ποσότητα, a.Price as Τιμή_Μονάδος, a.Poso as Τιμή " & _
        "from TableSupInvDet a inner join TableEidos b on a.Item = b.Eidcod " & _
        "where Seira = '" & Seira & "' and Number = " & _
        Number & " and SupCod = " & SupCod

        Dim adapterE As New Odbc.OdbcDataAdapter(SqlSelectD, MyConnection)
        Dim DsetE As New DataSet

        MyConnection.Open()
        DsetE.Clear()
        adapterE.Fill(DsetE)
        MyConnection.Close()

        Dim Row As Integer
        Dim Column As Integer

        xlRange = oexcel.Rows(4)
        xlRange.Font.Bold = 3

        Dim xlRow As Integer = 5
        Dim xlCol As Integer = 1

        For Row = 0 To DsetE.Tables(0).Rows.Count - 1
            xlCol = 1
            For Column = 0 To DsetE.Tables(0).Columns.Count - 1
                If Row = 0 Then
                    oexcel.Cells(xlRow - 1, xlCol) = DsetE.Tables(0).Columns(Column).Caption
                End If
                oexcel.Cells(xlRow, xlCol) = DsetE.Tables(0).Rows(Row).Item(Column)
                xlCol += 1
            Next
            xlRow += 1
        Next

        oexcel.Cells(xlRow, 5) = Dset1.Tables(0).Rows(0).Item("Ποσό")
        xlRange = oexcel.Columns("A")
        xlRange.AutoFit()

        xlRange = oexcel.Columns("B")
        xlRange.AutoFit()

        xlRange = oexcel.Columns("C")
        xlRange.AutoFit()

        xlRange = oexcel.Columns("D")
        xlRange.AutoFit()

        xlRange = oexcel.Columns("E")
        xlRange.AutoFit()

        xlRange = oexcel.Columns("F")
        xlRange.AutoFit()

        xlRange = oexcel.Columns("G")
        xlRange.AutoFit()

        xlRange = oexcel.Columns("H")
        xlRange.AutoFit()

        xlRange = oexcel.Columns("I")
        xlRange.AutoFit()

        xlRange = oexcel.Columns("J")
        xlRange.AutoFit()

        xlRange = oexcel.Columns("K")
        xlRange.AutoFit()

        xlRange = oexcel.Columns("L")
        xlRange.AutoFit()

        xlRange = oexcel.Columns("M")
        xlRange.AutoFit()

        xlRange = oexcel.Columns("N")
        xlRange.AutoFit()

        xlRange = oexcel.Columns("O")
        xlRange.AutoFit()

        xlRange = oexcel.Columns("P")
        xlRange.AutoFit()

        xlRange = oexcel.Columns("Q")
        xlRange.AutoFit()

        xlRange = oexcel.Columns("R")
        xlRange.AutoFit()

        xlRange = oexcel.Columns("S")
        xlRange.AutoFit()

        xlRange = oexcel.Columns("T")
        xlRange.AutoFit()

        xlRange = oexcel.Columns("J")
        xlRange.AutoFit()

        xlRange = oexcel.Columns("K")
        xlRange.AutoFit()

        xlRange = oexcel.Columns("L")
        xlRange.AutoFit()

        xlRange = oexcel.Columns("M")
        xlRange.AutoFit()

        xlRange = oexcel.Columns("N")
        xlRange.AutoFit()

        xlRange = oexcel.Columns("O")
        xlRange.AutoFit()

        xlRange = oexcel.Columns("P")
        xlRange.AutoFit()

        xlRange = oexcel.Columns("Q")
        xlRange.AutoFit()

        xlRange = oexcel.Columns("R")
        xlRange.AutoFit()

        xlRange = oexcel.Columns("S")
        xlRange.AutoFit()

        xlRange = oexcel.Columns("T")
        xlRange.AutoFit()

        xlRange = oexcel.Columns("U")
        xlRange.AutoFit()

        xlRange = oexcel.Columns("V")
        xlRange.AutoFit()

    End Sub


    Public Sub DataGridToExcel(ByVal DGV As DataGridView, ByVal ExcelTitle As String)
        Dim thisThread As System.Threading.Thread = _
           System.Threading.Thread.CurrentThread
        Dim originalCulture As System.Globalization.CultureInfo = _
            thisThread.CurrentCulture
        'Dim tempExpense As Object
        'Dim tempIncome As Object

        'Dim Criteria As String

        ' Use an exception block to switch back in case of a run-time error.
        Try
            thisThread.CurrentCulture = New System.Globalization.CultureInfo( _
                "en-US")
        Finally
            'thisThread.CurrentCulture = originalCulture
        End Try

        Dim oexcel As Excel.Application
        oexcel = New Excel.Application
        Dim obook As Excel.Workbook = oexcel.Workbooks.Add
        Dim xlRange As Excel.Range

        'Επικεφαλίδες

        oexcel.Visible = True
        oexcel.Cells(1, 1) = Trim(ExcelTitle)
        xlRange = oexcel.Range("A1", "I1")
        xlRange.Merge()

        xlRange = oexcel.Rows(1)
        xlRange.Font.Bold = 3

        'Εκτύπωση του DataSet
        Dim Row As Integer
        Dim Column As Integer

        xlRange = oexcel.Rows(4)
        xlRange.Font.Bold = 3

        Dim xlRow As Integer = 5
        Dim xlCol As Integer = 1

        For Row = 0 To DGV.RowCount - 1
            xlCol = 1
            For Column = 0 To DGV.Columns.Count - 1
                If Row = 0 Then
                    oexcel.Cells(xlRow - 1, xlCol) = DGV.Columns(Column).HeaderText
                End If
                oexcel.Cells(xlRow, xlCol) = DGV.Rows(Row).Cells(Column).Value
                xlCol += 1
            Next
            xlRow += 1
        Next


        xlRange = oexcel.Columns("A")
        xlRange.AutoFit()

        xlRange = oexcel.Columns("B")
        xlRange.AutoFit()

        xlRange = oexcel.Columns("C")
        xlRange.AutoFit()

        xlRange = oexcel.Columns("D")
        xlRange.AutoFit()

        xlRange = oexcel.Columns("E")
        xlRange.AutoFit()

        xlRange = oexcel.Columns("F")
        xlRange.AutoFit()

        xlRange = oexcel.Columns("G")
        xlRange.AutoFit()

        xlRange = oexcel.Columns("H")
        xlRange.AutoFit()

        xlRange = oexcel.Columns("I")
        xlRange.AutoFit()

        xlRange = oexcel.Columns("J")
        xlRange.AutoFit()

        xlRange = oexcel.Columns("K")
        xlRange.AutoFit()

        xlRange = oexcel.Columns("L")
        xlRange.AutoFit()

        xlRange = oexcel.Columns("M")
        xlRange.AutoFit()

        xlRange = oexcel.Columns("N")
        xlRange.AutoFit()

        xlRange = oexcel.Columns("O")
        xlRange.AutoFit()

        xlRange = oexcel.Columns("P")
        xlRange.AutoFit()

        xlRange = oexcel.Columns("Q")
        xlRange.AutoFit()

        xlRange = oexcel.Columns("R")
        xlRange.AutoFit()

        xlRange = oexcel.Columns("S")
        xlRange.AutoFit()

        xlRange = oexcel.Columns("T")
        xlRange.AutoFit()

        xlRange = oexcel.Columns("J")
        xlRange.AutoFit()

        xlRange = oexcel.Columns("K")
        xlRange.AutoFit()

        xlRange = oexcel.Columns("L")
        xlRange.AutoFit()

        xlRange = oexcel.Columns("M")
        xlRange.AutoFit()

        xlRange = oexcel.Columns("N")
        xlRange.AutoFit()

        xlRange = oexcel.Columns("O")
        xlRange.AutoFit()

        xlRange = oexcel.Columns("P")
        xlRange.AutoFit()

        xlRange = oexcel.Columns("Q")
        xlRange.AutoFit()

        xlRange = oexcel.Columns("R")
        xlRange.AutoFit()

        xlRange = oexcel.Columns("S")
        xlRange.AutoFit()

        xlRange = oexcel.Columns("T")
        xlRange.AutoFit()

        xlRange = oexcel.Columns("U")
        xlRange.AutoFit()

        xlRange = oexcel.Columns("V")
        xlRange.AutoFit()

    End Sub
End Module


