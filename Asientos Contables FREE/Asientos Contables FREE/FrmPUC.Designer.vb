<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPUC
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.btnInsertar = New System.Windows.Forms.Button()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.txtDenominacion = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtRegistro = New System.Windows.Forms.TextBox()
        Me.btnUlt = New System.Windows.Forms.Button()
        Me.btnSig = New System.Windows.Forms.Button()
        Me.btnAnt = New System.Windows.Forms.Button()
        Me.btnPri = New System.Windows.Forms.Button()
        Me.btnActualizar = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.dgvCuenta = New System.Windows.Forms.DataGridView()
        Me.btnExportar = New System.Windows.Forms.Button()
        CType(Me.dgvCuenta, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnNuevo
        '
        Me.btnNuevo.Location = New System.Drawing.Point(19, 433)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(75, 23)
        Me.btnNuevo.TabIndex = 1
        Me.btnNuevo.Text = "&Nuevo"
        Me.btnNuevo.UseVisualStyleBackColor = True
        '
        'btnInsertar
        '
        Me.btnInsertar.Location = New System.Drawing.Point(100, 433)
        Me.btnInsertar.Name = "btnInsertar"
        Me.btnInsertar.Size = New System.Drawing.Size(75, 23)
        Me.btnInsertar.TabIndex = 2
        Me.btnInsertar.Text = "&Insertar"
        Me.btnInsertar.UseVisualStyleBackColor = True
        '
        'txtCodigo
        '
        Me.txtCodigo.Location = New System.Drawing.Point(93, 21)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(100, 20)
        Me.txtCodigo.TabIndex = 4
        '
        'txtDenominacion
        '
        Me.txtDenominacion.Location = New System.Drawing.Point(93, 47)
        Me.txtDenominacion.Name = "txtDenominacion"
        Me.txtDenominacion.Size = New System.Drawing.Size(382, 20)
        Me.txtDenominacion.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Codigo"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Denominacion"
        '
        'txtRegistro
        '
        Me.txtRegistro.Location = New System.Drawing.Point(100, 465)
        Me.txtRegistro.Name = "txtRegistro"
        Me.txtRegistro.Size = New System.Drawing.Size(157, 20)
        Me.txtRegistro.TabIndex = 28
        '
        'btnUlt
        '
        Me.btnUlt.Location = New System.Drawing.Point(303, 464)
        Me.btnUlt.Name = "btnUlt"
        Me.btnUlt.Size = New System.Drawing.Size(34, 23)
        Me.btnUlt.TabIndex = 27
        Me.btnUlt.Text = ">|"
        Me.btnUlt.UseVisualStyleBackColor = True
        '
        'btnSig
        '
        Me.btnSig.Location = New System.Drawing.Point(263, 463)
        Me.btnSig.Name = "btnSig"
        Me.btnSig.Size = New System.Drawing.Size(34, 23)
        Me.btnSig.TabIndex = 26
        Me.btnSig.Text = ">>"
        Me.btnSig.UseVisualStyleBackColor = True
        '
        'btnAnt
        '
        Me.btnAnt.Location = New System.Drawing.Point(59, 465)
        Me.btnAnt.Name = "btnAnt"
        Me.btnAnt.Size = New System.Drawing.Size(34, 23)
        Me.btnAnt.TabIndex = 25
        Me.btnAnt.Text = "<<"
        Me.btnAnt.UseVisualStyleBackColor = True
        '
        'btnPri
        '
        Me.btnPri.Location = New System.Drawing.Point(19, 465)
        Me.btnPri.Name = "btnPri"
        Me.btnPri.Size = New System.Drawing.Size(34, 23)
        Me.btnPri.TabIndex = 24
        Me.btnPri.Text = "|<"
        Me.btnPri.UseVisualStyleBackColor = True
        '
        'btnActualizar
        '
        Me.btnActualizar.Location = New System.Drawing.Point(181, 433)
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Size = New System.Drawing.Size(75, 23)
        Me.btnActualizar.TabIndex = 29
        Me.btnActualizar.Text = "&Actualizar"
        Me.btnActualizar.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.btnEliminar.Location = New System.Drawing.Point(262, 433)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(75, 23)
        Me.btnEliminar.TabIndex = 30
        Me.btnEliminar.Text = "&Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'dgvCuenta
        '
        Me.dgvCuenta.AllowUserToAddRows = False
        Me.dgvCuenta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.dgvCuenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCuenta.Location = New System.Drawing.Point(19, 82)
        Me.dgvCuenta.Name = "dgvCuenta"
        Me.dgvCuenta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvCuenta.Size = New System.Drawing.Size(456, 345)
        Me.dgvCuenta.TabIndex = 31
        '
        'btnExportar
        '
        Me.btnExportar.Location = New System.Drawing.Point(400, 462)
        Me.btnExportar.Name = "btnExportar"
        Me.btnExportar.Size = New System.Drawing.Size(75, 23)
        Me.btnExportar.TabIndex = 35
        Me.btnExportar.Text = "&Exportar"
        Me.btnExportar.UseVisualStyleBackColor = True
        '
        'FrmPUC
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(493, 500)
        Me.Controls.Add(Me.btnExportar)
        Me.Controls.Add(Me.dgvCuenta)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnActualizar)
        Me.Controls.Add(Me.txtRegistro)
        Me.Controls.Add(Me.btnUlt)
        Me.Controls.Add(Me.btnSig)
        Me.Controls.Add(Me.btnAnt)
        Me.Controls.Add(Me.btnPri)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtDenominacion)
        Me.Controls.Add(Me.txtCodigo)
        Me.Controls.Add(Me.btnInsertar)
        Me.Controls.Add(Me.btnNuevo)
        Me.Name = "FrmPUC"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PLAN UNICO DE CUENTAS"
        CType(Me.dgvCuenta, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnNuevo As Button
    Friend WithEvents btnInsertar As Button
    Friend WithEvents txtCodigo As TextBox
    Friend WithEvents txtDenominacion As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtRegistro As TextBox
    Friend WithEvents btnUlt As Button
    Friend WithEvents btnSig As Button
    Friend WithEvents btnAnt As Button
    Friend WithEvents btnPri As Button
    Friend WithEvents btnActualizar As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents dgvCuenta As DataGridView
    Friend WithEvents btnExportar As Button
End Class
