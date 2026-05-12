using System;
using System.Collections.Generic;
using System.Text;

namespace PROSERA.Entidades
{
    public class DetalleVenta
    {
        public int IdDetalle { get; set; }
        public int IdFactura { get; set; }
        public string NombreProducto { get; set; }
        public int IdProducto { get; set; }
        public int Cantidad { get; set; }
        public decimal PrecioUnitario { get; set; }
        public decimal Subtotal { get; set; }

        public FacturaVenta FacturaVenta { get; set; }
        public Producto Producto { get; set; }
    }
}
