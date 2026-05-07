using Microsoft.Data.SqlClient;
using PROSERA.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace PROSERA.Datos
{
    public class FacturaCompraDAL : IFacturaCompraDAL
    {

        /*
         * -- =========================================
-- 11. FACTURA_COMPRA
-- =========================================
CREATE TABLE Factura_Compras (
    id_compra INT PRIMARY KEY IDENTITY (1,1),
    fecha DATETIME NOT NULL,
    id_proveedor INT NOT NULL,
    total DECIMAL(10,2) NOT NULL,
    tipo_comprobante VARCHAR(50) NOT NULL DEFAULT 'Consumidor final',

    CONSTRAINT FK_Compra_Proveedores
    FOREIGN KEY (id_proveedor) REFERENCES Proveedores(id_proveedor)
);
         */
        public void Eliminar(int id)
        {
            using SqlConnection cn = new(ConexionDB.Cadena);
            cn.Open();

            const string SQL = "DELETE FROM Factura_Compras WHERE id_compra = @Id";
            using SqlCommand cmd = new(SQL, cn);
            cmd.Parameters.Add("@Id", SqlDbType.Int).Value = id;
            cmd.ExecuteNonQuery();
        }

        public void Guardar(FacturaCompra factura)
        {
<<<<<<< HEAD
            using SqlConnection cn = new(ConexionDB.Cadena);
            cn.Open();

            const string SQL = @"INSERT INTO Factura_Compras (fecha, id_proveedor, total, tipo_comprobante)
                            VALUES (@fecha, @id_proveedor, @total, @tipo_comprobante)";

            using SqlCommand cmd = new(SQL, cn);
            cmd.Parameters.Add("@fecha", SqlDbType.DateTime).Value = factura.Fecha;
            cmd.Parameters.Add("@id_proveedor", SqlDbType.Int).Value = factura.IdProveedor;
            cmd.Parameters.Add("@total", SqlDbType.Decimal).Value = factura.Total;
            cmd.Parameters.Add("@tipo_comprobante", SqlDbType.VarChar, 50).Value = factura.TipoComprobante;
            cmd.ExecuteNonQuery();
        }

        public DataTable Listar()
        {

            DataTable table = new();
            using SqlConnection cn = new(ConexionDB.Cadena);
            cn.Open();

            const string SQL = "SELECT id_compra, fecha, id_proveedor, total, tipo_comprobante FROM Factura_Compras";

            using SqlDataAdapter da = new(SQL, cn);
            da.Fill(table);
            return table;
=======
            throw new NotImplementedException();
        }

        public void Guardar(FacturaCompra factura)
        {
            throw new NotImplementedException();
>>>>>>> 3b7990587225094801f1cbf15aa4fb63d6d8315c
        }
    }
}
