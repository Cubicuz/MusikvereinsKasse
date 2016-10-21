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
        Me.Euro5Button = New System.Windows.Forms.Button()
        Me.Euro10Button = New System.Windows.Forms.Button()
        Me.Euro20Button = New System.Windows.Forms.Button()
        Me.Euro50Button = New System.Windows.Forms.Button()
        Me.Euro100Button = New System.Windows.Forms.Button()
        Me.NumeralTableLayoutPanel = New System.Windows.Forms.TableLayoutPanel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.Button11 = New System.Windows.Forms.Button()
        Me.Button12 = New System.Windows.Forms.Button()
        Me.Button13 = New System.Windows.Forms.Button()
        Me.BillTableLayoutPanel = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.ReturnButton = New System.Windows.Forms.Button()
        Me.AcceptButton = New System.Windows.Forms.Button()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.FlowLayoutPanel2.SuspendLayout()
        Me.NumeralTableLayoutPanel.SuspendLayout()
        Me.BillTableLayoutPanel.SuspendLayout()
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
        'NumeralTableLayoutPanel
        '
        Me.NumeralTableLayoutPanel.ColumnCount = 3
        Me.NumeralTableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.NumeralTableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.NumeralTableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.NumeralTableLayoutPanel.Controls.Add(Me.Button1, 0, 0)
        Me.NumeralTableLayoutPanel.Controls.Add(Me.Button3, 0, 1)
        Me.NumeralTableLayoutPanel.Controls.Add(Me.Button4, 1, 1)
        Me.NumeralTableLayoutPanel.Controls.Add(Me.Button2, 0, 2)
        Me.NumeralTableLayoutPanel.Controls.Add(Me.Button5, 0, 3)
        Me.NumeralTableLayoutPanel.Controls.Add(Me.Button6, 1, 2)
        Me.NumeralTableLayoutPanel.Controls.Add(Me.Button7, 2, 1)
        Me.NumeralTableLayoutPanel.Controls.Add(Me.Button8, 2, 2)
        Me.NumeralTableLayoutPanel.Controls.Add(Me.Button9, 1, 3)
        Me.NumeralTableLayoutPanel.Controls.Add(Me.Button10, 2, 3)
        Me.NumeralTableLayoutPanel.Controls.Add(Me.Button11, 0, 4)
        Me.NumeralTableLayoutPanel.Controls.Add(Me.Button12, 2, 4)
        Me.NumeralTableLayoutPanel.Controls.Add(Me.Button13, 1, 0)
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
        'Button1
        '
        Me.Button1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Button1.Location = New System.Drawing.Point(3, 3)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(66, 50)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Button3.Location = New System.Drawing.Point(3, 59)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(66, 50)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "Button3"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Button4.Location = New System.Drawing.Point(75, 59)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(66, 50)
        Me.Button4.TabIndex = 3
        Me.Button4.Text = "Button4"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Button2.Location = New System.Drawing.Point(3, 115)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(66, 50)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "Button2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Button5.Location = New System.Drawing.Point(3, 171)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(66, 50)
        Me.Button5.TabIndex = 5
        Me.Button5.Text = "Button5"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Button6.Location = New System.Drawing.Point(75, 115)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(66, 50)
        Me.Button6.TabIndex = 6
        Me.Button6.Text = "Button6"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Button7.Location = New System.Drawing.Point(147, 59)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(67, 50)
        Me.Button7.TabIndex = 7
        Me.Button7.Text = "Button7"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Button8.Location = New System.Drawing.Point(147, 115)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(67, 50)
        Me.Button8.TabIndex = 8
        Me.Button8.Text = "Button8"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Button9
        '
        Me.Button9.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Button9.Location = New System.Drawing.Point(75, 171)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(66, 50)
        Me.Button9.TabIndex = 9
        Me.Button9.Text = "Button9"
        Me.Button9.UseVisualStyleBackColor = True
        '
        'Button10
        '
        Me.Button10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Button10.Location = New System.Drawing.Point(147, 171)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(67, 50)
        Me.Button10.TabIndex = 10
        Me.Button10.Text = "Button10"
        Me.Button10.UseVisualStyleBackColor = True
        '
        'Button11
        '
        Me.NumeralTableLayoutPanel.SetColumnSpan(Me.Button11, 2)
        Me.Button11.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Button11.Location = New System.Drawing.Point(3, 227)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(138, 50)
        Me.Button11.TabIndex = 11
        Me.Button11.Text = "Button11"
        Me.Button11.UseVisualStyleBackColor = True
        '
        'Button12
        '
        Me.Button12.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Button12.Location = New System.Drawing.Point(147, 227)
        Me.Button12.Name = "Button12"
        Me.Button12.Size = New System.Drawing.Size(67, 50)
        Me.Button12.TabIndex = 12
        Me.Button12.Text = "Button12"
        Me.Button12.UseVisualStyleBackColor = True
        '
        'Button13
        '
        Me.NumeralTableLayoutPanel.SetColumnSpan(Me.Button13, 2)
        Me.Button13.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Button13.Location = New System.Drawing.Point(75, 3)
        Me.Button13.Name = "Button13"
        Me.Button13.Size = New System.Drawing.Size(139, 50)
        Me.Button13.TabIndex = 13
        Me.Button13.Text = "Button13"
        Me.Button13.UseVisualStyleBackColor = True
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
        Me.NumeralTableLayoutPanel.ResumeLayout(False)
        Me.BillTableLayoutPanel.ResumeLayout(False)
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
    Friend WithEvents Button1 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents Button9 As Button
    Friend WithEvents Button10 As Button
    Friend WithEvents Button11 As Button
    Friend WithEvents Button12 As Button
    Friend WithEvents Button13 As Button
    Friend WithEvents BillTableLayoutPanel As TableLayoutPanel
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents ReturnButton As Button
    Friend WithEvents AcceptButton As Button
End Class
