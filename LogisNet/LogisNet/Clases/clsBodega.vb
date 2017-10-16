Public Class clsBodega
    Public id As Long
    Public codigoBodega As String
    Public nombre As String
    Public admiteDespacho As Boolean

    Public Overrides Function ToString() As String
        Return nombre
    End Function


End Class
