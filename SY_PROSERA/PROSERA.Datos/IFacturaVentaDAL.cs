using System;
using System.Collections.Generic;
using System.Text;

namespace PROSERA.Datos
{

    public interface IFacturaVentaDAL
    {
        void Guardar(FacturaVenta factura);
        DataTable Listar();
        void Eliminar(int id);
    }

    // IMPLEMENTACIÓN
    public class FacturaVentaDAL : IFacturaVentaDAL
    {
        public void Guardar(FacturaVenta factura)
        {
            using SqlConnection cn = new(ConexionDB.Cadena);
            cn.Open();

            using SqlTransaction tx = cn.BeginTransaction();

            try
            {
                // GUARDAR FACTURA
                string sqlFactura = @"INSERT INTO Factura_Ventas
                                    (fecha, id_cliente, id_usuario, total, descuento, metodo_pago, estado_factura)
                                    VALUES (@fecha, @cliente, @usuario, @total, @descuento, @metodo, @estado);
                                    SELECT SCOPE_IDENTITY();";

                using SqlCommand cmdFactura = new(sqlFactura, cn, tx);
                cmdFactura.Parameters.AddWithValue("@fecha", factura.Fecha);
                cmdFactura.Parameters.AddWithValue("@cliente", factura.IdCliente);
                cmdFactura.Parameters.AddWithValue("@usuario", factura.IdUsuario);
                cmdFactura.Parameters.AddWithValue("@total", factura.Total);
                cmdFactura.Parameters.AddWithValue("@descuento", factura.Descuento);
                cmdFactura.Parameters.AddWithValue("@metodo", factura.MetodoPago);
                cmdFactura.Parameters.AddWithValue("@estado", factura.EstadoFactura);

                factura.IdFactura = Convert.ToInt32(cmdFactura.ExecuteScalar());

                //  GUARDAR DETALLES
                foreach (var detalle in factura.DetalleVentas)
                {
                    string sqlDetalle = @"INSERT INTO Detalle_Ventas
                                        (id_factura, id_producto, cantidad, precio_unitario, subtotal)
                                        VALUES (@factura, @producto, @cantidad, @precio, @subtotal)";

                    using SqlCommand cmdDetalle = new(sqlDetalle, cn, tx);
                    cmdDetalle.Parameters.AddWithValue("@factura", factura.IdFactura);
                    cmdDetalle.Parameters.AddWithValue("@producto", detalle.IdProducto);
                    cmdDetalle.Parameters.AddWithValue("@cantidad", detalle.Cantidad);
                    cmdDetalle.Parameters.AddWithValue("@precio", detalle.PrecioUnitario);
                    cmdDetalle.Parameters.AddWithValue("@subtotal", detalle.Subtotal);

                    cmdDetalle.ExecuteNonQuery();

                    // VALIDAR STOCK
                    string sqlCheck = @"SELECT stock FROM Inventario WHERE id_producto = @producto";

                    using SqlCommand cmdCheck = new(sqlCheck, cn, tx);
                    cmdCheck.Parameters.AddWithValue("@producto", detalle.IdProducto);

                    int stockActual = Convert.ToInt32(cmdCheck.ExecuteScalar());

                    if (stockActual < detalle.Cantidad)
                        throw new Exception("Stock insuficiente para el producto ID: " + detalle.IdProducto);

                    // RESTAR INVENTARIO
                    string sqlInventario = @"UPDATE Inventario
                                            SET stock = stock - @cantidad,
                                                fecha_actualizacion = GETDATE()
                                            WHERE id_producto = @producto";

                    using SqlCommand cmdInv = new(sqlInventario, cn, tx);
                    cmdInv.Parameters.AddWithValue("@cantidad", detalle.Cantidad);
                    cmdInv.Parameters.AddWithValue("@producto", detalle.IdProducto);

                    cmdInv.ExecuteNonQuery();
                }

                // 
                tx.Commit();
            }
            catch
            {
                tx.Rollback();
                throw;
            }
        }

        public DataTable Listar()
        {
            using SqlConnection cn = new(ConexionDB.Cadena);
            cn.Open();

            string sql = @"SELECT fv.id_factura, fv.fecha, c.nombre, fv.total, fv.metodo_pago, fv.estado_factura
                           FROM Factura_Ventas fv
                           INNER JOIN Clientes c ON fv.id_cliente = c.id_cliente";

            using SqlDataAdapter da = new(sql, cn);
            DataTable dt = new();
            da.Fill(dt);
            return dt;
        }

        public void Eliminar(int id)
        {
            using SqlConnection cn = new(ConexionDB.Cadena);
            cn.Open();

            string sql = "DELETE FROM Factura_Ventas WHERE id_factura = @id";

            using SqlCommand cmd = new(sql, cn);
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;

            cmd.ExecuteNonQuery();
        }
    }
}
