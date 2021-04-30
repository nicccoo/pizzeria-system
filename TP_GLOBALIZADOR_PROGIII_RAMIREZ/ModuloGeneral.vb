Module ModuloGeneral
    Private Const CadenaConexion = "Data Source=localhost\SQLEXPRESS;Initial Catalog=Pizzeria;Integrated Security=True"

    Public Sub Ejecutar(ByVal sql As String)
        Dim Conexion As SqlClient.SqlConnection
        Dim Comando As SqlClient.SqlCommand

        Conexion = New SqlClient.SqlConnection
        Conexion.ConnectionString = CadenaConexion
        Conexion.Open()

        Comando = New SqlClient.SqlCommand
        Comando.Connection = Conexion
        Comando.CommandType = CommandType.Text
        Comando.CommandText = sql
        Comando.ExecuteNonQuery()

        Conexion.Close()

    End Sub

    Public Sub Recuperar(ByVal sql As String, ByRef Tabla As DataTable)
        Dim Conexion As SqlClient.SqlConnection
        Dim Comando As SqlClient.SqlCommand
        Tabla = New DataTable

        Conexion = New SqlClient.SqlConnection
        Conexion.ConnectionString = CadenaConexion
        Conexion.Open()

        Comando = New SqlClient.SqlCommand
        Comando.Connection = Conexion
        Comando.CommandType = CommandType.Text
        Comando.CommandText = sql
        Tabla.Load(Comando.ExecuteReader)

        Conexion.Close()

    End Sub

End Module
