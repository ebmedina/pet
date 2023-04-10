Public Class MainPage
    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        MainPage2.Show()
        Me.Hide()
    End Sub

    Private Sub btnadmin_Click(sender As Object, e As EventArgs) Handles btnadmin.Click
        admin.Show()
        Me.Hide()

    End Sub
End Class