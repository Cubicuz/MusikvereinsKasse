Imports Kassensystem_Logic.Dining

Public Class CurrentOrderPanel
    Private MealControlList As New List(Of MealControl)

    Public Sub InitializeCurrentOrderPanel(DP As DiningPlan)
        MealControlList.Clear()
        FlowLayoutPanel1.Controls.Clear()
        For Each mg In DP.Groups
            For Each meal In mg.Meals
                Dim mc As New MealControl(meal)
                mc.BackColor = Color.LightGray
                mc.Dock = DockStyle.Fill
                mc.AutoSizeMode = AutoSizeMode.GrowOnly
                mc.PriceTextBox.Visible = True
                meal.Amount += 1
                AddHandler meal.amountChanged, Sub()
                                                   If meal.Amount = 0 And meal.AmountHalfPrice = 0 Then
                                                       mc.Visible = False
                                                   Else
                                                       mc.Visible = True
                                                   End If
                                               End Sub
                AddHandler meal.amountHalfPriceChanged, Sub()
                                                            If meal.Amount = 0 And meal.AmountHalfPrice = 0 Then
                                                                mc.Visible = False
                                                            Else
                                                                mc.Visible = True
                                                            End If
                                                        End Sub

                MealControlList.Add(mc)
                FlowLayoutPanel1.Controls.Add(mc)
            Next
        Next
    End Sub
End Class
