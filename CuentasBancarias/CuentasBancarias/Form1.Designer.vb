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
        Me.CmbPersonas = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LstCuentasBancarias = New System.Windows.Forms.ListBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BtnAgregarCuenta = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'CmbPersonas
        '
        Me.CmbPersonas.FormattingEnabled = True
        Me.CmbPersonas.Location = New System.Drawing.Point(107, 14)
        Me.CmbPersonas.Name = "CmbPersonas"
        Me.CmbPersonas.Size = New System.Drawing.Size(369, 21)
        Me.CmbPersonas.TabIndex = 0
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
        'LstCuentasBancarias
        '
        Me.LstCuentasBancarias.FormattingEnabled = True
        Me.LstCuentasBancarias.Location = New System.Drawing.Point(107, 39)
        Me.LstCuentasBancarias.Name = "LstCuentasBancarias"
        Me.LstCuentasBancarias.Size = New System.Drawing.Size(369, 160)
        Me.LstCuentasBancarias.TabIndex = 2
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
        'BtnAgregarCuenta
        '
        Me.BtnAgregarCuenta.Location = New System.Drawing.Point(7, 69)
        Me.BtnAgregarCuenta.Name = "BtnAgregarCuenta"
        Me.BtnAgregarCuenta.Size = New System.Drawing.Size(94, 46)
        Me.BtnAgregarCuenta.TabIndex = 4
        Me.BtnAgregarCuenta.Text = "Agregar Cuenta Bancaria ..."
        Me.BtnAgregarCuenta.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(488, 208)
        Me.Controls.Add(Me.BtnAgregarCuenta)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.LstCuentasBancarias)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CmbPersonas)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CmbPersonas As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents LstCuentasBancarias As ListBox
    Friend WithEvents Label2 As Label
    Friend WithEvents BtnAgregarCuenta As Button
End Class
