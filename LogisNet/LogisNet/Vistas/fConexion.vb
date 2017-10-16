Imports System.IO

Partial Public Class fConexion
    Inherits Syncfusion.Windows.Forms.MetroForm


    Private Sub Grabar()
        Dim Servidor As String = ""
        Dim ServidorExt As String = ""
        Dim BaseDatos As String = ""
        Dim Usuario As String = ""
        Dim Clave As String = ""
        Dim nombreArchivo As String = ""
        nombreArchivo = Application.StartupPath + "\cnx.cfg"
        Dim archivo As New StreamWriter(nombreArchivo)

        Servidor = tServidor.Text
        ServidorExt = tServidorExt.Text
        BaseDatos = tBaseDatos.Text
        Usuario = tUsuario.Text
        Clave = tClave.Text
        archivo.WriteLine(Encriptar(Servidor))
        archivo.WriteLine(Encriptar(ServidorExt))
        archivo.WriteLine(Encriptar(BaseDatos))
        archivo.WriteLine(Encriptar(Usuario))
        archivo.WriteLine(Encriptar(Clave))

        archivo.Close()

        Close()

        MsgBox("Los datos de Conexión han sido grabados, vuelva a entrar al programa", vbOKOnly, "Mensaje")

        End


    End Sub

    Private Sub fConexion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim nomarch As String = Application.StartupPath + "\cnx.cfg"
        If File.Exists(nomarch) Then
            Dim archivo As New StreamReader(nomarch)

            On Error GoTo control
            tServidor.Text = Desencriptar(archivo.ReadLine)
            tServidorExt.Text = Desencriptar(archivo.ReadLine)
            tBaseDatos.Text = Desencriptar(archivo.ReadLine)
            tUsuario.Text = Desencriptar(archivo.ReadLine)
            tClave.Text = Desencriptar(archivo.ReadLine)

            archivo.Close()
            archivo = Nothing


        End If

control:
        MsgBox("Existe un error en el archivo de conexión", vbOKOnly, "Mensaje")

    End Sub

    Private Sub ButtonAdv1_Click(sender As Object, e As EventArgs) Handles ButtonAdv1.Click
        Grabar()
    End Sub

    Private Sub ButtonAdv2_Click(sender As Object, e As EventArgs) Handles ButtonAdv2.Click
        Close()
    End Sub

    Private Sub fConexion_KeyUp(sender As Object, e As KeyEventArgs) Handles MyBase.KeyUp
        If e.KeyCode = Keys.Escape Then
            Close()
        End If
    End Sub
End Class