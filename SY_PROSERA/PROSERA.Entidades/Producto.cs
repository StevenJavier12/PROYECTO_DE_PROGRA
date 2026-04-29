using System;
using System.Collections.Generic;
using System.Text;

namespace PROSERA.Entidades
{
    public class Producto
    {
        public int IdProducto { get; set; }
        public string Nombre { get; set; }
        public string? Descripcion { get; set; }
        public decimal PrecioUnitario { get; set; }
        public int IdMarca { get; set; }
        public string EstadoProducto { get; set; }
        public int IdCategoria { get; set; }

        public Marca Marca { get; set; }
        public CategoriaProducto CategoriaProducto { get; set; }

        public List<DetalleVenta> DetalleVentas { get; set; }
        public List<DetalleCompra> DetalleCompras { get; set; }
    }
}
