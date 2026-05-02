using Microsoft.Data.SqlClient;
using PROSERA.Entidades;
using System.Data;
using System.Security.Cryptography;

namespace PROSERA.Datos
{
    internal class ClienteDAL : IClienteDAL
    {


        // datos de la entidad Cliente
        /*CREATE TABLE Clientes (
    id_cliente INT PRIMARY KEY IDENTITY,
    nombre VARCHAR(100) NOT NULL,
    apellido VARCHAR(100) NOT NULL,
    telefono VARCHAR(10) NOT NULL,
    direccion VARCHAR(200) NOT NULL,
    dui VARCHAR(12) NOT NULL UNIQUE,
    correo VARCHAR(100) NULL,
);
         */
        public void Editar(Cliente cliente)
        {
            using SqlConnection cn = new(ConexionDB.Cadena);
            cn.Open();



            const string SQL = @"UPDATE Clientes
                         SET nombre = @Nombre,
                             apellido = @Apellido,
                             telefono = @Telefono,
                             direccion = @Direccion,
                             dui = @Dui,
                             correo = @Correo
                       WHERE id_cliente = @IdCliente"; 
            using SqlCommand cmd = new(SQL, cn);
            cmd.Parameters.Add("@Nombre", SqlDbType.VarChar, 100).Value = cliente.Nombre;
            cmd.Parameters.Add("@Apellido", SqlDbType.VarChar, 100).Value = cliente.Apellido;
            cmd.Parameters.Add("@Telefono", SqlDbType.VarChar, 10).Value = cliente.Telefono;
            cmd.Parameters.Add("@Direccion", SqlDbType.VarChar, 200).Value = cliente.Direccion;
            cmd.Parameters.Add("@Dui", SqlDbType.VarChar, 12).Value = cliente.Dui;
            cmd.Parameters.Add("@Correo", SqlDbType.VarChar, 100).Value = cliente.Correo;
            cmd.Parameters.Add("@IdCliente", SqlDbType.Int).Value = cliente.IdCliente;

            cmd.ExecuteNonQuery();
        }


        //-----------------------------------------------------------------------------
        //-----------------------------------------------------------------------------
        public void Eliminar(int id)
        {
            using SqlConnection cn = new(ConexionDB.Cadena);
            cn.Open();

            const string SQL = "DELETE FROM Clientes WHERE id_cliente = @IdCliente";
            using SqlCommand cmd = new(SQL, cn);
            cmd.Parameters.Add("@IdCliente", SqlDbType.Int).Value = id;
            cmd.ExecuteNonQuery();
        }
        //-----------------------------------------------------------------------------
        //-----------------------------------------------------------------------------
        public bool ExistePorDui(string dui, int? excluirId = null)
        {
            using SqlConnection cn = new(ConexionDB.Cadena);
            cn.Open();

            string sql = "SELECT COUNT(*) FROM Clientes WHERE dui = @Dui AND nombre = @Nombre";
            if (excluirId.HasValue)
            {
                sql += " AND id_cliente <> @ExcluirId";
            }

            using SqlCommand cmd = new(sql, cn);
            cmd.Parameters.Add("@Dui", SqlDbType.VarChar, 12).Value = dui;
            cmd.Parameters.Add("@Nombre", SqlDbType.VarChar, 100).Value = dui;

            if (excluirId.HasValue)
            {
                cmd.Parameters.Add("@ExcluirId", SqlDbType.Int).Value = excluirId.Value;
            }

            int count = (int)cmd.ExecuteScalar();
            return count > 0;


        }
        //-----------------------------------------------------------------------------
        //-----------------------------------------------------------------------------
        public void Guardar(Cliente cliente)
        {
            using SqlConnection cn = new(ConexionDB.Cadena);
            cn.Open();

            const string SQL = @"INSERT INTO Clientes (nombre, apellido, telefono, direccion, dui, correo)
                         VALUES (@Nombre, @Apellido, @Telefono, @Direccion, @Dui, @Correo);
                         SELECT SCOPE_IDENTITY();";
            using SqlCommand cmd = new(SQL, cn);
            cmd.Parameters.Add("@Nombre", SqlDbType.VarChar, 100).Value = cliente.Nombre;
            cmd.Parameters.Add("@Apellido", SqlDbType.VarChar, 100).Value = cliente.Apellido;
            cmd.Parameters.Add("@Telefono", SqlDbType.VarChar, 10).Value = cliente.Telefono;
            cmd.Parameters.Add("@Direccion", SqlDbType.VarChar, 200).Value = cliente.Direccion;
            cmd.Parameters.Add("@Dui", SqlDbType.VarChar, 12).Value = cliente.Dui;
            cmd.Parameters.Add("@Correo", SqlDbType.VarChar, 100).Value = cliente.Correo;

            cliente.IdCliente = Convert.ToInt32(cmd.ExecuteScalar());
        }
        //-----------------------------------------------------------------------------
        //-----------------------------------------------------------------------------
        public DataTable Listar()
        {
            DataTable table = new();
            using SqlConnection cn = new(ConexionDB.Cadena);
            cn.Open();

            const string SQL = "SELECT id_cliente, nombre, apellido, telefono, direccion, dui, correo FROM Clientes";
            using SqlDataAdapter da = new(SQL, cn);
            da.Fill(table);
            return table;
        }
        //-----------------------------------------------------------------------------
        //-----------------------------------------------------------------------------
        public Cliente? ObtenerPorId(int id)
        {
            using SqlConnection cn = new(ConexionDB.Cadena);
            cn.Open();

            const string SQL = "SELECT id_cliente, nombre, apellido, telefono, direccion, dui, correo FROM Clientes WHERE id_cliente = @IdCliente";
            using SqlCommand cmd = new(SQL, cn);
            cmd.Parameters.Add("@IdCliente", SqlDbType.Int).Value = id; 
            using SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read()) return null;

            return new Cliente
            {
                IdCliente = Convert.ToInt32(dr["id_cliente"]),
                Nombre = dr["nombre"].ToString() ?? string.Empty,
                Apellido = dr["apellido"].ToString() ?? string.Empty,
                Telefono = dr["telefono"].ToString() ?? string.Empty,
                Direccion = dr["direccion"].ToString() ?? string.Empty,
                Dui = dr["dui"].ToString() ?? string.Empty,
                Correo = dr["correo"].ToString() ?? string.Empty
            };
        }
        //-----------------------------------------------------------------------------
        //-----------------------------------------------------------------------------
        public bool TieneFacturasRelacionadas(int clienteId)
        {
            using SqlConnection cn = new(ConexionDB.Cadena);
            cn.Open();

                             
            string sql = @"SELECT COUNT(*) FROM Factura_Compras WHERE id_cliente = @ClienteId";

            using SqlCommand cmd = new(sql, cn);
            cmd.Parameters.Add("@ClienteId", SqlDbType.Int).Value = clienteId;
            int count = Convert.ToInt32(cmd.ExecuteScalar());
            return count > 0;
        }
        //-----------------------------------------------------------------------------
        //-----------------------------------------------------------------------------


        public bool TieneRecepcionesRelacionadas(int clienteId)
        {
            using SqlConnection cn = new(ConexionDB.Cadena);
            cn.Open();

            string sql = @"SELECT COUNT(*) FROM Recepcion_Dispositivos WHERE id_cliente = @ClienteId";
            using SqlCommand cmd = new(sql, cn);
            cmd.Parameters.Add("@ClienteId", SqlDbType.Int).Value = clienteId;

            int count = Convert.ToInt32(cmd.ExecuteScalar());
            return count > 0;
        }
    }
}
