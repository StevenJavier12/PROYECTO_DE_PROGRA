using PROSERA.Datos;
using PROSERA.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace PROSERA.Negocios
{
    public class InventarioBL : IInventarioBL
    {
        private readonly IInventarioDAL _inventarioDAL;

        public InventarioBL(IInventarioDAL inventarioDAL)
        {
            _inventarioDAL = inventarioDAL;
        }


        public void Editar(Inventario inventario)
        {
            if (inventario.IdInventario <= 0)
                throw new Exception("El inventario no es válido.");

            if (inventario.IdProducto <= 0)
                throw new Exception("El producto no es válido.");

            if (inventario.Stock < 0)
                throw new Exception("El stock no puede ser negativo.");

            if (inventario.StockMinimo < 0)
                throw new Exception("El stock mínimo no puede ser negativo.");

            if (inventario.FechaActualizacion == DateTime.MinValue)
                throw new Exception("La fecha de actualización es obligatoria.");

            if (string.IsNullOrWhiteSpace(inventario.TipoMovimiento))
                throw new Exception("El tipo de movimiento es obligatorio.");

            if (inventario.TipoMovimiento != "Entrada" &&
                inventario.TipoMovimiento != "Salida")
                throw new Exception("El tipo de movimiento solo puede ser Entrada o Salida.");

            if (string.IsNullOrWhiteSpace(inventario.DescripcionMovimiento))
                throw new Exception("La descripción del movimiento es obligatoria.");

            _inventarioDAL.Editar(inventario);
        }

        public void Eliminar(int id)
        {
            if (id <= 0)
                throw new Exception("El inventario no es válido.");

            _inventarioDAL.Eliminar(id);
        }

        public bool ExisteProductoEnInventario(int idProducto)
        {
            throw new NotImplementedException();
        }

        public void Guardar(Inventario inventario)
        {
            if (inventario.IdProducto <= 0)
                throw new Exception("El producto no es válido.");

            if (inventario.Stock < 0)
                throw new Exception("El stock no puede ser negativo.");

            if (inventario.StockMinimo < 0)
                throw new Exception("El stock mínimo no puede ser negativo.");

            if (inventario.FechaActualizacion == DateTime.MinValue)
                throw new Exception("La fecha de actualización es obligatoria.");

            if (string.IsNullOrWhiteSpace(inventario.TipoMovimiento))
                throw new Exception("El tipo de movimiento es obligatorio.");

            if (inventario.TipoMovimiento != "Entrada" &&
                inventario.TipoMovimiento != "Salida")
                throw new Exception("El tipo de movimiento solo puede ser Entrada o Salida.");

            if (string.IsNullOrWhiteSpace(inventario.DescripcionMovimiento))
                throw new Exception("La descripción del movimiento es obligatoria.");

            _inventarioDAL.Guardar(inventario);
        }

        public DataTable Listar()
        {
            return _inventarioDAL.Listar();
        }

        public DataTable ListarPorTipoMovimiento(string tipoMovimiento)
        {
            throw new NotImplementedException();
        }

        public DataTable ListarStockBajo()
        {
            throw new NotImplementedException();
        }

        public Inventario? ObtenerPorId(int id)
        {
            throw new NotImplementedException();
        }
    }
}
