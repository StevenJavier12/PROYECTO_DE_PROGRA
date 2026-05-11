using System;
using System.Data;
using System.Windows.Forms;
using PROSERA.Entidades;
using PROSERA.Negocios;
using PROSERA.Datos;

namespace PROSERA.WinFormsUI.UsersControl
{
    public partial class UserControlClientes : UserControl
    {
        // Instancia de la capa de negocio (inyectada manualmente por simplicidad)
        private readonly IClienteBL _clienteBL;

        // Almacena el ID del cliente actualmente seleccionado para editar/eliminar
        private int? _idClienteActual = null;

        public UserControlClientes()
        {
            InitializeComponent();

            // Instanciamos las dependencias. En una aplicación real se usaría inyección de dependencias.
            _clienteBL = new ClienteBL(new ClienteDAL());
        }

        private void UserControlClientes_Load(object sender, EventArgs e)
        {
            // Configurar apariencia y eventos del DataGridView
            ConfigurarDataGridView();
            // Cargar todos los clientes en el grid
            CargarListado();
        }

        /// <summary>
        /// Configura las columnas y eventos del DataGridView.
        /// </summary>
        private void ConfigurarDataGridView()
        {
            // Permitir auto-generación de columnas según la tabla devuelta por Listar()
            dgvClientes.AutoGenerateColumns = true;

            // Asignar el evento de selección para cargar datos del cliente en los TextBox
            dgvClientes.SelectionChanged += dgvClientes_SelectionChanged; 
            dgvClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        /// <summary>
        /// Obtiene la lista de clientes desde la capa de negocio y la muestra en el DataGridView.
        /// </summary>
        private void CargarListado()
        {
            try
            {
                DataTable dt = _clienteBL.Listar();
                dgvClientes.DataSource = dt;

                // Ocultar la columna del ID para que no se muestre (opcional pero recomendable)
                if (dgvClientes.Columns["id_cliente"] != null)
                    dgvClientes.Columns["id_cliente"].Visible = false;

                // Limpiar selección y campos después de recargar
                dgvClientes.ClearSelection();
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar clientes: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Evento que se dispara al cambiar la fila seleccionada en el DataGridView.
        /// Si hay una fila seleccionada, carga los datos en los TextBox.
        /// Si se deselecciona, limpia los campos y resetea el ID.
        /// </summary>
        private void dgvClientes_SelectionChanged(object? sender, EventArgs e)
        {
            if (dgvClientes.CurrentRow == null || dgvClientes.SelectedRows.Count == 0)
            {
                LimpiarCampos();
                return;
            }

            DataGridViewRow row = dgvClientes.SelectedRows[0];
            // Obtener valores de la fila. El DataTable tiene exactamente esos nombres.
            _idClienteActual = Convert.ToInt32(row.Cells["id_cliente"].Value);            

            txtNombre.Text = row.Cells["nombre"].Value?.ToString() ?? "";
            txtApeliido.Text = row.Cells["apellido"].Value?.ToString() ?? "";
            txtTelefono.Text = row.Cells["telefono"].Value?.ToString() ?? "";
            txtDireccion.Text = row.Cells["direccion"].Value?.ToString() ?? "";
            txtDui.Text = row.Cells["dui"].Value?.ToString() ?? "";
            txtCorreo.Text = row.Cells["correo"].Value?.ToString() ?? "";
        }

        /// <summary>
        /// Limpia todos los campos de texto y resetea el ID interno.
        /// </summary>
        private void LimpiarCampos()
        {
            _idClienteActual = null;
            txtNombre.Clear();
            txtApeliido.Clear();
            txtTelefono.Clear();
            txtDireccion.Clear();
            txtDui.Clear();
            txtCorreo.Clear();
        }

        /// <summary>
        /// Construye un objeto Cliente a partir de los datos actualmente en los TextBox.
        /// Si estamos editando, se asigna también el ID.
        /// </summary>
        private Cliente ObtenerClienteDesdeFormulario()
        {
            Cliente cliente = new Cliente
            {
                Nombre = txtNombre.Text.Trim(),
                Apellido = txtApeliido.Text.Trim(),
                Telefono = txtTelefono.Text.Trim(),
                Direccion = txtDireccion.Text.Trim(),
                Dui = txtDui.Text.Trim(),
                Correo = string.IsNullOrWhiteSpace(txtCorreo.Text) ? null : txtCorreo.Text.Trim()
            };

            if (_idClienteActual.HasValue)
                cliente.IdCliente = _idClienteActual.Value;

            return cliente;
        }

        // ──────────────────────────────────────────────
        //  Manejadores de botones
        // ──────────────────────────────────────────────

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                // Validación extra: asegurarse de que no se intente guardar cuando ya hay un ID seleccionado
                if (_idClienteActual.HasValue)
                {
                    MessageBox.Show("Para insertar un nuevo cliente, primero limpie la selección.\n" +
                                    "Puede hacer clic en una zona vacía del grid o usar el botón 'Nuevo' si estuviera disponible.",
                                    "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                Cliente nuevo = ObtenerClienteDesdeFormulario();
                _clienteBL.Guardar(nuevo);

                MessageBox.Show("Cliente guardado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                if (!_idClienteActual.HasValue)
                {
                    MessageBox.Show("Seleccione un cliente del listado para modificar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                Cliente clienteEditado = ObtenerClienteDesdeFormulario();
                _clienteBL.Editar(clienteEditado);

                MessageBox.Show("Cliente modificado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                if (!_idClienteActual.HasValue)
                {
                    MessageBox.Show("Seleccione un cliente del listado para eliminar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DialogResult result = MessageBox.Show(
                    "¿Está seguro de que desea eliminar este cliente?",
                    "Confirmar eliminación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (result != DialogResult.Yes)
                    return;

                _clienteBL.Eliminar(_idClienteActual.Value);

                MessageBox.Show("Cliente eliminado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarListado();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al eliminar: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            // Aquí depende de la navegación de tu sistema.
            // Opción 1: Ocultar este UserControl (si se maneja con paneles)
            this.Visible = false;
            // Opción 2: Disparar un evento para que el formulario principal lo maneje.
            // Opción 3: Cerrar el formulario contenedor si el UserControl está en un form aparte.
        }

        // ──────────────────────────────────────────────
        //  Eventos vacíos generados por el diseñador (los conservamos para evitar errores)
        // ──────────────────────────────────────────────
        private void txtTelefono_TextChanged(object sender, EventArgs e) { }
        private void txtNombre_TextChanged(object sender, EventArgs e) { }
        private void label2_Click(object sender, EventArgs e) { }
        private void label4_Click(object sender, EventArgs e) { }
        private void txtApeliido_TextChanged(object sender, EventArgs e) { }
        private void label3_Click(object sender, EventArgs e) { }
    }
}