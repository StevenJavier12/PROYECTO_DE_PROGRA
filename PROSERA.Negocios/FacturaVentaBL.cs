using PROSERA.Datos;
using PROSERA.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace PROSERA.Negocios
{
    public class FacturaVentaBL : IFacturaVentaBL
    {
        private readonly IFacturaVentaDAL _facturaDAL;

        public FacturaVentaBL(IFacturaVentaDAL facturaDAL)
        {
            _facturaDAL = facturaDAL;
        }

        public void Guardar(FacturaVenta factura)
        {
            if (factura.Fecha == DateTime.MinValue)
                throw new Exception("La fecha de la factura es obligatoria.");

            if (factura.IdCliente <= 0)
                throw new Exception("El cliente no es válido.");

            if (factura.IdUsuario <= 0)
                throw new Exception("El usuario no es válido.");

            if (factura.Total <= 0)
                throw new Exception("El total debe ser mayor a cero.");

            if (string.IsNullOrWhiteSpace(factura.MetodoPago))
                throw new Exception("El método de pago es obligatorio.");

            if (string.IsNullOrWhiteSpace(factura.EstadoFactura))
                throw new Exception("El estado de la factura es obligatorio.");

            _facturaDAL.Guardar(factura);
        }

        public void Editar(FacturaVenta factura)
        {
            if (factura.IdFactura <= 0)
                throw new Exception("La factura no es válida.");

            if (factura.Fecha == DateTime.MinValue)
                throw new Exception("La fecha de la factura es obligatoria.");

            if (factura.IdCliente <= 0)
                throw new Exception("El cliente no es válido.");

            if (factura.IdUsuario <= 0)
                throw new Exception("El usuario no es válido.");

            if (factura.Total <= 0)
                throw new Exception("El total debe ser mayor a cero.");

            if (string.IsNullOrWhiteSpace(factura.MetodoPago))
                throw new Exception("El método de pago es obligatorio.");

            if (string.IsNullOrWhiteSpace(factura.EstadoFactura))
                throw new Exception("El estado de la factura es obligatorio.");

            _facturaDAL.Editar(factura);
        }

        public void Eliminar(int id)
        {
            if (id <= 0)
                throw new Exception("La factura no es válida.");

            _facturaDAL.Eliminar(id);
        }

        public DataTable Listar()
        {
            return _facturaDAL.Listar();
        }
        






        public DataTable ListarPorCliente(int idCliente)
        {
            throw new NotImplementedException();
        }

        public DataTable ListarPorFecha(DateTime fechaInicio, DateTime fechaFin)
        {
            throw new NotImplementedException();
        }

        public FacturaVenta? ObtenerPorId(int id)
        {
            throw new NotImplementedException();
        }

        public bool ExisteFactura(int idFactura)
        {
            throw new NotImplementedException();
        }
    }
}
