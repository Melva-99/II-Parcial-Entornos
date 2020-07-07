Imports System.ComponentModel

Public Class EntregaBolsaSolidaria
    Private mInfo(,) As String
    Private contador As Integer
    Private encuentra As Boolean = False

    Private Sub btnVerificar_Click(sender As Object, e As EventArgs) Handles btnVerificar.Click
        Dim filas As Integer = DGReporte.Rows.Count - 1
        Try
            For i = 0 To filas
                If txtID.Text = DGReporte.Rows(i).Cells(0).Value Then
                    MessageBox.Show("Ya existe ese id")
                    Exit Sub
                End If
            Next
            If Me.ValidateChildren And txtID.Text <> String.Empty And txtDepartamento.Text <> String.Empty And cmbEstado.Text <> String.Empty And cmbIntegrantes.Text <> String.Empty And txtDepartamento.Text <> String.Empty And txtMunicipio.Text <> String.Empty Then
                mInfo(contador, 0) = txtID.Text
                mInfo(contador, 1) = txtNombre.Text
                If (cmbEstado.Text = "Pobreza") Then
                    mInfo(contador, 3) = cmbEstado.Text
                Else
                    mInfo(contador, 3) = cmbEstado.Text
                End If

                If (cmbIntegrantes.Text = "1 - 3 personas") Then
                    chkBasica.Checked = True
                    chkRegular.Enabled = False
                    mInfo(contador, 2) = "1 - 3 personas"
                    mInfo(contador, 4) = "Básica"
                Else
                    chkRegular.Checked = True
                    chkBasica.Enabled = False
                    mInfo(contador, 2) = "Más de 3 personas"
                    mInfo(contador, 4) = "Regular"
                End If
                mInfo(contador, 5) = txtDireccion.Text
                mInfo(contador, 6) = txtDepartamento.Text
                mInfo(contador, 7) = txtMunicipio.Text
                DGReporte.Rows.Add(mInfo(contador, 0), mInfo(contador, 1), mInfo(contador, 2), mInfo(contador, 3), mInfo(contador, 4), mInfo(contador, 5), mInfo(contador, 6), mInfo(contador, 7))

                contador = contador + 1
            Else
                MessageBox.Show("Revise los datos Ingresados", "Error ", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub cmbIntegrantes_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbIntegrantes.SelectedIndexChanged
        If (cmbIntegrantes.Text = "1 - 3 personas") Then
            chkBasica.Checked = True
            chkBasica.Enabled = False
            chkRegular.Checked = False
            chkRegular.Enabled = False
        End If
        If (cmbIntegrantes.Text = "Más de 3 personas") Then
            chkRegular.Checked = True
            chkRegular.Enabled = False
            chkBasica.Checked = False
            chkBasica.Enabled = False
        End If
    End Sub

    Private Sub btnLimpiarD_Click(sender As Object, e As EventArgs) Handles btnLimpiarD.Click
        limpiar()
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        limpiar()
        DGReporte.Rows.Clear()
    End Sub

    Public Sub limpiar()
        txtID.Clear()
        txtNombre.Clear()
        cmbEstado.SelectedItem = ""
        cmbIntegrantes.SelectedItem = ""
        chkBasica.Checked = False
        chkRegular.Checked = False
        chkBasica.Enabled = True
        chkRegular.Enabled = True
        txtDireccion.Clear()
        txtDepartamento.Clear()
        txtMunicipio.Clear()
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        End
    End Sub

    Private Sub txtID_Validating(sender As Object, e As CancelEventArgs) Handles txtID.Validating
        If DirectCast(sender, TextBox).Text.Length = 13 Then
            Me.ErrorProvider1.SetError(sender, "")
        Else
            Me.ErrorProvider1.SetError(sender, "Debe ingresar el ID correcto")
        End If
    End Sub

    Private Sub txtNombre_Validating(sender As Object, e As CancelEventArgs) Handles txtNombre.Validating
        If DirectCast(sender, TextBox).Text.Length > 15 Then
            Me.ErrorProvider1.SetError(sender, "")
        Else
            Me.ErrorProvider1.SetError(sender, "Ingrese su nombre completo")
        End If
    End Sub

    Private Sub txtID_MouseHover(sender As Object, e As EventArgs) Handles txtID.MouseHover
        ToolTip1.SetToolTip(txtID, "Ingrese el número de identidad")
        ToolTip1.ToolTipTitle = "ID"
        ToolTip1.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtID_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtID.KeyPress
        If (Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57) Or Asc(e.KeyChar) = 8 Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub EntregaBolsaSolidaria_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ReDim mInfo(1000, 7)
        contador = 0
        chkBasica.Enabled = False
        chkRegular.Enabled = False
    End Sub

    Private Sub btnRegresar_Click(sender As Object, e As EventArgs) Handles btnRegresar.Click
        MenuPrincipal.Show()
        Me.Hide()
    End Sub
End Class