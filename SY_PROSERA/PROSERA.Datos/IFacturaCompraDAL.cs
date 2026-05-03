using System;
using System.Collections.Generic;
using System.Text;

namespace PROSERA.Datos
{
   
    public interface IFacturaCompraDAL
    {
        void Guardar(FacturaCompra factura);
        DataTable Listar();
        void Eliminar(int id);
    }

}
