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

        public void Eliminar(int id)
        {
            using SqlConnection cn = new(ConexionDB.Cadena);
            cn.Open();

            const string SQL = "DELETE FROM Factura_Compras WHERE id_compra = @Id";
            using SqlCommand cmd = new(SQL, cn);
            cmd.Parameters.Add("@Id", SqlDbType.Int).Value = id;
            cmd.ExecuteNonQuery();
        }

        public int Guardar(FacturaCompra factura)
        {
            using SqlConnection cn = new(ConexionDB.Cadena);
            cn.Open();

            const string SQL = @"INSERT INTO Factura_Compras (fecha, id_proveedor, total, tipo_comprobante)
                         OUTPUT INSERTED.id_compra
                         VALUES (@fecha, @id_proveedor, @total, @tipo_comprobante)";

            using SqlCommand cmd = new(SQL, cn);
            cmd.Parameters.Add("@fecha", SqlDbType.DateTime).Value = factura.Fecha;
            cmd.Parameters.Add("@id_proveedor", SqlDbType.Int).Value = factura.IdProveedor;
            cmd.Parameters.Add("@total", SqlDbType.Decimal).Value = factura.Total;
            cmd.Parameters.Add("@tipo_comprobante", SqlDbType.VarChar, 50).Value = factura.TipoComprobante;

            return (int)cmd.ExecuteScalar();
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
        }
        public FacturaCompra? ObtenerPorId(int id)
        {
            using SqlConnection cn = new(ConexionDB.Cadena);
            cn.Open();

            const string SQL = @"SELECT id_compra, fecha, id_proveedor, total, tipo_comprobante 
                         FROM Factura_Compras WHERE id_compra = @Id";
            using SqlCommand cmd = new(SQL, cn);
            cmd.Parameters.Add("@Id", SqlDbType.Int).Value = id;

            using SqlDataReader dr = cmd.ExecuteReader();
            if (!dr.Read()) return null;

            return new FacturaCompra
            {
                IdCompra = Convert.ToInt32(dr["id_compra"]),
                Fecha = Convert.ToDateTime(dr["fecha"]),
                IdProveedor = Convert.ToInt32(dr["id_proveedor"]),
                Total = Convert.ToDecimal(dr["total"]),
                TipoComprobante = dr["tipo_comprobante"].ToString()
            };
        }
        public void Editar(FacturaCompra factura)
        {
            using SqlConnection cn = new(ConexionDB.Cadena);
            cn.Open();

            const string SQL = @"UPDATE Factura_Compras 
                         SET fecha = @fecha, 
                             id_proveedor = @id_proveedor, 
                             total = @total, 
                             tipo_comprobante = @tipo_comprobante
                         WHERE id_compra = @id_compra";

            using SqlCommand cmd = new(SQL, cn);
            cmd.Parameters.Add("@id_compra", SqlDbType.Int).Value = factura.IdCompra;
            cmd.Parameters.Add("@fecha", SqlDbType.DateTime).Value = factura.Fecha;
            cmd.Parameters.Add("@id_proveedor", SqlDbType.Int).Value = factura.IdProveedor;
            cmd.Parameters.Add("@total", SqlDbType.Decimal).Value = factura.Total;
            cmd.Parameters.Add("@tipo_comprobante", SqlDbType.VarChar, 50).Value = factura.TipoComprobante;
            cmd.ExecuteNonQuery();
        }

    }
}
