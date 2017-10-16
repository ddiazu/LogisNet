<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fConexion
    Inherits Syncfusion.Windows.Forms.MetroForm

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
        Me.components = New System.ComponentModel.Container()
        Me.ButtonAdv1 = New Syncfusion.Windows.Forms.ButtonAdv()
        Me.ButtonAdv2 = New Syncfusion.Windows.Forms.ButtonAdv()
        Me.tClave = New System.Windows.Forms.TextBox()
        Me.tUsuario = New System.Windows.Forms.TextBox()
        Me.tBaseDatos = New System.Windows.Forms.TextBox()
        Me.tServidor = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tServidorExt = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ButtonAdv1
        '
        Me.ButtonAdv1.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro
        Me.ButtonAdv1.BackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(218, Byte), Integer))
        Me.ButtonAdv1.Location = New System.Drawing.Point(244, 139)
        Me.ButtonAdv1.Name = "ButtonAdv1"
        Me.ButtonAdv1.Size = New System.Drawing.Size(86, 35)
        Me.ButtonAdv1.TabIndex = 20
        Me.ButtonAdv1.Text = "Grabar"
        Me.ButtonAdv1.UseVisualStyle = True
        '
        'ButtonAdv2
        '
        Me.ButtonAdv2.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro
        Me.ButtonAdv2.BackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(218, Byte), Integer))
        Me.ButtonAdv2.Location = New System.Drawing.Point(336, 139)
        Me.ButtonAdv2.Name = "ButtonAdv2"
        Me.ButtonAdv2.Size = New System.Drawing.Size(86, 35)
        Me.ButtonAdv2.TabIndex = 21
        Me.ButtonAdv2.Text = "Salir"
        Me.ButtonAdv2.UseVisualStyle = True
        '
        'tClave
        '
        Me.tClave.Location = New System.Drawing.Point(118, 139)
        Me.tClave.Name = "tClave"
        Me.tClave.Size = New System.Drawing.Size(100, 20)
        Me.tClave.TabIndex = 33
        '
        'tUsuario
        '
        Me.tUsuario.Location = New System.Drawing.Point(118, 112)
        Me.tUsuario.Name = "tUsuario"
        Me.tUsuario.Size = New System.Drawing.Size(100, 20)
        Me.tUsuario.TabIndex = 32
        '
        'tBaseDatos
        '
        Me.tBaseDatos.Location = New System.Drawing.Point(118, 85)
        Me.tBaseDatos.Name = "tBaseDatos"
        Me.tBaseDatos.Size = New System.Drawing.Size(196, 20)
        Me.tBaseDatos.TabIndex = 31
        '
        'tServidor
        '
        Me.tServidor.Location = New System.Drawing.Point(118, 32)
        Me.tServidor.Name = "tServidor"
        Me.tServidor.Size = New System.Drawing.Size(196, 20)
        Me.tServidor.TabIndex = 30
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(19, 142)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(34, 13)
        Me.Label4.TabIndex = 29
        Me.Label4.Text = "Clave"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(19, 114)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 13)
        Me.Label3.TabIndex = 28
        Me.Label3.Text = "Usuario"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(19, 87)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 13)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "Base de Datos"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(19, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 13)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "Servidor Interno"
        '
        'tServidorExt
        '
        Me.tServidorExt.Location = New System.Drawing.Point(118, 58)
        Me.tServidorExt.Name = "tServidorExt"
        Me.tServidorExt.Size = New System.Drawing.Size(196, 20)
        Me.tServidorExt.TabIndex = 35
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(19, 61)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(85, 13)
        Me.Label5.TabIndex = 34
        Me.Label5.Text = "Servidor Externo"
        '
        'fConexion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(433, 187)
        Me.Controls.Add(Me.tServidorExt)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.tClave)
        Me.Controls.Add(Me.tUsuario)
        Me.Controls.Add(Me.tBaseDatos)
        Me.Controls.Add(Me.tServidor)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ButtonAdv2)
        Me.Controls.Add(Me.ButtonAdv1)
        Me.KeyPreview = True
        Me.Name = "fConexion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Datos de Conexión a la Base de Datos"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ButtonAdv1 As Syncfusion.Windows.Forms.ButtonAdv
    Friend WithEvents ButtonAdv2 As Syncfusion.Windows.Forms.ButtonAdv
    Friend WithEvents tClave As System.Windows.Forms.TextBox
    Friend WithEvents tUsuario As System.Windows.Forms.TextBox
    Friend WithEvents tBaseDatos As System.Windows.Forms.TextBox
    Friend WithEvents tServidor As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tServidorExt As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
End Class
