<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmTransaccion
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txtTransaccion = New System.Windows.Forms.TextBox()
        Me.txtCuenta = New System.Windows.Forms.TextBox()
        Me.txtValor = New System.Windows.Forms.TextBox()
        Me.txtDebito = New System.Windows.Forms.TextBox()
        Me.txtCredito = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.rbtDebito = New System.Windows.Forms.RadioButton()
        Me.rbtCredito = New System.Windows.Forms.RadioButton()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.btnInsertar = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnUlt = New System.Windows.Forms.Button()
        Me.btnSig = New System.Windows.Forms.Button()
        Me.btnAnt = New System.Windows.Forms.Button()
        Me.btnPri = New System.Windows.Forms.Button()
        Me.txtRegistro = New System.Windows.Forms.TextBox()
        Me.btnCuenta = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtUsuario = New System.Windows.Forms.TextBox()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.txtId = New System.Windows.Forms.TextBox()
        Me.lblId = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtCriterio = New System.Windows.Forms.TextBox()
        Me.cboCriterio = New System.Windows.Forms.ComboBox()
        Me.btnExportar = New System.Windows.Forms.Button()
        Me.dgvTransaccion = New System.Windows.Forms.DataGridView()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtDenominacion = New System.Windows.Forms.TextBox()
        CType(Me.dgvTransaccion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtTransaccion
        '
        Me.txtTransaccion.Location = New System.Drawing.Point(87, 60)
        Me.txtTransaccion.Name = "txtTransaccion"
        Me.txtTransaccion.Size = New System.Drawing.Size(120, 20)
        Me.txtTransaccion.TabIndex = 1
        '
        'txtCuenta
        '
        Me.txtCuenta.Location = New System.Drawing.Point(87, 89)
        Me.txtCuenta.Name = "txtCuenta"
        Me.txtCuenta.Size = New System.Drawing.Size(85, 20)
        Me.txtCuenta.TabIndex = 2
        '
        'txtValor
        '
        Me.txtValor.Location = New System.Drawing.Point(87, 162)
        Me.txtValor.Name = "txtValor"
        Me.txtValor.Size = New System.Drawing.Size(120, 20)
        Me.txtValor.TabIndex = 3
        '
        'txtDebito
        '
        Me.txtDebito.Enabled = False
        Me.txtDebito.Location = New System.Drawing.Point(87, 239)
        Me.txtDebito.Name = "txtDebito"
        Me.txtDebito.Size = New System.Drawing.Size(120, 20)
        Me.txtDebito.TabIndex = 4
        '
        'txtCredito
        '
        Me.txtCredito.Enabled = False
        Me.txtCredito.Location = New System.Drawing.Point(87, 265)
        Me.txtCredito.Name = "txtCredito"
        Me.txtCredito.Size = New System.Drawing.Size(120, 20)
        Me.txtCredito.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Fecha"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(21, 67)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Transaccion"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(21, 96)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Codigo"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(21, 169)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(31, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Valor"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(21, 246)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(38, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Debito"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(22, 272)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(40, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Credito"
        '
        'rbtDebito
        '
        Me.rbtDebito.AutoSize = True
        Me.rbtDebito.Checked = True
        Me.rbtDebito.Location = New System.Drawing.Point(54, 202)
        Me.rbtDebito.Name = "rbtDebito"
        Me.rbtDebito.Size = New System.Drawing.Size(56, 17)
        Me.rbtDebito.TabIndex = 12
        Me.rbtDebito.TabStop = True
        Me.rbtDebito.Text = "Debito"
        Me.rbtDebito.UseVisualStyleBackColor = True
        '
        'rbtCredito
        '
        Me.rbtCredito.AutoSize = True
        Me.rbtCredito.Location = New System.Drawing.Point(116, 202)
        Me.rbtCredito.Name = "rbtCredito"
        Me.rbtCredito.Size = New System.Drawing.Size(58, 17)
        Me.rbtCredito.TabIndex = 13
        Me.rbtCredito.Text = "Credito"
        Me.rbtCredito.UseVisualStyleBackColor = True
        '
        'btnNuevo
        '
        Me.btnNuevo.Location = New System.Drawing.Point(24, 440)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(75, 23)
        Me.btnNuevo.TabIndex = 14
        Me.btnNuevo.Text = "&Nuevo"
        Me.btnNuevo.UseVisualStyleBackColor = True
        '
        'btnInsertar
        '
        Me.btnInsertar.Enabled = False
        Me.btnInsertar.Location = New System.Drawing.Point(105, 440)
        Me.btnInsertar.Name = "btnInsertar"
        Me.btnInsertar.Size = New System.Drawing.Size(75, 23)
        Me.btnInsertar.TabIndex = 15
        Me.btnInsertar.Text = "&Insertar"
        Me.btnInsertar.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.btnEliminar.Location = New System.Drawing.Point(186, 440)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(75, 23)
        Me.btnEliminar.TabIndex = 17
        Me.btnEliminar.Text = "&Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'btnUlt
        '
        Me.btnUlt.Location = New System.Drawing.Point(308, 478)
        Me.btnUlt.Name = "btnUlt"
        Me.btnUlt.Size = New System.Drawing.Size(34, 23)
        Me.btnUlt.TabIndex = 22
        Me.btnUlt.Text = ">|"
        Me.btnUlt.UseVisualStyleBackColor = True
        '
        'btnSig
        '
        Me.btnSig.Location = New System.Drawing.Point(268, 478)
        Me.btnSig.Name = "btnSig"
        Me.btnSig.Size = New System.Drawing.Size(34, 23)
        Me.btnSig.TabIndex = 21
        Me.btnSig.Text = ">>"
        Me.btnSig.UseVisualStyleBackColor = True
        '
        'btnAnt
        '
        Me.btnAnt.Location = New System.Drawing.Point(64, 478)
        Me.btnAnt.Name = "btnAnt"
        Me.btnAnt.Size = New System.Drawing.Size(34, 23)
        Me.btnAnt.TabIndex = 20
        Me.btnAnt.Text = "<<"
        Me.btnAnt.UseVisualStyleBackColor = True
        '
        'btnPri
        '
        Me.btnPri.Location = New System.Drawing.Point(24, 478)
        Me.btnPri.Name = "btnPri"
        Me.btnPri.Size = New System.Drawing.Size(34, 23)
        Me.btnPri.TabIndex = 19
        Me.btnPri.Text = "|<"
        Me.btnPri.UseVisualStyleBackColor = True
        '
        'txtRegistro
        '
        Me.txtRegistro.Location = New System.Drawing.Point(105, 481)
        Me.txtRegistro.Name = "txtRegistro"
        Me.txtRegistro.Size = New System.Drawing.Size(157, 20)
        Me.txtRegistro.TabIndex = 23
        '
        'btnCuenta
        '
        Me.btnCuenta.Location = New System.Drawing.Point(173, 88)
        Me.btnCuenta.Name = "btnCuenta"
        Me.btnCuenta.Size = New System.Drawing.Size(34, 23)
        Me.btnCuenta.TabIndex = 24
        Me.btnCuenta.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(21, 369)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(43, 13)
        Me.Label7.TabIndex = 27
        Me.Label7.Text = "Usuario"
        '
        'txtUsuario
        '
        Me.txtUsuario.Enabled = False
        Me.txtUsuario.Location = New System.Drawing.Point(87, 362)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(120, 20)
        Me.txtUsuario.TabIndex = 26
        '
        'dtpFecha
        '
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha.Location = New System.Drawing.Point(87, 31)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(120, 20)
        Me.dtpFecha.TabIndex = 28
        '
        'txtId
        '
        Me.txtId.Enabled = False
        Me.txtId.Location = New System.Drawing.Point(87, 333)
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(85, 20)
        Me.txtId.TabIndex = 29
        '
        'lblId
        '
        Me.lblId.AutoSize = True
        Me.lblId.Location = New System.Drawing.Point(22, 340)
        Me.lblId.Name = "lblId"
        Me.lblId.Size = New System.Drawing.Size(16, 13)
        Me.lblId.TabIndex = 30
        Me.lblId.Text = "Id"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(393, 461)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(104, 13)
        Me.Label9.TabIndex = 33
        Me.Label9.Text = "Criterio de busqueda"
        '
        'txtCriterio
        '
        Me.txtCriterio.Location = New System.Drawing.Point(506, 477)
        Me.txtCriterio.Name = "txtCriterio"
        Me.txtCriterio.Size = New System.Drawing.Size(197, 20)
        Me.txtCriterio.TabIndex = 32
        '
        'cboCriterio
        '
        Me.cboCriterio.FormattingEnabled = True
        Me.cboCriterio.Items.AddRange(New Object() {"Fecha", "Transaccion", "Cuenta"})
        Me.cboCriterio.Location = New System.Drawing.Point(393, 477)
        Me.cboCriterio.Name = "cboCriterio"
        Me.cboCriterio.Size = New System.Drawing.Size(104, 21)
        Me.cboCriterio.TabIndex = 31
        '
        'btnExportar
        '
        Me.btnExportar.Location = New System.Drawing.Point(267, 440)
        Me.btnExportar.Name = "btnExportar"
        Me.btnExportar.Size = New System.Drawing.Size(75, 23)
        Me.btnExportar.TabIndex = 34
        Me.btnExportar.Text = "&Exportar"
        Me.btnExportar.UseVisualStyleBackColor = True
        '
        'dgvTransaccion
        '
        Me.dgvTransaccion.AllowUserToAddRows = False
        Me.dgvTransaccion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTransaccion.Location = New System.Drawing.Point(216, 31)
        Me.dgvTransaccion.Name = "dgvTransaccion"
        Me.dgvTransaccion.Size = New System.Drawing.Size(731, 385)
        Me.dgvTransaccion.TabIndex = 35
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(21, 122)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(41, 13)
        Me.Label8.TabIndex = 37
        Me.Label8.Text = "Cuenta"
        '
        'txtDenominacion
        '
        Me.txtDenominacion.Location = New System.Drawing.Point(87, 115)
        Me.txtDenominacion.Name = "txtDenominacion"
        Me.txtDenominacion.Size = New System.Drawing.Size(120, 20)
        Me.txtDenominacion.TabIndex = 36
        '
        'FrmTransaccion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(967, 538)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtDenominacion)
        Me.Controls.Add(Me.dgvTransaccion)
        Me.Controls.Add(Me.btnExportar)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtCriterio)
        Me.Controls.Add(Me.cboCriterio)
        Me.Controls.Add(Me.lblId)
        Me.Controls.Add(Me.txtId)
        Me.Controls.Add(Me.dtpFecha)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtUsuario)
        Me.Controls.Add(Me.btnCuenta)
        Me.Controls.Add(Me.txtRegistro)
        Me.Controls.Add(Me.btnUlt)
        Me.Controls.Add(Me.btnSig)
        Me.Controls.Add(Me.btnAnt)
        Me.Controls.Add(Me.btnPri)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnInsertar)
        Me.Controls.Add(Me.btnNuevo)
        Me.Controls.Add(Me.rbtCredito)
        Me.Controls.Add(Me.rbtDebito)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtCredito)
        Me.Controls.Add(Me.txtDebito)
        Me.Controls.Add(Me.txtValor)
        Me.Controls.Add(Me.txtCuenta)
        Me.Controls.Add(Me.txtTransaccion)
        Me.Name = "FrmTransaccion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ASIENTOS"
        CType(Me.dgvTransaccion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtTransaccion As System.Windows.Forms.TextBox
    Friend WithEvents txtCuenta As System.Windows.Forms.TextBox
    Friend WithEvents txtValor As System.Windows.Forms.TextBox
    Friend WithEvents txtDebito As System.Windows.Forms.TextBox
    Friend WithEvents txtCredito As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents rbtDebito As System.Windows.Forms.RadioButton
    Friend WithEvents rbtCredito As System.Windows.Forms.RadioButton
    Friend WithEvents btnNuevo As System.Windows.Forms.Button
    Friend WithEvents btnInsertar As System.Windows.Forms.Button
    Friend WithEvents btnEliminar As System.Windows.Forms.Button
    Friend WithEvents btnUlt As System.Windows.Forms.Button
    Friend WithEvents btnSig As System.Windows.Forms.Button
    Friend WithEvents btnAnt As System.Windows.Forms.Button
    Friend WithEvents btnPri As System.Windows.Forms.Button
    Friend WithEvents txtRegistro As System.Windows.Forms.TextBox
    Friend WithEvents btnCuenta As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtUsuario As System.Windows.Forms.TextBox
    Friend WithEvents dtpFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtId As System.Windows.Forms.TextBox
    Friend WithEvents lblId As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtCriterio As System.Windows.Forms.TextBox
    Friend WithEvents cboCriterio As System.Windows.Forms.ComboBox
    Friend WithEvents btnExportar As System.Windows.Forms.Button
    Friend WithEvents dgvTransaccion As System.Windows.Forms.DataGridView
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtDenominacion As System.Windows.Forms.TextBox
End Class
