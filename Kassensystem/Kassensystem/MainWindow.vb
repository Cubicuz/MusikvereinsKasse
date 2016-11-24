Imports Kassensystem_Logic.Saving
Imports Kassensystem_Logic.Dining

Public Class MainWindow
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
End Class
