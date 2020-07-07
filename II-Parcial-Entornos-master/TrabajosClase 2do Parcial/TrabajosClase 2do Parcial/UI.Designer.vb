<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UI
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UI))
        Me.PanelSuperior = New System.Windows.Forms.Panel()
        Me.btnRestaurar = New System.Windows.Forms.Button()
        Me.btnMinimisar = New System.Windows.Forms.Button()
        Me.btnMaximisar = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.PanelLateral = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnMenu = New System.Windows.Forms.PictureBox()
        Me.FlowLayoutPanel3 = New System.Windows.Forms.FlowLayoutPanel()
        Me.btnEmpleados = New System.Windows.Forms.Button()
        Me.FlowLayoutPanel2 = New System.Windows.Forms.FlowLayoutPanel()
        Me.btnClientes = New System.Windows.Forms.Button()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.btnProducto = New System.Windows.Forms.Button()
        Me.PanelForm = New System.Windows.Forms.Panel()
        Me.TimerOcultar = New System.Windows.Forms.Timer(Me.components)
        Me.TimerMostrar = New System.Windows.Forms.Timer(Me.components)
        Me.PanelSuperior.SuspendLayout()
        Me.PanelLateral.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnMenu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelSuperior
        '
        Me.PanelSuperior.BackColor = System.Drawing.SystemColors.HotTrack
        Me.PanelSuperior.Controls.Add(Me.btnRestaurar)
        Me.PanelSuperior.Controls.Add(Me.btnMinimisar)
        Me.PanelSuperior.Controls.Add(Me.btnMaximisar)
        Me.PanelSuperior.Controls.Add(Me.btnSalir)
        Me.PanelSuperior.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelSuperior.Location = New System.Drawing.Point(0, 0)
        Me.PanelSuperior.Name = "PanelSuperior"
        Me.PanelSuperior.Size = New System.Drawing.Size(825, 32)
        Me.PanelSuperior.TabIndex = 0
        '
        'btnRestaurar
        '
        Me.btnRestaurar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRestaurar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRestaurar.FlatAppearance.BorderSize = 0
        Me.btnRestaurar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.btnRestaurar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.btnRestaurar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRestaurar.Image = Global.TrabajosClase_2do_Parcial.My.Resources.Resources.Icono_Restaurar
        Me.btnRestaurar.Location = New System.Drawing.Point(754, 0)
        Me.btnRestaurar.Name = "btnRestaurar"
        Me.btnRestaurar.Size = New System.Drawing.Size(35, 32)
        Me.btnRestaurar.TabIndex = 3
        Me.btnRestaurar.UseVisualStyleBackColor = True
        Me.btnRestaurar.Visible = False
        '
        'btnMinimisar
        '
        Me.btnMinimisar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMinimisar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMinimisar.FlatAppearance.BorderSize = 0
        Me.btnMinimisar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.btnMinimisar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.btnMinimisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMinimisar.Image = Global.TrabajosClase_2do_Parcial.My.Resources.Resources.Icono_Minimizar
        Me.btnMinimisar.Location = New System.Drawing.Point(713, 0)
        Me.btnMinimisar.Name = "btnMinimisar"
        Me.btnMinimisar.Size = New System.Drawing.Size(35, 32)
        Me.btnMinimisar.TabIndex = 2
        Me.btnMinimisar.UseVisualStyleBackColor = True
        '
        'btnMaximisar
        '
        Me.btnMaximisar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMaximisar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMaximisar.FlatAppearance.BorderSize = 0
        Me.btnMaximisar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.btnMaximisar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.btnMaximisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMaximisar.Image = Global.TrabajosClase_2do_Parcial.My.Resources.Resources.Icono_Maximizar
        Me.btnMaximisar.Location = New System.Drawing.Point(749, 0)
        Me.btnMaximisar.Name = "btnMaximisar"
        Me.btnMaximisar.Size = New System.Drawing.Size(40, 32)
        Me.btnMaximisar.TabIndex = 1
        Me.btnMaximisar.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSalir.FlatAppearance.BorderSize = 0
        Me.btnSalir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.btnSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSalir.Image = Global.TrabajosClase_2do_Parcial.My.Resources.Resources.Icono_cerrar_FN
        Me.btnSalir.Location = New System.Drawing.Point(788, 0)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(34, 32)
        Me.btnSalir.TabIndex = 0
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'PanelLateral
        '
        Me.PanelLateral.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.PanelLateral.Controls.Add(Me.PictureBox1)
        Me.PanelLateral.Controls.Add(Me.Label1)
        Me.PanelLateral.Controls.Add(Me.btnMenu)
        Me.PanelLateral.Controls.Add(Me.FlowLayoutPanel3)
        Me.PanelLateral.Controls.Add(Me.btnEmpleados)
        Me.PanelLateral.Controls.Add(Me.FlowLayoutPanel2)
        Me.PanelLateral.Controls.Add(Me.btnClientes)
        Me.PanelLateral.Controls.Add(Me.FlowLayoutPanel1)
        Me.PanelLateral.Controls.Add(Me.btnProducto)
        Me.PanelLateral.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelLateral.Location = New System.Drawing.Point(0, 32)
        Me.PanelLateral.Name = "PanelLateral"
        Me.PanelLateral.Size = New System.Drawing.Size(165, 423)
        Me.PanelLateral.TabIndex = 1
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(2, 54)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(40, 42)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(46, 63)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(119, 24)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Mi empresa"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'btnMenu
        '
        Me.btnMenu.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMenu.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMenu.ErrorImage = Nothing
        Me.btnMenu.Image = CType(resources.GetObject("btnMenu.Image"), System.Drawing.Image)
        Me.btnMenu.Location = New System.Drawing.Point(129, 6)
        Me.btnMenu.Name = "btnMenu"
        Me.btnMenu.Size = New System.Drawing.Size(30, 32)
        Me.btnMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnMenu.TabIndex = 7
        Me.btnMenu.TabStop = False
        '
        'FlowLayoutPanel3
        '
        Me.FlowLayoutPanel3.BackColor = System.Drawing.SystemColors.Highlight
        Me.FlowLayoutPanel3.Location = New System.Drawing.Point(3, 256)
        Me.FlowLayoutPanel3.Name = "FlowLayoutPanel3"
        Me.FlowLayoutPanel3.Size = New System.Drawing.Size(8, 41)
        Me.FlowLayoutPanel3.TabIndex = 4
        '
        'btnEmpleados
        '
        Me.btnEmpleados.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEmpleados.FlatAppearance.BorderSize = 0
        Me.btnEmpleados.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.btnEmpleados.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.btnEmpleados.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEmpleados.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEmpleados.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnEmpleados.Image = CType(resources.GetObject("btnEmpleados.Image"), System.Drawing.Image)
        Me.btnEmpleados.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEmpleados.Location = New System.Drawing.Point(0, 256)
        Me.btnEmpleados.Name = "btnEmpleados"
        Me.btnEmpleados.Size = New System.Drawing.Size(165, 41)
        Me.btnEmpleados.TabIndex = 4
        Me.btnEmpleados.Text = "Empleados"
        Me.btnEmpleados.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnEmpleados.UseVisualStyleBackColor = True
        '
        'FlowLayoutPanel2
        '
        Me.FlowLayoutPanel2.BackColor = System.Drawing.SystemColors.Highlight
        Me.FlowLayoutPanel2.Location = New System.Drawing.Point(3, 189)
        Me.FlowLayoutPanel2.Name = "FlowLayoutPanel2"
        Me.FlowLayoutPanel2.Size = New System.Drawing.Size(8, 41)
        Me.FlowLayoutPanel2.TabIndex = 2
        '
        'btnClientes
        '
        Me.btnClientes.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClientes.FlatAppearance.BorderSize = 0
        Me.btnClientes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.btnClientes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.btnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClientes.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClientes.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnClientes.Image = CType(resources.GetObject("btnClientes.Image"), System.Drawing.Image)
        Me.btnClientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnClientes.Location = New System.Drawing.Point(0, 189)
        Me.btnClientes.Name = "btnClientes"
        Me.btnClientes.Size = New System.Drawing.Size(165, 41)
        Me.btnClientes.TabIndex = 3
        Me.btnClientes.Text = "Clientes"
        Me.btnClientes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnClientes.UseVisualStyleBackColor = True
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.BackColor = System.Drawing.SystemColors.Highlight
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(3, 122)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(8, 41)
        Me.FlowLayoutPanel1.TabIndex = 2
        '
        'btnProducto
        '
        Me.btnProducto.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnProducto.FlatAppearance.BorderSize = 0
        Me.btnProducto.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.btnProducto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.btnProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProducto.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnProducto.Image = CType(resources.GetObject("btnProducto.Image"), System.Drawing.Image)
        Me.btnProducto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnProducto.Location = New System.Drawing.Point(0, 122)
        Me.btnProducto.Name = "btnProducto"
        Me.btnProducto.Size = New System.Drawing.Size(165, 41)
        Me.btnProducto.TabIndex = 1
        Me.btnProducto.Text = "Productos"
        Me.btnProducto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnProducto.UseVisualStyleBackColor = True
        '
        'PanelForm
        '
        Me.PanelForm.BackColor = System.Drawing.SystemColors.Control
        Me.PanelForm.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelForm.Location = New System.Drawing.Point(165, 32)
        Me.PanelForm.Name = "PanelForm"
        Me.PanelForm.Size = New System.Drawing.Size(660, 423)
        Me.PanelForm.TabIndex = 2
        '
        'TimerOcultar
        '
        '
        'TimerMostrar
        '
        '
        'UI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(825, 455)
        Me.Controls.Add(Me.PanelForm)
        Me.Controls.Add(Me.PanelLateral)
        Me.Controls.Add(Me.PanelSuperior)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "UI"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.PanelSuperior.ResumeLayout(False)
        Me.PanelLateral.ResumeLayout(False)
        Me.PanelLateral.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnMenu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelSuperior As Panel
    Friend WithEvents PanelLateral As Panel
    Friend WithEvents PanelForm As Panel
    Friend WithEvents btnSalir As Button
    Friend WithEvents btnMinimisar As Button
    Friend WithEvents btnMaximisar As Button
    Friend WithEvents btnRestaurar As Button
    Friend WithEvents TimerOcultar As Timer
    Friend WithEvents TimerMostrar As Timer
    Friend WithEvents FlowLayoutPanel3 As FlowLayoutPanel
    Friend WithEvents btnEmpleados As Button
    Friend WithEvents FlowLayoutPanel2 As FlowLayoutPanel
    Friend WithEvents btnClientes As Button
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents btnProducto As Button
    Friend WithEvents btnMenu As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
End Class
