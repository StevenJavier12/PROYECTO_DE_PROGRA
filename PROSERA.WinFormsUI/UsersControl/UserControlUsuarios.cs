using PROSERA.Datos;
using PROSERA.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PROSERA.WinFormsUI.UsersControl
{
    public partial class UserControlUsuarios : UserControl
    {
        private readonly UsuarioDAL _usuarioDAL = new UsuarioDAL();
        public UserControlUsuarios()
        {
            InitializeComponent();

            CargarUsuarios();
            CargarRoles();
            CargarEstados();



        }

        private void CargarUsuarios()
        {
            dataGridUsuario.DataSource = _usuarioDAL.ListarConEmpleado();


        }

        private void CargarRoles()
        {
            cbxRolUsuario.Items.AddRange(new string[] { "Admin", "Empleado" });
        }

        private void CargarEstados()
        {
            cbxEstadoUsuario.Items.AddRange(new string[] { "Activo", "Inactivo" });
        }


        private void txtNombreUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtContraseña_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbxRolUsuario_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbxEstadoUsuario_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnGuardarUser_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario()
            {
                Username = txtNombreUsuario.Text,
                Contraseña = txtContraseña.Text,
                Rol = cbxRolUsuario.SelectedItem.ToString(),
                EstadoUser = cbxEstadoUsuario.SelectedItem.ToString()
            };

            _usuarioDAL.Guardar(usuario);
            CargarUsuarios();
            LimpiarCampos();


        }

        private void btnModificarUser_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario()
            {
                IdUsuario = Convert.ToInt32(dataGridUsuario.SelectedRows[0].Cells["id_usuario"].Value),
                Username = txtNombreUsuario.Text,
                Contraseña = txtContraseña.Text,
                Rol = cbxRolUsuario.SelectedItem.ToString(),
                EstadoUser = cbxEstadoUsuario.SelectedItem.ToString()
            };

            _usuarioDAL.Editar(usuario);
            CargarUsuarios();
            LimpiarCampos();
        }

        private void dataGridUsuario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dataGridUsuario.Rows[e.RowIndex];
                txtNombreUsuario.Text = fila.Cells["username"].Value.ToString();
                txtContraseña.Text = fila.Cells["contraseña"].Value.ToString();
                cbxRolUsuario.SelectedItem = fila.Cells["rol"].Value.ToString();
                cbxEstadoUsuario.SelectedItem = fila.Cells["estadoUser"].Value.ToString();
            }

        }

        private void btnEliminarUser_Click(object sender, EventArgs e)
        {
            int idUsuario = Convert.ToInt32(dataGridUsuario.SelectedRows[0].Cells["id_usuario"].Value);
            _usuarioDAL.Eliminar(idUsuario);
            CargarUsuarios();
            LimpiarCampos();
        }

        private void btnLimpiarUser_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }
        private void LimpiarCampos()
        {
            txtNombreUsuario.Clear();
            txtContraseña.Clear();
            cbxRolUsuario.SelectedIndex = -1;
            cbxEstadoUsuario.SelectedIndex = -1;
        }
    }

}
