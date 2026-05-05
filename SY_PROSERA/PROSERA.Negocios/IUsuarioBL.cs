using PROSERA.Entidades;
using System.Data;

namespace PROSERA.Negocios
{
    internal interface IUsuarioBL
    {
        void Guardar(Usuario usuario);
        void Editar(Usuario usuario);
        void Eliminar(int id);
        DataTable Listar();
        Usuario? ObtenerPorId(int id);
    }
}