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
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.FlowLayoutPanel2 = New System.Windows.Forms.FlowLayoutPanel()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.ReturnButton = New System.Windows.Forms.Button()
        Me.AcceptButton = New System.Windows.Forms.Button()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.FlowLayoutPanel2.SuspendLayout()
        Me.BillTableLayoutPanel.SuspendLayout()
        Me.NumeralTableLayoutPanel.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Controls.Add(Me.FlowLayoutPanel2)
        Me.FlowLayoutPanel1.Controls.Add(Me.BillTableLayoutPanel)
        Me.FlowLayoutPanel1.Controls.Add(Me.NumeralTableLayoutPanel)
        Me.FlowLayoutPanel1.Controls.Add(Me.TableLayoutPanel1)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(835, 333)
        Me.FlowLayoutPanel1.TabIndex = 0
        '
        'FlowLayoutPanel2
        '
        Me.FlowLayoutPanel2.Controls.Add(Me.TextBox1)
        Me.FlowLayoutPanel2.Controls.Add(Me.TextBox2)
        Me.FlowLayoutPanel2.Location = New System.Drawing.Point(3, 3)
        Me.FlowLayoutPanel2.Name = "FlowLayoutPanel2"
        Me.FlowLayoutPanel2.Size = New System.Drawing.Size(200, 274)
        Me.FlowLayoutPanel2.TabIndex = 0
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(3, 3)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 0
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(3, 29)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 20)
        Me.TextBox2.TabIndex = 1
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
        Me.BillTableLayoutPanel.Location = New System.Drawing.Point(209, 3)
        Me.BillTableLayoutPanel.Name = "BillTableLayoutPanel"
        Me.BillTableLayoutPanel.RowCount = 5
        Me.BillTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.BillTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.BillTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.BillTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.BillTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.BillTableLayoutPanel.Size = New System.Drawing.Size(122, 280)
        Me.BillTableLayoutPanel.TabIndex = 3
        '
        'Euro100Button
        '
        Me.Euro100Button.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Euro100Button.Location = New System.Drawing.Point(3, 227)
        Me.Euro100Button.Name = "Euro100Button"
        Me.Euro100Button.Size = New System.Drawing.Size(116, 50)
        Me.Euro100Button.TabIndex = 4
        Me.Euro100Button.Text = "100 €"
        Me.Euro100Button.UseVisualStyleBackColor = True
        '
        'Euro50Button
        '
        Me.Euro50Button.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Euro50Button.Location = New System.Drawing.Point(3, 171)
        Me.Euro50Button.Name = "Euro50Button"
        Me.Euro50Button.Size = New System.Drawing.Size(116, 50)
        Me.Euro50Button.TabIndex = 3
        Me.Euro50Button.Text = "50 €"
        Me.Euro50Button.UseVisualStyleBackColor = True
        '
        'Euro20Button
        '
        Me.Euro20Button.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Euro20Button.Location = New System.Drawing.Point(3, 115)
        Me.Euro20Button.Name = "Euro20Button"
        Me.Euro20Button.Size = New System.Drawing.Size(116, 50)
        Me.Euro20Button.TabIndex = 2
        Me.Euro20Button.Text = "20 €"
        Me.Euro20Button.UseVisualStyleBackColor = True
        '
        'Euro10Button
        '
        Me.Euro10Button.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Euro10Button.Location = New System.Drawing.Point(3, 59)
        Me.Euro10Button.Name = "Euro10Button"
        Me.Euro10Button.Size = New System.Drawing.Size(116, 50)
        Me.Euro10Button.TabIndex = 1
        Me.Euro10Button.Text = "10 €"
        Me.Euro10Button.UseVisualStyleBackColor = True
        '
        'Euro5Button
        '
        Me.Euro5Button.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Euro5Button.Location = New System.Drawing.Point(3, 3)
        Me.Euro5Button.Name = "Euro5Button"
        Me.Euro5Button.Size = New System.Drawing.Size(116, 50)
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
        Me.NumeralTableLayoutPanel.Location = New System.Drawing.Point(337, 3)
        Me.NumeralTableLayoutPanel.Name = "NumeralTableLayoutPanel"
        Me.NumeralTableLayoutPanel.RowCount = 5
        Me.NumeralTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.NumeralTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.NumeralTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.NumeralTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.NumeralTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.NumeralTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.NumeralTableLayoutPanel.Size = New System.Drawing.Size(217, 280)
        Me.NumeralTableLayoutPanel.TabIndex = 2
        '
        'NumDelButton
        '
        Me.NumDelButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.NumDelButton.Location = New System.Drawing.Point(3, 3)
        Me.NumDelButton.Name = "NumDelButton"
        Me.NumDelButton.Size = New System.Drawing.Size(66, 50)
        Me.NumDelButton.TabIndex = 0
        Me.NumDelButton.Text = "entf"
        Me.NumDelButton.UseVisualStyleBackColor = True
        '
        'Num7Button
        '
        Me.Num7Button.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Num7Button.Location = New System.Drawing.Point(3, 59)
        Me.Num7Button.Name = "Num7Button"
        Me.Num7Button.Size = New System.Drawing.Size(66, 50)
        Me.Num7Button.TabIndex = 2
        Me.Num7Button.Text = "7"
        Me.Num7Button.UseVisualStyleBackColor = True
        '
        'Num8Button
        '
        Me.Num8Button.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Num8Button.Location = New System.Drawing.Point(75, 59)
        Me.Num8Button.Name = "Num8Button"
        Me.Num8Button.Size = New System.Drawing.Size(66, 50)
        Me.Num8Button.TabIndex = 3
        Me.Num8Button.Text = "8"
        Me.Num8Button.UseVisualStyleBackColor = True
        '
        'Num4Button
        '
        Me.Num4Button.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Num4Button.Location = New System.Drawing.Point(3, 115)
        Me.Num4Button.Name = "Num4Button"
        Me.Num4Button.Size = New System.Drawing.Size(66, 50)
        Me.Num4Button.TabIndex = 4
        Me.Num4Button.Text = "4"
        Me.Num4Button.UseVisualStyleBackColor = True
        '
        'Num1Button
        '
        Me.Num1Button.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Num1Button.Location = New System.Drawing.Point(3, 171)
        Me.Num1Button.Name = "Num1Button"
        Me.Num1Button.Size = New System.Drawing.Size(66, 50)
        Me.Num1Button.TabIndex = 5
        Me.Num1Button.Text = "1"
        Me.Num1Button.UseVisualStyleBackColor = True
        '
        'Num5Button
        '
        Me.Num5Button.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Num5Button.Location = New System.Drawing.Point(75, 115)
        Me.Num5Button.Name = "Num5Button"
        Me.Num5Button.Size = New System.Drawing.Size(66, 50)
        Me.Num5Button.TabIndex = 6
        Me.Num5Button.Text = "5"
        Me.Num5Button.UseVisualStyleBackColor = True
        '
        'Num9Button
        '
        Me.Num9Button.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Num9Button.Location = New System.Drawing.Point(147, 59)
        Me.Num9Button.Name = "Num9Button"
        Me.Num9Button.Size = New System.Drawing.Size(67, 50)
        Me.Num9Button.TabIndex = 7
        Me.Num9Button.Text = "9"
        Me.Num9Button.UseVisualStyleBackColor = True
        '
        'Num6Button
        '
        Me.Num6Button.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Num6Button.Location = New System.Drawing.Point(147, 115)
        Me.Num6Button.Name = "Num6Button"
        Me.Num6Button.Size = New System.Drawing.Size(67, 50)
        Me.Num6Button.TabIndex = 8
        Me.Num6Button.Text = "6"
        Me.Num6Button.UseVisualStyleBackColor = True
        '
        'Num2Button
        '
        Me.Num2Button.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Num2Button.Location = New System.Drawing.Point(75, 171)
        Me.Num2Button.Name = "Num2Button"
        Me.Num2Button.Size = New System.Drawing.Size(66, 50)
        Me.Num2Button.TabIndex = 9
        Me.Num2Button.Text = "2"
        Me.Num2Button.UseVisualStyleBackColor = True
        '
        'Num3Button
        '
        Me.Num3Button.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Num3Button.Location = New System.Drawing.Point(147, 171)
        Me.Num3Button.Name = "Num3Button"
        Me.Num3Button.Size = New System.Drawing.Size(67, 50)
        Me.Num3Button.TabIndex = 10
        Me.Num3Button.Text = "3"
        Me.Num3Button.UseVisualStyleBackColor = True
        '
        'Num0Button
        '
        Me.NumeralTableLayoutPanel.SetColumnSpan(Me.Num0Button, 2)
        Me.Num0Button.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Num0Button.Location = New System.Drawing.Point(3, 227)
        Me.Num0Button.Name = "Num0Button"
        Me.Num0Button.Size = New System.Drawing.Size(138, 50)
        Me.Num0Button.TabIndex = 11
        Me.Num0Button.Text = "0"
        Me.Num0Button.UseVisualStyleBackColor = True
        '
        'NumDotButton
        '
        Me.NumDotButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.NumDotButton.Location = New System.Drawing.Point(147, 227)
        Me.NumDotButton.Name = "NumDotButton"
        Me.NumDotButton.Size = New System.Drawing.Size(67, 50)
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
        Me.NumClearButton.Size = New System.Drawing.Size(139, 50)
        Me.NumClearButton.TabIndex = 13
        Me.NumClearButton.Text = "clear"
        Me.NumClearButton.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.ReturnButton, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.AcceptButton, 0, 1)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(560, 3)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(200, 280)
        Me.TableLayoutPanel1.TabIndex = 4
        '
        'ReturnButton
        '
        Me.ReturnButton.BackColor = System.Drawing.Color.Red
        Me.ReturnButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ReturnButton.Location = New System.Drawing.Point(3, 3)
        Me.ReturnButton.Name = "ReturnButton"
        Me.ReturnButton.Size = New System.Drawing.Size(194, 64)
        Me.ReturnButton.TabIndex = 0
        Me.ReturnButton.Text = "Button14"
        Me.ReturnButton.UseVisualStyleBackColor = False
        '
        'AcceptButton
        '
        Me.AcceptButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AcceptButton.Location = New System.Drawing.Point(3, 73)
        Me.AcceptButton.Name = "AcceptButton"
        Me.AcceptButton.Size = New System.Drawing.Size(194, 204)
        Me.AcceptButton.TabIndex = 1
        Me.AcceptButton.Text = "Button15"
        Me.AcceptButton.UseVisualStyleBackColor = True
        '
        'CashRegisterPanel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Name = "CashRegisterPanel"
        Me.Size = New System.Drawing.Size(835, 333)
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.FlowLayoutPanel2.ResumeLayout(False)
        Me.FlowLayoutPanel2.PerformLayout()
        Me.BillTableLayoutPanel.ResumeLayout(False)
        Me.NumeralTableLayoutPanel.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents FlowLayoutPanel2 As FlowLayoutPanel
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
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
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents ReturnButton As Button
    Friend WithEvents AcceptButton As Button
End Class
