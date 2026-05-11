using PROSERA.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace PROSERA.Negocios
{
    public interface IClienteBL
    {
        void Guardar(Cliente cliente);
        void Editar(Cliente cliente);
        void Eliminar(int id);

        DataTable Listar();

        Cliente? ObtenerPorId(int id);
    }
}
