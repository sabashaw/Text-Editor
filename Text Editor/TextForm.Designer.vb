﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TextForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TextForm))
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.sslStatus = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.tbrClear = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tbrRed = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.tbrBlue = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.tbrUpperCase = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.tbrLowerCase = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.tbrHelpAbout = New System.Windows.Forms.ToolStripButton()
        Me.txtEdit = New System.Windows.Forms.TextBox()
        Me.StatusStrip1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.sslStatus})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 399)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(584, 22)
        Me.StatusStrip1.TabIndex = 0
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'sslStatus
        '
        Me.sslStatus.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.sslStatus.Name = "sslStatus"
        Me.sslStatus.Size = New System.Drawing.Size(39, 17)
        Me.sslStatus.Text = "Ready"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tbrClear, Me.ToolStripSeparator1, Me.tbrRed, Me.ToolStripSeparator2, Me.tbrBlue, Me.ToolStripSeparator3, Me.tbrUpperCase, Me.ToolStripSeparator4, Me.tbrLowerCase, Me.ToolStripSeparator5, Me.tbrHelpAbout})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(584, 25)
        Me.ToolStrip1.Stretch = True
        Me.ToolStrip1.TabIndex = 1
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'tbrClear
        '
        Me.tbrClear.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tbrClear.Image = CType(resources.GetObject("tbrClear.Image"), System.Drawing.Image)
        Me.tbrClear.ImageTransparentColor = System.Drawing.Color.Black
        Me.tbrClear.Name = "tbrClear"
        Me.tbrClear.Size = New System.Drawing.Size(23, 22)
        Me.tbrClear.Text = "New"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'tbrRed
        '
        Me.tbrRed.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tbrRed.Image = CType(resources.GetObject("tbrRed.Image"), System.Drawing.Image)
        Me.tbrRed.ImageTransparentColor = System.Drawing.Color.Black
        Me.tbrRed.Name = "tbrRed"
        Me.tbrRed.Size = New System.Drawing.Size(23, 22)
        Me.tbrRed.Text = "ToolStripButton1"
        Me.tbrRed.ToolTipText = "Red"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'tbrBlue
        '
        Me.tbrBlue.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tbrBlue.Image = CType(resources.GetObject("tbrBlue.Image"), System.Drawing.Image)
        Me.tbrBlue.ImageTransparentColor = System.Drawing.Color.Black
        Me.tbrBlue.Name = "tbrBlue"
        Me.tbrBlue.Size = New System.Drawing.Size(23, 22)
        Me.tbrBlue.Text = "ToolStripButton2"
        Me.tbrBlue.ToolTipText = "Blue"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'tbrUpperCase
        '
        Me.tbrUpperCase.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tbrUpperCase.Image = CType(resources.GetObject("tbrUpperCase.Image"), System.Drawing.Image)
        Me.tbrUpperCase.ImageTransparentColor = System.Drawing.Color.Black
        Me.tbrUpperCase.Name = "tbrUpperCase"
        Me.tbrUpperCase.Size = New System.Drawing.Size(23, 22)
        Me.tbrUpperCase.Text = "ToolStripButton3"
        Me.tbrUpperCase.ToolTipText = "Upper Case"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 25)
        '
        'tbrLowerCase
        '
        Me.tbrLowerCase.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tbrLowerCase.Image = CType(resources.GetObject("tbrLowerCase.Image"), System.Drawing.Image)
        Me.tbrLowerCase.ImageTransparentColor = System.Drawing.Color.Black
        Me.tbrLowerCase.Name = "tbrLowerCase"
        Me.tbrLowerCase.Size = New System.Drawing.Size(23, 22)
        Me.tbrLowerCase.Text = "ToolStripButton4"
        Me.tbrLowerCase.ToolTipText = "Lower Case"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 25)
        '
        'tbrHelpAbout
        '
        Me.tbrHelpAbout.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tbrHelpAbout.Image = CType(resources.GetObject("tbrHelpAbout.Image"), System.Drawing.Image)
        Me.tbrHelpAbout.ImageTransparentColor = System.Drawing.Color.Black
        Me.tbrHelpAbout.Name = "tbrHelpAbout"
        Me.tbrHelpAbout.Size = New System.Drawing.Size(23, 22)
        Me.tbrHelpAbout.Text = "ToolStripButton1"
        Me.tbrHelpAbout.ToolTipText = "About"
        '
        'txtEdit
        '
        Me.txtEdit.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtEdit.Location = New System.Drawing.Point(0, 25)
        Me.txtEdit.Margin = New System.Windows.Forms.Padding(3, 3, 3, 20)
        Me.txtEdit.Multiline = True
        Me.txtEdit.Name = "txtEdit"
        Me.txtEdit.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtEdit.Size = New System.Drawing.Size(584, 374)
        Me.txtEdit.TabIndex = 2
        '
        'TextForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(584, 421)
        Me.Controls.Add(Me.txtEdit)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Name = "TextForm"
        Me.Text = "TextForm"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents sslStatus As ToolStripStatusLabel
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents tbrClear As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents tbrRed As ToolStripButton
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents tbrBlue As ToolStripButton
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents tbrUpperCase As ToolStripButton
    Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
    Friend WithEvents tbrLowerCase As ToolStripButton
    Friend WithEvents ToolStripSeparator5 As ToolStripSeparator
    Friend WithEvents tbrHelpAbout As ToolStripButton
    Friend WithEvents txtEdit As TextBox
End Class
