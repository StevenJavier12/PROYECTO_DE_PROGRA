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

        private void TxbNombreEmpresa_TextChanged(object sender, EventArgs e)
        {


        }

        private void TxbTelefonoEmpresa_TextChanged(object sender, EventArgs e)
        {
            if (!long.TryParse(TxbTelefonoEmpresa.Text, out _))
            {
                MessageBox.Show("Solo números");
            }
        }

        private void TxbTelefonoRespaldo_TextChanged(object sender, EventArgs e)
        {
            if (!long.TryParse(TxbTelefonoRespaldo.Text, out _))
            {
                MessageBox.Show("Solo números");
            }
        }

        private void TxbCorreo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txbDireccion_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {

            dataGridProveedores.Rows.Add(
            TxbNombreEmpresa.Text,
            TxbTelefonoEmpresa.Text,
            TxbTelefonoRespaldo.Text,
            TxbCorreo.Text,
            txbDireccion.Text
            );



        }



        private void btnModificar_Click(object sender, EventArgs e)
        {
            dataGridProveedores.CurrentRow.Cells[0].Value = TxbNombreEmpresa.Text;
            dataGridProveedores.CurrentRow.Cells[1].Value = TxbTelefonoEmpresa.Text;
            dataGridProveedores.CurrentRow.Cells[2].Value = TxbTelefonoRespaldo.Text;
            dataGridProveedores.CurrentRow.Cells[3].Value = TxbCorreo.Text;
            dataGridProveedores.CurrentRow.Cells[4].Value = txbDireccion.Text;

        }

        private void dataGridProveedores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            TxbNombreEmpresa.Text = dataGridProveedores.CurrentRow.Cells[0].Value.ToString();
            TxbTelefonoEmpresa.Text = dataGridProveedores.CurrentRow.Cells[1].Value.ToString();
            TxbTelefonoRespaldo.Text = dataGridProveedores.CurrentRow.Cells[2].Value.ToString();
            TxbCorreo.Text = dataGridProveedores.CurrentRow.Cells[3].Value.ToString();
            txbDireccion.Text = dataGridProveedores.CurrentRow.Cells[4].Value.ToString();

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
                        if (dataGridProveedores.CurrentRow != null)
            {
                dataGridProveedores.Rows.Remove(dataGridProveedores.CurrentRow);
            }
        }
    }
}
