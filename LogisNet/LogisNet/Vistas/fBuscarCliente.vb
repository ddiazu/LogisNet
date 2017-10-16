Public Class fBuscarCliente

    Public rut As String

    Private Sub fBuscarCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Grid1.BrowseOnly = False
        Grid1.ReadOnly = False
        Grid1.RowCount = 0
        Dim ng As New ngEmpresa
        Dim lista As New List(Of clsCliente)
        Dim fila As Integer
        lista = ng.listaEmpresas

        ng = Nothing

        For Each emp In lista
            Grid1.RowCount += 1
            fila = Grid1.RowCount
            Grid1(fila, 1).CellValue = emp.rut
            Grid1(fila, 2).CellValue = emp.razonsocial
        Next
        Grid1.BrowseOnly = True
        Grid1.ReadOnly = True

    End Sub

    Private Sub Grid1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Grid1.KeyPress
        Dim fila As Integer = Grid1.CurrentCell.RowIndex
        If Asc(e.KeyChar) = 13 And fila > 0 Then
            Me.rut = Grid1(fila, 1).CellValue
            Close()

        End If
    End Sub

    Private Sub Grid1_DoubleClick(sender As Object, e As EventArgs) Handles Grid1.DoubleClick
        Dim fila As Integer = Grid1.CurrentCell.RowIndex
        If fila > 0 Then
            Me.rut = Grid1(fila, 1).CellValue
            Close()
        End If
    End Sub
End Class