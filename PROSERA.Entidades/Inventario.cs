using System;
using System.Collections.Generic;
using System.Text;

namespace PROSERA.Entidades
{
    public class Inventario
    {
        public int IdInventario { get; set; }
        public int IdProducto { get; set; }
        public int Stock { get; set; }
        public int StockMinimo { get; set; }
        public DateTime FechaActualizacion { get; set; }
        public string TipoMovimiento { get; set; }
        public string DescripcionMovimiento { get; set; }

        public Producto Producto { get; set; }
    }
}
