using PROSERA.Datos;
using PROSERA.Entidades;
using PROSERA.Negocios;
using System;
using System.Data;
using System.Windows.Forms;

namespace PROSERA.WinFormsUI.UsersControl
{
    public partial class UserControlRecepcion : UserControl
    {
        private readonly RecepcionDispositivoBL _recepcionBL;
        private readonly DetalleRecepcionBL _detalleBL;
        private readonly ClienteBL _clienteBL;
        private readonly UsuarioBL _usuarioBL;
        private readonly DispositivoElectronicoBL _dispositivoBL;

        public UserControlRecepcion()
        {
            InitializeComponent();

            _recepcionBL = new RecepcionDispositivoBL(new RecepcionDispositivoDAL());
            _detalleBL = new DetalleRecepcionBL(new DetalleRecepcionDAL());
            _clienteBL = new ClienteBL(new ClienteDAL());
            _usuarioBL = new UsuarioBL(new UsuarioDAL());
            _dispositivoBL = new DispositivoElectronicoBL(new DispositivoElectronicoDAL());
        }

        private void UserControlRecepcion_Load(object sender, EventArgs e)
        {
            if (DesignMode) return;


            CargarClientes();
            CargarUsuarios();
            CargarDispositivos();
            CargarGrid();

            txtIdRecepcion.Visible = false;
            txtIdDetalle.Visible = false;
        }

        private void CargarClientes()
        {
            DataTable tabla = _clienteBL.Listar();
            cbCliente.DataSource = tabla;
            cbCliente.DisplayMember = "Nombre";
            cbCliente.ValueMember = "IdCliente";
            cbCliente.SelectedIndex = -1;
        }

        private void CargarUsuarios()
        {
            DataTable tabla = _usuarioBL.Listar();
            cbUsuario.DataSource = tabla;
            cbUsuario.DisplayMember = "Username";
            cbUsuario.ValueMember = "IdUsuario";
            cbUsuario.SelectedIndex = -1;
        }

        private void CargarDispositivos()
        {
            List<DispositivoElectronico> dispositivos = _dispositivoBL.Listar();
            cbDispositivo.DataSource = dispositivos;
            cbDispositivo.DisplayMember = "Modelo";
            cbDispositivo.ValueMember = "IdDispositivo";
            cbDispositivo.SelectedIndex = -1;
        }

        private void CargarGrid()
        {
            dgvRecepcion.DataSource = _recepcionBL.Listar();
        }

        private void CargarDetalles(int idRecepcion)
        {
            DataTable todos = _detalleBL.Listar();
            DataView vista = new DataView(todos);
            vista.RowFilter = $"IdRecepcion = {idRecepcion}";
            dgvDetalle.DataSource = vista.ToTable();
        }

        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (cbCliente.SelectedValue == null || cbUsuario.SelectedValue == null)
                {
                    MessageBox.Show("Seleccione cliente y usuario.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                RecepcionDispositivo recepcion = new RecepcionDispositivo
                {
                    Fecha = dtimeFecha.Value,
                    IdCliente = (int)cbCliente.SelectedValue,
                    IdUsuario = (int)cbUsuario.SelectedValue,
                    Observaciones = txtObservaciones.Text.Trim()
                };

                _recepcionBL.Guardar(recepcion);
                MessageBox.Show("Recepción guardada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                if (string.IsNullOrWhiteSpace(txtIdRecepcion.Text))
                {
                    MessageBox.Show("Seleccione una recepción del grid para editar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                RecepcionDispositivo recepcion = new RecepcionDispositivo
                {
                    IdRecepcion = int.Parse(txtIdRecepcion.Text),
                    Fecha = dtimeFecha.Value,
                    IdCliente = (int)cbCliente.SelectedValue,
                    IdUsuario = (int)cbUsuario.SelectedValue,
                    Observaciones = txtObservaciones.Text.Trim()
                };

                _recepcionBL.Editar(recepcion);
                MessageBox.Show("Recepción actualizada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                if (string.IsNullOrWhiteSpace(txtIdRecepcion.Text))
                {
                    MessageBox.Show("Seleccione una recepción del grid para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DialogResult respuesta = MessageBox.Show("¿Está seguro de eliminar esta recepción?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (respuesta == DialogResult.Yes)
                {
                    _recepcionBL.Eliminar(int.Parse(txtIdRecepcion.Text));
                    MessageBox.Show("Recepción eliminada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            txtIdRecepcion.Text = string.Empty;
            txtIdDetalle.Text = string.Empty;
            dtimeFecha.Value = DateTime.Now;
            cbCliente.SelectedIndex = -1;
            cbUsuario.SelectedIndex = -1;
            txtObservaciones.Text = string.Empty;
            cbDispositivo.SelectedIndex = -1;
            txtCantidad.Text = string.Empty;
            dgvDetalle.DataSource = null;
        }

        private void dgvRecepcion_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow fila = dgvRecepcion.Rows[e.RowIndex];

            txtIdRecepcion.Text = fila.Cells["IdRecepcion"].Value.ToString();
            dtimeFecha.Value = Convert.ToDateTime(fila.Cells["Fecha"].Value);
            txtObservaciones.Text = fila.Cells["Observaciones"].Value.ToString();
            cbCliente.SelectedValue = Convert.ToInt32(fila.Cells["IdCliente"].Value);
            cbUsuario.SelectedValue = Convert.ToInt32(fila.Cells["IdUsuario"].Value);

            CargarDetalles(int.Parse(txtIdRecepcion.Text));
        }

        private void dgvDetalle_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow fila = dgvDetalle.Rows[e.RowIndex];

            txtIdDetalle.Text = fila.Cells["IdDetalle"].Value.ToString();
            txtCantidad.Text = fila.Cells["Cantidad"].Value.ToString();
            cbDispositivo.SelectedValue = Convert.ToInt32(fila.Cells["IdDispositivo"].Value);
        }

       
        

        private void cbDispositivo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtCantidad_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtIdDetalle_TextChanged(object sender, EventArgs e)
        {

        }

        private void dtimeFecha_ValueChanged(object sender, EventArgs e)
        {

        }

        private void cbCliente_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbUsuario_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtObservaciones_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtIdRecepcion_TextChanged(object sender, EventArgs e)
        {

        }

       
    }
}

