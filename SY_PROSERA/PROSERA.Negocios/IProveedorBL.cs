using PROSERA.Entidades;
using System.Data;

namespace PROSERA.Negocios
{
    internal interface IProveedorBL
    {
        void Guardar(Proveedor proveedor);
        void Editar(Proveedor proveedor);
        void Eliminar(int id);
        DataTable Listar();
        Proveedor? ObtenerPorId(int id);
    }
}
