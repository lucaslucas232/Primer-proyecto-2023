<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LISTBOX
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
        Me.BTN_AGREGAR = New System.Windows.Forms.Button()
        Me.BTN_ELIMINA1 = New System.Windows.Forms.Button()
        Me.BTN_CANTIDAD = New System.Windows.Forms.Button()
        Me.BTN_ELIMINA = New System.Windows.Forms.Button()
        Me.BTN_TRIM = New System.Windows.Forms.Button()
        Me.BTN_LTRIM = New System.Windows.Forms.Button()
        Me.BTN_RTRIM = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.CHKLST = New System.Windows.Forms.CheckedListBox()
        Me.RADIOBUTTON1 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.SuspendLayout()
        '
        'BTN_AGREGAR
        '
        Me.BTN_AGREGAR.Location = New System.Drawing.Point(227, 103)
        Me.BTN_AGREGAR.Name = "BTN_AGREGAR"
        Me.BTN_AGREGAR.Size = New System.Drawing.Size(75, 36)
        Me.BTN_AGREGAR.TabIndex = 0
        Me.BTN_AGREGAR.Text = "AGREGAR"
        Me.BTN_AGREGAR.UseVisualStyleBackColor = True
        '
        'BTN_ELIMINA1
        '
        Me.BTN_ELIMINA1.Location = New System.Drawing.Point(227, 145)
        Me.BTN_ELIMINA1.Name = "BTN_ELIMINA1"
        Me.BTN_ELIMINA1.Size = New System.Drawing.Size(75, 37)
        Me.BTN_ELIMINA1.TabIndex = 1
        Me.BTN_ELIMINA1.Text = "ELIMINA 1"
        Me.BTN_ELIMINA1.UseVisualStyleBackColor = True
        '
        'BTN_CANTIDAD
        '
        Me.BTN_CANTIDAD.Location = New System.Drawing.Point(227, 188)
        Me.BTN_CANTIDAD.Name = "BTN_CANTIDAD"
        Me.BTN_CANTIDAD.Size = New System.Drawing.Size(75, 38)
        Me.BTN_CANTIDAD.TabIndex = 2
        Me.BTN_CANTIDAD.Text = "CANTIDAD"
        Me.BTN_CANTIDAD.UseVisualStyleBackColor = True
        '
        'BTN_ELIMINA
        '
        Me.BTN_ELIMINA.Location = New System.Drawing.Point(227, 232)
        Me.BTN_ELIMINA.Name = "BTN_ELIMINA"
        Me.BTN_ELIMINA.Size = New System.Drawing.Size(75, 34)
        Me.BTN_ELIMINA.TabIndex = 3
        Me.BTN_ELIMINA.Text = "ELIMINAR"
        Me.BTN_ELIMINA.UseVisualStyleBackColor = True
        '
        'BTN_TRIM
        '
        Me.BTN_TRIM.Location = New System.Drawing.Point(441, 103)
        Me.BTN_TRIM.Name = "BTN_TRIM"
        Me.BTN_TRIM.Size = New System.Drawing.Size(65, 39)
        Me.BTN_TRIM.TabIndex = 4
        Me.BTN_TRIM.Text = "TRIM"
        Me.BTN_TRIM.UseVisualStyleBackColor = True
        '
        'BTN_LTRIM
        '
        Me.BTN_LTRIM.Location = New System.Drawing.Point(441, 148)
        Me.BTN_LTRIM.Name = "BTN_LTRIM"
        Me.BTN_LTRIM.Size = New System.Drawing.Size(65, 39)
        Me.BTN_LTRIM.TabIndex = 5
        Me.BTN_LTRIM.Text = "LTRIM"
        Me.BTN_LTRIM.UseVisualStyleBackColor = True
        '
        'BTN_RTRIM
        '
        Me.BTN_RTRIM.Location = New System.Drawing.Point(441, 193)
        Me.BTN_RTRIM.Name = "BTN_RTRIM"
        Me.BTN_RTRIM.Size = New System.Drawing.Size(65, 39)
        Me.BTN_RTRIM.TabIndex = 6
        Me.BTN_RTRIM.Text = "RTRIM"
        Me.BTN_RTRIM.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.Location = New System.Drawing.Point(227, 299)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(102, 35)
        Me.Button8.TabIndex = 7
        Me.Button8.Text = "CHEQUEADOS"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(41, 57)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(168, 20)
        Me.TextBox1.TabIndex = 15
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Items.AddRange(New Object() {"AZUL", "VERDE ", "AMARILLO", "VIOLETA"})
        Me.ListBox1.Location = New System.Drawing.Point(41, 102)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(168, 160)
        Me.ListBox1.TabIndex = 9
        '
        'CHKLST
        '
        Me.CHKLST.FormattingEnabled = True
        Me.CHKLST.Items.AddRange(New Object() {"LUNES ", "MARTES", "MIERCOLES", "JUEVES", "VIERNES", "SABADO ", "DOMINGO"})
        Me.CHKLST.Location = New System.Drawing.Point(41, 299)
        Me.CHKLST.Name = "CHKLST"
        Me.CHKLST.Size = New System.Drawing.Size(157, 94)
        Me.CHKLST.TabIndex = 10
        '
        'RADIOBUTTON1
        '
        Me.RADIOBUTTON1.AutoSize = True
        Me.RADIOBUTTON1.Location = New System.Drawing.Point(624, 107)
        Me.RADIOBUTTON1.Name = "RADIOBUTTON1"
        Me.RADIOBUTTON1.Size = New System.Drawing.Size(43, 17)
        Me.RADIOBUTTON1.TabIndex = 16
        Me.RADIOBUTTON1.TabStop = True
        Me.RADIOBUTTON1.Text = "IZQ"
        Me.RADIOBUTTON1.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(624, 148)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(70, 17)
        Me.RadioButton2.TabIndex = 17
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "CENTRO"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.Location = New System.Drawing.Point(624, 193)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(48, 17)
        Me.RadioButton3.TabIndex = 18
        Me.RadioButton3.TabStop = True
        Me.RadioButton3.Text = "DER"
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'LISTBOX
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(870, 405)
        Me.Controls.Add(Me.RadioButton3)
        Me.Controls.Add(Me.RadioButton2)
        Me.Controls.Add(Me.RADIOBUTTON1)
        Me.Controls.Add(Me.CHKLST)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.BTN_RTRIM)
        Me.Controls.Add(Me.BTN_LTRIM)
        Me.Controls.Add(Me.BTN_TRIM)
        Me.Controls.Add(Me.BTN_ELIMINA)
        Me.Controls.Add(Me.BTN_CANTIDAD)
        Me.Controls.Add(Me.BTN_ELIMINA1)
        Me.Controls.Add(Me.BTN_AGREGAR)
        Me.Name = "LISTBOX"
        Me.Text = "70"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BTN_AGREGAR As Button
    Friend WithEvents BTN_ELIMINA1 As Button
    Friend WithEvents BTN_CANTIDAD As Button
    Friend WithEvents BTN_ELIMINA As Button
    Friend WithEvents BTN_TRIM As Button
    Friend WithEvents BTN_LTRIM As Button
    Friend WithEvents BTN_RTRIM As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents ListBox1 As Windows.Forms.ListBox
    Friend WithEvents CHKLST As CheckedListBox
    Friend WithEvents RADIOBUTTON1 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton3 As RadioButton
End Class
