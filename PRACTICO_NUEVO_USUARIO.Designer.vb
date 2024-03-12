<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PRACTICO_NUEVO_USUARIO
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
        Me.BTN_FIN = New System.Windows.Forms.Button()
        Me.BTN_ELIMINAR = New System.Windows.Forms.Button()
        Me.BTN_CANCELAR = New System.Windows.Forms.Button()
        Me.BTN_MODIFICAR = New System.Windows.Forms.Button()
        Me.BTN_AGREGAR = New System.Windows.Forms.Button()
        Me.BTN_NUEVO = New System.Windows.Forms.Button()
        Me.DGV1 = New System.Windows.Forms.DataGridView()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_USUARIO = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TXT_CONTRASEÑA = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TXT_CONTRASEÑA2 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        CType(Me.DGV1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BTN_FIN
        '
        Me.BTN_FIN.Location = New System.Drawing.Point(610, 356)
        Me.BTN_FIN.Name = "BTN_FIN"
        Me.BTN_FIN.Size = New System.Drawing.Size(114, 44)
        Me.BTN_FIN.TabIndex = 15
        Me.BTN_FIN.Text = "FIN"
        Me.BTN_FIN.UseVisualStyleBackColor = True
        '
        'BTN_ELIMINAR
        '
        Me.BTN_ELIMINAR.Location = New System.Drawing.Point(610, 291)
        Me.BTN_ELIMINAR.Name = "BTN_ELIMINAR"
        Me.BTN_ELIMINAR.Size = New System.Drawing.Size(114, 44)
        Me.BTN_ELIMINAR.TabIndex = 14
        Me.BTN_ELIMINAR.Text = "ELIMINAR"
        Me.BTN_ELIMINAR.UseVisualStyleBackColor = True
        '
        'BTN_CANCELAR
        '
        Me.BTN_CANCELAR.Location = New System.Drawing.Point(610, 227)
        Me.BTN_CANCELAR.Name = "BTN_CANCELAR"
        Me.BTN_CANCELAR.Size = New System.Drawing.Size(114, 44)
        Me.BTN_CANCELAR.TabIndex = 13
        Me.BTN_CANCELAR.Text = "CANCELAR"
        Me.BTN_CANCELAR.UseVisualStyleBackColor = True
        '
        'BTN_MODIFICAR
        '
        Me.BTN_MODIFICAR.Location = New System.Drawing.Point(610, 166)
        Me.BTN_MODIFICAR.Name = "BTN_MODIFICAR"
        Me.BTN_MODIFICAR.Size = New System.Drawing.Size(114, 44)
        Me.BTN_MODIFICAR.TabIndex = 12
        Me.BTN_MODIFICAR.Text = "MODIFICAR"
        Me.BTN_MODIFICAR.UseVisualStyleBackColor = True
        '
        'BTN_AGREGAR
        '
        Me.BTN_AGREGAR.Location = New System.Drawing.Point(610, 103)
        Me.BTN_AGREGAR.Name = "BTN_AGREGAR"
        Me.BTN_AGREGAR.Size = New System.Drawing.Size(114, 44)
        Me.BTN_AGREGAR.TabIndex = 11
        Me.BTN_AGREGAR.Text = "AGREGAR"
        Me.BTN_AGREGAR.UseVisualStyleBackColor = True
        '
        'BTN_NUEVO
        '
        Me.BTN_NUEVO.Location = New System.Drawing.Point(610, 41)
        Me.BTN_NUEVO.Name = "BTN_NUEVO"
        Me.BTN_NUEVO.Size = New System.Drawing.Size(114, 44)
        Me.BTN_NUEVO.TabIndex = 10
        Me.BTN_NUEVO.Text = "NUEVO"
        Me.BTN_NUEVO.UseVisualStyleBackColor = True
        '
        'DGV1
        '
        Me.DGV1.AllowUserToAddRows = False
        Me.DGV1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV1.Location = New System.Drawing.Point(80, 262)
        Me.DGV1.Name = "DGV1"
        Me.DGV1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV1.Size = New System.Drawing.Size(477, 138)
        Me.DGV1.TabIndex = 16
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(87, 54)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 13)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "USUARIO"
        '
        'txt_USUARIO
        '
        Me.txt_USUARIO.Location = New System.Drawing.Point(187, 54)
        Me.txt_USUARIO.Name = "txt_USUARIO"
        Me.txt_USUARIO.Size = New System.Drawing.Size(216, 20)
        Me.txt_USUARIO.TabIndex = 17
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(87, 90)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(81, 13)
        Me.Label5.TabIndex = 20
        Me.Label5.Text = "CONTRASEÑA"
        '
        'TXT_CONTRASEÑA
        '
        Me.TXT_CONTRASEÑA.Location = New System.Drawing.Point(187, 87)
        Me.TXT_CONTRASEÑA.Name = "TXT_CONTRASEÑA"
        Me.TXT_CONTRASEÑA.Size = New System.Drawing.Size(215, 20)
        Me.TXT_CONTRASEÑA.TabIndex = 19
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(87, 134)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 13)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "CONTRASEÑA"
        '
        'TXT_CONTRASEÑA2
        '
        Me.TXT_CONTRASEÑA2.Location = New System.Drawing.Point(187, 127)
        Me.TXT_CONTRASEÑA2.Name = "TXT_CONTRASEÑA2"
        Me.TXT_CONTRASEÑA2.Size = New System.Drawing.Size(215, 20)
        Me.TXT_CONTRASEÑA2.TabIndex = 21
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(87, 169)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(32, 13)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "TIPO"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"admin", "final"})
        Me.ComboBox1.Location = New System.Drawing.Point(187, 169)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(215, 21)
        Me.ComboBox1.TabIndex = 25
        '
        'PRACTICO_NUEVO_USUARIO
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TXT_CONTRASEÑA2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TXT_CONTRASEÑA)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txt_USUARIO)
        Me.Controls.Add(Me.DGV1)
        Me.Controls.Add(Me.BTN_FIN)
        Me.Controls.Add(Me.BTN_ELIMINAR)
        Me.Controls.Add(Me.BTN_CANCELAR)
        Me.Controls.Add(Me.BTN_MODIFICAR)
        Me.Controls.Add(Me.BTN_AGREGAR)
        Me.Controls.Add(Me.BTN_NUEVO)
        Me.Name = "PRACTICO_NUEVO_USUARIO"
        Me.Text = "PRACTICO_NUEVO_USUARIOvb"
        CType(Me.DGV1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BTN_FIN As Button
    Friend WithEvents BTN_ELIMINAR As Button
    Friend WithEvents BTN_CANCELAR As Button
    Friend WithEvents BTN_MODIFICAR As Button
    Friend WithEvents BTN_AGREGAR As Button
    Friend WithEvents BTN_NUEVO As Button
    Friend WithEvents DGV1 As DataGridView
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_USUARIO As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TXT_CONTRASEÑA As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TXT_CONTRASEÑA2 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents ComboBox1 As ComboBox
End Class
