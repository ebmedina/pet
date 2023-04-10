Public Class SignIn
    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        Register.Show()
        Me.Hide()

    End Sub

    Private Sub btnGoback_Click(sender As Object, e As EventArgs) Handles btnGoback.Click
        Form1.Show()
        Me.Hide()

    End Sub

    Private Sub btnSignin_Click(sender As Object, e As EventArgs) Handles btnSignin.Click
        MainPage.Show()
        Me.Hide()


    End Sub
End Class