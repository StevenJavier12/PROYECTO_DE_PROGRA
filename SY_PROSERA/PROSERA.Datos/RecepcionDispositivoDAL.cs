using Microsoft.Data.SqlClient;
using PROSERA.Entidades;
using System.Data;

namespace PROSERA.Datos
{
    public class RecepcionDispositivoDAL : IRecepcionDispositivoDAL
    {
        public void Guardar(RecepcionDispositivo recepcion)
        {
            using SqlConnection cn = new(ConexionDB.Cadena);
            cn.Open();

            const string SQL = @"INSERT INTO Recepcion_Dispositivos 
                                (fecha, id_cliente, id_usuario, observaciones)
                                VALUES (@fecha, @id_cliente, @id_usuario, @observaciones)";

            using SqlCommand cmd = new(SQL, cn);
            cmd.Parameters.Add("@fecha", SqlDbType.DateTime).Value = recepcion.Fecha;
            cmd.Parameters.Add("@id_cliente", SqlDbType.Int).Value = recepcion.IdCliente;
            cmd.Parameters.Add("@id_usuario", SqlDbType.Int).Value = recepcion.IdUsuario;
            cmd.Parameters.Add("@observaciones", SqlDbType.VarChar, 200).Value = recepcion.Observaciones;

            cmd.ExecuteNonQuery();
        }

        public void Editar(RecepcionDispositivo recepcion)
        {
            using SqlConnection cn = new(ConexionDB.Cadena);
            cn.Open();

            const string SQL = @"UPDATE Recepcion_Dispositivos
                                SET fecha = @fecha,
                                    id_cliente = @id_cliente,
                                    id_usuario = @id_usuario,
                                    observaciones = @observaciones
                                WHERE id_recepcion = @id_recepcion";

            using SqlCommand cmd = new(SQL, cn);
            cmd.Parameters.Add("@fecha", SqlDbType.DateTime).Value = recepcion.Fecha;
            cmd.Parameters.Add("@id_cliente", SqlDbType.Int).Value = recepcion.IdCliente;
            cmd.Parameters.Add("@id_usuario", SqlDbType.Int).Value = recepcion.IdUsuario;
            cmd.Parameters.Add("@observaciones", SqlDbType.VarChar, 200).Value = recepcion.Observaciones;
            cmd.Parameters.Add("@id_recepcion", SqlDbType.Int).Value = recepcion.IdRecepcion;

            cmd.ExecuteNonQuery();
        }

        public void Eliminar(int id)
        {
            using SqlConnection cn = new(ConexionDB.Cadena);
            cn.Open();

            const string SQL = "DELETE FROM Recepcion_Dispositivos WHERE id_recepcion = @Id";
            using SqlCommand cmd = new(SQL, cn);
            cmd.Parameters.Add("@Id", SqlDbType.Int).Value = id;
            cmd.ExecuteNonQuery();
        }

        public DataTable ListarConRelaciones()
        {
            DataTable table = new();
            using SqlConnection cn = new(ConexionDB.Cadena);
            cn.Open();

            // Asumimos que Clientes tiene al menos id_cliente y nombre.
            const string SQL = @"SELECT r.id_recepcion, r.fecha, r.id_cliente, c.nombre AS cliente_nombre,
                                        r.id_usuario, u.username AS usuario_username, r.observaciones
                                 FROM Recepcion_Dispositivos r
                                 INNER JOIN Clientes c ON r.id_cliente = c.id_cliente
                                 INNER JOIN Usuarios u ON r.id_usuario = u.id_usuario";

            using SqlDataAdapter da = new(SQL, cn);
            da.Fill(table);
            return table;
        }

        public RecepcionDispositivo? ObtenerPorId(int id)
        {
            using SqlConnection cn = new(ConexionDB.Cadena);
            cn.Open();

            const string SQL = @"SELECT r.id_recepcion, r.fecha, r.id_cliente, c.nombre AS cliente_nombre,
                                        r.id_usuario, u.username, r.observaciones
                                 FROM Recepcion_Dispositivos r
                                 INNER JOIN Clientes c ON r.id_cliente = c.id_cliente
                                 INNER JOIN Usuarios u ON r.id_usuario = u.id_usuario
                                 WHERE r.id_recepcion = @Id";

            using SqlCommand cmd = new(SQL, cn);
            cmd.Parameters.Add("@Id", SqlDbType.Int).Value = id;

            using SqlDataReader dr = cmd.ExecuteReader();
            if (!dr.Read()) return null;

            return new RecepcionDispositivo
            {
                IdRecepcion = Convert.ToInt32(dr["id_recepcion"]),
                Fecha = Convert.ToDateTime(dr["fecha"]),
                IdCliente = Convert.ToInt32(dr["id_cliente"]),
                IdUsuario = Convert.ToInt32(dr["id_usuario"]),
                Observaciones = dr["observaciones"].ToString() ?? string.Empty,
                // Rellenamos objetos de navegación con la información disponible
                Cliente = new Cliente
                {
                    IdCliente = Convert.ToInt32(dr["id_cliente"]),
                    Nombre = dr["cliente_nombre"].ToString() ?? string.Empty
                },
                Usuario = new Usuario
                {
                    IdUsuario = Convert.ToInt32(dr["id_usuario"]),
                    Username = dr["username"].ToString() ?? string.Empty
                }
            };
        }
    }
}