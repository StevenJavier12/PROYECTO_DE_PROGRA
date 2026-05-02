using PROSERA.Entidades;
using System.Data;

namespace PROSERA.Negocios
{
    public interface IDetalleCompraBL
    {
        void Guardar(DetalleCompra detalleCompra);
        void Editar(DetalleCompra detalleCompra);
        void Eliminar(int id);

        DataTable Listar();

        DetalleCompra? ObtenerPorId(int id);

        DataTable ListarPorCompra(int idCompra);
    }
}
