using Microsoft.Data.SqlClient;
using PROSERA.Entidades;
using System.Data;

namespace PROSERA.Datos
{
    internal class EmpleadoDAL : IEmpleadoDAL
    {
        public void Guardar(Empleado empleado)
        {
            using SqlConnection cn = new(ConexionDB.Cadena);
            cn.Open();

            const string SQL = @"INSERT INTO Empleados 
                                (nombre, apellido, cargo, telefono, correo, direccion, dui)
                                VALUES (@nombre, @apellido, @cargo, @telefono, @correo, @direccion, @dui)";

            using SqlCommand cmd = new(SQL, cn);
            cmd.Parameters.Add("@nombre", SqlDbType.VarChar, 100).Value = empleado.Nombre;
            cmd.Parameters.Add("@apellido", SqlDbType.VarChar, 100).Value = empleado.Apellido;
            cmd.Parameters.Add("@cargo", SqlDbType.VarChar, 50).Value = empleado.Cargo;
            cmd.Parameters.Add("@telefono", SqlDbType.VarChar, 10).Value = empleado.Telefono;
            cmd.Parameters.Add("@correo", SqlDbType.VarChar, 100).Value = empleado.Correo;
            cmd.Parameters.Add("@direccion", SqlDbType.VarChar, 150).Value = empleado.Direccion;
            cmd.Parameters.Add("@dui", SqlDbType.VarChar, 12).Value = empleado.Dui;

            cmd.ExecuteNonQuery();
        }

        public void Editar(Empleado empleado)
        {
            using SqlConnection cn = new(ConexionDB.Cadena);
            cn.Open();

            const string SQL = @"UPDATE Empleados
                                SET nombre = @nombre,
                                    apellido = @apellido,
                                    cargo = @cargo,
                                    telefono = @telefono,
                                    correo = @correo,
                                    direccion = @direccion,
                                    dui = @dui
                                WHERE id_empleado = @id_empleado";

            using SqlCommand cmd = new(SQL, cn);
            cmd.Parameters.Add("@nombre", SqlDbType.VarChar, 100).Value = empleado.Nombre;
            cmd.Parameters.Add("@apellido", SqlDbType.VarChar, 100).Value = empleado.Apellido;
            cmd.Parameters.Add("@cargo", SqlDbType.VarChar, 50).Value = empleado.Cargo;
            cmd.Parameters.Add("@telefono", SqlDbType.VarChar, 10).Value = empleado.Telefono;
            cmd.Parameters.Add("@correo", SqlDbType.VarChar, 100).Value = empleado.Correo;
            cmd.Parameters.Add("@direccion", SqlDbType.VarChar, 150).Value = empleado.Direccion;
            cmd.Parameters.Add("@dui", SqlDbType.VarChar, 12).Value = empleado.Dui;
            cmd.Parameters.Add("@id_empleado", SqlDbType.Int).Value = empleado.IdEmpleado;

            cmd.ExecuteNonQuery();
        }

        public void Eliminar(int id)
        {
            using SqlConnection cn = new(ConexionDB.Cadena);
            cn.Open();

            const string SQL = "DELETE FROM Empleados WHERE id_empleado = @Id";
            using SqlCommand cmd = new(SQL, cn);
            cmd.Parameters.Add("@Id", SqlDbType.Int).Value = id;
            cmd.ExecuteNonQuery();
        }

        public bool ExistePorDui(string dui, int? excluirId = null)
        {
            using SqlConnection cn = new(ConexionDB.Cadena);
            cn.Open();

            string sql = "SELECT COUNT(*) FROM Empleados WHERE dui = @Dui";
            if (excluirId.HasValue)
                sql += " AND id_empleado <> @ExcluirId";

            using SqlCommand cmd = new(sql, cn);
            cmd.Parameters.Add("@Dui", SqlDbType.VarChar, 12).Value = dui;
            if (excluirId.HasValue)
                cmd.Parameters.Add("@ExcluirId", SqlDbType.Int).Value = excluirId.Value;

            int count = (int)cmd.ExecuteScalar();
            return count > 0;
        }

        public DataTable Listar()
        {
            DataTable table = new();
            using SqlConnection cn = new(ConexionDB.Cadena);
            cn.Open();

            const string SQL = "SELECT id_empleado, nombre, apellido, cargo, telefono, correo, direccion, dui FROM Empleados";
            using SqlDataAdapter da = new(SQL, cn);
            da.Fill(table);
            return table;
        }

        public Empleado? ObtenerPorId(int id)
        {
            using SqlConnection cn = new(ConexionDB.Cadena);
            cn.Open();

            const string SQL = "SELECT id_empleado, nombre, apellido, cargo, telefono, correo, direccion, dui FROM Empleados WHERE id_empleado = @Id";
            using SqlCommand cmd = new(SQL, cn);
            cmd.Parameters.Add("@Id", SqlDbType.Int).Value = id;

            using SqlDataReader dr = cmd.ExecuteReader();
            if (!dr.Read()) return null;

            return new Empleado
            {
                IdEmpleado = Convert.ToInt32(dr["id_empleado"]),
                Nombre = dr["nombre"].ToString() ?? string.Empty,
                Apellido = dr["apellido"].ToString() ?? string.Empty,
                Cargo = dr["cargo"].ToString() ?? string.Empty,
                Telefono = dr["telefono"].ToString() ?? string.Empty,
                Correo = dr["correo"].ToString() ?? string.Empty,
                Direccion = dr["direccion"].ToString() ?? string.Empty,
                Dui = dr["dui"].ToString() ?? string.Empty
            };
        }
    }
}