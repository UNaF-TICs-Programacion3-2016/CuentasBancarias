<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.PersonaGBox = New System.Windows.Forms.GroupBox()
        Me.TxtNombre = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtTel = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtDirec = New System.Windows.Forms.TextBox()
        Me.LblSexo = New System.Windows.Forms.Label()
        Me.CmbSexo = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtCuil = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtApellido = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.CmbMoneda = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.CmbTipo = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.CmbBanco = New System.Windows.Forms.ComboBox()
        Me.BancoLbl = New System.Windows.Forms.Label()
        Me.TxtNroCuenta = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtCBU = New System.Windows.Forms.TextBox()
        Me.CancelarCmd = New System.Windows.Forms.Button()
        Me.AceptarCmd = New System.Windows.Forms.Button()
        Me.CmbGCuenta = New System.Windows.Forms.Button()
        Me.CmbNCuenta = New System.Windows.Forms.Button()
        Me.PersonaGBox.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PersonaGBox
        '
        Me.PersonaGBox.Controls.Add(Me.TxtNombre)
        Me.PersonaGBox.Controls.Add(Me.Label4)
        Me.PersonaGBox.Controls.Add(Me.TxtTel)
        Me.PersonaGBox.Controls.Add(Me.Label3)
        Me.PersonaGBox.Controls.Add(Me.TxtDirec)
        Me.PersonaGBox.Controls.Add(Me.LblSexo)
        Me.PersonaGBox.Controls.Add(Me.CmbSexo)
        Me.PersonaGBox.Controls.Add(Me.Label2)
        Me.PersonaGBox.Controls.Add(Me.TxtCuil)
        Me.PersonaGBox.Controls.Add(Me.Label1)
        Me.PersonaGBox.Controls.Add(Me.TxtApellido)
        Me.PersonaGBox.Location = New System.Drawing.Point(12, 12)
        Me.PersonaGBox.Name = "PersonaGBox"
        Me.PersonaGBox.Size = New System.Drawing.Size(386, 171)
        Me.PersonaGBox.TabIndex = 0
        Me.PersonaGBox.TabStop = False
        Me.PersonaGBox.Text = "Persona"
        '
        'TxtNombre
        '
        Me.TxtNombre.Location = New System.Drawing.Point(245, 23)
        Me.TxtNombre.Name = "TxtNombre"
        Me.TxtNombre.Size = New System.Drawing.Size(114, 20)
        Me.TxtNombre.TabIndex = 10
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(56, 134)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Teléfono"
        '
        'TxtTel
        '
        Me.TxtTel.Location = New System.Drawing.Point(114, 131)
        Me.TxtTel.Name = "TxtTel"
        Me.TxtTel.Size = New System.Drawing.Size(109, 20)
        Me.TxtTel.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(56, 105)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Dirección"
        '
        'TxtDirec
        '
        Me.TxtDirec.Location = New System.Drawing.Point(114, 102)
        Me.TxtDirec.Name = "TxtDirec"
        Me.TxtDirec.Size = New System.Drawing.Size(245, 20)
        Me.TxtDirec.TabIndex = 6
        '
        'LblSexo
        '
        Me.LblSexo.AutoSize = True
        Me.LblSexo.Location = New System.Drawing.Point(77, 78)
        Me.LblSexo.Name = "LblSexo"
        Me.LblSexo.Size = New System.Drawing.Size(31, 13)
        Me.LblSexo.TabIndex = 5
        Me.LblSexo.Text = "Sexo"
        '
        'CmbSexo
        '
        Me.CmbSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbSexo.FormattingEnabled = True
        Me.CmbSexo.Location = New System.Drawing.Point(114, 75)
        Me.CmbSexo.Name = "CmbSexo"
        Me.CmbSexo.Size = New System.Drawing.Size(100, 21)
        Me.CmbSexo.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(77, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(31, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "CUIL"
        '
        'TxtCuil
        '
        Me.TxtCuil.Location = New System.Drawing.Point(114, 49)
        Me.TxtCuil.Name = "TxtCuil"
        Me.TxtCuil.Size = New System.Drawing.Size(93, 20)
        Me.TxtCuil.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Apellido y Nombre"
        '
        'TxtApellido
        '
        Me.TxtApellido.Location = New System.Drawing.Point(114, 23)
        Me.TxtApellido.Name = "TxtApellido"
        Me.TxtApellido.Size = New System.Drawing.Size(125, 20)
        Me.TxtApellido.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.CmbMoneda)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.CmbTipo)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.CmbBanco)
        Me.GroupBox1.Controls.Add(Me.BancoLbl)
        Me.GroupBox1.Controls.Add(Me.TxtNroCuenta)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.TxtCBU)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 189)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(386, 160)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Cuenta Bancaria"
        '
        'CmbMoneda
        '
        Me.CmbMoneda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbMoneda.FormattingEnabled = True
        Me.CmbMoneda.Location = New System.Drawing.Point(114, 73)
        Me.CmbMoneda.Name = "CmbMoneda"
        Me.CmbMoneda.Size = New System.Drawing.Size(64, 21)
        Me.CmbMoneda.TabIndex = 13
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(59, 76)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(46, 13)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "Moneda"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(41, 103)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(64, 13)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Nro. Cuenta"
        '
        'CmbTipo
        '
        Me.CmbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbTipo.FormattingEnabled = True
        Me.CmbTipo.Location = New System.Drawing.Point(114, 46)
        Me.CmbTipo.Name = "CmbTipo"
        Me.CmbTipo.Size = New System.Drawing.Size(64, 21)
        Me.CmbTipo.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(43, 49)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(65, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Tipo Cuenta"
        '
        'CmbBanco
        '
        Me.CmbBanco.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbBanco.FormattingEnabled = True
        Me.CmbBanco.Location = New System.Drawing.Point(114, 19)
        Me.CmbBanco.Name = "CmbBanco"
        Me.CmbBanco.Size = New System.Drawing.Size(100, 21)
        Me.CmbBanco.TabIndex = 8
        '
        'BancoLbl
        '
        Me.BancoLbl.AutoSize = True
        Me.BancoLbl.Location = New System.Drawing.Point(70, 22)
        Me.BancoLbl.Name = "BancoLbl"
        Me.BancoLbl.Size = New System.Drawing.Size(38, 13)
        Me.BancoLbl.TabIndex = 7
        Me.BancoLbl.Text = "Banco"
        '
        'TxtNroCuenta
        '
        Me.TxtNroCuenta.Location = New System.Drawing.Point(114, 100)
        Me.TxtNroCuenta.Name = "TxtNroCuenta"
        Me.TxtNroCuenta.Size = New System.Drawing.Size(153, 20)
        Me.TxtNroCuenta.TabIndex = 6
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(76, 129)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(29, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "CBU"
        '
        'TxtCBU
        '
        Me.TxtCBU.Location = New System.Drawing.Point(114, 126)
        Me.TxtCBU.Name = "TxtCBU"
        Me.TxtCBU.Size = New System.Drawing.Size(191, 20)
        Me.TxtCBU.TabIndex = 4
        '
        'CancelarCmd
        '
        Me.CancelarCmd.Location = New System.Drawing.Point(321, 355)
        Me.CancelarCmd.Name = "CancelarCmd"
        Me.CancelarCmd.Size = New System.Drawing.Size(75, 23)
        Me.CancelarCmd.TabIndex = 2
        Me.CancelarCmd.Text = "Cancelar"
        Me.CancelarCmd.UseVisualStyleBackColor = True
        '
        'AceptarCmd
        '
        Me.AceptarCmd.Location = New System.Drawing.Point(240, 355)
        Me.AceptarCmd.Name = "AceptarCmd"
        Me.AceptarCmd.Size = New System.Drawing.Size(75, 23)
        Me.AceptarCmd.TabIndex = 3
        Me.AceptarCmd.Text = "Aceptar"
        Me.AceptarCmd.UseVisualStyleBackColor = True
        '
        'CmbGCuenta
        '
        Me.CmbGCuenta.Location = New System.Drawing.Point(12, 355)
        Me.CmbGCuenta.Name = "CmbGCuenta"
        Me.CmbGCuenta.Size = New System.Drawing.Size(93, 23)
        Me.CmbGCuenta.TabIndex = 5
        Me.CmbGCuenta.Text = "Guardar Cuenta"
        Me.CmbGCuenta.UseVisualStyleBackColor = True
        '
        'CmbNCuenta
        '
        Me.CmbNCuenta.Location = New System.Drawing.Point(111, 355)
        Me.CmbNCuenta.Name = "CmbNCuenta"
        Me.CmbNCuenta.Size = New System.Drawing.Size(93, 23)
        Me.CmbNCuenta.TabIndex = 6
        Me.CmbNCuenta.Text = "Nueva Cuenta"
        Me.CmbNCuenta.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(410, 385)
        Me.Controls.Add(Me.CmbNCuenta)
        Me.Controls.Add(Me.CmbGCuenta)
        Me.Controls.Add(Me.AceptarCmd)
        Me.Controls.Add(Me.CancelarCmd)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.PersonaGBox)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.PersonaGBox.ResumeLayout(False)
        Me.PersonaGBox.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PersonaGBox As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtApellido As TextBox
    Friend WithEvents LblSexo As Label
    Friend WithEvents CmbSexo As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtCuil As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtTel As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtDirec As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label7 As Label
    Friend WithEvents CmbTipo As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents CmbBanco As ComboBox
    Friend WithEvents BancoLbl As Label
    Friend WithEvents TxtNroCuenta As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TxtCBU As TextBox
    Friend WithEvents CmbMoneda As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents CancelarCmd As Button
    Friend WithEvents AceptarCmd As Button
    Friend WithEvents TxtNombre As TextBox
    Friend WithEvents CmbGCuenta As Button
    Friend WithEvents CmbNCuenta As Button
End Class
