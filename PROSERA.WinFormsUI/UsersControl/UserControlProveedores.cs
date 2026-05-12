using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PROSERA.WinFormsUI.UsersControl
{
    public partial class UserControlProveedores : UserControl
    {
        public UserControlProveedores()
        {
            InitializeComponent();
            dataGridProveedores.Columns.Add("NombreEmpresa", "Nombre Empresa");
            dataGridProveedores.Columns.Add("TelefonoEmpresa", "Telefono Empresa");
            dataGridProveedores.Columns.Add("TelefonoRespaldo", "Telefono Respaldo");
            dataGridProveedores.Columns.Add("Correo", "Correo");
            dataGridProveedores.Columns.Add("Direccion", "Dirección");

        }

        private void txtNombreEmpresa_TextChanged(object sender, EventArgs e)
        {

        }




        private void txtCorreo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDireccion_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            dataGridProveedores.Rows.Add(
       txtNombreEmpresa.Text,
       txtTelefono.Text,
       txtRespaldo.Text,
       txtCorreo.Text,
       txtDireccion.Text);
            // Limpiar los campos después de agregar el proveedor
            txtNombreEmpresa.Clear();
            txtTelefono.Clear();
            txtRespaldo.Clear();
            txtCorreo.Clear();
            txtDireccion.Clear();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            dataGridProveedores.CurrentRow.Cells[0].Value = txtNombreEmpresa.Text;
            dataGridProveedores.CurrentRow.Cells[1].Value = txtTelefono.Text;
            dataGridProveedores.CurrentRow.Cells[2].Value = txtRespaldo.Text;
            dataGridProveedores.CurrentRow.Cells[3].Value = txtCorreo.Text;
            dataGridProveedores.CurrentRow.Cells[4].Value = txtDireccion.Text;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridProveedores.CurrentRow != null)
            {
                dataGridProveedores.Rows.Remove(dataGridProveedores.CurrentRow);
            }
        }

        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            dataGridProveedores.Rows.Add(
           txtNombreEmpresa.Text,
           txtTelefono.Text,
           txtRespaldo.Text,
           txtCorreo.Text,
           txtDireccion.Text);

        }

        private void dataGridProveedores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtNombreEmpresa.Text = dataGridProveedores.CurrentRow.Cells[0].Value.ToString();
            txtTelefono.Text = dataGridProveedores.CurrentRow.Cells[1].Value.ToString();
            txtRespaldo.Text = dataGridProveedores.CurrentRow.Cells[2].Value.ToString();
            txtCorreo.Text = dataGridProveedores.CurrentRow.Cells[3].Value.ToString();
            txtDireccion.Text = dataGridProveedores.CurrentRow.Cells[4].Value.ToString();
        }

        private void btnModificar_Click_1(object sender, EventArgs e)
        {
            dataGridProveedores.CurrentRow.Cells[0].Value = txtNombreEmpresa.Text;
            dataGridProveedores.CurrentRow.Cells[1].Value = txtTelefono.Text;
            dataGridProveedores.CurrentRow.Cells[2].Value = txtRespaldo.Text;
            dataGridProveedores.CurrentRow.Cells[3].Value = txtCorreo.Text;
            dataGridProveedores.CurrentRow.Cells[4].Value = txtDireccion.Text;

        }

        private void txtTelefono_TextChanged_1(object sender, EventArgs e)
        {
            if (!long.TryParse(txtTelefono.Text, out _))
            {
                MessageBox.Show("Solo números");
            }

        }

        private void txtRespaldo_TextChanged(object sender, EventArgs e)
        {
            if (!long.TryParse(txtRespaldo.Text, out _))
            {
                MessageBox.Show("Solo números");
            }
        }

        private void txtCorreo_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            // Limpiar los campos después de agregar el proveedor
            txtNombreEmpresa.Clear();
                        txtTelefono.Clear();
                        txtRespaldo.Clear();
                                    txtCorreo.Clear();
                                                txtDireccion.Clear();

        }
    }
}
