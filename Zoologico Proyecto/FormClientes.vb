Imports System.Data.SqlClient

Public Class FormClientes
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        conectar.Open()
        Dim insertar As String = "insert into clientes(nombre, apellido, telefono) values (@nombre,@apellido,@telefono)"
        Dim ejinsertar As New SqlCommand(insertar, conectar)
        ejinsertar.Parameters.AddWithValue("@nombre", txtnombre.Text)
        ejinsertar.Parameters.AddWithValue("@apellido", txtapellido.Text)
        ejinsertar.Parameters.AddWithValue("@telefono", txtTelefono.Text)

        ejinsertar.ExecuteNonQuery()
        conectar.Close()
        LlenarTabla("clientes", dgvclientes)
    End Sub

    Private Sub FormClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LlenarTabla("clientes", dgvclientes)
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        conectar.Open()
        Dim actualizar As String = "update clientes set nombre=@nombre,apellido=@apellido,telefono=@telefono where codcliente=@codigo"
        Dim ejactualizar As New SqlCommand(actualizar, conectar)
        ejactualizar.Parameters.AddWithValue("@codigo", Val(txtcodigo.Text))
        ejactualizar.Parameters.AddWithValue("@nombre", txtnombre.Text)
        ejactualizar.Parameters.AddWithValue("@apellido", txtapellido.Text)
        ejactualizar.Parameters.AddWithValue("@telefono", txtTelefono.Text)
        ejactualizar.ExecuteNonQuery()
        conectar.Close()
        LlenarTabla("clientes", dgvclientes)
    End Sub


    Private Sub dgvclientes_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvclientes.CellDoubleClick
        txtcodigo.Text = dgvclientes.CurrentRow.Cells(0).Value
        txtnombre.Text = dgvclientes.CurrentRow.Cells(1).Value
        txtapellido.Text = dgvclientes.CurrentRow.Cells(2).Value
        txtTelefono.Text = dgvclientes.CurrentRow.Cells(3).Value
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        conectar.Open()
        Dim eliminar As String = "delete from clientes where codcliente=@codigo"
        Dim ejeliminar As New SqlCommand(eliminar, conectar)
        ejeliminar.Parameters.AddWithValue("@codigo", txtcodigo.Text)
        ejeliminar.ExecuteNonQuery()
        conectar.Close()
        LlenarTabla("clientes", dgvclientes)
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        conectar.Open()
        Dim mostrar As String = "select * from clientes where codcliente=@codigo"
        Dim mostrar1 As New SqlCommand(mostrar, conectar)
        mostrar1.Parameters.AddWithValue("@codigo", txtcodigo.Text)
        Dim recuperar As New DataTable
        Using adcliente As New SqlDataAdapter(mostrar1)
            adcliente.Fill(recuperar)
        End Using
        dgvclientes.DataSource = recuperar
        conectar.Close()
    End Sub
End Class