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
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Button1 = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.ItemCode = New System.Windows.Forms.NumericUpDown
        Me.ItemDes = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Weight = New System.Windows.Forms.NumericUpDown
        Me.UPRICE = New System.Windows.Forms.NumericUpDown
        Me.Label3 = New System.Windows.Forms.Label
        Me.Stotal = New System.Windows.Forms.NumericUpDown
        Me.Label4 = New System.Windows.Forms.Label
        CType(Me.ItemCode, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Weight, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UPRICE, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Stotal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 200
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(658, 406)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 24)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "еидос"
        '
        'ItemCode
        '
        Me.ItemCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.ItemCode.Location = New System.Drawing.Point(132, 40)
        Me.ItemCode.Name = "ItemCode"
        Me.ItemCode.Size = New System.Drawing.Size(128, 31)
        Me.ItemCode.TabIndex = 3
        '
        'ItemDes
        '
        Me.ItemDes.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.ItemDes.Location = New System.Drawing.Point(312, 40)
        Me.ItemDes.Name = "ItemDes"
        Me.ItemDes.Size = New System.Drawing.Size(272, 31)
        Me.ItemDes.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 113)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 24)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "баяос"
        '
        'Weight
        '
        Me.Weight.DecimalPlaces = 3
        Me.Weight.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.Weight.Location = New System.Drawing.Point(132, 106)
        Me.Weight.Name = "Weight"
        Me.Weight.Size = New System.Drawing.Size(128, 31)
        Me.Weight.TabIndex = 7
        '
        'UPRICE
        '
        Me.UPRICE.DecimalPlaces = 2
        Me.UPRICE.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.UPRICE.Location = New System.Drawing.Point(132, 174)
        Me.UPRICE.Name = "UPRICE"
        Me.UPRICE.Size = New System.Drawing.Size(128, 31)
        Me.UPRICE.TabIndex = 9
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 181)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 24)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "тилг"
        '
        'Stotal
        '
        Me.Stotal.DecimalPlaces = 2
        Me.Stotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.Stotal.Location = New System.Drawing.Point(132, 236)
        Me.Stotal.Name = "Stotal"
        Me.Stotal.Size = New System.Drawing.Size(128, 31)
        Me.Stotal.TabIndex = 11
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 243)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(97, 24)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "сумоко"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(759, 457)
        Me.Controls.Add(Me.Stotal)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.UPRICE)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Weight)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ItemDes)
        Me.Controls.Add(Me.ItemCode)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.ItemCode, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Weight, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UPRICE, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Stotal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ItemCode As System.Windows.Forms.NumericUpDown
    Friend WithEvents ItemDes As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Weight As System.Windows.Forms.NumericUpDown
    Friend WithEvents UPRICE As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Stotal As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label4 As System.Windows.Forms.Label

End Class
