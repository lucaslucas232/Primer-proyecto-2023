<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PRACTICA_FORNEXT
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
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.LST_PAR = New System.Windows.Forms.ListBox()
        Me.LST_IMPAR = New System.Windows.Forms.ListBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(73, 89)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(110, 121)
        Me.ListBox1.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(202, 89)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(122, 44)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(525, 305)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(119, 44)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Button2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(417, 234)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(128, 20)
        Me.TextBox1.TabIndex = 3
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(597, 234)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(114, 20)
        Me.TextBox2.TabIndex = 4
        '
        'LST_PAR
        '
        Me.LST_PAR.FormattingEnabled = True
        Me.LST_PAR.Location = New System.Drawing.Point(417, 55)
        Me.LST_PAR.Name = "LST_PAR"
        Me.LST_PAR.Size = New System.Drawing.Size(106, 82)
        Me.LST_PAR.TabIndex = 5
        '
        'LST_IMPAR
        '
        Me.LST_IMPAR.FormattingEnabled = True
        Me.LST_IMPAR.Location = New System.Drawing.Point(597, 55)
        Me.LST_IMPAR.Name = "LST_IMPAR"
        Me.LST_IMPAR.Size = New System.Drawing.Size(106, 82)
        Me.LST_IMPAR.TabIndex = 6
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(538, 163)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(59, 30)
        Me.Button3.TabIndex = 7
        Me.Button3.Text = "Button3"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'PRACTICA_FORNEXT
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.LST_IMPAR)
        Me.Controls.Add(Me.LST_PAR)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ListBox1)
        Me.Name = "PRACTICA_FORNEXT"
        Me.Text = "PRACTICA_FORNEXT"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ListBox1 As Windows.Forms.ListBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents LST_PAR As Windows.Forms.ListBox
    Friend WithEvents LST_IMPAR As Windows.Forms.ListBox
    Friend WithEvents Button3 As Button
End Class
