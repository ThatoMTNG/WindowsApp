Public Class Form1
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click

        Dim length, width, height, surfaceArea, rollCoverage, singleRoll As Double

        length = Val(txtLength.Text)
        width = Val(txtWidth.Text)
        height = Val(txtHeight.Text)
        surfaceArea = 2 * ((length * height) + (width * height))
        rollCoverage = Val(txtRollCoverage.Text)
        singleRoll = Math.Ceiling(Val(surfaceArea / rollCoverage))
        txtSingleRoll.Text = singleRoll

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        Application.Exit()

    End Sub
End Class
