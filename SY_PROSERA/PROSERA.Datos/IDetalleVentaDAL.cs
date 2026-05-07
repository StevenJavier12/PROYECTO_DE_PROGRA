using PROSERA.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace PROSERA.Datos
{
    public interface IDetalleVentaDAL
    {
        
            void Agregar(DetalleVenta detalle);
            void Editar(DetalleVenta detalle);
            void Eliminar(int id);
            public DataTable Listar();

        DetalleVenta ObtenerPorId(int id);
            
        
    }
}
