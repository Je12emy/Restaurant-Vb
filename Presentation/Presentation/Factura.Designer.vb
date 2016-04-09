<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Factura
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
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
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.gbCaja.SuspendLayout()
        CType(Me.dgvCaja, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.gbCaja.Location = New System.Drawing.Point(21, 12)
        Me.gbCaja.Name = "gbCaja"
        Me.gbCaja.Size = New System.Drawing.Size(415, 219)
        Me.gbCaja.TabIndex = 18
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
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvCaja.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.dgvCaja.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCaja.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID_FACTURA, Me.MESA, Me.PRODUCTO, Me.CCANTIDAD, Me.CPRECIO, Me.TOTAL})
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvCaja.DefaultCellStyle = DataGridViewCellStyle8
        Me.dgvCaja.Location = New System.Drawing.Point(6, 19)
        Me.dgvCaja.Name = "dgvCaja"
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvCaja.RowHeadersDefaultCellStyle = DataGridViewCellStyle9
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
        'Timer1
        '
        Me.Timer1.Interval = 1
        '
        'Factura
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(500, 262)
        Me.Controls.Add(Me.gbCaja)
        Me.Name = "Factura"
        Me.Text = "Factura"
        Me.gbCaja.ResumeLayout(False)
        Me.gbCaja.PerformLayout()
        CType(Me.dgvCaja, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gbCaja As System.Windows.Forms.GroupBox
    Friend WithEvents txtCproducto As System.Windows.Forms.TextBox
    Friend WithEvents btnceliminar As System.Windows.Forms.Button
    Friend WithEvents btnProcesar As System.Windows.Forms.Button
    Friend WithEvents lblctotal As System.Windows.Forms.Label
    Friend WithEvents txtCtotal As System.Windows.Forms.TextBox
    Friend WithEvents lblCmesa As System.Windows.Forms.Label
    Friend WithEvents dgvCaja As System.Windows.Forms.DataGridView
    Friend WithEvents ID_FACTURA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MESA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PRODUCTO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CCANTIDAD As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CPRECIO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TOTAL As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txtCmesa As System.Windows.Forms.TextBox
    Friend WithEvents PrintDocument1 As Drawing.Printing.PrintDocument
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
End Class
