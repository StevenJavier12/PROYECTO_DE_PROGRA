using PROSERA.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace PROSERA.Negocios
{
    public interface IProductoBL
    {
        void Guardar(Producto producto);
        void Editar(Producto producto);
        void Eliminar(int id);

        DataTable ListarConCategoria();

        Producto? ObtenerPorId(int id);
    }
}
