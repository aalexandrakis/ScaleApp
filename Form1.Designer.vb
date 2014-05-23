<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Label1 = New System.Windows.Forms.Label
        Me.ItemDes = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Weight = New System.Windows.Forms.NumericUpDown
        Me.UPRICE = New System.Windows.Forms.NumericUpDown
        Me.Label3 = New System.Windows.Forms.Label
        Me.Stotal = New System.Windows.Forms.NumericUpDown
        Me.Label4 = New System.Windows.Forms.Label
        Me.DG1 = New System.Windows.Forms.DataGridView
        Me.GTOTAL = New System.Windows.Forms.NumericUpDown
        Me.Label5 = New System.Windows.Forms.Label
        Me.Button2 = New System.Windows.Forms.Button
        Me.ItemCode = New System.Windows.Forms.TextBox
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.rt1 = New System.Windows.Forms.RichTextBox
        Me.txtFpa = New System.Windows.Forms.NumericUpDown
        Me.Label6 = New System.Windows.Forms.Label
        Me.Button3 = New System.Windows.Forms.Button
        Me.pp1 = New System.Windows.Forms.PrintPreviewDialog
        Me.Button4 = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button5 = New System.Windows.Forms.Button
        Me.EidPrice = New System.Windows.Forms.NumericUpDown
        Me.Label7 = New System.Windows.Forms.Label
        Me.pd2 = New System.Drawing.Printing.PrintDocument
        Me.LINECOUNT = New System.Windows.Forms.NumericUpDown
        Me.Label8 = New System.Windows.Forms.Label
        Me.Button6 = New System.Windows.Forms.Button
        Me.txtDiscount = New System.Windows.Forms.NumericUpDown
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.TV1 = New System.Windows.Forms.TreeView
        Me.nmDebits = New System.Windows.Forms.NumericUpDown
        Me.Button7 = New System.Windows.Forms.Button
        Me.Button8 = New System.Windows.Forms.Button
        Me.Button9 = New System.Windows.Forms.Button
        Me.Button10 = New System.Windows.Forms.Button
        Me.Button11 = New System.Windows.Forms.Button
        Me.Button12 = New System.Windows.Forms.Button
        Me.Button13 = New System.Windows.Forms.Button
        Me.nmTimiHidden = New System.Windows.Forms.NumericUpDown
        CType(Me.Weight, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UPRICE, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Stotal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DG1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GTOTAL, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFpa, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EidPrice, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LINECOUNT, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDiscount, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nmDebits, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nmTimiHidden, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.Name = "Label1"
        '
        'ItemDes
        '
        resources.ApplyResources(Me.ItemDes, "ItemDes")
        Me.ItemDes.Name = "ItemDes"
        '
        'Label2
        '
        resources.ApplyResources(Me.Label2, "Label2")
        Me.Label2.Name = "Label2"
        '
        'Weight
        '
        Me.Weight.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Weight.DecimalPlaces = 3
        resources.ApplyResources(Me.Weight, "Weight")
        Me.Weight.Maximum = New Decimal(New Integer() {999999, 0, 0, 0})
        Me.Weight.Name = "Weight"
        Me.Weight.ReadOnly = True
        '
        'UPRICE
        '
        Me.UPRICE.DecimalPlaces = 2
        resources.ApplyResources(Me.UPRICE, "UPRICE")
        Me.UPRICE.Increment = New Decimal(New Integer() {5, 0, 0, 131072})
        Me.UPRICE.Maximum = New Decimal(New Integer() {999999, 0, 0, 0})
        Me.UPRICE.Name = "UPRICE"
        '
        'Label3
        '
        resources.ApplyResources(Me.Label3, "Label3")
        Me.Label3.Name = "Label3"
        '
        'Stotal
        '
        Me.Stotal.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Stotal.DecimalPlaces = 2
        resources.ApplyResources(Me.Stotal, "Stotal")
        Me.Stotal.ForeColor = System.Drawing.Color.Black
        Me.Stotal.Increment = New Decimal(New Integer() {0, 0, 0, 0})
        Me.Stotal.InterceptArrowKeys = False
        Me.Stotal.Maximum = New Decimal(New Integer() {999999, 0, 0, 0})
        Me.Stotal.Name = "Stotal"
        Me.Stotal.ReadOnly = True
        Me.Stotal.TabStop = False
        '
        'Label4
        '
        resources.ApplyResources(Me.Label4, "Label4")
        Me.Label4.Name = "Label4"
        '
        'DG1
        '
        Me.DG1.AllowUserToAddRows = False
        Me.DG1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        resources.ApplyResources(Me.DG1, "DG1")
        Me.DG1.Name = "DG1"
        Me.DG1.ReadOnly = True
        '
        'GTOTAL
        '
        Me.GTOTAL.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.GTOTAL.DecimalPlaces = 2
        resources.ApplyResources(Me.GTOTAL, "GTOTAL")
        Me.GTOTAL.ForeColor = System.Drawing.SystemColors.ControlText
        Me.GTOTAL.Maximum = New Decimal(New Integer() {999999, 0, 0, 0})
        Me.GTOTAL.Name = "GTOTAL"
        Me.GTOTAL.ReadOnly = True
        Me.GTOTAL.TabStop = False
        '
        'Label5
        '
        resources.ApplyResources(Me.Label5, "Label5")
        Me.Label5.Name = "Label5"
        '
        'Button2
        '
        resources.ApplyResources(Me.Button2, "Button2")
        Me.Button2.Name = "Button2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'ItemCode
        '
        resources.ApplyResources(Me.ItemCode, "ItemCode")
        Me.ItemCode.Name = "ItemCode"
        '
        'PrintDocument1
        '
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'rt1
        '
        resources.ApplyResources(Me.rt1, "rt1")
        Me.rt1.Name = "rt1"
        Me.rt1.TabStop = False
        '
        'txtFpa
        '
        Me.txtFpa.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtFpa.DecimalPlaces = 2
        resources.ApplyResources(Me.txtFpa, "txtFpa")
        Me.txtFpa.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txtFpa.Maximum = New Decimal(New Integer() {999999, 0, 0, 0})
        Me.txtFpa.Name = "txtFpa"
        Me.txtFpa.ReadOnly = True
        Me.txtFpa.TabStop = False
        '
        'Label6
        '
        resources.ApplyResources(Me.Label6, "Label6")
        Me.Label6.Name = "Label6"
        '
        'Button3
        '
        resources.ApplyResources(Me.Button3, "Button3")
        Me.Button3.Name = "Button3"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'pp1
        '
        resources.ApplyResources(Me.pp1, "pp1")
        Me.pp1.Name = "pp1"
        '
        'Button4
        '
        resources.ApplyResources(Me.Button4, "Button4")
        Me.Button4.Name = "Button4"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button1
        '
        resources.ApplyResources(Me.Button1, "Button1")
        Me.Button1.Name = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button5
        '
        resources.ApplyResources(Me.Button5, "Button5")
        Me.Button5.Name = "Button5"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'EidPrice
        '
        Me.EidPrice.DecimalPlaces = 2
        resources.ApplyResources(Me.EidPrice, "EidPrice")
        Me.EidPrice.Increment = New Decimal(New Integer() {5, 0, 0, 131072})
        Me.EidPrice.Maximum = New Decimal(New Integer() {999999, 0, 0, 0})
        Me.EidPrice.Name = "EidPrice"
        Me.EidPrice.ReadOnly = True
        '
        'Label7
        '
        resources.ApplyResources(Me.Label7, "Label7")
        Me.Label7.Name = "Label7"
        '
        'LINECOUNT
        '
        Me.LINECOUNT.DecimalPlaces = 2
        resources.ApplyResources(Me.LINECOUNT, "LINECOUNT")
        Me.LINECOUNT.Increment = New Decimal(New Integer() {5, 0, 0, 131072})
        Me.LINECOUNT.Maximum = New Decimal(New Integer() {999999, 0, 0, 0})
        Me.LINECOUNT.Name = "LINECOUNT"
        Me.LINECOUNT.ReadOnly = True
        Me.LINECOUNT.TabStop = False
        '
        'Label8
        '
        resources.ApplyResources(Me.Label8, "Label8")
        Me.Label8.Name = "Label8"
        '
        'Button6
        '
        resources.ApplyResources(Me.Button6, "Button6")
        Me.Button6.Name = "Button6"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'txtDiscount
        '
        Me.txtDiscount.DecimalPlaces = 2
        resources.ApplyResources(Me.txtDiscount, "txtDiscount")
        Me.txtDiscount.Increment = New Decimal(New Integer() {5, 0, 0, 131072})
        Me.txtDiscount.Maximum = New Decimal(New Integer() {999999, 0, 0, 0})
        Me.txtDiscount.Name = "txtDiscount"
        '
        'Label9
        '
        resources.ApplyResources(Me.Label9, "Label9")
        Me.Label9.Name = "Label9"
        '
        'Label10
        '
        resources.ApplyResources(Me.Label10, "Label10")
        Me.Label10.Name = "Label10"
        '
        'TV1
        '
        resources.ApplyResources(Me.TV1, "TV1")
        Me.TV1.Name = "TV1"
        '
        'nmDebits
        '
        Me.nmDebits.DecimalPlaces = 2
        resources.ApplyResources(Me.nmDebits, "nmDebits")
        Me.nmDebits.Increment = New Decimal(New Integer() {5, 0, 0, 131072})
        Me.nmDebits.Maximum = New Decimal(New Integer() {999999, 0, 0, 0})
        Me.nmDebits.Name = "nmDebits"
        Me.nmDebits.ReadOnly = True
        Me.nmDebits.TabStop = False
        '
        'Button7
        '
        resources.ApplyResources(Me.Button7, "Button7")
        Me.Button7.Name = "Button7"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button8
        '
        resources.ApplyResources(Me.Button8, "Button8")
        Me.Button8.Name = "Button8"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Button9
        '
        resources.ApplyResources(Me.Button9, "Button9")
        Me.Button9.Name = "Button9"
        Me.Button9.UseVisualStyleBackColor = True
        '
        'Button10
        '
        resources.ApplyResources(Me.Button10, "Button10")
        Me.Button10.Name = "Button10"
        Me.Button10.UseVisualStyleBackColor = True
        '
        'Button11
        '
        resources.ApplyResources(Me.Button11, "Button11")
        Me.Button11.Name = "Button11"
        Me.Button11.UseVisualStyleBackColor = True
        '
        'Button12
        '
        resources.ApplyResources(Me.Button12, "Button12")
        Me.Button12.Name = "Button12"
        Me.Button12.UseVisualStyleBackColor = True
        '
        'Button13
        '
        resources.ApplyResources(Me.Button13, "Button13")
        Me.Button13.Name = "Button13"
        Me.Button13.UseVisualStyleBackColor = True
        '
        'nmTimiHidden
        '
        Me.nmTimiHidden.DecimalPlaces = 2
        resources.ApplyResources(Me.nmTimiHidden, "nmTimiHidden")
        Me.nmTimiHidden.Increment = New Decimal(New Integer() {5, 0, 0, 131072})
        Me.nmTimiHidden.Maximum = New Decimal(New Integer() {999999, 0, 0, 0})
        Me.nmTimiHidden.Name = "nmTimiHidden"
        '
        'Form1
        '
        Me.AcceptButton = Me.Button3
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ControlBox = False
        Me.Controls.Add(Me.nmTimiHidden)
        Me.Controls.Add(Me.Button13)
        Me.Controls.Add(Me.Button12)
        Me.Controls.Add(Me.Button11)
        Me.Controls.Add(Me.Button9)
        Me.Controls.Add(Me.Button10)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.nmDebits)
        Me.Controls.Add(Me.TV1)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtDiscount)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.LINECOUNT)
        Me.Controls.Add(Me.EidPrice)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.txtFpa)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.rt1)
        Me.Controls.Add(Me.ItemCode)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.GTOTAL)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.DG1)
        Me.Controls.Add(Me.Stotal)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.UPRICE)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Weight)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ItemDes)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.Weight, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UPRICE, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Stotal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DG1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GTOTAL, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFpa, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EidPrice, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LINECOUNT, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDiscount, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nmDebits, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nmTimiHidden, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ItemDes As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Weight As System.Windows.Forms.NumericUpDown
    Friend WithEvents UPRICE As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Stotal As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents DG1 As System.Windows.Forms.DataGridView
    Friend WithEvents GTOTAL As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents ItemCode As System.Windows.Forms.TextBox
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents rt1 As System.Windows.Forms.RichTextBox
    Friend WithEvents txtFpa As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents pp1 As System.Windows.Forms.PrintPreviewDialog
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents EidPrice As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents pd2 As System.Drawing.Printing.PrintDocument
    Friend WithEvents LINECOUNT As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents txtDiscount As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents TV1 As System.Windows.Forms.TreeView
    Friend WithEvents nmDebits As System.Windows.Forms.NumericUpDown
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents Button9 As System.Windows.Forms.Button
    Friend WithEvents Button10 As System.Windows.Forms.Button
    Friend WithEvents Button11 As System.Windows.Forms.Button
    Friend WithEvents Button12 As System.Windows.Forms.Button
    Friend WithEvents Button13 As System.Windows.Forms.Button
    Friend WithEvents nmTimiHidden As System.Windows.Forms.NumericUpDown

End Class
