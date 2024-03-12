<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FOR_NEXT
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
        Me.BTN_GENERAR = New System.Windows.Forms.Button()
        Me.BTN_NUEVO = New System.Windows.Forms.Button()
        Me.BTN_FIN = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TXT_1 = New System.Windows.Forms.TextBox()
        Dim listBox As Windows.Forms.ListBox = New System.Windows.Forms.ListBox()
        Me.LST_1 = listBox
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'BTN_GENERAR
        '
        Me.BTN_GENERAR.Location = New System.Drawing.Point(86, 138)
        Me.BTN_GENERAR.Name = "BTN_GENERAR"
        Me.BTN_GENERAR.Size = New System.Drawing.Size(171, 56)
        Me.BTN_GENERAR.TabIndex = 0
        Me.BTN_GENERAR.Text = "GENERAR"
        Me.BTN_GENERAR.UseVisualStyleBackColor = True
        '
        'BTN_NUEVO
        '
        Me.BTN_NUEVO.Location = New System.Drawing.Point(86, 224)
        Me.BTN_NUEVO.Name = "BTN_NUEVO"
        Me.BTN_NUEVO.Size = New System.Drawing.Size(171, 56)
        Me.BTN_NUEVO.TabIndex = 1
        Me.BTN_NUEVO.Text = "NUEVO"
        Me.BTN_NUEVO.UseVisualStyleBackColor = True
        '
        'BTN_FIN
        '
        Me.BTN_FIN.Location = New System.Drawing.Point(86, 320)
        Me.BTN_FIN.Name = "BTN_FIN"
        Me.BTN_FIN.Size = New System.Drawing.Size(171, 56)
        Me.BTN_FIN.TabIndex = 2
        Me.BTN_FIN.Text = "FORMULARIO PRUEBA"
        Me.BTN_FIN.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(44, 54)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(309, 20)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "INGRESE UN NUMERO DEL 1 AL 10"
        '
        'TXT_1
        '
        Me.TXT_1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_1.Location = New System.Drawing.Point(402, 47)
        Me.TXT_1.Name = "TXT_1"
        Me.TXT_1.Size = New System.Drawing.Size(80, 30)
        Me.TXT_1.TabIndex = 5
        '
        'LST_1
        '
        Me.LST_1.FormattingEnabled = True
        Me.LST_1.Location = New System.Drawing.Point(402, 138)
        Me.LST_1.Name = "LST_1"
        Me.LST_1.Size = New System.Drawing.Size(289, 238)
        Me.LST_1.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(399, 398)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 20)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Label2"
        '
        'FOR_NEXT
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(722, 445)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.LST_1)
        Me.Controls.Add(Me.TXT_1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BTN_FIN)
        Me.Controls.Add(Me.BTN_NUEVO)
        Me.Controls.Add(Me.BTN_GENERAR)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "FOR_NEXT"
        Me.Text = "LOOPSvb"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BTN_GENERAR As Button
    Friend WithEvents BTN_NUEVO As Button
    Friend WithEvents BTN_FIN As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents TXT_1 As TextBox
    Friend WithEvents LST_1 As ListBox
    Friend WithEvents Label2 As Label
End Class
