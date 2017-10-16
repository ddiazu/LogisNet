<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fStockProducto
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
        Me.Grid1 = New Syncfusion.Windows.Forms.Grid.GridControl()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lBodega = New System.Windows.Forms.Label()
        Me.lDescripcion = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lCodigoBarra = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        CType(Me.Grid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.Grid1.ColCount = 6
        Me.Grid1.ColWidthEntries.AddRange(New Syncfusion.Windows.Forms.Grid.GridColWidth() {New Syncfusion.Windows.Forms.Grid.GridColWidth(0, 35), New Syncfusion.Windows.Forms.Grid.GridColWidth(1, 21), New Syncfusion.Windows.Forms.Grid.GridColWidth(5, 165)})
        Me.Grid1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Grid1.Location = New System.Drawing.Point(9, 72)
        Me.Grid1.Name = "Grid1"
        GridRangeStyle1.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Cell(0, 1)
        GridRangeStyle1.StyleInfo.Text = "IDLocacion"
        GridRangeStyle2.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Cell(0, 2)
        GridRangeStyle2.StyleInfo.Text = "Pasillo"
        GridRangeStyle3.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Cell(0, 3)
        GridRangeStyle3.StyleInfo.Text = "Módulo"
        GridRangeStyle4.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Cell(0, 4)
        GridRangeStyle4.StyleInfo.Text = "Cod.Barra"
        GridRangeStyle5.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Cell(0, 5)
        GridRangeStyle5.StyleInfo.Text = "Descripción"
        GridRangeStyle6.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Cell(0, 6)
        GridRangeStyle6.StyleInfo.Text = "Cantidad"
        Me.Grid1.RangeStyles.AddRange(New Syncfusion.Windows.Forms.Grid.GridRangeStyle() {GridRangeStyle1, GridRangeStyle2, GridRangeStyle3, GridRangeStyle4, GridRangeStyle5, GridRangeStyle6})
        Me.Grid1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Grid1.RowHeightEntries.AddRange(New Syncfusion.Windows.Forms.Grid.GridRowHeight() {New Syncfusion.Windows.Forms.Grid.GridRowHeight(0, 25)})
        Me.Grid1.SerializeCellsBehavior = Syncfusion.Windows.Forms.Grid.GridSerializeCellsBehavior.SerializeAsRangeStylesIntoCode
        Me.Grid1.Size = New System.Drawing.Size(656, 172)
        Me.Grid1.SmartSizeBox = False
        Me.Grid1.TabIndex = 5
        Me.Grid1.UseRightToLeftCompatibleTextBox = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Bodega"
        '
        'lBodega
        '
        Me.lBodega.BackColor = System.Drawing.Color.Lavender
        Me.lBodega.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lBodega.Location = New System.Drawing.Point(79, 9)
        Me.lBodega.Name = "lBodega"
        Me.lBodega.Size = New System.Drawing.Size(310, 20)
        Me.lBodega.TabIndex = 10
        Me.lBodega.Text = "Label2"
        '
        'lDescripcion
        '
        Me.lDescripcion.BackColor = System.Drawing.Color.Lavender
        Me.lDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lDescripcion.Location = New System.Drawing.Point(79, 39)
        Me.lDescripcion.Name = "lDescripcion"
        Me.lDescripcion.Size = New System.Drawing.Size(310, 20)
        Me.lDescripcion.TabIndex = 11
        Me.lDescripcion.Text = "Label2"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 40)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 13)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Descripción"
        '
        'lCodigoBarra
        '
        Me.lCodigoBarra.BackColor = System.Drawing.Color.Lavender
        Me.lCodigoBarra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lCodigoBarra.Location = New System.Drawing.Point(490, 39)
        Me.lCodigoBarra.Name = "lCodigoBarra"
        Me.lCodigoBarra.Size = New System.Drawing.Size(165, 20)
        Me.lCodigoBarra.TabIndex = 13
        Me.lCodigoBarra.Text = "Label2"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(401, 40)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(83, 13)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Código de Barra"
        '
        'fStockProducto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(677, 256)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lCodigoBarra)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lDescripcion)
        Me.Controls.Add(Me.lBodega)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Grid1)
        Me.Name = "fStockProducto"
        Me.Text = "Stock Producto"
        CType(Me.Grid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Grid1 As Syncfusion.Windows.Forms.Grid.GridControl
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lBodega As System.Windows.Forms.Label
    Friend WithEvents lDescripcion As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lCodigoBarra As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
End Class
