<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NUEVO_USUARIO
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
        Me.TXT_NOMBRE = New System.Windows.Forms.TextBox()
        Me.TXT_APELLIDO = New System.Windows.Forms.TextBox()
        Me.txt_USUARIO = New System.Windows.Forms.TextBox()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.BTN_NUEVO = New System.Windows.Forms.Button()
        Me.BTN_AGREGAR = New System.Windows.Forms.Button()
        Me.BTN_MODIFICAR = New System.Windows.Forms.Button()
        Me.BTN_CANCELAR = New System.Windows.Forms.Button()
        Me.BTN_ELIMINAR = New System.Windows.Forms.Button()
        Me.BTN_FIN = New System.Windows.Forms.Button()
        Me.DTP1 = New System.Windows.Forms.DateTimePicker()
        Me.DGV1 = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.TXT_CONTRASEÑA = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.DGV1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TXT_NOMBRE
        '
        Me.TXT_NOMBRE.Location = New System.Drawing.Point(112, 52)
        Me.TXT_NOMBRE.Name = "TXT_NOMBRE"
        Me.TXT_NOMBRE.Size = New System.Drawing.Size(216, 20)
        Me.TXT_NOMBRE.TabIndex = 0
        '
        'TXT_APELLIDO
        '
        Me.TXT_APELLIDO.Location = New System.Drawing.Point(112, 92)
        Me.TXT_APELLIDO.Name = "TXT_APELLIDO"
        Me.TXT_APELLIDO.Size = New System.Drawing.Size(216, 20)
        Me.TXT_APELLIDO.TabIndex = 1
        '
        'txt_USUARIO
        '
        Me.txt_USUARIO.Location = New System.Drawing.Point(112, 131)
        Me.txt_USUARIO.Name = "txt_USUARIO"
        Me.txt_USUARIO.Size = New System.Drawing.Size(216, 20)
        Me.txt_USUARIO.TabIndex = 2
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'BTN_NUEVO
        '
        Me.BTN_NUEVO.Location = New System.Drawing.Point(599, 30)
        Me.BTN_NUEVO.Name = "BTN_NUEVO"
        Me.BTN_NUEVO.Size = New System.Drawing.Size(114, 44)
        Me.BTN_NUEVO.TabIndex = 4
        Me.BTN_NUEVO.Text = "NUEVO"
        Me.BTN_NUEVO.UseVisualStyleBackColor = True
        '
        'BTN_AGREGAR
        '
        Me.BTN_AGREGAR.Location = New System.Drawing.Point(599, 92)
        Me.BTN_AGREGAR.Name = "BTN_AGREGAR"
        Me.BTN_AGREGAR.Size = New System.Drawing.Size(114, 44)
        Me.BTN_AGREGAR.TabIndex = 5
        Me.BTN_AGREGAR.Text = "AGREGAR"
        Me.BTN_AGREGAR.UseVisualStyleBackColor = True
        '
        'BTN_MODIFICAR
        '
        Me.BTN_MODIFICAR.Location = New System.Drawing.Point(599, 155)
        Me.BTN_MODIFICAR.Name = "BTN_MODIFICAR"
        Me.BTN_MODIFICAR.Size = New System.Drawing.Size(114, 44)
        Me.BTN_MODIFICAR.TabIndex = 6
        Me.BTN_MODIFICAR.Text = "MODIFICAR"
        Me.BTN_MODIFICAR.UseVisualStyleBackColor = True
        '
        'BTN_CANCELAR
        '
        Me.BTN_CANCELAR.Location = New System.Drawing.Point(599, 216)
        Me.BTN_CANCELAR.Name = "BTN_CANCELAR"
        Me.BTN_CANCELAR.Size = New System.Drawing.Size(114, 44)
        Me.BTN_CANCELAR.TabIndex = 7
        Me.BTN_CANCELAR.Text = "CANCELAR"
        Me.BTN_CANCELAR.UseVisualStyleBackColor = True
        '
        'BTN_ELIMINAR
        '
        Me.BTN_ELIMINAR.Location = New System.Drawing.Point(599, 280)
        Me.BTN_ELIMINAR.Name = "BTN_ELIMINAR"
        Me.BTN_ELIMINAR.Size = New System.Drawing.Size(114, 44)
        Me.BTN_ELIMINAR.TabIndex = 8
        Me.BTN_ELIMINAR.Text = "ELIMINAR"
        Me.BTN_ELIMINAR.UseVisualStyleBackColor = True
        '
        'BTN_FIN
        '
        Me.BTN_FIN.Location = New System.Drawing.Point(599, 345)
        Me.BTN_FIN.Name = "BTN_FIN"
        Me.BTN_FIN.Size = New System.Drawing.Size(114, 44)
        Me.BTN_FIN.TabIndex = 9
        Me.BTN_FIN.Text = "FIN"
        Me.BTN_FIN.UseVisualStyleBackColor = True
        '
        'DTP1
        '
        Me.DTP1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTP1.Location = New System.Drawing.Point(108, 166)
        Me.DTP1.Name = "DTP1"
        Me.DTP1.Size = New System.Drawing.Size(219, 20)
        Me.DTP1.TabIndex = 3
        '
        'DGV1
        '
        Me.DGV1.AllowUserToAddRows = False
        Me.DGV1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV1.Location = New System.Drawing.Point(89, 251)
        Me.DGV1.Name = "DGV1"
        Me.DGV1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV1.Size = New System.Drawing.Size(477, 138)
        Me.DGV1.TabIndex = 11
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(39, 55)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 13)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "NOMBRE"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(34, 95)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 13)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "APELLIDO"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(37, 134)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 13)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "USUARIO"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(51, 173)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 13)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "FECHA"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'TXT_CONTRASEÑA
        '
        Me.TXT_CONTRASEÑA.Location = New System.Drawing.Point(112, 208)
        Me.TXT_CONTRASEÑA.Name = "TXT_CONTRASEÑA"
        Me.TXT_CONTRASEÑA.Size = New System.Drawing.Size(215, 20)
        Me.TXT_CONTRASEÑA.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 211)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(81, 13)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "CONTRASEÑA"
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Location = New System.Drawing.Point(370, 52)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(196, 176)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 16
        Me.PictureBox1.TabStop = False
        '
        'NUEVO_USUARIO
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(733, 421)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TXT_CONTRASEÑA)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DGV1)
        Me.Controls.Add(Me.DTP1)
        Me.Controls.Add(Me.BTN_FIN)
        Me.Controls.Add(Me.BTN_ELIMINAR)
        Me.Controls.Add(Me.BTN_CANCELAR)
        Me.Controls.Add(Me.BTN_MODIFICAR)
        Me.Controls.Add(Me.BTN_AGREGAR)
        Me.Controls.Add(Me.BTN_NUEVO)
        Me.Controls.Add(Me.txt_USUARIO)
        Me.Controls.Add(Me.TXT_APELLIDO)
        Me.Controls.Add(Me.TXT_NOMBRE)
        Me.Name = "NUEVO_USUARIO"
        Me.Text = " "
        CType(Me.DGV1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TXT_NOMBRE As TextBox
    Friend WithEvents TXT_APELLIDO As TextBox
    Friend WithEvents txt_USUARIO As TextBox
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents BTN_NUEVO As Button
    Friend WithEvents BTN_AGREGAR As Button
    Friend WithEvents BTN_MODIFICAR As Button
    Friend WithEvents BTN_CANCELAR As Button
    Friend WithEvents BTN_ELIMINAR As Button
    Friend WithEvents BTN_FIN As Button
    Friend WithEvents DTP1 As DateTimePicker
    Friend WithEvents DGV1 As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents TXT_CONTRASEÑA As TextBox
    Friend WithEvents Label5 As Label
End Class
