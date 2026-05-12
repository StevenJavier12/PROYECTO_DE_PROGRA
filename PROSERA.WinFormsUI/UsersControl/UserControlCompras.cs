using PROSERA.Datos;
using PROSERA.Entidades;
using PROSERA.Negocios;
using System.Data;

namespace PROSERA.WinFormsUI.UsersControl
{
    public partial class UserControlCompras : UserControl
    {
        // ============ DEPENDENCIAS ============
        private readonly IFacturaCompraBL _facturaCompraBL;
        private readonly IDetalleCompraBL _detalleCompraBL;
        private readonly IProveedorBL _proveedorBL;
        private readonly IProductoBL _productoBL;

        // ============ CONSTRUCTOR ============
        public UserControlCompras()
        {
            InitializeComponent();

            // Instanciar dependencias (ajustar según como manejen DI ustedes)
            IFacturaCompraDAL facturaDAL = new FacturaCompraDAL();
            IDetalleCompraDAL detalleDAL = new DetalleCompraDAL();
            IProveedorDAL proveedorDAL = new ProveedorDAL();
            IProductoDAL productoDAL = new ProductoDAL();

            _facturaCompraBL = new FacturaCompraBL(facturaDAL);
            _detalleCompraBL = new DetalleCompraBL();
            _proveedorBL = new ProveedorBL(proveedorDAL);
            _productoBL = new ProductoBL(productoDAL);
        }

        // ============ LOAD ============
        private void UserControlCompras_Load(object sender, EventArgs e)
        {
            ConfigurarDataGridView();
            CargarProveedores();
            CargarProductosEnColumna();
            CargarTiposComprobante();
            PrepararNuevo();
        }

        // ============ CONFIGURACIÓN INICIAL ============
        private void ConfigurarDataGridView()
        {
            dgvDetalle.AutoGenerateColumns = false;
            dgvDetalle.Columns.Clear();

            // Columna Producto (ComboBox)
            DataGridViewComboBoxColumn colProducto = new DataGridViewComboBoxColumn();
            colProducto.Name = "colProducto";
            colProducto.HeaderText = "Producto";
            colProducto.DataPropertyName = "IdProducto";
            colProducto.DisplayMember = "Nombre";
            colProducto.ValueMember = "IdProducto";
            colProducto.Width = 200;
            dgvDetalle.Columns.Add(colProducto);

            // Columna Cantidad
            DataGridViewTextBoxColumn colCantidad = new DataGridViewTextBoxColumn();
            colCantidad.Name = "colCantidad";
            colCantidad.HeaderText = "Cantidad";
            colCantidad.Width = 80;
            colCantidad.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvDetalle.Columns.Add(colCantidad);

            // Columna Costo Unitario
            DataGridViewTextBoxColumn colCosto = new DataGridViewTextBoxColumn();
            colCosto.Name = "colCostoUnitario";
            colCosto.HeaderText = "Costo Unitario";
            colCosto.Width = 110;
            colCosto.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            colCosto.DefaultCellStyle.Format = "N2";
            dgvDetalle.Columns.Add(colCosto);

            // Columna Subtotal (solo lectura)
            DataGridViewTextBoxColumn colSubtotal = new DataGridViewTextBoxColumn();
            colSubtotal.Name = "colSubtotal";
            colSubtotal.HeaderText = "Subtotal";
            colSubtotal.Width = 110;
            colSubtotal.ReadOnly = true;
            colSubtotal.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            colSubtotal.DefaultCellStyle.Format = "N2";
            dgvDetalle.Columns.Add(colSubtotal);
        }

        private void CargarProveedores()
        {
            DataTable dt = _proveedorBL.Listar();
            cboProveedor.DataSource = dt;
            cboProveedor.DisplayMember = "nombre_empresa";
            cboProveedor.ValueMember = "id_proveedor";
            cboProveedor.SelectedIndex = -1;
        }

        private void CargarProductosEnColumna()
        {
            DataTable dt = _productoBL.ListarConCategoria();
            DataGridViewComboBoxColumn col = (DataGridViewComboBoxColumn)dgvDetalle.Columns["colProducto"];
            col.DataSource = dt;
            col.DisplayMember = "nombre";
            col.ValueMember = "id_producto";
        }

        private void CargarTiposComprobante()
        {
            cboTipoComprobante.Items.Clear();
            cboTipoComprobante.Items.Add("Consumidor final");
            cboTipoComprobante.Items.Add("Crédito fiscal");
            cboTipoComprobante.Items.Add("Factura");
            cboTipoComprobante.SelectedIndex = 0; // Default: Consumidor final
        }

        // ============ EVENTOS DEL DATAGRIDVIEW ============
        private void dgvDetalle_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            // Recalcular subtotal de la fila editada
            if (e.RowIndex >= 0)
            {
                CalcularSubtotalFila(e.RowIndex);
                CalcularTotal();
            }
        }

        private void dgvDetalle_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            CalcularTotal();
        }

        // ============ CÁLCULOS ============
        private void CalcularSubtotalFila(int rowIndex)
        {
            if (rowIndex < 0 || rowIndex >= dgvDetalle.Rows.Count) return;

            DataGridViewRow row = dgvDetalle.Rows[rowIndex];

            if (row.Cells["colCantidad"].Value != null &&
                row.Cells["colCostoUnitario"].Value != null)
            {
                if (int.TryParse(row.Cells["colCantidad"].Value.ToString(), out int cantidad) &&
                    decimal.TryParse(row.Cells["colCostoUnitario"].Value.ToString(), out decimal costo))
                {
                    row.Cells["colSubtotal"].Value = cantidad * costo;
                }
            }
        }

        private void CalcularTotal()
        {
            decimal total = 0;
            foreach (DataGridViewRow row in dgvDetalle.Rows)
            {
                if (!row.IsNewRow && row.Cells["colSubtotal"].Value != null)
                {
                    total += Convert.ToDecimal(row.Cells["colSubtotal"].Value);
                }
            }
            txtTotal.Text = total.ToString("N2");
        }

        // ============ BOTONES DEL DETALLE ============
        private void btnAgregarLinea_Click(object sender, EventArgs e)
        {
            dgvDetalle.Rows.Add();
        }

        private void btnQuitarLinea_Click(object sender, EventArgs e)
        {
            if (dgvDetalle.CurrentRow != null && !dgvDetalle.CurrentRow.IsNewRow)
            {
                dgvDetalle.Rows.RemoveAt(dgvDetalle.CurrentRow.Index);
            }
        }

        // ============ BOTONES PRINCIPALES ============
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            PrepararNuevo();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidarFormulario()) return;

                FacturaCompra factura = ObtenerFacturaDelFormulario();

                if (string.IsNullOrEmpty(txtIdCompra.Text))
                {
                    // NUEVA COMPRA
                    int idCompra = _facturaCompraBL.Guardar(factura);
                    GuardarDetalles(idCompra);
                    txtIdCompra.Text = idCompra.ToString();
                    MessageBox.Show("Compra registrada correctamente.", "Éxito",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    // EDITAR COMPRA EXISTENTE
                    factura.IdCompra = Convert.ToInt32(txtIdCompra.Text);
                    _facturaCompraBL.Editar(factura);

                    // Reemplazar detalles: eliminar los viejos y guardar los nuevos
                    DataTable detallesViejos = _detalleCompraBL.ListarPorCompra(factura.IdCompra);
                    foreach (DataRow row in detallesViejos.Rows)
                    {
                        _detalleCompraBL.Eliminar(Convert.ToInt32(row["id_detalle_compra"]));
                    }
                    GuardarDetalles(factura.IdCompra);

                    MessageBox.Show("Compra actualizada correctamente.", "Éxito",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            PrepararNuevo();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtIdCompra.Text))
                {
                    MessageBox.Show("No hay compra cargada para eliminar.", "Aviso",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int idCompra = Convert.ToInt32(txtIdCompra.Text);

                DialogResult result = MessageBox.Show("¿Eliminar esta compra y todo su detalle?",
                    "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    // Eliminar detalles primero
                    DataTable detalles = _detalleCompraBL.ListarPorCompra(idCompra);
                    foreach (DataRow row in detalles.Rows)
                    {
                        _detalleCompraBL.Eliminar(Convert.ToInt32(row["id_detalle_compra"]));
                    }
                    // Eliminar encabezado
                    _facturaCompraBL.Eliminar(idCompra);

                    MessageBox.Show("Compra eliminada.", "Éxito",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    PrepararNuevo();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!int.TryParse(txtBuscarCompra.Text.Trim(), out int idCompra) || idCompra <= 0)
                {
                    MessageBox.Show("Ingrese un ID de compra válido.", "Aviso",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                FacturaCompra? factura = _facturaCompraBL.ObtenerPorId(idCompra);
                if (factura == null)
                {
                    MessageBox.Show("Compra no encontrada.", "Aviso",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // Cargar encabezado
                txtIdCompra.Text = factura.IdCompra.ToString();
                dtpFecha.Value = factura.Fecha;
                cboProveedor.SelectedValue = factura.IdProveedor;
                cboTipoComprobante.Text = factura.TipoComprobante;
                txtTotal.Text = factura.Total.ToString("N2");

                // Cargar detalle
                CargarDetalleEnGrid(factura.IdCompra);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ============ MÉTODOS AUXILIARES ============
        private void PrepararNuevo()
        {
            txtIdCompra.Text = "";
            dtpFecha.Value = DateTime.Today;
            cboProveedor.SelectedIndex = -1;
            cboTipoComprobante.SelectedIndex = 0;
            txtTotal.Text = "0.00";
            dgvDetalle.Rows.Clear();
        }

        private bool ValidarFormulario()
        {
            if (cboProveedor.SelectedValue == null ||
                !int.TryParse(cboProveedor.SelectedValue.ToString(), out _))
            {
                MessageBox.Show("Seleccione un proveedor.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrWhiteSpace(cboTipoComprobante.Text))
            {
                MessageBox.Show("Seleccione un tipo de comprobante.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (dgvDetalle.Rows.Count == 0)
            {
                MessageBox.Show("Agregue al menos un producto al detalle.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            foreach (DataGridViewRow row in dgvDetalle.Rows)
            {
                if (row.IsNewRow) continue;

                if (row.Cells["colProducto"].Value == null)
                {
                    MessageBox.Show("Seleccione un producto en todas las filas.", "Validación",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
                if (row.Cells["colCantidad"].Value == null ||
                    !int.TryParse(row.Cells["colCantidad"].Value.ToString(), out int cant) || cant <= 0)
                {
                    MessageBox.Show("Ingrese una cantidad válida en todas las filas.", "Validación",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
                if (row.Cells["colCostoUnitario"].Value == null ||
                    !decimal.TryParse(row.Cells["colCostoUnitario"].Value.ToString(), out decimal costo) || costo <= 0)
                {
                    MessageBox.Show("Ingrese un costo unitario válido en todas las filas.", "Validación",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }

            return true;
        }

        private FacturaCompra ObtenerFacturaDelFormulario()
        {
            return new FacturaCompra
            {
                Fecha = dtpFecha.Value,
                IdProveedor = Convert.ToInt32(cboProveedor.SelectedValue),
                Total = Convert.ToDecimal(txtTotal.Text),
                TipoComprobante = cboTipoComprobante.Text
            };
        }

        private void GuardarDetalles(int idCompra)
        {
            foreach (DataGridViewRow row in dgvDetalle.Rows)
            {
                if (row.IsNewRow) continue;

                DetalleCompra detalle = new DetalleCompra
                {
                    IdCompra = idCompra,
                    IdProducto = Convert.ToInt32(row.Cells["colProducto"].Value),
                    Cantidad = Convert.ToInt32(row.Cells["colCantidad"].Value),
                    CostoUnitario = Convert.ToDecimal(row.Cells["colCostoUnitario"].Value),
                    Subtotal = Convert.ToDecimal(row.Cells["colSubtotal"].Value)
                };

                _detalleCompraBL.Guardar(detalle);
            }
        }

        private void CargarDetalleEnGrid(int idCompra)
        {
            dgvDetalle.Rows.Clear();
            DataTable dt = _detalleCompraBL.ListarPorCompra(idCompra);

            foreach (DataRow row in dt.Rows)
            {
                int rowIndex = dgvDetalle.Rows.Add();
                DataGridViewRow dgvRow = dgvDetalle.Rows[rowIndex];

                dgvRow.Cells["colProducto"].Value = row["id_producto"];
                dgvRow.Cells["colCantidad"].Value = row["cantidad"];
                dgvRow.Cells["colCostoUnitario"].Value = row["costo_unitario"];
                dgvRow.Cells["colSubtotal"].Value = row["subtotal"];
            }
        }

        private void txtTotal_TextChanged(object sender, EventArgs e)
        {

        }

        // ============ EVENTOS ASIGNADOS EN EL DESIGNER (solo los que existen) ============
        // El Designer ya tiene estos:
        // - UserControlCompras_Load
        // No tiene eventos Click para los botones aún.

        // Debes enlazar manualmente estos eventos en el Designer o en el constructor:
        // btnBuscar.Click += btnBuscar_Click;
        // btnNuevo.Click += btnNuevo_Click;
        // btnGuardar.Click += btnGuardar_Click;
        // btnCancelar.Click += btnCancelar_Click;
        // btnEliminar.Click += btnEliminar_Click;
        // btnAgregarLinea.Click += btnAgregarLinea_Click;
        // btnQuitarLinea.Click += btnQuitarLinea_Click;
        // dgvDetalle.CellEndEdit += dgvDetalle_CellEndEdit;
        // dgvDetalle.RowsRemoved += dgvDetalle_RowsRemoved;
    }
}