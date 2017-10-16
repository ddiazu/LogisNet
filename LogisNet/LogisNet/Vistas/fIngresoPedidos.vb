Imports System.IO

Public Class fIngresoPedidos
    Private idEmpresa As Long
    Private idProducto As Long
    Private idDireccion As Long

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        OpenFileDialog1.ShowDialog()
        If OpenFileDialog1.FileName <> "" Then
            If File.Exists(OpenFileDialog1.FileName) Then
                LeerArchivoPedido(OpenFileDialog1.FileName)
            Else
                MsgBox("El nombre de archivo ingresado no existe en la ruta especificada", vbOKOnly, "Mensaje")

            End If


        End If

    End Sub


    Private Sub LeerArchivoPedido(nombreArchivo As String)
        Dim f As New StreamReader(nombreArchivo)
        Dim linea As String
        Dim Cont As Integer = 0
        Dim p As New clsPedidoCliente
        Do
            linea = f.ReadLine()
            If Not linea Is Nothing Then
                Cont = Cont + 1
                If Cont = 1 Then 'Rut Cliente
                    p.rutCliente = linea
                ElseIf Cont = 2 Then
                    p.codigoDestinatario = linea
                End If
            End If
        Loop Until linea Is Nothing
        f.Close()

    End Sub

    Private Sub fIngresoPedidos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Grid1.ColWidths(5) = 0
        Grid1.Width = 800
        Grid1.RowCount = 0

        cmbTipoDocumento.SelectedIndex = 0


    End Sub

    Private Sub tRutCliente_KeyUp(sender As Object, e As KeyEventArgs) Handles tRutCliente.KeyUp
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

    Private Sub tRutCliente_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tRutCliente.KeyPress
        If Asc(e.KeyChar) = 13 Then

            cargarDatosCliente(tRutCliente.Text)


        End If
    End Sub

    Private Sub tCodigoBarra_KeyUp(sender As Object, e As KeyEventArgs) Handles tCodigoBarra.KeyUp
        If e.KeyCode = Keys.F2 Then
            Dim w As New fBuscarProducto
            w.StartPosition = FormStartPosition.CenterScreen
            w.idEmpresa = Me.idEmpresa
            w.ShowDialog()

            If w.codProducto <> Space(0) Then
                tCodigoBarra.Text = w.codBarra
                DatosProducto()
            End If
            w = Nothing
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
            tCantidad.Focus()
        End If
        p = Nothing

    End Sub

    Private Sub tCodigoBarra_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tCodigoBarra.KeyPress
        If Asc(e.KeyChar) = 13 Then
            DatosProducto()
        End If
    End Sub

    Private Sub tCantidad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tCantidad.KeyPress
        If Asc(e.KeyChar) = 13 Then
            If tCantidad.Value >= 0 Then

                Dim ng As New ngProducto

                Dim stockLocaciones As List(Of clsStock) = ng.Producto_Stock_Despacho(idProducto)

                Dim stock As Long = 0

                For Each i In stockLocaciones
                    stock += i.Cantidad
                Next
                Dim cantidadAceptada As Long = 0
                If stock <= 0 Then
                    MsgBox("No hay stock en bodega para este producto", vbOKOnly, "Mensaje")
                    Exit Sub
                End If
                Dim f As Integer = 0
                Grid1.ReadOnly = False
                Grid1.BrowseOnly = False

                For x = 1 To Grid1.RowCount
                    If Grid1(x, 1).CellValue = tCodigoBarra.Text Then
                        f = x
                        Exit For
                    End If
                Next

                If f = 0 Then
                    Grid1.RowCount += 1
                    f = Grid1.RowCount
                Else
                    If MsgBox("El producto ya se encuentra en la lista, ¿Desea reemplazar las cantidades?", vbYesNo, "Consulta") = MsgBoxResult.No Then
                        Exit Sub
                    End If
                End If


                If stock < tCantidad.Value Then
                    MsgBox("La cantidad de solicitada es mayor al stock disponible", vbOKOnly, "Mensaje")
                    cantidadAceptada = stock
                Else
                    cantidadAceptada = tCantidad.Value
                End If


                Grid1(f, 1).CellValue = tCodigoBarra.Text
                Grid1(f, 2).CellValue = lDescripcion.Text
                Grid1(f, 3).CellValue = tCantidad.Value
                Grid1(f, 4).CellValue = cantidadAceptada
                Grid1(f, 5).CellValue = Me.idProducto


                tCodigoBarra.Text = ""
                tCantidad.Value = 1
                lDescripcion.Text = ""

                tCodigoBarra.Focus()
                Grid1.ReadOnly = True
                Grid1.BrowseOnly = True

            End If

        End If
    End Sub

    Private Sub BtnCrearPicking_Click(sender As Object, e As EventArgs) Handles BtnCrearPicking.Click
        If tRutCliente.Text <> "" And
           tRutDestinatario.Text <> "" And
           tNumeroPedido.Text <> "" And
           Grid1.RowCount > 0 And
           tComuna.Text <> "" And
           tCiudad.Text <> "" And
           lNombreCliente.Text And
           lNombreDestinatario.Text <> "" Then

            GrabarPedido()

        End If
    End Sub

    Private Sub GrabarPedido()

    End Sub

    Private Sub tRutDestinatario_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tRutDestinatario.KeyPress
        If Asc(e.KeyChar) = 13 Then
            Dim d As New clsDestinatario
            Dim n As New ngDestinatario
            d = n.DatosDestinatarioporRut(Me.idEmpresa, tRutDestinatario.Text)

            If d.codCliente <> "" Then
                lNombreDestinatario.Text = d.razonSocial
            End If

            n = Nothing


        End If
    End Sub

    Private Sub tRutDestinatario_KeyUp(sender As Object, e As KeyEventArgs) Handles tRutDestinatario.KeyUp
        If e.KeyCode = Keys.F2 Then
            Dim w As New fBuscarDestintario
            w.StartPosition = FormStartPosition.CenterScreen
            w.idEmpresa = Me.idEmpresa
            w.ShowDialog()

            If w.idDestinatario > 0 Then
                lNombreDestinatario.Text = w.razonSocial
                tRutDestinatario.Text = w.rut
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

    Private Sub tRutDestinatario_TextChanged(sender As Object, e As EventArgs) Handles tRutDestinatario.TextChanged

    End Sub

    Private Sub Grid1_KeyUp(sender As Object, e As KeyEventArgs) Handles Grid1.KeyUp
        If e.KeyCode = Keys.Delete Then
            If MsgBox("¿Elimina la fila seleccionada?", vbYesNo, "Consulta") = vbYes Then
                Grid1.Rows.RemoveRange(Grid1.CurrentCell.RowIndex, Grid1.CurrentCell.RowIndex)
            End If
        End If
    End Sub
End Class