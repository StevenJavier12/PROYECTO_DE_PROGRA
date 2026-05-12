using Microsoft.Data.SqlClient;
using PROSERA.Entidades;
using System;
using System.Collections.Generic;
using System.Data;

namespace PROSERA.Datos
{
    public class DetalleVentaDAL : IDetalleVentaDAL
    {
        public void Agregar(DetalleVenta detalle)
        {
            using SqlConnection cn = new(ConexionDB.Cadena);
            cn.Open();

            string query = @"INSERT INTO Detalle_Ventas 
                            (id_factura, id_producto, cantidad, precio_unitario, subtotal) 
                            VALUES (@Factura, @Producto, @Cantidad, @Precio, @Subtotal)";

            using SqlCommand cmd = new(query, cn);
            cmd.Parameters.AddWithValue("@Factura", detalle.IdFactura);
            cmd.Parameters.AddWithValue("@Producto", detalle.IdProducto);
            cmd.Parameters.AddWithValue("@Cantidad", detalle.Cantidad);
            cmd.Parameters.AddWithValue("@Precio", detalle.PrecioUnitario);
            cmd.Parameters.AddWithValue("@Subtotal", detalle.Subtotal);

            cmd.ExecuteNonQuery();
        }

        public void Editar(DetalleVenta detalle)
        {
            using SqlConnection cn = new(ConexionDB.Cadena);
            cn.Open();

            string query = @"UPDATE Detalle_Ventas SET 
                            id_factura      = @Factura,
                            id_producto     = @Producto,
                            cantidad        = @Cantidad,
                            precio_unitario = @Precio,
                            subtotal        = @Subtotal
                            WHERE id_detalle = @Id";

            using SqlCommand cmd = new(query, cn);
            cmd.Parameters.AddWithValue("@Id", detalle.IdDetalle);
            cmd.Parameters.AddWithValue("@Factura", detalle.IdFactura);
            cmd.Parameters.AddWithValue("@Producto", detalle.IdProducto);
            cmd.Parameters.AddWithValue("@Cantidad", detalle.Cantidad);
            cmd.Parameters.AddWithValue("@Precio", detalle.PrecioUnitario);
            cmd.Parameters.AddWithValue("@Subtotal", detalle.Subtotal);

            cmd.ExecuteNonQuery();
        }

        public void Eliminar(int id)
        {
            using SqlConnection cn = new(ConexionDB.Cadena);
            cn.Open();

            string query = "DELETE FROM Detalle_Ventas WHERE id_detalle = @Id";
            using SqlCommand cmd = new(query, cn);
            cmd.Parameters.AddWithValue("@Id", id);

            cmd.ExecuteNonQuery();
        }

        public List<DetalleVenta> Listar()
        {
            List<DetalleVenta> lista = new();

            using SqlConnection cn = new(ConexionDB.Cadena);
            cn.Open();

            string query = @"
        SELECT 
            dv.id_detalle,
            dv.id_factura,
            dv.id_producto,
            p.nombre        AS nombre_producto,
            dv.cantidad,
            dv.precio_unitario,
            dv.subtotal
        FROM Detalle_Ventas dv
        INNER JOIN Productos p ON dv.id_producto = p.id_producto";

            using SqlCommand cmd = new(query, cn);
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                lista.Add(new DetalleVenta
                {
                    IdDetalle = (int)dr["id_detalle"],
                    IdFactura = (int)dr["id_factura"],
                    IdProducto = (int)dr["id_producto"],
                    NombreProducto = dr["nombre_producto"].ToString(),
                    Cantidad = (int)dr["cantidad"],
                    PrecioUnitario = Convert.ToDecimal(dr["precio_unitario"]),
                    Subtotal = Convert.ToDecimal(dr["subtotal"])
                });
            }

            return lista;
        }

        public DetalleVenta ObtenerPorId(int id)
        {
            DetalleVenta? detalle = null;

            using SqlConnection cn = new(ConexionDB.Cadena);
            cn.Open();

            string query = "SELECT * FROM Detalle_Ventas WHERE id_detalle = @Id";
            using SqlCommand cmd = new(query, cn);
            cmd.Parameters.AddWithValue("@Id", id);

            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                detalle = new DetalleVenta
                {
                    IdDetalle = (int)dr["id_detalle"],
                    IdFactura = (int)dr["id_factura"],
                    IdProducto = (int)dr["id_producto"],
                    Cantidad = (int)dr["cantidad"],
                    PrecioUnitario = Convert.ToDecimal(dr["precio_unitario"]),
                    Subtotal = Convert.ToDecimal(dr["subtotal"])
                };
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