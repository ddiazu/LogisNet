Public Class fMenuPrincipal

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        End

    End Sub

    Private Sub EmpresadsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EmpresadsToolStripMenuItem.Click
        Dim w As New fEmpresas

        w.StartPosition = FormStartPosition.CenterScreen
        w.ShowDialog()
        w = Nothing
    End Sub

    Private Sub IngresoDePedidosDeClientesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IngresoDePedidosDeClientesToolStripMenuItem.Click
        Dim w As New fIngresoPedidos
        w.StartPosition = FormStartPosition.CenterScreen
        w.ShowDialog()
        w = Nothing

    End Sub

    Private Sub IngresoDeProductosABodegaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IngresoDeProductosABodegaToolStripMenuItem.Click
        Dim w As New fIngresoaBodega

        w.StartPosition = FormStartPosition.CenterScreen
        w.ShowDialog()
        w = Nothing
    End Sub

    Private Sub BodegasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BodegasToolStripMenuItem.Click
        Dim w As New fBodegas
        w.StartPosition = FormStartPosition.CenterScreen
        w.ShowDialog()
        w = Nothing
    End Sub

    Private Sub LocacionesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LocacionesToolStripMenuItem.Click
        Dim w As New fLocaciones

        w.StartPosition = FormStartPosition.CenterScreen
        w.ShowDialog()
        w = Nothing
    End Sub

    Private Sub SalidaDeProductosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalidaDeProductosToolStripMenuItem.Click
        Dim w As New fSalidaBodega
        w.StartPosition = FormStartPosition.CenterScreen
        w.ShowDialog()
        w = Nothing
    End Sub

    Private Sub fMenuPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TarjetaDeMovimientosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TarjetaDeMovimientosToolStripMenuItem.Click
        Dim w As New fTarjetaMovimientos
        w.Show()

    End Sub

    Private Sub StockEnBodegaPorClienteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StockEnBodegaPorClienteToolStripMenuItem.Click
        Dim w As New fStockClienteBodega

        w.Show()

    End Sub

    Private Sub StockEnBodegaPorClienteDetalladoPorLocaciónToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StockEnBodegaPorClienteDetalladoPorLocaciónToolStripMenuItem.Click
        Dim w As New fStockClienteDetallado

        w.Show()
    End Sub

    Private Sub DevoluciónToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DevoluciónToolStripMenuItem.Click
        Dim w As New fDevolucion

        w.Show()

    End Sub
End Class