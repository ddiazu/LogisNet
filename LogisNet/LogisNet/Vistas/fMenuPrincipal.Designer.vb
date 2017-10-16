<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fMenuPrincipal
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ArchivoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EmpresadsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BodegasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LocacionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProcesosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IngresoDeProductosABodegaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IngresoDePedidosDeClientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalidaDeProductosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DevoluciónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InformesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TarjetaDeMovimientosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.StockEnBodegaPorClienteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StockEnBodegaPorClienteDetalladoPorLocaciónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArchivoToolStripMenuItem, Me.ProcesosToolStripMenuItem, Me.InformesToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(723, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ArchivoToolStripMenuItem
        '
        Me.ArchivoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EmpresadsToolStripMenuItem, Me.BodegasToolStripMenuItem, Me.LocacionesToolStripMenuItem})
        Me.ArchivoToolStripMenuItem.Name = "ArchivoToolStripMenuItem"
        Me.ArchivoToolStripMenuItem.Size = New System.Drawing.Size(60, 20)
        Me.ArchivoToolStripMenuItem.Text = "Archivo"
        '
        'EmpresadsToolStripMenuItem
        '
        Me.EmpresadsToolStripMenuItem.Name = "EmpresadsToolStripMenuItem"
        Me.EmpresadsToolStripMenuItem.Size = New System.Drawing.Size(133, 22)
        Me.EmpresadsToolStripMenuItem.Text = "Empresas"
        '
        'BodegasToolStripMenuItem
        '
        Me.BodegasToolStripMenuItem.Name = "BodegasToolStripMenuItem"
        Me.BodegasToolStripMenuItem.Size = New System.Drawing.Size(133, 22)
        Me.BodegasToolStripMenuItem.Text = "Bodegas"
        '
        'LocacionesToolStripMenuItem
        '
        Me.LocacionesToolStripMenuItem.Name = "LocacionesToolStripMenuItem"
        Me.LocacionesToolStripMenuItem.Size = New System.Drawing.Size(133, 22)
        Me.LocacionesToolStripMenuItem.Text = "Locaciones"
        '
        'ProcesosToolStripMenuItem
        '
        Me.ProcesosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.IngresoDeProductosABodegaToolStripMenuItem, Me.IngresoDePedidosDeClientesToolStripMenuItem, Me.SalidaDeProductosToolStripMenuItem, Me.DevoluciónToolStripMenuItem})
        Me.ProcesosToolStripMenuItem.Name = "ProcesosToolStripMenuItem"
        Me.ProcesosToolStripMenuItem.Size = New System.Drawing.Size(66, 20)
        Me.ProcesosToolStripMenuItem.Text = "Procesos"
        '
        'IngresoDeProductosABodegaToolStripMenuItem
        '
        Me.IngresoDeProductosABodegaToolStripMenuItem.Name = "IngresoDeProductosABodegaToolStripMenuItem"
        Me.IngresoDeProductosABodegaToolStripMenuItem.Size = New System.Drawing.Size(247, 22)
        Me.IngresoDeProductosABodegaToolStripMenuItem.Text = "Ingreso de productos a Bodega"
        '
        'IngresoDePedidosDeClientesToolStripMenuItem
        '
        Me.IngresoDePedidosDeClientesToolStripMenuItem.Name = "IngresoDePedidosDeClientesToolStripMenuItem"
        Me.IngresoDePedidosDeClientesToolStripMenuItem.Size = New System.Drawing.Size(247, 22)
        Me.IngresoDePedidosDeClientesToolStripMenuItem.Text = "Ingreso de Ordenes de Despacho"
        '
        'SalidaDeProductosToolStripMenuItem
        '
        Me.SalidaDeProductosToolStripMenuItem.Name = "SalidaDeProductosToolStripMenuItem"
        Me.SalidaDeProductosToolStripMenuItem.Size = New System.Drawing.Size(247, 22)
        Me.SalidaDeProductosToolStripMenuItem.Text = "Salida de Productos"
        '
        'DevoluciónToolStripMenuItem
        '
        Me.DevoluciónToolStripMenuItem.Name = "DevoluciónToolStripMenuItem"
        Me.DevoluciónToolStripMenuItem.Size = New System.Drawing.Size(247, 22)
        Me.DevoluciónToolStripMenuItem.Text = "Ingreso de Devoluciones"
        '
        'InformesToolStripMenuItem
        '
        Me.InformesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TarjetaDeMovimientosToolStripMenuItem, Me.ToolStripSeparator1, Me.StockEnBodegaPorClienteToolStripMenuItem, Me.StockEnBodegaPorClienteDetalladoPorLocaciónToolStripMenuItem})
        Me.InformesToolStripMenuItem.Name = "InformesToolStripMenuItem"
        Me.InformesToolStripMenuItem.Size = New System.Drawing.Size(66, 20)
        Me.InformesToolStripMenuItem.Text = "Informes"
        '
        'TarjetaDeMovimientosToolStripMenuItem
        '
        Me.TarjetaDeMovimientosToolStripMenuItem.Name = "TarjetaDeMovimientosToolStripMenuItem"
        Me.TarjetaDeMovimientosToolStripMenuItem.Size = New System.Drawing.Size(285, 22)
        Me.TarjetaDeMovimientosToolStripMenuItem.Text = "Tarjeta de Movimientos"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(282, 6)
        '
        'StockEnBodegaPorClienteToolStripMenuItem
        '
        Me.StockEnBodegaPorClienteToolStripMenuItem.Name = "StockEnBodegaPorClienteToolStripMenuItem"
        Me.StockEnBodegaPorClienteToolStripMenuItem.Size = New System.Drawing.Size(285, 22)
        Me.StockEnBodegaPorClienteToolStripMenuItem.Text = "Stock por Cliente"
        '
        'StockEnBodegaPorClienteDetalladoPorLocaciónToolStripMenuItem
        '
        Me.StockEnBodegaPorClienteDetalladoPorLocaciónToolStripMenuItem.Name = "StockEnBodegaPorClienteDetalladoPorLocaciónToolStripMenuItem"
        Me.StockEnBodegaPorClienteDetalladoPorLocaciónToolStripMenuItem.Size = New System.Drawing.Size(285, 22)
        Me.StockEnBodegaPorClienteDetalladoPorLocaciónToolStripMenuItem.Text = "Stock por Cliente detallado por locación"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(41, 20)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'fMenuPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(723, 436)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "fMenuPrincipal"
        Me.Text = "Sistema de Gestión Logística"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ArchivoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProcesosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents InformesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EmpresadsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BodegasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LocacionesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents IngresoDeProductosABodegaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents IngresoDePedidosDeClientesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SalidaDeProductosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DevoluciónToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TarjetaDeMovimientosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents StockEnBodegaPorClienteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StockEnBodegaPorClienteDetalladoPorLocaciónToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
