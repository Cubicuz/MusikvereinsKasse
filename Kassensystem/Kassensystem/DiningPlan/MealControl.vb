Imports Kassensystem_Logic.Dining

Public Class MealControl
    Public Event FullMealValueChanged(n As Integer)
    Public Event HalfMealValueChanged(n As Integer)

    Public Property FullMealValue As Integer
        Get
            Return Integer.Parse(FullMealComboBox.SelectedText())
        End Get
        Set(value As Integer)

        End Set
    End Property

    Public Property HalfMealValue As Integer
        Get
            Return Integer.Parse(HalfMealComboBox.SelectedText())
        End Get
        Set(value As Integer)

        End Set
    End Property

    Private MyMeal As Meal

    Public Sub New()

        ' Dieser Aufruf ist für den Designer erforderlich.
        InitializeComponent()

        ' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.

    End Sub

    Public Sub New(m As Meal)
        MyMeal = m
        ' Dieser Aufruf ist für den Designer erforderlich.
        InitializeComponent()
        NameLabel.Text = m.Name
        If m.HalfPrice = 0 Then
            HalfMealTableLayoutPanel.Enabled = False
        End If
        ' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.

    End Sub

    Private Sub FullMealComboBox_TextChanged(sender As Object, e As EventArgs) Handles FullMealComboBox.TextChanged

    End Sub


#Region "---------- ButtonHandler ----------"
    Private Sub FullMealDownButton_Click(sender As Object, e As EventArgs) Handles FullMealDownButton.Click

    End Sub

    Private Sub FullMealUpButton_Click(sender As Object, e As EventArgs) Handles FullMealUpButton.Click

    End Sub

    Private Sub HalfMealDownButton_Click(sender As Object, e As EventArgs) Handles HalfMealDownButton.Click

    End Sub

    Private Sub HalfMealUpButton_Click(sender As Object, e As EventArgs) Handles HalfMealUpButton.Click

    End Sub

#End Region
End Class
