Public Class Form1
    Dim Parcial As Integer = 0
    Dim Jugador As Integer = 0
    Dim Maquina As Integer = 0
    Dim dado As Integer = 0
    Dim veces As Integer = 0
    Dim cont As Integer = 0
    Private Sub btnTirar_Click(sender As Object, e As EventArgs) Handles btnTirar.Click
        dado = Random()
        txtDado.Text = dado
        Parcial += dado
        txtPuntajeParcial.Text = Parcial
        veces += 1
        txtVeces.Text = veces
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
    Private Sub btnParar_Click(sender As Object, e As EventArgs) Handles btnParar.Click
        Jugador += Parcial
        txtJugador.Text = Jugador
        MessageBox.Show("TURNO DE LA MAQUINA", "My Application", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        CPU()
    End Sub
    Function Random()
        Randomize()
        Dim valor As Integer = CInt((6 * Rnd()) + 1)
        Return valor
    End Function

    Sub CPU()
        Parcial = 0
        txtPuntajeParcial.Text = Parcial
        dado = Random()
        txtDado.Text = dado
        If dado = 1 Then
            MessageBox.Show("TURNO DEL JUGADOR , MAQUINA SACO 1", "My Application", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            Parcial = 0
            txtPuntajeParcial.Text = Parcial
            Maquina = 0
            txtMaquina.Text = Maquina
        End If
        While veces >= cont
            Parcial += dado
            txtPuntajeParcial.Text = Parcial
            Maquina += Parcial
            txtMaquina.Text = Maquina
            dado = Random()
            cont += 1
        End While
        MessageBox.Show("TURNO DEL JUGADOR", "My Application", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        veces = 0



    End Sub

End Class
