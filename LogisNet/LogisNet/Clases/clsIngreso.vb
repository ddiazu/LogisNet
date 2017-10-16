Public Class clsIngreso
    Public idIngreso As Long
    Public fecha As String
    Public MotivoIngreso As String
    Public numeroDocumentoIngreso As String
    Public idCliente As Long
    Public observaciones As String
    Public estado As Integer
    Public detalle As New List(Of clsDetalleDocumento)
End Class
