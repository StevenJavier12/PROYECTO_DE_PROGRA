using PROSERA.Datos;
using PROSERA.Negocios;
using PROSERA.WinFormsUI.UsersControl;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PROSERA.WinFormsUI
{
    public partial class ControlAdmin : Form
    {
        public ControlAdmin()
        {
            InitializeComponent();
        }

        public void addUserControl(UserControl userControl)
        {
            panelContainer.Controls.Clear();
            userControl.Dock = DockStyle.None;
            userControl.Location = new Point(0, 0);
            panelContainer.AutoScroll = true;
            panelContainer.Controls.Add(userControl);
            userControl.BringToFront();
        }
        private void button6_Click(object sender, EventArgs e)
        {
            UserControlVentas uc = new UserControlVentas(new DetalleVentaBL(new DetalleVentaDAL()));
            addUserControl(uc);
        }

        private void btnClientesA_Click(object sender, EventArgs e)
        {
            UserControlClientes uc = new UserControlClientes();
            addUserControl(uc);
        }

        private void btnComprasA_Click(object sender, EventArgs e)
        {
            UserControlCompras uc = new UserControlCompras();
            addUserControl(uc);
        }

        private void btnProvedoresA_Click(object sender, EventArgs e)
        {
            UserControlProveedores uc = new UserControlProveedores();
            addUserControl(uc);
        }

        private void btnProductosA_Click(object sender, EventArgs e)
        {
            UserControlProducto uc = new UserControlProducto();
            addUserControl(uc);
        }

        private void btnCategoriasA_Click(object sender, EventArgs e)
        {
            UserControlCategoria uc = new UserControlCategoria();
            addUserControl(uc);
        }

        private void btnInventarioA_Click(object sender, EventArgs e)
        {
            UserControlInventario uc = new UserControlInventario();
            addUserControl(uc);
        }

        private void btnRecepcionesA_Click(object sender, EventArgs e)
        {
            UserControlRecepcion uc = new UserControlRecepcion();
            addUserControl(uc);
        }

        private void btnDispositivosA_Click(object sender, EventArgs e)
        {
            UserControlDispositivos uc = new UserControlDispositivos();
            addUserControl(uc);
        }

        private void btnEmpleadosA_Click(object sender, EventArgs e)
        {
            UserControlEmpleados uc = new UserControlEmpleados();
            addUserControl(uc);
        }

        private void btnUsuariosA_Click(object sender, EventArgs e)
        {
            UserControlUsuarios uc = new UserControlUsuarios();
            addUserControl(uc);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
