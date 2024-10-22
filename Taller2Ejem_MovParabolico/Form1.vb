Public Class Form1
    Dim randomX As Integer
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        'Coordenada aleatoria x<=1200 & x>=500 & y=621
        Randomize()
        'Distribución Uniforme (Un*(LimSup-LimInf))+LimInf
        randomX = CInt(Rnd() * (938 - 459) + 459)
        Raton.Location = New Point(randomX, 456)
        Form2.Close()
        Form2.Show()
        Form2.Size = Me.Size
        Form2.Location = Me.Location
        Timer1.Enabled = False
    End Sub


End Class
