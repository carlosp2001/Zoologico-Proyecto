Public Class FormPrincipal
    Private Sub btnHabitat_Click(sender As Object, e As EventArgs) Handles btnHabitat.Click
        FormHabitat.Show()

    End Sub

    Private Sub btnRecorrido_Click(sender As Object, e As EventArgs) Handles btnRecorrido.Click
        FormRecorrido.Show()
    End Sub

    Private Sub btnEspecie_Click(sender As Object, e As EventArgs) Handles btnEspecie.Click
        FormEspecie.Show()
    End Sub
End Class