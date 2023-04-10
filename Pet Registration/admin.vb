Imports MySql.Data.MySqlClient

Public Class admin

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

    Public Sub getAllAccounts()
        Dim sql As String
        Dim TempTable As New DataTable

        sql = "select * from tblaccount"

        'bind the connection and query
        With cmd
            .Connection = MysqlConn
            .CommandText = sql
        End With

        da.SelectCommand = cmd
        da.Fill(TempTable)

        'the result of the query will now be displayed in the grid
        dgvAccounts.DataSource = TempTable

    End Sub

    Public Sub getAllPets()
        Dim sql As String
        Dim TempTable As New DataTable

        sql = "select * from tblpets"

        'bind the connection and query
        With cmd
            .Connection = MysqlConn
            .CommandText = sql
        End With

        da.SelectCommand = cmd
        da.Fill(TempTable)

        'the result of the query will now be displayed in the grid
        dgvAccounts.DataSource = TempTable

    End Sub
    Private Sub admin()
        'this will call the connection function and will attempt to connect to your database
        MysqlConnection()
        'this will call the function that contains your select statement and will try to perform it
        getAllAccounts()
    End Sub

    Private Sub dgvAccounts_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvAccounts.CellContentClick

    End Sub

    Private Sub btnAccounts_Click(sender As Object, e As EventArgs) Handles btnAccounts.Click
        MysqlConnection()
        getAllAccounts()
    End Sub

    Private Sub btnPets_Click(sender As Object, e As EventArgs) Handles btnPets.Click
        MysqlConnection()
        getAllPets()
    End Sub
End Class