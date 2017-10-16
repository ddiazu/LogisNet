<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fDevolucion
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
        Dim GridBaseStyle5 As Syncfusion.Windows.Forms.Grid.GridBaseStyle = New Syncfusion.Windows.Forms.Grid.GridBaseStyle()
        Dim GridBaseStyle6 As Syncfusion.Windows.Forms.Grid.GridBaseStyle = New Syncfusion.Windows.Forms.Grid.GridBaseStyle()
        Dim GridBaseStyle7 As Syncfusion.Windows.Forms.Grid.GridBaseStyle = New Syncfusion.Windows.Forms.Grid.GridBaseStyle()
        Dim GridBaseStyle8 As Syncfusion.Windows.Forms.Grid.GridBaseStyle = New Syncfusion.Windows.Forms.Grid.GridBaseStyle()
        Dim GridRangeStyle8 As Syncfusion.Windows.Forms.Grid.GridRangeStyle = New Syncfusion.Windows.Forms.Grid.GridRangeStyle()
        Dim GridRangeStyle9 As Syncfusion.Windows.Forms.Grid.GridRangeStyle = New Syncfusion.Windows.Forms.Grid.GridRangeStyle()
        Dim GridRangeStyle10 As Syncfusion.Windows.Forms.Grid.GridRangeStyle = New Syncfusion.Windows.Forms.Grid.GridRangeStyle()
        Dim GridRangeStyle11 As Syncfusion.Windows.Forms.Grid.GridRangeStyle = New Syncfusion.Windows.Forms.Grid.GridRangeStyle()
        Dim GridRangeStyle12 As Syncfusion.Windows.Forms.Grid.GridRangeStyle = New Syncfusion.Windows.Forms.Grid.GridRangeStyle()
        Dim GridRangeStyle13 As Syncfusion.Windows.Forms.Grid.GridRangeStyle = New Syncfusion.Windows.Forms.Grid.GridRangeStyle()
        Dim GridRangeStyle14 As Syncfusion.Windows.Forms.Grid.GridRangeStyle = New Syncfusion.Windows.Forms.Grid.GridRangeStyle()
        Me.tModulo = New System.Windows.Forms.TextBox()
        Me.tPasillo = New System.Windows.Forms.TextBox()
        Me.lTotal = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.tObservaciones = New System.Windows.Forms.TextBox()
        Me.Grid1 = New Syncfusion.Windows.Forms.Grid.GridControl()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.labelDescripcion = New System.Windows.Forms.Label()
        Me.lDescripcion = New System.Windows.Forms.Label()
        Me.tCantidad = New System.Windows.Forms.NumericUpDown()
        Me.tCodigoBarra = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbBodegas = New System.Windows.Forms.ComboBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.lNombre = New System.Windows.Forms.Label()
        Me.tRut = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lNombreLibreria = New System.Windows.Forms.Label()
        Me.tRutLibreria = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.tCiudad = New System.Windows.Forms.TextBox()
        Me.tComuna = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.tDireccion = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        CType(Me.Grid1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tCantidad, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tModulo
        '
        Me.tModulo.Location = New System.Drawing.Point(538, 175)
        Me.tModulo.Name = "tModulo"
        Me.tModulo.Size = New System.Drawing.Size(67, 20)
        Me.tModulo.TabIndex = 70
        '
        'tPasillo
        '
        Me.tPasillo.Location = New System.Drawing.Point(465, 175)
        Me.tPasillo.Name = "tPasillo"
        Me.tPasillo.Size = New System.Drawing.Size(67, 20)
        Me.tPasillo.TabIndex = 69
        '
        'lTotal
        '
        Me.lTotal.BackColor = System.Drawing.Color.Lavender
        Me.lTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lTotal.Location = New System.Drawing.Point(588, 436)
        Me.lTotal.Name = "lTotal"
        Me.lTotal.Size = New System.Drawing.Size(62, 20)
        Me.lTotal.TabIndex = 68
        Me.lTotal.Text = "0"
        Me.lTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(448, 440)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(134, 13)
        Me.Label10.TabIndex = 67
        Me.Label10.Text = "Total Unidades Ingresadas"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(17, 469)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(78, 13)
        Me.Label9.TabIndex = 66
        Me.Label9.Text = "Observaciones"
        '
        'tObservaciones
        '
        Me.tObservaciones.Location = New System.Drawing.Point(20, 485)
        Me.tObservaciones.Name = "tObservaciones"
        Me.tObservaciones.Size = New System.Drawing.Size(542, 20)
        Me.tObservaciones.TabIndex = 65
        '
        'Grid1
        '
        GridBaseStyle5.Name = "Header"
        GridBaseStyle5.StyleInfo.Borders.Bottom = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.None)
        GridBaseStyle5.StyleInfo.Borders.Left = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.None)
        GridBaseStyle5.StyleInfo.Borders.Right = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.None)
        GridBaseStyle5.StyleInfo.Borders.Top = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.None)
        GridBaseStyle5.StyleInfo.CellType = "Header"
        GridBaseStyle5.StyleInfo.Font.Bold = True
        GridBaseStyle5.StyleInfo.Interior = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.FromArgb(CType(CType(203, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(184, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(216, Byte), Integer)))
        GridBaseStyle5.StyleInfo.VerticalAlignment = Syncfusion.Windows.Forms.Grid.GridVerticalAlignment.Middle
        GridBaseStyle6.Name = "Standard"
        GridBaseStyle6.StyleInfo.Font.Facename = "Tahoma"
        GridBaseStyle6.StyleInfo.Interior = New Syncfusion.Drawing.BrushInfo(System.Drawing.SystemColors.Window)
        GridBaseStyle7.Name = "Column Header"
        GridBaseStyle7.StyleInfo.BaseStyle = "Header"
        GridBaseStyle7.StyleInfo.HorizontalAlignment = Syncfusion.Windows.Forms.Grid.GridHorizontalAlignment.Center
        GridBaseStyle8.Name = "Row Header"
        GridBaseStyle8.StyleInfo.BaseStyle = "Header"
        GridBaseStyle8.StyleInfo.HorizontalAlignment = Syncfusion.Windows.Forms.Grid.GridHorizontalAlignment.Left
        GridBaseStyle8.StyleInfo.Interior = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Horizontal, System.Drawing.Color.FromArgb(CType(CType(203, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(184, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(216, Byte), Integer)))
        Me.Grid1.BaseStylesMap.AddRange(New Syncfusion.Windows.Forms.Grid.GridBaseStyle() {GridBaseStyle5, GridBaseStyle6, GridBaseStyle7, GridBaseStyle8})
        Me.Grid1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Grid1.ColCount = 7
        Me.Grid1.ColWidthEntries.AddRange(New Syncfusion.Windows.Forms.Grid.GridColWidth() {New Syncfusion.Windows.Forms.Grid.GridColWidth(0, 35), New Syncfusion.Windows.Forms.Grid.GridColWidth(3, 112), New Syncfusion.Windows.Forms.Grid.GridColWidth(4, 292)})
        Me.Grid1.DefaultRowHeight = 20
        Me.Grid1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Grid1.GridOfficeScrollBars = Syncfusion.Windows.Forms.OfficeScrollBars.Metro
        Me.Grid1.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Metro
        Me.Grid1.Location = New System.Drawing.Point(15, 201)
        Me.Grid1.MetroScrollBars = True
        Me.Grid1.Name = "Grid1"
        GridRangeStyle8.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Cell(0, 1)
        GridRangeStyle8.StyleInfo.Text = "Pasillo"
        GridRangeStyle9.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Cell(0, 2)
        GridRangeStyle9.StyleInfo.Text = "Módulo"
        GridRangeStyle10.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Cell(0, 3)
        GridRangeStyle10.StyleInfo.Text = "Cod.Barra"
        GridRangeStyle11.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Cell(0, 4)
        GridRangeStyle11.StyleInfo.Text = "Descripción"
        GridRangeStyle12.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Cell(0, 5)
        GridRangeStyle12.StyleInfo.Text = "Cantidad"
        GridRangeStyle13.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Cell(0, 6)
        GridRangeStyle13.StyleInfo.Text = "ID Loc"
        GridRangeStyle14.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Cell(0, 7)
        GridRangeStyle14.StyleInfo.Text = "ID Prod"
        Me.Grid1.RangeStyles.AddRange(New Syncfusion.Windows.Forms.Grid.GridRangeStyle() {GridRangeStyle8, GridRangeStyle9, GridRangeStyle10, GridRangeStyle11, GridRangeStyle12, GridRangeStyle13, GridRangeStyle14})
        Me.Grid1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Grid1.RowHeightEntries.AddRange(New Syncfusion.Windows.Forms.Grid.GridRowHeight() {New Syncfusion.Windows.Forms.Grid.GridRowHeight(0, 25)})
        Me.Grid1.SerializeCellsBehavior = Syncfusion.Windows.Forms.Grid.GridSerializeCellsBehavior.SerializeAsRangeStylesIntoCode
        Me.Grid1.Size = New System.Drawing.Size(750, 221)
        Me.Grid1.SmartSizeBox = False
        Me.Grid1.TabIndex = 64
        Me.Grid1.ThemesEnabled = True
        Me.Grid1.UseRightToLeftCompatibleTextBox = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(536, 158)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(42, 13)
        Me.Label8.TabIndex = 63
        Me.Label8.Text = "Módulo"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(462, 158)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(37, 13)
        Me.Label5.TabIndex = 62
        Me.Label5.Text = "Pasillo"
        '
        'labelDescripcion
        '
        Me.labelDescripcion.AutoSize = True
        Me.labelDescripcion.Location = New System.Drawing.Point(141, 158)
        Me.labelDescripcion.Name = "labelDescripcion"
        Me.labelDescripcion.Size = New System.Drawing.Size(63, 13)
        Me.labelDescripcion.TabIndex = 61
        Me.labelDescripcion.Text = "Descripción"
        '
        'lDescripcion
        '
        Me.lDescripcion.BackColor = System.Drawing.Color.Lavender
        Me.lDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lDescripcion.Location = New System.Drawing.Point(144, 174)
        Me.lDescripcion.Name = "lDescripcion"
        Me.lDescripcion.Size = New System.Drawing.Size(310, 20)
        Me.lDescripcion.TabIndex = 60
        Me.lDescripcion.Text = "Label2"
        '
        'tCantidad
        '
        Me.tCantidad.Location = New System.Drawing.Point(611, 175)
        Me.tCantidad.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.tCantidad.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.tCantidad.Name = "tCantidad"
        Me.tCantidad.Size = New System.Drawing.Size(60, 20)
        Me.tCantidad.TabIndex = 59
        Me.tCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.tCantidad.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'tCodigoBarra
        '
        Me.tCodigoBarra.Location = New System.Drawing.Point(15, 174)
        Me.tCodigoBarra.Name = "tCodigoBarra"
        Me.tCodigoBarra.Size = New System.Drawing.Size(126, 20)
        Me.tCodigoBarra.TabIndex = 58
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(610, 158)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(49, 13)
        Me.Label6.TabIndex = 57
        Me.Label6.Text = "Cantidad"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(12, 158)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(68, 13)
        Me.Label7.TabIndex = 56
        Me.Label7.Text = "Codigo Barra"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 53
        Me.Label1.Text = "Bodega"
        '
        'cmbBodegas
        '
        Me.cmbBodegas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbBodegas.FormattingEnabled = True
        Me.cmbBodegas.Location = New System.Drawing.Point(15, 26)
        Me.cmbBodegas.Name = "cmbBodegas"
        Me.cmbBodegas.Size = New System.Drawing.Size(175, 21)
        Me.cmbBodegas.TabIndex = 52
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(675, 479)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(90, 30)
        Me.Button2.TabIndex = 51
        Me.Button2.Text = "Salir"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(579, 479)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(90, 30)
        Me.Button1.TabIndex = 50
        Me.Button1.Text = "Guardar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'lNombre
        '
        Me.lNombre.BackColor = System.Drawing.Color.Lavender
        Me.lNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lNombre.Location = New System.Drawing.Point(307, 26)
        Me.lNombre.Name = "lNombre"
        Me.lNombre.Size = New System.Drawing.Size(263, 20)
        Me.lNombre.TabIndex = 49
        Me.lNombre.Text = "Label4"
        '
        'tRut
        '
        Me.tRut.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tRut.Location = New System.Drawing.Point(198, 26)
        Me.tRut.Name = "tRut"
        Me.tRut.Size = New System.Drawing.Size(103, 20)
        Me.tRut.TabIndex = 48
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(306, 10)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 13)
        Me.Label3.TabIndex = 47
        Me.Label3.Text = "Nombre"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(195, 11)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 13)
        Me.Label2.TabIndex = 46
        Me.Label2.Text = "Rut Cliente"
        '
        'lNombreLibreria
        '
        Me.lNombreLibreria.BackColor = System.Drawing.Color.Lavender
        Me.lNombreLibreria.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lNombreLibreria.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lNombreLibreria.Location = New System.Drawing.Point(124, 74)
        Me.lNombreLibreria.Name = "lNombreLibreria"
        Me.lNombreLibreria.Size = New System.Drawing.Size(294, 20)
        Me.lNombreLibreria.TabIndex = 74
        Me.lNombreLibreria.Text = "Label4"
        '
        'tRutLibreria
        '
        Me.tRutLibreria.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tRutLibreria.Location = New System.Drawing.Point(15, 74)
        Me.tRutLibreria.Name = "tRutLibreria"
        Me.tRutLibreria.Size = New System.Drawing.Size(103, 20)
        Me.tRutLibreria.TabIndex = 73
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(121, 58)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(44, 13)
        Me.Label11.TabIndex = 72
        Me.Label11.Text = "Nombre"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(12, 58)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(63, 13)
        Me.Label12.TabIndex = 71
        Me.Label12.Text = "Rut Librería"
        '
        'tCiudad
        '
        Me.tCiudad.Location = New System.Drawing.Point(424, 115)
        Me.tCiudad.MaxLength = 50
        Me.tCiudad.Name = "tCiudad"
        Me.tCiudad.Size = New System.Drawing.Size(133, 20)
        Me.tCiudad.TabIndex = 80
        '
        'tComuna
        '
        Me.tComuna.Location = New System.Drawing.Point(284, 115)
        Me.tComuna.MaxLength = 50
        Me.tComuna.Name = "tComuna"
        Me.tComuna.Size = New System.Drawing.Size(134, 20)
        Me.tComuna.TabIndex = 79
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Maroon
        Me.Label4.Location = New System.Drawing.Point(281, 99)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 13)
        Me.Label4.TabIndex = 78
        Me.Label4.Text = "Comuna"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Maroon
        Me.Label13.Location = New System.Drawing.Point(421, 99)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(40, 13)
        Me.Label13.TabIndex = 77
        Me.Label13.Text = "Ciudad"
        '
        'tDireccion
        '
        Me.tDireccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tDireccion.Location = New System.Drawing.Point(15, 115)
        Me.tDireccion.MaxLength = 100
        Me.tDireccion.Name = "tDireccion"
        Me.tDireccion.Size = New System.Drawing.Size(265, 20)
        Me.tDireccion.TabIndex = 76
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Maroon
        Me.Label14.Location = New System.Drawing.Point(12, 99)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(52, 13)
        Me.Label14.TabIndex = 75
        Me.Label14.Text = "Dirección"
        '
        'fDevolucion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(779, 533)
        Me.Controls.Add(Me.tCiudad)
        Me.Controls.Add(Me.tComuna)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.tDireccion)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.lNombreLibreria)
        Me.Controls.Add(Me.tRutLibreria)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.tModulo)
        Me.Controls.Add(Me.tPasillo)
        Me.Controls.Add(Me.lTotal)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.tObservaciones)
        Me.Controls.Add(Me.Grid1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.labelDescripcion)
        Me.Controls.Add(Me.lDescripcion)
        Me.Controls.Add(Me.tCantidad)
        Me.Controls.Add(Me.tCodigoBarra)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmbBodegas)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lNombre)
        Me.Controls.Add(Me.tRut)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Name = "fDevolucion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ingreso de Devolución"
        CType(Me.Grid1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tCantidad, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tModulo As System.Windows.Forms.TextBox
    Friend WithEvents tPasillo As System.Windows.Forms.TextBox
    Friend WithEvents lTotal As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents tObservaciones As System.Windows.Forms.TextBox
    Friend WithEvents Grid1 As Syncfusion.Windows.Forms.Grid.GridControl
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents labelDescripcion As System.Windows.Forms.Label
    Friend WithEvents lDescripcion As System.Windows.Forms.Label
    Friend WithEvents tCantidad As System.Windows.Forms.NumericUpDown
    Friend WithEvents tCodigoBarra As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmbBodegas As System.Windows.Forms.ComboBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents lNombre As System.Windows.Forms.Label
    Friend WithEvents tRut As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lNombreLibreria As System.Windows.Forms.Label
    Friend WithEvents tRutLibreria As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents tCiudad As System.Windows.Forms.TextBox
    Friend WithEvents tComuna As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents tDireccion As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
End Class
