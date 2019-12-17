<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class currencyconverter
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(currencyconverter))
        Me.grpbxcurrency = New System.Windows.Forms.GroupBox()
        Me.cmbxleft = New System.Windows.Forms.ComboBox()
        Me.lbltofrom = New System.Windows.Forms.Label()
        Me.cmbxright = New System.Windows.Forms.ComboBox()
        Me.btnswap = New System.Windows.Forms.Button()
        Me.grpbxcurrency.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpbxcurrency
        '
        Me.grpbxcurrency.Controls.Add(Me.btnswap)
        Me.grpbxcurrency.Controls.Add(Me.cmbxright)
        Me.grpbxcurrency.Controls.Add(Me.lbltofrom)
        Me.grpbxcurrency.Controls.Add(Me.cmbxleft)
        Me.grpbxcurrency.Location = New System.Drawing.Point(139, 94)
        Me.grpbxcurrency.Name = "grpbxcurrency"
        Me.grpbxcurrency.Size = New System.Drawing.Size(521, 209)
        Me.grpbxcurrency.TabIndex = 0
        Me.grpbxcurrency.TabStop = False
        Me.grpbxcurrency.Text = "Settings"
        '
        'cmbxleft
        '
        Me.cmbxleft.FormattingEnabled = True
        Me.cmbxleft.Location = New System.Drawing.Point(35, 78)
        Me.cmbxleft.Name = "cmbxleft"
        Me.cmbxleft.Size = New System.Drawing.Size(146, 28)
        Me.cmbxleft.TabIndex = 0
        '
        'lbltofrom
        '
        Me.lbltofrom.AutoSize = True
        Me.lbltofrom.Font = New System.Drawing.Font("Georgia", 26.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltofrom.Location = New System.Drawing.Point(232, 59)
        Me.lbltofrom.Name = "lbltofrom"
        Me.lbltofrom.Size = New System.Drawing.Size(58, 60)
        Me.lbltofrom.TabIndex = 1
        Me.lbltofrom.Text = ">"
        '
        'cmbxright
        '
        Me.cmbxright.FormattingEnabled = True
        Me.cmbxright.Location = New System.Drawing.Point(324, 78)
        Me.cmbxright.Name = "cmbxright"
        Me.cmbxright.Size = New System.Drawing.Size(144, 28)
        Me.cmbxright.TabIndex = 2
        '
        'btnswap
        '
        Me.btnswap.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnswap.Location = New System.Drawing.Point(203, 122)
        Me.btnswap.Name = "btnswap"
        Me.btnswap.Size = New System.Drawing.Size(107, 47)
        Me.btnswap.TabIndex = 3
        Me.btnswap.Text = "Swap"
        Me.btnswap.UseVisualStyleBackColor = True
        '
        'currencyconverter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.grpbxcurrency)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "currencyconverter"
        Me.Text = "Currency Converter"
        Me.grpbxcurrency.ResumeLayout(False)
        Me.grpbxcurrency.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grpbxcurrency As GroupBox
    Friend WithEvents cmbxleft As ComboBox
    Friend WithEvents cmbxright As ComboBox
    Friend WithEvents lbltofrom As Label
    Friend WithEvents btnswap As Button
End Class
