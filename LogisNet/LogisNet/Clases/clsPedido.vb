Public Class clsPedido
    Public idPedido As Long
    Public idEmpresa As Long
    Public idDestintario As Long
    Public dest_rut As String
    Public dest_nombre As String
    Public dest_giro As String
    Public dest_direccion As String
    Public dest_comuna As String
    Public dest_ciudad As String
    Public observaciones As String
    Public idUsuario As Long
    Public usuarioSolicitante As String
    Public estado As Integer
    Public fecha As String
    Public fechaProceso As String
    Public horaProceso As String
    Public numeroPedido As Long 'numero de pedido u orden que envía el la librería a la Editorial

End Class
