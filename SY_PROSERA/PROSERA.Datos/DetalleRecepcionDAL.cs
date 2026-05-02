using Microsoft.Data.SqlClient;
using PROSERA.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

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

            string sql  = @"UPDATE DetalleRecepcion SET 
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
        }
    }
}
