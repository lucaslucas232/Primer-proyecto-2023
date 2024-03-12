<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRM_EJEMPLO_IF
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
        Me.LBL_NOMBRE = New System.Windows.Forms.Label()
        Me.LBL_APELLIDO = New System.Windows.Forms.Label()
        Me.TXT_APELLIDO = New System.Windows.Forms.TextBox()
        Me.LBL_EDAD = New System.Windows.Forms.Label()
        Me.TXT_EDAD = New System.Windows.Forms.TextBox()
        Me.TXT_NOMBRE = New System.Windows.Forms.TextBox()
        Me.BTN_OK = New System.Windows.Forms.Button()
        Me.BTN_CLEAR = New System.Windows.Forms.Button()
        Me.BTN_FIN = New System.Windows.Forms.Button()
        Me.LBL_OBSERVA = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.LBL_NOMBRE1 = New System.Windows.Forms.Label()
        Me.LBL_OBSERVA1 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LBL_NOMBRE
        '
        Me.LBL_NOMBRE.AutoSize = True
        Me.LBL_NOMBRE.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_NOMBRE.Location = New System.Drawing.Point(53, 73)
        Me.LBL_NOMBRE.Name = "LBL_NOMBRE"
        Me.LBL_NOMBRE.Size = New System.Drawing.Size(141, 31)
        Me.LBL_NOMBRE.TabIndex = 0
        Me.LBL_NOMBRE.Text = "NOMBRE:"
        '
        'LBL_APELLIDO
        '
        Me.LBL_APELLIDO.AutoSize = True
        Me.LBL_APELLIDO.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_APELLIDO.Location = New System.Drawing.Point(53, 133)
        Me.LBL_APELLIDO.Name = "LBL_APELLIDO"
        Me.LBL_APELLIDO.Size = New System.Drawing.Size(155, 31)
        Me.LBL_APELLIDO.TabIndex = 2
        Me.LBL_APELLIDO.Text = "APELLIDO:"
        '
        'TXT_APELLIDO
        '
        Me.TXT_APELLIDO.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_APELLIDO.Location = New System.Drawing.Point(304, 126)
        Me.TXT_APELLIDO.Name = "TXT_APELLIDO"
        Me.TXT_APELLIDO.Size = New System.Drawing.Size(363, 38)
        Me.TXT_APELLIDO.TabIndex = 1
        '
        'LBL_EDAD
        '
        Me.LBL_EDAD.AutoSize = True
        Me.LBL_EDAD.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_EDAD.Location = New System.Drawing.Point(53, 196)
        Me.LBL_EDAD.Name = "LBL_EDAD"
        Me.LBL_EDAD.Size = New System.Drawing.Size(98, 31)
        Me.LBL_EDAD.TabIndex = 4
        Me.LBL_EDAD.Text = "EDAD:"
        '
        'TXT_EDAD
        '
        Me.TXT_EDAD.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_EDAD.Location = New System.Drawing.Point(304, 189)
        Me.TXT_EDAD.MaxLength = 2
        Me.TXT_EDAD.Name = "TXT_EDAD"
        Me.TXT_EDAD.Size = New System.Drawing.Size(363, 38)
        Me.TXT_EDAD.TabIndex = 2
        '
        'TXT_NOMBRE
        '
        Me.TXT_NOMBRE.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_NOMBRE.Location = New System.Drawing.Point(304, 73)
        Me.TXT_NOMBRE.Name = "TXT_NOMBRE"
        Me.TXT_NOMBRE.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TXT_NOMBRE.Size = New System.Drawing.Size(363, 38)
        Me.TXT_NOMBRE.TabIndex = 0
        '
        'BTN_OK
        '
        Me.BTN_OK.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_OK.Location = New System.Drawing.Point(531, 405)
        Me.BTN_OK.Name = "BTN_OK"
        Me.BTN_OK.Size = New System.Drawing.Size(153, 47)
        Me.BTN_OK.TabIndex = 7
        Me.BTN_OK.Text = "OK"
        Me.BTN_OK.UseVisualStyleBackColor = True
        '
        'BTN_CLEAR
        '
        Me.BTN_CLEAR.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_CLEAR.Location = New System.Drawing.Point(334, 347)
        Me.BTN_CLEAR.Name = "BTN_CLEAR"
        Me.BTN_CLEAR.Size = New System.Drawing.Size(153, 52)
        Me.BTN_CLEAR.TabIndex = 4
        Me.BTN_CLEAR.Text = "CLEAR"
        Me.BTN_CLEAR.UseVisualStyleBackColor = True
        '
        'BTN_FIN
        '
        Me.BTN_FIN.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_FIN.Location = New System.Drawing.Point(531, 347)
        Me.BTN_FIN.Name = "BTN_FIN"
        Me.BTN_FIN.Size = New System.Drawing.Size(153, 52)
        Me.BTN_FIN.TabIndex = 5
        Me.BTN_FIN.Text = "FIN"
        Me.BTN_FIN.UseVisualStyleBackColor = True
        '
        'LBL_OBSERVA
        '
        Me.LBL_OBSERVA.AutoSize = True
        Me.LBL_OBSERVA.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_OBSERVA.ForeColor = System.Drawing.Color.Blue
        Me.LBL_OBSERVA.Location = New System.Drawing.Point(55, 252)
        Me.LBL_OBSERVA.Name = "LBL_OBSERVA"
        Me.LBL_OBSERVA.Size = New System.Drawing.Size(25, 24)
        Me.LBL_OBSERVA.TabIndex = 11
        Me.LBL_OBSERVA.Text = "..."
        Me.LBL_OBSERVA.Visible = False
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(95, 347)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(164, 52)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "ok1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'LBL_NOMBRE1
        '
        Me.LBL_NOMBRE1.AutoSize = True
        Me.LBL_NOMBRE1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_NOMBRE1.ForeColor = System.Drawing.Color.Blue
        Me.LBL_NOMBRE1.Location = New System.Drawing.Point(55, 422)
        Me.LBL_NOMBRE1.Name = "LBL_NOMBRE1"
        Me.LBL_NOMBRE1.Size = New System.Drawing.Size(25, 24)
        Me.LBL_NOMBRE1.TabIndex = 12
        Me.LBL_NOMBRE1.Text = "..."
        Me.LBL_NOMBRE1.Visible = False
        '
        'LBL_OBSERVA1
        '
        Me.LBL_OBSERVA1.AutoSize = True
        Me.LBL_OBSERVA1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_OBSERVA1.ForeColor = System.Drawing.Color.Blue
        Me.LBL_OBSERVA1.Location = New System.Drawing.Point(409, 252)
        Me.LBL_OBSERVA1.Name = "LBL_OBSERVA1"
        Me.LBL_OBSERVA1.Size = New System.Drawing.Size(25, 24)
        Me.LBL_OBSERVA1.TabIndex = 13
        Me.LBL_OBSERVA1.Text = "..."
        Me.LBL_OBSERVA1.Visible = False
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(334, 413)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(153, 47)
        Me.Button2.TabIndex = 14
        Me.Button2.Text = "OK-6"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'FRM_EJEMPLO_IF
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(817, 496)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.LBL_OBSERVA1)
        Me.Controls.Add(Me.LBL_NOMBRE1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.LBL_OBSERVA)
        Me.Controls.Add(Me.BTN_FIN)
        Me.Controls.Add(Me.BTN_CLEAR)
        Me.Controls.Add(Me.BTN_OK)
        Me.Controls.Add(Me.TXT_NOMBRE)
        Me.Controls.Add(Me.TXT_EDAD)
        Me.Controls.Add(Me.LBL_EDAD)
        Me.Controls.Add(Me.TXT_APELLIDO)
        Me.Controls.Add(Me.LBL_APELLIDO)
        Me.Controls.Add(Me.LBL_NOMBRE)
        Me.Name = "FRM_EJEMPLO_IF"
        Me.Text = "FRM_EJEMPLO_IF"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LBL_NOMBRE As Label
    Friend WithEvents LBL_APELLIDO As Label
    Friend WithEvents TXT_APELLIDO As TextBox
    Friend WithEvents LBL_EDAD As Label
    Friend WithEvents TXT_EDAD As TextBox
    Friend WithEvents TXT_NOMBRE As TextBox
    Friend WithEvents BTN_OK As Button
    Friend WithEvents BTN_CLEAR As Button
    Friend WithEvents BTN_FIN As Button
    Friend WithEvents LBL_OBSERVA As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents LBL_NOMBRE1 As Label
    Friend WithEvents LBL_OBSERVA1 As Label
    Friend WithEvents Button2 As Button
End Class
