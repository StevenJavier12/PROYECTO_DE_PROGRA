using System;
using System.Data;
using System.Windows.Forms;
using PROSERA.Entidades;
using PROSERA.Negocios;
using PROSERA.Datos;

namespace PROSERA.WinFormsUI.UsersControl
{
    public partial class UserControlCategoria : UserControl
    {
        private readonly ICategoriaProductoBL _categoriaBL;
        private int? _idCategoriaActual = null;

        public UserControlCategoria()
        {
            InitializeComponent();
            _categoriaBL = new CategoriaProductoBL(new CategoriaProductoDAL());
        }

        private void UserControlCategoria_Load(object sender, EventArgs e)
        {
            ConfigurarDataGridView();
            CargarListado();
        }

        private void ConfigurarDataGridView()
        {
            dgvCategorias.AutoGenerateColumns = true;
            dgvCategorias.SelectionChanged += dgvCategorias_SelectionChanged;

            // Ajustar automáticamente el ancho de las columnas al contenido y al espacio disponible
            dgvCategorias.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void CargarListado()
        {
            try
            {
                DataTable dt = _categoriaBL.Listar();
                dgvCategorias.DataSource = dt;

                // Ocultar la columna del ID
                if (dgvCategorias.Columns["id_categoria"] != null)
                    dgvCategorias.Columns["id_categoria"].Visible = false;

                dgvCategorias.ClearSelection();
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar categorías: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvCategorias_SelectionChanged(object? sender, EventArgs e)
        {
            if (dgvCategorias.CurrentRow == null || dgvCategorias.SelectedRows.Count == 0)
            {
                LimpiarCampos();
                return;
            }

            DataGridViewRow row = dgvCategorias.SelectedRows[0];
            _idCategoriaActual = Convert.ToInt32(row.Cells["id_categoria"].Value);
            txtNombre.Text = row.Cells["nombre"].Value?.ToString() ?? "";
            txtDescripcion.Text = row.Cells["descripcion"].Value?.ToString() ?? "";
        }

        private void LimpiarCampos()
        {
            _idCategoriaActual = null;
            txtNombre.Clear();
            txtDescripcion.Clear();
        }

        private CategoriaProducto ObtenerCategoriaDesdeFormulario()
        {
            CategoriaProducto categoria = new CategoriaProducto
            {
                Nombre = txtNombre.Text.Trim(),
                Descripcion = txtDescripcion.Text.Trim()
            };

            if (_idCategoriaActual.HasValue)
                categoria.IdCategoria = _idCategoriaActual.Value;

            return categoria;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (_idCategoriaActual.HasValue)
                {
                    MessageBox.Show("Para insertar una nueva categoría, primero limpie la selección.",
                                    "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                CategoriaProducto nueva = ObtenerCategoriaDesdeFormulario();
                _categoriaBL.Guardar(nueva);

                MessageBox.Show("Categoría guardada exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarListado();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!_idCategoriaActual.HasValue)
                {
                    MessageBox.Show("Seleccione una categoría del listado para modificar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                CategoriaProducto categoriaEditada = ObtenerCategoriaDesdeFormulario();
                _categoriaBL.Editar(categoriaEditada);

                MessageBox.Show("Categoría modificada exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarListado();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al modificar: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!_idCategoriaActual.HasValue)
                {
                    MessageBox.Show("Seleccione una categoría del listado para eliminar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DialogResult result = MessageBox.Show(
                    "¿Está seguro de que desea eliminar esta categoría?",
                    "Confirmar eliminación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (result != DialogResult.Yes)
                    return;

                _categoriaBL.Eliminar(_idCategoriaActual.Value);

                MessageBox.Show("Categoría eliminada exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarListado();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al eliminar: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Este método quedará vacío. Lo conservamos para no romper el diseñador.
        }
    }
}