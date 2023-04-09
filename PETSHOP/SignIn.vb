Public Class SignIn
    Private Sub SignIn_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnReg1_Click(sender As Object, e As EventArgs) Handles btnReg1.Click
        Register.Show()
        Me.Hide()

    End Sub

    Private Sub btnGoback_Click(sender As Object, e As EventArgs) Handles btnGoback.Click
        Form1.Show()
        Me.Hide()

    End Sub
End Class