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
        Me.PriceTextBox = New System.Windows.Forms.TextBox()
        Me.FullMealComboBox = New System.Windows.Forms.ComboBox()
        Me.NameLabel = New System.Windows.Forms.Label()
        Me.HalfMealComboBox = New System.Windows.Forms.ComboBox()
        Me.MainTableLayoutPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'MainTableLayoutPanel
        '
        Me.MainTableLayoutPanel.AutoSize = True
        Me.MainTableLayoutPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.MainTableLayoutPanel.ColumnCount = 4
        Me.MainTableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120.0!))
        Me.MainTableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.MainTableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.MainTableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.MainTableLayoutPanel.Controls.Add(Me.PriceTextBox, 3, 0)
        Me.MainTableLayoutPanel.Controls.Add(Me.FullMealComboBox, 1, 0)
        Me.MainTableLayoutPanel.Controls.Add(Me.NameLabel, 0, 0)
        Me.MainTableLayoutPanel.Controls.Add(Me.HalfMealComboBox, 2, 0)
        Me.MainTableLayoutPanel.Location = New System.Drawing.Point(3, 3)
        Me.MainTableLayoutPanel.Name = "MainTableLayoutPanel"
        Me.MainTableLayoutPanel.RowCount = 1
        Me.MainTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.MainTableLayoutPanel.Size = New System.Drawing.Size(240, 50)
        Me.MainTableLayoutPanel.TabIndex = 0
        '
        'PriceTextBox
        '
        Me.PriceTextBox.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PriceTextBox.Location = New System.Drawing.Point(203, 15)
        Me.PriceTextBox.Name = "PriceTextBox"
        Me.PriceTextBox.Size = New System.Drawing.Size(34, 20)
        Me.PriceTextBox.TabIndex = 1
        '
        'FullMealComboBox
        '
        Me.FullMealComboBox.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.FullMealComboBox.FormattingEnabled = True
        Me.FullMealComboBox.Location = New System.Drawing.Point(123, 14)
        Me.FullMealComboBox.Name = "FullMealComboBox"
        Me.FullMealComboBox.Size = New System.Drawing.Size(34, 21)
        Me.FullMealComboBox.TabIndex = 2
        '
        'NameLabel
        '
        Me.NameLabel.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.NameLabel.AutoSize = True
        Me.NameLabel.Location = New System.Drawing.Point(40, 18)
        Me.NameLabel.Name = "NameLabel"
        Me.NameLabel.Size = New System.Drawing.Size(39, 13)
        Me.NameLabel.TabIndex = 3
        Me.NameLabel.Text = "Label1"
        '
        'HalfMealComboBox
        '
        Me.HalfMealComboBox.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.HalfMealComboBox.FormattingEnabled = True
        Me.HalfMealComboBox.Location = New System.Drawing.Point(163, 14)
        Me.HalfMealComboBox.Name = "HalfMealComboBox"
        Me.HalfMealComboBox.Size = New System.Drawing.Size(34, 21)
        Me.HalfMealComboBox.TabIndex = 4
        '
        'MealControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Controls.Add(Me.MainTableLayoutPanel)
        Me.Name = "MealControl"
        Me.Size = New System.Drawing.Size(246, 56)
        Me.MainTableLayoutPanel.ResumeLayout(False)
        Me.MainTableLayoutPanel.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MainTableLayoutPanel As TableLayoutPanel
    Friend WithEvents PriceTextBox As TextBox
    Friend WithEvents FullMealComboBox As ComboBox
    Friend WithEvents NameLabel As Label
    Friend WithEvents HalfMealComboBox As ComboBox
End Class
