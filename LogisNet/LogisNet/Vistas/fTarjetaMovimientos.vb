Public Class fTarjetaMovimientos
    Private IdEmpresa As Long
    Private idProducto As Long
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Close()
    End Sub

    Private Sub fTarjetaMovimientos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim ng As New ngBodega
        cmbBodegas.DataSource = ng.listaBodegas
        lNombre.Text = ""
        lDescripcion.Text = ""
        ng = Nothing

    End Sub

    Private Sub tRut_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tRut.KeyPress
        If Asc(e.KeyChar) = 13 Then
            cargarDatosCliente(tRut.Text)
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

    Private Sub tCodigoBarra_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tCodigoBarra.KeyPress
        If Asc(e.KeyChar) = 13 Then
            DatosProducto()
        End If
    End Sub

    Private Sub DatosProducto()
        Dim ng As New ngProducto
        Dim p As New clsProducto
        p = ng.buscarCodBarraProducto(1, tCodigoBarra.Text)
        ng = Nothing

        lDescripcion.Text = p.nombre
        idProducto = p.idProducto

        p = Nothing

    End Sub

    Private Sub tCodigoBarra_KeyUp(sender As Object, e As KeyEventArgs) Handles tCodigoBarra.KeyUp
        If e.KeyCode = Keys.F2 Then
            Dim w As New fBuscarProducto
            w.StartPosition = FormStartPosition.CenterScreen
            w.idEmpresa = Me.IdEmpresa
            w.ShowDialog()

            If w.codProducto <> Space(0) Then
                tCodigoBarra.Text = w.codBarra
                DatosProducto()
            End If
            w = Nothing
        End If
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

    Private Sub btnVer_Click(sender As Object, e As EventArgs) Handles btnVer.Click
        Grid1.BrowseOnly = False
        Grid1.ReadOnly = False
        Grid1.RowCount = 0

        Dim ng As New ngProducto
        Dim mov As New List(Of clsMovimiento)
        mov = ng.Movimientos(Me.idProducto)
        ng = Nothing
        Dim f As Long = 0
        For Each m In mov
            Grid1.RowCount += 1
            f = Grid1.RowCount
            Grid1(f, 1).CellValue = m.fecha
            Grid1(f, 2).CellValue = m.numeroMovimiento
            Grid1(f, 3).CellValue = m.numeroDocumento
            Grid1(f, 4).CellValue = m.ingreso
            Grid1(f, 5).CellValue = m.salida
            Grid1(f, 6).CellValue = 0
            Grid1(f, 7).CellValue = m.observaciones
        Next
        Grid1.BrowseOnly = True
        Grid1.ReadOnly = True

    End Sub
End Class