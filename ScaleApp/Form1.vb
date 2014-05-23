Imports System.IO.stream
Public Class Form1
    Dim a As Integer = 0
    Private WithEvents Myserial As New System.IO.Ports.SerialPort("COM1", 9600, IO.Ports.Parity.Even, 8, IO.Ports.StopBits.One)
    Private CNTTYPE As String

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
       

    End Sub

    Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Myserial.Open()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim STRAR As String()
        Dim STRPOS As Integer
        Dim Strweight As String = ""

        Weight.Value = 0

        Do Until IsNumeric(StrWeight)
            STRAR = Myserial.ReadExisting.Split("@B")
            STRPOS = STRAR.Length - 1
            If STRAR(STRPOS).Length >= 7 Then
                Try
                    Strweight = STRAR(STRPOS).Substring(2, 7)
                    Strweight = Strweight.Replace(".", ",")

                Catch
                End Try
            End If
            'Myserial.Write(RichTextBox1.Text)
        Loop
        Weight.Value = Strweight
    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub ItemDes_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ItemDes.TextChanged
        
    End Sub

    Private Sub ItemCode_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles ItemCode.Leave
        ItemDes.Text = ""


        If ItemCode.Value = 0 Then Exit Sub

        Dim sqlString As String = "Select * from TableEidos where EidCod=" & Trim(ItemCode.Value.ToString)
        Dim adapter1 As New Odbc.OdbcDataAdapter(sqlString, MyConnection)
        Dim Dset1 As New DataSet

        MyConnection.Open()
        Dset1.Clear()
        adapter1.Fill(Dset1)
        MyConnection.Close()

        If Dset1.Tables(0).Rows.Count > 0 Then
            ItemDes.Text = Dset1.Tables(0).Rows(0).Item("EidDes")
            UPRICE.Value = Dset1.Tables(0).Rows(0).Item("EidPrice")
            CNTTYPE = Dset1.Tables(0).Rows(0).Item("CouCod")
            If CNTTYPE = "1" Then
                Label2.Text = "баяос"
            Else
                Label2.Text = "TEMAXIA"
            End If

        End If
    End Sub

    Private Sub ItemCode_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ItemCode.ValueChanged

    End Sub
End Class
