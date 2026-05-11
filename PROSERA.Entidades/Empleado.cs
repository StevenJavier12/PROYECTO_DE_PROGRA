using System;
using System.Collections.Generic;
using System.Text;

namespace PROSERA.Entidades
{
    public class Empleado
    {
        public int IdEmpleado { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Cargo { get; set; }
        public string Telefono { get; set; }
        public string Correo { get; set; }
        public string Direccion { get; set; }
        public string Dui { get; set; }

        public List<Usuario> Usuarios { get; set; }
    }
}
