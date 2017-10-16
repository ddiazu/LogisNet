Public Class fEmpresas
    Private IdEmpresa As Integer = 0
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Close()
    End Sub

    Private Sub fEmpresas_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim ng As New ngEmpresa
        Dim lista As New List(Of clsCliente)

        lista = ng.listaEmpresas

        ng = Nothing
        Dim fila As Integer = 0
        GridEditable(gEmpresas, True)
        gEmpresas.RowCount = 0
        For Each emp In lista
            gEmpresas.RowCount += 1
            fila = gEmpresas.RowCount
            gEmpresas(fila, 1).CellValue = emp.id
            gEmpresas(fila, 2).CellValue = emp.rut
            gEmpresas(fila, 3).CellValue = emp.razonsocial
            gEmpresas(fila, 4).CellValue = emp.giro
        Next
        GridEditable(gEmpresas, False)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnGrabar.Click
        If Not tRut.Text <> Space(0) Then
            MsgBox("El rut es obligatorio", vbOKOnly, "Advertencia")
            Exit Sub
        End If
        If Not tRazonSocial.Text <> Space(0) Then
            MsgBox("La razon social es obligatoria", vbOKOnly, "Advertencia")
            Exit Sub
        End If

        Dim emp As New clsCliente
        emp.id = IdEmpresa
        emp.rut = tRut.Text
        emp.razonsocial = tRazonSocial.Text


        Dim ng As New ngEmpresa

        emp.id = ng.Guardar(emp)

        ng = Nothing

        Dim fila As Integer = 0
        For x = 1 To gEmpresas.RowCount
            If gEmpresas(x, 1).CellValue = emp.id Then
                fila = x
                Exit For
            End If
        Next
        If fila = 0 Then
            gEmpresas.RowCount += 1
            fila = gEmpresas.RowCount
        End If
        GridEditable(gEmpresas, True)
        gEmpresas(fila, 1).CellValue = emp.id
        gEmpresas(fila, 2).CellValue = emp.rut
        gEmpresas(fila, 3).CellValue = emp.razonsocial
        GridEditable(gEmpresas, False)
        tRut.Text = ""
        tRazonSocial.Text = ""
        IdEmpresa = 0

    End Sub

    Private Sub gEmpresas_CellDoubleClick(sender As Object, e As Syncfusion.Windows.Forms.Grid.GridCellClickEventArgs) Handles gEmpresas.CellDoubleClick
        Dim fila As Integer = gEmpresas.CurrentCell.RowIndex
        If fila > 0 Then
            tRut.Text = gEmpresas(fila, 2).CellValue
            tRazonSocial.Text = gEmpresas(fila, 3).CellValue
            IdEmpresa = gEmpresas(fila, 1).CellValue
            tRut.Focus()
        End If
    End Sub
End Class
