using PROSERA.Entidades;
using System.Data;

namespace PROSERA.Datos
{
    public interface IUsuarioDAL
    {
        void Guardar(Usuario usuario);
        void Editar(Usuario usuario);
        void Eliminar(int id);
        DataTable ListarConEmpleado();
        Usuario? ObtenerPorId(int id);
        bool ExistePorUsername(string username, int? excluirId = null);
    }
}