<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class JUEGO
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
        Me.components = New System.ComponentModel.Container()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.BTN_NEW = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.LBL_PUN = New System.Windows.Forms.Label()
        Me.LBL_PUNTAJE = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(669, 44)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(85, 60)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "START"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'BTN_NEW
        '
        Me.BTN_NEW.Location = New System.Drawing.Point(669, 128)
        Me.BTN_NEW.Name = "BTN_NEW"
        Me.BTN_NEW.Size = New System.Drawing.Size(85, 60)
        Me.BTN_NEW.TabIndex = 1
        Me.BTN_NEW.Text = "NEW"
        Me.BTN_NEW.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(149, 57)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(123, 30)
        Me.TextBox1.TabIndex = 2
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(669, 241)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(85, 60)
        Me.Button3.TabIndex = 3
        Me.Button3.Text = "Button3"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RadioButton3)
        Me.GroupBox1.Controls.Add(Me.RadioButton2)
        Me.GroupBox1.Controls.Add(Me.RadioButton1)
        Me.GroupBox1.Location = New System.Drawing.Point(361, 41)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(222, 147)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "NIVEL"
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.Location = New System.Drawing.Point(19, 109)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(84, 17)
        Me.RadioButton3.TabIndex = 12
        Me.RadioButton3.TabStop = True
        Me.RadioButton3.Text = "AVANZADO"
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(19, 69)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(93, 17)
        Me.RadioButton2.TabIndex = 11
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "INTERMEDIO"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(19, 25)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(100, 17)
        Me.RadioButton1.TabIndex = 10
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "PRINCIPIANTE"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'LBL_PUN
        '
        Me.LBL_PUN.AutoSize = True
        Me.LBL_PUN.Location = New System.Drawing.Point(366, 241)
        Me.LBL_PUN.Name = "LBL_PUN"
        Me.LBL_PUN.Size = New System.Drawing.Size(59, 13)
        Me.LBL_PUN.TabIndex = 5
        Me.LBL_PUN.Text = "PUNTAJE:"
        '
        'LBL_PUNTAJE
        '
        Me.LBL_PUNTAJE.AutoSize = True
        Me.LBL_PUNTAJE.Location = New System.Drawing.Point(442, 241)
        Me.LBL_PUNTAJE.Name = "LBL_PUNTAJE"
        Me.LBL_PUNTAJE.Size = New System.Drawing.Size(13, 13)
        Me.LBL_PUNTAJE.TabIndex = 6
        Me.LBL_PUNTAJE.Text = "0"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(146, 110)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "ERROR!"
        Me.Label3.Visible = False
        '
        'Timer1
        '
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(58, 62)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(76, 25)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "2 * 3 ="
        '
        'JUEGO
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 362)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.LBL_PUNTAJE)
        Me.Controls.Add(Me.LBL_PUN)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.BTN_NEW)
        Me.Controls.Add(Me.Button1)
        Me.Name = "JUEGO"
        Me.Text = "JUEGO"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents BTN_NEW As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button3 As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents RadioButton3 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents LBL_PUN As Label
    Friend WithEvents LBL_PUNTAJE As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Timer1 As Windows.Forms.Timer
    Friend WithEvents Label4 As Label
End Class
