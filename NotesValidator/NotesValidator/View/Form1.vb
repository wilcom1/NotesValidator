Public Class Form1
    Public Calificaciones(10) As Student

    Private Sub SalirToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles SalirToolStripMenuItem.Click
        End
    End Sub

    Private Sub RegistrarNotasToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles RegistrarNotasToolStripMenuItem.Click
        RegisterForm.Show()
    End Sub

    Private Sub ConsultarNotasToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ConsultarNotasToolStripMenuItem.Click
        ShowCalifications.Show()
    End Sub

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Label1.Text = System.String.Format(Label1.Text, My.Application.Info.Version.Major, My.Application.Info.Version.Minor)
    End Sub
End Class
