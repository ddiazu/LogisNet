Public Class fSalidaBodega
    Private listaLocaciones As New List(Of clsLocacion)
    Private IdEmpresa As Integer
    Private idProducto As Long
    Private idLocacion As Long
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Close()
    End Sub

    Private Sub fSalidaBodega_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim ng As New ngBodega
        cmbBodegas.DataSource = ng.listaBodegas
        ng = Nothing
        lNombreCliente.Text = ""
        lDescripcion.Text = ""
        tPasillo.Text = ""
        tModulo.Text = ""
        Grid1.RowCount = 0
        Grid1.ColWidths(6) = 0
        Grid1.ColWidths(7) = 0
    End Sub

    Private Sub tRutCliente_KeyUp(sender As Object, e As KeyEventArgs) Handles tRutCliente.KeyUp
        If e.KeyCode = Keys.F2 Then
            If e.KeyCode = Keys.F2 Then
                Dim w As New fBuscarCliente
                w.StartPosition = FormStartPosition.CenterScreen
                w.ShowDialog()
                If w.rut <> Space(0) Then
                    tRutCliente.Text = w.rut
                    cargarDatosCliente(w.rut)
                End If
                w = Nothing
            End If
        End If
    End Sub
    Private Sub DatosProducto()
        Dim ng As New ngProducto
        Dim p As New clsProducto
        p = ng.buscarCodBarraProducto(1, tCodigoBarra.Text)
        ng = Nothing

        lDescripcion.Text = p.nombre
        idProducto = p.idProducto
        If p.idProducto > 0 Then
            tPasillo.Focus()
        End If
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
    Private Sub cargarDatosCliente(rut As String)
        Dim ng As New ngEmpresa
        Dim emp As New clsCliente
        emp = ng.DatosEmpresa(rut)
        If emp.id > 0 Then
            IdEmpresa = emp.id
            lNombreCliente.Text = emp.razonsocial
            ng = Nothing
            emp = Nothing
        End If
    End Sub

    Private Sub tCodigoBarra_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tCodigoBarra.KeyPress
        If Asc(e.KeyChar) = 13 Then
            DatosProducto()
        End If
    End Sub

    Private Sub tRutCliente_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tRutCliente.KeyPress
        If Asc(e.KeyChar) = 13 Then
            cargarDatosCliente(tRutCliente.Text)

        End If
    End Sub

    Private Sub tPasillo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tPasillo.KeyPress
        If Asc(e.KeyChar) = 13 Then
            tModulo.Focus()
        End If
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

    Private Sub cmbBodegas_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbBodegas.SelectedIndexChanged
        listaLocaciones.Clear()
        Dim ng As New ngLocacion
        Dim b As New clsBodega
        b = cmbBodegas.SelectedItem
        listaLocaciones = ng.listaLocaciones(b.id)
        b = Nothing
        ng = Nothing
    End Sub

    Private Sub tCantidad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tCantidad.KeyPress
        If Asc(e.KeyChar) = 13 Then
            If tCantidad.Value >= 0 Then

                Dim ng As New ngProducto

                Dim stock As Long = ng.Producto_Stock_Locacion(idProducto, idLocacion)

                If stock < tCantidad.Value Then
                    MsgBox("La cantidad de salidad es superior al stock de la locacion indicada", vbOKOnly, "Mensaje")
                    Exit Sub
                End If

                Grid1.ReadOnly = False
                Grid1.BrowseOnly = False

                Grid1.RowCount += 1
                Dim f As Integer = Grid1.RowCount
                Grid1(f, 1).CellValue = tPasillo.Text
                Grid1(f, 2).CellValue = tModulo.Text
                Grid1(f, 3).CellValue = tCodigoBarra.Text
                Grid1(f, 4).CellValue = lDescripcion.Text
                Grid1(f, 5).CellValue = tCantidad.Value
                Grid1(f, 6).CellValue = Me.idLocacion
                Grid1(f, 7).CellValue = Me.idProducto

                tPasillo.Text = ""
                tCodigoBarra.Text = ""
                tModulo.Text = ""
                tCantidad.Value = 0
                lDescripcion.Text = ""

                tCodigoBarra.Focus()
                Grid1.ReadOnly = True
                Grid1.BrowseOnly = True

            End If

        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim i As New clsSalida
        i.idCliente = Me.IdEmpresa
        i.numeroDocumentoSalida = 0
        i.observaciones = tObservaciones.Text
        i.fecha = Format(Now(), "yyyyMMdd")
        i.estado = 1
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
        Dim ng As New ngSalida

        ng.grabar(i)

        ng = Nothing

        MsgBox("La salida ha sido registrada", vbOKOnly, "Mensaje")

        Grid1.ReadOnly = False
        Grid1.BrowseOnly = False
        Grid1.RowCount = 0
        Grid1.ReadOnly = True
        Grid1.BrowseOnly = True

        tRutCliente.Text = ""
        lNombreCliente.Text = ""
        tObservaciones.Text = ""
        tNumDocCliente.Text = ""


        tRutCliente.Focus()


    End Sub


End Class