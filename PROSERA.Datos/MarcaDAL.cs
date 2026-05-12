using Microsoft.Data.SqlClient;
using PROSERA.Entidades;

namespace PROSERA.Datos
{
    public class MarcaDAL : IMarcaDAL
    {
        public void Agregar(Marca marca)
        {
            using SqlConnection cn = new(ConexionDB.Cadena);
            cn.Open();

            string query = "INSERT INTO Marcas (marca) VALUES (@Marca)";

            using SqlCommand cmd = new(query, cn);
            cmd.Parameters.AddWithValue("@Marca", marca.MarcaNombre);

            cmd.ExecuteNonQuery();
        }

        public void Editar(Marca m)
        {
            using SqlConnection cn = new(ConexionDB.Cadena);
            cn.Open();

            string query = @"UPDATE Marcas 
                             SET marca = @Marca 
                             WHERE id_marca = @IdMarca";

            using SqlCommand cmd = new(query, cn);
            cmd.Parameters.AddWithValue("@IdMarca", m.IdMarca);
            cmd.Parameters.AddWithValue("@Marca", m.MarcaNombre);

            cmd.ExecuteNonQuery();
        }

        public void Eliminar(int id)
        {
            using SqlConnection cn = new(ConexionDB.Cadena);
            cn.Open();

            string query = "DELETE FROM Marcas WHERE id_marca = @IdMarca";

            using SqlCommand cmd = new(query, cn);
            cmd.Parameters.AddWithValue("@IdMarca", id);

            cmd.ExecuteNonQuery();
        }

        public Marca ObtenerPorId(int id)
        {
            Marca? marca = null;

            using SqlConnection cn = new(ConexionDB.Cadena);
            cn.Open();

            string query = "SELECT id_marca, marca FROM Marcas WHERE id_marca = @IdMarca";

            using SqlCommand cmd = new(query, cn);
            cmd.Parameters.AddWithValue("@IdMarca", id);

            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                marca = new Marca
                {
                    IdMarca = (int)reader["id_marca"],
                    MarcaNombre = (string)reader["marca"]
                };
            }

            return marca;
        }

        public List<Marca> Listar()
        {
            List<Marca> lista = new();

            using SqlConnection cn = new(ConexionDB.Cadena);
            cn.Open();

            string query = "SELECT id_marca, marca FROM Marcas";

            using SqlCommand cmd = new(query, cn);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                lista.Add(new Marca
                {
                    IdMarca = (int)reader["id_marca"],
                    MarcaNombre = (string)reader["marca"]
                });
            }

            return lista;
        }

        public List<Marca> BuscarMarcas(string marca)
        {
            List<Marca> lista = new();

            using SqlConnection cn = new(ConexionDB.Cadena);
            cn.Open();

            string query = @"SELECT id_marca, marca 
                             FROM Marcas 
                             WHERE marca = @Marca";

            using SqlCommand cmd = new(query, cn);
            cmd.Parameters.AddWithValue("@Marca", marca);

            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                lista.Add(new Marca
                {
                    IdMarca = (int)reader["id_marca"],
                    MarcaNombre = (string)reader["marca"]
                });
            }

            return lista;
        }
    }
}