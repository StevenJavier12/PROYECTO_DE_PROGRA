using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace PROSERA.Negocios
{
    internal interface IInventarioBL
    {
        DataTable Listar();
        void ActualizarStock(int idProducto, int cantidad, string tipo);
    }
}
