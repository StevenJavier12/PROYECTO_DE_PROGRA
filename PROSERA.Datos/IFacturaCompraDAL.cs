using PROSERA.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace PROSERA.Datos
{

    public interface IFacturaCompraDAL
    {
        int Guardar(FacturaCompra factura);

        DataTable Listar();
        void Eliminar(int id);
        FacturaCompra? ObtenerPorId(int id);

        void Editar(FacturaCompra factura);

    }

}
