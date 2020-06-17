Imports MySql.Data.MySqlClient
Public Class frmMenu
    Dim conexion As MySqlConnection = New MySqlConnection
    Dim cmd As New MySqlCommand
    Dim adaptador As New MySqlDataAdapter
    Dim act As Boolean
    Dim idUsr As Integer


    Private Sub ActualizarSelect()
        Dim ds As DataSet = New DataSet
        Dim adaptador As MySqlDataAdapter = New MySqlDataAdapter

        conexion.ConnectionString = "server=localhost; database=usuarios_roles; Uid=root; pwd=123456789;"

        Try
            conexion.Open()
            cmd.Connection = conexion

            cmd.CommandText = "SELECT idUsuarios, nombreUsr, idRol, activo FROM usuarios ORDER BY idUsuarios ASC"
            adaptador.SelectCommand = cmd
            adaptador.Fill(ds, "Tabla")
            grdUsuarios.DataSource = ds
            grdUsuarios.DataMember = "Tabla"

            conexion.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub frmMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ActualizarSelect()
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
        frmLogin.Show()
        frmLogin.txtPass.Clear()
        frmLogin.txtUsuario.Clear()
    End Sub

    Private Sub btnActivar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnActivar.Click
        If (grdUsuarios.SelectedRows.Count > 0) Then
            act = grdUsuarios.Item("activo", grdUsuarios.SelectedRows(0).Index).Value
            idUsr = grdUsuarios.Item("idUsuarios", grdUsuarios.SelectedRows(0).Index).Value
        End If
        If act = False Then
            conexion.Open()
            cmd.Connection = conexion
            cmd.CommandText = "UPDATE usuarios SET activo='1' WHERE usuarios.idUsuarios=@idUsr"
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@idUsr", idUsr)
            cmd.Prepare()
            cmd.ExecuteNonQuery()
            MsgBox("El usuario ha sido activado", , "Notificacion")
            conexion.Close()
        Else
            MsgBox("El usuario seleccionado ya está activo", , "Error")
        End If

        ActualizarSelect()
    End Sub

    Private Sub btnDesactivar_Click(sender As Object, e As EventArgs) Handles btnDesactivar.Click
        If (grdUsuarios.SelectedRows.Count > 0) Then
            act = grdUsuarios.Item("activo", grdUsuarios.SelectedRows(0).Index).Value
            idUsr = grdUsuarios.Item("idUsuarios", grdUsuarios.SelectedRows(0).Index).Value
        End If
        If act = True Then
            conexion.Open()
            cmd.Connection = conexion
            cmd.CommandText = "UPDATE usuarios SET activo='0' WHERE usuarios.idUsuarios=@idUsr"
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@idUsr", idUsr)
            cmd.Prepare()
            cmd.ExecuteNonQuery()
            MsgBox("El usuario ha sido desactivado", , "Notificacion")
            conexion.Close()
        Else
            MsgBox("El usuario seleccionado ya está desactivado", , "Error")
        End If

        ActualizarSelect()
    End Sub

    Private Sub btnCambNom_Click(sender As Object, e As EventArgs) Handles btnCambNom.Click
        If (grdUsuarios.SelectedRows.Count > 0) Then
            idUsr = grdUsuarios.Item("idUsuarios", grdUsuarios.SelectedRows(0).Index).Value
            Dim nuevoNombre As String = InputBox("Introduzca el nuevo nombre para el usuario " & idUsr, "Cambio de nombre")
            If nuevoNombre <> "" Then
                If MessageBox.Show("¿Desea cambiar el nombre del usuario?", "Confirmacion", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.OK Then
                    conexion.Open()
                    cmd.CommandText = "UPDATE usuarios SET nombreUsr=@nombre WHERE usuarios.idUsuarios=@idUsr"
                    cmd.Parameters.Clear()
                    cmd.Parameters.AddWithValue("@nombre", nuevoNombre)
                    cmd.Parameters.AddWithValue("@idUsr", idUsr)
                    cmd.Prepare()
                    cmd.ExecuteNonQuery()
                    MsgBox("El nombre de usuario ha sido cambiado", , "Aviso")
                    conexion.Close()
                Else
                    MsgBox("Operacion cancelada", , "Aviso")
                End If
            Else
                MsgBox("Debe seleccionar un usuario", , "Error")
            End If
        End If

        ActualizarSelect()
    End Sub

    Private Sub btnCambPass_Click(sender As Object, e As EventArgs) Handles btnCambPass.Click
        If (grdUsuarios.SelectedRows.Count > 0) Then
            idUsr = grdUsuarios.Item("idUsuarios", grdUsuarios.SelectedRows(0).Index).Value
            Dim nuevaPass As String = InputBox("Introduzca una nueva constraseña para el usuario " & idUsr, "Cambio de contraseña")
            If nuevaPass <> "" Then
                If MessageBox.Show("¿Desea cambiar la contraseña del usuario?", "Confirmacion", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.OK Then
                    conexion.Open()
                    cmd.Connection = conexion
                    cmd.CommandText = "UPDATE usuarios SET pass=@pass WHERE usuarios.idUsuarios=@idUsr"
                    cmd.Parameters.Clear()
                    cmd.Parameters.AddWithValue("@idUsr", idUsr)
                    cmd.Parameters.AddWithValue("@pass", nuevaPass)
                    cmd.Prepare()
                    cmd.ExecuteNonQuery()
                    MsgBox("La contraseña del usuario " & idUsr & " ha sido actualizada", , "Aviso")
                    conexion.Close()
                Else
                    MsgBox("Operacion cancelada", , "Aviso")
                End If
            Else
                MsgBox("Operacion cancelada", , "Aviso")
            End If
        Else
            MsgBox("Debe seleccionar un usuario", , "Error")
        End If

        ActualizarSelect()
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If (grdUsuarios.SelectedRows.Count > 0) Then
            idUsr = grdUsuarios.Item("idUsuarios", grdUsuarios.SelectedRows(0).Index).Value
            If MessageBox.Show("¿Desea eliminar el usuario seleccionado?", "Eliminar usuario", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.OK Then
                conexion.Open()
                cmd.Connection = conexion
                cmd.CommandText = "DELETE FROM usuarios WHERE idUsuarios=@idUsr"
                cmd.Parameters.Clear()
                cmd.Parameters.AddWithValue("@idUsr", idUsr)
                cmd.Prepare()
                cmd.ExecuteNonQuery()
                MsgBox("El usuario " & idUsr & " ha sido eliminado", , "Aviso")
                conexion.Close()
            End If

        Else
                MsgBox("Debe seleccionar un usuario", , "Error")
        End If

        ActualizarSelect()
    End Sub
End Class