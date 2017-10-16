Imports System.Data.SqlClient

Public Class ngGeneral

    Public Function listaComunas(idRegion As Long) As List(Of clsComuna)
        Dim lista As New List(Of clsComuna)

        AbrirConexion()
        Dim cm As New SqlCommand("select idComuna, nombre from comunas where idRegion=" + idRegion.ToString, Cn)
        Dim dr As SqlDataReader = cm.ExecuteReader

        Do While dr.Read
            lista.Add(New clsComuna With {.idRegion = idRegion, .idComuna = dr("idComuna"), .nombre = dr("nombre").ToString.Trim()})
        Loop
        dr.Close()
        cm = Nothing

        dr = Nothing
        CerrarConexion()
        Return lista

    End Function

    Public Function listaRegiones() As List(Of clsRegion)
        Dim lista As New List(Of clsRegion)

        AbrirConexion()
        Dim cm As New SqlCommand("select idRegion, nombre from regiones", Cn)
        Dim dr As SqlDataReader = cm.ExecuteReader

        Do While dr.Read
            lista.Add(New clsRegion With {.idRegion = dr("idRegion"), .nombre = dr("nombre").ToString.Trim()})
        Loop
        dr.Close()
        cm = Nothing

        dr = Nothing
        CerrarConexion()
        Return lista

    End Function
End Class
