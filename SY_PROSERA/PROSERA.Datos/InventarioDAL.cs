using System;
using System.Collections.Generic;
using System.Text;

namespace PROSERA.Datos
{
      public class InventarioDAL : IInventarioDAL
    {
        public DataTable Listar()
        {
            using SqlConnection cn = new(ConexionDB.Cadena);
            cn.Open();

            string sql = @"SELECT i.id_inventario, p.nombre, i.stock, i.stock_minimo
                           FROM Inventario i
                           INNER JOIN Productos p 
                           ON i.id_producto = p.id_producto";

            using SqlDataAdapter da = new(sql, cn);
            DataTable dt = new();
            da.Fill(dt);
            return dt;
        }

        public void ActualizarStock(int idProducto, int cantidad, string tipo)
        {
            using SqlConnection cn = new(ConexionDB.Cadena);
            cn.Open();

            string operacion = tipo == "Entrada" ? "+" : "-";

            string sql = $@"UPDATE Inventario
                            SET stock = stock {operacion} @cantidad,
                                fecha_actualizacion = GETDATE()
                            WHERE id_producto = @idProducto";

            using SqlCommand cmd = new(sql, cn);
            cmd.Parameters.Add("@cantidad", SqlDbType.Int).Value = cantidad;
            cmd.Parameters.Add("@idProducto", SqlDbType.Int).Value = idProducto;

            cmd.ExecuteNonQuery();
        }
    }
}
