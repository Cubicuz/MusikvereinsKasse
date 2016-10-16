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
        Me.DateiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ÖffnenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SpeichernToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BeendenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenüplanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LadenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditierenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditierenToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DateiToolStripMenuItem, Me.MenüplanToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(814, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'DateiToolStripMenuItem
        '
        Me.DateiToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ÖffnenToolStripMenuItem, Me.SpeichernToolStripMenuItem, Me.ToolStripMenuItem1, Me.BeendenToolStripMenuItem})
        Me.DateiToolStripMenuItem.Name = "DateiToolStripMenuItem"
        Me.DateiToolStripMenuItem.Size = New System.Drawing.Size(46, 20)
        Me.DateiToolStripMenuItem.Text = "Datei"
        '
        'ÖffnenToolStripMenuItem
        '
        Me.ÖffnenToolStripMenuItem.Name = "ÖffnenToolStripMenuItem"
        Me.ÖffnenToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ÖffnenToolStripMenuItem.Text = "Öffnen"
        '
        'SpeichernToolStripMenuItem
        '
        Me.SpeichernToolStripMenuItem.Name = "SpeichernToolStripMenuItem"
        Me.SpeichernToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.SpeichernToolStripMenuItem.Text = "Speichern"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(149, 6)
        '
        'BeendenToolStripMenuItem
        '
        Me.BeendenToolStripMenuItem.Name = "BeendenToolStripMenuItem"
        Me.BeendenToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.BeendenToolStripMenuItem.Text = "Beenden"
        '
        'MenüplanToolStripMenuItem
        '
        Me.MenüplanToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LadenToolStripMenuItem, Me.EditierenToolStripMenuItem, Me.EditierenToolStripMenuItem1})
        Me.MenüplanToolStripMenuItem.Name = "MenüplanToolStripMenuItem"
        Me.MenüplanToolStripMenuItem.Size = New System.Drawing.Size(73, 20)
        Me.MenüplanToolStripMenuItem.Text = "Menüplan"
        '
        'LadenToolStripMenuItem
        '
        Me.LadenToolStripMenuItem.Name = "LadenToolStripMenuItem"
        Me.LadenToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.LadenToolStripMenuItem.Text = "Laden"
        '
        'EditierenToolStripMenuItem
        '
        Me.EditierenToolStripMenuItem.Name = "EditierenToolStripMenuItem"
        Me.EditierenToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.EditierenToolStripMenuItem.Text = "Speichern"
        '
        'EditierenToolStripMenuItem1
        '
        Me.EditierenToolStripMenuItem1.Name = "EditierenToolStripMenuItem1"
        Me.EditierenToolStripMenuItem1.Size = New System.Drawing.Size(152, 22)
        Me.EditierenToolStripMenuItem1.Text = "Editieren"
        '
        'MainWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(814, 439)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "MainWindow"
        Me.Text = "Kassensystem"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
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
End Class
