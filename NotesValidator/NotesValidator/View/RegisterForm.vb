Public Class RegisterForm
    Private Calificaciones(10) As Student
    Private i As Integer
    Private student As Student

    Private Sub RegisterForm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Label4.Text = "Ingrese los datos del estudiante 1"
        i = 0
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim ValidaCalificacion(2) As String
        Dim validate As Boolean
        validate = Validar_Campos()
        If Not validate Then
            MsgBox("La información de los campos editables es incorrecta", MsgBoxStyle.OkOnly, "Atención")
            Exit Sub
        End If
        student = New Student
        student.nombre = TextBox1.Text
        student.apellido = TextBox2.Text
        student.nota = CDbl(NumericUpDown1.Value)
        ValidaCalificacion = Valida_Calificacion(CDbl(NumericUpDown1.Value))
        student.estado = ValidaCalificacion(0)
        student.calificacion = ValidaCalificacion(1)
        Calificaciones(i) = student
        ToolStripProgressBar1.Value = (i + 1) * 10
        ToolStripStatusLabel1.Text = "Calificaciones Ingresadas: " + (i + 1).ToString
        If i = 9 Then
            Form1.Calificaciones = Me.Calificaciones
            MsgBox("Se han guardado todas las calificaciones")
            Me.Close()
        End If
        i = i + 1
        Label4.Text = "Ingrese los datos del estudiante " + (i + 1).ToString
    End Sub

    Private Sub Clean_Fields()
        TextBox1.Text = ""
        TextBox2.Text = ""
        NumericUpDown1.Value = 0
    End Sub

    Function Valida_Calificacion(Nota As Double)
        Dim Resultado(2) As String
        If Nota > 400 Then
            Resultado(0) = "Aprueba"
            Resultado(1) = "Excelente"
            Return Resultado
        End If
        If Nota > 350 And Nota <= 400 Then
            Resultado(0) = "Aprueba"
            Resultado(1) = "Aceptable"
            Return Resultado
        End If
        If Nota > 300 And Nota <= 350 Then
            Resultado(0) = "Aprueba"
            Resultado(1) = "Regular"
            Return Resultado
        End If
        If Nota > 250 And Nota <= 300 Then
            Resultado(0) = "Pierde"
            Resultado(1) = "Bajo - Alto"
            Return Resultado
        End If
        If Nota > 200 And Nota <= 250 Then
            Resultado(0) = "Pierde"
            Resultado(1) = "Bajo - Medio"
            Return Resultado
        End If
        If Nota >= 0 And Nota <= 200 Then
            Resultado(0) = "Pierde"
            Resultado(1) = "Bajo - Bajo"
            Return Resultado
        End If
        Return Resultado
    End Function

    Function Validar_Campos()
        If TextBox1.Text.Length <= 0 Then
            Return False
        End If
        If TextBox2.Text.Length <= 0 Then
            Return False
        End If
        Return True
    End Function

    Private Sub TextBox1_KeyDown(ByVal sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        End If
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox2_KeyDown(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox2.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        End If
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
End Class