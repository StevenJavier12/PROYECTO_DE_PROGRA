using PROSERA.Datos;
using PROSERA.Entidades;
using System.Data;

namespace PROSERA.Negocios
{
    internal class ProductoBL : IProductoBL
    {
        private readonly IProductoDAL _productoDAL;

        public ProductoBL(IProductoDAL productoDAL)
        {
            _productoDAL = productoDAL;
        }

        public void Guardar(Producto producto)
        {
            if (string.IsNullOrWhiteSpace(producto.Nombre))
                throw new Exception("El nombre del producto es obligatorio.");

            if (producto.PrecioUnitario <= 0)
                throw new Exception("El precio debe ser mayor que cero.");

            if (producto.IdMarca <= 0)
                throw new Exception("Debe seleccionar una marca.");

            if (producto.IdCategoria <= 0)
                throw new Exception("Debe seleccionar una categoría.");

            if (string.IsNullOrWhiteSpace(producto.EstadoProducto))
                throw new Exception("Debe indicar el estado del producto.");

            if (producto.EstadoProducto != "Activo" &&
                producto.EstadoProducto != "Inactivo")
            {
                throw new Exception("Estado de producto inválido.");
            }

            if (_productoDAL.ExistePorNombre(
                    producto.Nombre,
                    producto.IdCategoria))
            {
                throw new Exception("Ya existe un producto con ese nombre en la categoría.");
            }

            _productoDAL.Guardar(producto);
        }

        public void Editar(Producto producto)
        {
            if (producto.IdProducto <= 0)
                throw new Exception("Producto inválido.");

            if (string.IsNullOrWhiteSpace(producto.Nombre))
                throw new Exception("El nombre del producto es obligatorio.");

            if (producto.PrecioUnitario <= 0)
                throw new Exception("El precio debe ser mayor que cero.");

            if (producto.IdMarca <= 0)
                throw new Exception("Debe seleccionar una marca.");

            if (producto.IdCategoria <= 0)
                throw new Exception("Debe seleccionar una categoría.");

            if (producto.EstadoProducto != "Activo" &&
                producto.EstadoProducto != "Inactivo")
            {
                throw new Exception("Estado de producto inválido.");
            }

            if (_productoDAL.ExistePorNombre(
                    producto.Nombre,
                    producto.IdCategoria,
                    producto.IdProducto))
            {
                throw new Exception("Ya existe un producto con ese nombre en la categoría.");
            }

            _productoDAL.Editar(producto);
        }

        public void Eliminar(int id)
        {
            _productoDAL.Eliminar(id);
        }

        public DataTable ListarConCategoria()
        {
            return _productoDAL.ListarConCategoria();
        }

        public Producto? ObtenerPorId(int id)
        {
            return _productoDAL.ObtenerPorId(id);
        }
    }
}
