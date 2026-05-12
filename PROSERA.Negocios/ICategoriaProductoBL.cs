using PROSERA.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace PROSERA.Negocios
{
    public interface ICategoriaProductoBL
    {
        void Guardar(CategoriaProducto categoria);
        void Editar(CategoriaProducto categoria);
        void Eliminar(int id);

        DataTable Listar();

        CategoriaProducto? ObtenerPorId(int id);
    }
}
