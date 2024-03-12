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
        Me.TXT_CANTIDAD = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TXT_PRECIO = New System.Windows.Forms.TextBox()
        Me.BTN_CALCULAR = New System.Windows.Forms.Button()
        Me.BTN_NUEVO = New System.Windows.Forms.Button()
        Me.BTN_FIN = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CBO_CATEGORIA = New System.Windows.Forms.ComboBox()
        Me.LBL_TOTAL = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'TXT_CANTIDAD
        '
        Me.TXT_CANTIDAD.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_CANTIDAD.ForeColor = System.Drawing.SystemColors.ScrollBar
        Me.TXT_CANTIDAD.Location = New System.Drawing.Point(196, 186)
        Me.TXT_CANTIDAD.Name = "TXT_CANTIDAD"
        Me.TXT_CANTIDAD.Size = New System.Drawing.Size(244, 30)
        Me.TXT_CANTIDAD.TabIndex = 20
        Me.TXT_CANTIDAD.Text = "Ingrese numero"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(32, 130)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(144, 25)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "PRECIO UNIT:"
        '
        'TXT_PRECIO
        '
        Me.TXT_PRECIO.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_PRECIO.ForeColor = System.Drawing.SystemColors.ScrollBar
        Me.TXT_PRECIO.Location = New System.Drawing.Point(196, 125)
        Me.TXT_PRECIO.Name = "TXT_PRECIO"
        Me.TXT_PRECIO.Size = New System.Drawing.Size(244, 30)
        Me.TXT_PRECIO.TabIndex = 18
        Me.TXT_PRECIO.Text = "Ingrese numero"
        '
        'BTN_CALCULAR
        '
        Me.BTN_CALCULAR.Location = New System.Drawing.Point(583, 116)
        Me.BTN_CALCULAR.Name = "BTN_CALCULAR"
        Me.BTN_CALCULAR.Size = New System.Drawing.Size(141, 41)
        Me.BTN_CALCULAR.TabIndex = 17
        Me.BTN_CALCULAR.Text = "CALCULAR"
        Me.BTN_CALCULAR.UseVisualStyleBackColor = True
        '
        'BTN_NUEVO
        '
        Me.BTN_NUEVO.Location = New System.Drawing.Point(583, 178)
        Me.BTN_NUEVO.Name = "BTN_NUEVO"
        Me.BTN_NUEVO.Size = New System.Drawing.Size(141, 41)
        Me.BTN_NUEVO.TabIndex = 22
        Me.BTN_NUEVO.Text = "NUEVO"
        Me.BTN_NUEVO.UseVisualStyleBackColor = True
        '
        'BTN_FIN
        '
        Me.BTN_FIN.Location = New System.Drawing.Point(583, 245)
        Me.BTN_FIN.Name = "BTN_FIN"
        Me.BTN_FIN.Size = New System.Drawing.Size(141, 41)
        Me.BTN_FIN.TabIndex = 23
        Me.BTN_FIN.Text = "FIN"
        Me.BTN_FIN.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(55, 191)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(121, 25)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "CANTIDAD:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(40, 261)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(136, 25)
        Me.Label3.TabIndex = 25
        Me.Label3.Text = "CATEGORIA:"
        '
        'CBO_CATEGORIA
        '
        Me.CBO_CATEGORIA.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBO_CATEGORIA.FormattingEnabled = True
        Me.CBO_CATEGORIA.Items.AddRange(New Object() {"A", "B", "C", "D"})
        Me.CBO_CATEGORIA.Location = New System.Drawing.Point(196, 253)
        Me.CBO_CATEGORIA.Name = "CBO_CATEGORIA"
        Me.CBO_CATEGORIA.Size = New System.Drawing.Size(247, 33)
        Me.CBO_CATEGORIA.TabIndex = 26
        '
        'LBL_TOTAL
        '
        Me.LBL_TOTAL.AutoSize = True
        Me.LBL_TOTAL.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_TOTAL.Location = New System.Drawing.Point(578, 356)
        Me.LBL_TOTAL.Name = "LBL_TOTAL"
        Me.LBL_TOTAL.Size = New System.Drawing.Size(39, 25)
        Me.LBL_TOTAL.TabIndex = 27
        Me.LBL_TOTAL.Text = "0.0"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.LBL_TOTAL)
        Me.Controls.Add(Me.CBO_CATEGORIA)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.BTN_FIN)
        Me.Controls.Add(Me.BTN_NUEVO)
        Me.Controls.Add(Me.TXT_CANTIDAD)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TXT_PRECIO)
        Me.Controls.Add(Me.BTN_CALCULAR)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TXT_CANTIDAD As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TXT_PRECIO As TextBox
    Friend WithEvents BTN_CALCULAR As Button
    Friend WithEvents BTN_NUEVO As Button
    Friend WithEvents BTN_FIN As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents CBO_CATEGORIA As ComboBox
    Friend WithEvents LBL_TOTAL As Label
End Class
