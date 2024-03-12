<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VALIDAR_RUT
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
        Me.LBL_1 = New System.Windows.Forms.Label()
        Me.MaskedTextBox1 = New System.Windows.Forms.MaskedTextBox()
        Me.BTN_1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LBL_1
        '
        Me.LBL_1.AutoSize = True
        Me.LBL_1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_1.Location = New System.Drawing.Point(71, 80)
        Me.LBL_1.Name = "LBL_1"
        Me.LBL_1.Size = New System.Drawing.Size(57, 20)
        Me.LBL_1.TabIndex = 0
        Me.LBL_1.Text = "Label1"
        '
        'MaskedTextBox1
        '
        Me.MaskedTextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaskedTextBox1.Location = New System.Drawing.Point(268, 73)
        Me.MaskedTextBox1.Mask = "000.000.000.000"
        Me.MaskedTextBox1.Name = "MaskedTextBox1"
        Me.MaskedTextBox1.Size = New System.Drawing.Size(198, 26)
        Me.MaskedTextBox1.TabIndex = 1
        Me.MaskedTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BTN_1
        '
        Me.BTN_1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_1.Location = New System.Drawing.Point(531, 64)
        Me.BTN_1.Name = "BTN_1"
        Me.BTN_1.Size = New System.Drawing.Size(90, 45)
        Me.BTN_1.TabIndex = 2
        Me.BTN_1.Text = "Button1"
        Me.BTN_1.UseVisualStyleBackColor = True
        '
        'VALIDAR_RUT
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.BTN_1)
        Me.Controls.Add(Me.MaskedTextBox1)
        Me.Controls.Add(Me.LBL_1)
        Me.Name = "VALIDAR_RUT"
        Me.Text = "VALIDAR_RUT"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LBL_1 As Label
    Friend WithEvents MaskedTextBox1 As MaskedTextBox
    Friend WithEvents BTN_1 As Button
End Class
