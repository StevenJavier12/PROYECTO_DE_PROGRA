using Microsoft.Data.SqlClient;
using PROSERA.Entidades;
using System.Data;

namespace PROSERA.Datos
{
    public class ProductoDAL : IProductoDAL
    {
        public void Editar(Producto producto)
        {
            using SqlConnection cn = new(ConexionDB.Cadena);
            cn.Open();

            const string SQL = @"UPDATE Productos
                            SET nombre = @nombre,
                                descripcion = @descripcion,
                                precio_unitario = @precio_unitario,
                                id_marca = @id_marca,
                                estado_producto = @estado_producto,
                                id_categoria = @id_categoria
                            WHERE id_producto = @id_producto";

            using SqlCommand cmd = new(SQL, cn);
            cmd.Parameters.Add("@nombre", SqlDbType.VarChar, 100).Value = producto.Nombre;
            cmd.Parameters.Add("@descripcion", SqlDbType.VarChar, 200).Value = producto.Descripcion;
            cmd.Parameters.Add("@precio_unitario", SqlDbType.Decimal).Value = producto.PrecioUnitario;
            cmd.Parameters.Add("@id_marca", SqlDbType.Int).Value = producto.IdMarca;
            cmd.Parameters.Add("@estado_producto", SqlDbType.VarChar, 20).Value = producto.EstadoProducto;
            cmd.Parameters.Add("@id_categoria", SqlDbType.Int).Value = producto.IdCategoria;
            cmd.Parameters.Add("@id_producto", SqlDbType.Int).Value = producto.IdProducto;

            cmd.ExecuteNonQuery();
        }
        //-----------------------------------------------------------------------------
        //-----------------------------------------------------------------------------

        public void Eliminar(int id)
        {
            using SqlConnection cn = new(ConexionDB.Cadena);
            cn.Open();

            const string SQL = "DELETE FROM Productos WHERE id_producto = @Id";
            using SqlCommand cmd = new(SQL, cn);
            cmd.Parameters.Add("@Id", SqlDbType.Int).Value = id;
            cmd.ExecuteNonQuery();
        }
        //-----------------------------------------------------------------------------
        //-----------------------------------------------------------------------------

        public bool ExistePorNombre(string nombre, int categoriaId, int? excluirId = null)
        {
            using SqlConnection cn = new(ConexionDB.Cadena);
            cn.Open();

            string sql = "SELECT COUNT(*) FROM Productos WHERE nombre = @Nombre AND id_categoria = @CategoriaId";
            if (excluirId.HasValue)
            {
                sql += " AND id_producto <> @ExcluirId";
            }
            
            using SqlCommand cmd = new(sql, cn);
            cmd.Parameters.Add("@Nombre", SqlDbType.VarChar, 100).Value = nombre;
            cmd.Parameters.Add("@CategoriaId", SqlDbType.Int).Value = categoriaId;
            
            if (excluirId.HasValue)
            {
                cmd.Parameters.Add("@ExcluirId", SqlDbType.Int).Value = excluirId.Value;
            }

            int count = (int)cmd.ExecuteScalar();
            return count > 0;
        }
        //-----------------------------------------------------------------------------
        //-----------------------------------------------------------------------------



        public void Guardar(Producto producto)
        {
            using SqlConnection cn = new(ConexionDB.Cadena);
            cn.Open();

            const string SQL = @"INSERT INTO Productos (nombre, descripcion, precio_unitario, id_marca, estado_producto, id_categoria)
                            VALUES (@nombre, @descripcion, @precio_unitario, @id_marca, @estado_producto, @id_categoria)";

            using SqlCommand cmd = new(SQL, cn);
            cmd.Parameters.Add("@nombre", SqlDbType.VarChar, 100).Value = producto.Nombre;
            cmd.Parameters.Add("@descripcion", SqlDbType.VarChar, 200).Value = producto.Descripcion;
            cmd.Parameters.Add("@precio_unitario", SqlDbType.Decimal).Value = producto.PrecioUnitario;
            cmd.Parameters.Add("@id_marca", SqlDbType.Int).Value = producto.IdMarca;
            cmd.Parameters.Add("@estado_producto", SqlDbType.VarChar, 20).Value = producto.EstadoProducto;
            cmd.Parameters.Add("@id_categoria", SqlDbType.Int).Value = producto.IdCategoria;
            cmd.ExecuteNonQuery();
        }
        //-----------------------------------------------------------------------------
        //-----------------------------------------------------------------------------

        public DataTable ListarConCategoria()
        {
            DataTable table = new();
            using SqlConnection cn = new(ConexionDB.Cadena);
            cn.Open();

            const string SQL = @"SELECT p.id_producto, p.nombre, p.descripcion, p.precio_unitario, p.id_marca, p.estado_producto, c.nombre AS categoria
                            FROM Productos p
                            INNER JOIN Categoria_Productos c ON p.id_categoria = c.id_categoria";

            using SqlDataAdapter da = new(SQL, cn);
            da.Fill(table);
            return table;
        }
        //-----------------------------------------------------------------------------
        //-----------------------------------------------------------------------------

        public Producto? ObtenerPorId(int id)
        {
            using SqlConnection cn = new(ConexionDB.Cadena);
            cn.Open();

            
            const string SQL = @"SELECT p.id_producto, p.nombre, p.descripcion, p.precio_unitario, p.id_marca, p.estado_producto, c.id_categoria, c.nombre AS categoria, m.nombre AS marca
                            FROM Productos p
                            INNER JOIN Categoria_Productos c ON p.id_categoria = c.id_categoria
                            INNER JOIN Marcas m ON p.id_marca = m.id_marca
                            WHERE p.id_producto = @Id";
            
            using SqlCommand cmd = new(SQL, cn);
            cmd.Parameters.Add("@Id", SqlDbType.Int).Value = id;

            using SqlDataReader dr = cmd.ExecuteReader();
            if (!dr.Read()) return null;
            
            return new Producto
            {
                IdProducto = Convert.ToInt32(dr["id_producto"]),
                Nombre = dr["nombre"]?.ToString() ?? string.Empty,
                Descripcion = dr["descripcion"]?.ToString(),
                PrecioUnitario = Convert.ToDecimal(dr["precio_unitario"]),
                IdMarca = Convert.ToInt32(dr["id_marca"]),

                Marca = dr["marca"].ToString() ?? string.Empty,

                EstadoProducto = dr["estado_producto"].ToString() ?? string.Empty,
                IdCategoria = Convert.ToInt32(dr["id_categoria"]),

                Categoria = dr["categoria"].ToString() ?? string.Empty
            };
            
        }
    }
}
