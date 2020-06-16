Imports MySql.Data.MySqlClient
Public Class frmRegistro
    Dim conexionRegistro As MySqlConnection = New MySqlConnection
    Dim cmd As New MySqlCommand
    Dim adaptador As New MySqlDataAdapter

    Private Sub btnRegistrar_Click(sender As Object, e As EventArgs) Handles btnRegistrar.Click
        conexionRegistro.ConnectionString = "server=localhost; database=usuarios_roles; Uid=root; pwd=123456789;"
        Dim reader As MySqlDataReader
        If (txtNombre.Text <> "" And txtPass.Text <> "" And txtPass2.Text <> "") Then
            Try
                conexionRegistro.Open()
                cmd.Connection = conexionRegistro
                cmd.CommandText = "SELECT * FROM usuarios WHERE nombreUsr=@nombre"
                cmd.Parameters.Clear()
                cmd.Parameters.AddWithValue("@nombre", txtNombre.Text)
                cmd.Parameters.AddWithValue("@pass", txtPass.Text)
                cmd.Prepare()
                cmd.ExecuteNonQuery()
                reader = cmd.ExecuteReader()
                reader.Close()

                If (reader.HasRows) Then
                    MsgBox("El nombre de usuario ya existe", , "Error")
                Else
                    If (txtPass.Text = txtPass2.Text) Then
                        cmd.CommandText = "INSERT INTO usuarios(nombreUsr, pass, idRol, activo) VALUES (@nombre, @pass, 3, 0)"
                        cmd.Prepare()
                        cmd.ExecuteNonQuery()
                        Me.Close()
                        frmLogin.Show()
                        MsgBox("Se ha registrado el usuario con exito, un administrador debe activarlo posteriormente", , "Aviso")
                    Else
                        MsgBox("Las contraseñas no coinciden", , "Error")
                    End If
                End If

                conexionRegistro.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            MsgBox("Debe completar todos los campos", , "Error")
        End If
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Close()
        frmLogin.Show()
    End Sub
End Class