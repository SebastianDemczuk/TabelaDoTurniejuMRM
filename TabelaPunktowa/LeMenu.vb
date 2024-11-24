Public Class LeMenu
    Private Sub LeMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TabControl1.TabPages.Add(PointTable)
    End Sub

    Private Sub OProgramieItem_Click(sender As Object, e As EventArgs) Handles OProgramieItem.Click
        Info.Show()
    End Sub

    Private Sub OtwórzTabelkeItem_Click(sender As Object, e As EventArgs)
        Dim NewPointTable As New PointTable
        TabControl1.TabPages.Add(NewPointTable)
    End Sub

    Private Sub RozpocznikToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub UstawieniaDlaGościaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UstawieniaDlaGościaToolStripMenuItem.Click

    End Sub

    Private Sub UstawieniaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UstawieniaToolStripMenuItem.Click

    End Sub
End Class
