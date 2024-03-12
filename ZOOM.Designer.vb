<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ZOOM
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
        Me.BTN_ATRAS = New System.Windows.Forms.Button()
        Me.BTN_ADELANTE = New System.Windows.Forms.Button()
        Me.BTN_CERRAR = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BTN_ATRAS
        '
        Me.BTN_ATRAS.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.BTN_ATRAS.Location = New System.Drawing.Point(53, 194)
        Me.BTN_ATRAS.Name = "BTN_ATRAS"
        Me.BTN_ATRAS.Size = New System.Drawing.Size(48, 39)
        Me.BTN_ATRAS.TabIndex = 0
        Me.BTN_ATRAS.Text = "<<"
        Me.BTN_ATRAS.UseVisualStyleBackColor = True
        '
        'BTN_ADELANTE
        '
        Me.BTN_ADELANTE.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.BTN_ADELANTE.Location = New System.Drawing.Point(742, 194)
        Me.BTN_ADELANTE.Name = "BTN_ADELANTE"
        Me.BTN_ADELANTE.Size = New System.Drawing.Size(46, 43)
        Me.BTN_ADELANTE.TabIndex = 1
        Me.BTN_ADELANTE.Text = ">>"
        Me.BTN_ADELANTE.UseVisualStyleBackColor = True
        '
        'BTN_CERRAR
        '
        Me.BTN_CERRAR.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BTN_CERRAR.Location = New System.Drawing.Point(724, 406)
        Me.BTN_CERRAR.Name = "BTN_CERRAR"
        Me.BTN_CERRAR.Size = New System.Drawing.Size(63, 39)
        Me.BTN_CERRAR.TabIndex = 2
        Me.BTN_CERRAR.Text = "CERRAR"
        Me.BTN_CERRAR.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Yellow
        Me.Label1.Location = New System.Drawing.Point(50, 419)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Label1"
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.Location = New System.Drawing.Point(122, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(581, 433)
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'ZOOM
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(800, 473)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BTN_CERRAR)
        Me.Controls.Add(Me.BTN_ADELANTE)
        Me.Controls.Add(Me.BTN_ATRAS)
        Me.Name = "ZOOM"
        Me.Text = "ZOOM"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BTN_ATRAS As Button
    Friend WithEvents BTN_ADELANTE As Button
    Friend WithEvents BTN_CERRAR As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
