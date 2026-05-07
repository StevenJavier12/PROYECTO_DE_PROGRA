using Microsoft.Data.SqlClient;
using PROSERA.Entidades;
using System.Data;

namespace PROSERA.Datos
{
    public class CategoriaProductoDAL : ICategoriaProductoDAL
    {


        /*
         CREATE TABLE Categoria_Productos (
            id_categoria INT PRIMARY KEY IDENTITY (1,1),
            nombre VARCHAR(100) NOT NULL,
            descripcion VARCHAR(200) NOT NULL
         );
         */

        public void Guardar(CategoriaProducto categoria)
        {
            using SqlConnection cn = new(ConexionDB.Cadena);
            cn.Open();

            const string SQL = "INSERT INTO Categoria_Productos (nombre, descripcion) VALUES (@Nombre, @Descripcion)";
            using SqlCommand cmd = new(SQL, cn);

            cmd.Parameters.Add(@"Nombre", SqlDbType.VarChar, 100).Value = categoria.Nombre;
            cmd.Parameters.Add(@"Descripcion", SqlDbType.VarChar, 200).Value = categoria.Descripcion;
            cmd.ExecuteNonQuery();
        }

        public void Editar(CategoriaProducto categoria)
        {
            using SqlConnection cn = new(ConexionDB.Cadena);
            cn.Open();

            const string SQL = "UPDATE Categoria_Productos SET nombre = @Nombre, descripcion = @Descripcion WHERE id_categoria = @Id";
            using SqlCommand cmd = new(SQL, cn);
            cmd.Parameters.Add(@"Nombre", SqlDbType.VarChar, 100).Value = categoria.Nombre;
            cmd.Parameters.Add(@"Descripcion", SqlDbType.VarChar, 200).Value = categoria.Descripcion;
            cmd.Parameters.Add(@"Id", SqlDbType.Int).Value = categoria.IdCategoria;
            cmd.ExecuteNonQuery();
        }

        public void Eliminar(int id)
        {
            using SqlConnection cn = new(ConexionDB.Cadena);
            cn.Open();

            const string SQL = "DELETE FROM Categoria_Productos WHERE id_categoria = @Id";
            using SqlCommand cmd = new(SQL, cn);
            cmd.Parameters.Add(@"Id", SqlDbType.Int).Value = id;
            cmd.ExecuteNonQuery();
        }

        public DataTable Listar()
        {
            DataTable table = new();
            using SqlConnection cn = new(ConexionDB.Cadena);
            cn.Open();

            const string SQL = "SELECT id_categoria, nombre, descripcion FROM Categoria_Productos";

            using SqlDataAdapter da = new(SQL, cn);
            da.Fill(table);
            return table;
        }


        //Hasta aqui el CRUD basico, ahora los metodos adicionales

        public CategoriaProducto? ObtenerPorId(int id)
        {
            using SqlConnection cn = new(ConexionDB.Cadena);
            cn.Open();

            string sql = "SELECT id_categoria, nombre, descripcion FROM Categoria_Productos WHERE id_categoria = @Id";

            using SqlCommand cmd = new(sql, cn);
            cmd.Parameters.Add("@Id", SqlDbType.Int).Value = id;

            using SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read()) return null;

            
            return new CategoriaProducto
            {
                IdCategoria = Convert.ToInt32(dr["id_categoria"]),
                Nombre = dr["nombre"]?.ToString() ?? string.Empty,
                Descripcion = dr["descripcion"]?.ToString() ?? string.Empty
            };
                
        }

        public bool ExistePorNombre(string nombre, int? excluirId = null)
        {
            using SqlConnection cn = new(ConexionDB.Cadena);
            cn.Open();

            string sql = "SELECT COUNT(*) FROM Categoria_Productos WHERE nombre = @Nombre";

            if (excluirId.HasValue)
            {
                sql += " AND id_categoria <> @ExcluirId";
            }

            using SqlCommand cmd = new(sql, cn);

            cmd.Parameters.Add("@Nombre", SqlDbType.VarChar, 100).Value = nombre;

            if (excluirId.HasValue)
            {
                cmd.Parameters.Add("@ExcluirId", SqlDbType.Int).Value = excluirId.Value;
            }

            int total = Convert.ToInt32(cmd.ExecuteScalar());

            return total > 0;
        }


        public bool TieneProductosRelacionados(int categoriaId)
        {
            using SqlConnection cn = new(ConexionDB.Cadena);
            cn.Open();

            string sql = "SELECT COUNT(*) FROM Productos WHERE id_categoria = @CategoriaId";
            using SqlCommand cmd = new(sql, cn);
            cmd.Parameters.Add("@CategoriaId", SqlDbType.Int).Value = categoriaId;

            int total = Convert.ToInt32(cmd.ExecuteScalar());

            return total > 0;
        }
    }
}