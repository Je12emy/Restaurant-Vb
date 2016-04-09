<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Cocina
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
        Me.gbMenu = New System.Windows.Forms.GroupBox()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnModificarPlato = New System.Windows.Forms.Button()
        Me.btnAgregarPlato = New System.Windows.Forms.Button()
        Me.txtMprecio = New System.Windows.Forms.TextBox()
        Me.lblMprecio = New System.Windows.Forms.Label()
        Me.lblMdescripcion = New System.Windows.Forms.Label()
        Me.txtMdescripcion = New System.Windows.Forms.TextBox()
        Me.lblMnombre = New System.Windows.Forms.Label()
        Me.txtMnombre = New System.Windows.Forms.TextBox()
        Me.cbMtipo = New System.Windows.Forms.ComboBox()
        Me.lblID_Plato = New System.Windows.Forms.Label()
        Me.dgvMenu = New System.Windows.Forms.DataGridView()
        Me.ID_PLATO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ID_TIPO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NOMBRE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DESCRIPCION = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PRECIO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.gbMenu.SuspendLayout()
        CType(Me.dgvMenu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gbMenu
        '
        Me.gbMenu.Controls.Add(Me.btnEliminar)
        Me.gbMenu.Controls.Add(Me.btnModificarPlato)
        Me.gbMenu.Controls.Add(Me.btnAgregarPlato)
        Me.gbMenu.Controls.Add(Me.txtMprecio)
        Me.gbMenu.Controls.Add(Me.lblMprecio)
        Me.gbMenu.Controls.Add(Me.lblMdescripcion)
        Me.gbMenu.Controls.Add(Me.txtMdescripcion)
        Me.gbMenu.Controls.Add(Me.lblMnombre)
        Me.gbMenu.Controls.Add(Me.txtMnombre)
        Me.gbMenu.Controls.Add(Me.cbMtipo)
        Me.gbMenu.Controls.Add(Me.lblID_Plato)
        Me.gbMenu.Controls.Add(Me.dgvMenu)
        Me.gbMenu.Location = New System.Drawing.Point(12, 12)
        Me.gbMenu.Name = "gbMenu"
        Me.gbMenu.Size = New System.Drawing.Size(456, 261)
        Me.gbMenu.TabIndex = 0
        Me.gbMenu.TabStop = False
        Me.gbMenu.Text = "Menú"
        '
        'btnEliminar
        '
        Me.btnEliminar.Location = New System.Drawing.Point(176, 221)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(75, 23)
        Me.btnEliminar.TabIndex = 27
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'btnModificarPlato
        '
        Me.btnModificarPlato.Location = New System.Drawing.Point(95, 221)
        Me.btnModificarPlato.Name = "btnModificarPlato"
        Me.btnModificarPlato.Size = New System.Drawing.Size(75, 23)
        Me.btnModificarPlato.TabIndex = 26
        Me.btnModificarPlato.Text = "Modificar"
        Me.btnModificarPlato.UseVisualStyleBackColor = True
        '
        'btnAgregarPlato
        '
        Me.btnAgregarPlato.Location = New System.Drawing.Point(14, 221)
        Me.btnAgregarPlato.Name = "btnAgregarPlato"
        Me.btnAgregarPlato.Size = New System.Drawing.Size(75, 23)
        Me.btnAgregarPlato.TabIndex = 25
        Me.btnAgregarPlato.Text = "Agregar"
        Me.btnAgregarPlato.UseVisualStyleBackColor = True
        '
        'txtMprecio
        '
        Me.txtMprecio.Location = New System.Drawing.Point(374, 193)
        Me.txtMprecio.Name = "txtMprecio"
        Me.txtMprecio.Size = New System.Drawing.Size(65, 20)
        Me.txtMprecio.TabIndex = 24
        '
        'lblMprecio
        '
        Me.lblMprecio.AutoSize = True
        Me.lblMprecio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMprecio.Location = New System.Drawing.Point(371, 173)
        Me.lblMprecio.Name = "lblMprecio"
        Me.lblMprecio.Size = New System.Drawing.Size(47, 16)
        Me.lblMprecio.TabIndex = 23
        Me.lblMprecio.Text = "Precio"
        '
        'lblMdescripcion
        '
        Me.lblMdescripcion.AutoSize = True
        Me.lblMdescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMdescripcion.Location = New System.Drawing.Point(189, 173)
        Me.lblMdescripcion.Name = "lblMdescripcion"
        Me.lblMdescripcion.Size = New System.Drawing.Size(80, 16)
        Me.lblMdescripcion.TabIndex = 21
        Me.lblMdescripcion.Text = "Descripcion"
        '
        'txtMdescripcion
        '
        Me.txtMdescripcion.Location = New System.Drawing.Point(192, 193)
        Me.txtMdescripcion.Name = "txtMdescripcion"
        Me.txtMdescripcion.Size = New System.Drawing.Size(176, 20)
        Me.txtMdescripcion.TabIndex = 22
        '
        'lblMnombre
        '
        Me.lblMnombre.AutoSize = True
        Me.lblMnombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMnombre.Location = New System.Drawing.Point(66, 173)
        Me.lblMnombre.Name = "lblMnombre"
        Me.lblMnombre.Size = New System.Drawing.Size(57, 16)
        Me.lblMnombre.TabIndex = 19
        Me.lblMnombre.Text = "Nombre"
        '
        'txtMnombre
        '
        Me.txtMnombre.Location = New System.Drawing.Point(69, 194)
        Me.txtMnombre.Name = "txtMnombre"
        Me.txtMnombre.Size = New System.Drawing.Size(118, 20)
        Me.txtMnombre.TabIndex = 20
        '
        'cbMtipo
        '
        Me.cbMtipo.FormattingEnabled = True
        Me.cbMtipo.Items.AddRange(New Object() {"BEB", "PTS", "ELD", "CAR", "PAS"})
        Me.cbMtipo.Location = New System.Drawing.Point(14, 194)
        Me.cbMtipo.Name = "cbMtipo"
        Me.cbMtipo.Size = New System.Drawing.Size(47, 21)
        Me.cbMtipo.TabIndex = 18
        '
        'lblID_Plato
        '
        Me.lblID_Plato.AutoSize = True
        Me.lblID_Plato.Location = New System.Drawing.Point(11, 176)
        Me.lblID_Plato.Name = "lblID_Plato"
        Me.lblID_Plato.Size = New System.Drawing.Size(49, 13)
        Me.lblID_Plato.TabIndex = 17
        Me.lblID_Plato.Text = "ID_TIPO"
        '
        'dgvMenu
        '
        Me.dgvMenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvMenu.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID_PLATO, Me.ID_TIPO, Me.NOMBRE, Me.DESCRIPCION, Me.PRECIO})
        Me.dgvMenu.Location = New System.Drawing.Point(6, 19)
        Me.dgvMenu.Name = "dgvMenu"
        Me.dgvMenu.Size = New System.Drawing.Size(433, 150)
        Me.dgvMenu.TabIndex = 0
        '
        'ID_PLATO
        '
        Me.ID_PLATO.HeaderText = "ID_PLATO"
        Me.ID_PLATO.Name = "ID_PLATO"
        Me.ID_PLATO.Visible = False
        Me.ID_PLATO.Width = 60
        '
        'ID_TIPO
        '
        Me.ID_TIPO.HeaderText = "ID_TIPO"
        Me.ID_TIPO.Name = "ID_TIPO"
        Me.ID_TIPO.Width = 60
        '
        'NOMBRE
        '
        Me.NOMBRE.HeaderText = "NOMBRE"
        Me.NOMBRE.Name = "NOMBRE"
        Me.NOMBRE.Width = 120
        '
        'DESCRIPCION
        '
        Me.DESCRIPCION.HeaderText = "DESCRIPCION"
        Me.DESCRIPCION.Name = "DESCRIPCION"
        Me.DESCRIPCION.Width = 125
        '
        'PRECIO
        '
        Me.PRECIO.HeaderText = "PRECIO"
        Me.PRECIO.Name = "PRECIO"
        Me.PRECIO.Width = 65
        '
        'Cocina
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(653, 369)
        Me.Controls.Add(Me.gbMenu)
        Me.Name = "Cocina"
        Me.Text = "Cocina"
        Me.gbMenu.ResumeLayout(False)
        Me.gbMenu.PerformLayout()
        CType(Me.dgvMenu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gbMenu As System.Windows.Forms.GroupBox
    Friend WithEvents dgvMenu As System.Windows.Forms.DataGridView
    Friend WithEvents ID_PLATO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ID_TIPO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NOMBRE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DESCRIPCION As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PRECIO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents lblMprecio As System.Windows.Forms.Label
    Friend WithEvents lblMdescripcion As System.Windows.Forms.Label
    Friend WithEvents txtMdescripcion As System.Windows.Forms.TextBox
    Friend WithEvents lblMnombre As System.Windows.Forms.Label
    Friend WithEvents txtMnombre As System.Windows.Forms.TextBox
    Friend WithEvents cbMtipo As System.Windows.Forms.ComboBox
    Friend WithEvents lblID_Plato As System.Windows.Forms.Label
    Friend WithEvents txtMprecio As System.Windows.Forms.TextBox
    Friend WithEvents btnEliminar As System.Windows.Forms.Button
    Friend WithEvents btnModificarPlato As System.Windows.Forms.Button
    Friend WithEvents btnAgregarPlato As System.Windows.Forms.Button
End Class
