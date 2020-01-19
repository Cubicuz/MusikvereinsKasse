<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.MenüplanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LoadDiningPlanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatistikToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NichtVerfügbarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
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
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenüplanToolStripMenuItem, Me.StatistikToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(9, 3, 0, 3)
        Me.MenuStrip1.Size = New System.Drawing.Size(1604, 35)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MenüplanToolStripMenuItem
        '
        Me.MenüplanToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LoadDiningPlanToolStripMenuItem})
        Me.MenüplanToolStripMenuItem.Name = "MenüplanToolStripMenuItem"
        Me.MenüplanToolStripMenuItem.Size = New System.Drawing.Size(103, 29)
        Me.MenüplanToolStripMenuItem.Text = "Menüplan"
        '
        'LoadDiningPlanToolStripMenuItem
        '
        Me.LoadDiningPlanToolStripMenuItem.Name = "LoadDiningPlanToolStripMenuItem"
        Me.LoadDiningPlanToolStripMenuItem.Size = New System.Drawing.Size(210, 30)
        Me.LoadDiningPlanToolStripMenuItem.Text = "Laden"
        '
        'StatistikToolStripMenuItem
        '
        Me.StatistikToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NichtVerfügbarToolStripMenuItem})
        Me.StatistikToolStripMenuItem.Enabled = False
        Me.StatistikToolStripMenuItem.Name = "StatistikToolStripMenuItem"
        Me.StatistikToolStripMenuItem.Size = New System.Drawing.Size(85, 29)
        Me.StatistikToolStripMenuItem.Text = "Statistik"
        '
        'NichtVerfügbarToolStripMenuItem
        '
        Me.NichtVerfügbarToolStripMenuItem.Name = "NichtVerfügbarToolStripMenuItem"
        Me.NichtVerfügbarToolStripMenuItem.Size = New System.Drawing.Size(216, 30)
        Me.NichtVerfügbarToolStripMenuItem.Text = "nicht verfügbar"
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
        Me.MainTableLayoutPanel.Size = New System.Drawing.Size(1604, 847)
        Me.MainTableLayoutPanel.TabIndex = 2
        '
        'CashRegisterPanel1
        '
        Me.CashRegisterPanel1.AutoSize = True
        Me.CashRegisterPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.CashRegisterPanel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CashRegisterPanel1.Location = New System.Drawing.Point(4, 436)
        Me.CashRegisterPanel1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.CashRegisterPanel1.Name = "CashRegisterPanel1"
        Me.CashRegisterPanel1.Size = New System.Drawing.Size(1276, 406)
        Me.CashRegisterPanel1.TabIndex = 0
        '
        'CurrentOrderPanel1
        '
        Me.CurrentOrderPanel1.AutoSize = True
        Me.CurrentOrderPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.CurrentOrderPanel1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.CurrentOrderPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CurrentOrderPanel1.Location = New System.Drawing.Point(1298, 8)
        Me.CurrentOrderPanel1.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.CurrentOrderPanel1.MinimumSize = New System.Drawing.Size(300, 462)
        Me.CurrentOrderPanel1.Name = "CurrentOrderPanel1"
        Me.MainTableLayoutPanel.SetRowSpan(Me.CurrentOrderPanel1, 2)
        Me.CurrentOrderPanel1.Size = New System.Drawing.Size(300, 831)
        Me.CurrentOrderPanel1.TabIndex = 1
        '
        'MainWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1604, 882)
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
    Friend WithEvents MenüplanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LoadDiningPlanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MainTableLayoutPanel As TableLayoutPanel
    Friend WithEvents CashRegisterPanel1 As CashRegisterPanel
    Friend WithEvents CurrentOrderPanel1 As CurrentOrderPanel
    Friend WithEvents StatistikToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NichtVerfügbarToolStripMenuItem As ToolStripMenuItem
End Class
