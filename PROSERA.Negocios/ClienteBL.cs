using PROSERA.Entidades;
using PROSERA.Datos;
using System.Data;

namespace PROSERA.Negocios
{
    public class ClienteBL : IClienteBL
    {
        private readonly IClienteDAL _clienteDAL;

        public ClienteBL(IClienteDAL clienteDAL)
        {
            _clienteDAL = clienteDAL;
        }

        public void Guardar(Cliente cliente)
        {
            if (string.IsNullOrWhiteSpace(cliente.Nombre))
                throw new Exception("El nombre es obligatorio.");

            if (string.IsNullOrWhiteSpace(cliente.Apellido))
                throw new Exception("El apellido es obligatorio.");

            if (string.IsNullOrWhiteSpace(cliente.Telefono))
                throw new Exception("El teléfono es obligatorio.");

            if (string.IsNullOrWhiteSpace(cliente.Direccion))
                throw new Exception("La dirección es obligatoria.");

            if (string.IsNullOrWhiteSpace(cliente.Dui))
                throw new Exception("El DUI es obligatorio.");

            if (_clienteDAL.ExistePorDui(cliente.Dui))
                throw new Exception("Ya existe un cliente con ese DUI.");

            _clienteDAL.Guardar(cliente);
        }

        public void Editar(Cliente cliente)
        {
            if (cliente.IdCliente <= 0)
                throw new Exception("Cliente inválido.");

            if (string.IsNullOrWhiteSpace(cliente.Nombre))
                throw new Exception("El nombre es obligatorio.");

            if (string.IsNullOrWhiteSpace(cliente.Apellido))
                throw new Exception("El apellido es obligatorio.");

            if (string.IsNullOrWhiteSpace(cliente.Telefono))
                throw new Exception("El teléfono es obligatorio.");

            if (string.IsNullOrWhiteSpace(cliente.Direccion))
                throw new Exception("La dirección es obligatoria.");

            if (string.IsNullOrWhiteSpace(cliente.Dui))
                throw new Exception("El DUI es obligatorio.");

            if (_clienteDAL.ExistePorDui(cliente.Dui, cliente.IdCliente))
                throw new Exception("Ya existe un cliente con ese DUI.");

            _clienteDAL.Editar(cliente);
        }

        public void Eliminar(int id)
        {
            if (_clienteDAL.TieneFacturasRelacionadas(id))
                throw new Exception("No se puede eliminar el cliente porque tiene facturas relacionadas.");

            if (_clienteDAL.TieneRecepcionesRelacionadas(id))
                throw new Exception("No se puede eliminar el cliente porque tiene recepciones relacionadas.");

            _clienteDAL.Eliminar(id);
        }

        public DataTable Listar()
        {
            return _clienteDAL.Listar();
        }

        public Cliente? ObtenerPorId(int id)
        {
            return _clienteDAL.ObtenerPorId(id);
        }
    }
}
