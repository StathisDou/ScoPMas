Public Class Frm_Main
    Private Sub Frm_Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        End
    End Sub

    Private Sub ConfiguredbToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConfiguredbToolStripMenuItem.Click
        FrmData.MdiParent = Me
        FrmData.Show()

        FrmTest.MdiParent = Me
        FrmTest.Show()
    End Sub
End Class
