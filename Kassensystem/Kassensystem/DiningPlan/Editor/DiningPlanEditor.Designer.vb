<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DiningPlanEditor
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
        Me.MealDataGridView = New System.Windows.Forms.DataGridView()
        Me.MealName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MealPrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BelongsToMealGroup = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.MealGroupDataGridView = New System.Windows.Forms.DataGridView()
        Me.MealGroupName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MealGroupColor = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.MealGroupTab = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.TabDataGridView = New System.Windows.Forms.DataGridView()
        Me.AvailableTabs = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MainFlowLayoutPanel = New System.Windows.Forms.FlowLayoutPanel()
        Me.TabFlowLayoutPanel = New System.Windows.Forms.FlowLayoutPanel()
        Me.MealFlowLayoutPanel = New System.Windows.Forms.FlowLayoutPanel()
        Me.MealGroupFlowLayoutPanel = New System.Windows.Forms.FlowLayoutPanel()
        Me.MealLabel = New System.Windows.Forms.Label()
        Me.MealGroupLabel = New System.Windows.Forms.Label()
        Me.TabLabel = New System.Windows.Forms.Label()
        CType(Me.MealDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MealGroupDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TabDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MainFlowLayoutPanel.SuspendLayout()
        Me.TabFlowLayoutPanel.SuspendLayout()
        Me.MealFlowLayoutPanel.SuspendLayout()
        Me.MealGroupFlowLayoutPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'MealDataGridView
        '
        Me.MealDataGridView.AllowUserToOrderColumns = True
        Me.MealDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.MealDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.MealDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.MealDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.MealName, Me.MealPrice, Me.BelongsToMealGroup})
        Me.MealDataGridView.Location = New System.Drawing.Point(3, 23)
        Me.MealDataGridView.Name = "MealDataGridView"
        Me.MealDataGridView.RowTemplate.Height = 28
        Me.MealDataGridView.Size = New System.Drawing.Size(406, 150)
        Me.MealDataGridView.TabIndex = 0
        '
        'MealName
        '
        Me.MealName.HeaderText = "Name:"
        Me.MealName.Name = "MealName"
        Me.MealName.Width = 91
        '
        'MealPrice
        '
        Me.MealPrice.HeaderText = "Preis:"
        Me.MealPrice.Name = "MealPrice"
        Me.MealPrice.Width = 84
        '
        'BelongsToMealGroup
        '
        Me.BelongsToMealGroup.HeaderText = "Untergruppe"
        Me.BelongsToMealGroup.Name = "BelongsToMealGroup"
        Me.BelongsToMealGroup.Width = 105
        '
        'MealGroupDataGridView
        '
        Me.MealGroupDataGridView.AllowUserToOrderColumns = True
        Me.MealGroupDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.MealGroupDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.MealGroupDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.MealGroupDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.MealGroupName, Me.MealGroupColor, Me.MealGroupTab})
        Me.MealGroupDataGridView.Location = New System.Drawing.Point(3, 23)
        Me.MealGroupDataGridView.Name = "MealGroupDataGridView"
        Me.MealGroupDataGridView.RowTemplate.Height = 28
        Me.MealGroupDataGridView.Size = New System.Drawing.Size(348, 150)
        Me.MealGroupDataGridView.TabIndex = 2
        '
        'MealGroupName
        '
        Me.MealGroupName.HeaderText = "Name"
        Me.MealGroupName.Name = "MealGroupName"
        Me.MealGroupName.Width = 87
        '
        'MealGroupColor
        '
        Me.MealGroupColor.HeaderText = "Farbe"
        Me.MealGroupColor.Name = "MealGroupColor"
        Me.MealGroupColor.Width = 57
        '
        'MealGroupTab
        '
        Me.MealGroupTab.HeaderText = "Gruppe"
        Me.MealGroupTab.Name = "MealGroupTab"
        Me.MealGroupTab.Width = 69
        '
        'TabDataGridView
        '
        Me.TabDataGridView.AllowUserToOrderColumns = True
        Me.TabDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.TabDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.TabDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TabDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.AvailableTabs})
        Me.TabDataGridView.Location = New System.Drawing.Point(3, 23)
        Me.TabDataGridView.Name = "TabDataGridView"
        Me.TabDataGridView.RowTemplate.Height = 28
        Me.TabDataGridView.Size = New System.Drawing.Size(200, 150)
        Me.TabDataGridView.TabIndex = 3
        '
        'AvailableTabs
        '
        Me.AvailableTabs.HeaderText = "Gruppen Name:"
        Me.AvailableTabs.Name = "AvailableTabs"
        Me.AvailableTabs.Width = 145
        '
        'MainFlowLayoutPanel
        '
        Me.MainFlowLayoutPanel.Controls.Add(Me.TabFlowLayoutPanel)
        Me.MainFlowLayoutPanel.Controls.Add(Me.MealGroupFlowLayoutPanel)
        Me.MainFlowLayoutPanel.Controls.Add(Me.MealFlowLayoutPanel)
        Me.MainFlowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MainFlowLayoutPanel.Location = New System.Drawing.Point(0, 0)
        Me.MainFlowLayoutPanel.Name = "MainFlowLayoutPanel"
        Me.MainFlowLayoutPanel.Size = New System.Drawing.Size(1328, 1102)
        Me.MainFlowLayoutPanel.TabIndex = 4
        '
        'TabFlowLayoutPanel
        '
        Me.TabFlowLayoutPanel.Controls.Add(Me.TabLabel)
        Me.TabFlowLayoutPanel.Controls.Add(Me.TabDataGridView)
        Me.TabFlowLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.TabFlowLayoutPanel.Location = New System.Drawing.Point(3, 3)
        Me.TabFlowLayoutPanel.Name = "TabFlowLayoutPanel"
        Me.TabFlowLayoutPanel.Size = New System.Drawing.Size(243, 246)
        Me.TabFlowLayoutPanel.TabIndex = 4
        '
        'MealFlowLayoutPanel
        '
        Me.MealFlowLayoutPanel.Controls.Add(Me.MealLabel)
        Me.MealFlowLayoutPanel.Controls.Add(Me.MealDataGridView)
        Me.MealFlowLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.MealFlowLayoutPanel.Location = New System.Drawing.Point(658, 3)
        Me.MealFlowLayoutPanel.Name = "MealFlowLayoutPanel"
        Me.MealFlowLayoutPanel.Size = New System.Drawing.Size(420, 246)
        Me.MealFlowLayoutPanel.TabIndex = 0
        '
        'MealGroupFlowLayoutPanel
        '
        Me.MealGroupFlowLayoutPanel.Controls.Add(Me.MealGroupLabel)
        Me.MealGroupFlowLayoutPanel.Controls.Add(Me.MealGroupDataGridView)
        Me.MealGroupFlowLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.MealGroupFlowLayoutPanel.Location = New System.Drawing.Point(252, 3)
        Me.MealGroupFlowLayoutPanel.Name = "MealGroupFlowLayoutPanel"
        Me.MealGroupFlowLayoutPanel.Size = New System.Drawing.Size(400, 246)
        Me.MealGroupFlowLayoutPanel.TabIndex = 0
        '
        'MealLabel
        '
        Me.MealLabel.AutoSize = True
        Me.MealLabel.Location = New System.Drawing.Point(3, 0)
        Me.MealLabel.Name = "MealLabel"
        Me.MealLabel.Size = New System.Drawing.Size(148, 20)
        Me.MealLabel.TabIndex = 0
        Me.MealLabel.Text = "Speißen / Getränke"
        '
        'MealGroupLabel
        '
        Me.MealGroupLabel.AutoSize = True
        Me.MealGroupLabel.Location = New System.Drawing.Point(3, 0)
        Me.MealGroupLabel.Name = "MealGroupLabel"
        Me.MealGroupLabel.Size = New System.Drawing.Size(108, 20)
        Me.MealGroupLabel.TabIndex = 0
        Me.MealGroupLabel.Text = "Untergruppen"
        '
        'TabLabel
        '
        Me.TabLabel.AutoSize = True
        Me.TabLabel.Location = New System.Drawing.Point(3, 0)
        Me.TabLabel.Name = "TabLabel"
        Me.TabLabel.Size = New System.Drawing.Size(121, 20)
        Me.TabLabel.TabIndex = 0
        Me.TabLabel.Text = "Gruppen (Tabs)"
        '
        'DiningPlanEditor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1328, 1102)
        Me.Controls.Add(Me.MainFlowLayoutPanel)
        Me.Name = "DiningPlanEditor"
        Me.Text = "DiningPlanEditor"
        CType(Me.MealDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MealGroupDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TabDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MainFlowLayoutPanel.ResumeLayout(False)
        Me.TabFlowLayoutPanel.ResumeLayout(False)
        Me.TabFlowLayoutPanel.PerformLayout()
        Me.MealFlowLayoutPanel.ResumeLayout(False)
        Me.MealFlowLayoutPanel.PerformLayout()
        Me.MealGroupFlowLayoutPanel.ResumeLayout(False)
        Me.MealGroupFlowLayoutPanel.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MealDataGridView As DataGridView
    Friend WithEvents MealName As DataGridViewTextBoxColumn
    Friend WithEvents MealPrice As DataGridViewTextBoxColumn
    Friend WithEvents BelongsToMealGroup As DataGridViewComboBoxColumn
    Friend WithEvents MealGroupDataGridView As DataGridView
    Friend WithEvents MealGroupName As DataGridViewTextBoxColumn
    Friend WithEvents MealGroupColor As DataGridViewButtonColumn
    Friend WithEvents MealGroupTab As DataGridViewComboBoxColumn
    Friend WithEvents TabDataGridView As DataGridView
    Friend WithEvents AvailableTabs As DataGridViewTextBoxColumn
    Friend WithEvents MainFlowLayoutPanel As FlowLayoutPanel
    Friend WithEvents TabFlowLayoutPanel As FlowLayoutPanel
    Friend WithEvents TabLabel As Label
    Friend WithEvents MealGroupFlowLayoutPanel As FlowLayoutPanel
    Friend WithEvents MealGroupLabel As Label
    Friend WithEvents MealFlowLayoutPanel As FlowLayoutPanel
    Friend WithEvents MealLabel As Label
End Class
