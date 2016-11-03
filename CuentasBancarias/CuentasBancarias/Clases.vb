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
End Class
Public Class CuentaBancaria
    Private Banco As Banco
    Private CBU, Nro_Cuenta As Integer
    Private Tipo_Cuenta As Tipo_Cuenta
End Class