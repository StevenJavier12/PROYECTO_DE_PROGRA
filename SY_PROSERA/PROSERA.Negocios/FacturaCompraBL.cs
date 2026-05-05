using PROSERA.Datos;
using PROSERA.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace PROSERA.Negocios
{
    internal class FacturaCompraBL : IFacturaCompraBL
    {
        private readonly IFacturaCompraDAL _facturaDAL;

        public FacturaCompraBL(IFacturaCompraDAL facturaDAL)
        {
            _facturaDAL = facturaDAL;
        }

        public void Guardar(FacturaCompra factura)
        {
            if (factura == null)
                throw new Exception("La factura no puede ser nula.");

            if (factura.IdProveedor <= 0)
                throw new Exception("Debe seleccionar un proveedor.");

            if (factura.DetalleCompras == null || factura.DetalleCompras.Count == 0)
                throw new Exception("Debe agregar al menos un producto.");

            if (factura.Total <= 0)
                throw new Exception("El total debe ser mayor a 0.");

            foreach (var item in factura.DetalleCompras)
            {
                if (item.IdProducto <= 0)
                    throw new Exception("Producto inválido.");

                if (item.Cantidad <= 0)
                    throw new Exception("Cantidad inválida.");

                if (item.CostoUnitario <= 0)
                    throw new Exception("Costo inválido.");
            }

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
    }
}
