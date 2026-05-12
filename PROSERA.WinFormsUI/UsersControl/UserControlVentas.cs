using PROSERA.Datos;
using PROSERA.Entidades;
using PROSERA.Negocios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PROSERA.WinFormsUI.UsersControl
{
    public partial class UserControlVentas : UserControl
    {

        private readonly IDetalleVentaBL _detalleVentaBL;
        private readonly IFacturaVentaBL _facturaVentaBL;
        private readonly IProductoBL _ProductoBL;
        private readonly IClienteBL _ClienteBL;
        private readonly IUsuarioBL _UsuarioBL;

        private int? _idFacturaVentaActual = null;
        private int? _idDetalleVentaActual = null;


        public UserControlVentas(IDetalleVentaBL detalleVentaBL)
        {
            InitializeComponent();
            _detalleVentaBL = new DetalleVentaBL(new DetalleVentaDAL());
            _facturaVentaBL = new FacturaVentaBL(new FacturaVentaDAL());
            _ProductoBL = new ProductoBL(new ProductoDAL());
            _ClienteBL = new ClienteBL(new ClienteDAL());
            _UsuarioBL = new UsuarioBL(new UsuarioDAL());
        }

        public UserControlVentas()
        {
        }

        private void UserControlVentas_Load(object sender, EventArgs e)
        {
            ConfigurarDataGridView();
            ConfigurarDataGridViewDetalle();
            CargarListado();
            CargarListadoDetalleVenta();
            CargarProductoCombo();
            CargarClienteCombo();
            CargarUsuarioCombo();
            CalcularSubtotal();
        }






        private void ConfigurarDataGridView()
        {
            dgvFacturaVenta.AutoGenerateColumns = true;
            dgvFacturaVenta.SelectionChanged += dgvFacturaVenta_SelectionChanged;

            // Ajustar automáticamente el ancho de las columnas al contenido y al espacio disponible
            dgvFacturaVenta.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void CargarListado()
        {
            try
            {
                DataTable dt = _facturaVentaBL.Listar();
                dgvFacturaVenta.DataSource = dt;

                // Ocultar la columna del ID
                if (dgvFacturaVenta.Columns["id_factura"] != null)
                    dgvFacturaVenta.Columns["id_factura"].Visible = false;

                if (dgvFacturaVenta.Columns["id_usuario"] != null)
                    dgvFacturaVenta.Columns["id_usuario"].Visible = false;

                if (dgvFacturaVenta.Columns["id_cliente"] != null)
                    dgvFacturaVenta.Columns["id_cliente"].Visible = false;
                dgvFacturaVenta.ClearSelection();
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar facturas: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvFacturaVenta_SelectionChanged(object? sender, EventArgs e)
        {
            if (dgvFacturaVenta.CurrentRow == null || dgvFacturaVenta.SelectedRows.Count == 0)
            {
                LimpiarCampos();
                return;
            }

            DataGridViewRow row = dgvFacturaVenta.SelectedRows[0];
            _idFacturaVentaActual = Convert.ToInt32(row.Cells["id_factura"].Value);
            cbCliente.Text = row.Cells["cliente"].Value?.ToString() ?? "";
            cbUsuario.Text = row.Cells["usuario"].Value?.ToString() ?? "";
            cbDescuento.Text = row.Cells["descuento"].Value?.ToString() ?? "";
            txtTotal.Text = row.Cells["total"].Value?.ToString() ?? "";
            cbMetodoPago.Text = row.Cells["metodo_pago"].Value?.ToString() ?? "";
            cbEstadoFac.Text = row.Cells["estado_factura"].Value?.ToString() ?? "";

        }
        private void LimpiarCampos()
        {
            _idFacturaVentaActual = null;
            _idDetalleVentaActual = null;
            cbCliente.Text = "";
            dtimeFecha.Value = DateTime.Now;
            cbDescuento.Text = "";
            cbMetodoPago.Text = "";
            cbEstadoFac.Text = "";
            txtTotal.Text = "";
            cbProducto.Text = "";
            numCantidad.Text = "";
            txbPrecio.Text = "";
            txbSubTotal.Text = "";
        }
        private FacturaVenta ObtenerCategoriaDesdeFormulario()
        {
            FacturaVenta factura = new FacturaVenta
            {
                Fecha = dtimeFecha.Value,
                IdCliente = Convert.ToInt32(cbCliente.SelectedValue),
                IdUsuario = Convert.ToInt32(cbUsuario.SelectedValue),
                Total = Convert.ToDecimal(txtTotal.Text),
                Descuento = Convert.ToDecimal(cbDescuento.SelectedValue),
                MetodoPago = cbMetodoPago.SelectedItem?.ToString() ?? "",
                EstadoFactura = cbEstadoFac.SelectedItem?.ToString() ?? ""

            };

            if (_idFacturaVentaActual.HasValue)
                factura.IdFactura = _idFacturaVentaActual.Value;

            return factura;
        }

        /// /////////////////////////////////////////////////////////////////////////////

        //AHORA SE CONDIGURA LA DGV DE DETALLE VENTA

        private void ConfigurarDataGridViewDetalle()
        {
            dgvDetalleVenta.AutoGenerateColumns = true;
            dgvDetalleVenta.SelectionChanged += dgvDetalleVenta_SelectionChanged;

            // Ajustar automáticamente el ancho de las columnas al contenido y al espacio disponible
            dgvDetalleVenta.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void dgvDetalleVenta_SelectionChanged(object? sender, EventArgs e)
        {
            if (dgvDetalleVenta.CurrentRow == null || dgvDetalleVenta.SelectedRows.Count == 0)
            {
                LimpiarCampos();
                return;
            }

            DataGridViewRow row = dgvDetalleVenta.SelectedRows[0];
            _idFacturaVentaActual = Convert.ToInt32(row.Cells["Idfactura"].Value);
            cbCliente.Text = row.Cells["Idfactura"].Value?.ToString() ?? "";
            cbProducto.Text = row.Cells["IdProducto"].Value?.ToString() ?? "";
            numCantidad.Text = row.Cells["cantidad"].Value?.ToString() ?? "";
            txbPrecio.Text = row.Cells["PrecioUnitario"].Value?.ToString() ?? "";
            txbSubTotal.Text = row.Cells["subtotal"].Value?.ToString() ?? "";

        }

        private void CargarListadoDetalleVenta()
        {
            try
            {

                List<DetalleVenta> dt = _detalleVentaBL.Listar();
                dgvDetalleVenta.DataSource = dt;

                // Ocultar la columna del ID
                if (dgvDetalleVenta.Columns["IdDetalle"] != null)
                    dgvDetalleVenta.Columns["IdDetalle"].Visible = false;

                if (dgvDetalleVenta.Columns["FacturaVenta"] != null)
                    dgvDetalleVenta.Columns["FacturaVenta"].Visible = false;

                if (dgvDetalleVenta.Columns["Producto"] != null)
                    dgvDetalleVenta.Columns["Producto"].Visible = false;

                if (dgvDetalleVenta.Columns["IdProducto"] != null)
                    dgvDetalleVenta.Columns["IdProducto"].Visible = false;

                if (dgvDetalleVenta.Columns["NombreProducto"] != null)
                    dgvDetalleVenta.Columns["NombreProducto"].HeaderText = "Producto";



                dgvDetalleVenta.ClearSelection();
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar facturas: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvDetalleVenta_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        //Rellenando los combo box

        private void CargarProductoCombo()
        {
            cbProducto.DataSource = _ProductoBL.ListarConCategoria();
            cbProducto.DisplayMember = "nombre";
            cbProducto.ValueMember = "id_producto";
            cbProducto.SelectedIndex = -1;
        }

        private void CargarClienteCombo()
        {
            cbCliente.DataSource = _ClienteBL.Listar();
            cbCliente.DisplayMember = "nombre";
            cbCliente.ValueMember = "id_cliente";
            cbCliente.SelectedIndex = -1;
        }

        private void CargarUsuarioCombo()
        {
            cbUsuario.DataSource = _UsuarioBL.Listar();
            cbUsuario.DisplayMember = "empleado_nombre";
            cbUsuario.ValueMember = "id_usuario";
            cbUsuario.SelectedIndex = -1;
        }

        //CALCULAR SUBTOTAL Y TOTAL

        private void CalcularSubtotal()
        {
            if (decimal.TryParse(txbPrecio.Text, out decimal precio) &&
                int.TryParse(numCantidad.Text, out int cantidad))
            {
                txbSubTotal.Text = (precio * cantidad).ToString("F2");
            }
        }


        private void btnGuardar_Click(object sender, EventArgs e)
        {

        }

        private void cbProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbProducto.SelectedValue != null)
            {
                DataRowView fila = (DataRowView)cbProducto.SelectedItem;
                txbPrecio.Text = fila["precio_unitario"].ToString();
                CalcularSubtotal();
            }
        }

        private void numCantidad_ValueChanged(object sender, EventArgs e)
        {
            CalcularSubtotal();
        }
    }
}
