using PROSERA.Entidades;
using PROSERA.Datos;
using System.Data;

namespace PROSERA.Negocios
{
    internal class RecepcionDispositivoBL : IRecepcionDispositivoBL
    {
        private readonly IRecepcionDispositivoDAL _recepcionDAL;

        public RecepcionDispositivoBL(IRecepcionDispositivoDAL recepcionDAL)
        {
            _recepcionDAL = recepcionDAL;
        }

        public void Guardar(RecepcionDispositivo recepcion)
        {
            if (recepcion.Fecha == default)
                throw new Exception("La fecha es obligatoria.");

            if (recepcion.IdCliente <= 0)
                throw new Exception("El cliente es obligatorio.");

            if (recepcion.IdUsuario <= 0)
                throw new Exception("El usuario es obligatorio.");

            if (string.IsNullOrWhiteSpace(recepcion.Observaciones))
                throw new Exception("Las observaciones son obligatorias.");

            _recepcionDAL.Guardar(recepcion);
        }

        public void Editar(RecepcionDispositivo recepcion)
        {
            if (recepcion.IdRecepcion <= 0)
                throw new Exception("Recepción no válida.");

            if (recepcion.Fecha == default)
                throw new Exception("La fecha es obligatoria.");

            if (recepcion.IdCliente <= 0)
                throw new Exception("El cliente es obligatorio.");

            if (recepcion.IdUsuario <= 0)
                throw new Exception("El usuario es obligatorio.");

            if (string.IsNullOrWhiteSpace(recepcion.Observaciones))
                throw new Exception("Las observaciones son obligatorias.");

            _recepcionDAL.Editar(recepcion);
        }

        public void Eliminar(int id)
        {
            _recepcionDAL.Eliminar(id);
        }

        public DataTable Listar()
        {
            return _recepcionDAL.ListarConRelaciones();
        }

        public RecepcionDispositivo? ObtenerPorId(int id)
        {
            return _recepcionDAL.ObtenerPorId(id);
        }
    }
}