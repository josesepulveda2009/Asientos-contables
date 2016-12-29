
Imports System.Data
Imports System.Data.OleDb

Public Class Frmbalance

    Private conexion As OleDbConnection
    Private adaptador As OleDbDataAdapter
    Private datos As DataSet

    Private sql As String = "SELECT cuenta, SUM(debito) AS debitos, SUM(credito) AS creditos, IIf((debitos-creditos)>0,debitos-creditos) AS saldo_debito, IIf((creditos-debitos)>0,creditos-debitos) AS saldo_credito FROM TRANSACCION GROUP BY cuenta ORDER BY cuenta;"

    Private Sub Frmbalance_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        conexion = New OleDbConnection(Base.conectar)
        adaptador = New OleDbDataAdapter(sql, conexion)
        datos = New DataSet()

        conexion.Open()
        adaptador.Fill(datos)
        conexion.Close()

        dgvBalance.DataSource = datos.Tables(0)

    End Sub

    Private Sub btnExportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportar.Click
        Dim xp As New ExportarExcel()
        xp.ExportarExcel(dgvBalance)
    End Sub
End Class