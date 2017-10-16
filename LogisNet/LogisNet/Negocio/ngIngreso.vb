Imports System.Data.SqlClient

Public Class ngIngreso
    Public Function grabar(I As clsIngreso) As Long
        AbrirConexion()

        Dim cm As New SqlCommand("agregarIngreso @idCliente=" + I.idCliente.ToString + ", @numDocCliente=" + _
                                 I.numeroDocumentoIngreso.ToString + ", @observaciones='" + I.observaciones + "'", Cn)

        Dim idIngreso As Long = 0

        Dim dr As SqlDataReader = cm.ExecuteReader

        If dr.Read Then
            idIngreso = dr("id")
        End If
        dr.Close()

        For Each d In I.detalle
            cm.CommandText = "agregarIngreso_detalle @idIngreso=" + idIngreso.ToString + _
                ", @idLocacion=" + d.idLocacion.ToString + ", @idProducto=" + d.idProducto.ToString + _
                ", @cantidad=" + d.cantidad.ToString

            cm.ExecuteNonQuery()
        Next

        CerrarConexion()
        Return idIngreso

    End Function

End Class
