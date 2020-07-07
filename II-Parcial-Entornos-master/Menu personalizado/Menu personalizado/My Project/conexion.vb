﻿Imports System.Data
Imports System.Data.SqlClient
Imports System.Windows.Forms
Public Class conexion
    Public conexion As SqlConnection = New SqlConnection("Data Source= DESKTOP-IKI4BG5\MSSQLSERVER01;Initial Catalog=Ejemplo; Integrated Security=True")
    Private cmb As SqlCommandBuilder
    Public ds As DataSet = New DataSet()
    Public da As SqlDataAdapter
    Public comando As SqlCommand
    Public comand As SqlCommand
    Public comm As SqlCommand
    Public dv As New DataView
    Public adap As SqlDataAdapter
    Public datos2 As DataSet
    Public cmd As New SqlCommand

    Public Sub conectar()
        Try
            conexion.Open()
            MessageBox.Show("Conexión exitosa")
        Catch ex As Exception
            MessageBox.Show("Error conexion de base de datos")
        Finally
            conexion.Close()
        End Try
    End Sub

    Public Sub Llenar(ByVal sql, ByVal tabla)
        ds.Tables.Clear()
        da = New SqlDataAdapter(sql, conexion)
        cmb = New SqlCommandBuilder(da)
        da.Fill(ds, tabla)
        dv.Table = ds.Tables(0)
    End Sub

    Function insert(ByVal sql, ByVal ID)
        Dim reader As SqlDataReader
        Dim cont As Int32 = 0
        conexion.Open()
        comand = New SqlCommand("SELECT * FROM estudiante where codigo ='" + ID + "'", conexion)
        reader = comand.ExecuteReader()
        While reader.Read
            cont = cont + 1
        End While
        reader.Close()
        If cont = 0 Then
            comando = New SqlCommand(sql, conexion)
            Dim i As Integer = comando.ExecuteNonQuery()
            conexion.Close()
            If (i > 0) Then
                Return True

            End If
        Else
            conexion.Close()
            Return False
        End If
    End Function

    Function modificar(ByVal tabla, ByVal campos, ByVal condicion)
        conexion.Open()
        Dim modd As String = " update " + tabla + " set " + campos + " where " + condicion
        comando = New SqlCommand(modd, conexion)
        Dim i As Integer = comando.ExecuteNonQuery()
        conexion.Close()
        If (i > 0) Then
            Return True
            conexion.Close()
        Else
            Return False
            conexion.Close()
        End If
    End Function

    Function eliminar(ByVal tabla, ByVal condicion)
        conexion.Open()
        Dim elimina As String = " Delete from " + tabla + " where " + condicion
        comando = New SqlCommand(elimina, conexion)
        Dim i As String = comando.ExecuteNonQuery()
        conexion.Close()
        If (i > 0) Then
            Return True
            conexion.Close()
        Else
            Return False
            conexion.Close()
        End If
    End Function
    Function busqueda(ByVal tabla, ByVal condicion) As DataTable
        Try
            conexion.Open()
            Dim buscar As String = "select * from " + tabla + " where " + condicion
            Dim cmd As New SqlCommand(buscar, conexion)
            If cmd.ExecuteNonQuery Then
                Dim dt As New DataTable
                Dim da As New SqlDataAdapter(cmd)
                da.Fill(dt)
                Return dt
            Else
                Return Nothing
            End If
            conexion.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function
End Class
