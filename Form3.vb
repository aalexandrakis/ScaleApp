Public Class Form3
    Public P_AA As Integer
    Public P_DATE As Integer
    Public P_Action As String
    Public InsUpd As String
    Public DebAmm As Decimal

    Public Sub LoadForm(ByVal AA As Integer, ByVal SalDat As Integer, ByVal Action As String)
        P_Action = Action
        If Action = "Debit" Then
            Me.Text = "Χρέος"
            Label2.Text = "Υπόλοιπο"
            Call DebitSr(AA, SalDat)
        Else
            Me.Text = "Πληρωμή"
            Label2.Text = "Ποσό"
            Call CreditSr(AA, SalDat)
        End If
    End Sub

    Private Sub DebitSr(ByVal AA As Integer, ByVal SalDat As Integer)
        Dim Str As String = " "
        Dim SqlString1 As String = "SELECT Distinct DebDesc From TableDebits " & _
                                     " where Debdate > 0 and DebPayDate = 0" 

        Dim adapter1 As New Odbc.OdbcDataAdapter(SqlString1, MyConnection)
        Dim Dset1 As New DataSet

        If MyConnection.State = ConnectionState.Closed Then
            MyConnection.Open()
        End If
        P_AA = AA
        P_DATE = SalDat

        Dset1.Clear()
        adapter1.Fill(Dset1)

        Dset1.Tables(0).NewRow.Item(0) = " "
        Dset1.Tables(0).Rows.Add()

        CbxDebNames.Items.Clear()
        CbxDebNames.DataSource = Dset1.Tables(0)
        CbxDebNames.ValueMember = "DebDesc"
        CbxDebNames.DisplayMember = "DebDesc"

        Dim SqlString2 As String = "SELECT sum(tprice) " & _
                         " from SalesDetail where saldat = " & SalDat & _
                         " and aa = " & AA

        Dim adapter2 As New Odbc.OdbcDataAdapter(SqlString2, MyConnection)
        Dim Dset2 As New DataSet
        If MyConnection.State = ConnectionState.Closed Then
            MyConnection.Open()
        End If
        Dset2.Clear()
        adapter2.Fill(Dset2)
        MyConnection.Close()
        CbxDebNames.SelectedValue = " "


        nmAA.Value = AA
        NmDebAmm.Value = Dset2.Tables(0).Rows(0).Item(0)
        GetSalesDetail(AA, SalDat)
        Me.ShowDialog()
    End Sub
    Private Sub CreditSr(ByVal AA As Integer, ByVal SalDat As Integer)

        Dim SqlString1 As String = "SELECT DebDesc, sum(Debammount) From TableDebits " & _
                                     " where aa = " & AA & " and DebDate = " & SalDat & _
                                     " group by debDesc"

        Dim adapter1 As New Odbc.OdbcDataAdapter(SqlString1, MyConnection)
        Dim Dset1 As New DataSet

        If MyConnection.State = ConnectionState.Closed Then
            MyConnection.Open()
        End If
        P_AA = AA
        P_DATE = SalDat

        Dset1.Clear()
        adapter1.Fill(Dset1)
        
        CbxDebNames.Text = Dset1.Tables(0).Rows(0).Item(0)
        NmDebAmm.Value = Dset1.Tables(0).Rows(0).Item(1)
        DebAmm = Dset1.Tables(0).Rows(0).Item(1)
        nmAA.Value = AA
        GetSalesDetail(AA, SalDat)
        Me.ShowDialog()

    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click
        If CbxDebNames.Text = "" Then
            MsgBox("Δεν έχεις βάλει όνομα ωφειλέτη", MsgBoxStyle.OkOnly)
            Exit Sub
        End If

        If MyConnection.State = ConnectionState.Closed Then
            MyConnection.Open()
        End If

        If P_Action = "Credit" And NmDebAmm.Value > DebAmm Then
            MsgBox("Το ποσό πληρωμής είναι μεγαλύτερο από το ποσό ωφειλής", MsgBoxStyle.OkOnly)
            MyConnection.Close()
            Exit Sub
        End If


        Dim SqlCommand As String
        If P_Action = "Debit" Then
            Dim SqlString3 As String = "SELECT * from TableDebits where aa = " & P_AA & _
                             " and DebDate = " & P_DATE & " and DebPayDate = 0"
            Dim adapter3 As New Odbc.OdbcDataAdapter(SqlString3, MyConnection)
            Dim Dset3 As New DataSet
            
            Dset3.Clear()
            adapter3.Fill(Dset3)
            If Dset3.Tables(0).Rows.Count = 0 Then
                SqlCommand = "Insert into Tabledebits values( " & _
                                        P_AA & ", '" & CbxDebNames.Text & "', " & P_DATE & _
                                        ", '" & NmDebAmm.Value & "' , 0, " & Date.Now.ToString("yyyyMMdd") & ")"
            Else
                SqlCommand = "Update Tabledebits Set DebAmmout = '" & NmDebAmm.Value & "', " & _
                                                     " DebDesc = '" & CbxDebNames.Text & "', " & _
                                                     " LastDate = '" & Date.Now.ToString("yyyyMMdd") & "', " & _
                                                     " where aa = " & P_AA & _
                                                     " and DebDate = " & P_DATE
            End If
        End If

        If P_Action = "Credit" Then
            SqlCommand = "Insert into Tabledebits values( " & _
                                       P_AA & ", '" & CbxDebNames.Text & "', '" & P_DATE & _
                                       "', '" & NmDebAmm.Value * -1 & "' , 0, " & Date.Now.ToString("yyyyMMdd") & ")"
        End If

        trans = MyConnection.BeginTransaction
        MyCommand = New Odbc.OdbcCommand(SqlCommand, MyConnection, trans)
        MyCommand.CommandType = CommandType.Text
        MyCommand.ExecuteNonQuery()
        trans.Commit()

        If DebAmm = NmDebAmm.Value Then
            SqlCommand = "Update Tabledebits set DebPayDate ='" & Date.Now.ToString("yyyyMMdd") & _
                                                   "' where aa= " & P_AA & " and DebDate = " & P_DATE
            trans = MyConnection.BeginTransaction
            MyCommand = New Odbc.OdbcCommand(SqlCommand, MyConnection, trans)
            MyCommand.CommandType = CommandType.Text
            MyCommand.ExecuteNonQuery()
            trans.Commit()
        End If
        MyConnection.Close()

        Me.Close()
    End Sub

    Private Sub GetSalesDetail(ByVal AA As Integer, ByVal SalDat As Integer)
        If AA = 0 Then
            dg1.Rows.Clear()
            Exit Sub
        End If
        Dim SqlString2 As String = "SELECT saldat as Ημερομηνια, itemcode as Κωδικός, eiddes as Περιγραφή, " & _
                         " uprice as ΤιμηΜοναδος, count as Ποσοτητα, tprice as Αξία" & _
                         " from SalesDetail " & _
                         " where saldat = " & SalDat & _
                         " and aa = " & AA

        Dim adapter2 As New Odbc.OdbcDataAdapter(SqlString2, MyConnection)
        Dim Dset2 As New DataSet
        If MyConnection.State = ConnectionState.Closed Then
            MyConnection.Open()
        End If
        Dset2.Clear()
        adapter2.Fill(Dset2)
        MyConnection.Close()
        dg1.DataSource = Dset2.Tables(0)
    End Sub

End Class