using PROSERA.Datos;
using PROSERA.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace PROSERA.Negocios
{
    public class DetalleVentaBL : IDetalleVentaBL
    {
        private readonly DetalleVentaDAL _detalleVentaDAL;

        public DetalleVentaBL(DetalleVentaDAL detalleVentaDAL)
        {
            _detalleVentaDAL = detalleVentaDAL;
        }

        public void Agregar(DetalleVenta detalle)
        {
            if (detalle == null)
                throw new ArgumentNullException(nameof(detalle), "El detalle de venta no puede ser nulo");

            if (detalle.IdFactura <= 0)
                throw new ArgumentException("El ID de factura debe ser válido");

            if (detalle.IdProducto <= 0)
                throw new ArgumentException("El ID de producto debe ser válido");

            if (detalle.Cantidad <= 0)
                throw new ArgumentException("La cantidad debe ser mayor a 0");

            if (detalle.PrecioUnitario <= 0)
                throw new ArgumentException("El precio unitario debe ser mayor a 0");


            detalle.Subtotal = detalle.Cantidad * detalle.PrecioUnitario;

            try
            {
                _detalleVentaDAL.Agregar(detalle);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al agregar el detalle de venta: " + ex.Message);
            }
        }

        public void Editar(DetalleVenta detalle)
        {
            if (detalle == null)
                throw new ArgumentNullException(nameof(detalle), "El detalle de venta no puede ser nulo");

            if (detalle.IdDetalle <= 0)
                throw new ArgumentException("El ID del detalle debe ser válido");

            if (detalle.IdFactura <= 0)
                throw new ArgumentException("El ID de factura debe ser válido");

            if (detalle.IdProducto <= 0)
                throw new ArgumentException("El ID de producto debe ser válido");

            if (detalle.Cantidad <= 0)
                throw new ArgumentException("La cantidad debe ser mayor a 0");

            if (detalle.PrecioUnitario <= 0)
                throw new ArgumentException("El precio unitario debe ser mayor a 0");


            detalle.Subtotal = detalle.Cantidad * detalle.PrecioUnitario;

            try
            {
                _detalleVentaDAL.Editar(detalle);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al editar el detalle de venta: " + ex.Message);
            }
        }

        public void Eliminar(int id)
        {
            if (id <= 0)
                throw new ArgumentException("El ID debe ser válido");

            try
            {
                _detalleVentaDAL.Eliminar(id);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al eliminar el detalle de venta: " + ex.Message);
            }
        }

        public List<DetalleVenta> Listar()
        {
            try
            {
                return _detalleVentaDAL.Listar();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al listar los detalles de venta: " + ex.Message);
            }
        }

        public DataTable ListarPorFactura(int idFactura)
        {
            throw new NotImplementedException();
        }

        public DetalleVenta ObtenerPorId(int id)
        {
            if (id <= 0)
                throw new ArgumentException("El ID debe ser válido");

            try
            {
                return _detalleVentaDAL.ObtenerPorId(id);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener el detalle de venta: " + ex.Message);
            }
        }

       
    }
}