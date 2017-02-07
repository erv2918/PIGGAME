Public Class Form1
    Dim Parcial As Integer = 0
    Dim Jugador As Integer = 0
    Dim Maquina As Integer = 0
    Dim dado As Integer = 0
    Private Sub btnTirar_Click(sender As Object, e As EventArgs) Handles btnTirar.Click
        dado = Random()
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
        While dado <> 1
            txtDado.Text = dado
            Parcial += dado
            txtPuntajeParcial.Text = Parcial
            Maquina += Parcial
            txtMaquina.Text = Maquina
            dado = Random()
        End While



    End Sub
End Class
