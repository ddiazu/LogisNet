<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fBodegas
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
        Me.grid1 = New Syncfusion.Windows.Forms.Grid.GridControl()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnGrabar = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tCodigo = New System.Windows.Forms.TextBox()
        Me.tNombre = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.chkAdmiteDespacho = New System.Windows.Forms.CheckBox()
        CType(Me.grid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grid1
        '
        GridBaseStyle1.Name = "Column Header"
        GridBaseStyle1.StyleInfo.BaseStyle = "Header"
        GridBaseStyle1.StyleInfo.HorizontalAlignment = Syncfusion.Windows.Forms.Grid.GridHorizontalAlignment.Center
        GridBaseStyle2.Name = "Header"
        GridBaseStyle2.StyleInfo.Borders.Bottom = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.None)
        GridBaseStyle2.StyleInfo.Borders.Left = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.None)
        GridBaseStyle2.StyleInfo.Borders.Right = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.None)
        GridBaseStyle2.StyleInfo.Borders.Top = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.None)
        GridBaseStyle2.StyleInfo.CellType = "Header"
        GridBaseStyle2.StyleInfo.Font.Bold = True
        GridBaseStyle2.StyleInfo.Interior = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.FromArgb(CType(CType(203, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(184, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(216, Byte), Integer)))
        GridBaseStyle2.StyleInfo.VerticalAlignment = Syncfusion.Windows.Forms.Grid.GridVerticalAlignment.Middle
        GridBaseStyle3.Name = "Standard"
        GridBaseStyle3.StyleInfo.Font.Facename = "Tahoma"
        GridBaseStyle3.StyleInfo.Interior = New Syncfusion.Drawing.BrushInfo(System.Drawing.SystemColors.Window)
        GridBaseStyle4.Name = "Row Header"
        GridBaseStyle4.StyleInfo.BaseStyle = "Header"
        GridBaseStyle4.StyleInfo.HorizontalAlignment = Syncfusion.Windows.Forms.Grid.GridHorizontalAlignment.Left
        GridBaseStyle4.StyleInfo.Interior = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Horizontal, System.Drawing.Color.FromArgb(CType(CType(203, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(184, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(216, Byte), Integer)))
        Me.grid1.BaseStylesMap.AddRange(New Syncfusion.Windows.Forms.Grid.GridBaseStyle() {GridBaseStyle1, GridBaseStyle2, GridBaseStyle3, GridBaseStyle4})
        Me.grid1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.grid1.ColCount = 4
        Me.grid1.ColWidthEntries.AddRange(New Syncfusion.Windows.Forms.Grid.GridColWidth() {New Syncfusion.Windows.Forms.Grid.GridColWidth(0, 35), New Syncfusion.Windows.Forms.Grid.GridColWidth(1, 47), New Syncfusion.Windows.Forms.Grid.GridColWidth(2, 80), New Syncfusion.Windows.Forms.Grid.GridColWidth(3, 157)})
        Me.grid1.ForeColor = System.Drawing.SystemColors.ControlText
        GridCellInfo1.Col = -1
        GridCellInfo1.Row = -1
        GridCellInfo2.Col = 4
        GridCellInfo2.Row = -1
        GridCellInfo2.StyleInfo.CellType = "CheckBox"
        GridCellInfo2.StyleInfo.CellValueType = GetType(Boolean)
        GridCellInfo2.StyleInfo.HorizontalAlignment = Syncfusion.Windows.Forms.Grid.GridHorizontalAlignment.Center
        GridCellInfo2.StyleInfo.Text = ""
        GridCellInfo3.Col = 1
        GridCellInfo3.Row = 0
        GridCellInfo3.StyleInfo.Text = "ID"
        GridCellInfo4.Col = 2
        GridCellInfo4.Row = 0
        GridCellInfo4.StyleInfo.Text = "Codigo"
        GridCellInfo5.Col = 3
        GridCellInfo5.Row = 0
        GridCellInfo5.StyleInfo.Text = "Nombre "
        GridCellInfo6.Col = 4
        GridCellInfo6.Row = 0
        GridCellInfo6.StyleInfo.Text = "Admite Despacho"
        Me.grid1.GridCells.AddRange(New Syncfusion.Windows.Forms.Grid.GridCellInfo() {GridCellInfo1, GridCellInfo2, GridCellInfo3, GridCellInfo4, GridCellInfo5, GridCellInfo6})
        Me.grid1.Location = New System.Drawing.Point(12, 109)
        Me.grid1.Name = "grid1"
        Me.grid1.Properties.MarkColHeader = False
        Me.grid1.Properties.MarkRowHeader = False
        Me.grid1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.grid1.RowHeightEntries.AddRange(New Syncfusion.Windows.Forms.Grid.GridRowHeight() {New Syncfusion.Windows.Forms.Grid.GridRowHeight(0, 25)})
        Me.grid1.SerializeCellsBehavior = Syncfusion.Windows.Forms.Grid.GridSerializeCellsBehavior.SerializeIntoCode
        Me.grid1.Size = New System.Drawing.Size(422, 244)
        Me.grid1.SmartSizeBox = False
        Me.grid1.TabIndex = 27
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(323, 57)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(90, 30)
        Me.btnSalir.TabIndex = 26
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'btnGrabar
        '
        Me.btnGrabar.Location = New System.Drawing.Point(323, 21)
        Me.btnGrabar.Name = "btnGrabar"
        Me.btnGrabar.Size = New System.Drawing.Size(90, 30)
        Me.btnGrabar.TabIndex = 25
        Me.btnGrabar.Text = "Guardar"
        Me.btnGrabar.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(14, 20)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 13)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = "Código Bodega"
        '
        'tCodigo
        '
        Me.tCodigo.Location = New System.Drawing.Point(112, 17)
        Me.tCodigo.Name = "tCodigo"
        Me.tCodigo.Size = New System.Drawing.Size(69, 20)
        Me.tCodigo.TabIndex = 23
        '
        'tNombre
        '
        Me.tNombre.Location = New System.Drawing.Point(112, 44)
        Me.tNombre.Name = "tNombre"
        Me.tNombre.Size = New System.Drawing.Size(182, 20)
        Me.tNombre.TabIndex = 21
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Nombre"
        '
        'chkAdmiteDespacho
        '
        Me.chkAdmiteDespacho.AutoSize = True
        Me.chkAdmiteDespacho.Location = New System.Drawing.Point(112, 70)
        Me.chkAdmiteDespacho.Name = "chkAdmiteDespacho"
        Me.chkAdmiteDespacho.Size = New System.Drawing.Size(110, 17)
        Me.chkAdmiteDespacho.TabIndex = 28
        Me.chkAdmiteDespacho.Text = "Admite Despacho"
        Me.chkAdmiteDespacho.UseVisualStyleBackColor = True
        '
        'fBodegas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(443, 360)
        Me.Controls.Add(Me.chkAdmiteDespacho)
        Me.Controls.Add(Me.grid1)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnGrabar)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.tCodigo)
        Me.Controls.Add(Me.tNombre)
        Me.Controls.Add(Me.Label1)
        Me.Name = "fBodegas"
        Me.Text = "Bodegas"
        CType(Me.grid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grid1 As Syncfusion.Windows.Forms.Grid.GridControl
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents btnGrabar As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents tCodigo As System.Windows.Forms.TextBox
    Friend WithEvents tNombre As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents chkAdmiteDespacho As System.Windows.Forms.CheckBox
End Class
