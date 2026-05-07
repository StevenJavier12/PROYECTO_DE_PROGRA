using PROSERA.Entidades;
using System;
using System.Collections.Generic;
using System.Text;
using PROSERA.Datos;

namespace PROSERA.Negocios
{
<<<<<<< HEAD
    internal interface IMarcaBL
    {
=======
    public interface IMarcaBL
    {
        void Agregar(Marca marca);
        void Editar(Marca marca);
        void Eliminar(int id);
        Marca ObtenerPorId(int id);
        List<Marca> Listar();
        List<Marca> BuscarMarcas(string marca);
>>>>>>> 3b7990587225094801f1cbf15aa4fb63d6d8315c

    }
}
