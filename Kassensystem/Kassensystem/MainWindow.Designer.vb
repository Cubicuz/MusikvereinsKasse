﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainWindow
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
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

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.DateiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ÖffnenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SpeichernToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BeendenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenüplanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LadenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditierenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditierenToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MainTableLayoutPanel = New System.Windows.Forms.TableLayoutPanel()
        Me.CashRegisterPanel1 = New Kassensystem.CashRegisterPanel()
        Me.CurrentOrderPanel1 = New Kassensystem.CurrentOrderPanel()
        Me.MenuStrip1.SuspendLayout()
        Me.MainTableLayoutPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DateiToolStripMenuItem, Me.MenüplanToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(9, 3, 0, 3)
        Me.MenuStrip1.Size = New System.Drawing.Size(1896, 35)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'DateiToolStripMenuItem
        '
        Me.DateiToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ÖffnenToolStripMenuItem, Me.SpeichernToolStripMenuItem, Me.ToolStripMenuItem1, Me.BeendenToolStripMenuItem})
        Me.DateiToolStripMenuItem.Name = "DateiToolStripMenuItem"
        Me.DateiToolStripMenuItem.Size = New System.Drawing.Size(65, 29)
        Me.DateiToolStripMenuItem.Text = "Datei"
        '
        'ÖffnenToolStripMenuItem
        '
        Me.ÖffnenToolStripMenuItem.Name = "ÖffnenToolStripMenuItem"
        Me.ÖffnenToolStripMenuItem.Size = New System.Drawing.Size(173, 30)
        Me.ÖffnenToolStripMenuItem.Text = "Öffnen"
        '
        'SpeichernToolStripMenuItem
        '
        Me.SpeichernToolStripMenuItem.Name = "SpeichernToolStripMenuItem"
        Me.SpeichernToolStripMenuItem.Size = New System.Drawing.Size(173, 30)
        Me.SpeichernToolStripMenuItem.Text = "Speichern"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(170, 6)
        '
        'BeendenToolStripMenuItem
        '
        Me.BeendenToolStripMenuItem.Name = "BeendenToolStripMenuItem"
        Me.BeendenToolStripMenuItem.Size = New System.Drawing.Size(173, 30)
        Me.BeendenToolStripMenuItem.Text = "Beenden"
        '
        'MenüplanToolStripMenuItem
        '
        Me.MenüplanToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LadenToolStripMenuItem, Me.EditierenToolStripMenuItem, Me.EditierenToolStripMenuItem1})
        Me.MenüplanToolStripMenuItem.Name = "MenüplanToolStripMenuItem"
        Me.MenüplanToolStripMenuItem.Size = New System.Drawing.Size(103, 29)
        Me.MenüplanToolStripMenuItem.Text = "Menüplan"
        '
        'LadenToolStripMenuItem
        '
        Me.LadenToolStripMenuItem.Name = "LadenToolStripMenuItem"
        Me.LadenToolStripMenuItem.Size = New System.Drawing.Size(173, 30)
        Me.LadenToolStripMenuItem.Text = "Laden"
        '
        'EditierenToolStripMenuItem
        '
        Me.EditierenToolStripMenuItem.Name = "EditierenToolStripMenuItem"
        Me.EditierenToolStripMenuItem.Size = New System.Drawing.Size(173, 30)
        Me.EditierenToolStripMenuItem.Text = "Speichern"
        '
        'EditierenToolStripMenuItem1
        '
        Me.EditierenToolStripMenuItem1.Name = "EditierenToolStripMenuItem1"
        Me.EditierenToolStripMenuItem1.Size = New System.Drawing.Size(173, 30)
        Me.EditierenToolStripMenuItem1.Text = "Editieren"
        '
        'MainTableLayoutPanel
        '
        Me.MainTableLayoutPanel.ColumnCount = 2
        Me.MainTableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.MainTableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.MainTableLayoutPanel.Controls.Add(Me.CashRegisterPanel1, 0, 1)
        Me.MainTableLayoutPanel.Controls.Add(Me.CurrentOrderPanel1, 1, 0)
        Me.MainTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MainTableLayoutPanel.Location = New System.Drawing.Point(0, 35)
        Me.MainTableLayoutPanel.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MainTableLayoutPanel.Name = "MainTableLayoutPanel"
        Me.MainTableLayoutPanel.RowCount = 2
        Me.MainTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.MainTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.MainTableLayoutPanel.Size = New System.Drawing.Size(1896, 1136)
        Me.MainTableLayoutPanel.TabIndex = 2
        '
        'CashRegisterPanel1
        '
        Me.CashRegisterPanel1.AutoSize = True
        Me.CashRegisterPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.CashRegisterPanel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CashRegisterPanel1.Location = New System.Drawing.Point(4, 843)
        Me.CashRegisterPanel1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.CashRegisterPanel1.Name = "CashRegisterPanel1"
        Me.CashRegisterPanel1.Size = New System.Drawing.Size(910, 288)
        Me.CashRegisterPanel1.TabIndex = 0
        '
        'CurrentOrderPanel1
        '
        Me.CurrentOrderPanel1.AutoSize = True
        Me.CurrentOrderPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.CurrentOrderPanel1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.CurrentOrderPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CurrentOrderPanel1.Location = New System.Drawing.Point(1590, 8)
        Me.CurrentOrderPanel1.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.CurrentOrderPanel1.MinimumSize = New System.Drawing.Size(300, 462)
        Me.CurrentOrderPanel1.Name = "CurrentOrderPanel1"
        Me.MainTableLayoutPanel.SetRowSpan(Me.CurrentOrderPanel1, 2)
        Me.CurrentOrderPanel1.Size = New System.Drawing.Size(300, 1120)
        Me.CurrentOrderPanel1.TabIndex = 1
        '
        'MainWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1896, 1171)
        Me.Controls.Add(Me.MainTableLayoutPanel)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "MainWindow"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Kassensystem"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.MainTableLayoutPanel.ResumeLayout(False)
        Me.MainTableLayoutPanel.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents DateiToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ÖffnenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SpeichernToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripSeparator
    Friend WithEvents BeendenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MenüplanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LadenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditierenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditierenToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents MainTableLayoutPanel As TableLayoutPanel
    Friend WithEvents CashRegisterPanel1 As CashRegisterPanel
    Friend WithEvents CurrentOrderPanel1 As CurrentOrderPanel
End Class
