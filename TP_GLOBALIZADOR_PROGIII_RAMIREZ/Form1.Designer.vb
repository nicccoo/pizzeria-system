<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmExportar
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
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtVariedad = New System.Windows.Forms.TextBox()
        Me.DGVProductos = New System.Windows.Forms.DataGridView()
        Me.contextmenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ExportarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.pbBarra = New System.Windows.Forms.ProgressBar()
        Me.SFDExportar = New System.Windows.Forms.SaveFileDialog()
        CType(Me.DGVProductos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.contextmenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(28, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Variedad: "
        '
        'txtVariedad
        '
        Me.txtVariedad.Location = New System.Drawing.Point(89, 15)
        Me.txtVariedad.Name = "txtVariedad"
        Me.txtVariedad.Size = New System.Drawing.Size(335, 20)
        Me.txtVariedad.TabIndex = 1
        '
        'DGVProductos
        '
        Me.DGVProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVProductos.ContextMenuStrip = Me.contextmenu
        Me.DGVProductos.Location = New System.Drawing.Point(12, 50)
        Me.DGVProductos.Name = "DGVProductos"
        Me.DGVProductos.Size = New System.Drawing.Size(776, 359)
        Me.DGVProductos.TabIndex = 2
        '
        'contextmenu
        '
        Me.contextmenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExportarToolStripMenuItem})
        Me.contextmenu.Name = "contextmenu"
        Me.contextmenu.Size = New System.Drawing.Size(119, 26)
        '
        'ExportarToolStripMenuItem
        '
        Me.ExportarToolStripMenuItem.Name = "ExportarToolStripMenuItem"
        Me.ExportarToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ExportarToolStripMenuItem.Text = "Exportar"
        '
        'pbBarra
        '
        Me.pbBarra.Location = New System.Drawing.Point(12, 415)
        Me.pbBarra.Name = "pbBarra"
        Me.pbBarra.Size = New System.Drawing.Size(776, 23)
        Me.pbBarra.TabIndex = 3
        '
        'frmExportar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.pbBarra)
        Me.Controls.Add(Me.DGVProductos)
        Me.Controls.Add(Me.txtVariedad)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmExportar"
        Me.Text = "Exportar"
        CType(Me.DGVProductos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.contextmenu.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtVariedad As TextBox
    Friend WithEvents DGVProductos As DataGridView
    Friend WithEvents pbBarra As ProgressBar
    Friend WithEvents contextmenu As ContextMenuStrip
    Friend WithEvents ExportarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SFDExportar As SaveFileDialog
End Class
