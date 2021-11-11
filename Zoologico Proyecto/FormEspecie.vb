Imports System.Data.SqlClient
Public Class FormEspecie
    Private Sub FormEspecie_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LlenarTabla("especie", dgvespecie)
        Dim combxstring As String = "select HabitatId,Habitat_nombre from Habitat"
        cbxHabitat.DisplayMember = "Habitat_nombre"
        cbxHabitat.ValueMember = "HabitatId"
        LlenarTComboBox(combxstring, cbxHabitat)
    End Sub

    Private Sub btnIngresar_Click(sender As Object, e As EventArgs) Handles btnIngresar.Click
        conectar.Open()
        Dim insertar As String = "insert into especie values(@especienombrec,@especienombrecienti,@especiedesc,@habitatid)"

        Dim ejinsertar As New SqlCommand(insertar, conectar)

        ejinsertar.Parameters.AddWithValue("@especienombrec", txtnombrec.Text)
        ejinsertar.Parameters.AddWithValue("@especienombrecienti", txtnombrecienti.Text)
        ejinsertar.Parameters.AddWithValue("@especiedesc", txtdescripcion.Text)
        ejinsertar.Parameters.AddWithValue("@habitatid", cbxHabitat.SelectedValue)
        ejinsertar.ExecuteNonQuery()
        conectar.Close()
        LlenarTabla("especie", dgvespecie)

    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        conectar.Open()
        Dim actulizar As String = "update especie set Especie_nombre_comun=@especienombrec,Especie_nombre_cienti=@especienombrecienti,Especie_descripcion=@especiedesc,HabitatId=@habitatid where EspecieId=@EspecieId"

        Dim Ejactualizar As New SqlCommand(actulizar, conectar)
        Ejactualizar.Parameters.AddWithValue("@EspecieId", txtespecieid.Text)
        Ejactualizar.Parameters.AddWithValue("@especienombrec", txtnombrec.Text)
        Ejactualizar.Parameters.AddWithValue("@especienombrecienti", txtnombrecienti.Text)
        Ejactualizar.Parameters.AddWithValue("@especiedesc", txtdescripcion.Text)
        Ejactualizar.Parameters.AddWithValue("@habitatid", cbxHabitat.SelectedValue)
        Ejactualizar.ExecuteNonQuery()
        conectar.Close()
        LlenarTabla("especie", dgvespecie)

    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        conectar.Open()
        Dim eliminar As String = "delete from especie where EspecieId=@EspecieId"

        Dim EjEliminar As New SqlCommand(eliminar, conectar)
        EjEliminar.Parameters.AddWithValue("@EspecieId", txtespecieid.Text)

        EjEliminar.ExecuteNonQuery()
        conectar.Close()
        LlenarTabla("especie", dgvespecie)

    End Sub



    Private Sub dgvespecie_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvespecie.CellDoubleClick
        txtespecieid.Text = dgvespecie.CurrentRow.Cells(0).Value
        txtnombrec.Text = dgvespecie.CurrentRow.Cells(1).Value
        txtnombrecienti.Text = dgvespecie.CurrentRow.Cells(2).Value
        txtdescripcion.Text = dgvespecie.CurrentRow.Cells(3).Value
        cbxHabitat.SelectedValue = dgvespecie.CurrentRow.Cells(4).Value
    End Sub
End Class