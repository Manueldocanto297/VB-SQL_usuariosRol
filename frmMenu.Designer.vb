﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMenu
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
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.grdUsuarios = New System.Windows.Forms.DataGridView()
        Me.btnActivar = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnCambPass = New System.Windows.Forms.Button()
        Me.btnDesactivar = New System.Windows.Forms.Button()
        Me.btnCambNom = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        CType(Me.grdUsuarios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(217, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(148, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Listado de usuarios:"
        '
        'grdUsuarios
        '
        Me.grdUsuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.grdUsuarios.BackgroundColor = System.Drawing.Color.Silver
        Me.grdUsuarios.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle13.BackColor = System.Drawing.Color.DimGray
        DataGridViewCellStyle13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grdUsuarios.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle13
        Me.grdUsuarios.ColumnHeadersHeight = 25
        Me.grdUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle14.BackColor = System.Drawing.Color.Silver
        DataGridViewCellStyle14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.grdUsuarios.DefaultCellStyle = DataGridViewCellStyle14
        Me.grdUsuarios.GridColor = System.Drawing.Color.Black
        Me.grdUsuarios.Location = New System.Drawing.Point(44, 60)
        Me.grdUsuarios.MultiSelect = False
        Me.grdUsuarios.Name = "grdUsuarios"
        Me.grdUsuarios.ReadOnly = True
        Me.grdUsuarios.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle15.BackColor = System.Drawing.Color.Gray
        DataGridViewCellStyle15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.Firebrick
        DataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grdUsuarios.RowHeadersDefaultCellStyle = DataGridViewCellStyle15
        Me.grdUsuarios.RowHeadersVisible = False
        Me.grdUsuarios.RowHeadersWidth = 21
        DataGridViewCellStyle16.BackColor = System.Drawing.Color.Silver
        DataGridViewCellStyle16.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.Firebrick
        DataGridViewCellStyle16.SelectionForeColor = System.Drawing.Color.White
        Me.grdUsuarios.RowsDefaultCellStyle = DataGridViewCellStyle16
        Me.grdUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grdUsuarios.Size = New System.Drawing.Size(492, 283)
        Me.grdUsuarios.TabIndex = 1
        '
        'btnActivar
        '
        Me.btnActivar.Location = New System.Drawing.Point(44, 349)
        Me.btnActivar.Name = "btnActivar"
        Me.btnActivar.Size = New System.Drawing.Size(94, 23)
        Me.btnActivar.TabIndex = 2
        Me.btnActivar.Text = "Activar"
        Me.btnActivar.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.btnEliminar.Location = New System.Drawing.Point(442, 349)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(94, 23)
        Me.btnEliminar.TabIndex = 3
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'btnCambPass
        '
        Me.btnCambPass.Location = New System.Drawing.Point(342, 349)
        Me.btnCambPass.Name = "btnCambPass"
        Me.btnCambPass.Size = New System.Drawing.Size(94, 23)
        Me.btnCambPass.TabIndex = 4
        Me.btnCambPass.Text = "Cambiar Pass"
        Me.btnCambPass.UseVisualStyleBackColor = True
        '
        'btnDesactivar
        '
        Me.btnDesactivar.Location = New System.Drawing.Point(144, 349)
        Me.btnDesactivar.Name = "btnDesactivar"
        Me.btnDesactivar.Size = New System.Drawing.Size(94, 23)
        Me.btnDesactivar.TabIndex = 5
        Me.btnDesactivar.Text = "Desactivar"
        Me.btnDesactivar.UseVisualStyleBackColor = True
        '
        'btnCambNom
        '
        Me.btnCambNom.Location = New System.Drawing.Point(244, 349)
        Me.btnCambNom.Name = "btnCambNom"
        Me.btnCambNom.Size = New System.Drawing.Size(94, 23)
        Me.btnCambNom.TabIndex = 6
        Me.btnCambNom.Text = "Cambiar Nom"
        Me.btnCambNom.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(244, 378)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(94, 23)
        Me.btnSalir.TabIndex = 7
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'frmMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.ClientSize = New System.Drawing.Size(585, 411)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnCambNom)
        Me.Controls.Add(Me.btnDesactivar)
        Me.Controls.Add(Me.btnCambPass)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnActivar)
        Me.Controls.Add(Me.grdUsuarios)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmMenu"
        Me.Text = "Menú Principal"
        CType(Me.grdUsuarios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents grdUsuarios As DataGridView
    Friend WithEvents btnActivar As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnCambPass As Button
    Friend WithEvents btnDesactivar As Button
    Friend WithEvents btnCambNom As Button
    Friend WithEvents btnSalir As Button
End Class
