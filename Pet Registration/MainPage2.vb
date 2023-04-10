Imports MySql.Data.MySqlClient

Public Class MainPage2

    Public MysqlConn As MySqlConnection
    Public cmd As New MySqlCommand
    Public da As New MySqlDataAdapter
    Public result As Integer 'for insertion

    Public Sub MysqlConnection()
        MysqlConn = New MySqlConnection()

        'Connection String
        MysqlConn.ConnectionString = "server=localhost;" _
        & "user id=root;" _
        & "password=elly;" _
        & "database=dbpetshop;"

        'OPENING THE MysqlConnNECTION
        MysqlConn.Open()
    End Sub

    Public Sub InsertNewPet()
        Try
            If txttype.Text = "" Or txtname.Text = "" Or txtbreed.Text = "" Or txtcolor.Text = "" Or cbgender.SelectedItem = "" Or txtweight.Text = "" Or txtage.Text = "" Then
                MsgBox("Please complete all details", vbOKOnly + vbInformation, "PET STORE")
                txttype.Focus()

            Else
                With cmd
                    .Connection = MysqlConn
                    .CommandText = "INSERT INTO tblpets (type,name,breed,color,gender,weight,age) 
                                VALUES('" & txttype.Text & "', '" & txtname.Text & "' , '" & txtbreed.Text & "','" & txtcolor.Text & "','" & cbgender.SelectedItem & "','" & txtweight.Text & "','" & txtage.Text & "')"


                    'in this line it Executes a transact-SQL statements against the connection and returns the number of rows affected 
                    result = cmd.ExecuteNonQuery
                    'if the result is equal to zero it means that no rows is inserted or somethings wrong during the execution
                    If result = 0 Then
                        MsgBox("Something went wrong..", vbOKOnly + vbExclamation, "PET STORE")
                    Else
                        MsgBox("Pet succesfully added!", vbOKOnly + vbInformation, "PET STORE")
                        txttype.Clear()
                        txtname.Clear()
                        txtbreed.Clear()
                        txtcolor.Clear()
                        cbgender.SelectedIndex = -1
                        txtweight.Clear()
                        txtage.Clear()


                    End If
                End With
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        MysqlConn.Close()
    End Sub


    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        MysqlConnection()
        InsertNewPet()
    End Sub

    Private Sub btnGoback_Click(sender As Object, e As EventArgs) Handles btnGoback.Click
        MainPage.Show()
        Me.Hide()

    End Sub
End Class