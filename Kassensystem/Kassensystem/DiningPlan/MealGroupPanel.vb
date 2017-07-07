Imports Kassensystem_Logic.Dining

Public Class MealGroupPanel

    Private _DPlan As DiningPlan
    Friend MealControlList As List(Of MealControl)

    Public Sub New()

        ' Dieser Aufruf ist für den Designer erforderlich.
        InitializeComponent()

        ' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.

    End Sub

    Public Sub New(DPlan As DiningPlan)

        _DPlan = DPlan
        Me.MealControlList = New List(Of MealControl)
        ' Dieser Aufruf ist für den Designer erforderlich.
        InitializeComponent()
        For Each mg As MealGroup In DPlan.Groups
            For Each m As Meal In mg.Meals
                Dim mealC As MealControl = New MealControl(m)
                mealC.BackColor = mg.BgColor
                MealOrganizerFlowLayoutPanel.Controls.Add(mealC)
                mealC.Dock = DockStyle.Fill
                Me.MealControlList.Add(mealC)
            Next
        Next

    End Sub

    Public Sub DPlan(ByRef value As DiningPlan)

    End Sub
    Public Function DPlan() As DiningPlan
        Return _DPlan
    End Function

    Public Sub AddMeal(m As Meal)
        Dim mealC As MealControl = New MealControl(m)
        MealOrganizerFlowLayoutPanel.Controls.Add(mealC)
        Me.MealControlList.Add(mealC)
    End Sub
End Class
