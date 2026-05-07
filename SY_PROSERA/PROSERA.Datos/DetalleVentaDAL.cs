using Microsoft.Data.SqlClient;
using PROSERA.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace PROSERA.Datos
{

    // class DetalleVenta
    public class DetalleVentaDAL : IDetalleVentaDAL
    {
        
        public void Agregar(DetalleVenta detalle)
        {
            using SqlConnection cn = new(ConexionDB.Cadena);
            cn.Open();
            {
                string query = @"INSERT INTO DetalleVenta 
                        (IdFactura, IdProducto, Cantidad, Precio) 
                        VALUES (@Factura, @Producto, @Cantidad, @Precio)";

                using SqlCommand cmd = new(query, cn);

                cmd.Parameters.AddWithValue("@Factura", detalle.IdFactura);
                cmd.Parameters.AddWithValue("@Producto", detalle.IdProducto);
                cmd.Parameters.AddWithValue("@Cantidad", detalle.Cantidad);
                cmd.Parameters.AddWithValue("@Precio", detalle.Precio);

                cn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void Editar(DetalleVenta detalle)
        {
            using SqlConnection cn = new(ConexionDB.Cadena);
            cn.Open();

            string query = @"UPDATE DetalleVenta SET 
                    IdFactura = @Factura,
                    IdProducto = @Producto,
                    IdCantidad = @Cantidad,
                        Precio = @Precio
                        WHERE IdDetalle = @Id";

                using SqlCommand cmd = new(query, cn);
                cmd.Parameters.AddWithValue("@Id", detalle.IdDetalle);
                cmd.Parameters.AddWithValue("@Factura", detalle.IdFactura);
                cmd.Parameters.AddWithValue("@Producto", detalle.IdProducto);
                cmd.Parameters.AddWithValue("@Cantidad", detalle.Cantidad);
                cmd.Parameters.AddWithValue("@Precio", detalle.Precio);

                cn.Open();
                cmd.ExecuteNonQuery();
            
        }

        public void Eliminar(int id)
        {
            using SqlConnection cn = new(ConexionDB.Cadena);
            cn.Open();

            string query = "DELETE FROM DetalleVenta WHERE IdDetalle = @Id";
            using SqlCommand cmd = new(query, cn);

                cmd.Parameters.AddWithValue("@Id", id);

                cn.Open();
                cmd.ExecuteNonQuery();
            
        }

        public List<DetalleVenta> Listar()
        {
            List<DetalleVenta> lista = new List<DetalleVenta>();

            using SqlConnection cn = new(ConexionDB.Cadena);
            cn.Open();

            string query = "SELECT * FROM DetalleVenta";
            using SqlCommand cmd = new(query, cn);
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    lista.Add(new DetalleVenta
                    {
                        IdDetalle = (int)dr["IdDetalle"],
                        IdFactura = (int)dr["IdFactura"],
                        IdProducto = (int)dr["IdProducto"],
                        Cantidad = (int)dr["Cantidad"],
                        Precio = Convert.ToDecimal(dr["Precio"])
                    });
                }
            

            return lista;
        }

        public DetalleVenta ObtenerPorId(int id)
        {

            DetalleVenta detalle = null;

            using SqlConnection cn = new(ConexionDB.Cadena);
            {
                string query = "SELECT * FROM DetalleVenta WHERE IdDetalle = @Id";
                using SqlCommand cmd = new(query, cn);
                cmd.Parameters.AddWithValue("@Id", id);

                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    detalle = new DetalleVenta
                    {
                        IdDetalle = (int)dr["IdDetalle"],
                        IdFactura = (int)dr["IdFactura"],
                        IdProducto = (int)dr["IdProducto"],
                        Cantidad = (int)dr["Cantidad"],
                        Precio = Convert.ToDecimal(dr["Precio"])
                    };
                }
            }

            return detalle;
        }

        DataTable IDetalleVentaDAL.Listar()
        {
            DataTable dt = new();

            using SqlConnection cn = new(ConexionDB.Cadena);
            cn.Open();

            const string SQL = "SELECT * FROM Detalle_Ventas";

            using SqlCommand cmd = new(SQL, cn);
            using SqlDataAdapter da = new(cmd);

            da.Fill(dt);

            return dt;
        }
    }
}
