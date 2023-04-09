Imports System.Windows.Forms.VisualStyles.VisualStyleElement
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
        & "password=ellyxandra;" _
        & "database=dbpetshop;"

        'OPENING THE MysqlConnNECTION
        MysqlConn.Open()
    End Sub

    Public Sub InsertNewUser()
        Try
            If txtfname.Text = "" Or txtlname.Text = "" Or txtcontact.Text = "" Or txtemail.Text = "" Or txtaddress.Text = "" Or txtusername.Text = "" Or txtpassword.Text = "" Then
                MsgBox("Please complete all details", vbOKOnly + vbInformation, "REPLACE THIS WITH SYSTEM NAME")
                txtfname.Focus()
            Else
                With cmd
                    .Connection = MysqlConn
                    .CommandText = "INSERT INTO tblaccount (firstname,lastname,contact,email,address,username,password) 
                                VALUES('" & txtfname.Text & "', '" & txtlname.Text & "' , '" & txtcontact.Text & "','" & txtemail.Text & "','" & txtaddress.Text & "',,'" & txtusername.Text & "',,'" & txtpassword.Text & "')"


                    'in this line it Executes a transact-SQL statements against the connection and returns the number of rows affected 
                    result = cmd.ExecuteNonQuery
                    'if the result is equal to zero it means that no rows is inserted or somethings wrong during the execution
                    If result = 0 Then
                        MsgBox("Something went wrong..", vbOKOnly + vbExclamation, "REPLACE THIS WITH SYSTEM NAME")
                    Else
                        MsgBox("New student successfully created!", vbOKOnly + vbInformation, "REPLACE THIS WITH SYSTEM NAME")
                        txtfname.Clear()
                        txtlname.Clear()
                        txtcontact.Clear()
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

    Private Sub btnGoback_Click(sender As Object, e As EventArgs) Handles btnGoback.Click
        Form1.Show()
        Me.Hide()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        MysqlConnection()

    End Sub
End Class