Imports MySql.Data.MySqlClient
Public Class frmLogin
    Dim conexion As MySqlConnection = New MySqlConnection
    Dim cmd As New MySqlCommand
    Dim adaptador As New MySqlDataAdapter

    Private Sub btnIngresar_Click(sender As Object, e As EventArgs) Handles btnIngresar.Click
        conexion.ConnectionString = "server=localhost; database=usuarios_roles; Uid=root; pwd=123456789;"

        If (txtUsuario.Text <> "" And txtPass.Text <> "") Then

            Try
                conexion.Open()
                cmd.Connection = conexion
                cmd.CommandText = "SELECT * FROM usuarios WHERE nombreUsr=@nombre AND pass=@pass AND activo=1"
                cmd.Parameters.Clear()
                cmd.Parameters.AddWithValue("@nombre", txtUsuario.Text)
                cmd.Parameters.AddWithValue("@pass", txtPass.Text)
                cmd.Prepare()
                cmd.ExecuteNonQuery()
                Dim reader As MySqlDataReader
                reader = cmd.ExecuteReader()

                If (reader.HasRows) Then
                    Me.Hide()
                    frmMenu.Show()
                Else
                    MsgBox("Los datos ingresados no son correctos o el usuario está inactivo", , "Error")
                End If
                reader.Close()
                conexion.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            MsgBox("Debe ingresar un nombre de usuario y contraseña", , "Error")
        End If

    End Sub

    Private Sub btnRegistro_Click(sender As Object, e As EventArgs) Handles btnRegistro.Click
        Me.Hide()
        frmRegistro.Show()
        txtPass.Clear()
        txtUsuario.Clear()
    End Sub
End Class
