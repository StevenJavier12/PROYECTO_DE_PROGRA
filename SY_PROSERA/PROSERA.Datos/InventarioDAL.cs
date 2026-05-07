using Microsoft.Data.SqlClient;
<<<<<<< HEAD
using PROSERA.Entidades;
=======
>>>>>>> 3b7990587225094801f1cbf15aa4fb63d6d8315c
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace PROSERA.Datos
{
    public class InventarioDAL : IInventarioDAL
    {
        public void Editar(Inventario inventario)
        {
            using SqlConnection cn = new(ConexionDB.Cadena);
            cn.Open();

            const string SQL = @"UPDATE Inventario
                                SET id_producto = @IdProducto,
                                    stock = @Stock,
                                    stock_minimo = @StockMinimo,
                                    fecha_actualizacion = @FechaActualizacion,
                                    tipo_movimiento = @TipoMovimiento,
                                    DescripcionMovimiento = @DescripcionMovimiento
                                WHERE id_inventario = @Id";

            using SqlCommand cmd = new(SQL, cn);

            cmd.Parameters.Add("@IdProducto", SqlDbType.Int).Value = inventario.IdProducto;
            cmd.Parameters.Add("@Stock", SqlDbType.Int).Value = inventario.Stock;
            cmd.Parameters.Add("@StockMinimo", SqlDbType.Int).Value = inventario.StockMinimo;
            cmd.Parameters.Add("@FechaActualizacion", SqlDbType.DateTime).Value = inventario.FechaActualizacion;
            cmd.Parameters.Add("@TipoMovimiento", SqlDbType.VarChar, 20).Value = inventario.TipoMovimiento;
            cmd.Parameters.Add("@DescripcionMovimiento", SqlDbType.VarChar, 200).Value = inventario.DescripcionMovimiento;
            cmd.Parameters.Add("@Id", SqlDbType.Int).Value = inventario.IdInventario;

            cmd.ExecuteNonQuery();
        }

        public void Eliminar(int id)
        {
            using SqlConnection cn = new(ConexionDB.Cadena);
            cn.Open();

            const string SQL = "DELETE FROM Inventario WHERE id_inventario = @Id";

            using SqlCommand cmd = new(SQL, cn);

            cmd.Parameters.Add("@Id", SqlDbType.Int).Value = id;

            cmd.ExecuteNonQuery();
        }

       

        public void Guardar(Inventario inventario)
        {
            using SqlConnection cn = new(ConexionDB.Cadena);
            cn.Open();

            const string SQL = @"INSERT INTO Inventario
                                (id_producto, stock, stock_minimo, fecha_actualizacion, tipo_movimiento, DescripcionMovimiento)
                                VALUES
                                (@IdProducto, @Stock, @StockMinimo, @FechaActualizacion, @TipoMovimiento, @DescripcionMovimiento)";

            using SqlCommand cmd = new(SQL, cn);

            cmd.Parameters.Add("@IdProducto", SqlDbType.Int).Value = inventario.IdProducto;
            cmd.Parameters.Add("@Stock", SqlDbType.Int).Value = inventario.Stock;
            cmd.Parameters.Add("@StockMinimo", SqlDbType.Int).Value = inventario.StockMinimo;
            cmd.Parameters.Add("@FechaActualizacion", SqlDbType.DateTime).Value = inventario.FechaActualizacion;
            cmd.Parameters.Add("@TipoMovimiento", SqlDbType.VarChar, 20).Value = inventario.TipoMovimiento;
            cmd.Parameters.Add("@DescripcionMovimiento", SqlDbType.VarChar, 200).Value = inventario.DescripcionMovimiento;

            cmd.ExecuteNonQuery();
        }

        public DataTable Listar()
        {
            DataTable table = new();

            using SqlConnection cn = new(ConexionDB.Cadena);
            cn.Open();

            const string SQL = @"SELECT
                                    id_inventario,
                                    id_producto,
                                    stock,
                                    stock_minimo,
                                    fecha_actualizacion,
                                    tipo_movimiento,
                                    DescripcionMovimiento
                                 FROM Inventario";

            using SqlDataAdapter da = new(SQL, cn);

            da.Fill(table);

            return table;
        }



        public DataTable ListarPorTipoMovimiento(string tipoMovimiento)
        {
            throw new NotImplementedException();
        }

        public DataTable ListarStockBajo()
        {
            throw new NotImplementedException();
        }

        public Inventario? ObtenerPorId(int id)
        {
            throw new NotImplementedException();
        }

        public bool ExisteProductoEnInventario(int idProducto)
        {
            throw new NotImplementedException();
        }
    }
}
