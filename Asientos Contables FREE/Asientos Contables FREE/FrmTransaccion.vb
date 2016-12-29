Imports System.Data
Imports System.Data.OleDb

Public Class FrmTransaccion

    Private conexion As OleDbConnection
    Private adaptador As OleDbDataAdapter
    Private constructor As OleDbCommandBuilder
    Private datos As DataSet
    Private bmb As BindingManagerBase

    Private sql As String = "SELECT fecha, transaccion, cuenta, denominacion, debito, credito, usuario, T.id FROM CUENTA AS C, TRANSACCION AS T WHERE C.codigo = T.cuenta ORDER BY T.id"

    Private Sub FrmTransaccion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        rbtDebito.Checked = False
        rbtCredito.Checked = False

        conexion = New OleDbConnection(Base.conectar())
        adaptador = New OleDbDataAdapter(sql, conexion)
        constructor = New OleDbCommandBuilder(adaptador)
        datos = New DataSet()

        Dim insertar As New OleDbCommand("INSERT INTO TRANSACCION(transaccion, fecha, cuenta, debito, credito, usuario) VALUES(@transaccion, @fecha, @cuenta, @debito, @credito, @usuario)", conexion)
        adaptador.InsertCommand = insertar
        adaptador.InsertCommand.Parameters.Add(New OleDbParameter("@transaccion", OleDbType.VarChar))
        adaptador.InsertCommand.Parameters.Add(New OleDbParameter("@fecha", OleDbType.VarChar))
        adaptador.InsertCommand.Parameters.Add(New OleDbParameter("@cuenta", OleDbType.VarChar))
        adaptador.InsertCommand.Parameters.Add(New OleDbParameter("@debito", OleDbType.VarChar))
        adaptador.InsertCommand.Parameters.Add(New OleDbParameter("@credito", OleDbType.VarChar))
        adaptador.InsertCommand.Parameters.Add(New OleDbParameter("@usuario", OleDbType.VarChar))

        Dim eliminar As New OleDbCommand("DELETE * FROM TRANSACCION WHERE id=@id", conexion)
        adaptador.DeleteCommand = eliminar
        adaptador.DeleteCommand.Parameters.Add(New OleDbParameter("@id", OleDbType.Integer))
        adaptador.DeleteCommand.Parameters.Add(New OleDbParameter("@transaccion", OleDbType.VarChar))
        adaptador.DeleteCommand.Parameters.Add(New OleDbParameter("@fecha", OleDbType.VarChar))
        adaptador.DeleteCommand.Parameters.Add(New OleDbParameter("@cuenta", OleDbType.VarChar))
        adaptador.DeleteCommand.Parameters.Add(New OleDbParameter("@debito", OleDbType.VarChar))
        adaptador.DeleteCommand.Parameters.Add(New OleDbParameter("@credito", OleDbType.VarChar))
        adaptador.DeleteCommand.Parameters.Add(New OleDbParameter("@usuario", OleDbType.VarChar))

        conexion.Open()
        adaptador.Fill(datos)
        conexion.Close()

        txtId.DataBindings.Add(New Binding("Text", datos.Tables(0), "id"))
        txtTransaccion.DataBindings.Add(New Binding("Text", datos.Tables(0), "transaccion"))
        dtpFecha.DataBindings.Add(New Binding("Text", datos.Tables(0), "fecha"))

        txtCuenta.DataBindings.Add(New Binding("Text", datos.Tables(0), "cuenta"))
        txtDenominacion.DataBindings.Add(New Binding("Text", datos.Tables(0), "denominacion"))

        txtDebito.DataBindings.Add(New Binding("Text", datos.Tables(0), "debito"))

        txtCredito.DataBindings.Add(New Binding("Text", datos.Tables(0), "credito"))
        txtUsuario.DataBindings.Add(New Binding("Text", datos.Tables(0), "usuario"))


        dgvTransaccion.DataSource = datos.Tables(0)
        dgvTransaccion.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvTransaccion.Columns("id").Visible = False
        dgvTransaccion.Columns("usuario").Visible = False

        bmb = BindingContext(datos.Tables(0))
        Call registro()

    End Sub

    Private Sub registro()
        txtRegistro.Text = "Registro " & (bmb.Position + 1) & " de " & datos.Tables(0).Rows.Count
    End Sub

    Private Sub btnPri_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPri.Click
        bmb.Position = 0
        Call registro()
    End Sub

    Private Sub btnAnt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAnt.Click
        bmb.Position -= 1
        Call registro()
    End Sub

    Private Sub btnSig_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSig.Click
        bmb.Position += 1
        Call registro()
    End Sub

    Private Sub btnUlt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUlt.Click
        bmb.Position = datos.Tables(0).Rows.Count
        Call registro()
    End Sub

    Private Sub btnCuenta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCuenta.Click
        FrmCuenta.Show()
    End Sub

    Private Sub rbtDebito_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtDebito.CheckedChanged
        If txtValor.Text <> "" Then
            txtDebito.Text = txtValor.Text
            txtCredito.Text = 0
        End If
    End Sub

    Private Sub rbtCredito_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtCredito.CheckedChanged
        If txtValor.Text <> "" Then
            txtCredito.Text = txtValor.Text
            txtDebito.Text = 0
        End If
    End Sub

    Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click

        For Each txt As Control In Me.Controls
            If TypeOf txt Is TextBox Then
                txt.Text = ""
            End If
        Next
        dtpFecha.Text = DateTime.Now.ToString()
        txtUsuario.Text = FrmMenu.tslUsuario.Text
        btnNuevo.Enabled = False
        btnInsertar.Enabled = True
        txtTransaccion.Focus()
        Call Me.registro()

    End Sub

    Private Sub btnInsertar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInsertar.Click

        If txtTransaccion.Text = "" Or txtCuenta.Text = "" Or txtDebito.Text = "" Or txtCredito.Text = "" Then
            MessageBox.Show("Llene todos los campos ", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            Try
                adaptador.InsertCommand.Parameters("@transaccion").Value = txtTransaccion.Text
                adaptador.InsertCommand.Parameters("@fecha").Value = dtpFecha.Text
                adaptador.InsertCommand.Parameters("@cuenta").Value = txtCuenta.Text
                adaptador.InsertCommand.Parameters("@debito").Value = txtDebito.Text
                adaptador.InsertCommand.Parameters("@credito").Value = txtCredito.Text
                adaptador.InsertCommand.Parameters("@usuario").Value = txtUsuario.Text

                conexion.Open()
                Dim i As Integer = adaptador.InsertCommand.ExecuteNonQuery()
                conexion.Close()

                MessageBox.Show(i & " Registros añadidos", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)


                datos.Clear()
                adaptador.Fill(datos)
                dgvTransaccion.Refresh()

                btnInsertar.Enabled = False
                btnNuevo.Enabled = True
            Catch ex As Exception
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End Try
        End If

    End Sub

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click

        If MessageBox.Show("Desea eliminar este registro", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            If txtTransaccion.Text = "" Or txtCuenta.Text = "" Or txtDebito.Text = "" Or txtCredito.Text = "" Then
                MessageBox.Show("Llene todos los campos ", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                Try
                    adaptador.DeleteCommand.Parameters("@id").Value = txtId.Text
                    adaptador.DeleteCommand.Parameters("@transaccion").Value = txtTransaccion.Text
                    adaptador.DeleteCommand.Parameters("@fecha").Value = dtpFecha.Text
                    adaptador.DeleteCommand.Parameters("@cuenta").Value = txtCuenta.Text
                    adaptador.DeleteCommand.Parameters("@debito").Value = txtDebito.Text
                    adaptador.DeleteCommand.Parameters("@credito").Value = txtCredito.Text
                    adaptador.DeleteCommand.Parameters("@usuario").Value = txtUsuario.Text

                    conexion.Open()
                    Dim i As Integer = adaptador.DeleteCommand.ExecuteNonQuery()
                    conexion.Close()

                    MessageBox.Show(i & " Registros eliminados", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Catch ex As Exception
                    MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End Try
            End If
            datos.Clear()
            adaptador.Fill(datos)
            dgvTransaccion.Refresh()
        End If

    End Sub

    Private Sub txtCriterio_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCriterio.TextChanged

        Dim tabla As DataTable

        If cboCriterio.Text = "Transaccion" Then
            Dim sql As String = "SELECT fecha, transaccion, cuenta, denominacion, debito, credito, usuario, id FROM CUENTA AS C, TRANSACCION AS T WHERE C.codigo = T.cuenta AND transaccion LIKE '%" + txtCriterio.Text + "%' ORDER BY transaccion"
            adaptador = New OleDbDataAdapter(sql, conexion)
            tabla = New DataTable()

            conexion.Open()
            adaptador.Fill(tabla)
            conexion.Close()

            dgvTransaccion.DataSource = tabla

        ElseIf cboCriterio.Text = "Fecha" Then

            Dim sql As String = "SELECT fecha, transaccion, cuenta, denominacion, debito, credito, usuario, id FROM CUENTA AS C, TRANSACCION AS T WHERE C.codigo = T.cuenta AND fecha LIKE '%" + txtCriterio.Text + "%' ORDER BY fecha"
            adaptador = New OleDbDataAdapter(sql, conexion)
            tabla = New DataTable()

            conexion.Open()
            adaptador.Fill(tabla)
            conexion.Close()

            dgvTransaccion.DataSource = tabla

        ElseIf cboCriterio.Text = "Cuenta" Then
            Dim sql As String = "SELECT fecha, transaccion, cuenta, denominacion, debito, credito, usuario, id FROM CUENTA AS C, TRANSACCION AS T WHERE C.codigo = T.cuenta AND fecha LIKE '%" + txtCriterio.Text + "%' ORDER BY cuenta"
            adaptador = New OleDbDataAdapter(sql, conexion)
            tabla = New DataTable()

            conexion.Open()
            adaptador.Fill(tabla)
            conexion.Close()

            dgvTransaccion.DataSource = tabla
        End If

    End Sub

    Private Sub btnExportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportar.Click
        Dim xp As New ExportarExcel()
        xp.ExportarExcel(dgvTransaccion)
    End Sub
End Class