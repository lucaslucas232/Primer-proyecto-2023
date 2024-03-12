<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_actualiza_precios
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.DGV1 = New System.Windows.Forms.DataGridView()
        Me.btn_aumenta = New System.Windows.Forms.Button()
        Me.BTN_DISMINUYE = New System.Windows.Forms.Button()
        Me.BTN_IMPRIME = New System.Windows.Forms.Button()
        Me.PrintPreviewControl1 = New System.Windows.Forms.PrintPreviewControl()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGV1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(71, 53)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "CATEGORIA:"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(175, 50)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(161, 21)
        Me.ComboBox1.TabIndex = 1
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Location = New System.Drawing.Point(354, 51)
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(63, 20)
        Me.NumericUpDown1.TabIndex = 2
        '
        'DGV1
        '
        Me.DGV1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV1.Location = New System.Drawing.Point(59, 150)
        Me.DGV1.Name = "DGV1"
        Me.DGV1.Size = New System.Drawing.Size(358, 222)
        Me.DGV1.TabIndex = 3
        '
        'btn_aumenta
        '
        Me.btn_aumenta.Location = New System.Drawing.Point(456, 52)
        Me.btn_aumenta.Name = "btn_aumenta"
        Me.btn_aumenta.Size = New System.Drawing.Size(106, 25)
        Me.btn_aumenta.TabIndex = 4
        Me.btn_aumenta.Text = "AUMENTA"
        Me.btn_aumenta.UseVisualStyleBackColor = True
        '
        'BTN_DISMINUYE
        '
        Me.BTN_DISMINUYE.Location = New System.Drawing.Point(568, 52)
        Me.BTN_DISMINUYE.Name = "BTN_DISMINUYE"
        Me.BTN_DISMINUYE.Size = New System.Drawing.Size(107, 25)
        Me.BTN_DISMINUYE.TabIndex = 5
        Me.BTN_DISMINUYE.Text = "DISMINUYE"
        Me.BTN_DISMINUYE.UseVisualStyleBackColor = True
        '
        'BTN_IMPRIME
        '
        Me.BTN_IMPRIME.Location = New System.Drawing.Point(612, 347)
        Me.BTN_IMPRIME.Name = "BTN_IMPRIME"
        Me.BTN_IMPRIME.Size = New System.Drawing.Size(83, 25)
        Me.BTN_IMPRIME.TabIndex = 6
        Me.BTN_IMPRIME.Text = "IMPRIMIR"
        Me.BTN_IMPRIME.UseVisualStyleBackColor = True
        '
        'PrintPreviewControl1
        '
        Me.PrintPreviewControl1.Location = New System.Drawing.Point(487, 123)
        Me.PrintPreviewControl1.Name = "PrintPreviewControl1"
        Me.PrintPreviewControl1.Size = New System.Drawing.Size(188, 188)
        Me.PrintPreviewControl1.TabIndex = 7
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'frm_actualiza_precios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.PrintPreviewControl1)
        Me.Controls.Add(Me.BTN_IMPRIME)
        Me.Controls.Add(Me.BTN_DISMINUYE)
        Me.Controls.Add(Me.btn_aumenta)
        Me.Controls.Add(Me.DGV1)
        Me.Controls.Add(Me.NumericUpDown1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frm_actualiza_precios"
        Me.Text = "frm_actualiza_precios"
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGV1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents NumericUpDown1 As NumericUpDown
    Friend WithEvents DGV1 As DataGridView
    Friend WithEvents btn_aumenta As Button
    Friend WithEvents BTN_DISMINUYE As Button
    Friend WithEvents BTN_IMPRIME As Button
    Friend WithEvents PrintPreviewControl1 As PrintPreviewControl
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
End Class
