<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MAPA
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
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.ListBox2 = New System.Windows.Forms.ListBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.BTN_IR = New System.Windows.Forms.Button()
        Me.BTN_FIN = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LBL_LATITUD = New System.Windows.Forms.Label()
        Me.LBL_LONGITUD = New System.Windows.Forms.Label()
        Me.GMapControl1 = New GMap.NET.WindowsForms.GMapControl()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(22, 29)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(206, 20)
        Me.TextBox1.TabIndex = 0
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(22, 75)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(206, 173)
        Me.ListBox1.TabIndex = 1
        '
        'ListBox2
        '
        Me.ListBox2.FormattingEnabled = True
        Me.ListBox2.Location = New System.Drawing.Point(245, 75)
        Me.ListBox2.Name = "ListBox2"
        Me.ListBox2.Size = New System.Drawing.Size(212, 173)
        Me.ListBox2.TabIndex = 2
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(245, 28)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(212, 21)
        Me.ComboBox1.TabIndex = 3
        '
        'BTN_IR
        '
        Me.BTN_IR.Location = New System.Drawing.Point(624, 25)
        Me.BTN_IR.Name = "BTN_IR"
        Me.BTN_IR.Size = New System.Drawing.Size(59, 34)
        Me.BTN_IR.TabIndex = 4
        Me.BTN_IR.Text = "IR"
        Me.BTN_IR.UseVisualStyleBackColor = True
        '
        'BTN_FIN
        '
        Me.BTN_FIN.Location = New System.Drawing.Point(701, 25)
        Me.BTN_FIN.Name = "BTN_FIN"
        Me.BTN_FIN.Size = New System.Drawing.Size(59, 34)
        Me.BTN_FIN.TabIndex = 5
        Me.BTN_FIN.Text = "FIN"
        Me.BTN_FIN.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(475, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "LATITUD:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(475, 79)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "LONGITUD:"
        '
        'LBL_LATITUD
        '
        Me.LBL_LATITUD.AutoSize = True
        Me.LBL_LATITUD.Location = New System.Drawing.Point(570, 36)
        Me.LBL_LATITUD.Name = "LBL_LATITUD"
        Me.LBL_LATITUD.Size = New System.Drawing.Size(13, 13)
        Me.LBL_LATITUD.TabIndex = 8
        Me.LBL_LATITUD.Text = "0"
        '
        'LBL_LONGITUD
        '
        Me.LBL_LONGITUD.AutoSize = True
        Me.LBL_LONGITUD.Location = New System.Drawing.Point(570, 79)
        Me.LBL_LONGITUD.Name = "LBL_LONGITUD"
        Me.LBL_LONGITUD.Size = New System.Drawing.Size(13, 13)
        Me.LBL_LONGITUD.TabIndex = 9
        Me.LBL_LONGITUD.Text = "0"
        '
        'GMapControl1
        '
        Me.GMapControl1.Bearing = 0!
        Me.GMapControl1.CanDragMap = True
        Me.GMapControl1.EmptyTileColor = System.Drawing.Color.Navy
        Me.GMapControl1.GrayScaleMode = False
        Me.GMapControl1.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow
        Me.GMapControl1.LevelsKeepInMemmory = 5
        Me.GMapControl1.Location = New System.Drawing.Point(478, 172)
        Me.GMapControl1.MarkersEnabled = True
        Me.GMapControl1.MaxZoom = 2
        Me.GMapControl1.MinZoom = 2
        Me.GMapControl1.MouseWheelZoomEnabled = True
        Me.GMapControl1.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter
        Me.GMapControl1.Name = "GMapControl1"
        Me.GMapControl1.NegativeMode = False
        Me.GMapControl1.PolygonsEnabled = True
        Me.GMapControl1.RetryLoadTile = 0
        Me.GMapControl1.RoutesEnabled = True
        Me.GMapControl1.ScaleMode = GMap.NET.WindowsForms.ScaleModes.[Integer]
        Me.GMapControl1.SelectedAreaFillColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.GMapControl1.ShowTileGridLines = False
        Me.GMapControl1.Size = New System.Drawing.Size(282, 210)
        Me.GMapControl1.TabIndex = 10
        Me.GMapControl1.Zoom = 0R
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(478, 114)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(212, 21)
        Me.ComboBox2.TabIndex = 11
        '
        'MAPA
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.GMapControl1)
        Me.Controls.Add(Me.LBL_LONGITUD)
        Me.Controls.Add(Me.LBL_LATITUD)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BTN_FIN)
        Me.Controls.Add(Me.BTN_IR)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.ListBox2)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.TextBox1)
        Me.Name = "MAPA"
        Me.Text = "MAPA"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents ListBox1 As Windows.Forms.ListBox
    Friend WithEvents ListBox2 As Windows.Forms.ListBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents BTN_IR As Button
    Friend WithEvents BTN_FIN As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents LBL_LATITUD As Label
    Friend WithEvents LBL_LONGITUD As Label
    Friend WithEvents GMapControl1 As GMap.NET.WindowsForms.GMapControl
    Friend WithEvents ComboBox2 As ComboBox
End Class
