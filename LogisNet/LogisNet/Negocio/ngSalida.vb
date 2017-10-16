Imports System.Data.SqlClient

Public Class ngSalida
    Public Function grabar(I As clsSalida) As Long
        AbrirConexion()

        Dim cm As New SqlCommand("agregarSalida @idCliente=" + I.idCliente.ToString + ", @numDocSalida=" + _
                                 I.numeroDocumentoSalida.ToString + ", @observaciones='" + I.observaciones + "'", Cn)

        Dim idSalida As Long = 0

        Dim dr As SqlDataReader = cm.ExecuteReader

        If dr.Read Then
            idSalida = dr("id")
        End If
        dr.Close()

        For Each d In I.detalle
            cm.CommandText = "agregarSalida_detalle @idSalida=" + idSalida.ToString + _
                ", @idLocacion=" + d.idLocacion.ToString + ", @idProducto=" + d.idProducto.ToString + _
                ", @cantidad=" + d.cantidad.ToString

            cm.ExecuteNonQuery()
        Next

        CerrarConexion()
        Return idSalida

    End Function

End Class
