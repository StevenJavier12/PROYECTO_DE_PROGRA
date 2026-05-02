using System;
using System.Collections.Generic;
using System.Text;

namespace PROSERA.Datos
{
     public interface IFacturaCompraDAL
    {
        void Guardar(FacturaCompra factura);
        DataTable Listar();
        void Eliminar(int id);
    }

/*CREATE TABLE Factura_Compras (
    id_compra INT PRIMARY KEY IDENTITY (1,1),
    fecha DATETIME NOT NULL,
    id_proveedor INT NOT NULL,
    total DECIMAL(10,2) NOT NULL,
    tipo_comprobante VARCHAR(50) NOT NULL DEFAULT 'Consumidor final',

    CONSTRAINT FK_Compra_Proveedores
    FOREIGN KEY (id_proveedor) REFERENCES Proveedores(id_proveedor)
); */

    // IMPLEMENTACIÓN
    public class FacturaCompraDAL : IFacturaCompraDAL
    {
        public void Guardar(FacturaCompra factura)
        {
            using SqlConnection cn = new(ConexionDB.Cadena);
            cn.Open();

            string sql = @"INSERT INTO Factura_Compras 
                           (fecha, id_proveedor, total, tipo_comprobante)
                           VALUES (@fecha, @proveedor, @total, @tipo);
                           SELECT SCOPE_IDENTITY();";

            using SqlCommand cmd = new(sql, cn);
            cmd.Parameters.Add("@fecha", SqlDbType.DateTime).Value = factura.Fecha;
            cmd.Parameters.Add("@proveedor", SqlDbType.Int).Value = factura.IdProveedor;
            cmd.Parameters.Add("@total", SqlDbType.Decimal).Value = factura.Total;
            cmd.Parameters.Add("@tipo", SqlDbType.VarChar, 50).Value = factura.TipoComprobante;

            factura.IdCompra = Convert.ToInt32(cmd.ExecuteScalar());
        }

        public DataTable Listar()
        {
            using SqlConnection cn = new(ConexionDB.Cadena);
            cn.Open();

            string sql = @"SELECT fc.id_compra, fc.fecha, p.nombre_empresa, fc.total
                           FROM Factura_Compras fc
                           INNER JOIN Proveedores p 
                           ON fc.id_proveedor = p.id_proveedor";

            using SqlDataAdapter da = new(sql, cn);
            DataTable dt = new();
            da.Fill(dt);
            return dt;
        }

        public void Eliminar(int id)
        {
            using SqlConnection cn = new(ConexionDB.Cadena);
            cn.Open();

            string sql = "DELETE FROM Factura_Compras WHERE id_compra = @id";

            using SqlCommand cmd = new(sql, cn);
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;

            cmd.ExecuteNonQuery();
        }
    }
}
