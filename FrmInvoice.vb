Public Class FrmInvoice
    Inherits System.Windows.Forms.Form
    
    Dim PrintDialogResult As Windows.Forms.DialogResult

    Dim CustomerNameF As New System.Drawing.RectangleF
    Dim CustomerAddressF As New System.Drawing.RectangleF
    Dim CustomerZipCodeF As New System.Drawing.RectangleF
    Dim CustomerCityF As New System.Drawing.RectangleF
    Dim CustomerPhoneF As New System.Drawing.RectangleF
    Dim CustomerAfmF As New System.Drawing.RectangleF
    Dim CustomerDoyF As New System.Drawing.RectangleF

    Dim ItemF As New System.Drawing.RectangleF
    Dim CountF As New System.Drawing.RectangleF
    Dim PriceOfCountF As New System.Drawing.RectangleF
    Dim KathariAxiaF As New System.Drawing.RectangleF
    Dim FpaPercentF As New System.Drawing.RectangleF
    Dim FpaAmmountF As New System.Drawing.RectangleF
    Dim EkpPercentF As New System.Drawing.RectangleF
    Dim EkpAmmountF As New System.Drawing.RectangleF
    Dim LastPriceF As New System.Drawing.RectangleF

    Dim StrAlign As New System.drawing.StringFormat
    Dim TableFont, TitleFont As Font

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
    Friend WithEvents ZoomNumber As System.Windows.Forms.NumericUpDown
    Friend WithEvents PrintDialog1 As System.Windows.Forms.PrintDialog
    Friend WithEvents PageSetupDialog1 As System.Windows.Forms.PageSetupDialog
    Friend WithEvents Zoom As System.Windows.Forms.Label
    Friend WithEvents btnPrint2 As System.Windows.Forms.Button
    Friend WithEvents PrintTable As System.Drawing.Printing.PrintDocument
    Friend WithEvents PrintPreviewControl1 As System.Windows.Forms.PrintPreviewControl
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.ZoomNumber = New System.Windows.Forms.NumericUpDown
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog
        Me.PageSetupDialog1 = New System.Windows.Forms.PageSetupDialog
        Me.Zoom = New System.Windows.Forms.Label
        Me.btnPrint2 = New System.Windows.Forms.Button
        Me.PrintTable = New System.Drawing.Printing.PrintDocument
        Me.PrintPreviewControl1 = New System.Windows.Forms.PrintPreviewControl
        CType(Me.ZoomNumber, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ZoomNumber
        '
        Me.ZoomNumber.DecimalPlaces = 2
        Me.ZoomNumber.Increment = New Decimal(New Integer() {1, 0, 0, 131072})
        Me.ZoomNumber.Location = New System.Drawing.Point(128, 8)
        Me.ZoomNumber.Name = "ZoomNumber"
        Me.ZoomNumber.Size = New System.Drawing.Size(48, 20)
        Me.ZoomNumber.TabIndex = 88
        Me.ZoomNumber.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Zoom
        '
        Me.Zoom.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.Zoom.Location = New System.Drawing.Point(88, 8)
        Me.Zoom.Name = "Zoom"
        Me.Zoom.Size = New System.Drawing.Size(40, 16)
        Me.Zoom.TabIndex = 87
        Me.Zoom.Text = "Zoom"
        '
        'btnPrint2
        '
        Me.btnPrint2.Location = New System.Drawing.Point(8, 8)
        Me.btnPrint2.Name = "btnPrint2"
        Me.btnPrint2.Size = New System.Drawing.Size(72, 24)
        Me.btnPrint2.TabIndex = 86
        Me.btnPrint2.Text = "Εκτύπωση"
        '
        'PrintTable
        '
        '
        'PrintPreviewControl1
        '
        Me.PrintPreviewControl1.AutoZoom = False
        Me.PrintPreviewControl1.Location = New System.Drawing.Point(8, 48)
        Me.PrintPreviewControl1.Name = "PrintPreviewControl1"
        Me.PrintPreviewControl1.Size = New System.Drawing.Size(744, 400)
        Me.PrintPreviewControl1.TabIndex = 85
        Me.PrintPreviewControl1.Zoom = 0.3
        '
        'FrmInvoice
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(760, 460)
        Me.Controls.Add(Me.PrintPreviewControl1)
        Me.Controls.Add(Me.ZoomNumber)
        Me.Controls.Add(Me.Zoom)
        Me.Controls.Add(Me.btnPrint2)
        Me.Name = "FrmInvoice"
        Me.Text = "FrmInvoice"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.ZoomNumber, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub FrmInvoice_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        PrintPreviewControl1.Height = Me.Height - 100
        PrintPreviewControl1.Width = Me.Width - 30
        PrintPreviewControl1.Top = 30

        Call PrintPreview()

        PrintPreviewControl1.Zoom = 1
        Me.WindowState = FormWindowState.Maximized

    End Sub

    Private Sub PrintPreview()
        PrintTable.DefaultPageSettings.Landscape = True
        PageSetupDialog1.PageSettings = PrintTable.DefaultPageSettings

        Dim PageWidth As Integer
        With PrintTable.DefaultPageSettings
            PageWidth = .PaperSize.Width - .Margins.Left - .Margins.Right
        End With

        Try
            PrintTable.DocumentName = "ΤΙΜΟΛΟΓΙΟ"
            PrintPreviewControl1.Document = PrintTable
        Catch ex As Exception
            MsgBox("Print operation failed " & vbCrLf & ex.Message, , "Print Preview")
        End Try
    End Sub
    Private Sub PrintTable_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintTable.PrintPage
        TableFont = New Font("Arial", 10)
        TitleFont = New Font("Arial", 10, FontStyle.Bold)

        'x=column
        'y=row

        e.Graphics.DrawImage(Image.FromFile("C:\vbProjects\CustomerInvoice\Invoice.doc"), 0, 0)

        'Στοιχεία πελάτη
        CustomerNameF.X = 710
        CustomerNameF.Y = 52
        CustomerNameF.Height = TableFont.Height
        CustomerNameF.Width = 450
        StrAlign.Alignment = StringAlignment.Near
        e.Graphics.DrawString("Ονοματεπώνυμο πελάτη Ονοματεπώνυμο πελάτη Ονοματεπώνυμο πελάτη", TableFont, Brushes.Black, CustomerNameF, StrAlign)

        CustomerAddressF.X = 715
        CustomerAddressF.Y = 69
        CustomerAddressF.Height = TableFont.Height
        CustomerAddressF.Width = 450
        StrAlign.Alignment = StringAlignment.Near
        e.Graphics.DrawString("Διεύθυνση πελάτη Διεύθυνση πελάτη Διεύθυνση πελάτη Διεύθυνση πελάτη", TableFont, Brushes.Black, CustomerAddressF, StrAlign)

        CustomerZipCodeF.X = 655
        CustomerZipCodeF.Y = 85
        CustomerZipCodeF.Height = TableFont.Height
        CustomerZipCodeF.Width = 50
        StrAlign.Alignment = StringAlignment.Near
        e.Graphics.DrawString("000 00", TableFont, Brushes.Black, CustomerZipCodeF, StrAlign)

        CustomerCityF.X = 765
        CustomerCityF.Y = 85
        CustomerCityF.Height = TableFont.Height
        CustomerCityF.Width = 370
        StrAlign.Alignment = StringAlignment.Near
        e.Graphics.DrawString("Πόλη πελάτη Πόλη πελάτη Πόλη πελάτη Πόλη πελάτη Πόλη πελάτη", TableFont, Brushes.Black, CustomerCityF, StrAlign)

        CustomerPhoneF.X = 715
        CustomerPhoneF.Y = 101
        CustomerPhoneF.Height = TableFont.Height
        CustomerPhoneF.Width = 450
        StrAlign.Alignment = StringAlignment.Near
        e.Graphics.DrawString("Τηλέφωνο πελάτη Τηλέφωνο πελάτη Τηλέφωνο πελάτη Τηλέφωνο πελάτη", TableFont, Brushes.Black, CustomerPhoneF, StrAlign)

        CustomerAfmF.X = 665
        CustomerAfmF.Y = 117
        CustomerAfmF.Height = TableFont.Height
        CustomerAfmF.Width = 450
        StrAlign.Alignment = StringAlignment.Near
        e.Graphics.DrawString("Αφμ πελάτη Αφμ πελάτη Αφμ πελάτη Αφμ πελάτη Αφμ πελάτη Αφμ πελάτη", TableFont, Brushes.Black, CustomerAfmF, StrAlign)

        CustomerDoyF.X = 665
        CustomerDoyF.Y = 133
        CustomerDoyF.Height = TableFont.Height
        CustomerDoyF.Width = 450
        StrAlign.Alignment = StringAlignment.Near
        e.Graphics.DrawString("Δου πελάτη Δου πελάτη Δου πελάτη Δου πελάτη Δου πελάτη Δου πελάτη", TableFont, Brushes.Black, CustomerDoyF, StrAlign)
        'Γραμμές τιμολόγησης
        ItemF.X = 30
        ItemF.Y = 260
        ItemF.Height = TableFont.Height
        ItemF.Width = 380
        StrAlign.Alignment = StringAlignment.Near
        e.Graphics.DrawString("Τεστ είδος τιμολόγησης Τεστ είδος τιμολόγησης Τεστ είδος τιμολόγησης", TableFont, Brushes.Black, ItemF, StrAlign)

        CountF.X = 415
        CountF.Y = 260
        CountF.Height = TableFont.Height
        CountF.Width = 120
        StrAlign.Alignment = StringAlignment.Far
        e.Graphics.DrawString("123456789,99", TableFont, Brushes.Black, CountF, StrAlign)

        PriceOfCountF.X = 525
        PriceOfCountF.Y = 260
        PriceOfCountF.Height = TableFont.Height
        PriceOfCountF.Width = 120
        StrAlign.Alignment = StringAlignment.Far
        e.Graphics.DrawString("123456789,99", TableFont, Brushes.Black, PriceOfCountF, StrAlign)

        FpaPercentF.X = 645
        FpaPercentF.Y = 260
        FpaPercentF.Height = TableFont.Height
        FpaPercentF.Width = 70
        StrAlign.Alignment = StringAlignment.Far
        e.Graphics.DrawString("123,99", TableFont, Brushes.Black, FpaPercentF, StrAlign)

        FpaAmmountF.X = 720
        FpaAmmountF.Y = 260
        FpaAmmountF.Height = TableFont.Height
        FpaAmmountF.Width = 100
        StrAlign.Alignment = StringAlignment.Far
        e.Graphics.DrawString("123456789,99", TableFont, Brushes.Black, FpaAmmountF, StrAlign)

        EkpPercentF.X = 830
        EkpPercentF.Y = 260
        EkpPercentF.Height = TableFont.Height
        EkpPercentF.Width = 100
        StrAlign.Alignment = StringAlignment.Far
        e.Graphics.DrawString("123,99", TableFont, Brushes.Black, EkpPercentF, StrAlign)

        EkpAmmountF.X = 930
        EkpAmmountF.Y = 260
        EkpAmmountF.Height = TableFont.Height
        EkpAmmountF.Width = 100
        StrAlign.Alignment = StringAlignment.Far
        e.Graphics.DrawString("123456789,99", TableFont, Brushes.Black, EkpAmmountF, StrAlign)

        LastPriceF.X = 1060
        LastPriceF.Y = 260
        LastPriceF.Height = TableFont.Height
        LastPriceF.Width = 100
        StrAlign.Alignment = StringAlignment.Far
        e.Graphics.DrawString("123456789,99", TableFont, Brushes.Black, LastPriceF, StrAlign)

        e.HasMorePages = False
    End Sub

    Private Sub btnPrint2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint2.Click
        PrintDialog1.AllowSelection = True
        PrintDialog1.PrinterSettings = New System.Drawing.Printing.PrinterSettings
        PrintDialog1.PrinterSettings = PrintTable.PrinterSettings
        PrintDialogResult = PrintDialog1.ShowDialog()

        If PrintDialogResult = DialogResult.Cancel Then
            Exit Sub
        End If

        PrintTable.PrinterSettings.PrinterName = PrintDialog1.PrinterSettings.PrinterName
        PrintTable.PrinterSettings.FromPage = PrintDialog1.PrinterSettings.FromPage
        PrintTable.PrinterSettings.ToPage = PrintDialog1.PrinterSettings.ToPage
        PrintTable.PrinterSettings.Copies = PrintDialog1.PrinterSettings.Copies
        PrintTable.PrinterSettings.PrintRange = PrintDialog1.PrinterSettings.PrintRange

        Try
            PrintTable.Print()
        Catch ex As Exception
            MsgBox("Print operation failed " & vbCrLf & ex.Message, , "Print Preview")
        End Try

    End Sub
End Class
