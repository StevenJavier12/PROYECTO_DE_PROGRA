using Microsoft.Data.SqlClient;
using PROSERA.Entidades;
using System.Data;

namespace PROSERA.Datos
{
    public class FacturaVentaDAL : IFacturaVentaDAL
    {
        /*
         * -- =========================================
-- 8. FACTURA_VENTA
-- =========================================
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
        public void Editar(FacturaVenta factura)
        {
            using SqlConnection cn = new(ConexionDB.Cadena);
            cn.Open();

            const string SQL = @"UPDATE Factura_Ventas
                                SET fecha = @Fecha,
                                    id_cliente = @IdCliente,
                                    id_usuario = @IdUsuario,
                                    total = @Total,
                                    descuento = @Descuento,
                                    metodo_pago = @MetodoPago,
                                    estado_factura = @EstadoFactura
                                WHERE id_factura = @Id";

            using SqlCommand cmd = new(SQL, cn);

            cmd.Parameters.Add("@Fecha", SqlDbType.DateTime).Value = factura.Fecha;
            cmd.Parameters.Add("@IdCliente", SqlDbType.Int).Value = factura.IdCliente;
            cmd.Parameters.Add("@IdUsuario", SqlDbType.Int).Value = factura.IdUsuario;
            cmd.Parameters.Add("@Total", SqlDbType.Decimal).Value = factura.Total;
            cmd.Parameters.Add("@Descuento", SqlDbType.Decimal).Value = factura.Descuento;
            cmd.Parameters.Add("@MetodoPago", SqlDbType.VarChar, 50).Value = factura.MetodoPago;
            cmd.Parameters.Add("@EstadoFactura", SqlDbType.VarChar, 50).Value = factura.EstadoFactura;
            cmd.Parameters.Add("@Id", SqlDbType.Int).Value = factura.IdFactura;

            cmd.ExecuteNonQuery();
        }

        public void Eliminar(int id)
        {
            using SqlConnection cn = new(ConexionDB.Cadena);
            cn.Open();

            const string SQL = "DELETE FROM Factura_Ventas WHERE id_factura = @Id";

            using SqlCommand cmd = new(SQL, cn);

            cmd.Parameters.Add("@Id", SqlDbType.Int).Value = id;

            cmd.ExecuteNonQuery();
        }



        public void Guardar(FacturaVenta factura)
        {
            using SqlConnection cn = new(ConexionDB.Cadena);
            cn.Open();

            const string SQL = @"INSERT INTO Factura_Ventas
                                (fecha, id_cliente, id_usuario, total, descuento, metodo_pago, estado_factura)
                                VALUES
                                (@Fecha, @IdCliente, @IdUsuario, @Total, @Descuento, @MetodoPago, @EstadoFactura)";

            using SqlCommand cmd = new(SQL, cn);

            cmd.Parameters.Add("@Fecha", SqlDbType.DateTime).Value = factura.Fecha;
            cmd.Parameters.Add("@IdCliente", SqlDbType.Int).Value = factura.IdCliente;
            cmd.Parameters.Add("@IdUsuario", SqlDbType.Int).Value = factura.IdUsuario;
            cmd.Parameters.Add("@Total", SqlDbType.Decimal).Value = factura.Total;
            cmd.Parameters.Add("@Descuento", SqlDbType.Decimal).Value = factura.Descuento;
            cmd.Parameters.Add("@MetodoPago", SqlDbType.VarChar, 50).Value = factura.MetodoPago;
            cmd.Parameters.Add("@EstadoFactura", SqlDbType.VarChar, 50).Value = factura.EstadoFactura;

            cmd.ExecuteNonQuery();
        }

        public DataTable Listar()
        {
            DataTable table = new();

            using SqlConnection cn = new(ConexionDB.Cadena);
            cn.Open();

            const string SQL = @"SELECT
                                    id_factura,
                                    fecha,
                                    id_cliente,
                                    id_usuario,
                                    total,
                                    descuento,
                                    metodo_pago,
                                    estado_factura
                                 FROM Factura_Ventas";

            using SqlDataAdapter da = new(SQL, cn);

            da.Fill(table);

            return table;


        }

        public DataTable ListarPorCliente(int idCliente)
        {
            throw new NotImplementedException();
        }

        public DataTable ListarPorFecha(DateTime fechaInicio, DateTime fechaFin)
        {
            throw new NotImplementedException();
        }

        public FacturaVenta? ObtenerPorId(int id)
        {
            throw new NotImplementedException();
        }

        public bool ExisteFactura(int idFactura)
        {
            throw new NotImplementedException();
        }
    }
}
