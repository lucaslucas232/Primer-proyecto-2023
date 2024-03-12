Public Class evento_mouse_move
    Dim POSI As Byte = 2

    Dim CONTADOR As Byte = 0

    Private Sub evento_mouse_move_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Button1.Top = 10
        Button1.Left = 10

    End Sub

    Private Sub Button1_MouseMove(sender As Object, e As MouseEventArgs) Handles Button1.MouseMove
        'If Button1.Top < 15 Then
        '    Button1.Top = 80
        '    Button1.Left = 10
        'Else
        '    Button1.Top = 10
        '    Button1.Left = 10

        'End If
        CONTADOR += 1 'INCREMENTAR LA VARIABLE

        Select Case POSI
            Case 1
                Button1.Top = 10
                Button1.Left = 10
                POSI = 2 : Button1.Text = "HAGA CLICK"
            Case 2
                Button1.Top = 400
                Button1.Left = 10
                POSI = 3 : Button1.Text = "OSOO"
            Case 3
                Button1.Top = 400
                Button1.Left = 400
                POSI = 4 : Button1.Text = "OSOO"
            Case 4
                Button1.Top = 10
                Button1.Left = 400
                POSI = 5 : Button1.Text = "OSOO"
            Case 5
                Button1.Top = 200
                Button1.Left = 200
                POSI = 1 : Button1.Text = "OSOO"
        End Select

        If CONTADOR = 4 Then

        End If
        LBL_CONTADOR.Text = CONTADOR.ToString

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub
End Class