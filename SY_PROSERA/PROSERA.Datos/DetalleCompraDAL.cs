using Microsoft.Data.SqlClient;
using PROSERA.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace PROSERA.Datos
{

    /*Datos de la tabla en sql
     * CREATE TABLE Detalle_Compras (
    id_detalle_compra INT PRIMARY KEY IDENTITY (1,1),
    id_compra INT NOT NULL,
    id_producto INT NOT NULL,
    cantidad INT NOT NULL,
    costo_unitario DECIMAL(10,2) NOT NULL,
    subtotal DECIMAL(10,2) NOT NULL,

     */
    internal class DetalleCompraDAL : IDetalleCompraDAL
    {
        public void Editar(DetalleCompra detalleCompra)
        {
            using SqlConnection cn = new(ConexionDB.Cadena);
            cn.Open();

            const string SQL = @"UPDATE Detalle_Compras
                         SET id_compra = @idCompra,
                             id_producto = @idProducto,
                             cantidad = @cantidad,
                             costo_unitario = @costoUnitario,
                             subtotal = @subtotal
                         WHERE id_detalle_compra = @idDetalleCompra";

            using SqlCommand cmd = new(SQL, cn);
            cmd.Parameters.Add("@idCompra", SqlDbType.Int).Value = detalleCompra.IdCompra;
            cmd.Parameters.Add("@idProducto", SqlDbType.Int).Value = detalleCompra.IdProducto;
            cmd.Parameters.Add("@cantidad", SqlDbType.Int).Value = detalleCompra.Cantidad;
            cmd.Parameters.Add("@costoUnitario", SqlDbType.Decimal).Value = detalleCompra.CostoUnitario;
            cmd.Parameters.Add("@subtotal", SqlDbType.Decimal).Value = detalleCompra.Subtotal;
            cmd.Parameters.Add("@idDetalleCompra", SqlDbType.Int).Value = detalleCompra.IdDetalleCompra;

            cmd.ExecuteNonQuery();
        }

        public void Eliminar(int id)
        {
            using SqlConnection cn = new(ConexionDB.Cadena);
            cn.Open();

            const string SQL = "DELETE FROM Detalle_Compras WHERE id_detalle_compra = @Id";
            using SqlCommand cmd = new(SQL, cn);
            cmd.Parameters.Add("@Id", SqlDbType.Int).Value = id;
            cmd.ExecuteNonQuery();
        }

        public bool ExisteProductoEnCompra(int idCompra, int idProducto, int? excluirId = null)
        {
            using SqlConnection cn = new(ConexionDB.Cadena);
            cn.Open();

            string sql = "SELECT COUNT(*) FROM Detalle_Compras WHERE id_compra = @IdCompra AND id_producto = @IdProducto";
            if (excluirId.HasValue)
            {
                sql += " AND id_detalle_compra <> @ExcluirId";
            }
            
            using SqlCommand cmd = new(sql, cn);
            cmd.Parameters.Add("@IdCompra", SqlDbType.Int).Value = idCompra;
            cmd.Parameters.Add("@IdProducto", SqlDbType.Int).Value = idProducto;
            if (excluirId.HasValue)
            {
                cmd.Parameters.Add("@ExcluirId", SqlDbType.Int).Value = excluirId.Value;
            }

            int count = (int)cmd.ExecuteScalar();
            return count > 0;

        }

        public void Guardar(DetalleCompra detalleCompra)
        {
            using SqlConnection cn = new(ConexionDB.Cadena);
            cn.Open();

            string sql = @"INSERT INTO Detalle_Compras (id_compra, id_producto, cantidad, costo_unitario, subtotal)
                         VALUES (@idCompra, @idProducto, @cantidad, @costoUnitario, @subtotal)";

            using SqlCommand cmd = new(sql, cn);
            cmd.Parameters.Add("@idCompra", SqlDbType.Int).Value = detalleCompra.IdCompra;
            cmd.Parameters.Add("@idProducto", SqlDbType.Int).Value = detalleCompra.IdProducto;
            cmd.Parameters.Add("@cantidad", SqlDbType.Int).Value = detalleCompra.Cantidad;
            cmd.Parameters.Add("@costoUnitario", SqlDbType.Decimal).Value = detalleCompra.CostoUnitario;
            cmd.Parameters.Add("@subtotal", SqlDbType.Decimal).Value = detalleCompra.Subtotal;

            cmd.ExecuteNonQuery();
        }

        public DataTable Listar()
        {
            using SqlConnection cn = new(ConexionDB.Cadena);
            cn.Open();

            string sql = @"SELECT dc.id_detalle_compra, dc.id_compra, c.fecha_compra, dc.id_producto, p.nombre AS producto, dc.cantidad, dc.costo_unitario, dc.subtotal
                         FROM Detalle_Compras dc
                         INNER JOIN Compras c ON dc.id_compra = c.id_compra
                         INNER JOIN Productos p ON dc.id_producto = p.id_producto";

            using SqlCommand cmd = new(sql, cn);
            using SqlDataAdapter da = new(cmd);
            DataTable dt = new();
            da.Fill(dt);
            return dt;
        }
        //DAL SIGNI
        public DataTable ListarPorCompra(int idCompra)
        {
            using SqlConnection cn = new(ConexionDB.Cadena);
            cn.Open();

            string sql = @"SELECT dc.id_detalle_compra, dc.id_compra, c.fecha_compra, dc.id_producto, p.nombre AS producto, dc.cantidad, dc.costo_unitario, dc.subtotal
                         FROM Detalle_Compras dc
                         INNER JOIN Compras c ON dc.id_compra = c.id_compra
                         INNER JOIN Productos p ON dc.id_producto = p.id_producto
                         WHERE dc.id_compra = @IdCompra";

            using SqlCommand cmd = new(sql, cn);
            cmd.Parameters.Add("@IdCompra", SqlDbType.Int).Value = idCompra;

            using SqlDataReader dr = cmd.ExecuteReader();
            if (!dr.Read())return null;

            return new DetalleCompra
            {
                IdDetalleCompra = Convert.ToInt32(dr["id_detalle_compra"]),
                IdCompra = Convert.ToInt32(dr["id_compra"]),
                FechaCompra = Convert.ToDateTime(dr["fecha_compra"]),
                IdProducto = Convert.ToInt32(dr["id_producto"]),
                Producto = dr["producto"].ToString() ?? string.Empty,
                Cantidad = Convert.ToInt32(dr["cantidad"]),
                CostoUnitario = Convert.ToDecimal(dr["costo_unitario"]),
                Subtotal = Convert.ToDecimal(dr["subtotal"])
            };
        }

        public DetalleCompra? ObtenerPorId(int id)
        {
            using SqlConnection cn = new(ConexionDB.Cadena);
            cn.Open();

            string sql = @"SELECT dc.id_detalle_compra, dc.id_compra, c.fecha_compra, dc.id_producto, p.nombre AS producto, dc.cantidad, dc.costo_unitario, dc.subtotal
                         FROM Detalle_Compras dc
                         INNER JOIN Compras c ON dc.id_compra = c.id_compra
                         INNER JOIN Productos p ON dc.id_producto = p.id_producto
                         WHERE dc.id_detalle_compra = @Id";

            using SqlCommand cmd = new(sql, cn);
            cmd.Parameters.Add("@Id", SqlDbType.Int).Value = id;
            using SqlDataAdapter da = new(cmd);
            DataTable dt = new();
            da.Fill(dt);

            if (dt.Rows.Count == 0)
            {
                return null;
            }

            DataRow row = dt.Rows[0];
            return new DetalleCompra
            {
                IdDetalleCompra = (int)row["id_detalle_compra"],
                IdCompra = (int)row["id_compra"],
                FechaCompra = (DateTime)row["fecha_compra"],
                IdProducto = (int)row["id_producto"],
                Producto = (string)row["producto"],
                Cantidad = (int)row["cantidad"],
                CostoUnitario = (decimal)row["costo_unitario"],
                Subtotal = (decimal)row["subtotal"]
            };
        }
    }
}
