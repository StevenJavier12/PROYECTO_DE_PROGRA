using System;
using System.Collections.Generic;
using System.Text;

namespace PROSERA.Entidades
{
    public class Usuario
    {
        public int IdUsuario { get; set; }
        public string Username { get; set; }
        public string Contraseña { get; set; }
        public string Rol { get; set; }
        public string EstadoUser { get; set; }
        public int? IdEmpleado { get; set; }

        public Empleado? Empleado { get; set; }

        public List<FacturaVenta> FacturaVentas { get; set; }
        public List<RecepcionDispositivo> RecepcionDispositivos { get; set; }
    }
}
