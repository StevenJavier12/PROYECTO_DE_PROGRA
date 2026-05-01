using PROSERA.Entidades;
using System.Data;

namespace PROSERA.Datos
{
    internal interface IProveedorDAL
    {
        void Guardar(Proveedor proveedor);
        void Editar(Proveedor proveedor);
        void Eliminar(int id);
        DataTable Listar();
        Proveedor? ObtenerPorId(int id);
        bool ExistePorNombreEmpresa(string nombreEmpresa, int? excluirId = null);
    }
}