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
    Public CuentasBancarias As New List(Of CuentaBancaria)
    Private ApellidoyNombre, Dirección, CUIL, Teléfono As String
    Private Sexo As Sexo
    Public WriteOnly Property IngresarNomApe() As String
        Set(ByVal value As String)
            ApellidoyNombre = value
        End Set
    End Property
    Public WriteOnly Property IngresarCUIL() As String
        Set(ByVal value As String)
            CUIL = value
        End Set
    End Property
    Public WriteOnly Property IngresarDir() As String
        Set(ByVal value As String)
            Dirección = value
        End Set
    End Property
    Public WriteOnly Property IngresarTelef() As String
        Set(ByVal value As String)
            Teléfono = value
        End Set
    End Property
    Public Shared Function ValidarCuil(sCuil As String) As Boolean
        Dim CUILStr As String
        Dim Suma As Double
        Dim Resto As Double
        CUILStr = Replace(sCuil, "-", "")

        Suma = (Mid(CUILStr, 1, 1) * 5) +
            (Mid(CUILStr, 2, 1) * 4) +
            (Mid(CUILStr, 3, 1) * 3) +
            (Mid(CUILStr, 4, 1) * 2) +
            (Mid(CUILStr, 5, 1) * 7) +
            (Mid(CUILStr, 6, 1) * 6) +
            (Mid(CUILStr, 7, 1) * 5) +
            (Mid(CUILStr, 8, 1) * 4) +
            (Mid(CUILStr, 9, 1) * 3) +
            (Mid(CUILStr, 10, 1) * 2)

        Resto = Suma Mod 11

        If Resto = 0 And Mid(CUILStr, 11, 1) = 0 Then
            Return True
        ElseIf Resto = 1 And Mid(CUILStr, 11, 1) = 0 Then
            Return False
        ElseIf Mid(CUILStr, 11, 1) = (11 - Resto) Then
            Return True
        End If
        Return False

    End Function
    Public Sub AgregarCuentaBancaria(ObjCtaBancaria As CuentaBancaria)
        CuentasBancarias.Add(ObjCtaBancaria)
    End Sub
End Class
Public Class CuentaBancaria
    Private Banco As Banco
    Private CBU, Nro_Cuenta As String
    Private Tipo_Cuenta As Tipo_Cuenta
    Public WriteOnly Property IngresarNroCuenta() As String
        Set(ByVal value As String)
            Nro_Cuenta = value
        End Set
    End Property
    Public WriteOnly Property IngresarCBU() As String
        Set(ByVal value As String)
            CBU = value
        End Set
    End Property
    Public Shared Function ValidarCBU(pCBU As String) As Boolean
        Dim Suma1, Suma2 As Long
        Dim Resto1, Resto2 As Long

        Suma1 = (Mid(pCBU, 1, 1) * 7) +
            (Mid(pCBU, 2, 1) * 1) +
            (Mid(pCBU, 3, 1) * 3) +
            (Mid(pCBU, 4, 1) * 9) +
            (Mid(pCBU, 5, 1) * 7) +
            (Mid(pCBU, 6, 1) * 1) +
            (Mid(pCBU, 7, 1) * 3)
        Resto1 = 10 - (Mid(Suma1, 2, 1))
        Suma2 = (Mid(pCBU, 9, 1) * 3) +
            (Mid(pCBU, 10, 1) * 9) +
            (Mid(pCBU, 11, 1) * 7) +
            (Mid(pCBU, 12, 1) * 1) +
            (Mid(pCBU, 13, 1) * 3) +
            (Mid(pCBU, 14, 1) * 9) +
            (Mid(pCBU, 15, 1) * 7) +
            (Mid(pCBU, 16, 1) * 1) +
            (Mid(pCBU, 17, 1) * 3) +
            (Mid(pCBU, 18, 1) * 9) +
            (Mid(pCBU, 19, 1) * 7) +
            (Mid(pCBU, 20, 1) * 1) +
            (Mid(pCBU, 21, 1) * 3)
        Resto2 = 10 - (Mid(Suma2, 3, 1))

        If Resto1 = Mid(pCBU, 8, 1) And Resto2 = (Mid(pCBU, 22, 1)) Then
            Return True
        Else
            Return False
        End If
    End Function

End Class