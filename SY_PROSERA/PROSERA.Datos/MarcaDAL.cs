using Microsoft.Data.SqlClient;
using PROSERA.Entidades;
using System;
using System.Collections.Generic;
using System.Text;
using PROSERA.Entidades;

namespace PROSERA.Datos
{
    public class MarcaDAL : IMarcaDAL
    {
       
        public void Agregar(Marca marca)
        {
            using SqlConnection cn = new(ConexionDB.Cadena);
            cn.Open();
            {
                string query = @"INSERT INTO Marca (NombreMarca) 
                            VALUES (@NombreMarca)";

                using SqlCommand cmd = new(query, cn);
                cmd.Parameters.AddWithValue("@NombreMarca", marca.MarcaNombre);

                cn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void Editar(Marca marca)
        {
            using SqlConnection cn = new(ConexionDB.Cadena);
            {
                string query = @"UPDATE Marca 
                            SET NombreMarca = @NombreMarca 
                            WHERE IdMarca = @IdMarca";

                using SqlCommand cmd = new(query, cn);
                cmd.Parameters.AddWithValue("@IdMarca", marca.IdMarca);
                cmd.Parameters.AddWithValue("@NombreMarca", marca.MarcaNombre);

                cn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void Eliminar(int id)
        {
            using SqlConnection cn = new(ConexionDB.Cadena);
            {
                string query = @"DELETE FROM Marca 
                            WHERE IdMarca = @IdMarca";

                using SqlCommand cmd = new(query, cn);
                cmd.Parameters.AddWithValue("@IdMarca", id);

                cn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public Marca ObtenerPorId(int id)
        {
            Marca marca = null;

            using SqlConnection cn = new(ConexionDB.Cadena);
            {
                string query = @"SELECT IdMarca, NombreMarca 
                            FROM Marca 
                            WHERE IdMarca = @IdMarca";

                using SqlCommand cmd = new(query, cn);
                cmd.Parameters.AddWithValue("@IdMarca", id);

                cn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    marca = new Marca
                    {
                        IdMarca = (int)reader["IdMarca"],
                        MarcaNombre = (string)reader["NombreMarca"]
                    };
                }
            }

            return marca;
        }

        public List<Marca> Listar()
        {
            List<Marca> lista = new List<Marca>();

            using SqlConnection cn = new(ConexionDB.Cadena);
            {
                string query = @"SELECT IdMarca, NombreMarca 
                            FROM Marca";

                using SqlCommand cmd = new(query, cn);

                cn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Marca marca = new Marca
                    {
                        IdMarca = (int)reader["IdMarca"],
                       MarcaNombre = (string)reader["NombreMarca"]
                    };

                    lista.Add(marca);
                }
            }

            return lista;
        }

        public List<Marca> BuscarMarcas(string marca)
        {
            List<Marca> lista = new List<Marca>();

            using SqlConnection cn = new(ConexionDB.Cadena);
            {
                string query = @"SELECT IdMarca, NombreMarca 
                            FROM Marca 
                            WHERE NombreMarca = @NombreMarca";

                using SqlCommand cmd = new(query, cn);
                cmd.Parameters.AddWithValue("@NombreMarca", marca);

                cn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Marca marcaResultado = new Marca
                    {
                        IdMarca = (int)reader["IdMarca"],
                      MarcaNombre = (string)reader["NombreMarca"]
                    };

                    lista.Add(marcaResultado);
                }
            }

            return lista;
        }
    }
}
