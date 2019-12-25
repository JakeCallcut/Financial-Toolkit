<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class budget_manager
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(budget_manager))
        Me.btnback = New System.Windows.Forms.Button()
        Me.btnadd = New System.Windows.Forms.Button()
        Me.lstbxbudget = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblbudget = New System.Windows.Forms.Label()
        Me.txtbudget = New System.Windows.Forms.TextBox()
        Me.lblremaining = New System.Windows.Forms.Label()
        Me.lbltotal = New System.Windows.Forms.Label()
        Me.btnclr = New System.Windows.Forms.Button()
        Me.btnsrt = New System.Windows.Forms.Button()
        Me.cmbxbudget = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'btnback
        '
        Me.btnback.Location = New System.Drawing.Point(70, 366)
        Me.btnback.Name = "btnback"
        Me.btnback.Size = New System.Drawing.Size(149, 58)
        Me.btnback.TabIndex = 0
        Me.btnback.Text = "Back to Menu"
        Me.btnback.UseVisualStyleBackColor = True
        '
        'btnadd
        '
        Me.btnadd.Font = New System.Drawing.Font("Georgia", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnadd.Location = New System.Drawing.Point(225, 334)
        Me.btnadd.Name = "btnadd"
        Me.btnadd.Size = New System.Drawing.Size(201, 90)
        Me.btnadd.TabIndex = 1
        Me.btnadd.Text = "Add Item"
        Me.btnadd.UseVisualStyleBackColor = True
        '
        'lstbxbudget
        '
        Me.lstbxbudget.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstbxbudget.FormattingEnabled = True
        Me.lstbxbudget.ItemHeight = 29
        Me.lstbxbudget.Location = New System.Drawing.Point(441, 14)
        Me.lstbxbudget.Name = "lstbxbudget"
        Me.lstbxbudget.Size = New System.Drawing.Size(347, 410)
        Me.lstbxbudget.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Georgia", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(21, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(280, 41)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Budget Manager"
        '
        'lblbudget
        '
        Me.lblbudget.AutoSize = True
        Me.lblbudget.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblbudget.Location = New System.Drawing.Point(24, 120)
        Me.lblbudget.Name = "lblbudget"
        Me.lblbudget.Size = New System.Drawing.Size(89, 29)
        Me.lblbudget.TabIndex = 4
        Me.lblbudget.Text = "Budget"
        Me.lblbudget.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtbudget
        '
        Me.txtbudget.Location = New System.Drawing.Point(119, 124)
        Me.txtbudget.Name = "txtbudget"
        Me.txtbudget.Size = New System.Drawing.Size(278, 26)
        Me.txtbudget.TabIndex = 5
        '
        'lblremaining
        '
        Me.lblremaining.AutoSize = True
        Me.lblremaining.Font = New System.Drawing.Font("Georgia", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblremaining.Location = New System.Drawing.Point(27, 260)
        Me.lblremaining.Name = "lblremaining"
        Me.lblremaining.Size = New System.Drawing.Size(161, 32)
        Me.lblremaining.TabIndex = 6
        Me.lblremaining.Text = "Remaining:"
        '
        'lbltotal
        '
        Me.lbltotal.AutoSize = True
        Me.lbltotal.Font = New System.Drawing.Font("Georgia", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltotal.Location = New System.Drawing.Point(27, 215)
        Me.lbltotal.Name = "lbltotal"
        Me.lbltotal.Size = New System.Drawing.Size(212, 32)
        Me.lbltotal.TabIndex = 7
        Me.lbltotal.Text = "Total Expenses:"
        '
        'btnclr
        '
        Me.btnclr.Font = New System.Drawing.Font("Georgia", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnclr.Location = New System.Drawing.Point(804, 15)
        Me.btnclr.Name = "btnclr"
        Me.btnclr.Size = New System.Drawing.Size(157, 65)
        Me.btnclr.TabIndex = 8
        Me.btnclr.Text = "Clear"
        Me.btnclr.UseVisualStyleBackColor = True
        '
        'btnsrt
        '
        Me.btnsrt.Font = New System.Drawing.Font("Georgia", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsrt.Location = New System.Drawing.Point(804, 101)
        Me.btnsrt.Name = "btnsrt"
        Me.btnsrt.Size = New System.Drawing.Size(157, 65)
        Me.btnsrt.TabIndex = 9
        Me.btnsrt.Text = "Sort"
        Me.btnsrt.UseVisualStyleBackColor = True
        '
        'cmbxbudget
        '
        Me.cmbxbudget.FormattingEnabled = True
        Me.cmbxbudget.Items.AddRange(New Object() {"Lowest First", "Highest First"})
        Me.cmbxbudget.Location = New System.Drawing.Point(804, 172)
        Me.cmbxbudget.Name = "cmbxbudget"
        Me.cmbxbudget.Size = New System.Drawing.Size(157, 28)
        Me.cmbxbudget.TabIndex = 10
        '
        'budget_manager
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(973, 446)
        Me.Controls.Add(Me.cmbxbudget)
        Me.Controls.Add(Me.btnsrt)
        Me.Controls.Add(Me.btnclr)
        Me.Controls.Add(Me.lbltotal)
        Me.Controls.Add(Me.lblremaining)
        Me.Controls.Add(Me.txtbudget)
        Me.Controls.Add(Me.lblbudget)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lstbxbudget)
        Me.Controls.Add(Me.btnadd)
        Me.Controls.Add(Me.btnback)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "budget_manager"
        Me.Text = "Budget Manager"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnback As Button
    Friend WithEvents btnadd As Button
    Friend WithEvents lstbxbudget As ListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lblbudget As Label
    Friend WithEvents txtbudget As TextBox
    Friend WithEvents lblremaining As Label
    Friend WithEvents lbltotal As Label
    Friend WithEvents btnclr As Button
    Friend WithEvents btnsrt As Button
    Friend WithEvents cmbxbudget As ComboBox
End Class
