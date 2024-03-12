<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CORREO
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
        Me.TXT_DE = New System.Windows.Forms.TextBox()
        Me.TXT_CC = New System.Windows.Forms.TextBox()
        Me.TXT_ASUNTO = New System.Windows.Forms.TextBox()
        Me.TXT_PASSWORD = New System.Windows.Forms.TextBox()
        Me.TXT_PARA = New System.Windows.Forms.TextBox()
        Me.CBO_ADJUNTOS = New System.Windows.Forms.ComboBox()
        Me.TXT_MENSAJE = New System.Windows.Forms.TextBox()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.BTN_ENVIAR = New System.Windows.Forms.Button()
        Me.BTN_CANCELA = New System.Windows.Forms.Button()
        Me.BTN_FIN = New System.Windows.Forms.Button()
        Me.BTN_ADJUNTOS = New System.Windows.Forms.Button()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.HelpProvider1 = New System.Windows.Forms.HelpProvider()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TXT_DE
        '
        Me.TXT_DE.Location = New System.Drawing.Point(141, 69)
        Me.TXT_DE.Name = "TXT_DE"
        Me.TXT_DE.Size = New System.Drawing.Size(199, 20)
        Me.TXT_DE.TabIndex = 0
        '
        'TXT_CC
        '
        Me.TXT_CC.Location = New System.Drawing.Point(452, 118)
        Me.TXT_CC.Name = "TXT_CC"
        Me.TXT_CC.Size = New System.Drawing.Size(199, 20)
        Me.TXT_CC.TabIndex = 1
        '
        'TXT_ASUNTO
        '
        Me.TXT_ASUNTO.Location = New System.Drawing.Point(141, 164)
        Me.TXT_ASUNTO.Name = "TXT_ASUNTO"
        Me.TXT_ASUNTO.Size = New System.Drawing.Size(199, 20)
        Me.TXT_ASUNTO.TabIndex = 2
        '
        'TXT_PASSWORD
        '
        Me.TXT_PASSWORD.Location = New System.Drawing.Point(452, 69)
        Me.TXT_PASSWORD.Name = "TXT_PASSWORD"
        Me.TXT_PASSWORD.PasswordChar = Global.Microsoft.VisualBasic.ChrW(64)
        Me.TXT_PASSWORD.Size = New System.Drawing.Size(199, 20)
        Me.TXT_PASSWORD.TabIndex = 3
        '
        'TXT_PARA
        '
        Me.TXT_PARA.Location = New System.Drawing.Point(141, 118)
        Me.TXT_PARA.Name = "TXT_PARA"
        Me.TXT_PARA.Size = New System.Drawing.Size(199, 20)
        Me.TXT_PARA.TabIndex = 5
        '
        'CBO_ADJUNTOS
        '
        Me.CBO_ADJUNTOS.FormattingEnabled = True
        Me.CBO_ADJUNTOS.Location = New System.Drawing.Point(141, 208)
        Me.CBO_ADJUNTOS.Name = "CBO_ADJUNTOS"
        Me.CBO_ADJUNTOS.Size = New System.Drawing.Size(247, 21)
        Me.CBO_ADJUNTOS.TabIndex = 6
        '
        'TXT_MENSAJE
        '
        Me.TXT_MENSAJE.Location = New System.Drawing.Point(137, 269)
        Me.TXT_MENSAJE.Name = "TXT_MENSAJE"
        Me.TXT_MENSAJE.Size = New System.Drawing.Size(498, 20)
        Me.TXT_MENSAJE.TabIndex = 7
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(68, 374)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(271, 30)
        Me.ProgressBar1.TabIndex = 8
        '
        'BTN_ENVIAR
        '
        Me.BTN_ENVIAR.Location = New System.Drawing.Point(379, 374)
        Me.BTN_ENVIAR.Name = "BTN_ENVIAR"
        Me.BTN_ENVIAR.Size = New System.Drawing.Size(91, 30)
        Me.BTN_ENVIAR.TabIndex = 9
        Me.BTN_ENVIAR.Text = "ENVIAR"
        Me.BTN_ENVIAR.UseVisualStyleBackColor = True
        '
        'BTN_CANCELA
        '
        Me.BTN_CANCELA.Location = New System.Drawing.Point(512, 374)
        Me.BTN_CANCELA.Name = "BTN_CANCELA"
        Me.BTN_CANCELA.Size = New System.Drawing.Size(91, 30)
        Me.BTN_CANCELA.TabIndex = 10
        Me.BTN_CANCELA.Text = "CANCELA"
        Me.BTN_CANCELA.UseVisualStyleBackColor = True
        '
        'BTN_FIN
        '
        Me.BTN_FIN.Location = New System.Drawing.Point(638, 374)
        Me.BTN_FIN.Name = "BTN_FIN"
        Me.BTN_FIN.Size = New System.Drawing.Size(91, 30)
        Me.BTN_FIN.TabIndex = 11
        Me.BTN_FIN.Text = "FIN"
        Me.BTN_FIN.UseVisualStyleBackColor = True
        '
        'BTN_ADJUNTOS
        '
        Me.BTN_ADJUNTOS.Location = New System.Drawing.Point(560, 190)
        Me.BTN_ADJUNTOS.Name = "BTN_ADJUNTOS"
        Me.BTN_ADJUNTOS.Size = New System.Drawing.Size(91, 54)
        Me.BTN_ADJUNTOS.TabIndex = 12
        Me.BTN_ADJUNTOS.Text = "AGREGAR ADJUNTOS"
        Me.BTN_ADJUNTOS.UseVisualStyleBackColor = True
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(65, 71)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(25, 13)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "DE:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(65, 125)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "PARA:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(65, 171)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 13)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "ASUNTO:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(65, 216)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 13)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "ADJUNTOS:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(65, 269)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(57, 13)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "MENSAJE"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(397, 72)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(35, 13)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "PASS"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(408, 121)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(24, 13)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "CC:"
        '
        'CORREO
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BTN_ADJUNTOS)
        Me.Controls.Add(Me.BTN_FIN)
        Me.Controls.Add(Me.BTN_CANCELA)
        Me.Controls.Add(Me.BTN_ENVIAR)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.TXT_MENSAJE)
        Me.Controls.Add(Me.CBO_ADJUNTOS)
        Me.Controls.Add(Me.TXT_PARA)
        Me.Controls.Add(Me.TXT_PASSWORD)
        Me.Controls.Add(Me.TXT_ASUNTO)
        Me.Controls.Add(Me.TXT_CC)
        Me.Controls.Add(Me.TXT_DE)
        Me.Name = "CORREO"
        Me.Text = "CORREO"
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TXT_DE As TextBox
    Friend WithEvents TXT_CC As TextBox
    Friend WithEvents TXT_ASUNTO As TextBox
    Friend WithEvents TXT_PASSWORD As TextBox
    Friend WithEvents TXT_PARA As TextBox
    Friend WithEvents CBO_ADJUNTOS As ComboBox
    Friend WithEvents TXT_MENSAJE As TextBox
    Friend WithEvents ProgressBar1 As Windows.Forms.ProgressBar
    Friend WithEvents BTN_ENVIAR As Button
    Friend WithEvents BTN_CANCELA As Button
    Friend WithEvents BTN_FIN As Button
    Friend WithEvents BTN_ADJUNTOS As Button
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents HelpProvider1 As HelpProvider
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
