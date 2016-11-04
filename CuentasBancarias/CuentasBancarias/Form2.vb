Public Class Form2
    Private Sub CancelarCmd_Click(sender As Object, e As EventArgs) Handles CancelarCmd.Click

    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CBOSexo.Items.Add("Femenino")
        CBOSexo.Items.Add("Masculino")
        CBOBanco.Items.Add("BNA")
        CBOBanco.Items.Add("BCOFSA")
        CBOBanco.Items.Add("GALICIA")
        CBOBanco.Items.Add("FRANCES")
        CBOBanco.Items.Add("HIPOTECARIO")
        CBOTipo.Items.Add("CA")
        CBOTipo.Items.Add("CC")
        CBOMoneda.Items.Add("$")
        CBOMoneda.Items.Add("U$D")
    End Sub

    Private Sub AceptarCmd_Click(sender As Object, e As EventArgs) Handles AceptarCmd.Click
        If Persona.ValidadCuil(TXTCUIL.Text) = False Then
            MsgBox("El cuil ingresado no es válido")
            'ElseIf CuentaBancaria.ValidarCBU(Val(TXTCBU.Text)) = False Then
            'MsgBox("El CBU Ingresado no es válido")
        Else
            Dim Persona As New Persona(TXTAyN.Text, TXTCUIL.Text, CBOSexo.SelectedIndex, TXTDireccion.Text, TXTTelefono.Text)
            Dim Cuenta As New CuentaBancaria(CBOBanco.SelectedIndex, CBOTipo.SelectedIndex, CBOMoneda.SelectedIndex, TXTNroCuenta.Text, TXTCBU.Text)
            Persona.Cargar_Datos("Insert Into Persona Values(:ID_Persona, :ApellidoyNombre, :CUIL, :Sexo, :Direccion, :Telefono)")
            Cuenta.Cargar_Datos("Insert Into Cuenta Values(:ID_Cuenta, :Banco, :TipoCuenta, :Moneda, :NroCuenta, :CBU, :Rela_Persona)")
        End If
    End Sub
End Class