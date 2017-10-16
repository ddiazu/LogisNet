Imports System.Data.SqlClient

Public Class ngDestinatario
    Public Function DatosDestinatarioporId(idEmpresa As Long, idDestinatario As Long) As clsDestinatario
        Dim destinatario As New clsDestinatario
        AbrirConexion()
        Dim cm As New SqlCommand("select top 1 * from Destinatario where idEmpresa=" + idEmpresa.ToString() + " and idDestinatario=" + idDestinatario.ToString(), Cn)
        Dim Dr As SqlDataReader = cm.ExecuteReader
        If Dr.Read Then
            destinatario.idDestinatario = Dr("idDestinatario")
            destinatario.rut = Dr("rut")
            destinatario.razonSocial = Dr("razonSocial")
            destinatario.giro = Dr("giro")
            destinatario.codCliente = Dr("codCliente")
        End If
        Dr.Close()
        Dr = Nothing
        cm = Nothing
        CerrarConexion()
        Return destinatario
    End Function
    Public Function DatosDestinatarioporRut(idEmpresa As Long, rut As String) As clsDestinatario
        Dim destinatario As New clsDestinatario
        AbrirConexion()
        Dim cm As New SqlCommand("select top 1 * from Destinatario where idEmpresa=" + idEmpresa.ToString() + " and rut=" + rut.ToString(), Cn)
        Dim Dr As SqlDataReader = cm.ExecuteReader
        If Dr.Read Then
            destinatario.idDestinatario = Dr("idDestinatario")
            destinatario.rut = Dr("rut")
            destinatario.razonSocial = Dr("razonSocial")
            destinatario.giro = Dr("giro")
            destinatario.codCliente = Dr("codCliente")
        End If
        Dr.Close()
        Dr = Nothing
        cm = Nothing
        CerrarConexion()
        Return destinatario
    End Function
    Public Function DatosDestinatarioporCodCliente(idEmpresa As Long, codCliente As String) As clsDestinatario
        Dim destinatario As New clsDestinatario
        AbrirConexion()
        Dim cm As New SqlCommand("select top 1 * from Destinatario where idEmpresa=" + idEmpresa.ToString() + " and codCliente=" + codCliente.ToString(), Cn)
        Dim Dr As SqlDataReader = cm.ExecuteReader
        If Dr.Read Then
            destinatario.idDestinatario = Dr("idDestinatario")
            destinatario.rut = Dr("rut")
            destinatario.razonSocial = Dr("razonSocial")
            destinatario.giro = Dr("giro")
            destinatario.codCliente = Dr("codCliente")
        End If
        Dr.Close()
        Dr = Nothing
        cm = Nothing
        CerrarConexion()
        Return destinatario
    End Function

    Public Function listaDestinatarios(idEmpresa As Long, buscar As String) As List(Of clsDestinatario)
        Dim lista As New List(Of clsDestinatario)
        AbrirConexion()
        Dim cm As New SqlCommand("select * from destinatarios where idEmpresa=" + idEmpresa.ToString() + " and razonSocial like '%" + buscar.ToString() + "%' order by razonSocial", Cn)

        Dim dr As SqlDataReader = cm.ExecuteReader

        Do While dr.Read
            lista.Add(New clsDestinatario With {.codCliente = dr("codCliente"),
                                                 .razonSocial = dr("razonSocial"),
                                                 .rut = dr("rut"),
                                                 .giro = dr("giro"),
                                                 .idDestinatario = dr("idDestinatario")})
        Loop
        dr.Close()
        dr = Nothing
        cm = Nothing
        CerrarConexion()

        Return lista
    End Function

End Class
