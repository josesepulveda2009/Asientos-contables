Imports System.Data
Imports System.Data.OleDb

Public Class FrmCuenta

    Private conexion As OleDbConnection
    Private adaptador As OleDbDataAdapter
    Private datos As DataSet
    Private bmb As BindingManagerBase
    Private tabla As DataTable

    Private sql As String = "SELECT codigo, denominacion FROM CUENTA ORDER BY codigo;"

    Private Sub FrmCuenta_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        conexion = New OleDbConnection(Base.conectar())
        adaptador = New OleDbDataAdapter(Sql, conexion)
        datos = New DataSet()

        conexion.Open()
        adaptador.Fill(datos)
        conexion.Close()

        dgvCuenta.DataSource = datos.Tables(0)
        dgvCuenta.SelectionMode = DataGridViewSelectionMode.FullRowSelect

        bmb = BindingContext(datos.Tables(0))
    End Sub

    Private Sub txtCriterio_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCriterio.TextChanged
        If cboCriterio.Text = "Codigo" Then
            Dim sql As String = "SELECT codigo, denominacion FROM CUENTA WHERE codigo LIKE '%" + txtCriterio.Text + "%' "
            adaptador = New OleDbDataAdapter(sql, conexion)
            tabla = New DataTable()

            conexion.Open()
            adaptador.Fill(tabla)
            conexion.Close()

            dgvCuenta.DataSource = tabla

        ElseIf cboCriterio.Text = "Cuenta" Then
            Dim sql As String = "SELECT codigo, denominacion FROM CUENTA WHERE cuenta LIKE '%" + txtCriterio.Text + "%' "
            adaptador = New OleDbDataAdapter(sql, conexion)
            tabla = New DataTable()

            conexion.Open()
            adaptador.Fill(tabla)
            conexion.Close()

            dgvCuenta.DataSource = tabla
        End If

    End Sub

    Private Sub dgvCuenta_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvCuenta.CellClick
        Label2.Text = dgvCuenta.CurrentRow.Cells(0).Value.ToString()
        Label3.Text = dgvCuenta.CurrentRow.Cells(1).Value.ToString()
    End Sub

    Private Sub dgvCuenta_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgvCuenta.SelectionChanged
        Label2.Text = dgvCuenta.CurrentRow.Cells(0).Value.ToString()
        Label3.Text = dgvCuenta.CurrentRow.Cells(1).Value.ToString()
    End Sub

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        FrmTransaccion.txtCuenta.Text = Me.Label2.Text
        FrmTransaccion.txtDenominacion.Text = Me.Label3.Text
        Me.Close()
    End Sub
End Class