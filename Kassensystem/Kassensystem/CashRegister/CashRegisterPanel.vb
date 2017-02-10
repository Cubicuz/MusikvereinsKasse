Imports System.ComponentModel

Public Class CashRegisterPanel



#Region "---------- ButtonHandler ----------"
#Region "---------- EuroButtonHandler ----------"
    Private Sub Euro5Button_Click(sender As Object, e As EventArgs) Handles Euro5Button.Click
        EuroButtonAdder(5)
    End Sub

    Private Sub Euro10Button_Click(sender As Object, e As EventArgs) Handles Euro10Button.Click
        EuroButtonAdder(10)
    End Sub

    Private Sub Euro20Button_Click(sender As Object, e As EventArgs) Handles Euro20Button.Click
        EuroButtonAdder(20)
    End Sub

    Private Sub Euro50Button_Click(sender As Object, e As EventArgs) Handles Euro50Button.Click
        EuroButtonAdder(50)
    End Sub

    Private Sub Euro100Button_Click(sender As Object, e As EventArgs) Handles Euro100Button.Click
        EuroButtonAdder(100)
    End Sub

    Private Sub EuroButtonAdder(value As Int16)
        Dim dec As Decimal
        Decimal.TryParse(MoneyInTextBox.Text, dec)
        dec += value
        MoneyInTextBox.Text = dec.ToString
    End Sub
#End Region
#Region "---------- NumControlHandler ----------"

    Private Sub Num1Button_Click(sender As Object, e As EventArgs) Handles Num1Button.Click
        MoneyInTextBox.AppendText("1")
    End Sub

    Private Sub Num2Button_Click(sender As Object, e As EventArgs) Handles Num2Button.Click
        MoneyInTextBox.AppendText("2")
    End Sub

    Private Sub Num3Button_Click(sender As Object, e As EventArgs) Handles Num3Button.Click
        MoneyInTextBox.AppendText("3")
    End Sub

    Private Sub Num4Button_Click(sender As Object, e As EventArgs) Handles Num4Button.Click
        MoneyInTextBox.AppendText("4")
    End Sub

    Private Sub Num5Button_Click(sender As Object, e As EventArgs) Handles Num5Button.Click
        MoneyInTextBox.AppendText("5")
    End Sub

    Private Sub Num6Button_Click(sender As Object, e As EventArgs) Handles Num6Button.Click
        MoneyInTextBox.AppendText("6")
    End Sub

    Private Sub Num7Button_Click(sender As Object, e As EventArgs) Handles Num7Button.Click
        MoneyInTextBox.AppendText("7")
    End Sub

    Private Sub Num8Button_Click(sender As Object, e As EventArgs) Handles Num8Button.Click
        MoneyInTextBox.AppendText("8")
    End Sub

    Private Sub Num9Button_Click(sender As Object, e As EventArgs) Handles Num9Button.Click
        MoneyInTextBox.AppendText("9")
    End Sub

    Private Sub Num0Button_Click(sender As Object, e As EventArgs) Handles Num0Button.Click
        MoneyInTextBox.AppendText("0")
    End Sub

    Private Sub NumDotButton_Click(sender As Object, e As EventArgs) Handles NumDotButton.Click
        If Not MoneyInTextBox.Text.Contains(",") Then
            MoneyInTextBox.AppendText(",")
        End If
    End Sub

    Private Sub NumDelButton_Click(sender As Object, e As EventArgs) Handles NumDelButton.Click
        MoneyInTextBox.Text = MoneyInTextBox.Text.Substring(0, MoneyInTextBox.Text.Length - 1)
    End Sub

    Private Sub NumClearButton_Click(sender As Object, e As EventArgs) Handles NumClearButton.Click
        MoneyInTextBox.Text = "0"
    End Sub



#End Region

#End Region
#Region "---------- MoneyTextBox ----------"
    Private Sub MoneyInTextBox_TextChanged(sender As Object, e As EventArgs) Handles MoneyInTextBox.TextChanged
        Dim res As Decimal
        If MoneyInTextBox.Text = "0" Then
            Return
        End If
        If MoneyInTextBox.Text = "" Then
            MoneyInTextBox.Text = "0"
            Return
        End If
        If Decimal.TryParse(MoneyInTextBox.Text, res) Then
            If MoneyInTextBox.Text.First.Equals("0"c) Then
                MoneyInTextBox.Text = MoneyInTextBox.Text.TrimStart("0"c)
            End If
        Else
            MoneyInTextBox.Text = "0"
            'TODO: Fehlermeldung
        End If
        MoneyOutTextBox_ChangeText()
    End Sub

    Private Sub MoneyOutTextBox_ChangeText()
        If MainWindow.DiningPlanInstance Is Nothing Then
            MoneyOutTextBox.Text = "---"
        Else
            Dim moneyIn As Decimal
            Decimal.TryParse(MoneyInTextBox.Text, moneyIn)
            MoneyOutTextBox.Text = (moneyIn - MainWindow.DiningPlanInstance.Price)
        End If
    End Sub
#End Region

End Class
