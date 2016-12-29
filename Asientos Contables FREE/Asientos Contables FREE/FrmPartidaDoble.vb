Imports System.Data
Imports System.Data.OleDb

Public Class FrmPartidaDoble

    Private conexion As OleDbConnection
    Private adaptador As OleDbDataAdapter
    Private datos As DataSet

    Private sql As String = "SELECT transaccion, SUM(debito) AS total_debito, SUM(credito) AS total_credito, (total_debito-total_credito) AS diferencia FROM TRANSACCION GROUP BY transaccion ORDER BY transaccion;"

    Private Sub FrmPartidaDoble_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        conexion = New OleDbConnection(Base.conectar)
        adaptador = New OleDbDataAdapter(sql, conexion)
        datos = New DataSet()

        conexion.Open()
        adaptador.Fill(datos)
        conexion.Close()

        dgvPartidaDoble.DataSource = datos.Tables(0)

    End Sub

    Private Sub btnExportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportar.Click
        Dim xp As New ExportarExcel()
        xp.ExportarExcel(dgvPartidaDoble)
    End Sub
End Class