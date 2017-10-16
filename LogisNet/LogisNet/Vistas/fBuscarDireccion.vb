Public Class fBuscarDireccion
    Public codSucursal As String
    Public idDestinatario As Long
    Public direccion As String
    Public comuna As String
    Public ciudad As String
    Public idDireccion As Long

    Private Sub fBuscarDireccion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim lista As New List(Of clsDireccion)
        Dim n As New ngDirecciones
        lista = n.DestinatarioDirecciones(Me.idDestinatario)
        Grid1.BrowseOnly = False
        Grid1.ReadOnly = False
        Grid1.RowCount = 0
        Grid1.ColWidths(5) = 0

        Dim fila As Integer = 0
        For Each d In lista
            Grid1.RowCount += 1
            fila = Grid1.RowCount
            Grid1(fila, 1).CellValue = d.codSucursal
            Grid1(fila, 2).CellValue = d.direccion
            Grid1(fila, 3).CellValue = d.comuna
            Grid1(fila, 4).CellValue = d.ciudad
            Grid1(fila, 5).CellValue = d.idDireccion

        Next
        Grid1.BrowseOnly = True
        Grid1.ReadOnly = True
    End Sub

    Private Sub Grid1_DoubleClick(sender As Object, e As EventArgs) Handles Grid1.DoubleClick
        Seleccion()
    End Sub

    Private Sub Seleccion()
        Dim fila As Long = Grid1.CurrentCell.RowIndex
        Me.codSucursal = Grid1(fila, 1).CellValue
        Me.direccion = Grid1(fila, 2).CellValue
        Me.comuna = Grid1(fila, 3).CellValue
        Me.ciudad = Grid1(fila, 4).CellValue
        Me.idDireccion = Grid1(fila, 5).CellValue
        Close()

    End Sub

    Private Sub Grid1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Grid1.KeyPress
        If Asc(e.KeyChar) = 13 Then
            Seleccion()
        End If

    End Sub
End Class