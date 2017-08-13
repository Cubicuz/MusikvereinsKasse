<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MealControl
    Inherits System.Windows.Forms.UserControl

    'UserControl überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
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
        Me.MainTableLayoutPanel = New System.Windows.Forms.TableLayoutPanel()
        Me.NameLabel = New System.Windows.Forms.Label()
        Me.PriceTextBox = New System.Windows.Forms.TextBox()
        Me.HalfMealTableLayoutPanel = New System.Windows.Forms.TableLayoutPanel()
        Me.HalfMealComboBox = New System.Windows.Forms.ComboBox()
        Me.HalfMealDownButton = New System.Windows.Forms.Button()
        Me.HalfMealUpButton = New System.Windows.Forms.Button()
        Me.FullMealTableLayoutPanel = New System.Windows.Forms.TableLayoutPanel()
        Me.FullMealComboBox = New System.Windows.Forms.ComboBox()
        Me.FullMealUpButton = New System.Windows.Forms.Button()
        Me.FullMealDownButton = New System.Windows.Forms.Button()
        Me.MainTableLayoutPanel.SuspendLayout()
        Me.HalfMealTableLayoutPanel.SuspendLayout()
        Me.FullMealTableLayoutPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'MainTableLayoutPanel
        '
        Me.MainTableLayoutPanel.AutoSize = True
        Me.MainTableLayoutPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.MainTableLayoutPanel.ColumnCount = 4
        Me.MainTableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.MainTableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.MainTableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.MainTableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.MainTableLayoutPanel.Controls.Add(Me.NameLabel, 0, 0)
        Me.MainTableLayoutPanel.Controls.Add(Me.PriceTextBox, 3, 0)
        Me.MainTableLayoutPanel.Controls.Add(Me.HalfMealTableLayoutPanel, 2, 0)
        Me.MainTableLayoutPanel.Controls.Add(Me.FullMealTableLayoutPanel, 1, 0)
        Me.MainTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MainTableLayoutPanel.Location = New System.Drawing.Point(0, 0)
        Me.MainTableLayoutPanel.Margin = New System.Windows.Forms.Padding(0)
        Me.MainTableLayoutPanel.MinimumSize = New System.Drawing.Size(250, 0)
        Me.MainTableLayoutPanel.Name = "MainTableLayoutPanel"
        Me.MainTableLayoutPanel.RowCount = 1
        Me.MainTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.MainTableLayoutPanel.Size = New System.Drawing.Size(250, 73)
        Me.MainTableLayoutPanel.TabIndex = 0
        '
        'NameLabel
        '
        Me.NameLabel.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.NameLabel.AutoSize = True
        Me.NameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NameLabel.Location = New System.Drawing.Point(23, 24)
        Me.NameLabel.Name = "NameLabel"
        Me.NameLabel.Size = New System.Drawing.Size(66, 24)
        Me.NameLabel.TabIndex = 3
        Me.NameLabel.Text = "Label1"
        Me.NameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PriceTextBox
        '
        Me.PriceTextBox.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PriceTextBox.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.PriceTextBox.Location = New System.Drawing.Point(207, 26)
        Me.PriceTextBox.MinimumSize = New System.Drawing.Size(40, 4)
        Me.PriceTextBox.Name = "PriceTextBox"
        Me.PriceTextBox.ReadOnly = True
        Me.PriceTextBox.Size = New System.Drawing.Size(40, 20)
        Me.PriceTextBox.TabIndex = 1
        Me.PriceTextBox.TabStop = False
        Me.PriceTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'HalfMealTableLayoutPanel
        '
        Me.HalfMealTableLayoutPanel.AutoSize = True
        Me.HalfMealTableLayoutPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.HalfMealTableLayoutPanel.ColumnCount = 1
        Me.HalfMealTableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.HalfMealTableLayoutPanel.Controls.Add(Me.HalfMealComboBox, 0, 1)
        Me.HalfMealTableLayoutPanel.Controls.Add(Me.HalfMealDownButton, 0, 2)
        Me.HalfMealTableLayoutPanel.Controls.Add(Me.HalfMealUpButton, 0, 0)
        Me.HalfMealTableLayoutPanel.Location = New System.Drawing.Point(158, 0)
        Me.HalfMealTableLayoutPanel.Margin = New System.Windows.Forms.Padding(0)
        Me.HalfMealTableLayoutPanel.Name = "HalfMealTableLayoutPanel"
        Me.HalfMealTableLayoutPanel.RowCount = 3
        Me.HalfMealTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.HalfMealTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.HalfMealTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.HalfMealTableLayoutPanel.Size = New System.Drawing.Size(46, 73)
        Me.HalfMealTableLayoutPanel.TabIndex = 5
        '
        'HalfMealComboBox
        '
        Me.HalfMealComboBox.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.HalfMealComboBox.FormattingEnabled = True
        Me.HalfMealComboBox.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.HalfMealComboBox.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10"})
        Me.HalfMealComboBox.Location = New System.Drawing.Point(3, 26)
        Me.HalfMealComboBox.Margin = New System.Windows.Forms.Padding(3, 0, 3, 0)
        Me.HalfMealComboBox.Name = "HalfMealComboBox"
        Me.HalfMealComboBox.Size = New System.Drawing.Size(40, 21)
        Me.HalfMealComboBox.TabIndex = 4
        Me.HalfMealComboBox.TabStop = False
        Me.HalfMealComboBox.Text = "0"
        '
        'HalfMealDownButton
        '
        Me.HalfMealDownButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.HalfMealDownButton.Location = New System.Drawing.Point(3, 50)
        Me.HalfMealDownButton.Name = "HalfMealDownButton"
        Me.HalfMealDownButton.Size = New System.Drawing.Size(40, 20)
        Me.HalfMealDownButton.TabIndex = 5
        Me.HalfMealDownButton.TabStop = False
        Me.HalfMealDownButton.Text = "▼"
        Me.HalfMealDownButton.UseVisualStyleBackColor = True
        '
        'HalfMealUpButton
        '
        Me.HalfMealUpButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.HalfMealUpButton.Location = New System.Drawing.Point(3, 3)
        Me.HalfMealUpButton.Name = "HalfMealUpButton"
        Me.HalfMealUpButton.Size = New System.Drawing.Size(40, 20)
        Me.HalfMealUpButton.TabIndex = 6
        Me.HalfMealUpButton.TabStop = False
        Me.HalfMealUpButton.Text = "▲"
        Me.HalfMealUpButton.UseVisualStyleBackColor = True
        '
        'FullMealTableLayoutPanel
        '
        Me.FullMealTableLayoutPanel.AutoSize = True
        Me.FullMealTableLayoutPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.FullMealTableLayoutPanel.ColumnCount = 1
        Me.FullMealTableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.FullMealTableLayoutPanel.Controls.Add(Me.FullMealComboBox, 0, 1)
        Me.FullMealTableLayoutPanel.Controls.Add(Me.FullMealUpButton, 0, 0)
        Me.FullMealTableLayoutPanel.Controls.Add(Me.FullMealDownButton, 0, 2)
        Me.FullMealTableLayoutPanel.Location = New System.Drawing.Point(112, 0)
        Me.FullMealTableLayoutPanel.Margin = New System.Windows.Forms.Padding(0)
        Me.FullMealTableLayoutPanel.Name = "FullMealTableLayoutPanel"
        Me.FullMealTableLayoutPanel.RowCount = 3
        Me.FullMealTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.FullMealTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.FullMealTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.FullMealTableLayoutPanel.Size = New System.Drawing.Size(46, 73)
        Me.FullMealTableLayoutPanel.TabIndex = 4
        '
        'FullMealComboBox
        '
        Me.FullMealComboBox.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.FullMealComboBox.FormattingEnabled = True
        Me.FullMealComboBox.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.FullMealComboBox.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10"})
        Me.FullMealComboBox.Location = New System.Drawing.Point(3, 26)
        Me.FullMealComboBox.Margin = New System.Windows.Forms.Padding(3, 0, 3, 0)
        Me.FullMealComboBox.MaxDropDownItems = 11
        Me.FullMealComboBox.Name = "FullMealComboBox"
        Me.FullMealComboBox.Size = New System.Drawing.Size(40, 21)
        Me.FullMealComboBox.TabIndex = 2
        Me.FullMealComboBox.Text = "0"
        '
        'FullMealUpButton
        '
        Me.FullMealUpButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FullMealUpButton.Location = New System.Drawing.Point(3, 3)
        Me.FullMealUpButton.Name = "FullMealUpButton"
        Me.FullMealUpButton.Size = New System.Drawing.Size(40, 20)
        Me.FullMealUpButton.TabIndex = 3
        Me.FullMealUpButton.TabStop = False
        Me.FullMealUpButton.Text = "▲"
        Me.FullMealUpButton.UseVisualStyleBackColor = True
        '
        'FullMealDownButton
        '
        Me.FullMealDownButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FullMealDownButton.Location = New System.Drawing.Point(3, 50)
        Me.FullMealDownButton.Name = "FullMealDownButton"
        Me.FullMealDownButton.Size = New System.Drawing.Size(40, 20)
        Me.FullMealDownButton.TabIndex = 4
        Me.FullMealDownButton.TabStop = False
        Me.FullMealDownButton.Text = "▼"
        Me.FullMealDownButton.UseVisualStyleBackColor = True
        '
        'MealControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Controls.Add(Me.MainTableLayoutPanel)
        Me.Name = "MealControl"
        Me.Size = New System.Drawing.Size(250, 73)
        Me.MainTableLayoutPanel.ResumeLayout(False)
        Me.MainTableLayoutPanel.PerformLayout()
        Me.HalfMealTableLayoutPanel.ResumeLayout(False)
        Me.FullMealTableLayoutPanel.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MainTableLayoutPanel As TableLayoutPanel
    Friend WithEvents PriceTextBox As TextBox
    Friend WithEvents FullMealComboBox As ComboBox
    Friend WithEvents NameLabel As Label
    Friend WithEvents HalfMealComboBox As ComboBox
    Friend WithEvents FullMealTableLayoutPanel As TableLayoutPanel
    Friend WithEvents FullMealUpButton As Button
    Friend WithEvents FullMealDownButton As Button
    Friend WithEvents HalfMealTableLayoutPanel As TableLayoutPanel
    Friend WithEvents HalfMealDownButton As Button
    Friend WithEvents HalfMealUpButton As Button
End Class
