Imports System.Data.SqlClient

Public Class ngProducto
    Public Function buscarCodigoProducto(idEmpresa As Integer, codProducto As String) As clsProducto
        Dim prod As New clsProducto
        AbrirConexion()
        Dim cm As New SqlCommand("select top 1 * from productos where idEmpresa=" + idEmpresa.ToString + _
                                 " and codProducto='" + codProducto + "' order by razonsocial", Cn)
        Dim dr As SqlDataReader = cm.ExecuteReader

        If dr.Read Then
            prod.idProducto = dr("idProducto")
            prod.idEmpresa = dr("idEmpresa")
            prod.codProducto = dr("codProducto")
            prod.codBarra = dr("codBarra")
            prod.nombre = dr("nombre")
            prod.peso = dr("peso")
        End If
        dr.Close()
        dr = Nothing
        CerrarConexion()

        Return prod
    End Function
    Public Function buscarCodBarraProducto(idEmpresa As Integer, codBarra As String) As clsProducto
        Dim prod As New clsProducto
        AbrirConexion()
        Dim cm As New SqlCommand("select top 1 * from productos where idEmpresa=" + idEmpresa.ToString + _
                                 " and codBarra='" + codBarra + "'", Cn)
        Dim dr As SqlDataReader = cm.ExecuteReader

        If dr.Read Then
            prod.idProducto = dr("idProducto")
            prod.idEmpresa = dr("idEmpresa")
            prod.codProducto = dr("codProducto")
            prod.codBarra = dr("codBarra")
            prod.nombre = dr("nombre")
            prod.peso = dr("peso")
        End If
        dr.Close()
        dr = Nothing
        CerrarConexion()

        Return prod
    End Function
    Public Function buscarNombreProducto(idEmpresa As Integer, nombre As String) As List(Of clsProducto)
        Dim lista As New List(Of clsProducto)
        AbrirConexion()
        Dim cm As New SqlCommand("select * from productos where idEmpresa=" + idEmpresa.ToString + _
                      " and nombre like '%" + nombre + "%'", Cn)
        Dim dr As SqlDataReader = cm.ExecuteReader

        Do While dr.Read
            Dim prod As New clsProducto
            prod.idProducto = dr("idProducto")
            prod.codProducto = dr("codProducto")
            prod.codBarra = dr("codBarra")
            prod.nombre = dr("nombre")
            lista.Add(prod)
        Loop
        dr.Close()
        dr = Nothing
        CerrarConexion()

        Return lista
    End Function

    Function Producto_Stock_Locacion(idProducto As Long, idLocacion As Long) As Long
        AbrirConexion()
        Dim cm As New SqlCommand("StockProductoLocacion @idProducto=" + idProducto.ToString + _
                                 ", @idLocacion=" + idLocacion.ToString, Cn)
        Dim dr As SqlDataReader = cm.ExecuteReader
        Dim stock As Long = 0
        If dr.Read Then
            stock = dr("cantidad")
        End If
        dr.Close()
        cm = Nothing
        CerrarConexion()

        Return stock
    End Function
    Function Producto_Stock_Despacho(idProducto As Long) As List(Of clsStock)
        AbrirConexion()
        Dim cm As New SqlCommand("StockProductoDespacho @idProducto=" + idProducto.ToString, Cn)
        Dim dr As SqlDataReader = cm.ExecuteReader
        Dim lista As New List(Of clsStock)
        Do While dr.Read
            lista.Add(New clsStock With {.idLocacion = dr("idLocacion"),
                                         .Pasillo = dr("pasillo"),
                                         .Modulo = dr("modulo"),
                                         .Cantidad = dr("cantidad")})

        Loop
        dr.Close()
        cm = Nothing
        CerrarConexion()
        Return lista
    End Function


    Function Movimientos(idProducto As Long) As List(Of clsMovimiento)
        Dim lista As New List(Of clsMovimiento)
        AbrirConexion()
        Dim cm As New SqlCommand("movimientosProducto @idProducto=" + idProducto.ToString, Cn)
        Dim dr As SqlDataReader = cm.ExecuteReader
        Do While dr.Read
            lista.Add(New clsMovimiento With {.fecha = dr("fecha"),
                                         .numeroMovimiento = dr("numeroMovimiento"),
                                         .numeroDocumento = dr("numeroDocumento"),
                                         .ingreso = dr("ingreso"),
                                         .salida = dr("salida"),
                                         .observaciones = dr("observaciones")})
        Loop
        dr.Close()
        cm = Nothing
        CerrarConexion()
        Return lista
    End Function

    Function stockClienteBodegaDetallado(idCliente As Long, idBodega As Long) As List(Of clsStock)
        Dim lista As New List(Of clsStock)
        AbrirConexion()
        Dim cm As New SqlCommand("stockClienteporBodegaDetallado @idEmpresa=" + idCliente.ToString + ", @idBodega=" + idBodega.ToString, Cn)
        Dim dr As SqlDataReader = cm.ExecuteReader
        Do While dr.Read
            lista.Add(New clsStock With {.codProducto = dr("codProducto"),
                                         .codBarra = dr("codBarra"),
                                         .nombre = dr("nombre"),
                                         .Pasillo = dr("Pasillo"),
                                         .Modulo = dr("modulo"),
                                         .Cantidad = dr("cantidad")
                                        })
        Loop
        dr.Close()
        cm = Nothing
        CerrarConexion()
        Return lista
    End Function
    Function stockClienteBodega(idCliente As Long, idBodega As Long) As List(Of clsStock)
        Dim lista As New List(Of clsStock)
        AbrirConexion()
        Dim cm As New SqlCommand("stockClienteporBodega @idEmpresa=" + idCliente.ToString + ", @idBodega=" + idBodega.ToString, Cn)
        Dim dr As SqlDataReader = cm.ExecuteReader
        Do While dr.Read
            lista.Add(New clsStock With {.codProducto = dr("codProducto"),
                                         .codBarra = dr("codBarra"),
                                         .nombre = dr("nombre"),
                                         .Cantidad = dr("total")
                                        })
        Loop
        dr.Close()
        cm = Nothing
        CerrarConexion()
        Return lista
    End Function
End Class
