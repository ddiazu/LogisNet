Public Class fIngresoaBodega
    Private listaLocaciones As New List(Of clsLocacion)
    Private IdEmpresa As Integer
    Private idProducto As Long
    Private idLocacion As Long

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Close()
    End Sub

    Private Sub cmbBodegas_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbBodegas.SelectedIndexChanged
        listaLocaciones.Clear()
        Dim ng As New ngLocacion
        Dim b As New clsBodega
        b = cmbBodegas.SelectedItem
        listaLocaciones = ng.listaLocaciones(b.id)
        b = Nothing
        ng = Nothing
    End Sub

    Private Sub fIngresoaBodega_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

    Private Sub tModulo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tModulo.KeyPress
        If Asc(e.KeyChar) = 13 Then
            Dim existe As Boolean = False
            idLocacion = 0
            For Each l In listaLocaciones
                If l.pasillo.ToUpper = tPasillo.Text.ToUpper And l.modulo.ToUpper = tModulo.Text.ToUpper Then
                    idLocacion = l.idLocacion
                    existe = True
                    Exit For
                End If
            Next
            If Not existe Then
                tModulo.Text = ""
                tCantidad.Enabled = False

                MsgBox("El modulo no existe, ingrese nuevamente", vbOKOnly, "Mensaje")
                Exit Sub
            Else
                tCantidad.Enabled = True
                tCantidad.Select(0, tCantidad.Text.Length)
                tCantidad.Focus()
            End If
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
        tPasillo.Focus()
    End Sub

    Private Sub tRut_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tRut.KeyPress
        If Asc(e.KeyChar) = 13 Then

            cargarDatosCliente(tRut.Text)


        End If
    End Sub

    Private Sub tCantidad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tCantidad.KeyPress
        If Asc(e.KeyChar) = 13 Then
            If idLocacion <= 0 Then
                MsgBox("Verifique que el pasillo y modulo ingresados estén correctos", vbOKOnly, "Mensaje")
                tPasillo.Focus()
                Exit Sub
            End If
            If idProducto <= 0 Then
                MsgBox("Verifique que el codigo de barra ingresado existe.", vbOKOnly, "Mensaje")
                tCodigoBarra.Focus()
                Exit Sub
            End If

            Grid1.RowCount += 1
            Grid1.ReadOnly = False
            Grid1.BrowseOnly = False
            Dim fila As Integer = Grid1.RowCount

            Grid1(fila, 1).CellValue = tPasillo.Text
            Grid1(fila, 2).CellValue = tModulo.Text
            Grid1(fila, 3).CellValue = tCodigoBarra.Text
            Grid1(fila, 4).CellValue = lDescripcion.Text
            Grid1(fila, 5).CellValue = tCantidad.Value
            Grid1(fila, 6).CellValue = idLocacion
            Grid1(fila, 7).CellValue = idProducto

            Totales()
            Grid1.ReadOnly = True
            Grid1.BrowseOnly = True

            tPasillo.Text = ""
            tModulo.Text = ""
            tCodigoBarra.Text = ""
            lDescripcion.Text = ""
            tCantidad.Value = 1

            tCodigoBarra.Focus()

        End If
    End Sub

    Private Sub Totales()
        Dim tot As Long = 0
        For x = 1 To Grid1.RowCount
            tot += Grid1(x, 5).CellValue
        Next
        lTotal.Text = tot
    End Sub

    Private Sub tPasillo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tPasillo.KeyPress
        If Asc(e.KeyChar) = 13 Then
            tModulo.Focus()
        End If
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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim i As New clsIngreso
        i.idCliente = Me.IdEmpresa
        i.observaciones = tObservaciones.Text
        i.fecha = Format(Now(), "yyyyMMdd")
        i.numeroDocumentoIngreso = tNumDocCliente.Text

        For x = 1 To Grid1.RowCount
            Dim d As New clsDetalleDocumento
            d.pasillo = Grid1(x, 1).CellValue
            d.modulo = Grid1(x, 2).CellValue
            d.codBarra = Grid1(x, 3).CellValue
            d.descripcion = Grid1(x, 4).CellValue
            d.cantidad = Grid1(x, 5).CellValue
            d.idLocacion = Grid1(x, 6).CellValue
            d.idProducto = Grid1(x, 7).CellValue
            i.detalle.Add(d)
        Next

        Dim ng As New ngIngreso
        If ng.grabar(i) > 0 Then
            MsgBox("El ingreso ha sido grabado", vbOKOnly, "Nota")

        End If

        Grid1.ReadOnly = False
        Grid1.RowCount = 0
        Grid1.ReadOnly = True
        tRut.Text = ""
        lNombre.Text = ""
        tObservaciones.Text = ""
        tNumDocCliente.Text = ""
        lTotal.Text = 0

    End Sub
End Class