Imports System.Text
Imports System.Security.Cryptography
Imports System.IO
Imports System.Data.SqlClient
Imports System.Net.Mail
Imports System.Xml.Serialization

Module libreria
    Public stringConexion As String = ""
    Public carpetaTemporal As String = Application.StartupPath + "\Temporal"
    Public global_idUsuario As Long = 0
    Public global_nombreUsuario As String = ""
    Public global_ServidorDeDatos As String = ""
    Public Cn As New System.Data.SqlClient.SqlConnection
    Public TasaIva As Decimal = 19

    Public Sub CargarParametros(TipoConexion As String)
        Dim nombreArchivo As String
        nombreArchivo = Application.StartupPath + "\cnx.cfg"

        If Not File.Exists(nombreArchivo) Then
            Dim w As New fConexion
            w.ShowDialog()
            w = Nothing
            If Not File.Exists(nombreArchivo) Then
                End
            End If
        End If

        Dim archivo As New StreamReader(nombreArchivo)
        Dim ServidorInt As String = Desencriptar(archivo.ReadLine)
        Dim ServidorExt As String = Desencriptar(archivo.ReadLine)

        global_ServidorDeDatos = IIf(TipoConexion = 1, ServidorInt, ServidorExt)

        stringConexion = "Data Source=" + global_ServidorDeDatos + ";Initial Catalog=" + Desencriptar(archivo.ReadLine) + _
            ";User ID=" + Desencriptar(archivo.ReadLine) + ";Password=" + Desencriptar(archivo.ReadLine)

        Cn.ConnectionString = stringConexion


        archivo.Close()
        archivo = Nothing

    End Sub

    Public Function AbrirConexion() As Integer
        On Error GoTo Control
        If Cn.State = ConnectionState.Broken Then
            Cn.Close()
            Cn.Open()
        ElseIf Cn.State = ConnectionState.Closed Then
            Cn.Open()
        End If
        Return 1

Control:
        Dim w As New fConexion

        w.ShowDialog()
        MsgBox("Debe volver a ingresar al sistema para cargar los nuevos datos de conexión", vbOKOnly, "Mensaje")

        End

    End Function

    Public Function CerrarConexion() As Integer
        Cn.Close()
        Return 1
    End Function

    Function FormatoFecha(Fecha As String) As String
        Return Right(Fecha, 2) + "/" + Left(Right(Fecha, 4), 2) + "/" + Mid(Fecha, 1, 4)
    End Function

    Function FormatRut(tRut As String, Tipo As Byte) As String
        Dim Verif As String = ""
        Dim Rt As String = ""
        FormatRut = ""
        If Not tRut <> Space(0) Then
            Exit Function
        End If
        Try
            If Tipo = 1 Then
                Verif = Mid(tRut, Len(tRut))
                If InStr(tRut, "-") > 0 Then
                    Rt = Format(CLng(Mid(tRut, 1, Len(tRut) - 2)), "###,###,##0")
                Else
                    Rt = Format(CLng(Mid(tRut, 1, Len(tRut) - 1)), "###,###,##0")
                End If
                FormatRut = UCase(Rt + "-" + Verif)
                If Not IsNumeric(Rt) Then
                    MsgBox("Error, ingrese nuevamente el Rut", vbOKOnly, "Mensaje")
                    FormatRut = ""
                ElseIf Verificador(Trim(CDbl(Rt))) <> UCase(Verif) Then
                    MsgBox("Error, ingrese nuevamente el Rut", vbOKOnly, "Mensaje")
                    FormatRut = ""
                End If
            Else
                If InStr(tRut, "-") > 0 Then
                    Rt = Trim(CLng(Mid(tRut, 1, Len(tRut) - 2)))
                Else
                    Rt = Trim(CLng(Mid(tRut, 1, Len(tRut) - 1)))
                End If
                FormatRut = UCase(Trim(Rt))
            End If

        Catch
            MsgBox("Verifique el formato del Rut ingresado, solo se admiten números y guión", vbOKOnly, "Mensaje")
            FormatRut = ""
        End Try

    End Function


    'Verifica un Rut
    Function Verificador(Rut As String) As String
        Dim residuo As Integer, Tot As Integer, Multiplicador As Integer
        Rut = Trim(Rut)
        Multiplicador = 2
        For X = Len(Rut) To 1 Step -1
            Tot = Tot + (Val(Mid(Rut, X, 1)) * Multiplicador)
            Multiplicador = IIf(Multiplicador = 7, 2, Multiplicador + 1)
        Next
        residuo = Tot Mod 11
        If residuo = 0 Then
            Verificador = "0"
        Else
            residuo = 11 - residuo
            Verificador = IIf(residuo = 10, "K", Trim(residuo))
        End If
    End Function
    Public Function Encriptar(ByVal Input As String) As String

        Dim IV() As Byte = ASCIIEncoding.ASCII.GetBytes("qualityi") 'La clave debe ser de 8 caracteres  
        Dim EncryptionKey() As Byte = Convert.FromBase64String("rpaSPvIvVLlrcmtzPU9/c67Gkj7yL1S5") 'No se puede alterar la cantidad de caracteres pero si la clave  
        Dim buffer() As Byte = Encoding.UTF8.GetBytes(Input)
        Dim des As TripleDESCryptoServiceProvider = New TripleDESCryptoServiceProvider
        des.Key = EncryptionKey
        des.IV = IV

        Return Convert.ToBase64String(des.CreateEncryptor().TransformFinalBlock(buffer, 0, buffer.Length()))

    End Function

    Public Function Desencriptar(ByVal Input As String) As String

        Dim IV() As Byte = ASCIIEncoding.ASCII.GetBytes("qualityi") 'La clave debe ser de 8 caracteres  
        Dim EncryptionKey() As Byte = Convert.FromBase64String("rpaSPvIvVLlrcmtzPU9/c67Gkj7yL1S5") 'No se puede alterar la cantidad de caracteres pero si la clave  
        Dim buffer() As Byte = Convert.FromBase64String(Input)
        Dim des As TripleDESCryptoServiceProvider = New TripleDESCryptoServiceProvider
        des.Key = EncryptionKey
        des.IV = IV
        Return Encoding.UTF8.GetString(des.CreateDecryptor().TransformFinalBlock(buffer, 0, buffer.Length()))
    End Function

    Public Sub ExportarGrid(miGrid As Syncfusion.Windows.Forms.Grid.GridControl)

        Dim gecc As New Syncfusion.GridExcelConverter.GridExcelConverterControl()


        Dim saveFileDialog As New SaveFileDialog()
        saveFileDialog.Filter = "Files(*.xls)|*.xls"
        saveFileDialog.DefaultExt = ".xls"

        If saveFileDialog.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            gecc.GridToExcel(miGrid.Model, saveFileDialog.FileName, Syncfusion.GridExcelConverter.ConverterOptions.ColumnHeaders)

            If MessageBox.Show("¿Desea Abrir el Archivo creado?", "Consulta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then
                Dim proc As New Process()
                proc.StartInfo.FileName = saveFileDialog.FileName
                proc.Start()
            End If
        End If
    End Sub

    Public Sub GridEditable(miGrid As Syncfusion.Windows.Forms.Grid.GridControl, Editable As Boolean)
        miGrid.ReadOnly = Not Editable
        miGrid.BrowseOnly = Not Editable
    End Sub

    Function listaMes() As List(Of String)

        Dim lista As New List(Of String)
        lista.Add("Enero")
        lista.Add("Febrero")
        lista.Add("Marzo")
        lista.Add("Abril")
        lista.Add("Mayo")
        lista.Add("Junio")
        lista.Add("Julio")
        lista.Add("Agosto")
        lista.Add("Septiembre")
        lista.Add("Octubre")
        lista.Add("Noviembre")
        lista.Add("Diciembre")
        Return lista

    End Function

    Function UltimoDiadelMes(Fecha As Date) As Date
        Return Fecha.AddMonths(1).AddDays(-1)
    End Function




    Public Function importarArchivoExcel(rutaExcel As String, Hoja As String) As DataTable
        Dim Cb As New OleDb.OleDbConnectionStringBuilder
        Cb.DataSource = rutaExcel
        If (Path.GetExtension(rutaExcel).ToUpper() = ".XLS") Then

            Cb.Provider = "Microsoft.Jet.OLEDB.4.0"
            Cb.Add("Extended Properties", "Excel 8.0;HDR=YES;IMEX=0;")

        ElseIf (Path.GetExtension(rutaExcel).ToUpper() = ".XLSX") Then

            Cb.Provider = "Microsoft.ACE.OLEDB.12.0"
            Cb.Add("Extended Properties", "Excel 12.0 Xml;HDR=YES;IMEX=1;MaxScanRows=0")
        End If

        Dim dt As DataTable = New DataTable("Datos")

        Dim conn = New OleDb.OleDbConnection(Cb.ConnectionString)

        conn.Open()

        Dim cmd As New OleDb.OleDbCommand



        cmd.CommandType = CommandType.Text
        cmd.CommandText = "SELECT * FROM [" + Hoja + "$]"
        cmd.Connection = conn

        Dim da As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter(cmd)
        da.Fill(dt)
        conn.Close()

        Return dt

    End Function

    Public Function PrecioSinIva(precio As Long, valorIva As Double, Decimales As Integer) As Long
        Return Math.Round(precio / (1 + (valorIva / 100)), Decimales)
    End Function




    Public Function PadL(cadena As String, Largo As Integer, Caracter As String) As String
        cadena = Mid(cadena, 1, Largo)
        cadena = Replicate(Caracter, Largo - Len(cadena)) + cadena
        Return cadena
    End Function
    Public Function PadR(cadena As String, Largo As Integer, Caracter As String) As String
        cadena = Mid(cadena, 1, Largo)
        cadena = cadena + Replicate(Caracter, Largo - Len(cadena))
        Return cadena
    End Function
    Public Function Replicate(caracter As String, largo As Integer) As String
        Dim cadena As String = ""
        For x = 1 To largo
            cadena += caracter
        Next
        Return cadena
    End Function


    Function archivo_A_binario(nombreArchivo As String) As Byte()
        Dim archivo As New FileStream(nombreArchivo, FileMode.Open, FileAccess.Read)
        Dim MyData(archivo.Length) As Byte
        archivo.Read(MyData, 0, archivo.Length)
        archivo.Close()
        Return MyData
    End Function

    Function DiasdelMes(ano As Integer, mes As Integer) As Integer
        Return DateTime.DaysInMonth(ano, mes)
    End Function

End Module
