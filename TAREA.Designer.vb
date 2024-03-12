<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TAREA
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
        Me.BTN_COMIENZA = New System.Windows.Forms.Button()
        Me.BTN_NUEVO = New System.Windows.Forms.Button()
        Me.LBL_NUM1 = New System.Windows.Forms.Label()
        Me.LBL_NUM2 = New System.Windows.Forms.Label()
        Me.LBL_NUM3 = New System.Windows.Forms.Label()
        Me.LBL_SEGUNDOS = New System.Windows.Forms.Label()
        Me.LBL_TIRADAS = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'BTN_COMIENZA
        '
        Me.BTN_COMIENZA.Location = New System.Drawing.Point(392, 64)
        Me.BTN_COMIENZA.Name = "BTN_COMIENZA"
        Me.BTN_COMIENZA.Size = New System.Drawing.Size(85, 32)
        Me.BTN_COMIENZA.TabIndex = 0
        Me.BTN_COMIENZA.Text = "COMIENZA"
        Me.BTN_COMIENZA.UseVisualStyleBackColor = True
        '
        'BTN_NUEVO
        '
        Me.BTN_NUEVO.Location = New System.Drawing.Point(500, 64)
        Me.BTN_NUEVO.Name = "BTN_NUEVO"
        Me.BTN_NUEVO.Size = New System.Drawing.Size(85, 32)
        Me.BTN_NUEVO.TabIndex = 1
        Me.BTN_NUEVO.Text = "NUEVO"
        Me.BTN_NUEVO.UseVisualStyleBackColor = True
        '
        'LBL_NUM1
        '
        Me.LBL_NUM1.AutoSize = True
        Me.LBL_NUM1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_NUM1.Location = New System.Drawing.Point(98, 76)
        Me.LBL_NUM1.Name = "LBL_NUM1"
        Me.LBL_NUM1.Size = New System.Drawing.Size(20, 22)
        Me.LBL_NUM1.TabIndex = 2
        Me.LBL_NUM1.Text = "3"
        '
        'LBL_NUM2
        '
        Me.LBL_NUM2.AutoSize = True
        Me.LBL_NUM2.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_NUM2.Location = New System.Drawing.Point(174, 74)
        Me.LBL_NUM2.Name = "LBL_NUM2"
        Me.LBL_NUM2.Size = New System.Drawing.Size(20, 22)
        Me.LBL_NUM2.TabIndex = 3
        Me.LBL_NUM2.Text = "7"
        '
        'LBL_NUM3
        '
        Me.LBL_NUM3.AutoSize = True
        Me.LBL_NUM3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_NUM3.Location = New System.Drawing.Point(255, 76)
        Me.LBL_NUM3.Name = "LBL_NUM3"
        Me.LBL_NUM3.Size = New System.Drawing.Size(18, 20)
        Me.LBL_NUM3.TabIndex = 4
        Me.LBL_NUM3.Text = "5"
        '
        'LBL_SEGUNDOS
        '
        Me.LBL_SEGUNDOS.AutoSize = True
        Me.LBL_SEGUNDOS.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_SEGUNDOS.Location = New System.Drawing.Point(73, 242)
        Me.LBL_SEGUNDOS.Name = "LBL_SEGUNDOS"
        Me.LBL_SEGUNDOS.Size = New System.Drawing.Size(20, 22)
        Me.LBL_SEGUNDOS.TabIndex = 5
        Me.LBL_SEGUNDOS.Text = "5"
        '
        'LBL_TIRADAS
        '
        Me.LBL_TIRADAS.AutoSize = True
        Me.LBL_TIRADAS.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_TIRADAS.Location = New System.Drawing.Point(469, 242)
        Me.LBL_TIRADAS.Name = "LBL_TIRADAS"
        Me.LBL_TIRADAS.Size = New System.Drawing.Size(20, 22)
        Me.LBL_TIRADAS.TabIndex = 6
        Me.LBL_TIRADAS.Text = "0"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(516, 247)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(123, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "NUMERO DE TIRADAS"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(116, 247)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(68, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "SEGUNDOS"
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'Timer2
        '
        '
        'TAREA
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.LBL_TIRADAS)
        Me.Controls.Add(Me.LBL_SEGUNDOS)
        Me.Controls.Add(Me.LBL_NUM3)
        Me.Controls.Add(Me.LBL_NUM2)
        Me.Controls.Add(Me.LBL_NUM1)
        Me.Controls.Add(Me.BTN_NUEVO)
        Me.Controls.Add(Me.BTN_COMIENZA)
        Me.Name = "TAREA"
        Me.Text = "TI"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BTN_COMIENZA As Button
    Friend WithEvents BTN_NUEVO As Button
    Friend WithEvents LBL_NUM1 As Label
    Friend WithEvents LBL_NUM2 As Label
    Friend WithEvents LBL_NUM3 As Label
    Friend WithEvents LBL_SEGUNDOS As Label
    Friend WithEvents LBL_TIRADAS As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Timer1 As Windows.Forms.Timer
    Friend WithEvents Timer2 As Windows.Forms.Timer
End Class
