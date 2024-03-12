<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DO_WHILE
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
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.BTN_RIGHT = New System.Windows.Forms.Button()
        Me.BTN_LEFT = New System.Windows.Forms.Button()
        Me.BTN_DOWHILE = New System.Windows.Forms.Button()
        Me.BTN_DOWHILE2 = New System.Windows.Forms.Button()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(129, 80)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(471, 30)
        Me.TextBox1.TabIndex = 0
        Me.TextBox1.Text = "C:\ASD\FOTOS\CARA.JPG"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(126, 159)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Label1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(246, 349)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Label2"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(104, 395)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Label3"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(554, 147)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Label4"
        '
        'BTN_RIGHT
        '
        Me.BTN_RIGHT.Location = New System.Drawing.Point(129, 203)
        Me.BTN_RIGHT.Name = "BTN_RIGHT"
        Me.BTN_RIGHT.Size = New System.Drawing.Size(120, 33)
        Me.BTN_RIGHT.TabIndex = 5
        Me.BTN_RIGHT.Text = "RIGHT"
        Me.BTN_RIGHT.UseVisualStyleBackColor = True
        '
        'BTN_LEFT
        '
        Me.BTN_LEFT.Location = New System.Drawing.Point(336, 203)
        Me.BTN_LEFT.Name = "BTN_LEFT"
        Me.BTN_LEFT.Size = New System.Drawing.Size(120, 33)
        Me.BTN_LEFT.TabIndex = 6
        Me.BTN_LEFT.Text = "LEFT"
        Me.BTN_LEFT.UseVisualStyleBackColor = True
        '
        'BTN_DOWHILE
        '
        Me.BTN_DOWHILE.Location = New System.Drawing.Point(535, 203)
        Me.BTN_DOWHILE.Name = "BTN_DOWHILE"
        Me.BTN_DOWHILE.Size = New System.Drawing.Size(120, 33)
        Me.BTN_DOWHILE.TabIndex = 7
        Me.BTN_DOWHILE.Text = "DO WHILE"
        Me.BTN_DOWHILE.UseVisualStyleBackColor = True
        '
        'BTN_DOWHILE2
        '
        Me.BTN_DOWHILE2.Location = New System.Drawing.Point(311, 339)
        Me.BTN_DOWHILE2.Name = "BTN_DOWHILE2"
        Me.BTN_DOWHILE2.Size = New System.Drawing.Size(120, 33)
        Me.BTN_DOWHILE2.TabIndex = 8
        Me.BTN_DOWHILE2.Text = "DO WHILE"
        Me.BTN_DOWHILE2.UseVisualStyleBackColor = True
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumericUpDown1.Location = New System.Drawing.Point(197, 142)
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(41, 30)
        Me.NumericUpDown1.TabIndex = 9
        '
        'TextBox2
        '
        Me.TextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(107, 342)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(73, 30)
        Me.TextBox2.TabIndex = 10
        '
        'DO_WHILE
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.NumericUpDown1)
        Me.Controls.Add(Me.BTN_DOWHILE2)
        Me.Controls.Add(Me.BTN_DOWHILE)
        Me.Controls.Add(Me.BTN_LEFT)
        Me.Controls.Add(Me.BTN_RIGHT)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox1)
        Me.Name = "DO_WHILE"
        Me.Text = "DO_WHILE"
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents BTN_RIGHT As Button
    Friend WithEvents BTN_LEFT As Button
    Friend WithEvents BTN_DOWHILE As Button
    Friend WithEvents BTN_DOWHILE2 As Button
    Friend WithEvents NumericUpDown1 As NumericUpDown
    Friend WithEvents TextBox2 As TextBox
End Class
