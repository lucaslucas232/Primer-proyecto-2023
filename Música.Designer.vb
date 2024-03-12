<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Música
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Música))
        Me.btn_elige = New System.Windows.Forms.Button()
        Me.btn_stop = New System.Windows.Forms.Button()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.AxWindowsMediaPlayer1 = New AxWMPLib.AxWindowsMediaPlayer()
        CType(Me.AxWindowsMediaPlayer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_elige
        '
        Me.btn_elige.Location = New System.Drawing.Point(75, 291)
        Me.btn_elige.Name = "btn_elige"
        Me.btn_elige.Size = New System.Drawing.Size(145, 36)
        Me.btn_elige.TabIndex = 0
        Me.btn_elige.Text = "ELIGE"
        Me.btn_elige.UseVisualStyleBackColor = True
        '
        'btn_stop
        '
        Me.btn_stop.Location = New System.Drawing.Point(330, 291)
        Me.btn_stop.Name = "btn_stop"
        Me.btn_stop.Size = New System.Drawing.Size(145, 36)
        Me.btn_stop.TabIndex = 1
        Me.btn_stop.Text = "STOP"
        Me.btn_stop.UseVisualStyleBackColor = True
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(541, 73)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(179, 251)
        Me.ListBox1.TabIndex = 2
        '
        'AxWindowsMediaPlayer1
        '
        Me.AxWindowsMediaPlayer1.Enabled = True
        Me.AxWindowsMediaPlayer1.Location = New System.Drawing.Point(75, 73)
        Me.AxWindowsMediaPlayer1.Name = "AxWindowsMediaPlayer1"
        Me.AxWindowsMediaPlayer1.OcxState = CType(resources.GetObject("AxWindowsMediaPlayer1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxWindowsMediaPlayer1.Size = New System.Drawing.Size(420, 196)
        Me.AxWindowsMediaPlayer1.TabIndex = 3
        '
        'Música
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.AxWindowsMediaPlayer1)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.btn_stop)
        Me.Controls.Add(Me.btn_elige)
        Me.Name = "Música"
        Me.Text = "Música"
        CType(Me.AxWindowsMediaPlayer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btn_elige As Button
    Friend WithEvents btn_stop As Button
    Friend WithEvents ListBox1 As Windows.Forms.ListBox
    Friend WithEvents AxWindowsMediaPlayer1 As AxWMPLib.AxWindowsMediaPlayer
End Class
