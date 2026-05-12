using PROSERA.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace PROSERA.Negocios
{
    public interface IDispositivoElectronicoBL
    {
        void Agregar(DispositivoElectronico dispositivo);
        void Editar(DispositivoElectronico dispositivo);
        void Eliminar(int id);

        DispositivoElectronico ObtenerPorId(int id);
        List<DispositivoElectronico> Listar();

        List<DispositivoElectronico> BuscarPorMarca(string marca);
        List<DispositivoElectronico> BuscarPorTipo(string tipo);

    }
}
