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
<<<<<<< HEAD

        private readonly IDetalleVentaDAL _detalleVentaDAL;

        public DetalleVentaBL(IDetalleVentaDAL detalleVentaDAL)
=======
        private readonly DetalleVentaDAL _detalleVentaDAL;

        public DetalleVentaBL(DetalleVentaDAL detalleVentaDAL)
>>>>>>> 3b7990587225094801f1cbf15aa4fb63d6d8315c
        {
            _detalleVentaDAL = detalleVentaDAL;
        }

        public void Agregar(DetalleVenta detalle)
        {
<<<<<<< HEAD
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
=======
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
>>>>>>> 3b7990587225094801f1cbf15aa4fb63d6d8315c
        }

        public void Editar(DetalleVenta detalle)
        {
<<<<<<< HEAD
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
=======
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
>>>>>>> 3b7990587225094801f1cbf15aa4fb63d6d8315c
        }

        public void Eliminar(int id)
        {
            if (id <= 0)
<<<<<<< HEAD
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
=======
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
>>>>>>> 3b7990587225094801f1cbf15aa4fb63d6d8315c
        }
    }
}
