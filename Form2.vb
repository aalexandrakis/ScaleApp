Public Class Form2

    Dim aa As Integer
    Dim GRDDATE As Integer

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        RadioButton1.Checked = True
    End Sub

   

    Private Sub SummaryHeads(ByVal ColPos As Integer, Optional ByVal ColKos As Integer = -1, Optional ByVal ColKer As Integer = -1)
        Dim i As Integer
        NmSum.Value = 0
        NmKostos.Value = 0
        NmKerdos.Value = 0
        For i = 1 To dg1.Rows.Count
            NmSum.Value += CDec(dg1.Item(ColPos, i - 1).Value)
            If ColKos >= 0 Then
                NmKostos.Value += CDec(dg1.Item(ColKos, i - 1).Value)
            End If
            If ColKer >= 0 Then
                NmKerdos.Value += CDec(dg1.Item(ColKer, i - 1).Value)
            End If
        Next

    End Sub



    Private Sub dg1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dg1.DoubleClick
        If RadioButton1.Checked = False And RadioButton2.Checked = False _
                                        And RadioButton3.Checked = False Then
            Exit Sub
        End If
        Dim i As Integer

        For i = 1 To dg1.Rows.Count
            If dg1.Rows(i - 1).Cells(0).Selected = True Then

                If RadioButton3.Checked Then
                    If dg1.Item(1, i - 1).Value = "÷’—≈”" Then
                        Call GetDestroys()
                        Exit Sub
                    End If
                End If

                If RadioButton3.Checked Then
                    If dg1.Item(1, i - 1).Value = "”–…‘…" Then
                        Call GetBuy()
                        Exit Sub
                    End If
                End If


                If RadioButton1.Checked = True Then
                    aa = CDec(dg1.Item(0, i - 1).Value)
                    GRDDATE = CDec(dg1.Item(4, i - 1).Value)
                    Call GetDetails(aa, GRDDATE)
                End If

                If RadioButton2.Checked = True Then
                    aa = CDec(dg1.Item(0, i - 1).Value)
                    Call GetDetails2(aa)
                End If

                Exit Sub
            End If


        Next

    End Sub

    Private Sub GetDestroys()

        Dim SqlString1 As String = "Select ItemCode as  Ÿƒ… œ” , EidDes as –≈—…√—¡÷«, " & _
                                   " Count as –œ”œ‘«‘¡, Uprice as ‘…Ã«ÃœÕ¡ƒœ”, " & _
                                   " tprice as ”ıÌÔÎÔ from DestroysTable inner join TableEidos " & _
                                   " on DESTROYSTable.ItemCode = TableEIDOS.EidCod where SalDat between " & _
                                   datef.Value.ToString("yyyyMMdd") & " and " & _
                                   datet.Value.ToString("yyyyMMdd")

        Dim adapter1 As New Odbc.OdbcDataAdapter(SqlString1, MyConnection)
        Dim Dset1 As New DataSet
        If MyConnection.State = ConnectionState.Closed Then
            MyConnection.Open()
        End If
        Dset1.Clear()
        adapter1.Fill(Dset1)
        MyConnection.Close()
        dg1.Columns.Clear()
        dg1.DataSource = Dset1.Tables(0)
        Call SummaryHeads(4)
        Button1.Visible = True
    End Sub

    Private Sub GetBuy()

        Dim SqlString1 As String = "Select ItemCode as  Ÿƒ… œ” , EidDes as –≈—…√—¡÷«, " & _
                                   " Count as –œ”œ‘«‘¡, Uprice as ‘…Ã«ÃœÕ¡ƒœ”, " & _
                                   " tprice as ”ıÌÔÎÔ from BuyTable inner join TableEidos " & _
                                   " on BuyTable.ItemCode = TableEIDOS.EidCod where SalDat between " & _
                                   datef.Value.ToString("yyyyMMdd") & " and " & _
                                   datet.Value.ToString("yyyyMMdd")

        Dim adapter1 As New Odbc.OdbcDataAdapter(SqlString1, MyConnection)
        Dim Dset1 As New DataSet
        If MyConnection.State = ConnectionState.Closed Then
            MyConnection.Open()
        End If
        Dset1.Clear()
        adapter1.Fill(Dset1)
        MyConnection.Close()
        dg1.Columns.Clear()
        dg1.DataSource = Dset1.Tables(0)
        Call SummaryHeads(4)
        Button1.Visible = True
    End Sub
    Private Sub GetDetails(ByVal AA As Integer, ByVal DT As Integer)
        Button2.Visible = True
        Dim SqlString1 As String = "SELECT AA, itemcode as  ˘‰ÈÍ¸Ú, eiddes as –ÂÒÈ„Ò·ˆﬁ, uprice as ‘ÈÏÁÃÔÌ·‰ÔÚ, count as –ÔÛÔÙÁÙ·," & _
                                   " tprice as ‘ÈÏﬁ, Kostos as  ¸ÛÙÔÚ, expr3 as  ÂÒ‰ÔÚ, saldat as SaleDate" & _
                                 " from SalesDetail where saldat = " & DT & _
                                 " and aa =" & AA

        Dim adapter1 As New Odbc.OdbcDataAdapter(SqlString1, MyConnection)
        Dim Dset1 As New DataSet
        If MyConnection.State = ConnectionState.Closed Then
            MyConnection.Open()
        End If
        Dset1.Clear()
        adapter1.Fill(Dset1)
        MyConnection.Close()
        dg1.Columns.Clear()
        dg1.DataSource = Dset1.Tables(0)
        Call SummaryHeads(5, 6, 7)
        Button1.Visible = True
    End Sub
    Private Sub GetDetails2(ByVal AA As Integer)
        Dim SqlString1 As String = "SELECT itemcode as  ˘‰ÈÍ¸Ú, eiddes as –ÂÒÈ„Ò·ˆﬁ, uprice as ‘ÈÏÁÃÔÌ·‰ÔÚ, sum(count) as –ÔÛÔÙÁÙ·," & _
                                   " sum(tprice) as ‘ÈÏﬁ, sum(Kostos) as  ¸ÛÙÔÚ, sum(expr3) as  ÂÒ‰ÔÚ" & _
                                 " from SalesDetail where saldat between " & CDec(datef.Value.ToString("yyyMMdd")) & " and " & CDec(datet.Value.ToString("yyyMMdd")) & _
                                 " and codcat =" & AA & " group by itemcode, eiddes, uprice"

        Dim adapter1 As New Odbc.OdbcDataAdapter(SqlString1, MyConnection)
        Dim Dset1 As New DataSet
        If MyConnection.State = ConnectionState.Closed Then
            MyConnection.Open()
        End If
        Dset1.Clear()
        adapter1.Fill(Dset1)
        MyConnection.Close()
        dg1.Columns.Clear()
        dg1.DataSource = Dset1.Tables(0)
        Call SummaryHeads(4, 5, 6)
        Button1.Visible = True
    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If RadioButton1.Checked Then
            RadioButton1.Checked = False
            RadioButton1.Checked = True
        End If
        If RadioButton2.Checked Then
            RadioButton2.Checked = False
            RadioButton2.Checked = True
        End If
        If RadioButton3.Checked Then
            RadioButton3.Checked = False
            RadioButton3.Checked = True
        End If
        Button1.Visible = False
    End Sub
    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        Call FILLGRID()
    End Sub
    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged
        Call FILLGRID()
    End Sub

    Private Sub RadioButton3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton3.CheckedChanged
        Call FILLGRID()
    End Sub

    Private Sub RadioButton4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton4.CheckedChanged
        Call FILLGRID()
    End Sub

    Private Sub RadioButton5_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton5.CheckedChanged
        Call FILLGRID()
    End Sub


    Private Sub FILLGRID()
        Button2.Visible = False
        If RadioButton1.Checked = True Then
            Dim SqlString1 As String = "SELECT AA, sum(tprice) as –œ”œ, sum(kostos) as  œ”‘œ”, sum(expr3) as  ≈—ƒœ”, SALDAT AS «Ã≈—œÃ«Õ…¡ " & _
                         " from SalesDetail where saldat between " & CDec(datef.Value.ToString("yyyMMdd")) & " and " & CDec(datet.Value.ToString("yyyMMdd")) & _
                         " group by AA, SALDAT ORDER BY SALDAT, AA"

            Dim adapter1 As New Odbc.OdbcDataAdapter(SqlString1, MyConnection)
            Dim Dset1 As New DataSet
            If MyConnection.State = ConnectionState.Closed Then
                MyConnection.Open()
            End If
            Dset1.Clear()
            adapter1.Fill(Dset1)
            MyConnection.Close()
            dg1.Columns.Clear()
            dg1.DataSource = Dset1.Tables(0)
            Call SummaryHeads(1, 2, 3)
            Button1.Visible = False
        End If

        If RadioButton2.Checked = True Then
            Dim SqlString1 As String = "SELECT codcat, DesCat, sum(tprice) as –œ”œ, sum(kostos) as  œ”‘œ”, sum(expr3) as  ≈—ƒœ” " & _
                                 " from SalesDetail where saldat between " & CDec(datef.Value.ToString("yyyMMdd")) & " and " & CDec(datet.Value.ToString("yyyMMdd")) & _
                                 " group by codcat, DesCat"

            Dim adapter1 As New Odbc.OdbcDataAdapter(SqlString1, MyConnection)
            Dim Dset1 As New DataSet
            If MyConnection.State = ConnectionState.Closed Then
                MyConnection.Open()
            End If
            Dset1.Clear()
            adapter1.Fill(Dset1)
            MyConnection.Close()
            dg1.Columns.Clear()
            dg1.DataSource = Dset1.Tables(0)
            Call SummaryHeads(2, 3, 4)
            Button1.Visible = False
        End If

        If RadioButton3.Checked = True Then
            Dim SPITI As String = "”–…‘…"
            Dim FYRES As String = "÷’—≈”"
            Dim TAMEIO As String = "‘¡Ã≈…œ"
            Dim AGORA As String = "¡√œ—¡"
            Dim KERDOS As String = " ≈—ƒœ”"
            Dim SqlString1 As String = "SELECT Sum(Tprice) AS –œ”œ, '”–…‘…'" & _
            " FROM BuyTable " & _
            " WHERE BuyTable.SalDat Between " & CDec(datef.Value.ToString("yyyMMdd")) & " and " & CDec(datet.Value.ToString("yyyMMdd")) & _
            " UNION SELECT Sum(DestroysTable.Tprice) AS Expr1, '÷’—≈”'" & _
            " FROM(DestroysTable) " & _
            " WHERE DestroysTable.SalDat Between  " & CDec(datef.Value.ToString("yyyMMdd")) & " and " & CDec(datet.Value.ToString("yyyMMdd")) & _
            " UNION SELECT Sum(TableInOut.Ammount) AS Expr1, TableInOut.Descri " & _
            " FROM(TableInOut)" & _
            " WHERE TableInout.Date Between  " & CDec(datef.Value.ToString("yyyMMdd")) & " and " & CDec(datet.Value.ToString("yyyMMdd")) & _
            " group by TableInOut.descri" & _
            " UNION SELECT Sum(SalesTable.Tprice) AS Expr1, '‘¡Ã≈…œ'" & _
            " FROM(SalesTable) " & _
            " WHERE SalesTable.SalDat Between " & CDec(datef.Value.ToString("yyyMMdd")) & " and " & CDec(datet.Value.ToString("yyyMMdd")) & _
            " UNION SELECT Sum(TableSupInvHead.Summary + TableSupInvHead.FPA) AS Expr1, '¡√œ—¡'" & _
            " FROM(TableSupInvHead)" & _
            " WHERE TableSupInvHead.InvDate Between  " & CDec(datef.Value.ToString("yyyMMdd")) & " and " & CDec(datet.Value.ToString("yyyMMdd")) & _
            " UNION SELECT Sum(SalesDetail.Expr3) AS Expr1, ' ≈—ƒœ”'" & _
            " FROM(SalesDetail) " & _
            " WHERE SalesDetail.SalDat Between  " & CDec(datef.Value.ToString("yyyMMdd")) & " and " & CDec(datet.Value.ToString("yyyMMdd"))

            Dim adapter1 As New Odbc.OdbcDataAdapter(SqlString1, MyConnection)
            Dim Dset1 As New DataSet
            If MyConnection.State = ConnectionState.Closed Then
                MyConnection.Open()
            End If
            Dset1.Clear()
            adapter1.Fill(Dset1)
            MyConnection.Close()
            dg1.Columns.Clear()
            dg1.DataSource = Dset1.Tables(0)
            NmSum.Value = 0
            NmKostos.Value = 0
            NmKerdos.Value = 0
        End If


        If RadioButton4.Checked = True Then
            Dim I As Integer
            Dim COLCOUNT As Integer
            Dim DateFrom As Date
            If datef.Value > Date.Now Then
                MsgBox("«Ã≈—œÃ«Õ…¡ ¡–œ Ã≈√¡À’‘≈—« ¡–œ ‘«Õ ‘—≈◊œ’”¡", MsgBoxStyle.OkOnly)
                Exit Sub
            End If
            If datet.Value > Date.Now Then
                MsgBox("«Ã≈—œÃ«Õ…¡ ≈Ÿ” Ã≈√¡À’‘≈—« ¡–œ ‘«Õ ‘—≈◊œ’”¡", MsgBoxStyle.OkOnly)
                Exit Sub
            End If
            DateFrom = datef.Value
            'Do While DateFrom.DayOfYear <= datet.Value.DayOfYear
            'DateAdd(DateInterval.Day, 1, DateFrom)
            'DAYSCOUNT += 1
            'Loop
            Dim sqlstring As String = "Select Saldat from SalesDetail where saldat between " & CDec(datef.Value.ToString("yyyMMdd")) & " and " & CDec(datet.Value.ToString("yyyMMdd")) & _
                                 " GROUP BY saldat"
            Dim adapter As New Odbc.OdbcDataAdapter(sqlstring, MyConnection)
            Dim Dset As New DataSet
            If MyConnection.State = ConnectionState.Closed Then
                MyConnection.Open()
            End If
            Dset.Clear()
            adapter.Fill(Dset)

            Dim SqlString1 As String = "" & _
            " SELECT  SUM(tprice) as Tameio, cint(saltim / 100) as SaleTime," & _
                                 " SUM(tprice) / " & Dset.Tables(0).Rows.Count & " as MesosOros, " & _
                                Dset.Tables(0).Rows.Count & " as Days " & _
                                 " from SalesDetail where saldat between " & CDec(datef.Value.ToString("yyyMMdd")) & " and " & CDec(datet.Value.ToString("yyyMMdd")) & _
                                 " GROUP BY cint(saltim / 100)"

            Dim adapter1 As New Odbc.OdbcDataAdapter(SqlString1, MyConnection)
            Dim Dset1 As New DataSet
            If MyConnection.State = ConnectionState.Closed Then
                MyConnection.Open()
            End If
            Dset1.Clear()
            adapter1.Fill(Dset1)
            MyConnection.Close()
            dg1.Columns.Clear()
            dg1.DataSource = Dset1.Tables(0)
            Call SummaryHeads(0)
            COLCOUNT = dg1.Columns.Add("PROOD", "–—œœƒ≈’‘… œ")
            For I = 1 To dg1.Rows.Count
                If I > 1 Then
                    dg1.Item(COLCOUNT, I - 1).Value = dg1.Item(COLCOUNT, I - 2).Value + dg1.Item(2, I - 1).Value
                Else
                    dg1.Item(COLCOUNT, I - 1).Value = dg1.Item(2, I - 1).Value
                End If
            Next
            Button1.Visible = False
        End If

        If RadioButton5.Checked = True Then
            Dim q As String = "''"


            Dim SqlString1 As String = "SELECT SalDat as ÁÏÂÒÔÏÁÌﬂ·, " & _
                                       " sum(tprice) as –ÔÛ¸, sum(Kostos) as  ¸ÛÙÔÚ, sum(expr3) as  ÂÒ‰ÔÚ" & _
                                     " from SalesDetail where saldat between " & CDec(datef.Value.ToString("yyyMMdd")) & " and " & CDec(datet.Value.ToString("yyyMMdd")) & _
                                     " group by saldat"


            Dim adapter1 As New Odbc.OdbcDataAdapter(SqlString1, MyConnection)
            Dim Dset1 As New DataSet
            If MyConnection.State = ConnectionState.Closed Then
                MyConnection.Open()
            End If
            Dset1.Clear()
            adapter1.Fill(Dset1)
            MyConnection.Close()

            Dset1.Tables(0).Columns.Add("day")
            Dim i As Integer
            For i = 1 To Dset1.Tables(0).Rows.Count
                Dset1.Tables(0).Rows(i - 1).Item(4) = WeekdayName(Weekday(CDate(Dset1.Tables(0).Rows(i - 1).Item(0).ToString.Substring(6, 2) & "/" & Dset1.Tables(0).Rows(i - 1).Item(0).ToString.Substring(4, 2) & "/" & Dset1.Tables(0).Rows(i - 1).Item(0).ToString.Substring(0, 4)), FirstDayOfWeek.Monday))
            Next
            dg1.Columns.Clear()
            dg1.DataSource = Dset1.Tables(0)
            Call SummaryHeads(1, 2, 3)
            Button1.Visible = False
        End If

        If rdDebits.Checked = True Then
            Dim q As String = "''"


            Dim SqlString1 As String = "SELECT DEBDESC AS œ÷≈…À≈‘«”, AA AS ¡¡, " & _
                                       " DEBDATE AS «Ã≈—œÃ«Õ…¡, DEBAMMOUNT AS –œ”œ, " & _
                                       " DEBPAYDATE AS ≈Œœ÷À«”«, LASTDATE AS  …Õ«”« " & _
                                     " from TableDebits where Lastdate between " & CDec(datef.Value.ToString("yyyMMdd")) & " and " & CDec(datet.Value.ToString("yyyMMdd")) & _
                                     " order by debdesc, aa, lastdate"


            Dim adapter1 As New Odbc.OdbcDataAdapter(SqlString1, MyConnection)
            Dim Dset1 As New DataSet
            If MyConnection.State = ConnectionState.Closed Then
                MyConnection.Open()
            End If
            Dset1.Clear()
            adapter1.Fill(Dset1)
            MyConnection.Close()

            dg1.Columns.Clear()
            dg1.DataSource = Dset1.Tables(0)
            NmSum.Value = 0
            NmKostos.Value = 0
            NmKerdos.Value = 0
            Button1.Visible = False
        End If

    End Sub

    Private Sub datef_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles datef.ValueChanged

    End Sub

    Private Sub btnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefresh.Click
        Call FILLGRID()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        PrintDocument1.Print()
    End Sub

    Private Sub PrintDocument1_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim i As Integer
        Dim line As Integer = 15
        e.Graphics.DrawString(Date.Now & " ¡/¡ " & aa, New Font("Arial", 8, FontStyle.Bold), Brushes.Blue, 5, line)
        line += 15
        e.Graphics.DrawString("œ–Ÿ—œ–¡Õ‘œ–ŸÀ≈…œ ¡À≈Œ¡Õƒ—¡ «” ‘«À.2107643761", New Font("Arial", 8, FontStyle.Bold), Brushes.Blue, 5, line)
        line += 15

        e.Graphics.DrawString("≈…ƒœ”", New Font("Arial", 6, FontStyle.Bold), Brushes.Blue, 15, line)
        e.Graphics.DrawString("–œ”œ‘«‘¡", New Font("Arial", 6, FontStyle.Bold), Brushes.Blue, 180, line)
        e.Graphics.DrawString("‘…Ã« ÃœÕ.", New Font("Arial", 6, FontStyle.Bold), Brushes.Blue, 240, line)
        e.Graphics.DrawString("¡Œ…¡", New Font("Arial", 6, FontStyle.Bold), Brushes.Blue, 290, line)
        line += 15

        For i = 1 To dg1.Rows.Count

            If dg1.Rows(i - 1).Cells(1).Value.ToString.Length <= 25 Then
                e.Graphics.DrawString(dg1.Rows(i - 1).Cells(2).Value.ToString, New Font("Arial", 6, FontStyle.Bold), Brushes.Blue, 15, line)
            Else
                e.Graphics.DrawString(dg1.Rows(i - 1).Cells(2).Value.ToString.Substring(0, 25), New Font("Arial", 6, FontStyle.Bold), Brushes.Blue, 15, line)
            End If
            e.Graphics.DrawString(dg1.Rows(i - 1).Cells(4).Value.ToString, New Font("Arial", 6, FontStyle.Bold), Brushes.Blue, 200, line)
            e.Graphics.DrawString(dg1.Rows(i - 1).Cells(3).Value.ToString, New Font("Arial", 6, FontStyle.Bold), Brushes.Blue, 240, line)
            e.Graphics.DrawString(dg1.Rows(i - 1).Cells(5).Value.ToString, New Font("Arial", 6, FontStyle.Bold), Brushes.Blue, 290, line)
            line += 15
        Next
        e.Graphics.DrawString("”’ÕœÀœ", New Font("Arial", 10, FontStyle.Bold), Brushes.Blue, 180, line)
        e.Graphics.DrawString(NmSum.Text, New Font("Arial", 10, FontStyle.Bold), Brushes.Blue, 280, line)
        line += 15
        e.Graphics.DrawString("‘œ –¡—œÕ ƒ≈Õ …”◊’≈… √…¡ ‘«Õ ≈÷œ—…¡", New Font("Arial", 10, FontStyle.Bold), Brushes.Blue, 15, line)
        line += 15
        e.Graphics.DrawString("≈’◊¡—…”‘œ’Ã≈ √…¡ ‘«Õ –—œ‘…Ã«”« ”¡”", New Font("Arial", 10, FontStyle.Bold), Brushes.Blue, 15, line)
        line += 15
    End Sub

    Private Sub AddRemains()

        Dim i As Integer
        Dim index As Integer
        For i = 0 To dg1.SelectedRows.Count - 1
            index = dg1.Rows.IndexOf(dg1.SelectedRows.Item(i))
            If MsgBox("ƒÈ·„Ò·ˆﬁ " & dg1.Item(2, index).Value, MsgBoxStyle.OkCancel, "") = MsgBoxResult.Ok Then
                Dim SqlUpdateD As String = "Update TableRem set " & _
                            "Rem = Rem + '" & dg1.Item(4, index).Value & "' " & _
                            " where ItemCode  =" & dg1.Item(1, index).Value

                Dim SqlDeleteD As String = "Delete from SalesTable where " & _
                           " AA = " & aa & " and SalDat = " & dg1.Item(8, index).Value & _
                           " and ItemCode  =" & dg1.Item(1, index).Value

                If MyConnection.State = ConnectionState.Closed Then
                    MyConnection.Open()
                End If
                trans = MyConnection.BeginTransaction
                MyCommand = New Odbc.OdbcCommand(SqlUpdateD, MyConnection, trans)
                MyCommand.CommandType = CommandType.Text
                MyCommand.ExecuteNonQuery()
                trans.Commit()

                trans = MyConnection.BeginTransaction
                MyCommand = New Odbc.OdbcCommand(SqlDeleteD, MyConnection, trans)
                MyCommand.CommandType = CommandType.Text
                MyCommand.ExecuteNonQuery()
                trans.Commit()
                MyConnection.Close()
            End If
        Next
        Button1.Visible = False
        Call FILLGRID()
    End Sub

    Private Sub Delete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Delete.Click
        If RadioButton1.Checked And Button1.Visible Then
            Call AddRemains()
        Else
            MsgBox("ƒÂÌ „ﬂÌÂÙ·È ‰È·„Ò·ˆﬁ ·¸ ·ıÙ¸ ÙÔ ÛÁÏÂﬂÔ", MsgBoxStyle.OkOnly)
        End If
    End Sub

    

    

  
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        DataGridToExcel(dg1, "Fruitshop")
    End Sub

    Private Sub ◊Ò›ÔÚToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ◊Ò›ÔÚToolStripMenuItem.Click
        If RadioButton1.Checked And Button1.Visible = False Then
            Dim form3 As New Form3

            Dim i As Integer
            Dim index As Integer
            For i = 0 To dg1.SelectedRows.Count - 1
                index = dg1.Rows.IndexOf(dg1.SelectedRows.Item(i))
                Call form3.LoadForm(dg1.Rows(index).Cells(0).Value, dg1.Rows(index).Cells(4).Value, "Debit")
            Next

        Else
            MsgBox("ƒÂÌ „ﬂÌÂÙ·È ˜Ò›ÔÚ ·¸ ·ıÙ¸ ÙÔ ÛÁÏÂﬂÔ", MsgBoxStyle.OkOnly)
        End If
    End Sub

    Private Sub AddToDebits()

        

    End Sub
End Class