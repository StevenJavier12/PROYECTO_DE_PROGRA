using PROSERA.Datos;
using PROSERA.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace PROSERA.Negocios
{
    internal class DetalleVentaBL : IDetalleVentaBL
    {

        private readonly IDetalleVentaDAL _detalleVentaDAL;

        public DetalleVentaBL(IDetalleVentaDAL detalleVentaDAL)
        {
            _detalleVentaDAL = detalleVentaDAL;
        }

        public void Agregar(DetalleVenta detalle)
        {
            if (detalle.IdFactura <= 0)
                throw new Exception("La factura no es válida.");

            if (detalle.IdProducto <= 0)
                throw new Exception("El producto no es válido.");

            if (detalle.Cantidad <= 0)
                throw new Exception("La cantidad debe ser mayor a cero.");

            if (detalle.PrecioUnitario <= 0)
                throw new Exception("El precio unitario debe ser mayor a cero.");

            if (detalle.Subtotal <= 0)
                throw new Exception("El subtotal debe ser mayor a cero.");

            _detalleVentaDAL.Agregar(detalle);
        }

        public void Editar(DetalleVenta detalle)
        {
            if (detalle.IdDetalle <= 0)
                throw new Exception("El detalle de venta no es válido.");

            if (detalle.IdFactura <= 0)
                throw new Exception("La factura no es válida.");

            if (detalle.IdProducto <= 0)
                throw new Exception("El producto no es válido.");

            if (detalle.Cantidad <= 0)
                throw new Exception("La cantidad debe ser mayor a cero.");

            if (detalle.PrecioUnitario <= 0)
                throw new Exception("El precio unitario debe ser mayor a cero.");

            if (detalle.Subtotal <= 0)
                throw new Exception("El subtotal debe ser mayor a cero.");

            _detalleVentaDAL.Editar(detalle);
        }

        public void Eliminar(int id)
        {
            if (id <= 0)
                throw new Exception("El detalle de venta no es válido.");

            _detalleVentaDAL.Eliminar(id);
        }

        

        public DataTable Listar()
        {
            return _detalleVentaDAL.Listar();
        }

        public DataTable ListarPorFactura(int idFactura)
        {
            throw new NotImplementedException();
        }

        public DetalleVenta? ObtenerPorId(int id)
        {
            throw new NotImplementedException();
        }
    }
}
