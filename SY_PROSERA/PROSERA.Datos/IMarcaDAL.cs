using PROSERA.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace PROSERA.Datos
{
    public interface IMarcaDAL
    {
        void Agregar(Marca marca);
        void Editar(Marca marca);
        void Eliminar(int id);
        Marca? ObtenerPorId(int id);
        List<Marca> Listar();
        List<Marca> BuscarMarcas(string marca);
    }


}

