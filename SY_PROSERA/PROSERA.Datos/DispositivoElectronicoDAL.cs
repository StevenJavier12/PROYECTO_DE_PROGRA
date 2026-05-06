using Microsoft.Data.SqlClient;
using PROSERA.Entidades;
using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace PROSERA.Datos
{
    internal class DispositivoElectronicoDAL : IDispositivoElectronicoDAL
    {

       
        public void Agregar(DispositivoElectronico dispositivo)
        {

            using SqlConnection cn = new(ConexionDB.Cadena);
            cn.Open();
            {
                string query = @"INSERT INTO [Dispositivos electrónicos]
                        (Tipo, Marca, Modelo, Estado, UnidadDeMedida, Descripcion) 
                        VALUES (@Tipo, @Marca, @Modelo, @Estado, @UnidadDeMedida, @Descripcion)";

                using SqlCommand cmd = new(query, cn);

                cmd.Parameters.AddWithValue("@Tipo", dispositivo.Tipo);
                cmd.Parameters.AddWithValue("@Marca", dispositivo.Marca);
                cmd.Parameters.AddWithValue("@Modelo", dispositivo.Modelo);
                cmd.Parameters.AddWithValue("@Estado", dispositivo.Estado);
                cmd.Parameters.AddWithValue("@UnidadDeMedida", dispositivo.UnidadDeMedida);
                cmd.Parameters.AddWithValue("@Descripcion", dispositivo.Descripcion);

                cn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public List<DispositivoElectronico> BuscarPorMarca(string marca)
        {
            List<DispositivoElectronico> lista = new List<DispositivoElectronico>();

            using SqlConnection cn = new(ConexionDB.Cadena);
            cn.Open();
            {
                string query = @"SELECT IdDispositivo, Tipo, Marca, Modelo, Estado, UnidadDeMedida, Descripcion 
                        FROM [Dispositivos electrónicos] 
                        WHERE Marca = @Marca";

                using SqlCommand cmd = new(query, cn);
                cmd.Parameters.AddWithValue("@Marca", marca);

                cn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    DispositivoElectronico dispositivo = new DispositivoElectronico
                    {
                        IdDispositivo = (int)reader["IdDispositivo"],
                        Tipo = (string)reader["Tipo"],
                        Marca = (string)reader["Marca"],
                        Modelo = (string)reader["Modelo"],
                        Estado = (string)reader["Estado"],
                        UnidadDeMedida = (int)reader["UnidadDeMedida"],
                        Descripcion = (string)reader["Descripcion"]
                    };

                    lista.Add(dispositivo);
                }
            }

            return lista;
        }

        public List<DispositivoElectronico> BuscarPorTipo(string tipo)
        {
            List<DispositivoElectronico> lista = new List<DispositivoElectronico>();

            using SqlConnection cn = new(ConexionDB.Cadena);
            {
                string query = @"SELECT IdDispositivo, Tipo, Marca, Modelo, Estado, UnidadDeMedida, Descripcion 
                        FROM [Dispositivos electrónicos] 
                        WHERE Tipo = @Tipo";

                using SqlCommand cmd = new(query, cn);
                cmd.Parameters.AddWithValue("@Tipo", tipo);

                cn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    DispositivoElectronico dispositivo = new DispositivoElectronico
                    {
                        IdDispositivo = (int)reader["IdDispositivo"],
                        Tipo = (string)reader["Tipo"],
                        Marca = (string)reader["Marca"],
                        Modelo = (string)reader["Modelo"],
                        Estado = (string)reader["Estado"],
                        UnidadDeMedida = (int)reader["UnidadDeMedida"],
                        Descripcion = (string)reader["Descripcion"]
                    };

                    lista.Add(dispositivo);
                }
            }

            return lista;
        }

        public void Editar(DispositivoElectronico dispositivo)
        {
            using SqlConnection cn = new(ConexionDB.Cadena);
            {
                string query = @"UPDATE [Dispositivos electrónicos] 
                        SET Tipo = @Tipo, Marca = @Marca, Modelo = @Modelo, 
                            Estado = @Estado, UnidadDeMedida = @UnidadDeMedida, Descripcion = @Descripcion 
                        WHERE IdDispositivo = @IdDispositivo";

                SqlCommand cmd = new SqlCommand(query, cn);

                cmd.Parameters.AddWithValue("@IdDispositivo", dispositivo.IdDispositivo);
                cmd.Parameters.AddWithValue("@Tipo", dispositivo.Tipo);
                cmd.Parameters.AddWithValue("@Marca", dispositivo.Marca);
                cmd.Parameters.AddWithValue("@Modelo", dispositivo.Modelo);
                cmd.Parameters.AddWithValue("@Estado", dispositivo.Estado);
                cmd.Parameters.AddWithValue("@UnidadDeMedida", dispositivo.UnidadDeMedida);
                cmd.Parameters.AddWithValue("@Descripcion", dispositivo.Descripcion);

                cn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void Eliminar(int id)
        {
            using SqlConnection cn = new(ConexionDB.Cadena);
            {
                string query = @"DELETE FROM [Dispositivos electrónicos] 
                        WHERE IdDispositivo = @IdDispositivo";

                using SqlCommand cmd = new(query, cn);
                cmd.Parameters.AddWithValue("@IdDispositivo", id);

                cn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public List<DispositivoElectronico> Listar()
        {
            List<DispositivoElectronico> lista = new List<DispositivoElectronico>();

            using SqlConnection cn = new(ConexionDB.Cadena);
            {
                string query = @"SELECT IdDispositivo, Tipo, Marca, Modelo, Estado, UnidadDeMedida, Descripcion 
                        FROM [Dispositivos electrónicos]";

                using SqlCommand cmd = new(query, cn);

                cn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    DispositivoElectronico dispositivo = new DispositivoElectronico
                    {
                        IdDispositivo = (int)reader["IdDispositivo"],
                        Tipo = (string)reader["Tipo"],
                        Marca = (string)reader["Marca"],
                        Modelo = (string)reader["Modelo"],
                        Estado = (string)reader["Estado"],
                        UnidadDeMedida = (int)reader["UnidadDeMedida"],
                        Descripcion = (string)reader["Descripcion"]
                    };

                    lista.Add(dispositivo);
                }
            }

            return lista;
        }

        public DispositivoElectronico ObtenerPorId(int id)
        {
            DispositivoElectronico? dispositivo = null;

            using SqlConnection cn = new(ConexionDB.Cadena);
            {
                string query = @"SELECT IdDispositivo, Tipo, Marca, Modelo, Estado, UnidadDeMedida, Descripcion 
                        FROM [Dispositivos electrónicos] 
                        WHERE IdDispositivo = @IdDispositivo";

                using SqlCommand cmd = new(query, cn);
                cmd.Parameters.AddWithValue("@IdDispositivo", id);

                cn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    dispositivo = new DispositivoElectronico
                    {
                        IdDispositivo = (int)reader["IdDispositivo"],
                        Tipo = (string)reader["Tipo"],
                        Marca = (string)reader["Marca"],
                        Modelo = (string)reader["Modelo"],
                        Estado = (string)reader["Estado"],
                        UnidadDeMedida = (int)reader["UnidadDeMedida"],
                        Descripcion = (string)reader["Descripcion"]
                    };
                }
            }

            return dispositivo;
        }
    }
}
