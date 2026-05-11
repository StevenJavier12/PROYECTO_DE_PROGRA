using PROSERA.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace PROSERA.Datos
{
    public interface IInventarioDAL
    {
        // CRUD básico
        void Guardar(Inventario inventario);
        void Editar(Inventario inventario);
        void Eliminar(int id);
        DataTable Listar();

        // Métodos adicionales
        Inventario? ObtenerPorId(int id);
        bool ExisteProductoEnInventario(int idProducto);
        DataTable ListarStockBajo();
        DataTable ListarPorTipoMovimiento(string tipoMovimiento);
    }
    
}
