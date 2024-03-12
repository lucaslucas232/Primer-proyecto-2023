<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EJERCICIO3
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_numero = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(147, 320)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 25)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Label1"
        Me.Label1.Visible = False
        '
        'txt_numero
        '
        Me.txt_numero.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_numero.ForeColor = System.Drawing.SystemColors.ScrollBar
        Me.txt_numero.Location = New System.Drawing.Point(150, 140)
        Me.txt_numero.Name = "txt_numero"
        Me.txt_numero.Size = New System.Drawing.Size(244, 30)
        Me.txt_numero.TabIndex = 7
        Me.txt_numero.Text = "Ingrese numero"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(459, 105)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(195, 89)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'EJERCICIO3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_numero)
        Me.Controls.Add(Me.Button1)
        Me.Name = "EJERCICIO3"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txt_numero As TextBox
    Friend WithEvents Button1 As Button
End Class
