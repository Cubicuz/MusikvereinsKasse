<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MealGroupPanel
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
        Me.MealOrganizerFlowLayoutPanel = New System.Windows.Forms.FlowLayoutPanel()
        Me.SuspendLayout()
        '
        'MealOrganizerFlowLayoutPanel
        '
        Me.MealOrganizerFlowLayoutPanel.AutoSize = True
        Me.MealOrganizerFlowLayoutPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.MealOrganizerFlowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MealOrganizerFlowLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.MealOrganizerFlowLayoutPanel.Location = New System.Drawing.Point(0, 0)
        Me.MealOrganizerFlowLayoutPanel.Name = "MealOrganizerFlowLayoutPanel"
        Me.MealOrganizerFlowLayoutPanel.Size = New System.Drawing.Size(819, 503)
        Me.MealOrganizerFlowLayoutPanel.TabIndex = 0
        '
        'MealGroupPanel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.MealOrganizerFlowLayoutPanel)
        Me.Name = "MealGroupPanel"
        Me.Size = New System.Drawing.Size(819, 503)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MealOrganizerFlowLayoutPanel As FlowLayoutPanel
End Class
