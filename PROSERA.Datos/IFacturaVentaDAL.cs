using PROSERA.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace PROSERA.Datos
{

    public interface IFacturaVentaDAL
    {
        void Guardar(FacturaVenta factura);
        void Editar(FacturaVenta factura);
        void Eliminar(int id);
        DataTable Listar();


        // Métodos adicionales
        FacturaVenta? ObtenerPorId(int id);
        bool ExisteFactura(int idFactura);
        DataTable ListarPorCliente(int idCliente);
        DataTable ListarPorFecha(DateTime fechaInicio, DateTime fechaFin);
    }



}



