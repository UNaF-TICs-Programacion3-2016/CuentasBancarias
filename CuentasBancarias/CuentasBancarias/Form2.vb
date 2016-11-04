Public Class Form2
    Public oPersona As New Persona
    Public oCuenta As New CuentaBancaria

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CmbSexo.Items.Add("Femenino")
        CmbSexo.Items.Add("Masculino")

        CmbBanco.Items.Add("BNA")
        CmbBanco.Items.Add("BCOFSA")
        CmbBanco.Items.Add("GALICIA")
        CmbBanco.Items.Add("FRANCES")
        CmbBanco.Items.Add("HIPOTECARIO")

        CmbTipo.Items.Add("Caja de Ahorro")
        CmbTipo.Items.Add("Cta Corriente")

        CmbMoneda.Items.Add("$")
        CmbMoneda.Items.Add("U$D")

        TxtApellido.Text = "Recalde"
        TxtNombre.Text = "Augusto Oscar"
        TxtCuil.Text = "20402128456"
        CmbSexo.Text = "Masculino"
        TxtDirec.Text = "Av. Colon e Irigoyen"
        TxtTel.Text = "3718526576"
    End Sub

    Private Sub AceptarCmd_Click(sender As Object, e As EventArgs) Handles AceptarCmd.Click
        Dim Apellido As String
        Dim Nombre As String
        Dim Cuil As String
        Dim Sexo As String
        Dim Direccion As String
        Dim Telefono As String

        Apellido = TxtApellido.Text
        Nombre = TxtNombre.Text
        Cuil = TxtCuil.Text
        Sexo = CmbSexo.Text
        Direccion = TxtDirec.Text
        Telefono = TxtTel.Text



        If oPersona.ValidarCUIL() = False Then
            TxtCuil.Focus()
        End If

        oPersona = New Persona(Apellido, Nombre, Cuil, Sexo, Direccion, Telefono)

        Form1.CmbPersonas_Form1.Items.Add(oPersona.Per_Apellido + oPersona.Per_Nombre)

        Form1.ListBoxCuentasBancarias.DataSource = oPersona.Cuentas
        Form1.ListBoxCuentasBancarias.DisplayMember = "CB_NroDeCuenta"
        Form1.ListBoxCuentasBancarias.ValueMember = "CB_CBU"
        Me.Close()
    End Sub
    Private Sub CancelarCmd_Click(sender As Object, e As EventArgs) Handles CancelarCmd.Click
        Me.Close()
    End Sub

    '===Botones de Agregación de CBU===
    Private Sub CmbGCuenta_Click(sender As Object, e As EventArgs) Handles CmbGCuenta.Click

        oCuenta = New CuentaBancaria(CmbBanco.Text, TxtNroCuenta.Text, CmbTipo.Text, TxtCBU.Text, CmbMoneda.Text)
        oCuenta.ValidacionNroCuenta()

        oPersona.AddCuentaBancaria(oCuenta)

    End Sub
    Private Sub CmbNCuenta_Click(sender As Object, e As EventArgs) Handles CmbNCuenta.Click
        CmbBanco.Text = ""
        TxtNroCuenta.Text = ""
        CmbTipo.Text = ""
        TxtCBU.Text = ""
        CmbMoneda.Text = ""
    End Sub
End Class