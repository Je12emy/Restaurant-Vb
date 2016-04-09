<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Deposito
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
        Me.gbDeposito = New System.Windows.Forms.GroupBox()
        Me.dgvDepositos = New System.Windows.Forms.DataGridView()
        Me.ID_CTR = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ID_TIPO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DESCRIPCION = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CANTIDAD = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cbMtipo = New System.Windows.Forms.ComboBox()
        Me.lblID_Plato = New System.Windows.Forms.Label()
        Me.lblDescripcion = New System.Windows.Forms.Label()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.txtCantidad = New System.Windows.Forms.TextBox()
        Me.lblCantidad = New System.Windows.Forms.Label()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.gbDeposito.SuspendLayout()
        CType(Me.dgvDepositos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gbDeposito
        '
        Me.gbDeposito.Controls.Add(Me.btnEliminar)
        Me.gbDeposito.Controls.Add(Me.btnModificar)
        Me.gbDeposito.Controls.Add(Me.btnAgregar)
        Me.gbDeposito.Controls.Add(Me.txtCantidad)
        Me.gbDeposito.Controls.Add(Me.lblCantidad)
        Me.gbDeposito.Controls.Add(Me.txtDescripcion)
        Me.gbDeposito.Controls.Add(Me.lblDescripcion)
        Me.gbDeposito.Controls.Add(Me.cbMtipo)
        Me.gbDeposito.Controls.Add(Me.lblID_Plato)
        Me.gbDeposito.Controls.Add(Me.dgvDepositos)
        Me.gbDeposito.Location = New System.Drawing.Point(12, 12)
        Me.gbDeposito.Name = "gbDeposito"
        Me.gbDeposito.Size = New System.Drawing.Size(420, 271)
        Me.gbDeposito.TabIndex = 0
        Me.gbDeposito.TabStop = False
        Me.gbDeposito.Text = "Depositos"
        '
        'dgvDepositos
        '
        Me.dgvDepositos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDepositos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID_CTR, Me.ID_TIPO, Me.DESCRIPCION, Me.CANTIDAD})
        Me.dgvDepositos.Location = New System.Drawing.Point(6, 19)
        Me.dgvDepositos.Name = "dgvDepositos"
        Me.dgvDepositos.Size = New System.Drawing.Size(297, 150)
        Me.dgvDepositos.TabIndex = 0
        '
        'ID_CTR
        '
        Me.ID_CTR.HeaderText = "ID_CTR"
        Me.ID_CTR.Name = "ID_CTR"
        Me.ID_CTR.Visible = False
        '
        'ID_TIPO
        '
        Me.ID_TIPO.HeaderText = "ID_TIPO"
        Me.ID_TIPO.Name = "ID_TIPO"
        Me.ID_TIPO.Width = 65
        '
        'DESCRIPCION
        '
        Me.DESCRIPCION.HeaderText = "DESCRIPCION"
        Me.DESCRIPCION.Name = "DESCRIPCION"
        Me.DESCRIPCION.Width = 120
        '
        'CANTIDAD
        '
        Me.CANTIDAD.HeaderText = "CANTIDAD"
        Me.CANTIDAD.Name = "CANTIDAD"
        Me.CANTIDAD.Width = 65
        '
        'cbMtipo
        '
        Me.cbMtipo.FormattingEnabled = True
        Me.cbMtipo.Items.AddRange(New Object() {"BEB", "PTS", "ELD", "CAR", "PAS"})
        Me.cbMtipo.Location = New System.Drawing.Point(17, 200)
        Me.cbMtipo.Name = "cbMtipo"
        Me.cbMtipo.Size = New System.Drawing.Size(47, 21)
        Me.cbMtipo.TabIndex = 20
        '
        'lblID_Plato
        '
        Me.lblID_Plato.AutoSize = True
        Me.lblID_Plato.Location = New System.Drawing.Point(14, 182)
        Me.lblID_Plato.Name = "lblID_Plato"
        Me.lblID_Plato.Size = New System.Drawing.Size(49, 13)
        Me.lblID_Plato.TabIndex = 19
        Me.lblID_Plato.Text = "ID_TIPO"
        '
        'lblDescripcion
        '
        Me.lblDescripcion.AutoSize = True
        Me.lblDescripcion.Location = New System.Drawing.Point(67, 183)
        Me.lblDescripcion.Name = "lblDescripcion"
        Me.lblDescripcion.Size = New System.Drawing.Size(63, 13)
        Me.lblDescripcion.TabIndex = 21
        Me.lblDescripcion.Text = "Descripcion"
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Location = New System.Drawing.Point(70, 200)
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(125, 20)
        Me.txtDescripcion.TabIndex = 22
        '
        'txtCantidad
        '
        Me.txtCantidad.Location = New System.Drawing.Point(201, 201)
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Size = New System.Drawing.Size(65, 20)
        Me.txtCantidad.TabIndex = 24
        '
        'lblCantidad
        '
        Me.lblCantidad.AutoSize = True
        Me.lblCantidad.Location = New System.Drawing.Point(198, 185)
        Me.lblCantidad.Name = "lblCantidad"
        Me.lblCantidad.Size = New System.Drawing.Size(49, 13)
        Me.lblCantidad.TabIndex = 23
        Me.lblCantidad.Text = "Cantidad"
        '
        'btnEliminar
        '
        Me.btnEliminar.Location = New System.Drawing.Point(179, 226)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(75, 23)
        Me.btnEliminar.TabIndex = 30
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'btnModificar
        '
        Me.btnModificar.Location = New System.Drawing.Point(98, 226)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(75, 23)
        Me.btnModificar.TabIndex = 29
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'btnAgregar
        '
        Me.btnAgregar.Location = New System.Drawing.Point(17, 226)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(75, 23)
        Me.btnAgregar.TabIndex = 28
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'Deposito
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(657, 386)
        Me.Controls.Add(Me.gbDeposito)
        Me.Name = "Deposito"
        Me.Text = "Deposito"
        Me.gbDeposito.ResumeLayout(False)
        Me.gbDeposito.PerformLayout()
        CType(Me.dgvDepositos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gbDeposito As System.Windows.Forms.GroupBox
    Friend WithEvents dgvDepositos As System.Windows.Forms.DataGridView
    Friend WithEvents ID_CTR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ID_TIPO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DESCRIPCION As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CANTIDAD As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txtCantidad As System.Windows.Forms.TextBox
    Friend WithEvents lblCantidad As System.Windows.Forms.Label
    Friend WithEvents txtDescripcion As System.Windows.Forms.TextBox
    Friend WithEvents lblDescripcion As System.Windows.Forms.Label
    Friend WithEvents cbMtipo As System.Windows.Forms.ComboBox
    Friend WithEvents lblID_Plato As System.Windows.Forms.Label
    Friend WithEvents btnEliminar As System.Windows.Forms.Button
    Friend WithEvents btnModificar As System.Windows.Forms.Button
    Friend WithEvents btnAgregar As System.Windows.Forms.Button
End Class
