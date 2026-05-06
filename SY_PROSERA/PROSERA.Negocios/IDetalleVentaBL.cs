using PROSERA.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace PROSERA.Negocios
{
    internal interface IDetalleVentaBL
    {

        void Agregar(DetalleVenta detalle);
        void Editar(DetalleVenta detalle);
        void Eliminar(int id);

        DetalleVenta ObtenerPorId(int id);
        List<DetalleVenta> Listar();
    }
}
