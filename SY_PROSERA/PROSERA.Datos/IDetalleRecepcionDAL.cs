using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using PROSERA.Entidades;

namespace PROSERA.Datos
{
    public interface IDetalleRecepcionDAL
    {

        void Agregar(DetalleRecepcion detalle);
        void Editar(DetalleRecepcion detalle);
        void Eliminar(int Id);
        public DataTable Listar();
        void ListarPorCompra(int IdRecepcion);
        DetalleRecepcion ObtenerPorId(int Id);
        DetalleCompra ObtenerPorId(object systemint32, int id);
    }
}
