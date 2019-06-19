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
        Try
            targetOfBtn.Text = CSV_Manipulation.ReadFile()
        Catch ex As Exception
            MsgBox(ex.Message + "--  /'data.csv/' does not exist.")
        End Try
    End Sub

    Private Sub btnMean_Click(sender As Object, e As EventArgs) Handles btnMean.Click
        Try
            targetOfBtn.Text = CustomMath.CalcMean(CSVToIntList(targetOfBtn.Text))
        Catch ex As Exception
            MsgBox(ex.Message)
            Exit Sub
        End Try
    End Sub

    Private Sub btnMedian_Click(sender As Object, e As EventArgs) Handles btnMedian.Click
        Try
            targetOfBtn.Text = CustomMath.CalcMedian(CSVToIntList(targetOfBtn.Text))
        Catch ex As Exception
            MsgBox(ex.Message)
            Exit Sub
        End Try
    End Sub

    Private Sub btnRange_Click(sender As Object, e As EventArgs) Handles btnRange.Click
        Try
            targetOfBtn.Text = CustomMath.CalcRange(CSVToIntList(targetOfBtn.Text))
        Catch ex As Exception
            MsgBox(ex.Message)
            Exit Sub
        End Try
    End Sub

    Private Sub btnSort_Click(sender As Object, e As EventArgs) Handles btnSort.Click
        Try
            Dim test As String = IntListToCSV(CustomMath.SortNumbs(CSVToIntList(targetOfBtn.Text)))
            targetOfBtn.Text = test
        Catch ex As Exception
            MsgBox(ex.Message)
            Exit Sub
        End Try
    End Sub

End Class