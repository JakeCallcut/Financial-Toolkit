﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.btninterest = New System.Windows.Forms.Button()
        Me.btnquit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btninterest
        '
        Me.btninterest.Font = New System.Drawing.Font("Georgia", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btninterest.Location = New System.Drawing.Point(82, 299)
        Me.btninterest.Name = "btninterest"
        Me.btninterest.Size = New System.Drawing.Size(171, 91)
        Me.btninterest.TabIndex = 0
        Me.btninterest.Text = "Interest Calculator"
        Me.btninterest.UseVisualStyleBackColor = True
        '
        'btnquit
        '
        Me.btnquit.Font = New System.Drawing.Font("Georgia", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnquit.Location = New System.Drawing.Point(65, 396)
        Me.btnquit.Name = "btnquit"
        Me.btnquit.Size = New System.Drawing.Size(198, 86)
        Me.btnquit.TabIndex = 1
        Me.btnquit.Text = "Quit"
        Me.btnquit.UseVisualStyleBackColor = True
        '
        'frmmenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(329, 494)
        Me.Controls.Add(Me.btnquit)
        Me.Controls.Add(Me.btninterest)
        Me.Name = "frmmenu"
        Me.Text = "Financial Toolkit"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btninterest As Button
    Friend WithEvents btnquit As Button
End Class
