using Microsoft.Data.SqlClient;
using PROSERA.Entidades;
using System.Data;

namespace PROSERA.Datos
{
    internal class UsuarioDAL : IUsuarioDAL
    {
        public void Guardar(Usuario usuario)
        {
            using SqlConnection cn = new(ConexionDB.Cadena);
            cn.Open();

            const string SQL = @"INSERT INTO Usuarios 
                                (username, contraseña, rol, estadoUser, id_empleado)
                                VALUES (@username, @contraseña, @rol, @estadoUser, @id_empleado)";

            using SqlCommand cmd = new(SQL, cn);
            cmd.Parameters.Add("@username", SqlDbType.VarChar, 50).Value = usuario.Username;
            cmd.Parameters.Add("@contraseña", SqlDbType.VarChar, 100).Value = usuario.Contraseña;
            cmd.Parameters.Add("@rol", SqlDbType.VarChar, 50).Value = usuario.Rol;
            cmd.Parameters.Add("@estadoUser", SqlDbType.VarChar, 20).Value = usuario.EstadoUser;
            cmd.Parameters.Add("@id_empleado", SqlDbType.Int).Value = (object?)usuario.IdEmpleado ?? DBNull.Value;

            cmd.ExecuteNonQuery();
        }

        public void Editar(Usuario usuario)
        {
            using SqlConnection cn = new(ConexionDB.Cadena);
            cn.Open();

            const string SQL = @"UPDATE Usuarios
                                SET username = @username,
                                    contraseña = @contraseña,
                                    rol = @rol,
                                    estadoUser = @estadoUser,
                                    id_empleado = @id_empleado
                                WHERE id_usuario = @id_usuario";

            using SqlCommand cmd = new(SQL, cn);
            cmd.Parameters.Add("@username", SqlDbType.VarChar, 50).Value = usuario.Username;
            cmd.Parameters.Add("@contraseña", SqlDbType.VarChar, 100).Value = usuario.Contraseña;
            cmd.Parameters.Add("@rol", SqlDbType.VarChar, 50).Value = usuario.Rol;
            cmd.Parameters.Add("@estadoUser", SqlDbType.VarChar, 20).Value = usuario.EstadoUser;
            cmd.Parameters.Add("@id_empleado", SqlDbType.Int).Value = (object?)usuario.IdEmpleado ?? DBNull.Value;
            cmd.Parameters.Add("@id_usuario", SqlDbType.Int).Value = usuario.IdUsuario;

            cmd.ExecuteNonQuery();
        }

        public void Eliminar(int id)
        {
            using SqlConnection cn = new(ConexionDB.Cadena);
            cn.Open();

            const string SQL = "DELETE FROM Usuarios WHERE id_usuario = @Id";
            using SqlCommand cmd = new(SQL, cn);
            cmd.Parameters.Add("@Id", SqlDbType.Int).Value = id;
            cmd.ExecuteNonQuery();
        }

        public bool ExistePorUsername(string username, int? excluirId = null)
        {
            using SqlConnection cn = new(ConexionDB.Cadena);
            cn.Open();

            string sql = "SELECT COUNT(*) FROM Usuarios WHERE username = @Username";
            if (excluirId.HasValue)
                sql += " AND id_usuario <> @ExcluirId";

            using SqlCommand cmd = new(sql, cn);
            cmd.Parameters.Add("@Username", SqlDbType.VarChar, 50).Value = username;
            if (excluirId.HasValue)
                cmd.Parameters.Add("@ExcluirId", SqlDbType.Int).Value = excluirId.Value;

            int count = (int)cmd.ExecuteScalar();
            return count > 0;
        }

        public DataTable ListarConEmpleado()
        {
            DataTable table = new();
            using SqlConnection cn = new(ConexionDB.Cadena);
            cn.Open();

            const string SQL = @"SELECT u.id_usuario, u.username, u.contraseña, u.rol, u.estadoUser, 
                                        u.id_empleado, e.nombre + ' ' + e.apellido AS empleado_nombre
                                 FROM Usuarios u
                                 LEFT JOIN Empleados e ON u.id_empleado = e.id_empleado";

            using SqlDataAdapter da = new(SQL, cn);
            da.Fill(table);
            return table;
        }

        public Usuario? ObtenerPorId(int id)
        {
            using SqlConnection cn = new(ConexionDB.Cadena);
            cn.Open();

            const string SQL = @"SELECT u.id_usuario, u.username, u.contraseña, u.rol, u.estadoUser, 
                                        u.id_empleado, e.nombre, e.apellido, e.cargo, e.telefono, e.correo, e.direccion, e.dui
                                 FROM Usuarios u
                                 LEFT JOIN Empleados e ON u.id_empleado = e.id_empleado
                                 WHERE u.id_usuario = @Id";

            using SqlCommand cmd = new(SQL, cn);
            cmd.Parameters.Add("@Id", SqlDbType.Int).Value = id;

            using SqlDataReader dr = cmd.ExecuteReader();
            if (!dr.Read()) return null;

            var usuario = new Usuario
            {
                IdUsuario = Convert.ToInt32(dr["id_usuario"]),
                Username = dr["username"].ToString() ?? string.Empty,
                Contraseña = dr["contraseña"].ToString() ?? string.Empty,
                Rol = dr["rol"].ToString() ?? string.Empty,
                EstadoUser = dr["estadoUser"].ToString() ?? string.Empty,
                IdEmpleado = dr["id_empleado"] as int?
            };

            if (usuario.IdEmpleado.HasValue)
            {
                usuario.Empleado = new Empleado
                {
                    IdEmpleado = usuario.IdEmpleado.Value,
                    Nombre = dr["nombre"].ToString() ?? string.Empty,
                    Apellido = dr["apellido"].ToString() ?? string.Empty,
                    Cargo = dr["cargo"].ToString() ?? string.Empty,
                    Telefono = dr["telefono"].ToString() ?? string.Empty,
                    Correo = dr["correo"].ToString() ?? string.Empty,
                    Direccion = dr["direccion"].ToString() ?? string.Empty,
                    Dui = dr["dui"].ToString() ?? string.Empty
                };
            }

            return usuario;
        }
    }
}