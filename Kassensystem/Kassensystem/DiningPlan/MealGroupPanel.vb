Imports Kassensystem_Logic.Dining

Public Class MealGroupPanel

    Private _MealGroup As MealGroup
    Friend MealControlList As List(Of MealControl)

    Public Sub New()

        ' Dieser Aufruf ist für den Designer erforderlich.
        InitializeComponent()

        ' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.

    End Sub

    Public Sub New(MGroup As MealGroup)

        _MealGroup = MGroup
        Me.MealControlList = New List(Of MealControl)
        ' Dieser Aufruf ist für den Designer erforderlich.
        InitializeComponent()
        For Each m As Meal In _MealGroup.Meals
            Dim mealC As MealControl = New MealControl(m)
            mealC.BackColor = _MealGroup.BgColor
            MealOrganizerFlowLayoutPanel.Controls.Add(mealC)
            mealC.Dock = DockStyle.Fill
            Me.MealControlList.Add(mealC)
        Next


    End Sub

    Public Sub DPlan(ByRef value As DiningPlan)

    End Sub
    Public Function MGroup() As MealGroup
        Return _MealGroup
    End Function

    Public Sub AddMeal(m As Meal)
        Dim mealC As MealControl = New MealControl(m)
        MealOrganizerFlowLayoutPanel.Controls.Add(mealC)
        Me.MealControlList.Add(mealC)
    End Sub

    Public Sub addMeal(mc As MealControl)
        MealOrganizerFlowLayoutPanel.Controls.Add(mc)
        Me.MealControlList.Add(mc)
    End Sub

    Public Sub AddMealGroup(mg As MealGroup)
        For Each meal In mg.Meals
            Dim mealC As MealControl = New MealControl(meal)
            mealC.BackColor = mg.BgColor
            MealOrganizerFlowLayoutPanel.Controls.Add(mealC)
            mealC.Dock = DockStyle.Fill
            Me.MealControlList.Add(mealC)
        Next
    End Sub

End Class
