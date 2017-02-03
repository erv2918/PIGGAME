Public Class Form1
    Private Sub btnTirar_Click(sender As Object, e As EventArgs) Handles btnTirar.Click
        Dim dado As Integer = Random()
        txtDado.Text = dado
    End Sub

    Function Random()
        Dim valor As Integer = Int((20 * Rnd()) + 1)
        Return valor
    End Function
End Class
