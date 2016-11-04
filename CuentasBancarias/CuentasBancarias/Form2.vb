Public Class Form2
    Private oPersona As New Persona
    Private oCuentaBancaria As New CuentaBancaria
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Cargo Combo Sexo
        CmbSexo.Items.Insert(Sexo.Masculino, Sexo.Masculino.ToString)
        CmbSexo.Items.Insert(Sexo.Femenino, Sexo.Femenino.ToString)
        'Cargo Combo Banco
        CmbBanco.Items.Insert(Banco.BNA, Banco.BNA.ToString)
        CmbBanco.Items.Insert(Banco.BCOFSA, Banco.BCOFSA.ToString)
        CmbBanco.Items.Insert(Banco.GALICIA, Banco.GALICIA.ToString)
        CmbBanco.Items.Insert(Banco.FRANCES, Banco.FRANCES.ToString)
        CmbBanco.Items.Insert(Banco.HIPOTECARIO, Banco.HIPOTECARIO.ToString)
        'Cargo combo Tipo de cuenta
        CmbTipoCuenta.Items.Insert(Tipo_Cuenta.CA, Tipo_Cuenta.CA.ToString)
        CmbTipoCuenta.Items.Insert(Tipo_Cuenta.CC, Tipo_Cuenta.CC.ToString)
        'Cargo combo Tipo de Moneda
        CmbMoneda.Items.Insert(Tipo_Moneda.Pesos, Tipo_Moneda.Pesos.ToString)
        CmbMoneda.Items.Insert(Tipo_Moneda.Dolar, Tipo_Moneda.Dolar.ToString)

    End Sub
    Private Sub AceptarCmd_Click(sender As Object, e As EventArgs) Handles AceptarCmd.Click

        'Ingreso los Datos para persona
        With oPersona
            .IngresarNomApe = TxtNomyApe.Text
            .IngresarCUIL = TxtCUIL.Text
            .IngresarDir = TxtDireccion.Text
            .IngresarTelef = TxtTelefono.Text
        End With
        'Ingreso Los datos de la Cuenta Bancaria para la persona 
        With oCuentaBancaria
            .IngresarCBU = (TxtCBU1.Text)
            .IngresarNroCuenta = TxtNroCuenta.Text
        End With
        'Valida el Numero de Cuil
        If Persona.ValidarCuil(TxtCUIL.Text) = True Then
            MsgBox("El CUIL es Valido")
        Else
            MsgBox("El CUIL NO es Valido")
        End If
        'Valida el Numero de CBU
        If CuentaBancaria.ValidarCBU(TxtCBU1.Text) = True Then
            MsgBox("El CBU es Valido")
        Else
            MsgBox("El CBU NO es Valido")
        End If
        'Ingreso el Nombre de la Personaen El ComboBox del Form1
        Form1.Cargar_Personas_Cmb()

    End Sub
    Private Sub CancelarCmd_Click(sender As Object, e As EventArgs) Handles CancelarCmd.Click
        Me.Close()
    End Sub
End Class