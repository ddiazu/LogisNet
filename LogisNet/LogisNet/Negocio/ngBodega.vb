Imports System.Data.SqlClient
Public Class ngBodega
    Public Function Guardar(b As clsBodega) As Long
        Dim Id As Long = 0
        AbrirConexion()
        Dim cadena As String = "agregarBodega @idBodega=" + b.id.ToString + ", @codigoBodega='" + b.codigoBodega + _
            "', @nombre='" + b.nombre + "', @admiteDespacho=" + IIf(b.admiteDespacho, "1", "0")

        Dim cm As New SqlCommand(cadena, Cn)

        Dim dr As SqlDataReader = cm.ExecuteReader

        If dr.Read Then
            Id = dr("id")
        End If

        dr.Close()
        dr = Nothing
        cm = Nothing
        CerrarConexion()
        Return Id
    End Function

    Function listaBodegas() As List(Of clsBodega)
        Dim lista As New List(Of clsBodega)
        AbrirConexion()
        Dim cm As New SqlCommand("select * from bodegas order by nombre", Cn)
        Dim dr As SqlDataReader = cm.ExecuteReader

        Do While dr.Read
            Dim b As New clsBodega
            b.id = dr("idBodega")
            b.codigoBodega = dr("codigoBodega")
            b.nombre = dr("nombre")
            b.admiteDespacho = dr("admiteDespacho")
            lista.Add(b)

        Loop

        dr.Close()
        dr = Nothing
        cm = Nothing
        CerrarConexion()
        Return lista
    End Function
End Class
