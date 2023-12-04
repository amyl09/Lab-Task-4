'AMYLIANA DARA BT MOHAMMAD
'20DDT21F2006

Public Class about

    Private Sub SoftwareToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles SoftwareToolStripMenuItem.Click
        author.Show()
        Me.Hide()
    End Sub

    Private Sub HomeToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles HomeToolStripMenuItem.Click
        homee.Show()
        Me.Hide()
    End Sub

    Private Sub ExitToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub CRUDAuthorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CRUDAuthorToolStripMenuItem.Click
        author.Show()
        Me.Hide()

    End Sub
End Class