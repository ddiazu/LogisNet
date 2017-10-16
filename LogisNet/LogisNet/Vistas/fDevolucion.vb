Public Class fDevolucion
    Private listaLocaciones As New List(Of clsLocacion)
    Private IdEmpresa As Integer
    Private idProducto As Long
    Private idLocacion As Long
    Private idDireccion As Long


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Close()
    End Sub

    Private Sub fDevolucion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim ng As New ngBodega
        cmbBodegas.DataSource = ng.listaBodegas
        lNombre.Text = ""
        lDescripcion.Text = ""
        Grid1.RowCount = 0
        Grid1.ReadOnly = True
        Grid1.BrowseOnly = True
        Grid1.ColWidths(6) = 0
        Grid1.ColWidths(7) = 0
        ng = Nothing
    End Sub

    Private Sub tRut_KeyUp(sender As Object, e As KeyEventArgs) Handles tRut.KeyUp
        If e.KeyCode = Keys.F2 Then
            Dim w As New fBuscarCliente
            w.StartPosition = FormStartPosition.CenterScreen
            w.ShowDialog()
            If w.rut <> Space(0) Then
                tRut.Text = w.rut
                cargarDatosCliente(w.rut)
            End If
            w = Nothing
        End If
    End Sub
    Private Sub cargarDatosCliente(rut As String)
        Dim ng As New ngEmpresa
        Dim emp As New clsCliente
        emp = ng.DatosEmpresa(rut)
        If emp.id > 0 Then
            IdEmpresa = emp.id
            lNombre.Text = emp.razonsocial
            ng = Nothing
            emp = Nothing
        End If
    End Sub

    Private Sub tRutLibreria_KeyUp(sender As Object, e As KeyEventArgs) Handles tRutLibreria.KeyUp
        If e.KeyCode = Keys.F2 Then
            Dim w As New fBuscarDestintario
            w.StartPosition = FormStartPosition.CenterScreen
            w.idEmpresa = Me.IdEmpresa
            w.ShowDialog()

            If w.idDestinatario > 0 Then
                lNombreLibreria.Text = w.razonSocial
                tRutLibreria.Text = w.rut
                Dim ws As New fBuscarDireccion
                ws.StartPosition = FormStartPosition.CenterScreen
                ws.idDestinatario = w.idDestinatario
                ws.ShowDialog()
                If ws.direccion <> "" Then
                    tDireccion.Text = ws.direccion
                    tComuna.Text = ws.comuna
                    tCiudad.Text = ws.ciudad
                    Me.idDireccion = ws.idDireccion
                End If
                ws = Nothing
            End If
            w = Nothing
        End If
    End Sub
End Class