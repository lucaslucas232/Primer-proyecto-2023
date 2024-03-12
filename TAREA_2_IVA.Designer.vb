<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TAREA_2_IVA
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
        Me.TXT_MONTO = New System.Windows.Forms.TextBox()
        Me.TXT_IVA = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.LBL_RESULTADO = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.CALCULA = New System.Windows.Forms.Button()
        Me.BTN_NUEVO = New System.Windows.Forms.Button()
        Me.BTN_FIN = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TXT_MONTO
        '
        Me.TXT_MONTO.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_MONTO.Location = New System.Drawing.Point(59, 71)
        Me.TXT_MONTO.Name = "TXT_MONTO"
        Me.TXT_MONTO.Size = New System.Drawing.Size(131, 27)
        Me.TXT_MONTO.TabIndex = 0
        '
        'TXT_IVA
        '
        Me.TXT_IVA.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_IVA.Location = New System.Drawing.Point(236, 71)
        Me.TXT_IVA.Name = "TXT_IVA"
        Me.TXT_IVA.Size = New System.Drawing.Size(43, 27)
        Me.TXT_IVA.TabIndex = 1
        Me.TXT_IVA.Text = "22%"
        '
        'TextBox3
        '
        Me.TextBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox3.Location = New System.Drawing.Point(441, 71)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(131, 27)
        Me.TextBox3.TabIndex = 2
        '
        'LBL_RESULTADO
        '
        Me.LBL_RESULTADO.AutoSize = True
        Me.LBL_RESULTADO.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_RESULTADO.Location = New System.Drawing.Point(345, 71)
        Me.LBL_RESULTADO.Name = "LBL_RESULTADO"
        Me.LBL_RESULTADO.Size = New System.Drawing.Size(24, 25)
        Me.LBL_RESULTADO.TabIndex = 3
        Me.LBL_RESULTADO.Text = "0"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(56, 31)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "PRECIO S/IVA"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(244, 31)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(24, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "IVA"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(317, 31)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(93, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "PRECIO CON IVA"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(625, 71)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(24, 25)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "0"
        '
        'CALCULA
        '
        Me.CALCULA.Location = New System.Drawing.Point(76, 143)
        Me.CALCULA.Name = "CALCULA"
        Me.CALCULA.Size = New System.Drawing.Size(79, 47)
        Me.CALCULA.TabIndex = 8
        Me.CALCULA.Text = "CALCULAR"
        Me.CALCULA.UseVisualStyleBackColor = True
        '
        'BTN_NUEVO
        '
        Me.BTN_NUEVO.Location = New System.Drawing.Point(221, 143)
        Me.BTN_NUEVO.Name = "BTN_NUEVO"
        Me.BTN_NUEVO.Size = New System.Drawing.Size(72, 47)
        Me.BTN_NUEVO.TabIndex = 9
        Me.BTN_NUEVO.Text = "NUEVO"
        Me.BTN_NUEVO.UseVisualStyleBackColor = True
        '
        'BTN_FIN
        '
        Me.BTN_FIN.Location = New System.Drawing.Point(580, 143)
        Me.BTN_FIN.Name = "BTN_FIN"
        Me.BTN_FIN.Size = New System.Drawing.Size(119, 47)
        Me.BTN_FIN.TabIndex = 10
        Me.BTN_FIN.Text = "FIN"
        Me.BTN_FIN.UseVisualStyleBackColor = True
        '
        'TAREA_2_IVA
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.BTN_FIN)
        Me.Controls.Add(Me.BTN_NUEVO)
        Me.Controls.Add(Me.CALCULA)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.LBL_RESULTADO)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TXT_IVA)
        Me.Controls.Add(Me.TXT_MONTO)
        Me.Name = "TAREA_2_IVA"
        Me.Text = "TAREA_2_IVA"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TXT_MONTO As TextBox
    Friend WithEvents TXT_IVA As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents LBL_RESULTADO As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents CALCULA As Button
    Friend WithEvents BTN_NUEVO As Button
    Friend WithEvents BTN_FIN As Button
End Class
