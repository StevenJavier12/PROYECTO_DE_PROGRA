using PROSERA.Entidades;
using System.Data;

namespace PROSERA.Datos
{
    internal interface IRecepcionDispositivoDAL
    {
        void Guardar(RecepcionDispositivo recepcion);
        void Editar(RecepcionDispositivo recepcion);
        void Eliminar(int id);
        DataTable ListarConRelaciones();
        RecepcionDispositivo? ObtenerPorId(int id);
    }
}