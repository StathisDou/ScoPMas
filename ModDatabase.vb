Module ModDatabase

    Public dataSendCmd As String = ""
    Public Source_Bind As BindingSource
    Public databaseName As String
    Public databasePath As String
    Public connection_String As String
    Public connection_As As SQLite.SQLiteConnection
    Public Command_Cmd As SQLite.SQLiteCommand


    Public Sub ExecuteCommand(ByVal SQLCode)
        Try
            connection_As.Open()
        Catch ex As Exception

        End Try

        If connection_As.State = ConnectionState.Open Then
            FrmData.LblConnectionState.BackColor = Color.DarkGreen

            Try
                Command_Cmd.Connection = connection_As
                Command_Cmd.CommandText = SQLCode
                Dim DataR As SQLite.SQLiteDataReader = Command_Cmd.ExecuteReader

                Dim DataT As New DataTable
                DataT.Load(DataR)
                FrmTest.dgv1.DataSource = DataT
            Catch ex As Exception
                MsgBox("An error occured when parsing the db")
            End Try

        Else
            FrmData.LblConnectionState.BackColor = Color.DarkRed
        End If
        connection_As.Close()
    End Sub

End Module
