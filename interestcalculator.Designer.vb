<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class interestcalculator
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(interestcalculator))
        Me.rdbtncompound = New System.Windows.Forms.RadioButton()
        Me.rdbtnsimple = New System.Windows.Forms.RadioButton()
        Me.grpbx = New System.Windows.Forms.GroupBox()
        Me.btncalc = New System.Windows.Forms.Button()
        Me.txtamount = New System.Windows.Forms.TextBox()
        Me.txtyears = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtrate = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblresult = New System.Windows.Forms.Label()
        Me.grpbx.SuspendLayout()
        Me.SuspendLayout()
        '
        'rdbtncompound
        '
        Me.rdbtncompound.AutoSize = True
        Me.rdbtncompound.Location = New System.Drawing.Point(17, 66)
        Me.rdbtncompound.Name = "rdbtncompound"
        Me.rdbtncompound.Size = New System.Drawing.Size(112, 24)
        Me.rdbtncompound.TabIndex = 0
        Me.rdbtncompound.TabStop = True
        Me.rdbtncompound.Text = "Compound"
        Me.rdbtncompound.UseVisualStyleBackColor = True
        '
        'rdbtnsimple
        '
        Me.rdbtnsimple.AutoSize = True
        Me.rdbtnsimple.Location = New System.Drawing.Point(17, 36)
        Me.rdbtnsimple.Name = "rdbtnsimple"
        Me.rdbtnsimple.Size = New System.Drawing.Size(82, 24)
        Me.rdbtnsimple.TabIndex = 1
        Me.rdbtnsimple.TabStop = True
        Me.rdbtnsimple.Text = "Simple"
        Me.rdbtnsimple.UseVisualStyleBackColor = True
        '
        'grpbx
        '
        Me.grpbx.Controls.Add(Me.rdbtnsimple)
        Me.grpbx.Controls.Add(Me.rdbtncompound)
        Me.grpbx.Location = New System.Drawing.Point(12, 12)
        Me.grpbx.Name = "grpbx"
        Me.grpbx.Size = New System.Drawing.Size(168, 109)
        Me.grpbx.TabIndex = 2
        Me.grpbx.TabStop = False
        Me.grpbx.Text = "Interest Type"
        '
        'btncalc
        '
        Me.btncalc.Font = New System.Drawing.Font("Georgia", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncalc.Location = New System.Drawing.Point(288, 345)
        Me.btncalc.Name = "btncalc"
        Me.btncalc.Size = New System.Drawing.Size(231, 93)
        Me.btncalc.TabIndex = 3
        Me.btncalc.Text = "Calculate"
        Me.btncalc.UseVisualStyleBackColor = True
        '
        'txtamount
        '
        Me.txtamount.Location = New System.Drawing.Point(491, 95)
        Me.txtamount.Name = "txtamount"
        Me.txtamount.Size = New System.Drawing.Size(236, 26)
        Me.txtamount.TabIndex = 4
        '
        'txtyears
        '
        Me.txtyears.Location = New System.Drawing.Point(491, 46)
        Me.txtyears.Name = "txtyears"
        Me.txtyears.Size = New System.Drawing.Size(236, 26)
        Me.txtyears.TabIndex = 5
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(136, 362)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(136, 68)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Back To Menu"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtrate
        '
        Me.txtrate.Location = New System.Drawing.Point(491, 143)
        Me.txtrate.Name = "txtrate"
        Me.txtrate.Size = New System.Drawing.Size(236, 26)
        Me.txtrate.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Georgia", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(426, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 24)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Years"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Georgia", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(402, 95)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 24)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Amount"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Georgia", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(434, 145)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 24)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Rate"
        '
        'lblresult
        '
        Me.lblresult.AutoSize = True
        Me.lblresult.Font = New System.Drawing.Font("Georgia", 22.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblresult.Location = New System.Drawing.Point(136, 229)
        Me.lblresult.Name = "lblresult"
        Me.lblresult.Size = New System.Drawing.Size(183, 51)
        Me.lblresult.TabIndex = 11
        Me.lblresult.Text = "Return: "
        '
        'interestcalculator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblresult)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtrate)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtyears)
        Me.Controls.Add(Me.txtamount)
        Me.Controls.Add(Me.btncalc)
        Me.Controls.Add(Me.grpbx)
        Me.ForeColor = System.Drawing.Color.Black
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "interestcalculator"
        Me.Text = "interestcalculator"
        Me.grpbx.ResumeLayout(False)
        Me.grpbx.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents rdbtncompound As RadioButton
    Friend WithEvents rdbtnsimple As RadioButton
    Friend WithEvents grpbx As GroupBox
    Friend WithEvents btncalc As Button
    Friend WithEvents txtamount As TextBox
    Friend WithEvents txtyears As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents txtrate As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblresult As Label
End Class
