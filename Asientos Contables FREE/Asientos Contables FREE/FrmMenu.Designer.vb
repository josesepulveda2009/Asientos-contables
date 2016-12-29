<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmMenu
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMenu))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ArchivoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PUCToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.usuarios = New System.Windows.Forms.ToolStripMenuItem()
        Me.salir = New System.Windows.Forms.ToolStripMenuItem()
        Me.VerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.transacciones = New System.Windows.Forms.ToolStripMenuItem()
        Me.BalanceGeneral = New System.Windows.Forms.ToolStripMenuItem()
        Me.PartidaDoble = New System.Windows.Forms.ToolStripMenuItem()
        Me.Mantenimiento = New System.Windows.Forms.ToolStripMenuItem()
        Me.LimpiarDatos = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.tslUsuario = New System.Windows.Forms.ToolStripStatusLabel()
        Me.MenuStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArchivoToolStripMenuItem, Me.VerToolStripMenuItem, Me.Mantenimiento})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(967, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ArchivoToolStripMenuItem
        '
        Me.ArchivoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PUCToolStripMenuItem, Me.usuarios, Me.salir})
        Me.ArchivoToolStripMenuItem.Name = "ArchivoToolStripMenuItem"
        Me.ArchivoToolStripMenuItem.Size = New System.Drawing.Size(60, 20)
        Me.ArchivoToolStripMenuItem.Text = "Archivo"
        '
        'PUCToolStripMenuItem
        '
        Me.PUCToolStripMenuItem.Name = "PUCToolStripMenuItem"
        Me.PUCToolStripMenuItem.Size = New System.Drawing.Size(119, 22)
        Me.PUCToolStripMenuItem.Text = "PUC"
        '
        'usuarios
        '
        Me.usuarios.Enabled = False
        Me.usuarios.Name = "usuarios"
        Me.usuarios.Size = New System.Drawing.Size(119, 22)
        Me.usuarios.Text = "Usuarios"
        '
        'salir
        '
        Me.salir.Name = "salir"
        Me.salir.Size = New System.Drawing.Size(119, 22)
        Me.salir.Text = "Salir"
        '
        'VerToolStripMenuItem
        '
        Me.VerToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.transacciones, Me.PartidaDoble, Me.BalanceGeneral})
        Me.VerToolStripMenuItem.Name = "VerToolStripMenuItem"
        Me.VerToolStripMenuItem.Size = New System.Drawing.Size(35, 20)
        Me.VerToolStripMenuItem.Text = "Ver"
        '
        'transacciones
        '
        Me.transacciones.Name = "transacciones"
        Me.transacciones.Size = New System.Drawing.Size(171, 22)
        Me.transacciones.Text = "Transacciones"
        '
        'BalanceGeneral
        '
        Me.BalanceGeneral.Name = "BalanceGeneral"
        Me.BalanceGeneral.Size = New System.Drawing.Size(171, 22)
        Me.BalanceGeneral.Text = "Balance de prueba"
        '
        'PartidaDoble
        '
        Me.PartidaDoble.Name = "PartidaDoble"
        Me.PartidaDoble.Size = New System.Drawing.Size(171, 22)
        Me.PartidaDoble.Text = "Partida Doble"
        '
        'Mantenimiento
        '
        Me.Mantenimiento.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LimpiarDatos})
        Me.Mantenimiento.Name = "Mantenimiento"
        Me.Mantenimiento.Size = New System.Drawing.Size(101, 20)
        Me.Mantenimiento.Text = "Mantenimiento"
        '
        'LimpiarDatos
        '
        Me.LimpiarDatos.Name = "LimpiarDatos"
        Me.LimpiarDatos.Size = New System.Drawing.Size(147, 22)
        Me.LimpiarDatos.Text = "Limpiar Datos"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tslUsuario})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 443)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(967, 22)
        Me.StatusStrip1.TabIndex = 1
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'tslUsuario
        '
        Me.tslUsuario.Name = "tslUsuario"
        Me.tslUsuario.Size = New System.Drawing.Size(47, 17)
        Me.tslUsuario.Text = "Usuario"
        '
        'FrmMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(967, 465)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "FrmMenu"
        Me.Text = "MENU PRINCIPAL"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ArchivoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents salir As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents transacciones As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BalanceGeneral As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents usuarios As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Mantenimiento As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents tslUsuario As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents LimpiarDatos As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PartidaDoble As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PUCToolStripMenuItem As ToolStripMenuItem
End Class
