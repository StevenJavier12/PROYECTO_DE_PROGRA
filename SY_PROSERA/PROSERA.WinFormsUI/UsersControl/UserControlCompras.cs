using PROSERA.Datos;
using PROSERA.Entidades;
using PROSERA.Negocios;
using System.ComponentModel;
using System.Data;

namespace PROSERA.WinFormsUI.UsersControl
{
    public partial class UserControlCompras : UserControl
    {
        private readonly IProveedorBL _proveedorBL;
        private readonly IDetalleCompraBL _detalleCompraBL;
        private readonly ICategoriaProductoBL _categoriaBL;

        public UserControlCompras()
        {
            InitializeComponent();
            _proveedorBL = new ProveedorBL(new ProveedorDAL());
            _categoriaBL = new CategoriaProductoBL(new CategoriaProductoDAL());
            _detalleCompraBL = new DetalleCompraBL(new DetalleCompraDAL());

            CargarProveedores();
            CargarProductos();
            ConfigurarDataGridView();
            CargarVentasGrid();
        }

        // ─────────────────────────────────────────
        // CARGA INICIAL
        // ─────────────────────────────────────────

        private void CargarProveedores()
        {
            ProveedorDAL dal = new ProveedorDAL();
            cbProveedor.DataSource = dal.Listar();
            cbProveedor.DisplayMember = "nombre_empresa";
            cbProveedor.ValueMember = "id_proveedor";
        }

        private void CargarProductos()
        {
            ProductoDAL dal = new ProductoDAL();
            DataTable dt = dal.ListarConCategoria();

            cbProducto.DataSource = dt;
            cbProducto.DisplayMember = "nombre";
            cbProducto.ValueMember = "id_producto";

            // Evitar que dispare eventos antes de que el usuario elija
            cbProducto.SelectedIndex = -1;
        }

        private void ConfigurarDataGridView()
        {
            dgvDetalleProducto.Columns.Clear();
            dgvDetalleProducto.AutoGenerateColumns = false;

            dgvDetalleProducto.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "IdProducto",
                HeaderText = "ID",
                DataPropertyName = "IdProducto",
                Visible = false
            });
            dgvDetalleProducto.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Producto",
                HeaderText = "Producto",
                DataPropertyName = "Producto",
                Width = 200
            });
            dgvDetalleProducto.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Cantidad",
                HeaderText = "Cantidad",
                DataPropertyName = "Cantidad",
                Width = 80
            });
            dgvDetalleProducto.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Precio",
                HeaderText = "Precio",
                DataPropertyName = "Precio",
                Width = 100,
                DefaultCellStyle = { Format = "N2" }
            });
            dgvDetalleProducto.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "SubTotal",
                HeaderText = "SubTotal",
                DataPropertyName = "SubTotal",
                Width = 100,
                DefaultCellStyle = { Format = "N2" }
            });

            // Lista en memoria que alimenta el grid
            dgvDetalleProducto.DataSource = _detalleCompra;
        }

        // ─────────────────────────────────────────
        // LISTA EN MEMORIA (detalle de la compra)
        // ─────────────────────────────────────────

        private readonly BindingList<DetalleCompraItem> _detalleCompra = new();

        // Clase auxiliar para las filas del grid
        private class DetalleCompraItem
        {
            public int IdProducto { get; set; }
            public string Producto { get; set; } = "";
            public int Cantidad { get; set; }
            public decimal Precio { get; set; }
            public decimal SubTotal { get; set; }
        }

        // ─────────────────────────────────────────
        // EVENTOS
        // ─────────────────────────────────────────

        /// <summary>
        /// Al seleccionar un producto → llena Precio y recalcula SubTotal
        /// </summary>
        private void cbProducto_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cbProducto.SelectedItem is not DataRowView fila) return;

            // Llenar precio desde la fila del DataTable (sin ir a la BD de nuevo)
            if (decimal.TryParse(fila["precio_unitario"].ToString(), out decimal precio))
            {
                txbPrecio.Text = precio.ToString("N2");
            }
            else
            {
                txbPrecio.Text = "0.00";
            }

            CalcularSubTotal();
        }

        /// <summary>
        /// Al cambiar la cantidad → recalcula SubTotal
        /// </summary>
        private void numCantidad_ValueChanged(object sender, EventArgs e)
        {
            CalcularSubTotal();
        }

        /// <summary>
        /// Botón Agregar → añade la fila al DataGridView
        /// </summary>
        private void btnAgregar_Click(object sender, EventArgs e)
        {

        }




        /// <summary>
        /// Botón Eliminar → quita la fila seleccionada del grid
        /// </summary>
        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }

        // ─────────────────────────────────────────
        // HELPERS
        // ─────────────────────────────────────────

        private void CalcularSubTotal()
        {
            if (!decimal.TryParse(txbPrecio.Text, out decimal precio)) return;

            decimal subtotal = (int)numCantidad.Value * precio;
            txbSubtotal.Text = subtotal.ToString("N2");
        }

        private void ActualizarTotalGeneral()
        {
            // Si tienes un label/textbox para el Total general, actualízalo aquí
            decimal total = _detalleCompra.Sum(x => x.SubTotal);
            // lblTotal.Text = total.ToString("N2");  // ← descomenta si tienes este control
        }

        private void LimpiarDetalle()
        {
            cbProducto.SelectedIndex = -1;
            numCantidad.Value = 1;
            txbPrecio.Text = "";
            txbSubtotal.Text = "";
        }

        private void UserControlCompras_Load(object sender, EventArgs e) { }

        private void txbSubtotal_TextChanged(object sender, EventArgs e)
        {
            CalcularSubTotal();
        }

        private void txbPrecio_TextChanged(object sender, EventArgs e)
        {
            CalcularSubTotal();
        }

        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
            if (cbProducto.SelectedItem is not DataRowView fila)
            {
                MessageBox.Show("Selecciona un producto.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(txbPrecio.Text, out decimal precio) || precio <= 0)
            {
                MessageBox.Show("El precio no es válido.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int cantidad = (int)numCantidad.Value;
            int idProducto = Convert.ToInt32(fila["id_producto"]);
            string nombre = fila["nombre"].ToString() ?? "";
            decimal subtotal = cantidad * precio;

            // ¿Ya existe ese producto en el grid? → actualizar cantidad
            var existente = _detalleCompra.FirstOrDefault(x => x.IdProducto == idProducto);
            if (existente != null)
            {
                existente.Cantidad += cantidad;
                existente.SubTotal = existente.Cantidad * existente.Precio;
            }
            else
            {
                _detalleCompra.Add(new DetalleCompraItem
                {
                    IdProducto = idProducto,
                    Producto = nombre,
                    Cantidad = cantidad,
                    Precio = precio,
                    SubTotal = subtotal
                });
            }

            dgvDetalleProducto.Refresh();
            ActualizarTotalGeneral();
            LimpiarDetalle();
        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            if (dgvDetalleProducto.CurrentRow == null) return;

            int index = dgvDetalleProducto.CurrentRow.Index;
            if (index >= 0 && index < _detalleCompra.Count)
            {
                _detalleCompra.RemoveAt(index);
                ActualizarTotalGeneral();
            }
        }

        private void cbDescuento_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbProveedor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void CargarVentasGrid()
        {
            dgvVenta.DataSource = _detalleCompraBL.Listar();
            if (dgvVenta.Columns["IdFactura"] != null)
                dgvVenta.Columns["IdFactura"].Visible = false;
            if (dgvVenta.Columns["CategoriaId"] != null)
                dgvVenta.Columns["CategoriaId"].Visible = false;
        }
        private void dgvVenta_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}