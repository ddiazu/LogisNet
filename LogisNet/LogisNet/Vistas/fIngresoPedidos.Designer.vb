<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fIngresoPedidos
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
        Dim GridBaseStyle1 As Syncfusion.Windows.Forms.Grid.GridBaseStyle = New Syncfusion.Windows.Forms.Grid.GridBaseStyle()
        Dim GridBaseStyle2 As Syncfusion.Windows.Forms.Grid.GridBaseStyle = New Syncfusion.Windows.Forms.Grid.GridBaseStyle()
        Dim GridBaseStyle3 As Syncfusion.Windows.Forms.Grid.GridBaseStyle = New Syncfusion.Windows.Forms.Grid.GridBaseStyle()
        Dim GridBaseStyle4 As Syncfusion.Windows.Forms.Grid.GridBaseStyle = New Syncfusion.Windows.Forms.Grid.GridBaseStyle()
        Dim GridCellInfo1 As Syncfusion.Windows.Forms.Grid.GridCellInfo = New Syncfusion.Windows.Forms.Grid.GridCellInfo()
        Dim GridCellInfo2 As Syncfusion.Windows.Forms.Grid.GridCellInfo = New Syncfusion.Windows.Forms.Grid.GridCellInfo()
        Dim GridCellInfo3 As Syncfusion.Windows.Forms.Grid.GridCellInfo = New Syncfusion.Windows.Forms.Grid.GridCellInfo()
        Dim GridCellInfo4 As Syncfusion.Windows.Forms.Grid.GridCellInfo = New Syncfusion.Windows.Forms.Grid.GridCellInfo()
        Dim GridCellInfo5 As Syncfusion.Windows.Forms.Grid.GridCellInfo = New Syncfusion.Windows.Forms.Grid.GridCellInfo()
        Dim GridCellInfo6 As Syncfusion.Windows.Forms.Grid.GridCellInfo = New Syncfusion.Windows.Forms.Grid.GridCellInfo()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tRutCliente = New System.Windows.Forms.TextBox()
        Me.lNombreCliente = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tNumeroPedido = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.tDireccion = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Grid1 = New Syncfusion.Windows.Forms.Grid.GridControl()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.tObservaciones = New System.Windows.Forms.TextBox()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.BtnCrearPicking = New System.Windows.Forms.Button()
        Me.tRutDestinatario = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.labelDescripcion = New System.Windows.Forms.Label()
        Me.lDescripcion = New System.Windows.Forms.Label()
        Me.tCantidad = New System.Windows.Forms.NumericUpDown()
        Me.tCodigoBarra = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.tNumeroOrdendeCompra = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cmbTipoDocumento = New System.Windows.Forms.ComboBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.lNombreDestinatario = New System.Windows.Forms.Label()
        Me.tComuna = New System.Windows.Forms.TextBox()
        Me.tCiudad = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        CType(Me.Grid1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tCantidad, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Cliente"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Maroon
        Me.Label2.Location = New System.Drawing.Point(7, 44)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(24, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Rut"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Maroon
        Me.Label3.Location = New System.Drawing.Point(201, 41)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Razón Social"
        '
        'tRutCliente
        '
        Me.tRutCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tRutCliente.Location = New System.Drawing.Point(92, 41)
        Me.tRutCliente.MaxLength = 15
        Me.tRutCliente.Name = "tRutCliente"
        Me.tRutCliente.Size = New System.Drawing.Size(103, 20)
        Me.tRutCliente.TabIndex = 3
        '
        'lNombreCliente
        '
        Me.lNombreCliente.BackColor = System.Drawing.Color.White
        Me.lNombreCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lNombreCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lNombreCliente.Location = New System.Drawing.Point(277, 39)
        Me.lNombreCliente.Name = "lNombreCliente"
        Me.lNombreCliente.Size = New System.Drawing.Size(396, 22)
        Me.lNombreCliente.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Maroon
        Me.Label5.Location = New System.Drawing.Point(7, 68)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "N° Pedido"
        '
        'tNumeroPedido
        '
        Me.tNumeroPedido.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tNumeroPedido.Location = New System.Drawing.Point(92, 67)
        Me.tNumeroPedido.MaxLength = 10
        Me.tNumeroPedido.Name = "tNumeroPedido"
        Me.tNumeroPedido.Size = New System.Drawing.Size(88, 20)
        Me.tNumeroPedido.TabIndex = 6
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Maroon
        Me.Label6.Location = New System.Drawing.Point(201, 70)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(37, 13)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Fecha"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(5, 107)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(75, 13)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "Destinatario"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Maroon
        Me.Label9.Location = New System.Drawing.Point(6, 158)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(52, 13)
        Me.Label9.TabIndex = 11
        Me.Label9.Text = "Dirección"
        '
        'tDireccion
        '
        Me.tDireccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tDireccion.Location = New System.Drawing.Point(92, 158)
        Me.tDireccion.MaxLength = 100
        Me.tDireccion.Name = "tDireccion"
        Me.tDireccion.Size = New System.Drawing.Size(291, 20)
        Me.tDireccion.TabIndex = 12
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Maroon
        Me.Label10.Location = New System.Drawing.Point(605, 161)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(40, 13)
        Me.Label10.TabIndex = 13
        Me.Label10.Text = "Ciudad"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Maroon
        Me.Label11.Location = New System.Drawing.Point(397, 161)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(46, 13)
        Me.Label11.TabIndex = 15
        Me.Label11.Text = "Comuna"
        '
        'Grid1
        '
        GridBaseStyle1.Name = "Header"
        GridBaseStyle1.StyleInfo.Borders.Bottom = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.None)
        GridBaseStyle1.StyleInfo.Borders.Left = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.None)
        GridBaseStyle1.StyleInfo.Borders.Right = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.None)
        GridBaseStyle1.StyleInfo.Borders.Top = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.None)
        GridBaseStyle1.StyleInfo.CellType = "Header"
        GridBaseStyle1.StyleInfo.Font.Bold = True
        GridBaseStyle1.StyleInfo.Interior = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.FromArgb(CType(CType(203, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(184, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(216, Byte), Integer)))
        GridBaseStyle1.StyleInfo.VerticalAlignment = Syncfusion.Windows.Forms.Grid.GridVerticalAlignment.Middle
        GridBaseStyle2.Name = "Standard"
        GridBaseStyle2.StyleInfo.Font.Facename = "Tahoma"
        GridBaseStyle2.StyleInfo.Interior = New Syncfusion.Drawing.BrushInfo(System.Drawing.SystemColors.Window)
        GridBaseStyle3.Name = "Column Header"
        GridBaseStyle3.StyleInfo.BaseStyle = "Header"
        GridBaseStyle3.StyleInfo.HorizontalAlignment = Syncfusion.Windows.Forms.Grid.GridHorizontalAlignment.Center
        GridBaseStyle4.Name = "Row Header"
        GridBaseStyle4.StyleInfo.BaseStyle = "Header"
        GridBaseStyle4.StyleInfo.HorizontalAlignment = Syncfusion.Windows.Forms.Grid.GridHorizontalAlignment.Left
        GridBaseStyle4.StyleInfo.Interior = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Horizontal, System.Drawing.Color.FromArgb(CType(CType(203, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(184, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(216, Byte), Integer)))
        Me.Grid1.BaseStylesMap.AddRange(New Syncfusion.Windows.Forms.Grid.GridBaseStyle() {GridBaseStyle1, GridBaseStyle2, GridBaseStyle3, GridBaseStyle4})
        Me.Grid1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Grid1.ColCount = 5
        Me.Grid1.ColWidthEntries.AddRange(New Syncfusion.Windows.Forms.Grid.GridColWidth() {New Syncfusion.Windows.Forms.Grid.GridColWidth(0, 35), New Syncfusion.Windows.Forms.Grid.GridColWidth(1, 97), New Syncfusion.Windows.Forms.Grid.GridColWidth(2, 303)})
        Me.Grid1.DefaultRowHeight = 20
        Me.Grid1.ForeColor = System.Drawing.SystemColors.ControlText
        GridCellInfo1.Col = -1
        GridCellInfo1.Row = -1
        GridCellInfo2.Col = 1
        GridCellInfo2.Row = 0
        GridCellInfo2.StyleInfo.Text = "Cod.Producto"
        GridCellInfo3.Col = 2
        GridCellInfo3.Row = 0
        GridCellInfo3.StyleInfo.Text = "Descripción"
        GridCellInfo4.Col = 3
        GridCellInfo4.Row = 0
        GridCellInfo4.StyleInfo.Text = "Cantidad Solicitada "
        GridCellInfo5.Col = 4
        GridCellInfo5.Row = 0
        GridCellInfo5.StyleInfo.Text = "Cantidad Aceptada"
        GridCellInfo6.Col = 5
        GridCellInfo6.Row = 0
        GridCellInfo6.StyleInfo.Text = "IdProducto"
        Me.Grid1.GridCells.AddRange(New Syncfusion.Windows.Forms.Grid.GridCellInfo() {GridCellInfo1, GridCellInfo2, GridCellInfo3, GridCellInfo4, GridCellInfo5, GridCellInfo6})
        Me.Grid1.GridOfficeScrollBars = Syncfusion.Windows.Forms.OfficeScrollBars.Metro
        Me.Grid1.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Metro
        Me.Grid1.Location = New System.Drawing.Point(12, 296)
        Me.Grid1.MetroScrollBars = True
        Me.Grid1.Name = "Grid1"
        Me.Grid1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Grid1.RowHeightEntries.AddRange(New Syncfusion.Windows.Forms.Grid.GridRowHeight() {New Syncfusion.Windows.Forms.Grid.GridRowHeight(0, 30)})
        Me.Grid1.SerializeCellsBehavior = Syncfusion.Windows.Forms.Grid.GridSerializeCellsBehavior.SerializeIntoCode
        Me.Grid1.Size = New System.Drawing.Size(800, 193)
        Me.Grid1.SmartSizeBox = False
        Me.Grid1.TabIndex = 17
        Me.Grid1.ThemesEnabled = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(9, 230)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(110, 13)
        Me.Label12.TabIndex = 18
        Me.Label12.Text = "Detalle del pedido"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(7, 190)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(78, 13)
        Me.Label13.TabIndex = 19
        Me.Label13.Text = "Observaciones"
        '
        'tObservaciones
        '
        Me.tObservaciones.Location = New System.Drawing.Point(92, 187)
        Me.tObservaciones.MaxLength = 150
        Me.tObservaciones.Name = "tObservaciones"
        Me.tObservaciones.Size = New System.Drawing.Size(498, 20)
        Me.tObservaciones.TabIndex = 20
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(722, 495)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(90, 30)
        Me.btnSalir.TabIndex = 22
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'BtnCrearPicking
        '
        Me.BtnCrearPicking.Location = New System.Drawing.Point(618, 495)
        Me.BtnCrearPicking.Name = "BtnCrearPicking"
        Me.BtnCrearPicking.Size = New System.Drawing.Size(98, 30)
        Me.BtnCrearPicking.TabIndex = 21
        Me.BtnCrearPicking.Text = "Crear Picking"
        Me.BtnCrearPicking.UseVisualStyleBackColor = True
        '
        'tRutDestinatario
        '
        Me.tRutDestinatario.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tRutDestinatario.Location = New System.Drawing.Point(92, 132)
        Me.tRutDestinatario.MaxLength = 15
        Me.tRutDestinatario.Name = "tRutDestinatario"
        Me.tRutDestinatario.Size = New System.Drawing.Size(103, 20)
        Me.tRutDestinatario.TabIndex = 25
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Maroon
        Me.Label15.Location = New System.Drawing.Point(201, 132)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(70, 13)
        Me.Label15.TabIndex = 24
        Me.Label15.Text = "Razón Social"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Maroon
        Me.Label16.Location = New System.Drawing.Point(7, 135)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(27, 13)
        Me.Label16.TabIndex = 23
        Me.Label16.Text = "Rut "
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(699, 12)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(113, 30)
        Me.Button3.TabIndex = 27
        Me.Button3.Text = "Importar Archivo"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'labelDescripcion
        '
        Me.labelDescripcion.AutoSize = True
        Me.labelDescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelDescripcion.Location = New System.Drawing.Point(140, 254)
        Me.labelDescripcion.Name = "labelDescripcion"
        Me.labelDescripcion.Size = New System.Drawing.Size(63, 13)
        Me.labelDescripcion.TabIndex = 49
        Me.labelDescripcion.Text = "Descripción"
        '
        'lDescripcion
        '
        Me.lDescripcion.BackColor = System.Drawing.Color.Lavender
        Me.lDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lDescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lDescripcion.Location = New System.Drawing.Point(143, 270)
        Me.lDescripcion.Name = "lDescripcion"
        Me.lDescripcion.Size = New System.Drawing.Size(310, 20)
        Me.lDescripcion.TabIndex = 48
        '
        'tCantidad
        '
        Me.tCantidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tCantidad.Location = New System.Drawing.Point(459, 270)
        Me.tCantidad.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.tCantidad.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.tCantidad.Name = "tCantidad"
        Me.tCantidad.Size = New System.Drawing.Size(60, 20)
        Me.tCantidad.TabIndex = 47
        Me.tCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.tCantidad.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'tCodigoBarra
        '
        Me.tCodigoBarra.Location = New System.Drawing.Point(12, 270)
        Me.tCodigoBarra.Name = "tCodigoBarra"
        Me.tCodigoBarra.Size = New System.Drawing.Size(126, 20)
        Me.tCodigoBarra.TabIndex = 46
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(458, 253)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(49, 13)
        Me.Label19.TabIndex = 45
        Me.Label19.Text = "Cantidad"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(9, 254)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(68, 13)
        Me.Label20.TabIndex = 44
        Me.Label20.Text = "Codigo Barra"
        '
        'tNumeroOrdendeCompra
        '
        Me.tNumeroOrdendeCompra.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tNumeroOrdendeCompra.Location = New System.Drawing.Point(711, 132)
        Me.tNumeroOrdendeCompra.Name = "tNumeroOrdendeCompra"
        Me.tNumeroOrdendeCompra.Size = New System.Drawing.Size(101, 20)
        Me.tNumeroOrdendeCompra.TabIndex = 52
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(615, 132)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(90, 13)
        Me.Label4.TabIndex = 51
        Me.Label4.Text = "Orden de Compra"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Maroon
        Me.Label7.Location = New System.Drawing.Point(398, 71)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(127, 13)
        Me.Label7.TabIndex = 53
        Me.Label7.Text = "Documento de despacho"
        '
        'cmbTipoDocumento
        '
        Me.cmbTipoDocumento.FormattingEnabled = True
        Me.cmbTipoDocumento.Items.AddRange(New Object() {"Guia", "Factura"})
        Me.cmbTipoDocumento.Location = New System.Drawing.Point(531, 67)
        Me.cmbTipoDocumento.Name = "cmbTipoDocumento"
        Me.cmbTipoDocumento.Size = New System.Drawing.Size(142, 21)
        Me.cmbTipoDocumento.TabIndex = 54
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(277, 68)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(106, 20)
        Me.DateTimePicker1.TabIndex = 55
        '
        'lNombreDestinatario
        '
        Me.lNombreDestinatario.BackColor = System.Drawing.Color.White
        Me.lNombreDestinatario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lNombreDestinatario.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lNombreDestinatario.Location = New System.Drawing.Point(277, 131)
        Me.lNombreDestinatario.Name = "lNombreDestinatario"
        Me.lNombreDestinatario.Size = New System.Drawing.Size(332, 22)
        Me.lNombreDestinatario.TabIndex = 58
        '
        'tComuna
        '
        Me.tComuna.Location = New System.Drawing.Point(456, 158)
        Me.tComuna.MaxLength = 50
        Me.tComuna.Name = "tComuna"
        Me.tComuna.Size = New System.Drawing.Size(134, 20)
        Me.tComuna.TabIndex = 59
        '
        'tCiudad
        '
        Me.tCiudad.Location = New System.Drawing.Point(651, 158)
        Me.tCiudad.MaxLength = 50
        Me.tCiudad.Name = "tCiudad"
        Me.tCiudad.Size = New System.Drawing.Size(133, 20)
        Me.tCiudad.TabIndex = 60
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(13, 505)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(440, 13)
        Me.Label14.TabIndex = 61
        Me.Label14.Text = "Los datos en ROJO son exigidos, si falta alguno no podrá generar el Picking"
        '
        'fIngresoPedidos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(824, 535)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.tCiudad)
        Me.Controls.Add(Me.tComuna)
        Me.Controls.Add(Me.lNombreDestinatario)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.cmbTipoDocumento)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.tNumeroOrdendeCompra)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.labelDescripcion)
        Me.Controls.Add(Me.lDescripcion)
        Me.Controls.Add(Me.tCantidad)
        Me.Controls.Add(Me.tCodigoBarra)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.tRutDestinatario)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.BtnCrearPicking)
        Me.Controls.Add(Me.tObservaciones)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.tDireccion)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Grid1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.tNumeroPedido)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lNombreCliente)
        Me.Controls.Add(Me.tRutCliente)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "fIngresoPedidos"
        Me.Text = "Ingreso de Pedidos"
        CType(Me.Grid1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tCantidad, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents tRutCliente As System.Windows.Forms.TextBox
    Friend WithEvents lNombreCliente As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents tNumeroPedido As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents tDireccion As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Grid1 As Syncfusion.Windows.Forms.Grid.GridControl
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents tObservaciones As System.Windows.Forms.TextBox
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents BtnCrearPicking As System.Windows.Forms.Button
    Friend WithEvents tRutDestinatario As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents labelDescripcion As System.Windows.Forms.Label
    Friend WithEvents lDescripcion As System.Windows.Forms.Label
    Friend WithEvents tCantidad As System.Windows.Forms.NumericUpDown
    Friend WithEvents tCodigoBarra As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents tNumeroOrdendeCompra As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cmbTipoDocumento As System.Windows.Forms.ComboBox
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents lNombreDestinatario As System.Windows.Forms.Label
    Friend WithEvents tComuna As System.Windows.Forms.TextBox
    Friend WithEvents tCiudad As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
End Class
