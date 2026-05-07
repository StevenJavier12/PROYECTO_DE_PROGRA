using Microsoft.Data.SqlClient;
using PROSERA.Entidades;
using System.Data;

namespace PROSERA.Datos
{
    public class ProveedorDAL : IProveedorDAL
    {
        public void Guardar(Proveedor proveedor)
        {
            using SqlConnection cn = new(ConexionDB.Cadena);
            cn.Open();

            const string SQL = @"INSERT INTO Proveedores 
                                (nombre_empresa, contacto, telefono, direccion, correo)
                                VALUES (@nombre_empresa, @contacto, @telefono, @direccion, @correo)";

            using SqlCommand cmd = new(SQL, cn);
            cmd.Parameters.Add("@nombre_empresa", SqlDbType.VarChar, 100).Value = proveedor.NombreEmpresa;
            cmd.Parameters.Add("@contacto", SqlDbType.VarChar, 100).Value = proveedor.Contacto;
            cmd.Parameters.Add("@telefono", SqlDbType.VarChar, 20).Value = proveedor.Telefono;
            cmd.Parameters.Add("@direccion", SqlDbType.VarChar, 200).Value = proveedor.Direccion;
            cmd.Parameters.Add("@correo", SqlDbType.VarChar, 100).Value = proveedor.Correo;

            cmd.ExecuteNonQuery();
        }

        public void Editar(Proveedor proveedor)
        {
            using SqlConnection cn = new(ConexionDB.Cadena);
            cn.Open();

            const string SQL = @"UPDATE Proveedores
                                SET nombre_empresa = @nombre_empresa,
                                    contacto = @contacto,
                                    telefono = @telefono,
                                    direccion = @direccion,
                                    correo = @correo
                                WHERE id_proveedor = @id_proveedor";

            using SqlCommand cmd = new(SQL, cn);
            cmd.Parameters.Add("@nombre_empresa", SqlDbType.VarChar, 100).Value = proveedor.NombreEmpresa;
            cmd.Parameters.Add("@contacto", SqlDbType.VarChar, 100).Value = proveedor.Contacto;
            cmd.Parameters.Add("@telefono", SqlDbType.VarChar, 20).Value = proveedor.Telefono;
            cmd.Parameters.Add("@direccion", SqlDbType.VarChar, 200).Value = proveedor.Direccion;
            cmd.Parameters.Add("@correo", SqlDbType.VarChar, 100).Value = proveedor.Correo;
            cmd.Parameters.Add("@id_proveedor", SqlDbType.Int).Value = proveedor.IdProveedor;

            cmd.ExecuteNonQuery();
        }

        public void Eliminar(int id)
        {
            using SqlConnection cn = new(ConexionDB.Cadena);
            cn.Open();

            const string SQL = "DELETE FROM Proveedores WHERE id_proveedor = @Id";
            using SqlCommand cmd = new(SQL, cn);
            cmd.Parameters.Add("@Id", SqlDbType.Int).Value = id;
            cmd.ExecuteNonQuery();
        }

        public bool ExistePorNombreEmpresa(string nombreEmpresa, int? excluirId = null)
        {
            using SqlConnection cn = new(ConexionDB.Cadena);
            cn.Open();

            string sql = "SELECT COUNT(*) FROM Proveedores WHERE nombre_empresa = @NombreEmpresa";
            if (excluirId.HasValue)
                sql += " AND id_proveedor <> @ExcluirId";

            using SqlCommand cmd = new(sql, cn);
            cmd.Parameters.Add("@NombreEmpresa", SqlDbType.VarChar, 100).Value = nombreEmpresa;
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

            const string SQL = "SELECT id_proveedor, nombre_empresa, contacto, telefono, direccion, correo FROM Proveedores";
            using SqlDataAdapter da = new(SQL, cn);
            da.Fill(table);
            return table;
        }

        public Proveedor? ObtenerPorId(int id)
        {
            using SqlConnection cn = new(ConexionDB.Cadena);
            cn.Open();

            const string SQL = "SELECT id_proveedor, nombre_empresa, contacto, telefono, direccion, correo FROM Proveedores WHERE id_proveedor = @Id";
            using SqlCommand cmd = new(SQL, cn);
            cmd.Parameters.Add("@Id", SqlDbType.Int).Value = id;

            using SqlDataReader dr = cmd.ExecuteReader();
            if (!dr.Read()) return null;

            return new Proveedor
            {
                IdProveedor = Convert.ToInt32(dr["id_proveedor"]),
                NombreEmpresa = dr["nombre_empresa"].ToString() ?? string.Empty,
                Contacto = dr["contacto"].ToString() ?? string.Empty,
                Telefono = dr["telefono"].ToString() ?? string.Empty,
                Direccion = dr["direccion"].ToString() ?? string.Empty,
                Correo = dr["correo"].ToString() ?? string.Empty
            };
        }
    }
}