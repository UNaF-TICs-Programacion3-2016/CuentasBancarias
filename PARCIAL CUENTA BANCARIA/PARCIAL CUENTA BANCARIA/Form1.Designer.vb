<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Cbo_Persona = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ListBoxCuentasBancarias = New System.Windows.Forms.ListBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.AgregarCuentaBtn = New System.Windows.Forms.Button()
        Me.btn_CtaBancaria = New System.Windows.Forms.Button()
        Me.Modificar_persona_BTN = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Cbo_Persona
        '
        Me.Cbo_Persona.FormattingEnabled = True
        Me.Cbo_Persona.Location = New System.Drawing.Point(107, 14)
        Me.Cbo_Persona.Name = "Cbo_Persona"
        Me.Cbo_Persona.Size = New System.Drawing.Size(369, 21)
        Me.Cbo_Persona.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(58, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Persona"
        '
        'ListBoxCuentasBancarias
        '
        Me.ListBoxCuentasBancarias.FormattingEnabled = True
        Me.ListBoxCuentasBancarias.Location = New System.Drawing.Point(110, 41)
        Me.ListBoxCuentasBancarias.Name = "ListBoxCuentasBancarias"
        Me.ListBoxCuentasBancarias.Size = New System.Drawing.Size(366, 186)
        Me.ListBoxCuentasBancarias.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 39)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Cuentas Bancarias"
        '
        'AgregarCuentaBtn
        '
        Me.AgregarCuentaBtn.Location = New System.Drawing.Point(7, 69)
        Me.AgregarCuentaBtn.Name = "AgregarCuentaBtn"
        Me.AgregarCuentaBtn.Size = New System.Drawing.Size(97, 59)
        Me.AgregarCuentaBtn.TabIndex = 4
        Me.AgregarCuentaBtn.Text = "Agregar Persona Y Cuenta Bancaria"
        Me.AgregarCuentaBtn.UseVisualStyleBackColor = True
        '
        'btn_CtaBancaria
        '
        Me.btn_CtaBancaria.Location = New System.Drawing.Point(7, 134)
        Me.btn_CtaBancaria.Name = "btn_CtaBancaria"
        Me.btn_CtaBancaria.Size = New System.Drawing.Size(97, 42)
        Me.btn_CtaBancaria.TabIndex = 5
        Me.btn_CtaBancaria.Text = "Agregar Cta Bancaria"
        Me.btn_CtaBancaria.UseVisualStyleBackColor = True
        '
        'Modificar_persona_BTN
        '
        Me.Modificar_persona_BTN.Location = New System.Drawing.Point(7, 182)
        Me.Modificar_persona_BTN.Name = "Modificar_persona_BTN"
        Me.Modificar_persona_BTN.Size = New System.Drawing.Size(97, 41)
        Me.Modificar_persona_BTN.TabIndex = 6
        Me.Modificar_persona_BTN.Text = "Modificar Persona"
        Me.Modificar_persona_BTN.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(585, 279)
        Me.Controls.Add(Me.Modificar_persona_BTN)
        Me.Controls.Add(Me.btn_CtaBancaria)
        Me.Controls.Add(Me.AgregarCuentaBtn)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ListBoxCuentasBancarias)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Cbo_Persona)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Cbo_Persona As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ListBoxCuentasBancarias As ListBox
    Friend WithEvents Label2 As Label
    Friend WithEvents AgregarCuentaBtn As Button
    Friend WithEvents btn_CtaBancaria As Button
    Friend WithEvents Modificar_persona_BTN As Button
End Class
