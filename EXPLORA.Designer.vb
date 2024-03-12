<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EXPLORA
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
        Me.BTN_EXAMINAR = New System.Windows.Forms.Button()
        Me.BTN_BUSCAR = New System.Windows.Forms.Button()
        Me.BTN_FIN = New System.Windows.Forms.Button()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BTN_IZQ = New System.Windows.Forms.Button()
        Me.BTN_DEREC = New System.Windows.Forms.Button()
        Me.PIC = New System.Windows.Forms.PictureBox()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        CType(Me.PIC, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BTN_EXAMINAR
        '
        Me.BTN_EXAMINAR.Location = New System.Drawing.Point(95, 51)
        Me.BTN_EXAMINAR.Name = "BTN_EXAMINAR"
        Me.BTN_EXAMINAR.Size = New System.Drawing.Size(113, 36)
        Me.BTN_EXAMINAR.TabIndex = 0
        Me.BTN_EXAMINAR.Text = "EXAMINAR"
        Me.BTN_EXAMINAR.UseVisualStyleBackColor = True
        '
        'BTN_BUSCAR
        '
        Me.BTN_BUSCAR.Location = New System.Drawing.Point(95, 93)
        Me.BTN_BUSCAR.Name = "BTN_BUSCAR"
        Me.BTN_BUSCAR.Size = New System.Drawing.Size(113, 36)
        Me.BTN_BUSCAR.TabIndex = 1
        Me.BTN_BUSCAR.Text = "BUSCAR"
        Me.BTN_BUSCAR.UseVisualStyleBackColor = True
        '
        'BTN_FIN
        '
        Me.BTN_FIN.Location = New System.Drawing.Point(645, 353)
        Me.BTN_FIN.Name = "BTN_FIN"
        Me.BTN_FIN.Size = New System.Drawing.Size(113, 36)
        Me.BTN_FIN.TabIndex = 2
        Me.BTN_FIN.Text = "FIN"
        Me.BTN_FIN.UseVisualStyleBackColor = True
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(101, 153)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(248, 225)
        Me.ListBox1.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(252, 93)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(21, 20)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "..."
        '
        'BTN_IZQ
        '
        Me.BTN_IZQ.Location = New System.Drawing.Point(476, 93)
        Me.BTN_IZQ.Name = "BTN_IZQ"
        Me.BTN_IZQ.Size = New System.Drawing.Size(52, 36)
        Me.BTN_IZQ.TabIndex = 5
        Me.BTN_IZQ.Text = "<"
        Me.BTN_IZQ.UseVisualStyleBackColor = True
        '
        'BTN_DEREC
        '
        Me.BTN_DEREC.Location = New System.Drawing.Point(534, 93)
        Me.BTN_DEREC.Name = "BTN_DEREC"
        Me.BTN_DEREC.Size = New System.Drawing.Size(56, 36)
        Me.BTN_DEREC.TabIndex = 6
        Me.BTN_DEREC.Text = ">"
        Me.BTN_DEREC.UseVisualStyleBackColor = True
        '
        'PIC
        '
        Me.PIC.Location = New System.Drawing.Point(389, 155)
        Me.PIC.Name = "PIC"
        Me.PIC.Size = New System.Drawing.Size(224, 222)
        Me.PIC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PIC.TabIndex = 7
        Me.PIC.TabStop = False
        '
        'EXPLORA
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.PIC)
        Me.Controls.Add(Me.BTN_DEREC)
        Me.Controls.Add(Me.BTN_IZQ)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.BTN_FIN)
        Me.Controls.Add(Me.BTN_BUSCAR)
        Me.Controls.Add(Me.BTN_EXAMINAR)
        Me.Name = "EXPLORA"
        Me.Text = "EXPLORA"
        CType(Me.PIC, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BTN_EXAMINAR As Button
    Friend WithEvents BTN_BUSCAR As Button
    Friend WithEvents BTN_FIN As Button
    Friend WithEvents ListBox1 As Windows.Forms.ListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents BTN_IZQ As Button
    Friend WithEvents BTN_DEREC As Button
    Friend WithEvents PIC As PictureBox
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
End Class
