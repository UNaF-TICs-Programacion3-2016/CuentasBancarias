Imports PARCIAL_CUENTA_BANCARIA

Public Class Form2
    Private Sub CancelarCmd_Click(sender As Object, e As EventArgs) Handles CancelarCmd.Click
        Me.Close()
    End Sub

    Private Sub AceptarCmd_Click(sender As Object, e As EventArgs) Handles AceptarCmd.Click

        'instanciar cuenta
        Dim ocuenta As New Cuenta_bancaria
            'istanciar persona
            Dim opersonas As New PERSONA

            With opersonas
                .IngresarCUIL = txt_cuil.Text
                .IngresarNomApe = txt_nombre.Text
                .ingresar_telefono(txt_telefono.Text)
                .Ingresardireccion = txt_direccion.Text
                .Ingresarsexo = CmbSexo.SelectedIndex
            End With


            'constructor cta_bancaria
            With ocuenta
                .IngresarCBU = txt_cbu.Text
                .IngresarNroCuenta = txt_nro_bancaria.Text
                .IngresarBanco(cmb_Banco.SelectedIndex)
                .IngresarTipocuenta1(cmb_Tdecuenta.SelectedIndex)
                .IngresarMoneda(cmb_Moneda.SelectedIndex)
            End With

            If ocuenta.Validar1CBU() = True And opersonas.ValidarCuil() = True Then

            opersonas.AgregarCuentaBancaria(ocuenta)


        Else
            End If





    End Sub



    Private Sub PersonaGBox_Enter(sender As Object, e As EventArgs) Handles PersonaGBox.Enter
        CmbSexo.Items.Add("femenino")
        CmbSexo.Items.Add("masculino")
        cmb_Banco.Items.Add("BNA")
        cmb_Banco.Items.Add("BCOFSA")
        cmb_Banco.Items.Add("GALICIA")
        cmb_Banco.Items.Add("FRANCES")
        cmb_Banco.Items.Add("HIPOTECARIO")
        cmb_Tdecuenta.Items.Add("CA")
        cmb_Tdecuenta.Items.Add("CC")
        cmb_Moneda.Items.Add("PESO")
        cmb_Moneda.Items.Add("DOLAR")
    End Sub
End Class