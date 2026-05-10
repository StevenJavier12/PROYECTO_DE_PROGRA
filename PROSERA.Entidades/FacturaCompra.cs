using System;
using System.Collections.Generic;
using System.Text;

namespace PROSERA.Entidades
{
    public class FacturaCompra
    {
        public int IdCompra { get; set; }
        public DateTime Fecha { get; set; }
        public int IdProveedor { get; set; }
        public decimal Total { get; set; }
        public string TipoComprobante { get; set; }

        public Proveedor Proveedor { get; set; }
        public List<DetalleCompra> DetalleCompras { get; set; }
    }
}
