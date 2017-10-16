Public Class fStockClienteDetallado
    Private IdEmpresa As Long
    Private idBodega As Long
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Close()
    End Sub

    Private Sub fStockClienteDetallado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim ng As New ngBodega
        cmbBodegas.DataSource = ng.listaBodegas
        lNombre.Text = ""
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
        Dim b As New clsBodega
        b = cmbBodegas.SelectedItem
        Dim n As New ngProducto
        Dim lista As New List(Of clsStock)
        Grid1.BrowseOnly = False
        Grid1.ReadOnly = False
        Grid1.RowCount = 0
        lista = n.stockClienteBodegaDetallado(Me.IdEmpresa, b.id)
        n = Nothing
        Dim f As Long = 0
        For Each m In lista
            Grid1.RowCount += 1
            f = Grid1.RowCount
            Grid1(f, 1).CellValue = m.codProducto
            Grid1(f, 2).CellValue = m.codBarra
            Grid1(f, 3).CellValue = m.nombre
            Grid1(f, 4).CellValue = m.Pasillo + "-" + m.Modulo
            Grid1(f, 5).CellValue = m.Cantidad
        Next
        Grid1.BrowseOnly = True
        Grid1.ReadOnly = True
    End Sub


End Class