Public Class fAcceso

    Private Sub btnIngreso_Click(sender As Object, e As EventArgs) Handles btnIngreso.Click
        Dim w As New fMenuPrincipal
        w.WindowState = FormWindowState.Maximized
        w.Show()
        Me.Hide()
    End Sub

    Private Sub fAcceso_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarParametros(1)
        AbrirConexion()
        CerrarConexion()
        tUsuario.Text = "adminis"
        tClave.Text = "itsoft802"

    End Sub

    Private Sub tUsuario_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tUsuario.KeyPress
        If Asc(e.KeyChar) = 13 Then
            tClave.Focus()

        End If
    End Sub

    Private Sub tClave_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tClave.KeyPress
        If Asc(e.KeyChar) = 13 Then
            btnIngreso.Focus()

        End If
    End Sub
End Class