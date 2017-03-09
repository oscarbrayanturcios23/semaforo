Public Class Form1
    Dim semaforo As Integer

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        semaforo = 0
        Timer1.Enabled = True
        Timer1.Interval = 1000
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        semaforo = semaforo + 1

        If semaforo = 5 Then
            rojo.Visible = False
            amarillo.Visible = True
            verde.Visible = True
        End If

        If semaforo = 1 Then
            rojo.Visible = True
            amarillo.Visible = False
            verde.Visible = True
        End If

        If semaforo = 6 Then
            rojo.Visible = True
            amarillo.Visible = True
            verde.Visible = False
        End If


        If semaforo = 7 Then
            semaforo = 0
        End If
    End Sub
End Class


