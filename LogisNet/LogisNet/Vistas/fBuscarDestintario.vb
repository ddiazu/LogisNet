Public Class fBuscarDestintario
    Public idEmpresa As Long
    Public idDestinatario As Long
    Public razonSocial As String
    Public rut As String
    Public codCliente As String

    Private Sub fBuscarDestintario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Grid1.RowCount = 0
        Grid1.ColWidths(4) = 0
        tNombre.Select()
    End Sub

    Private Sub buscarDestinatarios()
        Dim lista As New List(Of clsDestinatario)
        Dim n As New ngDestinatario
        lista = n.listaDestinatarios(Me.idEmpresa, tNombre.Text)
        Grid1.BrowseOnly = False
        Grid1.ReadOnly = False
        Grid1.RowCount = 0
        Dim fila As Integer = 0
        For Each d In lista
            Grid1.RowCount += 1
            fila = Grid1.RowCount
            Grid1(fila, 1).CellValue = d.rut
            Grid1(fila, 2).CellValue = d.razonSocial
            Grid1(fila, 3).CellValue = d.codCliente
            Grid1(fila, 4).CellValue = d.idDestinatario

        Next
        Grid1.BrowseOnly = True
        Grid1.ReadOnly = True
    End Sub

    Private Sub tNombre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tNombre.KeyPress
        If Asc(e.KeyChar) = 13 Then
            buscarDestinatarios()

        End If
    End Sub

    Private Sub Grid1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Grid1.KeyPress
        If Asc(e.KeyChar) = 13 Then
            seleccion()

        End If
    End Sub

    Private Sub seleccion()
        Dim fila As Long = Grid1.CurrentCell.RowIndex
        Me.idDestinatario = Grid1(fila, 4).CellValue
        Me.rut = Grid1(fila, 1).CellValue
        Me.razonSocial = Grid1(fila, 2).CellValue
        Me.codCliente = Grid1(fila, 3).CellValue
        Close()
    End Sub

    Private Sub Grid1_DoubleClick(sender As Object, e As EventArgs) Handles Grid1.DoubleClick
        seleccion()

    End Sub
End Class