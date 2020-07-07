<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Arreglos
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
        Me.TimerOcultar = New System.Windows.Forms.Timer(Me.components)
        Me.TimerMostrar = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.cmbPrecio = New System.Windows.Forms.ComboBox()
        Me.btnPrecio = New System.Windows.Forms.Button()
        Me.cmbPC = New System.Windows.Forms.ComboBox()
        Me.btnGenerar = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cmbCompu = New System.Windows.Forms.ComboBox()
        Me.btnSolicitar = New System.Windows.Forms.Button()
        Me.txtCant = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btnRegistrar = New System.Windows.Forms.Button()
        Me.txtIngresar = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.txtCantidadB = New System.Windows.Forms.TextBox()
        Me.txtPrecioB = New System.Windows.Forms.TextBox()
        Me.txtModeloB = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtMarca = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnVender = New System.Windows.Forms.Button()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.txtVender = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnRegresar = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.GroupBox1.Controls.Add(Me.btnLimpiar)
        Me.GroupBox1.Controls.Add(Me.cmbPrecio)
        Me.GroupBox1.Controls.Add(Me.btnPrecio)
        Me.GroupBox1.Controls.Add(Me.cmbPC)
        Me.GroupBox1.Controls.Add(Me.btnGenerar)
        Me.GroupBox1.Location = New System.Drawing.Point(37, 10)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(261, 285)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Unidimensional"
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Location = New System.Drawing.Point(93, 245)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(75, 23)
        Me.btnLimpiar.TabIndex = 4
        Me.btnLimpiar.Text = "Limpiar" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'cmbPrecio
        '
        Me.cmbPrecio.FormattingEnabled = True
        Me.cmbPrecio.Location = New System.Drawing.Point(77, 202)
        Me.cmbPrecio.Name = "cmbPrecio"
        Me.cmbPrecio.Size = New System.Drawing.Size(121, 21)
        Me.cmbPrecio.TabIndex = 3
        '
        'btnPrecio
        '
        Me.btnPrecio.Location = New System.Drawing.Point(36, 148)
        Me.btnPrecio.Name = "btnPrecio"
        Me.btnPrecio.Size = New System.Drawing.Size(132, 23)
        Me.btnPrecio.TabIndex = 2
        Me.btnPrecio.Text = "Precio" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.btnPrecio.UseVisualStyleBackColor = True
        '
        'cmbPC
        '
        Me.cmbPC.FormattingEnabled = True
        Me.cmbPC.Location = New System.Drawing.Point(77, 96)
        Me.cmbPC.Name = "cmbPC"
        Me.cmbPC.Size = New System.Drawing.Size(121, 21)
        Me.cmbPC.TabIndex = 1
        '
        'btnGenerar
        '
        Me.btnGenerar.Location = New System.Drawing.Point(36, 42)
        Me.btnGenerar.Name = "btnGenerar"
        Me.btnGenerar.Size = New System.Drawing.Size(132, 23)
        Me.btnGenerar.TabIndex = 0
        Me.btnGenerar.Text = "Generar computador" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.btnGenerar.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.GroupBox2.Controls.Add(Me.cmbCompu)
        Me.GroupBox2.Controls.Add(Me.btnSolicitar)
        Me.GroupBox2.Controls.Add(Me.txtCant)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Location = New System.Drawing.Point(37, 322)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(261, 226)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Dinámico"
        '
        'cmbCompu
        '
        Me.cmbCompu.FormattingEnabled = True
        Me.cmbCompu.Location = New System.Drawing.Point(99, 167)
        Me.cmbCompu.Name = "cmbCompu"
        Me.cmbCompu.Size = New System.Drawing.Size(121, 21)
        Me.cmbCompu.TabIndex = 3
        '
        'btnSolicitar
        '
        Me.btnSolicitar.Location = New System.Drawing.Point(99, 112)
        Me.btnSolicitar.Name = "btnSolicitar"
        Me.btnSolicitar.Size = New System.Drawing.Size(75, 23)
        Me.btnSolicitar.TabIndex = 2
        Me.btnSolicitar.Text = "Solicitar" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.btnSolicitar.UseVisualStyleBackColor = True
        '
        'txtCant
        '
        Me.txtCant.Location = New System.Drawing.Point(99, 49)
        Me.txtCant.Name = "txtCant"
        Me.txtCant.Size = New System.Drawing.Size(100, 20)
        Me.txtCant.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(27, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Cantidad PC"
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GroupBox3.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.GroupBox3.Controls.Add(Me.btnRegistrar)
        Me.GroupBox3.Controls.Add(Me.txtIngresar)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Location = New System.Drawing.Point(324, 10)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(260, 144)
        Me.GroupBox3.TabIndex = 4
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Cantidad Ingresar"
        '
        'btnRegistrar
        '
        Me.btnRegistrar.Location = New System.Drawing.Point(67, 94)
        Me.btnRegistrar.Name = "btnRegistrar"
        Me.btnRegistrar.Size = New System.Drawing.Size(132, 23)
        Me.btnRegistrar.TabIndex = 5
        Me.btnRegistrar.Text = "Registrar" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.btnRegistrar.UseVisualStyleBackColor = True
        '
        'txtIngresar
        '
        Me.txtIngresar.Location = New System.Drawing.Point(99, 49)
        Me.txtIngresar.Name = "txtIngresar"
        Me.txtIngresar.Size = New System.Drawing.Size(100, 20)
        Me.txtIngresar.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(27, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Cantidad PC"
        '
        'GroupBox4
        '
        Me.GroupBox4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GroupBox4.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.GroupBox4.Controls.Add(Me.btnBuscar)
        Me.GroupBox4.Controls.Add(Me.txtCantidadB)
        Me.GroupBox4.Controls.Add(Me.txtPrecioB)
        Me.GroupBox4.Controls.Add(Me.txtModeloB)
        Me.GroupBox4.Controls.Add(Me.Label6)
        Me.GroupBox4.Controls.Add(Me.Label5)
        Me.GroupBox4.Controls.Add(Me.Label4)
        Me.GroupBox4.Controls.Add(Me.txtMarca)
        Me.GroupBox4.Controls.Add(Me.Label3)
        Me.GroupBox4.Location = New System.Drawing.Point(324, 185)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(260, 192)
        Me.GroupBox4.TabIndex = 5
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Buscar"
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(162, 19)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(81, 23)
        Me.btnBuscar.TabIndex = 6
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'txtCantidadB
        '
        Me.txtCantidadB.Location = New System.Drawing.Point(99, 151)
        Me.txtCantidadB.Name = "txtCantidadB"
        Me.txtCantidadB.Size = New System.Drawing.Size(100, 20)
        Me.txtCantidadB.TabIndex = 11
        '
        'txtPrecioB
        '
        Me.txtPrecioB.Location = New System.Drawing.Point(99, 117)
        Me.txtPrecioB.Name = "txtPrecioB"
        Me.txtPrecioB.Size = New System.Drawing.Size(100, 20)
        Me.txtPrecioB.TabIndex = 10
        '
        'txtModeloB
        '
        Me.txtModeloB.Location = New System.Drawing.Point(99, 83)
        Me.txtModeloB.Name = "txtModeloB"
        Me.txtModeloB.Size = New System.Drawing.Size(100, 20)
        Me.txtModeloB.TabIndex = 9
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(27, 154)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(49, 26)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Cantidad" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(27, 86)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(42, 13)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Modelo" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(27, 120)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(37, 26)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Precio" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'txtMarca
        '
        Me.txtMarca.Location = New System.Drawing.Point(99, 49)
        Me.txtMarca.Name = "txtMarca"
        Me.txtMarca.Size = New System.Drawing.Size(100, 20)
        Me.txtMarca.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(27, 52)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Marca" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'btnVender
        '
        Me.btnVender.Location = New System.Drawing.Point(126, 87)
        Me.btnVender.Name = "btnVender"
        Me.btnVender.Size = New System.Drawing.Size(85, 23)
        Me.btnVender.TabIndex = 5
        Me.btnVender.Text = "Vender"
        Me.btnVender.UseVisualStyleBackColor = True
        '
        'GroupBox5
        '
        Me.GroupBox5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GroupBox5.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.GroupBox5.Controls.Add(Me.txtVender)
        Me.GroupBox5.Controls.Add(Me.Label7)
        Me.GroupBox5.Controls.Add(Me.btnVender)
        Me.GroupBox5.Location = New System.Drawing.Point(324, 400)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(260, 148)
        Me.GroupBox5.TabIndex = 6
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Vender"
        '
        'txtVender
        '
        Me.txtVender.Location = New System.Drawing.Point(111, 36)
        Me.txtVender.Name = "txtVender"
        Me.txtVender.Size = New System.Drawing.Size(100, 20)
        Me.txtVender.TabIndex = 13
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(16, 39)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(89, 26)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Cantidad Vender:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'btnRegresar
        '
        Me.btnRegresar.Location = New System.Drawing.Point(509, 562)
        Me.btnRegresar.Name = "btnRegresar"
        Me.btnRegresar.Size = New System.Drawing.Size(75, 23)
        Me.btnRegresar.TabIndex = 7
        Me.btnRegresar.Text = "Regresar"
        Me.btnRegresar.UseVisualStyleBackColor = True
        '
        'Arreglos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(616, 597)
        Me.Controls.Add(Me.btnRegresar)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Arreglos"
        Me.Text = "Arreglos"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TimerOcultar As Timer
    Friend WithEvents TimerMostrar As Timer
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnGenerar As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents cmbPC As ComboBox
    Friend WithEvents cmbPrecio As ComboBox
    Friend WithEvents btnPrecio As Button
    Friend WithEvents cmbCompu As ComboBox
    Friend WithEvents btnSolicitar As Button
    Friend WithEvents txtCant As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents btnRegistrar As Button
    Friend WithEvents txtIngresar As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents txtCantidadB As TextBox
    Friend WithEvents txtPrecioB As TextBox
    Friend WithEvents txtModeloB As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btnVender As Button
    Friend WithEvents txtMarca As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btnBuscar As Button
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents txtVender As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents btnRegresar As Button
End Class
