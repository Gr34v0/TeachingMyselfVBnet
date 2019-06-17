Public Class Form1

    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1Click.Click
        targetOfBtn.Text = btn1Click.Text
    End Sub

    Private Sub btn2_Click(sender As Object, e As EventArgs) Handles btn2Click.Click
        targetOfBtn.Text = btn2Click.Text
    End Sub

    Private Sub bt31_Click(sender As Object, e As EventArgs) Handles btn3Click.Click
        targetOfBtn.Text = btn3Click.Text
    End Sub

    Private Sub btnCSView_Click(sender As Object, e As EventArgs) Handles btnCSViewClick.Click
        targetOfBtn.Text = CSV_Manipulation.ReadFile()
    End Sub

    Private Sub btnMean_Click(sender As Object, e As EventArgs) Handles btnMean.Click

    End Sub

    Private Sub btnMedian_Click(sender As Object, e As EventArgs) Handles btnMedian.Click

    End Sub

    Private Sub btnRange_Click(sender As Object, e As EventArgs) Handles btnRange.Click
        targetOfBtn.Text = CustomMath.CalcRange(CSVToIntList(targetOfBtn.Text))
    End Sub

End Class