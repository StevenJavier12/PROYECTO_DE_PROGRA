using PROSERA.Datos;
using PROSERA.Entidades;
using PROSERA.Negocios;
using System.Data;

namespace PROSERA.WinFormsUI.UsersControl
{
    public partial class UserControlProducto : UserControl
    {
        private readonly ProductoBL _productoBL;
        private readonly MarcaBL _marcaBL;
        private readonly CategoriaProductoBL _categoriaBL;

        public UserControlProducto()
        {
            InitializeComponent();

            _productoBL = new ProductoBL(new ProductoDAL());
            _marcaBL = new MarcaBL(new MarcaDAL());
            _categoriaBL = new CategoriaProductoBL(new CategoriaProductoDAL());
        }

        private void UserControlProducto_Load(object sender, EventArgs e)
        {
            if (DesignMode) return;
            CargarMarcas();
            CargarCategorias();
            CargarEstados();
            CargarGrid();

            txtIdProducto.Visible = false;
        }

        private void CargarMarcas()
        {
            List<Marca> marcas = _marcaBL.Listar();
            cbMarca.DataSource = marcas;
            cbMarca.DisplayMember = "Nombre";
            cbMarca.ValueMember = "IdMarca";
            cbMarca.SelectedIndex = -1;
        }

        private void CargarCategorias()
        {
            DataTable tabla = _categoriaBL.Listar();
            cbCategoria.DataSource = tabla;
            cbCategoria.DisplayMember = "nombre";
            cbCategoria.ValueMember = "id_categoria";
            cbCategoria.SelectedIndex = -1;
        }

        private void CargarEstados()
        {
            cbEstadoProducto.Items.Clear();
            cbEstadoProducto.Items.Add("Activo");
            cbEstadoProducto.Items.Add("Inactivo");
            cbEstadoProducto.SelectedIndex = -1;
        }

        private void CargarGrid()
        {
            dgvProducto.DataSource = _productoBL.ListarConCategoria();
        }

        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (cbMarca.SelectedValue == null || cbCategoria.SelectedValue == null || cbEstadoProducto.SelectedItem == null)
                {
                    MessageBox.Show("Complete todos los campos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                Producto producto = new Producto
                {
                    Nombre = txtNombre.Text.Trim(),
                    Descripcion = txtDescripcion.Text.Trim(),
                    PrecioUnitario = decimal.Parse(txtPrecioUnitario.Text.Trim()),
                    IdMarca = (int)cbMarca.SelectedValue,
                    IdCategoria = (int)cbCategoria.SelectedValue,
                    EstadoProducto = cbEstadoProducto.SelectedItem.ToString()
                };

                _productoBL.Guardar(producto);
                MessageBox.Show("Producto guardado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Limpiar();
                CargarGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEditar_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtIdProducto.Text))
                {
                    MessageBox.Show("Seleccione un producto del grid para editar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                Producto producto = new Producto
                {
                    IdProducto = int.Parse(txtIdProducto.Text),
                    Nombre = txtNombre.Text.Trim(),
                    Descripcion = txtDescripcion.Text.Trim(),
                    PrecioUnitario = decimal.Parse(txtPrecioUnitario.Text.Trim()),
                    IdMarca = (int)cbMarca.SelectedValue,
                    IdCategoria = (int)cbCategoria.SelectedValue,
                    EstadoProducto = cbEstadoProducto.SelectedItem.ToString()
                };

                _productoBL.Editar(producto);
                MessageBox.Show("Producto actualizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Limpiar();
                CargarGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtIdProducto.Text))
                {
                    MessageBox.Show("Seleccione un producto del grid para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DialogResult respuesta = MessageBox.Show("¿Está seguro de eliminar este producto?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (respuesta == DialogResult.Yes)
                {
                    _productoBL.Eliminar(int.Parse(txtIdProducto.Text));
                    MessageBox.Show("Producto eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Limpiar();
                    CargarGrid();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLimpiar_Click_1(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Limpiar()
        {
            txtIdProducto.Text = string.Empty;
            txtNombre.Text = string.Empty;
            txtDescripcion.Text = string.Empty;
            txtPrecioUnitario.Text = string.Empty;
            cbMarca.SelectedIndex = -1;
            cbCategoria.SelectedIndex = -1;
            cbEstadoProducto.SelectedIndex = -1;
        }

        private void dgvProducto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow fila = dgvProducto.Rows[e.RowIndex];

            txtIdProducto.Text = fila.Cells["IdProducto"].Value.ToString();
            txtNombre.Text = fila.Cells["Nombre"].Value.ToString();
            txtDescripcion.Text = fila.Cells["Descripcion"].Value.ToString();
            txtPrecioUnitario.Text = fila.Cells["PrecioUnitario"].Value.ToString();
            cbEstadoProducto.SelectedItem = fila.Cells["EstadoProducto"].Value.ToString();
            cbMarca.SelectedValue = Convert.ToInt32(fila.Cells["IdMarca"].Value);
            cbCategoria.SelectedValue = Convert.ToInt32(fila.Cells["IdCategoria"].Value);
        }

<<<<<<< HEAD
        private void cbMarca_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarMarcas();
        }
=======
        private void cbEstadoProducto_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDescripcion_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPrecioUnitario_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbMarca_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

       

        

       

      

        private void txtIdProducto_TextChanged(object sender, EventArgs e)
        {

        }

       
>>>>>>> 8fab699fa5c3adbb4463fca748e4e82fe2d2b6cb
    }
}