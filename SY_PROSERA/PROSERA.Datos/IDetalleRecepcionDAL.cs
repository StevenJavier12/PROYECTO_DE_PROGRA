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
<<<<<<< HEAD
=======
        void ListarPorCompra(int IdRecepcion);
        DetalleRecepcion ListarPorCompra(object int32, int idRecepcion);
>>>>>>> 3b7990587225094801f1cbf15aa4fb63d6d8315c
        DetalleRecepcion ObtenerPorId(int Id);
        DetalleCompra ObtenerPorId(object systemint32, int id);
    }
}
