Public Class Form1
    Dim Persona As New Persona

    Private Sub AgregarCuentaBtn_Click(sender As Object, e As EventArgs) Handles AgregarCuentaBtn.Click
        Form2.ShowDialog()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.DataSource = Persona.Mostrar_Datos("Select * From Persona")
        ComboBox1.DisplayMember = "ApellidoyNombre"
        ComboBox1.ValueMember = "ID_Persona"
        Form2.Show()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        ' Dim Sentencia = "Select * From Cuenta Inner Join Persona On ID_Persona = Rela_Persona Where Persona.ApellidoyNombre = '" & ComboBox1.Text & "'"
        'ComboBox1.DataSource = Persona.Mostrar_Datos(Sentencia)
    End Sub
End Class
