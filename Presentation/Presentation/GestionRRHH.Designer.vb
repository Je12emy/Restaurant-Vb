<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GestionRRHH
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.gbEmpleados = New System.Windows.Forms.GroupBox()
        Me.btnEeliminar = New System.Windows.Forms.Button()
        Me.btnEModificar = New System.Windows.Forms.Button()
        Me.btnEAgregar = New System.Windows.Forms.Button()
        Me.mtID_EM = New System.Windows.Forms.MaskedTextBox()
        Me.mtEdad = New System.Windows.Forms.MaskedTextBox()
        Me.txtEdireccion = New System.Windows.Forms.TextBox()
        Me.lblEdireccion = New System.Windows.Forms.Label()
        Me.txtEcorreo = New System.Windows.Forms.TextBox()
        Me.lblCorreo = New System.Windows.Forms.Label()
        Me.mtEtelefono = New System.Windows.Forms.MaskedTextBox()
        Me.lblEdad = New System.Windows.Forms.Label()
        Me.lbleTelefono = New System.Windows.Forms.Label()
        Me.cbID_DPTO = New System.Windows.Forms.ComboBox()
        Me.txtEapellido = New System.Windows.Forms.TextBox()
        Me.lblEapellido = New System.Windows.Forms.Label()
        Me.txtEnombre = New System.Windows.Forms.TextBox()
        Me.lblENombre = New System.Windows.Forms.Label()
        Me.lblID_DPTO = New System.Windows.Forms.Label()
        Me.lblEID_EM = New System.Windows.Forms.Label()
        Me.dgvEmpleados = New System.Windows.Forms.DataGridView()
        Me.ID_CTR = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ID_EMPLEADO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ID_DPTO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NOMBRE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.APELLIDO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TELEFONO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EDAD = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CORREO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DIRECCION = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.gbLogin = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbLtipouser = New System.Windows.Forms.ComboBox()
        Me.btnLeliminar = New System.Windows.Forms.Button()
        Me.btnLmodificar = New System.Windows.Forms.Button()
        Me.txtLpass = New System.Windows.Forms.TextBox()
        Me.BtnLagregar = New System.Windows.Forms.Button()
        Me.lblpass = New System.Windows.Forms.Label()
        Me.txtLusername = New System.Windows.Forms.TextBox()
        Me.lblLusername = New System.Windows.Forms.Label()
        Me.txtLid_user = New System.Windows.Forms.TextBox()
        Me.lblLid_user = New System.Windows.Forms.Label()
        Me.dgvLogin = New System.Windows.Forms.DataGridView()
        Me.ID_USER = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.USERNAME = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PASS = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.gbEmpleados.SuspendLayout()
        CType(Me.dgvEmpleados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbLogin.SuspendLayout()
        CType(Me.dgvLogin, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gbEmpleados
        '
        Me.gbEmpleados.Controls.Add(Me.btnEeliminar)
        Me.gbEmpleados.Controls.Add(Me.btnEModificar)
        Me.gbEmpleados.Controls.Add(Me.btnEAgregar)
        Me.gbEmpleados.Controls.Add(Me.mtID_EM)
        Me.gbEmpleados.Controls.Add(Me.mtEdad)
        Me.gbEmpleados.Controls.Add(Me.txtEdireccion)
        Me.gbEmpleados.Controls.Add(Me.lblEdireccion)
        Me.gbEmpleados.Controls.Add(Me.txtEcorreo)
        Me.gbEmpleados.Controls.Add(Me.lblCorreo)
        Me.gbEmpleados.Controls.Add(Me.mtEtelefono)
        Me.gbEmpleados.Controls.Add(Me.lblEdad)
        Me.gbEmpleados.Controls.Add(Me.lbleTelefono)
        Me.gbEmpleados.Controls.Add(Me.cbID_DPTO)
        Me.gbEmpleados.Controls.Add(Me.txtEapellido)
        Me.gbEmpleados.Controls.Add(Me.lblEapellido)
        Me.gbEmpleados.Controls.Add(Me.txtEnombre)
        Me.gbEmpleados.Controls.Add(Me.lblENombre)
        Me.gbEmpleados.Controls.Add(Me.lblID_DPTO)
        Me.gbEmpleados.Controls.Add(Me.lblEID_EM)
        Me.gbEmpleados.Controls.Add(Me.dgvEmpleados)
        Me.gbEmpleados.Location = New System.Drawing.Point(12, 12)
        Me.gbEmpleados.Name = "gbEmpleados"
        Me.gbEmpleados.Size = New System.Drawing.Size(647, 434)
        Me.gbEmpleados.TabIndex = 0
        Me.gbEmpleados.TabStop = False
        Me.gbEmpleados.Text = "Empleados"
        '
        'btnEeliminar
        '
        Me.btnEeliminar.Location = New System.Drawing.Point(285, 318)
        Me.btnEeliminar.Name = "btnEeliminar"
        Me.btnEeliminar.Size = New System.Drawing.Size(75, 39)
        Me.btnEeliminar.TabIndex = 22
        Me.btnEeliminar.Text = "Eliminar"
        Me.btnEeliminar.UseVisualStyleBackColor = True
        '
        'btnEModificar
        '
        Me.btnEModificar.Location = New System.Drawing.Point(285, 269)
        Me.btnEModificar.Name = "btnEModificar"
        Me.btnEModificar.Size = New System.Drawing.Size(75, 39)
        Me.btnEModificar.TabIndex = 21
        Me.btnEModificar.Text = "Modificar"
        Me.btnEModificar.UseVisualStyleBackColor = True
        '
        'btnEAgregar
        '
        Me.btnEAgregar.Location = New System.Drawing.Point(285, 221)
        Me.btnEAgregar.Name = "btnEAgregar"
        Me.btnEAgregar.Size = New System.Drawing.Size(75, 40)
        Me.btnEAgregar.TabIndex = 20
        Me.btnEAgregar.Text = "Agregar"
        Me.btnEAgregar.UseVisualStyleBackColor = True
        '
        'mtID_EM
        '
        Me.mtID_EM.Location = New System.Drawing.Point(67, 189)
        Me.mtID_EM.Mask = "0000"
        Me.mtID_EM.Name = "mtID_EM"
        Me.mtID_EM.Size = New System.Drawing.Size(39, 20)
        Me.mtID_EM.TabIndex = 1
        '
        'mtEdad
        '
        Me.mtEdad.Location = New System.Drawing.Point(67, 328)
        Me.mtEdad.Mask = "00"
        Me.mtEdad.Name = "mtEdad"
        Me.mtEdad.Size = New System.Drawing.Size(26, 20)
        Me.mtEdad.TabIndex = 6
        '
        'txtEdireccion
        '
        Me.txtEdireccion.Location = New System.Drawing.Point(67, 378)
        Me.txtEdireccion.Name = "txtEdireccion"
        Me.txtEdireccion.Size = New System.Drawing.Size(150, 20)
        Me.txtEdireccion.TabIndex = 8
        '
        'lblEdireccion
        '
        Me.lblEdireccion.AutoSize = True
        Me.lblEdireccion.Location = New System.Drawing.Point(9, 381)
        Me.lblEdireccion.Name = "lblEdireccion"
        Me.lblEdireccion.Size = New System.Drawing.Size(52, 13)
        Me.lblEdireccion.TabIndex = 19
        Me.lblEdireccion.Text = "Dirección"
        '
        'txtEcorreo
        '
        Me.txtEcorreo.Location = New System.Drawing.Point(67, 352)
        Me.txtEcorreo.Name = "txtEcorreo"
        Me.txtEcorreo.Size = New System.Drawing.Size(150, 20)
        Me.txtEcorreo.TabIndex = 7
        '
        'lblCorreo
        '
        Me.lblCorreo.AutoSize = True
        Me.lblCorreo.Location = New System.Drawing.Point(19, 359)
        Me.lblCorreo.Name = "lblCorreo"
        Me.lblCorreo.Size = New System.Drawing.Size(38, 13)
        Me.lblCorreo.TabIndex = 17
        Me.lblCorreo.Text = "Correo"
        '
        'mtEtelefono
        '
        Me.mtEtelefono.Location = New System.Drawing.Point(65, 302)
        Me.mtEtelefono.Mask = "00000000000000"
        Me.mtEtelefono.Name = "mtEtelefono"
        Me.mtEtelefono.Size = New System.Drawing.Size(100, 20)
        Me.mtEtelefono.TabIndex = 5
        '
        'lblEdad
        '
        Me.lblEdad.AutoSize = True
        Me.lblEdad.Location = New System.Drawing.Point(25, 333)
        Me.lblEdad.Name = "lblEdad"
        Me.lblEdad.Size = New System.Drawing.Size(32, 13)
        Me.lblEdad.TabIndex = 14
        Me.lblEdad.Text = "Edad"
        '
        'lbleTelefono
        '
        Me.lbleTelefono.AutoSize = True
        Me.lbleTelefono.Location = New System.Drawing.Point(15, 305)
        Me.lbleTelefono.Name = "lbleTelefono"
        Me.lbleTelefono.Size = New System.Drawing.Size(49, 13)
        Me.lbleTelefono.TabIndex = 12
        Me.lbleTelefono.Text = "Teléfono"
        '
        'cbID_DPTO
        '
        Me.cbID_DPTO.FormattingEnabled = True
        Me.cbID_DPTO.Items.AddRange(New Object() {"ADMIN", "COCIN", "MESER", "BODEG", ""})
        Me.cbID_DPTO.Location = New System.Drawing.Point(67, 215)
        Me.cbID_DPTO.Name = "cbID_DPTO"
        Me.cbID_DPTO.Size = New System.Drawing.Size(67, 21)
        Me.cbID_DPTO.TabIndex = 2
        '
        'txtEapellido
        '
        Me.txtEapellido.Location = New System.Drawing.Point(65, 269)
        Me.txtEapellido.Name = "txtEapellido"
        Me.txtEapellido.Size = New System.Drawing.Size(123, 20)
        Me.txtEapellido.TabIndex = 4
        '
        'lblEapellido
        '
        Me.lblEapellido.AutoSize = True
        Me.lblEapellido.Location = New System.Drawing.Point(17, 276)
        Me.lblEapellido.Name = "lblEapellido"
        Me.lblEapellido.Size = New System.Drawing.Size(44, 13)
        Me.lblEapellido.TabIndex = 7
        Me.lblEapellido.Text = "Apellido"
        '
        'txtEnombre
        '
        Me.txtEnombre.Location = New System.Drawing.Point(65, 241)
        Me.txtEnombre.Name = "txtEnombre"
        Me.txtEnombre.Size = New System.Drawing.Size(123, 20)
        Me.txtEnombre.TabIndex = 3
        '
        'lblENombre
        '
        Me.lblENombre.AutoSize = True
        Me.lblENombre.Location = New System.Drawing.Point(15, 248)
        Me.lblENombre.Name = "lblENombre"
        Me.lblENombre.Size = New System.Drawing.Size(44, 13)
        Me.lblENombre.TabIndex = 5
        Me.lblENombre.Text = "Nombre"
        '
        'lblID_DPTO
        '
        Me.lblID_DPTO.AutoSize = True
        Me.lblID_DPTO.Location = New System.Drawing.Point(7, 222)
        Me.lblID_DPTO.Name = "lblID_DPTO"
        Me.lblID_DPTO.Size = New System.Drawing.Size(54, 13)
        Me.lblID_DPTO.TabIndex = 3
        Me.lblID_DPTO.Text = "ID_DPTO"
        '
        'lblEID_EM
        '
        Me.lblEID_EM.AutoSize = True
        Me.lblEID_EM.Location = New System.Drawing.Point(17, 195)
        Me.lblEID_EM.Name = "lblEID_EM"
        Me.lblEID_EM.Size = New System.Drawing.Size(40, 13)
        Me.lblEID_EM.TabIndex = 1
        Me.lblEID_EM.Text = "ID_EM"
        '
        'dgvEmpleados
        '
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvEmpleados.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvEmpleados.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID_CTR, Me.ID_EMPLEADO, Me.ID_DPTO, Me.NOMBRE, Me.APELLIDO, Me.TELEFONO, Me.EDAD, Me.CORREO, Me.DIRECCION})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvEmpleados.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvEmpleados.Location = New System.Drawing.Point(6, 19)
        Me.dgvEmpleados.Name = "dgvEmpleados"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvEmpleados.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvEmpleados.Size = New System.Drawing.Size(635, 150)
        Me.dgvEmpleados.TabIndex = 0
        '
        'ID_CTR
        '
        Me.ID_CTR.HeaderText = "ID_CTR"
        Me.ID_CTR.Name = "ID_CTR"
        Me.ID_CTR.Visible = False
        '
        'ID_EMPLEADO
        '
        Me.ID_EMPLEADO.HeaderText = "ID_EM"
        Me.ID_EMPLEADO.Name = "ID_EMPLEADO"
        Me.ID_EMPLEADO.Width = 75
        '
        'ID_DPTO
        '
        Me.ID_DPTO.HeaderText = "ID_DPTO"
        Me.ID_DPTO.Name = "ID_DPTO"
        Me.ID_DPTO.Width = 65
        '
        'NOMBRE
        '
        Me.NOMBRE.HeaderText = "NOMBRE"
        Me.NOMBRE.Name = "NOMBRE"
        Me.NOMBRE.Width = 80
        '
        'APELLIDO
        '
        Me.APELLIDO.HeaderText = "APELLIDO"
        Me.APELLIDO.Name = "APELLIDO"
        Me.APELLIDO.Width = 80
        '
        'TELEFONO
        '
        Me.TELEFONO.HeaderText = "TELEFONO"
        Me.TELEFONO.Name = "TELEFONO"
        Me.TELEFONO.Width = 65
        '
        'EDAD
        '
        Me.EDAD.HeaderText = "EDAD"
        Me.EDAD.Name = "EDAD"
        Me.EDAD.Width = 45
        '
        'CORREO
        '
        Me.CORREO.HeaderText = "CORREO"
        Me.CORREO.Name = "CORREO"
        '
        'DIRECCION
        '
        Me.DIRECCION.HeaderText = "DIRECCION"
        Me.DIRECCION.Name = "DIRECCION"
        Me.DIRECCION.Width = 80
        '
        'gbLogin
        '
        Me.gbLogin.Controls.Add(Me.Label1)
        Me.gbLogin.Controls.Add(Me.cbLtipouser)
        Me.gbLogin.Controls.Add(Me.btnLeliminar)
        Me.gbLogin.Controls.Add(Me.btnLmodificar)
        Me.gbLogin.Controls.Add(Me.txtLpass)
        Me.gbLogin.Controls.Add(Me.BtnLagregar)
        Me.gbLogin.Controls.Add(Me.lblpass)
        Me.gbLogin.Controls.Add(Me.txtLusername)
        Me.gbLogin.Controls.Add(Me.lblLusername)
        Me.gbLogin.Controls.Add(Me.txtLid_user)
        Me.gbLogin.Controls.Add(Me.lblLid_user)
        Me.gbLogin.Controls.Add(Me.dgvLogin)
        Me.gbLogin.Location = New System.Drawing.Point(665, 12)
        Me.gbLogin.Name = "gbLogin"
        Me.gbLogin.Size = New System.Drawing.Size(376, 299)
        Me.gbLogin.TabIndex = 1
        Me.gbLogin.TabStop = False
        Me.gbLogin.Text = "Login"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(288, 172)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 13)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "ID_DPTO"
        '
        'cbLtipouser
        '
        Me.cbLtipouser.FormattingEnabled = True
        Me.cbLtipouser.Items.AddRange(New Object() {"ADMIN", "COCIN", "MESER", "BODEG", ""})
        Me.cbLtipouser.Location = New System.Drawing.Point(291, 193)
        Me.cbLtipouser.Name = "cbLtipouser"
        Me.cbLtipouser.Size = New System.Drawing.Size(67, 21)
        Me.cbLtipouser.TabIndex = 23
        '
        'btnLeliminar
        '
        Me.btnLeliminar.Location = New System.Drawing.Point(187, 244)
        Me.btnLeliminar.Name = "btnLeliminar"
        Me.btnLeliminar.Size = New System.Drawing.Size(75, 39)
        Me.btnLeliminar.TabIndex = 25
        Me.btnLeliminar.Text = "Eliminar"
        Me.btnLeliminar.UseVisualStyleBackColor = True
        '
        'btnLmodificar
        '
        Me.btnLmodificar.Location = New System.Drawing.Point(106, 244)
        Me.btnLmodificar.Name = "btnLmodificar"
        Me.btnLmodificar.Size = New System.Drawing.Size(75, 39)
        Me.btnLmodificar.TabIndex = 24
        Me.btnLmodificar.Text = "Modificar"
        Me.btnLmodificar.UseVisualStyleBackColor = True
        '
        'txtLpass
        '
        Me.txtLpass.Location = New System.Drawing.Point(226, 192)
        Me.txtLpass.Name = "txtLpass"
        Me.txtLpass.Size = New System.Drawing.Size(60, 20)
        Me.txtLpass.TabIndex = 24
        '
        'BtnLagregar
        '
        Me.BtnLagregar.Location = New System.Drawing.Point(25, 244)
        Me.BtnLagregar.Name = "BtnLagregar"
        Me.BtnLagregar.Size = New System.Drawing.Size(75, 40)
        Me.BtnLagregar.TabIndex = 23
        Me.BtnLagregar.Text = "Agregar"
        Me.BtnLagregar.UseVisualStyleBackColor = True
        '
        'lblpass
        '
        Me.lblpass.AutoSize = True
        Me.lblpass.Location = New System.Drawing.Point(223, 176)
        Me.lblpass.Name = "lblpass"
        Me.lblpass.Size = New System.Drawing.Size(30, 13)
        Me.lblpass.TabIndex = 23
        Me.lblpass.Text = "Pass"
        '
        'txtLusername
        '
        Me.txtLusername.Location = New System.Drawing.Point(96, 192)
        Me.txtLusername.Name = "txtLusername"
        Me.txtLusername.Size = New System.Drawing.Size(124, 20)
        Me.txtLusername.TabIndex = 22
        '
        'lblLusername
        '
        Me.lblLusername.AutoSize = True
        Me.lblLusername.Location = New System.Drawing.Point(93, 176)
        Me.lblLusername.Name = "lblLusername"
        Me.lblLusername.Size = New System.Drawing.Size(55, 13)
        Me.lblLusername.TabIndex = 21
        Me.lblLusername.Text = "Username"
        '
        'txtLid_user
        '
        Me.txtLid_user.Location = New System.Drawing.Point(15, 193)
        Me.txtLid_user.Name = "txtLid_user"
        Me.txtLid_user.Size = New System.Drawing.Size(70, 20)
        Me.txtLid_user.TabIndex = 20
        '
        'lblLid_user
        '
        Me.lblLid_user.AutoSize = True
        Me.lblLid_user.Location = New System.Drawing.Point(12, 177)
        Me.lblLid_user.Name = "lblLid_user"
        Me.lblLid_user.Size = New System.Drawing.Size(54, 13)
        Me.lblLid_user.TabIndex = 12
        Me.lblLid_user.Text = "ID_USER"
        '
        'dgvLogin
        '
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvLogin.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvLogin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvLogin.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID_USER, Me.USERNAME, Me.PASS})
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvLogin.DefaultCellStyle = DataGridViewCellStyle5
        Me.dgvLogin.Location = New System.Drawing.Point(15, 19)
        Me.dgvLogin.Name = "dgvLogin"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvLogin.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.dgvLogin.Size = New System.Drawing.Size(343, 150)
        Me.dgvLogin.TabIndex = 0
        '
        'ID_USER
        '
        Me.ID_USER.HeaderText = "ID_USER"
        Me.ID_USER.Name = "ID_USER"
        Me.ID_USER.Width = 65
        '
        'USERNAME
        '
        Me.USERNAME.HeaderText = "USERNAME"
        Me.USERNAME.Name = "USERNAME"
        Me.USERNAME.Width = 120
        '
        'PASS
        '
        Me.PASS.HeaderText = "PASS"
        Me.PASS.Name = "PASS"
        '
        'GestionRRHH
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1097, 519)
        Me.Controls.Add(Me.gbLogin)
        Me.Controls.Add(Me.gbEmpleados)
        Me.Name = "GestionRRHH"
        Me.Text = "GestionRRHH"
        Me.gbEmpleados.ResumeLayout(False)
        Me.gbEmpleados.PerformLayout()
        CType(Me.dgvEmpleados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbLogin.ResumeLayout(False)
        Me.gbLogin.PerformLayout()
        CType(Me.dgvLogin, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gbEmpleados As System.Windows.Forms.GroupBox
    Friend WithEvents txtEapellido As System.Windows.Forms.TextBox
    Friend WithEvents lblEapellido As System.Windows.Forms.Label
    Friend WithEvents txtEnombre As System.Windows.Forms.TextBox
    Friend WithEvents lblENombre As System.Windows.Forms.Label
    Friend WithEvents lblID_DPTO As System.Windows.Forms.Label
    Friend WithEvents lblEID_EM As System.Windows.Forms.Label
    Friend WithEvents dgvEmpleados As System.Windows.Forms.DataGridView
    Friend WithEvents cbID_DPTO As System.Windows.Forms.ComboBox
    Friend WithEvents lblCorreo As System.Windows.Forms.Label
    Friend WithEvents mtEtelefono As System.Windows.Forms.MaskedTextBox
    Friend WithEvents lblEdad As System.Windows.Forms.Label
    Friend WithEvents lbleTelefono As System.Windows.Forms.Label
    Friend WithEvents txtEdireccion As System.Windows.Forms.TextBox
    Friend WithEvents lblEdireccion As System.Windows.Forms.Label
    Friend WithEvents txtEcorreo As System.Windows.Forms.TextBox
    Friend WithEvents mtID_EM As System.Windows.Forms.MaskedTextBox
    Friend WithEvents mtEdad As System.Windows.Forms.MaskedTextBox
    Friend WithEvents ID_CTR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ID_EMPLEADO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ID_DPTO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NOMBRE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents APELLIDO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TELEFONO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EDAD As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CORREO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DIRECCION As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents gbLogin As System.Windows.Forms.GroupBox
    Friend WithEvents dgvLogin As System.Windows.Forms.DataGridView
    Friend WithEvents btnEeliminar As System.Windows.Forms.Button
    Friend WithEvents btnEModificar As System.Windows.Forms.Button
    Friend WithEvents btnEAgregar As System.Windows.Forms.Button
    Friend WithEvents btnLeliminar As System.Windows.Forms.Button
    Friend WithEvents btnLmodificar As System.Windows.Forms.Button
    Friend WithEvents txtLpass As System.Windows.Forms.TextBox
    Friend WithEvents BtnLagregar As System.Windows.Forms.Button
    Friend WithEvents lblpass As System.Windows.Forms.Label
    Friend WithEvents txtLusername As System.Windows.Forms.TextBox
    Friend WithEvents lblLusername As System.Windows.Forms.Label
    Friend WithEvents txtLid_user As System.Windows.Forms.TextBox
    Friend WithEvents lblLid_user As System.Windows.Forms.Label
    Friend WithEvents ID_USER As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents USERNAME As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PASS As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cbLtipouser As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
