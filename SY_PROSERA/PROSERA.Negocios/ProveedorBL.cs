using PROSERA.Entidades;
using PROSERA.Datos;
using System.Data;

namespace PROSERA.Negocios
{
    internal class ProveedorBL : IProveedorBL
    {
        private readonly IProveedorDAL _proveedorDAL;

        public ProveedorBL(IProveedorDAL proveedorDAL)
        {
            _proveedorDAL = proveedorDAL;
        }

        public void Guardar(Proveedor proveedor)
        {
            if (string.IsNullOrWhiteSpace(proveedor.NombreEmpresa))
                throw new Exception("El nombre de la empresa es obligatorio.");

            if (string.IsNullOrWhiteSpace(proveedor.Contacto))
                throw new Exception("El contacto es obligatorio.");

            if (string.IsNullOrWhiteSpace(proveedor.Telefono))
                throw new Exception("El teléfono es obligatorio.");

            if (string.IsNullOrWhiteSpace(proveedor.Direccion))
                throw new Exception("La dirección es obligatoria.");

            if (string.IsNullOrWhiteSpace(proveedor.Correo))
                throw new Exception("El correo es obligatorio.");

            if (_proveedorDAL.ExistePorNombreEmpresa(proveedor.NombreEmpresa))
                throw new Exception("Ya existe un proveedor con ese nombre de empresa.");

            _proveedorDAL.Guardar(proveedor);
        }

        public void Editar(Proveedor proveedor)
        {
            if (proveedor.IdProveedor <= 0)
                throw new Exception("Proveedor no válido.");

            if (string.IsNullOrWhiteSpace(proveedor.NombreEmpresa))
                throw new Exception("El nombre de la empresa es obligatorio.");

            if (string.IsNullOrWhiteSpace(proveedor.Contacto))
                throw new Exception("El contacto es obligatorio.");

            if (string.IsNullOrWhiteSpace(proveedor.Telefono))
                throw new Exception("El teléfono es obligatorio.");

            if (string.IsNullOrWhiteSpace(proveedor.Direccion))
                throw new Exception("La dirección es obligatoria.");

            if (string.IsNullOrWhiteSpace(proveedor.Correo))
                throw new Exception("El correo es obligatorio.");

            if (_proveedorDAL.ExistePorNombreEmpresa(proveedor.NombreEmpresa, proveedor.IdProveedor))
                throw new Exception("Ya existe un proveedor con ese nombre de empresa.");

            _proveedorDAL.Editar(proveedor);
        }

        public void Eliminar(int id)
        {
            _proveedorDAL.Eliminar(id);
        }

        public DataTable Listar()
        {
            return _proveedorDAL.Listar();
        }

        public Proveedor? ObtenerPorId(int id)
        {
            return _proveedorDAL.ObtenerPorId(id);
        }
    }
}