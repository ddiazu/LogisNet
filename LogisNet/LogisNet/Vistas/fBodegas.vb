Public Class fBodegas
    Private IdBodega As Integer = 0
    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Close()
    End Sub

    Private Sub fBodegas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim ng As New ngBodega
        Dim lista As New List(Of clsBodega)

        lista = ng.listaBodegas


        ng = Nothing
        Dim fila As Integer = 0
        GridEditable(grid1, True)
        grid1.RowCount = 0
        For Each b In lista
            grid1.RowCount += 1
            fila = grid1.RowCount
            grid1(fila, 1).CellValue = b.id
            grid1(fila, 2).CellValue = b.codigoBodega
            grid1(fila, 3).CellValue = b.nombre
            grid1(fila, 4).CellValue = b.admiteDespacho

        Next
        GridEditable(grid1, False)
    End Sub

    Private Sub btnGrabar_Click(sender As Object, e As EventArgs) Handles btnGrabar.Click
        If Not tCodigo.Text <> Space(0) Then
            MsgBox("El codigo es obligatorio", vbOKOnly, "Advertencia")
            Exit Sub
        End If
        If Not tNombre.Text <> Space(0) Then
            MsgBox("El nombre es obligatorio", vbOKOnly, "Advertencia")
            Exit Sub
        End If

        Dim b As New clsBodega
        b.id = IdBodega
        b.codigoBodega = tCodigo.Text
        b.nombre = tNombre.Text
        b.admiteDespacho = chkAdmiteDespacho.Checked

        Dim ng As New ngBodega

        b.id = ng.Guardar(b)

        ng = Nothing

        Dim fila As Integer = 0
        For x = 1 To grid1.RowCount
            If grid1(x, 1).CellValue = b.id Then
                fila = x
                Exit For
            End If
        Next
        If fila = 0 Then
            grid1.RowCount += 1
            fila = grid1.RowCount
        End If
        GridEditable(grid1, True)
        grid1(fila, 1).CellValue = b.id
        grid1(fila, 2).CellValue = b.codigoBodega
        grid1(fila, 3).CellValue = b.nombre
        grid1(fila, 4).CellValue = b.admiteDespacho

        GridEditable(grid1, False)

    End Sub

    Private Sub grid1_CellDoubleClick(sender As Object, e As Syncfusion.Windows.Forms.Grid.GridCellClickEventArgs) Handles grid1.CellDoubleClick
        Dim fila As Integer = grid1.CurrentCell.RowIndex
        If fila > 0 Then
            IdBodega = grid1(fila, 1).CellValue
            tCodigo.Text = grid1(fila, 2).CellValue
            tNombre.Text = grid1(fila, 3).CellValue
            chkAdmiteDespacho.Checked = grid1(fila, 4).CellValue

            tCodigo.Focus()
        End If
    End Sub
End Class