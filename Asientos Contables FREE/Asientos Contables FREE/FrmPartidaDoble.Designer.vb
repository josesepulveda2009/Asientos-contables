﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPartidaDoble
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
        Me.btnExportar = New System.Windows.Forms.Button()
        Me.dgvPartidaDoble = New System.Windows.Forms.DataGridView()
        CType(Me.dgvPartidaDoble, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnExportar
        '
        Me.btnExportar.Location = New System.Drawing.Point(601, 470)
        Me.btnExportar.Name = "btnExportar"
        Me.btnExportar.Size = New System.Drawing.Size(75, 23)
        Me.btnExportar.TabIndex = 3
        Me.btnExportar.Text = "&Exportar"
        Me.btnExportar.UseVisualStyleBackColor = True
        '
        'dgvPartidaDoble
        '
        Me.dgvPartidaDoble.AllowUserToAddRows = False
        Me.dgvPartidaDoble.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPartidaDoble.Location = New System.Drawing.Point(12, 12)
        Me.dgvPartidaDoble.Name = "dgvPartidaDoble"
        Me.dgvPartidaDoble.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvPartidaDoble.Size = New System.Drawing.Size(664, 452)
        Me.dgvPartidaDoble.TabIndex = 2
        '
        'FrmPartidaDoble
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(688, 504)
        Me.Controls.Add(Me.btnExportar)
        Me.Controls.Add(Me.dgvPartidaDoble)
        Me.Name = "FrmPartidaDoble"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "COMPROBACION PARTIDA DOBLE"
        CType(Me.dgvPartidaDoble, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnExportar As System.Windows.Forms.Button
    Friend WithEvents dgvPartidaDoble As System.Windows.Forms.DataGridView
End Class
