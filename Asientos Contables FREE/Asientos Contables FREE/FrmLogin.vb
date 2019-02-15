Imports System.Data
Imports System.Data.OleDb

Public Class FrmLogin
    Private conexion As OleDbConnection
    Private adaptador As OleDbDataAdapter
    Private datos As DataSet
    Private comando As OleDbCommand

    Private Sub FrmLogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        conexion = New OleDbConnection(Base.conectar())

        conexion.Open()

        Dim sql As String = "SELECT COUNT(*) FROM USUARIO WHERE usuario='" + txtUsuario.Text + "' AND contraseña='" + txtContraseña.Text + "' AND tipo='" + cboCargo.Text + "' "
        comando = conexion.CreateCommand()
        comando.CommandText = sql

        Dim res As Integer
        res = comando.ExecuteScalar()

        conexion.Close()

        If res = 0 Then
            MessageBox.Show("Usuario o contraseña invalidos", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtUsuario.Clear()
            txtContraseña.Clear()
        Else
            'corregir el nivel de acceso '''''
            FrmMenu.Show()
            FrmMenu.tslUsuario.Text = txtUsuario.Text
            Me.Hide()
        End If

    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        If MessageBox.Show("Desea salir de la aplicacion", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Application.ExitThread()
        End If
    End Sub
End Class
