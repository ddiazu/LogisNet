Imports System.Data.SqlClient

Public Class ngDirecciones
    Public Function DestinatarioDirecciones(idDestinatario As Long) As List(Of clsDireccion)
        Dim lista As New List(Of clsDireccion)
        AbrirConexion()
        Dim cm As New SqlCommand("select * from direcciones where idDestinatario=" + idDestinatario.ToString(), Cn)
        Dim Dr As SqlDataReader = cm.ExecuteReader
        Do While Dr.Read
            lista.Add(New clsDireccion With {.idDireccion = Dr("idDireccion"),
                                              .direccion = Dr("direccion"),
                                              .comuna = Dr("comuna"),
                                              .ciudad = Dr("ciudad"),
                                              .idComuna = Dr("idComuna"),
                                              .idCiudad = Dr("idCiudad"),
                                             .codSucursal = Dr("codSucursal")})
        Loop
        Dr.Close()
        Dr = Nothing
        cm = Nothing
        CerrarConexion()
        Return lista
    End Function
End Class
