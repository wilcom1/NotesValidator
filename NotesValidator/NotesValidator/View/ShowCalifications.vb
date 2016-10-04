Public Class ShowCalifications

    Private Sub ShowCalifications_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        DataGridView1.DataSource = Form1.Calificaciones
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class