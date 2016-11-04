Public Enum Banco As Byte
    BNA = 0
    BCOFSA = 1
    GALICIA = 2
    FRANCES = 3
    HIPOTECARIO = 4
End Enum
Public Enum Sexo As Byte
    Masculino = 0
    Femenino = 1
End Enum
Public Enum Tipo_Moneda As Byte
    Pesos = 0
    Dolar = 1
End Enum
Public Enum Tipo_Cuenta As Byte
    CA = 0
    CC = 1
End Enum
Public Class Persona
    Private ApellidoyNombre, Dirección As String
    Private CUIL, Teléfono As Integer
    Private Sexo As Sexo
    Public WriteOnly Property IngresarNomApe() As String
        Set(ByVal value As String)
            ApellidoyNombre = value
        End Set
    End Property
    Public WriteOnly Property IngresarCUIL() As Integer
        Set(ByVal value As Integer)
            CUIL = value
        End Set
    End Property
    Public WriteOnly Property IngresarDir() As String
        Set(ByVal value As String)
            Dirección = value
        End Set
    End Property
    Public WriteOnly Property IngresarTelef() As Integer
        Set(ByVal value As Integer)
            Teléfono = value
        End Set
    End Property
    Public Shared Function ValidarCuil(sCuil As String) As Boolean
        Dim CUILStr As String
        Dim Suma As Integer
        Dim Resto As Integer
        CUILStr = Replace(sCuil, "-", "")

        Suma = (Mid(sCuil, 1, 1) * 5) +
            (Mid(sCuil, 2, 1) * 4) +
            (Mid(sCuil, 3, 1) * 3) +
            (Mid(sCuil, 4, 1) * 2) +
            (Mid(sCuil, 5, 1) * 7) +
            (Mid(sCuil, 6, 1) * 6) +
            (Mid(sCuil, 7, 1) * 5) +
            (Mid(sCuil, 8, 1) * 4) +
            (Mid(sCuil, 9, 1) * 3) +
            (Mid(sCuil, 10, 1) * 2)

        Resto = Suma Mod 11

        If Resto = 0 And Mid(sCuil, 11, 1) = 0 Then
            Return True
        ElseIf Resto = 1 And Mid(sCuil, 11, 1) = 0 Then
            Return False
        ElseIf Mid(sCuil, 11, 1) <> (11 - Resto) Then
            Return True
        End If
        Return False

    End Function
End Class
Public Class CuentaBancaria
    Private Banco As Banco
    Private CBU, Nro_Cuenta As Integer
    Private Tipo_Cuenta As Tipo_Cuenta
    Public WriteOnly Property IngresarNroCuenta() As Integer
        Set(ByVal value As Integer)
            Nro_Cuenta = value
        End Set
    End Property
    Public WriteOnly Property IngresarCBU() As Integer
        Set(ByVal value As Integer)
            CBU = value
        End Set
    End Property

End Class