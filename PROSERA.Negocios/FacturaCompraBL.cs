using PROSERA.Datos;
using PROSERA.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace PROSERA.Negocios
{
    public class FacturaCompraBL : IFacturaCompraBL
    {
        private readonly IFacturaCompraDAL _facturaCompraDAL;

        public FacturaCompraBL(IFacturaCompraDAL facturaCompraDAL)
        {
            _facturaCompraDAL = facturaCompraDAL;
        }

        public void Guardar(FacturaCompra factura)
        {
            if (factura.Fecha == DateTime.MinValue)
                throw new Exception("La fecha de la compra es obligatoria.");

            if (factura.IdProveedor <= 0)
                throw new Exception("El proveedor no es válido.");

            if (factura.Total <= 0)
                throw new Exception("El total debe ser mayor a cero.");

            if (string.IsNullOrWhiteSpace(factura.TipoComprobante))
                throw new Exception("El tipo de comprobante es obligatorio.");

            _facturaCompraDAL.Guardar(factura);
        }

        public void Eliminar(int id)
        {
            if (id <= 0)
                throw new Exception("La compra no es válida.");

            _facturaCompraDAL.Eliminar(id);
        }

        public DataTable Listar()
        {
            return _facturaCompraDAL.Listar();
        }
    }
}
