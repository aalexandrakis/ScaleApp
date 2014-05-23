Public Class FrmPrintOrder
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents PrintDialog1 As System.Windows.Forms.PrintDialog
    Friend WithEvents PrintTable As System.Drawing.Printing.PrintDocument
    Friend WithEvents PageSetupDialog1 As System.Windows.Forms.PageSetupDialog
    Friend WithEvents PrintPreviewControl1 As System.Windows.Forms.PrintPreviewControl
    Friend WithEvents ZoomNumber As System.Windows.Forms.NumericUpDown
    Friend WithEvents Zoom As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog
        Me.PrintTable = New System.Drawing.Printing.PrintDocument
        Me.PageSetupDialog1 = New System.Windows.Forms.PageSetupDialog
        Me.PrintPreviewControl1 = New System.Windows.Forms.PrintPreviewControl
        Me.ZoomNumber = New System.Windows.Forms.NumericUpDown
        Me.Zoom = New System.Windows.Forms.Label
        CType(Me.ZoomNumber, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PrintDialog1
        '
        Me.PrintDialog1.AllowSelection = True
        Me.PrintDialog1.AllowSomePages = True
        Me.PrintDialog1.Document = Me.PrintTable
        '
        'PrintTable
        '
        Me.PrintTable.DocumentName = "printtable"
        '
        'PrintPreviewControl1
        '
        Me.PrintPreviewControl1.AutoZoom = False
        Me.PrintPreviewControl1.Location = New System.Drawing.Point(8, 32)
        Me.PrintPreviewControl1.Name = "PrintPreviewControl1"
        Me.PrintPreviewControl1.Size = New System.Drawing.Size(264, 216)
        Me.PrintPreviewControl1.TabIndex = 91
        Me.PrintPreviewControl1.Zoom = 0.3
        '
        'ZoomNumber
        '
        Me.ZoomNumber.DecimalPlaces = 2
        Me.ZoomNumber.Increment = New Decimal(New Integer() {1, 0, 0, 131072})
        Me.ZoomNumber.Location = New System.Drawing.Point(40, 0)
        Me.ZoomNumber.Name = "ZoomNumber"
        Me.ZoomNumber.Size = New System.Drawing.Size(48, 20)
        Me.ZoomNumber.TabIndex = 93
        Me.ZoomNumber.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Zoom
        '
        Me.Zoom.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.Zoom.Location = New System.Drawing.Point(0, 0)
        Me.Zoom.Name = "Zoom"
        Me.Zoom.Size = New System.Drawing.Size(40, 16)
        Me.Zoom.TabIndex = 92
        Me.Zoom.Text = "Zoom"
        '
        'FrmPrintOrder
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(284, 264)
        Me.Controls.Add(Me.ZoomNumber)
        Me.Controls.Add(Me.Zoom)
        Me.Controls.Add(Me.PrintPreviewControl1)
        Me.Name = "FrmPrintOrder"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmPrintOrder"
        CType(Me.ZoomNumber, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim y As Integer
    Dim TableFont, TitleFont As Font
    Dim X1, X2, X3, X5, X6 As Integer
    Dim W1, W2, W3, W4 As Integer
    Dim ITM As Integer
    Dim PrintDialogResult As Windows.Forms.DialogResult
    Dim sumResPrice As Decimal
    Dim SumResPay As Decimal
    Dim SumResYpol As Decimal
    Dim PageWidth As Integer
    Dim page As Integer
    Dim title As String
    Dim sqlSelect As String
    Dim rec As Integer = 1
    Dim rec2 As Integer
    Dim Bycontinue As Boolean
    Dim Summary As Decimal
    Dim CatDesc As String
    Dim ProDesc As String
    Dim PrintedRows As Integer
    Dim SqlSelect1 As String = "SELECT OrderHead.*, TableCustomers.* from OrderHead Inner Join TableCustomers " & _
    "on OrderHead.CusCod = TableCustomers.CusCod " & _
    "WHERE OrderHead.OrderNumber=" & SelectedRec
    Dim adapter1 As New Odbc.OdbcDataAdapter(SqlSelect1, MyConnection)
    Dim Dset1 As New DataSet

    Dim SqlSelect2 As String = "Select " & _
        "a.EidCod as ÊÙÄ_ÅÉÄÏÕÓ, " & _
        "(select EidDes from TableEidos where a.EidCod=TableEidos.EidCod) as ÅÉÄÏÓ, " & _
        "a.CouCod as ÊÙÄ_ÌÏÍ_ÌÅÔ, " & _
        "(select CouDes from TableCounter where a.CouCod=TableCounter.CouCod) as ÌÏÍ_ÌÅÔ, " & _
        "a.count as ÐÏÓÏÔÇÔÁ, " & _
        "a.EidPrice as ÔÉÌÇ_ÌÏÍÁÄÏÓ, " & _
        "a.PriceB as ÔÉÌÇ, " & _
        "a.EkpPer as ÐÏÓÏÓÔÏ_ÅÊÐÔÙÓÇÓ, " & _
        "a.EkpPos as ÐÏÓÏ_ÅÊÐÔÙÓÇÓ, " & _
        "a.Price as ÔÅËÉÊÇ_ÔÉÌÇ, " & _
        "a.FpaPer as ÐÏÓÏÓÔÏ_ÖÐÁ, " & _
        "a.FpaPos as ÐÏÓÏ_ÖÐÁ " & _
        "from OrderDetail as a where OrderNumber =  " & SelectedRec
    Dim adapter2 As New Odbc.OdbcDataAdapter(SqlSelect2, MyConnection)
    Dim Dset2 As New DataSet


    Private Sub FrmPrintOrder_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        Call PrintPreview()
    End Sub
   

    Private Sub PrintPreview()

        TableFont = New Font("Arial", 8)
        TitleFont = New Font("Arial", 12, FontStyle.Bold)
        X1 = PrintTable.DefaultPageSettings.Margins.Left

        With PrintTable.DefaultPageSettings
            .Margins.Left = 0
            .Margins.Right = 0
            .Margins.Top = 0
            PageWidth = .PaperSize.Width - .Margins.Left - .Margins.Right
        End With
        MyConnection.Open()
        Dset1.Clear()
        adapter1.Fill(Dset1)
        Dset2.Clear()
        adapter2.Fill(Dset2)
        MyConnection.Close()

        page = 0
        rec = 1
        rec2 = 1
        Summary = 0
        PrintedRows = 0

        Try
            'PrintPreviewControl1.Document = PrintTable
            PrintTable.Print()
            Me.Close()
        Catch ex As Exception
            MsgBox("Print operation failed " & vbCrLf & ex.Message, , "Print Preview")
        End Try
        ITM = 0
    End Sub

    Private Sub PrintTable_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintTable.PrintPage
        Dim RECD As New System.Drawing.RectangleF
        Dim STRF As New System.Drawing.StringFormat

        If rec > Dset2.Tables(0).Rows.Count Then
            e.HasMorePages = False
            PrintPreviewControl1.Rows = page
            PrintPreviewControl1.Zoom = ZoomNumber.Value
            Exit Sub
        End If

        Bycontinue = False
        page = page + 1

        X1 = 5
        y = y + TableFont.Height - 6
        e.Graphics.DrawString("¼íïìá:" & Dset1.Tables(0).Rows(rec - 1).Item("CusName"), TableFont, Brushes.Black, X1, y)
        y = y + TableFont.Height + 3
        e.Graphics.DrawString("Äéåýèõíóç:" & Dset1.Tables(0).Rows(rec - 1).Item("CusAddress"), TableFont, Brushes.Black, X1, y)
        y = y + TableFont.Height + 3
        e.Graphics.DrawString("ÔçëÝöùíï:" & Dset1.Tables(0).Rows(rec - 1).Item("CusPhone"), TableFont, Brushes.Black, X1, y)
        y = y + TableFont.Height + 3
        e.Graphics.DrawString("Áñ.Ðáñáããåëßáò:" & Dset1.Tables(0).Rows(rec - 1).Item("OrderNumber"), TableFont, Brushes.Black, X1, y)
        y = y + TableFont.Height + 3
        e.Graphics.DrawString(Dset1.Tables(0).Rows(rec - 1).Item("OrderText"), TableFont, Brushes.Black, X1, y)
        y = y + TableFont.Height + 3

        X1 = -4
        X2 = 23
        X3 = 120
        X5 = 190
        X6 = 222

        Dim C1 As Integer = 20
        Dim C2 As Integer = 80
        Dim C3 As Integer = 300
        Dim C4 As Integer = 400
        Dim C5 As Integer = 500
        Dim C6 As Integer = 600
        Dim C7 As Integer = 700

        y = y + TableFont.Height + 21
        e.Graphics.DrawString("ÊÙÄ.", TitleFont, Brushes.Black, C1 - 4, y)
        e.Graphics.DrawString("ÐÅÑÉÃÑÁÖÇ ÅÉÄÏÕÓ", TitleFont, Brushes.Black, C2 - 4, y)
        e.Graphics.DrawString("ÌÏÍ.ÌÅÔÑ.", TitleFont, Brushes.Black, C3 - 4, y)
        e.Graphics.DrawString("ÐÏÓÏÔÇÔÁ", TitleFont, Brushes.Black, C4 - 4, y)
        e.Graphics.DrawString("ÔÉÌÇ ÌÏÍ.", TitleFont, Brushes.Black, C5 - 4, y)
        e.Graphics.DrawString("ÅÊÐÔÙÓÇ", TitleFont, Brushes.Black, C6 - 4, y)
        e.Graphics.DrawString("ÔÅËÉÊÇ", TitleFont, Brushes.Black, C7 - 4, y)
        y = y + TitleFont.Height
read1:
        If rec2 > Dset2.Tables(0).Rows.Count Then
            y = y + TableFont.Height + 5
            e.Graphics.DrawString("Óýíïëï:" & Dset1.Tables(0).Rows(rec - 1).Item("OrderPrice"), TitleFont, Brushes.Black, C6, y)
            e.HasMorePages = False
            Exit Sub
        End If
        y = y + TableFont.Height + 7


        e.Graphics.DrawString(Trim(Dset2.Tables(0).Rows(rec2 - 1).Item(0)), TableFont, Brushes.Black, C1, y)
        e.Graphics.DrawString(Trim(Dset2.Tables(0).Rows(rec2 - 1).Item(1)), TableFont, Brushes.Black, C2, y)
        e.Graphics.DrawString(Trim(Dset2.Tables(0).Rows(rec2 - 1).Item(3)), TableFont, Brushes.Black, C3, y)
        e.Graphics.DrawString(Trim(Dset2.Tables(0).Rows(rec2 - 1).Item(4)), TableFont, Brushes.Black, C4, y)
        e.Graphics.DrawString(Trim(Dset2.Tables(0).Rows(rec2 - 1).Item(5)), TableFont, Brushes.Black, C5, y)
        e.Graphics.DrawString(Trim(Dset2.Tables(0).Rows(rec2 - 1).Item(8)), TableFont, Brushes.Black, C6, y)
        e.Graphics.DrawString(Trim(Dset2.Tables(0).Rows(rec2 - 1).Item(9)), TableFont, Brushes.Black, C7, y)


        
        RECD.X = (X6)
        RECD.Y = (y)
        RECD.Height = TableFont.Height
        RECD.Width = 50
        STRF.Alignment = StringAlignment.Far
        

        PrintedRows = PrintedRows + 1
        rec2 = rec2 + 1
        If PrintedRows > 20 Then
            e.HasMorePages = True
            Bycontinue = True
            y = 0
            PrintedRows = 0
            Exit Sub
        End If
        GoTo read1

        e.HasMorePages = False
    End Sub

    Private Sub FrmPrintOrder_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Resize
        PrintPreviewControl1.Height = Me.Height - 80
        PrintPreviewControl1.Width = Me.Width - 30
        PrintPreviewControl1.Top = 110
    End Sub

    Private Sub ZoomNumber_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ZoomNumber.ValueChanged
        If ZoomNumber.Value = 0 Then ZoomNumber.Value = 0.01
        PrintPreviewControl1.Zoom = ZoomNumber.Value
    End Sub


    Private Sub PrintPreviewControl1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintPreviewControl1.Click

    End Sub
End Class
