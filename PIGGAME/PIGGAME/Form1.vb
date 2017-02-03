Public Class Form1
    Dim Parcial As Integer = 0
    Private Sub btnTirar_Click(sender As Object, e As EventArgs) Handles btnTirar.Click
        Dim dado As Integer = Random()
        txtDado.Text = dado
        Parcial += dado
        txtPuntajeParcial.Text = Parcial
        If dado = 1 Then
            Parcial = 0
            txtPuntajeParcial.Text = 0
            txtDado.Text = ""
        End If
    End Sub

    Function Random()
        Dim valor As Integer = Int((20 * Rnd()) + 1)
        Return valor
    End Function
End Class
