using PROSERA.Entidades;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace PROSERA.Negocios
{
    internal interface IFacturaVentaBL
    {
        void Guardar(FacturaVenta factura);
        DataTable Listar();
        void Eliminar(int id);
        void Guardar(Datos.FacturaVenta factura);
    }
}
