using PROSERA.Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace PROSERA.Negocios
{
    internal class FacturaVentaBL : IFacturaVentaBL
    {
        private readonly IFacturaVentaDAL _facturaDAL;

        public FacturaVentaBL(IFacturaVentaDAL facturaDAL)
        {
            _facturaDAL = facturaDAL;
        }

        public void Guardar(FacturaVenta factura)
        {
            // 🔴 VALIDACIONES

            if (factura == null)
                throw new Exception("La factura no puede ser nula.");

            if (factura.IdCliente <= 0)
                throw new Exception("Debe seleccionar un cliente.");

            if (factura.IdUsuario <= 0)
                throw new Exception("Debe seleccionar un usuario.");

            if (factura.DetalleVentas == null || !factura.DetalleVentas.Any())
                throw new Exception("Debe agregar al menos un producto.");

            if (factura.Total <= 0)
                throw new Exception("El total debe ser mayor a 0.");

            
            foreach (dynamic item in factura.DetalleVentas)
            {
                if (item.IdProducto <= 0)
                    throw new Exception("Producto inválido.");

                if (item.Cantidad <= 0)
                    throw new Exception("Cantidad inválida.");

                if (item.PrecioUnitario <= 0)
                    throw new Exception("Precio inválido.");
            }

            // ✅ GUARDAR
            _facturaDAL.Guardar(factura);
        }

        public void Eliminar(int id)
        {
            if (id <= 0)
                throw new Exception("ID inválido.");

            _facturaDAL.Eliminar(id);
        }

        public DataTable Listar()
        {
            return _facturaDAL.Listar();
        }

        // Implementación explícita de la interfaz para asegurar coincidencia exacta de firma
        void IFacturaVentaBL.Guardar(FacturaVenta factura)
        {
            Guardar(factura);
        }

        public void Guardar(Entidades.FacturaVenta factura)
        {
            throw new NotImplementedException();
        }
    }
}
