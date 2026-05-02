using System;
using System.Collections.Generic;
using System.Text;
using PROSERA.Entidades;

namespace PROSERA.Datos
{
    public interface IDetalleRecepcionDAL
    {

        void Agregar(DetalleRecepcion detalle);
        void Editar(DetalleRecepcion detalle);
        void Eliminar(int Id);
    }
}
