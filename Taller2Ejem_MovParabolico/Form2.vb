Public Class Form2
    Dim posInicialXPuntero, posIniciaYPuntero As Integer
    Dim coordenadaInicialXTejo, coordenadaInicialYTejo As Integer
    Dim v0x, v0y, X, Y, t, x0, y0, g, vx, vy As Double
    Dim deltaCooX, deltaCooY As Integer
    Dim contador As Integer = 0


    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        coordenadaInicialXTejo = PBTejo.Location.X
        coordenadaInicialYTejo = PBTejo.Location.Y
        g = 9.81
        t = 0
        Suelo.Location = Form1.Suelo.Location
        Suelo.Size = Form1.Suelo.Size
        Torre.Location = Form1.Torre.Location
        Torre.Size = Form1.Torre.Size
        Raton.Location = Form1.Raton.Location
        Raton.Size = Form1.Raton.Size

        Form3.Show()
        Form3.WindowState = FormWindowState.Minimized
        Timer2.Enabled = True

    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        'TablaVariables.Rows.Clear()
        'TablaVariables.Rows.Add("posInicialXPuntero", posInicialXPuntero)
        'TablaVariables.Rows.Add("posIniciaYPuntero", posIniciaYPuntero)
        'TablaVariables.Rows.Add("coordenadaInicialXTejo", coordenadaInicialXTejo)
        'TablaVariables.Rows.Add("coordenadaInicialYTejo", coordenadaInicialYTejo)
        'TablaVariables.Rows.Add("x0", x0)
        'TablaVariables.Rows.Add("y0", y0)
        'TablaVariables.Rows.Add("v0x", v0x)
        'TablaVariables.Rows.Add("v0y", v0y)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form1.Close()
        'Form3.Close()
        Form1.Show()
    End Sub

    Private Sub PBTejo_MouseDown(sender As Object, e As MouseEventArgs) Handles PBTejo.MouseDown
        If e.Button = MouseButtons.Left Then
            posInicialXPuntero = e.X
            posIniciaYPuntero = e.Y
        End If
    End Sub
    Private Sub PBTejo_MouseMove(sender As Object, e As MouseEventArgs) Handles PBTejo.MouseMove
        Dim nuevaCooX, nuevaCooY As Integer
        If e.Button = MouseButtons.Left Then
            nuevaCooX = PBTejo.Location.X + e.X - posInicialXPuntero
            nuevaCooY = PBTejo.Location.Y + e.Y - posIniciaYPuntero
            PBTejo.Location = New Point(nuevaCooX, nuevaCooY)
            deltaCooX = coordenadaInicialXTejo - PBTejo.Location.X
            deltaCooY = PBTejo.Location.Y - coordenadaInicialYTejo
        End If
    End Sub
    Private Sub PBTejo_MouseUp(sender As Object, e As MouseEventArgs) Handles PBTejo.MouseUp
        If e.Button = MouseButtons.Left Then
            x0 = deltaCooX * -1
            y0 = deltaCooY * -1
            v0x = deltaCooX
            v0y = deltaCooY
            Timer2.Enabled = False
            Timer1.Enabled = True
        End If
    End Sub


    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        contador += 1
        Y = -0.5 * t ^ 2 * g + v0y * t + y0
        X = v0x * t + x0
        vx = v0x
        vy = -g * t + v0y
        PBTejo.Location = New Point(X + coordenadaInicialXTejo,
        coordenadaInicialYTejo - Y)

        Form3.DataGridView1.Rows.Add(contador, Math.Round(t, 1), Math.Round(X, 2), Math.Round(Y, 2),
                                    "(" & Math.Round(X, 2) & "," & Math.Round(Y, 2) & ")",
                                    Math.Round(vx, 2), Math.Round(vy, 2))
        Form3.Chart1.Series(0).Points.AddXY(t, Y)
        Form3.Chart1.Series(1).Points.AddXY(t, vy)
        Form3.Chart2.Series(0).Points.AddXY(t, X)
        Form3.Chart2.Series(1).Points.AddXY(t, vx)
        Form3.Chart3.Series(0).Points.AddXY(X, Y)
        t += 0.1
        If PBTejo.Bounds.IntersectsWith(Suelo.Bounds) Then
            MensajeLabel.Text = "Pendejo, le dió al suelo"
            Timer1.Enabled = False
        End If
        If PBTejo.Bounds.IntersectsWith(Torre.Bounds) Then
            MensajeLabel.Text = "Sonso, le dió a la torre"
            Timer1.Enabled = False
        End If
        If PBTejo.Bounds.IntersectsWith(Raton.Bounds) Then
            MensajeLabel.Text = "Mecha!!!!!"
            Explosion.Location = Raton.Location
            PBTejo.Visible = False
            Explosion.Visible = True
            Timer1.Enabled = False
        End If
    End Sub
End Class