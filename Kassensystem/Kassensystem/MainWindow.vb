Imports Kassensystem_Logic.Saving
Imports Kassensystem_Logic.Dining
Imports Microsoft.VisualBasic.FileIO

Public Class MainWindow

    Private isSessionOpen As Boolean = False


    Public Sub New()

        ' Dieser Aufruf ist für den Designer erforderlich.
        InitializeComponent()
        Dim M() As Meal = {New Meal(1, "Maultaschen", 5.0, 2.8), New Meal(2, "Bratwurst", 4.3, 0), New Meal(3, "Salzfleisch", 4.7, 3.0)}
        Dim MG() As MealGroup = {New MealGroup(M, "Group1", Color.Aqua)}
        Dim DNP As DiningPlan = FileIO.LoadDiningPlan("C:\Users\michi\Desktop\exampleDiningPlan.xml") 'New DiningPlan(MG)
        DiningPlan.DiningPlanInstance = DNP
        Dim MGP As MealGroupPanel = New MealGroupPanel(DNP)
        'Dim MC As MealControl = New MealControl(M(0))
        TableLayoutPanel1.Controls.Add(MGP, 0, 0)
        MGP.Dock = DockStyle.Fill
        CurrentOrderPanel1.InitializeCurrentOrderPanel(DNP)
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
            DiningPlan.DiningPlanInstance = FileIO.LoadDiningPlan(fd.FileName)
        End If
    End Sub
End Class
