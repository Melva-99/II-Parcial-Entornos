Public Class Estudiante
    Dim conexion As New conexion()
    Dim dt As New DataTable
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim agregar As String = "insert into estudiante values('" + txtCodigo.Text + "','" + txtNombre.Text + "','" + txtPrimerApellido.Text + "','" + txtSegApellido.Text + "','" + txtEdad.Text + "','" + cmbSexo.Text + "','" + cmbCodigoClase.Text + "')"
        If (conexion.insert(agregar, txtCodigo.Text)) Then
            MessageBox.Show("Datos Agregados exitosamente")
            Llenar()
        Else
            MessageBox.Show("Datos existentes")
        End If
    End Sub

    Private Sub Estudiante_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexion.conectar()
        Llenar()
        dtgRegistros.DataSource = conexion.dv
    End Sub
    Private Sub Llenar()
        conexion.Llenar("Select * from estudiante", "estudiante")
        dtgRegistros.DataSource = conexion.ds.Tables("estudiante")
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        Dim update As String = "codigo='" + txtCodigo.Text + "', nombre='" + txtNombre.Text + "', primerApellido='" + txtPrimerApellido.Text + "', segundoApellido='" + txtSegApellido.Text + "', edad='" + txtEdad.Text + "', sexo='" + cmbSexo.Text + "', codigoClase='" + cmbCodigoClase.Text + "'"
        If (conexion.modificar(" estudiante ", update, " codigo= '" + txtCodigo.Text + "'")) Then
            MessageBox.Show("Se ha actualizado satisfactoriamente")
            Llenar()
        Else
            MessageBox.Show("Error al actualizar los datos")
        End If
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If (conexion.eliminar("estudiante", "codigo='" + txtCodigo.Text + "'")) Then
            MessageBox.Show("Datos Eliminados exitosamente")
            Llenar()
            Limpiar()
        Else
            MessageBox.Show("Error al eliminar datos")
        End If
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Try
            dt = conexion.busqueda(" estudiante ", " codigo like '%" + txtCodigo.Text + "%'")
            If dt.Rows.Count <> 0 Then
                dtgRegistros.DataSource = dt
                conexion.conexion.Close()
            Else
                dtgRegistros.DataSource = Nothing
                conexion.conexion.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Limpiar()
        txtCodigo.Clear()
        txtPrimerApellido.Clear()
        txtSegApellido.Clear()
        txtEdad.Clear()
        txtNombre.Clear()
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        Limpiar()
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        End
    End Sub

    Private Sub dtgRegistros_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtgRegistros.CellClick
        Dim FilaActual As Integer
        FilaActual = dtgRegistros.CurrentRow.Index
        txtCodigo.Text = dtgRegistros.Rows(FilaActual).Cells(0).Value
        txtNombre.Text = dtgRegistros.Rows(FilaActual).Cells(1).Value
        txtPrimerApellido.Text = dtgRegistros.Rows(FilaActual).Cells(2).Value
        txtSegApellido.Text = dtgRegistros.Rows(FilaActual).Cells(3).Value
        txtEdad.Text = dtgRegistros.Rows(FilaActual).Cells(4).Value
        cmbSexo.Text = dtgRegistros.Rows(FilaActual).Cells(5).Value
        cmbCodigoClase.Text = dtgRegistros.Rows(FilaActual).Cells(6).Value
    End Sub
End Class