﻿Public Class Form1
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
            txtJugador.Text = Jugador
            txtPuntajeParcial.Text = 0
            txtDado.Text = ""
            MessageBox.Show("SACO 1 , TURNO DE LA MAQUINA", "My Application", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            CPU()
        End If
    End Sub
    Private Sub btnParar_Click(sender As Object, e As EventArgs) Handles btnParar.Click
        Jugador += Parcial
        txtJugador.Text = Jugador
        If Jugador >= 100 Then
            MessageBox.Show("FELICIDADES GANASTE !!", "My Application", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            End
        End If
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
        While veces >= cont
            Parcial += dado
            txtPuntajeParcial.Text = Parcial
            Maquina += Parcial
            txtMaquina.Text = Maquina
            If dado = 1 Then
                MessageBox.Show("TURNO DEL JUGADOR , MAQUINA SACO 1", "My Application", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                Maquina -= Parcial
                txtPuntajeParcial.Text = Parcial
                txtMaquina.Text = Maquina
                dado = 0
                txtDado.Text = dado
                Exit While
            End If

            If Maquina >= 100 Then
                MessageBox.Show(" JUGADOR PERDIO !!", "My Application", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                End
            End If
            dado = Random()
            cont = Random()
        End While
        MessageBox.Show("TURNO DEL JUGADOR", "My Application", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        veces = 0
    End Sub
End Class

