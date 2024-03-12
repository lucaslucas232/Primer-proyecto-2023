<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FACTURAS_BOLETAS
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TXT_CODIGO = New System.Windows.Forms.TextBox()
        Me.TXT_PRODUCTO = New System.Windows.Forms.TextBox()
        Me.TXT_PRECIO = New System.Windows.Forms.TextBox()
        Me.TXT_CANTIDAD = New System.Windows.Forms.TextBox()
        Me.BTN_AGREGA = New System.Windows.Forms.Button()
        Me.BTN_NUEVO = New System.Windows.Forms.Button()
        Me.BTN_ELIMINA = New System.Windows.Forms.Button()
        Me.BTN_REDONDEAR = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lbl_sus = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.CODIGO = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.LBL_SUBTOTAL = New System.Windows.Forms.Label()
        Me.LBL_IVA = New System.Windows.Forms.Label()
        Me.LBL_SUBTOTAL2 = New System.Windows.Forms.Label()
        Me.LBL_REDONDEO = New System.Windows.Forms.Label()
        Me.LBL_TOTAL = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(32, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "CODIGO"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(187, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "PRODUCTO"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(354, 45)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "PRECIO"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(514, 45)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "CANTIDAD"
        '
        'TXT_CODIGO
        '
        Me.TXT_CODIGO.Location = New System.Drawing.Point(87, 42)
        Me.TXT_CODIGO.Name = "TXT_CODIGO"
        Me.TXT_CODIGO.Size = New System.Drawing.Size(87, 20)
        Me.TXT_CODIGO.TabIndex = 4
        Me.TXT_CODIGO.Text = "1"
        '
        'TXT_PRODUCTO
        '
        Me.TXT_PRODUCTO.Location = New System.Drawing.Point(261, 42)
        Me.TXT_PRODUCTO.Name = "TXT_PRODUCTO"
        Me.TXT_PRODUCTO.Size = New System.Drawing.Size(87, 20)
        Me.TXT_PRODUCTO.TabIndex = 5
        '
        'TXT_PRECIO
        '
        Me.TXT_PRECIO.Location = New System.Drawing.Point(407, 42)
        Me.TXT_PRECIO.Name = "TXT_PRECIO"
        Me.TXT_PRECIO.Size = New System.Drawing.Size(87, 20)
        Me.TXT_PRECIO.TabIndex = 6
        Me.TXT_PRECIO.Text = "1"
        '
        'TXT_CANTIDAD
        '
        Me.TXT_CANTIDAD.Location = New System.Drawing.Point(577, 42)
        Me.TXT_CANTIDAD.Name = "TXT_CANTIDAD"
        Me.TXT_CANTIDAD.Size = New System.Drawing.Size(87, 20)
        Me.TXT_CANTIDAD.TabIndex = 7
        Me.TXT_CANTIDAD.Text = "1"
        '
        'BTN_AGREGA
        '
        Me.BTN_AGREGA.Location = New System.Drawing.Point(681, 42)
        Me.BTN_AGREGA.Name = "BTN_AGREGA"
        Me.BTN_AGREGA.Size = New System.Drawing.Size(68, 58)
        Me.BTN_AGREGA.TabIndex = 8
        Me.BTN_AGREGA.Text = "AGREGAR"
        Me.BTN_AGREGA.UseVisualStyleBackColor = True
        '
        'BTN_NUEVO
        '
        Me.BTN_NUEVO.Location = New System.Drawing.Point(35, 363)
        Me.BTN_NUEVO.Name = "BTN_NUEVO"
        Me.BTN_NUEVO.Size = New System.Drawing.Size(68, 58)
        Me.BTN_NUEVO.TabIndex = 9
        Me.BTN_NUEVO.Text = "NUEVO"
        Me.BTN_NUEVO.UseVisualStyleBackColor = True
        '
        'BTN_ELIMINA
        '
        Me.BTN_ELIMINA.Location = New System.Drawing.Point(126, 363)
        Me.BTN_ELIMINA.Name = "BTN_ELIMINA"
        Me.BTN_ELIMINA.Size = New System.Drawing.Size(68, 58)
        Me.BTN_ELIMINA.TabIndex = 10
        Me.BTN_ELIMINA.Text = "ELIMINA"
        Me.BTN_ELIMINA.UseVisualStyleBackColor = True
        '
        'BTN_REDONDEAR
        '
        Me.BTN_REDONDEAR.Location = New System.Drawing.Point(225, 363)
        Me.BTN_REDONDEAR.Name = "BTN_REDONDEAR"
        Me.BTN_REDONDEAR.Size = New System.Drawing.Size(83, 58)
        Me.BTN_REDONDEAR.TabIndex = 11
        Me.BTN_REDONDEAR.Text = "REDONDEO"
        Me.BTN_REDONDEAR.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(597, 355)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(67, 13)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "SUBTOTAL:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(597, 380)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(47, 13)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "IVA 22%"
        '
        'lbl_sus
        '
        Me.lbl_sus.AutoSize = True
        Me.lbl_sus.Location = New System.Drawing.Point(597, 408)
        Me.lbl_sus.Name = "lbl_sus"
        Me.lbl_sus.Size = New System.Drawing.Size(70, 13)
        Me.lbl_sus.TabIndex = 14
        Me.lbl_sus.Text = "SUBTOTAL1"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(597, 431)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(69, 13)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "REDONDEO"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(597, 453)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(42, 13)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "TOTAL"
        '
        'ListView1
        '
        Me.ListView1.CheckBoxes = True
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.CODIGO, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6})
        Me.ListView1.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.ListView1.FullRowSelect = True
        Me.ListView1.GridLines = True
        Me.ListView1.HideSelection = False
        Me.ListView1.Location = New System.Drawing.Point(35, 113)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(629, 208)
        Me.ListView1.TabIndex = 17
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'CODIGO
        '
        Me.CODIGO.Text = "CODIGO"
        Me.CODIGO.Width = 88
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "NOMBRE"
        Me.ColumnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader2.Width = 106
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "PRECIO"
        Me.ColumnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader3.Width = 107
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "CANTIDAD"
        Me.ColumnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader4.Width = 103
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "DESCUENTO"
        Me.ColumnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader5.Width = 119
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "IMPORTE"
        Me.ColumnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader6.Width = 102
        '
        'LBL_SUBTOTAL
        '
        Me.LBL_SUBTOTAL.AutoSize = True
        Me.LBL_SUBTOTAL.Location = New System.Drawing.Point(690, 355)
        Me.LBL_SUBTOTAL.Name = "LBL_SUBTOTAL"
        Me.LBL_SUBTOTAL.Size = New System.Drawing.Size(13, 13)
        Me.LBL_SUBTOTAL.TabIndex = 18
        Me.LBL_SUBTOTAL.Text = "0"
        '
        'LBL_IVA
        '
        Me.LBL_IVA.AutoSize = True
        Me.LBL_IVA.Location = New System.Drawing.Point(690, 380)
        Me.LBL_IVA.Name = "LBL_IVA"
        Me.LBL_IVA.Size = New System.Drawing.Size(13, 13)
        Me.LBL_IVA.TabIndex = 19
        Me.LBL_IVA.Text = "0"
        '
        'LBL_SUBTOTAL2
        '
        Me.LBL_SUBTOTAL2.AutoSize = True
        Me.LBL_SUBTOTAL2.Location = New System.Drawing.Point(690, 408)
        Me.LBL_SUBTOTAL2.Name = "LBL_SUBTOTAL2"
        Me.LBL_SUBTOTAL2.Size = New System.Drawing.Size(13, 13)
        Me.LBL_SUBTOTAL2.TabIndex = 20
        Me.LBL_SUBTOTAL2.Text = "0"
        '
        'LBL_REDONDEO
        '
        Me.LBL_REDONDEO.AutoSize = True
        Me.LBL_REDONDEO.Location = New System.Drawing.Point(690, 431)
        Me.LBL_REDONDEO.Name = "LBL_REDONDEO"
        Me.LBL_REDONDEO.Size = New System.Drawing.Size(13, 13)
        Me.LBL_REDONDEO.TabIndex = 21
        Me.LBL_REDONDEO.Text = "0"
        '
        'LBL_TOTAL
        '
        Me.LBL_TOTAL.AutoSize = True
        Me.LBL_TOTAL.Location = New System.Drawing.Point(690, 453)
        Me.LBL_TOTAL.Name = "LBL_TOTAL"
        Me.LBL_TOTAL.Size = New System.Drawing.Size(13, 13)
        Me.LBL_TOTAL.TabIndex = 22
        Me.LBL_TOTAL.Text = "0"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(357, 363)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(82, 58)
        Me.Button1.TabIndex = 23
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'FACTURAS_BOLETAS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 560)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.LBL_TOTAL)
        Me.Controls.Add(Me.LBL_REDONDEO)
        Me.Controls.Add(Me.LBL_SUBTOTAL2)
        Me.Controls.Add(Me.LBL_IVA)
        Me.Controls.Add(Me.LBL_SUBTOTAL)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.lbl_sus)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.BTN_REDONDEAR)
        Me.Controls.Add(Me.BTN_ELIMINA)
        Me.Controls.Add(Me.BTN_NUEVO)
        Me.Controls.Add(Me.BTN_AGREGA)
        Me.Controls.Add(Me.TXT_CANTIDAD)
        Me.Controls.Add(Me.TXT_PRECIO)
        Me.Controls.Add(Me.TXT_PRODUCTO)
        Me.Controls.Add(Me.TXT_CODIGO)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FACTURAS_BOLETAS"
        Me.Text = "FACTURAS_BOLETAS"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TXT_CODIGO As TextBox
    Friend WithEvents TXT_PRODUCTO As TextBox
    Friend WithEvents TXT_PRECIO As TextBox
    Friend WithEvents TXT_CANTIDAD As TextBox
    Friend WithEvents BTN_AGREGA As Button
    Friend WithEvents BTN_NUEVO As Button
    Friend WithEvents BTN_ELIMINA As Button
    Friend WithEvents BTN_REDONDEAR As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents lbl_sus As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents ListView1 As Windows.Forms.ListView
    Friend WithEvents CODIGO As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents ColumnHeader6 As ColumnHeader
    Friend WithEvents LBL_SUBTOTAL As Label
    Friend WithEvents LBL_IVA As Label
    Friend WithEvents LBL_SUBTOTAL2 As Label
    Friend WithEvents LBL_REDONDEO As Label
    Friend WithEvents LBL_TOTAL As Label
    Friend WithEvents Button1 As Button
End Class
