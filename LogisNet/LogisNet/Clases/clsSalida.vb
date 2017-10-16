Public Class clsSalida
    Public idSalida As Long
    Public fecha As String
    Public idCliente As Long
    Public MotivoSalida As String
    Public numeroDocumentoSalida As String
    Public observaciones As String
    Public estado As Integer

    Public detalle As New List(Of clsDetalleDocumento)
End Class
