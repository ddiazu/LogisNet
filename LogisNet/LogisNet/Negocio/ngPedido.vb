Imports System.Data.SqlClient


Public Class ngPedido
    Public Function agregarPedido(p As clsPedido, detalle As List(Of clsDetallePedido)) As Long
        Dim IdPedido As Long = 0
        AbrirConexion()
        Dim cm As New SqlCommand("agregarPedido idEmpresa=" + p.idEmpresa.ToString() + ", dest_rut='" + p.dest_rut + "', @dest_nombre='" + p.dest_nombre +
                                 "', @dest_giro='" + p.dest_giro + "', @dest_direccion='" + p.dest_direccion + "', @dest_comuna='" + p.dest_comuna +
                                 "', @dest_ciudad='" + p.dest_ciudad + "', @observaciones='" + p.observaciones + "', @usuariosolicitante='" + p.usuarioSolicitante +
                                 "', @idUsuario=" + p.idUsuario.ToString + ", @numeroPedido=" + p.numeroPedido.ToString, Cn)
        Dim dr As SqlDataReader = cm.ExecuteReader
        If dr.Read Then
            IdPedido = dr("Id")
        End If
        dr.Close()
        For Each d In detalle
            cm.CommandText = "insert into pedido_detalle(idPedido, idProducto, cantidad_solicitada, cantidad_aceptada) values(" + IdPedido.ToString + ", " +
            d.idProducto.ToString + ", " + d.cantidadSolicitada.ToString + ", " + d.cantidadAceptada.ToString + ")"
            cm.ExecuteNonQuery()
        Next
        cm = Nothing
        Return IdPedido
    End Function
End Class
