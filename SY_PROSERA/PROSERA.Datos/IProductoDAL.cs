using PROSERA.Entidades;
using System.Data;

namespace PROSERA.Datos
{
    internal interface IProductoDAL
    {
        void Guardar(Producto producto);
        void Editar(Producto producto);
        void Eliminar(int id);
        DataTable ListarConCategoria();

        //Hasta aqui el metodo crud, ahora los metodos de consulta

        Producto? ObtenerPorId(int id);
        bool ExistePorNombre(string nombre, int categoriaId, int? excluirId = null);

    }
}
