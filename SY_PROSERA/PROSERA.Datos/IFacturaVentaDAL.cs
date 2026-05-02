using System;
using System.Collections.Generic;
using System.Text;

namespace PROSERA.Datos
{
    public interface IFacturaVentaDAL
    {
        void Guardar(FacturaVenta factura);
        DataTable Listar();
        void Eliminar(int id);
    }
/*
CREATE TABLE Factura_Ventas (
    id_factura INT PRIMARY KEY IDENTITY (1,1),
    fecha DATETIME NOT NULL,
    id_cliente INT NOT NULL,
    id_usuario INT NOT NULL,
    total DECIMAL(10,2) NOT NULL,
    descuento DECIMAL(10,2) NOT NULL DEFAULT 0,
    metodo_pago VARCHAR(50) NOT NULL,
    estado_factura VARCHAR(50) NOT NULL,


    CONSTRAINT FK_Factura_Clientes
    FOREIGN KEY (id_cliente) REFERENCES Clientes(id_cliente),

    CONSTRAINT FK_Factura_Usuarios
    FOREIGN KEY (id_usuario) REFERENCES Usuarios(id_usuario)
);
*/
    public class FacturaVentaDAL : IFacturaVentaDAL
    {
        public void Guardar(FacturaVenta factura)
        {
            using SqlConnection cn = new(ConexionDB.Cadena);
            cn.Open();

            string sql = @"INSERT INTO Factura_Ventas
                          (fecha, id_cliente, id_usuario, total, descuento, metodo_pago, estado_factura)
                          VALUES (@fecha, @cliente, @usuario, @total, @desc, @metodo, @estado);
                          SELECT SCOPE_IDENTITY();";

            using SqlCommand cmd = new(sql, cn);
            cmd.Parameters.Add("@fecha", SqlDbType.DateTime).Value = factura.Fecha;
            cmd.Parameters.Add("@cliente", SqlDbType.Int).Value = factura.IdCliente;
            cmd.Parameters.Add("@usuario", SqlDbType.Int).Value = factura.IdUsuario;
            cmd.Parameters.Add("@total", SqlDbType.Decimal).Value = factura.Total;
            cmd.Parameters.Add("@desc", SqlDbType.Decimal).Value = factura.Descuento;
            cmd.Parameters.Add("@metodo", SqlDbType.VarChar, 50).Value = factura.MetodoPago;
            cmd.Parameters.Add("@estado", SqlDbType.VarChar, 50).Value = factura.EstadoFactura;

            factura.IdFactura = Convert.ToInt32(cmd.ExecuteScalar());
        }

        public DataTable Listar()
        {
            using SqlConnection cn = new(ConexionDB.Cadena);
            cn.Open();

            string sql = @"SELECT fv.id_factura, fv.fecha, c.nombre, fv.total
                           FROM Factura_Ventas fv
                           INNER JOIN Clientes c 
                           ON fv.id_cliente = c.id_cliente";

            using SqlDataAdapter da = new(sql, cn);
            DataTable dt = new();
            da.Fill(dt);
            return dt;
        }

        public void Eliminar(int id)
        {
            using SqlConnection cn = new(ConexionDB.Cadena);
            cn.Open();

            string sql = "DELETE FROM Factura_Ventas WHERE id_factura = @id";

            using SqlCommand cmd = new(sql, cn);
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;

            cmd.ExecuteNonQuery();
        }
    }
}
