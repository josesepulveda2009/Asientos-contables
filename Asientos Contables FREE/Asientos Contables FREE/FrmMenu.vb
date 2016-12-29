Imports System.Data
Imports System.Data.OleDb

Public Class FrmMenu

    Private Sub transacciones_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles transacciones.Click
        FrmTransaccion.MdiParent = Me
        FrmTransaccion.Show()
        FrmTransaccion.txtUsuario.Text = tslUsuario.Text
    End Sub

    Private Sub salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles salir.Click
        If MessageBox.Show("Desea salir de la aplicacion", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Application.ExitThread()
        End If
    End Sub

    Private Sub BalanceGeneral_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BalanceGeneral.Click
        Frmbalance.MdiParent = Me
        Frmbalance.show()
    End Sub

    Private Sub PartidaDoble_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PartidaDoble.Click
        Frmbalance.MdiParent = Me
        FrmPartidaDoble.Show()
    End Sub

    Private Sub LimpiarDatos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LimpiarDatos.Click
        If MessageBox.Show("Desea eliminar todas las transacciones", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Using con As New OleDbConnection(Base.conectar)
                Dim cmd As New OleDbCommand("DELETE * FROM TRANSACCION ", con)
                'cmd.Parameters.AddWithValue("@ID", id)

                con.Open()
                Dim i As Integer = cmd.ExecuteNonQuery()
                con.Close()

                MessageBox.Show(i & " Registros eliminados")
            End Using
        End If


    End Sub


    Private Sub MenuStrip1_ItemClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub

    Private Sub PUCToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PUCToolStripMenuItem.Click
        FrmPUC.MdiParent = Me
        FrmPUC.Show()
    End Sub
End Class