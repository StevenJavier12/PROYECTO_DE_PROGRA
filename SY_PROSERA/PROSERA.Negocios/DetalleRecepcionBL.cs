using PROSERA.Datos;
using PROSERA.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace PROSERA.Negocios
{


    internal class DetalleRecepcionBL : IDetalleRecepcionBL
    {
        private readonly IDetalleRecepcionDAL _detalleRecepcionDAL;

        public DetalleRecepcionBL(IDetalleRecepcionDAL detalleRecepcionDAL)
        {
            _detalleRecepcionDAL = detalleRecepcionDAL;
        }

        public void Guardar(DetalleRecepcion detalleRecepcion)
        {

            if (detalleRecepcion == null)
                throw new ArgumentNullException(nameof(detalleRecepcion), "El detalle de recepción no puede ser nulo");

            if (detalleRecepcion.IdRecepcion <= 0)
                throw new ArgumentException("El ID de recepción debe ser válido");

            if (detalleRecepcion.IdDispositivo <= 0)
                throw new ArgumentException("El ID del dispositivo debe ser válido");

            if (detalleRecepcion.Cantidad <= 0)
                throw new ArgumentException("La cantidad debe ser mayor a 0");

            try
            {

                _detalleRecepcionDAL.Agregar(detalleRecepcion);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al guardar el detalle de recepción: " + ex.Message);
            }
        }

        public void Editar(DetalleRecepcion detalleRecepcion)
        {

            if (detalleRecepcion == null)
                throw new ArgumentNullException(nameof(detalleRecepcion), "El detalle de recepción no puede ser nulo");

            if (detalleRecepcion.IdDetalle <= 0)
                throw new ArgumentException("El ID del detalle debe ser válido");

            if (detalleRecepcion.IdRecepcion <= 0)
                throw new ArgumentException("El ID de recepción debe ser válido");

            if (detalleRecepcion.IdDispositivo <= 0)
                throw new ArgumentException("El ID del dispositivo debe ser válido");

            if (detalleRecepcion.Cantidad <= 0)
                throw new ArgumentException("La cantidad debe ser mayor a 0");

            try
            {

                _detalleRecepcionDAL.Editar(detalleRecepcion);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al editar el detalle de recepción: " + ex.Message);
            }
        }

        public void Eliminar(int id)
        {

            if (id <= 0)
                throw new ArgumentException("El ID debe ser válido");

            try
            {

                _detalleRecepcionDAL.Eliminar(id);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al eliminar el detalle de recepción: " + ex.Message);
            }
        }

        public DataTable Listar()
        {
            try
            {
                return _detalleRecepcionDAL.Listar();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al listar los detalles de recepción: " + ex.Message);
            }
        }

        public DetalleRecepcion ObtenerPorId(int id)
        {
            if (id <= 0)
                throw new ArgumentException("El ID debe ser válido");

            try
            {
                return _detalleRecepcionDAL.ObtenerPorId(id);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener el detalle de recepción: " + ex.Message);
            }
        }

        public DetalleRecepcion ListarPorCompra(int idRecepcion, IDetalleRecepcionDAL detalleRecepcionDAL)
        {
<<<<<<< HEAD
            throw new NotImplementedException();
=======
            if (idRecepcion <= 0)
                throw new ArgumentException("El ID de recepción debe ser válido");

            try
            {
                return ListarPorCompra(idRecepcion, _detalleRecepcionDAL);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al listar detalles por recepción: " + ex.Message);
            }
>>>>>>> 3b7990587225094801f1cbf15aa4fb63d6d8315c
        }

        DetalleCompra? IDetalleRecepcionBL.ObtenerPorId(int id)
        {
            throw new NotImplementedException();
        }

<<<<<<< HEAD
        DataTable IDetalleRecepcionBL.ListarPorCompra(int id)
=======
        public DataTable ListarPorCompra(int id)
>>>>>>> 3b7990587225094801f1cbf15aa4fb63d6d8315c
        {
            throw new NotImplementedException();
        }
    }
}

}

