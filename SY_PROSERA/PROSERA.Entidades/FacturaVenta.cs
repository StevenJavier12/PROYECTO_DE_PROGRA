using System;
using System.Collections.Generic;
using System.Text;

namespace PROSERA.Entidades
{
    public class FacturaVenta
    {
        public int IdFactura { get; set; }
        public DateTime Fecha { get; set; }
        public int IdCliente { get; set; }
        public int IdUsuario { get; set; }
        public decimal Total { get; set; }
        public decimal Descuento { get; set; }
        public string MetodoPago { get; set; }
        public string EstadoFactura { get; set; }

        public Cliente Cliente { get; set; }
        public Usuario Usuario { get; set; }

        public List<DetalleVenta> DetalleVentas { get; set; }
    }
}
