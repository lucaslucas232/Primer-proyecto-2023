<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRM_PRACTICO_BD
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
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DGV1 = New System.Windows.Forms.DataGridView()
        Me.DTP1 = New System.Windows.Forms.DateTimePicker()
        Me.BTN_ELIMINAR = New System.Windows.Forms.Button()
        Me.BTN_CANCELAR = New System.Windows.Forms.Button()
        Me.BTN_MODIFICAR = New System.Windows.Forms.Button()
        Me.BTN_AGREGAR = New System.Windows.Forms.Button()
        Me.BTN_NUEVO = New System.Windows.Forms.Button()
        Me.TXT_PRECIO = New System.Windows.Forms.TextBox()
        Me.TXT_NOMBRE = New System.Windows.Forms.TextBox()
        Me.BTN_FIN = New System.Windows.Forms.Button()
        CType(Me.DGV1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(80, 108)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(137, 13)
        Me.Label4.TabIndex = 33
        Me.Label4.Text = "FECHA DE VENCIMIENTO"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(115, 71)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(102, 13)
        Me.Label2.TabIndex = 31
        Me.Label2.Text = "PRECIO UNITARIO"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(99, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(118, 13)
        Me.Label1.TabIndex = 30
        Me.Label1.Text = "NOMBRE PRODUCTO"
        '
        'DGV1
        '
        Me.DGV1.AllowUserToAddRows = False
        Me.DGV1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV1.Location = New System.Drawing.Point(45, 160)
        Me.DGV1.Name = "DGV1"
        Me.DGV1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV1.Size = New System.Drawing.Size(477, 169)
        Me.DGV1.TabIndex = 29
        '
        'DTP1
        '
        Me.DTP1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTP1.Location = New System.Drawing.Point(250, 105)
        Me.DTP1.Name = "DTP1"
        Me.DTP1.Size = New System.Drawing.Size(219, 20)
        Me.DTP1.TabIndex = 22
        '
        'BTN_ELIMINAR
        '
        Me.BTN_ELIMINAR.Location = New System.Drawing.Point(634, 285)
        Me.BTN_ELIMINAR.Name = "BTN_ELIMINAR"
        Me.BTN_ELIMINAR.Size = New System.Drawing.Size(114, 44)
        Me.BTN_ELIMINAR.TabIndex = 28
        Me.BTN_ELIMINAR.Text = "ELIMINAR"
        Me.BTN_ELIMINAR.UseVisualStyleBackColor = True
        '
        'BTN_CANCELAR
        '
        Me.BTN_CANCELAR.Location = New System.Drawing.Point(634, 221)
        Me.BTN_CANCELAR.Name = "BTN_CANCELAR"
        Me.BTN_CANCELAR.Size = New System.Drawing.Size(114, 44)
        Me.BTN_CANCELAR.TabIndex = 27
        Me.BTN_CANCELAR.Text = "CANCELAR"
        Me.BTN_CANCELAR.UseVisualStyleBackColor = True
        '
        'BTN_MODIFICAR
        '
        Me.BTN_MODIFICAR.Location = New System.Drawing.Point(634, 160)
        Me.BTN_MODIFICAR.Name = "BTN_MODIFICAR"
        Me.BTN_MODIFICAR.Size = New System.Drawing.Size(114, 44)
        Me.BTN_MODIFICAR.TabIndex = 26
        Me.BTN_MODIFICAR.Text = "MODIFICAR"
        Me.BTN_MODIFICAR.UseVisualStyleBackColor = True
        '
        'BTN_AGREGAR
        '
        Me.BTN_AGREGAR.Location = New System.Drawing.Point(634, 97)
        Me.BTN_AGREGAR.Name = "BTN_AGREGAR"
        Me.BTN_AGREGAR.Size = New System.Drawing.Size(114, 44)
        Me.BTN_AGREGAR.TabIndex = 25
        Me.BTN_AGREGAR.Text = "AGREGAR"
        Me.BTN_AGREGAR.UseVisualStyleBackColor = True
        '
        'BTN_NUEVO
        '
        Me.BTN_NUEVO.Location = New System.Drawing.Point(634, 35)
        Me.BTN_NUEVO.Name = "BTN_NUEVO"
        Me.BTN_NUEVO.Size = New System.Drawing.Size(114, 44)
        Me.BTN_NUEVO.TabIndex = 23
        Me.BTN_NUEVO.Text = "NUEVO"
        Me.BTN_NUEVO.UseVisualStyleBackColor = True
        '
        'TXT_PRECIO
        '
        Me.TXT_PRECIO.Location = New System.Drawing.Point(253, 68)
        Me.TXT_PRECIO.Name = "TXT_PRECIO"
        Me.TXT_PRECIO.Size = New System.Drawing.Size(216, 20)
        Me.TXT_PRECIO.TabIndex = 20
        '
        'TXT_NOMBRE
        '
        Me.TXT_NOMBRE.Location = New System.Drawing.Point(253, 28)
        Me.TXT_NOMBRE.Name = "TXT_NOMBRE"
        Me.TXT_NOMBRE.Size = New System.Drawing.Size(216, 20)
        Me.TXT_NOMBRE.TabIndex = 19
        '
        'BTN_FIN
        '
        Me.BTN_FIN.Location = New System.Drawing.Point(634, 335)
        Me.BTN_FIN.Name = "BTN_FIN"
        Me.BTN_FIN.Size = New System.Drawing.Size(114, 44)
        Me.BTN_FIN.TabIndex = 34
        Me.BTN_FIN.Text = "FIN"
        Me.BTN_FIN.UseVisualStyleBackColor = True
        '
        'FRM_PRACTICO_BD
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(792, 417)
        Me.Controls.Add(Me.BTN_FIN)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DGV1)
        Me.Controls.Add(Me.DTP1)
        Me.Controls.Add(Me.BTN_ELIMINAR)
        Me.Controls.Add(Me.BTN_CANCELAR)
        Me.Controls.Add(Me.BTN_MODIFICAR)
        Me.Controls.Add(Me.BTN_AGREGAR)
        Me.Controls.Add(Me.BTN_NUEVO)
        Me.Controls.Add(Me.TXT_PRECIO)
        Me.Controls.Add(Me.TXT_NOMBRE)
        Me.Name = "FRM_PRACTICO_BD"
        Me.Text = "FRM_PRACTICO_BD"
        CType(Me.DGV1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents DGV1 As DataGridView
    Friend WithEvents DTP1 As DateTimePicker
    Friend WithEvents BTN_ELIMINAR As Button
    Friend WithEvents BTN_CANCELAR As Button
    Friend WithEvents BTN_MODIFICAR As Button
    Friend WithEvents BTN_AGREGAR As Button
    Friend WithEvents BTN_NUEVO As Button
    Friend WithEvents TXT_PRECIO As TextBox
    Friend WithEvents TXT_NOMBRE As TextBox
    Friend WithEvents BTN_FIN As Button
End Class
