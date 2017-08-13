<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CashRegisterPanel
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
        Me.MoneyInTextBox = New System.Windows.Forms.TextBox()
        Me.MoneyOutTextBox = New System.Windows.Forms.TextBox()
        Me.BillTableLayoutPanel = New System.Windows.Forms.TableLayoutPanel()
        Me.Euro100Button = New System.Windows.Forms.Button()
        Me.Euro50Button = New System.Windows.Forms.Button()
        Me.Euro20Button = New System.Windows.Forms.Button()
        Me.Euro10Button = New System.Windows.Forms.Button()
        Me.Euro5Button = New System.Windows.Forms.Button()
        Me.NumeralTableLayoutPanel = New System.Windows.Forms.TableLayoutPanel()
        Me.NumDelButton = New System.Windows.Forms.Button()
        Me.Num7Button = New System.Windows.Forms.Button()
        Me.Num8Button = New System.Windows.Forms.Button()
        Me.Num4Button = New System.Windows.Forms.Button()
        Me.Num1Button = New System.Windows.Forms.Button()
        Me.Num5Button = New System.Windows.Forms.Button()
        Me.Num9Button = New System.Windows.Forms.Button()
        Me.Num6Button = New System.Windows.Forms.Button()
        Me.Num2Button = New System.Windows.Forms.Button()
        Me.Num3Button = New System.Windows.Forms.Button()
        Me.Num0Button = New System.Windows.Forms.Button()
        Me.NumDotButton = New System.Windows.Forms.Button()
        Me.NumClearButton = New System.Windows.Forms.Button()
        Me.AcceptReturnTableLayoutPanel = New System.Windows.Forms.TableLayoutPanel()
        Me.ReturnButton = New System.Windows.Forms.Button()
        Me.AcceptButton = New System.Windows.Forms.Button()
        Me.MainTableLayoutPanel = New System.Windows.Forms.TableLayoutPanel()
        Me.TextBoxTableLayoutPanel = New System.Windows.Forms.TableLayoutPanel()
        Me.LabelGegeben = New System.Windows.Forms.Label()
        Me.LabelRueck = New System.Windows.Forms.Label()
        Me.LabelPreis = New System.Windows.Forms.Label()
        Me.PriceTextBox = New System.Windows.Forms.TextBox()
        Me.BillTableLayoutPanel.SuspendLayout()
        Me.NumeralTableLayoutPanel.SuspendLayout()
        Me.AcceptReturnTableLayoutPanel.SuspendLayout()
        Me.MainTableLayoutPanel.SuspendLayout()
        Me.TextBoxTableLayoutPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'MoneyInTextBox
        '
        Me.MoneyInTextBox.Location = New System.Drawing.Point(3, 36)
        Me.MoneyInTextBox.Name = "MoneyInTextBox"
        Me.MoneyInTextBox.Size = New System.Drawing.Size(100, 20)
        Me.MoneyInTextBox.TabIndex = 0
        Me.MoneyInTextBox.Text = "0"
        Me.MoneyInTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'MoneyOutTextBox
        '
        Me.MoneyOutTextBox.Location = New System.Drawing.Point(3, 168)
        Me.MoneyOutTextBox.Name = "MoneyOutTextBox"
        Me.MoneyOutTextBox.ReadOnly = True
        Me.MoneyOutTextBox.Size = New System.Drawing.Size(100, 20)
        Me.MoneyOutTextBox.TabIndex = 1
        Me.MoneyOutTextBox.Text = "0"
        Me.MoneyOutTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'BillTableLayoutPanel
        '
        Me.BillTableLayoutPanel.ColumnCount = 1
        Me.BillTableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.BillTableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.BillTableLayoutPanel.Controls.Add(Me.Euro100Button, 0, 4)
        Me.BillTableLayoutPanel.Controls.Add(Me.Euro50Button, 0, 3)
        Me.BillTableLayoutPanel.Controls.Add(Me.Euro20Button, 0, 2)
        Me.BillTableLayoutPanel.Controls.Add(Me.Euro10Button, 0, 1)
        Me.BillTableLayoutPanel.Controls.Add(Me.Euro5Button, 0, 0)
        Me.BillTableLayoutPanel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BillTableLayoutPanel.Location = New System.Drawing.Point(115, 3)
        Me.BillTableLayoutPanel.Name = "BillTableLayoutPanel"
        Me.BillTableLayoutPanel.RowCount = 5
        Me.BillTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.BillTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.BillTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.BillTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.BillTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.BillTableLayoutPanel.Size = New System.Drawing.Size(122, 200)
        Me.BillTableLayoutPanel.TabIndex = 3
        '
        'Euro100Button
        '
        Me.Euro100Button.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Euro100Button.Location = New System.Drawing.Point(3, 163)
        Me.Euro100Button.Name = "Euro100Button"
        Me.Euro100Button.Size = New System.Drawing.Size(116, 34)
        Me.Euro100Button.TabIndex = 4
        Me.Euro100Button.Text = "100 €"
        Me.Euro100Button.UseVisualStyleBackColor = True
        '
        'Euro50Button
        '
        Me.Euro50Button.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Euro50Button.Location = New System.Drawing.Point(3, 123)
        Me.Euro50Button.Name = "Euro50Button"
        Me.Euro50Button.Size = New System.Drawing.Size(116, 34)
        Me.Euro50Button.TabIndex = 3
        Me.Euro50Button.Text = "50 €"
        Me.Euro50Button.UseVisualStyleBackColor = True
        '
        'Euro20Button
        '
        Me.Euro20Button.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Euro20Button.Location = New System.Drawing.Point(3, 83)
        Me.Euro20Button.Name = "Euro20Button"
        Me.Euro20Button.Size = New System.Drawing.Size(116, 34)
        Me.Euro20Button.TabIndex = 2
        Me.Euro20Button.Text = "20 €"
        Me.Euro20Button.UseVisualStyleBackColor = True
        '
        'Euro10Button
        '
        Me.Euro10Button.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Euro10Button.Location = New System.Drawing.Point(3, 43)
        Me.Euro10Button.Name = "Euro10Button"
        Me.Euro10Button.Size = New System.Drawing.Size(116, 34)
        Me.Euro10Button.TabIndex = 1
        Me.Euro10Button.Text = "10 €"
        Me.Euro10Button.UseVisualStyleBackColor = True
        '
        'Euro5Button
        '
        Me.Euro5Button.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Euro5Button.Location = New System.Drawing.Point(3, 3)
        Me.Euro5Button.Name = "Euro5Button"
        Me.Euro5Button.Size = New System.Drawing.Size(116, 34)
        Me.Euro5Button.TabIndex = 0
        Me.Euro5Button.Text = "5 €"
        Me.Euro5Button.UseVisualStyleBackColor = True
        '
        'NumeralTableLayoutPanel
        '
        Me.NumeralTableLayoutPanel.ColumnCount = 3
        Me.NumeralTableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.NumeralTableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.NumeralTableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.NumeralTableLayoutPanel.Controls.Add(Me.NumDelButton, 0, 0)
        Me.NumeralTableLayoutPanel.Controls.Add(Me.Num7Button, 0, 1)
        Me.NumeralTableLayoutPanel.Controls.Add(Me.Num8Button, 1, 1)
        Me.NumeralTableLayoutPanel.Controls.Add(Me.Num4Button, 0, 2)
        Me.NumeralTableLayoutPanel.Controls.Add(Me.Num1Button, 0, 3)
        Me.NumeralTableLayoutPanel.Controls.Add(Me.Num5Button, 1, 2)
        Me.NumeralTableLayoutPanel.Controls.Add(Me.Num9Button, 2, 1)
        Me.NumeralTableLayoutPanel.Controls.Add(Me.Num6Button, 2, 2)
        Me.NumeralTableLayoutPanel.Controls.Add(Me.Num2Button, 1, 3)
        Me.NumeralTableLayoutPanel.Controls.Add(Me.Num3Button, 2, 3)
        Me.NumeralTableLayoutPanel.Controls.Add(Me.Num0Button, 0, 4)
        Me.NumeralTableLayoutPanel.Controls.Add(Me.NumDotButton, 2, 4)
        Me.NumeralTableLayoutPanel.Controls.Add(Me.NumClearButton, 1, 0)
        Me.NumeralTableLayoutPanel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumeralTableLayoutPanel.Location = New System.Drawing.Point(243, 3)
        Me.NumeralTableLayoutPanel.Name = "NumeralTableLayoutPanel"
        Me.NumeralTableLayoutPanel.RowCount = 5
        Me.NumeralTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.NumeralTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.NumeralTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.NumeralTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.NumeralTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.NumeralTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.NumeralTableLayoutPanel.Size = New System.Drawing.Size(217, 200)
        Me.NumeralTableLayoutPanel.TabIndex = 2
        '
        'NumDelButton
        '
        Me.NumDelButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.NumDelButton.Location = New System.Drawing.Point(3, 3)
        Me.NumDelButton.Name = "NumDelButton"
        Me.NumDelButton.Size = New System.Drawing.Size(66, 34)
        Me.NumDelButton.TabIndex = 0
        Me.NumDelButton.Text = "entf"
        Me.NumDelButton.UseVisualStyleBackColor = True
        '
        'Num7Button
        '
        Me.Num7Button.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Num7Button.Location = New System.Drawing.Point(3, 43)
        Me.Num7Button.Name = "Num7Button"
        Me.Num7Button.Size = New System.Drawing.Size(66, 34)
        Me.Num7Button.TabIndex = 2
        Me.Num7Button.Text = "7"
        Me.Num7Button.UseVisualStyleBackColor = True
        '
        'Num8Button
        '
        Me.Num8Button.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Num8Button.Location = New System.Drawing.Point(75, 43)
        Me.Num8Button.Name = "Num8Button"
        Me.Num8Button.Size = New System.Drawing.Size(66, 34)
        Me.Num8Button.TabIndex = 3
        Me.Num8Button.Text = "8"
        Me.Num8Button.UseVisualStyleBackColor = True
        '
        'Num4Button
        '
        Me.Num4Button.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Num4Button.Location = New System.Drawing.Point(3, 83)
        Me.Num4Button.Name = "Num4Button"
        Me.Num4Button.Size = New System.Drawing.Size(66, 34)
        Me.Num4Button.TabIndex = 4
        Me.Num4Button.Text = "4"
        Me.Num4Button.UseVisualStyleBackColor = True
        '
        'Num1Button
        '
        Me.Num1Button.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Num1Button.Location = New System.Drawing.Point(3, 123)
        Me.Num1Button.Name = "Num1Button"
        Me.Num1Button.Size = New System.Drawing.Size(66, 34)
        Me.Num1Button.TabIndex = 5
        Me.Num1Button.Text = "1"
        Me.Num1Button.UseVisualStyleBackColor = True
        '
        'Num5Button
        '
        Me.Num5Button.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Num5Button.Location = New System.Drawing.Point(75, 83)
        Me.Num5Button.Name = "Num5Button"
        Me.Num5Button.Size = New System.Drawing.Size(66, 34)
        Me.Num5Button.TabIndex = 6
        Me.Num5Button.Text = "5"
        Me.Num5Button.UseVisualStyleBackColor = True
        '
        'Num9Button
        '
        Me.Num9Button.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Num9Button.Location = New System.Drawing.Point(147, 43)
        Me.Num9Button.Name = "Num9Button"
        Me.Num9Button.Size = New System.Drawing.Size(67, 34)
        Me.Num9Button.TabIndex = 7
        Me.Num9Button.Text = "9"
        Me.Num9Button.UseVisualStyleBackColor = True
        '
        'Num6Button
        '
        Me.Num6Button.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Num6Button.Location = New System.Drawing.Point(147, 83)
        Me.Num6Button.Name = "Num6Button"
        Me.Num6Button.Size = New System.Drawing.Size(67, 34)
        Me.Num6Button.TabIndex = 8
        Me.Num6Button.Text = "6"
        Me.Num6Button.UseVisualStyleBackColor = True
        '
        'Num2Button
        '
        Me.Num2Button.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Num2Button.Location = New System.Drawing.Point(75, 123)
        Me.Num2Button.Name = "Num2Button"
        Me.Num2Button.Size = New System.Drawing.Size(66, 34)
        Me.Num2Button.TabIndex = 9
        Me.Num2Button.Text = "2"
        Me.Num2Button.UseVisualStyleBackColor = True
        '
        'Num3Button
        '
        Me.Num3Button.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Num3Button.Location = New System.Drawing.Point(147, 123)
        Me.Num3Button.Name = "Num3Button"
        Me.Num3Button.Size = New System.Drawing.Size(67, 34)
        Me.Num3Button.TabIndex = 10
        Me.Num3Button.Text = "3"
        Me.Num3Button.UseVisualStyleBackColor = True
        '
        'Num0Button
        '
        Me.NumeralTableLayoutPanel.SetColumnSpan(Me.Num0Button, 2)
        Me.Num0Button.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Num0Button.Location = New System.Drawing.Point(3, 163)
        Me.Num0Button.Name = "Num0Button"
        Me.Num0Button.Size = New System.Drawing.Size(138, 34)
        Me.Num0Button.TabIndex = 11
        Me.Num0Button.Text = "0"
        Me.Num0Button.UseVisualStyleBackColor = True
        '
        'NumDotButton
        '
        Me.NumDotButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.NumDotButton.Location = New System.Drawing.Point(147, 163)
        Me.NumDotButton.Name = "NumDotButton"
        Me.NumDotButton.Size = New System.Drawing.Size(67, 34)
        Me.NumDotButton.TabIndex = 12
        Me.NumDotButton.Text = ","
        Me.NumDotButton.UseVisualStyleBackColor = True
        '
        'NumClearButton
        '
        Me.NumeralTableLayoutPanel.SetColumnSpan(Me.NumClearButton, 2)
        Me.NumClearButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.NumClearButton.Location = New System.Drawing.Point(75, 3)
        Me.NumClearButton.Name = "NumClearButton"
        Me.NumClearButton.Size = New System.Drawing.Size(139, 34)
        Me.NumClearButton.TabIndex = 13
        Me.NumClearButton.Text = "clear"
        Me.NumClearButton.UseVisualStyleBackColor = True
        '
        'AcceptReturnTableLayoutPanel
        '
        Me.AcceptReturnTableLayoutPanel.ColumnCount = 1
        Me.AcceptReturnTableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.AcceptReturnTableLayoutPanel.Controls.Add(Me.ReturnButton, 0, 0)
        Me.AcceptReturnTableLayoutPanel.Controls.Add(Me.AcceptButton, 0, 1)
        Me.AcceptReturnTableLayoutPanel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AcceptReturnTableLayoutPanel.Location = New System.Drawing.Point(476, 3)
        Me.AcceptReturnTableLayoutPanel.Name = "AcceptReturnTableLayoutPanel"
        Me.AcceptReturnTableLayoutPanel.RowCount = 2
        Me.AcceptReturnTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.AcceptReturnTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75.0!))
        Me.AcceptReturnTableLayoutPanel.Size = New System.Drawing.Size(200, 200)
        Me.AcceptReturnTableLayoutPanel.TabIndex = 4
        '
        'ReturnButton
        '
        Me.ReturnButton.BackColor = System.Drawing.Color.Red
        Me.ReturnButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ReturnButton.Location = New System.Drawing.Point(3, 3)
        Me.ReturnButton.Name = "ReturnButton"
        Me.ReturnButton.Size = New System.Drawing.Size(194, 44)
        Me.ReturnButton.TabIndex = 0
        Me.ReturnButton.Text = "löschen"
        Me.ReturnButton.UseVisualStyleBackColor = False
        '
        'AcceptButton
        '
        Me.AcceptButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.AcceptButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AcceptButton.Location = New System.Drawing.Point(3, 53)
        Me.AcceptButton.Name = "AcceptButton"
        Me.AcceptButton.Size = New System.Drawing.Size(194, 144)
        Me.AcceptButton.TabIndex = 1
        Me.AcceptButton.Text = "bezahlen"
        Me.AcceptButton.UseVisualStyleBackColor = False
        '
        'MainTableLayoutPanel
        '
        Me.MainTableLayoutPanel.AutoSize = True
        Me.MainTableLayoutPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.MainTableLayoutPanel.ColumnCount = 5
        Me.MainTableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.MainTableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.MainTableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.MainTableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10.0!))
        Me.MainTableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.MainTableLayoutPanel.Controls.Add(Me.TextBoxTableLayoutPanel, 0, 0)
        Me.MainTableLayoutPanel.Controls.Add(Me.AcceptReturnTableLayoutPanel, 4, 0)
        Me.MainTableLayoutPanel.Controls.Add(Me.NumeralTableLayoutPanel, 2, 0)
        Me.MainTableLayoutPanel.Controls.Add(Me.BillTableLayoutPanel, 1, 0)
        Me.MainTableLayoutPanel.Location = New System.Drawing.Point(3, 3)
        Me.MainTableLayoutPanel.Name = "MainTableLayoutPanel"
        Me.MainTableLayoutPanel.RowCount = 1
        Me.MainTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.MainTableLayoutPanel.Size = New System.Drawing.Size(679, 206)
        Me.MainTableLayoutPanel.TabIndex = 1
        '
        'TextBoxTableLayoutPanel
        '
        Me.TextBoxTableLayoutPanel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.TextBoxTableLayoutPanel.AutoScroll = True
        Me.TextBoxTableLayoutPanel.AutoSize = True
        Me.TextBoxTableLayoutPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.TextBoxTableLayoutPanel.ColumnCount = 1
        Me.TextBoxTableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TextBoxTableLayoutPanel.Controls.Add(Me.LabelGegeben, 0, 0)
        Me.TextBoxTableLayoutPanel.Controls.Add(Me.MoneyOutTextBox, 0, 5)
        Me.TextBoxTableLayoutPanel.Controls.Add(Me.LabelRueck, 0, 4)
        Me.TextBoxTableLayoutPanel.Controls.Add(Me.MoneyInTextBox, 0, 1)
        Me.TextBoxTableLayoutPanel.Controls.Add(Me.LabelPreis, 0, 2)
        Me.TextBoxTableLayoutPanel.Controls.Add(Me.PriceTextBox, 0, 3)
        Me.TextBoxTableLayoutPanel.Location = New System.Drawing.Point(3, 3)
        Me.TextBoxTableLayoutPanel.Name = "TextBoxTableLayoutPanel"
        Me.TextBoxTableLayoutPanel.RowCount = 6
        Me.TextBoxTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TextBoxTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TextBoxTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TextBoxTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TextBoxTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TextBoxTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TextBoxTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TextBoxTableLayoutPanel.Size = New System.Drawing.Size(106, 200)
        Me.TextBoxTableLayoutPanel.TabIndex = 0
        '
        'LabelGegeben
        '
        Me.LabelGegeben.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.LabelGegeben.AutoSize = True
        Me.LabelGegeben.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelGegeben.Location = New System.Drawing.Point(5, 9)
        Me.LabelGegeben.Name = "LabelGegeben"
        Me.LabelGegeben.Size = New System.Drawing.Size(95, 24)
        Me.LabelGegeben.TabIndex = 3
        Me.LabelGegeben.Text = "Gegeben:"
        '
        'LabelRueck
        '
        Me.LabelRueck.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.LabelRueck.AutoSize = True
        Me.LabelRueck.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelRueck.Location = New System.Drawing.Point(5, 141)
        Me.LabelRueck.Name = "LabelRueck"
        Me.LabelRueck.Size = New System.Drawing.Size(95, 24)
        Me.LabelRueck.TabIndex = 2
        Me.LabelRueck.Text = "Rückgeld:"
        '
        'LabelPreis
        '
        Me.LabelPreis.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.LabelPreis.AutoSize = True
        Me.LabelPreis.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.LabelPreis.Location = New System.Drawing.Point(24, 75)
        Me.LabelPreis.Name = "LabelPreis"
        Me.LabelPreis.Size = New System.Drawing.Size(57, 24)
        Me.LabelPreis.TabIndex = 4
        Me.LabelPreis.Text = "Preis:"
        '
        'PriceTextBox
        '
        Me.PriceTextBox.Location = New System.Drawing.Point(3, 102)
        Me.PriceTextBox.Name = "PriceTextBox"
        Me.PriceTextBox.ReadOnly = True
        Me.PriceTextBox.Size = New System.Drawing.Size(100, 20)
        Me.PriceTextBox.TabIndex = 5
        Me.PriceTextBox.Text = "0"
        Me.PriceTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'CashRegisterPanel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Controls.Add(Me.MainTableLayoutPanel)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "CashRegisterPanel"
        Me.Size = New System.Drawing.Size(685, 212)
        Me.BillTableLayoutPanel.ResumeLayout(False)
        Me.NumeralTableLayoutPanel.ResumeLayout(False)
        Me.AcceptReturnTableLayoutPanel.ResumeLayout(False)
        Me.MainTableLayoutPanel.ResumeLayout(False)
        Me.MainTableLayoutPanel.PerformLayout()
        Me.TextBoxTableLayoutPanel.ResumeLayout(False)
        Me.TextBoxTableLayoutPanel.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MoneyInTextBox As TextBox
    Friend WithEvents MoneyOutTextBox As TextBox
    Friend WithEvents Euro5Button As Button
    Friend WithEvents Euro10Button As Button
    Friend WithEvents Euro20Button As Button
    Friend WithEvents Euro50Button As Button
    Friend WithEvents Euro100Button As Button
    Friend WithEvents NumeralTableLayoutPanel As TableLayoutPanel
    Friend WithEvents NumDelButton As Button
    Friend WithEvents Num7Button As Button
    Friend WithEvents Num8Button As Button
    Friend WithEvents Num4Button As Button
    Friend WithEvents Num1Button As Button
    Friend WithEvents Num5Button As Button
    Friend WithEvents Num9Button As Button
    Friend WithEvents Num6Button As Button
    Friend WithEvents Num2Button As Button
    Friend WithEvents Num3Button As Button
    Friend WithEvents Num0Button As Button
    Friend WithEvents NumDotButton As Button
    Friend WithEvents NumClearButton As Button
    Friend WithEvents BillTableLayoutPanel As TableLayoutPanel
    Friend WithEvents AcceptReturnTableLayoutPanel As TableLayoutPanel
    Friend WithEvents ReturnButton As Button
    Friend WithEvents AcceptButton As Button
    Friend WithEvents MainTableLayoutPanel As TableLayoutPanel
    Friend WithEvents TextBoxTableLayoutPanel As TableLayoutPanel
    Friend WithEvents LabelRueck As Label
    Friend WithEvents LabelGegeben As Label
    Friend WithEvents LabelPreis As Label
    Friend WithEvents PriceTextBox As TextBox
End Class
