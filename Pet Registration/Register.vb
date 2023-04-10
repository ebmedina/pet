Imports MySql.Data.MySqlClient
Public Class Register

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

    Public Sub InsertNewOwner()
        Try
            If txtfname.Text = "" Or txtlname.Text = "" Or txtcontact.Text = "" Or txtaddress.Text = "" Or cbgender.SelectedItem = "" Or txtemail.Text = "" Or txtusername.Text = "" Or txtpassword.Text = "" Then
                MsgBox("Please complete all details", vbOKOnly + vbInformation, "PET STORE")
                txtfname.Focus()

            Else
                With cmd
                    .Connection = MysqlConn
                    .CommandText = "INSERT INTO tblaccount (firstName,lastName,contact,address,gender,email,username,password) 
                                VALUES('" & txtfname.Text & "', '" & txtlname.Text & "' , '" & txtcontact.Text & "','" & txtaddress.Text & "','" & cbgender.SelectedItem & "','" & txtemail.Text & "','" & txtusername.Text & "','" & txtpassword.Text & "')"




                    'in this line it Executes a transact-SQL statements against the connection and returns the number of rows affected 
                    result = cmd.ExecuteNonQuery
                    'if the result is equal to zero it means that no rows is inserted or somethings wrong during the execution
                    If result = 0 Then
                        MsgBox("Something went wrong..", vbOKOnly + vbExclamation, "PET STORE")
                    Else
                        MsgBox("Account succesfully created!", vbOKOnly + vbInformation, "PET STORE")
                        txtfname.Clear()
                        txtlname.Clear()
                        txtcontact.Clear()
                        txtaddress.Clear()
                        cbgender.SelectedItem = 0
                        txtemail.Clear()
                        txtaddress.Clear()
                        txtusername.Clear()
                        txtpassword.Clear()

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
        InsertNewOwner()
    End Sub

    Private Sub btnGoback_Click(sender As Object, e As EventArgs) Handles btnGoback.Click
        Form1.Show()
        Me.Hide()

    End Sub
End Class