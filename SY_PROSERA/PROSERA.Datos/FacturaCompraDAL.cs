using Microsoft.Data.SqlClient;
using PROSERA.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace PROSERA.Datos
{
    public class FacturaCompraDAL : IFacturaCompraDAL
    {
        public void Guardar(FacturaCompra factura)
        {
            using SqlConnection cn = new(ConexionDB.Cadena);
            cn.Open();

            using SqlTransaction tx = cn.BeginTransaction();

            try
            {
                // GUARDAR FACTURA
                string sqlFactura = @"INSERT INTO Factura_Compras 
                                    (fecha, id_proveedor, total, tipo_comprobante)
                                    VALUES (@fecha, @proveedor, @total, @tipo);
                                    SELECT SCOPE_IDENTITY();";

                using SqlCommand cmdFactura = new(sqlFactura, cn, tx);
                cmdFactura.Parameters.AddWithValue("@fecha", factura.Fecha);
                cmdFactura.Parameters.AddWithValue("@proveedor", factura.IdProveedor);
                cmdFactura.Parameters.AddWithValue("@total", factura.Total);
                cmdFactura.Parameters.AddWithValue("@tipo", factura.TipoComprobante);

                factura.IdCompra = Convert.ToInt32(cmdFactura.ExecuteScalar());

                // GUARDAR DETALLES
                foreach (var detalle in factura.DetalleCompras)
                {
                    string sqlDetalle = @"INSERT INTO Detalle_Compras
                                        (id_compra, id_producto, cantidad, costo_unitario, subtotal)
                                        VALUES (@compra, @producto, @cantidad, @costo, @subtotal)";

                    using SqlCommand cmdDetalle = new(sqlDetalle, cn, tx);
                    cmdDetalle.Parameters.AddWithValue("@compra", factura.IdCompra);
                    cmdDetalle.Parameters.AddWithValue("@producto", detalle.IdProducto);
                    cmdDetalle.Parameters.AddWithValue("@cantidad", detalle.Cantidad);
                    cmdDetalle.Parameters.AddWithValue("@costo", detalle.CostoUnitario);
                    cmdDetalle.Parameters.AddWithValue("@subtotal", detalle.Subtotal);

                    cmdDetalle.ExecuteNonQuery();

                    //  ACTUALIZAR INVENTARIO (SUMA)
                    string sqlInventario = @"UPDATE Inventario
                                            SET stock = stock + @cantidad,
                                                fecha_actualizacion = GETDATE()
                                            WHERE id_producto = @producto";

                    using SqlCommand cmdInv = new(sqlInventario, cn, tx);
                    cmdInv.Parameters.AddWithValue("@cantidad", detalle.Cantidad);
                    cmdInv.Parameters.AddWithValue("@producto", detalle.IdProducto);

                    cmdInv.ExecuteNonQuery();
                }

                //  CONFIRMAR TODO
                tx.Commit();
            }
            catch
            {
                //  SI FALLA → DESHACE TODO
                tx.Rollback();
                throw;
            }
        }

        public DataTable Listar()
        {
            using SqlConnection cn = new(ConexionDB.Cadena);
            cn.Open();

            string sql = @"SELECT fc.id_compra, fc.fecha, p.nombre_empresa, fc.total, fc.tipo_comprobante
                           FROM Factura_Compras fc
                           INNER JOIN Proveedores p 
                           ON fc.id_proveedor = p.id_proveedor";

            using SqlDataAdapter da = new(sql, cn);
            DataTable dt = new();
            da.Fill(dt);
            return dt;
        }

        public void Eliminar(int id)
        {
            using SqlConnection cn = new(ConexionDB.Cadena);
            cn.Open();

            string sql = "DELETE FROM Factura_Compras WHERE id_compra = @id";

            using SqlCommand cmd = new(sql, cn);
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;

            cmd.ExecuteNonQuery();
        }

        public void Guardar(FacturaCompra factura)
        {
            throw new NotImplementedException();
        }

        public void Guardar(FacturaCompra factura)
        {
            throw new NotImplementedException();
        }
    }
}
