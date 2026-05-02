using PROSERA.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace PROSERA.Datos
{
    internal interface IDetalleVentaDAL
    {
        
            void Agregar(DetalleVenta detalle);
            void Editar(DetalleVenta detalle);
            void Eliminar(int id);

            DetalleVenta ObtenerPorId(int id);
            List<DetalleVenta> Listar();
        
    }
}
