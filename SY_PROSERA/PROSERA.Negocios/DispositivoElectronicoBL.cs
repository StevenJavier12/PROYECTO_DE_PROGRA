using PROSERA.Entidades;
using System;
using System.Collections.Generic;
using System.Text;
using PROSERA.Datos;

namespace PROSERA.Negocios
{
    public class DispositivoElectronicoBL : IDispositivoElectronicoBL
    {
        private readonly IDispositivoElectronicoDAL _dispositivoDAL;

        public DispositivoElectronicoBL(IDispositivoElectronicoDAL dispositivoDAL) => _dispositivoDAL = dispositivoDAL;

        public void Agregar(DispositivoElectronico dispositivo)
        {
            if (dispositivo == null)
                throw new ArgumentNullException(nameof(dispositivo), "El dispositivo no puede ser nulo");

            if (string.IsNullOrWhiteSpace(dispositivo.Tipo))
                throw new ArgumentException("El tipo del dispositivo es obligatorio");

            if (string.IsNullOrWhiteSpace(dispositivo.Marca))
                throw new ArgumentException("La marca del dispositivo es obligatoria");

            if (string.IsNullOrWhiteSpace(dispositivo.Modelo))
                throw new ArgumentException("El modelo del dispositivo es obligatorio");

            if (string.IsNullOrWhiteSpace(dispositivo.Estado))
                throw new ArgumentException("El estado del dispositivo es obligatorio");

            try
            {
                _dispositivoDAL.Agregar(dispositivo);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al agregar el dispositivo: " + ex.Message);
            }
        }

        public void Editar(DispositivoElectronico dispositivo)
        {
            if (dispositivo == null)
                throw new ArgumentNullException(nameof(dispositivo), "El dispositivo no puede ser nulo");

            if (dispositivo.IdDispositivo <= 0)
                throw new ArgumentException("El ID del dispositivo debe ser válido");

            if (string.IsNullOrWhiteSpace(dispositivo.Tipo))
                throw new ArgumentException("El tipo del dispositivo es obligatorio");

            if (string.IsNullOrWhiteSpace(dispositivo.Marca))
                throw new ArgumentException("La marca del dispositivo es obligatoria");

            if (string.IsNullOrWhiteSpace(dispositivo.Modelo))
                throw new ArgumentException("El modelo del dispositivo es obligatorio");

            if (string.IsNullOrWhiteSpace(dispositivo.Estado))
                throw new ArgumentException("El estado del dispositivo es obligatorio");

            try
            {
                _dispositivoDAL.Editar(dispositivo);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al editar el dispositivo: " + ex.Message);
            }
        }

        public void Eliminar(int id)
        {
            if (id <= 0)
                throw new ArgumentException("El ID debe ser válido");

            try
            {
                _dispositivoDAL.Eliminar(id);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al eliminar el dispositivo: " + ex.Message);
            }
        }

        public DispositivoElectronico ObtenerPorId(int id)
        {
            if (id <= 0)
                throw new ArgumentException("El ID debe ser válido");

            try
            {
                return _dispositivoDAL.ObtenerPorId(id);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener el dispositivo: " + ex.Message);
            }
        }

        public List<DispositivoElectronico> Listar()
        {
            try
            {
                return _dispositivoDAL.Listar();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al listar los dispositivos: " + ex.Message);
            }
        }

        public List<DispositivoElectronico> BuscarPorMarca(string marca)
        {
            if (string.IsNullOrWhiteSpace(marca))
                throw new ArgumentException("La marca no puede estar vacía");

            try
            {
                return _dispositivoDAL.BuscarPorMarca(marca);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al buscar por marca: " + ex.Message);
            }
        }

        public List<DispositivoElectronico> BuscarPorTipo(string tipo)
        {
            if (string.IsNullOrWhiteSpace(tipo))
                throw new ArgumentException("El tipo no puede estar vacío");

            try
            {
                return _dispositivoDAL.BuscarPorTipo(tipo);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al buscar por tipo: " + ex.Message);
            }
        }
    }
}
