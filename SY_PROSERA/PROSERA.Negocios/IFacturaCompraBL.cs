using PROSERA.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace PROSERA.Negocios
{
    internal interface IFacturaCompraBL
    {
        void Guardar(FacturaCompra factura);
        DataTable Listar();
        void Eliminar(int id);
    }
}
