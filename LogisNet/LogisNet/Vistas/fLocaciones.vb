Public Class fLocaciones
    Private IdLocacion As Long = 0
    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Close()
    End Sub

    Private Sub btnListar_Click(sender As Object, e As EventArgs) Handles btnListar.Click
        GridEditable(Grid1, True)

        Dim ng As New ngLocacion
        Dim lista As New List(Of clsLocacion)
        Dim b As New clsBodega
        b = cmbBodegas.SelectedItem
        lista = ng.listaLocaciones(b.id)
        b = Nothing
        ng = Nothing

        Grid1.RowCount = 0
        Dim fila As Integer = 0
        For Each l In lista
            Grid1.RowCount += 1
            fila = Grid1.RowCount
            Grid1(fila, 1).CellValue = l.idLocacion
            Grid1(fila, 2).CellValue = l.pasillo
            Grid1(fila, 3).CellValue = l.modulo
        Next

        GridEditable(Grid1, False)

        tPasillo.Text = ""
        tModulo.Text = ""
        tPasillo.Focus()

    End Sub

    Private Sub fLocaciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim ng As New ngBodega
        cmbBodegas.DataSource = ng.listaBodegas
        ng = Nothing



    End Sub

    Private Sub tPasillo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tPasillo.KeyPress
        If Asc(e.KeyChar) = 13 Then
            tModulo.Focus()
        End If
    End Sub


    Private Sub tModulo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tModulo.KeyPress
        If Asc(e.KeyChar) = 13 Then
            Dim b As New clsBodega
            b = cmbBodegas.SelectedItem
            Dim l As New clsLocacion
            l.idLocacion = idLocacion
            l.idBodega = b.id
            l.pasillo = tPasillo.Text
            l.modulo = tModulo.Text
            Dim ng As New ngLocacion
            l.idLocacion = ng.grabar(l)
            ng = Nothing

            Dim fila As Integer = 0
            For x = 1 To Grid1.RowCount
                If Grid1(x, 1).CellValue = l.idLocacion Then
                    fila = x
                    Exit For
                End If
            Next
            If fila = 0 Then
                Grid1.RowCount += 1
                fila = Grid1.RowCount
            End If

            GridEditable(Grid1, True)
            Grid1(fila, 1).CellValue = l.idLocacion
            Grid1(fila, 2).CellValue = l.pasillo
            Grid1(fila, 3).CellValue = l.modulo
            GridEditable(Grid1, False)
            IdLocacion = 0
            tModulo.Text = ""
            tModulo.Focus()

        End If
    End Sub

    Private Sub Grid1_CellDoubleClick(sender As Object, e As Syncfusion.Windows.Forms.Grid.GridCellClickEventArgs) Handles Grid1.CellDoubleClick
        Dim Fila As Integer = Grid1.CurrentCell.RowIndex

        If Fila > 0 Then
            IdLocacion = Grid1(Fila, 1).CellValue
            tPasillo.Text = Grid1(Fila, 2).CellValue
            tModulo.Text = Grid1(Fila, 3).CellValue

            tPasillo.Focus()

        End If
    End Sub
End Class