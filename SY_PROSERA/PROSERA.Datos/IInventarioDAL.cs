using System;
using System.Collections.Generic;
using System.Text;

namespace PROSERA.Datos
{
    public interface IInventarioDAL
    {
        DataTable Listar();
        void ActualizarStock(int idProducto, int cantidad, string tipo);
    }
    
}
