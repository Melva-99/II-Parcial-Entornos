
Public Class Arreglos
    Private mComputadoras(,) As String
    Private cantComputadoras As Integer
    Private index As Byte
    Private encuentra As Boolean = False
    Private Sub btnGenerar_Click(sender As Object, e As EventArgs) Handles btnGenerar.Click
        Dim computadoras(3) As String
        computadoras(0) = "Toshiba"
        computadoras(1) = "Dell"
        computadoras(2) = "Asus"
        computadoras(3) = "MAC"

        For i = 0 To (computadoras.Length - 1) Step 1
            cmbPC.Items.Add(computadoras(i))
        Next
    End Sub

    Private Sub btnPrecio_Click(sender As Object, e As EventArgs) Handles btnPrecio.Click
        Dim precio(3) As Integer
        precio(0) = 22500
        precio(1) = 21000
        precio(2) = 29000
        precio(3) = 42000
        For i = 0 To (precio.Length - 1) Step 1
            cmbPrecio.Items.Add(precio(i))
        Next
    End Sub

    Private Sub btnSolicitar_Click(sender As Object, e As EventArgs) Handles btnSolicitar.Click
        Dim cant As Integer
        Dim comp() As String
        cant = Val(txtCant.Text)

        ReDim comp(cant)

        For i = 0 To (comp.Length - 1) Step 1
            comp(i) = InputBox("Ingrese la marca de la PC", "Ingreso")
        Next
        For j = 0 To (comp.Length - 1) Step 1
            cmbCompu.Items.Add(comp(j))
        Next
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        cmbPrecio.Items.Clear()
        cmbPC.Items.Clear()
    End Sub

    Private Sub Arreglos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtModeloB.Enabled = False
        txtPrecioB.Enabled = False
        txtCantidadB.Enabled = False
        btnBuscar.Enabled = False
        btnVender.Enabled = False
    End Sub

    Private Sub btnRegistrar_Click(sender As Object, e As EventArgs) Handles btnRegistrar.Click
        If IsNumeric(txtIngresar.Text) Then
            cantComputadoras = Val(txtIngresar.Text)
            ReDim mComputadoras(cantComputadoras, 3)
            For i = 0 To (cantComputadoras - 1) Step 1
                mComputadoras(i, 0) = InputBox("Ingrese la marca N." & (i + 1), "Registro").ToUpper()
                mComputadoras(i, 1) = InputBox("Ingrese el modelo N." & (i + 1), "Registro")
                mComputadoras(i, 2) = InputBox("Ingrese el precio N." & (i + 1), "Registro")
                mComputadoras(i, 3) = InputBox("Ingrese la cantidad N." & (i + 1), "Registro")
                index = i
            Next
            btnBuscar.Enabled = True
        Else
            MessageBox.Show("Por favor ingrese un valor numerico", "Datos erroneos", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Dim marca As String
        marca = txtMarca.Text
        For i = 0 To (cantComputadoras - 1) Step 1
            If (mComputadoras(i, 0) = marca.ToUpper()) Then
                mostrarDatos(i)
                index = i
                encuentra = True
            End If
            If (encuentra = False) Then
                MessageBox.Show("No existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtModeloB.Text = ""
                txtPrecioB.Text = ""
                txtCantidadB.Text = ""
                encuentra = False
            End If
        Next
    End Sub

    Private Sub btnVender_Click(sender As Object, e As EventArgs) Handles btnVender.Click
        Dim CantVender, Stock As Integer
        CantVender = Val(txtVender.text)
        Stock = mComputadoras(index, 3)
        If (CantVender > Stock) Then
            MessageBox.Show("Sin stock", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            mComputadoras(index, 3) = Stock - CantVender
            MessageBox.Show("Venta Realizada", "Venta", MessageBoxButtons.OK, MessageBoxIcon.Information)
            mostrarDatos(index)
        End If
    End Sub

    Public Sub mostrarDatos(ByVal indice)
        txtMarca.Text = mComputadoras(indice, 0)
        txtModeloB.Text = mComputadoras(indice, 1)
        txtPrecioB.Text = mComputadoras(indice, 2)
        txtCantidadB.Text = mComputadoras(indice, 3)
    End Sub

    Private Sub btnRegresar_Click(sender As Object, e As EventArgs) Handles btnRegresar.Click
        MenuPrincipal.Show()
        Me.Hide()
    End Sub
End Class
