using System;
using System.Data;
using System.Windows.Forms;
using PROSERA.Entidades;
using PROSERA.Negocios;
using PROSERA.Datos;

namespace PROSERA.WinFormsUI.UsersControl
{
    public partial class UserControlEmpleados : UserControl
    {
        private readonly IEmpleadoBL _empleadoBL;
        private int? _idEmpleadoActual = null;

        public UserControlEmpleados()
        {
            InitializeComponent();
            _empleadoBL = new EmpleadoBL(new EmpleadoDAL());
            this.Load += UserControlEmpleados_Load;
        }

        private void UserControlEmpleados_Load(object sender, EventArgs e)
        {
            ConfigurarDataGridView();
            CargarListado();
        }

        private void ConfigurarDataGridView()
        {
            dgvEmpleados.AutoGenerateColumns = true;
            dgvEmpleados.SelectionChanged += dgvEmpleados_SelectionChanged;
            dgvEmpleados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void CargarListado()
        {
            try
            {
                DataTable dt = _empleadoBL.Listar();
                dgvEmpleados.DataSource = dt;

                if (dgvEmpleados.Columns["id_empleado"] != null)
                    dgvEmpleados.Columns["id_empleado"].Visible = false;

                dgvEmpleados.ClearSelection();
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar empleados: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvEmpleados_SelectionChanged(object? sender, EventArgs e)
        {
            if (dgvEmpleados.CurrentRow == null || dgvEmpleados.SelectedRows.Count == 0)
            {
                LimpiarCampos();
                return;
            }

            DataGridViewRow row = dgvEmpleados.SelectedRows[0];
            _idEmpleadoActual = Convert.ToInt32(row.Cells["id_empleado"].Value);
            txtNombre.Text = row.Cells["nombre"].Value?.ToString() ?? "";
            txtApeliido.Text = row.Cells["apellido"].Value?.ToString() ?? "";
            txtCargo.Text = row.Cells["cargo"].Value?.ToString() ?? "";
            txtTelefono.Text = row.Cells["telefono"].Value?.ToString() ?? "";
            txtCorreo.Text = row.Cells["correo"].Value?.ToString() ?? "";
            txtDireccion.Text = row.Cells["direccion"].Value?.ToString() ?? "";
            txtDUI.Text = row.Cells["dui"].Value?.ToString() ?? "";
        }

        private void LimpiarCampos()
        {
            _idEmpleadoActual = null;
            txtNombre.Clear();
            txtApeliido.Clear();
            txtCargo.Clear();
            txtTelefono.Clear();
            txtCorreo.Clear();
            txtDireccion.Clear();
            txtDUI.Clear();
        }

        private Empleado ObtenerEmpleadoDesdeFormulario()
        {
            Empleado empleado = new Empleado
            {
                Nombre = txtNombre.Text.Trim(),
                Apellido = txtApeliido.Text.Trim(),
                Cargo = txtCargo.Text.Trim(),
                Telefono = txtTelefono.Text.Trim(),
                Correo = txtCorreo.Text.Trim(),
                Direccion = txtDireccion.Text.Trim(),
                Dui = txtDUI.Text.Trim()
            };

            if (_idEmpleadoActual.HasValue)
                empleado.IdEmpleado = _idEmpleadoActual.Value;

            return empleado;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (_idEmpleadoActual.HasValue)
                {
                    MessageBox.Show("Para insertar un nuevo empleado, primero limpie la selección.",
                                    "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                Empleado nuevo = ObtenerEmpleadoDesdeFormulario();
                _empleadoBL.Guardar(nuevo);

                MessageBox.Show("Empleado guardado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                if (!_idEmpleadoActual.HasValue)
                {
                    MessageBox.Show("Seleccione un empleado del listado para modificar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                Empleado empleadoEditado = ObtenerEmpleadoDesdeFormulario();
                _empleadoBL.Editar(empleadoEditado);

                MessageBox.Show("Empleado modificado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                if (!_idEmpleadoActual.HasValue)
                {
                    MessageBox.Show("Seleccione un empleado del listado para eliminar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DialogResult result = MessageBox.Show(
                    "¿Está seguro de que desea eliminar este empleado?",
                    "Confirmar eliminación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (result != DialogResult.Yes)
                    return;

                _empleadoBL.Eliminar(_idEmpleadoActual.Value);

                MessageBox.Show("Empleado eliminado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
    }
}