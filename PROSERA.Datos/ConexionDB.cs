using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;

namespace PROSERA.Datos
{
    public class ConexionDB
    {
        public static string Cadena =>
            ConfigurationManager.ConnectionStrings["PROSERADB"].ConnectionString
            ?? throw new InvalidOperationException("No se encontrro la conexion PROSERADB");
    }
}
