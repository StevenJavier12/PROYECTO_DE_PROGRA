using PROSERA.Entidades;
using System.Data;

namespace PROSERA.Datos
{
    public interface ICategoriaProductoDAL
    {
        void Guardar(CategoriaProducto categoria);
        void Editar(CategoriaProducto categoria);
        void Eliminar(int id);
        DataTable Listar();
        CategoriaProducto? ObtenerPorId(int id);
        bool ExistePorNombre(string nombre, int? excluirId = null);
        bool TieneProductosRelacionados(int categoriaId);
    }
}
