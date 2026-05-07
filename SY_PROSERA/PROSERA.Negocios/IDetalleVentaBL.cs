using PROSERA.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace PROSERA.Negocios
{
    internal interface IDetalleVentaBL
    {
        // CRUD básico
        void Agregar(DetalleVenta detalle);
        void Editar(DetalleVenta detalle);
        void Eliminar(int id);
        DataTable Listar();

        // Métodos adicionales
        DetalleVenta? ObtenerPorId(int id);
        DataTable ListarPorFactura(int idFactura);
    }
}
