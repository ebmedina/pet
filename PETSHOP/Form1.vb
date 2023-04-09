Public Class Form1
    Private Sub btnSignin_Click(sender As Object, e As EventArgs) Handles btnSignin.Click
        SignIn.Show()
        Me.Hide()

    End Sub

    Private Sub btnReg_Click(sender As Object, e As EventArgs) Handles btnReg.Click
        Register.Show()
        Me.Hide()


    End Sub
End Class
