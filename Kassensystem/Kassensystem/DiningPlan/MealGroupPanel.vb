Imports Kassensystem_Logic.Dining

Public Class MealGroupPanel

    Private DPlan As DiningPlan
    Public MealControlList As List(Of MealControl)

    Public Sub New()

        ' Dieser Aufruf ist für den Designer erforderlich.
        InitializeComponent()

        ' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.

    End Sub

    Public Sub New(DPlan As DiningPlan)
        Me.DPlan = DPlan
        Me.MealControlList = New List(Of MealControl)
        ' Dieser Aufruf ist für den Designer erforderlich.
        InitializeComponent()
        For Each mg As MealGroup In DPlan.Groups
            For Each m As Meal In mg.meals
                Dim mealC As MealControl = New MealControl()
                mealC.BackColor = mg.BgColor
            Next
        Next
        ' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.

    End Sub

    Public Sub AddMeal(m As Meal)

    End Sub
End Class
