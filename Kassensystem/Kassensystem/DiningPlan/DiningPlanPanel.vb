Imports Kassensystem_Logic.Dining

Public Class DiningPlanPanel

    Public Sub New()

        ' Dieser Aufruf ist für den Designer erforderlich.
        InitializeComponent()

    End Sub

    Private _DiningPlan As DiningPlan
    Private _TabPageDict As Dictionary(Of String, TabPage)
    Private _MealGroupPanelDict As Dictionary(Of String, MealGroupPanel)
    Public Sub New(DPlan As DiningPlan)

        ' Dieser Aufruf ist für den Designer erforderlich.
        InitializeComponent()

        _DiningPlan = DPlan
        _TabPageDict = New Dictionary(Of String, TabPage)
        _MealGroupPanelDict = New Dictionary(Of String, MealGroupPanel)



        For Each mg In _DiningPlan.Groups
            Dim tabC As TabPage
            Dim mgp As MealGroupPanel
            If _TabPageDict.ContainsKey(mg.tab) Then
                mgp = _MealGroupPanelDict(mg.tab)
                mgp.AddMealGroup(mg)
            Else
                tabC = New TabPage
                _TabPageDict.Add(mg.tab, tabC)
                mgp = New MealGroupPanel(mg)
                _MealGroupPanelDict.Add(mg.tab, mgp)
                tabC.Text = mg.tab
                tabC.Controls.Add(mgp)
                mgp.Dock = DockStyle.Fill
                Me.MainTabControl.TabPages.Add(tabC)
            End If

        Next

    End Sub


End Class
