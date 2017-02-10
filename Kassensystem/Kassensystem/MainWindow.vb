Imports Kassensystem_Logic.Saving
Imports Kassensystem_Logic.Dining
Imports Microsoft.VisualBasic.FileIO

Public Class MainWindow

    Private isSessionOpen As Boolean = False

    Public Shared DiningPlanInstance As DiningPlan = Nothing

#Region "---------- Events ----------"

    Public Shared Event DiningPlanInstanceChanged(ByRef diningPlan As DiningPlan)

#End Region
    Public Sub New()

        ' Dieser Aufruf ist für den Designer erforderlich.
        InitializeComponent()

        Dim m As MealControl = New MealControl(New Meal(1, "aslkdjf", 1.5, 0))
        m.BackColor = Color.Red
        m.Anchor = AnchorStyles.Left And AnchorStyles.Right
        FlowLayoutPanel1.Controls.Add(m)


        m = New MealControl(New Meal(1, "aslkdjf", 1.5, 5))
        m.BackColor = Color.Blue
        m.Anchor = AnchorStyles.Left And AnchorStyles.Right

        FlowLayoutPanel1.Controls.Add(m)


        'FileIO.loadDiningPlan("C:\Users\PegaMenis\ownCloud\Musikverein\Kassensystem\exampleDiningPlan.xml")
    End Sub

    Private Sub ÖffnenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ÖffnenToolStripMenuItem.Click
        If isSessionOpen Then
            'TODO: ask to save Session
        End If
        Dim fd As OpenFileDialog = New OpenFileDialog()
        fd.Title = "Kasse öffnen"
        fd.InitialDirectory = SpecialDirectories.Desktop
        fd.Filter = "All files (*.*)|*.*|All files (*.*)|*.*"
        fd.FilterIndex = 2
        fd.RestoreDirectory = True
        If fd.ShowDialog() = DialogResult.OK Then
            FileIO.LoadDiningPlan(fd.FileName)
        End If
    End Sub
End Class
