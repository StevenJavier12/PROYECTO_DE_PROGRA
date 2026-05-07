using PROSERA.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace PROSERA.Negocios
{
    internal interface IDetalleVentaBL
    {
<<<<<<< HEAD
        // CRUD básico
        void Agregar(DetalleVenta detalle);
        void Editar(DetalleVenta detalle);
        void Eliminar(int id);
        DataTable Listar();

        // Métodos adicionales
        DetalleVenta? ObtenerPorId(int id);
        DataTable ListarPorFactura(int idFactura);
=======

        void Agregar(DetalleVenta detalle);
        void Editar(DetalleVenta detalle);
        void Eliminar(int id);

        DetalleVenta ObtenerPorId(int id);
        List<DetalleVenta> Listar();
>>>>>>> 3b7990587225094801f1cbf15aa4fb63d6d8315c
    }
}
