Imports System.Net

Public Class Form1
    Private Sub AbrirFrom(from As Object)
        If containerpanel.Controls.Count > 0 Then containerpanel.Controls.RemoveAt(0)
        Dim fh As System.Windows.Forms.Form = TryCast(from, System.Windows.Forms.Form)
        fh.TopLevel = False
        fh.Dock = System.Windows.Forms.DockStyle.Fill
        containerpanel.Controls.Add(fh)
        containerpanel.Tag = fh
        fh.Show()


    End Sub

    Private Sub UndirectedBtn_Click(sender As Object, e As EventArgs) Handles UndirectedBtn.Click
        AbrirFrom(New Undirected())
    End Sub

    Private Sub Directed_Click(sender As Object, e As EventArgs) Handles Directed.Click
        AbrirFrom(New Directed())
    End Sub

    Private Sub button3_Click(sender As Object, e As EventArgs) Handles button3.Click
        AbrirFrom(New BFS())
    End Sub

    Private Sub button4_Click(sender As Object, e As EventArgs) Handles button4.Click
        AbrirFrom(New DFS())
    End Sub
End Class
