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
        Me.cmbxright = New System.Windows.Forms.ComboBox()
        Me.cmbxleft = New System.Windows.Forms.ComboBox()
        Me.btnback = New System.Windows.Forms.Button()
        Me.btngo = New System.Windows.Forms.Button()
        Me.lblto = New System.Windows.Forms.Label()
        Me.grpbxcurrency.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpbxcurrency
        '
        Me.grpbxcurrency.Controls.Add(Me.lblto)
        Me.grpbxcurrency.Controls.Add(Me.cmbxright)
        Me.grpbxcurrency.Controls.Add(Me.cmbxleft)
        Me.grpbxcurrency.Location = New System.Drawing.Point(142, 80)
        Me.grpbxcurrency.Name = "grpbxcurrency"
        Me.grpbxcurrency.Size = New System.Drawing.Size(521, 209)
        Me.grpbxcurrency.TabIndex = 0
        Me.grpbxcurrency.TabStop = False
        Me.grpbxcurrency.Text = "Settings"
        '
        'cmbxright
        '
        Me.cmbxright.FormattingEnabled = True
        Me.cmbxright.Items.AddRange(New Object() {"GBP", "USD", "EUR", "JPY", "CHF", "AUD", "CAD", "ZAR"})
        Me.cmbxright.Location = New System.Drawing.Point(324, 89)
        Me.cmbxright.Name = "cmbxright"
        Me.cmbxright.Size = New System.Drawing.Size(144, 28)
        Me.cmbxright.TabIndex = 2
        '
        'cmbxleft
        '
        Me.cmbxleft.FormattingEnabled = True
        Me.cmbxleft.Items.AddRange(New Object() {"GBP", "USD", "EUR", "JPY", "CHF", "AUD", "CAD", "ZAR"})
        Me.cmbxleft.Location = New System.Drawing.Point(35, 89)
        Me.cmbxleft.Name = "cmbxleft"
        Me.cmbxleft.Size = New System.Drawing.Size(146, 28)
        Me.cmbxleft.TabIndex = 0
        '
        'btnback
        '
        Me.btnback.Font = New System.Drawing.Font("Georgia", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnback.Location = New System.Drawing.Point(130, 342)
        Me.btnback.Name = "btnback"
        Me.btnback.Size = New System.Drawing.Size(159, 96)
        Me.btnback.TabIndex = 1
        Me.btnback.Text = "Back to Menu"
        Me.btnback.UseVisualStyleBackColor = True
        '
        'btngo
        '
        Me.btngo.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btngo.Font = New System.Drawing.Font("Georgia", 26.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btngo.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btngo.Location = New System.Drawing.Point(295, 319)
        Me.btngo.Name = "btngo"
        Me.btngo.Size = New System.Drawing.Size(203, 119)
        Me.btngo.TabIndex = 2
        Me.btngo.Text = "Go"
        Me.btngo.UseVisualStyleBackColor = False
        '
        'lblto
        '
        Me.lblto.AutoSize = True
        Me.lblto.Font = New System.Drawing.Font("Georgia", 28.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblto.Location = New System.Drawing.Point(230, 69)
        Me.lblto.Name = "lblto"
        Me.lblto.Size = New System.Drawing.Size(64, 65)
        Me.lblto.TabIndex = 3
        Me.lblto.Text = ">"
        '
        'currencyconverter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btngo)
        Me.Controls.Add(Me.btnback)
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
    Friend WithEvents btnback As Button
    Friend WithEvents btngo As Button
    Friend WithEvents lblto As Label
End Class
