Public Class FrmData
    Private Sub BtnConnectDB_Click(sender As Object, e As EventArgs) Handles BtnConnectDB.Click
        databasePath = TxtDatabasePath.Text & databaseName
        connection_String = "Data source=" & databasePath & ";Version=" & txtVersionNumber.Text
        connection_As = New SQLite.SQLiteConnection(connection_String)
        Command_Cmd = New SQLite.SQLiteCommand("", connection_As)


        Try
            connection_As.Open()
        Catch ex As Exception

        End Try


        LblConnectionState.Text = "State : " & connection_As.State


        If connection_As.State = ConnectionState.Open Then
            LblConnectionState.BackColor = Color.DarkGreen

            Try
                Command_Cmd.Connection = connection_As
                Command_Cmd.CommandText = "SELECT * FROM T_Customers"
                Dim DataR As SQLite.SQLiteDataReader = Command_Cmd.ExecuteReader

                Dim DataT As New DataTable
                DataT.Load(DataR)
                FrmTest.dgv1.DataSource = DataT
            Catch ex As Exception

            End Try

        Else
            LblConnectionState.BackColor = Color.DarkRed
        End If
        'connection_As.Close()

    End Sub

    Private Sub FrmData_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

End Class