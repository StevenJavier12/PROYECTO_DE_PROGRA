using PROSERA.Entidades;
using System.Data;

namespace PROSERA.Negocios
{
    internal interface IRecepcionDispositivoBL
    {
        void Guardar(RecepcionDispositivo recepcion);
        void Editar(RecepcionDispositivo recepcion);
        void Eliminar(int id);
        DataTable Listar();
        RecepcionDispositivo? ObtenerPorId(int id);
    }
}