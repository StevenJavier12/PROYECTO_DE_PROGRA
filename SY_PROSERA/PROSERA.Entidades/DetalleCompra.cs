using System;
using System.Collections.Generic;
using System.Text;

namespace PROSERA.Entidades
{
    public class DetalleCompra
    {
        public int IdDetalleCompra { get; set; }
        public int IdCompra { get; set; }
        public int IdProducto { get; set; }
        public int Cantidad { get; set; }
        public decimal CostoUnitario { get; set; }
        public decimal Subtotal { get; set; }

        public FacturaCompra FacturaCompra { get; set; }
        public Producto Producto { get; set; }
    }
}
