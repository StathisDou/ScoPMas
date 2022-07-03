Public Class FrmTest
    Private Sub FrmTest_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BtnExecute_Click(sender As Object, e As EventArgs) Handles BtnExecute.Click

        ExecuteCommand(TxtExecute.Text)

    End Sub
End Class