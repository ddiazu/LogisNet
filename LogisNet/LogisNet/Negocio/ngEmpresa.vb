Imports System.Data.SqlClient

Public Class ngEmpresa
    Public Function Guardar(emp As clsCliente) As Long
        Dim Id As Long = 0
        AbrirConexion()
        Dim cadena As String = "agregarEmpresa @idEmpresa=" + emp.id.ToString + ", @rut='" + emp.rut + _
            "', @razonSocial='" + emp.razonsocial + "'"
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

    Function listaEmpresas(Optional buscar As String = "") As List(Of clsCliente)
        Dim lista As New List(Of clsCliente)
        AbrirConexion()

        Dim cm As New SqlCommand("select idEmpresa,rut, razonsocial from empresas where razonsocial like '%" + buscar + "%' order by razonsocial", Cn)
        Dim dr As SqlDataReader = cm.ExecuteReader

        Do While dr.Read
            Dim emp As New clsCliente
            emp.id = dr("idEmpresa")
            emp.razonsocial = dr("razonsocial")
            emp.rut = dr("rut")
            lista.Add(emp)

        Loop

        dr.Close()
        dr = Nothing
        cm = Nothing
        CerrarConexion()
        Return lista
    End Function

    Public Function DatosEmpresa(rut As String) As clsCliente
        Dim emp As New clsCliente
        AbrirConexion()

        Dim cm As New SqlCommand("select top 1 idEmpresa,rut, razonsocial from empresas where rut='" + rut + "' order by razonsocial", Cn)
        Dim dr As SqlDataReader = cm.ExecuteReader

        If dr.Read Then
            emp.id = dr("idEmpresa")
            emp.razonsocial = dr("razonsocial")
            emp.rut = dr("rut")
        End If
        dr.Close()
        dr = Nothing
        CerrarConexion()

        Return emp
    End Function
End Class
