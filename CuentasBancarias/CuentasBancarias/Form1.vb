Imports CuentasBancarias
Public Class Form1
    Private oPersona As New Persona
    Private oCuentaBancaria As New CuentaBancaria
    Private Sub AgregarCuentaBtn_Click(sender As Object, e As EventArgs) Handles BtnAgregarCuenta.Click
        Form2.Show()
    End Sub
    Public Sub Cargar_Personas_Cmb()
        CmbPersonas.Items.Add(Form2.TxtNomyApe.Text)
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub CmbPersonas_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbPersonas.SelectedIndexChanged

    End Sub
End Class