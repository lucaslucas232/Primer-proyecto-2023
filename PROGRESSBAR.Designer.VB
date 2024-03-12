<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PROGRESSBAR
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
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.BTN_COMINZA = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.StatusBar1 = New System.Windows.Forms.StatusBar()
        Me.SuspendLayout()
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(88, 93)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(223, 49)
        Me.ProgressBar1.TabIndex = 0
        '
        'Timer1
        '
        Me.Timer1.Interval = 200
        '
        'BTN_COMINZA
        '
        Me.BTN_COMINZA.Location = New System.Drawing.Point(401, 116)
        Me.BTN_COMINZA.Name = "BTN_COMINZA"
        Me.BTN_COMINZA.Size = New System.Drawing.Size(172, 26)
        Me.BTN_COMINZA.TabIndex = 2
        Me.BTN_COMINZA.Text = "COMIENZA"
        Me.BTN_COMINZA.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(85, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Label1"
        '
        'StatusBar1
        '
        Me.StatusBar1.Location = New System.Drawing.Point(0, 397)
        Me.StatusBar1.Name = "StatusBar1"
        Me.StatusBar1.Size = New System.Drawing.Size(800, 53)
        Me.StatusBar1.TabIndex = 9
        Me.StatusBar1.Text = "StatusBar1"
        '
        'PROGRESSBAR
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.StatusBar1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BTN_COMINZA)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Name = "PROGRESSBAR"
        Me.Text = "PROGRESSBAR"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ProgressBar1 As Windows.Forms.ProgressBar
    Friend WithEvents Timer1 As Windows.Forms.Timer
    Friend WithEvents BTN_COMINZA As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents StatusBar1 As StatusBar
End Class
