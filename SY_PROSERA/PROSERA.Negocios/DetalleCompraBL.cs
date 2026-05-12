using PROSERA.Datos;
using PROSERA.Entidades;
using System.Data;

namespace PROSERA.Negocios
{
    public class DetalleCompraBL : IDetalleCompraBL
    {
        private readonly IDetalleCompraDAL _detalleDAL;

        public DetalleCompraBL(DetalleCompra detalleCompra)
        {
            _detalleDAL = new DetalleCompraDAL();
        }


        public void Guardar(DetalleCompra detalleCompra)
        {
            ValidarDetalle(detalleCompra);

            bool existe = _detalleDAL.ExisteProductoEnCompra(
                detalleCompra.IdCompra,
                detalleCompra.IdProducto
            );

            if (existe)
                throw new Exception("El producto ya existe en esta compra.");

            detalleCompra.Subtotal =
                detalleCompra.Cantidad * detalleCompra.CostoUnitario;

            _detalleDAL.Guardar(detalleCompra);
        }


        public void Editar(DetalleCompra detalleCompra)
        {
            if (detalleCompra.IdDetalleCompra <= 0)
                throw new Exception("El ID del detalle es inválido.");

            ValidarDetalle(detalleCompra);

            bool existe = _detalleDAL.ExisteProductoEnCompra(
                detalleCompra.IdCompra,
                detalleCompra.IdProducto,
                detalleCompra.IdDetalleCompra
            );

            if (existe)
                throw new Exception("El producto ya existe en esta compra.");

            detalleCompra.Subtotal =
                detalleCompra.Cantidad * detalleCompra.CostoUnitario;

            _detalleDAL.Editar(detalleCompra);
        }


        public void Eliminar(int id)
        {
            if (id <= 0)
                throw new Exception("ID inválido.");

            DetalleCompra? detalle = _detalleDAL.ObtenerPorId(id);

            if (detalle == null)
                throw new Exception("El detalle no existe.");

            _detalleDAL.Eliminar(id);
        }


        public DataTable Listar()
        {
            return _detalleDAL.Listar();
        }


        public DetalleCompra? ObtenerPorId(int id)
        {
            if (id <= 0)
                throw new Exception("ID inválido.");

            return _detalleDAL.ObtenerPorId(id);
        }


        public DataTable ListarPorCompra(int idCompra)
        {
            if (idCompra <= 0)
                throw new Exception("Compra inválida.");

            return _detalleDAL.ListarPorCompra(idCompra);
        }


        private void ValidarDetalle(DetalleCompra detalle)
        {
            if (detalle == null)
                throw new Exception("El detalle está vacío.");

            if (detalle.IdCompra <= 0)
                throw new Exception("La compra es obligatoria.");

            if (detalle.IdProducto <= 0)
                throw new Exception("El producto es obligatorio.");

            if (detalle.Cantidad <= 0)
                throw new Exception("La cantidad debe ser mayor a cero.");

            if (detalle.CostoUnitario <= 0)
                throw new Exception("El costo unitario debe ser mayor a cero.");
        }
    }
}
