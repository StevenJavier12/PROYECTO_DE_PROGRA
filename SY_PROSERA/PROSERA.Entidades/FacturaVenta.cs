using System;
using System.Collections.Generic;

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
        public List<DetalleVenta> DetalleVentas { get; set; } = new();
    }

    public class DetalleVenta
    {
        public int IdProducto { get; set; }
        public int Cantidad { get; set; }
        public decimal PrecioUnitario { get; set; }
        public decimal Subtotal { get; set; }
    }
}
