<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LISTVIEW
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
        Me.TXT_NOMBRE = New System.Windows.Forms.TextBox()
        Me.TXT_APELLIDO = New System.Windows.Forms.TextBox()
        Me.TXT_NOTA = New System.Windows.Forms.TextBox()
        Me.LBL_NOMBRE = New System.Windows.Forms.Label()
        Me.LBL_APELLIDO = New System.Windows.Forms.Label()
        Me.LBL_NOTA = New System.Windows.Forms.Label()
        Me.BTN_AGREGA = New System.Windows.Forms.Button()
        Me.BTN_ELIMINA = New System.Windows.Forms.Button()
        Me.BTN_LIMPIA = New System.Windows.Forms.Button()
        Me.BTN_FIN = New System.Windows.Forms.Button()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.NOMBRE = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.APELLIDO = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.NOTA = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.OBSERVACIONES = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.BTN_CARGA = New System.Windows.Forms.Button()
        Me.BTN_PROMEDIO = New System.Windows.Forms.Button()
        Me.LBL_PROMEDIO = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'TXT_NOMBRE
        '
        Me.TXT_NOMBRE.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_NOMBRE.Location = New System.Drawing.Point(111, 59)
        Me.TXT_NOMBRE.Name = "TXT_NOMBRE"
        Me.TXT_NOMBRE.Size = New System.Drawing.Size(144, 26)
        Me.TXT_NOMBRE.TabIndex = 0
        '
        'TXT_APELLIDO
        '
        Me.TXT_APELLIDO.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_APELLIDO.Location = New System.Drawing.Point(355, 59)
        Me.TXT_APELLIDO.Name = "TXT_APELLIDO"
        Me.TXT_APELLIDO.Size = New System.Drawing.Size(144, 26)
        Me.TXT_APELLIDO.TabIndex = 1
        '
        'TXT_NOTA
        '
        Me.TXT_NOTA.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_NOTA.Location = New System.Drawing.Point(563, 59)
        Me.TXT_NOTA.Name = "TXT_NOTA"
        Me.TXT_NOTA.Size = New System.Drawing.Size(144, 26)
        Me.TXT_NOTA.TabIndex = 2
        '
        'LBL_NOMBRE
        '
        Me.LBL_NOMBRE.AutoSize = True
        Me.LBL_NOMBRE.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_NOMBRE.Location = New System.Drawing.Point(26, 65)
        Me.LBL_NOMBRE.Name = "LBL_NOMBRE"
        Me.LBL_NOMBRE.Size = New System.Drawing.Size(79, 20)
        Me.LBL_NOMBRE.TabIndex = 3
        Me.LBL_NOMBRE.Text = "NOMBRE"
        '
        'LBL_APELLIDO
        '
        Me.LBL_APELLIDO.AutoSize = True
        Me.LBL_APELLIDO.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_APELLIDO.Location = New System.Drawing.Point(261, 59)
        Me.LBL_APELLIDO.Name = "LBL_APELLIDO"
        Me.LBL_APELLIDO.Size = New System.Drawing.Size(88, 20)
        Me.LBL_APELLIDO.TabIndex = 4
        Me.LBL_APELLIDO.Text = "APELLIDO"
        '
        'LBL_NOTA
        '
        Me.LBL_NOTA.AutoSize = True
        Me.LBL_NOTA.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_NOTA.Location = New System.Drawing.Point(505, 59)
        Me.LBL_NOTA.Name = "LBL_NOTA"
        Me.LBL_NOTA.Size = New System.Drawing.Size(52, 20)
        Me.LBL_NOTA.TabIndex = 5
        Me.LBL_NOTA.Text = "NOTA"
        '
        'BTN_AGREGA
        '
        Me.BTN_AGREGA.Location = New System.Drawing.Point(81, 278)
        Me.BTN_AGREGA.Name = "BTN_AGREGA"
        Me.BTN_AGREGA.Size = New System.Drawing.Size(63, 43)
        Me.BTN_AGREGA.TabIndex = 6
        Me.BTN_AGREGA.Text = "AGREGA"
        Me.BTN_AGREGA.UseVisualStyleBackColor = True
        '
        'BTN_ELIMINA
        '
        Me.BTN_ELIMINA.Location = New System.Drawing.Point(207, 278)
        Me.BTN_ELIMINA.Name = "BTN_ELIMINA"
        Me.BTN_ELIMINA.Size = New System.Drawing.Size(62, 43)
        Me.BTN_ELIMINA.TabIndex = 7
        Me.BTN_ELIMINA.Text = "ELIMINA"
        Me.BTN_ELIMINA.UseVisualStyleBackColor = True
        '
        'BTN_LIMPIA
        '
        Me.BTN_LIMPIA.Location = New System.Drawing.Point(335, 278)
        Me.BTN_LIMPIA.Name = "BTN_LIMPIA"
        Me.BTN_LIMPIA.Size = New System.Drawing.Size(62, 43)
        Me.BTN_LIMPIA.TabIndex = 8
        Me.BTN_LIMPIA.Text = "LIMPIA"
        Me.BTN_LIMPIA.UseVisualStyleBackColor = True
        '
        'BTN_FIN
        '
        Me.BTN_FIN.Location = New System.Drawing.Point(447, 278)
        Me.BTN_FIN.Name = "BTN_FIN"
        Me.BTN_FIN.Size = New System.Drawing.Size(69, 43)
        Me.BTN_FIN.TabIndex = 9
        Me.BTN_FIN.Text = "FIN"
        Me.BTN_FIN.UseVisualStyleBackColor = True
        '
        'ListView1
        '
        Me.ListView1.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.ListView1.CheckBoxes = True
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.NOMBRE, Me.APELLIDO, Me.NOTA, Me.OBSERVACIONES})
        Me.ListView1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListView1.FullRowSelect = True
        Me.ListView1.GridLines = True
        Me.ListView1.HideSelection = False
        Me.ListView1.Location = New System.Drawing.Point(81, 113)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(635, 143)
        Me.ListView1.TabIndex = 10
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'NOMBRE
        '
        Me.NOMBRE.Text = "NOMBRE"
        Me.NOMBRE.Width = 127
        '
        'APELLIDO
        '
        Me.APELLIDO.Text = "APELLIDO"
        Me.APELLIDO.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.APELLIDO.Width = 159
        '
        'NOTA
        '
        Me.NOTA.Text = "NOTA"
        Me.NOTA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.NOTA.Width = 129
        '
        'OBSERVACIONES
        '
        Me.OBSERVACIONES.Text = "OBSERVACION"
        Me.OBSERVACIONES.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.OBSERVACIONES.Width = 214
        '
        'BTN_CARGA
        '
        Me.BTN_CARGA.Location = New System.Drawing.Point(605, 284)
        Me.BTN_CARGA.Name = "BTN_CARGA"
        Me.BTN_CARGA.Size = New System.Drawing.Size(89, 36)
        Me.BTN_CARGA.TabIndex = 12
        Me.BTN_CARGA.Text = "CARGA AUTOMATICA"
        Me.BTN_CARGA.UseVisualStyleBackColor = True
        '
        'BTN_PROMEDIO
        '
        Me.BTN_PROMEDIO.Location = New System.Drawing.Point(86, 350)
        Me.BTN_PROMEDIO.Name = "BTN_PROMEDIO"
        Me.BTN_PROMEDIO.Size = New System.Drawing.Size(102, 38)
        Me.BTN_PROMEDIO.TabIndex = 13
        Me.BTN_PROMEDIO.Text = "PROMEDIO DE NOTAS"
        Me.BTN_PROMEDIO.UseVisualStyleBackColor = True
        '
        'LBL_PROMEDIO
        '
        Me.LBL_PROMEDIO.AutoSize = True
        Me.LBL_PROMEDIO.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_PROMEDIO.Location = New System.Drawing.Point(224, 358)
        Me.LBL_PROMEDIO.Name = "LBL_PROMEDIO"
        Me.LBL_PROMEDIO.Size = New System.Drawing.Size(31, 20)
        Me.LBL_PROMEDIO.TabIndex = 14
        Me.LBL_PROMEDIO.Text = "0.0"
        '
        'LISTVIEW
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(823, 535)
        Me.Controls.Add(Me.LBL_PROMEDIO)
        Me.Controls.Add(Me.BTN_PROMEDIO)
        Me.Controls.Add(Me.BTN_CARGA)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.BTN_FIN)
        Me.Controls.Add(Me.BTN_LIMPIA)
        Me.Controls.Add(Me.BTN_ELIMINA)
        Me.Controls.Add(Me.BTN_AGREGA)
        Me.Controls.Add(Me.LBL_NOTA)
        Me.Controls.Add(Me.LBL_APELLIDO)
        Me.Controls.Add(Me.LBL_NOMBRE)
        Me.Controls.Add(Me.TXT_NOTA)
        Me.Controls.Add(Me.TXT_APELLIDO)
        Me.Controls.Add(Me.TXT_NOMBRE)
        Me.Name = "LISTVIEW"
        Me.Text = "LISTVIEW"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TXT_NOMBRE As TextBox
    Friend WithEvents TXT_APELLIDO As TextBox
    Friend WithEvents TXT_NOTA As TextBox
    Friend WithEvents LBL_NOMBRE As Label
    Friend WithEvents LBL_APELLIDO As Label
    Friend WithEvents LBL_NOTA As Label
    Friend WithEvents BTN_AGREGA As Button
    Friend WithEvents BTN_ELIMINA As Button
    Friend WithEvents BTN_LIMPIA As Button
    Friend WithEvents BTN_FIN As Button
    Friend WithEvents ListView1 As Windows.Forms.ListView
    Friend WithEvents NOMBRE As ColumnHeader
    Friend WithEvents APELLIDO As ColumnHeader
    Friend WithEvents NOTA As ColumnHeader
    Friend WithEvents OBSERVACIONES As ColumnHeader
    Friend WithEvents BTN_CARGA As Button
    Friend WithEvents BTN_PROMEDIO As Button
    Friend WithEvents LBL_PROMEDIO As Label
End Class
