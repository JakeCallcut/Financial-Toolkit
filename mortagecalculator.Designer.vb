<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class mortagecalculator
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(mortagecalculator))
        Me.btnback = New System.Windows.Forms.Button()
        Me.btncalc = New System.Windows.Forms.Button()
        Me.txtmonthpay = New System.Windows.Forms.TextBox()
        Me.txtdownpay = New System.Windows.Forms.TextBox()
        Me.txtprice = New System.Windows.Forms.TextBox()
        Me.lblprice = New System.Windows.Forms.Label()
        Me.lbldownpay = New System.Windows.Forms.Label()
        Me.lblmonthlypay = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblyears = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnback
        '
        Me.btnback.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnback.Location = New System.Drawing.Point(170, 324)
        Me.btnback.Name = "btnback"
        Me.btnback.Size = New System.Drawing.Size(121, 69)
        Me.btnback.TabIndex = 0
        Me.btnback.Text = "Back to Menu"
        Me.btnback.UseVisualStyleBackColor = True
        '
        'btncalc
        '
        Me.btncalc.Font = New System.Drawing.Font("Georgia", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncalc.Location = New System.Drawing.Point(297, 302)
        Me.btncalc.Name = "btncalc"
        Me.btncalc.Size = New System.Drawing.Size(179, 91)
        Me.btncalc.TabIndex = 1
        Me.btncalc.Text = "Calculate"
        Me.btncalc.UseVisualStyleBackColor = True
        '
        'txtmonthpay
        '
        Me.txtmonthpay.Location = New System.Drawing.Point(475, 113)
        Me.txtmonthpay.Name = "txtmonthpay"
        Me.txtmonthpay.Size = New System.Drawing.Size(181, 26)
        Me.txtmonthpay.TabIndex = 2
        '
        'txtdownpay
        '
        Me.txtdownpay.Location = New System.Drawing.Point(475, 69)
        Me.txtdownpay.Name = "txtdownpay"
        Me.txtdownpay.Size = New System.Drawing.Size(181, 26)
        Me.txtdownpay.TabIndex = 3
        '
        'txtprice
        '
        Me.txtprice.AcceptsReturn = True
        Me.txtprice.Location = New System.Drawing.Point(475, 24)
        Me.txtprice.Name = "txtprice"
        Me.txtprice.Size = New System.Drawing.Size(181, 26)
        Me.txtprice.TabIndex = 4
        '
        'lblprice
        '
        Me.lblprice.AutoSize = True
        Me.lblprice.Location = New System.Drawing.Point(377, 27)
        Me.lblprice.Name = "lblprice"
        Me.lblprice.Size = New System.Drawing.Size(92, 18)
        Me.lblprice.TabIndex = 5
        Me.lblprice.Text = "House Price"
        '
        'lbldownpay
        '
        Me.lbldownpay.AutoSize = True
        Me.lbldownpay.Location = New System.Drawing.Point(353, 72)
        Me.lbldownpay.Name = "lbldownpay"
        Me.lbldownpay.Size = New System.Drawing.Size(116, 18)
        Me.lbldownpay.TabIndex = 6
        Me.lbldownpay.Text = "Down Payment"
        '
        'lblmonthlypay
        '
        Me.lblmonthlypay.AutoSize = True
        Me.lblmonthlypay.Location = New System.Drawing.Point(333, 116)
        Me.lblmonthlypay.Name = "lblmonthlypay"
        Me.lblmonthlypay.Size = New System.Drawing.Size(136, 18)
        Me.lblmonthlypay.TabIndex = 7
        Me.lblmonthlypay.Text = "Monthly Payment"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Georgia", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(268, 32)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Mortgage Calculator"
        '
        'lblyears
        '
        Me.lblyears.AutoSize = True
        Me.lblyears.Font = New System.Drawing.Font("Georgia", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblyears.Location = New System.Drawing.Point(90, 198)
        Me.lblyears.Name = "lblyears"
        Me.lblyears.Size = New System.Drawing.Size(130, 46)
        Me.lblyears.TabIndex = 9
        Me.lblyears.Text = "Years:"
        '
        'mortagecalculator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(689, 405)
        Me.Controls.Add(Me.lblyears)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblmonthlypay)
        Me.Controls.Add(Me.lbldownpay)
        Me.Controls.Add(Me.lblprice)
        Me.Controls.Add(Me.txtprice)
        Me.Controls.Add(Me.txtdownpay)
        Me.Controls.Add(Me.txtmonthpay)
        Me.Controls.Add(Me.btncalc)
        Me.Controls.Add(Me.btnback)
        Me.Font = New System.Drawing.Font("Georgia", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "mortagecalculator"
        Me.Text = "Mortgage Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnback As Button
    Friend WithEvents btncalc As Button
    Friend WithEvents txtmonthpay As TextBox
    Friend WithEvents txtdownpay As TextBox
    Friend WithEvents txtprice As TextBox
    Friend WithEvents lblprice As Label
    Friend WithEvents lbldownpay As Label
    Friend WithEvents lblmonthlypay As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblyears As Label
End Class
