<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EJERCICIO5
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
        Me.T1 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.T2 = New System.Windows.Forms.TextBox()
        Me.T3 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(147, 320)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 25)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Label1"
        Me.Label1.Visible = False
        '
        'T1
        '
        Me.T1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.T1.ForeColor = System.Drawing.SystemColors.ScrollBar
        Me.T1.Location = New System.Drawing.Point(150, 140)
        Me.T1.Name = "T1"
        Me.T1.Size = New System.Drawing.Size(244, 30)
        Me.T1.TabIndex = 13
        Me.T1.Text = "Ingrese numero"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(459, 105)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(195, 89)
        Me.Button1.TabIndex = 12
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'T2
        '
        Me.T2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.T2.ForeColor = System.Drawing.SystemColors.ScrollBar
        Me.T2.Location = New System.Drawing.Point(152, 194)
        Me.T2.Name = "T2"
        Me.T2.Size = New System.Drawing.Size(244, 30)
        Me.T2.TabIndex = 15
        Me.T2.Text = "Ingrese numero"
        '
        'T3
        '
        Me.T3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.T3.ForeColor = System.Drawing.SystemColors.ScrollBar
        Me.T3.Location = New System.Drawing.Point(152, 242)
        Me.T3.Name = "T3"
        Me.T3.Size = New System.Drawing.Size(244, 30)
        Me.T3.TabIndex = 16
        Me.T3.Text = "Ingrese numero"
        '
        'EJERCICIO5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.T3)
        Me.Controls.Add(Me.T2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.T1)
        Me.Controls.Add(Me.Button1)
        Me.Name = "EJERCICIO5"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents T1 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents T2 As TextBox
    Friend WithEvents T3 As TextBox
End Class
