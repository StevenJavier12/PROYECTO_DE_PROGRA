using System;
using System.Collections.Generic;
using System.Text;

namespace PROSERA.Entidades
{
    public class Cliente
    {
        public int IdCliente { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }
        public string Dui { get; set; }
        public string? Correo { get; set; }


        public List<FacturaVenta> FacturaVentas { get; set; }
        public List<RecepcionDispositivo> RecepcionDispositivos { get; set; }
    }
}
