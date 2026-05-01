using PROSERA.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace PROSERA.Datos
{
    internal interface IDetalleCompraDAL
    {
        void Guardar(DetalleCompra detalleCompra);
        void Editar(DetalleCompra detalleCompra);
        void Eliminar(int id);
        DataTable Listar();

        // Consultas
        DetalleCompra? ObtenerPorId(int id);

        // Métodos específicos 
        DataTable ListarPorCompra(int idCompra);
        bool ExisteProductoEnCompra(int idCompra, int idProducto, int? excluirId = null);
    }
}
