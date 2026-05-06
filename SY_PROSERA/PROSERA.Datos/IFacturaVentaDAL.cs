using PROSERA.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Data;

namespace PROSERA.Datos
{

    public interface IFacturaVentaDAL
    {
        void Guardar(FacturaVenta factura);
        DataTable Listar();
        void Eliminar(int id);
    }

   
    
}

namespace PROSERA.Datos
{
    public class FacturaVenta
    {
        internal int IdFactura;

        // Clase mínima para resolver CS0246.
        // Añade propiedades según lo requiera la aplicación.
        public IEnumerable<object> DetalleVentas { get; internal set; }
        public int IdCliente { get; set; }
        public int IdUsuario { get; set; }
        public int Total { get; set; }
        public object Fecha { get; internal set; }
        public object Descuento { get; internal set; }
        public object MetodoPago { get; internal set; }
        public object EstadoFactura { get; internal set; }
    }
}
