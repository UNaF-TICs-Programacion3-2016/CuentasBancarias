
Public Class Persona
    Public Cuentas As New List(Of CuentaBancaria)

    Public Sub AddCuentaBancaria(oCuenta As CuentaBancaria)
        Cuentas.Add(oCuenta)
    End Sub

    Private Apellido As String
    Public Property Per_Apellido() As String
        Get
            Return Apellido
        End Get
        Set(ByVal value As String)
            Apellido = value
        End Set
    End Property

    Private Nombre As String
    Public Property Per_Nombre() As String
        Get
            Return Nombre
        End Get
        Set(ByVal value As String)
            Nombre = value
        End Set
    End Property

    Private CUIL As String
    Public Property Per_CUIL() As String
        Get
            Return CUIL
        End Get
        Set(ByVal value As String)
            CUIL = value
        End Set
    End Property

    Private Sexo As String
    Public Property Per_Sexo() As String
        Get
            Return Sexo
        End Get
        Set(ByVal value As String)
            Sexo = value
        End Set
    End Property

    Private Direccion As String
    Public Property Per_Direccion() As String
        Get
            Return Direccion
        End Get
        Set(ByVal value As String)
            Direccion = value
        End Set
    End Property

    Private Telefono As String
    Public Property Per_Telefono() As String
        Get
            Return Telefono
        End Get
        Set(ByVal value As String)
            Telefono = value
        End Set
    End Property


    '===========METODOS===========


    Public Function ValidarCUIL() As Boolean
        Dim NroVerificador As Integer
        Dim SumaCuil As Integer
        Dim Resto As Integer
        Dim Comparacion As Integer

        SumaCuil = (Int(Mid(CUIL, 1, 1))) * 5 _
                 + (Int(Mid(CUIL, 2, 1))) * 4 _
                 + (Int(Mid(CUIL, 3, 1))) * 3 _
                 + (Int(Mid(CUIL, 4, 1))) * 2 _
                 + (Int(Mid(CUIL, 5, 1))) * 7 _
                 + (Int(Mid(CUIL, 6, 1))) * 6 _
                 + (Int(Mid(CUIL, 7, 1))) * 5 _
                 + (Int(Mid(CUIL, 8, 1))) * 4 _
                 + (Int(Mid(CUIL, 9, 1))) * 3 _
                 + (Int(Mid(CUIL, 10, 1))) * 2


        Resto = SumaCuil Mod 11
        NroVerificador = (Int(Mid(CUIL, 11, 1)))

        Select Case Resto
            Case 0
                Return ValidarCUIL = True
            Case 1
                Return ValidarCUIL = True
            Case (NroVerificador - 11)
                Return ValidarCUIL = True
            Case Else
                MsgBox("El cuil es Inválido")
                Return ValidarCUIL = False
        End Select


    End Function

    '=====Constructores======
    Public Sub New()

    End Sub
    Public Sub New(Apellido As String, Nombre As String, CUIL As String, Sexo As String, Direc As String, Telefono As String)
        Per_Apellido = Apellido
        Per_Nombre = Nombre
        Per_CUIL = CUIL
        Per_Sexo = Sexo
        Per_Direccion = Direc
        Per_Telefono = Telefono
    End Sub
End Class

Public Class CuentaBancaria
    Private Banco As String
    Public Property CB_Banco() As String
        Get
            Return Banco
        End Get
        Set(ByVal value As String)
            Banco = value
        End Set
    End Property

    Private NroDeCuenta As String
    Public Property CB_NroDeCuenta() As String
        Get
            Return NroDeCuenta
        End Get
        Set(ByVal value As String)
            NroDeCuenta = value
        End Set
    End Property

    Private Tipo As String
    Public Property CB_Tipo() As String
        Get
            Return Tipo
        End Get
        Set(ByVal value As String)
            Tipo = value
        End Set
    End Property

    Private CBU As String
    Public Property CB_CBU() As String
        Get
            Return CBU
        End Get
        Set(ByVal value As String)
            CBU = value
        End Set
    End Property

    Private Moneda As String
    Public Property CB_Moneda() As String
        Get
            Return Moneda
        End Get
        Set(ByVal value As String)
            Moneda = value
        End Set
    End Property


    '========Contructores====
    Public Sub New()

    End Sub

    Public Sub New(Banco, NroCuenta, Tipo, CBU, Moneda)
        CB_Banco = Banco
        CB_NroDeCuenta = NroCuenta
        CB_Tipo = Tipo
        CB_CBU = CBU
        CB_Moneda = Moneda
    End Sub

    '=======Funciones de Validación====
    Public Function ValidarCBU_PriBloque() As Integer
        Dim DigitoVerificador1 As Integer
        Dim SUMA1 As Integer
        Dim DIFERENCIA1 As Integer

        'Constantes de Multiplicación: 7-1-3-9
        SUMA1 = (Int(Mid(CBU, 1, 1))) * 7 _
              + (Int(Mid(CBU, 2, 1))) * 1 _
              + (Int(Mid(CBU, 3, 1))) * 3 _
              + (Int(Mid(CBU, 4, 1))) * 9 _
              + (Int(Mid(CBU, 5, 1))) * 7 _
              + (Int(Mid(CBU, 6, 1))) * 1 _
              + (Int(Mid(CBU, 7, 1))) * 3

        SUMA1 = Str(SUMA1)

        DIFERENCIA1 = 10 - Mid(SUMA1, 2)
        DigitoVerificador1 = (Int(Mid(CBU, 8, 1)))
        If DigitoVerificador1 <> DIFERENCIA1 Then
            MsgBox("Numero de CBU inválido. Por favor verifique y vuelva a intentar")
        End If
    End Function

    Public Function ValidarCBU_SegBloque() As Integer

        Dim SUMA2 As Integer
        Dim DIFERENCIA2 As Integer
        Dim DigitoVerificador1 As Integer

        SUMA2 = (Int(Mid(CBU, 1, 1))) * 3 _
              + (Int(Mid(CBU, 2, 1))) * 9 _
              + (Int(Mid(CBU, 3, 1))) * 7 _
              + (Int(Mid(CBU, 4, 1))) * 1 _
              + (Int(Mid(CBU, 5, 1))) * 3 _
              + (Int(Mid(CBU, 6, 1))) * 9 _
              + (Int(Mid(CBU, 7, 1))) * 7 _
              + (Int(Mid(CBU, 8, 1))) * 1 _
              + (Int(Mid(CBU, 9, 1))) * 3 _
              + (Int(Mid(CBU, 10, 1))) * 9 _
              + (Int(Mid(CBU, 11, 1))) * 7 _
              + (Int(Mid(CBU, 12, 1))) * 1 _
              + (Int(Mid(CBU, 13, 1))) * 3

        SUMA2 = Str(SUMA2)

        DigitoVerificador1 = (Int(Mid(CBU, 14, 1)))
        DIFERENCIA2 = 10 - Mid(SUMA2, 2)
        If DigitoVerificador1 <> DIFERENCIA2 Then
            MsgBox("Numero de CBU inválido. Por favor verifique y vuelva a intentar")
        End If

    End Function

    Public Function ValidacionNroCuenta()
        Dim NroCuentaEnCBU
        NroCuentaEnCBU = Int(Mid(CBU, 9, 13))

        If NroCuentaEnCBU = NroDeCuenta Then
            MsgBox("Su número de cuenta es válida")
        Else
            MsgBox("Número de Cuenta o CBU Incorreta. Por favor verifique y vuelva a Intentar.")
        End If
    End Function

    ''' <summary>
    ''' Usando el nro de CBU ingresado, se verifica si esta correcto.
    ''' </summary>
    ''' <param name="CBU"></param>
    ''' <returns></returns>
    Public Function ValidacionCBU()
        ValidarCBU_PriBloque()
        ValidarCBU_SegBloque()
    End Function

End Class
