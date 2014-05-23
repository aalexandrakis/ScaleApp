Imports System.IO.stream
Public Class Form1
    Private aa As Integer
    Dim a As Integer = 0
    Private PortName As String = ""
    Private WithEvents Myserial As New System.IO.Ports.SerialPort
    Private CNTTYPE As String
    
    Private itemexist As Boolean
    Private ScaleExists As Boolean


    
    Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Dim sqlString As String = "Select PortName from TablePortName "
        Dim adapter1 As New Odbc.OdbcDataAdapter(sqlString, MyConnection)
        Dim Dset1 As New DataSet

        Me.WindowState = FormWindowState.Maximized


        If MyConnection.State = ConnectionState.Closed Then
            MyConnection.Open()
        End If
        Dset1.Clear()
        adapter1.Fill(Dset1)
        MyConnection.Close()

        PortName = Dset1.Tables(0).Rows(0).Item(0)
        '(PortName, 9600, IO.Ports.Parity.Even, 8, IO.Ports.StopBits.One)
        Myserial.PortName = PortName
        Myserial.BaudRate = 9600
        'Myserial.Parity = IO.Ports.Parity.None
        Myserial.Parity = IO.Ports.Parity.Even
        Myserial.DataBits = 8
        Myserial.StopBits = IO.Ports.StopBits.One

        ScaleExists = True

        Try
            Myserial.Open()
        Catch ex As Exception
            ScaleExists = False
            If MsgBox("‰ÂÌ ‚Ò›ËÁÍÂ Êı„·ÒÈ‹. –‹Ù· OK „È· ÛıÌ›˜ÂÈ· ﬁ Cancel „È· ·Í˝Ò˘ÛÁ", MsgBoxStyle.OkOnly, "Error") = MsgBoxResult.Ok Then

            Else
                Me.Close()
            End If
        End Try

        DG1.Columns.Clear()
        DG1.Columns.Add("CODE", " Ÿƒ… œ”")
        DG1.Columns.Add("DESC", "≈…ƒœ”")
        DG1.Columns.Add("CNT", "–œ”œ‘«‘¡")
        DG1.Columns.Add("SelPrice", "‘…Ã« ÃœÕ¡ƒœ”")
        DG1.Columns.Add("LTotal", "¡Œ…¡")
        DG1.Columns.Add("FPA", "÷–¡")
        DG1.Columns.Add("EIDPRICE", "EIDPRICE")
        DG1.Columns(6).Width = 0
        DG1.Columns.Add("SELPRICEH", "SELPRICEH")
        DG1.Columns(7).Width = 0

        Call DEBITSUB()
    End Sub


    Private Sub Getweight()
        If ScaleExists = False Then
            Exit Sub
        End If

        Dim ScaleLine As String = ""
        Dim StrWeight As String = ""

       
        Do While Myserial.BytesToRead <> 0
            ScaleLine = Myserial.ReadLine
        Loop
        If ScaleLine = "" Then
            Exit Sub
        End If

        Myserial.Write("@C" & Constants.vbCr & "000.000" & Constants.vbCr & "400.000" & Constants.vbCr & "U" & UPRICE.Value.ToString & Constants.vbCr & "T000.000" & Constants.vbCrLf)

        StrWeight = ScaleLine.Substring(3, 7)
        StrWeight = StrWeight.Replace(".", ",")
        If IsNumeric(StrWeight) Then
            Weight.Value = CDec(StrWeight)
        End If
    End Sub


    Private Sub AddToList()
        If itemexist = False Then
            MsgBox("À‹ËÔÚ Í˘‰ÈÍ¸Ú Âﬂ‰ÔıÚ", MsgBoxStyle.OkOnly, "À‹ËÔÚ")
            ItemCode.Focus()
            Exit Sub
        End If

        If Weight.Value = 0 Then
            MsgBox("ƒÂÌ ı‹Ò˜ÂÈ ÔÛ¸ÙÁÙ·", MsgBoxStyle.OkOnly, "À‹ËÔÚ")
            Weight.Focus()
            Exit Sub
        End If

        If UPRICE.Value = 0 Then
            MsgBox("‘Ô Âﬂ‰ÔÚ ‰ÂÌ ›˜ÂÈ ÙÈÏﬁ", MsgBoxStyle.OkOnly, "À‹ËÔÚ")
            ItemCode.Focus()
            Exit Sub
        End If

        

        Stotal.Value = Weight.Value * UPRICE.Value
        'UPRICE.Value = UPRICE.Value.ToString.Replace(".", ",")
        Dim ROWCNT As Integer
        dg1.Rows.Add()
        ROWCNT = dg1.Rows.Count - 1
        dg1.Item(0, ROWCNT).Value = ItemCode.Text
        dg1.Item(1, ROWCNT).Value = ItemDes.Text
        dg1.Item(2, ROWCNT).Value = Weight.Text
        dg1.Item(3, ROWCNT).Value = UPRICE.Text
        dg1.Item(4, ROWCNT).Value = Stotal.Text
        dg1.Item(5, ROWCNT).Value = txtFpa.Value
        dg1.Item(6, ROWCNT).Value = EidPrice.Value
        DG1.Item(7, ROWCNT).Value = nmTimiHidden.Value
        Call summary()
        Weight.Value = 0
        UPRICE.Value = 0
        Stotal.Value = 0

        ItemCode.Text = ""
        ItemCode.Focus()


    End Sub
    Private Sub summary()
        Dim i As Integer
        Dim Index As Integer
        Dim FpaAr As Decimal() = New Decimal() {0, 0, 0, 0}
        Dim PosAr As Decimal() = New Decimal() {0, 0, 0, 0}

        GTOTAL.Value = 0
        For i = 1 To dg1.Rows.Count
            GTOTAL.Value += dg1.Rows(i - 1).Cells(4).Value
            If FpaAr(0) = 0 Then
                Index = 0
            Else
                Index = GetFpaIndex(dg1.Rows(i - 1).Cells(5).Value, FpaAr)
            End If
            FpaAr.SetValue(dg1.Rows(i - 1).Cells(5).Value, Index)
            PosAr.SetValue(PosAr(Index) + CDec(dg1.Rows(i - 1).Cells(4).Value), Index)

        Next
        LINECOUNT.Value = dg1.Rows.Count
        rt1.Clear()
        For i = 1 To FpaAr.Length
            rt1.AppendText(PosAr(i - 1).ToString & "-" & FpaAr(i - 1).ToString & "%" & Constants.vbCr)
        Next

    End Sub
    Private Function GetFpaIndex(ByVal FPAPER As Decimal, ByVal fpaar As Decimal()) As Integer
        Dim s As Integer
        For s = 0 To fpaar.Length - 1
            If FPAPER = fpaar(s) Or fpaar(s) = 0 Then
                Return s
            End If

        Next
    End Function


    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ItemCode.TextChanged
        itemexist = False
        'ItemDes.Text = ""


        If Not IsNumeric(ItemCode.Text) Then Exit Sub

        Dim sqlString As String = "Select * from TableEidos where EidCod=" & Trim(ItemCode.Text.ToString)
        Dim adapter1 As New Odbc.OdbcDataAdapter(sqlString, MyConnection)
        Dim Dset1 As New DataSet
        If MyConnection.State = ConnectionState.Closed Then
            MyConnection.Open()
        End If
        Dset1.Clear()
        adapter1.Fill(Dset1)
        MyConnection.Close()

        If Dset1.Tables(0).Rows.Count > 0 Then
            itemexist = True
            ItemDes.Text = Dset1.Tables(0).Rows(0).Item("EidDes")
            UPRICE.Value = Dset1.Tables(0).Rows(0).Item("SelPrice")
            CNTTYPE = Dset1.Tables(0).Rows(0).Item("CouCod")
            txtFpa.Value = Dset1.Tables(0).Rows(0).Item("fpa")
            EidPrice.Value = Dset1.Tables(0).Rows(0).Item("EidPrice")
            nmTimiHidden.Value = Dset1.Tables(0).Rows(0).Item("SelPrice")

            If CNTTYPE = "1" Then
                Label2.Text = "¬¡—œ”"
                Timer1.Enabled = True
                Weight.ReadOnly = True
                If ScaleExists = True Then
                    Weight.Enabled = False
                Else
                    Weight.Enabled = True
                End If
            Else
                Label2.Text = "TEMAXIA"
                Timer1.Enabled = False
                Weight.ReadOnly = False
                Weight.Enabled = True
                Weight.Value = 1
            End If
                If txtDiscount.Value > 0 Then
                    UPRICE.Value = Math.Round(CDec(UPRICE.Value - (UPRICE.Value * txtDiscount.Value / 100)), 2)
                End If
                Stotal.Value = Weight.Value * UPRICE.Value
                'Call Getweight()
                'Stotal.Value = Weight.Value * UPRICE.Value
            End If
    End Sub

    Private Sub Weight_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Weight.GotFocus
        Weight.Select(0, Weight.Value.ToString.Length)
    End Sub



    Private Sub UPRICE_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles UPRICE.GotFocus
        UPRICE.Select(0, UPRICE.Value.ToString.Length)
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Call Getweight()
        'Stotal.Value = Weight.Value * UPRICE.Value

    End Sub


    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        aa = 0
        PrintDocument1.Print()
    End Sub

    Private Sub PrintDocument1_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim i As Integer
        Dim line As Integer = 15
        e.Graphics.DrawString(Date.Now & " ¡/¡ " & aa, New Font("Arial", 8, FontStyle.Bold), Brushes.Blue, 5, line)
        line += 15
        e.Graphics.DrawString("œ–Ÿ—œ–¡Õ‘œ–ŸÀ≈…œ ¡À≈Œ¡Õƒ—¡ «” ‘«À.2107643761", New Font("Arial", 8, FontStyle.Bold), Brushes.blue, 5, line)
        line += 15

        e.Graphics.DrawString("≈…ƒœ”", New Font("Arial", 6, FontStyle.Bold), Brushes.blue, 15, line)
        e.Graphics.DrawString("–œ”œ‘«‘¡", New Font("Arial", 6, FontStyle.Bold), Brushes.blue, 180, line)
        e.Graphics.DrawString("‘…Ã« ÃœÕ.", New Font("Arial", 6, FontStyle.Bold), Brushes.blue, 240, line)
        e.Graphics.DrawString("¡Œ…¡", New Font("Arial", 6, FontStyle.Bold), Brushes.blue, 290, line)
        line += 15

        For i = 1 To dg1.Rows.Count

            If dg1.Rows(i - 1).Cells(1).Value.ToString.Length <= 25 Then
                e.Graphics.DrawString(dg1.Rows(i - 1).Cells(1).Value.ToString, New Font("Arial", 6, FontStyle.Bold), Brushes.blue, 15, line)
            Else
                e.Graphics.DrawString(dg1.Rows(i - 1).Cells(1).Value.ToString.Substring(0, 25), New Font("Arial", 6, FontStyle.Bold), Brushes.blue, 15, line)
            End If
            e.Graphics.DrawString(dg1.Rows(i - 1).Cells(2).Value.ToString, New Font("Arial", 6, FontStyle.Bold), Brushes.blue, 200, line)
            e.Graphics.DrawString(dg1.Rows(i - 1).Cells(3).Value.ToString, New Font("Arial", 6, FontStyle.Bold), Brushes.blue, 240, line)
            e.Graphics.DrawString(dg1.Rows(i - 1).Cells(4).Value.ToString, New Font("Arial", 6, FontStyle.Bold), Brushes.blue, 290, line)
            line += 15
        Next
        e.Graphics.DrawString("”’ÕœÀœ", New Font("Arial", 10, FontStyle.Bold), Brushes.blue, 180, line)
        e.Graphics.DrawString(GTOTAL.Text, New Font("Arial", 10, FontStyle.Bold), Brushes.blue, 280, line)
        line += 15
        e.Graphics.DrawString("‘œ –¡—œÕ ƒ≈Õ …”◊’≈… √…¡ ‘«Õ ≈÷œ—…¡", New Font("Arial", 10, FontStyle.Bold), Brushes.Blue, 15, line)
        line += 15
        e.Graphics.DrawString("≈’◊¡—…”‘œ’Ã≈ √…¡ ‘«Õ –—œ‘…Ã«”« ”¡”", New Font("Arial", 10, FontStyle.Bold), Brushes.Blue, 15, line)
        line += 15
    End Sub
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If ItemCode.Text.Trim.Length > 5 Then
            If ItemCode.Text.Substring(0, 5) = "*port" Then
                If MsgBox("¡ÎÎ·„ﬁ PortName ÛÂ " & ItemCode.Text.Substring(5), MsgBoxStyle.OkCancel, "¡ÎÎ·„ﬁ PortName") = MsgBoxResult.Ok Then
                    Dim SqlUpdateD As String = "Update TablePortName set " & _
                                          "PortName = '" & ItemCode.Text.Substring(5) & "'"

                    If MyConnection.State = ConnectionState.Closed Then
                        MyConnection.Open()
                    End If
                    trans = MyConnection.BeginTransaction
                    MyCommand = New Odbc.OdbcCommand(SqlUpdateD, MyConnection, trans)
                    MyCommand.CommandType = CommandType.Text
                    MyCommand.ExecuteNonQuery()
                    trans.Commit()
                    MyConnection.Close()

                    Me.Close()
                End If
                ItemCode.Text = ""
                Exit Sub
            End If
        End If
        If ItemCode.Text = "**##" Then
            Call SHOWCODES()
            Exit Sub
        End If


        If ItemCode.Text = "*K" Or ItemCode.Text = "*k" Or _
            ItemCode.Text = "* " Or ItemCode.Text = "*Í" Then
            Call FindKostos()
            ItemCode.Text = ""
            Exit Sub
        End If

        If ItemCode.Text = "*E" Or ItemCode.Text = "*e" Or _
            ItemCode.Text = "*≈" Or ItemCode.Text = "*Â" Then
            Call GetDiscount()
            ItemCode.Text = ""
            Exit Sub
        End If

        If ItemCode.Text = "*" Then
            ItemCode.Text = ""
            Call INSERT2DB()
            PrintDocument1.Print()
            DG1.Rows.Clear()
            Call summary()
            txtDiscount.Value = 0
            Exit Sub
        End If
        If ItemCode.Text = "**" Then
            ItemCode.Text = ""
            Call INSERT2DB()
            DG1.Rows.Clear()
            Call summary()
            txtDiscount.Value = 0
            Exit Sub
        End If

        If ItemCode.Text = "*9*" Then
            ItemCode.Text = ""
            DG1.Rows.Clear()
            Call PrintLast()
            Call summary()
            Exit Sub
        End If

        If ItemCode.Text = "*11*" Then
            ItemCode.Text = ""
            Call AddToDestroys()
            DG1.Rows.Clear()
            Call summary()
            Exit Sub
        End If

        If ItemCode.Text = "*12*" Then
            ItemCode.Text = ""
            Call AddToBuy()
            DG1.Rows.Clear()
            Call summary()
            Exit Sub
        End If

        If ItemCode.Text = "*13*" Then
            Call DAILYSALES()
            Exit Sub
        End If

        Call AddToList()
        ItemDes.Text = ""

    End Sub


    Private Sub dg1_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dg1.KeyUp
        If e.KeyCode = Keys.Delete Then
            Call summary()
        End If
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Call INSERT2DB()
        PrintDocument1.Print()
        dg1.Rows.Clear()
        Call summary()
    End Sub
    Private Sub INSERT2DB()
        Dim sqlString As String = "Select MAX(AA) from SalesTable where saldat=" & CDec(Date.Now.ToString("yyyMMdd"))
        Dim adapter1 As New Odbc.OdbcDataAdapter(sqlString, MyConnection)
        Dim Dset1 As New DataSet
        
        If MyConnection.State = ConnectionState.Closed Then
            MyConnection.Open()
        End If
        Dset1.Clear()
        adapter1.Fill(Dset1)
        MyConnection.Close()

        If IsDBNull(Dset1.Tables(0).Rows(0).Item(0)) Then
            aa = 1
        Else
            aa = Dset1.Tables(0).Rows(0).Item(0) + 1
        End If
        Dim i As Integer
        For i = 1 To dg1.Rows.Count
            Dim sqlString2 As String = "Insert into SalesTable Values (" & aa & ", '" & CInt(Date.Now.ToString("yyyyMMdd")) & "', '" & CInt(Date.Now.ToString("Hmm")) & "', '" & _
            dg1.Rows(i - 1).Cells(0).Value & "', '" & dg1.Rows(i - 1).Cells(2).Value & "', '" & dg1.Rows(i - 1).Cells(3).Value & "', '" & dg1.Rows(i - 1).Cells(4).Value & "', '" & dg1.Rows(i - 1).Cells(6).Value & "')"

            If MyConnection.State = ConnectionState.Closed Then
                MyConnection.Open()
            End If
            trans = MyConnection.BeginTransaction
            MyCommand = New Odbc.OdbcCommand(sqlString2, MyConnection, trans)
            MyCommand.CommandType = CommandType.Text
            MyCommand.ExecuteNonQuery()
            trans.Commit()
            MyConnection.Close()



        Next

        Call SubRemains()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Timer1.Enabled = False
        Myserial.Close()
        Dim form1a As New Form1
        form1a.ShowDialog()
        Myserial.Open()
        Timer1.Enabled = True
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Timer1.Enabled = False
        Myserial.Close()
        Me.Close()
    End Sub

    Private Sub ItemDes_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ItemDes.KeyUp
        If e.KeyCode = Keys.Back Or e.KeyCode = Keys.Space Then
            ItemCode.Text = ""
            UPRICE.Value = 0
            Exit Sub
        End If

        itemexist = False
        ItemDes.Text.Trim()

        Dim SqlSelectEid As String
        Dim Leng As Integer
        'MsgBox(ItemDes.Text.Length, MsgBoxStyle.OkOnly)

        If e.KeyCode = Keys.Up Then
            SqlSelectEid = "Select * from TableEidos where trim(EidDes) < '" & ItemDes.Text.Trim & " ' ORDER BY EIDDES desc"
        ElseIf e.KeyCode = Keys.Down Then
            SqlSelectEid = "Select * from TableEidos where trim(EidDes) > '" & ItemDes.Text.Trim & " ' ORDER BY EIDDES"
        Else
            SqlSelectEid = "Select * from TableEidos where lEFT(EidDes, " & ItemDes.Text.Length & ") = '" & ItemDes.Text & " ' ORDER BY EIDDES"
        End If




        Dim adapter1 As New Odbc.OdbcDataAdapter(SqlSelectEid, MyConnection)
        Dim Dset1 As New DataSet
        Leng = ItemDes.Text.Trim.Length
        If ItemDes.Text <> "" Then
            If MyConnection.State = ConnectionState.Closed Then
                MyConnection.Open()
            End If
            Dset1.Clear()
            adapter1.Fill(Dset1)
            MyConnection.Close()

            If Dset1.Tables(0).Rows.Count > 0 Then
                itemexist = True
                ItemCode.Text = Dset1.Tables(0).Rows(0).Item("Eidcod")
                ItemDes.Text = Dset1.Tables(0).Rows(0).Item("EidDes")
                UPRICE.Value = Dset1.Tables(0).Rows(0).Item("SelPrice")
                CNTTYPE = Dset1.Tables(0).Rows(0).Item("CouCod")
                txtFpa.Value = Dset1.Tables(0).Rows(0).Item("fpa")
                EidPrice.Value = Dset1.Tables(0).Rows(0).Item("EidPrice")
                ItemDes.Select(Leng, ItemDes.Text.Trim.Length - Leng)
                If CNTTYPE = "1" Then
                    Label2.Text = "¬¡—œ”"
                    Timer1.Enabled = True
                    Weight.ReadOnly = True
                    If ScaleExists = True Then
                        Weight.Enabled = False
                    Else
                        Weight.Enabled = True
                    End If
                Else
                    Label2.Text = "TEMAXIA"
                    Timer1.Enabled = False
                    Weight.ReadOnly = False
                    Weight.Enabled = True
                    Weight.Value = 1
                End If
                If txtDiscount.Value > 0 Then
                    UPRICE.Value = Math.Round(CDec(UPRICE.Value - (UPRICE.Value * txtDiscount.Value / 100)), 2)
                End If
                Stotal.Value = Weight.Value * UPRICE.Value
            Else

            End If
        Else

        End If
    End Sub
    Private Sub PrintLast()
        Dim sqlString As String = "Select MAX(AA) from SalesTable where saldat=" & CDec(Date.Now.ToString("yyyMMdd"))
        Dim adapter1 As New Odbc.OdbcDataAdapter(sqlString, MyConnection)
        Dim Dset1 As New DataSet

        If MyConnection.State = ConnectionState.Closed Then
            MyConnection.Open()
        End If
        Dset1.Clear()
        adapter1.Fill(Dset1)
        MyConnection.Close()

        If IsDBNull(Dset1.Tables(0).Rows(0).Item(0)) Then
            MsgBox("ƒÂÌ ›˜ÂÈ ÂÍ‰ÔËÂﬂ ÎÔ„·ÒÈ·Ï¸Ú ÛﬁÏÂÒ·")
            Exit Sub
        Else
            aa = Dset1.Tables(0).Rows(0).Item(0)
        End If

        Dim sqlStringA As String = "Select * from SalesTable inner join tableEidos on SALESTABLE.Itemcode = TABLEEIDOS.EidCod " & _
        " where saldat=" & CDec(Date.Now.ToString("yyyMMdd")) & " and AA = " & aa
        Dim adapterA As New Odbc.OdbcDataAdapter(sqlStringA, MyConnection)
        Dim DsetA As New DataSet

        If MyConnection.State = ConnectionState.Closed Then
            MyConnection.Open()
        End If
        DsetA.Clear()
        adapterA.Fill(DsetA)
        MyConnection.Close()
        Dim i As Integer
        For i = 1 To DsetA.Tables(0).Rows.Count
            dg1.Rows.Add()
            dg1.Item(0, i - 1).Value = DsetA.Tables(0).Rows(i - 1).Item("Itemcode")
            dg1.Item(1, i - 1).Value = DsetA.Tables(0).Rows(i - 1).Item("EidDes")
            dg1.Item(2, i - 1).Value = DsetA.Tables(0).Rows(i - 1).Item("COUNT")
            dg1.Item(3, i - 1).Value = DsetA.Tables(0).Rows(i - 1).Item("Uprice")
            dg1.Item(4, i - 1).Value = DsetA.Tables(0).Rows(i - 1).Item("Tprice")
            dg1.Item(5, i - 1).Value = DsetA.Tables(0).Rows(i - 1).Item("Fpa")
        Next
        Call summary()
        PrintDocument1.Print()
        dg1.Rows.Clear()
    End Sub

    Private Sub AddToDestroys()

        Dim i As Integer
        For i = 1 To dg1.Rows.Count
            Dim sqlString2 As String = "Insert into DestroysTable Values ('" & CInt(Date.Now.ToString("yyyyMMdd")) & "', '" & _
            dg1.Rows(i - 1).Cells(0).Value & "', '" & dg1.Rows(i - 1).Cells(2).Value & "', '" & dg1.Rows(i - 1).Cells(6).Value & "', '" & dg1.Rows(i - 1).Cells(2).Value * dg1.Rows(i - 1).Cells(6).Value & "')"

            If MyConnection.State = ConnectionState.Closed Then
                MyConnection.Open()
            End If
            trans = MyConnection.BeginTransaction
            MyCommand = New Odbc.OdbcCommand(sqlString2, MyConnection, trans)
            MyCommand.CommandType = CommandType.Text
            MyCommand.ExecuteNonQuery()
            trans.Commit()
            MyConnection.Close()
        Next


        Call SubRemains()
    End Sub

    Private Sub AddToBuy()

        Dim i As Integer
        For i = 1 To dg1.Rows.Count
            Dim sqlString2 As String = "Insert into BuyTable Values ('" & CInt(Date.Now.ToString("yyyyMMdd")) & "', '" & _
            dg1.Rows(i - 1).Cells(0).Value & "', '" & dg1.Rows(i - 1).Cells(2).Value & "', '" & dg1.Rows(i - 1).Cells(6).Value & "', '" & dg1.Rows(i - 1).Cells(2).Value * dg1.Rows(i - 1).Cells(6).Value & "')"

            If MyConnection.State = ConnectionState.Closed Then
                MyConnection.Open()
            End If
            trans = MyConnection.BeginTransaction
            MyCommand = New Odbc.OdbcCommand(sqlString2, MyConnection, trans)
            MyCommand.CommandType = CommandType.Text
            MyCommand.ExecuteNonQuery()
            trans.Commit()
            MyConnection.Close()
        Next


        Call SubRemains()
    End Sub
    Private Sub DAILYSALES()
        Dim Salesresults As String = ""

        Dim sqlString As String = "Select CODCAT, DESCAT, SUM(TPRICE) FROM salesdetail " & _
        " where saldat=" & CDec(Date.Now.ToString("yyyMMdd")) & " group by codcat, descat"
        Dim adapter1 As New Odbc.OdbcDataAdapter(sqlString, MyConnection)
        Dim Dset1 As New DataSet

        If MyConnection.State = ConnectionState.Closed Then
            MyConnection.Open()
        End If
        Dset1.Clear()
        adapter1.Fill(Dset1)
        MyConnection.Close()
        Dim summary As Decimal

        Dim i As Integer = 0
        For i = 1 To Dset1.Tables(0).Rows.Count
            Salesresults = Salesresults & Constants.vbCr & _
                            Dset1.Tables(0).Rows(i - 1).Item(0) & "-" & _
                            Dset1.Tables(0).Rows(i - 1).Item(1) & "-" & _
                            Dset1.Tables(0).Rows(i - 1).Item(2)
            summary += Dset1.Tables(0).Rows(i - 1).Item(2)
        Next
        Salesresults = Salesresults & Constants.vbCr & "”’ÕœÀœ " & summary

        Dim sqlString2 As String = "Select MAX(AA) from SalesTable where saldat=" & CDec(Date.Now.ToString("yyyMMdd"))
        Dim adapter2 As New Odbc.OdbcDataAdapter(sqlString2, MyConnection)
        Dim Dset2 As New DataSet

        If MyConnection.State = ConnectionState.Closed Then
            MyConnection.Open()
        End If
        Dset2.Clear()
        adapter2.Fill(Dset2)
        MyConnection.Close()
        Dim BB As Integer
        If IsDBNull(Dset2.Tables(0).Rows(0).Item(0)) Then
            MsgBox("ƒÂÌ ›˜ÂÈ ÂÍ‰ÔËÂﬂ ÎÔ„·ÒÈ·Ï¸Ú ÛﬁÏÂÒ·")
            Exit Sub
        Else
            BB = Dset2.Tables(0).Rows(0).Item(0)
        End If
        Salesresults = Salesresults & Constants.vbCr & "¡–œƒ≈…Œ≈…” " & BB
        MsgBox(Salesresults, MsgBoxStyle.OkOnly, "«ÏÂÒﬁÛÈ· ¡Ì·ˆÔÒ‹")
        ItemCode.Text = ""

    End Sub

    Private Sub SHOWCODES()
        Dim Salesresults As String = ""

        Dim sqlString As String = "Select * FROM TABLECODES "

        Dim adapter1 As New Odbc.OdbcDataAdapter(sqlString, MyConnection)
        Dim Dset1 As New DataSet

        If MyConnection.State = ConnectionState.Closed Then
            MyConnection.Open()
        End If
        Dset1.Clear()
        adapter1.Fill(Dset1)
        MyConnection.Close()

        Dim i As Integer = 0
        For i = 1 To Dset1.Tables(0).Rows.Count
            Salesresults = Salesresults & Constants.vbCr & _
                            Dset1.Tables(0).Rows(i - 1).Item(0) & "-" & _
                            Dset1.Tables(0).Rows(i - 1).Item(1) 
        Next

        MsgBox(Salesresults, MsgBoxStyle.OkOnly, "HELP CODES")
        ItemCode.Text = ""

    End Sub
    Private Sub ItemDes_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ItemDes.TextChanged

    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Dim FrmEidosView As New FrmEidosView
        FrmEidosView.ShowDialog()

    End Sub


    Private Sub Weight_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Weight.ValueChanged
        

        Stotal.Value = Weight.Value * UPRICE.Value
    End Sub

    Private Sub SubRemains()

        Dim i As Integer
        For i = 0 To dg1.Rows.Count - 1
            Dim SqlUpdateD As String = "Update TableRem set " & _
                        "Rem = Rem - '" & dg1.Item(2, i).Value & "' " & _
                        " where ItemCode  =" & dg1.Item(0, i).Value
            If MyConnection.State = ConnectionState.Closed Then
                MyConnection.Open()
            End If
            trans = MyConnection.BeginTransaction
            MyCommand = New Odbc.OdbcCommand(SqlUpdateD, MyConnection, trans)
            MyCommand.CommandType = CommandType.Text
            MyCommand.ExecuteNonQuery()
            trans.Commit()
            MyConnection.Close()

        Next

    End Sub

    Private Sub MakeRemains()
        dg1.Columns.Clear()
        Dim sqlString As String = "SELECT SalesTable.ItemCode, TableEidos.EidDes, Sum(SalesTable.Count) AS SumOfCount " & _
        " FROM SalesTable INNER JOIN TableEidos ON SalesTable.ItemCode = TableEidos.EidCod " & _
        " WHERE (((SalesTable.SalDat)>=20111231)) OR (((SalesTable.SalDat)>=20111230) AND ((TableEidos.CodCat)=9) AND ((SalesTable.SalTim)>=549)) OR (((SalesTable.SalDat)>=20111230) AND ((TableEidos.CodCat) In (13,5,6,3)) AND ((SalesTable.SalTim)>=1801)) OR (((SalesTable.SalDat)>=20111230) AND ((TableEidos.CodCat) In (12,4,8,11)) AND ((SalesTable.SalTim)>=1635)) " & _
        " GROUP BY SalesTable.ItemCode, TableEidos.EidDes"

        'Dim sqlString As String = "SELECT BuyTable.ItemCode, TableEidos.EidDes, Sum(BuyTable.Count) AS SumOfCount " & _
        '" FROM BuyTable INNER JOIN TableEidos ON BuyTable.ItemCode = TableEidos.EidCod " & _
        '" WHERE BuyTable.SalDat>=20111231 " & _
        '" GROUP BY BuyTable.ItemCode, TableEidos.EidDes"

        'Dim sqlString As String = "SELECT DestroysTable.ItemCode, TableEidos.EidDes, Sum(DestroysTable.Count) AS SumOfCount " & _
        '" FROM DestroysTable INNER JOIN TableEidos ON DestroysTable.ItemCode = TableEidos.EidCod " & _
        '" WHERE DestroysTable.SalDat>=20111231 " & _
        '" GROUP BY DestroysTable.ItemCode, TableEidos.EidDes"

        Dim adapter1 As New Odbc.OdbcDataAdapter(sqlString, MyConnection)
        Dim Dset1 As New DataSet

        If MyConnection.State = ConnectionState.Closed Then
            MyConnection.Open()
        End If
        Dset1.Clear()
        adapter1.Fill(Dset1)
        MyConnection.Close()
        dg1.DataSource = Dset1.Tables(0)
    End Sub


    Private Sub FindKostos()
        GTOTAL.Value = 0
        Dim i As Integer = 0
        For i = 1 To DG1.Rows.Count
            DG1.Item("SelPrice", i - 1).Value = DG1.Item(6, i - 1).Value
            DG1.Item("lTOTAL", i - 1).Value = DG1.Item("SelPrice", i - 1).Value * DG1.Item("CNT", i - 1).Value
            'GTOTAL.Value += DG1.Item(2, i - 1).Value * DG1.Item(6, i - 1).Value
        Next
        Call summary()
    End Sub

    Private Sub GetDiscount()
        Dim i As Integer = 0
        If txtDiscount.Value = 0 Then
            Exit Sub
        End If

        For i = 1 To dg1.Rows.Count
            DG1.Item("SELPRICE", i - 1).Value = Math.Round(DG1.Item("SELPRICE", i - 1).Value - (DG1.Item("SELPRICE", i - 1).Value * txtDiscount.Value / 100), 2)
            DG1.Item("LTOTAL", i - 1).Value = Math.Round(CDec(DG1.Item("SELPRICE", i - 1).Value * DG1.Item("CNT", i - 1).Value), 2)
        Next
        txtDiscount.Value = 0
        Call summary()
    End Sub

    Private Sub txtDiscount_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDiscount.GotFocus
        txtDiscount.Select(0, txtDiscount.Value.ToString.Length)
    End Sub

    Private Sub DEBITSUB()

        Dim sqlStringD As String = "Select DebDesc, sum(DebAmmount) from TableDebits where DebPayDate = 0 group by DebDesc "
        Dim adapterD As New Odbc.OdbcDataAdapter(sqlStringD, MyConnection)
        Dim DsetD As New DataSet

        Dim sqlStringD1 As String = "Select AA, DebDate, DebDesc, DebAmmount, LastDate from TableDebits where DebPayDate = 0 "
        Dim adapterD1 As New Odbc.OdbcDataAdapter(sqlStringD1, MyConnection)
        Dim DsetD1 As New DataSet


        If MyConnection.State = ConnectionState.Closed Then
            MyConnection.Open()
        End If
        DsetD.Clear()
        adapterD.Fill(DsetD)

        DsetD1.Clear()
        adapterD1.Fill(DsetD1)
        MyConnection.Close()

        TV1.Nodes.Clear()
        nmDebits.Value = 0
        Dim g As Integer
        For g = 1 To DsetD.Tables(0).Rows.Count
            TV1.Nodes.Add(DsetD.Tables(0).Rows(g - 1).Item(0) & " - " & DsetD.Tables(0).Rows(g - 1).Item(1))
            Dim j As Integer
            For j = 1 To DsetD1.Tables(0).Rows.Count
                If DsetD1.Tables(0).Rows(j - 1).Item(2) = DsetD.Tables(0).Rows(g - 1).Item(0) Then
                    TV1.Nodes(g - 1).Nodes.Add(DsetD1.Tables(0).Rows(j - 1).Item(0) & " - " & _
                                             DsetD1.Tables(0).Rows(j - 1).Item(1) & " - " & _
                                             DsetD1.Tables(0).Rows(j - 1).Item(3) & " - " & DsetD1.Tables(0).Rows(j - 1).Item(4))
                End If
            Next
            nmDebits.Value += DsetD.Tables(0).Rows(g - 1).Item(1)
        Next

    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Call DEBITSUB()
    End Sub

 

    Private Sub TV1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles TV1.DoubleClick
        Dim aa As Integer
        Dim saldat As Integer
        Dim Arr As String()
        If TV1.SelectedNode.Level = 1 Then

            Arr = TV1.SelectedNode.Text.Split(" - ")
            If Arr(0) = "" Then
                Arr(0) = "00"
            End If
            aa = CInt(Arr(0))
            saldat = CInt(Arr(2))
            Dim form3 As New Form3
            Call form3.LoadForm(aa, saldat, "Credit")

            Call DEBITSUB()
        End If
    End Sub

  
    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        Dim FORM4 As New Form4
        FORM4.Show()
    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        Dim FRMINOUT As New frmInOut
        FRMINOUT.Show()
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        Dim FRMSUPINVOICES As New FrmSupInvoices
        FRMSUPINVOICES.Show()
    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        Dim FRMITEMS As New frmItems
        FRMITEMS.Show()
    End Sub

    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.Click
        Dim form2 As New Form2
        form2.Show()
    End Sub

    Private Sub Button13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button13.Click
        Dim i As Integer
        For i = 1 To DG1.Rows.Count
            DG1.Item("selprice", i - 1).Value = DG1.Item("selpriceh", i - 1).Value
            DG1.Item("ltotal", i - 1).Value = Math.Round(CDec(DG1.Item("cnt", i - 1).Value * DG1.Item("selprice", i - 1).Value), 2)
        Next
        Call summary()
    End Sub

    Private Sub UPRICE_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UPRICE.ValueChanged
        
        Stotal.Value = Weight.Value * UPRICE.Value
    End Sub
End Class
