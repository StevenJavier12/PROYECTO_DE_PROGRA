using PROSERA.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace PROSERA.Negocios
{
    public interface IFacturaCompraBL
    {
        int Guardar(FacturaCompra factura);
        void Editar(FacturaCompra factura);
        void Eliminar(int id);
        DataTable Listar();

        FacturaCompra? ObtenerPorId(int id);


       

    }
}
