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
        'budget_manager
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
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
End Class
