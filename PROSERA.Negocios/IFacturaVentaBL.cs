using PROSERA.Entidades;
using System.Data;

namespace PROSERA.Negocios
{
    public interface IFacturaVentaBL
    {
        // CRUD básico
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
