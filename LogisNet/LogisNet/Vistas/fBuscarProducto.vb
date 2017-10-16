Public Class fBuscarProducto
    Public idEmpresa As Long
    Public codProducto As String
    Public codBarra As String
    Public nombre As String
    Private Sub fBuscarProducto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Grid1.BrowseOnly = False
        Grid1.ReadOnly = False
        Grid1.RowCount = 0
        Grid1.BrowseOnly = True
        Grid1.ReadOnly = True
        tNombre.Select()

    End Sub

    Private Sub tNombre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tNombre.KeyPress
        If Asc(e.KeyChar) = 13 Then
            buscarProducto(tNombre.Text)
        End If

    End Sub

    Public Sub buscarProducto(nombre As String)
        Grid1.BrowseOnly = False
        Grid1.ReadOnly = False
        Grid1.RowCount = 0
        Dim ng As New ngProducto
        Dim lista As New List(Of clsProducto)
        Dim fila As Integer
        lista = ng.buscarNombreProducto(Me.idEmpresa, nombre)

        ng = Nothing

        For Each prod In lista
            Grid1.RowCount += 1
            fila = Grid1.RowCount
            Grid1(fila, 1).CellValue = prod.codProducto
            Grid1(fila, 2).CellValue = prod.codBarra
            Grid1(fila, 3).CellValue = prod.nombre

        Next
        Grid1.BrowseOnly = True
        Grid1.ReadOnly = True
        If Grid1.RowCount > 0 Then
            Grid1.Select()
        End If
    End Sub

    Private Sub tNombre_TextChanged(sender As Object, e As EventArgs) Handles tNombre.TextChanged

    End Sub

    Private Sub Grid1_DoubleClick(sender As Object, e As EventArgs) Handles Grid1.DoubleClick
        Dim fila As Integer = Grid1.CurrentCell.RowIndex
        If fila > 0 Then

            Me.codProducto = Grid1(fila, 1).CellValue
            Me.codBarra = Grid1(fila, 2).CellValue
            Me.nombre = Grid1(fila, 3).CellValue
            Close()
        End If
    End Sub
End Class