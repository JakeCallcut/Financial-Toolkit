<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmmenu
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmmenu))
        Me.btninterest = New System.Windows.Forms.Button()
        Me.btnquit = New System.Windows.Forms.Button()
        Me.btnmortgage = New System.Windows.Forms.Button()
        Me.btncurr = New System.Windows.Forms.Button()
        Me.btnbudgeting = New System.Windows.Forms.Button()
        Me.cmbcurr = New System.Windows.Forms.ComboBox()
        Me.lblcurr = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btninterest
        '
        Me.btninterest.Font = New System.Drawing.Font("Georgia", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btninterest.Location = New System.Drawing.Point(124, 491)
        Me.btninterest.Name = "btninterest"
        Me.btninterest.Size = New System.Drawing.Size(188, 100)
        Me.btninterest.TabIndex = 0
        Me.btninterest.Text = "Interest Calculator"
        Me.btninterest.UseVisualStyleBackColor = True
        '
        'btnquit
        '
        Me.btnquit.Font = New System.Drawing.Font("Georgia", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnquit.Location = New System.Drawing.Point(109, 597)
        Me.btnquit.Name = "btnquit"
        Me.btnquit.Size = New System.Drawing.Size(219, 86)
        Me.btnquit.TabIndex = 1
        Me.btnquit.Text = "Quit"
        Me.btnquit.UseVisualStyleBackColor = True
        '
        'btnmortgage
        '
        Me.btnmortgage.Font = New System.Drawing.Font("Georgia", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnmortgage.Location = New System.Drawing.Point(124, 384)
        Me.btnmortgage.Name = "btnmortgage"
        Me.btnmortgage.Size = New System.Drawing.Size(188, 101)
        Me.btnmortgage.TabIndex = 2
        Me.btnmortgage.Text = "Mortgage Calculator"
        Me.btnmortgage.UseVisualStyleBackColor = True
        '
        'btncurr
        '
        Me.btncurr.Font = New System.Drawing.Font("Georgia", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncurr.Location = New System.Drawing.Point(124, 277)
        Me.btncurr.Name = "btncurr"
        Me.btncurr.Size = New System.Drawing.Size(188, 101)
        Me.btncurr.TabIndex = 4
        Me.btncurr.Text = "Currency Converter"
        Me.btncurr.UseVisualStyleBackColor = True
        '
        'btnbudgeting
        '
        Me.btnbudgeting.Font = New System.Drawing.Font("Georgia", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnbudgeting.Location = New System.Drawing.Point(124, 170)
        Me.btnbudgeting.Name = "btnbudgeting"
        Me.btnbudgeting.Size = New System.Drawing.Size(188, 101)
        Me.btnbudgeting.TabIndex = 5
        Me.btnbudgeting.Text = "Budget Manager"
        Me.btnbudgeting.UseVisualStyleBackColor = True
        '
        'cmbcurr
        '
        Me.cmbcurr.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbcurr.FormattingEnabled = True
        Me.cmbcurr.Items.AddRange(New Object() {"GBP", "USD", "EUR", "JPY", "KRW", "AUD", "CAD", "IDR", "CHF"})
        Me.cmbcurr.Location = New System.Drawing.Point(229, 117)
        Me.cmbcurr.Name = "cmbcurr"
        Me.cmbcurr.Size = New System.Drawing.Size(99, 28)
        Me.cmbcurr.TabIndex = 6
        '
        'lblcurr
        '
        Me.lblcurr.AutoSize = True
        Me.lblcurr.Font = New System.Drawing.Font("Georgia", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcurr.Location = New System.Drawing.Point(84, 110)
        Me.lblcurr.Name = "lblcurr"
        Me.lblcurr.Size = New System.Drawing.Size(139, 32)
        Me.lblcurr.TabIndex = 7
        Me.lblcurr.Text = "Currency:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.PowderBlue
        Me.Label1.Font = New System.Drawing.Font("Palatino Linotype", 22.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label1.Location = New System.Drawing.Point(64, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(300, 60)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Finance Toolkit"
        '
        'frmmenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(427, 695)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblcurr)
        Me.Controls.Add(Me.cmbcurr)
        Me.Controls.Add(Me.btnbudgeting)
        Me.Controls.Add(Me.btncurr)
        Me.Controls.Add(Me.btnmortgage)
        Me.Controls.Add(Me.btnquit)
        Me.Controls.Add(Me.btninterest)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmmenu"
        Me.Text = "Financial Toolkit"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btninterest As Button
    Friend WithEvents btnquit As Button
    Friend WithEvents btnmortgage As Button
    Friend WithEvents btncurr As Button
    Friend WithEvents btnbudgeting As Button
    Friend WithEvents cmbcurr As ComboBox
    Friend WithEvents lblcurr As Label
    Friend WithEvents Label1 As Label
End Class
