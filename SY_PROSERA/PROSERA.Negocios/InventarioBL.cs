using PROSERA.Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace PROSERA.Negocios
{
    internal class InventarioBL : IInventarioBL
    {
        private readonly IInventarioDAL _inventarioDAL;

        public InventarioBL(IInventarioDAL inventarioDAL)
        {
            _inventarioDAL = inventarioDAL;
        }

        public DataTable Listar()
        {
            return _inventarioDAL.Listar();
        }

        public void ActualizarStock(int idProducto, int cantidad, string tipo, string descripcion)
        {
            if (idProducto <= 0)
                throw new Exception("Producto inválido.");

            if (cantidad <= 0)
                throw new Exception("Cantidad inválida.");

            if (string.IsNullOrWhiteSpace(tipo))
                throw new Exception("Debe especificar el tipo de movimiento.");

            if (tipo != "Entrada" && tipo != "Salida")
                throw new Exception("Tipo de movimiento inválido.");

            _inventarioDAL.ActualizarStock(idProducto, cantidad, tipo, descripcion);
        }

        public void ActualizarStock(int idProducto, int cantidad, string tipo)
        {
            throw new NotImplementedException();
        }
    }
}
