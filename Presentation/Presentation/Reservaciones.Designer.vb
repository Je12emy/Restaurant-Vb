<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Reservaciones
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
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dgvMesas = New System.Windows.Forms.DataGridView()
        Me.ID_MESA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.STATUS = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CAPACIDAD = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ORDENES = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ID_MESONERO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvMenu = New System.Windows.Forms.DataGridView()
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ID_TIPO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NOMBRE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DESCRIPCION = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PRECIO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtmesa = New System.Windows.Forms.TextBox()
        Me.lblMesa = New System.Windows.Forms.Label()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.txtOrdenes = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblID_Mesonero = New System.Windows.Forms.Label()
        Me.txtId_Mesonero = New System.Windows.Forms.TextBox()
        Me.cbStatus = New System.Windows.Forms.ComboBox()
        Me.lblcantidad = New System.Windows.Forms.Label()
        Me.txtCapacidad = New System.Windows.Forms.TextBox()
        Me.btnActualizar = New System.Windows.Forms.Button()
        Me.gbmesas = New System.Windows.Forms.GroupBox()
        Me.gbMenus = New System.Windows.Forms.GroupBox()
        Me.mtMcantidad = New System.Windows.Forms.MaskedTextBox()
        Me.lblMcantidad = New System.Windows.Forms.Label()
        Me.lblMmesa = New System.Windows.Forms.Label()
        Me.btnCargarOrden = New System.Windows.Forms.Button()
        Me.txtMmesa = New System.Windows.Forms.TextBox()
        Me.lblMprecio = New System.Windows.Forms.Label()
        Me.txtMprecio = New System.Windows.Forms.TextBox()
        Me.lblMdescripcion = New System.Windows.Forms.Label()
        Me.txtMdescripcion = New System.Windows.Forms.TextBox()
        Me.lblMnombre = New System.Windows.Forms.Label()
        Me.txtMnombre = New System.Windows.Forms.TextBox()
        Me.cbMtipo = New System.Windows.Forms.ComboBox()
        Me.lblID_Plato = New System.Windows.Forms.Label()
        Me.gbCaja = New System.Windows.Forms.GroupBox()
        Me.txtCproducto = New System.Windows.Forms.TextBox()
        Me.btnceliminar = New System.Windows.Forms.Button()
        Me.btnProcesar = New System.Windows.Forms.Button()
        Me.lblctotal = New System.Windows.Forms.Label()
        Me.txtCtotal = New System.Windows.Forms.TextBox()
        Me.lblCmesa = New System.Windows.Forms.Label()
        Me.dgvCaja = New System.Windows.Forms.DataGridView()
        Me.ID_FACTURA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MESA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PRODUCTO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CCANTIDAD = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CPRECIO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TOTAL = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtCmesa = New System.Windows.Forms.TextBox()
        CType(Me.dgvMesas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvMenu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbmesas.SuspendLayout()
        Me.gbMenus.SuspendLayout()
        Me.gbCaja.SuspendLayout()
        CType(Me.dgvCaja, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvMesas
        '
        Me.dgvMesas.BackgroundColor = System.Drawing.Color.DimGray
        Me.dgvMesas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvMesas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID_MESA, Me.STATUS, Me.CAPACIDAD, Me.ORDENES, Me.ID_MESONERO})
        Me.dgvMesas.Location = New System.Drawing.Point(6, 19)
        Me.dgvMesas.Name = "dgvMesas"
        Me.dgvMesas.Size = New System.Drawing.Size(500, 150)
        Me.dgvMesas.TabIndex = 0
        '
        'ID_MESA
        '
        Me.ID_MESA.FillWeight = 25.0!
        Me.ID_MESA.HeaderText = "ID"
        Me.ID_MESA.Name = "ID_MESA"
        Me.ID_MESA.Width = 25
        '
        'STATUS
        '
        Me.STATUS.HeaderText = "STATUS"
        Me.STATUS.Name = "STATUS"
        '
        'CAPACIDAD
        '
        Me.CAPACIDAD.HeaderText = "CAPACIDAD"
        Me.CAPACIDAD.Name = "CAPACIDAD"
        '
        'ORDENES
        '
        Me.ORDENES.HeaderText = "ORDENES"
        Me.ORDENES.Name = "ORDENES"
        '
        'ID_MESONERO
        '
        Me.ID_MESONERO.HeaderText = "ID_MESONERO"
        Me.ID_MESONERO.Name = "ID_MESONERO"
        Me.ID_MESONERO.Width = 110
        '
        'dgvMenu
        '
        Me.dgvMenu.BackgroundColor = System.Drawing.Color.DimGray
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvMenu.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.dgvMenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvMenu.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID, Me.ID_TIPO, Me.NOMBRE, Me.DESCRIPCION, Me.PRECIO})
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvMenu.DefaultCellStyle = DataGridViewCellStyle8
        Me.dgvMenu.Location = New System.Drawing.Point(9, 19)
        Me.dgvMenu.Name = "dgvMenu"
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvMenu.RowHeadersDefaultCellStyle = DataGridViewCellStyle9
        Me.dgvMenu.Size = New System.Drawing.Size(461, 150)
        Me.dgvMenu.TabIndex = 1
        '
        'ID
        '
        Me.ID.HeaderText = "ID"
        Me.ID.Name = "ID"
        Me.ID.Visible = False
        '
        'ID_TIPO
        '
        Me.ID_TIPO.HeaderText = "ID_TIPO"
        Me.ID_TIPO.Name = "ID_TIPO"
        Me.ID_TIPO.Width = 65
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
        Me.DESCRIPCION.Width = 150
        '
        'PRECIO
        '
        Me.PRECIO.HeaderText = "PRECIO"
        Me.PRECIO.Name = "PRECIO"
        Me.PRECIO.Width = 65
        '
        'txtmesa
        '
        Me.txtmesa.Location = New System.Drawing.Point(6, 191)
        Me.txtmesa.Name = "txtmesa"
        Me.txtmesa.Size = New System.Drawing.Size(39, 22)
        Me.txtmesa.TabIndex = 2
        '
        'lblMesa
        '
        Me.lblMesa.AutoSize = True
        Me.lblMesa.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMesa.Location = New System.Drawing.Point(3, 172)
        Me.lblMesa.Name = "lblMesa"
        Me.lblMesa.Size = New System.Drawing.Size(42, 16)
        Me.lblMesa.TabIndex = 3
        Me.lblMesa.Text = "Mesa"
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatus.Location = New System.Drawing.Point(54, 172)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(45, 16)
        Me.lblStatus.TabIndex = 5
        Me.lblStatus.Text = "Status"
        '
        'txtOrdenes
        '
        Me.txtOrdenes.Location = New System.Drawing.Point(266, 191)
        Me.txtOrdenes.Name = "txtOrdenes"
        Me.txtOrdenes.Size = New System.Drawing.Size(48, 22)
        Me.txtOrdenes.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(263, 172)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 16)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Ordenes"
        '
        'lblID_Mesonero
        '
        Me.lblID_Mesonero.AutoSize = True
        Me.lblID_Mesonero.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblID_Mesonero.Location = New System.Drawing.Point(329, 172)
        Me.lblID_Mesonero.Name = "lblID_Mesonero"
        Me.lblID_Mesonero.Size = New System.Drawing.Size(89, 16)
        Me.lblID_Mesonero.TabIndex = 9
        Me.lblID_Mesonero.Text = "ID_Mesonero"
        '
        'txtId_Mesonero
        '
        Me.txtId_Mesonero.Location = New System.Drawing.Point(330, 191)
        Me.txtId_Mesonero.Name = "txtId_Mesonero"
        Me.txtId_Mesonero.Size = New System.Drawing.Size(67, 22)
        Me.txtId_Mesonero.TabIndex = 8
        '
        'cbStatus
        '
        Me.cbStatus.FormattingEnabled = True
        Me.cbStatus.Items.AddRange(New Object() {"DISPONIBLE", "OCUPADO"})
        Me.cbStatus.Location = New System.Drawing.Point(54, 191)
        Me.cbStatus.Name = "cbStatus"
        Me.cbStatus.Size = New System.Drawing.Size(105, 24)
        Me.cbStatus.TabIndex = 10
        '
        'lblcantidad
        '
        Me.lblcantidad.AutoSize = True
        Me.lblcantidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcantidad.Location = New System.Drawing.Point(162, 172)
        Me.lblcantidad.Name = "lblcantidad"
        Me.lblcantidad.Size = New System.Drawing.Size(75, 16)
        Me.lblcantidad.TabIndex = 12
        Me.lblcantidad.Text = "Capacidad"
        '
        'txtCapacidad
        '
        Me.txtCapacidad.Location = New System.Drawing.Point(165, 191)
        Me.txtCapacidad.Name = "txtCapacidad"
        Me.txtCapacidad.Size = New System.Drawing.Size(95, 22)
        Me.txtCapacidad.TabIndex = 11
        '
        'btnActualizar
        '
        Me.btnActualizar.Location = New System.Drawing.Point(403, 190)
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Size = New System.Drawing.Size(75, 23)
        Me.btnActualizar.TabIndex = 13
        Me.btnActualizar.Text = "Actualizar"
        Me.btnActualizar.UseVisualStyleBackColor = True
        '
        'gbmesas
        '
        Me.gbmesas.Controls.Add(Me.dgvMesas)
        Me.gbmesas.Controls.Add(Me.lblMesa)
        Me.gbmesas.Controls.Add(Me.btnActualizar)
        Me.gbmesas.Controls.Add(Me.txtmesa)
        Me.gbmesas.Controls.Add(Me.lblcantidad)
        Me.gbmesas.Controls.Add(Me.txtOrdenes)
        Me.gbmesas.Controls.Add(Me.txtCapacidad)
        Me.gbmesas.Controls.Add(Me.lblStatus)
        Me.gbmesas.Controls.Add(Me.cbStatus)
        Me.gbmesas.Controls.Add(Me.Label3)
        Me.gbmesas.Controls.Add(Me.lblID_Mesonero)
        Me.gbmesas.Controls.Add(Me.txtId_Mesonero)
        Me.gbmesas.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbmesas.Location = New System.Drawing.Point(12, 12)
        Me.gbmesas.Name = "gbmesas"
        Me.gbmesas.Size = New System.Drawing.Size(518, 230)
        Me.gbmesas.TabIndex = 15
        Me.gbmesas.TabStop = False
        Me.gbmesas.Text = "Mesas"
        '
        'gbMenus
        '
        Me.gbMenus.Controls.Add(Me.mtMcantidad)
        Me.gbMenus.Controls.Add(Me.lblMcantidad)
        Me.gbMenus.Controls.Add(Me.lblMmesa)
        Me.gbMenus.Controls.Add(Me.btnCargarOrden)
        Me.gbMenus.Controls.Add(Me.txtMmesa)
        Me.gbMenus.Controls.Add(Me.lblMprecio)
        Me.gbMenus.Controls.Add(Me.txtMprecio)
        Me.gbMenus.Controls.Add(Me.lblMdescripcion)
        Me.gbMenus.Controls.Add(Me.txtMdescripcion)
        Me.gbMenus.Controls.Add(Me.lblMnombre)
        Me.gbMenus.Controls.Add(Me.txtMnombre)
        Me.gbMenus.Controls.Add(Me.cbMtipo)
        Me.gbMenus.Controls.Add(Me.lblID_Plato)
        Me.gbMenus.Controls.Add(Me.dgvMenu)
        Me.gbMenus.Location = New System.Drawing.Point(536, 12)
        Me.gbMenus.Name = "gbMenus"
        Me.gbMenus.Size = New System.Drawing.Size(542, 230)
        Me.gbMenus.TabIndex = 16
        Me.gbMenus.TabStop = False
        Me.gbMenus.Text = "Menú"
        '
        'mtMcantidad
        '
        Me.mtMcantidad.Location = New System.Drawing.Point(59, 193)
        Me.mtMcantidad.Mask = "000"
        Me.mtMcantidad.Name = "mtMcantidad"
        Me.mtMcantidad.Size = New System.Drawing.Size(28, 20)
        Me.mtMcantidad.TabIndex = 18
        Me.mtMcantidad.Text = "1"
        '
        'lblMcantidad
        '
        Me.lblMcantidad.AutoSize = True
        Me.lblMcantidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMcantidad.Location = New System.Drawing.Point(56, 174)
        Me.lblMcantidad.Name = "lblMcantidad"
        Me.lblMcantidad.Size = New System.Drawing.Size(31, 16)
        Me.lblMcantidad.TabIndex = 20
        Me.lblMcantidad.Text = "C/U"
        '
        'lblMmesa
        '
        Me.lblMmesa.AutoSize = True
        Me.lblMmesa.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMmesa.Location = New System.Drawing.Point(8, 174)
        Me.lblMmesa.Name = "lblMmesa"
        Me.lblMmesa.Size = New System.Drawing.Size(42, 16)
        Me.lblMmesa.TabIndex = 15
        Me.lblMmesa.Text = "Mesa"
        '
        'btnCargarOrden
        '
        Me.btnCargarOrden.Location = New System.Drawing.Point(458, 191)
        Me.btnCargarOrden.Name = "btnCargarOrden"
        Me.btnCargarOrden.Size = New System.Drawing.Size(78, 23)
        Me.btnCargarOrden.TabIndex = 14
        Me.btnCargarOrden.Text = "Ordenar"
        Me.btnCargarOrden.UseVisualStyleBackColor = True
        '
        'txtMmesa
        '
        Me.txtMmesa.Location = New System.Drawing.Point(11, 193)
        Me.txtMmesa.Name = "txtMmesa"
        Me.txtMmesa.Size = New System.Drawing.Size(34, 20)
        Me.txtMmesa.TabIndex = 14
        '
        'lblMprecio
        '
        Me.lblMprecio.AutoSize = True
        Me.lblMprecio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMprecio.Location = New System.Drawing.Point(476, 47)
        Me.lblMprecio.Name = "lblMprecio"
        Me.lblMprecio.Size = New System.Drawing.Size(47, 16)
        Me.lblMprecio.TabIndex = 17
        Me.lblMprecio.Text = "Precio"
        Me.lblMprecio.Visible = False
        '
        'txtMprecio
        '
        Me.txtMprecio.Location = New System.Drawing.Point(482, 68)
        Me.txtMprecio.Name = "txtMprecio"
        Me.txtMprecio.Size = New System.Drawing.Size(58, 20)
        Me.txtMprecio.TabIndex = 18
        Me.txtMprecio.Visible = False
        '
        'lblMdescripcion
        '
        Me.lblMdescripcion.AutoSize = True
        Me.lblMdescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMdescripcion.Location = New System.Drawing.Point(274, 172)
        Me.lblMdescripcion.Name = "lblMdescripcion"
        Me.lblMdescripcion.Size = New System.Drawing.Size(80, 16)
        Me.lblMdescripcion.TabIndex = 15
        Me.lblMdescripcion.Text = "Descripcion"
        '
        'txtMdescripcion
        '
        Me.txtMdescripcion.Location = New System.Drawing.Point(277, 192)
        Me.txtMdescripcion.Name = "txtMdescripcion"
        Me.txtMdescripcion.Size = New System.Drawing.Size(176, 20)
        Me.txtMdescripcion.TabIndex = 16
        '
        'lblMnombre
        '
        Me.lblMnombre.AutoSize = True
        Me.lblMnombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMnombre.Location = New System.Drawing.Point(151, 172)
        Me.lblMnombre.Name = "lblMnombre"
        Me.lblMnombre.Size = New System.Drawing.Size(57, 16)
        Me.lblMnombre.TabIndex = 14
        Me.lblMnombre.Text = "Nombre"
        '
        'txtMnombre
        '
        Me.txtMnombre.Location = New System.Drawing.Point(154, 193)
        Me.txtMnombre.Name = "txtMnombre"
        Me.txtMnombre.Size = New System.Drawing.Size(118, 20)
        Me.txtMnombre.TabIndex = 14
        '
        'cbMtipo
        '
        Me.cbMtipo.FormattingEnabled = True
        Me.cbMtipo.Items.AddRange(New Object() {"BEB", "PTS", "ELD", "CAR", "PAS"})
        Me.cbMtipo.Location = New System.Drawing.Point(99, 193)
        Me.cbMtipo.Name = "cbMtipo"
        Me.cbMtipo.Size = New System.Drawing.Size(47, 21)
        Me.cbMtipo.TabIndex = 3
        '
        'lblID_Plato
        '
        Me.lblID_Plato.AutoSize = True
        Me.lblID_Plato.Location = New System.Drawing.Point(96, 175)
        Me.lblID_Plato.Name = "lblID_Plato"
        Me.lblID_Plato.Size = New System.Drawing.Size(49, 13)
        Me.lblID_Plato.TabIndex = 2
        Me.lblID_Plato.Text = "ID_TIPO"
        '
        'gbCaja
        '
        Me.gbCaja.Controls.Add(Me.txtCproducto)
        Me.gbCaja.Controls.Add(Me.btnceliminar)
        Me.gbCaja.Controls.Add(Me.btnProcesar)
        Me.gbCaja.Controls.Add(Me.lblctotal)
        Me.gbCaja.Controls.Add(Me.txtCtotal)
        Me.gbCaja.Controls.Add(Me.lblCmesa)
        Me.gbCaja.Controls.Add(Me.dgvCaja)
        Me.gbCaja.Controls.Add(Me.txtCmesa)
        Me.gbCaja.Location = New System.Drawing.Point(18, 248)
        Me.gbCaja.Name = "gbCaja"
        Me.gbCaja.Size = New System.Drawing.Size(399, 219)
        Me.gbCaja.TabIndex = 17
        Me.gbCaja.TabStop = False
        Me.gbCaja.Text = "Caja"
        '
        'txtCproducto
        '
        Me.txtCproducto.Enabled = False
        Me.txtCproducto.Location = New System.Drawing.Point(309, 175)
        Me.txtCproducto.Name = "txtCproducto"
        Me.txtCproducto.Size = New System.Drawing.Size(73, 20)
        Me.txtCproducto.TabIndex = 19
        Me.txtCproducto.Visible = False
        '
        'btnceliminar
        '
        Me.btnceliminar.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnceliminar.Location = New System.Drawing.Point(133, 186)
        Me.btnceliminar.Name = "btnceliminar"
        Me.btnceliminar.Size = New System.Drawing.Size(75, 23)
        Me.btnceliminar.TabIndex = 18
        Me.btnceliminar.Text = "Eliminar"
        Me.btnceliminar.UseVisualStyleBackColor = True
        '
        'btnProcesar
        '
        Me.btnProcesar.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnProcesar.Location = New System.Drawing.Point(214, 186)
        Me.btnProcesar.Name = "btnProcesar"
        Me.btnProcesar.Size = New System.Drawing.Size(75, 23)
        Me.btnProcesar.TabIndex = 14
        Me.btnProcesar.Text = "Procesar"
        Me.btnProcesar.UseVisualStyleBackColor = True
        '
        'lblctotal
        '
        Me.lblctotal.AutoSize = True
        Me.lblctotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblctotal.Location = New System.Drawing.Point(51, 170)
        Me.lblctotal.Name = "lblctotal"
        Me.lblctotal.Size = New System.Drawing.Size(76, 16)
        Me.lblctotal.TabIndex = 17
        Me.lblctotal.Text = "Total Mesa"
        '
        'txtCtotal
        '
        Me.txtCtotal.Location = New System.Drawing.Point(54, 189)
        Me.txtCtotal.Name = "txtCtotal"
        Me.txtCtotal.Size = New System.Drawing.Size(73, 20)
        Me.txtCtotal.TabIndex = 16
        '
        'lblCmesa
        '
        Me.lblCmesa.AutoSize = True
        Me.lblCmesa.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCmesa.Location = New System.Drawing.Point(3, 170)
        Me.lblCmesa.Name = "lblCmesa"
        Me.lblCmesa.Size = New System.Drawing.Size(42, 16)
        Me.lblCmesa.TabIndex = 15
        Me.lblCmesa.Text = "Mesa"
        '
        'dgvCaja
        '
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvCaja.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle10
        Me.dgvCaja.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCaja.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID_FACTURA, Me.MESA, Me.PRODUCTO, Me.CCANTIDAD, Me.CPRECIO, Me.TOTAL})
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvCaja.DefaultCellStyle = DataGridViewCellStyle11
        Me.dgvCaja.Location = New System.Drawing.Point(6, 19)
        Me.dgvCaja.Name = "dgvCaja"
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvCaja.RowHeadersDefaultCellStyle = DataGridViewCellStyle12
        Me.dgvCaja.Size = New System.Drawing.Size(385, 150)
        Me.dgvCaja.TabIndex = 0
        '
        'ID_FACTURA
        '
        Me.ID_FACTURA.HeaderText = "ID_FACTURA"
        Me.ID_FACTURA.Name = "ID_FACTURA"
        Me.ID_FACTURA.Visible = False
        '
        'MESA
        '
        Me.MESA.HeaderText = "MESA"
        Me.MESA.Name = "MESA"
        Me.MESA.Width = 40
        '
        'PRODUCTO
        '
        Me.PRODUCTO.HeaderText = "PRODUCTO"
        Me.PRODUCTO.Name = "PRODUCTO"
        Me.PRODUCTO.Width = 120
        '
        'CCANTIDAD
        '
        Me.CCANTIDAD.HeaderText = "C/U"
        Me.CCANTIDAD.Name = "CCANTIDAD"
        Me.CCANTIDAD.Width = 45
        '
        'CPRECIO
        '
        Me.CPRECIO.HeaderText = "PRECIO"
        Me.CPRECIO.Name = "CPRECIO"
        Me.CPRECIO.Width = 65
        '
        'TOTAL
        '
        Me.TOTAL.HeaderText = "TOTAL"
        Me.TOTAL.Name = "TOTAL"
        Me.TOTAL.Width = 65
        '
        'txtCmesa
        '
        Me.txtCmesa.Location = New System.Drawing.Point(6, 189)
        Me.txtCmesa.Name = "txtCmesa"
        Me.txtCmesa.Size = New System.Drawing.Size(39, 20)
        Me.txtCmesa.TabIndex = 14
        '
        'Reservaciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1127, 548)
        Me.Controls.Add(Me.gbCaja)
        Me.Controls.Add(Me.gbMenus)
        Me.Controls.Add(Me.gbmesas)
        Me.Name = "Reservaciones"
        Me.Text = "Reservaciones"
        CType(Me.dgvMesas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvMenu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbmesas.ResumeLayout(False)
        Me.gbmesas.PerformLayout()
        Me.gbMenus.ResumeLayout(False)
        Me.gbMenus.PerformLayout()
        Me.gbCaja.ResumeLayout(False)
        Me.gbCaja.PerformLayout()
        CType(Me.dgvCaja, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgvMesas As System.Windows.Forms.DataGridView
    Friend WithEvents dgvMenu As System.Windows.Forms.DataGridView
    Friend WithEvents txtmesa As System.Windows.Forms.TextBox
    Friend WithEvents lblMesa As System.Windows.Forms.Label
    Friend WithEvents lblStatus As System.Windows.Forms.Label
    Friend WithEvents txtOrdenes As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblID_Mesonero As System.Windows.Forms.Label
    Friend WithEvents txtId_Mesonero As System.Windows.Forms.TextBox
    Friend WithEvents cbStatus As System.Windows.Forms.ComboBox
    Friend WithEvents lblcantidad As System.Windows.Forms.Label
    Friend WithEvents txtCapacidad As System.Windows.Forms.TextBox
    Friend WithEvents btnActualizar As System.Windows.Forms.Button
    Friend WithEvents gbmesas As System.Windows.Forms.GroupBox
    Friend WithEvents ID_MESA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents STATUS As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CAPACIDAD As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ORDENES As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ID_MESONERO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents gbMenus As System.Windows.Forms.GroupBox
    Friend WithEvents ID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ID_TIPO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NOMBRE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DESCRIPCION As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PRECIO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnCargarOrden As System.Windows.Forms.Button
    Friend WithEvents lblMprecio As System.Windows.Forms.Label
    Friend WithEvents txtMprecio As System.Windows.Forms.TextBox
    Friend WithEvents lblMdescripcion As System.Windows.Forms.Label
    Friend WithEvents txtMdescripcion As System.Windows.Forms.TextBox
    Friend WithEvents lblMnombre As System.Windows.Forms.Label
    Friend WithEvents txtMnombre As System.Windows.Forms.TextBox
    Friend WithEvents cbMtipo As System.Windows.Forms.ComboBox
    Friend WithEvents lblID_Plato As System.Windows.Forms.Label
    Friend WithEvents lblMmesa As System.Windows.Forms.Label
    Friend WithEvents txtMmesa As System.Windows.Forms.TextBox
    Friend WithEvents gbCaja As System.Windows.Forms.GroupBox
    Friend WithEvents dgvCaja As System.Windows.Forms.DataGridView
    Friend WithEvents lblMcantidad As System.Windows.Forms.Label
    Friend WithEvents btnceliminar As System.Windows.Forms.Button
    Friend WithEvents btnProcesar As System.Windows.Forms.Button
    Friend WithEvents lblctotal As System.Windows.Forms.Label
    Friend WithEvents txtCtotal As System.Windows.Forms.TextBox
    Friend WithEvents lblCmesa As System.Windows.Forms.Label
    Friend WithEvents txtCmesa As System.Windows.Forms.TextBox
    Friend WithEvents mtMcantidad As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtCproducto As System.Windows.Forms.TextBox
    Friend WithEvents ID_FACTURA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MESA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PRODUCTO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CCANTIDAD As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CPRECIO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TOTAL As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
