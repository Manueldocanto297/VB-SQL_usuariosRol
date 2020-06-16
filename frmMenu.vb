Imports MySql.Data.MySqlClient
Public Class frmMenu
    Dim conexion As MySqlConnection = New MySqlConnection
    Dim cmd As New MySqlCommand
    Dim adaptador As New MySqlDataAdapter

    Private Sub ActualizarSelect()
        Dim ds As DataSet = New DataSet
        Dim adaptador As MySqlDataAdapter = New MySqlDataAdapter

        conexion.ConnectionString = "server=localhost; database=usuarios_roles; Uid=root; pwd=123456789;"

        Try
            conexion.Open()
            cmd.Connection = conexion

            cmd.CommandText = "SELECT * FROM usuarios ORDER BY idUsuarios ASC"
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
    End Sub
End Class