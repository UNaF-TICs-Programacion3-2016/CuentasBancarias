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
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TXTTelefono = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TXTDireccion = New System.Windows.Forms.TextBox()
        Me.LblSexo = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TXTCUIL = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TXTAyN = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.BancoLbl = New System.Windows.Forms.Label()
        Me.TXTNroCuenta = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TXTCBU = New System.Windows.Forms.TextBox()
        Me.CancelarCmd = New System.Windows.Forms.Button()
        Me.AceptarCmd = New System.Windows.Forms.Button()
        Me.CBOSexo = New System.Windows.Forms.ComboBox()
        Me.CBOMoneda = New System.Windows.Forms.ComboBox()
        Me.CBOTipo = New System.Windows.Forms.ComboBox()
        Me.CBOBanco = New System.Windows.Forms.ComboBox()
        Me.PersonaGBox.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PersonaGBox
        '
        Me.PersonaGBox.Controls.Add(Me.Label4)
        Me.PersonaGBox.Controls.Add(Me.TXTTelefono)
        Me.PersonaGBox.Controls.Add(Me.Label3)
        Me.PersonaGBox.Controls.Add(Me.TXTDireccion)
        Me.PersonaGBox.Controls.Add(Me.LblSexo)
        Me.PersonaGBox.Controls.Add(Me.CBOSexo)
        Me.PersonaGBox.Controls.Add(Me.Label2)
        Me.PersonaGBox.Controls.Add(Me.TXTCUIL)
        Me.PersonaGBox.Controls.Add(Me.Label1)
        Me.PersonaGBox.Controls.Add(Me.TXTAyN)
        Me.PersonaGBox.Location = New System.Drawing.Point(12, 12)
        Me.PersonaGBox.Name = "PersonaGBox"
        Me.PersonaGBox.Size = New System.Drawing.Size(386, 171)
        Me.PersonaGBox.TabIndex = 0
        Me.PersonaGBox.TabStop = False
        Me.PersonaGBox.Text = "Persona"
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
        'TXTTelefono
        '
        Me.TXTTelefono.Location = New System.Drawing.Point(114, 131)
        Me.TXTTelefono.Name = "TXTTelefono"
        Me.TXTTelefono.Size = New System.Drawing.Size(109, 20)
        Me.TXTTelefono.TabIndex = 8
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
        'TXTDireccion
        '
        Me.TXTDireccion.Location = New System.Drawing.Point(114, 102)
        Me.TXTDireccion.Name = "TXTDireccion"
        Me.TXTDireccion.Size = New System.Drawing.Size(245, 20)
        Me.TXTDireccion.TabIndex = 6
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
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(77, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(31, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "CUIL"
        '
        'TXTCUIL
        '
        Me.TXTCUIL.Location = New System.Drawing.Point(114, 49)
        Me.TXTCUIL.Name = "TXTCUIL"
        Me.TXTCUIL.Size = New System.Drawing.Size(93, 20)
        Me.TXTCUIL.TabIndex = 2
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
        'TXTAyN
        '
        Me.TXTAyN.Location = New System.Drawing.Point(114, 23)
        Me.TXTAyN.Name = "TXTAyN"
        Me.TXTAyN.Size = New System.Drawing.Size(245, 20)
        Me.TXTAyN.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.CBOMoneda)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.CBOTipo)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.CBOBanco)
        Me.GroupBox1.Controls.Add(Me.BancoLbl)
        Me.GroupBox1.Controls.Add(Me.TXTNroCuenta)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.TXTCBU)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 189)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(386, 160)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Cuenta Bancaria"
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
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(43, 49)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(65, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Tipo Cuenta"
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
        'TXTNroCuenta
        '
        Me.TXTNroCuenta.Location = New System.Drawing.Point(114, 100)
        Me.TXTNroCuenta.Name = "TXTNroCuenta"
        Me.TXTNroCuenta.Size = New System.Drawing.Size(153, 20)
        Me.TXTNroCuenta.TabIndex = 6
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
        'TXTCBU
        '
        Me.TXTCBU.Location = New System.Drawing.Point(114, 126)
        Me.TXTCBU.Name = "TXTCBU"
        Me.TXTCBU.Size = New System.Drawing.Size(191, 20)
        Me.TXTCBU.TabIndex = 4
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
        'CBOSexo
        '
        Me.CBOSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBOSexo.FormattingEnabled = True
        Me.CBOSexo.Location = New System.Drawing.Point(114, 75)
        Me.CBOSexo.Name = "CBOSexo"
        Me.CBOSexo.Size = New System.Drawing.Size(100, 21)
        Me.CBOSexo.TabIndex = 4
        '
        'CBOMoneda
        '
        Me.CBOMoneda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBOMoneda.FormattingEnabled = True
        Me.CBOMoneda.Location = New System.Drawing.Point(114, 73)
        Me.CBOMoneda.Name = "CBOMoneda"
        Me.CBOMoneda.Size = New System.Drawing.Size(64, 21)
        Me.CBOMoneda.TabIndex = 13
        '
        'CBOTipo
        '
        Me.CBOTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBOTipo.FormattingEnabled = True
        Me.CBOTipo.Location = New System.Drawing.Point(114, 46)
        Me.CBOTipo.Name = "CBOTipo"
        Me.CBOTipo.Size = New System.Drawing.Size(64, 21)
        Me.CBOTipo.TabIndex = 10
        '
        'CBOBanco
        '
        Me.CBOBanco.AccessibleName = "CBOBanco"
        Me.CBOBanco.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBOBanco.FormattingEnabled = True
        Me.CBOBanco.Location = New System.Drawing.Point(114, 19)
        Me.CBOBanco.Name = "CBOBanco"
        Me.CBOBanco.Size = New System.Drawing.Size(100, 21)
        Me.CBOBanco.TabIndex = 8
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(410, 385)
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
    Friend WithEvents TXTAyN As TextBox
    Friend WithEvents LblSexo As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TXTCUIL As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TXTTelefono As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TXTDireccion As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents BancoLbl As Label
    Friend WithEvents TXTNroCuenta As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TXTCBU As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents CancelarCmd As Button
    Friend WithEvents AceptarCmd As Button
    Friend WithEvents CBOSexo As System.Windows.Forms.ComboBox
    Friend WithEvents CBOMoneda As System.Windows.Forms.ComboBox
    Friend WithEvents CBOTipo As System.Windows.Forms.ComboBox
    Friend WithEvents CBOBanco As System.Windows.Forms.ComboBox
End Class
