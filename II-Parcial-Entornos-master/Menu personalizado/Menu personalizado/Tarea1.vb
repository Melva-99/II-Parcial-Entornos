Imports System.ComponentModel
Public Class Tarea1
    Private mClientes(,) As String
    Private contador, idC As Integer
    Private Mtotal As Double
    Private encuentra As Boolean = False
    Private Sub activarControles()
        txtCiudad.Enabled = True
        txtMontoT.Enabled = True
        btnRetirar.Enabled = True
        btnDepositar.Enabled = True
        txtCliente.Enabled = True
    End Sub

    Private Sub activarControles2()
        mtID.Enabled = True
    End Sub

    Private Sub desactiveControles()
        txtCliente.Enabled = False
        txtMontoT.Enabled = False
        btnRetirar.Enabled = False
        btnDepositar.Enabled = False
        mtID.Enabled = False
    End Sub

    Private Sub limpiarapertura()
        txtNombre.Clear()
        txtID.Clear()
        txtEdad.Clear()
        txtPais.Clear()
        txtCiudad.Clear()
        txtMonto.Clear()
    End Sub
    Private Sub limpiar()
        desactiveControles()
        txtNombre.Clear()
        txtID.Clear()
        txtEdad.Clear()
        txtPais.Clear()
        txtCiudad.Clear()
        txtMonto.Clear()
        txtCliente.Clear()
        txtMontoT.Clear()
        mtID.Clear()
    End Sub

    Private Sub frmTarea1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        desactiveControles()
        ReDim mClientes(1000, 5)
        contador = 0
        datainf.Columns.Add("Nombre", "Nombre")
        datainf.Columns.Add("ID", "ID")
        datainf.Columns.Add("Edad", "Edad")
        datainf.Columns.Add("Pais", "Pais")
        datainf.Columns.Add("Ciudad", "Ciudad")
        datainf.Columns.Add("Total", "Total")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Apertura de cuenta
        Try
            If Me.ValidateChildren And txtNombre.Text <> String.Empty And txtID.Text <> String.Empty And txtEdad.Text <> String.Empty And txtPais.Text <> String.Empty And txtCiudad.Text <> String.Empty And txtMonto.Text <> String.Empty Then
                mClientes(contador, 0) = txtNombre.Text
                mClientes(contador, 1) = txtID.Text
                If (txtEdad.Text > 0) And (txtEdad.Text < 120) Then
                    mClientes(contador, 2) = txtEdad.Text
                Else
                    MessageBox.Show("Ingrese su edad verdadera", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If

                mClientes(contador, 3) = txtPais.Text
                mClientes(contador, 4) = txtCiudad.Text
                If txtMonto.Text > 500 Then
                    mClientes(contador, 5) = txtMonto.Text
                Else
                    MessageBox.Show("La cantidad miníma es de L.500", "Deposite más", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If

                contador = contador + 1

                activarControles()
                activarControles2()
            Else
                MessageBox.Show("Revise los datos Ingresados", "Error ", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnRetirar_Click(sender As Object, e As EventArgs) Handles btnRetirar.Click

        idC = txtID.Text
        For i = 0 To (contador - 1) Step 1
            If (mClientes(i, 1) = idC) Then
                If (txtMontoT.Text < mClientes(i, 5)) Then
                    Mtotal = mClientes(i, 5) - txtMontoT.Text
                    mClientes(i, 5) = Mtotal
                    MsgBox("Su saldo es de: " & Mtotal)
                Else
                    MessageBox.Show("Saldo insuficiente", "Deposite más", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
        Next
    End Sub

    Private Sub btnDepositar_Click(sender As Object, e As EventArgs) Handles btnDepositar.Click
        idC = txtID.Text
        For i = 0 To (contador - 1) Step 1
            If (mClientes(i, 1) = idC) Then
                If (txtMontoT.Text > 0) Then
                    Mtotal = mClientes(i, 5) + txtMontoT.Text
                    mClientes(i, 5) = Mtotal
                    MsgBox("Su saldo es de: " & Mtotal)
                Else
                    MessageBox.Show("Ingrese una cantidad valida", "Deposite más", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    limpiarapertura()
                End If
            End If
        Next
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click

        idC = mtID.Text
        For i = 0 To (contador - 1) Step 1
            If (mClientes(i, 1) = idC) Then
                MessageBox.Show("Si se encuentra el id")
                datainf.Rows.Add(mClientes(i, 0), mClientes(i, 1), mClientes(i, 2), mClientes(i, 3), mClientes(i, 4), mClientes(i, 5))
                encuentra = True
            End If
            If (encuentra = False) Then
                MessageBox.Show("No existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                encuentra = False
            End If
        Next
    End Sub

    Private Sub brnSalir_Click(sender As Object, e As EventArgs) Handles brnSalir.Click
        End
    End Sub

    Private Sub btnLimpiarR_Click(sender As Object, e As EventArgs) Handles btnLimpiarR.Click
        limpiarapertura()
    End Sub

    Private Sub txtID_Validating(sender As Object, e As CancelEventArgs) Handles txtID.Validating
        If DirectCast(sender, TextBox).Text.Length = 13 Then
            Me.ErrorProvider1.SetError(sender, "")
        Else
            Me.ErrorProvider1.SetError(sender, "Debe ingresar el ID correcto")
        End If
    End Sub

    Private Sub mtID_Validating(sender As Object, e As CancelEventArgs) Handles mtID.Validating
        If DirectCast(sender, TextBox).Text.Length = 13 Then
            Me.ErrorProvider1.SetError(sender, "")
        Else
            Me.ErrorProvider1.SetError(sender, "Debe ingresar el ID correcto")
        End If
    End Sub

    Private Sub txtCliente_Validating(sender As Object, e As CancelEventArgs) Handles txtCliente.Validating
        If DirectCast(sender, TextBox).Text.Length = 13 Then
            Me.ErrorProvider1.SetError(sender, "")
        Else
            Me.ErrorProvider1.SetError(sender, "Debe ingresar el ID correcto")
        End If
    End Sub

    Private Sub txtID_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtID.KeyPress
        If (Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57) Or Asc(e.KeyChar) = 8 Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtCliente_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCliente.KeyPress
        If (Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57) Or Asc(e.KeyChar) = 8 Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub mtID_KeyPress(sender As Object, e As KeyPressEventArgs) Handles mtID.KeyPress
        If (Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57) Or Asc(e.KeyChar) = 8 Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub btnLimpiarV_Click(sender As Object, e As EventArgs) Handles btnLimpiarV.Click
        limpiar()
    End Sub

    Private Sub txtEdad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtEdad.KeyPress
        If (Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57) Or Asc(e.KeyChar) = 8 Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
End Class