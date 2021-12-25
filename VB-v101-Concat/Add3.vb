Public Class Add3
    Private Sum As Integer
    Private Sub btnCalcSum_Click(sender As Object, e As EventArgs) Handles btnCalcSum.Click
        Sum = txtNo1.Text + txtNo2.Text + txtNo3.Text
        txtSumValue.Text = Sum
    End Sub
End Class
