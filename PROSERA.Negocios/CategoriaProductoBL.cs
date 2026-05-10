using PROSERA.Entidades;
using PROSERA.Datos;
using System.Data;


namespace PROSERA.Negocios
{
    public class CategoriaProductoBL : ICategoriaProductoBL
    {
        private readonly ICategoriaProductoDAL _categoriaDAL;

        public CategoriaProductoBL(ICategoriaProductoDAL categoriaDAL)
        {
            _categoriaDAL = categoriaDAL;
        }

        public void Guardar(CategoriaProducto categoria)
        {
            if (string.IsNullOrWhiteSpace(categoria.Nombre))
                throw new Exception("El nombre de la categoría es obligatorio.");

            if (string.IsNullOrWhiteSpace(categoria.Descripcion))
                throw new Exception("La descripción es obligatoria.");

            if (_categoriaDAL.ExistePorNombre(categoria.Nombre))
                throw new Exception("Ya existe una categoría con ese nombre.");

            _categoriaDAL.Guardar(categoria);
        }

        public void Editar(CategoriaProducto categoria)
        {
            if (categoria.IdCategoria <= 0)
                throw new Exception("La categoría no es válida.");

            if (string.IsNullOrWhiteSpace(categoria.Nombre))
                throw new Exception("El nombre es obligatorio.");

            if (string.IsNullOrWhiteSpace(categoria.Descripcion))
                throw new Exception("La descripción es obligatoria.");

            if (_categoriaDAL.ExistePorNombre(categoria.Nombre, categoria.IdCategoria))
                throw new Exception("Ya existe una categoría con ese nombre.");

            _categoriaDAL.Editar(categoria);
        }

        public void Eliminar(int id)
        {
            if (_categoriaDAL.TieneProductosRelacionados(id))
                throw new Exception("No se puede eliminar la categoría porque tiene productos relacionados.");

            _categoriaDAL.Eliminar(id);
        }

        public DataTable Listar()
        {
            return _categoriaDAL.Listar();
        }

        public CategoriaProducto? ObtenerPorId(int id)
        {
            return _categoriaDAL.ObtenerPorId(id);
        }
    }
}
