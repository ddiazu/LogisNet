<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fSalidaBodega
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
        Dim GridRangeStyle1 As Syncfusion.Windows.Forms.Grid.GridRangeStyle = New Syncfusion.Windows.Forms.Grid.GridRangeStyle()
        Dim GridRangeStyle2 As Syncfusion.Windows.Forms.Grid.GridRangeStyle = New Syncfusion.Windows.Forms.Grid.GridRangeStyle()
        Dim GridRangeStyle3 As Syncfusion.Windows.Forms.Grid.GridRangeStyle = New Syncfusion.Windows.Forms.Grid.GridRangeStyle()
        Dim GridRangeStyle4 As Syncfusion.Windows.Forms.Grid.GridRangeStyle = New Syncfusion.Windows.Forms.Grid.GridRangeStyle()
        Dim GridRangeStyle5 As Syncfusion.Windows.Forms.Grid.GridRangeStyle = New Syncfusion.Windows.Forms.Grid.GridRangeStyle()
        Dim GridRangeStyle6 As Syncfusion.Windows.Forms.Grid.GridRangeStyle = New Syncfusion.Windows.Forms.Grid.GridRangeStyle()
        Dim GridRangeStyle7 As Syncfusion.Windows.Forms.Grid.GridRangeStyle = New Syncfusion.Windows.Forms.Grid.GridRangeStyle()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.tObservaciones = New System.Windows.Forms.TextBox()
        Me.tModulo = New System.Windows.Forms.TextBox()
        Me.tPasillo = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lNombreCliente = New System.Windows.Forms.Label()
        Me.tRutCliente = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lMotivo = New System.Windows.Forms.Label()
        Me.cmbMotivos = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.labelDescripcion = New System.Windows.Forms.Label()
        Me.lDescripcion = New System.Windows.Forms.Label()
        Me.tCantidad = New System.Windows.Forms.NumericUpDown()
        Me.tCodigoBarra = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Grid1 = New Syncfusion.Windows.Forms.Grid.GridControl()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbBodegas = New System.Windows.Forms.ComboBox()
        Me.tNumDocCliente = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        CType(Me.tCantidad, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Grid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(483, 422)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(95, 30)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Grabar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(584, 422)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(95, 30)
        Me.Button2.TabIndex = 6
        Me.Button2.Text = "Salir"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(14, 370)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(78, 13)
        Me.Label9.TabIndex = 15
        Me.Label9.Text = "Observaciones"
        '
        'tObservaciones
        '
        Me.tObservaciones.Location = New System.Drawing.Point(17, 386)
        Me.tObservaciones.Name = "tObservaciones"
        Me.tObservaciones.Size = New System.Drawing.Size(662, 20)
        Me.tObservaciones.TabIndex = 16
        '
        'tModulo
        '
        Me.tModulo.Location = New System.Drawing.Point(534, 101)
        Me.tModulo.Name = "tModulo"
        Me.tModulo.Size = New System.Drawing.Size(67, 20)
        Me.tModulo.TabIndex = 64
        '
        'tPasillo
        '
        Me.tPasillo.Location = New System.Drawing.Point(461, 101)
        Me.tPasillo.Name = "tPasillo"
        Me.tPasillo.Size = New System.Drawing.Size(67, 20)
        Me.tPasillo.TabIndex = 63
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(114, 27)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(44, 13)
        Me.Label7.TabIndex = 62
        Me.Label7.Text = "Nombre"
        '
        'lNombreCliente
        '
        Me.lNombreCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lNombreCliente.Location = New System.Drawing.Point(117, 42)
        Me.lNombreCliente.Name = "lNombreCliente"
        Me.lNombreCliente.Size = New System.Drawing.Size(248, 20)
        Me.lNombreCliente.TabIndex = 61
        Me.lNombreCliente.Text = "Label2"
        '
        'tRutCliente
        '
        Me.tRutCliente.Location = New System.Drawing.Point(12, 43)
        Me.tRutCliente.Name = "tRutCliente"
        Me.tRutCliente.Size = New System.Drawing.Size(99, 20)
        Me.tRutCliente.TabIndex = 60
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 27)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 13)
        Me.Label2.TabIndex = 59
        Me.Label2.Text = "Rut Cliente"
        '
        'lMotivo
        '
        Me.lMotivo.AutoSize = True
        Me.lMotivo.Location = New System.Drawing.Point(558, 25)
        Me.lMotivo.Name = "lMotivo"
        Me.lMotivo.Size = New System.Drawing.Size(39, 13)
        Me.lMotivo.TabIndex = 58
        Me.lMotivo.Text = "Motivo"
        '
        'cmbMotivos
        '
        Me.cmbMotivos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbMotivos.FormattingEnabled = True
        Me.cmbMotivos.Location = New System.Drawing.Point(561, 42)
        Me.cmbMotivos.Name = "cmbMotivos"
        Me.cmbMotivos.Size = New System.Drawing.Size(103, 21)
        Me.cmbMotivos.TabIndex = 57
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(531, 86)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(42, 13)
        Me.Label8.TabIndex = 56
        Me.Label8.Text = "Módulo"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(457, 86)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(37, 13)
        Me.Label5.TabIndex = 55
        Me.Label5.Text = "Pasillo"
        '
        'labelDescripcion
        '
        Me.labelDescripcion.AutoSize = True
        Me.labelDescripcion.Location = New System.Drawing.Point(141, 86)
        Me.labelDescripcion.Name = "labelDescripcion"
        Me.labelDescripcion.Size = New System.Drawing.Size(63, 13)
        Me.labelDescripcion.TabIndex = 54
        Me.labelDescripcion.Text = "Descripción"
        '
        'lDescripcion
        '
        Me.lDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lDescripcion.Location = New System.Drawing.Point(144, 101)
        Me.lDescripcion.Name = "lDescripcion"
        Me.lDescripcion.Size = New System.Drawing.Size(310, 20)
        Me.lDescripcion.TabIndex = 53
        Me.lDescripcion.Text = "Label2"
        '
        'tCantidad
        '
        Me.tCantidad.Location = New System.Drawing.Point(607, 101)
        Me.tCantidad.Name = "tCantidad"
        Me.tCantidad.Size = New System.Drawing.Size(60, 20)
        Me.tCantidad.TabIndex = 52
        '
        'tCodigoBarra
        '
        Me.tCodigoBarra.Location = New System.Drawing.Point(13, 101)
        Me.tCodigoBarra.Name = "tCodigoBarra"
        Me.tCodigoBarra.Size = New System.Drawing.Size(126, 20)
        Me.tCodigoBarra.TabIndex = 51
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(607, 86)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 13)
        Me.Label4.TabIndex = 50
        Me.Label4.Text = "Cantidad"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(10, 86)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 13)
        Me.Label3.TabIndex = 49
        Me.Label3.Text = "Codigo Barra"
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
        Me.Grid1.ColCount = 7
        Me.Grid1.ColWidthEntries.AddRange(New Syncfusion.Windows.Forms.Grid.GridColWidth() {New Syncfusion.Windows.Forms.Grid.GridColWidth(0, 35), New Syncfusion.Windows.Forms.Grid.GridColWidth(1, 52), New Syncfusion.Windows.Forms.Grid.GridColWidth(2, 57), New Syncfusion.Windows.Forms.Grid.GridColWidth(3, 115), New Syncfusion.Windows.Forms.Grid.GridColWidth(4, 274)})
        Me.Grid1.DefaultRowHeight = 20
        Me.Grid1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Grid1.GridOfficeScrollBars = Syncfusion.Windows.Forms.OfficeScrollBars.Metro
        Me.Grid1.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Metro
        Me.Grid1.Location = New System.Drawing.Point(12, 128)
        Me.Grid1.MetroScrollBars = True
        Me.Grid1.Name = "Grid1"
        GridRangeStyle1.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Cell(0, 1)
        GridRangeStyle1.StyleInfo.Text = "Pasillo"
        GridRangeStyle2.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Cell(0, 2)
        GridRangeStyle2.StyleInfo.Text = "Módulo"
        GridRangeStyle3.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Cell(0, 3)
        GridRangeStyle3.StyleInfo.Text = "Cod.Barra"
        GridRangeStyle4.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Cell(0, 4)
        GridRangeStyle4.StyleInfo.Text = "Descripción"
        GridRangeStyle5.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Cell(0, 5)
        GridRangeStyle5.StyleInfo.Text = "Cantidad"
        GridRangeStyle6.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Cell(0, 6)
        GridRangeStyle6.StyleInfo.Text = "ID Loc"
        GridRangeStyle7.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Cell(0, 7)
        GridRangeStyle7.StyleInfo.Text = "ID Prod"
        Me.Grid1.RangeStyles.AddRange(New Syncfusion.Windows.Forms.Grid.GridRangeStyle() {GridRangeStyle1, GridRangeStyle2, GridRangeStyle3, GridRangeStyle4, GridRangeStyle5, GridRangeStyle6, GridRangeStyle7})
        Me.Grid1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Grid1.RowHeightEntries.AddRange(New Syncfusion.Windows.Forms.Grid.GridRowHeight() {New Syncfusion.Windows.Forms.Grid.GridRowHeight(0, 25)})
        Me.Grid1.SerializeCellsBehavior = Syncfusion.Windows.Forms.Grid.GridSerializeCellsBehavior.SerializeAsRangeStylesIntoCode
        Me.Grid1.Size = New System.Drawing.Size(759, 233)
        Me.Grid1.SmartSizeBox = False
        Me.Grid1.TabIndex = 48
        Me.Grid1.ThemesEnabled = True
        Me.Grid1.UseRightToLeftCompatibleTextBox = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(377, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 47
        Me.Label1.Text = "Bodega"
        '
        'cmbBodegas
        '
        Me.cmbBodegas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbBodegas.FormattingEnabled = True
        Me.cmbBodegas.Location = New System.Drawing.Point(380, 42)
        Me.cmbBodegas.Name = "cmbBodegas"
        Me.cmbBodegas.Size = New System.Drawing.Size(175, 21)
        Me.cmbBodegas.TabIndex = 46
        '
        'tNumDocCliente
        '
        Me.tNumDocCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tNumDocCliente.Location = New System.Drawing.Point(670, 43)
        Me.tNumDocCliente.Name = "tNumDocCliente"
        Me.tNumDocCliente.Size = New System.Drawing.Size(103, 20)
        Me.tNumDocCliente.TabIndex = 66
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(667, 27)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(77, 13)
        Me.Label6.TabIndex = 65
        Me.Label6.Text = "N° Doc.Cliente"
        '
        'fSalidaBodega
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(783, 466)
        Me.Controls.Add(Me.tNumDocCliente)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.tModulo)
        Me.Controls.Add(Me.tPasillo)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.lNombreCliente)
        Me.Controls.Add(Me.tRutCliente)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lMotivo)
        Me.Controls.Add(Me.cmbMotivos)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.labelDescripcion)
        Me.Controls.Add(Me.lDescripcion)
        Me.Controls.Add(Me.tCantidad)
        Me.Controls.Add(Me.tCodigoBarra)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Grid1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmbBodegas)
        Me.Controls.Add(Me.tObservaciones)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Name = "fSalidaBodega"
        Me.Text = "Salida de Bodega"
        CType(Me.tCantidad, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Grid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents tObservaciones As System.Windows.Forms.TextBox
    Friend WithEvents tModulo As System.Windows.Forms.TextBox
    Friend WithEvents tPasillo As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents lNombreCliente As System.Windows.Forms.Label
    Friend WithEvents tRutCliente As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lMotivo As System.Windows.Forms.Label
    Friend WithEvents cmbMotivos As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents labelDescripcion As System.Windows.Forms.Label
    Friend WithEvents lDescripcion As System.Windows.Forms.Label
    Friend WithEvents tCantidad As System.Windows.Forms.NumericUpDown
    Friend WithEvents tCodigoBarra As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Grid1 As Syncfusion.Windows.Forms.Grid.GridControl
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmbBodegas As System.Windows.Forms.ComboBox
    Friend WithEvents tNumDocCliente As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
End Class
