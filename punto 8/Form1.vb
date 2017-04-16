Public Class Form1

    Dim ar As Integer

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If usuario.Text = "chow" And contra.Text = "hola1" Then
            Form2.Show()

        Else

        End If
        If ar = 3 Then
            MsgBox("Usuario o contraseña incorrecta")
            usuario.Text = ""
            contra.Text = ""
        End If
        ar = ar + 1
        If ar >= 3 Then End
    End Sub
End Class
