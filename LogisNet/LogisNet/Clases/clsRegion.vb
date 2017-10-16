Public Class clsRegion
    Public idRegion As Long
    Public nombre As String

    Public Overrides Function ToString() As String
        Return nombre
    End Function
End Class
