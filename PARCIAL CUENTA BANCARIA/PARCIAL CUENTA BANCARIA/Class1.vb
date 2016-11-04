

Public Enum tipo_de_cuenta As Byte
    CA = 0
    CC = 1
End Enum
Public Enum moneda As Byte
    peso = 0
    dolar = 1
End Enum
Public Enum Banco As Byte
    BNA = 0
    BCOFSA = 1
    GALICIA = 2
    FRANCES = 3
    HIPOTECARIO = 4
End Enum
Public Enum sexo As Byte
    masculino = 0
    femenino = 1
End Enum

Public Class PERSONA
    'atributos
    Private apellidoynombre As String
    Private cuil As String
    Private sexo As sexo
    Private direccion As String
    Private telefono As String
    Public Cuentas As New List(Of Cuenta_bancaria)

    Sub New()

    End Sub
    Sub New(nombre As String, cuil As String, sexo As sexo, direcion As String, telefono As String)

        Me.apellidoynombre = nombre
        Me.cuil = cuil
        Me.sexo = sexo
        Me.direccion = direcion
        Me.telefono = telefono
    End Sub
    Public Property IngresarNomApe() As String
        Get
            Return apellidoynombre
        End Get
        Set(ByVal value As String)
            Me.apellidoynombre = value
        End Set
    End Property
    Public WriteOnly Property Ingresardireccion() As String
        Set(ByVal value As String)
            Me.direccion = value
        End Set
    End Property
    Public WriteOnly Property Ingresarsexo() As sexo
        Set(ByVal value As sexo)
            Me.sexo = value
        End Set
    End Property
    Public WriteOnly Property IngresarCUIL() As String
        Set(ByVal value As String)
            Me.cuil = value
        End Set
    End Property

    Public Sub ingresar_telefono(ByVal telefono As String)
        Me.telefono = telefono
    End Sub

    Public Sub AgregarCuentaBancaria(ByVal ocuenta As Cuenta_bancaria)
        Cuentas.Add(ocuenta)
    End Sub
    Public Function ValidarCuil() As Boolean

        If cuil.Length <> 11 Then
            MsgBox("cuil invalido")
            Exit Function
        End If

        Dim suma As Integer
        Dim resto As Integer
        Dim digitoverificador As Double
        digitoverificador = (Mid(cuil, 11, 1))


        suma = (Mid(cuil, 1, 1) * 7) +
                (Mid(cuil, 2, 1) * 1) +
                (Mid(cuil, 3, 1) * 3) +
                (Mid(cuil, 4, 1) * 9) +
                (Mid(cuil, 5, 1) * 7) +
                (Mid(cuil, 6, 1) * 1) +
                (Mid(cuil, 7, 1) * 3) +
                (Mid(cuil, 8, 1) * 1) +
                (Mid(cuil, 9, 1) * 1) +
                (Mid(cuil, 10, 1) * 1)
        resto = (suma Mod 11)
        If resto = 0 And digitoverificador = 0 Then
            MsgBox("cuil valido")
            Return True
        ElseIf resto = 1 And digitoverificador = 9 Then
            MsgBox("cuil valido")
            Return True
        ElseIf Not digitoverificador = 11 - resto Then
            MsgBox("cuil valido")
            Return True
        Else MsgBox("cuil no valido")
            Return False
        End If
    End Function


End Class
Public Class Cuenta_bancaria
    'atributos
    Private banco As Banco
    Private nro_cuenta As Double
    Private moneda As moneda
    Private cbu As String
    Private tipo_de_cuenta As tipo_de_cuenta
    Sub New()

    End Sub
    Sub New(banco As Banco, nro_cuenta As String, moneda As moneda, cbu As String, tipocuenta As tipo_de_cuenta)

        Me.banco = banco
        Me.nro_cuenta = nro_cuenta
        Me.moneda = moneda
        Me.cbu = cbu
        Me.tipo_de_cuenta = tipocuenta
    End Sub
    Public Sub IngresarBanco(ByVal banco As Banco)
        Me.banco = banco
    End Sub
    Public Sub IngresarTipocuenta1(ByVal tipo As tipo_de_cuenta)
        Me.tipo_de_cuenta = tipo
    End Sub
    Public Sub IngresarMoneda(ByVal moneda As moneda)
        Me.moneda = moneda
    End Sub
    Public WriteOnly Property IngresarNroCuenta() As String
        Set(ByVal value As String)
            nro_cuenta = value
        End Set
    End Property
    Public Sub Ingresartipocuenta(ByVal cuenta As tipo_de_cuenta)
        Me.tipo_de_cuenta = cuenta
    End Sub

    Public WriteOnly Property IngresarCBU() As String
        Set(ByVal value As String)
            cbu = value
        End Set
    End Property
    Public Function Validar1CBU() As Boolean

        If cbu.Length <> 22 Then
            MsgBox("cbu invalido")
            Exit Function
        End If
        Dim digito As Double = Mid(cbu, 1, 7)
        Dim diferencia As Double
        Dim suma As String
        Dim digitosultimo As Double
        Dim digito1 As String = Mid(cbu, 9, 21)
        Dim diferencia1 As String
        Dim suma1 As String
        Dim digitosultimo1 As Double

        suma = (Mid(digito, 1, 1) * 7) +
            (Mid(digito, 2, 1) * 1) +
            (Mid(digito, 3, 1) * 3) +
            (Mid(digito, 4, 1) * 9) +
            (Mid(digito, 5, 1) * 7) +
            (Mid(digito, 6, 1) * 1) +
            (Mid(digito, 7, 1) * 3)
        'no pude hacer funcionar el len incluso pasando a integer o a string o viseversa esta linea sacaba los digitos de la suma
        digitosultimo = Len(suma)
        diferencia = 10 - Mid(suma, 2, 1)
        ' segundo bloque

        suma1 = (Mid(digito1, 1, 1) * 3) +
            (Mid(digito1, 2, 1) * 9) +
            (Mid(digito1, 3, 1) * 7) +
            (Mid(digito1, 4, 1) * 1) +
            (Mid(digito1, 5, 1) * 3) +
            (Mid(digito1, 6, 1) * 9) +
            (Mid(digito1, 7, 1) * 7) +
            (Mid(digito1, 8, 1) * 1) +
            (Mid(digito1, 9, 1) * 3) +
            (Mid(digito1, 10, 1) * 9) +
            (Mid(digito1, 11, 1) * 7) +
            (Mid(digito1, 12, 1) * 1) +
            (Mid(digito1, 13, 1) * 3)

        digitosultimo1 = Len(suma1)
        diferencia1 = 10 - Mid(suma1, 3, 1)

        If diferencia = Mid(cbu, 8, 1) And diferencia1 = Mid(cbu, 22, 1) And nro_cuenta = Mid(digito1, 1, 13) Then
            MsgBox("cbu valido")
            Return True
        Else
            MsgBox("cbu no valido")
            Return False
        End If

    End Function


End Class



