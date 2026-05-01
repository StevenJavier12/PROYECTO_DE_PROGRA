using PROSERA.Entidades;
using System.Data;

namespace PROSERA.Datos
{
    internal interface IEmpleadoDAL
    {
        void Guardar(Empleado empleado);
        void Editar(Empleado empleado);
        void Eliminar(int id);
        DataTable Listar();
        Empleado? ObtenerPorId(int id);
        bool ExistePorDui(string dui, int? excluirId = null);
    }
}