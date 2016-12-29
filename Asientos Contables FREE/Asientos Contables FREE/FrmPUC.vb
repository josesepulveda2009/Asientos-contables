Imports System.Data
Imports System.Data.OleDb

Public Class FrmPUC
    Dim conexion As OleDbConnection
    Dim adaptador As OleDbDataAdapter
    Dim datos As DataSet
    Dim bmb As BindingManagerBase

    Private Sub FrmPUC_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexion = New OleDbConnection(Base.conectar())
        adaptador = New OleDbDataAdapter("SELECT codigo, denominacion, id FROM CUENTA ORDER BY codigo", conexion)
        datos = New DataSet()

        Dim insertar As New OleDbCommand("INSERT INTO CUENTA(codigo, denominacion) VALUES(@codigo, @denominacion)", conexion)
        adaptador.InsertCommand = insertar
        adaptador.InsertCommand.Parameters.Add(New OleDbParameter("@codigo", OleDbType.VarChar))
        adaptador.InsertCommand.Parameters.Add(New OleDbParameter("@denominacion", OleDbType.VarChar))

        Dim actualizar As New OleDbCommand("UPDATE CUENTA SET codigo=@codigo, denominacion=@denominacion WHERE id=@id", conexion)
        adaptador.UpdateCommand = actualizar
        adaptador.UpdateCommand.Parameters.Add(New OleDbParameter("@codigo", OleDbType.VarChar))
        adaptador.UpdateCommand.Parameters.Add(New OleDbParameter("@denominacion", OleDbType.VarChar))
        adaptador.UpdateCommand.Parameters.Add(New OleDbParameter("@id", OleDbType.VarChar))

        Dim eliminar = New OleDbCommand("DELETE * FROM CUENTA WHERE id=@id", conexion)
        adaptador.DeleteCommand = eliminar
        'adaptador.DeleteCommand.Parameters.Add(New OleDbParameter("@codigo", OleDbType.VarChar))
        'adaptador.DeleteCommand.Parameters.Add(New OleDbParameter("@denominacion", OleDbType.VarChar))
        adaptador.DeleteCommand.Parameters.Add(New OleDbParameter("@id", OleDbType.VarChar))

        conexion.Open()
        adaptador.Fill(datos, "CUENTA")
        conexion.Close()

        dgvCuenta.DataSource = datos.Tables("CUENTA")
        dgvCuenta.Columns("id").Visible = False

        txtCodigo.DataBindings.Add(New Binding("Text", datos.Tables("CUENTA"), "codigo"))
        txtDenominacion.DataBindings.Add(New Binding("Text", datos.Tables("CUENTA"), "denominacion"))

        bmb = BindingContext(datos.Tables("CUENTA"))

        Call registro()
    End Sub

    Private Sub registro()
        txtRegistro.Text = "Registro " & (bmb.Position + 1) & " de " & datos.Tables(0).Rows.Count
    End Sub

    Private Sub btnPri_Click(sender As Object, e As EventArgs) Handles btnPri.Click
        bmb.Position = 0
        Call registro()
    End Sub

    Private Sub btnAnt_Click(sender As Object, e As EventArgs) Handles btnAnt.Click
        bmb.Position -= 1
        Call registro()
    End Sub

    Private Sub btnSig_Click(sender As Object, e As EventArgs) Handles btnSig.Click
        bmb.Position += 1
        Call registro()
    End Sub

    Private Sub btnUlt_Click(sender As Object, e As EventArgs) Handles btnUlt.Click
        bmb.Position = datos.Tables("CUENTA").Rows.Count
        Call registro()
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        txtCodigo.Clear()
        txtDenominacion.Clear()
        txtCodigo.Focus()

        btnNuevo.Enabled = False
        btnInsertar.Enabled = True
    End Sub

    Private Sub btnInsertar_Click(sender As Object, e As EventArgs) Handles btnInsertar.Click
        If txtCodigo.Text = "" Or txtDenominacion.Text = "" Then
            MessageBox.Show("Llene todos los campos ", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            Try
                adaptador.InsertCommand.Parameters("@codigo").Value = txtCodigo.Text
                adaptador.InsertCommand.Parameters("@denominacion").Value = txtDenominacion.Text

                conexion.Open()
                Dim i As Integer = adaptador.InsertCommand.ExecuteNonQuery()
                conexion.Close()

                MessageBox.Show(i & " Registros añadidos", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)

                datos.Clear()
                adaptador.Fill(datos, "CUENTA")
                dgvCuenta.Refresh()

                btnInsertar.Enabled = False
                btnNuevo.Enabled = True
            Catch ex As Exception
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End Try
        End If
    End Sub

    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        If txtCodigo.Text = "" Or txtDenominacion.Text = "" Then
            MessageBox.Show("Llene todos los campos ", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            Try
                adaptador.UpdateCommand.Parameters("@codigo").Value = txtCodigo.Text
                adaptador.UpdateCommand.Parameters("@denominacion").Value = txtDenominacion.Text
                adaptador.UpdateCommand.Parameters("@id").Value = dgvCuenta.CurrentRow.Cells("id").Value

                conexion.Open()
                Dim i As Integer = adaptador.UpdateCommand.ExecuteNonQuery()
                conexion.Close()

                MessageBox.Show(i & " Registros actualizados", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)

                datos.Clear()
                adaptador.Fill(datos, "CUENTA")
                dgvCuenta.Refresh()

            Catch ex As Exception
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End Try
        End If
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If MessageBox.Show("Desea eliminar este registro", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Try
                'adaptador.DeleteCommand.Parameters("@codigo").Value = txtCodigo.Text
                'adaptador.DeleteCommand.Parameters("@denominacion").Value = txtDenominacion.Text
                adaptador.DeleteCommand.Parameters("@id").Value = dgvCuenta.CurrentRow.Cells("id").Value

                conexion.Open()
                Dim i As Integer = adaptador.DeleteCommand.ExecuteNonQuery()
                conexion.Close()

                MessageBox.Show(i & " Registros eliminados", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)

                datos.Clear()
                adaptador.Fill(datos, "CUENTA")
                dgvCuenta.Refresh()

            Catch ex As Exception
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End Try
        End If
    End Sub

    Private Sub btnExportar_Click(sender As Object, e As EventArgs) Handles btnExportar.Click
        Dim xp As New ExportarExcel()
        xp.ExportarExcel(dgvCuenta)
    End Sub
End Class