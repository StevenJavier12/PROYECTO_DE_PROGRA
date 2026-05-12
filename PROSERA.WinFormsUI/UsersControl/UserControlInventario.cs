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
    public partial class UserControlInventario : UserControl
    {
        private readonly IInventarioBL _inventarioBL;
        private readonly IProductoBL _productoBL;

        public UserControlInventario()
        {



            InitializeComponent();

            _inventarioBL = new InventarioBL(new InventarioDAL());
            _productoBL = new ProductoBL(new ProductoDAL());
        }

        private void UserControlInventario_Load_1(object sender, EventArgs e)
        {
            CargarProductos();
            CargarTiposMovimiento();
            CargarGrid();

            txtInventario.Visible = false;


        }

        private void CargarProductos()
        {
            cbProducto.DataSource = _productoBL.ListarConCategoria();
            cbProducto.DisplayMember = "nombre";
            cbProducto.ValueMember = "id_producto";
            cbProducto.SelectedIndex = -1;
        }

        private void CargarTiposMovimiento()
        {
            cbTipoMovimiento.Items.Clear();
            cbTipoMovimiento.Items.Add("Entrada");
            cbTipoMovimiento.Items.Add("Salida");
            cbTipoMovimiento.SelectedIndex = -1;
        }

        private void CargarGrid()
        {
            dgvInventario.DataSource = _inventarioBL.Listar();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbProducto.SelectedValue == null)
                {
                    MessageBox.Show("Seleccione un producto.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                Inventario inventario = new Inventario
                {
                    IdProducto = (int)cbProducto.SelectedValue,
                    Stock = int.Parse(txtStock.Text.Trim()),
                    StockMinimo = int.Parse(txtStockMinimo.Text.Trim()),
                    FechaActualizacion = dtimeFechaActualizacion.Value,
                    TipoMovimiento = cbTipoMovimiento.SelectedItem.ToString(),
                    DescripcionMovimiento = txtDescripcionMovimiento.Text.Trim()
                };

                _inventarioBL.Guardar(inventario);
                MessageBox.Show("Registro guardado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Limpiar();
                CargarGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtInventario.Text))
                {
                    MessageBox.Show("Seleccione un registro del grid para editar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                Inventario inventario = new Inventario
                {
                    IdInventario = int.Parse(txtInventario.Text),
                    IdProducto = (int)cbProducto.SelectedValue,
                    Stock = int.Parse(txtStock.Text.Trim()),
                    StockMinimo = int.Parse(txtStockMinimo.Text.Trim()),
                    FechaActualizacion = dtimeFechaActualizacion.Value,
                    TipoMovimiento = cbTipoMovimiento.SelectedItem.ToString(),
                    DescripcionMovimiento = txtDescripcionMovimiento.Text.Trim()
                };

                _inventarioBL.Editar(inventario);
                MessageBox.Show("Registro actualizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Limpiar();
                CargarGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtInventario.Text))
                {
                    MessageBox.Show("Seleccione un registro del grid para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DialogResult respuesta = MessageBox.Show("¿Está seguro de eliminar este registro?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (respuesta == DialogResult.Yes)
                {
                    _inventarioBL.Eliminar(int.Parse(txtInventario.Text));
                    MessageBox.Show("Registro eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Limpiar();
                    CargarGrid();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Limpiar()
        {
            txtInventario.Text = string.Empty;
            cbProducto.SelectedIndex = -1;
            txtStock.Text = string.Empty;
            txtStockMinimo.Text = string.Empty;
            dtimeFechaActualizacion.Value = DateTime.Now;
            cbTipoMovimiento.SelectedIndex = -1;
            txtDescripcionMovimiento.Text = string.Empty;
        }

        private void dgvInventario_SelectionChanged(object? sender, EventArgs e)
        {
            if (dgvInventario.CurrentRow == null || dgvInventario.SelectedRows.Count == 0)
            {
                Limpiar();
                return;
            }

            DataGridViewRow row = dgvInventario.SelectedRows[0];

            txtInventario.Text = row.Cells["id_inventario"].Value?.ToString() ?? "";
            txtStock.Text = row.Cells["stock"].Value?.ToString() ?? "";
            txtStockMinimo.Text = row.Cells["stock_minimo"].Value?.ToString() ?? "";
            dtimeFechaActualizacion.Value = Convert.ToDateTime(row.Cells["fecha_actualizacion"].Value);
            cbTipoMovimiento.SelectedItem = row.Cells["tipo_movimiento"].Value?.ToString() ?? "";
            txtDescripcionMovimiento.Text = row.Cells["DescripcionMovimiento"].Value?.ToString() ?? "";
            cbProducto.SelectedValue = Convert.ToInt32(row.Cells["id_producto"].Value);
        }
    }
}