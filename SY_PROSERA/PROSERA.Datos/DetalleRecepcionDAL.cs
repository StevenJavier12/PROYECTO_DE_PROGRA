using Microsoft.Data.SqlClient;
using PROSERA.Entidades;
using System.Data;


namespace PROSERA.Datos
{
    public class DetalleRecepcionDAL : IDetalleRecepcionDAL
    {


        public void Agregar(DetalleRecepcion detalle)
        {
            using SqlConnection cn = new(ConexionDB.Cadena);
            cn.Open();

            string sql = @"INSERT INTO DetalleRecepcion 
                        (IdRecepcion, IdDispositivo, Cantidad) 
                        VALUES (@Recepcion, @Dispositivo, @Cantidad)";

            using SqlCommand cmd = new(sql, cn);
            cmd.Parameters.AddWithValue("@Recepcion", detalle.IdRecepcion);
            cmd.Parameters.AddWithValue("@Dispositivo", detalle.IdDispositivo);
            cmd.Parameters.AddWithValue("@Cantidad", detalle.Cantidad);

            cn.Open();
            cmd.ExecuteNonQuery();

        }

        public void Editar(DetalleRecepcion detalle)
        {
            using SqlConnection cn = new(ConexionDB.Cadena);
            cn.Open();

            string sql = @"UPDATE DetalleRecepcion SET 
                        IdRecepcion = @Recepcion,
                        IdDispositivo = @Dispositivo,
                        Cantidad = @Cantidad
                        WHERE IdDetalle = @Id";

            using SqlCommand cmd = new(sql, cn);

            cmd.Parameters.AddWithValue("@Id", detalle.IdDetalle);
            cmd.Parameters.AddWithValue("@Recepcion", detalle.IdRecepcion);
            cmd.Parameters.AddWithValue("@Dispositivo", detalle.IdDispositivo);
            cmd.Parameters.AddWithValue("@Cantidad", detalle.Cantidad);

            cn.Open();
            cmd.ExecuteNonQuery();

        }

        public void Eliminar(int Id)
        {
            using SqlConnection cn = new(ConexionDB.Cadena);
            cn.Open();

            string sql = "DELETE FROM DetalleRecepcion WHERE IdDetalle = @Id";
            using SqlCommand cmd = new(sql, cn);

            cmd.Parameters.AddWithValue("@Id", Id);

            cn.Open();
            cmd.ExecuteNonQuery();

        }




        public DataTable Listar()
        {
            DataTable table = new();

            using SqlConnection cn = new(ConexionDB.Cadena);
            cn.Open();

            string sql = @"SELECT 
                        dr.id_detalle,
                        dr.id_recepcion,
                        dr.id_dispositivo,
                        de.nombre_dispositivo,
                        dr.cantidad
                   FROM Detalles_Recepcion dr
                   INNER JOIN Dispositivos_Electronicos de
                        ON dr.id_dispositivo = de.id_dispositivo";

            using SqlDataAdapter da = new(sql, cn);

            da.Fill(table);

            return table;
        }
              

        public DetalleRecepcion ObtenerPorId(int Id)
        {
            throw new NotImplementedException();
        }

<<<<<<< HEAD
        public DetalleCompra ObtenerPorId(object systemint32, int id)
=======
        public DetalleRecepcion ListarPorCompra(object int32, int idRecepcion)
        {
            throw new NotImplementedException();
        }

        public DetalleRecepcion  ObtenerPorId(int Id)
>>>>>>> 3b7990587225094801f1cbf15aa4fb63d6d8315c
        {
            throw new NotImplementedException();
        }

        public DetalleCompra ObtenerPorId(object systemint32, int id)
        {
            throw new NotImplementedException();
        }
    }
}
