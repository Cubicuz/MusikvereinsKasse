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

        FullMealDownButton.Enabled = Not m.Amount = 0
        HalfMealDownButton.Enabled = Not m.AmountHalfPrice = 0

        AddHandler MyMeal.amountChanged, AddressOf HandleMealAmountChanged
        AddHandler MyMeal.amountHalfPriceChanged, AddressOf HandleMealAmountHalfPriceChanged
    End Sub

    Private Sub FullMealComboBox_TextChanged(sender As Object, e As EventArgs) Handles FullMealComboBox.TextChanged

    End Sub


#Region "---------- ButtonHandler ----------"
    Private Sub FullMealDownButton_Click(sender As Object, e As EventArgs) Handles FullMealDownButton.Click
        MyMeal.Amount -= 1
    End Sub

    Private Sub FullMealUpButton_Click(sender As Object, e As EventArgs) Handles FullMealUpButton.Click
        MyMeal.Amount += 1
    End Sub

    Private Sub HalfMealDownButton_Click(sender As Object, e As EventArgs) Handles HalfMealDownButton.Click
        MyMeal.AmountHalfPrice -= 1
    End Sub

    Private Sub HalfMealUpButton_Click(sender As Object, e As EventArgs) Handles HalfMealUpButton.Click
        MyMeal.AmountHalfPrice += 1
    End Sub

#End Region
#Region "---------- ComboboxHandler ----------"
    Private Sub HandleFullMealSelectionChanged(sender As Object, e As EventArgs) Handles FullMealComboBox.TextChanged
        If Not FullMealComboBox.Text.Equals(MyMeal.Amount) Then
            Try
                MyMeal.Amount = Integer.Parse(FullMealComboBox.Text)
            Catch
                MyMeal.Amount = 0
            End Try

        End If
    End Sub

    Private Sub HandleHalfMealSelectionChanged(sender As Object, e As EventArgs) Handles HalfMealComboBox.TextChanged
        If Not HalfMealComboBox.Text.Equals(MyMeal.AmountHalfPrice) Then
            Try
                MyMeal.AmountHalfPrice = Integer.Parse(HalfMealComboBox.Text)
            Catch
                MyMeal.AmountHalfPrice = 0
            End Try
        End If
    End Sub
#End Region
#Region "---------- MealHandler ----------"

    Private Sub HandleMealAmountChanged(sender As Meal, diff As Integer)
        If Not Me.FullMealComboBox.Text.Equals(MyMeal.Amount.ToString) Then
            Me.FullMealComboBox.Text = MyMeal.Amount
        End If
        UpdatePrice()
        FullMealDownButton.Enabled = Not sender.Amount = 0
    End Sub

    Private Sub HandleMealAmountHalfPriceChanged(sender As Meal, diff As Integer)
        If Not Me.HalfMealComboBox.Text.Equals(MyMeal.AmountHalfPrice.ToString) Then
            Me.HalfMealComboBox.Text = MyMeal.AmountHalfPrice
        End If
        UpdatePrice()
        HalfMealDownButton.Enabled = Not sender.AmountHalfPrice = 0
    End Sub

    Private Sub UpdatePrice()
        PriceTextBox.Text = (MyMeal.Price * MyMeal.Amount + MyMeal.HalfPrice * MyMeal.AmountHalfPrice).ToString("C")
    End Sub
#End Region
End Class
