Imports System.Data.SqlClient

Public Class ngLocacion
    Public Function grabar(l As clsLocacion) As Long
        Dim id As Long = 0
        AbrirConexion()
        Dim cm As New SqlCommand("agregarLocacion @idLocacion=" + l.idLocacion.ToString + _
                                 ", @idBodega=" + l.idBodega.ToString + ", @pasillo='" + l.pasillo + _
                                 "', @modulo='" + l.modulo + "'", Cn)

        Dim dr As SqlDataReader = cm.ExecuteReader

        If dr.Read Then
            id = dr("id")
        End If
        dr.Close()
        cm = Nothing
        dr = Nothing
        CerrarConexion()

        Return id
    End Function
    Function listaLocaciones(idBodega As Long) As List(Of clsLocacion)
        Dim lista As New List(Of clsLocacion)
        AbrirConexion()
        Dim cm As New SqlCommand("select * from locaciones where idBodega=" + idBodega.ToString + " order by pasillo, modulo", Cn)
        Dim dr As SqlDataReader = cm.ExecuteReader

        Do While dr.Read
            Dim l As New clsLocacion
            l.idLocacion = dr("idLocacion")
            l.idBodega = dr("idBodega")
            l.pasillo = dr("pasillo")
            l.modulo = dr("modulo")

            lista.Add(l)

        Loop

        dr.Close()
        dr = Nothing
        cm = Nothing
        CerrarConexion()
        Return lista
    End Function
End Class
