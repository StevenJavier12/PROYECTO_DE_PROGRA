using System;
using System.Collections.Generic;
using System.Text;

namespace PROSERA.Datos
{

    public interface IFacturaVentaDAL
    {
        void Guardar(FacturaVenta factura);
        DataTable Listar();
        void Eliminar(int id);
    }

   
    
}
