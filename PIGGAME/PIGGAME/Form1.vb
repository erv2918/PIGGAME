Public Class Form1
    Dim Parcial As Integer = 0
    Dim Jugador As Integer = 0
    Dim Maquina As Integer = 0
    Dim dado As Integer = Random()
    Private Sub btnTirar_Click(sender As Object, e As EventArgs) Handles btnTirar.Click
        txtDado.Text = dado
        Parcial += dado
        txtPuntajeParcial.Text = Parcial
        If dado = 1 Then
            Parcial = 0
            Jugador = 0
            txtJugador.Text = 0
            txtPuntajeParcial.Text = 0
            txtDado.Text = ""
            MessageBox.Show("BABOSO , TURNO DE LA MAQUINA", "My Application", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            CPU()
        End If
    End Sub

    Function Random()
        Dim valor As Integer = Int((6 * Rnd()) + 1)
        Return valor
    End Function

    Private Sub btnParar_Click(sender As Object, e As EventArgs) Handles btnParar.Click
        Jugador += Parcial
        txtJugador.Text = Jugador
        MessageBox.Show("TURNO DE LA MAQUINA", "My Application", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        CPU()
    End Sub
    Sub CPU()
        Do While dado <> 1
            txtDado.Text = dado
            Parcial += dado
            txtPuntajeParcial.Text = Parcial
        Loop
    End Sub
End Class
