<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Principal
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.AdministradorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GestionRRHHToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChefToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CocinaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MeseroToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReservacionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BodegaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DepositoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AdministradorToolStripMenuItem, Me.ChefToolStripMenuItem, Me.MeseroToolStripMenuItem, Me.BodegaToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1184, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'AdministradorToolStripMenuItem
        '
        Me.AdministradorToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GestionRRHHToolStripMenuItem})
        Me.AdministradorToolStripMenuItem.Name = "AdministradorToolStripMenuItem"
        Me.AdministradorToolStripMenuItem.Size = New System.Drawing.Size(95, 20)
        Me.AdministradorToolStripMenuItem.Text = "Administrador"
        '
        'GestionRRHHToolStripMenuItem
        '
        Me.GestionRRHHToolStripMenuItem.AutoToolTip = True
        Me.GestionRRHHToolStripMenuItem.Name = "GestionRRHHToolStripMenuItem"
        Me.GestionRRHHToolStripMenuItem.Size = New System.Drawing.Size(149, 22)
        Me.GestionRRHHToolStripMenuItem.Text = "Gestion RRHH"
        '
        'ChefToolStripMenuItem
        '
        Me.ChefToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CocinaToolStripMenuItem})
        Me.ChefToolStripMenuItem.Name = "ChefToolStripMenuItem"
        Me.ChefToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.ChefToolStripMenuItem.Text = "Chef"
        '
        'CocinaToolStripMenuItem
        '
        Me.CocinaToolStripMenuItem.Name = "CocinaToolStripMenuItem"
        Me.CocinaToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.CocinaToolStripMenuItem.Text = "Cocina"
        '
        'MeseroToolStripMenuItem
        '
        Me.MeseroToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ReservacionesToolStripMenuItem})
        Me.MeseroToolStripMenuItem.Name = "MeseroToolStripMenuItem"
        Me.MeseroToolStripMenuItem.Size = New System.Drawing.Size(58, 20)
        Me.MeseroToolStripMenuItem.Text = "Mesero"
        '
        'ReservacionesToolStripMenuItem
        '
        Me.ReservacionesToolStripMenuItem.Name = "ReservacionesToolStripMenuItem"
        Me.ReservacionesToolStripMenuItem.Size = New System.Drawing.Size(148, 22)
        Me.ReservacionesToolStripMenuItem.Text = "Reservaciones"
        '
        'BodegaToolStripMenuItem
        '
        Me.BodegaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DepositoToolStripMenuItem})
        Me.BodegaToolStripMenuItem.Name = "BodegaToolStripMenuItem"
        Me.BodegaToolStripMenuItem.Size = New System.Drawing.Size(59, 20)
        Me.BodegaToolStripMenuItem.Text = "Bodega"
        '
        'DepositoToolStripMenuItem
        '
        Me.DepositoToolStripMenuItem.Name = "DepositoToolStripMenuItem"
        Me.DepositoToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.DepositoToolStripMenuItem.Text = "Deposito"
        '
        'Principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1184, 562)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Principal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Principal"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents AdministradorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GestionRRHHToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ChefToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CocinaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MeseroToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReservacionesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BodegaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DepositoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
