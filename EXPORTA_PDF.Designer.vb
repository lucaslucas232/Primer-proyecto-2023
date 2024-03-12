<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EXPORTA_PDF
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
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.DGV_ALUMNOS = New System.Windows.Forms.DataGridView()
        Me.BTN_EXPORTAR = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        CType(Me.DGV_ALUMNOS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(96, 68)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(297, 21)
        Me.ComboBox1.TabIndex = 0
        '
        'DGV_ALUMNOS
        '
        Me.DGV_ALUMNOS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_ALUMNOS.Location = New System.Drawing.Point(74, 151)
        Me.DGV_ALUMNOS.Name = "DGV_ALUMNOS"
        Me.DGV_ALUMNOS.Size = New System.Drawing.Size(369, 160)
        Me.DGV_ALUMNOS.TabIndex = 1
        '
        'BTN_EXPORTAR
        '
        Me.BTN_EXPORTAR.Location = New System.Drawing.Point(445, 57)
        Me.BTN_EXPORTAR.Name = "BTN_EXPORTAR"
        Me.BTN_EXPORTAR.Size = New System.Drawing.Size(87, 41)
        Me.BTN_EXPORTAR.TabIndex = 2
        Me.BTN_EXPORTAR.Text = "EXPORTAR"
        Me.BTN_EXPORTAR.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(599, 59)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(53, 41)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "Button2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'EXPORTA_PDF
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.BTN_EXPORTAR)
        Me.Controls.Add(Me.DGV_ALUMNOS)
        Me.Controls.Add(Me.ComboBox1)
        Me.Name = "EXPORTA_PDF"
        Me.Text = "EXPORTA_PDF"
        CType(Me.DGV_ALUMNOS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents DGV_ALUMNOS As DataGridView
    Friend WithEvents BTN_EXPORTAR As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
End Class
