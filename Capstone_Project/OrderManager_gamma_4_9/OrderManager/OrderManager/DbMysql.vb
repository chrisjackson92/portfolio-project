Imports MySql.Data.MySqlClient
Imports System.Data
Module DbMysql

    Public dbConn As MySql.Data.MySqlClient.MySqlConnection = Nothing
    Public strConnection As String = ""
    Private established As Boolean = False

    Public Function Connected() As Boolean
        Return established
    End Function

    Public Function Touch(strFileName As String) As Boolean
        strConnection = "server=107.180.121.67;charset=utf8; user id=csc289; password=defaultpass; database=" & strFileName
        dbConn = New MySqlConnection(strConnection)
        established = False
        Try
            dbConn.Open()
            If dbConn.State <> ConnectionState.Open Then
                Throw New Exception("Error connecting to the database")
            End If
            established = True
            'Debug.WriteLine("connected")
            dbConn.Close()
            dbConn.Dispose()
        Catch ex As Exception
            dbConn = Nothing
        End Try
        Return established
    End Function

    Public Function Query(cmd As String) As List(Of Array)
        Dim data As List(Of Array) = New List(Of Array)(0)
        If established = True Then
            If cmd.Split(" ")(0).ToUpper = "SELECT" Then
                Try
                    dbConn.Open()
                    If dbConn.State = ConnectionState.Open Then
                        Dim residentData As DataSet = New DataSet()
                        Dim sqlCommand As MySqlCommand = New MySqlCommand(cmd, dbConn)
                        Dim adapter As MySqlDataAdapter = New MySqlDataAdapter(sqlCommand)
                        adapter.Fill(residentData)
                        Dim answerSet As DataTable = residentData.Tables.Item(0)
                        For Each row In answerSet.Rows
                            data.Add(row.ItemArray().Clone())
                        Next
                    Else
                        Throw New Exception("Database connection error")
                    End If
                Catch ex As MySqlException
                    MessageBox.Show("SQL Error")
                Catch ex As Exception
                    'continue
                Finally
                    dbConn.Close()
                    dbConn.Dispose()
                End Try
            Else Run(cmd)
            End If
        End If
        Return data
    End Function


    Public Sub Run(cmd As String)
        If established Then
            Try
                dbConn.Open()
                If dbConn.State = ConnectionState.Open Then
                    Dim adapter As MySqlCommand = New MySqlCommand(cmd, dbConn)
                    adapter.ExecuteNonQuery()
                Else
                    Throw New Exception("Database connection error")
                End If
            Catch ex As MySqlException
                MessageBox.Show("SQL Error: " & ex.Message)
            Finally
                dbConn.Close()
                dbConn.Dispose()
            End Try
        End If
    End Sub

    Public Sub MultiRun(cmds() As String)
        If established = True Then
            Try
                dbConn.Open()
                If dbConn.State = ConnectionState.Open Then
                    Dim adapter As MySqlCommand
                    For Each cmd In cmds
                        adapter = New MySqlCommand(cmd, dbConn)
                        adapter.ExecuteNonQuery()
                    Next
                Else
                    Throw New Exception("Database connection error")
                End If
            Catch ex As MySqlException
                MessageBox.Show("SQL Error" & ex.Message)
            Catch ex As Exception
                'continue
            Finally
                dbConn.Close()
                dbConn.Dispose()
            End Try
        End If
    End Sub

End Module
