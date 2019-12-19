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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btncurr = New System.Windows.Forms.Button()
        Me.btnbudgeting = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.InitialImage = CType(resources.GetObject("PictureBox1.InitialImage"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(63, 48)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(314, 74)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
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
        'frmmenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(427, 695)
        Me.Controls.Add(Me.btnbudgeting)
        Me.Controls.Add(Me.btncurr)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnmortgage)
        Me.Controls.Add(Me.btnquit)
        Me.Controls.Add(Me.btninterest)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmmenu"
        Me.Text = "Financial Toolkit"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btninterest As Button
    Friend WithEvents btnquit As Button
    Friend WithEvents btnmortgage As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btncurr As Button
    Friend WithEvents btnbudgeting As Button
End Class
