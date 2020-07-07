Public Class frmLibretaAhorro
    Dim monto As Double
    Private Sub activarControles()
        txtNombre.Enabled = False
        txtMonto.Enabled = False
        btnAperturar.Enabled = False
        btnRetirar.Enabled = True
        btnDepositar.Enabled = True
    End Sub
    Private Sub desactivarControles()
        txtNombre.Enabled = True
        txtMonto.Enabled = True
        btnAperturar.Enabled = True
        btnRetirar.Enabled = False
        btnDepositar.Enabled = False
    End Sub
    Private Sub limpiar()
        desactivarControles()
        txtMonto.Clear()
        txtNombre.Clear()
        txtSaldo.Clear()
        lstRetiros.Items.Clear()
        lstDepositos.Items.Clear()

    End Sub

    Private Sub rmLibretaAhorro_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        desactivarControles()
    End Sub
    Private Sub mostrarSaldo()
        txtSaldo.Text = monto
    End Sub
    Private Sub btnAperturar_Click(sender As Object, e As EventArgs) Handles btnAperturar.Click
        Dim cliente As String
        cliente = txtNombre.Text
        monto = Val(txtMonto.Text)
        If (monto > 0) Then
            activarControles()
        Else
            MessageBox.Show("Monto inválido", "Ingresar Monto", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
    Private Function leer(mensaje As String)
        Dim cantidad As Double
        cantidad = InputBox("Ingrese un monto a " & mensaje, "Operación ")
        mostrarSaldo()
        Return cantidad
    End Function

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        limpiar()
    End Sub

    Private Sub btnDepositar_Click(sender As Object, e As EventArgs) Handles btnDepositar.Click
        Dim deposito As Double
        deposito = leer("Depositar")
        monto += deposito
        lstDepositos.Items.Add(deposito)
        mostrarSaldo()
    End Sub

    Private Sub btnRetirar_Click(sender As Object, e As EventArgs) Handles btnRetirar.Click
        Dim retirar As Double
        retirar = leer("Retirar")
        If (retirar > monto) Then
            MessageBox.Show("Saldo insuficiente", "Depósito", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            monto += retirar
            lstRetiros.Items.Add(retirar)
            mostrarSaldo()
        End If
    End Sub

    Private Sub btnRegresar_Click(sender As Object, e As EventArgs) Handles btnRegresar.Click
        MenuPrincipal.Show()
        Me.Hide()
    End Sub
End Class