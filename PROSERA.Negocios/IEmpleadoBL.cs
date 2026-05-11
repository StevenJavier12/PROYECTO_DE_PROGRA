using PROSERA.Entidades;
using System.Data;

namespace PROSERA.Negocios
{
    public interface IEmpleadoBL
    {
        void Guardar(Empleado empleado);
        void Editar(Empleado empleado);
        void Eliminar(int id);
        DataTable Listar();
        Empleado? ObtenerPorId(int id);
    }
}