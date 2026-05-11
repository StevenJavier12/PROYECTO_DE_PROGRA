using System;
using System.Data;
using System.Windows.Forms;
using PROSERA.Entidades;
using PROSERA.Negocios;
using PROSERA.Datos;

namespace PROSERA.WinFormsUI.UsersControl
{
    public partial class UserControlDispositivos : UserControl
    {
        private readonly IDispositivoElectronicoBL _dispositivoBL;
        private int? _idDispositivoActual = null;

        public UserControlDispositivos()
        {
            InitializeComponent();
            _dispositivoBL = new DispositivoElectronicoBL(new DispositivoElectronicoDAL());
            this.Load += UserControlDispositivos_Load;
        }

        private void UserControlDispositivos_Load(object sender, EventArgs e)
        {
            ConfigurarDataGridView();
            CargarListado();
        }

        private void ConfigurarDataGridView()
        {
            dgvDispositivos.AutoGenerateColumns = true;
            dgvDispositivos.SelectionChanged += dgvDispositivos_SelectionChanged;
            dgvDispositivos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void CargarListado()
        {
            try
            {
                var lista = _dispositivoBL.Listar();
                dgvDispositivos.DataSource = lista;

                if (dgvDispositivos.Columns["IdDispositivo"] != null)
                    dgvDispositivos.Columns["IdDispositivo"].Visible = false;

                dgvDispositivos.ClearSelection();
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar dispositivos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvDispositivos_SelectionChanged(object? sender, EventArgs e)
        {
            if (dgvDispositivos.CurrentRow == null || dgvDispositivos.SelectedRows.Count == 0)
            {
                LimpiarCampos();
                return;
            }

            DataGridViewRow row = dgvDispositivos.SelectedRows[0];
            _idDispositivoActual = Convert.ToInt32(row.Cells["IdDispositivo"].Value);
            txtDispositivo.Text = row.Cells["Tipo"].Value?.ToString() ?? "";
            txtMarca.Text = row.Cells["Marca"].Value?.ToString() ?? "";
            txtModelo.Text = row.Cells["Modelo"].Value?.ToString() ?? "";
            txtEstado.Text = row.Cells["Estado"].Value?.ToString() ?? "";
            txtDui.Text = row.Cells["UnidadDeMedida"].Value?.ToString() ?? "";
            txtDescripcion.Text = row.Cells["Descripcion"].Value?.ToString() ?? "";
        }

        private void LimpiarCampos()
        {
            _idDispositivoActual = null;
            txtDispositivo.Clear();
            txtMarca.Clear();
            txtModelo.Clear();
            txtEstado.Clear();
            txtDui.Clear();
            txtDescripcion.Clear();
        }

        private DispositivoElectronico ObtenerDispositivoDesdeFormulario()
        {
            DispositivoElectronico dispositivo = new DispositivoElectronico
            {
                Tipo = txtDispositivo.Text.Trim(),
                Marca = txtMarca.Text.Trim(),
                Modelo = txtModelo.Text.Trim(),
                Estado = txtEstado.Text.Trim(),
                UnidadDeMedida = string.IsNullOrWhiteSpace(txtDui.Text) ? 0 : Convert.ToInt32(txtDui.Text.Trim()),
                Descripcion = txtDescripcion.Text.Trim()
            };

            if (_idDispositivoActual.HasValue)
                dispositivo.IdDispositivo = _idDispositivoActual.Value;

            return dispositivo;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (_idDispositivoActual.HasValue)
                {
                    MessageBox.Show("Para insertar un nuevo dispositivo, primero limpie la selección.",
                                    "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                DispositivoElectronico nuevo = ObtenerDispositivoDesdeFormulario();
                _dispositivoBL.Agregar(nuevo);

                MessageBox.Show("Dispositivo guardado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                if (!_idDispositivoActual.HasValue)
                {
                    MessageBox.Show("Seleccione un dispositivo del listado para modificar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DispositivoElectronico dispositivoEditado = ObtenerDispositivoDesdeFormulario();
                _dispositivoBL.Editar(dispositivoEditado);

                MessageBox.Show("Dispositivo modificado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                if (!_idDispositivoActual.HasValue)
                {
                    MessageBox.Show("Seleccione un dispositivo del listado para eliminar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DialogResult result = MessageBox.Show(
                    "¿Está seguro de que desea eliminar este dispositivo?",
                    "Confirmar eliminación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (result != DialogResult.Yes)
                    return;

                _dispositivoBL.Eliminar(_idDispositivoActual.Value);

                MessageBox.Show("Dispositivo eliminado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
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