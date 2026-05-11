using PROSERA.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace PROSERA.Negocios
{
    public  interface IDetalleRecepcionBL
    {
        void Guardar(DetalleRecepcion detalleRecepcion);
        void Editar(DetalleRecepcion detalleRecepcion);
        void Eliminar(int id);

        DataTable Listar();

        DetalleCompra? ObtenerPorId(int id);

        DataTable ListarPorCompra(int id);
    }
}
